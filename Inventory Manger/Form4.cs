using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manger
{
    public partial class Form4 : Form
    {


        MainForm mainForm;
        public Form4(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string product = textBox1.Text.Trim();
            string quantity = textBox2.Text.Trim();
            string MRP = textBox3.Text.Trim();
            if (product == "" || quantity == "" || MRP == "")
            {
                MessageBox.Show("Input value is empty","error");
                return;
            }
            else
            {
                if( long.TryParse(quantity, out long r ) && (double.TryParse(MRP,out double rr) || long.TryParse(MRP,out long rrr)))
                {
                MessageBox.Show("Product has been successfully added!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                mainForm.refresh_panel(product,quantity,MRP);
                this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid input", "error");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    return;
                }
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        { 
            mainForm.Show();
        }
    }
}
