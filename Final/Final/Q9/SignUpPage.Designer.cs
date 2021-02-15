namespace Final.Q9
{
    partial class SignUpPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.radioGroupGender = new System.Windows.Forms.Panel();
            this.radGenderOther = new System.Windows.Forms.RadioButton();
            this.radGenderFemale = new System.Windows.Forms.RadioButton();
            this.radGenderMale = new System.Windows.Forms.RadioButton();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblTos = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblAlreadyRegistered = new System.Windows.Forms.LinkLabel();
            this.radioGroupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(110, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Its fast and easy!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 1);
            this.panel1.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 82);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 21);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(186, 82);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 21);
            this.txtLastName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(16, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDob.Location = new System.Drawing.Point(13, 169);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(68, 14);
            this.lblDob.TabIndex = 7;
            this.lblDob.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGender.Location = new System.Drawing.Point(13, 229);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(44, 14);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // radioGroupGender
            // 
            this.radioGroupGender.Controls.Add(this.radGenderOther);
            this.radioGroupGender.Controls.Add(this.radGenderFemale);
            this.radioGroupGender.Controls.Add(this.radGenderMale);
            this.radioGroupGender.Location = new System.Drawing.Point(16, 246);
            this.radioGroupGender.Name = "radioGroupGender";
            this.radioGroupGender.Size = new System.Drawing.Size(315, 23);
            this.radioGroupGender.TabIndex = 12;
            // 
            // radGenderOther
            // 
            this.radGenderOther.AutoSize = true;
            this.radGenderOther.Location = new System.Drawing.Point(199, 3);
            this.radGenderOther.Name = "radGenderOther";
            this.radGenderOther.Size = new System.Drawing.Size(51, 17);
            this.radGenderOther.TabIndex = 15;
            this.radGenderOther.TabStop = true;
            this.radGenderOther.Text = "Other";
            this.radGenderOther.UseVisualStyleBackColor = true;
            // 
            // radGenderFemale
            // 
            this.radGenderFemale.AutoSize = true;
            this.radGenderFemale.Location = new System.Drawing.Point(123, 3);
            this.radGenderFemale.Name = "radGenderFemale";
            this.radGenderFemale.Size = new System.Drawing.Size(60, 17);
            this.radGenderFemale.TabIndex = 14;
            this.radGenderFemale.TabStop = true;
            this.radGenderFemale.Text = "Female";
            this.radGenderFemale.UseVisualStyleBackColor = true;
            // 
            // radGenderMale
            // 
            this.radGenderMale.AutoSize = true;
            this.radGenderMale.Location = new System.Drawing.Point(48, 3);
            this.radGenderMale.Name = "radGenderMale";
            this.radGenderMale.Size = new System.Drawing.Size(48, 17);
            this.radGenderMale.TabIndex = 13;
            this.radGenderMale.TabStop = true;
            this.radGenderMale.Text = "Male";
            this.radGenderMale.UseVisualStyleBackColor = true;
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(16, 196);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(315, 21);
            this.dtpDob.TabIndex = 13;
            // 
            // lblTos
            // 
            this.lblTos.AutoSize = true;
            this.lblTos.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTos.Location = new System.Drawing.Point(13, 285);
            this.lblTos.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblTos.Name = "lblTos";
            this.lblTos.Size = new System.Drawing.Size(331, 28);
            this.lblTos.TabIndex = 14;
            this.lblTos.Text = "By clicking sign up, you agree to our Terms, Data Policy and Cookie Policy. You m" +
    "ay recieve SMS from us and can opt out at any time";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignup.Location = new System.Drawing.Point(102, 340);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(141, 35);
            this.btnSignup.TabIndex = 15;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = false;
            // 
            // lblAlreadyRegistered
            // 
            this.lblAlreadyRegistered.AutoSize = true;
            this.lblAlreadyRegistered.Location = new System.Drawing.Point(109, 387);
            this.lblAlreadyRegistered.Name = "lblAlreadyRegistered";
            this.lblAlreadyRegistered.Size = new System.Drawing.Size(127, 13);
            this.lblAlreadyRegistered.TabIndex = 16;
            this.lblAlreadyRegistered.TabStop = true;
            this.lblAlreadyRegistered.Text = "Already have an account?";
            // 
            // SignUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(350, 421);
            this.Controls.Add(this.lblAlreadyRegistered);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblTos);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.radioGroupGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignUpPage";
            this.Text = "SignUpPage";
            this.radioGroupGender.ResumeLayout(false);
            this.radioGroupGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Panel radioGroupGender;
        private System.Windows.Forms.RadioButton radGenderOther;
        private System.Windows.Forms.RadioButton radGenderFemale;
        private System.Windows.Forms.RadioButton radGenderMale;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblTos;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.LinkLabel lblAlreadyRegistered;
    }
}