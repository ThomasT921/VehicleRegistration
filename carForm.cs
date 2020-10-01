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
    public partial class carForm : Form
    {
        public carForm()
        {
            InitializeComponent();
        }
        // add a car
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validation to ensure someone atleast one character has been entered
            bool validated = true;
            if (txtCarMake.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles make.");
                validated = false;
            }
            if (txtCarModel.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles model.");
                validated = false;
            }
            if (txtCarDrive.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles drivetrain.");
                validated = false;
            }
            if (txtCarEngine.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles engine.");
                validated = false;
            }
            if (txtCarStyle.Text.Length < 1)
            {
                MessageBox.Show("Please enter the vehicles Bodystyle.");
                validated = false;
            }
            // if its validated it closes
            if (validated)
            {
                this.Close();
            }
            
        }
    }
}
