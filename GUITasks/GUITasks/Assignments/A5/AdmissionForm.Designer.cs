namespace GUITasks.Assignments.A5
{
    partial class AdmissionForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_percentage = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_percentage = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.rad_gender_m = new System.Windows.Forms.RadioButton();
            this.rad_gender_f = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(166, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(148, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Admission Form";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(94, 68);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_percentage
            // 
            this.lbl_percentage.AutoSize = true;
            this.lbl_percentage.Location = new System.Drawing.Point(94, 101);
            this.lbl_percentage.Name = "lbl_percentage";
            this.lbl_percentage.Size = new System.Drawing.Size(65, 13);
            this.lbl_percentage.TabIndex = 2;
            this.lbl_percentage.Text = "Percentage:";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(94, 135);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(87, 13);
            this.lbl_contact.TabIndex = 3;
            this.lbl_contact.Text = "Contact Number:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(257, 65);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(138, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_percentage
            // 
            this.txt_percentage.Location = new System.Drawing.Point(257, 98);
            this.txt_percentage.Name = "txt_percentage";
            this.txt_percentage.Size = new System.Drawing.Size(138, 20);
            this.txt_percentage.TabIndex = 5;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(257, 132);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(138, 20);
            this.txt_contact.TabIndex = 6;
            // 
            // rad_gender_m
            // 
            this.rad_gender_m.AutoSize = true;
            this.rad_gender_m.Checked = true;
            this.rad_gender_m.Location = new System.Drawing.Point(257, 170);
            this.rad_gender_m.Name = "rad_gender_m";
            this.rad_gender_m.Size = new System.Drawing.Size(48, 17);
            this.rad_gender_m.TabIndex = 7;
            this.rad_gender_m.TabStop = true;
            this.rad_gender_m.Text = "Male";
            this.rad_gender_m.UseVisualStyleBackColor = true;
            // 
            // rad_gender_f
            // 
            this.rad_gender_f.AutoSize = true;
            this.rad_gender_f.Location = new System.Drawing.Point(311, 170);
            this.rad_gender_f.Name = "rad_gender_f";
            this.rad_gender_f.Size = new System.Drawing.Size(59, 17);
            this.rad_gender_f.TabIndex = 8;
            this.rad_gender_f.Text = "Female";
            this.rad_gender_f.UseVisualStyleBackColor = true;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(94, 170);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(45, 13);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(200, 202);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 40);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.percentage,
            this.gender,
            this.contact});
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(12, 248);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(443, 179);
            this.dgv.TabIndex = 11;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // percentage
            // 
            this.percentage.HeaderText = "Percentage";
            this.percentage.Name = "percentage";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // contact
            // 
            this.contact.HeaderText = "Contact No.";
            this.contact.Name = "contact";
            // 
            // AdmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 439);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.rad_gender_f);
            this.Controls.Add(this.rad_gender_m);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_percentage);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_percentage);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_title);
            this.Name = "AdmissionForm";
            this.Text = "AdmissionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_percentage;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_percentage;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.RadioButton rad_gender_m;
        private System.Windows.Forms.RadioButton rad_gender_f;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
    }
}