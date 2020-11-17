using System.Windows.Forms;

/* Question 1:
 * Create an application in which user will enter the name of the
 * product in the textbox and click on add button will add the element
 * in the list box and the remove button will remove the name from the
 * list box .remove Selected button will remove the selected item from
 * the list box. Clear button will remove all the elements from the 
 * listBox and exit button will exit the application.
 */
namespace GUITasks.Assignments.A6
{
    public partial class ListBoxExample : Form
    {
        public ListBoxExample()
        {
            InitializeComponent();
            btn_add.Click += (s, e) => onAdd();
            btn_remove.Click += (s, e) => onRemove();
            btn_remove_selected.Click += (s, e) => onRemoveSelected();
            btn_clear.Click += (s, e) => onClear();
            btn_exit.Click += (s, e) => Application.Exit();
        }

        private void onAdd()
        {
            var toAdd = txt_product_name.Text;
            lstBox.Items.Add(toAdd);
        }

        private void onRemove()
        {
            var toRem = txt_product_name.Text;
            lstBox.Items.Remove(toRem);
        }

        private void onRemoveSelected()
        {
            lstBox.Items.RemoveAt(lstBox.SelectedIndex);
        }

        private void onClear()
        {
            lstBox.Items.Clear();
            txt_product_name.Clear();
        }
    }
}
