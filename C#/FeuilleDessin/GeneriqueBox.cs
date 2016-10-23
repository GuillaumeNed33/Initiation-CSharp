using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace FeuilleDessin
{
    public partial class GeneriqueBox : Form
    {
        private Object currentObject;

        public GeneriqueBox(Object obj)
        {
            currentObject = obj;
            int x = 20;
            int y = 0;
            int xMax = x;

            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (PropertyInfo p in properties)
            {
                Label lb = new Label();
                if (p.Name != "Supprimé")
                {
                    lb.Text = p.Name;
                    lb.Location = new Point(x, y);
                    Controls.Add(lb);
                }


                if (p.SetMethod != null)
                {
                    Control tb = new Control();
                    Control tb2 = new Control();

                    switch (p.PropertyType.Name)
                    {
                        case "Int32":
                            tb = new NumericUpDown();
                            tb.Width = 50;
                            ((NumericUpDown)tb).Maximum = 1000;
                            tb.Text = p.GetValue(obj).ToString();
                            break;

                        case "String":
                            tb = new TextBox();
                            tb.Width = 150;
                            if (p.GetValue(obj) != null)
                            {
                                tb.Text = p.GetValue(obj).ToString();
                            }
                            break;

                        case "Color":
                            tb = new Label();
                            tb.Text = "  ";
                            tb.Width = 50;
                            tb.BackColor = (Color)p.GetValue(obj);
                            tb.Click += Couleur_Click;
                            break;

                        case "Point":
                            tb = new Label();
                            tb.Text = "Pas encore implementé";
                            tb.Width = 150;
                            /*tb = new TextBox();
                            tb.Width = 150;
                            if (p.GetValue(obj) != null)
                            {
                                tb.Text = p.GetValue(obj).ToString();
                            }*/
                            break;

                        case "Size":
                            tb = new Label();
                            tb.Text = "Pas encore implementé";
                            tb.Width = 150;
                            /*tb = new TextBox();
                            tb.Width = 150;
                            if (p.GetValue(obj) != null)
                            {
                                tb.Text = p.GetValue(obj).ToString();
                            }*/
                            break;
                    }
                    tb.Location = new Point(x + lb.Width + 5, y);
                    tb.Tag = p;
                    Controls.Add(tb);
                }
                y += 30;
            }

            foreach (string s in new string[] { "OK", "Annuler" })
            {
                Button bouton = new Button();
                bouton.Text = s;
                Controls.Add(bouton);
                bouton.Location = new Point(x, y);
                bouton.Click += OK_button_Click;
                y += bouton.Height + 5;
            }
        }

        private void Couleur_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog { Color = ((Control)sender).BackColor };
            if (col.ShowDialog() == DialogResult.OK)
            {
                ((Control)sender).BackColor = col.Color;
            }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Annuler")
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                return;
            }

            /* Relecture */

            foreach (Control c in Controls)
            {
                if (c.Tag != null)
                {
                    PropertyInfo p = (PropertyInfo)c.Tag;

                    switch (p.PropertyType.Name)
                    {
                        case "Int32":
                            int val;
                            if (int.TryParse(c.Text, out val))
                            {
                                p.SetValue(currentObject, val);
                            }
                            break;

                        case "String":
                            p.SetValue(currentObject, c.Text);
                            break;

                        case "Color":
                            Color col = (c.BackColor);
                            p.SetValue(currentObject, col);
                            break;

                        /*case "Point":
                             p.SetValue(currentObject, c.Text);
                             break;

                        case "Size":
                             p.SetValue(currentObject, c.Text);
                             break;*/
                    }
                }
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}

