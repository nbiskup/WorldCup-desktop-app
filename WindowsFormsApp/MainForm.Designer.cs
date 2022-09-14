namespace WindowsFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.promjeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRankByGoals = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnRankByVisitors = new System.Windows.Forms.Button();
            this.btnRankByYellow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.smRemoveFromFavourites = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFavourites = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelDestination = new System.Windows.Forms.FlowLayoutPanel();
            this.smAddToFavourites = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPlayers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelSource = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmFavourites.SuspendLayout();
            this.cmPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promjeniToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // promjeniToolStripMenuItem
            // 
            this.promjeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeToolStripMenuItem});
            this.promjeniToolStripMenuItem.Name = "promjeniToolStripMenuItem";
            resources.ApplyResources(this.promjeniToolStripMenuItem, "promjeniToolStripMenuItem");
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            resources.ApplyResources(this.postavkeToolStripMenuItem, "postavkeToolStripMenuItem");
            this.postavkeToolStripMenuItem.Click += new System.EventHandler(this.postavkeToolStripMenuItem_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Tag = "Rank by:";
            // 
            // stripStatusLabel
            // 
            this.stripStatusLabel.Name = "stripStatusLabel";
            resources.ApplyResources(this.stripStatusLabel, "stripStatusLabel");
            // 
            // btnRankByGoals
            // 
            this.btnRankByGoals.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnRankByGoals, "btnRankByGoals");
            this.btnRankByGoals.Name = "btnRankByGoals";
            this.btnRankByGoals.UseVisualStyleBackColor = false;
            this.btnRankByGoals.Click += new System.EventHandler(this.btnRangirajPoGolovima_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripStatusLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // btnRankByVisitors
            // 
            this.btnRankByVisitors.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnRankByVisitors, "btnRankByVisitors");
            this.btnRankByVisitors.Name = "btnRankByVisitors";
            this.btnRankByVisitors.Tag = "";
            this.btnRankByVisitors.UseVisualStyleBackColor = false;
            this.btnRankByVisitors.Click += new System.EventHandler(this.btnRangirajPoPosjetiteljima);
            // 
            // btnRankByYellow
            // 
            this.btnRankByYellow.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnRankByYellow, "btnRankByYellow");
            this.btnRankByYellow.Name = "btnRankByYellow";
            this.btnRankByYellow.UseVisualStyleBackColor = false;
            this.btnRankByYellow.Click += new System.EventHandler(this.btnRangirajPoKartonima_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // smRemoveFromFavourites
            // 
            this.smRemoveFromFavourites.Name = "smRemoveFromFavourites";
            resources.ApplyResources(this.smRemoveFromFavourites, "smRemoveFromFavourites");
            // 
            // cmFavourites
            // 
            this.cmFavourites.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmFavourites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smRemoveFromFavourites});
            this.cmFavourites.Name = "cmFavourites";
            resources.ApplyResources(this.cmFavourites, "cmFavourites");
            // 
            // panelDestination
            // 
            this.panelDestination.AllowDrop = true;
            resources.ApplyResources(this.panelDestination, "panelDestination");
            this.panelDestination.BackColor = System.Drawing.Color.OldLace;
            this.panelDestination.ContextMenuStrip = this.cmFavourites;
            this.panelDestination.Name = "panelDestination";
            this.panelDestination.Tag = "2";
            // 
            // smAddToFavourites
            // 
            this.smAddToFavourites.Name = "smAddToFavourites";
            resources.ApplyResources(this.smAddToFavourites, "smAddToFavourites");
            // 
            // cmPlayers
            // 
            this.cmPlayers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmPlayers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smAddToFavourites});
            this.cmPlayers.Name = "cmPlayers";
            resources.ApplyResources(this.cmPlayers, "cmPlayers");
            // 
            // panelSource
            // 
            this.panelSource.AllowDrop = true;
            resources.ApplyResources(this.panelSource, "panelSource");
            this.panelSource.BackColor = System.Drawing.Color.OldLace;
            this.panelSource.ContextMenuStrip = this.cmPlayers;
            this.panelSource.Name = "panelSource";
            this.panelSource.Tag = "1";
            // 
            // cbTeams
            // 
            this.cbTeams.BackColor = System.Drawing.Color.Silver;
            this.cbTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeams.FormattingEnabled = true;
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTim_SelectedIndexChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRankByGoals);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRankByVisitors);
            this.Controls.Add(this.btnRankByYellow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDestination);
            this.Controls.Add(this.panelSource);
            this.Controls.Add(this.cbTeams);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_ZatvaranjeForme);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormZatvoren);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmFavourites.ResumeLayout(false);
            this.cmPlayers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem promjeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel stripStatusLabel;
        private System.Windows.Forms.Button btnRankByGoals;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnRankByVisitors;
        private System.Windows.Forms.Button btnRankByYellow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem smRemoveFromFavourites;
        private System.Windows.Forms.ContextMenuStrip cmFavourites;
        private System.Windows.Forms.FlowLayoutPanel panelDestination;
        private System.Windows.Forms.ToolStripMenuItem smAddToFavourites;
        private System.Windows.Forms.ContextMenuStrip cmPlayers;
        private System.Windows.Forms.FlowLayoutPanel panelSource;
        private System.Windows.Forms.ComboBox cbTeams;
    }
}