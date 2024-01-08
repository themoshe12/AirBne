namespace OOP_Project
{
    partial class CreateApartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateApartment));
            this.createBox = new System.Windows.Forms.Button();
            this.petsBox = new System.Windows.Forms.CheckBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.residentsBox = new System.Windows.Forms.NumericUpDown();
            this.roomCountBox = new System.Windows.Forms.NumericUpDown();
            this.floorBox = new System.Windows.Forms.NumericUpDown();
            this.zipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.poolBox = new System.Windows.Forms.CheckBox();
            this.wifiBox = new System.Windows.Forms.CheckBox();
            this.elevatorBox = new System.Windows.Forms.CheckBox();
            this.porchBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createBox
            // 
            this.createBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.createBox.Location = new System.Drawing.Point(649, 501);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(186, 61);
            this.createBox.TabIndex = 0;
            this.createBox.Text = "Add Apartment";
            this.createBox.UseVisualStyleBackColor = true;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            // 
            // petsBox
            // 
            this.petsBox.AutoSize = true;
            this.petsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsBox.Location = new System.Drawing.Point(5, 36);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(145, 19);
            this.petsBox.TabIndex = 1;
            this.petsBox.Text = "Are Pets Allowed?";
            this.petsBox.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addressBox.Location = new System.Drawing.Point(10, 36);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(446, 21);
            this.addressBox.TabIndex = 3;
            this.addressBox.Text = "Enter Address...";
            this.addressBox.Click += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionBox.Location = new System.Drawing.Point(10, 388);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(446, 58);
            this.descriptionBox.TabIndex = 4;
            this.descriptionBox.Text = "Enter Description...";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(10, 96);
            this.priceBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(446, 21);
            this.priceBox.TabIndex = 5;
            // 
            // residentsBox
            // 
            this.residentsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.residentsBox.Location = new System.Drawing.Point(10, 159);
            this.residentsBox.Name = "residentsBox";
            this.residentsBox.Size = new System.Drawing.Size(446, 21);
            this.residentsBox.TabIndex = 6;
            // 
            // roomCountBox
            // 
            this.roomCountBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.roomCountBox.Location = new System.Drawing.Point(10, 221);
            this.roomCountBox.Name = "roomCountBox";
            this.roomCountBox.Size = new System.Drawing.Size(446, 21);
            this.roomCountBox.TabIndex = 7;
            // 
            // floorBox
            // 
            this.floorBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.floorBox.Location = new System.Drawing.Point(10, 286);
            this.floorBox.Name = "floorBox";
            this.floorBox.Size = new System.Drawing.Size(446, 21);
            this.floorBox.TabIndex = 8;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.zipCodeBox.Location = new System.Drawing.Point(10, 344);
            this.zipCodeBox.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(446, 21);
            this.zipCodeBox.TabIndex = 9;
            // 
            // poolBox
            // 
            this.poolBox.AutoSize = true;
            this.poolBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.poolBox.Location = new System.Drawing.Point(5, 82);
            this.poolBox.Name = "poolBox";
            this.poolBox.Size = new System.Drawing.Size(136, 19);
            this.poolBox.TabIndex = 10;
            this.poolBox.Text = "Is There A Pool?";
            this.poolBox.UseVisualStyleBackColor = true;
            // 
            // wifiBox
            // 
            this.wifiBox.AutoSize = true;
            this.wifiBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.wifiBox.Location = new System.Drawing.Point(5, 131);
            this.wifiBox.Name = "wifiBox";
            this.wifiBox.Size = new System.Drawing.Size(119, 19);
            this.wifiBox.TabIndex = 11;
            this.wifiBox.Text = "Is There Wifi?";
            this.wifiBox.UseVisualStyleBackColor = true;
            // 
            // elevatorBox
            // 
            this.elevatorBox.AutoSize = true;
            this.elevatorBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.elevatorBox.Location = new System.Drawing.Point(5, 185);
            this.elevatorBox.Name = "elevatorBox";
            this.elevatorBox.Size = new System.Drawing.Size(171, 19);
            this.elevatorBox.TabIndex = 12;
            this.elevatorBox.Text = "Is There An Elevator?";
            this.elevatorBox.UseVisualStyleBackColor = true;
            // 
            // porchBox
            // 
            this.porchBox.AutoSize = true;
            this.porchBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.porchBox.Location = new System.Drawing.Point(5, 238);
            this.porchBox.Name = "porchBox";
            this.porchBox.Size = new System.Drawing.Size(145, 19);
            this.porchBox.TabIndex = 13;
            this.porchBox.Text = "Is There A Porch?";
            this.porchBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.zipCodeBox);
            this.groupBox1.Controls.Add(this.residentsBox);
            this.groupBox1.Controls.Add(this.floorBox);
            this.groupBox1.Controls.Add(this.roomCountBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(175, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(809, 451);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Apartment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(470, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "How many Rooms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(470, 345);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zip Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(470, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "How many Floors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(206, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(202, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(470, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Max. Capacity Of Residents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(469, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.petsBox);
            this.groupBox2.Controls.Add(this.poolBox);
            this.groupBox2.Controls.Add(this.wifiBox);
            this.groupBox2.Controls.Add(this.porchBox);
            this.groupBox2.Controls.Add(this.elevatorBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(1022, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(236, 275);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DimGray;
            this.backButton.BackgroundImage = global::OOP_Project.Properties.Resources.BackArrowWhite;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(9, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(46, 45);
            this.backButton.TabIndex = 17;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 578);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OOP_Project.Properties.Resources.breaking_and_entering_german_logo_sm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(63, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 576);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CreateApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1296, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateApartment";
            this.Text = "Add An Apartment!";
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.CheckBox petsBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.NumericUpDown residentsBox;
        private System.Windows.Forms.NumericUpDown roomCountBox;
        private System.Windows.Forms.NumericUpDown floorBox;
        private System.Windows.Forms.NumericUpDown zipCodeBox;
        private System.Windows.Forms.CheckBox poolBox;
        private System.Windows.Forms.CheckBox wifiBox;
        private System.Windows.Forms.CheckBox elevatorBox;
        private System.Windows.Forms.CheckBox porchBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}