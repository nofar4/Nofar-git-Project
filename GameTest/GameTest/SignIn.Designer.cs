namespace GameTest
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.label1 = new System.Windows.Forms.Label();
            this.UserIDTxtBox = new System.Windows.Forms.TextBox();
            this.ErrorPic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(800, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please insert your ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserIDTxtBox
            // 
            this.UserIDTxtBox.BackColor = System.Drawing.Color.LightCyan;
            this.UserIDTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIDTxtBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDTxtBox.Location = new System.Drawing.Point(810, 372);
            this.UserIDTxtBox.Name = "UserIDTxtBox";
            this.UserIDTxtBox.Size = new System.Drawing.Size(205, 31);
            this.UserIDTxtBox.TabIndex = 1;
            this.UserIDTxtBox.TextChanged += new System.EventHandler(this.UserIDTxtBox_TextChanged);
            this.UserIDTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserIDTxtBox_KeyPress);
            // 
            // ErrorPic
            // 
            this.ErrorPic.BackColor = System.Drawing.Color.Transparent;
            this.ErrorPic.BackgroundImage = global::GameTest.Properties.Resources.Error_User;
            this.ErrorPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ErrorPic.Location = new System.Drawing.Point(761, 431);
            this.ErrorPic.Name = "ErrorPic";
            this.ErrorPic.Size = new System.Drawing.Size(396, 134);
            this.ErrorPic.TabIndex = 2;
            this.ErrorPic.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1019, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.Black;
            this.RegisterBtn.Location = new System.Drawing.Point(810, 334);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(298, 31);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GameTest.Properties.Resources.SignIn_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ErrorPic);
            this.Controls.Add(this.UserIDTxtBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserIDTxtBox;
        private System.Windows.Forms.PictureBox ErrorPic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegisterBtn;
    }
}