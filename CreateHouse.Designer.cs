namespace OOP_Project
{
    partial class CreateHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateHouse));
            this.wifiBox = new System.Windows.Forms.CheckBox();
            this.poolBox = new System.Windows.Forms.CheckBox();
            this.zipCodeBox = new System.Windows.Forms.NumericUpDown();
            this.roomCountBox = new System.Windows.Forms.NumericUpDown();
            this.residentsBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.petsBox = new System.Windows.Forms.CheckBox();
            this.createBox = new System.Windows.Forms.Button();
            this.floorsBox = new System.Windows.Forms.NumericUpDown();
            this.yardBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wifiBox
            // 
            this.wifiBox.AutoSize = true;
            this.wifiBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.wifiBox.Location = new System.Drawing.Point(29, 122);
            this.wifiBox.Margin = new System.Windows.Forms.Padding(5);
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
            this.poolBox.Location = new System.Drawing.Point(29, 85);
            this.poolBox.Margin = new System.Windows.Forms.Padding(5);
            this.poolBox.Name = "poolBox";
            this.poolBox.Size = new System.Drawing.Size(136, 19);
            this.poolBox.TabIndex = 24;
            this.poolBox.Text = "Is There A Pool?";
            this.poolBox.UseVisualStyleBackColor = true;
            // 
            // zipCodeBox
            // 
            this.zipCodeBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.zipCodeBox.Location = new System.Drawing.Point(6, 261);
            this.zipCodeBox.Margin = new System.Windows.Forms.Padding(5);
            this.zipCodeBox.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.zipCodeBox.Name = "zipCodeBox";
            this.zipCodeBox.Size = new System.Drawing.Size(446, 21);
            this.zipCodeBox.TabIndex = 23;
            // 
            // roomCountBox
            // 
            this.roomCountBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.roomCountBox.Location = new System.Drawing.Point(6, 181);
            this.roomCountBox.Margin = new System.Windows.Forms.Padding(5);
            this.roomCountBox.Name = "roomCountBox";
            this.roomCountBox.Size = new System.Drawing.Size(446, 21);
            this.roomCountBox.TabIndex = 21;
            // 
            // residentsBox
            // 
            this.residentsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.residentsBox.Location = new System.Drawing.Point(6, 141);
            this.residentsBox.Margin = new System.Windows.Forms.Padding(5);
            this.residentsBox.Name = "residentsBox";
            this.residentsBox.Size = new System.Drawing.Size(446, 21);
            this.residentsBox.TabIndex = 20;
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.priceBox.ForeColor = System.Drawing.Color.Black;
            this.priceBox.Location = new System.Drawing.Point(6, 101);
            this.priceBox.Margin = new System.Windows.Forms.Padding(5);
            this.priceBox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(446, 21);
            this.priceBox.TabIndex = 19;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.descriptionBox.Location = new System.Drawing.Point(8, 301);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(5);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(444, 84);
            this.descriptionBox.TabIndex = 18;
            this.descriptionBox.Text = "Enter Description...";
            this.descriptionBox.Enter += new System.EventHandler(this.descriptionBox_Enter);
            this.descriptionBox.Leave += new System.EventHandler(this.descriptionBox_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.addressBox.Location = new System.Drawing.Point(6, 61);
            this.addressBox.Margin = new System.Windows.Forms.Padding(5);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(444, 21);
            this.addressBox.TabIndex = 17;
            this.addressBox.Text = "Enter Address...";
            this.addressBox.Enter += new System.EventHandler(this.addressBox_Enter);
            this.addressBox.Leave += new System.EventHandler(this.addressBox_Leave);
            // 
            // petsBox
            // 
            this.petsBox.AutoSize = true;
            this.petsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.petsBox.Location = new System.Drawing.Point(29, 48);
            this.petsBox.Margin = new System.Windows.Forms.Padding(5);
            this.petsBox.Name = "petsBox";
            this.petsBox.Size = new System.Drawing.Size(145, 19);
            this.petsBox.TabIndex = 16;
            this.petsBox.Text = "Are Pets Allowed?";
            this.petsBox.UseVisualStyleBackColor = true;
            // 
            // createBox
            // 
            this.createBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.createBox.Location = new System.Drawing.Point(672, 466);
            this.createBox.Margin = new System.Windows.Forms.Padding(5);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(201, 59);
            this.createBox.TabIndex = 15;
            this.createBox.Text = "Add House";
            this.createBox.UseVisualStyleBackColor = true;
            this.createBox.Click += new System.EventHandler(this.createBox_Click);
            // 
            // floorsBox
            // 
            this.floorsBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.floorsBox.Location = new System.Drawing.Point(6, 221);
            this.floorsBox.Margin = new System.Windows.Forms.Padding(5);
            this.floorsBox.Name = "floorsBox";
            this.floorsBox.Size = new System.Drawing.Size(446, 21);
            this.floorsBox.TabIndex = 22;
            // 
            // yardBox
            // 
            this.yardBox.AutoSize = true;
            this.yardBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.yardBox.Location = new System.Drawing.Point(29, 160);
            this.yardBox.Margin = new System.Windows.Forms.Padding(5);
            this.yardBox.Name = "yardBox";
            this.yardBox.Size = new System.Drawing.Size(138, 19);
            this.yardBox.TabIndex = 26;
            this.yardBox.Text = "Is There A Yard?";
            this.yardBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.petsBox);
            this.groupBox2.Controls.Add(this.poolBox);
            this.groupBox2.Controls.Add(this.yardBox);
            this.groupBox2.Controls.Add(this.wifiBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(942, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(273, 218);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.priceBox);
            this.groupBox1.Controls.Add(this.zipCodeBox);
            this.groupBox1.Controls.Add(this.residentsBox);
            this.groupBox1.Controls.Add(this.floorsBox);
            this.groupBox1.Controls.Add(this.roomCountBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(212, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(687, 395);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register House";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(456, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Zip Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(456, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "How Many Floors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(456, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "How many Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(456, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Max. Capacity of Residents";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(456, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 576);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OOP_Project.Properties.Resources.breaking_and_entering_german_logo_sm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(86, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 574);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImage = global::OOP_Project.Properties.Resources.BackArrowWhite;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 55);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1296, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.createBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create A House!";
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorsBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox wifiBox;
        private System.Windows.Forms.CheckBox poolBox;
        private System.Windows.Forms.NumericUpDown zipCodeBox;
        private System.Windows.Forms.NumericUpDown roomCountBox;
        private System.Windows.Forms.NumericUpDown residentsBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.CheckBox petsBox;
        private System.Windows.Forms.Button createBox;
        private System.Windows.Forms.NumericUpDown floorsBox;
        private System.Windows.Forms.CheckBox yardBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}