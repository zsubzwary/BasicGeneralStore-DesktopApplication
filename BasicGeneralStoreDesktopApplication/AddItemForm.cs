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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Item | " + Program.storeName;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudBuyingPrice.Value = 0;
            txtName.Text = "";
            nudQuantity.Value = 0;
            nudSellingPrice.Value = 0;
            cmbxUnit.Text = "";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            // doing nothing in here, I have just set the dialogResult to cancle and it goes back automatically because it is opened as a dialog result form the MainForm.
        }

        private void btnAddNewUnit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Name = txtName.Text,
                BuyingPrice = Convert.ToDouble(nudBuyingPrice.Value),
                SellingPrice = Convert.ToDouble(nudSellingPrice.Value),
                Quantity = Convert.ToDouble(nudQuantity.Value),
                Unit = cmbxUnit.Text,
            };
            try
            {
                SqliteDataAccess.SaveItem(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save ITEM to database.\n\n\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
