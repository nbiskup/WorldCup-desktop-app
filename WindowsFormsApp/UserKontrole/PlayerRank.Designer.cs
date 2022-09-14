namespace WindowsFormsApp.UserKontrole
{
    partial class PlayerRank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerRank));
            this.lblRank = new System.Windows.Forms.Label();
            this.lblBrojEvenata = new System.Windows.Forms.Label();
            this.lblImee = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRank
            // 
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRank.Location = new System.Drawing.Point(426, 32);
            this.lblRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(111, 44);
            this.lblRank.TabIndex = 8;
            this.lblRank.Text = "Text3";
            // 
            // lblBrojEvenata
            // 
            this.lblBrojEvenata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBrojEvenata.Location = new System.Drawing.Point(170, 103);
            this.lblBrojEvenata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrojEvenata.Name = "lblBrojEvenata";
            this.lblBrojEvenata.Size = new System.Drawing.Size(216, 28);
            this.lblBrojEvenata.TabIndex = 7;
            this.lblBrojEvenata.Text = "Text";
            // 
            // lblImee
            // 
            this.lblImee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblImee.Location = new System.Drawing.Point(170, 48);
            this.lblImee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImee.Name = "lblImee";
            this.lblImee.Size = new System.Drawing.Size(216, 28);
            this.lblImee.TabIndex = 6;
            this.lblImee.Text = "Text2";
            // 
            // pbSlika
            // 
            this.pbSlika.Image = ((System.Drawing.Image)(resources.GetObject("pbSlika.Image")));
            this.pbSlika.Location = new System.Drawing.Point(18, 32);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(4);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(124, 130);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 5;
            this.pbSlika.TabStop = false;
            // 
            // PlayerRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblBrojEvenata);
            this.Controls.Add(this.lblImee);
            this.Controls.Add(this.pbSlika);
            this.Name = "PlayerRank";
            this.Size = new System.Drawing.Size(555, 195);
            this.Load += new System.EventHandler(this.PlayerRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblBrojEvenata;
        private System.Windows.Forms.Label lblImee;
        private System.Windows.Forms.PictureBox pbSlika;
    }
}
