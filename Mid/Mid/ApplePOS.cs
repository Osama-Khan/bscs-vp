using System.Windows.Forms;

/* Question Number 2: Carefully analyze and code the interface of 
 * “Apple Point of Sale Application” given below. There are three 
 * columns: product name, Quantity and amount in Apple POS Form. 
 * Quantity and amount fields has been disabled. When user chooses 
 * product (from checkBox) the application should focus quantity 
 * field againt the selected product and allow the user to input 
 * product quantity. On calculate bill button it will calculate 
 * price of each product, sum of quantity and total price. It will 
 * also calculate Tax and Grand Total. Clear button will reset all 
 * fields to it default setting.
 */
namespace Mid
{
    public partial class ApplePOS : Form
    {
        const int TAX = 16;
        float[] costs = new float[] { 60000, 80000, 50000, 20000, 15000 };

        CheckBox[] chks;
        TextBox[] qtys;
        TextBox[] amts;
        public ApplePOS()
        {
            InitializeComponent();
            chks = new CheckBox[] {
                chk_iPhone6s, chk_iPadPro, chk_iPadMini, chk_iPod, chk_watch
            };
            qtys = new TextBox[] {
                txt_iPhone6s_qty, txt_iPadPro_qty, txt_iPadMini_qty, txt_iPod_qty, txt_watch_qty
            };
            amts = new TextBox[] {
                txt_iPhone6s_amt, txt_iPadPro_amt, txt_iPadMini_amt, txt_iPod_amt, txt_watch_amt
            };

            foreach(var chk in chks)
                chk.CheckedChanged += OnCheckedChanged;

            btn_calculate.Click += OnCalculate;
            btn_clear.Click += OnClear;
            btn_exit.Click += OnExit;
        }

        void OnCheckedChanged(object sender, System.EventArgs args)
        {
            for (int i = 0; i < chks.Length; i++) { 
                if (chks[i] == sender) {
                    qtys[i].ReadOnly = !chks[i].Checked;
                    if (chks[i].Checked) qtys[i].Focus();
                }
            }
        }

        void OnCalculate(object sender, System.EventArgs args)
        {
            float basicBill = 0;
            int totalQty = 0;
            for (int i = 0; i < amts.Length; i++)
            {
                if (chks[i].Checked)
                {
                    int qty = int.Parse(qtys[i].Text);
                    totalQty += qty;
                    basicBill += costs[i] * qty;
                    amts[i].Text = (costs[i] * qty) + "";
                }
            }

            float tax = basicBill * (TAX / 100f),
                grandTotal = basicBill + tax;

            txt_total_qty.Text = totalQty + "";
            txt_total_amt.Text = basicBill + "";
            txt_tax.Text = (TAX) + "%";
            txt_tax_amt.Text = tax + "";
            txt_grand_total.Text = grandTotal + "";
        }

        void OnClear(object sender, System.EventArgs args)
        {
            foreach(Control child in Controls)
            {
                if (typeof(TextBox) == child.GetType())
                    child.ResetText();
                else if (typeof(CheckBox) == child.GetType())
                    ((CheckBox) child).Checked = false;
            }
        }

        void OnExit(object sender, System.EventArgs args)
        {
            Application.Exit();
        }
    }
}
