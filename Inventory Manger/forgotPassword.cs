using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Manger
{
    public partial class forgotPassword : Form
    {
        private Form1 fs;
        public forgotPassword(Form1 f)
        {
            InitializeComponent();
            fs = f; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_Enter(object sender, EventArgs e)
        {
            
            email.BackColor = Color.SlateBlue;
        }
        private void password_Leave(object sender, EventArgs e)
        {
            email.BackColor = Color.FromArgb(24, 20, 57);
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string emaild = email.Text.Trim();
            string pass = "";
            if (emaild == "")
            {
                MessageBox.Show("Field is empty");
                button1.Enabled = true;
                return;

            }
                var clent = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential("ezioa1527@gmail.com", "zmtaqprnxelndpij")
                };
                MailMessage m = new MailMessage();
                m.From = new MailAddress("ezioa1527@gmail.com");

 /*               IFirebaseConfig config = new FirebaseConfig()
                {
                    AuthSecret = "h21orDLjTx6bvSpWJMLReuWdQ0p8jpYqyRMU0gw0",
                    BasePath = "https://inventeger-data-default-rtdb.firebaseio.com/"
                };
                IFirebaseClient client = new FirebaseClient(config);
                var data = await client.GetAsync("userList");*/
            Dictionary<string, User> data =await FireBaseConfig.Get();
         
            try
            {
                if (data[emaild.Substring(0,emaild.Length-4)].Email == emaild)
                {
                    pass += data[emaild.Substring(0, emaild.Length - 4)].Password;
                    m.Subject = "Password";
                    m.Body = "<html></body>Your password is " + pass + " </body></html>";
                    m.IsBodyHtml = true;
                    m.To.Add(new MailAddress(emaild));
                    await clent.SendMailAsync(m);
                    MessageBox.Show("Your password has been sent to your email :D", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(KeyNotFoundException)
            {
                MessageBox.Show("You don't have an account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            button1.Enabled = true;

        }


        private void forgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            fs.Show();

        }
    }
}
