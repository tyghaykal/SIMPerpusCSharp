namespace WindowsFormsApp1
{
    partial class ucPerpustakanLanding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPerpustakanLanding));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDPeminjaman = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKembaliBuku = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDBuku = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbIDMember = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPinjamBuku = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 724);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbIDPeminjaman, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(47, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27132F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.77519F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07752F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16279F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.83721F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(442, 645);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Quicksand", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(25, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengembalian Buku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIDPeminjaman
            // 
            this.tbIDPeminjaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDPeminjaman.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbIDPeminjaman.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDPeminjaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIDPeminjaman.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbIDPeminjaman.HintText = "ID Peminjaman";
            this.tbIDPeminjaman.isPassword = false;
            this.tbIDPeminjaman.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbIDPeminjaman.LineIdleColor = System.Drawing.Color.Gray;
            this.tbIDPeminjaman.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbIDPeminjaman.LineThickness = 4;
            this.tbIDPeminjaman.Location = new System.Drawing.Point(28, 256);
            this.tbIDPeminjaman.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbIDPeminjaman.Name = "tbIDPeminjaman";
            this.tbIDPeminjaman.Size = new System.Drawing.Size(385, 47);
            this.tbIDPeminjaman.TabIndex = 1;
            this.tbIDPeminjaman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIDPeminjaman.OnValueChanged += new System.EventHandler(this.tbIDPeminjaman_OnValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnReset1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnKembaliBuku, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(25, 377);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 66);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnReset1
            // 
            this.btnReset1.ActiveBorderThickness = 1;
            this.btnReset1.ActiveCornerRadius = 20;
            this.btnReset1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReset1.ActiveForecolor = System.Drawing.Color.White;
            this.btnReset1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnReset1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset1.BackgroundImage")));
            this.btnReset1.ButtonText = "Reset";
            this.btnReset1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReset1.IdleBorderThickness = 1;
            this.btnReset1.IdleCornerRadius = 20;
            this.btnReset1.IdleFillColor = System.Drawing.Color.White;
            this.btnReset1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReset1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset1.Location = new System.Drawing.Point(5, 5);
            this.btnReset1.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(185, 56);
            this.btnReset1.TabIndex = 0;
            this.btnReset1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click_1);
            // 
            // btnKembaliBuku
            // 
            this.btnKembaliBuku.ActiveBorderThickness = 1;
            this.btnKembaliBuku.ActiveCornerRadius = 20;
            this.btnKembaliBuku.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKembaliBuku.ActiveForecolor = System.Drawing.Color.White;
            this.btnKembaliBuku.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKembaliBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnKembaliBuku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKembaliBuku.BackgroundImage")));
            this.btnKembaliBuku.ButtonText = "Kembalikan Buku";
            this.btnKembaliBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembaliBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKembaliBuku.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembaliBuku.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKembaliBuku.IdleBorderThickness = 1;
            this.btnKembaliBuku.IdleCornerRadius = 20;
            this.btnKembaliBuku.IdleFillColor = System.Drawing.Color.White;
            this.btnKembaliBuku.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKembaliBuku.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKembaliBuku.Location = new System.Drawing.Point(200, 5);
            this.btnKembaliBuku.Margin = new System.Windows.Forms.Padding(5);
            this.btnKembaliBuku.Name = "btnKembaliBuku";
            this.btnKembaliBuku.Size = new System.Drawing.Size(186, 56);
            this.btnKembaliBuku.TabIndex = 1;
            this.btnKembaliBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbIDBuku, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbIDMember, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(539, 39);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.11628F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.62016F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.23256F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00775F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.14729F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.923077F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(442, 645);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Quicksand", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(25, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peminjaman Buku";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIDBuku
            // 
            this.tbIDBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDBuku.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbIDBuku.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDBuku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbIDBuku.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbIDBuku.HintText = "ID Buku";
            this.tbIDBuku.isPassword = false;
            this.tbIDBuku.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbIDBuku.LineIdleColor = System.Drawing.Color.Gray;
            this.tbIDBuku.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbIDBuku.LineThickness = 4;
            this.tbIDBuku.Location = new System.Drawing.Point(28, 254);
            this.tbIDBuku.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbIDBuku.Name = "tbIDBuku";
            this.tbIDBuku.Size = new System.Drawing.Size(385, 47);
            this.tbIDBuku.TabIndex = 1;
            this.tbIDBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIDMember
            // 
            this.tbIDMember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbIDMember.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbIDMember.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tbIDMember.HintText = "ID Member";
            this.tbIDMember.isPassword = false;
            this.tbIDMember.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbIDMember.LineIdleColor = System.Drawing.Color.Gray;
            this.tbIDMember.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbIDMember.LineThickness = 4;
            this.tbIDMember.Location = new System.Drawing.Point(28, 320);
            this.tbIDMember.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbIDMember.Name = "tbIDMember";
            this.tbIDMember.Size = new System.Drawing.Size(385, 47);
            this.tbIDMember.TabIndex = 2;
            this.tbIDMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnReset2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPinjamBuku, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(25, 376);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(391, 65);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // btnReset2
            // 
            this.btnReset2.ActiveBorderThickness = 1;
            this.btnReset2.ActiveCornerRadius = 20;
            this.btnReset2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReset2.ActiveForecolor = System.Drawing.Color.White;
            this.btnReset2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnReset2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset2.BackgroundImage")));
            this.btnReset2.ButtonText = "Reset";
            this.btnReset2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReset2.IdleBorderThickness = 1;
            this.btnReset2.IdleCornerRadius = 20;
            this.btnReset2.IdleFillColor = System.Drawing.Color.White;
            this.btnReset2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReset2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset2.Location = new System.Drawing.Point(5, 5);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(185, 55);
            this.btnReset2.TabIndex = 0;
            this.btnReset2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click_1);
            // 
            // btnPinjamBuku
            // 
            this.btnPinjamBuku.ActiveBorderThickness = 1;
            this.btnPinjamBuku.ActiveCornerRadius = 20;
            this.btnPinjamBuku.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPinjamBuku.ActiveForecolor = System.Drawing.Color.White;
            this.btnPinjamBuku.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPinjamBuku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btnPinjamBuku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPinjamBuku.BackgroundImage")));
            this.btnPinjamBuku.ButtonText = "Pinjam Buku";
            this.btnPinjamBuku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPinjamBuku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPinjamBuku.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPinjamBuku.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPinjamBuku.IdleBorderThickness = 1;
            this.btnPinjamBuku.IdleCornerRadius = 20;
            this.btnPinjamBuku.IdleFillColor = System.Drawing.Color.White;
            this.btnPinjamBuku.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPinjamBuku.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPinjamBuku.Location = new System.Drawing.Point(200, 5);
            this.btnPinjamBuku.Margin = new System.Windows.Forms.Padding(5);
            this.btnPinjamBuku.Name = "btnPinjamBuku";
            this.btnPinjamBuku.Size = new System.Drawing.Size(186, 55);
            this.btnPinjamBuku.TabIndex = 1;
            this.btnPinjamBuku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucPerpustakanLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucPerpustakanLanding";
            this.Size = new System.Drawing.Size(1032, 724);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbIDPeminjaman;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKembaliBuku;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbIDBuku;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbIDMember;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPinjamBuku;
    }
}
