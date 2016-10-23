namespace FeuilleDessin
{
    partial class ParametresNoeud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epais = new System.Windows.Forms.NumericUpDown();
            this.coul = new System.Windows.Forms.Label();
            this.Valid = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Epaisseur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Couleur";
            // 
            // epais
            // 
            this.epais.Location = new System.Drawing.Point(91, 28);
            this.epais.Name = "epais";
            this.epais.Size = new System.Drawing.Size(34, 20);
            this.epais.TabIndex = 4;
            this.epais.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // coul
            // 
            this.coul.AutoSize = true;
            this.coul.BackColor = System.Drawing.Color.Black;
            this.coul.Location = new System.Drawing.Point(91, 65);
            this.coul.Name = "coul";
            this.coul.Size = new System.Drawing.Size(34, 13);
            this.coul.TabIndex = 5;
            this.coul.Text = "         ";
            this.coul.Click += new System.EventHandler(this.coul_Click);
            // 
            // Valid
            // 
            this.Valid.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Valid.Location = new System.Drawing.Point(64, 132);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(75, 23);
            this.Valid.TabIndex = 6;
            this.Valid.Text = "OK";
            this.Valid.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(159, 132);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Texte";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(91, 97);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(165, 20);
            this.text.TabIndex = 9;
            // 
            // ParametresNoeud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.coul);
            this.Controls.Add(this.epais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ParametresNoeud";
            this.Text = "ParametresNoeud";
            ((System.ComponentModel.ISupportInitialize)(this.epais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown epais;
        private System.Windows.Forms.Label coul;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text;

    }
}