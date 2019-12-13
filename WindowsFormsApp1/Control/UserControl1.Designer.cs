namespace WindowsFormsApp1
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBuku = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCariBuku = new System.Windows.Forms.TableLayoutPanel();
            this.ddPrmCari = new Bunifu.Framework.UI.BunifuDropdown();
            this.tbCariBuku = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCariBuku = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tlpProperti = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEditBuku = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefreshBuku = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTambahBuku = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHapusBuku = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tlpBuku.SuspendLayout();
            this.tlpCariBuku.SuspendLayout();
            this.tlpProperti.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBuku
            // 
            this.tlpBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tlpBuku.ColumnCount = 3;
            this.tlpBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBuku.Controls.Add(this.tlpCariBuku, 1, 0);
            this.tlpBuku.Controls.Add(this.tlpProperti, 1, 2);
            this.tlpBuku.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tlpBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBuku.Location = new System.Drawing.Point(0, 0);
            this.tlpBuku.Name = "tlpBuku";
            this.tlpBuku.RowCount = 4;
            this.tlpBuku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.243193F));
            this.tlpBuku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.50391F));
            this.tlpBuku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.243193F));
            this.tlpBuku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.009701F));
            this.tlpBuku.Size = new System.Drawing.Size(1032, 724);
            this.tlpBuku.TabIndex = 11;
            // 
            // tlpCariBuku
            // 
            this.tlpCariBuku.ColumnCount = 3;
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.43758F));
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.56242F));
            this.tlpCariBuku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tlpCariBuku.Controls.Add(this.ddPrmCari, 0, 0);
            this.tlpCariBuku.Controls.Add(this.tbCariBuku, 1, 0);
            this.tlpCariBuku.Controls.Add(this.btnCariBuku, 2, 0);
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
        "Judul",
        "Penulis",
        "Pengarang"};
            this.ddPrmCari.Location = new System.Drawing.Point(3, 3);
            this.ddPrmCari.Name = "ddPrmCari";
            this.ddPrmCari.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddPrmCari.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddPrmCari.selectedIndex = 0;
            this.ddPrmCari.Size = new System.Drawing.Size(164, 40);
            this.ddPrmCari.TabIndex = 0;
            // 
            // tbCariBuku
            // 
            this.tbCariBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCariBuku.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbCariBuku.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCariBuku.ForeColor = System.Drawing.SystemColors.Control;
            this.tbCariBuku.HintForeColor = System.Drawing.Color.Empty;
            this.tbCariBuku.HintText = "Masukkan Keyword Buku";
            this.tbCariBuku.isPassword = false;
            this.tbCariBuku.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbCariBuku.LineIdleColor = System.Drawing.Color.Gray;
            this.tbCariBuku.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbCariBuku.LineThickness = 4;
            this.tbCariBuku.Location = new System.Drawing.Point(174, 9);
            this.tbCariBuku.Margin = new System.Windows.Forms.Padding(4);
            this.tbCariBuku.Name = "tbCariBuku";
            this.tbCariBuku.Size = new System.Drawing.Size(617, 33);
            this.tbCariBuku.TabIndex = 1;
            this.tbCariBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCariBuku
            // 
            this.btnCariBuku.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariBuku.BorderRadius = 0;
            this.btnCariBuku.ButtonText = "Cari Buku";
            this.btnCariBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCariBuku.DisabledColor = System.Drawing.Color.Gray;
            this.btnCariBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCariBuku.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCariBuku.Iconimage = null;
            this.btnCariBuku.Iconimage_right = null;
            this.btnCariBuku.Iconimage_right_Selected = null;
            this.btnCariBuku.Iconimage_Selected = null;
            this.btnCariBuku.IconMarginLeft = 0;
            this.btnCariBuku.IconMarginRight = 0;
            this.btnCariBuku.IconRightVisible = true;
            this.btnCariBuku.IconRightZoom = 0D;
            this.btnCariBuku.IconVisible = true;
            this.btnCariBuku.IconZoom = 90D;
            this.btnCariBuku.IsTab = false;
            this.btnCariBuku.Location = new System.Drawing.Point(798, 3);
            this.btnCariBuku.Name = "btnCariBuku";
            this.btnCariBuku.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCariBuku.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCariBuku.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCariBuku.selected = false;
            this.btnCariBuku.Size = new System.Drawing.Size(121, 40);
            this.btnCariBuku.TabIndex = 2;
            this.btnCariBuku.Text = "Cari Buku";
            this.btnCariBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCariBuku.Textcolor = System.Drawing.Color.White;
            this.btnCariBuku.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tlpProperti
            // 
            this.tlpProperti.ColumnCount = 4;
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProperti.Controls.Add(this.btnEditBuku, 0, 0);
            this.tlpProperti.Controls.Add(this.btnRefreshBuku, 0, 0);
            this.tlpProperti.Controls.Add(this.btnTambahBuku, 0, 0);
            this.tlpProperti.Controls.Add(this.btnHapusBuku, 0, 0);
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
            this.tableLayoutPanel1.Controls.Add(this.bunifuCustomDataGrid1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 605);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 3);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(916, 599);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            // 
            // btnEditBuku
            // 
            this.btnEditBuku.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditBuku.BorderRadius = 0;
            this.btnEditBuku.ButtonText = "            Edit Buku";
            this.btnEditBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBuku.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditBuku.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditBuku.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Edit_24px;
            this.btnEditBuku.Iconimage_right = null;
            this.btnEditBuku.Iconimage_right_Selected = null;
            this.btnEditBuku.Iconimage_Selected = null;
            this.btnEditBuku.IconMarginLeft = 0;
            this.btnEditBuku.IconMarginRight = 0;
            this.btnEditBuku.IconRightVisible = true;
            this.btnEditBuku.IconRightZoom = 0D;
            this.btnEditBuku.IconVisible = true;
            this.btnEditBuku.IconZoom = 65D;
            this.btnEditBuku.IsTab = false;
            this.btnEditBuku.Location = new System.Drawing.Point(463, 3);
            this.btnEditBuku.Name = "btnEditBuku";
            this.btnEditBuku.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditBuku.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditBuku.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditBuku.selected = false;
            this.btnEditBuku.Size = new System.Drawing.Size(224, 37);
            this.btnEditBuku.TabIndex = 6;
            this.btnEditBuku.Text = "            Edit Buku";
            this.btnEditBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditBuku.Textcolor = System.Drawing.Color.White;
            this.btnEditBuku.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRefreshBuku
            // 
            this.btnRefreshBuku.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshBuku.BorderRadius = 0;
            this.btnRefreshBuku.ButtonText = "            Refresh Book List";
            this.btnRefreshBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshBuku.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefreshBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshBuku.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefreshBuku.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Refresh_24px;
            this.btnRefreshBuku.Iconimage_right = null;
            this.btnRefreshBuku.Iconimage_right_Selected = null;
            this.btnRefreshBuku.Iconimage_Selected = null;
            this.btnRefreshBuku.IconMarginLeft = 0;
            this.btnRefreshBuku.IconMarginRight = 0;
            this.btnRefreshBuku.IconRightVisible = true;
            this.btnRefreshBuku.IconRightZoom = 0D;
            this.btnRefreshBuku.IconVisible = true;
            this.btnRefreshBuku.IconZoom = 65D;
            this.btnRefreshBuku.IsTab = false;
            this.btnRefreshBuku.Location = new System.Drawing.Point(693, 3);
            this.btnRefreshBuku.Name = "btnRefreshBuku";
            this.btnRefreshBuku.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRefreshBuku.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRefreshBuku.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefreshBuku.selected = false;
            this.btnRefreshBuku.Size = new System.Drawing.Size(226, 37);
            this.btnRefreshBuku.TabIndex = 5;
            this.btnRefreshBuku.Text = "            Refresh Book List";
            this.btnRefreshBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshBuku.Textcolor = System.Drawing.Color.White;
            this.btnRefreshBuku.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambahBuku.BorderRadius = 0;
            this.btnTambahBuku.ButtonText = "            Tambah Buku";
            this.btnTambahBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahBuku.DisabledColor = System.Drawing.Color.Gray;
            this.btnTambahBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTambahBuku.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTambahBuku.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Plus_24px;
            this.btnTambahBuku.Iconimage_right = null;
            this.btnTambahBuku.Iconimage_right_Selected = null;
            this.btnTambahBuku.Iconimage_Selected = null;
            this.btnTambahBuku.IconMarginLeft = 0;
            this.btnTambahBuku.IconMarginRight = 0;
            this.btnTambahBuku.IconRightVisible = true;
            this.btnTambahBuku.IconRightZoom = 0D;
            this.btnTambahBuku.IconVisible = true;
            this.btnTambahBuku.IconZoom = 65D;
            this.btnTambahBuku.IsTab = false;
            this.btnTambahBuku.Location = new System.Drawing.Point(3, 3);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTambahBuku.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTambahBuku.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTambahBuku.selected = false;
            this.btnTambahBuku.Size = new System.Drawing.Size(224, 37);
            this.btnTambahBuku.TabIndex = 4;
            this.btnTambahBuku.Text = "            Tambah Buku";
            this.btnTambahBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambahBuku.Textcolor = System.Drawing.Color.White;
            this.btnTambahBuku.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBuku.Click += new System.EventHandler(this.btnTambahBuku_Click);
            // 
            // btnHapusBuku
            // 
            this.btnHapusBuku.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapusBuku.BorderRadius = 0;
            this.btnHapusBuku.ButtonText = "            Hapus Buku";
            this.btnHapusBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusBuku.DisabledColor = System.Drawing.Color.Gray;
            this.btnHapusBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHapusBuku.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHapusBuku.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Trash_24px;
            this.btnHapusBuku.Iconimage_right = null;
            this.btnHapusBuku.Iconimage_right_Selected = null;
            this.btnHapusBuku.Iconimage_Selected = null;
            this.btnHapusBuku.IconMarginLeft = 0;
            this.btnHapusBuku.IconMarginRight = 0;
            this.btnHapusBuku.IconRightVisible = true;
            this.btnHapusBuku.IconRightZoom = 0D;
            this.btnHapusBuku.IconVisible = true;
            this.btnHapusBuku.IconZoom = 65D;
            this.btnHapusBuku.IsTab = false;
            this.btnHapusBuku.Location = new System.Drawing.Point(233, 3);
            this.btnHapusBuku.Name = "btnHapusBuku";
            this.btnHapusBuku.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHapusBuku.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHapusBuku.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHapusBuku.selected = false;
            this.btnHapusBuku.Size = new System.Drawing.Size(224, 37);
            this.btnHapusBuku.TabIndex = 3;
            this.btnHapusBuku.Text = "            Hapus Buku";
            this.btnHapusBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHapusBuku.Textcolor = System.Drawing.Color.White;
            this.btnHapusBuku.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBuku);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1032, 724);
            this.tlpBuku.ResumeLayout(false);
            this.tlpCariBuku.ResumeLayout(false);
            this.tlpProperti.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBuku;
        private System.Windows.Forms.TableLayoutPanel tlpCariBuku;
        private Bunifu.Framework.UI.BunifuDropdown ddPrmCari;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCariBuku;
        private Bunifu.Framework.UI.BunifuFlatButton btnCariBuku;
        private System.Windows.Forms.TableLayoutPanel tlpProperti;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditBuku;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefreshBuku;
        private Bunifu.Framework.UI.BunifuFlatButton btnTambahBuku;
        private Bunifu.Framework.UI.BunifuFlatButton btnHapusBuku;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
