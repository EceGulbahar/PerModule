namespace PerModule
{
    partial class UC_NewPersonnels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NewPersonnels));
            this.pictureFoto = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lbladisoyadi = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblaciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureFoto
            // 
            this.pictureFoto.AllowFocused = false;
            this.pictureFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureFoto.AutoSizeHeight = true;
            this.pictureFoto.BorderRadius = 35;
            this.pictureFoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureFoto.Image")));
            this.pictureFoto.IsCircle = true;
            this.pictureFoto.Location = new System.Drawing.Point(17, 7);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(71, 71);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFoto.TabIndex = 0;
            this.pictureFoto.TabStop = false;
            this.pictureFoto.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 83);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(477, 10);
            this.bunifuSeparator1.TabIndex = 13;
            // 
            // lbladisoyadi
            // 
            this.lbladisoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbladisoyadi.ForeColor = System.Drawing.Color.DarkGray;
            this.lbladisoyadi.Location = new System.Drawing.Point(105, 5);
            this.lbladisoyadi.Name = "lbladisoyadi";
            this.lbladisoyadi.Size = new System.Drawing.Size(263, 18);
            this.lbladisoyadi.TabIndex = 14;
            this.lbladisoyadi.Text = "label1";
            // 
            // lbltarih
            // 
            this.lbltarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbltarih.ForeColor = System.Drawing.Color.DarkGray;
            this.lbltarih.Location = new System.Drawing.Point(392, 5);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(82, 18);
            this.lbltarih.TabIndex = 15;
            this.lbltarih.Text = "label1";
            this.lbltarih.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblaciklama
            // 
            this.lblaciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblaciklama.ForeColor = System.Drawing.Color.LightGray;
            this.lblaciklama.Location = new System.Drawing.Point(105, 36);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(351, 34);
            this.lblaciklama.TabIndex = 16;
            this.lblaciklama.Text = "label1";
            this.lblaciklama.Click += new System.EventHandler(this.lblaciklama_Click);
            // 
            // UC_NewPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lbladisoyadi);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.pictureFoto);
            this.Name = "UC_NewPersonnels";
            this.Size = new System.Drawing.Size(477, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Label lbladisoyadi;
        public System.Windows.Forms.Label lbltarih;
        public System.Windows.Forms.Label lblaciklama;
        public Bunifu.UI.WinForms.BunifuPictureBox pictureFoto;
    }
}
