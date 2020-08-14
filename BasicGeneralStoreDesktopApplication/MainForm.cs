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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code for opening Add form will go here
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Code for closing the application
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblStoreName.Text = Program.storeName;
            this.Text = Program.storeName;
        }
    }
}
