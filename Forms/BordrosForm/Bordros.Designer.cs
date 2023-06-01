namespace PerModule.Forms.BordrosForm
{
    partial class Bordros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bordros));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlTopItems = new System.Windows.Forms.Panel();
            this.PersonelListesiLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.KontrolPanelLink = new System.Windows.Forms.LinkLabel();
            this.txtSearchboxPerList = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BordroGridList = new System.Windows.Forms.DataGridView();
            this.perTcknDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamGunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ızinliGunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemAyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemYilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bordroidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBordroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewBordroDS = new PerModule.ViewBordroDS();
            this.dropDonemAy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dropDonemYil = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.viewBordroTableAdapter = new PerModule.ViewBordroDSTableAdapters.ViewBordroTableAdapter();
            this.btnDonemlikBordroHesapla = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDonemKayitSil = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnYenile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnExceleAl = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.btnPdfCikar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlTopItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BordroGridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroDS)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopItems
            // 
            this.pnlTopItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.pnlTopItems.Controls.Add(this.PersonelListesiLink);
            this.pnlTopItems.Controls.Add(this.label2);
            this.pnlTopItems.Controls.Add(this.KontrolPanelLink);
            this.pnlTopItems.Controls.Add(this.txtSearchboxPerList);
            this.pnlTopItems.Location = new System.Drawing.Point(57, 42);
            this.pnlTopItems.Name = "pnlTopItems";
            this.pnlTopItems.Size = new System.Drawing.Size(1711, 48);
            this.pnlTopItems.TabIndex = 15;
            // 
            // PersonelListesiLink
            // 
            this.PersonelListesiLink.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.PersonelListesiLink.AutoSize = true;
            this.PersonelListesiLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelListesiLink.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PersonelListesiLink.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.PersonelListesiLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PersonelListesiLink.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.PersonelListesiLink.Location = new System.Drawing.Point(142, 15);
            this.PersonelListesiLink.Name = "PersonelListesiLink";
            this.PersonelListesiLink.Size = new System.Drawing.Size(54, 18);
            this.PersonelListesiLink.TabIndex = 11;
            this.PersonelListesiLink.TabStop = true;
            this.PersonelListesiLink.Text = "Bordro";
            this.PersonelListesiLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(116, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = ">";
            // 
            // KontrolPanelLink
            // 
            this.KontrolPanelLink.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.KontrolPanelLink.AutoSize = true;
            this.KontrolPanelLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KontrolPanelLink.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KontrolPanelLink.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.KontrolPanelLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.KontrolPanelLink.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.KontrolPanelLink.Location = new System.Drawing.Point(15, 15);
            this.KontrolPanelLink.Name = "KontrolPanelLink";
            this.KontrolPanelLink.Size = new System.Drawing.Size(104, 18);
            this.KontrolPanelLink.TabIndex = 9;
            this.KontrolPanelLink.TabStop = true;
            this.KontrolPanelLink.Text = "Kontrol Paneli ";
            this.KontrolPanelLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // txtSearchboxPerList
            // 
            this.txtSearchboxPerList.AcceptsReturn = false;
            this.txtSearchboxPerList.AcceptsTab = false;
            this.txtSearchboxPerList.AnimationSpeed = 200;
            this.txtSearchboxPerList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchboxPerList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchboxPerList.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchboxPerList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearchboxPerList.BackgroundImage")));
            this.txtSearchboxPerList.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtSearchboxPerList.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtSearchboxPerList.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtSearchboxPerList.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtSearchboxPerList.BorderRadius = 1;
            this.txtSearchboxPerList.BorderThickness = 1;
            this.txtSearchboxPerList.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchboxPerList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchboxPerList.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchboxPerList.DefaultText = "";
            this.txtSearchboxPerList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtSearchboxPerList.ForeColor = System.Drawing.Color.White;
            this.txtSearchboxPerList.HideSelection = true;
            this.txtSearchboxPerList.IconLeft = null;
            this.txtSearchboxPerList.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchboxPerList.IconPadding = 10;
            this.txtSearchboxPerList.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchboxPerList.IconRight")));
            this.txtSearchboxPerList.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchboxPerList.Lines = new string[0];
            this.txtSearchboxPerList.Location = new System.Drawing.Point(1296, 3);
            this.txtSearchboxPerList.MaxLength = 32767;
            this.txtSearchboxPerList.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearchboxPerList.Modified = false;
            this.txtSearchboxPerList.Multiline = false;
            this.txtSearchboxPerList.Name = "txtSearchboxPerList";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchboxPerList.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchboxPerList.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchboxPerList.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearchboxPerList.OnIdleState = stateProperties4;
            this.txtSearchboxPerList.Padding = new System.Windows.Forms.Padding(2);
            this.txtSearchboxPerList.PasswordChar = '\0';
            this.txtSearchboxPerList.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchboxPerList.PlaceholderText = "Bordroda Ara...";
            this.txtSearchboxPerList.ReadOnly = false;
            this.txtSearchboxPerList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchboxPerList.SelectedText = "";
            this.txtSearchboxPerList.SelectionLength = 0;
            this.txtSearchboxPerList.SelectionStart = 0;
            this.txtSearchboxPerList.ShortcutsEnabled = true;
            this.txtSearchboxPerList.Size = new System.Drawing.Size(413, 42);
            this.txtSearchboxPerList.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearchboxPerList.TabIndex = 7;
            this.txtSearchboxPerList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchboxPerList.TextMarginBottom = 0;
            this.txtSearchboxPerList.TextMarginLeft = 3;
            this.txtSearchboxPerList.TextMarginTop = 0;
            this.txtSearchboxPerList.TextPlaceholder = "Bordroda Ara...";
            this.txtSearchboxPerList.UseSystemPasswordChar = false;
            this.txtSearchboxPerList.WordWrap = true;
            this.txtSearchboxPerList.TextChanged += new System.EventHandler(this.txtSearchboxPerList_TextChanged);
            // 
            // BordroGridList
            // 
            this.BordroGridList.AllowUserToAddRows = false;
            this.BordroGridList.AllowUserToDeleteRows = false;
            this.BordroGridList.AllowUserToResizeRows = false;
            this.BordroGridList.AutoGenerateColumns = false;
            this.BordroGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BordroGridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BordroGridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BordroGridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BordroGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BordroGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BordroGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BordroGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perTcknDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.personnelidDataGridViewTextBoxColumn,
            this.toplamGunDataGridViewTextBoxColumn,
            this.ızinliGunDataGridViewTextBoxColumn,
            this.brutMaasDataGridViewTextBoxColumn,
            this.netMaasDataGridViewTextBoxColumn,
            this.donemAyDataGridViewTextBoxColumn,
            this.donemYilDataGridViewTextBoxColumn,
            this.bordroidDataGridViewTextBoxColumn});
            this.BordroGridList.DataSource = this.viewBordroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BordroGridList.DefaultCellStyle = dataGridViewCellStyle2;
            this.BordroGridList.EnableHeadersVisualStyles = false;
            this.BordroGridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.BordroGridList.Location = new System.Drawing.Point(57, 203);
            this.BordroGridList.Name = "BordroGridList";
            this.BordroGridList.ReadOnly = true;
            this.BordroGridList.RowHeadersVisible = false;
            this.BordroGridList.RowTemplate.Height = 30;
            this.BordroGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BordroGridList.Size = new System.Drawing.Size(1267, 776);
            this.BordroGridList.TabIndex = 16;
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
            // 
            // toplamGunDataGridViewTextBoxColumn
            // 
            this.toplamGunDataGridViewTextBoxColumn.DataPropertyName = "ToplamGun";
            this.toplamGunDataGridViewTextBoxColumn.HeaderText = "ToplamGun";
            this.toplamGunDataGridViewTextBoxColumn.Name = "toplamGunDataGridViewTextBoxColumn";
            this.toplamGunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ızinliGunDataGridViewTextBoxColumn
            // 
            this.ızinliGunDataGridViewTextBoxColumn.DataPropertyName = "IzinliGun";
            this.ızinliGunDataGridViewTextBoxColumn.HeaderText = "IzinliGun";
            this.ızinliGunDataGridViewTextBoxColumn.Name = "ızinliGunDataGridViewTextBoxColumn";
            this.ızinliGunDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brutMaasDataGridViewTextBoxColumn
            // 
            this.brutMaasDataGridViewTextBoxColumn.DataPropertyName = "BrutMaas";
            this.brutMaasDataGridViewTextBoxColumn.HeaderText = "BrutMaas";
            this.brutMaasDataGridViewTextBoxColumn.Name = "brutMaasDataGridViewTextBoxColumn";
            this.brutMaasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netMaasDataGridViewTextBoxColumn
            // 
            this.netMaasDataGridViewTextBoxColumn.DataPropertyName = "NetMaas";
            this.netMaasDataGridViewTextBoxColumn.HeaderText = "NetMaas";
            this.netMaasDataGridViewTextBoxColumn.Name = "netMaasDataGridViewTextBoxColumn";
            this.netMaasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donemAyDataGridViewTextBoxColumn
            // 
            this.donemAyDataGridViewTextBoxColumn.DataPropertyName = "DonemAy";
            this.donemAyDataGridViewTextBoxColumn.HeaderText = "DonemAy";
            this.donemAyDataGridViewTextBoxColumn.Name = "donemAyDataGridViewTextBoxColumn";
            this.donemAyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donemYilDataGridViewTextBoxColumn
            // 
            this.donemYilDataGridViewTextBoxColumn.DataPropertyName = "DonemYil";
            this.donemYilDataGridViewTextBoxColumn.HeaderText = "DonemYil";
            this.donemYilDataGridViewTextBoxColumn.Name = "donemYilDataGridViewTextBoxColumn";
            this.donemYilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bordroidDataGridViewTextBoxColumn
            // 
            this.bordroidDataGridViewTextBoxColumn.DataPropertyName = "Bordroid";
            this.bordroidDataGridViewTextBoxColumn.HeaderText = "Bordroid";
            this.bordroidDataGridViewTextBoxColumn.Name = "bordroidDataGridViewTextBoxColumn";
            this.bordroidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewBordroBindingSource
            // 
            this.viewBordroBindingSource.DataMember = "ViewBordro";
            this.viewBordroBindingSource.DataSource = this.viewBordroDS;
            // 
            // viewBordroDS
            // 
            this.viewBordroDS.DataSetName = "ViewBordroDS";
            this.viewBordroDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dropDonemAy
            // 
            this.dropDonemAy.BackColor = System.Drawing.Color.Transparent;
            this.dropDonemAy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.dropDonemAy.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemAy.BorderRadius = 1;
            this.dropDonemAy.Color = System.Drawing.Color.WhiteSmoke;
            this.dropDonemAy.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropDonemAy.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDonemAy.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropDonemAy.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDonemAy.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropDonemAy.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropDonemAy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropDonemAy.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropDonemAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDonemAy.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDonemAy.FillDropDown = true;
            this.dropDonemAy.FillIndicator = false;
            this.dropDonemAy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDonemAy.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dropDonemAy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemAy.FormattingEnabled = true;
            this.dropDonemAy.Icon = null;
            this.dropDonemAy.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDonemAy.IndicatorColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemAy.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDonemAy.ItemBackColor = System.Drawing.Color.Silver;
            this.dropDonemAy.ItemBorderColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemAy.ItemForeColor = System.Drawing.Color.Black;
            this.dropDonemAy.ItemHeight = 26;
            this.dropDonemAy.ItemHighLightColor = System.Drawing.Color.Goldenrod;
            this.dropDonemAy.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropDonemAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.dropDonemAy.ItemTopMargin = 3;
            this.dropDonemAy.Location = new System.Drawing.Point(265, 154);
            this.dropDonemAy.Name = "dropDonemAy";
            this.dropDonemAy.Size = new System.Drawing.Size(147, 32);
            this.dropDonemAy.TabIndex = 56;
            this.dropDonemAy.Text = null;
            this.dropDonemAy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDonemAy.TextLeftMargin = 5;
            this.dropDonemAy.SelectedIndexChanged += new System.EventHandler(this.dropDonemAy_SelectedIndexChanged);
            // 
            // dropDonemYil
            // 
            this.dropDonemYil.BackColor = System.Drawing.Color.Transparent;
            this.dropDonemYil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.dropDonemYil.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemYil.BorderRadius = 1;
            this.dropDonemYil.Color = System.Drawing.Color.WhiteSmoke;
            this.dropDonemYil.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropDonemYil.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDonemYil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropDonemYil.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDonemYil.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropDonemYil.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropDonemYil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropDonemYil.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropDonemYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDonemYil.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDonemYil.FillDropDown = true;
            this.dropDonemYil.FillIndicator = false;
            this.dropDonemYil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDonemYil.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dropDonemYil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemYil.FormattingEnabled = true;
            this.dropDonemYil.Icon = null;
            this.dropDonemYil.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDonemYil.IndicatorColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemYil.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDonemYil.ItemBackColor = System.Drawing.Color.Silver;
            this.dropDonemYil.ItemBorderColor = System.Drawing.Color.WhiteSmoke;
            this.dropDonemYil.ItemForeColor = System.Drawing.Color.Black;
            this.dropDonemYil.ItemHeight = 26;
            this.dropDonemYil.ItemHighLightColor = System.Drawing.Color.Goldenrod;
            this.dropDonemYil.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropDonemYil.ItemTopMargin = 3;
            this.dropDonemYil.Location = new System.Drawing.Point(439, 154);
            this.dropDonemYil.Name = "dropDonemYil";
            this.dropDonemYil.Size = new System.Drawing.Size(137, 32);
            this.dropDonemYil.TabIndex = 57;
            this.dropDonemYil.Text = null;
            this.dropDonemYil.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDonemYil.TextLeftMargin = 5;
            this.dropDonemYil.SelectedIndexChanged += new System.EventHandler(this.dropDonemYil_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(415, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "/";
            // 
            // viewBordroTableAdapter
            // 
            this.viewBordroTableAdapter.ClearBeforeFill = true;
            // 
            // btnDonemlikBordroHesapla
            // 
            this.btnDonemlikBordroHesapla.AllowAnimations = true;
            this.btnDonemlikBordroHesapla.AllowMouseEffects = true;
            this.btnDonemlikBordroHesapla.AllowToggling = false;
            this.btnDonemlikBordroHesapla.AnimationSpeed = 200;
            this.btnDonemlikBordroHesapla.AutoGenerateColors = false;
            this.btnDonemlikBordroHesapla.AutoRoundBorders = false;
            this.btnDonemlikBordroHesapla.AutoSizeLeftIcon = true;
            this.btnDonemlikBordroHesapla.AutoSizeRightIcon = true;
            this.btnDonemlikBordroHesapla.BackColor = System.Drawing.Color.Transparent;
            this.btnDonemlikBordroHesapla.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.btnDonemlikBordroHesapla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonemlikBordroHesapla.BackgroundImage")));
            this.btnDonemlikBordroHesapla.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemlikBordroHesapla.ButtonText = "Dönemlik Bordro Hesapla";
            this.btnDonemlikBordroHesapla.ButtonTextMarginLeft = 0;
            this.btnDonemlikBordroHesapla.ColorContrastOnClick = 45;
            this.btnDonemlikBordroHesapla.ColorContrastOnHover = 45;
            this.btnDonemlikBordroHesapla.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDonemlikBordroHesapla.CustomizableEdges = borderEdges1;
            this.btnDonemlikBordroHesapla.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDonemlikBordroHesapla.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDonemlikBordroHesapla.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDonemlikBordroHesapla.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDonemlikBordroHesapla.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDonemlikBordroHesapla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonemlikBordroHesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDonemlikBordroHesapla.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonemlikBordroHesapla.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDonemlikBordroHesapla.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnDonemlikBordroHesapla.IconMarginLeft = 11;
            this.btnDonemlikBordroHesapla.IconPadding = 11;
            this.btnDonemlikBordroHesapla.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonemlikBordroHesapla.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDonemlikBordroHesapla.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDonemlikBordroHesapla.IconSize = 20;
            this.btnDonemlikBordroHesapla.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.btnDonemlikBordroHesapla.IdleBorderRadius = 1;
            this.btnDonemlikBordroHesapla.IdleBorderThickness = 1;
            this.btnDonemlikBordroHesapla.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.btnDonemlikBordroHesapla.IdleIconLeftImage = null;
            this.btnDonemlikBordroHesapla.IdleIconRightImage = null;
            this.btnDonemlikBordroHesapla.IndicateFocus = false;
            this.btnDonemlikBordroHesapla.Location = new System.Drawing.Point(588, 154);
            this.btnDonemlikBordroHesapla.Name = "btnDonemlikBordroHesapla";
            this.btnDonemlikBordroHesapla.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDonemlikBordroHesapla.OnDisabledState.BorderRadius = 1;
            this.btnDonemlikBordroHesapla.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemlikBordroHesapla.OnDisabledState.BorderThickness = 1;
            this.btnDonemlikBordroHesapla.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDonemlikBordroHesapla.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDonemlikBordroHesapla.OnDisabledState.IconLeftImage = null;
            this.btnDonemlikBordroHesapla.OnDisabledState.IconRightImage = null;
            this.btnDonemlikBordroHesapla.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(95)))), ((int)(((byte)(78)))));
            this.btnDonemlikBordroHesapla.onHoverState.BorderRadius = 1;
            this.btnDonemlikBordroHesapla.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemlikBordroHesapla.onHoverState.BorderThickness = 1;
            this.btnDonemlikBordroHesapla.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(95)))), ((int)(((byte)(78)))));
            this.btnDonemlikBordroHesapla.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDonemlikBordroHesapla.onHoverState.IconLeftImage = null;
            this.btnDonemlikBordroHesapla.onHoverState.IconRightImage = null;
            this.btnDonemlikBordroHesapla.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.btnDonemlikBordroHesapla.OnIdleState.BorderRadius = 1;
            this.btnDonemlikBordroHesapla.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemlikBordroHesapla.OnIdleState.BorderThickness = 1;
            this.btnDonemlikBordroHesapla.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.btnDonemlikBordroHesapla.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDonemlikBordroHesapla.OnIdleState.IconLeftImage = null;
            this.btnDonemlikBordroHesapla.OnIdleState.IconRightImage = null;
            this.btnDonemlikBordroHesapla.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.btnDonemlikBordroHesapla.OnPressedState.BorderRadius = 1;
            this.btnDonemlikBordroHesapla.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemlikBordroHesapla.OnPressedState.BorderThickness = 1;
            this.btnDonemlikBordroHesapla.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.btnDonemlikBordroHesapla.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDonemlikBordroHesapla.OnPressedState.IconLeftImage = null;
            this.btnDonemlikBordroHesapla.OnPressedState.IconRightImage = null;
            this.btnDonemlikBordroHesapla.Size = new System.Drawing.Size(250, 32);
            this.btnDonemlikBordroHesapla.TabIndex = 168;
            this.btnDonemlikBordroHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDonemlikBordroHesapla.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDonemlikBordroHesapla.TextMarginLeft = 0;
            this.btnDonemlikBordroHesapla.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDonemlikBordroHesapla.UseDefaultRadiusAndThickness = true;
            this.btnDonemlikBordroHesapla.Click += new System.EventHandler(this.btnDonemlikBordroHesapla_Click);
            // 
            // btnDonemKayitSil
            // 
            this.btnDonemKayitSil.AllowAnimations = true;
            this.btnDonemKayitSil.AllowMouseEffects = true;
            this.btnDonemKayitSil.AllowToggling = false;
            this.btnDonemKayitSil.AnimationSpeed = 200;
            this.btnDonemKayitSil.AutoGenerateColors = false;
            this.btnDonemKayitSil.AutoRoundBorders = false;
            this.btnDonemKayitSil.AutoSizeLeftIcon = true;
            this.btnDonemKayitSil.AutoSizeRightIcon = true;
            this.btnDonemKayitSil.BackColor = System.Drawing.Color.Transparent;
            this.btnDonemKayitSil.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnDonemKayitSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonemKayitSil.BackgroundImage")));
            this.btnDonemKayitSil.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemKayitSil.ButtonText = "";
            this.btnDonemKayitSil.ButtonTextMarginLeft = 0;
            this.btnDonemKayitSil.ColorContrastOnClick = 45;
            this.btnDonemKayitSil.ColorContrastOnHover = 45;
            this.btnDonemKayitSil.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDonemKayitSil.CustomizableEdges = borderEdges2;
            this.btnDonemKayitSil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDonemKayitSil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDonemKayitSil.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDonemKayitSil.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDonemKayitSil.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDonemKayitSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDonemKayitSil.ForeColor = System.Drawing.Color.White;
            this.btnDonemKayitSil.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonemKayitSil.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDonemKayitSil.IconLeftPadding = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.btnDonemKayitSil.IconMarginLeft = 11;
            this.btnDonemKayitSil.IconPadding = 5;
            this.btnDonemKayitSil.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDonemKayitSil.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDonemKayitSil.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.btnDonemKayitSil.IconSize = 25;
            this.btnDonemKayitSil.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnDonemKayitSil.IdleBorderRadius = 1;
            this.btnDonemKayitSil.IdleBorderThickness = 1;
            this.btnDonemKayitSil.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnDonemKayitSil.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDonemKayitSil.IdleIconLeftImage")));
            this.btnDonemKayitSil.IdleIconRightImage = null;
            this.btnDonemKayitSil.IndicateFocus = false;
            this.btnDonemKayitSil.Location = new System.Drawing.Point(844, 154);
            this.btnDonemKayitSil.Name = "btnDonemKayitSil";
            this.btnDonemKayitSil.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDonemKayitSil.OnDisabledState.BorderRadius = 1;
            this.btnDonemKayitSil.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemKayitSil.OnDisabledState.BorderThickness = 1;
            this.btnDonemKayitSil.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDonemKayitSil.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDonemKayitSil.OnDisabledState.IconLeftImage = null;
            this.btnDonemKayitSil.OnDisabledState.IconRightImage = null;
            this.btnDonemKayitSil.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.btnDonemKayitSil.onHoverState.BorderRadius = 1;
            this.btnDonemKayitSil.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemKayitSil.onHoverState.BorderThickness = 1;
            this.btnDonemKayitSil.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(99)))), ((int)(((byte)(12)))));
            this.btnDonemKayitSil.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDonemKayitSil.onHoverState.IconLeftImage = null;
            this.btnDonemKayitSil.onHoverState.IconRightImage = null;
            this.btnDonemKayitSil.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnDonemKayitSil.OnIdleState.BorderRadius = 1;
            this.btnDonemKayitSil.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemKayitSil.OnIdleState.BorderThickness = 1;
            this.btnDonemKayitSil.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnDonemKayitSil.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDonemKayitSil.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDonemKayitSil.OnIdleState.IconLeftImage")));
            this.btnDonemKayitSil.OnIdleState.IconRightImage = null;
            this.btnDonemKayitSil.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnDonemKayitSil.OnPressedState.BorderRadius = 1;
            this.btnDonemKayitSil.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDonemKayitSil.OnPressedState.BorderThickness = 1;
            this.btnDonemKayitSil.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.btnDonemKayitSil.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDonemKayitSil.OnPressedState.IconLeftImage = null;
            this.btnDonemKayitSil.OnPressedState.IconRightImage = null;
            this.btnDonemKayitSil.Size = new System.Drawing.Size(35, 32);
            this.btnDonemKayitSil.TabIndex = 169;
            this.btnDonemKayitSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDonemKayitSil.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDonemKayitSil.TextMarginLeft = 0;
            this.btnDonemKayitSil.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDonemKayitSil.UseDefaultRadiusAndThickness = true;
            this.btnDonemKayitSil.Click += new System.EventHandler(this.btnDonemKayitSil_Click);
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
            this.btnYenile.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYenile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.BackgroundImage")));
            this.btnYenile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.ButtonText = "";
            this.btnYenile.ButtonTextMarginLeft = 0;
            this.btnYenile.ColorContrastOnClick = 45;
            this.btnYenile.ColorContrastOnHover = 45;
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnYenile.CustomizableEdges = borderEdges3;
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
            this.btnYenile.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYenile.IdleBorderRadius = 1;
            this.btnYenile.IdleBorderThickness = 1;
            this.btnYenile.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYenile.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.IdleIconLeftImage")));
            this.btnYenile.IdleIconRightImage = null;
            this.btnYenile.IndicateFocus = false;
            this.btnYenile.Location = new System.Drawing.Point(1289, 154);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYenile.OnDisabledState.BorderRadius = 1;
            this.btnYenile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.OnDisabledState.BorderThickness = 1;
            this.btnYenile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYenile.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYenile.OnDisabledState.IconLeftImage = null;
            this.btnYenile.OnDisabledState.IconRightImage = null;
            this.btnYenile.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnYenile.onHoverState.BorderRadius = 1;
            this.btnYenile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.onHoverState.BorderThickness = 1;
            this.btnYenile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.btnYenile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnYenile.onHoverState.IconLeftImage = null;
            this.btnYenile.onHoverState.IconRightImage = null;
            this.btnYenile.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYenile.OnIdleState.BorderRadius = 1;
            this.btnYenile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.OnIdleState.BorderThickness = 1;
            this.btnYenile.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnYenile.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnYenile.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.OnIdleState.IconLeftImage")));
            this.btnYenile.OnIdleState.IconRightImage = null;
            this.btnYenile.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnYenile.OnPressedState.BorderRadius = 1;
            this.btnYenile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYenile.OnPressedState.BorderThickness = 1;
            this.btnYenile.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnYenile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnYenile.OnPressedState.IconLeftImage = null;
            this.btnYenile.OnPressedState.IconRightImage = null;
            this.btnYenile.Size = new System.Drawing.Size(35, 32);
            this.btnYenile.TabIndex = 170;
            this.btnYenile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYenile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnYenile.TextMarginLeft = 0;
            this.btnYenile.TextPadding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnYenile.UseDefaultRadiusAndThickness = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel7);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.linkLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(173)))), ((int)(((byte)(142)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1353, 154);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(413, 210);
            this.bunifuGradientPanel1.TabIndex = 171;
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel7.Location = new System.Drawing.Point(21, 171);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(260, 100);
            this.linkLabel7.TabIndex = 16;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Net Ücret = Brüt - Kesintiler Toplamı\r\n\r\n\r\n\r\n\r\n";
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel6.Location = new System.Drawing.Point(21, 149);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(285, 80);
            this.linkLabel6.TabIndex = 15;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Damga Vergisi = Brüt * 0,00759 - 75,96\r\n\r\n\r\n\r\n";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel5.Location = new System.Drawing.Point(21, 129);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(369, 60);
            this.linkLabel5.TabIndex = 14;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Gelir Vergisi = Gelir Vergisi Matrahı * 0,15 - 1276,02\r\n\r\n\r\n";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel4.Location = new System.Drawing.Point(21, 89);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(319, 40);
            this.linkLabel4.TabIndex = 13;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Gelir Vergisi Matrahı =\r\nBrüt - (SGK İşçi Payı +SGK İşçi İşsizlik Payı )";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel3.Location = new System.Drawing.Point(21, 69);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(216, 20);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "SGK İşçi İşsizlik Payı = %0,01";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.Location = new System.Drawing.Point(21, 49);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(166, 20);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "SGK İşçi Payı = %0,14";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.Location = new System.Drawing.Point(131, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 25);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Açıklamalar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // btnExceleAl
            // 
            this.btnExceleAl.AllowAnimations = true;
            this.btnExceleAl.AllowMouseEffects = true;
            this.btnExceleAl.AllowToggling = false;
            this.btnExceleAl.AnimationSpeed = 200;
            this.btnExceleAl.AutoGenerateColors = false;
            this.btnExceleAl.AutoRoundBorders = false;
            this.btnExceleAl.AutoSizeLeftIcon = true;
            this.btnExceleAl.AutoSizeRightIcon = true;
            this.btnExceleAl.BackColor = System.Drawing.Color.Transparent;
            this.btnExceleAl.BackColor1 = System.Drawing.Color.SteelBlue;
            this.btnExceleAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExceleAl.BackgroundImage")));
            this.btnExceleAl.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExceleAl.ButtonText = "Excel Olarak Çıkar\r\n";
            this.btnExceleAl.ButtonTextMarginLeft = 0;
            this.btnExceleAl.ColorContrastOnClick = 45;
            this.btnExceleAl.ColorContrastOnHover = 45;
            this.btnExceleAl.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnExceleAl.CustomizableEdges = borderEdges4;
            this.btnExceleAl.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExceleAl.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExceleAl.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExceleAl.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExceleAl.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExceleAl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExceleAl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExceleAl.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExceleAl.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExceleAl.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnExceleAl.IconMarginLeft = 11;
            this.btnExceleAl.IconPadding = 11;
            this.btnExceleAl.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExceleAl.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExceleAl.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExceleAl.IconSize = 20;
            this.btnExceleAl.IdleBorderColor = System.Drawing.Color.SteelBlue;
            this.btnExceleAl.IdleBorderRadius = 1;
            this.btnExceleAl.IdleBorderThickness = 1;
            this.btnExceleAl.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btnExceleAl.IdleIconLeftImage = null;
            this.btnExceleAl.IdleIconRightImage = null;
            this.btnExceleAl.IndicateFocus = false;
            this.btnExceleAl.Location = new System.Drawing.Point(1093, 154);
            this.btnExceleAl.Name = "btnExceleAl";
            this.btnExceleAl.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExceleAl.OnDisabledState.BorderRadius = 1;
            this.btnExceleAl.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExceleAl.OnDisabledState.BorderThickness = 1;
            this.btnExceleAl.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExceleAl.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExceleAl.OnDisabledState.IconLeftImage = null;
            this.btnExceleAl.OnDisabledState.IconRightImage = null;
            this.btnExceleAl.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(186)))), ((int)(((byte)(213)))));
            this.btnExceleAl.onHoverState.BorderRadius = 1;
            this.btnExceleAl.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExceleAl.onHoverState.BorderThickness = 1;
            this.btnExceleAl.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(186)))), ((int)(((byte)(213)))));
            this.btnExceleAl.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExceleAl.onHoverState.IconLeftImage = null;
            this.btnExceleAl.onHoverState.IconRightImage = null;
            this.btnExceleAl.OnIdleState.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnExceleAl.OnIdleState.BorderRadius = 1;
            this.btnExceleAl.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExceleAl.OnIdleState.BorderThickness = 1;
            this.btnExceleAl.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnExceleAl.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExceleAl.OnIdleState.IconLeftImage = null;
            this.btnExceleAl.OnIdleState.IconRightImage = null;
            this.btnExceleAl.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
            this.btnExceleAl.OnPressedState.BorderRadius = 1;
            this.btnExceleAl.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExceleAl.OnPressedState.BorderThickness = 1;
            this.btnExceleAl.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
            this.btnExceleAl.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExceleAl.OnPressedState.IconLeftImage = null;
            this.btnExceleAl.OnPressedState.IconRightImage = null;
            this.btnExceleAl.Size = new System.Drawing.Size(190, 32);
            this.btnExceleAl.TabIndex = 172;
            this.btnExceleAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExceleAl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExceleAl.TextMarginLeft = 0;
            this.btnExceleAl.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExceleAl.UseDefaultRadiusAndThickness = true;
            this.btnExceleAl.Click += new System.EventHandler(this.btnExceleAl_Click);
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel8.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel8.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel8.Location = new System.Drawing.Point(54, 157);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(216, 24);
            this.linkLabel8.TabIndex = 12;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Dönem Ay / Dönem Yıl : ";
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            // 
            // btnPdfCikar
            // 
            this.btnPdfCikar.AllowAnimations = true;
            this.btnPdfCikar.AllowMouseEffects = true;
            this.btnPdfCikar.AllowToggling = false;
            this.btnPdfCikar.AnimationSpeed = 200;
            this.btnPdfCikar.AutoGenerateColors = false;
            this.btnPdfCikar.AutoRoundBorders = false;
            this.btnPdfCikar.AutoSizeLeftIcon = true;
            this.btnPdfCikar.AutoSizeRightIcon = true;
            this.btnPdfCikar.BackColor = System.Drawing.Color.Transparent;
            this.btnPdfCikar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.btnPdfCikar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdfCikar.BackgroundImage")));
            this.btnPdfCikar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPdfCikar.ButtonText = "PDF Olarak Çıkar\r\n";
            this.btnPdfCikar.ButtonTextMarginLeft = 0;
            this.btnPdfCikar.ColorContrastOnClick = 45;
            this.btnPdfCikar.ColorContrastOnHover = 45;
            this.btnPdfCikar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnPdfCikar.CustomizableEdges = borderEdges5;
            this.btnPdfCikar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPdfCikar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPdfCikar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPdfCikar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPdfCikar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPdfCikar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPdfCikar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPdfCikar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdfCikar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPdfCikar.IconLeftPadding = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.btnPdfCikar.IconMarginLeft = 11;
            this.btnPdfCikar.IconPadding = 11;
            this.btnPdfCikar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPdfCikar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPdfCikar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPdfCikar.IconSize = 20;
            this.btnPdfCikar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.btnPdfCikar.IdleBorderRadius = 1;
            this.btnPdfCikar.IdleBorderThickness = 1;
            this.btnPdfCikar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.btnPdfCikar.IdleIconLeftImage = null;
            this.btnPdfCikar.IdleIconRightImage = null;
            this.btnPdfCikar.IndicateFocus = false;
            this.btnPdfCikar.Location = new System.Drawing.Point(885, 155);
            this.btnPdfCikar.Name = "btnPdfCikar";
            this.btnPdfCikar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPdfCikar.OnDisabledState.BorderRadius = 1;
            this.btnPdfCikar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPdfCikar.OnDisabledState.BorderThickness = 1;
            this.btnPdfCikar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPdfCikar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPdfCikar.OnDisabledState.IconLeftImage = null;
            this.btnPdfCikar.OnDisabledState.IconRightImage = null;
            this.btnPdfCikar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(125)))), ((int)(((byte)(126)))));
            this.btnPdfCikar.onHoverState.BorderRadius = 1;
            this.btnPdfCikar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPdfCikar.onHoverState.BorderThickness = 1;
            this.btnPdfCikar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(125)))), ((int)(((byte)(126)))));
            this.btnPdfCikar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPdfCikar.onHoverState.IconLeftImage = null;
            this.btnPdfCikar.onHoverState.IconRightImage = null;
            this.btnPdfCikar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.btnPdfCikar.OnIdleState.BorderRadius = 1;
            this.btnPdfCikar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPdfCikar.OnIdleState.BorderThickness = 1;
            this.btnPdfCikar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.btnPdfCikar.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPdfCikar.OnIdleState.IconLeftImage = null;
            this.btnPdfCikar.OnIdleState.IconRightImage = null;
            this.btnPdfCikar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.btnPdfCikar.OnPressedState.BorderRadius = 1;
            this.btnPdfCikar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPdfCikar.OnPressedState.BorderThickness = 1;
            this.btnPdfCikar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(10)))), ((int)(((byte)(11)))));
            this.btnPdfCikar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPdfCikar.OnPressedState.IconLeftImage = null;
            this.btnPdfCikar.OnPressedState.IconRightImage = null;
            this.btnPdfCikar.Size = new System.Drawing.Size(202, 32);
            this.btnPdfCikar.TabIndex = 173;
            this.btnPdfCikar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPdfCikar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPdfCikar.TextMarginLeft = 0;
            this.btnPdfCikar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPdfCikar.UseDefaultRadiusAndThickness = true;
            this.btnPdfCikar.Click += new System.EventHandler(this.btnPdfCikar_Click);
            // 
            // Bordros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1825, 991);
            this.Controls.Add(this.btnPdfCikar);
            this.Controls.Add(this.btnExceleAl);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnDonemKayitSil);
            this.Controls.Add(this.btnDonemlikBordroHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropDonemYil);
            this.Controls.Add(this.dropDonemAy);
            this.Controls.Add(this.BordroGridList);
            this.Controls.Add(this.pnlTopItems);
            this.Controls.Add(this.linkLabel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bordros";
            this.Text = "Bordros";
            this.Load += new System.EventHandler(this.Bordros_Load);
            this.pnlTopItems.ResumeLayout(false);
            this.pnlTopItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BordroGridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroDS)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopItems;
        private System.Windows.Forms.LinkLabel PersonelListesiLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel KontrolPanelLink;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchboxPerList;
        private System.Windows.Forms.DataGridView BordroGridList;
        private Bunifu.UI.WinForms.BunifuDropdown dropDonemAy;
        private Bunifu.UI.WinForms.BunifuDropdown dropDonemYil;
        private System.Windows.Forms.Label label4;
        private ViewBordroDS viewBordroDS;
        private System.Windows.Forms.BindingSource viewBordroBindingSource;
        private ViewBordroDSTableAdapters.ViewBordroTableAdapter viewBordroTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDonemlikBordroHesapla;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDonemKayitSil;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYenile;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExceleAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTcknDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamGunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ızinliGunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemAyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemYilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bordroidDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPdfCikar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}