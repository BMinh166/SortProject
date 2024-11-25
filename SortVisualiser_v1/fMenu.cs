﻿using System;
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

        fManually fman;

        public fMenu()
        {
            InitializeComponent();
        }


        public event EventHandler<EventArgs> LanguageChange;
       

        /// <summary>
        /// Thực thi chức năng của cái button ở tabpage Cài Đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncOrDes_Click(object sender, EventArgs e)
        {
            if(fMain.isIncrease)
            {
                btnIncOrDes.Text = "Giảm";
                fMain.isIncrease = false;
            }
            else
            {
                btnIncOrDes.Text = "Tăng";
                fMain.isIncrease = true;
            }
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
                fman = new fManually();
                fman.ShowDialog();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (!fMain.isEnglish)
            {
                btnLanguage.Text = "English";
                fMain.isEnglish = true;
                LanguageChange?.Invoke(this, new EventArgs());
            }
            else
            {
                btnLanguage.Text = "Tiếng Việt";
                fMain.isEnglish = false;
                LanguageChange?.Invoke(this, new EventArgs());
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

        #region TabPage Tùy chỉnh
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


        //Thay đổi màu
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

        
        //Tùy chỉnh nhập tay kích thước Node
        private void btnNodeSizeChange_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Clicks == 2)
            {
                tbNodeSize.BringToFront();
                tbNodeSize.Focus();
            }
        }

        private void tbNodeSize_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                int number ;
                if(Int32.TryParse(tbNodeSize.Text, out number))
                {
                    if (number > 50)
                        tbNodeSize.Text = "50";
                    else if (number < 1)
                        tbNodeSize.Text = "1";
                    btnNodeSizeChange.Text = tbNodeSize.Text;
                }
                
                tbNodeSize.Text = "";
                tbNodeSize.SendToBack();
            }
        }

        private void tbNodeSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Tùy chỉnh nhập tay khoảng cách Node
        private void btnNodeSpace_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Clicks == 2)
            {
                tbNodeSpace.BringToFront();
                tbNodeSpace.Focus();
            }
        }

        private void tbNodeSpace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                int number;
                if(Int32.TryParse(tbNodeSpace.Text, out number))
                {
                    if (number > 50)
                        tbNodeSpace.Text = "50";
                    else if (number < 1)
                        tbNodeSpace.Text = "1";
                    btnNodeSpace.Text = tbNodeSpace.Text;
                }    
                tbNodeSpace.Text = "";
                tbNodeSpace.SendToBack();
            }
        }

        private void tbNodeSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        #endregion

        private void nudN_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }


    }
}
