namespace WindowsFormsApp1
{
    partial class usrMgmtDerivedStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMember = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCariBuku = new System.Windows.Forms.TableLayoutPanel();
            this.ddPrmCari = new Bunifu.Framework.UI.BunifuDropdown();
            this.tbCariStaff = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCariStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tlpProperti = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefreshStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTambahStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHapusStaff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgStaff = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tlpMember.SuspendLayout();
            this.tlpCariBuku.SuspendLayout();
            this.tlpProperti.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).BeginInit();
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
            this.tlpMember.TabIndex = 13;
            // 
            // tlpCariBuku
            // 
            this.tlpCariBuku.ColumnCount = 3;
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.43758F));
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.56242F));
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpCariBuku.Controls.Add(this.ddPrmCari, 0, 0);
            this.tlpCariBuku.Controls.Add(this.tbCariStaff, 1, 0);
            this.tlpCariBuku.Controls.Add(this.btnCariStaff, 2, 0);
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
            // tbCariStaff
            // 
            this.tbCariStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCariStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCariStaff.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCariStaff.ForeColor = System.Drawing.SystemColors.Control;
            this.tbCariStaff.HintForeColor = System.Drawing.Color.Empty;
            this.tbCariStaff.HintText = "Masukkan Keyword Staff";
            this.tbCariStaff.isPassword = false;
            this.tbCariStaff.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbCariStaff.LineIdleColor = System.Drawing.Color.Gray;
            this.tbCariStaff.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbCariStaff.LineThickness = 4;
            this.tbCariStaff.Location = new System.Drawing.Point(174, 9);
            this.tbCariStaff.Margin = new System.Windows.Forms.Padding(4);
            this.tbCariStaff.Name = "tbCariStaff";
            this.tbCariStaff.Size = new System.Drawing.Size(615, 33);
            this.tbCariStaff.TabIndex = 1;
            this.tbCariStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCariStaff
            // 
            this.btnCariStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariStaff.BorderRadius = 0;
            this.btnCariStaff.ButtonText = "Cari Staff";
            this.btnCariStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnCariStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCariStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCariStaff.Iconimage = null;
            this.btnCariStaff.Iconimage_right = null;
            this.btnCariStaff.Iconimage_right_Selected = null;
            this.btnCariStaff.Iconimage_Selected = null;
            this.btnCariStaff.IconMarginLeft = 0;
            this.btnCariStaff.IconMarginRight = 0;
            this.btnCariStaff.IconRightVisible = true;
            this.btnCariStaff.IconRightZoom = 0D;
            this.btnCariStaff.IconVisible = true;
            this.btnCariStaff.IconZoom = 90D;
            this.btnCariStaff.IsTab = false;
            this.btnCariStaff.Location = new System.Drawing.Point(796, 3);
            this.btnCariStaff.Name = "btnCariStaff";
            this.btnCariStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCariStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCariStaff.selected = false;
            this.btnCariStaff.Size = new System.Drawing.Size(123, 40);
            this.btnCariStaff.TabIndex = 2;
            this.btnCariStaff.Text = "Cari Staff";
            this.btnCariStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCariStaff.Textcolor = System.Drawing.Color.White;
            this.btnCariStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tlpProperti
            // 
            this.tlpProperti.ColumnCount = 4;
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.Controls.Add(this.btnEditStaff, 0, 0);
            this.tlpProperti.Controls.Add(this.btnRefreshStaff, 0, 0);
            this.tlpProperti.Controls.Add(this.btnTambahStaff, 0, 0);
            this.tlpProperti.Controls.Add(this.btnHapusStaff, 0, 0);
            this.tlpProperti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpProperti.Location = new System.Drawing.Point(54, 669);
            this.tlpProperti.Name = "tlpProperti";
            this.tlpProperti.RowCount = 1;
            this.tlpProperti.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProperti.Size = new System.Drawing.Size(922, 43);
            this.tlpProperti.TabIndex = 2;
            // 
            // btnEditStaff
            // 
            this.btnEditStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditStaff.BorderRadius = 0;
            this.btnEditStaff.ButtonText = "   Edit Staff";
            this.btnEditStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditStaff.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Edit_24px;
            this.btnEditStaff.Iconimage_right = null;
            this.btnEditStaff.Iconimage_right_Selected = null;
            this.btnEditStaff.Iconimage_Selected = null;
            this.btnEditStaff.IconMarginLeft = 0;
            this.btnEditStaff.IconMarginRight = 0;
            this.btnEditStaff.IconRightVisible = true;
            this.btnEditStaff.IconRightZoom = 0D;
            this.btnEditStaff.IconVisible = true;
            this.btnEditStaff.IconZoom = 65D;
            this.btnEditStaff.IsTab = false;
            this.btnEditStaff.Location = new System.Drawing.Point(463, 3);
            this.btnEditStaff.Name = "btnEditStaff";
            this.btnEditStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditStaff.selected = false;
            this.btnEditStaff.Size = new System.Drawing.Size(224, 37);
            this.btnEditStaff.TabIndex = 6;
            this.btnEditStaff.Text = "   Edit Staff";
            this.btnEditStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStaff.Textcolor = System.Drawing.Color.White;
            this.btnEditStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRefreshStaff
            // 
            this.btnRefreshStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshStaff.BorderRadius = 0;
            this.btnRefreshStaff.ButtonText = "   Refresh Staff List";
            this.btnRefreshStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefreshStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefreshStaff.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Refresh_24px;
            this.btnRefreshStaff.Iconimage_right = null;
            this.btnRefreshStaff.Iconimage_right_Selected = null;
            this.btnRefreshStaff.Iconimage_Selected = null;
            this.btnRefreshStaff.IconMarginLeft = 0;
            this.btnRefreshStaff.IconMarginRight = 0;
            this.btnRefreshStaff.IconRightVisible = true;
            this.btnRefreshStaff.IconRightZoom = 0D;
            this.btnRefreshStaff.IconVisible = true;
            this.btnRefreshStaff.IconZoom = 65D;
            this.btnRefreshStaff.IsTab = false;
            this.btnRefreshStaff.Location = new System.Drawing.Point(693, 3);
            this.btnRefreshStaff.Name = "btnRefreshStaff";
            this.btnRefreshStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRefreshStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefreshStaff.selected = false;
            this.btnRefreshStaff.Size = new System.Drawing.Size(226, 37);
            this.btnRefreshStaff.TabIndex = 5;
            this.btnRefreshStaff.Text = "   Refresh Staff List";
            this.btnRefreshStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshStaff.Textcolor = System.Drawing.Color.White;
            this.btnRefreshStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTambahStaff
            // 
            this.btnTambahStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahStaff.BorderRadius = 0;
            this.btnTambahStaff.ButtonText = "   Tambah Staff";
            this.btnTambahStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnTambahStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTambahStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTambahStaff.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Plus_24px;
            this.btnTambahStaff.Iconimage_right = null;
            this.btnTambahStaff.Iconimage_right_Selected = null;
            this.btnTambahStaff.Iconimage_Selected = null;
            this.btnTambahStaff.IconMarginLeft = 0;
            this.btnTambahStaff.IconMarginRight = 0;
            this.btnTambahStaff.IconRightVisible = true;
            this.btnTambahStaff.IconRightZoom = 0D;
            this.btnTambahStaff.IconVisible = true;
            this.btnTambahStaff.IconZoom = 65D;
            this.btnTambahStaff.IsTab = false;
            this.btnTambahStaff.Location = new System.Drawing.Point(3, 3);
            this.btnTambahStaff.Name = "btnTambahStaff";
            this.btnTambahStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTambahStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTambahStaff.selected = false;
            this.btnTambahStaff.Size = new System.Drawing.Size(224, 37);
            this.btnTambahStaff.TabIndex = 4;
            this.btnTambahStaff.Text = "   Tambah Staff";
            this.btnTambahStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambahStaff.Textcolor = System.Drawing.Color.White;
            this.btnTambahStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHapusStaff
            // 
            this.btnHapusStaff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapusStaff.BorderRadius = 0;
            this.btnHapusStaff.ButtonText = "   Hapus Staff";
            this.btnHapusStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusStaff.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapusStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHapusStaff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapusStaff.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Trash_24px;
            this.btnHapusStaff.Iconimage_right = null;
            this.btnHapusStaff.Iconimage_right_Selected = null;
            this.btnHapusStaff.Iconimage_Selected = null;
            this.btnHapusStaff.IconMarginLeft = 0;
            this.btnHapusStaff.IconMarginRight = 0;
            this.btnHapusStaff.IconRightVisible = true;
            this.btnHapusStaff.IconRightZoom = 0D;
            this.btnHapusStaff.IconVisible = true;
            this.btnHapusStaff.IconZoom = 65D;
            this.btnHapusStaff.IsTab = false;
            this.btnHapusStaff.Location = new System.Drawing.Point(233, 3);
            this.btnHapusStaff.Name = "btnHapusStaff";
            this.btnHapusStaff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusStaff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHapusStaff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapusStaff.selected = false;
            this.btnHapusStaff.Size = new System.Drawing.Size(224, 37);
            this.btnHapusStaff.TabIndex = 3;
            this.btnHapusStaff.Text = "   Hapus Staff";
            this.btnHapusStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapusStaff.Textcolor = System.Drawing.Color.White;
            this.btnHapusStaff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgStaff, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 605);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgStaff
            // 
            this.dgStaff.AllowUserToAddRows = false;
            this.dgStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStaff.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStaff.DoubleBuffered = true;
            this.dgStaff.EnableHeadersVisualStyles = false;
            this.dgStaff.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgStaff.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgStaff.Location = new System.Drawing.Point(3, 3);
            this.dgStaff.Name = "dgStaff";
            this.dgStaff.ReadOnly = true;
            this.dgStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgStaff.Size = new System.Drawing.Size(916, 599);
            this.dgStaff.TabIndex = 0;
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
            this.btnBack.Iconimage = global::WindowsFormsApp1.Properties.Resources.balek;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // usrMgmtDerivedStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMember);
            this.Name = "usrMgmtDerivedStaff";
            this.Size = new System.Drawing.Size(1032, 724);
            this.tlpMember.ResumeLayout(false);
            this.tlpCariBuku.ResumeLayout(false);
            this.tlpProperti.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMember;
        private System.Windows.Forms.TableLayoutPanel tlpCariBuku;
        private Bunifu.Framework.UI.BunifuDropdown ddPrmCari;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCariStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnCariStaff;
        private System.Windows.Forms.TableLayoutPanel tlpProperti;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefreshStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnTambahStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnHapusStaff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgStaff;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}
