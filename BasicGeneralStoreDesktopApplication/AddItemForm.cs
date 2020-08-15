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
            List<String> unitList = SqliteDataAccess.getAllUniqueUnitsName();
            cmbxUnit.Items.AddRange(unitList.ToArray<object>());
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrWhiteSpace(cmbxUnit.Text))
            {
                MessageBox.Show("Fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

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
                MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save ITEM to database.\n\n\nError Message:\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
