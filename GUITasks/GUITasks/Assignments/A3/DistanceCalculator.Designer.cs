namespace GUITasks
{
    partial class DistanceCalculator
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
            this.lbl_dist = new System.Windows.Forms.Label();
            this.txt_dist = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.lbl_spd = new System.Windows.Forms.Label();
            this.txt_spd = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dist
            // 
            this.lbl_dist.AutoSize = true;
            this.lbl_dist.Location = new System.Drawing.Point(58, 64);
            this.lbl_dist.Name = "lbl_dist";
            this.lbl_dist.Size = new System.Drawing.Size(73, 13);
            this.lbl_dist.TabIndex = 0;
            this.lbl_dist.Text = "Distance (Km)";
            // 
            // txt_dist
            // 
            this.txt_dist.Location = new System.Drawing.Point(178, 61);
            this.txt_dist.Name = "txt_dist";
            this.txt_dist.Size = new System.Drawing.Size(100, 20);
            this.txt_dist.TabIndex = 1;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(67, 90);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(55, 13);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "Time (Hrs)";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(178, 87);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(100, 20);
            this.txt_time.TabIndex = 3;
            // 
            // lbl_spd
            // 
            this.lbl_spd.AutoSize = true;
            this.lbl_spd.Location = new System.Drawing.Point(43, 144);
            this.lbl_spd.Name = "lbl_spd";
            this.lbl_spd.Size = new System.Drawing.Size(116, 13);
            this.lbl_spd.TabIndex = 4;
            this.lbl_spd.Text = "Average Speed (Km/h)";
            // 
            // txt_spd
            // 
            this.txt_spd.Location = new System.Drawing.Point(178, 141);
            this.txt_spd.Name = "txt_spd";
            this.txt_spd.ReadOnly = true;
            this.txt_spd.Size = new System.Drawing.Size(100, 20);
            this.txt_spd.TabIndex = 5;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(203, 212);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(122, 212);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(41, 212);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            // 
            // DistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.lbl_dist);
            this.Controls.Add(this.txt_dist);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.lbl_spd);
            this.Controls.Add(this.txt_spd);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Name = "DistanceCalculator";
            this.Padding = new System.Windows.Forms.Padding(64);
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dist;
        private System.Windows.Forms.TextBox txt_dist;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label lbl_spd;
        private System.Windows.Forms.TextBox txt_spd;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_calc;
    }
}

