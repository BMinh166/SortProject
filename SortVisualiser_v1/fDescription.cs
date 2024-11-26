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

        
    }
}
