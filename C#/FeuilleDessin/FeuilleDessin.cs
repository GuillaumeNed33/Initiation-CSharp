using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;
using System.Reflection;

namespace FeuilleDessin
{
    public partial class FeuilleDessin : Form
    {
        List<Noeud> noeuds = new List<Noeud>();
        List<Trait> traits = new List<Trait>();

        bool enDessinTrait = false;
        bool enMouvement = false;
        bool TraitOK = true;
                
        private Point PointCourant;
        private Point PointCentre;
        Noeud selection = null;
        Point origine = new Point(0, 0);

        Trait trait_tmp;
        Noeud noeud_tmp;

        int epaisseurParDefaut = 2;
        Color couleurParDefaut = Color.Black;

        int epaisseurTrait = 2;
        Color couleurTrait = Color.Black;

        int i = 1;
        int id = 1;

        Stack<Action> actions = new Stack<Action>();
        Stack<Action> actions_retablir = new Stack<Action>();

        PrintDocument Impression = new PrintDocument();
        PrinterSettings printer;

       
        float zoom = 1f;

        public FeuilleDessin()
        {
            InitializeComponent();
        }

        private void FeuilleDessin_Paint(object sender, PaintEventArgs e)
        {
            foreach (Noeud n in noeuds)
                if (!n.Supprimé)
                    n.Dessine(origine, e.Graphics, zoom);
            
            foreach (Trait t in traits)
                if (!t.Supprimé)
                    t.Dessine(origine, e.Graphics, zoom);

            if (selection != null)
            {
                selection.AfficheSelect(e.Graphics, origine, zoom);
            }

            if (enDessinTrait)
            {
                noeud_tmp.Dessine(origine,e.Graphics, zoom);
                trait_tmp.Dessine(origine, e.Graphics, zoom);
            }
        }

        private Noeud Sélection(Point p)
        {
            return noeuds.FirstOrDefault(c => c.Contient(p));
        }

        private void Element_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            switch (tm.Text)
            {
                case "Modifier":
                    ParametresNoeud param = new ParametresNoeud(selection.Couleur, selection.Epaisseur, selection.Texte);
                    if (param.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        selection.Epaisseur = param.Epaisseur;
                        selection.Couleur = param.Couleur;
                        selection.Texte = param.LeTexte;
                    }
       
                    Refresh();
                    break;

                case  "DialogueGenerique":
                    GeneriqueBox generique = new GeneriqueBox(selection);
                    if (generique.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        selection = null;
                        Refresh();
                    }
                    break;

                case "Supprimer":
                    List<Trait> trait_suppr = new List<Trait>(traits);
                    foreach (Trait t in trait_suppr)
                    {
                        if (t.Source == selection || t.Destination == selection)
                        {
                            traits.Remove(t);
                        }
                    }
                    noeuds.Remove(selection);
                    selection = null;
                    Refresh();
                    break;
            }
        }

        private void FeuilleDessin_MouseDown(object sender, MouseEventArgs e)
        {
            selection = Sélection(PointCentre);

            if (déplacement.Checked)
            {
                enMouvement = selection != null;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (selection == null)
                    {
                        Noeud nouveau = new Noeud(id, PointCentre, new Size(10, 10), epaisseurParDefaut, couleurParDefaut, i.ToString());
                        noeuds.Add(nouveau);
                        Action action = new Action(Type_Action.Créer, new List<ISupprimable>() { nouveau });
                        actions.Push(action);
                        i++;
                        id++;
                    }

                    else
                    {
                        enDessinTrait = true;
                        noeud_tmp = new Noeud(id,PointCentre, new Size(10, 10), epaisseurParDefaut, Color.Red, i.ToString());
                        trait_tmp = new Trait(selection, noeud_tmp, epaisseurTrait, Color.Red);
                    }
                }
                else
                {
                    if (selection != null)
                    {
                        ContextMenuStrip cm = new ContextMenuStrip();
                        foreach (string libel in new string[] { "Supprimer", "Modifier", "DialogueGenerique" })
                        {
                            ToolStripMenuItem élément = new ToolStripMenuItem(libel);
                            élément.Click += Element_Click;
                            cm.Items.Add(élément);
                        }
                        cm.Show(this, e.Location);
                        Refresh();
                    }
                    /*else
                    {
                        FeuilleDessin feuille = new FeuilleDessin();
                        GeneriqueBox generique = new GeneriqueBox(feuille);
                        if (generique.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            foreach (Control c in Controls)
                            {
                                selection.Epaisseur= generique.;
                                selection.Couleur;
                                selection.Texte;
                                selection.Position;
                                selection.Taille;
                                if (c.Tag != null)
                                {
                                    PropertyInfo p = (PropertyInfo)c.Tag;
                                    p.SetValue(selection, c.Text);
                                }
                            }
                        }
                        Refresh();
                    }*/
                }
            }
            Refresh();
        }

        private void FeuilleDessin_MouseMove(object sender, MouseEventArgs e)
        {
            PointCourant = e.Location;
            PointCentre = new Point((int)(PointCourant.X/zoom) - (int)(origine.X/zoom), (int)(PointCourant.Y/zoom) - (int)(origine.Y/zoom));


            if (enMouvement)
            {
                selection.Deplace(PointCentre);
                Refresh();
            }
            if (enDessinTrait)
            {
                noeud_tmp.Deplace(PointCentre);
                Refresh();
            }
        }

        private void FeuilleDessin_MouseUp(object sender, MouseEventArgs e)
        {
            if (déplacement.Checked)
            {
                enMouvement = false;
                
                                
            }
            if (enDessinTrait)
            {
                Noeud fin = Sélection(e.Location);

                if (fin == null)
                {
                    fin = new Noeud(id, PointCentre, new Size(10, 10), epaisseurParDefaut, couleurParDefaut, i.ToString());
                    i++;
                    id++;
                    noeuds.Add(fin);
                    Action action = new Action(Type_Action.Créer, new List<ISupprimable>() { fin });
                    actions.Push(action);
                }

                TraitOK = fin !=selection;

                foreach(Trait t in traits)
                {
                    if ((t.Source == selection && t.Destination == fin) || (t.Source == fin && t.Destination == selection))
                        TraitOK = false;
                }

                if (TraitOK)
                {
                    Trait tr = new Trait(selection, fin, epaisseurTrait, couleurTrait);
                    traits.Add(tr);
                    Action action = new Action(Type_Action.Créer, new List<ISupprimable>() { tr });
                    actions.Push(action);
                    selection = null;
                    TraitOK = false;
                }
                Refresh();

                enDessinTrait = false;
            }
            Refresh();
        }

        private void reinitialise_Click(object sender, EventArgs e)
        {
            List<Trait> supprTrait = new List<Trait>(traits);
            List<Noeud> supprNoeuds = new List<Noeud>(noeuds);

            foreach (Trait t in supprTrait)
            {
                traits.Remove(t);
            }
            foreach (Noeud n in supprNoeuds)
            {
                noeuds.Remove(n);
            }
            i = 1;
            id = 1;
            selection = null;            

            Refresh();
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            epaisseurParDefaut--;
        }

        private void agrandir_Click(object sender, EventArgs e)
        {
            epaisseurParDefaut++;
        }

        private void couleur_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog { Color = couleurParDefaut };
            if (col.ShowDialog() == DialogResult.OK)
            {
                couleurParDefaut = col.Color;
            }
        }

        private void reduct_trait_Click(object sender, EventArgs e)
        {
            epaisseurTrait--;
        }

        private void agrandirTrait_Click(object sender, EventArgs e)
        {
            epaisseurTrait++;
        }

        private void coulTrait_Click(object sender, EventArgs e)
        {
            ColorDialog coltrait = new ColorDialog { Color = couleurTrait };
            if (coltrait.ShowDialog() == DialogResult.OK)
            {
                couleurTrait = coltrait.Color;
            }
        }
        
        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog
            {
                //Filter = "Fichier .des | *.des",
                //Filter = "Fichier csv | *.csv",
                Filter = "Fichier xml | *.xml",

                InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svd.FileName);
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?> ");
                sw.WriteLine("<DESSIN>");
                noeuds.ForEach(c => c.SauveXML(sw));
                traits.ForEach(c => c.SauveXML(sw));
                sw.WriteLine("</DESSIN>");
                sw.Close();

                /*StreamWriter sw2 = new StreamWriter(svd.FileName);
                noeuds.ForEach(c => c.SauveCSV(sw2));
                traits.ForEach(c => c.SauveCSV(sw2));
                sw2.Close();*/

                /*Stream stream = File.Open(svd.FileName, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, noeuds);
                bformatter.Serialize(stream, traits);
                stream.Close();*/
            }
        }

        private void ouvrirToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog
            {
                //Filter = "Fichier csv | *.csv",
                //Filter = "Fichier .des | *.des",
                Filter = "Fichier xml | *.xml",

                Title = "Choisir le fichier",
                InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            if (opfd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(opfd.FileName);
                reinitialise_Click(sender, e);
                foreach (XmlNode xN in doc.ChildNodes)
                {
                    if (xN.Name == "DESSIN")
                    {
                        foreach (XmlNode xNN in xN.ChildNodes)
                        {
                            if (xNN.Name == "NOEUDS")
                            {
                                noeuds.Add(new Noeud(xNN));
                            }
                            if (xNN.Name == "TRAIT")
                            {
                                traits.Add(new Trait(xNN, noeuds));
                            }
                        }
                    }
                }
                i = noeuds.Count()+1;
                /*
                Stream stream = File.Open(opfd.FileName, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                noeuds = (List<Noeud>)bformatter.Deserialize(stream);
                traits = (List<Trait>)bformatter.Deserialize(stream);
                stream.Close();*/
            }
        }

        private void annulerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (actions.Count > 0)
            {
                actions_retablir.Push(actions.Peek());
                actions.Pop().Undo();
                selection = null;
                Refresh();
            }
        }

        private void retablir_Click(object sender, EventArgs e)
        {
            if (actions_retablir.Count > 0)
            {
                actions.Push(actions_retablir.Peek());
                actions_retablir.Pop().Redo();
                Refresh();
            }
        }

        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            retablir_Click(sender,e);
        }

        private void annulerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            annulerToolStripMenuItem_Click_1(sender, e);
        }

        private void réinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reinitialise_Click(sender, e);
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enregistrerToolStripButton_Click(sender, e);
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvrirToolStripButton_Click(sender, e);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = e.NewValue;
            origine.Y = -vScrollBar1.Value;
            Refresh();            
        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Value = e.NewValue;
            origine.X = -hScrollBar1.Value;
            Refresh();
        }

        private void imprimer_Click(object sender, EventArgs e)
        {
            ChoixImprimante(); 
        }

        private void Impression_PrintPage(object sender, PrintPageEventArgs e)
        {
            foreach (Noeud n in noeuds)
                if (!n.Supprimé)
                    n.Dessine(origine, e.Graphics, zoom);

            foreach (Trait t in traits)
                if (!t.Supprimé)
                    t.Dessine(origine, e.Graphics, zoom);
        }

        private void ChoixImprimante()
        {
            if(printer == null)
            {
                PrintDialog printDial = new PrintDialog();
                printDial.AllowSelection = false;
                printDial.AllowSomePages = true;
                printDial.AllowPrintToFile = false;
                if(printDial.ShowDialog() == DialogResult.OK)
                {
                    printer = printDial.PrinterSettings;
                    Impression.PrintPage += Impression_PrintPage;
                    Impression.Print();
                }
            }
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimer_Click(sender, e);
        }

        private void apercuAvantImpressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintApercu_Click(sender, e);
        }

        private void PrintApercu_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ptPrev = new PrintPreviewDialog();
            Impression = new PrintDocument();
            Impression.PrintPage += Impression_PrintPage;
            ptPrev.Document = Impression;
            ptPrev.ShowDialog();
        }

        void FeuilleDessin_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                if(e.Delta > 0)
                {
                    zoom *= 1.1f;
                    if(zoom >15f)
                    {
                        zoom = 15f;
                    }
                }
                else
                {
                    zoom *= 0.9f;
                    if(zoom < 0.4f)
                    {
                        zoom = 0.4f;
                    }
                }
            }
            Refresh();
        }

        private void DessinObjets_Keydown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Down:
                    origine.Y += 1;
                    break;
                case Keys.Up:
                    origine.Y -= 1;
                    break;
                case Keys.PageDown:
                    origine.Y += 50;
                    break;
                case Keys.PageUp:
                    origine.Y -= 50;
                    break;
            }
            Refresh();
            //return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
