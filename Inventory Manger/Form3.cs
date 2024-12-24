using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manger
{
    public partial class newAccountForm : Form
    {
        Form1 f;
        public newAccountForm(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private async void  btnCreate_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = emailIBox.Text.Trim();
            user.Email = user.Email.Substring(0,user.Email.Length-4);
            user.Password = passwordBox.Text.Trim(); 
            user.Username = userName.Text.Trim();
            string confirm = confirmBox.Text.Trim();
            btnCreate.BackColor = Color.Gray;
            //to show waiting icon
            btnCreate.Enabled = false;    //to disable the button, User won't be able to send multiple request to database
            if (Utility.check_internet())
            {
                Dictionary<string, User> users = await FireBaseConfig.Get();
            if (user.Email == "" || user.Password == "" || confirm =="" || user.Username=="")
            {
                MessageBox.Show("The required field is empty","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    btnCreate.BackColor = Color.SlateBlue;
                    btnCreate.Enabled = true;
                return;
            }
            if(user.Password!=confirm)
            {
                MessageBox.Show("Password did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnCreate.BackColor = Color.SlateBlue;
                    btnCreate.Enabled = true;
                    return;
            }
                try
                {
                if (users[user.Email].Email == user.Email+".com")
                {
                    MessageBox.Show("Your account already exist!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCreate.BackColor = Color.SlateBlue;
                        btnCreate.Enabled = true;
                        return;
                }

                }
                catch(KeyNotFoundException)
                {
                    user.Email += ".com";
                FireBaseConfig.Post(user.Email, user);
                    
                    DialogResult m = MessageBox.Show("Your account has been successfully created", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    if(m==DialogResult.OK)
                    {
                        this.Close();
                    }

                }
                btnCreate.BackColor = Color.SlateBlue;
                btnCreate.Enabled = true;
            }
            
            else
            {
                MessageBox.Show("Check your internet connection","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnCreate.BackColor = Color.SlateBlue;
                btnCreate.Enabled = true;
            }

        }

        private void userName_Enter(object sender, EventArgs e)
        {
            userName.BackColor = Color.FromArgb(56, 49, 127);
        }
        private void emailIBox_Enter(object sender, EventArgs e)
        {
            emailIBox.BackColor = Color.FromArgb(56, 49, 127);

        }
        

        private void passwordBox_Enter(object sender, EventArgs e) //change the color of input box when it is focused
        {
            passwordBox.BackColor = Color.FromArgb(56, 49, 127);
        }

        private void confirmBox_Enter(object sender, EventArgs e)
        {
            confirmBox.BackColor = Color.FromArgb(56, 49, 127);
        }

        private void emailIBox_Leave(object sender, EventArgs e)
        {

            emailIBox.BackColor = Color.FromArgb(24, 20, 57);
            passwordBox.BackColor = Color.FromArgb(24, 20, 57);
            confirmBox.BackColor = Color.FromArgb(24, 20, 57);
        }

        private void newAccountForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            emailIBox.BackColor = Color.FromArgb(24, 20, 57);
            passwordBox.BackColor = Color.FromArgb(24, 20, 57);
            confirmBox.BackColor = Color.FromArgb(24, 20, 57);
        }

        private void newAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            f.Show();
        }


        private void userName_Leave(object sender, EventArgs e)
        {
            emailIBox.BackColor = Color.FromArgb(24, 20, 57);
            passwordBox.BackColor = Color.FromArgb(24, 20, 57);
            confirmBox.BackColor = Color.FromArgb(24, 20, 57);
            userName.BackColor = Color.FromArgb(24, 20, 57);
        }

        private void newAccountForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
