using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGeneralStoreDesktopApplication
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
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

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Item | " + Program.storeName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
