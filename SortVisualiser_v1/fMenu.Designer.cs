namespace SortVisualiser_v1
{
    partial class fMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.lblSpeedShow = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trbSpeed = new System.Windows.Forms.TrackBar();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnIncOrDes = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblSortHow = new System.Windows.Forms.Label();
            this.tbCustomize = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbNodeSortedColor = new System.Windows.Forms.Label();
            this.btnNodeSortedColor = new System.Windows.Forms.Button();
            this.btnNodeChoosingColor = new System.Windows.Forms.Button();
            this.lbNodeChoosingColor = new System.Windows.Forms.Label();
            this.btnNodeBackColor = new System.Windows.Forms.Button();
            this.btnNodeSpaceInc = new System.Windows.Forms.Button();
            this.btnNodeSpaceDes = new System.Windows.Forms.Button();
            this.btnNodeSpace = new System.Windows.Forms.Button();
            this.tbNodeSpace = new System.Windows.Forms.TextBox();
            this.btnNodeSizeInc = new System.Windows.Forms.Button();
            this.btnNodeSizeDes = new System.Windows.Forms.Button();
            this.btnNodeSizeChange = new System.Windows.Forms.Button();
            this.tbNodeSize = new System.Windows.Forms.TextBox();
            this.lbNodeBackColor = new System.Windows.Forms.Label();
            this.lbNodeSpace = new System.Windows.Forms.Label();
            this.lbNodeSize = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpCreate.SuspendLayout();
            this.tpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.tbCustomize.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.White;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(154, 75);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(127, 38);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudN);
            this.panel1.Location = new System.Drawing.Point(61, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 38);
            this.panel1.TabIndex = 2;
            // 
            // nudN
            // 
            this.nudN.BackColor = System.Drawing.Color.White;
            this.nudN.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudN.Location = new System.Drawing.Point(0, 5);
            this.nudN.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(87, 27);
            this.nudN.TabIndex = 3;
            this.nudN.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudN.ValueChanged += new System.EventHandler(this.nudN_ValueChanged);
            // 
            // btnHand
            // 
            this.btnHand.BackColor = System.Drawing.Color.White;
            this.btnHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHand.Location = new System.Drawing.Point(287, 75);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(116, 38);
            this.btnHand.TabIndex = 3;
            this.btnHand.Text = "Nhập tay";
            this.btnHand.UseVisualStyleBackColor = false;
            this.btnHand.Click += new System.EventHandler(this.btnHand_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(154, 194);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(23, 83);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(32, 22);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "N =";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCreate);
            this.tabControl1.Controls.Add(this.tpSetting);
            this.tabControl1.Controls.Add(this.tbCustomize);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 330);
            this.tabControl1.TabIndex = 8;
            // 
            // tpCreate
            // 
            this.tpCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpCreate.Controls.Add(this.button1);
            this.tpCreate.Controls.Add(this.btnDelete);
            this.tpCreate.Controls.Add(this.panel1);
            this.tpCreate.Controls.Add(this.lblN);
            this.tpCreate.Controls.Add(this.btnRandom);
            this.tpCreate.Controls.Add(this.btnStart);
            this.tpCreate.Controls.Add(this.btnHand);
            this.tpCreate.Location = new System.Drawing.Point(4, 28);
            this.tpCreate.Name = "tpCreate";
            this.tpCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreate.Size = new System.Drawing.Size(587, 298);
            this.tpCreate.TabIndex = 0;
            this.tpCreate.Text = "Khởi tạo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "NULL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(409, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa mảng";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tpSetting
            // 
            this.tpSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpSetting.Controls.Add(this.lblSpeedShow);
            this.tpSetting.Controls.Add(this.lblSpeed);
            this.tpSetting.Controls.Add(this.trbSpeed);
            this.tpSetting.Controls.Add(this.btnLanguage);
            this.tpSetting.Controls.Add(this.btnIncOrDes);
            this.tpSetting.Controls.Add(this.lblLanguage);
            this.tpSetting.Controls.Add(this.lblSortHow);
            this.tpSetting.Location = new System.Drawing.Point(4, 28);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(587, 298);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "Cài đặt";
            // 
            // lblSpeedShow
            // 
            this.lblSpeedShow.AutoSize = true;
            this.lblSpeedShow.Location = new System.Drawing.Point(350, 249);
            this.lblSpeedShow.Name = "lblSpeedShow";
            this.lblSpeedShow.Size = new System.Drawing.Size(25, 19);
            this.lblSpeedShow.TabIndex = 18;
            this.lblSpeedShow.Text = "1x";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(19, 221);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(71, 23);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Text = "Tốc độ";
            // 
            // trbSpeed
            // 
            this.trbSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trbSpeed.Location = new System.Drawing.Point(144, 221);
            this.trbSpeed.Maximum = 8;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(433, 56);
            this.trbSpeed.TabIndex = 16;
            this.trbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbSpeed.Value = 4;
            this.trbSpeed.Scroll += new System.EventHandler(this.trbSpeed_Scroll);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.White;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(144, 123);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(433, 46);
            this.btnLanguage.TabIndex = 15;
            this.btnLanguage.Text = "Tiếng Việt";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnIncOrDes
            // 
            this.btnIncOrDes.BackColor = System.Drawing.Color.White;
            this.btnIncOrDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncOrDes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncOrDes.Location = new System.Drawing.Point(142, 35);
            this.btnIncOrDes.Name = "btnIncOrDes";
            this.btnIncOrDes.Size = new System.Drawing.Size(435, 46);
            this.btnIncOrDes.TabIndex = 14;
            this.btnIncOrDes.Text = "Tăng";
            this.btnIncOrDes.UseVisualStyleBackColor = false;
            this.btnIncOrDes.Click += new System.EventHandler(this.btnIncOrDes_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(19, 135);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(95, 23);
            this.lblLanguage.TabIndex = 13;
            this.lblLanguage.Text = "Ngôn ngữ";
            // 
            // lblSortHow
            // 
            this.lblSortHow.AutoSize = true;
            this.lblSortHow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortHow.Location = new System.Drawing.Point(19, 47);
            this.lblSortHow.Name = "lblSortHow";
            this.lblSortHow.Size = new System.Drawing.Size(82, 23);
            this.lblSortHow.TabIndex = 12;
            this.lblSortHow.Text = "Sắp xếp";
            // 
            // tbCustomize
            // 
            this.tbCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbCustomize.Controls.Add(this.panel2);
            this.tbCustomize.Location = new System.Drawing.Point(4, 28);
            this.tbCustomize.Name = "tbCustomize";
            this.tbCustomize.Size = new System.Drawing.Size(587, 298);
            this.tbCustomize.TabIndex = 2;
            this.tbCustomize.Text = "Tùy chỉnh";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnDefault);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.lbNodeSortedColor);
            this.panel2.Controls.Add(this.btnNodeSortedColor);
            this.panel2.Controls.Add(this.btnNodeChoosingColor);
            this.panel2.Controls.Add(this.lbNodeChoosingColor);
            this.panel2.Controls.Add(this.btnNodeBackColor);
            this.panel2.Controls.Add(this.btnNodeSpaceInc);
            this.panel2.Controls.Add(this.btnNodeSpaceDes);
            this.panel2.Controls.Add(this.btnNodeSpace);
            this.panel2.Controls.Add(this.tbNodeSpace);
            this.panel2.Controls.Add(this.btnNodeSizeInc);
            this.panel2.Controls.Add(this.btnNodeSizeDes);
            this.panel2.Controls.Add(this.btnNodeSizeChange);
            this.panel2.Controls.Add(this.tbNodeSize);
            this.panel2.Controls.Add(this.lbNodeBackColor);
            this.panel2.Controls.Add(this.lbNodeSpace);
            this.panel2.Controls.Add(this.lbNodeSize);
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 291);
            this.panel2.TabIndex = 0;
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.White;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.Location = new System.Drawing.Point(299, 318);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(255, 46);
            this.btnDefault.TabIndex = 29;
            this.btnDefault.Text = "Mặc định";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(3, 318);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(255, 46);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbNodeSortedColor
            // 
            this.lbNodeSortedColor.AutoSize = true;
            this.lbNodeSortedColor.Location = new System.Drawing.Point(18, 258);
            this.lbNodeSortedColor.Name = "lbNodeSortedColor";
            this.lbNodeSortedColor.Size = new System.Drawing.Size(165, 23);
            this.lbNodeSortedColor.TabIndex = 27;
            this.lbNodeSortedColor.Text = "Màu Node đã xếp";
            // 
            // btnNodeSortedColor
            // 
            this.btnNodeSortedColor.BackColor = System.Drawing.Color.Gray;
            this.btnNodeSortedColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeSortedColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSortedColor.Location = new System.Drawing.Point(224, 246);
            this.btnNodeSortedColor.Name = "btnNodeSortedColor";
            this.btnNodeSortedColor.Size = new System.Drawing.Size(280, 46);
            this.btnNodeSortedColor.TabIndex = 26;
            this.btnNodeSortedColor.UseVisualStyleBackColor = false;
            this.btnNodeSortedColor.Click += new System.EventHandler(this.btnNodeSortedColor_Click);
            // 
            // btnNodeChoosingColor
            // 
            this.btnNodeChoosingColor.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNodeChoosingColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeChoosingColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeChoosingColor.Location = new System.Drawing.Point(226, 187);
            this.btnNodeChoosingColor.Name = "btnNodeChoosingColor";
            this.btnNodeChoosingColor.Size = new System.Drawing.Size(280, 46);
            this.btnNodeChoosingColor.TabIndex = 24;
            this.btnNodeChoosingColor.UseVisualStyleBackColor = false;
            this.btnNodeChoosingColor.Click += new System.EventHandler(this.btnNodeChoosingColor_Click);
            // 
            // lbNodeChoosingColor
            // 
            this.lbNodeChoosingColor.AutoSize = true;
            this.lbNodeChoosingColor.Location = new System.Drawing.Point(18, 199);
            this.lbNodeChoosingColor.Name = "lbNodeChoosingColor";
            this.lbNodeChoosingColor.Size = new System.Drawing.Size(200, 23);
            this.lbNodeChoosingColor.TabIndex = 23;
            this.lbNodeChoosingColor.Text = "Màu Node được chọn";
            // 
            // btnNodeBackColor
            // 
            this.btnNodeBackColor.BackColor = System.Drawing.Color.White;
            this.btnNodeBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeBackColor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeBackColor.Location = new System.Drawing.Point(226, 128);
            this.btnNodeBackColor.Name = "btnNodeBackColor";
            this.btnNodeBackColor.Size = new System.Drawing.Size(280, 46);
            this.btnNodeBackColor.TabIndex = 22;
            this.btnNodeBackColor.UseVisualStyleBackColor = false;
            this.btnNodeBackColor.Click += new System.EventHandler(this.btnNodeBackColor_Click);
            // 
            // btnNodeSpaceInc
            // 
            this.btnNodeSpaceInc.BackColor = System.Drawing.Color.White;
            this.btnNodeSpaceInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeSpaceInc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSpaceInc.Location = new System.Drawing.Point(504, 69);
            this.btnNodeSpaceInc.Name = "btnNodeSpaceInc";
            this.btnNodeSpaceInc.Size = new System.Drawing.Size(48, 46);
            this.btnNodeSpaceInc.TabIndex = 21;
            this.btnNodeSpaceInc.Text = ">";
            this.btnNodeSpaceInc.UseVisualStyleBackColor = false;
            this.btnNodeSpaceInc.Click += new System.EventHandler(this.btnNodeSpaceInc_Click);
            // 
            // btnNodeSpaceDes
            // 
            this.btnNodeSpaceDes.BackColor = System.Drawing.Color.White;
            this.btnNodeSpaceDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeSpaceDes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSpaceDes.Location = new System.Drawing.Point(178, 69);
            this.btnNodeSpaceDes.Name = "btnNodeSpaceDes";
            this.btnNodeSpaceDes.Size = new System.Drawing.Size(48, 46);
            this.btnNodeSpaceDes.TabIndex = 20;
            this.btnNodeSpaceDes.Text = "<";
            this.btnNodeSpaceDes.UseVisualStyleBackColor = false;
            this.btnNodeSpaceDes.Click += new System.EventHandler(this.btnNodeSpaceDes_Click);
            // 
            // btnNodeSpace
            // 
            this.btnNodeSpace.BackColor = System.Drawing.Color.White;
            this.btnNodeSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeSpace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSpace.Location = new System.Drawing.Point(178, 69);
            this.btnNodeSpace.Name = "btnNodeSpace";
            this.btnNodeSpace.Size = new System.Drawing.Size(374, 46);
            this.btnNodeSpace.TabIndex = 19;
            this.btnNodeSpace.Text = "15";
            this.btnNodeSpace.UseVisualStyleBackColor = false;
            this.btnNodeSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNodeSpace_MouseDown);
            // 
            // tbNodeSpace
            // 
            this.tbNodeSpace.Location = new System.Drawing.Point(275, 77);
            this.tbNodeSpace.Name = "tbNodeSpace";
            this.tbNodeSpace.Size = new System.Drawing.Size(185, 30);
            this.tbNodeSpace.TabIndex = 18;
            this.tbNodeSpace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNodeSpace_KeyDown);
            this.tbNodeSpace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNodeSpace_KeyPress);
            this.tbNodeSpace.Leave += new System.EventHandler(this.tbNodeSpace_Leave);
            // 
            // btnNodeSizeInc
            // 
            this.btnNodeSizeInc.BackColor = System.Drawing.Color.White;
            this.btnNodeSizeInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeSizeInc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSizeInc.Location = new System.Drawing.Point(504, 10);
            this.btnNodeSizeInc.Name = "btnNodeSizeInc";
            this.btnNodeSizeInc.Size = new System.Drawing.Size(48, 46);
            this.btnNodeSizeInc.TabIndex = 17;
            this.btnNodeSizeInc.Text = ">";
            this.btnNodeSizeInc.UseVisualStyleBackColor = false;
            this.btnNodeSizeInc.Click += new System.EventHandler(this.btnNodeSizeInc_Click);
            // 
            // btnNodeSizeDes
            // 
            this.btnNodeSizeDes.BackColor = System.Drawing.Color.White;
            this.btnNodeSizeDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeSizeDes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSizeDes.Location = new System.Drawing.Point(178, 10);
            this.btnNodeSizeDes.Name = "btnNodeSizeDes";
            this.btnNodeSizeDes.Size = new System.Drawing.Size(48, 46);
            this.btnNodeSizeDes.TabIndex = 16;
            this.btnNodeSizeDes.Text = "<";
            this.btnNodeSizeDes.UseVisualStyleBackColor = false;
            this.btnNodeSizeDes.Click += new System.EventHandler(this.btnNodeSizeDes_Click);
            // 
            // btnNodeSizeChange
            // 
            this.btnNodeSizeChange.BackColor = System.Drawing.Color.White;
            this.btnNodeSizeChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodeSizeChange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSizeChange.Location = new System.Drawing.Point(178, 10);
            this.btnNodeSizeChange.Name = "btnNodeSizeChange";
            this.btnNodeSizeChange.Size = new System.Drawing.Size(374, 46);
            this.btnNodeSizeChange.TabIndex = 15;
            this.btnNodeSizeChange.Text = "45";
            this.btnNodeSizeChange.UseVisualStyleBackColor = false;
            this.btnNodeSizeChange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNodeSizeChange_MouseDown);
            // 
            // tbNodeSize
            // 
            this.tbNodeSize.Location = new System.Drawing.Point(275, 18);
            this.tbNodeSize.Name = "tbNodeSize";
            this.tbNodeSize.Size = new System.Drawing.Size(185, 30);
            this.tbNodeSize.TabIndex = 3;
            this.tbNodeSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNodeSize_KeyDown);
            this.tbNodeSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNodeSize_KeyPress);
            this.tbNodeSize.Leave += new System.EventHandler(this.tbNodeSize_Leave);
            // 
            // lbNodeBackColor
            // 
            this.lbNodeBackColor.AutoSize = true;
            this.lbNodeBackColor.Location = new System.Drawing.Point(18, 140);
            this.lbNodeBackColor.Name = "lbNodeBackColor";
            this.lbNodeBackColor.Size = new System.Drawing.Size(137, 23);
            this.lbNodeBackColor.TabIndex = 2;
            this.lbNodeBackColor.Text = "Màu nền Node";
            // 
            // lbNodeSpace
            // 
            this.lbNodeSpace.AutoSize = true;
            this.lbNodeSpace.Location = new System.Drawing.Point(18, 81);
            this.lbNodeSpace.Name = "lbNodeSpace";
            this.lbNodeSpace.Size = new System.Drawing.Size(123, 23);
            this.lbNodeSpace.TabIndex = 1;
            this.lbNodeSpace.Text = "Khoảng cách";
            // 
            // lbNodeSize
            // 
            this.lbNodeSize.AutoSize = true;
            this.lbNodeSize.Location = new System.Drawing.Point(18, 25);
            this.lbNodeSize.Name = "lbNodeSize";
            this.lbNodeSize.Size = new System.Drawing.Size(89, 23);
            this.lbNodeSize.TabIndex = 0;
            this.lbNodeSize.Text = "Cỡ Node";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(595, 331);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMenu";
            this.Text = "ChildForm1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpCreate.ResumeLayout(false);
            this.tpCreate.PerformLayout();
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).EndInit();
            this.tbCustomize.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblSortHow;
        private System.Windows.Forms.TabPage tbCustomize;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSpeedShow;
        public System.Windows.Forms.Button btnRandom;
        public System.Windows.Forms.NumericUpDown nudN;
        public System.Windows.Forms.Button btnHand;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnLanguage;
        public System.Windows.Forms.Button btnIncOrDes;
        public System.Windows.Forms.TrackBar trbSpeed;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNodeSpace;
        private System.Windows.Forms.Label lbNodeSize;
        private System.Windows.Forms.TextBox tbNodeSize;
        private System.Windows.Forms.Label lbNodeBackColor;
        public System.Windows.Forms.Button btnNodeSizeChange;
        private System.Windows.Forms.Button btnNodeSizeInc;
        private System.Windows.Forms.Button btnNodeSizeDes;
        private System.Windows.Forms.Button btnNodeSpaceInc;
        private System.Windows.Forms.Button btnNodeSpaceDes;
        public System.Windows.Forms.Button btnNodeSpace;
        private System.Windows.Forms.TextBox tbNodeSpace;
        public System.Windows.Forms.Button btnNodeBackColor;
        private System.Windows.Forms.Label lbNodeChoosingColor;
        public System.Windows.Forms.Button btnNodeChoosingColor;
        private System.Windows.Forms.Label lbNodeSortedColor;
        public System.Windows.Forms.Button btnNodeSortedColor;
        public System.Windows.Forms.Button btnDefault;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}