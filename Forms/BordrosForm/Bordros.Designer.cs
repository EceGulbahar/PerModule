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
            this.pnlTopItems = new System.Windows.Forms.Panel();
            this.PersonelListesiLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.KontrolPanelLink = new System.Windows.Forms.LinkLabel();
            this.txtSearchboxPerList = new Bunifu.UI.WinForms.BunifuTextBox();
            this.IzinGridList = new System.Windows.Forms.DataGridView();
            this.perTcknDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bordroidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamGunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ızinliGunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemAyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donemYilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewBordroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewBordroDS = new PerModule.ViewBordroDS();
            this.dropDonemAy = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dropDonemYil = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.viewBordroTableAdapter = new PerModule.ViewBordroDSTableAdapters.ViewBordroTableAdapter();
            this.btnDonemlikBordroHesapla = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlTopItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzinGridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroDS)).BeginInit();
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
            this.txtSearchboxPerList.Location = new System.Drawing.Point(1312, 3);
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
            this.txtSearchboxPerList.Size = new System.Drawing.Size(397, 42);
            this.txtSearchboxPerList.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearchboxPerList.TabIndex = 7;
            this.txtSearchboxPerList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchboxPerList.TextMarginBottom = 0;
            this.txtSearchboxPerList.TextMarginLeft = 3;
            this.txtSearchboxPerList.TextMarginTop = 0;
            this.txtSearchboxPerList.TextPlaceholder = "Bordroda Ara...";
            this.txtSearchboxPerList.UseSystemPasswordChar = false;
            this.txtSearchboxPerList.WordWrap = true;
            // 
            // IzinGridList
            // 
            this.IzinGridList.AllowUserToAddRows = false;
            this.IzinGridList.AllowUserToDeleteRows = false;
            this.IzinGridList.AllowUserToResizeRows = false;
            this.IzinGridList.AutoGenerateColumns = false;
            this.IzinGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IzinGridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.IzinGridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IzinGridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.IzinGridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IzinGridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IzinGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IzinGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perTcknDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.bordroidDataGridViewTextBoxColumn,
            this.personnelidDataGridViewTextBoxColumn,
            this.toplamGunDataGridViewTextBoxColumn,
            this.ızinliGunDataGridViewTextBoxColumn,
            this.brutMaasDataGridViewTextBoxColumn,
            this.netMaasDataGridViewTextBoxColumn,
            this.donemAyDataGridViewTextBoxColumn,
            this.donemYilDataGridViewTextBoxColumn});
            this.IzinGridList.DataSource = this.viewBordroBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(180)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IzinGridList.DefaultCellStyle = dataGridViewCellStyle2;
            this.IzinGridList.EnableHeadersVisualStyles = false;
            this.IzinGridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.IzinGridList.Location = new System.Drawing.Point(57, 203);
            this.IzinGridList.Name = "IzinGridList";
            this.IzinGridList.ReadOnly = true;
            this.IzinGridList.RowHeadersVisible = false;
            this.IzinGridList.RowTemplate.Height = 30;
            this.IzinGridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IzinGridList.Size = new System.Drawing.Size(1267, 776);
            this.IzinGridList.TabIndex = 16;
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
            // bordroidDataGridViewTextBoxColumn
            // 
            this.bordroidDataGridViewTextBoxColumn.DataPropertyName = "Bordroid";
            this.bordroidDataGridViewTextBoxColumn.HeaderText = "Bordroid";
            this.bordroidDataGridViewTextBoxColumn.Name = "bordroidDataGridViewTextBoxColumn";
            this.bordroidDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.dropDonemAy.Location = new System.Drawing.Point(57, 154);
            this.dropDonemAy.Name = "dropDonemAy";
            this.dropDonemAy.Size = new System.Drawing.Size(147, 32);
            this.dropDonemAy.TabIndex = 56;
            this.dropDonemAy.Text = null;
            this.dropDonemAy.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDonemAy.TextLeftMargin = 5;
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
            this.dropDonemYil.Location = new System.Drawing.Point(231, 154);
            this.dropDonemYil.Name = "dropDonemYil";
            this.dropDonemYil.Size = new System.Drawing.Size(137, 32);
            this.dropDonemYil.TabIndex = 57;
            this.dropDonemYil.Text = null;
            this.dropDonemYil.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDonemYil.TextLeftMargin = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(207, 162);
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
            this.btnDonemlikBordroHesapla.Location = new System.Drawing.Point(380, 154);
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
            this.btnDonemlikBordroHesapla.Size = new System.Drawing.Size(232, 32);
            this.btnDonemlikBordroHesapla.TabIndex = 168;
            this.btnDonemlikBordroHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDonemlikBordroHesapla.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDonemlikBordroHesapla.TextMarginLeft = 0;
            this.btnDonemlikBordroHesapla.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDonemlikBordroHesapla.UseDefaultRadiusAndThickness = true;
            this.btnDonemlikBordroHesapla.Click += new System.EventHandler(this.btnDonemlikBordroHesapla_Click);
            // 
            // Bordros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1825, 991);
            this.Controls.Add(this.btnDonemlikBordroHesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropDonemYil);
            this.Controls.Add(this.dropDonemAy);
            this.Controls.Add(this.IzinGridList);
            this.Controls.Add(this.pnlTopItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bordros";
            this.Text = "Bordros";
            this.Load += new System.EventHandler(this.Bordros_Load);
            this.pnlTopItems.ResumeLayout(false);
            this.pnlTopItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IzinGridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBordroDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopItems;
        private System.Windows.Forms.LinkLabel PersonelListesiLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel KontrolPanelLink;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearchboxPerList;
        private System.Windows.Forms.DataGridView IzinGridList;
        private Bunifu.UI.WinForms.BunifuDropdown dropDonemAy;
        private Bunifu.UI.WinForms.BunifuDropdown dropDonemYil;
        private System.Windows.Forms.Label label4;
        private ViewBordroDS viewBordroDS;
        private System.Windows.Forms.BindingSource viewBordroBindingSource;
        private ViewBordroDSTableAdapters.ViewBordroTableAdapter viewBordroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTcknDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bordroidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamGunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ızinliGunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemAyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donemYilDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDonemlikBordroHesapla;
    }
}