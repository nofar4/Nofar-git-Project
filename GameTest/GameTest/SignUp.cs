using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTest
{
    public partial class SignUp : Form
    {
        Dashboard myDash1;
        SignIn mySignIn;
        User u;



        bool txtChanged = false,
             registred = false,
             nickNameSelected = false;


        string[] nickNames = new string[] {"Kraken", "Big Papa", "Mad Dog", "Psycho", "Ranger", "Cobra", "Reaper", "Diablo", "Scar",
                                              "Dracula", "Dragon", "Skull Crusher", "Slasher", "Gunner", "Killer","Lightning", "Bullet-Proof"};



        public SignUp(Dashboard dashName)
        {
            InitializeComponent();
            myDash1 = dashName;
            mySignIn = new SignIn(dashName);
            userIdSignUpTxt.MaxLength = 9;
            ErrorPic.Visible = false;
            NickNameError.Visible = false;
            myDash1.opened = true;
   



        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void RegisterSignUp_Click(object sender, EventArgs e)
        {
            int counter = 0;


            for (int i = 0; i < userIdSignUpTxt.Text.Length; i++)
            {
                counter++;
            }
            if (counter < 9)
            {
                ErrorPic.Visible = true;
                txtChanged = true;
            }
            if (!nickNameSelected)
            {
                NickNameError.Visible = true;
            }
            else if (counter == 9 && nickNameSelected)
            {
                u = new User(int.Parse(userIdSignUpTxt.Text), userNameTxt.Text, comboBox1.Text);
                registred = true;
                Close();
            }
        }

        private void userIdSignUpTxt_TxtChanged(object sender, EventArgs e)
        {
            if (txtChanged)
                ErrorPic.Visible = false;
        }

        private void userIdSignUpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nickNameSelected = true;
            NickNameError.Visible = false;
        }

       

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = nickNames;
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(registred)
            {
                myDash1.WellcomeText(u.Name,u.NickName);
                myDash1.ShowPlayBtn();
                myDash1.ShowWellcom();

            }
            myDash1.opened = false;

        }

    }
}
