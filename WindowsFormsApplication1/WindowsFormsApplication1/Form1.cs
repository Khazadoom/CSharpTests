using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string BarCode;
        string FirstName;
        string LastName;
        string IDNum;

        public Form1()
        {
            InitializeComponent();


        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            Form2 testDialog = new Form2();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                BarCode = testDialog.BarCodeTextBox.Text;
                FirstName = testDialog.FNameTextBox.Text;
                LastName = testDialog.LNameTextBox.Text;
                IDNum = testDialog.IDTextBox.Text;
            }
            else
            {
                //this.txtResult.Text = "Cancelled";
            }
            testDialog.Dispose();

        }

        private void checkoutButton_click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
