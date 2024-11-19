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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpCreate.SuspendLayout();
            this.tpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.White;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(154, 21);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(127, 38);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudN);
            this.panel1.Location = new System.Drawing.Point(61, 22);
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
            2,
            0,
            0,
            0});
            // 
            // btnHand
            // 
            this.btnHand.BackColor = System.Drawing.Color.White;
            this.btnHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHand.Location = new System.Drawing.Point(287, 21);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(116, 38);
            this.btnHand.TabIndex = 3;
            this.btnHand.Text = "Nhập tay";
            this.btnHand.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(154, 113);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(23, 29);
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
            this.tabControl1.Size = new System.Drawing.Size(592, 228);
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
            this.tpCreate.Size = new System.Drawing.Size(584, 196);
            this.tpCreate.TabIndex = 0;
            this.tpCreate.Text = "Khởi tạo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 113);
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
            this.btnDelete.Location = new System.Drawing.Point(409, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa mảng";
            this.btnDelete.UseVisualStyleBackColor = false;
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
            this.tpSetting.Size = new System.Drawing.Size(584, 196);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "Cài đặt";
            // 
            // lblSpeedShow
            // 
            this.lblSpeedShow.AutoSize = true;
            this.lblSpeedShow.Location = new System.Drawing.Point(350, 164);
            this.lblSpeedShow.Name = "lblSpeedShow";
            this.lblSpeedShow.Size = new System.Drawing.Size(25, 19);
            this.lblSpeedShow.TabIndex = 18;
            this.lblSpeedShow.Text = "1x";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(17, 127);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(71, 23);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Text = "Tốc độ";
            // 
            // trbSpeed
            // 
            this.trbSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trbSpeed.Location = new System.Drawing.Point(142, 127);
            this.trbSpeed.Maximum = 8;
            this.trbSpeed.Name = "trbSpeed";
            this.trbSpeed.Size = new System.Drawing.Size(433, 56);
            this.trbSpeed.TabIndex = 16;
            this.trbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbSpeed.Scroll += new System.EventHandler(this.trbSpeed_Scroll);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.White;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(142, 63);
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
            this.btnIncOrDes.Location = new System.Drawing.Point(140, 11);
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
            this.lblLanguage.Location = new System.Drawing.Point(17, 75);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(95, 23);
            this.lblLanguage.TabIndex = 13;
            this.lblLanguage.Text = "Ngôn ngữ";
            // 
            // lblSortHow
            // 
            this.lblSortHow.AutoSize = true;
            this.lblSortHow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortHow.Location = new System.Drawing.Point(17, 23);
            this.lblSortHow.Name = "lblSortHow";
            this.lblSortHow.Size = new System.Drawing.Size(82, 23);
            this.lblSortHow.TabIndex = 12;
            this.lblSortHow.Text = "Sắp xếp";
            // 
            // tbCustomize
            // 
            this.tbCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbCustomize.Location = new System.Drawing.Point(4, 28);
            this.tbCustomize.Name = "tbCustomize";
            this.tbCustomize.Size = new System.Drawing.Size(584, 196);
            this.tbCustomize.TabIndex = 2;
            this.tbCustomize.Text = "Tùy chỉnh";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(591, 228);
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
    }
}