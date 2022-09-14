namespace WindowsFormsApp.UserKontrole
{
    partial class UserKontrolaIgrac
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserKontrolaIgrac));
            this.lblKapetan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pblsFavorite = new System.Windows.Forms.PictureBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pblsFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKapetan
            // 
            this.lblKapetan.AutoSize = true;
            this.lblKapetan.BackColor = System.Drawing.Color.Transparent;
            this.lblKapetan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblKapetan.ForeColor = System.Drawing.Color.Red;
            this.lblKapetan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKapetan.Location = new System.Drawing.Point(509, 23);
            this.lblKapetan.Name = "lblKapetan";
            this.lblKapetan.Size = new System.Drawing.Size(49, 46);
            this.lblKapetan.TabIndex = 14;
            this.lblKapetan.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(218, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Broj:";
            // 
            // pblsFavorite
            // 
            this.pblsFavorite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pblsFavorite.Location = new System.Drawing.Point(20, 11);
            this.pblsFavorite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pblsFavorite.Name = "pblsFavorite";
            this.pblsFavorite.Size = new System.Drawing.Size(53, 47);
            this.pblsFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblsFavorite.TabIndex = 12;
            this.pblsFavorite.TabStop = false;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBroj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBroj.Location = new System.Drawing.Point(293, 133);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(23, 25);
            this.lblBroj.TabIndex = 11;
            this.lblBroj.Text = "1";
            // 
            // lblPozicija
            // 
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPozicija.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPozicija.Location = new System.Drawing.Point(218, 74);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(79, 25);
            this.lblPozicija.TabIndex = 10;
            this.lblPozicija.Text = "Pozicija";
            // 
            // lblIme
            // 
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblIme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIme.Location = new System.Drawing.Point(218, 23);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(211, 31);
            this.lblIme.TabIndex = 9;
            this.lblIme.Text = "Ime i Prezime";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbSlika
            // 
            this.pbSlika.Image = ((System.Drawing.Image)(resources.GetObject("pbSlika.Image")));
            this.pbSlika.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbSlika.Location = new System.Drawing.Point(76, 23);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(137, 142);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 8;
            this.pbSlika.TabStop = false;
            this.pbSlika.Tag = "PictureBox";
            // 
            // UserKontrolaIgrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblKapetan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pblsFavorite);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.pbSlika);
            this.Name = "UserKontrolaIgrac";
            this.Size = new System.Drawing.Size(578, 177);
            this.Load += new System.EventHandler(this.UserKontrolaIgrac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblsFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKapetan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pblsFavorite;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.PictureBox pbSlika;
    }
}
