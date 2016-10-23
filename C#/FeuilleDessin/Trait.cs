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
    class Trait : ISupprimable
    {
        #region Implémentation de l'interface
        public bool Supprimé { get; private set; }
        public void Supprime() { Supprimé = true; }
        public void Restaure() { Supprimé = false; }
        #endregion

        private Noeud source;
        private Noeud destination;
        private Color c;
        private int e;
        public Trait(Noeud sour, Noeud dest, int epaisseur, Color couleur)
        {
            source = sour;
            destination = dest;
            c = couleur;
            e = epaisseur;
        }

        public Noeud Source { get { return source; } }
        public Noeud Destination { get { return destination; } }

        public void Dessine(Point orig, Graphics g, float zoom)
        {
                Pen p = new Pen(c, e);
                g.DrawLine(p, new Point((int)(source.Position.X * zoom)+orig.X, (int)(source.Position.Y*zoom)+orig.Y), new Point((int)(destination.Position.X*zoom)+orig.X, (int)(destination.Position.Y*zoom)+orig.Y));
        }

        public void SauveCSV(StreamWriter sw)
        {
            String text = source.ToString();
            text = destination.ToString();
            text = e.ToString();
            text = c.ToArgb().ToString();
            sw.WriteLine(text);
        }

        public void SauveXML(StreamWriter sw)
        {
            string text = "<TRAIT>";
            text += "   <SOURCE>";
            text += "       " + source.Identifiant.ToString();
            text += "   </SOURCE>";
            text += "   <DESTINATION>";
            text += "       " + destination.Identifiant.ToString();
            text += "   </DESTINATION>";
            text += "   <EPAISSEUR>";
            text += "       " + e.ToString();
            text += "   </EPAISSEUR>";
            text += "   <COULEUR>";
            text += "       " + c.ToArgb().ToString();
            text += "   </COULEUR>";
            text += "</TRAIT>";
            sw.WriteLine(text);
        }

        public Trait(XmlNode xNN, List<Noeud> noeuds)
        {
            foreach (XmlNode xNNN in xNN.ChildNodes)
            {
                switch (xNNN.Name)
                {                       
                    case "SOURCE":
                        int x = int.Parse(xNNN.InnerText);
                        source=noeuds.FirstOrDefault(n => n.Identifiant == x);
                        break;
                    case "COULEUR":
                        int col = int.Parse(xNNN.InnerText);
                        c = Color.FromArgb(col);
                        break;
                    case "EPAISSEUR":
                        int epais = int.Parse(xNNN.InnerText);
                        e = epais;
                        break;

                    case "DESTINATION":
                        int y = int.Parse(xNNN.InnerText);
                        destination=noeuds.FirstOrDefault(n => n.Identifiant == y);            
                        break;
                }
            }
        }
    }
}
