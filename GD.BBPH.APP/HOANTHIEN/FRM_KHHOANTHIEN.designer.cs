namespace GD.BBPH.APP.HOANTHIEN
{
    partial class FRM_KHHOANTHIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_KHHOANTHIEN));
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanel1 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel1Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.txt_SOTUICONLAI = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.label6 = new GD.BBPH.CONTROL.LABEL();
            this.txt_SOTUIDAHOANTHIEN = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.label7 = new GD.BBPH.CONTROL.LABEL();
            this.txt_NGAYGIAO = new System.Windows.Forms.MaskedTextBox();
            this.txt_TENKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MADONHANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.label4 = new GD.BBPH.CONTROL.LABEL();
            this.txt_SOLUONG = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.txt_SLDUKIEN = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.pne_CHITIET = new System.Windows.Forms.Panel();
            this.label8 = new GD.BBPH.CONTROL.LABEL();
            this.btn_Thoat = new GD.BBPH.CONTROL.BUTTON();
            this.btn_KHOIPHUC = new GD.BBPH.CONTROL.BUTTON();
            this.btn_LUULAI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_XOA = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMMOI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_SUA = new GD.BBPH.CONTROL.BUTTON();
            this.txt_TENSP = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MASP = new GD.BBPH.CONTROL.TEXTBOX();
            this.label22 = new GD.BBPH.CONTROL.LABEL();
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(722, 559), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(754, 559), true);
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
            this.uiPanel0.Size = new System.Drawing.Size(722, 559);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Danh sách";
            this.uiPanel0.Resize += new System.EventHandler(this.uiPanel0_Resize);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(716, 535);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(725, 3);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(754, 559);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Chi tiết";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.txt_SOTUICONLAI);
            this.uiPanel1Container.Controls.Add(this.label6);
            this.uiPanel1Container.Controls.Add(this.txt_SOTUIDAHOANTHIEN);
            this.uiPanel1Container.Controls.Add(this.label7);
            this.uiPanel1Container.Controls.Add(this.txt_NGAYGIAO);
            this.uiPanel1Container.Controls.Add(this.txt_TENKHACH);
            this.uiPanel1Container.Controls.Add(this.label3);
            this.uiPanel1Container.Controls.Add(this.txt_MADONHANG);
            this.uiPanel1Container.Controls.Add(this.label4);
            this.uiPanel1Container.Controls.Add(this.txt_SOLUONG);
            this.uiPanel1Container.Controls.Add(this.txt_SLDUKIEN);
            this.uiPanel1Container.Controls.Add(this.label1);
            this.uiPanel1Container.Controls.Add(this.label2);
            this.uiPanel1Container.Controls.Add(this.pne_CHITIET);
            this.uiPanel1Container.Controls.Add(this.label8);
            this.uiPanel1Container.Controls.Add(this.btn_Thoat);
            this.uiPanel1Container.Controls.Add(this.btn_KHOIPHUC);
            this.uiPanel1Container.Controls.Add(this.btn_LUULAI);
            this.uiPanel1Container.Controls.Add(this.btn_XOA);
            this.uiPanel1Container.Controls.Add(this.btn_THEMMOI);
            this.uiPanel1Container.Controls.Add(this.btn_SUA);
            this.uiPanel1Container.Controls.Add(this.txt_TENSP);
            this.uiPanel1Container.Controls.Add(this.txt_MASP);
            this.uiPanel1Container.Controls.Add(this.label22);
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(752, 535);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // txt_SOTUICONLAI
            // 
            this.txt_SOTUICONLAI.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOTUICONLAI.BannerText = null;
            this.txt_SOTUICONLAI.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SOTUICONLAI.Giatrithapphan = 0;
            this.txt_SOTUICONLAI.IsSoNguyen = false;
            this.txt_SOTUICONLAI.Location = new System.Drawing.Point(349, 159);
            this.txt_SOTUICONLAI.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SOTUICONLAI.Name = "txt_SOTUICONLAI";
            this.txt_SOTUICONLAI.ReadOnly = true;
            this.txt_SOTUICONLAI.Regular_Expression = "";
            this.txt_SOTUICONLAI.Size = new System.Drawing.Size(138, 20);
            this.txt_SOTUICONLAI.TabIndex = 189;
            this.txt_SOTUICONLAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 190;
            this.label6.Text = "Số túi còn lại";
            // 
            // txt_SOTUIDAHOANTHIEN
            // 
            this.txt_SOTUIDAHOANTHIEN.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOTUIDAHOANTHIEN.BannerText = null;
            this.txt_SOTUIDAHOANTHIEN.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SOTUIDAHOANTHIEN.Giatrithapphan = 0;
            this.txt_SOTUIDAHOANTHIEN.IsSoNguyen = false;
            this.txt_SOTUIDAHOANTHIEN.Location = new System.Drawing.Point(107, 159);
            this.txt_SOTUIDAHOANTHIEN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SOTUIDAHOANTHIEN.Name = "txt_SOTUIDAHOANTHIEN";
            this.txt_SOTUIDAHOANTHIEN.ReadOnly = true;
            this.txt_SOTUIDAHOANTHIEN.Regular_Expression = "";
            this.txt_SOTUIDAHOANTHIEN.Size = new System.Drawing.Size(138, 20);
            this.txt_SOTUIDAHOANTHIEN.TabIndex = 191;
            this.txt_SOTUIDAHOANTHIEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 192;
            this.label7.Text = "Số túi đã hoàn thiện";
            // 
            // txt_NGAYGIAO
            // 
            this.txt_NGAYGIAO.Location = new System.Drawing.Point(88, 98);
            this.txt_NGAYGIAO.Mask = "00/00/0000";
            this.txt_NGAYGIAO.Name = "txt_NGAYGIAO";
            this.txt_NGAYGIAO.ReadOnly = true;
            this.txt_NGAYGIAO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NGAYGIAO.Size = new System.Drawing.Size(138, 20);
            this.txt_NGAYGIAO.TabIndex = 3;
            this.txt_NGAYGIAO.ValidatingType = typeof(System.DateTime);
            // 
            // txt_TENKHACH
            // 
            this.txt_TENKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKHACH.BannerText = null;
            this.txt_TENKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENKHACH.FormNametoShow = "";
            this.txt_TENKHACH.Is_DateTime = false;
            this.txt_TENKHACH.IsShowForm = false;
            this.txt_TENKHACH.Location = new System.Drawing.Point(88, 38);
            this.txt_TENKHACH.Name = "txt_TENKHACH";
            this.txt_TENKHACH.ReadOnly = true;
            this.txt_TENKHACH.Regular_Expression = null;
            this.txt_TENKHACH.Size = new System.Drawing.Size(381, 20);
            this.txt_TENKHACH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 186;
            this.label3.Text = "Khách hàng";
            // 
            // txt_MADONHANG
            // 
            this.txt_MADONHANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MADONHANG.BannerText = null;
            this.txt_MADONHANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MADONHANG.FormNametoShow = "";
            this.txt_MADONHANG.Is_DateTime = false;
            this.txt_MADONHANG.IsShowForm = false;
            this.txt_MADONHANG.Location = new System.Drawing.Point(88, 12);
            this.txt_MADONHANG.Name = "txt_MADONHANG";
            this.txt_MADONHANG.ReadOnly = true;
            this.txt_MADONHANG.Regular_Expression = null;
            this.txt_MADONHANG.Size = new System.Drawing.Size(138, 20);
            this.txt_MADONHANG.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 185;
            this.label4.Text = "Mã đơn hàng";
            // 
            // txt_SOLUONG
            // 
            this.txt_SOLUONG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOLUONG.BannerText = null;
            this.txt_SOLUONG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SOLUONG.Giatrithapphan = 0;
            this.txt_SOLUONG.IsSoNguyen = false;
            this.txt_SOLUONG.Location = new System.Drawing.Point(107, 130);
            this.txt_SOLUONG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SOLUONG.Name = "txt_SOLUONG";
            this.txt_SOLUONG.ReadOnly = true;
            this.txt_SOLUONG.Regular_Expression = "";
            this.txt_SOLUONG.Size = new System.Drawing.Size(138, 20);
            this.txt_SOLUONG.TabIndex = 7;
            this.txt_SOLUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SLDUKIEN
            // 
            this.txt_SLDUKIEN.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SLDUKIEN.BannerText = null;
            this.txt_SLDUKIEN.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_SLDUKIEN.Giatrithapphan = 0;
            this.txt_SLDUKIEN.IsSoNguyen = false;
            this.txt_SLDUKIEN.Location = new System.Drawing.Point(350, 131);
            this.txt_SLDUKIEN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SLDUKIEN.Name = "txt_SLDUKIEN";
            this.txt_SLDUKIEN.ReadOnly = true;
            this.txt_SLDUKIEN.Regular_Expression = "";
            this.txt_SLDUKIEN.Size = new System.Drawing.Size(138, 20);
            this.txt_SLDUKIEN.TabIndex = 8;
            this.txt_SLDUKIEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 181;
            this.label1.Text = "Ngày giao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 179;
            this.label2.Text = "Số lượng dự kiến";
            // 
            // pne_CHITIET
            // 
            this.pne_CHITIET.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pne_CHITIET.Location = new System.Drawing.Point(7, 183);
            this.pne_CHITIET.Margin = new System.Windows.Forms.Padding(2);
            this.pne_CHITIET.Name = "pne_CHITIET";
            this.pne_CHITIET.Size = new System.Drawing.Size(739, 285);
            this.pne_CHITIET.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 176;
            this.label8.Text = "Số lượng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Thoat.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.Location = new System.Drawing.Point(176, 493);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 16;
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
            this.btn_KHOIPHUC.Location = new System.Drawing.Point(177, 493);
            this.btn_KHOIPHUC.Name = "btn_KHOIPHUC";
            this.btn_KHOIPHUC.Size = new System.Drawing.Size(75, 23);
            this.btn_KHOIPHUC.TabIndex = 13;
            this.btn_KHOIPHUC.Text = "&Khôi phục";
            this.btn_KHOIPHUC.UseVisualStyleBackColor = true;
            this.btn_KHOIPHUC.Visible = false;
            this.btn_KHOIPHUC.Click += new System.EventHandler(this.btn_KHOIPHUC_Click);
            // 
            // btn_LUULAI
            // 
            this.btn_LUULAI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_LUULAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_LUULAI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_LUULAI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_LUULAI.Location = new System.Drawing.Point(339, 493);
            this.btn_LUULAI.Name = "btn_LUULAI";
            this.btn_LUULAI.Size = new System.Drawing.Size(75, 23);
            this.btn_LUULAI.TabIndex = 15;
            this.btn_LUULAI.Text = "&Lưu lại";
            this.btn_LUULAI.UseVisualStyleBackColor = true;
            this.btn_LUULAI.Visible = false;
            this.btn_LUULAI.Click += new System.EventHandler(this.btn_LUULAI_Click);
            // 
            // btn_XOA
            // 
            this.btn_XOA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_XOA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_XOA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_XOA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_XOA.Location = new System.Drawing.Point(94, 493);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 23);
            this.btn_XOA.TabIndex = 14;
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
            this.btn_THEMMOI.Location = new System.Drawing.Point(14, 493);
            this.btn_THEMMOI.Name = "btn_THEMMOI";
            this.btn_THEMMOI.Size = new System.Drawing.Size(75, 23);
            this.btn_THEMMOI.TabIndex = 11;
            this.btn_THEMMOI.Text = "Lập KH";
            this.btn_THEMMOI.UseVisualStyleBackColor = true;
            this.btn_THEMMOI.Click += new System.EventHandler(this.btn_THEMMOI_Click);
            // 
            // btn_SUA
            // 
            this.btn_SUA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_SUA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SUA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_SUA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_SUA.Location = new System.Drawing.Point(94, 493);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 23);
            this.btn_SUA.TabIndex = 12;
            this.btn_SUA.Text = "&Sửa";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Visible = false;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // txt_TENSP
            // 
            this.txt_TENSP.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENSP.BannerText = null;
            this.txt_TENSP.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENSP.FormNametoShow = "";
            this.txt_TENSP.Is_DateTime = false;
            this.txt_TENSP.IsShowForm = false;
            this.txt_TENSP.Location = new System.Drawing.Point(231, 69);
            this.txt_TENSP.Name = "txt_TENSP";
            this.txt_TENSP.ReadOnly = true;
            this.txt_TENSP.Regular_Expression = null;
            this.txt_TENSP.Size = new System.Drawing.Size(238, 20);
            this.txt_TENSP.TabIndex = 6;
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
            this.txt_MASP.Location = new System.Drawing.Point(88, 69);
            this.txt_MASP.Name = "txt_MASP";
            this.txt_MASP.ReadOnly = true;
            this.txt_MASP.Regular_Expression = null;
            this.txt_MASP.Size = new System.Drawing.Size(138, 20);
            this.txt_MASP.TabIndex = 5;
            this.txt_MASP.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAMANH_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 71);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 119;
            this.label22.Text = "Mã sản phẩm";
            // 
            // FRM_KHHOANTHIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 565);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_KHHOANTHIEN";
            this.Text = "DANH MỤC CHƯƠNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_KHHOANTHIEN_FormClosing);
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
        private GD.BBPH.CONTROL.TEXTBOX txt_TENSP;
        private GD.BBPH.CONTROL.TEXTBOX txt_MASP;
        private GD.BBPH.CONTROL.LABEL label22;
        private GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC;
        private GD.BBPH.CONTROL.BUTTON btn_LUULAI;
        private GD.BBPH.CONTROL.BUTTON btn_XOA;
        private GD.BBPH.CONTROL.BUTTON btn_THEMMOI;
        private GD.BBPH.CONTROL.BUTTON btn_SUA;
        private GD.BBPH.CONTROL.BUTTON btn_Thoat;
        private CONTROL.LABEL label8;
        private System.Windows.Forms.Panel pne_CHITIET;
        private CONTROL.LABEL label2;
        private CONTROL.LABEL label1;
        private CONTROL.TEXTBOXNUMBER txt_SOLUONG;
        private CONTROL.TEXTBOXNUMBER txt_SLDUKIEN;
        private CONTROL.TEXTBOX txt_TENKHACH;
        private CONTROL.LABEL label3;
        private CONTROL.TEXTBOX txt_MADONHANG;
        private CONTROL.LABEL label4;
        private System.Windows.Forms.MaskedTextBox txt_NGAYGIAO;
        private CONTROL.TEXTBOXNUMBER txt_SOTUICONLAI;
        private CONTROL.LABEL label6;
        private CONTROL.TEXTBOXNUMBER txt_SOTUIDAHOANTHIEN;
        private CONTROL.LABEL label7;
    }
}