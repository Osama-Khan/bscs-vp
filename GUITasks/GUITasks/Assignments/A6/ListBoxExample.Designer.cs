namespace GUITasks.Assignments.A6
{
    partial class ListBoxExample
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
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btn_remove_selected = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Location = new System.Drawing.Point(35, 32);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(78, 13);
            this.lbl_product_name.TabIndex = 0;
            this.lbl_product_name.Text = "Product Name:";
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(119, 29);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(156, 20);
            this.txt_product_name.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(119, 55);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(200, 55);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(36, 85);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(239, 173);
            this.lstBox.TabIndex = 4;
            // 
            // btn_remove_selected
            // 
            this.btn_remove_selected.Location = new System.Drawing.Point(38, 264);
            this.btn_remove_selected.Name = "btn_remove_selected";
            this.btn_remove_selected.Size = new System.Drawing.Size(156, 52);
            this.btn_remove_selected.TabIndex = 5;
            this.btn_remove_selected.Text = "Remove Selected";
            this.btn_remove_selected.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(200, 293);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(200, 264);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // ListBoxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 347);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_remove_selected);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.lbl_product_name);
            this.Name = "ListBoxExample";
            this.Padding = new System.Windows.Forms.Padding(32);
            this.Text = "ListBoxExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product_name;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btn_remove_selected;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
    }
}