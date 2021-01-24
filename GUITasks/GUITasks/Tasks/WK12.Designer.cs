namespace GUITasks.Tasks
{
    partial class WK12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WK12));
            this.strip = new System.Windows.Forms.ToolStrip();
            this.strip_btn_fore = new System.Windows.Forms.ToolStripButton();
            this.strip_btn_back = new System.Windows.Forms.ToolStripButton();
            this.strip_btn_font = new System.Windows.Forms.ToolStripButton();
            this.txt = new System.Windows.Forms.TextBox();
            this.dialog_color = new System.Windows.Forms.ColorDialog();
            this.dialog_font = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.strip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // strip
            // 
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_btn_fore,
            this.strip_btn_back,
            this.strip_btn_font});
            this.strip.Location = new System.Drawing.Point(0, 24);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(397, 25);
            this.strip.TabIndex = 1;
            this.strip.Text = "toolStrip1";
            // 
            // strip_btn_fore
            // 
            this.strip_btn_fore.Image = ((System.Drawing.Image)(resources.GetObject("strip_btn_fore.Image")));
            this.strip_btn_fore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btn_fore.Name = "strip_btn_fore";
            this.strip_btn_fore.Size = new System.Drawing.Size(79, 22);
            this.strip_btn_fore.Text = "ForeColor";
            // 
            // strip_btn_back
            // 
            this.strip_btn_back.Image = ((System.Drawing.Image)(resources.GetObject("strip_btn_back.Image")));
            this.strip_btn_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btn_back.Name = "strip_btn_back";
            this.strip_btn_back.Size = new System.Drawing.Size(81, 22);
            this.strip_btn_back.Text = "BackColor";
            // 
            // strip_btn_font
            // 
            this.strip_btn_font.Image = ((System.Drawing.Image)(resources.GetObject("strip_btn_font.Image")));
            this.strip_btn_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_btn_font.Name = "strip_btn_font";
            this.strip_btn_font.Size = new System.Drawing.Size(51, 22);
            this.strip_btn_font.Text = "Font";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 78);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(373, 97);
            this.txt.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.toolStripMenuItem1.Text = "Admission";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem2.Text = "Exams";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem3.Text = "Fee";
            // 
            // WK12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 244);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WK12";
            this.Text = "WK12";
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip strip;
        private System.Windows.Forms.ToolStripButton strip_btn_fore;
        private System.Windows.Forms.ToolStripButton strip_btn_back;
        private System.Windows.Forms.ToolStripButton strip_btn_font;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ColorDialog dialog_color;
        private System.Windows.Forms.FontDialog dialog_font;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}