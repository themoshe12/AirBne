using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OOP_Project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Enter Username...")
                usernameBox.Text = "";
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
                usernameBox.Text = "Enter Username...";
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Enter Password...")
            {
                passwordBox.Text = "";
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.UseSystemPasswordChar=false;
                passwordBox.Text = "Enter Password...";
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            if (nameBox.Text == "Enter Name...")
                nameBox.Text = "";
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            if (nameBox.Text == "")
                nameBox.Text = "Enter Name...";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text.Length < 6 || usernameBox.Text.Equals("Enter Username..."))
            {
                MessageBox.Show("Bad Username!");
                return;
            }
            if (passwordBox.Text.Length < 6)
            {
                MessageBox.Show("Password Too Short!");
                return;
            }
            if (nameBox.Text.Length < 2 || nameBox.Text.Equals("Enter Name..."))
            {
                MessageBox.Show("\"" + nameBox.Text + "\"" + " Can't Possibly Be Your Name!");
                return;
            }
            string username = usernameBox.Text.ToLower();
            if (AirBNE.users.Count != 0)
            {
                foreach (User user in AirBNE.users)
                {
                    if (user.UserName.ToLower().Equals(username))
                    {
                        MessageBox.Show("Invalid Credentials!");
                        return;
                    }
                }
            }
            User createdUser = new User(usernameBox.Text, passwordBox.Text, nameBox.Text);
            AirBNE.users.Add(createdUser);
            AirBNE.user = createdUser;
            AirBNE form = new AirBNE();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            AirBNE form = new AirBNE();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(234, 234, 234), Color.FromArgb(255, 94, 0), 65F))
                {
                    this.DoubleBuffered = true;
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            }
        }
    }
}
