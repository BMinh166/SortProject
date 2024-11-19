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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnHand = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCreate = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.lblSpeedShow = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnIncOrDes = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblSortHow = new System.Windows.Forms.Label();
            this.tbCustomize = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpCreate.SuspendLayout();
            this.tpSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(154, 21);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(127, 38);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(61, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 38);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(0, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 27);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnHand
            // 
            this.btnHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHand.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHand.Location = new System.Drawing.Point(287, 21);
            this.btnHand.Name = "btnHand";
            this.btnHand.Size = new System.Drawing.Size(116, 38);
            this.btnHand.TabIndex = 3;
            this.btnHand.Text = "Nhập tay";
            this.btnHand.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(154, 113);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
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
            this.tabControl1.Size = new System.Drawing.Size(591, 230);
            this.tabControl1.TabIndex = 8;
            // 
            // tpCreate
            // 
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
            this.tpCreate.Size = new System.Drawing.Size(583, 198);
            this.tpCreate.TabIndex = 0;
            this.tpCreate.Text = "Khởi tạo";
            this.tpCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(409, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 38);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa mảng";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.lblSpeedShow);
            this.tpSetting.Controls.Add(this.lblSpeed);
            this.tpSetting.Controls.Add(this.trackBar1);
            this.tpSetting.Controls.Add(this.btnLanguage);
            this.tpSetting.Controls.Add(this.btnIncOrDes);
            this.tpSetting.Controls.Add(this.lblLanguage);
            this.tpSetting.Controls.Add(this.lblSortHow);
            this.tpSetting.Location = new System.Drawing.Point(4, 28);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(583, 198);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "Cài đặt";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // lblSpeedShow
            // 
            this.lblSpeedShow.AutoSize = true;
            this.lblSpeedShow.Location = new System.Drawing.Point(349, 173);
            this.lblSpeedShow.Name = "lblSpeedShow";
            this.lblSpeedShow.Size = new System.Drawing.Size(18, 19);
            this.lblSpeedShow.TabIndex = 18;
            this.lblSpeedShow.Text = "0";
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(142, 114);
            this.trackBar1.Maximum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(433, 56);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnLanguage
            // 
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.Location = new System.Drawing.Point(142, 63);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(433, 46);
            this.btnLanguage.TabIndex = 15;
            this.btnLanguage.Text = "Tiếng Việt";
            this.btnLanguage.UseVisualStyleBackColor = true;
            // 
            // btnIncOrDes
            // 
            this.btnIncOrDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncOrDes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncOrDes.Location = new System.Drawing.Point(140, 11);
            this.btnIncOrDes.Name = "btnIncOrDes";
            this.btnIncOrDes.Size = new System.Drawing.Size(435, 46);
            this.btnIncOrDes.TabIndex = 14;
            this.btnIncOrDes.Text = "Tăng";
            this.btnIncOrDes.UseVisualStyleBackColor = true;
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
            this.tbCustomize.Location = new System.Drawing.Point(4, 28);
            this.tbCustomize.Name = "tbCustomize";
            this.tbCustomize.Size = new System.Drawing.Size(583, 198);
            this.tbCustomize.TabIndex = 2;
            this.tbCustomize.Text = "Tùy chỉnh";
            this.tbCustomize.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "NULL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 228);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMenu";
            this.Text = "ChildForm1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpCreate.ResumeLayout(false);
            this.tpCreate.PerformLayout();
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnHand;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCreate;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblSortHow;
        private System.Windows.Forms.TabPage tbCustomize;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnIncOrDes;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblSpeedShow;
        private System.Windows.Forms.Button button1;
    }
}