namespace WindowsFormsApp1
{
    partial class frmMain
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnMenuSlider = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAbout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMgmntUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPerpustakaan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuku = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogoTYG = new PictureBoxAbouAmmar.صورة_دائرة();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.anmTlpBuku = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.usrMgmtStaffLand1 = new WindowsFormsApp1.usrMgmtStaffLand();
            this.usrMgmtAdminLand1 = new WindowsFormsApp1.usrMgmtAdminLand();
            this.ucBooks = new WindowsFormsApp1.UserControl1();
            this.ucHome1 = new WindowsFormsApp1.ucHome();
            this.ucPerpustakanLanding1 = new WindowsFormsApp1.ucPerpustakanLanding();
            this.anmArrow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.anmSlider = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblUserLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserPrivelege = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTYG)).BeginInit();
            this.panelAtas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelLeft.Controls.Add(this.tableLayoutPanel2);
            this.panelLeft.Controls.Add(this.tableLayoutPanel1);
            this.panelLeft.Controls.Add(this.btnMenuSlider);
            this.panelLeft.Controls.Add(this.btnAbout);
            this.panelLeft.Controls.Add(this.btnMgmntUser);
            this.panelLeft.Controls.Add(this.btnPerpustakaan);
            this.panelLeft.Controls.Add(this.btnBuku);
            this.panelLeft.Controls.Add(this.LogoTYG);
            this.anmTlpBuku.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.panelLeft, BunifuAnimatorNS.DecorationType.None);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 44);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(332, 724);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // btnMenuSlider
            // 
            this.btnMenuSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.anmTlpBuku.SetDecoration(this.btnMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.btnMenuSlider, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuSlider.Image = global::WindowsFormsApp1.Properties.Resources.icons8_Menu_24px;
            this.btnMenuSlider.ImageActive = null;
            this.btnMenuSlider.Location = new System.Drawing.Point(299, 6);
            this.btnMenuSlider.Name = "btnMenuSlider";
            this.btnMenuSlider.Size = new System.Drawing.Size(27, 27);
            this.btnMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuSlider.TabIndex = 6;
            this.btnMenuSlider.TabStop = false;
            this.btnMenuSlider.Zoom = 10;
            this.btnMenuSlider.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.BorderRadius = 0;
            this.btnAbout.ButtonText = "    About";
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmSlider.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.btnAbout, BunifuAnimatorNS.DecorationType.None);
            this.btnAbout.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbout.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_High_Importance_24px_1;
            this.btnAbout.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnAbout.Iconimage_right")));
            this.btnAbout.Iconimage_right_Selected = null;
            this.btnAbout.Iconimage_Selected = null;
            this.btnAbout.IconMarginLeft = 0;
            this.btnAbout.IconMarginRight = 0;
            this.btnAbout.IconRightVisible = true;
            this.btnAbout.IconRightZoom = 0D;
            this.btnAbout.IconVisible = true;
            this.btnAbout.IconZoom = 55D;
            this.btnAbout.IsTab = false;
            this.btnAbout.Location = new System.Drawing.Point(0, 525);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAbout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAbout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbout.selected = false;
            this.btnAbout.Size = new System.Drawing.Size(334, 48);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "    About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Textcolor = System.Drawing.Color.White;
            this.btnAbout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMgmntUser
            // 
            this.btnMgmntUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMgmntUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMgmntUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMgmntUser.BorderRadius = 0;
            this.btnMgmntUser.ButtonText = "    Manajemen User dan Anggota";
            this.btnMgmntUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmSlider.SetDecoration(this.btnMgmntUser, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnMgmntUser, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.btnMgmntUser, BunifuAnimatorNS.DecorationType.None);
            this.btnMgmntUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnMgmntUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMgmntUser.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_User_Account_24px;
            this.btnMgmntUser.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnMgmntUser.Iconimage_right")));
            this.btnMgmntUser.Iconimage_right_Selected = null;
            this.btnMgmntUser.Iconimage_Selected = null;
            this.btnMgmntUser.IconMarginLeft = 0;
            this.btnMgmntUser.IconMarginRight = 0;
            this.btnMgmntUser.IconRightVisible = true;
            this.btnMgmntUser.IconRightZoom = 0D;
            this.btnMgmntUser.IconVisible = true;
            this.btnMgmntUser.IconZoom = 55D;
            this.btnMgmntUser.IsTab = false;
            this.btnMgmntUser.Location = new System.Drawing.Point(0, 446);
            this.btnMgmntUser.Name = "btnMgmntUser";
            this.btnMgmntUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMgmntUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMgmntUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMgmntUser.selected = false;
            this.btnMgmntUser.Size = new System.Drawing.Size(334, 48);
            this.btnMgmntUser.TabIndex = 4;
            this.btnMgmntUser.Text = "    Manajemen User dan Anggota";
            this.btnMgmntUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMgmntUser.Textcolor = System.Drawing.Color.White;
            this.btnMgmntUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMgmntUser.Click += new System.EventHandler(this.btnMgmntUser_Click);
            // 
            // btnPerpustakaan
            // 
            this.btnPerpustakaan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPerpustakaan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPerpustakaan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerpustakaan.BorderRadius = 0;
            this.btnPerpustakaan.ButtonText = "    Perpustakaan";
            this.btnPerpustakaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmSlider.SetDecoration(this.btnPerpustakaan, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnPerpustakaan, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.btnPerpustakaan, BunifuAnimatorNS.DecorationType.None);
            this.btnPerpustakaan.DisabledColor = System.Drawing.Color.Gray;
            this.btnPerpustakaan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPerpustakaan.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Museum_24px;
            this.btnPerpustakaan.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnPerpustakaan.Iconimage_right")));
            this.btnPerpustakaan.Iconimage_right_Selected = null;
            this.btnPerpustakaan.Iconimage_Selected = null;
            this.btnPerpustakaan.IconMarginLeft = 0;
            this.btnPerpustakaan.IconMarginRight = 0;
            this.btnPerpustakaan.IconRightVisible = true;
            this.btnPerpustakaan.IconRightZoom = 0D;
            this.btnPerpustakaan.IconVisible = true;
            this.btnPerpustakaan.IconZoom = 55D;
            this.btnPerpustakaan.IsTab = false;
            this.btnPerpustakaan.Location = new System.Drawing.Point(0, 367);
            this.btnPerpustakaan.Name = "btnPerpustakaan";
            this.btnPerpustakaan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPerpustakaan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPerpustakaan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPerpustakaan.selected = false;
            this.btnPerpustakaan.Size = new System.Drawing.Size(334, 48);
            this.btnPerpustakaan.TabIndex = 3;
            this.btnPerpustakaan.Text = "    Perpustakaan";
            this.btnPerpustakaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerpustakaan.Textcolor = System.Drawing.Color.White;
            this.btnPerpustakaan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerpustakaan.Click += new System.EventHandler(this.btnPerpustakaan_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuku.BorderRadius = 0;
            this.btnBuku.ButtonText = "    Buku";
            this.btnBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmSlider.SetDecoration(this.btnBuku, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnBuku, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.btnBuku, BunifuAnimatorNS.DecorationType.None);
            this.btnBuku.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuku.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuku.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Bookmark_24px;
            this.btnBuku.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("btnBuku.Iconimage_right")));
            this.btnBuku.Iconimage_right_Selected = null;
            this.btnBuku.Iconimage_Selected = null;
            this.btnBuku.IconMarginLeft = 0;
            this.btnBuku.IconMarginRight = 0;
            this.btnBuku.IconRightVisible = true;
            this.btnBuku.IconRightZoom = 0D;
            this.btnBuku.IconVisible = true;
            this.btnBuku.IconZoom = 55D;
            this.btnBuku.IsTab = false;
            this.btnBuku.Location = new System.Drawing.Point(0, 288);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBuku.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBuku.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuku.selected = false;
            this.btnBuku.Size = new System.Drawing.Size(334, 48);
            this.btnBuku.TabIndex = 2;
            this.btnBuku.Text = "    Buku";
            this.btnBuku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuku.Textcolor = System.Drawing.Color.White;
            this.btnBuku.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click);
            // 
            // LogoTYG
            // 
            this.LogoTYG.BackColor = System.Drawing.Color.DarkGray;
            this.anmSlider.SetDecoration(this.LogoTYG, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.LogoTYG, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.LogoTYG, BunifuAnimatorNS.DecorationType.None);
            this.LogoTYG.Image = ((System.Drawing.Image)(resources.GetObject("LogoTYG.Image")));
            this.LogoTYG.Location = new System.Drawing.Point(91, 26);
            this.LogoTYG.Name = "LogoTYG";
            this.LogoTYG.Size = new System.Drawing.Size(157, 140);
            this.LogoTYG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoTYG.TabIndex = 0;
            this.LogoTYG.TabStop = false;
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.panelAtas.Controls.Add(this.btnMinimize);
            this.panelAtas.Controls.Add(this.btnMaximize);
            this.panelAtas.Controls.Add(this.btnExit);
            this.anmTlpBuku.SetDecoration(this.panelAtas, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.panelAtas, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.panelAtas, BunifuAnimatorNS.DecorationType.None);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1366, 44);
            this.panelAtas.TabIndex = 0;
            this.panelAtas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAtas_Paint);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.ButtonText = "_";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmSlider.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.DisabledColor = System.Drawing.Color.Gray;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMinimize.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Minus_24px_4;
            this.btnMinimize.Iconimage_right = null;
            this.btnMinimize.Iconimage_right_Selected = null;
            this.btnMinimize.Iconimage_Selected = null;
            this.btnMinimize.IconMarginLeft = 0;
            this.btnMinimize.IconMarginRight = 0;
            this.btnMinimize.IconRightVisible = true;
            this.btnMinimize.IconRightZoom = 0D;
            this.btnMinimize.IconVisible = true;
            this.btnMinimize.IconZoom = 40D;
            this.btnMinimize.IsTab = false;
            this.btnMinimize.Location = new System.Drawing.Point(1225, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnMinimize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btnMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMinimize.selected = false;
            this.btnMinimize.Size = new System.Drawing.Size(47, 44);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Textcolor = System.Drawing.Color.White;
            this.btnMinimize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.BorderRadius = 0;
            this.btnMaximize.ButtonText = "";
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmSlider.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.DisabledColor = System.Drawing.Color.Gray;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMaximize.Iconimage = global::WindowsFormsApp1.Properties.Resources.icons8_Up_Right_24px;
            this.btnMaximize.Iconimage_right = null;
            this.btnMaximize.Iconimage_right_Selected = null;
            this.btnMaximize.Iconimage_Selected = null;
            this.btnMaximize.IconMarginLeft = 0;
            this.btnMaximize.IconMarginRight = 0;
            this.btnMaximize.IconRightVisible = true;
            this.btnMaximize.IconRightZoom = 0D;
            this.btnMaximize.IconVisible = true;
            this.btnMaximize.IconZoom = 40D;
            this.btnMaximize.IsTab = false;
            this.btnMaximize.Location = new System.Drawing.Point(1272, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnMaximize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(146)))), ((int)(((byte)(243)))));
            this.btnMaximize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMaximize.selected = false;
            this.btnMaximize.Size = new System.Drawing.Size(47, 44);
            this.btnMaximize.TabIndex = 9;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaximize.Textcolor = System.Drawing.Color.White;
            this.btnMaximize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "X";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anmSlider.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(1319, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(143)))));
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(82)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(47, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.White;
            this.btnExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // anmTlpBuku
            // 
            this.anmTlpBuku.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.anmTlpBuku.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.anmTlpBuku.DefaultAnimation = animation3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usrMgmtStaffLand1);
            this.panel1.Controls.Add(this.usrMgmtAdminLand1);
            this.panel1.Controls.Add(this.ucBooks);
            this.panel1.Controls.Add(this.ucHome1);
            this.panel1.Controls.Add(this.ucPerpustakanLanding1);
            this.anmTlpBuku.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(332, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 724);
            this.panel1.TabIndex = 1;
            // 
            // usrMgmtStaffLand1
            // 
            this.anmSlider.SetDecoration(this.usrMgmtStaffLand1, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.usrMgmtStaffLand1, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.usrMgmtStaffLand1, BunifuAnimatorNS.DecorationType.None);
            this.usrMgmtStaffLand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrMgmtStaffLand1.Location = new System.Drawing.Point(0, 0);
            this.usrMgmtStaffLand1.Name = "usrMgmtStaffLand1";
            this.usrMgmtStaffLand1.Size = new System.Drawing.Size(1034, 724);
            this.usrMgmtStaffLand1.TabIndex = 4;
            this.usrMgmtStaffLand1.Load += new System.EventHandler(this.usrMgmtStaffLand1_Load);
            // 
            // usrMgmtAdminLand1
            // 
            this.anmSlider.SetDecoration(this.usrMgmtAdminLand1, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.usrMgmtAdminLand1, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.usrMgmtAdminLand1, BunifuAnimatorNS.DecorationType.None);
            this.usrMgmtAdminLand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrMgmtAdminLand1.Location = new System.Drawing.Point(0, 0);
            this.usrMgmtAdminLand1.Name = "usrMgmtAdminLand1";
            this.usrMgmtAdminLand1.Size = new System.Drawing.Size(1034, 724);
            this.usrMgmtAdminLand1.TabIndex = 3;
            this.usrMgmtAdminLand1.Load += new System.EventHandler(this.usrMgmtAdminLand1_Load);
            // 
            // ucBooks
            // 
            this.anmSlider.SetDecoration(this.ucBooks, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.ucBooks, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.ucBooks, BunifuAnimatorNS.DecorationType.None);
            this.ucBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBooks.Location = new System.Drawing.Point(0, 0);
            this.ucBooks.Name = "ucBooks";
            this.ucBooks.Size = new System.Drawing.Size(1034, 724);
            this.ucBooks.TabIndex = 5;
            // 
            // ucHome1
            // 
            this.anmSlider.SetDecoration(this.ucHome1, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.ucHome1, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.ucHome1, BunifuAnimatorNS.DecorationType.None);
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(1034, 724);
            this.ucHome1.TabIndex = 0;
            // 
            // ucPerpustakanLanding1
            // 
            this.ucPerpustakanLanding1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.anmSlider.SetDecoration(this.ucPerpustakanLanding1, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.ucPerpustakanLanding1, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.ucPerpustakanLanding1, BunifuAnimatorNS.DecorationType.None);
            this.ucPerpustakanLanding1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPerpustakanLanding1.Location = new System.Drawing.Point(0, 0);
            this.ucPerpustakanLanding1.Name = "ucPerpustakanLanding1";
            this.ucPerpustakanLanding1.Size = new System.Drawing.Size(1034, 724);
            this.ucPerpustakanLanding1.TabIndex = 2;
            // 
            // anmArrow
            // 
            this.anmArrow.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.anmArrow.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.anmArrow.DefaultAnimation = animation2;
            // 
            // anmSlider
            // 
            this.anmSlider.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.anmSlider.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.anmSlider.DefaultAnimation = animation1;
            this.anmSlider.MaxAnimationTime = 500;
            this.anmSlider.TimeStep = 0.01F;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.anmArrow.SetDecoration(this.lblUserLogin, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.lblUserLogin, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.lblUserLogin, BunifuAnimatorNS.DecorationType.None);
            this.lblUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.White;
            this.lblUserLogin.Location = new System.Drawing.Point(3, 0);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(326, 39);
            this.lblUserLogin.TabIndex = 1;
            this.lblUserLogin.Text = "userName_disini";
            this.lblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserLogin.Click += new System.EventHandler(this.lblUserLogin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblUserLogin, 0, 0);
            this.anmTlpBuku.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 191);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 39);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblUserPrivelege, 0, 0);
            this.anmTlpBuku.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.anmArrow.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.tableLayoutPanel2, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 233);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 39);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblUserPrivelege
            // 
            this.lblUserPrivelege.AutoSize = true;
            this.anmArrow.SetDecoration(this.lblUserPrivelege, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this.lblUserPrivelege, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this.lblUserPrivelege, BunifuAnimatorNS.DecorationType.None);
            this.lblUserPrivelege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserPrivelege.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPrivelege.ForeColor = System.Drawing.Color.White;
            this.lblUserPrivelege.Location = new System.Drawing.Point(3, 0);
            this.lblUserPrivelege.Name = "lblUserPrivelege";
            this.lblUserPrivelege.Size = new System.Drawing.Size(326, 39);
            this.lblUserPrivelege.TabIndex = 2;
            this.lblUserPrivelege.Text = "userName_disini";
            this.lblUserPrivelege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelAtas);
            this.anmArrow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.anmTlpBuku.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.anmSlider.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTYG)).EndInit();
            this.panelAtas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelAtas;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbout;
        private Bunifu.Framework.UI.BunifuFlatButton btnMgmntUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnPerpustakaan;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuku;
        private PictureBoxAbouAmmar.صورة_دائرة LogoTYG;
        private BunifuAnimatorNS.BunifuTransition anmTlpBuku;
        private System.Windows.Forms.Panel panel1;
        private ucHome ucHome1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMaximize;
        private Bunifu.Framework.UI.BunifuFlatButton btnMinimize;
        private BunifuAnimatorNS.BunifuTransition anmArrow;
        private Bunifu.Framework.UI.BunifuImageButton btnMenuSlider;
        private BunifuAnimatorNS.BunifuTransition anmSlider;
        private ucPerpustakanLanding ucPerpustakanLanding1;
        private usrMgmtStaffLand usrMgmtStaffLand1;
        private usrMgmtAdminLand usrMgmtAdminLand1;
        private UserControl1 ucBooks;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserPrivelege;
    }
}