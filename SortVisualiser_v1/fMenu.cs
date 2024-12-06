using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SortVisualiser_v1
{
    public partial class fMenu : Form
    {

        fManually fman;
        private fMain fmain;
        public fMenu(fMain fmain)
        {
            InitializeComponent();
            SetDefault();
            this.fmain = fmain;
        }


        public event EventHandler<EventArgs> LanguageChange;
        public event EventHandler IncDesSwap;
        //public event EventHandler DataCleared;
        //public event EventHandler Venut;
        //public event EventHandler MangChuaSapXep;
        public event EventHandler TrackBarValueChange;
        //public event EventHandler StopNow;
        public int NodeTotal;


        /// <summary>
        /// Thực thi chức năng của cái button ở tabpage Cài Đặt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncOrDes_Click(object sender, EventArgs e)
        {
            if(fMain.isIncrease)
            {
                if (!fMain.isEnglish)
                    btnIncOrDes.Text = LanguageChanged.DesVN;
                else
                    btnIncOrDes.Text = LanguageChanged.DesEN;
                fMain.isIncrease = false;
                IncDesSwap?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                if(!fMain.isEnglish)
                    btnIncOrDes.Text = LanguageChanged.IncVN;
                else
                    btnIncOrDes.Text = LanguageChanged.IncEN;
                fMain.isIncrease = true;
                IncDesSwap?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            /*fman = new fManually();
            fman.ManualLanguageChange();
            fman.ShowDialog();
            if (fman.isNhap == true)
            {
                string temp = "";
                fMain.SoLuongNode = fman.DayInput.Count();
                nudN.Value = fMain.SoLuongNode;
                Venut?.Invoke(this, EventArgs.Empty);
            for (int i = 0; i < fMain.SoLuongNode; i++)
                {
                    // DanhSachNode[i].Value = input.DayInput[i];
                    fMain.DanhSachNode[i].Text = fman.DayInput[i].ToString();
                    fMain.DanhSachThamSo[i] = fman.DayInput[i];

                }
            MangChuaSapXep?.Invoke(this, EventArgs.Empty);
        }*/
            fmain.HandInput();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            if (!fMain.isEnglish)
            {
                btnLanguage.Text = "English";
                fMain.isEnglish = true;
                LanguageChange?.Invoke(this, new EventArgs());
                MenuLanguageChange();
            }
            else
            {
                btnLanguage.Text = "Tiếng Việt";
                fMain.isEnglish = false;
                LanguageChange?.Invoke(this, new EventArgs());
                MenuLanguageChange();
            }
        }

        void MenuLanguageChange()
        {
            if(!fMain.isEnglish)
            {
                tpCreate.Text = LanguageChanged.IniVN;
                tpSetting.Text = LanguageChanged.SettVN;
                tbCustomize.Text = LanguageChanged.CustomVN;
                btnRandom.Text = LanguageChanged.RandVN;
                btnHand.Text = LanguageChanged.ManuaVN;
                btnDelete.Text = LanguageChanged.DeleteArrVN;
                btnStart.Text = LanguageChanged.StartVN;
                button1.Text = LanguageChanged.ExitVN;
                lblSortHow.Text = LanguageChanged.SortVN;
                if(fMain.isIncrease)
                {
                    btnIncOrDes.Text = LanguageChanged.IncVN;
                }
                else
                    btnIncOrDes.Text = LanguageChanged.DesVN;
                lblLanguage.Text = LanguageChanged.LangVN;
                lblSpeed.Text = LanguageChanged.SpeedVN;
                lbNodeSize.Text = LanguageChanged.NodeSizeVN;
                lbNodeSpace.Text = LanguageChanged.NodeSpaceVN;
                lbNodeBackColor.Text = LanguageChanged.BackGrdColorVN;
                lbNodeChoosingColor.Text = LanguageChanged.ChoosingNodeColorVN;
                lbNodeSortedColor.Text = LanguageChanged.SortedNodeColorVN;
                btnUpdate.Text = LanguageChanged.UpdateVN;
                btnDefault.Text = LanguageChanged.DefaultVN;
            }
            else
            {
                tpCreate.Text = LanguageChanged.IniEN;
                tpSetting.Text = LanguageChanged.SettEN;
                tbCustomize.Text = LanguageChanged.CustomEN;
                btnRandom.Text = LanguageChanged.RandEN;
                btnHand.Text = LanguageChanged.ManuaEN;
                btnDelete.Text = LanguageChanged.DeleteArrEN;
                btnStart.Text = LanguageChanged.StartEN;
                button1.Text = LanguageChanged.ExitEN;
                lblSortHow.Text = LanguageChanged.SortEN;
                if (fMain.isIncrease)
                {
                    btnIncOrDes.Text = LanguageChanged.IncEN;
                }
                else
                    btnIncOrDes.Text = LanguageChanged.DesEN;
                lblLanguage.Text = LanguageChanged.LangEN;
                lblSpeed.Text = LanguageChanged.SpeedEN;
                lbNodeSize.Text = LanguageChanged.NodeSizeEN;
                lbNodeSpace.Text = LanguageChanged.NodeSpaceEN;
                lbNodeBackColor.Text = LanguageChanged.BackGrdColorEN;
                lbNodeChoosingColor.Text = LanguageChanged.ChoosingNodeColorEN;
                lbNodeSortedColor.Text = LanguageChanged.SortedNodeColorEN;
                btnUpdate.Text = LanguageChanged.UpdateEN;
                btnDefault.Text = LanguageChanged.DefaultEN;
            }
        }

        private void trbSpeed_Scroll(object sender, EventArgs e)
        {
            SpeedShowChange();
            TrackBarValueChange?.Invoke(this, EventArgs.Empty);
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
            if (term > 30)
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
            if (term > 10)
                term--;
            btnNodeSpace.Text = term.ToString();
        }

        private void btnNodeSpaceInc_Click(object sender, EventArgs e)
        {
            int term = Int32.Parse(btnNodeSpace.Text);
            if (term < 30)
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
                    else if (number < 30)
                        tbNodeSize.Text = "30";
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
                    if (number > 30)
                        tbNodeSpace.Text = "30";
                    else if (number < 10)
                        tbNodeSpace.Text = "10";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            
            btnStart.Enabled = false;

            fmain.DataCleared();

            int kichCoNode, khoanCachGiuaCacNode;
            //soLuongPhanTuMacDinh;
            bool rs = int.TryParse(btnNodeSizeChange.Text , out kichCoNode);
            if (rs = false || (kichCoNode < 30 || kichCoNode > 50))
            {
                MessageBox.Show("Kích cỡ Node phải là số nguyên và thuộc khoản từ 30 đến 50!", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rs = int.TryParse(btnNodeSpace.Text, out khoanCachGiuaCacNode);
            if (rs = false || (khoanCachGiuaCacNode < 1 || khoanCachGiuaCacNode > 100))
            {
                MessageBox.Show("Khoảng cách giữa các Node phải là số nguyên và thuộc khoản từ 1 đến 100!", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /*rs = int.TryParse(txbSoLuongPhanTuMacDinh.Text, out soLuongPhanTuMacDinh);
            if (rs = false || (soLuongPhanTuMacDinh < 1 || soLuongPhanTuMacDinh > ThamSo.SoluongNodeLonNhat))
            {
                MessageBox.Show("Số lượng phần tử mặc định phải là số nguyên và thuộc khoản từ 1 đến " + ThamSo.SoluongNodeLonNhat + " !", "Giá trị công hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/


            Properties.Settings.Default.kichCoNode = ThamSo.KichCoNode = kichCoNode;
            Properties.Settings.Default.khoangCachGiuaCacNode = ThamSo.KhoangCachCacNode = khoanCachGiuaCacNode;

            Properties.Settings.Default.mauNenNode = ThamSo.mauNen = btnNodeBackColor.BackColor;
            Properties.Settings.Default.mauNodeHoanTatSapXep = ThamSo.mauNodeHTSX = btnNodeSortedColor.BackColor;
            Properties.Settings.Default.mauNodeDangSapXep = ThamSo.mauNodeDangSX = btnNodeChoosingColor.BackColor;

            //  Properties.Settings.Default.labelFont = txbLabelFont.Font = labelFontDialog.Font;
            // Properties.Settings.Default.chuFont = txbChuFont.Font = chuFontDialog.Font;

            //Properties.Settings.Default.soLuongPhanTuMacDinh = soLuongPhanTuMacDinh;


            Properties.Settings.Default.Save();

            //this.Close();
        }


        #endregion

        private void nudN_ValueChanged(object sender, EventArgs e)
        {
            NodeTotal = (int)nudN.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            fmain.startButton();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fmain.DataCleared();
            btnStart.Enabled = false;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            /*if(fMain.isRunning)
            {
                StopNow?.Invoke(this, EventArgs.Empty);
            }
            //fMain.SoLuongNode = fMain.rank.Next(2, ThamSo.SoluongNodeLonNhat);
            nudN.Value = fMain.SoLuongNode = NodeTotal;
            Venut?.Invoke(this, EventArgs.Empty);
            */
            fmain.RandomInput();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            fmain.DataCleared();
            btnStart.Enabled = false;
            SetDefault();
        }

        void SetDefault()
        {

            btnNodeSizeChange.Text = "45";
            Properties.Settings.Default.kichCoNode = ThamSo.KichCoNode = 45;
            btnNodeSpace.Text = "15";
            Properties.Settings.Default.khoangCachGiuaCacNode = ThamSo.KhoangCachCacNode = 15;
            Properties.Settings.Default.mauNenNode = ThamSo.mauNen = btnNodeBackColor.BackColor = Color.White;
            Properties.Settings.Default.mauNodeHoanTatSapXep = ThamSo.mauNodeHTSX = btnNodeSortedColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            Properties.Settings.Default.mauNodeDangSapXep = ThamSo.mauNodeDangSX = btnNodeChoosingColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0))))); ;
            Properties.Settings.Default.Save();
        }

        public void SortStarted()
        {
            nudN.Enabled = false;
            btnHand.Enabled = false;
            btnUpdate.Enabled = false;
            btnDefault.Enabled = false;
            btnIncOrDes.Enabled = false;
        }

        public void SortFinished()
        {
            nudN.Enabled = true;
            btnHand.Enabled = true;
            btnUpdate.Enabled = true;
            btnDefault.Enabled = true;
            btnIncOrDes.Enabled = true;
        }

        private void tbNodeSize_Leave(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(tbNodeSize.Text, out number))
            {
                if (number > 50)
                    tbNodeSize.Text = "50";
                else if (number < 30)
                    tbNodeSize.Text = "30";
                btnNodeSizeChange.Text = tbNodeSize.Text;
            }

            tbNodeSize.Text = "";
            tbNodeSize.SendToBack();
        }

        private void tbNodeSpace_Leave(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(tbNodeSpace.Text, out number))
            {
                if (number > 30)
                    tbNodeSpace.Text = "30";
                else if (number < 10)
                    tbNodeSpace.Text = "10";
                btnNodeSpace.Text = tbNodeSpace.Text;
            }
            tbNodeSpace.Text = "";
            tbNodeSpace.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmain.ExitButton();
        }
    }
}
