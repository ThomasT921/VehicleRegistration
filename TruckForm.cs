using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT_Final_Project
{
    public partial class TruckForm : Form
    {
        public TruckForm()
        {
            InitializeComponent();
        }
        //add button to add truck
        private void btnTruckAdd_Click(object sender, EventArgs e)
        {
            //Validation to make sure atleast 1 character has been entered
            bool validated = true;
            if (txtTruckMake.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles make.");
                validated = false;
            }
            if (txtTruckModel.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles model.");
                validated = false;
            }
            if (txtTruckDrive.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles drivetrain.");
                validated = false;
            }
            if (txtTruckEngine.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles engine.");
                validated = false;
            }
            if (txtTruckStyle.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles Bodystyle.");
                validated = false;
            }
            if (txtTruckSize.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles bed size.");
                validated = false;
            }
            //if validated it closes
            if (validated)
            {
                this.Close();
            }
        }
    }
}
