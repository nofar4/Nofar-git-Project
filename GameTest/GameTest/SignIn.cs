using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameTest
{
    public partial class SignIn : Form
    {
        Dashboard myDash1;




        bool txtChanged = false;





        public Dashboard Mydash1 { get; set; }

        public SignIn(Dashboard dashName)
        {
            InitializeComponent();
            myDash1 = dashName;
            UserIDTxtBox.MaxLength = 9;
            ErrorPic.Visible = false;
            RegisterBtn.Visible = false;
        }


        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            myDash1.opened = false;


        }

        private void UserIDTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void GoBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            bool appeared = false;


            for (int i = 0; i < UserIDTxtBox.Text.Length; i++)
            {
                counter++;
            }
            if (counter < 9)
            {
                ErrorPic.Visible = true;
                txtChanged = true;
            }
            else
            {
                string directory = Environment.CurrentDirectory;
                //string path = @"C:\Users\figma\source\repos\GameTest\GameTest\Resources\Users.txt";
                string path = directory + @"..\..\..\..\..\GameTest\GameTest\Resources\Users.txt";
                StreamReader sr = File.OpenText(path);
                {
                    string[] lines = File.ReadAllLines(path);
                    bool isMatch = false;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains(UserIDTxtBox.Text))
                        {
                            string source = lines[i];
                            string name = getBetween(source, "Name: ", ",");
                            string nickName = getBetween(source, "NickName: ", ",");

                            sr.Close();
                            myDash1.opened = false;
                            Close();
                            myDash1.WellcomeText(name,nickName);
                            myDash1.ShowPlayBtn();
                            myDash1.ShowWellcom();
                            isMatch = true;
                        }
                    }
                    if (!isMatch)
                    {
                        sr.Close();
                        RegisterBtn.Visible = true;
                    }
                }


                //for (int i = 0; i < userID.Length; i++)
                //{
                //    if (userID[i] != 0)
                //    {
                //        if (int.Parse(UserIDTxtBox.Text) == userID[i])
                //        {
                //            
                //        }
                //    }
                //    else
                //    {
                //        
                //    }

                //}
            }
        }

        private void UserIDTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (txtChanged)
                ErrorPic.Visible = false;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Close();
            myDash1.OpenSignUpPage(this);

        }

        static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }


    }
}
