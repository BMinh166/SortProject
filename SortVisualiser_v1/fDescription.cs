using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualiser_v1
{
    public partial class fDescription : Form
    {
        public fDescription()
        {
            HienThiThuatToan.RichTextBoxChange += rtbAlChange;
            InitializeComponent();
        }

        

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

        void rtbAlChange(object sender, EventArgs e)
        {
            rtbAlgorithm.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));//144, 224, 239
            rtbAlgorithm.SelectionFont = new Font(rtbAlgorithm.Font, FontStyle.Regular);
            rtbAlgorithm.SelectionColor = Color.Black;
            int lineIndex = HienThiThuatToan.number;
            int start = rtbAlgorithm.GetFirstCharIndexFromLine(lineIndex);
            int length = rtbAlgorithm.Lines[HienThiThuatToan.number].Length;
            rtbAlgorithm.Select(start, length);
            rtbAlgorithm.SelectionFont = new Font(rtbAlgorithm.Font, FontStyle.Bold);
            rtbAlgorithm.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            rtbAlgorithm.SelectionColor = Color.White;
            rtbAlgorithm.ScrollToCaret();
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        public void SortStarted()
        {
            tabControl1.SelectedIndex = 1;
        }

        private void rtbAlgorithm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
