using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualiser_v1
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void btnIncOrDes_Click(object sender, EventArgs e)
        {
            if(btnIncOrDes.Text == "Tăng")
            {
                btnIncOrDes.Text = "Giảm";
            }
            else
            {
                btnIncOrDes.Text = "Tăng";
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (btnLanguage.Text == "Tiếng Việt")
            {
                btnLanguage.Text = "English";
            }
            else
            {
                btnLanguage.Text = "Tiếng Việt";
            }
        }

        private void trbSpeed_Scroll(object sender, EventArgs e)
        {
            SpeedShowChange();
        }
        public void SpeedShowChange()
        {
            switch (trbSpeed.Value)
            {
                case 0:
                    lblSpeedShow.Text = "0.1x";
                    break;
                case 1:
                    lblSpeedShow.Text = "0.25x";
                    break;
                case 2:
                    lblSpeedShow.Text = "0.5x";
                    break;
                case 3:
                    lblSpeedShow.Text = "0.75x";
                    break;
                case 4:
                    lblSpeedShow.Text = "1x";
                    break;
                case 5:
                    lblSpeedShow.Text = "2x";
                    break;
                case 6:
                    lblSpeedShow.Text = "3x";
                    break;
                case 7:
                    lblSpeedShow.Text = "4x";
                    break;
                case 8:
                    lblSpeedShow.Text = "5x";
                    break;
            }
        }
    }
}
