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
    public partial class Order : Form
    {
        public static Rentable item= null;
        public Order()
        {
            InitializeComponent();
            if (AirBNE.user.Item != null)
            {
                item=AirBNE.user.Item;
                label1.Text = item.toString();
            }
            else
            {
                item=null;
                label1.Text = "You Still Didnt Order Anything...";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                MessageBox.Show("Your Order List Is Empty");
            }
            else
            {
                foreach (Rentable item in AirBNE.items)
                {
                    if (Order.item.Id == item.Id)
                    {
                        item.Occupied = false;
                        label1.Text = "Empty";
                        MessageBox.Show("Check out Complete");
                        break;
                    }
                }
                item = null;
                AirBNE.user.Item = null;
            }
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
