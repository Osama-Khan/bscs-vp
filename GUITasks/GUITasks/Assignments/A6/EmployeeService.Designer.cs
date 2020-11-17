namespace GUITasks.Assignments.A6
{
    partial class EmployeeService
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_join = new System.Windows.Forms.Label();
            this.lbl_resign = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.date_join = new System.Windows.Forms.DateTimePicker();
            this.date_resign = new System.Windows.Forms.DateTimePicker();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_service = new System.Windows.Forms.TextBox();
            this.txt_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(35, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(35, 59);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_join
            // 
            this.lbl_join.AutoSize = true;
            this.lbl_join.Location = new System.Drawing.Point(35, 86);
            this.lbl_join.Name = "lbl_join";
            this.lbl_join.Size = new System.Drawing.Size(55, 13);
            this.lbl_join.TabIndex = 2;
            this.lbl_join.Text = "Join Date:";
            // 
            // lbl_resign
            // 
            this.lbl_resign.AutoSize = true;
            this.lbl_resign.Location = new System.Drawing.Point(35, 114);
            this.lbl_resign.Name = "lbl_resign";
            this.lbl_resign.Size = new System.Drawing.Size(69, 13);
            this.lbl_resign.TabIndex = 3;
            this.lbl_resign.Text = "Resign Date:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(110, 56);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(110, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(200, 20);
            this.txt_id.TabIndex = 6;
            // 
            // date_join
            // 
            this.date_join.Location = new System.Drawing.Point(110, 82);
            this.date_join.Name = "date_join";
            this.date_join.Size = new System.Drawing.Size(200, 20);
            this.date_join.TabIndex = 8;
            // 
            // date_resign
            // 
            this.date_resign.Location = new System.Drawing.Point(110, 108);
            this.date_resign.Name = "date_resign";
            this.date_resign.Size = new System.Drawing.Size(200, 20);
            this.date_resign.TabIndex = 9;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(228, 196);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(82, 36);
            this.btn_calculate.TabIndex = 10;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            // 
            // txt_service
            // 
            this.txt_service.Location = new System.Drawing.Point(110, 170);
            this.txt_service.Name = "txt_service";
            this.txt_service.ReadOnly = true;
            this.txt_service.Size = new System.Drawing.Size(200, 20);
            this.txt_service.TabIndex = 12;
            // 
            // txt_label
            // 
            this.txt_label.AutoSize = true;
            this.txt_label.Location = new System.Drawing.Point(35, 173);
            this.txt_label.Name = "txt_label";
            this.txt_label.Size = new System.Drawing.Size(46, 13);
            this.txt_label.TabIndex = 11;
            this.txt_label.Text = "Service:";
            // 
            // EmployeeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 255);
            this.Controls.Add(this.txt_service);
            this.Controls.Add(this.txt_label);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.date_resign);
            this.Controls.Add(this.date_join);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_resign);
            this.Controls.Add(this.lbl_join);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_id);
            this.Name = "EmployeeService";
            this.Padding = new System.Windows.Forms.Padding(32);
            this.Text = "EmployeeService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_join;
        private System.Windows.Forms.Label lbl_resign;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DateTimePicker date_join;
        private System.Windows.Forms.DateTimePicker date_resign;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_service;
        private System.Windows.Forms.Label txt_label;
    }
}