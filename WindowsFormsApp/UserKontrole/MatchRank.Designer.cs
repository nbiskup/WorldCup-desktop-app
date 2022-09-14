namespace WindowsFormsApp.UserKontrole
{
    partial class MatchRank
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGostujuciTim = new System.Windows.Forms.Label();
            this.lblDomaciTim = new System.Windows.Forms.Label();
            this.lblGledaoci = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.lblGostujuciTim);
            this.panel1.Controls.Add(this.lblDomaciTim);
            this.panel1.Controls.Add(this.lblGledaoci);
            this.panel1.Controls.Add(this.lblLokacija);
            this.panel1.Location = new System.Drawing.Point(26, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 362);
            this.panel1.TabIndex = 5;
            // 
            // lblGostujuciTim
            // 
            this.lblGostujuciTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGostujuciTim.Location = new System.Drawing.Point(16, 278);
            this.lblGostujuciTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGostujuciTim.Name = "lblGostujuciTim";
            this.lblGostujuciTim.Size = new System.Drawing.Size(315, 46);
            this.lblGostujuciTim.TabIndex = 3;
            this.lblGostujuciTim.Text = "label4";
            // 
            // lblDomaciTim
            // 
            this.lblDomaciTim.BackColor = System.Drawing.Color.Wheat;
            this.lblDomaciTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDomaciTim.Location = new System.Drawing.Point(16, 192);
            this.lblDomaciTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomaciTim.Name = "lblDomaciTim";
            this.lblDomaciTim.Size = new System.Drawing.Size(315, 50);
            this.lblDomaciTim.TabIndex = 2;
            this.lblDomaciTim.Text = "label3";
            // 
            // lblGledaoci
            // 
            this.lblGledaoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGledaoci.Location = new System.Drawing.Point(16, 107);
            this.lblGledaoci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGledaoci.Name = "lblGledaoci";
            this.lblGledaoci.Size = new System.Drawing.Size(315, 41);
            this.lblGledaoci.TabIndex = 1;
            this.lblGledaoci.Text = "label2";
            // 
            // lblLokacija
            // 
            this.lblLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLokacija.ForeColor = System.Drawing.Color.Red;
            this.lblLokacija.Location = new System.Drawing.Point(16, 18);
            this.lblLokacija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(315, 42);
            this.lblLokacija.TabIndex = 0;
            this.lblLokacija.Text = "label1";
            // 
            // MatchRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MatchRank";
            this.Size = new System.Drawing.Size(413, 403);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGostujuciTim;
        private System.Windows.Forms.Label lblDomaciTim;
        private System.Windows.Forms.Label lblGledaoci;
        private System.Windows.Forms.Label lblLokacija;
    }
}
