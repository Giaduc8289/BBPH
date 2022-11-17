namespace GD.BBPH.APP.BANHANG
{
    partial class FRM_HANGTRALAI
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
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanel1 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel1Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.txt_SOLUONGTRA = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.label8 = new GD.BBPH.CONTROL.LABEL();
            this.txt_NGAYTRA = new System.Windows.Forms.MaskedTextBox();
            this.txt_NGUYENNHAN = new GD.BBPH.CONTROL.TEXTBOX();
            this.label7 = new GD.BBPH.CONTROL.LABEL();
            this.label6 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MASANPHAM = new GD.BBPH.CONTROL.TEXTBOX();
            this.label4 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENSANPHAM = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_TENKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MAKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.btn_Thoat = new GD.BBPH.CONTROL.BUTTON();
            this.btn_KHOIPHUC = new GD.BBPH.CONTROL.BUTTON();
            this.btn_LUULAI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_XOA = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMMOI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_SUA = new GD.BBPH.CONTROL.BUTTON();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel1Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            this.uiPanel1.Id = new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad");
            this.uiPanelManager1.Panels.Add(this.uiPanel1);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(785, 559), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(590, 559), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(785, 559);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Danh sách";
            this.uiPanel0.Resize += new System.EventHandler(this.uiPanel0_Resize);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(779, 535);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(788, 3);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(590, 559);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Chi tiết";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.txt_SOLUONGTRA);
            this.uiPanel1Container.Controls.Add(this.label8);
            this.uiPanel1Container.Controls.Add(this.txt_NGAYTRA);
            this.uiPanel1Container.Controls.Add(this.txt_NGUYENNHAN);
            this.uiPanel1Container.Controls.Add(this.label7);
            this.uiPanel1Container.Controls.Add(this.label6);
            this.uiPanel1Container.Controls.Add(this.txt_MASANPHAM);
            this.uiPanel1Container.Controls.Add(this.label4);
            this.uiPanel1Container.Controls.Add(this.txt_TENSANPHAM);
            this.uiPanel1Container.Controls.Add(this.txt_TENKHACH);
            this.uiPanel1Container.Controls.Add(this.txt_MAKHACH);
            this.uiPanel1Container.Controls.Add(this.label3);
            this.uiPanel1Container.Controls.Add(this.btn_Thoat);
            this.uiPanel1Container.Controls.Add(this.btn_KHOIPHUC);
            this.uiPanel1Container.Controls.Add(this.btn_LUULAI);
            this.uiPanel1Container.Controls.Add(this.btn_XOA);
            this.uiPanel1Container.Controls.Add(this.btn_THEMMOI);
            this.uiPanel1Container.Controls.Add(this.btn_SUA);
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(588, 535);
            this.uiPanel1Container.TabIndex = 0;
            this.uiPanel1Container.Click += new System.EventHandler(this.uiPanel1Container_Click);
            // 
            // txt_SOLUONGTRA
            // 
            this.txt_SOLUONGTRA.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOLUONGTRA.BannerText = null;
            this.txt_SOLUONGTRA.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SOLUONGTRA.Giatrithapphan = 2;
            this.txt_SOLUONGTRA.IsSoNguyen = false;
            this.txt_SOLUONGTRA.Location = new System.Drawing.Point(120, 127);
            this.txt_SOLUONGTRA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_SOLUONGTRA.Name = "txt_SOLUONGTRA";
            this.txt_SOLUONGTRA.Regular_Expression = "";
            this.txt_SOLUONGTRA.Size = new System.Drawing.Size(138, 20);
            this.txt_SOLUONGTRA.TabIndex = 5;
            this.txt_SOLUONGTRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày trả";
            // 
            // txt_NGAYTRA
            // 
            this.txt_NGAYTRA.Location = new System.Drawing.Point(119, 49);
            this.txt_NGAYTRA.Mask = "  00  / 00 / 0000";
            this.txt_NGAYTRA.Name = "txt_NGAYTRA";
            this.txt_NGAYTRA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NGAYTRA.Size = new System.Drawing.Size(138, 20);
            this.txt_NGAYTRA.TabIndex = 0;
            this.txt_NGAYTRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NGAYTRA.ValidatingType = typeof(System.DateTime);
            // 
            // txt_NGUYENNHAN
            // 
            this.txt_NGUYENNHAN.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NGUYENNHAN.BannerText = null;
            this.txt_NGUYENNHAN.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_NGUYENNHAN.FormNametoShow = "";
            this.txt_NGUYENNHAN.Is_DateTime = false;
            this.txt_NGUYENNHAN.IsShowForm = false;
            this.txt_NGUYENNHAN.Location = new System.Drawing.Point(120, 179);
            this.txt_NGUYENNHAN.Multiline = true;
            this.txt_NGUYENNHAN.Name = "txt_NGUYENNHAN";
            this.txt_NGUYENNHAN.Regular_Expression = null;
            this.txt_NGUYENNHAN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_NGUYENNHAN.Size = new System.Drawing.Size(181, 95);
            this.txt_NGUYENNHAN.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 175;
            this.label7.Text = "Lý do trả lại";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 171;
            this.label6.Text = "Số lượng trả lại";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_MASANPHAM
            // 
            this.txt_MASANPHAM.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MASANPHAM.BannerText = null;
            this.txt_MASANPHAM.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MASANPHAM.FormNametoShow = "";
            this.txt_MASANPHAM.Is_DateTime = false;
            this.txt_MASANPHAM.IsShowForm = false;
            this.txt_MASANPHAM.Location = new System.Drawing.Point(119, 101);
            this.txt_MASANPHAM.Name = "txt_MASANPHAM";
            this.txt_MASANPHAM.Regular_Expression = null;
            this.txt_MASANPHAM.Size = new System.Drawing.Size(138, 20);
            this.txt_MASANPHAM.TabIndex = 3;
            this.txt_MASANPHAM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MAHANG_KeyDown);
            this.txt_MASANPHAM.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Masp_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 169;
            this.label4.Text = "Sản phẩm";
            // 
            // txt_TENSANPHAM
            // 
            this.txt_TENSANPHAM.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENSANPHAM.BannerText = null;
            this.txt_TENSANPHAM.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENSANPHAM.FormNametoShow = "";
            this.txt_TENSANPHAM.Is_DateTime = false;
            this.txt_TENSANPHAM.IsShowForm = false;
            this.txt_TENSANPHAM.Location = new System.Drawing.Point(287, 101);
            this.txt_TENSANPHAM.Name = "txt_TENSANPHAM";
            this.txt_TENSANPHAM.ReadOnly = true;
            this.txt_TENSANPHAM.Regular_Expression = null;
            this.txt_TENSANPHAM.Size = new System.Drawing.Size(248, 20);
            this.txt_TENSANPHAM.TabIndex = 4;
            this.txt_TENSANPHAM.TabStop = false;
            this.txt_TENSANPHAM.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Masp_Validating);
            // 
            // txt_TENKHACH
            // 
            this.txt_TENKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKHACH.BannerText = null;
            this.txt_TENKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENKHACH.FormNametoShow = "";
            this.txt_TENKHACH.Is_DateTime = false;
            this.txt_TENKHACH.IsShowForm = false;
            this.txt_TENKHACH.Location = new System.Drawing.Point(287, 75);
            this.txt_TENKHACH.Name = "txt_TENKHACH";
            this.txt_TENKHACH.ReadOnly = true;
            this.txt_TENKHACH.Regular_Expression = null;
            this.txt_TENKHACH.Size = new System.Drawing.Size(247, 20);
            this.txt_TENKHACH.TabIndex = 2;
            this.txt_TENKHACH.TabStop = false;
            this.txt_TENKHACH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Makhach_Validating);
            // 
            // txt_MAKHACH
            // 
            this.txt_MAKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKHACH.BannerText = null;
            this.txt_MAKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAKHACH.FormNametoShow = "";
            this.txt_MAKHACH.Is_DateTime = false;
            this.txt_MAKHACH.IsShowForm = false;
            this.txt_MAKHACH.Location = new System.Drawing.Point(120, 75);
            this.txt_MAKHACH.Name = "txt_MAKHACH";
            this.txt_MAKHACH.Regular_Expression = null;
            this.txt_MAKHACH.Size = new System.Drawing.Size(138, 20);
            this.txt_MAKHACH.TabIndex = 1;
            this.txt_MAKHACH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MAKHACH_KeyDown);
            this.txt_MAKHACH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Makhach_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 165;
            this.label3.Text = "Khách hàng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.Location = new System.Drawing.Point(427, 337);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 12;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_KHOIPHUC
            // 
            this.btn_KHOIPHUC.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_KHOIPHUC.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_KHOIPHUC.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_KHOIPHUC.Location = new System.Drawing.Point(183, 337);
            this.btn_KHOIPHUC.Name = "btn_KHOIPHUC";
            this.btn_KHOIPHUC.Size = new System.Drawing.Size(75, 23);
            this.btn_KHOIPHUC.TabIndex = 9;
            this.btn_KHOIPHUC.Text = "&Khôi phục";
            this.btn_KHOIPHUC.UseVisualStyleBackColor = true;
            this.btn_KHOIPHUC.Click += new System.EventHandler(this.btn_KHOIPHUC_Click);
            // 
            // btn_LUULAI
            // 
            this.btn_LUULAI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_LUULAI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_LUULAI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_LUULAI.Location = new System.Drawing.Point(20, 337);
            this.btn_LUULAI.Name = "btn_LUULAI";
            this.btn_LUULAI.Size = new System.Drawing.Size(75, 23);
            this.btn_LUULAI.TabIndex = 7;
            this.btn_LUULAI.Text = "&Lưu lại";
            this.btn_LUULAI.UseVisualStyleBackColor = true;
            this.btn_LUULAI.Click += new System.EventHandler(this.btn_LUULAI_Click);
            // 
            // btn_XOA
            // 
            this.btn_XOA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_XOA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_XOA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_XOA.Location = new System.Drawing.Point(99, 337);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 23);
            this.btn_XOA.TabIndex = 8;
            this.btn_XOA.Text = "&Xóa";
            this.btn_XOA.UseVisualStyleBackColor = true;
            this.btn_XOA.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // btn_THEMMOI
            // 
            this.btn_THEMMOI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THEMMOI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THEMMOI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THEMMOI.Location = new System.Drawing.Point(345, 337);
            this.btn_THEMMOI.Name = "btn_THEMMOI";
            this.btn_THEMMOI.Size = new System.Drawing.Size(75, 23);
            this.btn_THEMMOI.TabIndex = 11;
            this.btn_THEMMOI.Text = "Thêm &mới";
            this.btn_THEMMOI.UseVisualStyleBackColor = true;
            this.btn_THEMMOI.Click += new System.EventHandler(this.btn_THEMMOI_Click);
            // 
            // btn_SUA
            // 
            this.btn_SUA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_SUA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_SUA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_SUA.Location = new System.Drawing.Point(264, 337);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 23);
            this.btn_SUA.TabIndex = 10;
            this.btn_SUA.Text = "&Sửa";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // FRM_HANGTRALAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 565);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_HANGTRALAI";
            this.Text = "DANH MỤC CHƯƠNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_HANGTRALAI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1Container.ResumeLayout(false);
            this.uiPanel1Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel1;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel1Container;
        private GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC;
        private GD.BBPH.CONTROL.BUTTON btn_LUULAI;
        private GD.BBPH.CONTROL.BUTTON btn_XOA;
        private GD.BBPH.CONTROL.BUTTON btn_THEMMOI;
        private GD.BBPH.CONTROL.BUTTON btn_SUA;
        private GD.BBPH.CONTROL.BUTTON btn_Thoat;
        private CONTROL.TEXTBOX txt_TENKHACH;
        private CONTROL.TEXTBOX txt_MAKHACH;
        private CONTROL.LABEL label3;
        private CONTROL.TEXTBOX txt_MASANPHAM;
        private CONTROL.LABEL label4;
        private CONTROL.TEXTBOX txt_TENSANPHAM;
        private CONTROL.LABEL label6;
        private CONTROL.LABEL label7;
        private CONTROL.TEXTBOX txt_NGUYENNHAN;
        private CONTROL.LABEL label8;
        private System.Windows.Forms.MaskedTextBox txt_NGAYTRA;
        private CONTROL.TEXTBOXNUMBER txt_SOLUONGTRA;
    }
}