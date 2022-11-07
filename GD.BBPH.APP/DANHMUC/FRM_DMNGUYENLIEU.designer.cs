namespace GD.BBPH.APP.DANHMUC
{
    partial class FRM_DMNGUYENLIEU
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
            this.txt_TENRUTGON = new GD.BBPH.CONTROL.TEXTBOX();
            this.label6 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENNHOM = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MANHOM = new GD.BBPH.CONTROL.TEXTBOX();
            this.label5 = new GD.BBPH.CONTROL.LABEL();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.txt_NGAYAPDUNG = new System.Windows.Forms.MaskedTextBox();
            this.pne_CHITIET = new System.Windows.Forms.Panel();
            this.btn_XOADONG = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMDONG = new GD.BBPH.CONTROL.BUTTON();
            this.txt_GIA = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.btn_Thoat = new GD.BBPH.CONTROL.BUTTON();
            this.btn_KHOIPHUC = new GD.BBPH.CONTROL.BUTTON();
            this.btn_LUULAI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_XOA = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMMOI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_SUA = new GD.BBPH.CONTROL.BUTTON();
            this.txt_TENNL = new GD.BBPH.CONTROL.TEXTBOX();
            this.label21 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MANL = new GD.BBPH.CONTROL.TEXTBOX();
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(604, 512), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(517, 512), true);
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
            this.uiPanel0.Size = new System.Drawing.Size(604, 512);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Danh sách";
            this.uiPanel0.Resize += new System.EventHandler(this.uiPanel0_Resize);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(598, 488);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(607, 3);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(517, 512);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Chi tiết";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.label16);
            this.uiPanel1Container.Controls.Add(this.txt_TENRUTGON);
            this.uiPanel1Container.Controls.Add(this.label6);
            this.uiPanel1Container.Controls.Add(this.txt_TENNHOM);
            this.uiPanel1Container.Controls.Add(this.txt_MANHOM);
            this.uiPanel1Container.Controls.Add(this.label5);
            this.uiPanel1Container.Controls.Add(this.label2);
            this.uiPanel1Container.Controls.Add(this.txt_NGAYAPDUNG);
            this.uiPanel1Container.Controls.Add(this.pne_CHITIET);
            this.uiPanel1Container.Controls.Add(this.btn_XOADONG);
            this.uiPanel1Container.Controls.Add(this.btn_THEMDONG);
            this.uiPanel1Container.Controls.Add(this.txt_GIA);
            this.uiPanel1Container.Controls.Add(this.label1);
            this.uiPanel1Container.Controls.Add(this.btn_Thoat);
            this.uiPanel1Container.Controls.Add(this.btn_KHOIPHUC);
            this.uiPanel1Container.Controls.Add(this.btn_LUULAI);
            this.uiPanel1Container.Controls.Add(this.btn_XOA);
            this.uiPanel1Container.Controls.Add(this.btn_THEMMOI);
            this.uiPanel1Container.Controls.Add(this.btn_SUA);
            this.uiPanel1Container.Controls.Add(this.txt_TENNL);
            this.uiPanel1Container.Controls.Add(this.label21);
            this.uiPanel1Container.Controls.Add(this.txt_MANL);
            this.uiPanel1Container.Controls.Add(this.label22);
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(515, 488);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(3, 118);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(509, 2);
            this.label16.TabIndex = 250;
            // 
            // txt_TENRUTGON
            // 
            this.txt_TENRUTGON.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENRUTGON.BannerText = null;
            this.txt_TENRUTGON.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENRUTGON.FormNametoShow = "";
            this.txt_TENRUTGON.Is_DateTime = false;
            this.txt_TENRUTGON.IsShowForm = false;
            this.txt_TENRUTGON.Location = new System.Drawing.Point(96, 57);
            this.txt_TENRUTGON.Name = "txt_TENRUTGON";
            this.txt_TENRUTGON.Regular_Expression = null;
            this.txt_TENRUTGON.Size = new System.Drawing.Size(276, 20);
            this.txt_TENRUTGON.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 169;
            this.label6.Text = "Tên rút gọn";
            // 
            // txt_TENNHOM
            // 
            this.txt_TENNHOM.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENNHOM.BannerText = null;
            this.txt_TENNHOM.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENNHOM.FormNametoShow = "";
            this.txt_TENNHOM.Is_DateTime = false;
            this.txt_TENNHOM.IsShowForm = false;
            this.txt_TENNHOM.Location = new System.Drawing.Point(178, 86);
            this.txt_TENNHOM.Name = "txt_TENNHOM";
            this.txt_TENNHOM.ReadOnly = true;
            this.txt_TENNHOM.Regular_Expression = null;
            this.txt_TENNHOM.Size = new System.Drawing.Size(194, 20);
            this.txt_TENNHOM.TabIndex = 4;
            this.txt_TENNHOM.TabStop = false;
            // 
            // txt_MANHOM
            // 
            this.txt_MANHOM.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANHOM.BannerText = null;
            this.txt_MANHOM.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MANHOM.FormNametoShow = "";
            this.txt_MANHOM.Is_DateTime = false;
            this.txt_MANHOM.IsShowForm = false;
            this.txt_MANHOM.Location = new System.Drawing.Point(96, 86);
            this.txt_MANHOM.Name = "txt_MANHOM";
            this.txt_MANHOM.Regular_Expression = null;
            this.txt_MANHOM.Size = new System.Drawing.Size(77, 20);
            this.txt_MANHOM.TabIndex = 3;
            this.txt_MANHOM.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MANHOM_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 167;
            this.label5.Text = "Nhóm NL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 160;
            this.label2.Text = "Ngày áp dụng";
            // 
            // txt_NGAYAPDUNG
            // 
            this.txt_NGAYAPDUNG.Location = new System.Drawing.Point(296, 137);
            this.txt_NGAYAPDUNG.Mask = "00/00/0000";
            this.txt_NGAYAPDUNG.Name = "txt_NGAYAPDUNG";
            this.txt_NGAYAPDUNG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NGAYAPDUNG.Size = new System.Drawing.Size(77, 20);
            this.txt_NGAYAPDUNG.TabIndex = 6;
            this.txt_NGAYAPDUNG.ValidatingType = typeof(System.DateTime);
            // 
            // pne_CHITIET
            // 
            this.pne_CHITIET.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pne_CHITIET.Location = new System.Drawing.Point(14, 209);
            this.pne_CHITIET.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pne_CHITIET.Name = "pne_CHITIET";
            this.pne_CHITIET.Size = new System.Drawing.Size(486, 218);
            this.pne_CHITIET.TabIndex = 9;
            // 
            // btn_XOADONG
            // 
            this.btn_XOADONG.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_XOADONG.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_XOADONG.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_XOADONG.Location = new System.Drawing.Point(96, 176);
            this.btn_XOADONG.Name = "btn_XOADONG";
            this.btn_XOADONG.Size = new System.Drawing.Size(78, 23);
            this.btn_XOADONG.TabIndex = 8;
            this.btn_XOADONG.Text = "Xóa giá";
            this.btn_XOADONG.UseVisualStyleBackColor = true;
            this.btn_XOADONG.Click += new System.EventHandler(this.btn_XOADONG_Click);
            // 
            // btn_THEMDONG
            // 
            this.btn_THEMDONG.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THEMDONG.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THEMDONG.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THEMDONG.Location = new System.Drawing.Point(10, 176);
            this.btn_THEMDONG.Name = "btn_THEMDONG";
            this.btn_THEMDONG.Size = new System.Drawing.Size(78, 23);
            this.btn_THEMDONG.TabIndex = 7;
            this.btn_THEMDONG.Text = "Thêm giá";
            this.btn_THEMDONG.UseVisualStyleBackColor = true;
            this.btn_THEMDONG.Click += new System.EventHandler(this.btn_THEMDONG_Click);
            // 
            // txt_GIA
            // 
            this.txt_GIA.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GIA.BannerText = null;
            this.txt_GIA.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_GIA.Giatrithapphan = 0;
            this.txt_GIA.IsSoNguyen = false;
            this.txt_GIA.Location = new System.Drawing.Point(96, 136);
            this.txt_GIA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GIA.Name = "txt_GIA";
            this.txt_GIA.Regular_Expression = "";
            this.txt_GIA.Size = new System.Drawing.Size(77, 20);
            this.txt_GIA.TabIndex = 5;
            this.txt_GIA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Giá";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Thoat.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.Location = new System.Drawing.Point(420, 447);
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
            this.btn_KHOIPHUC.Location = new System.Drawing.Point(173, 447);
            this.btn_KHOIPHUC.Name = "btn_KHOIPHUC";
            this.btn_KHOIPHUC.Size = new System.Drawing.Size(75, 23);
            this.btn_KHOIPHUC.TabIndex = 13;
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
            this.btn_LUULAI.Location = new System.Drawing.Point(14, 447);
            this.btn_LUULAI.Name = "btn_LUULAI";
            this.btn_LUULAI.Size = new System.Drawing.Size(75, 23);
            this.btn_LUULAI.TabIndex = 11;
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
            this.btn_XOA.Location = new System.Drawing.Point(92, 447);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 23);
            this.btn_XOA.TabIndex = 12;
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
            this.btn_THEMMOI.Location = new System.Drawing.Point(338, 447);
            this.btn_THEMMOI.Name = "btn_THEMMOI";
            this.btn_THEMMOI.Size = new System.Drawing.Size(75, 23);
            this.btn_THEMMOI.TabIndex = 15;
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
            this.btn_SUA.Location = new System.Drawing.Point(257, 447);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 23);
            this.btn_SUA.TabIndex = 14;
            this.btn_SUA.Text = "&Sửa";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // txt_TENNL
            // 
            this.txt_TENNL.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENNL.BannerText = null;
            this.txt_TENNL.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENNL.FormNametoShow = "";
            this.txt_TENNL.Is_DateTime = false;
            this.txt_TENNL.IsShowForm = false;
            this.txt_TENNL.Location = new System.Drawing.Point(96, 30);
            this.txt_TENNL.Name = "txt_TENNL";
            this.txt_TENNL.Regular_Expression = null;
            this.txt_TENNL.Size = new System.Drawing.Size(276, 20);
            this.txt_TENNL.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 120;
            this.label21.Text = "Tên nguyên liệu";
            // 
            // txt_MANL
            // 
            this.txt_MANL.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANL.BannerText = null;
            this.txt_MANL.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MANL.FormNametoShow = "";
            this.txt_MANL.Is_DateTime = false;
            this.txt_MANL.IsShowForm = false;
            this.txt_MANL.Location = new System.Drawing.Point(96, 5);
            this.txt_MANL.Name = "txt_MANL";
            this.txt_MANL.Regular_Expression = null;
            this.txt_MANL.Size = new System.Drawing.Size(77, 20);
            this.txt_MANL.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 119;
            this.label22.Text = "Mã nguyên liệu";
            // 
            // FRM_DMNGUYENLIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 518);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_DMNGUYENLIEU";
            this.Text = "DANH MỤC CHƯƠNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_DMNGUYENLIEU_FormClosing);
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
        private GD.BBPH.CONTROL.TEXTBOX txt_TENNL;
        private GD.BBPH.CONTROL.LABEL label21;
        private GD.BBPH.CONTROL.TEXTBOX txt_MANL;
        private GD.BBPH.CONTROL.LABEL label22;
        private GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC;
        private GD.BBPH.CONTROL.BUTTON btn_LUULAI;
        private GD.BBPH.CONTROL.BUTTON btn_XOA;
        private GD.BBPH.CONTROL.BUTTON btn_THEMMOI;
        private GD.BBPH.CONTROL.BUTTON btn_SUA;
        private GD.BBPH.CONTROL.BUTTON btn_Thoat;
        private CONTROL.TEXTBOXNUMBER txt_GIA;
        private CONTROL.LABEL label1;
        private System.Windows.Forms.Panel pne_CHITIET;
        private CONTROL.BUTTON btn_XOADONG;
        private CONTROL.BUTTON btn_THEMDONG;
        private CONTROL.LABEL label2;
        private System.Windows.Forms.MaskedTextBox txt_NGAYAPDUNG;
        private CONTROL.TEXTBOX txt_TENNHOM;
        private CONTROL.TEXTBOX txt_MANHOM;
        private CONTROL.LABEL label5;
        private CONTROL.TEXTBOX txt_TENRUTGON;
        private CONTROL.LABEL label6;
        private System.Windows.Forms.Label label16;
    }
}