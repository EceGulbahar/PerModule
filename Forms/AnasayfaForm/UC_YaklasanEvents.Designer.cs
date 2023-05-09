namespace PerModule.Forms.AnasayfaForm
{
    partial class UC_YaklasanEvents
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_YaklasanEvents));
            this.lbleventsy = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.SuspendLayout();
            // 
            // lbleventsy
            // 
            this.lbleventsy.BackColor = System.Drawing.Color.Transparent;
            this.lbleventsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbleventsy.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbleventsy.Location = new System.Drawing.Point(7, 6);
            this.lbleventsy.Name = "lbleventsy";
            this.lbleventsy.Size = new System.Drawing.Size(615, 41);
            this.lbleventsy.TabIndex = 159;
            this.lbleventsy.Text = "00";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 45);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(625, 14);
            this.bunifuSeparator1.TabIndex = 160;
            // 
            // UC_YaklasanEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lbleventsy);
            this.Name = "UC_YaklasanEvents";
            this.Size = new System.Drawing.Size(625, 54);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbleventsy;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
    }
}
