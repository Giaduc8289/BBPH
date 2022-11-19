namespace GD.BBPH.APP.KHO
{
    partial class FRM_KIEMKESANPHAM
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
            this.label16 = new System.Windows.Forms.Label();
            this.txt_SOM = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.txt_SOLUONG = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.btn_XOADONG = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMDONG = new GD.BBPH.CONTROL.BUTTON();
            this.label6 = new GD.BBPH.CONTROL.LABEL();
            this.label8 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENSP = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MASP = new GD.BBPH.CONTROL.TEXTBOX();
            this.label5 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENKHO = new GD.BBPH.CONTROL.TEXTBOX();
            this.pne_CHITIET = new System.Windows.Forms.Panel();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.txt_NGAY = new System.Windows.Forms.MaskedTextBox();
            this.btn_Thoat = new GD.BBPH.CONTROL.BUTTON();
            this.btn_KHOIPHUC = new GD.BBPH.CONTROL.BUTTON();
            this.btn_LUULAI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_XOA = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMMOI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_SUA = new GD.BBPH.CONTROL.BUTTON();
            this.txt_MAKHO = new GD.BBPH.CONTROL.TEXTBOX();
            this.label22 = new GD.BBPH.CONTROL.LABEL();
            this.txt_SOKG = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.btn_SUADONG = new GD.BBPH.CONTROL.BUTTON();
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(472, 477), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(519, 477), true);
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
            this.uiPanel0.Size = new System.Drawing.Size(472, 477);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Danh sách";
            this.uiPanel0.Resize += new System.EventHandler(this.uiPanel0_Resize);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(466, 453);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(475, 3);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(519, 477);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Chi tiết";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.btn_SUADONG);
            this.uiPanel1Container.Controls.Add(this.txt_SOKG);
            this.uiPanel1Container.Controls.Add(this.label2);
            this.uiPanel1Container.Controls.Add(this.label16);
            this.uiPanel1Container.Controls.Add(this.txt_SOM);
            this.uiPanel1Container.Controls.Add(this.txt_SOLUONG);
            this.uiPanel1Container.Controls.Add(this.btn_XOADONG);
            this.uiPanel1Container.Controls.Add(this.btn_THEMDONG);
            this.uiPanel1Container.Controls.Add(this.label6);
            this.uiPanel1Container.Controls.Add(this.label8);
            this.uiPanel1Container.Controls.Add(this.txt_TENSP);
            this.uiPanel1Container.Controls.Add(this.txt_MASP);
            this.uiPanel1Container.Controls.Add(this.label5);
            this.uiPanel1Container.Controls.Add(this.txt_TENKHO);
            this.uiPanel1Container.Controls.Add(this.pne_CHITIET);
            this.uiPanel1Container.Controls.Add(this.label1);
            this.uiPanel1Container.Controls.Add(this.txt_NGAY);
            this.uiPanel1Container.Controls.Add(this.btn_Thoat);
            this.uiPanel1Container.Controls.Add(this.btn_KHOIPHUC);
            this.uiPanel1Container.Controls.Add(this.btn_LUULAI);
            this.uiPanel1Container.Controls.Add(this.btn_XOA);
            this.uiPanel1Container.Controls.Add(this.btn_THEMMOI);
            this.uiPanel1Container.Controls.Add(this.btn_SUA);
            this.uiPanel1Container.Controls.Add(this.txt_MAKHO);
            this.uiPanel1Container.Controls.Add(this.label22);
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(517, 453);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(10, 46);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(500, 2);
            this.label16.TabIndex = 260;
            // 
            // txt_SOM
            // 
            this.txt_SOM.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOM.BannerText = null;
            this.txt_SOM.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SOM.Giatrithapphan = 2;
            this.txt_SOM.IsSoNguyen = false;
            this.txt_SOM.Location = new System.Drawing.Point(243, 95);
            this.txt_SOM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_SOM.Name = "txt_SOM";
            this.txt_SOM.Regular_Expression = "";
            this.txt_SOM.Size = new System.Drawing.Size(81, 20);
            this.txt_SOM.TabIndex = 6;
            this.txt_SOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SOLUONG
            // 
            this.txt_SOLUONG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOLUONG.BannerText = null;
            this.txt_SOLUONG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SOLUONG.Giatrithapphan = 2;
            this.txt_SOLUONG.IsSoNguyen = false;
            this.txt_SOLUONG.Location = new System.Drawing.Point(88, 93);
            this.txt_SOLUONG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_SOLUONG.Name = "txt_SOLUONG";
            this.txt_SOLUONG.Regular_Expression = "";
            this.txt_SOLUONG.Size = new System.Drawing.Size(81, 20);
            this.txt_SOLUONG.TabIndex = 5;
            this.txt_SOLUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_XOADONG
            // 
            this.btn_XOADONG.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_XOADONG.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_XOADONG.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_XOADONG.Enabled = false;
            this.btn_XOADONG.Location = new System.Drawing.Point(120, 130);
            this.btn_XOADONG.Name = "btn_XOADONG";
            this.btn_XOADONG.Size = new System.Drawing.Size(95, 23);
            this.btn_XOADONG.TabIndex = 8;
            this.btn_XOADONG.Text = "Xóa dòng";
            this.btn_XOADONG.UseVisualStyleBackColor = true;
            this.btn_XOADONG.Click += new System.EventHandler(this.btn_XOADONG_Click);
            // 
            // btn_THEMDONG
            // 
            this.btn_THEMDONG.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THEMDONG.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THEMDONG.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THEMDONG.Enabled = false;
            this.btn_THEMDONG.Location = new System.Drawing.Point(19, 130);
            this.btn_THEMDONG.Name = "btn_THEMDONG";
            this.btn_THEMDONG.Size = new System.Drawing.Size(95, 23);
            this.btn_THEMDONG.TabIndex = 7;
            this.btn_THEMDONG.Text = "Thêm dòng";
            this.btn_THEMDONG.UseVisualStyleBackColor = true;
            this.btn_THEMDONG.Click += new System.EventHandler(this.btn_THEMDONG_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số mét";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 201;
            this.label8.Text = "Số lượng";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // txt_TENSP
            // 
            this.txt_TENSP.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENSP.BannerText = null;
            this.txt_TENSP.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENSP.FormNametoShow = "";
            this.txt_TENSP.Is_DateTime = false;
            this.txt_TENSP.IsShowForm = false;
            this.txt_TENSP.Location = new System.Drawing.Point(175, 63);
            this.txt_TENSP.Name = "txt_TENSP";
            this.txt_TENSP.ReadOnly = true;
            this.txt_TENSP.Regular_Expression = null;
            this.txt_TENSP.Size = new System.Drawing.Size(218, 20);
            this.txt_TENSP.TabIndex = 4;
            this.txt_TENSP.TabStop = false;
            // 
            // txt_MASP
            // 
            this.txt_MASP.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MASP.BannerText = null;
            this.txt_MASP.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MASP.FormNametoShow = "";
            this.txt_MASP.Is_DateTime = false;
            this.txt_MASP.IsShowForm = false;
            this.txt_MASP.Location = new System.Drawing.Point(88, 63);
            this.txt_MASP.Name = "txt_MASP";
            this.txt_MASP.Regular_Expression = null;
            this.txt_MASP.Size = new System.Drawing.Size(81, 20);
            this.txt_MASP.TabIndex = 3;
            this.txt_MASP.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MASP_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 196;
            this.label5.Text = "Sản phẩm";
            // 
            // txt_TENKHO
            // 
            this.txt_TENKHO.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKHO.BannerText = null;
            this.txt_TENKHO.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENKHO.FormNametoShow = "";
            this.txt_TENKHO.Is_DateTime = false;
            this.txt_TENKHO.IsShowForm = false;
            this.txt_TENKHO.Location = new System.Drawing.Point(398, 13);
            this.txt_TENKHO.Name = "txt_TENKHO";
            this.txt_TENKHO.ReadOnly = true;
            this.txt_TENKHO.Regular_Expression = null;
            this.txt_TENKHO.Size = new System.Drawing.Size(218, 20);
            this.txt_TENKHO.TabIndex = 2;
            this.txt_TENKHO.TabStop = false;
            // 
            // pne_CHITIET
            // 
            this.pne_CHITIET.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pne_CHITIET.Location = new System.Drawing.Point(13, 168);
            this.pne_CHITIET.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pne_CHITIET.Name = "pne_CHITIET";
            this.pne_CHITIET.Size = new System.Drawing.Size(498, 214);
            this.pne_CHITIET.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 160;
            this.label1.Text = "Ngày kiểm kê";
            // 
            // txt_NGAY
            // 
            this.txt_NGAY.Location = new System.Drawing.Point(88, 13);
            this.txt_NGAY.Mask = "00/00/0000";
            this.txt_NGAY.Name = "txt_NGAY";
            this.txt_NGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NGAY.Size = new System.Drawing.Size(81, 20);
            this.txt_NGAY.TabIndex = 0;
            this.txt_NGAY.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Thoat.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.Location = new System.Drawing.Point(426, 405);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 15;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_KHOIPHUC
            // 
            this.btn_KHOIPHUC.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_KHOIPHUC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_KHOIPHUC.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_KHOIPHUC.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_KHOIPHUC.Location = new System.Drawing.Point(179, 405);
            this.btn_KHOIPHUC.Name = "btn_KHOIPHUC";
            this.btn_KHOIPHUC.Size = new System.Drawing.Size(75, 23);
            this.btn_KHOIPHUC.TabIndex = 12;
            this.btn_KHOIPHUC.Text = "&Khôi phục";
            this.btn_KHOIPHUC.UseVisualStyleBackColor = true;
            this.btn_KHOIPHUC.Click += new System.EventHandler(this.btn_KHOIPHUC_Click);
            // 
            // btn_LUULAI
            // 
            this.btn_LUULAI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_LUULAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_LUULAI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_LUULAI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_LUULAI.Location = new System.Drawing.Point(19, 405);
            this.btn_LUULAI.Name = "btn_LUULAI";
            this.btn_LUULAI.Size = new System.Drawing.Size(75, 23);
            this.btn_LUULAI.TabIndex = 10;
            this.btn_LUULAI.Text = "&Lưu lại";
            this.btn_LUULAI.UseVisualStyleBackColor = true;
            this.btn_LUULAI.Click += new System.EventHandler(this.btn_LUULAI_Click);
            // 
            // btn_XOA
            // 
            this.btn_XOA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_XOA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XOA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_XOA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_XOA.Location = new System.Drawing.Point(98, 405);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 23);
            this.btn_XOA.TabIndex = 11;
            this.btn_XOA.Text = "&Xóa";
            this.btn_XOA.UseVisualStyleBackColor = true;
            this.btn_XOA.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // btn_THEMMOI
            // 
            this.btn_THEMMOI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THEMMOI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_THEMMOI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THEMMOI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THEMMOI.Location = new System.Drawing.Point(344, 405);
            this.btn_THEMMOI.Name = "btn_THEMMOI";
            this.btn_THEMMOI.Size = new System.Drawing.Size(75, 23);
            this.btn_THEMMOI.TabIndex = 14;
            this.btn_THEMMOI.Text = "Thêm &mới";
            this.btn_THEMMOI.UseVisualStyleBackColor = true;
            this.btn_THEMMOI.Click += new System.EventHandler(this.btn_THEMMOI_Click);
            // 
            // btn_SUA
            // 
            this.btn_SUA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_SUA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SUA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_SUA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_SUA.Location = new System.Drawing.Point(263, 405);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 23);
            this.btn_SUA.TabIndex = 13;
            this.btn_SUA.Text = "&Sửa";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // txt_MAKHO
            // 
            this.txt_MAKHO.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKHO.BannerText = null;
            this.txt_MAKHO.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAKHO.FormNametoShow = "";
            this.txt_MAKHO.Is_DateTime = false;
            this.txt_MAKHO.IsShowForm = false;
            this.txt_MAKHO.Location = new System.Drawing.Point(311, 13);
            this.txt_MAKHO.Name = "txt_MAKHO";
            this.txt_MAKHO.Regular_Expression = null;
            this.txt_MAKHO.Size = new System.Drawing.Size(81, 20);
            this.txt_MAKHO.TabIndex = 1;
            this.txt_MAKHO.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAKHO_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(283, 15);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 119;
            this.label22.Text = "Kho";
            // 
            // txt_SOKG
            // 
            this.txt_SOKG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOKG.BannerText = null;
            this.txt_SOKG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SOKG.Giatrithapphan = 2;
            this.txt_SOKG.IsSoNguyen = false;
            this.txt_SOKG.Location = new System.Drawing.Point(398, 97);
            this.txt_SOKG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_SOKG.Name = "txt_SOKG";
            this.txt_SOKG.Regular_Expression = "";
            this.txt_SOKG.Size = new System.Drawing.Size(81, 20);
            this.txt_SOKG.TabIndex = 8;
            this.txt_SOKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Kg";
            // 
            // btn_SUADONG
            // 
            this.btn_SUADONG.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_SUADONG.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_SUADONG.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_SUADONG.Enabled = false;
            this.btn_SUADONG.Location = new System.Drawing.Point(243, 130);
            this.btn_SUADONG.Name = "btn_SUADONG";
            this.btn_SUADONG.Size = new System.Drawing.Size(95, 23);
            this.btn_SUADONG.TabIndex = 274;
            this.btn_SUADONG.Text = "Sửa dòng";
            this.btn_SUADONG.UseVisualStyleBackColor = true;
            this.btn_SUADONG.Click += new System.EventHandler(this.btn_SUADONG_Click);
            // 
            // FRM_KIEMKESANPHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 483);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRM_KIEMKESANPHAM";
            this.Text = "DANH MỤC CHƯƠNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_KIEMKESANPHAM_FormClosing);
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
        private CONTROL.TEXTBOX txt_MAKHO;
        private CONTROL.LABEL label22;
        private CONTROL.LABEL label1;
        private System.Windows.Forms.MaskedTextBox txt_NGAY;
        private System.Windows.Forms.Panel pne_CHITIET;
        private CONTROL.TEXTBOX txt_TENKHO;
        private CONTROL.LABEL label6;
        private CONTROL.LABEL label8;
        private CONTROL.TEXTBOX txt_TENSP;
        private CONTROL.TEXTBOX txt_MASP;
        private CONTROL.LABEL label5;
        private CONTROL.BUTTON btn_XOADONG;
        private CONTROL.BUTTON btn_THEMDONG;
        private CONTROL.TEXTBOXNUMBER txt_SOM;
        private CONTROL.TEXTBOXNUMBER txt_SOLUONG;
        private System.Windows.Forms.Label label16;
        private CONTROL.TEXTBOXNUMBER txt_SOKG;
        private CONTROL.LABEL label2;
        private CONTROL.BUTTON btn_SUADONG;
    }
}