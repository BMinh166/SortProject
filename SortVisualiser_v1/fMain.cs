using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private fMenu fmenu;
        fDescription fdes = new fDescription();
        
        public fMain()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            fmenu = new fMenu(this);
            fmenu.Show();
            EventRegister();
            //fmenu.DataCleared += fmenu_DataCleared; 
            //fmenu.Venut += fmenu_Venut;
            //fmenu.MangChuaSapXep += fmenu_MangChuaSapXep;
            fmenu.IncDesSwap += fmenu_IncDesSwap;
            fmenu.TrackBarValueChange += fmenu_trackBarValueChanged;
            //fmenu.StopNow += picStop_Click;
            InitializeComponent();
            BUBClickAction();
            fChildStart();
        }

        #region Các biến toàn cục
        public static bool isEnglish = false;
        public static int typeSort = 0;
        public static bool isIncrease = true;
        public static bool isRunning;
        CultureInfo culture;

        public int loaiThuatToan;
        HienThiThuatToan HienThuattoan = new HienThiThuatToan();
        public static bool isDebug = false;
        private int SoLuongNode; //Đã chuyển từ private sang static
        private List<int> DanhSachThamSo; //Đã chuyển từ private sang static
        private List<ucNode> DanhSachNode;    //Đã chuyển từ private sang static
        public List<Label> danhSachLabel;

        public List<int> MangChuaSapXep;
        private Random rank = new Random(); //Đã chuyển từ private sang static


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

        //Hàm đăng kí sự kiện
        void EventRegister()
        {
            fmenu.LanguageChange += fmenu_LanguageChange;//Đăng kí sự kiện LanguageChange của fmenu
        }

        /*public void fmenu_DataCleared(object sender, EventArgs e) //Đăng ký sự kiện DataCleared của fmenu
        {
            chuasapxepPanel.Controls.Clear();
            pnlMain.Controls.Clear();
            DanhSachNode.Clear();
            DanhSachThamSo.Clear();
           
        }*/

        /*public void fmenu_Venut(object sender, EventArgs e) //Đăng ký sự kiện DataCleared của fmenu
        {
            VeNut();
        }*/

        /*public void fmenu_MangChuaSapXep(object sender, EventArgs e) //Đăng ký sự kiện của fmenu
        {
            Mangchuasapxep();
        }*/

        public void fmenu_IncDesSwap(object sender, EventArgs e)
        {
            IncDesSwap();
        }
        #endregion



        #region Các thiết lập controls của Main form
        #region Event nhấn nút của các hàm sắp xếp ở hàng trên
        void BUBClickAction()
        {
            if(!isRunning)
            {
                ThuatToanSapXep = BubbleSort;
                lblButtonDefault();
                lblBUB.Text = "BUBLE SORT";
                lblBUB.ForeColor = SystemColors.HighlightText;
                lblBUB.Font = new Font(lblBUB.Font, FontStyle.Bold);
                typeSort = 0;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }
        private void lblBUB_Click(object sender, EventArgs e)
        {
            BUBClickAction();
        }

        private void lblINT_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                ThuatToanSapXep = InterchangeSort;
                lblButtonDefault();
                lblINT.Text = "INTERCHANGE SORT";
                lblINT.ForeColor = SystemColors.HighlightText;
                lblINT.Font = new Font(lblINT.Font, FontStyle.Bold);
                typeSort = 1;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }

        private void lblBIN_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                ThuatToanSapXep = BinaryInsertionSort;
                lblButtonDefault();
                lblBIN.Text = "BINARY INSERTION SORT";
                lblBIN.ForeColor = SystemColors.HighlightText;
                lblBIN.Font = new Font(lblBIN.Font, FontStyle.Bold);
                typeSort = 2;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }

        private void lblINS_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                ThuatToanSapXep = InsertionSort;
                lblButtonDefault();
                lblINS.Text = "INSERTION SORT";
                lblINS.ForeColor = SystemColors.HighlightText;
                lblINS.Font = new Font(lblINS.Font, FontStyle.Bold);
                typeSort = 3;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }

        private void lblSEL_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                ThuatToanSapXep = SelectionSort;
                lblButtonDefault();
                lblSEL.Text = "SELECTION SORT";
                lblSEL.ForeColor = SystemColors.HighlightText;
                lblSEL.Font = new Font(lblSEL.Font, FontStyle.Bold);
                typeSort = 4;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }


        private void lblHEA_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                ThuatToanSapXep = HeapSort;
                lblButtonDefault();
                lblHEA.Text = "HEAP SORT";
                lblHEA.ForeColor = SystemColors.HighlightText;
                lblHEA.Font = new Font(lblHEA.Font, FontStyle.Bold);
                typeSort = 5;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }

        private void lblMER_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                ThuatToanSapXep = MergeSort;
                lblButtonDefault();
                lblMER.Text = "MERGE SORT";
                lblMER.ForeColor = SystemColors.HighlightText;
                lblMER.Font = new Font(lblMER.Font, FontStyle.Bold);
                typeSort = 6;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }

        private void lblQUI_Click(object sender, EventArgs e)
        {
            if(!isRunning)
            {
                ThuatToanSapXep = QuickSort;
                lblButtonDefault();
                lblQUI.Text = "QUICK SORT";
                lblQUI.ForeColor = SystemColors.HighlightText;
                lblQUI.Font = new Font(lblQUI.Font, FontStyle.Bold);
                typeSort = 7;
                HienThiThuatToan.Type_Sort();
                fdes.DescriptionTextChange();
            }
        }

        void IncDesSwap()
        {
            HienThiThuatToan.Type_Sort();
            fdes.DescriptionTextChange();
        }
        #endregion

        #region Chỉnh các label button về mặc định 
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
        #endregion

        #region Trạng thái chờ đợi khi trỏ con trỏ vào label
        void SortLabelOff()
        {
            lblBUB.Cursor = Cursors.WaitCursor;
            lblINT.Cursor = Cursors.WaitCursor;
            lblBIN.Cursor = Cursors.WaitCursor;
            lblINS.Cursor = Cursors.WaitCursor;
            lblSEL.Cursor = Cursors.WaitCursor;
            lblHEA.Cursor = Cursors.WaitCursor;
            lblMER.Cursor = Cursors.WaitCursor;
            lblQUI.Cursor = Cursors.WaitCursor;
        }
        

        void SortLabelOn() 
        {
            lblBUB.Cursor = Cursors.Hand;
            lblINT.Cursor = Cursors.Hand;
            lblBIN.Cursor = Cursors.Hand;
            lblINS.Cursor = Cursors.Hand;
            lblSEL.Cursor = Cursors.Hand;
            lblHEA.Cursor = Cursors.Hand;
            lblMER.Cursor = Cursors.Hand;
            lblQUI.Cursor = Cursors.Hand;
        }
        #endregion

        #region Đẩy các label button khác sang phải khi size của 1 label button tăng
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
        #endregion

        #region Thực hiện hành động khi mở fChild
        //Thực hiện hành động bấm nút Menu
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnMenu.Text == ">")
            {
                btnMenu.Text = "<";
                fmenu.Visible = true;
                //fmenu.TopLevel = false;
                //fmenu.Dock = DockStyle.Fill;
                //pnlMenu.Controls.Add(fmenu);
                //fmenu.Show();
            }
            else
            {
                btnMenu.Text = ">";
                fmenu.Visible = false;
            }
            
        }

        void fChildStart()
        {
            fmenu.TopLevel = false;
            fmenu.Dock = DockStyle.Fill;
            pnlMenu.Controls.Add(fmenu);
            fmenu.Show();
            fdes.TopLevel = false;
            fdes.Dock = DockStyle.Fill;
            pnlDescription.Controls.Add(fdes);
            fdes.Show();
        }

        //Hành động khi bấm nút Description
        private void btnDescription_Click(object sender, EventArgs e)
        {
            if (btnDescription.Text == "<")
            {
                btnDescription.Text = ">";
                fdes.Visible = true;
                //fdes.TopLevel = false;
                //fdes.Dock = DockStyle.Fill;
                //pnlDescription.Controls.Add(fdes);
                //fdes.Show();
            }
            else
            {
                btnDescription.Text = "<";
                fdes.Visible=false;
            }
        }
        #endregion

        #region Thiết lập các nút nhấn Pause, Resume, Stop
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
            if(ucNode.IsPause)
            {
                picResPau.Image = new Bitmap(Application.StartupPath + "\\Resources\\Pause.png");
                ucNode.pauseStatus.Set();     // hàm để resume
                ucNode.IsPause = false;
                //dungbtn.Text = "Tạm dừng";
                timer1.Start();
            }
            else
            {
                picResPau.Image = new Bitmap(Application.StartupPath + "\\Resources\\Resume.png");
                ucNode.pauseStatus.Reset();    // hàm để pause
                ucNode.IsPause = true;
                //dungbtn.Text = "Tiếp tục";
                timer1.Stop();
            }


        }
        #endregion
        #endregion

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

        //sự kiện kích hoạt khi button ngôn ngữ của fmenu thay đổi
        private void fmenu_LanguageChange(object sender, EventArgs e)
        {
            fdes.DescriptionTextChange();
            fdes.DescriptionLanguageChange();
            MainLanguageChange();
        }

        void MainLanguageChange()
        {
            if (!isEnglish)
            {
                lbMangChuaSapXep.Text = LanguageChanged.OriginArrVN;
            }
            else
            {
                lbMangChuaSapXep.Text = LanguageChanged.OriginArrEN;
            }
        }


        // Cac thong so mac dinh khi form duoc tao ra
        private void fMain_Load(object sender, EventArgs e)
        {

            KhoiTaoMacDinh();
            VeNut();
            Mangchuasapxep();

            culture = CultureInfo.CurrentCulture;
            picStop.Enabled = false;
            fmenu.trbSpeed.Maximum = ThamSo.ThoiGianDoi * 2 / 5;
            fmenu.trbSpeed.Minimum = 0;
            fmenu.trbSpeed.Value = ThamSo.ThoiGianDoi / 5;
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
            bienArr["pos"].ForeColor = bienArr["vt_x"].ForeColor = bienArr["gap"].ForeColor = bienArr["a:"].ForeColor = bienArr["b:"].ForeColor = bienArr["c:"].ForeColor = bienArr["k"].ForeColor = Color.Black;

            bienArr["i"].BorderStyle = bienArr["left"].BorderStyle = bienArr["j"].BorderStyle = bienArr["min"].BorderStyle =
            bienArr["m"].BorderStyle = bienArr["right"].BorderStyle = bienArr["pos"].BorderStyle = bienArr["vt_x"].BorderStyle =
            bienArr["gap"].BorderStyle = bienArr["k"].BorderStyle = BorderStyle.FixedSingle;

            //BUBClickAction();
            //isIncrease = true;
            isRunning = false;
            fmenu.nudN.Value = 5;
            SoLuongNode = 5;
            picResPau.Enabled = picStop.Enabled = false;
            VeNut();
            DieuChinhControls(isRunning);

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
                tam.ForeColor = Color.Black;
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
            lbMangChuaSapXep.Location = new Point(chuasapxepPanel.Location.X + 12, 12);
            chuasapxepPanel.Controls.Add(lbMangChuaSapXep);

            string _string = "";
            foreach (var item in DanhSachThamSo)
            {
                _string += item + "    ";
            }
            Label lbtext = new Label() { Text = _string };
            lbtext.ForeColor = Color.Black;
            lbtext.Size = new Size(600, 20);
            lbtext.Font = new Font("Minecrosoft Sans", 10f);
            lbtext.Location = new Point(lbMangChuaSapXep.Location.X + lbMangChuaSapXep.Width + 8, 13);
            chuasapxepPanel.Controls.Add(lbtext);


        }
        #endregion


        private void DieuChinhControls(bool isRunning)
        {
            //  batdaubtn.Focus();
            if (isRunning == true)
            {
                foreach (ucNode item in DanhSachNode)
                {
                    item.Enabled = false;
                }
                fmenu.btnStart.Enabled = false;
                fmenu.btnDelete.Enabled = false;
                picResPau.Enabled = picStop.Enabled = true;
                //daydangxepListbox.Items.Clear();
                //daydangxepListbox.BringToFront();
                //tabctlytuong.SelectedIndex = 1;
                //thuattoanpanel.Enabled = khoitaopanel.Enabled = ngonngupanel.Enabled = Loaisapxeppanel.Enabled = false;
            }
            else
            {
                foreach (ucNode item in DanhSachNode)
                {
                    item.Enabled = true;
                }
                fmenu.btnDelete.Enabled = true;
                picResPau.Enabled = picStop.Enabled = false;
                //thuattoanpanel.Enabled = khoitaopanel.Enabled = ngonngupanel.Enabled = fmenu.btnStart.Enabled = Loaisapxeppanel.Enabled = true;

            }
        }





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
            StopNow();
        }


        #region thu dung thread va tack , thread co the abort bất kỳ lúc nào, task có thể callback

        public void DiChuyenNodeDen(object oNode, object oVitriMoi)
        {
            int vitriMoi = (int)oVitriMoi;
            ucNode node = oNode as ucNode;
            if (vitriMoi > node.vitriHienTai)
            {
                node.ChuyenLen();
                node.ChuyenNgang(vitriMoi);
                node.ChuyenXuong();
            }
            else if (vitriMoi < node.vitriHienTai)
            {
                node.ChuyenXuong();
                node.ChuyenNgang(vitriMoi);
                node.ChuyenLen();
            }

            // set lai vi tri moi
            node.vitriHienTai = vitriMoi;
        }

        // Hoán vị chổ của 2 node
        Task hoanVi1Task;
        Task hoanVi2Task;
        private void DichuyenCacNode(int vitriNodeA, int vitriNodeB)
        {
            DanhSachNode[vitriNodeA].BackColor = DanhSachNode[vitriNodeB].BackColor = ThamSo.mauNodeDangSX;
            // Cách dùng task
            hoanVi1Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(DanhSachNode[vitriNodeA], vitriNodeB); });
            hoanVi2Task = Task.Factory.StartNew(() => { DiChuyenNodeDen(DanhSachNode[vitriNodeB], vitriNodeA); });
            // note: Task.Factory.StartNew = THÊM task vào cuối hàng đợi và CHẠY ngay khi có thể

            Task.WaitAll(hoanVi1Task, hoanVi1Task);

            // Thay đổi vị trí của node trong mảng nodeArray
            if (DanhSachNode.Count != 0)                   //check xem nếu mảng còn tồn tại --> trong trường hợp mảng đã bị hủy
            {
                CapNhatDanhSachNode(vitriNodeA, vitriNodeB);
            }

            // Đổi màu 2 node sau khi sắp xếp
            DanhSachNode[vitriNodeA].BackColor = DanhSachNode[vitriNodeB].BackColor = ThamSo.mauNodeHTSX;
        }



        #endregion


        #region Cac Ham cap nhat lai mang va Node
        private void CapNhatThamSo(int vt1, int vt2)
        {
            int temp = DanhSachThamSo[vt1];
            DanhSachThamSo[vt1] = DanhSachThamSo[vt2];
            DanhSachThamSo[vt2] = temp;
            DanhSachNode[vt1].BackColor = DanhSachNode[vt2].BackColor = ThamSo.mauNodeDangSX;



        }
        private void CapNhatDanhSachNode(int vt1, int vt2)
        {

            ucNode temp = DanhSachNode[vt1];
            DanhSachNode[vt1] = DanhSachNode[vt2];
            DanhSachNode[vt2] = temp;
            DanhSachNode[vt1].BackColor = DanhSachNode[vt2].BackColor = ThamSo.mauNodeDangSX;
        }
        #endregion

        #region Count Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            DemThoiGian();
        }
        private void DemThoiGian()
        {
            Giay++;
            if (Giay > 59)
            {
                Giay = 0;
                Phut++;
            }

            if (Giay < 10)
            {
                label11.Text = Phut + ":0" + Giay;
            }
            else
            {
                label11.Text = Phut + ":" + Giay;
            }

        }
        #endregion

        #region Các hàm thực hiện thao tác cho nhứng button ở fMenu
        public void ExitButton()
        {
            if (sapxepThread != null)
            {
                sapxepThread.Abort();
            }
            this.Close();
        }

        public void startButton() //Hàm thực hiện thao tác cho btnStart của fMenu
        {
            if(fmenu.NodeTotal != SoLuongNode)
            {
                if(!isEnglish)
                    MessageBox.Show(LanguageChanged.WarnMessVN,LanguageChanged.WarnVN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(LanguageChanged.WarnMessEN, LanguageChanged.WarnEN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sapxepThread != null)
            {
                sapxepThread.Abort();
            }
            //daydangxepListbox.Visible = true;
            picStop.Enabled = true;
            isRunning = true;
            DieuChinhControls(isRunning);
            Reset_CountTime();
            fdes.SortStarted();
            fmenu.SortStarted();
            SortLabelOff();
            timer1.Start();
            //ChonThuatToan();
            sapxepThread = new Thread(new ThreadStart(ThuatToanSapXep));
            sapxepThread.Start();
        }

        public void HandInput()
        {
            fManually fman = new fManually();
            fman.ShowDialog();
            if(fman.isNhap == true)
            {
                string temp = "";
                SoLuongNode = fman.DayInput.Count();
                fmenu.nudN.Value = SoLuongNode;
                VeNut();
                for (int i = 0; i < SoLuongNode; i++)
                {
                    // DanhSachNode[i].Value = input.DayInput[i];
                    DanhSachNode[i].Text = fman.DayInput[i].ToString();
                    DanhSachThamSo[i] = fman.DayInput[i];

                }
                Mangchuasapxep();
            }
        }

        public void RandomInput()
        {
            if (fMain.isRunning)
            {
                StopNow();
            }
            //fMain.SoLuongNode = fMain.rank.Next(2, ThamSo.SoluongNodeLonNhat);
            fmenu.nudN.Value = SoLuongNode = fmenu.NodeTotal;
            VeNut();
        }

        public void StopNow()
        {
            sapxepThread.Abort();
            VeNut();
            isRunning = false;
            for (int i = 0; i < SoLuongNode; i++)
            {
                DanhSachNode[i].Text = MangChuaSapXep[i].ToString();
                DanhSachThamSo[i] = MangChuaSapXep[i];
            }
            DieuChinhControls(isRunning);
            Mangchuasapxep();
            fmenu.SortFinished();
            SortLabelOn();
            Reset_CountTime();
            timer1.Stop();
            picStop.Enabled = false;
        }

        public void DataCleared()
        {
            chuasapxepPanel.Controls.Clear();
            pnlMain.Controls.Clear();
            DanhSachNode.Clear();
            DanhSachThamSo.Clear();
        }


        #endregion

        private void Reset_CountTime()
        {

            Phut = Giay = 0;
            label11.Text = "00:00";
        }
        private void hoanTatSapXep()
        {

            //   HienThiThuatToan.ChayCodeC(1);
            foreach (ucNode item in DanhSachNode)
            {
                item.BackColor = ThamSo.mauNodeHTSX;
            }
            isRunning = false;
            DieuChinhControls(isRunning);
            /*if (isEnglish == true)
            {
                setLang("en-US");
            }
            else
                setLang("vi-VN");
            */
            
            fmenu.SortFinished();
            SortLabelOn();
            timer1.Stop();
            if (!isEnglish)
                MessageBox.Show(LanguageChanged.ArrFinishedVN, LanguageChanged.AnnounVN, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(LanguageChanged.ArrFinishedEN, LanguageChanged.AnnounEN, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset_CountTime();
            foreach (Label label in bienArr.Values)
            {
                label.Visible = false;
            }
            picStop.Enabled = false;

        }

        private void fmenu_trackBarValueChanged(object sender, EventArgs e)
        {
            if(fmenu.trbSpeed.Value >= 4)
            ThamSo.ThoiGianDoi = (8 - fmenu.trbSpeed.Value) * 3;
            else
                ThamSo.ThoiGianDoi = (8 - fmenu.trbSpeed.Value) * 5;
            //label1.Text = fmenu.trbSpeed.Value.ToString();
        }


        ///

        #region Phần thuật toán
        #region BubbleSort
        private void BubbleSort()
        {
            
            bool flag = false;
            HienThiThuatToan.ChayCodeC(2);
            HienThiThuatToan.ChayCodeC(3);
            int i = 0, j = 0;
            //DanhSachNode[i].BackColor = ThamSo.mauNodeHTSX;
            bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
            bienArr["i"].Text = "i = " + i;
            pnlMain.Controls.Add(bienArr["i"]);
            bienArr["i"].Visible = true;
            for (i = 0; i < SoLuongNode - 1; i++)
            {
                HienThiThuatToan.ChayCodeC(4);
                j = SoLuongNode - 1;
                bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 40);
                bienArr["j"].Text = "j = " + j;
                pnlMain.Controls.Add(bienArr["j"]);
                bienArr["j"].Visible = true;
                for (j = SoLuongNode - 1; j > i; j--)
                {
                    //DanhSachNode[j].BackColor = ThamSo.Nodeketiep;
                    flag = false;
                    if (isIncrease == true)
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] < DanhSachThamSo[j - 1]) flag = true;

                    }
                    else
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] > DanhSachThamSo[j - 1]) flag = true;
                        //bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 40);
                        //bienArr["j"].Text = "j = " + j;
                        //sapxepPanel.Controls.Add(bienArr["j"]);
                        //bienArr["j"].Visible = true;
                    }
                    if (flag == true)
                    {
                        HienThiThuatToan.ChayCodeC(6);
                        Thread.Sleep(ThamSo.ThoiGianDoi);
                        //DanhSachNode[j].BackColor = DanhSachNode[j - 1].BackColor = ThamSo.mauNodeDangSX;
                        CapNhatThamSo(j, j - 1);
                        DichuyenCacNode(j, j - 1);
                        //Hienthimangdangsapxep(i, j, "i", "j");
                    }
                    else
                    {
                        //DanhSachNode[j].BackColor = ThamSo.mauNen;
                    }

                }
            }
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            hoanTatSapXep();

        } //xong
        #endregion
        #region InterchangeSort
        private void InterchangeSort()
        {

            int i = 0, j = 0;
            bool flag;

            HienThiThuatToan.ChayCodeC(2);
            for (i = 0; i < SoLuongNode - 1; i++)
            {
                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                bienArr["i"].Text = "i = " + i;
                pnlMain.Controls.Add(bienArr["i"]);
                bienArr["i"].Visible = true;
                HienThiThuatToan.ChayCodeC(3);
                for (j = i + 1; j < SoLuongNode; j++)
                {
                    DanhSachNode[j].BackColor = ThamSo.Nodeketiep;
                    bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 40);
                    bienArr["j"].Text = "j = " + j;
                    pnlMain.Controls.Add(bienArr["j"]);
                    bienArr["j"].Visible = true;
                    HienThiThuatToan.ChayCodeC(4);

                    flag = false;
                    if (isIncrease == true)
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] < DanhSachThamSo[i]) flag = true;
                    }
                    else
                    {
                        HienThiThuatToan.ChayCodeC(5);
                        if (DanhSachThamSo[j] > DanhSachThamSo[i]) flag = true;
                    }
                    if (flag)
                    {
                        HienThiThuatToan.ChayCodeC(6);
                        Thread.Sleep(ThamSo.ThoiGianDoi);

                        CapNhatThamSo(i, j);
                        DichuyenCacNode(j, i);

                        //Hienthimangdangsapxep(i, j, "i", "j");
                    }
                    else
                    {
                        DanhSachNode[j].BackColor = ThamSo.mauNen;
                    }


                }

            }
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            hoanTatSapXep();

        }


        #endregion
        #region BinaryInsectionSort
        public void BinaryInsertionSort()
        {
            //  yTuongTextBox.Clear();
            int left, right, m, i, pos;
            int x;
            ucNode nodeTam, nodeTam2;
            for (i = 1; i < DanhSachNode.Count; i++)
            {
                pos = i - 1;
                HienThiThuatToan.ChayCodeC(4);
                DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                bienArr["i"].Text = "i = " + i;
                pnlMain.Controls.Add(bienArr["i"]);
                bienArr["i"].Visible = true;
                nodeTam = DanhSachNode[i];
                x = DanhSachThamSo[i];
                HienThiThuatToan.ChayCodeC(6);
                DanhSachNode[i].ChuyenLen();
                DanhSachNode[i].BackColor = ThamSo.mauNodeDangSX;
                left = 0;
                right = i - 1;
                bienArr["left"].Location = new Point(danhSachLabel[left].Location.X, danhSachLabel[left].Location.Y - 280);
                bienArr["left"].Text = "left = " + left;
                pnlMain.Controls.Add(bienArr["left"]);
                //bienArr["left"].Visible = true;

                bienArr["pos"].Location = new Point(danhSachLabel[pos].Location.X, danhSachLabel[pos].Location.Y - 240);
                bienArr["pos"].Text = "pos = " + pos;
                pnlMain.Controls.Add(bienArr["pos"]);
                //bienArr["pos"].Visible = false;

                bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y - 260);
                bienArr["right"].Text = "right = " + right;
                pnlMain.Controls.Add(bienArr["right"]);
                //bienArr["right"].Visible = true;
                HienThiThuatToan.ChayCodeC(7);
                while (left <= right)
                {
                    m = (left + right) / 2;

                    if (isIncrease == true)
                    {

                        if (x < DanhSachThamSo[m])
                        {
                            HienThiThuatToan.ChayCodeC(10);
                            bienArr["m"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 60);
                            bienArr["m"].Text = "m = " + i;
                            pnlMain.Controls.Add(bienArr["m"]);
                            //bienArr["m"].Visible = true;
                            //bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y - 260);
                            bienArr["right"].Text = "right = " + right;
                            pnlMain.Controls.Add(bienArr["right"]);
                            // bienArr["right"].Visible = true;

                            right = m - 1;
                            //bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y - 260);
                            bienArr["right"].Text = "right = " + right;
                            pnlMain.Controls.Add(bienArr["right"]);
                            // bienArr["right"].Visible = true;
                        }
                        else
                        {
                            HienThiThuatToan.ChayCodeC(11);
                            //bienArr["m"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 60);
                            bienArr["m"].Text = "m = " + i;
                            pnlMain.Controls.Add(bienArr["m"]);
                            // bienArr["m"].Visible = true;
                            left = m + 1;


                        }
                    }
                    else
                    {
                        if (x > DanhSachThamSo[m])
                        {
                            HienThiThuatToan.ChayCodeC(10);
                            bienArr["m"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 60);
                            bienArr["m"].Text = "m = " + i;
                            pnlMain.Controls.Add(bienArr["m"]);
                            //bienArr["m"].Visible = true;
                            //bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y - 260);
                            bienArr["right"].Text = "right = " + right;
                            pnlMain.Controls.Add(bienArr["right"]);
                            //bienArr["right"].Visible = true;

                            right = m - 1;
                            //bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y - 260);
                            bienArr["right"].Text = "right = " + right;
                            pnlMain.Controls.Add(bienArr["right"]);
                            // bienArr["right"].Visible = true;
                        }
                        else
                        {
                            HienThiThuatToan.ChayCodeC(11);
                            //bienArr["m"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 60);
                            bienArr["m"].Text = "m = " + i;
                            pnlMain.Controls.Add(bienArr["m"]);
                            //bienArr["m"].Visible = true;

                            left = m + 1;


                        }
                    }
                    HienThiThuatToan.ChayCodeC(7);
                    bienArr["left"].Location = new Point(danhSachLabel[left].Location.X, danhSachLabel[left].Location.Y - 280);
                    bienArr["left"].Text = "left = " + left;
                    pnlMain.Controls.Add(bienArr["left"]);
                    //bienArr["left"].Visible = true;
                }
                HienThiThuatToan.ChayCodeC(13);
                //bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y - 260);
                bienArr["right"].Text = "right = " + right;
                pnlMain.Controls.Add(bienArr["right"]);
                // bienArr["right"].Visible = true;
                pos = i - 1;
                //bienArr["pos"].Location = new Point(danhSachLabel[pos].Location.X, danhSachLabel[pos].Location.Y - 240);
                bienArr["pos"].Text = "pos = " + pos;
                pnlMain.Controls.Add(bienArr["pos"]);
                //bienArr["pos"].Visible = true;
                for (pos = i - 1; pos >= left; pos--)
                {
                    //bienArr["pos"].Location = new Point(danhSachLabel[pos].Location.X, danhSachLabel[pos].Location.Y - 240);
                    bienArr["pos"].Text = "pos = " + pos;
                    pnlMain.Controls.Add(bienArr["pos"]);
                    bienArr["pos"].Visible = true;
                    HienThiThuatToan.ChayCodeC(14);
                    DanhSachNode[pos].ChuyenNgang(pos + 1);
                    DanhSachNode[pos].vitriHienTai = pos + 1;
                    nodeTam2 = DanhSachNode[pos + 1];
                    DanhSachNode[pos + 1] = DanhSachNode[pos];
                    DanhSachThamSo[pos + 1] = DanhSachThamSo[pos];
                    DanhSachNode[pos] = nodeTam2;
                }
                //bienArr["pos"].Location = new Point(danhSachLabel[pos].Location.X, danhSachLabel[pos].Location.Y - 240);
                bienArr["pos"].Text = "pos = " + pos;
                pnlMain.Controls.Add(bienArr["pos"]);
                bienArr["pos"].Visible = true;
                HienThiThuatToan.ChayCodeC(15);

                nodeTam.ChuyenNgang(pos + 1);
                nodeTam.ChuyenXuong();
                DanhSachNode[pos + 1] = nodeTam;
                nodeTam.vitriHienTai = pos + 1;
                DanhSachNode[pos + 1].BackColor = ThamSo.mauNodeHTSX;

                DanhSachThamSo[left] = x;

                //Cập nhật ý tưởng Text Box
                //Hienthimangdangsapxep(pos, i, "pos", "i");


            }
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            hoanTatSapXep();
        }

        #endregion
        #region InsertionSort
        private void InsertionSort()
        {
            int pos, key;

            ucNode Nodetam;
            DanhSachNode[0].BackColor = ThamSo.mauNodeDangSX;
            for (int i = 1; i < SoLuongNode; i++)
            {
                HienThiThuatToan.ChayCodeC(5);

                DanhSachNode[i].BackColor = ThamSo.mauNodeDangSX;

                key = DanhSachThamSo[i];
                HienThiThuatToan.ChayCodeC(7);
                Nodetam = DanhSachNode[i];
                pos = i - 1;

                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 40);
                bienArr["i"].Text = "i = " + i;
                pnlMain.Controls.Add(bienArr["i"]);
                bienArr["i"].Visible = true;

                DanhSachNode[i].ChuyenLen();

                DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;

                HienThiThuatToan.ChayCodeC(8);

                bienArr["pos"].Location = new Point(danhSachLabel[pos].Location.X, danhSachLabel[pos].Location.Y - 240);
                bienArr["pos"].Text = "pos = " + pos;
                pnlMain.Controls.Add(bienArr["pos"]);
                bienArr["pos"].Visible = true;

                if (isIncrease == true)
                {
                    while ((pos >= 0) && (DanhSachThamSo[pos] > key))
                    {
                        DanhSachNode[pos].ChuyenNgang(pos + 1);
                        DanhSachNode[pos].vitriHienTai = pos + 1;
                        DanhSachNode[pos + 1] = DanhSachNode[pos];
                        DanhSachThamSo[pos + 1] = DanhSachThamSo[pos];

                        //Hienthimangdangsapxep(pos, pos + 1, "pos", "i");

                        HienThiThuatToan.ChayCodeC(10);

                        pos--;
                    }

                }
                else
                {
                    while ((pos >= 0) && (DanhSachThamSo[pos] < key))
                    {
                        DanhSachNode[pos].ChuyenNgang(pos + 1);
                        DanhSachNode[pos].vitriHienTai = pos + 1;
                        DanhSachNode[pos + 1] = DanhSachNode[pos];
                        DanhSachThamSo[pos + 1] = DanhSachThamSo[pos];
                        //Hienthimangdangsapxep(pos, pos + 1, "pos", "i");
                        HienThiThuatToan.ChayCodeC(10);
                        pos--;
                    }
                }
                Nodetam.ChuyenNgang(pos + 1);
                Nodetam.ChuyenXuong();

                DanhSachThamSo[pos + 1] = key;
                DanhSachNode[pos + 1] = Nodetam;
                Nodetam.vitriHienTai = pos + 1;

                DanhSachNode[pos + 1].BackColor = ThamSo.mauNodeHTSX;

            }
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            hoanTatSapXep();
        }
        #endregion
        #region SelectionSort
        private void SelectionSort()
        {

            int min, i = 0, j = 0;
            bool flag = false;


            HienThiThuatToan.ChayCodeC(2);
            for (i = 0; i < SoLuongNode - 1; i++)
            {

                HienThiThuatToan.ChayCodeC(3);
                HienThiThuatToan.ChayCodeC(5);
                bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                bienArr["i"].Text = "i = " + i;
                pnlMain.Controls.Add(bienArr["i"]);
                bienArr["i"].Visible = true;
                for (j = i + 1; j < SoLuongNode; j++)
                {
                    DanhSachNode[j].BackColor = ThamSo.Nodeketiep;
                    HienThiThuatToan.ChayCodeC(6);
                    flag = false;
                    min = i;
                    bienArr["min"].Location = new Point(danhSachLabel[min].Location.X, danhSachLabel[min].Location.Y - ThamSo.KichCoNode - 180);
                    bienArr["min"].Text = "min = " + min;
                    bienArr["min"].SendToBack();
                    pnlMain.Controls.Add(bienArr["min"]);
                    bienArr["min"].Visible = true;
                    if (isIncrease == true)
                    {

                        HienThiThuatToan.ChayCodeC(7);
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 40);
                        bienArr["j"].Text = "j = " + j;
                        pnlMain.Controls.Add(bienArr["j"]);
                        bienArr["j"].Visible = true;
                        if (DanhSachThamSo[j] < DanhSachThamSo[min])
                        {

                            min = j;

                            flag = true;
                            bienArr["min"].Location = new Point(danhSachLabel[min].Location.X, danhSachLabel[min].Location.Y - ThamSo.KichCoNode - 180);
                            bienArr["min"].Text = "min = " + min;
                            bienArr["min"].SendToBack();
                        }
                    }
                    else
                    {

                        HienThiThuatToan.ChayCodeC(7);
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 40);
                        bienArr["j"].Text = "j = " + j;
                        pnlMain.Controls.Add(bienArr["j"]);
                        if (DanhSachThamSo[j] > DanhSachThamSo[min])
                        {

                            min = j;

                            flag = true;
                            bienArr["min"].Location = new Point(danhSachLabel[min].Location.X, danhSachLabel[min].Location.Y - 180);
                            bienArr["min"].Text = "min = " + min;
                            bienArr["min"].SendToBack();

                        }
                    }
                    if (flag == true)
                    {
                        HienThiThuatToan.ChayCodeC(8);
                        HienThiThuatToan.ChayCodeC(9);
                        Thread.Sleep(ThamSo.ThoiGianDoi);
                        DanhSachNode[i].BackColor = DanhSachNode[min].BackColor = ThamSo.mauNodeDangSX;
                        CapNhatThamSo(min, i);
                        DichuyenCacNode(min, i);
                        //Hienthimangdangsapxep(i, j, "i", "j");
                    }
                    else
                    {
                        DanhSachNode[j].BackColor = ThamSo.mauNen;
                    }
                }
            }
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            hoanTatSapXep();
        }
        #endregion
        #region HeapSort
        private void HeapSort()
        {
            HienThiThuatToan.ChayCodeC(1);
            HienThiThuatToan.ChayCodeC(2);
            CreateHeap(DanhSachThamSo.Count);

            HienThiThuatToan.ChayCodeC(3);
            HienThiThuatToan.ChayCodeC(4);
            int r = DanhSachThamSo.Count - 1;

            HienThiThuatToan.ChayCodeC(5);
            while (r > 0)
            {
                HienThiThuatToan.ChayCodeC(6);
                HienThiThuatToan.ChayCodeC(7);
                CapNhatThamSo(0, r);
                DichuyenCacNode(r, 0);
                HienThiThuatToan.ChayCodeC(8);
                bienArr["right"].Location = new Point(danhSachLabel[r].Location.X, danhSachLabel[r].Location.Y - 240);
                bienArr["right"].Text = "right = " + r;
                pnlMain.Controls.Add(bienArr["right"]);
                bienArr["right"].Visible = true;
                bienArr["right"].SendToBack();
                r--;


                HienThiThuatToan.ChayCodeC(9);
                if (r > 0)
                {
                    HienThiThuatToan.ChayCodeC(10);
                    Shift(0, r);
                }

                HienThiThuatToan.ChayCodeC(11);
                HienThiThuatToan.ChayCodeC(5);
            }
            HienThiThuatToan.ChayCodeC(12);
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            if (DanhSachNode.Count != 0)
            {
                hoanTatSapXep();
            }

        }
        private void CreateHeap(int N)
        {
            HienThiThuatToan.ChayCodeC(14);
            HienThiThuatToan.ChayCodeC(15);
            HienThiThuatToan.ChayCodeC(16);
            HienThiThuatToan.ChayCodeC(17);
            int l = N / 2 - 1;

            HienThiThuatToan.ChayCodeC(18);
            while (l >= 0)
            {
                HienThiThuatToan.ChayCodeC(19);
                HienThiThuatToan.ChayCodeC(20);
                Shift(l, N - 1);

                HienThiThuatToan.ChayCodeC(21);
                bienArr["left"].Location = new Point(danhSachLabel[l].Location.X, danhSachLabel[l].Location.Y - 260);
                bienArr["left"].Text = "left = " + l;
                pnlMain.Controls.Add(bienArr["left"]);
                bienArr["left"].Visible = true;
                bienArr["left"].SendToBack();
                l--;

                HienThiThuatToan.ChayCodeC(22);
                HienThiThuatToan.ChayCodeC(18);
            }

            HienThiThuatToan.ChayCodeC(23);
        }

        private void Shift(int l, int r)
        {
            HienThiThuatToan.ChayCodeC(25);
            HienThiThuatToan.ChayCodeC(26);
            HienThiThuatToan.ChayCodeC(27);
            HienThiThuatToan.ChayCodeC(28);
            int i = l;
            int j = 2 * i + 1;

            HienThiThuatToan.ChayCodeC(29);
            while (j <= r)
            {
                HienThiThuatToan.ChayCodeC(30);
                HienThiThuatToan.ChayCodeC(31);
                if (isIncrease == true)
                {
                    if (j < r && DanhSachThamSo[j] < DanhSachThamSo[j + 1])
                    {
                        HienThiThuatToan.ChayCodeC(32);
                        j++;
                    }
                }
                else
                {
                    if (j < r && DanhSachThamSo[j] > DanhSachThamSo[j + 1])
                    {
                        HienThiThuatToan.ChayCodeC(32);
                        j++;
                    }
                }

                HienThiThuatToan.ChayCodeC(33);
                if (isIncrease == true)
                {
                    if (DanhSachThamSo[i] < DanhSachThamSo[j])
                    {
                        HienThiThuatToan.ChayCodeC(34);
                        HienThiThuatToan.ChayCodeC(35);

                        DichuyenCacNode(j, i);
                        CapNhatThamSo(i, j);
                        //Hienthimangdangsapxep(i, j, "i", "j");


                        HienThiThuatToan.ChayCodeC(36);
                        i = j;

                        HienThiThuatToan.ChayCodeC(37);
                        j = 2 * i + 1;

                        HienThiThuatToan.ChayCodeC(38);
                    }
                    else
                    {
                        HienThiThuatToan.ChayCodeC(39);
                        return;
                    }
                }
                else
                {
                    if (DanhSachThamSo[i] > DanhSachThamSo[j])
                    {
                        HienThiThuatToan.ChayCodeC(34);
                        HienThiThuatToan.ChayCodeC(35);
                        CapNhatThamSo(i, j);
                        DichuyenCacNode(i, j);
                        //Hienthimangdangsapxep(i, j, "i", "j");



                        HienThiThuatToan.ChayCodeC(36);
                        i = j;

                        HienThiThuatToan.ChayCodeC(37);
                        j = 2 * i + 1;

                        HienThiThuatToan.ChayCodeC(38);
                    }
                    else
                    {
                        HienThiThuatToan.ChayCodeC(39);
                        return;
                    }
                }

                HienThiThuatToan.ChayCodeC(40);
                HienThiThuatToan.ChayCodeC(29);
            }
            HienThiThuatToan.ChayCodeC(41);

        }

        #endregion // cần ktra lại   //cần ktra lại 
        #region MergeSoft
        List<ucNode> b = new List<ucNode>();
        List<ucNode> c = new List<ucNode>();
        int nb, nc;

        int Min(int a, int b)
        {
            if (a > b) return b;
            else return a;
        }
        void Distribute(List<ucNode> a, int N, ref int nb, ref int nc, int k)
        {
            int i, pa, pb, pc;
            pa = pb = pc = 0;
            HienThiThuatToan.ChayCodeC(10);

            while (pa < N)
            {
                HienThiThuatToan.ChayCodeC(12);
                for (i = 0; (pa < N) && (i < k); i++, pa++, pb++)
                {

                    //b[pb] = a[pa];
                    HienThiThuatToan.ChayCodeC(13);
                    a[pa].BackColor = ThamSo.mauNodeDangSX;
                    a[pa].ChuyenLen();
                    a[pa].ChuyenNgang(pb);
                    a[pa].vitriHienTai = pb;

                    b[pb] = a[pa];
                    HienThiThuatToan.ChayCodeC(12);
                }
                HienThiThuatToan.ChayCodeC(12);
                HienThiThuatToan.ChayCodeC(14);
                for (i = 0; (pa < N) && (i < k); i++, pa++, pc++)
                {
                    HienThiThuatToan.ChayCodeC(15);
                    //c[pc] = a[pa];
                    a[pa].BackColor = ThamSo.mauNodeDangSX;
                    a[pa].ChuyenXuong();
                    a[pa].ChuyenNgang(pc);
                    a[pa].vitriHienTai = pc;

                    c[pc] = a[pa];

                    HienThiThuatToan.ChayCodeC(14);
                }
                HienThiThuatToan.ChayCodeC(14);
                HienThiThuatToan.ChayCodeC(10);
            }
            HienThiThuatToan.ChayCodeC(10);
            nb = pb; nc = pc;
        }
        void Merge(List<ucNode> a, int nb, int nc, int k)
        {
            int p, pb, pc, ib, ic, kb, kc;
            p = pb = pc = 0; ib = ic = 0;
            HienThiThuatToan.ChayCodeC(23);

            while ((nb > 0) && (nc > 0))
            {
                kb = Min(k, nb);
                kc = Min(k, nc);
                HienThiThuatToan.ChayCodeC(26);

                bool thucHien = false; // dùng để xét tăng/giảm , nếu bằng true thì code sẽ chạy
                if (isIncrease == true)
                {
                    if (c[pc + ic].Value >= b[pb + ib].Value)
                        thucHien = true;
                }
                else
                {
                    if (c[pc + ic].Value <= b[pb + ib].Value)
                        thucHien = true;
                }
                if (thucHien)
                {

                    //a[p++] = b[pb + ib];
                    HienThiThuatToan.ChayCodeC(28);
                    b[pb + ib].BackColor = ThamSo.mauNen;
                    b[pb + ib].ChuyenXuong();
                    b[pb + ib].ChuyenNgang(p);
                    b[pb + ib].vitriHienTai = p;

                    a[p] = b[pb + ib];
                    p = p + 1;

                    ib++;

                    HienThiThuatToan.ChayCodeC(29);
                    if (ib == kb)
                    {
                        HienThiThuatToan.ChayCodeC(31);
                        for (; ic < kc; ic++)
                        {
                            HienThiThuatToan.ChayCodeC(32);
                            //a[p++] = c[pc + ic];
                            c[pc + ic].BackColor = ThamSo.mauNen;
                            c[pc + ic].ChuyenLen();
                            c[pc + ic].ChuyenNgang(p);
                            c[pc + ic].vitriHienTai = p;

                            a[p] = c[pc + ic];
                            p = p + 1;
                            HienThiThuatToan.ChayCodeC(32);
                        }

                        pb += kb; pc += kc; ib = ic = 0;
                        nb -= kb; nc -= kc;
                    }
                }
                else
                {
                    HienThiThuatToan.ChayCodeC(39);
                    //a[p++] = c[pc + ic];
                    c[pc + ic].BackColor = ThamSo.mauNen;
                    c[pc + ic].ChuyenLen();
                    c[pc + ic].ChuyenNgang(p);
                    c[pc + ic].vitriHienTai = p;

                    a[p] = c[pc + ic];
                    p = p + 1;

                    ic++;
                    HienThiThuatToan.ChayCodeC(40);
                    if (ic == kc)
                    {
                        HienThiThuatToan.ChayCodeC(42);
                        for (; ib < kb; ib++)
                        {
                            HienThiThuatToan.ChayCodeC(43);
                            //a[p++] = b[pb + ib];
                            b[pb + ib].BackColor = ThamSo.mauNen;
                            b[pb + ib].ChuyenXuong();
                            b[pb + ib].ChuyenNgang(p);
                            b[pb + ib].vitriHienTai = p;


                            a[p] = b[pb + ib];
                            p = p + 1;
                            HienThiThuatToan.ChayCodeC(43);
                        }
                        HienThiThuatToan.ChayCodeC(42);
                        pb += kb; pc += kc; ib = ic = 0;
                        nb -= kb; nc -= kc;
                    }
                }

                HienThiThuatToan.ChayCodeC(23);
            }  // while
            HienThiThuatToan.ChayCodeC(23);
            if (a.Count % 2 == 1 && (k != (a.Count - 1)))
            {
                if (nb > nc)
                {
                    HienThiThuatToan.ChayCodeC(43);
                    b[pb].BackColor = ThamSo.mauNen;
                    b[pb].ChuyenXuong();
                    b[pb].ChuyenNgang(a.Count - 1);
                    b[pb].vitriHienTai = a.Count - 1;

                }

            }
            if (a.Count % 2 == 0 && Math.Abs(nb - nc) == 2)
            {

                HienThiThuatToan.ChayCodeC(43);
                b[pb].BackColor = ThamSo.mauNen;
                b[pb].ChuyenXuong();
                b[pb].ChuyenNgang(a.Count - 2);
                b[pb].vitriHienTai = a.Count - 2;
                HienThiThuatToan.ChayCodeC(43);
                b[pb + 1].BackColor = ThamSo.mauNen;
                b[pb + 1].ChuyenXuong();
                b[pb + 1].ChuyenNgang(a.Count - 1);
                b[pb + 1].vitriHienTai = a.Count - 1;


            }

            ;
        }
        void ThucHienMergeSort(List<ucNode> a, int N)
        {
            for (int i = 0; i < SoLuongNode; i++)
            {
                b.Add(new ucNode(i));
                c.Add(new ucNode(i));
            }
            int k;
            HienThiThuatToan.ChayCodeC(53);
            for (k = 1; k < N; k *= 2)
            {
                bienArr["k"].Location = new Point(danhSachLabel[k].Location.X, danhSachLabel[k].Location.Y - 260);
                bienArr["k"].Text = "k = " + k;
                pnlMain.Controls.Add(bienArr["k"]);
                bienArr["k"].Visible = true;
                HienThiThuatToan.ChayCodeC(55);
                Distribute(a, N, ref nb, ref nc, k);
                HienThiThuatToan.ChayCodeC(56);
                Merge(a, nb, nc, k);
                HienThiThuatToan.ChayCodeC(53);
            }
            HienThiThuatToan.ChayCodeC(53);
        }

        void MergeSort()
        {
            //  yTuongTextBox.Clear();
            bienArr["a:"].Location = new Point(0, 110 + DanhSachNode[0].Height / 2);
            bienArr["a:"].Text = "a:";
            pnlMain.Controls.Add(bienArr["a:"]);
            bienArr["c:"].Location = new Point(0, 160 + DanhSachNode[0].Height / 2);
            bienArr["c:"].Text = "c:";
            pnlMain.Controls.Add(bienArr["c:"]);
            bienArr["b:"].Location = new Point(0, 60 + DanhSachNode[0].Height / 2);
            bienArr["b:"].Text = "b:";
            pnlMain.Controls.Add(bienArr["b:"]);
            bienArr["a:"].Visible = bienArr["b:"].Visible = bienArr["c:"].Visible = true;
            HienThiThuatToan.ChayCodeC(51);
            ThucHienMergeSort(DanhSachNode, DanhSachNode.Count);
            foreach (ucNode node in DanhSachNode)
            {
                node.BackColor = ThamSo.mauNodeHTSX;
            }
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            hoanTatSapXep();

        }


        #endregion
        #region QuickSort
        public void QuickSort()
        {
            ThucHienQuickSort(0, DanhSachThamSo.Count - 1);
            DanhSachNode[0].BackColor = ThamSo.mauNodeHTSX;
            DanhSachNode[DanhSachNode.Count - 1].BackColor = ThamSo.mauNodeHTSX;
            hoanTatSapXep();
        }
        private void ThucHienQuickSort(int left, int right)
        {
            HienThiThuatToan.ChayCodeC(1);
            int i, j, x, vt_x;
            bienArr["left"].Text = "left = " + left;
            bienArr["left"].Location = new Point(danhSachLabel[left].Location.X, danhSachLabel[left].Location.Y - 260);
            pnlMain.Controls.Add(bienArr["left"]);
            bienArr["left"].Visible = true;
            bienArr["left"].SendToBack();

            bienArr["right"].Text = "right = " + right;
            bienArr["right"].Location = new Point(danhSachLabel[right].Location.X, danhSachLabel[right].Location.Y - 240);
            pnlMain.Controls.Add(bienArr["right"]);
            bienArr["right"].Visible = true;
            bienArr["right"].SendToBack();
            x = DanhSachThamSo[(left + right) / 2];
            HienThiThuatToan.ChayCodeC(3);
            vt_x = (left + right) / 2;
            i = left; j = right;
            do
            {
                int z_vt_x = vt_x;
                if (isIncrease == true)
                {
                    HienThiThuatToan.ChayCodeC(7);
                    bienArr["vt_x"].Location = new Point(danhSachLabel[vt_x].Location.X, danhSachLabel[vt_x].Location.Y - 40);
                    bienArr["vt_x"].Text = "x = a[" + vt_x + "]";
                    pnlMain.Controls.Add(bienArr["vt_x"]);
                    bienArr["vt_x"].Visible = true;
                    bienArr["vt_x"].SendToBack();

                    bienArr["i"].Text = "i = " + i;
                    bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                    pnlMain.Controls.Add(bienArr["i"]);
                    bienArr["i"].Visible = true;
                    bienArr["i"].SendToBack();

                    bienArr["j"].Text = "j = " + j;
                    bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 60);
                    pnlMain.Controls.Add(bienArr["j"]);
                    bienArr["j"].Visible = true;
                    bienArr["j"].SendToBack();
                    while (DanhSachThamSo[i] < x)
                    {
                        HienThiThuatToan.ChayCodeC(8);
                        int f_i = i;
                        i++;
                        bienArr["i"].Text = "i = " + i;
                        bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                        pnlMain.Controls.Add(bienArr["i"]);
                        bienArr["i"].Visible = true;
                        bienArr["i"].SendToBack();
                    }
                    HienThiThuatToan.ChayCodeC(9);
                    while (DanhSachThamSo[j] > x)
                    {
                        HienThiThuatToan.ChayCodeC(10);
                        int f_j = j;
                        j--;
                        bienArr["j"].Text = "j = " + j;
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 60);
                        pnlMain.Controls.Add(bienArr["j"]);
                        bienArr["j"].Visible = true;
                        bienArr["j"].SendToBack();
                    }
                }
                else
                {
                    HienThiThuatToan.ChayCodeC(7);
                    bienArr["vt_x"].Location = new Point(danhSachLabel[vt_x].Location.X, danhSachLabel[vt_x].Location.Y - 40);
                    bienArr["vt_x"].Text = "x = a[" + vt_x + "]";
                    pnlMain.Controls.Add(bienArr["vt_x"]);
                    bienArr["vt_x"].Visible = true;
                    bienArr["vt_x"].SendToBack();

                    bienArr["i"].Text = "i = " + i;
                    bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                    pnlMain.Controls.Add(bienArr["i"]);
                    bienArr["i"].Visible = true;
                    bienArr["i"].SendToBack();

                    bienArr["j"].Text = "j = " + j;
                    bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 60);
                    pnlMain.Controls.Add(bienArr["j"]);
                    bienArr["j"].Visible = true;
                    bienArr["j"].SendToBack();
                    while (DanhSachThamSo[i] > x)
                    {
                        HienThiThuatToan.ChayCodeC(8);
                        int f_i = i;
                        i++;
                        bienArr["i"].Text = "i = " + i;
                        bienArr["i"].Location = new Point(danhSachLabel[i].Location.X, danhSachLabel[i].Location.Y - 20);
                        pnlMain.Controls.Add(bienArr["i"]);
                        bienArr["i"].Visible = true;
                        bienArr["i"].SendToBack();
                    }
                    HienThiThuatToan.ChayCodeC(9);
                    while (DanhSachThamSo[j] < x)
                    {
                        HienThiThuatToan.ChayCodeC(10);
                        int f_j = j;
                        j--;
                        bienArr["j"].Text = "j = " + j;
                        bienArr["j"].Location = new Point(danhSachLabel[j].Location.X, danhSachLabel[j].Location.Y - 60);
                        pnlMain.Controls.Add(bienArr["j"]);
                        bienArr["j"].Visible = true;
                        bienArr["j"].SendToBack();
                    }
                }
                HienThiThuatToan.ChayCodeC(11);
                if (i <= j)
                {
                    int f_vt_x = vt_x;
                    if (i == vt_x)
                    {
                        vt_x = j;
                    }
                    else if (j == vt_x)
                    {
                        vt_x = i;
                    }
                    HienThiThuatToan.ChayCodeC(13);
                    CapNhatThamSo(i, j);
                    DichuyenCacNode(j, i);
                    //Hienthimangdangsapxep(i, j, "i", "j");
                    bienArr["vt_x"].Location = new Point(danhSachLabel[vt_x].Location.X, danhSachLabel[vt_x].Location.Y - 40);
                    bienArr["vt_x"].Text = "x = a[" + vt_x + "]";
                    pnlMain.Controls.Add(bienArr["vt_x"]);
                    bienArr["vt_x"].Visible = true;
                    bienArr["vt_x"].SendToBack();
                    i++; j--;
                }

                HienThiThuatToan.ChayCodeC(16);
            } while (i <= j);
            HienThiThuatToan.ChayCodeC(17);
            if (left < j)
            {
                HienThiThuatToan.ChayCodeC(18);
                ThucHienQuickSort(left, j);
            }
            HienThiThuatToan.ChayCodeC(19);
            if (i < right)
            {
                HienThiThuatToan.ChayCodeC(20);
                ThucHienQuickSort(i, right);
            }

        }
        #endregion//xong      

        public static bool CodertbxIsPause = false;
        #endregion
        #region Phần Debug dùng manualresetevent
        public void XuLyDebug()
        {
            if (cboxdebug.Checked == true)
            {
                ThamSo.ThoiGianDoi = 1;
                picResPau.Enabled = false;
                ucNode.pauseStatus.Set();
                ucNode.IsPause = false;
                isDebug = true;
                timer1.Stop();
                Reset_CountTime();
            }
            else
            {
                picResPau.Enabled = true;
                HienThiThuatToan.tamdung.Set();
                ucNode.pauseStatus.Set();
                ucNode.IsPause = false;
                isDebug = false;
            }



        }

       

        private void picArrow_Click(object sender, EventArgs e)
        {
            if (isDebug == true)
            {
                // batdaubtn.Enabled = true;
                //  Nếu đang ở chế độ thường thì chuyển thành Debug
                if (!cboxdebug.Checked)
                    cboxdebug.Checked = true;

                // Chạy code
                //đặt sign kích hoạt manualresetevent => tạm dừng đợi trong khoảng thời gian vô tận
                HienThiThuatToan.tamdung.Set();
                CodertbxIsPause = false;
            }
        }
        #endregion


        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sapxepThread != null)
            {
                sapxepThread.Abort();
            }
        }

        private void pnlMain_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cboxdebug_CheckedChanged_1(object sender, EventArgs e)
        {
            XuLyDebug();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sapxepThread != null)
            {
                sapxepThread.Abort();
            }
        }
    }
}
