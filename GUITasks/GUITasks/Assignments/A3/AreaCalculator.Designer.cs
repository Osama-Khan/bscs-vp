namespace GUITasks.Assignments.A3
{
    partial class AreaCalculator
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
            this.lbl_w = new System.Windows.Forms.Label();
            this.txt_w = new System.Windows.Forms.TextBox();
            this.lbl_h = new System.Windows.Forms.Label();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.lbl_area = new System.Windows.Forms.Label();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_w
            // 
            this.lbl_w.AutoSize = true;
            this.lbl_w.Location = new System.Drawing.Point(62, 64);
            this.lbl_w.Name = "lbl_w";
            this.lbl_w.Size = new System.Drawing.Size(63, 13);
            this.lbl_w.TabIndex = 9;
            this.lbl_w.Text = "Enter Width";
            // 
            // txt_w
            // 
            this.txt_w.Location = new System.Drawing.Point(187, 61);
            this.txt_w.Name = "txt_w";
            this.txt_w.Size = new System.Drawing.Size(100, 20);
            this.txt_w.TabIndex = 10;
            // 
            // lbl_h
            // 
            this.lbl_h.AutoSize = true;
            this.lbl_h.Location = new System.Drawing.Point(62, 90);
            this.lbl_h.Name = "lbl_h";
            this.lbl_h.Size = new System.Drawing.Size(66, 13);
            this.lbl_h.TabIndex = 11;
            this.lbl_h.Text = "Enter Height";
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(187, 87);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(100, 20);
            this.txt_h.TabIndex = 12;
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Location = new System.Drawing.Point(76, 144);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(29, 13);
            this.lbl_area.TabIndex = 13;
            this.lbl_area.Text = "Area";
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(187, 141);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(100, 20);
            this.txt_area.TabIndex = 14;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(50, 212);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 17;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(131, 212);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(212, 212);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // AreaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.lbl_w);
            this.Controls.Add(this.txt_w);
            this.Controls.Add(this.lbl_h);
            this.Controls.Add(this.txt_h);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Name = "AreaCalculator";
            this.Padding = new System.Windows.Forms.Padding(64);
            this.Text = "AreaCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_w;
        private System.Windows.Forms.TextBox txt_w;
        private System.Windows.Forms.Label lbl_h;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}