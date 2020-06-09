namespace quanlytinhoc
{
    partial class frmMains
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghềNghiệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cơQuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcHọcViênToolStripMenuItem,
            this.danhMụcGiáoViênToolStripMenuItem,
            this.nghềNghiệpToolStripMenuItem,
            this.cơQuanToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMucToolStripMenuItem.Text = "Danh Mục";
            this.danhMucToolStripMenuItem.Click += new System.EventHandler(this.danhMucToolStripMenuItem_Click);
            // 
            // danhMụcHọcViênToolStripMenuItem
            // 
            this.danhMụcHọcViênToolStripMenuItem.Name = "danhMụcHọcViênToolStripMenuItem";
            this.danhMụcHọcViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.danhMụcHọcViênToolStripMenuItem.Text = "Danh mục học viên";
            // 
            // danhMụcGiáoViênToolStripMenuItem
            // 
            this.danhMụcGiáoViênToolStripMenuItem.Name = "danhMụcGiáoViênToolStripMenuItem";
            this.danhMụcGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.danhMụcGiáoViênToolStripMenuItem.Text = "Danh mục giáo viên";
            // 
            // nghềNghiệpToolStripMenuItem
            // 
            this.nghềNghiệpToolStripMenuItem.Name = "nghềNghiệpToolStripMenuItem";
            this.nghềNghiệpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nghềNghiệpToolStripMenuItem.Text = "Nghề nghiệp";
            // 
            // cơQuanToolStripMenuItem
            // 
            this.cơQuanToolStripMenuItem.Name = "cơQuanToolStripMenuItem";
            this.cơQuanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cơQuanToolStripMenuItem.Text = "Cơ quan";
            // 
            // frmMains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMains";
            this.Text = "frmMains";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghềNghiệpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cơQuanToolStripMenuItem;
    }
}