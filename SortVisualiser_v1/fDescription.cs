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
