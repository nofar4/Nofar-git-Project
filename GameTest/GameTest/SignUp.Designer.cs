namespace GameTest
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.userIdSignUp = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.Label();
            this.userIdSignUpTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.ErrorPic = new System.Windows.Forms.PictureBox();
            this.RegisterSignUp = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nickName = new System.Windows.Forms.Label();
            this.NickNameError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NickNameError)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdSignUp
            // 
            this.userIdSignUp.BackColor = System.Drawing.Color.Transparent;
            this.userIdSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdSignUp.ForeColor = System.Drawing.Color.Black;
            this.userIdSignUp.Location = new System.Drawing.Point(478, 319);
            this.userIdSignUp.Name = "userIdSignUp";
            this.userIdSignUp.Size = new System.Drawing.Size(90, 28);
            this.userIdSignUp.TabIndex = 0;
            this.userIdSignUp.Text = "ID:";
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.Transparent;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.Location = new System.Drawing.Point(478, 395);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(142, 28);
            this.NameBox.TabIndex = 1;
            this.NameBox.Text = "Name:";
            // 
            // userIdSignUpTxt
            // 
            this.userIdSignUpTxt.BackColor = System.Drawing.Color.LightCyan;
            this.userIdSignUpTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIdSignUpTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userIdSignUpTxt.Location = new System.Drawing.Point(483, 359);
            this.userIdSignUpTxt.Name = "userIdSignUpTxt";
            this.userIdSignUpTxt.Size = new System.Drawing.Size(148, 20);
            this.userIdSignUpTxt.TabIndex = 2;
            this.userIdSignUpTxt.TextChanged += new System.EventHandler(this.userIdSignUpTxt_TxtChanged);
            this.userIdSignUpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userIdSignUpTxt_KeyPress);
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.Color.LightCyan;
            this.userNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userNameTxt.Location = new System.Drawing.Point(483, 438);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(148, 20);
            this.userNameTxt.TabIndex = 3;
            // 
            // ErrorPic
            // 
            this.ErrorPic.BackColor = System.Drawing.Color.Transparent;
            this.ErrorPic.BackgroundImage = global::GameTest.Properties.Resources.Error_User;
            this.ErrorPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ErrorPic.Location = new System.Drawing.Point(56, 324);
            this.ErrorPic.Name = "ErrorPic";
            this.ErrorPic.Size = new System.Drawing.Size(396, 134);
            this.ErrorPic.TabIndex = 4;
            this.ErrorPic.TabStop = false;
            // 
            // RegisterSignUp
            // 
            this.RegisterSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSignUp.ForeColor = System.Drawing.Color.Black;
            this.RegisterSignUp.Location = new System.Drawing.Point(483, 489);
            this.RegisterSignUp.Name = "RegisterSignUp";
            this.RegisterSignUp.Size = new System.Drawing.Size(137, 38);
            this.RegisterSignUp.TabIndex = 5;
            this.RegisterSignUp.Text = "Sign Up";
            this.RegisterSignUp.UseVisualStyleBackColor = true;
            this.RegisterSignUp.Click += new System.EventHandler(this.RegisterSignUp_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightCyan;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(671, 437);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select your nick name";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nickName
            // 
            this.nickName.BackColor = System.Drawing.Color.Transparent;
            this.nickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickName.ForeColor = System.Drawing.Color.Black;
            this.nickName.Location = new System.Drawing.Point(675, 395);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(125, 37);
            this.nickName.TabIndex = 7;
            this.nickName.Text = "Nick Name:";
            // 
            // NickNameError
            // 
            this.NickNameError.BackColor = System.Drawing.Color.Transparent;
            this.NickNameError.BackgroundImage = global::GameTest.Properties.Resources.NickName;
            this.NickNameError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NickNameError.Location = new System.Drawing.Point(795, 282);
            this.NickNameError.Name = "NickNameError";
            this.NickNameError.Size = new System.Drawing.Size(313, 149);
            this.NickNameError.TabIndex = 8;
            this.NickNameError.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GameTest.Properties.Resources.SignUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 552);
            this.Controls.Add(this.NickNameError);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RegisterSignUp);
            this.Controls.Add(this.ErrorPic);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.userIdSignUpTxt);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.userIdSignUp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NickNameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdSignUp;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.TextBox userIdSignUpTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.PictureBox ErrorPic;
        private System.Windows.Forms.Button RegisterSignUp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label nickName;
        private System.Windows.Forms.PictureBox NickNameError;
    }
}