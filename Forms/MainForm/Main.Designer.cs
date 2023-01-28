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
            this.gradientPanel1 = new PerModule.Tools.GradientPanel();
            this.GPTop = new PerModule.Tools.GradientPanel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnQMark = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.GPTop2 = new PerModule.Tools.GradientPanel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnPerRaport = new System.Windows.Forms.Button();
            this.BtnIzin = new System.Windows.Forms.Button();
            this.btnZimmet = new System.Windows.Forms.Button();
            this.btnOzlukB = new System.Windows.Forms.Button();
            this.btnBordro = new System.Windows.Forms.Button();
            this.Pmenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PFormGetir = new System.Windows.Forms.Panel();
            this.pnlHLight = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pnlHLight1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.GPTop.SuspendLayout();
            this.Pmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(10, 751);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1318, 10);
            this.gradientPanel1.TabIndex = 6;
            // 
            // GPTop
            // 
            this.GPTop.BackColor = System.Drawing.Color.Transparent;
            this.GPTop.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            this.GPTop.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.GPTop.Controls.Add(this.btnMin);
            this.GPTop.Controls.Add(this.btnQMark);
            this.GPTop.Controls.Add(this.btnClose);
            this.GPTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPTop.Location = new System.Drawing.Point(0, 0);
            this.GPTop.Name = "GPTop";
            this.GPTop.Size = new System.Drawing.Size(1328, 21);
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
            this.btnMin.Size = new System.Drawing.Size(21, 21);
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
            this.btnQMark.Size = new System.Drawing.Size(21, 21);
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
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GPTop2
            // 
            this.GPTop2.BackColor = System.Drawing.Color.Transparent;
            this.GPTop2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GPTop2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.GPTop2.Dock = System.Windows.Forms.DockStyle.Left;
            this.GPTop2.Location = new System.Drawing.Point(0, 21);
            this.GPTop2.Name = "GPTop2";
            this.GPTop2.Size = new System.Drawing.Size(10, 740);
            this.GPTop2.TabIndex = 4;
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
            this.btnAnasayfa.Size = new System.Drawing.Size(72, 75);
            this.btnAnasayfa.TabIndex = 8;
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseEnter += new System.EventHandler(this.btnAnasayfa_MouseEnter);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
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
            this.btnPersonel.Size = new System.Drawing.Size(72, 75);
            this.btnPersonel.TabIndex = 9;
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            this.btnPersonel.MouseEnter += new System.EventHandler(this.btnPersonel_MouseEnter);
            this.btnPersonel.MouseLeave += new System.EventHandler(this.btnPersonel_MouseLeave);
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
            this.btnPerRaport.Size = new System.Drawing.Size(72, 75);
            this.btnPerRaport.TabIndex = 10;
            this.btnPerRaport.UseVisualStyleBackColor = false;
            this.btnPerRaport.Click += new System.EventHandler(this.btnPerRaport_Click_1);
            this.btnPerRaport.MouseEnter += new System.EventHandler(this.btnPerRaport_MouseEnter);
            this.btnPerRaport.MouseLeave += new System.EventHandler(this.btnPerRaport_MouseLeave);
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
            this.BtnIzin.Size = new System.Drawing.Size(72, 75);
            this.BtnIzin.TabIndex = 11;
            this.BtnIzin.UseVisualStyleBackColor = false;
            this.BtnIzin.Click += new System.EventHandler(this.BtnIzin_Click_1);
            this.BtnIzin.MouseEnter += new System.EventHandler(this.BtnIzin_MouseEnter);
            this.BtnIzin.MouseLeave += new System.EventHandler(this.BtnIzin_MouseLeave);
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
            this.btnZimmet.Size = new System.Drawing.Size(72, 75);
            this.btnZimmet.TabIndex = 12;
            this.btnZimmet.UseVisualStyleBackColor = false;
            this.btnZimmet.Click += new System.EventHandler(this.btnZimmet_Click_1);
            this.btnZimmet.MouseEnter += new System.EventHandler(this.btnZimmet_MouseEnter);
            this.btnZimmet.MouseLeave += new System.EventHandler(this.btnZimmet_MouseLeave);
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
            this.btnOzlukB.Size = new System.Drawing.Size(72, 75);
            this.btnOzlukB.TabIndex = 13;
            this.btnOzlukB.UseVisualStyleBackColor = false;
            this.btnOzlukB.Click += new System.EventHandler(this.btnOzlukB_Click_1);
            this.btnOzlukB.MouseEnter += new System.EventHandler(this.btnOzlukB_MouseEnter);
            this.btnOzlukB.MouseLeave += new System.EventHandler(this.btnOzlukB_MouseLeave);
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
            this.btnBordro.Size = new System.Drawing.Size(72, 75);
            this.btnBordro.TabIndex = 14;
            this.btnBordro.UseVisualStyleBackColor = false;
            this.btnBordro.Click += new System.EventHandler(this.btnBordro_Click_1);
            this.btnBordro.MouseEnter += new System.EventHandler(this.btnBordro_MouseEnter);
            this.btnBordro.MouseLeave += new System.EventHandler(this.btnBordro_MouseLeave);
            // 
            // Pmenu
            // 
            this.Pmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.Pmenu.Controls.Add(this.pnlHLight1);
            this.Pmenu.Controls.Add(this.pnlHLight);
            this.Pmenu.Controls.Add(this.btnBordro);
            this.Pmenu.Controls.Add(this.btnOzlukB);
            this.Pmenu.Controls.Add(this.btnZimmet);
            this.Pmenu.Controls.Add(this.BtnIzin);
            this.Pmenu.Controls.Add(this.btnPerRaport);
            this.Pmenu.Controls.Add(this.btnPersonel);
            this.Pmenu.Controls.Add(this.btnAnasayfa);
            this.Pmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pmenu.Location = new System.Drawing.Point(15, 108);
            this.Pmenu.Name = "Pmenu";
            this.Pmenu.Size = new System.Drawing.Size(72, 622);
            this.Pmenu.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.Pmenu);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 730);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 19);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 711);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(87, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 711);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(15, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 19);
            this.panel5.TabIndex = 3;
            // 
            // PFormGetir
            // 
            this.PFormGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PFormGetir.Location = new System.Drawing.Point(114, 21);
            this.PFormGetir.Name = "PFormGetir";
            this.PFormGetir.Size = new System.Drawing.Size(1214, 730);
            this.PFormGetir.TabIndex = 9;
            // 
            // pnlHLight
            // 
            this.pnlHLight.BackColor = System.Drawing.Color.Transparent;
            this.pnlHLight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHLight.BackgroundImage")));
            this.pnlHLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHLight.BorderRadius = 1;
            this.pnlHLight.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.pnlHLight.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlHLight.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.pnlHLight.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlHLight.Location = new System.Drawing.Point(55, 0);
            this.pnlHLight.Name = "pnlHLight";
            this.pnlHLight.Quality = 10;
            this.pnlHLight.Size = new System.Drawing.Size(18, 75);
            this.pnlHLight.TabIndex = 0;
            // 
            // pnlHLight1
            // 
            this.pnlHLight1.BackColor = System.Drawing.Color.Transparent;
            this.pnlHLight1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHLight1.BackgroundImage")));
            this.pnlHLight1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHLight1.BorderRadius = 1;
            this.pnlHLight1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlHLight1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.pnlHLight1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlHLight1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.pnlHLight1.Location = new System.Drawing.Point(0, 0);
            this.pnlHLight1.Name = "pnlHLight1";
            this.pnlHLight1.Quality = 10;
            this.pnlHLight1.Size = new System.Drawing.Size(16, 75);
            this.pnlHLight1.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1328, 761);
            this.Controls.Add(this.PFormGetir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.GPTop2);
            this.Controls.Add(this.GPTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.GPTop.ResumeLayout(false);
            this.Pmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Tools.GradientPanel GPTop;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnQMark;
        private System.Windows.Forms.Button btnClose;
        private Tools.GradientPanel gradientPanel1;
        private Tools.GradientPanel GPTop2;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnPerRaport;
        private System.Windows.Forms.Button BtnIzin;
        private System.Windows.Forms.Button btnZimmet;
        private System.Windows.Forms.Button btnOzlukB;
        private System.Windows.Forms.Button btnBordro;
        private System.Windows.Forms.Panel Pmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PFormGetir;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlHLight;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnlHLight1;
    }
}

