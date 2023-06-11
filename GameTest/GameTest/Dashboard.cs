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

  


    public partial class Dashboard : Form
    {

        

        bool registred = false;

        public bool Registered { get; set; }
        public bool opened { get; set; }



        public Dashboard()
        {
            InitializeComponent();
            WellcomeTextBox.Visible = false;
            btnPlay.Visible = false;
        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
          

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!opened)
            {
                btnPlay.Visible = false;
                WellcomeTextBox.Visible = false;
                opened = true;
                About myAbout = new About(this);
                myAbout.Show();
                myAbout.MdiParent = this;
                LayoutMdi(MdiLayout.TileVertical);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void signInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           

            if (!opened)
            {
                opened = true;
                SignIn mySignIn = new SignIn(this);
                btnPlay.Visible = false;
                WellcomeTextBox.Visible = false;
                mySignIn.Show();
                mySignIn.MdiParent = this;
                LayoutMdi(MdiLayout.TileVertical);
                
            }
        }

        public void ShowWellcom()
        {
            WellcomeTextBox.Visible = true;
        }

        public void WellcomeText(string userName, string nickName)
        {
            WellcomeTextBox.Text = $"Welcome {userName} the {nickName}, click on Play to start the game";
        }

        public void ShowPlayBtn()
        {
            btnPlay.Visible = true;

        }

        public void OpenSignUpPage(SignIn mySignIn)
        {
           
                SignUp mySignUp = new SignUp(this);
                btnPlay.Visible = false;
                WellcomeTextBox.Visible = false;
                mySignUp.Show();
                mySignUp.MdiParent = this;
                LayoutMdi(MdiLayout.TileVertical);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game myGame = new Game();
            myGame.StartPosition = FormStartPosition.CenterParent;
            myGame.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opened)
            {
                SignUp mySignUp = new SignUp(this);
                btnPlay.Visible = false;
                WellcomeTextBox.Visible = false;
                mySignUp.Show();
                mySignUp.MdiParent = this;
                LayoutMdi(MdiLayout.TileVertical);
            }
        }
    }
}

