using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class CreateApartment : Form
    {
        public CreateApartment()
        {
            InitializeComponent();
        }

        private void addressBox_Enter(object sender, EventArgs e)
        {
            if (addressBox.Text == "Enter Address...")
                addressBox.Text = "";
        }

        private void addressBox_Leave(object sender, EventArgs e)
        {
            if (addressBox.Text == "")
                addressBox.Text = "Enter Address...";
        }

        private void createBox_Click(object sender, EventArgs e)
        {
            if (addressBox.Text.Length < 6 || addressBox.Text.Equals("Enter Address..."))
            {
                MessageBox.Show("Bad Address");
                return;
            }
            if (priceBox.Value <50)
            {
                MessageBox.Show("Bad Price");
                return;
            }
            if (residentsBox.Value == 0)
            {
                MessageBox.Show("You Must Be Able To Host Residents");
                return;
            }
            if (roomCountBox.Value == 0)
            {
                MessageBox.Show("You Must Have At Least One Room");
                return;
            }
            if (floorBox.Value == 0)
            {
                MessageBox.Show("You Must Have At Least One Floor");
                return;
            }
            if (zipCodeBox.Value == 0)
            {
                MessageBox.Show("You Must Enter A Zip Code");
                return;
            }
            if (descriptionBox.Text.Equals("Enter Description..."))
                descriptionBox.Text = "";
            Apartment apartment = new Apartment(addressBox.Text, descriptionBox.Text, Convert.ToInt32(zipCodeBox.Value), Convert.ToDouble(priceBox.Value), Convert.ToInt32(residentsBox.Value), petsBox.Checked, poolBox.Checked, wifiBox.Checked, AirBNE.user, Convert.ToInt32(roomCountBox.Value), Convert.ToInt32(floorBox.Value), porchBox.Checked, elevatorBox.Checked);
            AirBNE.items.Add(apartment);
            MessageBox.Show("Apartment Created ");
        }

        private void descriptionBox_Enter(object sender, EventArgs e)
        {
            if(descriptionBox.Text== "Enter Description...")
                descriptionBox.Text = "";
        }

        private void descriptionBox_Leave(object sender, EventArgs e)
        {
            if (descriptionBox.Text == "")
                descriptionBox.Text = "Enter Description...";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ItemChoice form = new ItemChoice();
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
