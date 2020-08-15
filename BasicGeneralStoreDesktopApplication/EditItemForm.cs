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
    public partial class EditItemForm : Form
    {
        private int ID;
        public EditItemForm(int id)
        {
            InitializeComponent();
            this.Text = "Edit Item |" + Program.storeName;
            this.ID = id;
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            List<String> unitList = SqliteDataAccess.getAllUniqueUnitsName();
            cmbxUnit.Items.AddRange(unitList.ToArray<object>());

            try
            {
                Item toBeEdited = SqliteDataAccess.getItemByID(ID);
                lblItemID.Text = toBeEdited.ID.ToString();
                txtName.Text = toBeEdited.Name;
                nudBuyingPrice.Value = Convert.ToDecimal(toBeEdited.BuyingPrice);
                nudSellingPrice.Value = Convert.ToDecimal(toBeEdited.SellingPrice);
                nudQuantity.Value = Convert.ToDecimal(toBeEdited.Quantity);
                cmbxUnit.Text = toBeEdited.Unit;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get the item with the ID of “"+ID+"” from database for editing.\n\n\nError Message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item
                {
                    ID = this.ID,
                    Name = txtName.Text,
                    BuyingPrice = Convert.ToDouble(nudBuyingPrice.Value),
                    SellingPrice = Convert.ToDouble(nudSellingPrice.Value),
                    Quantity = Convert.ToDouble(nudQuantity.Value),
                    Unit = cmbxUnit.Text,
                };
                SqliteDataAccess.UpdateItemByID(item);
                MessageBox.Show("Changes Saved Successfully", "Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save new changes made to the ITEM to database.\n\n\nError Message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
