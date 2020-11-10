namespace GUITasks.Assignments.A5
{
    partial class ColorDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_back_red = new System.Windows.Forms.RadioButton();
            this.rad_back_green = new System.Windows.Forms.RadioButton();
            this.rad_back_blue = new System.Windows.Forms.RadioButton();
            this.rad_back_grey = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_fore_black = new System.Windows.Forms.RadioButton();
            this.rad_fore_white = new System.Windows.Forms.RadioButton();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_back_blue);
            this.groupBox1.Controls.Add(this.rad_back_grey);
            this.groupBox1.Controls.Add(this.rad_back_red);
            this.groupBox1.Controls.Add(this.rad_back_green);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Back Color";
            // 
            // rad_back_red
            // 
            this.rad_back_red.AutoSize = true;
            this.rad_back_red.Checked = true;
            this.rad_back_red.Location = new System.Drawing.Point(7, 20);
            this.rad_back_red.Name = "rad_back_red";
            this.rad_back_red.Size = new System.Drawing.Size(45, 17);
            this.rad_back_red.TabIndex = 0;
            this.rad_back_red.TabStop = true;
            this.rad_back_red.Text = "Red";
            this.rad_back_red.UseVisualStyleBackColor = true;
            // 
            // rad_back_green
            // 
            this.rad_back_green.AutoSize = true;
            this.rad_back_green.Location = new System.Drawing.Point(140, 19);
            this.rad_back_green.Name = "rad_back_green";
            this.rad_back_green.Size = new System.Drawing.Size(54, 17);
            this.rad_back_green.TabIndex = 1;
            this.rad_back_green.Text = "Green";
            this.rad_back_green.UseVisualStyleBackColor = true;
            // 
            // rad_back_blue
            // 
            this.rad_back_blue.AutoSize = true;
            this.rad_back_blue.Location = new System.Drawing.Point(7, 78);
            this.rad_back_blue.Name = "rad_back_blue";
            this.rad_back_blue.Size = new System.Drawing.Size(46, 17);
            this.rad_back_blue.TabIndex = 2;
            this.rad_back_blue.Text = "Blue";
            this.rad_back_blue.UseVisualStyleBackColor = true;
            // 
            // rad_back_grey
            // 
            this.rad_back_grey.AutoSize = true;
            this.rad_back_grey.Location = new System.Drawing.Point(140, 77);
            this.rad_back_grey.Name = "rad_back_grey";
            this.rad_back_grey.Size = new System.Drawing.Size(47, 17);
            this.rad_back_grey.TabIndex = 3;
            this.rad_back_grey.Text = "Grey";
            this.rad_back_grey.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_fore_black);
            this.groupBox2.Controls.Add(this.rad_fore_white);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 54);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fore Color";
            // 
            // rad_fore_black
            // 
            this.rad_fore_black.AutoSize = true;
            this.rad_fore_black.Checked = true;
            this.rad_fore_black.Location = new System.Drawing.Point(7, 20);
            this.rad_fore_black.Name = "rad_fore_black";
            this.rad_fore_black.Size = new System.Drawing.Size(52, 17);
            this.rad_fore_black.TabIndex = 0;
            this.rad_fore_black.TabStop = true;
            this.rad_fore_black.Text = "Black";
            this.rad_fore_black.UseVisualStyleBackColor = true;
            // 
            // rad_fore_white
            // 
            this.rad_fore_white.AutoSize = true;
            this.rad_fore_white.Location = new System.Drawing.Point(140, 19);
            this.rad_fore_white.Name = "rad_fore_white";
            this.rad_fore_white.Size = new System.Drawing.Size(53, 17);
            this.rad_fore_white.TabIndex = 1;
            this.rad_fore_white.Text = "White";
            this.rad_fore_white.UseVisualStyleBackColor = true;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(13, 188);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 38);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(138, 188);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 38);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // ColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 246);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorDialog";
            this.Text = "ColorDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_back_blue;
        private System.Windows.Forms.RadioButton rad_back_grey;
        private System.Windows.Forms.RadioButton rad_back_red;
        private System.Windows.Forms.RadioButton rad_back_green;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_fore_black;
        private System.Windows.Forms.RadioButton rad_fore_white;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_exit;
    }
}