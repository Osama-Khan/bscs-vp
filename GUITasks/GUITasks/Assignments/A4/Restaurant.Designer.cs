namespace GUITasks.Assignments.A4
{
    partial class Restaurant
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
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.lbl_extra = new System.Windows.Forms.Label();
            this.chk_raita = new System.Windows.Forms.CheckBox();
            this.chk_salad = new System.Windows.Forms.CheckBox();
            this.group_pay = new System.Windows.Forms.GroupBox();
            this.rad_pay_cc = new System.Windows.Forms.RadioButton();
            this.rad_pay_cash = new System.Windows.Forms.RadioButton();
            this.lbl_bill = new System.Windows.Forms.Label();
            this.txt_bill = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.group_pay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Location = new System.Drawing.Point(12, 66);
            this.lbl_item.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(96, 13);
            this.lbl_item.TabIndex = 0;
            this.lbl_item.Text = "Select Item to Buy:";
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Items.AddRange(new object[] {
            "Mutton Karahi Half - 950 Rs.",
            "Mutton Karahi Full - 1800 Rs.",
            "Chicken Karahi Half - 550 Rs.",
            "Chicken Karahi Full - 900 Rs.",
            "Tikka Boti 1 Dozen - 1200 Rs.",
            "Malai Boti 1 Dozen - 1200 Rs."});
            this.cmb_item.Location = new System.Drawing.Point(179, 63);
            this.cmb_item.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(120, 21);
            this.cmb_item.TabIndex = 1;
            // 
            // lbl_extra
            // 
            this.lbl_extra.AutoSize = true;
            this.lbl_extra.Location = new System.Drawing.Point(12, 98);
            this.lbl_extra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_extra.Name = "lbl_extra";
            this.lbl_extra.Size = new System.Drawing.Size(42, 13);
            this.lbl_extra.TabIndex = 2;
            this.lbl_extra.Text = "Extras: ";
            // 
            // chk_raita
            // 
            this.chk_raita.AutoSize = true;
            this.chk_raita.Location = new System.Drawing.Point(74, 98);
            this.chk_raita.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chk_raita.Name = "chk_raita";
            this.chk_raita.Size = new System.Drawing.Size(97, 17);
            this.chk_raita.TabIndex = 3;
            this.chk_raita.Text = "Raita (+Rs. 70)";
            this.chk_raita.UseVisualStyleBackColor = true;
            // 
            // chk_salad
            // 
            this.chk_salad.AutoSize = true;
            this.chk_salad.Location = new System.Drawing.Point(176, 98);
            this.chk_salad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chk_salad.Name = "chk_salad";
            this.chk_salad.Size = new System.Drawing.Size(99, 17);
            this.chk_salad.TabIndex = 4;
            this.chk_salad.Text = "Salad (+Rs. 70)";
            this.chk_salad.UseVisualStyleBackColor = true;
            // 
            // group_pay
            // 
            this.group_pay.Controls.Add(this.rad_pay_cash);
            this.group_pay.Controls.Add(this.rad_pay_cc);
            this.group_pay.Location = new System.Drawing.Point(14, 121);
            this.group_pay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.group_pay.Name = "group_pay";
            this.group_pay.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.group_pay.Size = new System.Drawing.Size(284, 52);
            this.group_pay.TabIndex = 5;
            this.group_pay.TabStop = false;
            this.group_pay.Text = "Payment Method";
            // 
            // rad_pay_cc
            // 
            this.rad_pay_cc.AutoSize = true;
            this.rad_pay_cc.Location = new System.Drawing.Point(149, 19);
            this.rad_pay_cc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_pay_cc.Name = "rad_pay_cc";
            this.rad_pay_cc.Size = new System.Drawing.Size(77, 17);
            this.rad_pay_cc.TabIndex = 1;
            this.rad_pay_cc.Text = "Credit Card";
            this.rad_pay_cc.UseVisualStyleBackColor = true;
            // 
            // rad_pay_cash
            // 
            this.rad_pay_cash.AutoSize = true;
            this.rad_pay_cash.Checked = true;
            this.rad_pay_cash.Location = new System.Drawing.Point(44, 19);
            this.rad_pay_cash.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rad_pay_cash.Name = "rad_pay_cash";
            this.rad_pay_cash.Size = new System.Drawing.Size(49, 17);
            this.rad_pay_cash.TabIndex = 0;
            this.rad_pay_cash.TabStop = true;
            this.rad_pay_cash.Text = "Cash";
            this.rad_pay_cash.UseVisualStyleBackColor = true;
            // 
            // lbl_bill
            // 
            this.lbl_bill.AutoSize = true;
            this.lbl_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bill.Location = new System.Drawing.Point(46, 207);
            this.lbl_bill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bill.Name = "lbl_bill";
            this.lbl_bill.Size = new System.Drawing.Size(88, 20);
            this.lbl_bill.TabIndex = 6;
            this.lbl_bill.Text = "Total Bill: ";
            // 
            // txt_bill
            // 
            this.txt_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_bill.Location = new System.Drawing.Point(164, 204);
            this.txt_bill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_bill.Name = "txt_bill";
            this.txt_bill.ReadOnly = true;
            this.txt_bill.Size = new System.Drawing.Size(100, 26);
            this.txt_bill.TabIndex = 7;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_order.FlatAppearance.BorderSize = 0;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Blinker", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_order.Location = new System.Drawing.Point(105, 253);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(100, 47);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = false;
            // 
            // Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 312);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.lbl_extra);
            this.Controls.Add(this.chk_raita);
            this.Controls.Add(this.chk_salad);
            this.Controls.Add(this.group_pay);
            this.Controls.Add(this.lbl_bill);
            this.Controls.Add(this.txt_bill);
            this.Controls.Add(this.btn_order);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Restaurant";
            this.Text = "Restaurant";
            this.group_pay.ResumeLayout(false);
            this.group_pay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.Label lbl_extra;
        private System.Windows.Forms.CheckBox chk_raita;
        private System.Windows.Forms.CheckBox chk_salad;
        private System.Windows.Forms.GroupBox group_pay;
        private System.Windows.Forms.RadioButton rad_pay_cc;
        private System.Windows.Forms.RadioButton rad_pay_cash;
        private System.Windows.Forms.Label lbl_bill;
        private System.Windows.Forms.TextBox txt_bill;
        private System.Windows.Forms.Button btn_order;
    }
}