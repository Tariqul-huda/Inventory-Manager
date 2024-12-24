using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Manger
{
    public partial class Form1 : Form
    {
        public string BasePath { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
       

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            emailBox.BackColor = Color.FromArgb(24, 20, 57);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            emailBox.BackColor = Color.FromArgb(56,49,127);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            passwordBox.BackColor = Color.FromArgb(56,49,127);
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            passwordBox.BackColor = Color.FromArgb(24, 20, 57);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SlateBlue;
            button1.ForeColor = Color.White;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
             //to show waiting icon
            button1.Enabled = false;    //to disable the button, User won't be able to send multiple request to database
            
            
            //if Utility.check_internet is for checking the internet on submission
            
            if(Utility.check_internet())
            {
            User user = new User();
            user.Email = emailBox.Text.Trim();
            user.Password = passwordBox.Text.Trim();
                if(user.Email =="" || user.Password=="")
                {
                    MessageBox.Show("Input field is empty!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                    button1.Enabled = true;
                    return;
                }
                
                //configuring firebase 
                user.Email = user.Email.Substring(0,user.Email.Length-4);
                

            IFirebaseConfig config = new FirebaseConfig()
                {
                AuthSecret = "h21orDLjTx6bvSpWJMLReuWdQ0p8jpYqyRMU0gw0",
                BasePath = "https://inventeger-data-default-rtdb.firebaseio.com/"
            };
            
            IFirebaseClient client = new FirebaseClient(config);
                
                //first getting the data from the database
                //start
                var data = await client.GetAsync("userList");
                
                //checking if the database is empty

                if(data.ToString()=="null")
                {
                    MessageBox.Show("Invalid credentials","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    
                    button1.Enabled = true;
                    return;
                }
                //adding database information to dictonary

                Dictionary<string, User> users = data.ResultAs<Dictionary<string, User>>();

                //checking if the value from the box matches with database
                try
                {
                if (users[user.Email].Email==user.Email+".com" && users[user.Email].Password == user.Password)
                {
                        MainForm m = new MainForm(this);
                        this.Hide();
                        m.Show();
                        
                    

                }
                else
                    {
                        MessageBox.Show("Incorrect password or email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch(KeyNotFoundException)
                {
                    MessageBox.Show("Incorrect password or email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //end
               
                //if the user is found then found you, otherwise not found you :)
            }
            else
            {
                MessageBox.Show("Check your internet connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            button1.Enabled = true;
            button1.BackColor = Color.SlateBlue;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //hiding the first form to show the forgot password form
            this.Hide();
            
            //creating forgot password form
            forgotPassword fs = new forgotPassword(this);
            fs.Show();
        }

        private void newAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            newAccountForm n = new newAccountForm(this);
            
            n.Show();
        }
    }
}
