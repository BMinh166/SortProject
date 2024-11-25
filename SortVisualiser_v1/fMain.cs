using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SortVisualiser_v1
{
    public partial class fMain : Form
    {
        fMenu fmenu = new fMenu();
        fDescription fdes = new fDescription();
        
        public fMain()
        {
            fdes.Visible = false;
            fmenu.Visible = false;
            InitializeComponent();
            BUBClickAction();
        }

        #region Các biến toàn cục
        public static bool isEnglish = false;
        public static int typeSort = 0;
        public static bool isIncrease = true;
        CultureInfo culture;

        public int loaiThuatToan;
        HienThiThuatToan HienThuattoan = new HienThiThuatToan();
        private bool isRunning;
        private bool isTang;
        public static bool isDebug = false;
        private int SoLuongNode;
        public List<int> DanhSachThamSo;
        public List<ucNode> DanhSachNode;
        public List<Label> danhSachLabel;

        public List<int> MangChuaSapXep;
        Random rank = new Random();


        private int Phut = 0;
        private int Giay = 0;
        //String thông báo


        private string thoatMessageBoxName;
        private string thoat;
        private string hoanTatMessageBoxName;
        private string hoanTat;
        private string strSoLuongNode;


        Action ThuatToanSapXep;// giong delegate
        //thread điều khiển quá trình sắp xếp
        private Thread sapxepThread;
        private Dictionary<string, Label> bienArr;



        #endregion




        #region Event nhấn nút của các hàm sắp xếp ở hàng trên
        void BUBClickAction()
        {
            lblButtonDefault();
            lblBUB.Text = "BUBLE SORT";
            lblBUB.ForeColor = SystemColors.HighlightText;
            lblBUB.Font = new Font(lblBUB.Font, FontStyle.Bold);
            typeSort = 0;
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }
        private void lblBUB_Click(object sender, EventArgs e)
        {
            BUBClickAction();
        }

        private void lblINT_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblINT.Text = "INTERCHANGE SORT";
            lblINT.ForeColor = SystemColors.HighlightText;
            lblINT.Font = new Font(lblINT.Font, FontStyle.Bold);
            typeSort = 1;
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }

        private void lblBIN_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblBIN.Text = "BINARY INSERTION SORT";
            lblBIN.ForeColor = SystemColors.HighlightText;
            lblBIN.Font = new Font(lblBIN.Font, FontStyle.Bold);
            typeSort = 2;
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }

        private void lblINS_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblINS.Text = "INSERTION SORT";
            lblINS.ForeColor = SystemColors.HighlightText;
            lblINS.Font = new Font(lblINS.Font, FontStyle.Bold);
            typeSort = 3;
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }

        private void lblSEL_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblSEL.Text = "SELECTION SORT";
            lblSEL.ForeColor = SystemColors.HighlightText;
            lblSEL.Font = new Font(lblSEL.Font, FontStyle.Bold);
            typeSort = 4;
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }

        private void lblHEA_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblHEA.Text = "HEAP SORT";
            lblHEA.ForeColor = SystemColors.HighlightText;
            lblHEA.Font = new Font(lblHEA.Font, FontStyle.Bold);
            typeSort = 5;
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }

        private void lblMER_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblMER.Text = "MERGE SORT";
            lblMER.ForeColor = SystemColors.HighlightText;
            lblMER.Font = new Font(lblMER.Font, FontStyle.Bold);
            typeSort = 6;
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }

        private void lblQUI_Click(object sender, EventArgs e)
        {
            lblButtonDefault();
            lblQUI.Text = "QUICK SORT";
            lblQUI.ForeColor = SystemColors.HighlightText;
            lblQUI.Font = new Font(lblQUI.Font, FontStyle.Bold);
            typeSort = 7; 
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }
        #endregion

        /// Chỉnh các label button về mặc định 
        void lblButtonDefault()
        {
            //Các label button chuyển về text mặc định
            lblBUB.Text = "BUB";
            lblINT.Text = "INT";
            lblBIN.Text = "BIN";
            lblINS.Text = "INS";
            lblSEL.Text = "SEL";
            lblHEA.Text = "HEA";
            lblMER.Text = "MER";
            lblQUI.Text = "QUI";
            
            //Nền đen
            lblBUB.BackColor = SystemColors.ActiveCaptionText;
            lblINT.BackColor = SystemColors.ActiveCaptionText;
            lblBIN.BackColor = SystemColors.ActiveCaptionText;
            lblINS.BackColor = SystemColors.ActiveCaptionText;
            lblSEL.BackColor = SystemColors.ActiveCaptionText;
            lblHEA.BackColor = SystemColors.ActiveCaptionText;
            lblMER.BackColor = SystemColors.ActiveCaptionText;
            lblQUI.BackColor = SystemColors.ActiveCaptionText;
            
            //Chữ xám
            lblBUB.ForeColor = SystemColors.ActiveBorder;
            lblINT.ForeColor = SystemColors.ActiveBorder;
            lblBIN.ForeColor = SystemColors.ActiveBorder;
            lblINS.ForeColor = SystemColors.ActiveBorder;
            lblSEL.ForeColor = SystemColors.ActiveBorder;
            lblHEA.ForeColor = SystemColors.ActiveBorder;
            lblMER.ForeColor = SystemColors.ActiveBorder;
            lblQUI.ForeColor = SystemColors.ActiveBorder;
            
            //Kiểu chữ thông thường
            lblBUB.Font = new Font(lblBUB.Font, FontStyle.Regular);
            lblINT.Font = new Font(lblINT.Font, FontStyle.Regular);
            lblBIN.Font = new Font(lblBIN.Font, FontStyle.Regular);
            lblINS.Font = new Font(lblINS.Font, FontStyle.Regular);
            lblSEL.Font = new Font(lblSEL.Font, FontStyle.Regular);
            lblHEA.Font = new Font(lblHEA.Font, FontStyle.Regular);
            lblMER.Font = new Font(lblMER.Font, FontStyle.Regular);
            lblQUI.Font = new Font(lblQUI.Font, FontStyle.Regular);

            //Vị trí panel mặc định
            pnlINT.Location = new Point(49, 0);
            pnlINT.Location = new Point(49, 0);
            pnlBIN.Location = new Point(35, 0);
            pnlINS.Location = new Point(39, 0);
            pnlSEL.Location = new Point(33, 0);
            pnlHEA.Location = new Point(41, 0);
            pnlMER.Location = new Point(43, 0);
            pnlQUI.Location = new Point(48, 0);
        }

        //Đẩy các label button khác sang phải khi size của 1 label button tăng
        private void lblBUB_SizeChanged(object sender, EventArgs e)
        {
            if (lblBUB.Text == "BUB")
                return;
            pnlINT.Location = new Point(49+70, pnlINT.Location.Y);
        }

        private void lblINT_SizeChanged(object sender, EventArgs e)
        {
            if (lblINT.Text == "INT")
                return;
            pnlBIN.Location = new Point(35 + 145, pnlBIN.Location.Y);
        }

        private void lblBIN_SizeChanged(object sender, EventArgs e)
        {
            if (lblBIN.Text == "BIN")
                return;
            pnlINS.Location = new Point(39 + 174, pnlINS.Location.Y);
        }

        private void lblINS_SizeChanged(object sender, EventArgs e)
        {
            if (lblINS.Text == "INS")
                return;
            pnlSEL.Location = new Point(33 + 114, pnlSEL.Location.Y);
        }

        private void lblSEL_SizeChanged(object sender, EventArgs e)
        {
            if (lblSEL.Text == "SEL")
                return;
            pnlHEA.Location = new Point(41 + 114, pnlHEA.Location.Y);
        }

        private void lblHEA_SizeChanged(object sender, EventArgs e)
        {
            if (lblHEA.Text == "HEA")
                return;
            pnlMER.Location = new Point(43 + 65, pnlMER.Location.Y);
        }

        private void lblMER_SizeChanged(object sender, EventArgs e)
        {
            if (lblMER.Text == "MER")
                return;
            pnlQUI.Location = new Point(48 + 70, pnlQUI.Location.Y);
        }

        private void lblQUI_SizeChanged(object sender, EventArgs e)
        {

        }

        //Thực hiện hành động bấm nút Menu
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnMenu.Text == ">")
            {
                btnMenu.Text = "<";
                fmenu.Visible = true;
                fmenu.TopLevel = false;
                fmenu.Dock = DockStyle.Fill;
                pnlMenu.Controls.Add(fmenu);
                fmenu.Show();
            }
            else
            {
                btnMenu.Text = ">";
                fmenu.Visible = false;
            }
            
        }

        //Hành động khi bấm nút Description
        private void btnDescription_Click(object sender, EventArgs e)
        {
            if (btnDescription.Text == "<")
            {
                btnDescription.Text = ">";
                fdes.Visible = true;
                fdes.TopLevel = false;
                fdes.Dock = DockStyle.Fill;
                pnlDescription.Controls.Add(fdes);
                fdes.Show();
            }
            else
            {
                btnDescription.Text = "<";
                fdes.Visible=false;
            }
        }

        /// <summary>
        /// Điều chỉnh các picture box Resume, Stop, Arrow dưới dạng button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        //Picture box sẽ sáng lên khi trỏ chuột vào
        private void picStop_MouseEnter(object sender, EventArgs e)
        {
            picStop.Image = new Bitmap(Application.StartupPath + "\\Resources\\Stop.png");
        }

        private void picStop_MouseLeave(object sender, EventArgs e)
        {
            picStop.Image = new Bitmap(Application.StartupPath + "\\Resources\\Stop_Off1.png");
        }

        private void picArrow_MouseEnter(object sender, EventArgs e)
        {
            picArrow.Image = new Bitmap(Application.StartupPath + "\\Resources\\Arrow.png");
        }

        private void picArrow_MouseLeave(object sender, EventArgs e)
        {
            picArrow.Image = new Bitmap(Application.StartupPath + "\\Resources\\Arrow_Off.png");
        }

        //Thay đổi qua lại giữa Resume và Pause khi nhấn
        bool isPause = true;
        private void picResPau_Click(object sender, EventArgs e)
        {
            if(isPause)
            {
                picResPau.Image = new Bitmap(Application.StartupPath + "\\Resources\\Resume.png");
                isPause = false;
            }
            else
            {
                picResPau.Image = new Bitmap(Application.StartupPath + "\\Resources\\Pause.png");
                isPause = true;
            }
        }


        ///Khởi tạo các biến lưu trữ giá trị cho các form con

        //Biến lưu trữ liên quan đến form con Menu
        string menu_Language = "Tiếng Việt";
        string menu_InsOrDes = "Tăng";
        decimal menu_N = 10;
        int menu_Speed = 4;
        

        //Lưu những thay đổi
        void SaveMenuChange()
        {
            menu_Language = fmenu.btnLanguage.Text;
            menu_InsOrDes = fmenu.btnIncOrDes.Text;
            menu_N = fmenu.nudN.Value;
            menu_Speed = fmenu.trbSpeed.Value;
        }

        //Áp dụng những thay đổi
        void SetMenuChange()
        {
            fmenu.btnLanguage.Text = menu_Language;
            fmenu.btnIncOrDes.Text = menu_InsOrDes;
            fmenu.nudN.Value = menu_N;
            fmenu.trbSpeed.Value = menu_Speed;
            fmenu.SpeedShowChange();
        }


        // Cac thong so mac dinh khi form duoc tao ra
        private void fMain_Load(object sender, EventArgs e)
        {

            KhoiTaoMacDinh();
            VeNut();
            Mangchuasapxep();

            culture = CultureInfo.CurrentCulture;
            picStop.Enabled = false;
            fmenu.trbSpeed.Maximum = ThamSo.ThoiGianDoi * 2;
            fmenu.trbSpeed.Minimum = 0;
            fmenu.trbSpeed.Value = ThamSo.ThoiGianDoi;
            fmenu.trbSpeed.LargeChange = 1;
        }


        private void KhoiTaoMacDinh()
        {
            bienArr = new Dictionary<string, Label>();
            List<string> bienArrString = new List<string>() { "i", "j", "min", "right", "left", "k", "pos", "m", "vt_x", "gap", "a:", "b:", "c:" };
            foreach (string item in bienArrString)
            {
                bienArr.Add(item, new Label());
            }
            foreach (var item in bienArr)
            {

                this.pnlMain.Controls.Add(item.Value);
                item.Value.TextAlign = ContentAlignment.MiddleCenter;
            }

            bienArr["i"].Size = bienArr["j"].Size = new Size(ThamSo.KichCoNode, 15);

            bienArr["min"].Size = new Size(60, 20);
            bienArr["left"].Size = new Size(60, 20);
            bienArr["right"].Size = new Size(60, 20);
            bienArr["m"].Size = bienArr["k"].Size = new Size(40, 15);
            bienArr["pos"].Size = new Size(60, 20);
            bienArr["vt_x"].Size = new Size(60, 20);
            bienArr["gap"].Size = new Size(60, 20);
            bienArr["a:"].Size = bienArr["b:"].Size = bienArr["c:"].Size = new Size(40, 15);
            bienArr["i"].ForeColor = bienArr["j"].ForeColor = bienArr["left"].ForeColor = bienArr["right"].ForeColor = bienArr["m"].ForeColor =
            bienArr["pos"].ForeColor = bienArr["vt_x"].ForeColor = bienArr["gap"].ForeColor = bienArr["a:"].ForeColor = bienArr["b:"].ForeColor = bienArr["c:"].ForeColor = bienArr["k"].ForeColor = Color.White;

            bienArr["i"].BorderStyle = bienArr["left"].BorderStyle = bienArr["j"].BorderStyle = bienArr["min"].BorderStyle =
            bienArr["m"].BorderStyle = bienArr["right"].BorderStyle = bienArr["pos"].BorderStyle = bienArr["vt_x"].BorderStyle =
            bienArr["gap"].BorderStyle = bienArr["k"].BorderStyle = BorderStyle.FixedSingle;

            //interchangerdbtn.Checked = true;
            //tangrdbtn.Checked = true;
            isRunning = false;
            fmenu.nudN.Value = 5;
            SoLuongNode = 5;
            //dungbtn.Enabled = huybnt.Enabled = false;
            VeNut();
            //DieuChinhControls(isRunning);

            // setMauAllControl();
        }




        #region Khởi tạo Node
        void VeNut()
        {
            DanhSachThamSo = new List<int>(SoLuongNode);
            DanhSachNode = new List<ucNode>(SoLuongNode);
            danhSachLabel = new List<Label>(SoLuongNode);

            pnlMain.Controls.Clear(); // Xóa những btn cũ trên panel ở phiên làm việc
            int temp = -SoLuongNode / 2;
            int temp2 = ThamSo.KhoangCachCacNode / 2;
            int temp3 = temp + 1;
            Point newPoint;
            for (int i = 0; i < SoLuongNode; i++)
            {
                Label tam = new Label() { Text = i.ToString() };
                tam.Size = new Size(ThamSo.KichCoNode / 2, ThamSo.KichCoNode / 2);
                tam.ForeColor = Color.White;
                //tam.Enabled = false;
                ucNode btn = new ucNode(i);
                int Value = rank.Next(2, 100);
                btn.Value = Value;
                btn.Text = Value.ToString();
                btn.BackColor = ThamSo.mauNen;
                if (SoLuongNode % 2 != 0)
                {
                    newPoint = new Point(pnlMain.Width / 2 - btn.Width / 2,
                                         pnlMain.Height / 2 - btn.Height / 2);
                    btn.Location = new Point(newPoint.X + temp * btn.Width + temp * ThamSo.KhoangCachCacNode, newPoint.Y);
                    temp++;
                    tam.Location = new Point(btn.Location.X + btn.Width / 2 - tam.Width / 2, btn.Location.Y + 150);
                }
                else
                {
                    if (i == SoLuongNode / 2)
                    {
                        temp2 = -temp2;
                        temp3 = 0;
                    }

                    newPoint = new Point(pnlMain.Width / 2 - btn.Width / 2 + ThamSo.KichCoNode / 2, pnlMain.Height / 2 - btn.Height / 2);
                    btn.Location = new Point(newPoint.X - temp2 + temp3 * ThamSo.KhoangCachCacNode + temp * btn.Width, newPoint.Y);// Node Xuất hiện giữa panel
                    tam.Location = new Point(btn.Location.X + btn.Width / 2 - tam.Width / 2, btn.Location.Y + 150);
                    temp++;
                    temp3++;
                }
                pnlMain.Controls.Add(tam);
                pnlMain.Controls.Add(btn);
                DanhSachNode.Add(btn);
                DanhSachThamSo.Add(Value);
                danhSachLabel.Add(tam);
                btn.Capnhat += Btn_Capnhat;
            }
            if (isRunning == false)
            {
                MangChuaSapXep = new List<int>(SoLuongNode);
                for (int i = 0; i < SoLuongNode; i++)
                {
                    MangChuaSapXep.Add(DanhSachThamSo[i]);
                }
            }
            Mangchuasapxep();
            fmenu.btnStart.Enabled = true;

        }

        private void Mangchuasapxep()
        {
            chuasapxepPanel.Controls.Clear();
            lbMangChuaSapXep.Location = new Point(chuasapxepPanel.Location.X, 10);
            chuasapxepPanel.Controls.Add(lbMangChuaSapXep);

            string _string = "";
            foreach (var item in DanhSachThamSo)
            {
                _string += item + "    ";
            }
            Label lbtext = new Label() { Text = _string };
            lbtext.ForeColor = Color.White;
            lbtext.Size = new Size(600, 20);
            lbtext.Location = new Point(lbMangChuaSapXep.Location.X + lbMangChuaSapXep.Width + 10, 12);
            chuasapxepPanel.Controls.Add(lbtext);


        }
        #endregion

        private void Btn_Capnhat(object sender, EventArgs e)
        {
            for (int i = 0; i < SoLuongNode; i++)
            {
                DanhSachThamSo[i] = DanhSachNode[i].Value;
            }
            Mangchuasapxep();
        }

        private void picStop_Click(object sender, EventArgs e)
        {

        }

        ///

    }
}
