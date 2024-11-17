namespace SortVisualiser_v1
{
    partial class ucNode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(51, 84);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 28);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseDown);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(34, 41);
            this.tbx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx1.Multiline = true;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(132, 24);
            this.tbx1.TabIndex = 1;
            this.tbx1.TextChanged += new System.EventHandler(this.tbx1_TextChanged);
            this.tbx1.Enter += new System.EventHandler(this.tbx1_Enter);
            this.tbx1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx1_KeyDown);
            this.tbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx1_KeyPress);
            // 
            // Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbx1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Node";
            this.Size = new System.Drawing.Size(200, 185);
            this.Load += new System.EventHandler(this.TbxBtn_Load);
            this.BackColorChanged += new System.EventHandler(this.TbxBtn_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox tbx1;
    }
}
