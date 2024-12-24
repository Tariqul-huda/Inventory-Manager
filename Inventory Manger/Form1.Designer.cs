namespace Inventory_Manger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sign_form = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.newAccount = new System.Windows.Forms.LinkLabel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sign_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign_form
            // 
            this.sign_form.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sign_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.sign_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sign_form.Controls.Add(this.linkLabel2);
            this.sign_form.Controls.Add(this.button1);
            this.sign_form.Controls.Add(this.newAccount);
            this.sign_form.Controls.Add(this.passwordBox);
            this.sign_form.Controls.Add(this.emailBox);
            this.sign_form.Controls.Add(this.label2);
            this.sign_form.Controls.Add(this.label1);
            this.sign_form.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sign_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_form.ForeColor = System.Drawing.Color.SlateBlue;
            this.sign_form.Location = new System.Drawing.Point(308, 110);
            this.sign_form.Name = "sign_form";
            this.sign_form.Size = new System.Drawing.Size(311, 298);
            this.sign_form.TabIndex = 0;
            this.sign_form.TabStop = false;
            this.sign_form.Text = "Sign in";

            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.SlateBlue;
            this.linkLabel2.Location = new System.Drawing.Point(8, 141);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(145, 18);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot password?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // newAccount
            // 
            this.newAccount.AutoSize = true;
            this.newAccount.LinkColor = System.Drawing.Color.SlateBlue;
            this.newAccount.Location = new System.Drawing.Point(32, 257);
            this.newAccount.Name = "newAccount";
            this.newAccount.Size = new System.Drawing.Size(250, 18);
            this.newAccount.TabIndex = 4;
            this.newAccount.TabStop = true;
            this.newAccount.Text = "Don\'t have an account? Sign up!";
            this.newAccount.Click += new System.EventHandler(this.newAccount_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(106, 90);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(199, 24);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.Enter += new System.EventHandler(this.textBox2_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(57)))));
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailBox.Location = new System.Drawing.Point(106, 51);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(199, 24);
            this.emailBox.TabIndex = 2;
            this.emailBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.emailBox.Leave += new System.EventHandler(this.textBox1_Leave_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:  ";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Inventory_Manger.Properties.Resources._6114100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 486);
            this.Controls.Add(this.sign_form);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(960, 525);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventeger";

            this.Click += new System.EventHandler(this.Form1_Click);
            this.sign_form.ResumeLayout(false);
            this.sign_form.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox sign_form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.LinkLabel newAccount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

