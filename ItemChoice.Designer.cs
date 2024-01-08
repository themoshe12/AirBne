namespace OOP_Project
{
    partial class ItemChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemChoice));
            this.apartmentButton = new System.Windows.Forms.Button();
            this.hotelRoomButton = new System.Windows.Forms.Button();
            this.houseButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apartmentButton
            // 
            this.apartmentButton.BackgroundImage = global::OOP_Project.Properties.Resources.Apartment;
            this.apartmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apartmentButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apartmentButton.Location = new System.Drawing.Point(63, 12);
            this.apartmentButton.Name = "apartmentButton";
            this.apartmentButton.Size = new System.Drawing.Size(290, 406);
            this.apartmentButton.TabIndex = 3;
            this.apartmentButton.Text = "Apartment";
            this.apartmentButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.apartmentButton.UseVisualStyleBackColor = true;
            this.apartmentButton.Click += new System.EventHandler(this.apartmentButton_Click);
            // 
            // hotelRoomButton
            // 
            this.hotelRoomButton.BackgroundImage = global::OOP_Project.Properties.Resources.Hotel;
            this.hotelRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hotelRoomButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.hotelRoomButton.Location = new System.Drawing.Point(714, 12);
            this.hotelRoomButton.Name = "hotelRoomButton";
            this.hotelRoomButton.Size = new System.Drawing.Size(290, 406);
            this.hotelRoomButton.TabIndex = 5;
            this.hotelRoomButton.Text = "Hotel Room";
            this.hotelRoomButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotelRoomButton.UseVisualStyleBackColor = true;
            this.hotelRoomButton.Click += new System.EventHandler(this.hotelRoomButton_Click);
            // 
            // houseButton
            // 
            this.houseButton.BackColor = System.Drawing.Color.Red;
            this.houseButton.BackgroundImage = global::OOP_Project.Properties.Resources.House;
            this.houseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.houseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.houseButton.Location = new System.Drawing.Point(389, 12);
            this.houseButton.Name = "houseButton";
            this.houseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.houseButton.Size = new System.Drawing.Size(290, 406);
            this.houseButton.TabIndex = 4;
            this.houseButton.Text = "House";
            this.houseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.houseButton.UseVisualStyleBackColor = false;
            this.houseButton.Click += new System.EventHandler(this.houseButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::OOP_Project.Properties.Resources.BackArrow;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backButton.Location = new System.Drawing.Point(11, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 39);
            this.backButton.TabIndex = 18;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ItemChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1022, 434);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.apartmentButton);
            this.Controls.Add(this.hotelRoomButton);
            this.Controls.Add(this.houseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemChoice";
            this.Text = "Choose Item Type";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apartmentButton;
        private System.Windows.Forms.Button houseButton;
        private System.Windows.Forms.Button hotelRoomButton;
        private System.Windows.Forms.Button backButton;
    }
}