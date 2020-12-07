using System;
using System.Drawing;
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
    }
}
