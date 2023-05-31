namespace PerModule.Forms.PersonelListForm.PersonCardDrop
{
    partial class OzlukBcard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OzlukBcard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblKBWhatudoing = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OzlukBGridList = new System.Windows.Forms.DataGridView();
            this.perTcknDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDataDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pdfidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewOzlukBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewOzlukB = new PerModule.ViewOzlukB();
            this.viewOzlukBTableAdapter = new PerModule.ViewOzlukBTableAdapters.ViewOzlukBTableAdapter();
            this.btnYenile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOzlukPdfEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.OzlukBGridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOzlukBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOzlukB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(142)))), ((int)(((byte)(146)))));
            this.panel10.Location = new System.Drawing.Point(6, 54);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1384, 1);
            this.panel10.TabIndex = 160;
            // 
            // lblKBWhatudoing
            // 
            this.lblKBWhatudoing.AutoSize = true;
            this.lblKBWhatudoing.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKBWhatudoing.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblKBWhatudoing.Location = new System.Drawing.Point(5, 9);
            this.lblKBWhatudoing.Name = "lblKBWhatudoing";
            this.lblKBWhatudoing.Size = new System.Drawing.Size(249, 39);
            this.lblKBWhatudoing.TabIndex = 159;
            this.lblKBWhatudoing.Text = "Özlük Dosyaları\r\n";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OzlukBGridList
            // 
            this.OzlukBGridList.AllowUserToAddRows = false;
            this.OzlukBGridList.AllowUserToDeleteRows = false;
            this.OzlukBGridList.AllowUserToResizeRows = false;
            this.OzlukBGridList.AutoGenerateColumns = false;
            this.OzlukBGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OzlukBGridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.OzlukBGridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OzlukBGridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OzlukBGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OzlukBGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OzlukBGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OzlukBGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perTcknDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.personnelidDataGridViewTextBoxColumn,
            this.kullaniciidDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.fileDataDataGridViewImageColumn,
            this.pdfidDataGridViewTextBoxColumn});
            this.OzlukBGridList.DataSource = this.viewOzlukBBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OzlukBGridList.DefaultCellStyle = dataGridViewCellStyle2;
            this.OzlukBGridList.EnableHeadersVisualStyles = false;
            this.OzlukBGridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.OzlukBGridList.Location = new System.Drawing.Point(8, 61);
            this.OzlukBGridList.Name = "OzlukBGridList";
            this.OzlukBGridList.ReadOnly = true;
            this.OzlukBGridList.RowHeadersVisible = false;
            this.OzlukBGridList.RowTemplate.Height = 30;
            this.OzlukBGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OzlukBGridList.Size = new System.Drawing.Size(1382, 417);
            this.OzlukBGridList.TabIndex = 164;
            this.OzlukBGridList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OzlukBGridList_CellContentDoubleClick);
            // 
            // perTcknDataGridViewTextBoxColumn
            // 
            this.perTcknDataGridViewTextBoxColumn.DataPropertyName = "PerTckn";
            this.perTcknDataGridViewTextBoxColumn.HeaderText = "PerTckn";
            this.perTcknDataGridViewTextBoxColumn.Name = "perTcknDataGridViewTextBoxColumn";
            this.perTcknDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personnelidDataGridViewTextBoxColumn
            // 
            this.personnelidDataGridViewTextBoxColumn.DataPropertyName = "personnelid";
            this.personnelidDataGridViewTextBoxColumn.HeaderText = "personnelid";
            this.personnelidDataGridViewTextBoxColumn.Name = "personnelidDataGridViewTextBoxColumn";
            this.personnelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kullaniciidDataGridViewTextBoxColumn
            // 
            this.kullaniciidDataGridViewTextBoxColumn.DataPropertyName = "kullaniciid";
            this.kullaniciidDataGridViewTextBoxColumn.HeaderText = "kullaniciid";
            this.kullaniciidDataGridViewTextBoxColumn.Name = "kullaniciidDataGridViewTextBoxColumn";
            this.kullaniciidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileDataDataGridViewImageColumn
            // 
            this.fileDataDataGridViewImageColumn.DataPropertyName = "FileData";
            this.fileDataDataGridViewImageColumn.HeaderText = "FileData";
            this.fileDataDataGridViewImageColumn.Name = "fileDataDataGridViewImageColumn";
            this.fileDataDataGridViewImageColumn.ReadOnly = true;
            this.fileDataDataGridViewImageColumn.Visible = false;
            // 
            // pdfidDataGridViewTextBoxColumn
            // 
            this.pdfidDataGridViewTextBoxColumn.DataPropertyName = "pdfid";
            this.pdfidDataGridViewTextBoxColumn.HeaderText = "pdfid";
            this.pdfidDataGridViewTextBoxColumn.Name = "pdfidDataGridViewTextBoxColumn";
            this.pdfidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdfidDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewOzlukBBindingSource
            // 
            this.viewOzlukBBindingSource.DataMember = "ViewOzlukB";
            this.viewOzlukBBindingSource.DataSource = this.viewOzlukB;
            // 
            // viewOzlukB
            // 
            this.viewOzlukB.DataSetName = "ViewOzlukB";
            this.viewOzlukB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewOzlukBTableAdapter
            // 
            this.viewOzlukBTableAdapter.ClearBeforeFill = true;
            // 
            // btnYenile
            // 
            this.btnYenile.AllowAnimations = true;
            this.btnYenile.AllowMouseEffects = true;
            this.btnYenile.AllowToggling = false;
            this.btnYenile.AnimationSpeed = 200;
            this.btnYenile.AutoGenerateColors = true;
            this.btnYenile.AutoRoundBorders = false;
            this.btnYenile.AutoSizeLeftIcon = true;
            this.btnYenile.AutoSizeRightIcon = true;
            this.btnYenile.BackColor = System.Drawing.Color.Transparent;
            this.btnYenile.BackColor1 = System.Drawing.Color.Silver;
            this.btnYenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.BackgroundImage")));
            this.btnYenile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.ButtonText = "";
            this.btnYenile.ButtonTextMarginLeft = 0;
            this.btnYenile.ColorContrastOnClick = 45;
            this.btnYenile.ColorContrastOnHover = 45;
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnYenile.CustomizableEdges = borderEdges1;
            this.btnYenile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYenile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYenile.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYenile.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYenile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYenile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnYenile.IconLeftPadding = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.btnYenile.IconMarginLeft = 11;
            this.btnYenile.IconPadding = 7;
            this.btnYenile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYenile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnYenile.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnYenile.IconSize = 35;
            this.btnYenile.IdleBorderColor = System.Drawing.Color.Silver;
            this.btnYenile.IdleBorderRadius = 1;
            this.btnYenile.IdleBorderThickness = 1;
            this.btnYenile.IdleFillColor = System.Drawing.Color.Silver;
            this.btnYenile.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.IdleIconLeftImage")));
            this.btnYenile.IdleIconRightImage = null;
            this.btnYenile.IndicateFocus = false;
            this.btnYenile.Location = new System.Drawing.Point(1314, 16);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYenile.OnDisabledState.BorderRadius = 1;
            this.btnYenile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.OnDisabledState.BorderThickness = 1;
            this.btnYenile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYenile.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYenile.OnDisabledState.IconLeftImage = null;
            this.btnYenile.OnDisabledState.IconRightImage = null;
            this.btnYenile.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnYenile.onHoverState.BorderRadius = 1;
            this.btnYenile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.onHoverState.BorderThickness = 1;
            this.btnYenile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnYenile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnYenile.onHoverState.IconLeftImage = null;
            this.btnYenile.onHoverState.IconRightImage = null;
            this.btnYenile.OnIdleState.BorderColor = System.Drawing.Color.Silver;
            this.btnYenile.OnIdleState.BorderRadius = 1;
            this.btnYenile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.OnIdleState.BorderThickness = 1;
            this.btnYenile.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btnYenile.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnYenile.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.OnIdleState.IconLeftImage")));
            this.btnYenile.OnIdleState.IconRightImage = null;
            this.btnYenile.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnYenile.OnPressedState.BorderRadius = 1;
            this.btnYenile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.OnPressedState.BorderThickness = 1;
            this.btnYenile.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnYenile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnYenile.OnPressedState.IconLeftImage = null;
            this.btnYenile.OnPressedState.IconRightImage = null;
            this.btnYenile.Size = new System.Drawing.Size(35, 32);
            this.btnYenile.TabIndex = 162;
            this.btnYenile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYenile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnYenile.TextMarginLeft = 0;
            this.btnYenile.TextPadding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnYenile.UseDefaultRadiusAndThickness = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnOzlukPdfEkle
            // 
            this.btnOzlukPdfEkle.AllowAnimations = true;
            this.btnOzlukPdfEkle.AllowMouseEffects = true;
            this.btnOzlukPdfEkle.AllowToggling = false;
            this.btnOzlukPdfEkle.AnimationSpeed = 200;
            this.btnOzlukPdfEkle.AutoGenerateColors = false;
            this.btnOzlukPdfEkle.AutoRoundBorders = false;
            this.btnOzlukPdfEkle.AutoSizeLeftIcon = true;
            this.btnOzlukPdfEkle.AutoSizeRightIcon = true;
            this.btnOzlukPdfEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnOzlukPdfEkle.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnOzlukPdfEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOzlukPdfEkle.BackgroundImage")));
            this.btnOzlukPdfEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOzlukPdfEkle.ButtonText = "";
            this.btnOzlukPdfEkle.ButtonTextMarginLeft = 0;
            this.btnOzlukPdfEkle.ColorContrastOnClick = 45;
            this.btnOzlukPdfEkle.ColorContrastOnHover = 45;
            this.btnOzlukPdfEkle.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnOzlukPdfEkle.CustomizableEdges = borderEdges2;
            this.btnOzlukPdfEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOzlukPdfEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOzlukPdfEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOzlukPdfEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOzlukPdfEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOzlukPdfEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOzlukPdfEkle.ForeColor = System.Drawing.Color.White;
            this.btnOzlukPdfEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOzlukPdfEkle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOzlukPdfEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOzlukPdfEkle.IconMarginLeft = 11;
            this.btnOzlukPdfEkle.IconPadding = 10;
            this.btnOzlukPdfEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOzlukPdfEkle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOzlukPdfEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOzlukPdfEkle.IconSize = 25;
            this.btnOzlukPdfEkle.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnOzlukPdfEkle.IdleBorderRadius = 1;
            this.btnOzlukPdfEkle.IdleBorderThickness = 1;
            this.btnOzlukPdfEkle.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnOzlukPdfEkle.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnOzlukPdfEkle.IdleIconLeftImage")));
            this.btnOzlukPdfEkle.IdleIconRightImage = null;
            this.btnOzlukPdfEkle.IndicateFocus = false;
            this.btnOzlukPdfEkle.Location = new System.Drawing.Point(1355, 16);
            this.btnOzlukPdfEkle.Name = "btnOzlukPdfEkle";
            this.btnOzlukPdfEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOzlukPdfEkle.OnDisabledState.BorderRadius = 1;
            this.btnOzlukPdfEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOzlukPdfEkle.OnDisabledState.BorderThickness = 1;
            this.btnOzlukPdfEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOzlukPdfEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOzlukPdfEkle.OnDisabledState.IconLeftImage = null;
            this.btnOzlukPdfEkle.OnDisabledState.IconRightImage = null;
            this.btnOzlukPdfEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.btnOzlukPdfEkle.onHoverState.BorderRadius = 1;
            this.btnOzlukPdfEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOzlukPdfEkle.onHoverState.BorderThickness = 1;
            this.btnOzlukPdfEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.btnOzlukPdfEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOzlukPdfEkle.onHoverState.IconLeftImage = null;
            this.btnOzlukPdfEkle.onHoverState.IconRightImage = null;
            this.btnOzlukPdfEkle.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnOzlukPdfEkle.OnIdleState.BorderRadius = 1;
            this.btnOzlukPdfEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOzlukPdfEkle.OnIdleState.BorderThickness = 1;
            this.btnOzlukPdfEkle.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnOzlukPdfEkle.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOzlukPdfEkle.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnOzlukPdfEkle.OnIdleState.IconLeftImage")));
            this.btnOzlukPdfEkle.OnIdleState.IconRightImage = null;
            this.btnOzlukPdfEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnOzlukPdfEkle.OnPressedState.BorderRadius = 1;
            this.btnOzlukPdfEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOzlukPdfEkle.OnPressedState.BorderThickness = 1;
            this.btnOzlukPdfEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnOzlukPdfEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOzlukPdfEkle.OnPressedState.IconLeftImage = null;
            this.btnOzlukPdfEkle.OnPressedState.IconRightImage = null;
            this.btnOzlukPdfEkle.Size = new System.Drawing.Size(35, 32);
            this.btnOzlukPdfEkle.TabIndex = 161;
            this.btnOzlukPdfEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOzlukPdfEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOzlukPdfEkle.TextMarginLeft = 0;
            this.btnOzlukPdfEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOzlukPdfEkle.UseDefaultRadiusAndThickness = true;
            this.btnOzlukPdfEkle.Click += new System.EventHandler(this.btnOzlukPdfEkle_Click);
            // 
            // OzlukBcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1413, 490);
            this.Controls.Add(this.OzlukBGridList);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnOzlukPdfEkle);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.lblKBWhatudoing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OzlukBcard";
            this.Text = "OzlukBcard";
            this.Load += new System.EventHandler(this.OzlukBcard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OzlukBGridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOzlukBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOzlukB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblKBWhatudoing;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOzlukPdfEkle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYenile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView OzlukBGridList;
        private ViewOzlukB viewOzlukB;
        private System.Windows.Forms.BindingSource viewOzlukBBindingSource;
        private ViewOzlukBTableAdapters.ViewOzlukBTableAdapter viewOzlukBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTcknDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fileDataDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdfidDataGridViewTextBoxColumn;
    }
}