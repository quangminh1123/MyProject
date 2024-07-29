namespace QuanLyShopDongHo.Forms
{
    partial class DoiMKMoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaTK = new System.Windows.Forms.TextBox();
            this.mkMoi = new System.Windows.Forms.TextBox();
            this.xnMK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(100, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(100, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // MaTK
            // 
            this.MaTK.Enabled = false;
            this.MaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTK.Location = new System.Drawing.Point(218, 32);
            this.MaTK.Name = "MaTK";
            this.MaTK.Size = new System.Drawing.Size(259, 26);
            this.MaTK.TabIndex = 3;
            // 
            // mkMoi
            // 
            this.mkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkMoi.Location = new System.Drawing.Point(218, 74);
            this.mkMoi.Name = "mkMoi";
            this.mkMoi.Size = new System.Drawing.Size(259, 26);
            this.mkMoi.TabIndex = 4;
            // 
            // xnMK
            // 
            this.xnMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xnMK.Location = new System.Drawing.Point(218, 118);
            this.xnMK.Name = "xnMK";
            this.xnMK.Size = new System.Drawing.Size(259, 26);
            this.xnMK.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyShopDongHo.Properties.Resources.Save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(218, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xác nhận";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(359, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DoiMKMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyShopDongHo.Properties.Resources.bg_kh;
            this.ClientSize = new System.Drawing.Size(545, 239);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xnMK);
            this.Controls.Add(this.mkMoi);
            this.Controls.Add(this.MaTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoiMKMoi";
            this.Text = "DoiMKMoi";
            this.Load += new System.EventHandler(this.DoiMKMoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaTK;
        private System.Windows.Forms.TextBox mkMoi;
        private System.Windows.Forms.TextBox xnMK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}