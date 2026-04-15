namespace faszg
{
    partial class Tortenet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tortenet));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.történetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanárokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezárToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.történetToolStripMenuItem,
            this.tanárokToolStripMenuItem,
            this.aToolStripMenuItem,
            this.bezárToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // történetToolStripMenuItem
            // 
            this.történetToolStripMenuItem.Name = "történetToolStripMenuItem";
            this.történetToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.történetToolStripMenuItem.Text = "Történet";
            this.történetToolStripMenuItem.Click += new System.EventHandler(this.történetToolStripMenuItem_Click);
            // 
            // tanárokToolStripMenuItem
            // 
            this.tanárokToolStripMenuItem.Name = "tanárokToolStripMenuItem";
            this.tanárokToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.tanárokToolStripMenuItem.Text = "Tanárok";
            this.tanárokToolStripMenuItem.Click += new System.EventHandler(this.tanárokToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aToolStripMenuItem.Text = "12/A";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bezárToolStripMenuItem
            // 
            this.bezárToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bezárToolStripMenuItem.Name = "bezárToolStripMenuItem";
            this.bezárToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.bezárToolStripMenuItem.Text = "Bezár";
            this.bezárToolStripMenuItem.Click += new System.EventHandler(this.bezárToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3439, 160);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tortenet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tortenet";
            this.Text = "Tortenet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem történetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanárokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezárToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}