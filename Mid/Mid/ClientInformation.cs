using System;
using System.Windows.Forms;

/* Question Number 1: GUI of client information form has been given below. 
 * You have to write code for “Choose Image” and “Save Data” buttons. 
 * Choose image button is used to set picture in a Picture Box while on 
 * “Save Data” button the data of all fields must be saved in a Grid View. 
 * Also note that age must be calculated based on date of birth and then 
 * saved in GridView.
 */
namespace Mid
{
    public partial class ClientInformation : Form
    {
        public ClientInformation()
        {
            InitializeComponent();
            btn_choose_image.Click += SetPicture;
            btn_save.Click += SaveData;
        }

        void SetPicture(object sender, System.EventArgs args)
        {
            var res = dialog_picture.ShowDialog();
            if (res == DialogResult.OK)
            {
                pic_main.ImageLocation = dialog_picture.FileName;
            }
        }

        void SaveData(object sender, EventArgs args)
        {
            string name = txt_name.Text,
                address = txt_address.Text,
                city = txt_city.Text,
                state = txt_state.Text,
                zip = txt_zip.Text,
                country = txt_country.Text,
                phone = txt_phone.Text,
                email = txt_email.Text,
                imagePath = pic_main.ImageLocation;
            DateTime dob = date_dob.Value;
            DateTime cur = DateTime.Now;
            int age = cur.Year - dob.Year;
            if (cur.Month < dob.Month)
            {
                age -= 1;
            }
            else if (cur.Month == dob.Month)
            {
                age -= cur.Day < dob.Day ? 1 : 0;
            }
            string[] row = new string[]
            {
                name, address, city, state, zip, country, phone, email, age.ToString(), imagePath
            };
            dgv.Rows.Add(row);
        }

        /* Question 4: Update the given form of Question 1 in a way that when user 
         * Double Clicks on any cell of DataGridView, the entire data (row data) of 
         * the selected cell must be populated in the above editable fields in the 
         * same sequence. Note you are required to write code for click event only.
         */

        void OnDgvDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgv.Rows[e.RowIndex].Cells;
            txt_name.Text = cells[0].Value.ToString();
            txt_address.Text = cells[1].Value.ToString();
            txt_city.Text = cells[2].Value.ToString();
            txt_state.Text = cells[3].Value.ToString();
            txt_zip.Text = cells[4].Value.ToString();
            txt_country.Text = cells[5].Value.ToString();
            txt_phone.Text = cells[6].Value.ToString();
            txt_email.Text = cells[7].Value.ToString();
            int age = int.Parse(cells[8].Value.ToString());
            date_dob.Value = new DateTime(2020 - age, 1, 1);
            pic_main.ImageLocation = cells[9].Value.ToString();
        }
    }
}
