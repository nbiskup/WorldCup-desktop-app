namespace WindowsFormsApp
{
    partial class RankIPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankIPrint));
            this.flpRankKontener = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.Pregledispisa = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // flpRankKontener
            // 
            this.flpRankKontener.AutoScroll = true;
            this.flpRankKontener.Location = new System.Drawing.Point(17, 14);
            this.flpRankKontener.Margin = new System.Windows.Forms.Padding(4);
            this.flpRankKontener.Name = "flpRankKontener";
            this.flpRankKontener.Size = new System.Drawing.Size(587, 677);
            this.flpRankKontener.TabIndex = 3;
            // 
            // Pregledispisa
            // 
            this.Pregledispisa.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Pregledispisa.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Pregledispisa.ClientSize = new System.Drawing.Size(400, 300);
            this.Pregledispisa.Document = this.printDocument;
            this.Pregledispisa.Enabled = true;
            this.Pregledispisa.Icon = ((System.Drawing.Icon)(resources.GetObject("Pregledispisa.Icon")));
            this.Pregledispisa.Name = "printPreviewDialog";
            this.Pregledispisa.Visible = false;
            // 
            // RankIPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 771);
            this.Controls.Add(this.flpRankKontener);
            this.Name = "RankIPrint";
            this.Text = "RankIPrint";
            this.Load += new System.EventHandler(this.RankIPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpRankKontener;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog Pregledispisa;
    }
}