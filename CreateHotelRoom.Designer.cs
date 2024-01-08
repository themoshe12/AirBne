namespace OOP_Project
{
    partial class CreateHotelRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHotelRoom));
            this.wifiBox = new System.Windows.Forms.CheckBox();
            this.poolBox = new System.Windows.Forms.CheckBox();
            this.zipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.roomNumberBox = new System.Windows.Forms.NumericUpDown();
            this.residentsBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.petsBox = new System.Windows.Forms.CheckBox();
            this.createBox = new System.Windows.Forms.Button();
            this.hotelNameBox = new System.Windows.Forms.TextBox();
            this.gymBox = new System.Windows.Forms.CheckBox();
            this.hotelGrade = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPenion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // wifiBox
            // 
            this.wifiBox.AutoSize = true;
            this.wifiBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.wifiBox.Location = new System.Drawing.Point(6, 129);
            this.wifiBox.Margin = new System.Windows.Forms.Padding(4);
            this.wifiBox.Name = "wifiBox";
            this.wifiBox.Size = new System.Drawing.Size(119, 19);
            this.wifiBox.TabIndex = 25;
            this.wifiBox.Text = "Is There Wifi?";
            this.wifiBox.UseVisualStyleBackColor = true;
            // 
            // poolBox
            // 
            this.poolBox.AutoSize = true;
            this.poolBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.poolBox.Location = new System.Drawing.Point(6, 82);
            this.poolBox.Margin = new System.Windows.Forms.Padding(4);
            this.poolBox.Name = "poolBox";
            this.poolBox.Size = new System.Drawing.Size(136, 19);
            this.poolBox.TabIndex = 24;
            this.poolBox.Text = "Is There A Pool?";
            this.poolBox.UseVisualStyleBackColor = true;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.zipCodeBox.Location = new System.Drawing.Point(4, 292);
            this.zipCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.zipCodeBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(359, 21);
            this.zipCodeBox.TabIndex = 23;
            // 
            // roomNumberBox
            // 
            this.roomNumberBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.roomNumberBox.Location = new System.Drawing.Point(4, 211);
            this.roomNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomNumberBox.Name = "roomNumberBox";
            this.roomNumberBox.Size = new System.Drawing.Size(359, 21);
            this.roomNumberBox.TabIndex = 21;
            // 
            // residentsBox
            // 
            this.residentsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.residentsBox.Location = new System.Drawing.Point(4, 169);
            this.residentsBox.Margin = new System.Windows.Forms.Padding(4);
            this.residentsBox.Name = "residentsBox";
            this.residentsBox.Size = new System.Drawing.Size(359, 21);
            this.residentsBox.TabIndex = 20;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(4, 123);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(359, 21);
            this.priceBox.TabIndex = 19;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionBox.Location = new System.Drawing.Point(4, 373);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(359, 45);
            this.descriptionBox.TabIndex = 18;
            this.descriptionBox.Text = "Enter Description...";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addressBox.Location = new System.Drawing.Point(4, 85);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(359, 21);
            this.addressBox.TabIndex = 17;
            this.addressBox.Text = "Enter Address...";
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // petsBox
            // 
            this.petsBox.AutoSize = true;
            this.petsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.petsBox.Location = new System.Drawing.Point(6, 36);
            this.petsBox.Margin = new System.Windows.Forms.Padding(4);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(145, 19);
            this.petsBox.TabIndex = 16;
            this.petsBox.Text = "Are Pets Allowed?";
            this.petsBox.UseVisualStyleBackColor = true;
            // 
            // createBox
            // 
            this.createBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.createBox.Location = new System.Drawing.Point(629, 467);
            this.createBox.Margin = new System.Windows.Forms.Padding(4);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(186, 61);
            this.createBox.TabIndex = 15;
            this.createBox.Text = "Add Hotel Room";
            this.createBox.UseVisualStyleBackColor = true;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            // 
            // hotelNameBox
            // 
            this.hotelNameBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.hotelNameBox.Location = new System.Drawing.Point(4, 41);
            this.hotelNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.hotelNameBox.Name = "hotelNameBox";
            this.hotelNameBox.Size = new System.Drawing.Size(359, 21);
            this.hotelNameBox.TabIndex = 29;
            this.hotelNameBox.Text = "Enter Hotel Name...";
            this.hotelNameBox.Enter += new System.EventHandler(this.hotelNameBox_Enter);
            this.hotelNameBox.Leave += new System.EventHandler(this.hotelNameBox_Leave);
            // 
            // gymBox
            // 
            this.gymBox.AutoSize = true;
            this.gymBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gymBox.Location = new System.Drawing.Point(6, 178);
            this.gymBox.Margin = new System.Windows.Forms.Padding(4);
            this.gymBox.Name = "gymBox";
            this.gymBox.Size = new System.Drawing.Size(138, 19);
            this.gymBox.TabIndex = 30;
            this.gymBox.Text = "Is There A Gym?";
            this.gymBox.UseVisualStyleBackColor = true;
            // 
            // hotelGrade
            // 
            this.hotelGrade.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.hotelGrade.Location = new System.Drawing.Point(4, 335);
            this.hotelGrade.Margin = new System.Windows.Forms.Padding(4);
            this.hotelGrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hotelGrade.Name = "hotelGrade";
            this.hotelGrade.Size = new System.Drawing.Size(359, 21);
            this.hotelGrade.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.petsBox);
            this.groupBox1.Controls.Add(this.poolBox);
            this.groupBox1.Controls.Add(this.gymBox);
            this.groupBox1.Controls.Add(this.wifiBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(970, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(261, 217);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxPenion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hotelNameBox);
            this.groupBox2.Controls.Add(this.addressBox);
            this.groupBox2.Controls.Add(this.hotelGrade);
            this.groupBox2.Controls.Add(this.descriptionBox);
            this.groupBox2.Controls.Add(this.priceBox);
            this.groupBox2.Controls.Add(this.zipCodeBox);
            this.groupBox2.Controls.Add(this.residentsBox);
            this.groupBox2.Controls.Add(this.roomNumberBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(211, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(706, 424);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register Hotel Room";
            // 
            // comboBoxPenion
            // 
            this.comboBoxPenion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxPenion.FormattingEnabled = true;
            this.comboBoxPenion.Items.AddRange(new object[] {
            "Only Breakfast",
            "Breakfast and Dinner",
            "Full Pension"});
            this.comboBoxPenion.Location = new System.Drawing.Point(4, 250);
            this.comboBoxPenion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPenion.Name = "comboBoxPenion";
            this.comboBoxPenion.Size = new System.Drawing.Size(360, 21);
            this.comboBoxPenion.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(369, 336);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Hotel Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(369, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(369, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Pension level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(369, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(369, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Max. Capacity Of Residents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(367, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Enter price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 558);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OOP_Project.Properties.Resources.breaking_and_entering_german_logo_sm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(84, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 553);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 577);
            this.panel2.TabIndex = 37;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::OOP_Project.Properties.Resources.breaking_and_entering_german_logo_sm;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(80, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 576);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.BackgroundImage = global::OOP_Project.Properties.Resources.BackArrowWhite;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(12, 16);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(61, 55);
            this.backButton.TabIndex = 17;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateHotelRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1296, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateHotelRoom";
            this.Text = "Create A Hotel Room!";
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox wifiBox;
        private System.Windows.Forms.CheckBox poolBox;
        private System.Windows.Forms.NumericUpDown zipCodeBox;
        private System.Windows.Forms.NumericUpDown roomNumberBox;
        private System.Windows.Forms.NumericUpDown residentsBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox petsBox;
        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.TextBox hotelNameBox;
        private System.Windows.Forms.CheckBox gymBox;
        private System.Windows.Forms.NumericUpDown hotelGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPenion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button backButton;
    }
}