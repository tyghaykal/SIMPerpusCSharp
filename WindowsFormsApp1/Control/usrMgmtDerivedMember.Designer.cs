namespace WindowsFormsApp1
{
    partial class usrMgmtDerivedMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMember = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCariBuku = new System.Windows.Forms.TableLayoutPanel();
            this.ddPrmCari = new Bunifu.Framework.UI.BunifuDropdown();
            this.tbCariMember = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCariMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tlpProperti = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgMember = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnEditMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefreshMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTambahMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHapusMember = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tlpMember.SuspendLayout();
            this.tlpCariBuku.SuspendLayout();
            this.tlpProperti.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMember)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMember
            // 
            this.tlpMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tlpMember.ColumnCount = 3;
            this.tlpMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMember.Controls.Add(this.tlpCariBuku, 1, 0);
            this.tlpMember.Controls.Add(this.tlpProperti, 1, 2);
            this.tlpMember.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tlpMember.Controls.Add(this.btnBack, 0, 0);
            this.tlpMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMember.Location = new System.Drawing.Point(0, 0);
            this.tlpMember.Name = "tlpMember";
            this.tlpMember.RowCount = 4;
            this.tlpMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.243193F));
            this.tlpMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.50391F));
            this.tlpMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.243193F));
            this.tlpMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.009701F));
            this.tlpMember.Size = new System.Drawing.Size(1032, 724);
            this.tlpMember.TabIndex = 12;
            // 
            // tlpCariBuku
            // 
            this.tlpCariBuku.ColumnCount = 3;
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.43758F));
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.56242F));
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tlpCariBuku.Controls.Add(this.ddPrmCari, 0, 0);
            this.tlpCariBuku.Controls.Add(this.tbCariMember, 1, 0);
            this.tlpCariBuku.Controls.Add(this.btnCariMember, 2, 0);
            this.tlpCariBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCariBuku.Location = new System.Drawing.Point(54, 3);
            this.tlpCariBuku.Name = "tlpCariBuku";
            this.tlpCariBuku.RowCount = 1;
            this.tlpCariBuku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCariBuku.Size = new System.Drawing.Size(922, 46);
            this.tlpCariBuku.TabIndex = 1;
            // 
            // ddPrmCari
            // 
            this.ddPrmCari.BackColor = System.Drawing.Color.Transparent;
            this.ddPrmCari.BorderRadius = 3;
            this.ddPrmCari.DisabledColor = System.Drawing.Color.Gray;
            this.ddPrmCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddPrmCari.ForeColor = System.Drawing.Color.White;
            this.ddPrmCari.Items = new string[] {
        "ID",
        "Nama"};
            this.ddPrmCari.Location = new System.Drawing.Point(3, 3);
            this.ddPrmCari.Name = "ddPrmCari";
            this.ddPrmCari.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddPrmCari.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddPrmCari.selectedIndex = -1;
            this.ddPrmCari.Size = new System.Drawing.Size(164, 40);
            this.ddPrmCari.TabIndex = 0;
            // 
            // tbCariMember
            // 
            this.tbCariMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCariMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCariMember.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCariMember.ForeColor = System.Drawing.Color.White;
            this.tbCariMember.HintForeColor = System.Drawing.Color.Empty;
            this.tbCariMember.HintText = "Masukkan Keyword Member";
            this.tbCariMember.isPassword = false;
            this.tbCariMember.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbCariMember.LineIdleColor = System.Drawing.Color.Gray;
            this.tbCariMember.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbCariMember.LineThickness = 4;
            this.tbCariMember.Location = new System.Drawing.Point(174, 9);
            this.tbCariMember.Margin = new System.Windows.Forms.Padding(4);
            this.tbCariMember.Name = "tbCariMember";
            this.tbCariMember.Size = new System.Drawing.Size(615, 33);
            this.tbCariMember.TabIndex = 1;
            this.tbCariMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCariMember
            // 
            this.btnCariMember.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariMember.BorderRadius = 0;
            this.btnCariMember.ButtonText = "Cari Member";
            this.btnCariMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnCariMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCariMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCariMember.Iconimage = null;
            this.btnCariMember.Iconimage_right = null;
            this.btnCariMember.Iconimage_right_Selected = null;
            this.btnCariMember.Iconimage_Selected = null;
            this.btnCariMember.IconMarginLeft = 0;
            this.btnCariMember.IconMarginRight = 0;
            this.btnCariMember.IconRightVisible = true;
            this.btnCariMember.IconRightZoom = 0D;
            this.btnCariMember.IconVisible = true;
            this.btnCariMember.IconZoom = 90D;
            this.btnCariMember.IsTab = false;
            this.btnCariMember.Location = new System.Drawing.Point(796, 3);
            this.btnCariMember.Name = "btnCariMember";
            this.btnCariMember.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariMember.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCariMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCariMember.selected = false;
            this.btnCariMember.Size = new System.Drawing.Size(123, 40);
            this.btnCariMember.TabIndex = 2;
            this.btnCariMember.Text = "Cari Member";
            this.btnCariMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCariMember.Textcolor = System.Drawing.Color.White;
            this.btnCariMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tlpProperti
            // 
            this.tlpProperti.ColumnCount = 4;
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.Controls.Add(this.btnEditMember, 0, 0);
            this.tlpProperti.Controls.Add(this.btnRefreshMember, 0, 0);
            this.tlpProperti.Controls.Add(this.btnTambahMember, 0, 0);
            this.tlpProperti.Controls.Add(this.btnHapusMember, 0, 0);
            this.tlpProperti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpProperti.Location = new System.Drawing.Point(54, 669);
            this.tlpProperti.Name = "tlpProperti";
            this.tlpProperti.RowCount = 1;
            this.tlpProperti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperti.Size = new System.Drawing.Size(922, 43);
            this.tlpProperti.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgMember, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 605);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgMember
            // 
            this.dgMember.AllowUserToAddRows = false;
            this.dgMember.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgMember.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMember.DoubleBuffered = true;
            this.dgMember.EnableHeadersVisualStyles = false;
            this.dgMember.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgMember.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgMember.Location = new System.Drawing.Point(3, 3);
            this.dgMember.Name = "dgMember";
            this.dgMember.ReadOnly = true;
            this.dgMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMember.Size = new System.Drawing.Size(916, 599);
            this.dgMember.TabIndex = 0;
            // 
            // btnEditMember
            // 
            this.btnEditMember.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditMember.BorderRadius = 0;
            this.btnEditMember.ButtonText = "   Edit Member";
            this.btnEditMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditMember.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Edit_24px;
            this.btnEditMember.Iconimage_right = null;
            this.btnEditMember.Iconimage_right_Selected = null;
            this.btnEditMember.Iconimage_Selected = null;
            this.btnEditMember.IconMarginLeft = 0;
            this.btnEditMember.IconMarginRight = 0;
            this.btnEditMember.IconRightVisible = true;
            this.btnEditMember.IconRightZoom = 0D;
            this.btnEditMember.IconVisible = true;
            this.btnEditMember.IconZoom = 65D;
            this.btnEditMember.IsTab = false;
            this.btnEditMember.Location = new System.Drawing.Point(463, 3);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditMember.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditMember.selected = false;
            this.btnEditMember.Size = new System.Drawing.Size(224, 37);
            this.btnEditMember.TabIndex = 6;
            this.btnEditMember.Text = "   Edit Member";
            this.btnEditMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMember.Textcolor = System.Drawing.Color.White;
            this.btnEditMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRefreshMember
            // 
            this.btnRefreshMember.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshMember.BorderRadius = 0;
            this.btnRefreshMember.ButtonText = "   Refresh Member List";
            this.btnRefreshMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefreshMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefreshMember.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Refresh_24px;
            this.btnRefreshMember.Iconimage_right = null;
            this.btnRefreshMember.Iconimage_right_Selected = null;
            this.btnRefreshMember.Iconimage_Selected = null;
            this.btnRefreshMember.IconMarginLeft = 0;
            this.btnRefreshMember.IconMarginRight = 0;
            this.btnRefreshMember.IconRightVisible = true;
            this.btnRefreshMember.IconRightZoom = 0D;
            this.btnRefreshMember.IconVisible = true;
            this.btnRefreshMember.IconZoom = 65D;
            this.btnRefreshMember.IsTab = false;
            this.btnRefreshMember.Location = new System.Drawing.Point(693, 3);
            this.btnRefreshMember.Name = "btnRefreshMember";
            this.btnRefreshMember.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshMember.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRefreshMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefreshMember.selected = false;
            this.btnRefreshMember.Size = new System.Drawing.Size(226, 37);
            this.btnRefreshMember.TabIndex = 5;
            this.btnRefreshMember.Text = "   Refresh Member List";
            this.btnRefreshMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshMember.Textcolor = System.Drawing.Color.White;
            this.btnRefreshMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTambahMember
            // 
            this.btnTambahMember.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahMember.BorderRadius = 0;
            this.btnTambahMember.ButtonText = "   Tambah Member";
            this.btnTambahMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnTambahMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTambahMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTambahMember.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Plus_24px;
            this.btnTambahMember.Iconimage_right = null;
            this.btnTambahMember.Iconimage_right_Selected = null;
            this.btnTambahMember.Iconimage_Selected = null;
            this.btnTambahMember.IconMarginLeft = 0;
            this.btnTambahMember.IconMarginRight = 0;
            this.btnTambahMember.IconRightVisible = true;
            this.btnTambahMember.IconRightZoom = 0D;
            this.btnTambahMember.IconVisible = true;
            this.btnTambahMember.IconZoom = 65D;
            this.btnTambahMember.IsTab = false;
            this.btnTambahMember.Location = new System.Drawing.Point(3, 3);
            this.btnTambahMember.Name = "btnTambahMember";
            this.btnTambahMember.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahMember.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTambahMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTambahMember.selected = false;
            this.btnTambahMember.Size = new System.Drawing.Size(224, 37);
            this.btnTambahMember.TabIndex = 4;
            this.btnTambahMember.Text = "   Tambah Member";
            this.btnTambahMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambahMember.Textcolor = System.Drawing.Color.White;
            this.btnTambahMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHapusMember
            // 
            this.btnHapusMember.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapusMember.BorderRadius = 0;
            this.btnHapusMember.ButtonText = "   Hapus Member";
            this.btnHapusMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusMember.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapusMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHapusMember.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapusMember.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Trash_24px;
            this.btnHapusMember.Iconimage_right = null;
            this.btnHapusMember.Iconimage_right_Selected = null;
            this.btnHapusMember.Iconimage_Selected = null;
            this.btnHapusMember.IconMarginLeft = 0;
            this.btnHapusMember.IconMarginRight = 0;
            this.btnHapusMember.IconRightVisible = true;
            this.btnHapusMember.IconRightZoom = 0D;
            this.btnHapusMember.IconVisible = true;
            this.btnHapusMember.IconZoom = 65D;
            this.btnHapusMember.IsTab = false;
            this.btnHapusMember.Location = new System.Drawing.Point(233, 3);
            this.btnHapusMember.Name = "btnHapusMember";
            this.btnHapusMember.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusMember.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHapusMember.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapusMember.selected = false;
            this.btnHapusMember.Size = new System.Drawing.Size(224, 37);
            this.btnHapusMember.TabIndex = 3;
            this.btnHapusMember.Text = "   Hapus Member";
            this.btnHapusMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapusMember.Textcolor = System.Drawing.Color.White;
            this.btnHapusMember.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = global::WindowsFormsApp1.Properties.Resources.balek1;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 90D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(45, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // usrMgmtDerivedMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMember);
            this.Name = "usrMgmtDerivedMember";
            this.Size = new System.Drawing.Size(1032, 724);
            this.tlpMember.ResumeLayout(false);
            this.tlpCariBuku.ResumeLayout(false);
            this.tlpProperti.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMember;
        private System.Windows.Forms.TableLayoutPanel tlpCariBuku;
        private Bunifu.Framework.UI.BunifuDropdown ddPrmCari;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCariMember;
        private Bunifu.Framework.UI.BunifuFlatButton btnCariMember;
        private System.Windows.Forms.TableLayoutPanel tlpProperti;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditMember;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefreshMember;
        private Bunifu.Framework.UI.BunifuFlatButton btnTambahMember;
        private Bunifu.Framework.UI.BunifuFlatButton btnHapusMember;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgMember;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}
