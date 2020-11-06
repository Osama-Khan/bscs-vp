namespace GUITasks.Assignments.A4
{
    partial class TemperatureConverter
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
            this.lbl_input = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.rad_fahren = new System.Windows.Forms.RadioButton();
            this.rad_celsius = new System.Windows.Forms.RadioButton();
            this.lbl_convert = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(37, 21);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(206, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Temperature Converter";
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(12, 73);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(98, 13);
            this.lbl_input.TabIndex = 1;
            this.lbl_input.Text = "Enter Temperature:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(137, 70);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(139, 20);
            this.txt_input.TabIndex = 2;
            // 
            // rad_fahren
            // 
            this.rad_fahren.AutoSize = true;
            this.rad_fahren.Checked = true;
            this.rad_fahren.Location = new System.Drawing.Point(137, 111);
            this.rad_fahren.Name = "rad_fahren";
            this.rad_fahren.Size = new System.Drawing.Size(75, 17);
            this.rad_fahren.TabIndex = 3;
            this.rad_fahren.TabStop = true;
            this.rad_fahren.Text = "Fahrenheit";
            this.rad_fahren.UseVisualStyleBackColor = true;
            // 
            // rad_celsius
            // 
            this.rad_celsius.AutoSize = true;
            this.rad_celsius.Location = new System.Drawing.Point(218, 111);
            this.rad_celsius.Name = "rad_celsius";
            this.rad_celsius.Size = new System.Drawing.Size(58, 17);
            this.rad_celsius.TabIndex = 4;
            this.rad_celsius.TabStop = true;
            this.rad_celsius.Text = "Celsius";
            this.rad_celsius.UseVisualStyleBackColor = true;
            // 
            // lbl_convert
            // 
            this.lbl_convert.AutoSize = true;
            this.lbl_convert.Location = new System.Drawing.Point(12, 115);
            this.lbl_convert.Name = "lbl_convert";
            this.lbl_convert.Size = new System.Drawing.Size(59, 13);
            this.lbl_convert.TabIndex = 5;
            this.lbl_convert.Text = "Convert to:";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(83, 144);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(129, 43);
            this.btn_convert.TabIndex = 6;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(137, 217);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(139, 20);
            this.txt_output.TabIndex = 8;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(12, 220);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(43, 13);
            this.lbl_result.TabIndex = 7;
            this.lbl_result.Text = "Result: ";
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 264);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_convert);
            this.Controls.Add(this.rad_fahren);
            this.Controls.Add(this.rad_celsius);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_output);
            this.Name = "TemperatureConverter";
            this.Text = "TemperatureConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.RadioButton rad_fahren;
        private System.Windows.Forms.RadioButton rad_celsius;
        private System.Windows.Forms.Label lbl_convert;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label lbl_result;
    }
}