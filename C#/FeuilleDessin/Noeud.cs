using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml;

namespace FeuilleDessin
{
    [Serializable]
    class Noeud : ISupprimable
    {
        #region Implémentation de l'interface
        public bool Supprimé { get; private set; }
        public void Supprime() { Supprimé = true; }
        public void Restaure() { Supprimé = false; }
        #endregion

        public Point Position {get; set;}
        public Size Taille { get; set; }

        public string Texte { get; set; }
        public int Epaisseur { get; set; }
        public Color Couleur { get; set; }
        public int Identifiant;


        public Noeud(int id, Point p, Size s, int epaisseur, Color couleur, string text)
        {
            Position = p;
            Taille = s;
            Couleur=couleur;
            Epaisseur = epaisseur;
            Texte = text;
            Identifiant = id;
        }
        public void Dessine(Point orig, Graphics g, float zoom)
        {
            Rectangle r = new Rectangle(Position, Taille);
            Rectangle rect = new Rectangle((int)(r.X*zoom) + orig.X,
                (int)(r.Y * zoom) + orig.Y,
                (int)(r.Width * zoom),
                (int)(r.Height *zoom));
            Pen p = new Pen(Couleur,Epaisseur);
            g.DrawRectangle(p, rect);
            g.DrawString(Texte, new Font("Comic Sans MS", 12*zoom, FontStyle.Italic), Brushes.Black,
                new Point(rect.Location.X, rect.Location.Y+6));
        }

        public bool Contient(Point p)
        {
            Rectangle r = new Rectangle(Position, Taille);
            return r.Contains(p);
        }
        public void Deplace(Point p)
        {
            Position = p;
        }

        public void AfficheSelect(Graphics g, Point orig, float zoom)
        {
            Rectangle r = new Rectangle(Position, Taille);
            Rectangle rect = new Rectangle((int)(r.X * zoom) + orig.X, (int)(r.Y * zoom) + orig.Y, (int)(r.Width * zoom), (int)(r.Height * zoom));
            g.FillRectangle(Brushes.Blue, rect);
        }

        public void SauveCSV(StreamWriter sw)
        {
            String text = Position.X.ToString() + ";"
                + Position.Y.ToString();
            text = Taille.Width.ToString() + ";"
                + Taille.Height.ToString();
            text = Epaisseur.ToString();
            text = Couleur.ToArgb().ToString();
            sw.WriteLine(text);
        }

        public void SauveXML(StreamWriter sw)
        {
            string text = "<NOEUDS>";
            text += "   <ID>";
            text += "       " + Identifiant.ToString();
            text += "   </ID>";
            text += "   <POSITION>";
            text += "       " + Position.ToString();
            text += "   </POSITION>";
            text += "   <TAILLE>";
            text += "       " + Taille.ToString();
            text += "   </TAILLE>";
            text += "   <EPAISSEUR>";
            text += "       " + Epaisseur.ToString();
            text += "   </EPAISSEUR>";
            text += "   <COULEUR>";
            text += "       " + Couleur.ToArgb().ToString();
            text += "   </COULEUR>";
            text += "   <TEXTE>";
            text += "       " + Texte;
            text += "   </TEXTE>";
            text += "</NOEUDS>";
            sw.WriteLine(text);
        }

        public Noeud(XmlNode xNN)
        {
            foreach (XmlNode xNNN in xNN.ChildNodes)
            {
                switch (xNNN.Name)
                {
                    case "ID":
                        int id = int.Parse(xNNN.InnerText);
                        Identifiant = id;
                        break;
                    case "POSITION":
                        string[] data = xNNN.InnerText.Split(',');
                        int x = int.Parse(data[0].Split('=')[1]);
                        string del = data[1].Split('=')[1];
                        int y = int.Parse(del.Split('}')[0]);
                        Position = new Point(x, y);
                        break;
                    case "COULEUR":
                        int col = int.Parse(xNNN.InnerText);
                        Couleur = Color.FromArgb(col);
                        break;
                    case "EPAISSEUR":
                        int epais = int.Parse(xNNN.InnerText);
                        Epaisseur = epais;
                        break;
                    case "TEXTE":
                        int t = int.Parse(xNNN.InnerText);
                        Texte = t.ToString();
                        break;
                    case "TAILLE":
                        string[] dataSize = xNNN.InnerText.Split(',');
                        int w = int.Parse(dataSize[0].Split('=')[1]);
                        string delimit = dataSize[1].Split('=')[1];
                        int h = int.Parse(delimit.Split('}')[0]);
                        Taille = new Size(w,h);
                        break;
                }
            }
        }        
    }
}
