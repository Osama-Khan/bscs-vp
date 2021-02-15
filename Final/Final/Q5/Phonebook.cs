using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.Q5
{
    /* Design the application for phonebook to store and manage contact numbers, and code for each button.
     * •	Save button will save name and contact in dataGridView
     * •	Select the row you want to delete from gridview and press Delete button to delete the contact. 
     * •	For update, fetch the data from gridview to editable text fields, modify them according to your choice and then press Update button to perform the changes. 
     * •	Search button will search contact based on name as well as contact and show in gridview
     */
    public partial class Phonebook : Form
    {
        int index = 0;
        string selectedId = null;
        public Phonebook()
        {
            InitializeComponent();
            btnSave.Click += OnSave;
            btnDelete.Click += OnDelete;
            btnUpdate.Click += OnUpdate;
            btnSearch.Click += OnSearch;
            btnFetch.Click += OnFetch;
        }

        private void OnFetch(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv.SelectedRows[0];
            selectedId = selected.Cells[0].Value.ToString();
            txtName.Text = selected.Cells[1].Value.ToString();
            txtPhone.Text = selected.Cells[2].Value.ToString();
        }

        private void OnSearch(object sender, EventArgs e)
        {
            var rows = new List<string[]>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[1].Value.ToString() == txtSearch.Text ||
                    row.Cells[2].Value.ToString() == txtSearch.Text)
                {
                    rows.Add(new string[] { 
                        row.Cells[0].Value.ToString(), 
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                    });
                }
            }
            dgv.Rows.Clear();
            foreach (var row in rows)
            {
                dgv.Rows.Add(row);
            }
        }

        private void OnUpdate(object sender, EventArgs e)
        {
            if (selectedId == null) return;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[0].Value.ToString() == selectedId)
                {
                    row.Cells[1].Value = txtName.Text;
                    row.Cells[2].Value = txtPhone.Text;
                }
            }
            selectedId = null;
        }

        private void OnDelete(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgv.SelectedRows)
            {
                dgv.Rows.Remove(row);
                if (selectedId == row.Cells[0].Value.ToString())
                {
                    selectedId = null;
                }
            }
            index = dgv.Rows.Count > 0 ?
                int.Parse(dgv.Rows[dgv.Rows.Count - 1].Cells[0].Value.ToString()) + 1 : 0;
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                return;
            }
            dgv.Rows.Add(new string[] { "" + index++, txtName.Text, txtPhone.Text });
        }
    }
}
