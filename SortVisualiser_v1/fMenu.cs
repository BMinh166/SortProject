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

        /// <summary>
        /// Thực thi chức năng của cái button ở tabpage Cài Đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Thực thi chức năng của cái button ở tabpage Tùy Chỉnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        //Tăng giảm kích thước Node
        private void btnNodeSizeDes_Click(object sender, EventArgs e)
        {
            int term = Int32.Parse(btnNodeSizeChange.Text);
            if (term > 1)
                term--;
            btnNodeSizeChange.Text = term.ToString();
        }

        private void btnNodeSizeInc_Click(object sender, EventArgs e)
        {
            int term = Int32.Parse(btnNodeSizeChange.Text);
            if (term < 50)
                term++;
            btnNodeSizeChange.Text = term.ToString();
        }

        //Tăng giảm khoảng cách giữa cách Node
        private void btnNodeSpaceDes_Click(object sender, EventArgs e)
        {
            int term = Int32.Parse(btnNodeSpace.Text);
            if (term > 1)
                term--;
            btnNodeSpace.Text = term.ToString();
        }

        private void btnNodeSpaceInc_Click(object sender, EventArgs e)
        {
            int term = Int32.Parse(btnNodeSpace.Text);
            if (term < 50)
                term++;
            btnNodeSpace.Text = term.ToString();
        }

        private void btnNodeBackColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnNodeBackColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnNodeChoosingColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnNodeChoosingColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnNodeSortedColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnNodeSortedColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
