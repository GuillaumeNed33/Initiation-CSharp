namespace FeuilleDessin
{
    partial class FeuilleDessin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeuilleDessin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.déplacement = new System.Windows.Forms.ToolStripButton();
            this.reduire = new System.Windows.Forms.ToolStripButton();
            this.agrandir = new System.Windows.Forms.ToolStripButton();
            this.couleur = new System.Windows.Forms.ToolStripButton();
            this.reduct_trait = new System.Windows.Forms.ToolStripButton();
            this.agrandirTrait = new System.Windows.Forms.ToolStripButton();
            this.coulTrait = new System.Windows.Forms.ToolStripButton();
            this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ouvrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reinitialise = new System.Windows.Forms.ToolStripButton();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.retablir = new System.Windows.Forms.ToolStripButton();
            this.imprimer = new System.Windows.Forms.ToolStripButton();
            this.PrintApercu = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apercuAvantImpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MouseWheel += FeuilleDessin_MouseWheel;
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déplacement,
            this.reduire,
            this.agrandir,
            this.couleur,
            this.reduct_trait,
            this.agrandirTrait,
            this.coulTrait,
            this.enregistrerToolStripButton,
            this.ouvrirToolStripButton,
            this.reinitialise,
            this.annulerToolStripMenuItem,
            this.retablir,
            this.imprimer,
            this.PrintApercu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1192, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // déplacement
            // 
            this.déplacement.BackColor = System.Drawing.Color.Red;
            this.déplacement.CheckOnClick = true;
            this.déplacement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.déplacement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.déplacement.Image = ((System.Drawing.Image)(resources.GetObject("déplacement.Image")));
            this.déplacement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.déplacement.Name = "déplacement";
            this.déplacement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.déplacement.Size = new System.Drawing.Size(80, 22);
            this.déplacement.Text = "déplacement";
            // 
            // reduire
            // 
            this.reduire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.reduire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reduire.Name = "reduire";
            this.reduire.Size = new System.Drawing.Size(23, 22);
            this.reduire.Text = "-";
            this.reduire.Click += new System.EventHandler(this.reduire_Click);
            // 
            // agrandir
            // 
            this.agrandir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.agrandir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.agrandir.Image = ((System.Drawing.Image)(resources.GetObject("agrandir.Image")));
            this.agrandir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agrandir.Name = "agrandir";
            this.agrandir.Size = new System.Drawing.Size(23, 22);
            this.agrandir.Text = "+";
            this.agrandir.Click += new System.EventHandler(this.agrandir_Click);
            // 
            // couleur
            // 
            this.couleur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.couleur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.couleur.Image = ((System.Drawing.Image)(resources.GetObject("couleur.Image")));
            this.couleur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(79, 22);
            this.couleur.Text = "Noeud Color";
            this.couleur.Click += new System.EventHandler(this.couleur_Click);
            // 
            // reduct_trait
            // 
            this.reduct_trait.BackColor = System.Drawing.Color.Lime;
            this.reduct_trait.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reduct_trait.Image = ((System.Drawing.Image)(resources.GetObject("reduct_trait.Image")));
            this.reduct_trait.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reduct_trait.Name = "reduct_trait";
            this.reduct_trait.Size = new System.Drawing.Size(40, 22);
            this.reduct_trait.Text = "trait -";
            this.reduct_trait.Click += new System.EventHandler(this.reduct_trait_Click);
            // 
            // agrandirTrait
            // 
            this.agrandirTrait.BackColor = System.Drawing.Color.Lime;
            this.agrandirTrait.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.agrandirTrait.Image = ((System.Drawing.Image)(resources.GetObject("agrandirTrait.Image")));
            this.agrandirTrait.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.agrandirTrait.Name = "agrandirTrait";
            this.agrandirTrait.Size = new System.Drawing.Size(43, 22);
            this.agrandirTrait.Text = "trait +";
            this.agrandirTrait.Click += new System.EventHandler(this.agrandirTrait_Click);
            // 
            // coulTrait
            // 
            this.coulTrait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.coulTrait.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.coulTrait.Image = ((System.Drawing.Image)(resources.GetObject("coulTrait.Image")));
            this.coulTrait.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.coulTrait.Name = "coulTrait";
            this.coulTrait.Size = new System.Drawing.Size(70, 22);
            this.coulTrait.Text = "Trait Color ";
            this.coulTrait.Click += new System.EventHandler(this.coulTrait_Click);
            // 
            // enregistrerToolStripButton
            // 
            this.enregistrerToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.enregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enregistrerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripButton.Image")));
            this.enregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripButton.Name = "enregistrerToolStripButton";
            this.enregistrerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.enregistrerToolStripButton.Text = "Save";
            this.enregistrerToolStripButton.Click += new System.EventHandler(this.enregistrerToolStripButton_Click);
            // 
            // ouvrirToolStripButton
            // 
            this.ouvrirToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ouvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ouvrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripButton.Image")));
            this.ouvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripButton.Name = "ouvrirToolStripButton";
            this.ouvrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ouvrirToolStripButton.Text = "Ouvrir";
            this.ouvrirToolStripButton.Click += new System.EventHandler(this.ouvrirToolStripButton_Click);
            // 
            // reinitialise
            // 
            this.reinitialise.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.reinitialise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reinitialise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reinitialise.Image = ((System.Drawing.Image)(resources.GetObject("reinitialise.Image")));
            this.reinitialise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reinitialise.Name = "reinitialise";
            this.reinitialise.Size = new System.Drawing.Size(94, 22);
            this.reinitialise.Text = "Supprimer Tout";
            this.reinitialise.Click += new System.EventHandler(this.reinitialise_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.annulerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("annulerToolStripMenuItem.Image")));
            this.annulerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(23, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click_1);
            // 
            // retablir
            // 
            this.retablir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.retablir.Image = ((System.Drawing.Image)(resources.GetObject("retablir.Image")));
            this.retablir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.retablir.Name = "retablir";
            this.retablir.Size = new System.Drawing.Size(23, 22);
            this.retablir.Text = "Retablir";
            this.retablir.Click += new System.EventHandler(this.retablir_Click);
            // 
            // imprimer
            // 
            this.imprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimer.Image = ((System.Drawing.Image)(resources.GetObject("imprimer.Image")));
            this.imprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(23, 22);
            this.imprimer.Text = "Imprimer";
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // PrintApercu
            // 
            this.PrintApercu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintApercu.Image = ((System.Drawing.Image)(resources.GetObject("PrintApercu.Image")));
            this.PrintApercu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintApercu.Name = "PrintApercu";
            this.PrintApercu.Size = new System.Drawing.Size(23, 22);
            this.PrintApercu.Text = "Aperçu avant Impression";
            this.PrintApercu.Click += new System.EventHandler(this.PrintApercu_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1192, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1192, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserToolStripMenuItem,
            this.apercuAvantImpressionToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.ouvrirToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialiser";
            this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserToolStripMenuItem_Click);
            // 
            // apercuAvantImpressionToolStripMenuItem
            // 
            this.apercuAvantImpressionToolStripMenuItem.Name = "apercuAvantImpressionToolStripMenuItem";
            this.apercuAvantImpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.apercuAvantImpressionToolStripMenuItem.Text = "Aperçu avant Impression";
            this.apercuAvantImpressionToolStripMenuItem.Click += new System.EventHandler(this.apercuAvantImpressionToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem1,
            this.rétablirToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // annulerToolStripMenuItem1
            // 
            this.annulerToolStripMenuItem1.Name = "annulerToolStripMenuItem1";
            this.annulerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annulerToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.annulerToolStripMenuItem1.Text = "Annuler";
            this.annulerToolStripMenuItem1.Click += new System.EventHandler(this.annulerToolStripMenuItem1_Click);
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.rétablirToolStripMenuItem.Text = "Rétablir";
            this.rétablirToolStripMenuItem.Click += new System.EventHandler(this.rétablirToolStripMenuItem_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.LargeChange = 50;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 609);
            this.hScrollBar1.Maximum = 800;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1192, 17);
            this.hScrollBar1.SmallChange = 4;
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll_1);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.LargeChange = 50;
            this.vScrollBar1.Location = new System.Drawing.Point(1175, 74);
            this.vScrollBar1.Maximum = 800;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 535);
            this.vScrollBar1.SmallChange = 4;
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // FeuilleDessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 626);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FeuilleDessin";
            this.Text = "DessinNoeud";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FeuilleDessin_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton reduire;
        private System.Windows.Forms.ToolStripButton agrandir;
        private System.Windows.Forms.ToolStripButton couleur;
        private System.Windows.Forms.ToolStripButton ouvrirToolStripButton;
        private System.Windows.Forms.ToolStripButton enregistrerToolStripButton;
        private System.Windows.Forms.ToolStripButton reduct_trait;
        private System.Windows.Forms.ToolStripButton agrandirTrait;
        private System.Windows.Forms.ToolStripButton coulTrait;
        private System.Windows.Forms.ToolStripButton déplacement;
        private System.Windows.Forms.ToolStripButton reinitialise;
        private System.Windows.Forms.ToolStripButton annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton retablir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ToolStripButton imprimer;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apercuAvantImpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton PrintApercu;
    }
}

