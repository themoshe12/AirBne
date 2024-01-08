using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace OOP_Project
{
    public partial class AirBNE : Form
    {
        public static List<Rentable> items = new List<Rentable>();
        public static List<User> users = new List<User>();
        public static User user = null;

        public AirBNE()
        {
            InitializeComponent();
            if (user == null)
            {
                orderButton.Visible = false;
                addItemsButton.Visible = false;
                logoutButton.Visible = false;
            }
            else
            {
                welcomeText.Text="Welcome, "+user.Name+"!";
                orderButton.Visible = true;
                registerButton.Visible = false;
                loginButton.Visible = false;
                addItemsButton.Visible = true;
            }
            Stream stream;
            if (items.Count == 0)
            {
                if (!File.Exists("items.mdl"))
                {
                    File.Create("items.mdl");
                }
                stream = File.Open("items.mdl", FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Rentable item;
                while (stream.Position < stream.Length)
                {
                    item = (Rentable)binaryFormatter.Deserialize(stream);
                    if (user!=null&&item.Id==user.Item.Id)
                        Order.item = item;
                    items.Add(item);
                }
                stream.Dispose();
            }
            if (users.Count == 0)
            {
                if (!File.Exists("users.mdl"))
                {
                    File.Create("users.mdl");
                }
                stream = File.Open("users.mdl", FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                User userData;
                while (stream.Position < stream.Length)
                {
                    userData = (User)binaryFormatter.Deserialize(stream);
                    users.Add(userData);
                }
                stream.Dispose();
            }
        }

        private void itemChoiceButton_Click(object sender, EventArgs e)
        {
            ItemChoice form = new ItemChoice();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void itemViewButton_Click(object sender, EventArgs e)
        {
            ItemView form = new ItemView();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Order form = new Order();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login form = new Login();
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            user = null;
            AirBNE form=new AirBNE();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
    }
}
