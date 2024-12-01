using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortVisualiser_v1
{
    public partial class fManually : Form
    {
        public fManually()
        {
            InitializeComponent();
        }

        public List<int> DayInput;
        public bool isNhap;

        public void ManualLanguageChange()
        {
            if(!fMain.isEnglish)
            {
                lblTitle.Text = LanguageChanged.EnterNumbersVN;
                lblTitle.Location = new Point(134, 20);
                lblTotal.Text = LanguageChanged.If1_VN;
                lblTotal.Location = new Point(70, 80);
                lblValue.Text = LanguageChanged.If2_VN;
                lblValue.Location = new Point(75, 100);
                btnEsc.Text = LanguageChanged.CancelVN;
            }
            else
            {
                lblTitle.Text = LanguageChanged.EnterNumbersEN;
                lblTitle.Location = new Point(90, 20);
                lblTotal.Text = LanguageChanged.If1_EN;
                lblTotal.Location = new Point(20, 80);
                lblValue.Text = LanguageChanged.If2_EN;
                lblValue.Location = new Point(92, 100);
                btnEsc.Text = LanguageChanged.CancelEN;
            }
        }
        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // xoa day cũ nếu đã tạo ở phiên trước
            DayInput.Clear();
            foreach (string item in tbxdayso.Text.Split(' '))
            {
                if (item == " ")
                {
                }
                else
                {
                    int temp = 10;
                    bool result = int.TryParse(item, out temp);
                    if (result == true && (temp < 0 || temp > 99))
                    {
                        MessageBox.Show("Phần tử có giá trị nhỏ hơn 0 hoặc lớn hơn 99");
                        return;
                    }
                    if (result == true)
                    {
                        DayInput.Add(temp);
                    }
                }

            }

            if (DayInput.Count > ThamSo.SoluongNodeLonNhat)
            {
                MessageBox.Show("Dãy vừa nhập vượt quá " + ThamSo.SoluongNodeLonNhat);
                return;
            }
            if (DayInput.Count == 0)
            {
                MessageBox.Show("Dãy nhập rỗng");
                return;
            }
            isNhap = true;
            this.Close();
        }

        private void fManually_Load(object sender, EventArgs e)
        {
            DayInput = new List<int>();
            isNhap = false;
        }

        private void tbxdayso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxdayso_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }
    }
}
