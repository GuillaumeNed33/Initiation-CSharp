using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeuilleDessin
{
    public partial class ParametresNoeud : Form
    {
         public ParametresNoeud(Color c, int e, string t)
        {
            InitializeComponent();
            epais.Value = e;
            coul.BackColor = c;
            text.Text = t;
        }

        public Color Couleur { get { return coul.BackColor;  } }

        public int Epaisseur { get { return (int)epais.Value; } }

        public string LeTexte { get { return text.Text; } }

        private void coul_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog { Color = coul.BackColor };
            if (col.ShowDialog() == DialogResult.OK)
            {
                coul.BackColor = col.Color;
            }
        }
    }
}
