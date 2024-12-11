using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualiser_v1
{
    public partial class fDescription : Form
    {
        public fDescription()
        {
            HienThiThuatToan.RichTextBoxChange += rtbAlChange;//Đăng kí event thay đổi form thông qua HienThiThuatToan
            InitializeComponent();
        }
        int lineIndex = 0;

        #region Thay đổi văn bản/ngôn ngữ ở fdes
        public void DescriptionTextChange()
        {
            if (fMain.isEnglish)
                tbDescription.Text = HienThiThuatToan.yTuongEn;
            else
                tbDescription.Text = HienThiThuatToan.yTuongVi;
            rtbAlgorithm.Text = HienThiThuatToan.algorithm;
        }

        public void DescriptionLanguageChange()
        {
            if(!fMain.isEnglish)
            {
                tpDescription.Text = LanguageChanged.DescriptVN;
                tpAlgorithm.Text = LanguageChanged.AlgorithmVN;
            }
            else
            {
                tpDescription.Text = LanguageChanged.DescriptEN;
                tpAlgorithm.Text = LanguageChanged.AlgorithmEN;
            }
        }
        #endregion

        #region Thay đổi richtextbox
        void rtbAlChange(object sender, EventArgs e)
        {
            //int start = rtbAlgorithm.GetFirstCharIndexFromLine(lineIndex);
            //int length = rtbAlgorithm.Lines[lineIndex].Length;
            //rtbAlgorithm.Select(start, length);
            rtbAlgorithm.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));//144, 224, 239
            //rtbAlgorithm.Select(start, length);
            rtbAlgorithm.SelectionFont = new Font(rtbAlgorithm.Font, FontStyle.Regular);
            //rtbAlgorithm.Select(start, length);
            rtbAlgorithm.SelectionColor = Color.Black;

            lineIndex = HienThiThuatToan.number;
            int start = rtbAlgorithm.GetFirstCharIndexFromLine(lineIndex);
            int length = rtbAlgorithm.Lines[HienThiThuatToan.number].Length;
            rtbAlgorithm.Select(start, length);
            rtbAlgorithm.SelectionFont = new Font(rtbAlgorithm.Font, FontStyle.Bold);
            rtbAlgorithm.Select(start, length);
            rtbAlgorithm.SelectionBackColor = Color.Navy;
            rtbAlgorithm.Select(start, length);
            rtbAlgorithm.SelectionColor = Color.White;
            rtbAlgorithm.ScrollToCaret();
        }
        #endregion

        #region Thay đổi của form khi bắt đầu sort
        public void SortStarted()
        {
            tabControl1.SelectedIndex = 1;
        }
        #endregion

    }
}
