namespace WindowsFormsApp1
{
    partial class frmTambahBuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTambahBuku));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbJudulBuku = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPengarangBuku = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPenerbitBuku = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbJmlBuku = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTambah = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambahkan Buku";
            // 
            // tbJudulBuku
            // 
            this.tbJudulBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbJudulBuku.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJudulBuku.ForeColor = System.Drawing.Color.White;
            this.tbJudulBuku.HintForeColor = System.Drawing.Color.Silver;
            this.tbJudulBuku.HintText = "Judul Buku";
            this.tbJudulBuku.isPassword = false;
            this.tbJudulBuku.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbJudulBuku.LineIdleColor = System.Drawing.Color.Gray;
            this.tbJudulBuku.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbJudulBuku.LineThickness = 5;
            this.tbJudulBuku.Location = new System.Drawing.Point(33, 101);
            this.tbJudulBuku.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbJudulBuku.Name = "tbJudulBuku";
            this.tbJudulBuku.Size = new System.Drawing.Size(465, 56);
            this.tbJudulBuku.TabIndex = 6;
            this.tbJudulBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPengarangBuku
            // 
            this.tbPengarangBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPengarangBuku.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPengarangBuku.ForeColor = System.Drawing.Color.White;
            this.tbPengarangBuku.HintForeColor = System.Drawing.Color.Silver;
            this.tbPengarangBuku.HintText = "Pengarang Buku";
            this.tbPengarangBuku.isPassword = false;
            this.tbPengarangBuku.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPengarangBuku.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPengarangBuku.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPengarangBuku.LineThickness = 5;
            this.tbPengarangBuku.Location = new System.Drawing.Point(33, 171);
            this.tbPengarangBuku.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbPengarangBuku.Name = "tbPengarangBuku";
            this.tbPengarangBuku.Size = new System.Drawing.Size(465, 56);
            this.tbPengarangBuku.TabIndex = 7;
            this.tbPengarangBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPenerbitBuku
            // 
            this.tbPenerbitBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPenerbitBuku.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPenerbitBuku.ForeColor = System.Drawing.Color.White;
            this.tbPenerbitBuku.HintForeColor = System.Drawing.Color.Silver;
            this.tbPenerbitBuku.HintText = "Penerbit Buku";
            this.tbPenerbitBuku.isPassword = false;
            this.tbPenerbitBuku.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbPenerbitBuku.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPenerbitBuku.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbPenerbitBuku.LineThickness = 5;
            this.tbPenerbitBuku.Location = new System.Drawing.Point(33, 241);
            this.tbPenerbitBuku.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbPenerbitBuku.Name = "tbPenerbitBuku";
            this.tbPenerbitBuku.Size = new System.Drawing.Size(465, 56);
            this.tbPenerbitBuku.TabIndex = 8;
            this.tbPenerbitBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbJmlBuku
            // 
            this.tbJmlBuku.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbJmlBuku.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJmlBuku.ForeColor = System.Drawing.Color.White;
            this.tbJmlBuku.HintForeColor = System.Drawing.Color.Silver;
            this.tbJmlBuku.HintText = "Jumlah Buku";
            this.tbJmlBuku.isPassword = false;
            this.tbJmlBuku.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbJmlBuku.LineIdleColor = System.Drawing.Color.Gray;
            this.tbJmlBuku.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbJmlBuku.LineThickness = 5;
            this.tbJmlBuku.Location = new System.Drawing.Point(33, 311);
            this.tbJmlBuku.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbJmlBuku.Name = "tbJmlBuku";
            this.tbJmlBuku.Size = new System.Drawing.Size(465, 56);
            this.tbJmlBuku.TabIndex = 9;
            this.tbJmlBuku.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Batalkan Proses";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(33, 400);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 53);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.ActiveBorderThickness = 1;
            this.btnTambah.ActiveCornerRadius = 20;
            this.btnTambah.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTambah.ActiveForecolor = System.Drawing.Color.White;
            this.btnTambah.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnTambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTambah.BackgroundImage")));
            this.btnTambah.ButtonText = "Tambahkan Buku";
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTambah.IdleBorderThickness = 1;
            this.btnTambah.IdleCornerRadius = 20;
            this.btnTambah.IdleFillColor = System.Drawing.Color.White;
            this.btnTambah.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTambah.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTambah.Location = new System.Drawing.Point(278, 400);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(220, 53);
            this.btnTambah.TabIndex = 11;
            this.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // frmTambahBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(531, 472);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbJmlBuku);
            this.Controls.Add(this.tbPenerbitBuku);
            this.Controls.Add(this.tbPengarangBuku);
            this.Controls.Add(this.tbJudulBuku);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmTambahBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTambahBuku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbJmlBuku;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPenerbitBuku;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPengarangBuku;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbJudulBuku;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTambah;
    }
}