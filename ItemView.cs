using OOP_Project.Properties;
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
    public partial class ItemView : Form
    {
        public ItemView()
        {
            InitializeComponent();
            foreach(User user in AirBNE.users)
            {
                if (user.Item != null)
                {
                    foreach(Rentable item in AirBNE.items)
                    {
                        if (user.Item.Id == item.Id)
                            item.Occupied = true;
                    }
                }
            }
            foreach (Rentable item in AirBNE.items)
            {
                renderButton(item);
            }
        }

        private void renderButton(Rentable item)
        {
            Button button = new Button();
            switch (item.GetType().Name)
            {
                case "Apartment":
                    button.BackgroundImage = Properties.Resources.Apartment;
                    break;
                case "House":
                    button.BackgroundImage = Properties.Resources.House;
                    break;
                case "HotelRoom":
                    button.BackgroundImage = Properties.Resources.Hotel;
                    break;
            }
            button.BackgroundImageLayout = ImageLayout.Stretch;
            button.TextAlign = ContentAlignment.TopCenter;
            button.TextImageRelation = TextImageRelation.TextBeforeImage;
            button.Name = Convert.ToString(item.Id);
            button.Size = new Size(225, 250);
            button.Text = item.getText();
            button.Click += new EventHandler(this.itemClick);
            itemContainer.Controls.Add(button);
        }
        private void itemClick(object sender, EventArgs e)
        {
            ItemInfo.itemID = Convert.ToInt32(((Control)sender).Name);
            ItemInfo form = new ItemInfo();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
            this.Close();
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            itemContainer.Controls.Clear();
            string name1 = "";
            string name2 = searchBox.Text.ToLower();
            foreach (Rentable item in AirBNE.items)
            {
                name1 = item.Address.ToLower();
                if (name1.Contains(name2))
                    renderButton(item);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            itemContainer.Controls.Clear();
            foreach (Rentable item in AirBNE.items)
            {
                renderButton(item);
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

        private void maxPriceBox_ValueChanged(object sender, EventArgs e)
        {
            itemContainer.Controls.Clear();
            double tmp =Convert.ToDouble(maxPriceBox.Value);
            if (maxPriceBox.Value == 0)
            {
                foreach (Rentable item in AirBNE.items)
                {
                    renderButton(item);
                }
                return;
            }
            foreach(Rentable item in AirBNE.items)
            {
                if (item.Price <= tmp)
                {
                    renderButton(item);
                }
            }
        }
    }
}
