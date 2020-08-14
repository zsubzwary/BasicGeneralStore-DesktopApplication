using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicGeneralStoreDesktopApplication.Model;

namespace BasicGeneralStoreDesktopApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblStoreName.Text = Program.storeName;
            this.Text = Program.storeName;
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code for opening Add form will go here
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
            addItemForm.Close();
            RefreshDataIn_DataGridView();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code for closing the application
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshDataIn_DataGridView();
        }

        private void RefreshDataIn_DataGridView()
        {
            List<Item> items = SqliteDataAccess.getAllItems();
            dgvResults.DataSource = items;
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResults.Columns[e.ColumnIndex].Name == "Delete")
            {
                String name = dgvResults.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show("Are you sure you want to delete “"+ name +"” from the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                }
            }
            else if (dgvResults.Columns[e.ColumnIndex].Name == "Edit")
            {
                int ID = Convert.ToInt32(dgvResults.Rows[e.RowIndex].Cells[0].Value);
                
            }
        }
    }
}
