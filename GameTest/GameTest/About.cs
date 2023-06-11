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
    public partial class About : Form
    {
        Dashboard myDash1;

        public Dashboard Mydash1 { get; set; }

        public About(Dashboard dashName)
        {
            myDash1 = dashName;
            BackgroundImage = Properties.Resources.About;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            myDash1.opened = false;
            myDash1.ShowPlayBtn();
            myDash1.ShowWellcom();
        }
    }
}
