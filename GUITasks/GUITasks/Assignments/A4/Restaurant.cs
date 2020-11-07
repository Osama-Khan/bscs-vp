using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

/* Question 2
 * Create the application for the restaurant point of sale.
 * Application will show the list of items with their prices
 * in a ComboBox and the user will select the desired item from 
 * the ComboBox. On the selection of the item the amount of the
 * item will be added in the total bill and shown in the Bill 
 * text Box. When user will select the raita or salad the price 
 * of the items will be added in the total bill. Order button 
 * will show the detail of order in the message Box.
 */
namespace GUITasks.Assignments.A4
{
    public partial class Restaurant : Form
    {
        int[] itemPrices = { 950, 1800, 550, 900, 1200, 1200 };
        string[] items = {
            "Mutton Karahi Half",
            "Mutton Karahi Full",
            "Chicken Karahi Half",
            "Chicken Karahi Full",
            "Tikka Boti 1 Dozen",
            "Malai Boti 1 Dozen"};

    public Restaurant()
        {
            InitializeComponent();
            cmb_item.SelectedIndex = 0;
            cmb_item.SelectedIndexChanged += CalculateBill;
            chk_raita.CheckedChanged += CalculateBill;
            chk_salad.CheckedChanged += CalculateBill;
            btn_order.Click += (s, e) => Order();
        }

        private void CalculateBill(object s, System.EventArgs e)
        {
            int item = cmb_item.SelectedIndex;
            bool raita = chk_raita.Checked;
            bool salad = chk_salad.Checked;

            int bill = itemPrices[item];
            bill += raita? 70: 0;
            bill += salad ? 70 : 0;
            txt_bill.Text = bill.ToString();
        }

        private void Order()
        {
            int item = cmb_item.SelectedIndex;
            bool raita = chk_raita.Checked;
            bool salad = chk_salad.Checked;
            int bill = itemPrices[item];
            bill += raita ? 70 : 0;
            bill += salad ? 70 : 0;

            string order = "Order details: \n"
                + items[item] + " --- Rs. " + itemPrices[item] + "\n"
                + (raita ? "Raita --- Rs. 70\n" : "")
                + (salad ? "Raita --- Rs. 70\n" : "")
                + "Payment by: " + (rad_pay_cash.Checked ? "Cash" : "Credit Card")
                + "\n------------------------------\n"
                + "Total Amount Due: " + bill + " Rs.";

            MessageBox.Show(order, "Bill Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
    }
}
