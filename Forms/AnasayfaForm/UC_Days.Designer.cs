namespace PerModule.Forms.AnasayfaForm
{
    partial class UC_Days
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
            this.components = new System.ComponentModel.Container();
            this.lbldays = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.BackColor = System.Drawing.Color.Transparent;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldays.ForeColor = System.Drawing.Color.White;
            this.lbldays.Location = new System.Drawing.Point(3, 4);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(27, 20);
            this.lbldays.TabIndex = 158;
            this.lbldays.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.lbldays);
            this.Name = "UC_Days";
            this.Size = new System.Drawing.Size(87, 63);
            this.Load += new System.EventHandler(this.UC_Days_Load);
            this.Click += new System.EventHandler(this.UC_Days_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbldays;
    }
}
