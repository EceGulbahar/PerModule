namespace PerModule
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Pmenu = new System.Windows.Forms.Panel();
            this.btnBordro = new System.Windows.Forms.Button();
            this.btnOzlukB = new System.Windows.Forms.Button();
            this.btnZimmet = new System.Windows.Forms.Button();
            this.BtnIzin = new System.Windows.Forms.Button();
            this.btnPerRaport = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.PFormGetir = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new PerModule.Tools.GradientPanel();
            this.GPTop2 = new PerModule.Tools.GradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GPTop = new PerModule.Tools.GradientPanel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnQMark = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Pmenu.SuspendLayout();
            this.GPTop2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GPTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Pmenu
            // 
            this.Pmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.Pmenu.Controls.Add(this.btnBordro);
            this.Pmenu.Controls.Add(this.btnOzlukB);
            this.Pmenu.Controls.Add(this.btnZimmet);
            this.Pmenu.Controls.Add(this.BtnIzin);
            this.Pmenu.Controls.Add(this.btnPerRaport);
            this.Pmenu.Controls.Add(this.btnPersonel);
            this.Pmenu.Controls.Add(this.btnAnasayfa);
            this.Pmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pmenu.Location = new System.Drawing.Point(0, 99);
            this.Pmenu.Name = "Pmenu";
            this.Pmenu.Size = new System.Drawing.Size(100, 662);
            this.Pmenu.TabIndex = 5;
            // 
            // btnBordro
            // 
            this.btnBordro.BackColor = System.Drawing.Color.Transparent;
            this.btnBordro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBordro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBordro.FlatAppearance.BorderSize = 0;
            this.btnBordro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBordro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBordro.Image = ((System.Drawing.Image)(resources.GetObject("btnBordro.Image")));
            this.btnBordro.Location = new System.Drawing.Point(0, 450);
            this.btnBordro.Margin = new System.Windows.Forms.Padding(2);
            this.btnBordro.Name = "btnBordro";
            this.btnBordro.Size = new System.Drawing.Size(100, 75);
            this.btnBordro.TabIndex = 14;
            this.btnBordro.UseVisualStyleBackColor = false;
            this.btnBordro.Click += new System.EventHandler(this.btnBordro_Click_1);
            // 
            // btnOzlukB
            // 
            this.btnOzlukB.BackColor = System.Drawing.Color.Transparent;
            this.btnOzlukB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOzlukB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOzlukB.FlatAppearance.BorderSize = 0;
            this.btnOzlukB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOzlukB.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOzlukB.Image = ((System.Drawing.Image)(resources.GetObject("btnOzlukB.Image")));
            this.btnOzlukB.Location = new System.Drawing.Point(0, 375);
            this.btnOzlukB.Margin = new System.Windows.Forms.Padding(2);
            this.btnOzlukB.Name = "btnOzlukB";
            this.btnOzlukB.Size = new System.Drawing.Size(100, 75);
            this.btnOzlukB.TabIndex = 13;
            this.btnOzlukB.UseVisualStyleBackColor = false;
            this.btnOzlukB.Click += new System.EventHandler(this.btnOzlukB_Click_1);
            // 
            // btnZimmet
            // 
            this.btnZimmet.BackColor = System.Drawing.Color.Transparent;
            this.btnZimmet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZimmet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZimmet.FlatAppearance.BorderSize = 0;
            this.btnZimmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZimmet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnZimmet.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmet.Image")));
            this.btnZimmet.Location = new System.Drawing.Point(0, 300);
            this.btnZimmet.Margin = new System.Windows.Forms.Padding(2);
            this.btnZimmet.Name = "btnZimmet";
            this.btnZimmet.Size = new System.Drawing.Size(100, 75);
            this.btnZimmet.TabIndex = 12;
            this.btnZimmet.UseVisualStyleBackColor = false;
            this.btnZimmet.Click += new System.EventHandler(this.btnZimmet_Click_1);
            // 
            // BtnIzin
            // 
            this.BtnIzin.BackColor = System.Drawing.Color.Transparent;
            this.BtnIzin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnIzin.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIzin.FlatAppearance.BorderSize = 0;
            this.BtnIzin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzin.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnIzin.Image = ((System.Drawing.Image)(resources.GetObject("BtnIzin.Image")));
            this.BtnIzin.Location = new System.Drawing.Point(0, 225);
            this.BtnIzin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIzin.Name = "BtnIzin";
            this.BtnIzin.Size = new System.Drawing.Size(100, 75);
            this.BtnIzin.TabIndex = 11;
            this.BtnIzin.UseVisualStyleBackColor = false;
            this.BtnIzin.Click += new System.EventHandler(this.BtnIzin_Click_1);
            // 
            // btnPerRaport
            // 
            this.btnPerRaport.BackColor = System.Drawing.Color.Transparent;
            this.btnPerRaport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerRaport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerRaport.FlatAppearance.BorderSize = 0;
            this.btnPerRaport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerRaport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerRaport.Image = ((System.Drawing.Image)(resources.GetObject("btnPerRaport.Image")));
            this.btnPerRaport.Location = new System.Drawing.Point(0, 150);
            this.btnPerRaport.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerRaport.Name = "btnPerRaport";
            this.btnPerRaport.Size = new System.Drawing.Size(100, 75);
            this.btnPerRaport.TabIndex = 10;
            this.btnPerRaport.UseVisualStyleBackColor = false;
            this.btnPerRaport.Click += new System.EventHandler(this.btnPerRaport_Click_1);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPersonel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonel.FlatAppearance.BorderSize = 0;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPersonel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Image")));
            this.btnPersonel.Location = new System.Drawing.Point(0, 75);
            this.btnPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(100, 75);
            this.btnPersonel.TabIndex = 9;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnasayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.Image")));
            this.btnAnasayfa.Location = new System.Drawing.Point(0, 0);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(100, 75);
            this.btnAnasayfa.TabIndex = 8;
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // PFormGetir
            // 
            this.PFormGetir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PFormGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PFormGetir.Location = new System.Drawing.Point(100, 99);
            this.PFormGetir.Name = "PFormGetir";
            this.PFormGetir.Size = new System.Drawing.Size(1228, 652);
            this.PFormGetir.TabIndex = 6;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(100, 751);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1228, 10);
            this.gradientPanel1.TabIndex = 6;
            // 
            // GPTop2
            // 
            this.GPTop2.BackColor = System.Drawing.Color.Transparent;
            this.GPTop2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GPTop2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.GPTop2.Controls.Add(this.pictureBox4);
            this.GPTop2.Controls.Add(this.pictureBox3);
            this.GPTop2.Controls.Add(this.pictureBox2);
            this.GPTop2.Controls.Add(this.pictureBox1);
            this.GPTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPTop2.Location = new System.Drawing.Point(0, 24);
            this.GPTop2.Name = "GPTop2";
            this.GPTop2.Size = new System.Drawing.Size(1328, 75);
            this.GPTop2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1313, 12);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GPTop
            // 
            this.GPTop.BackColor = System.Drawing.Color.Transparent;
            this.GPTop.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GPTop.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.GPTop.Controls.Add(this.btnMin);
            this.GPTop.Controls.Add(this.btnQMark);
            this.GPTop.Controls.Add(this.btnClose);
            this.GPTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPTop.Location = new System.Drawing.Point(0, 0);
            this.GPTop.Name = "GPTop";
            this.GPTop.Size = new System.Drawing.Size(1328, 24);
            this.GPTop.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1265, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(21, 24);
            this.btnMin.TabIndex = 8;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnQMark
            // 
            this.btnQMark.BackColor = System.Drawing.Color.Transparent;
            this.btnQMark.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQMark.FlatAppearance.BorderSize = 0;
            this.btnQMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQMark.Image = ((System.Drawing.Image)(resources.GetObject("btnQMark.Image")));
            this.btnQMark.Location = new System.Drawing.Point(1286, 0);
            this.btnQMark.Margin = new System.Windows.Forms.Padding(2);
            this.btnQMark.Name = "btnQMark";
            this.btnQMark.Size = new System.Drawing.Size(21, 24);
            this.btnQMark.TabIndex = 7;
            this.btnQMark.UseVisualStyleBackColor = false;
            this.btnQMark.Click += new System.EventHandler(this.btnQMark_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1307, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 24);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(88, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(12, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1328, 761);
            this.Controls.Add(this.PFormGetir);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.Pmenu);
            this.Controls.Add(this.GPTop2);
            this.Controls.Add(this.GPTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Pmenu.ResumeLayout(false);
            this.GPTop2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GPTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Tools.GradientPanel GPTop;
        private Tools.GradientPanel GPTop2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnQMark;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel Pmenu;
        private System.Windows.Forms.Button btnBordro;
        private System.Windows.Forms.Button btnOzlukB;
        private System.Windows.Forms.Button btnZimmet;
        private System.Windows.Forms.Button BtnIzin;
        private System.Windows.Forms.Button btnPerRaport;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Panel PFormGetir;
        private Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

