namespace OOP_Project
{
    partial class AirBNE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirBNE));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewItemsButton = new System.Windows.Forms.Button();
            this.addItemsButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::OOP_Project.Properties.Resources.BETransparentBlackLogocopy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(152, 172);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 267);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // viewItemsButton
            // 
            this.viewItemsButton.BackColor = System.Drawing.Color.DimGray;
            this.viewItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewItemsButton.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.viewItemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.viewItemsButton.Location = new System.Drawing.Point(79, 58);
            this.viewItemsButton.Name = "viewItemsButton";
            this.viewItemsButton.Size = new System.Drawing.Size(634, 41);
            this.viewItemsButton.TabIndex = 43;
            this.viewItemsButton.Text = "View Items";
            this.viewItemsButton.UseVisualStyleBackColor = false;
            this.viewItemsButton.Click += new System.EventHandler(this.itemViewButton_Click);
            // 
            // addItemsButton
            // 
            this.addItemsButton.BackColor = System.Drawing.Color.DimGray;
            this.addItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addItemsButton.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.addItemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.addItemsButton.Location = new System.Drawing.Point(79, 115);
            this.addItemsButton.Name = "addItemsButton";
            this.addItemsButton.Size = new System.Drawing.Size(634, 41);
            this.addItemsButton.TabIndex = 42;
            this.addItemsButton.Text = "Add Items";
            this.addItemsButton.UseVisualStyleBackColor = false;
            this.addItemsButton.Click += new System.EventHandler(this.itemChoiceButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.DimGray;
            this.orderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.orderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.orderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.orderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.orderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.orderButton.Location = new System.Drawing.Point(654, 201);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(93, 37);
            this.orderButton.TabIndex = 47;
            this.orderButton.Text = "My Order";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DimGray;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.registerButton.Location = new System.Drawing.Point(654, 266);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(93, 37);
            this.registerButton.TabIndex = 48;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeText.Cursor = System.Windows.Forms.Cursors.Default;
            this.welcomeText.Font = new System.Drawing.Font("Nirmala UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.welcomeText.Location = new System.Drawing.Point(307, 9);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(115, 30);
            this.welcomeText.TabIndex = 49;
            this.welcomeText.Text = "Welcome!";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DimGray;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.loginButton.Location = new System.Drawing.Point(654, 332);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(93, 37);
            this.loginButton.TabIndex = 50;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DimGray;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(0)))));
            this.logoutButton.Location = new System.Drawing.Point(654, 253);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(93, 37);
            this.logoutButton.TabIndex = 52;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AirBNE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewItemsButton);
            this.Controls.Add(this.addItemsButton);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AirBNE";
            this.Text = "AirBNE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewItemsButton;
        private System.Windows.Forms.Button addItemsButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
    }
}

