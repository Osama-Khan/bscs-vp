namespace GUITasks.Tasks
{
    partial class WK11
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.salary});
            this.dgv.Location = new System.Drawing.Point(12, 89);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(308, 212);
            this.dgv.TabIndex = 25;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(246, 49);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 34);
            this.btn_show.TabIndex = 24;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(246, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(64, 61);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(164, 20);
            this.txt_salary.TabIndex = 22;
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Location = new System.Drawing.Point(9, 64);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(36, 13);
            this.lbl_salary.TabIndex = 21;
            this.lbl_salary.Text = "Salary";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(64, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 20);
            this.txt_name.TabIndex = 20;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(9, 38);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 19;
            this.lbl_name.Text = "Name";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(64, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(164, 20);
            this.txt_id.TabIndex = 18;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(9, 12);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 17;
            this.lbl_id.Text = "ID";
            // 
            // WK11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 313);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "WK11";
            this.Text = "WK11";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
    }
}