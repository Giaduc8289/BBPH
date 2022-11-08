namespace GD.BBPH.APP.DANHMUC
{
    partial class FRM_DMMANG
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
            this.txt_TENQUYCACHMANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MAQUYCACHMANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.label9 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENLOAIMANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MALOAIMANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.label8 = new GD.BBPH.CONTROL.LABEL();
            this.label6 = new GD.BBPH.CONTROL.LABEL();
            this.label7 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENCTPT = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MACTPT = new GD.BBPH.CONTROL.TEXTBOX();
            this.label5 = new GD.BBPH.CONTROL.LABEL();
            this.label4 = new GD.BBPH.CONTROL.LABEL();
            this.txt_KICHTHUOC = new GD.BBPH.CONTROL.TEXTBOX();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MAKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.btn_Thoat = new GD.BBPH.CONTROL.BUTTON();
            this.btn_KHOIPHUC = new GD.BBPH.CONTROL.BUTTON();
            this.btn_LUULAI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_XOA = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMMOI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_SUA = new GD.BBPH.CONTROL.BUTTON();
            this.txt_TENHIEU = new GD.BBPH.CONTROL.TEXTBOX();
            this.label21 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MAHIEU = new GD.BBPH.CONTROL.TEXTBOX();
            this.label22 = new GD.BBPH.CONTROL.LABEL();
            this.txt_RONG = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.txt_DODAY = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
            this.txt_TRONGLUONG = new GD.BBPH.CONTROL.TEXTBOXNUMBER();
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(1111, 559), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(536, 559), true);
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
            this.uiPanel0.Size = new System.Drawing.Size(1111, 559);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Danh sách";
            this.uiPanel0.Resize += new System.EventHandler(this.uiPanel0_Resize);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(1105, 535);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(1114, 3);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(536, 559);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Chi tiết";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.txt_TRONGLUONG);
            this.uiPanel1Container.Controls.Add(this.txt_DODAY);
            this.uiPanel1Container.Controls.Add(this.txt_RONG);
            this.uiPanel1Container.Controls.Add(this.txt_TENQUYCACHMANG);
            this.uiPanel1Container.Controls.Add(this.txt_MAQUYCACHMANG);
            this.uiPanel1Container.Controls.Add(this.label9);
            this.uiPanel1Container.Controls.Add(this.txt_TENLOAIMANG);
            this.uiPanel1Container.Controls.Add(this.txt_MALOAIMANG);
            this.uiPanel1Container.Controls.Add(this.label8);
            this.uiPanel1Container.Controls.Add(this.label6);
            this.uiPanel1Container.Controls.Add(this.label7);
            this.uiPanel1Container.Controls.Add(this.txt_TENCTPT);
            this.uiPanel1Container.Controls.Add(this.txt_MACTPT);
            this.uiPanel1Container.Controls.Add(this.label5);
            this.uiPanel1Container.Controls.Add(this.label4);
            this.uiPanel1Container.Controls.Add(this.txt_KICHTHUOC);
            this.uiPanel1Container.Controls.Add(this.label3);
            this.uiPanel1Container.Controls.Add(this.txt_TENKHACH);
            this.uiPanel1Container.Controls.Add(this.label2);
            this.uiPanel1Container.Controls.Add(this.txt_MAKHACH);
            this.uiPanel1Container.Controls.Add(this.label1);
            this.uiPanel1Container.Controls.Add(this.btn_Thoat);
            this.uiPanel1Container.Controls.Add(this.btn_KHOIPHUC);
            this.uiPanel1Container.Controls.Add(this.btn_LUULAI);
            this.uiPanel1Container.Controls.Add(this.btn_XOA);
            this.uiPanel1Container.Controls.Add(this.btn_THEMMOI);
            this.uiPanel1Container.Controls.Add(this.btn_SUA);
            this.uiPanel1Container.Controls.Add(this.txt_TENHIEU);
            this.uiPanel1Container.Controls.Add(this.label21);
            this.uiPanel1Container.Controls.Add(this.txt_MAHIEU);
            this.uiPanel1Container.Controls.Add(this.label22);
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(534, 535);
            this.uiPanel1Container.TabIndex = 0;
            this.uiPanel1Container.Click += new System.EventHandler(this.uiPanel1Container_Click);
            // 
            // txt_TENQUYCACHMANG
            // 
            this.txt_TENQUYCACHMANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENQUYCACHMANG.BannerText = null;
            this.txt_TENQUYCACHMANG.Enabled = false;
            this.txt_TENQUYCACHMANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENQUYCACHMANG.FormNametoShow = "";
            this.txt_TENQUYCACHMANG.Is_DateTime = false;
            this.txt_TENQUYCACHMANG.IsShowForm = false;
            this.txt_TENQUYCACHMANG.Location = new System.Drawing.Point(258, 162);
            this.txt_TENQUYCACHMANG.Name = "txt_TENQUYCACHMANG";
            this.txt_TENQUYCACHMANG.ReadOnly = true;
            this.txt_TENQUYCACHMANG.Regular_Expression = null;
            this.txt_TENQUYCACHMANG.Size = new System.Drawing.Size(205, 20);
            this.txt_TENQUYCACHMANG.TabIndex = 11;
            // 
            // txt_MAQUYCACHMANG
            // 
            this.txt_MAQUYCACHMANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAQUYCACHMANG.BannerText = null;
            this.txt_MAQUYCACHMANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAQUYCACHMANG.FormNametoShow = "";
            this.txt_MAQUYCACHMANG.Is_DateTime = false;
            this.txt_MAQUYCACHMANG.IsShowForm = false;
            this.txt_MAQUYCACHMANG.Location = new System.Drawing.Point(78, 162);
            this.txt_MAQUYCACHMANG.Name = "txt_MAQUYCACHMANG";
            this.txt_MAQUYCACHMANG.Regular_Expression = null;
            this.txt_MAQUYCACHMANG.Size = new System.Drawing.Size(138, 20);
            this.txt_MAQUYCACHMANG.TabIndex = 10;
            this.txt_MAQUYCACHMANG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MAQCMANG_KeyDown);
            this.txt_MAQUYCACHMANG.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAQUYCACHMANG_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 140;
            this.label9.Text = "QC màng";
            // 
            // txt_TENLOAIMANG
            // 
            this.txt_TENLOAIMANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENLOAIMANG.BannerText = null;
            this.txt_TENLOAIMANG.Enabled = false;
            this.txt_TENLOAIMANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENLOAIMANG.FormNametoShow = "";
            this.txt_TENLOAIMANG.Is_DateTime = false;
            this.txt_TENLOAIMANG.IsShowForm = false;
            this.txt_TENLOAIMANG.Location = new System.Drawing.Point(258, 136);
            this.txt_TENLOAIMANG.Name = "txt_TENLOAIMANG";
            this.txt_TENLOAIMANG.ReadOnly = true;
            this.txt_TENLOAIMANG.Regular_Expression = null;
            this.txt_TENLOAIMANG.Size = new System.Drawing.Size(205, 20);
            this.txt_TENLOAIMANG.TabIndex = 9;
            // 
            // txt_MALOAIMANG
            // 
            this.txt_MALOAIMANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MALOAIMANG.BannerText = null;
            this.txt_MALOAIMANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MALOAIMANG.FormNametoShow = "";
            this.txt_MALOAIMANG.Is_DateTime = false;
            this.txt_MALOAIMANG.IsShowForm = false;
            this.txt_MALOAIMANG.Location = new System.Drawing.Point(78, 136);
            this.txt_MALOAIMANG.Name = "txt_MALOAIMANG";
            this.txt_MALOAIMANG.Regular_Expression = null;
            this.txt_MALOAIMANG.Size = new System.Drawing.Size(138, 20);
            this.txt_MALOAIMANG.TabIndex = 8;
            this.txt_MALOAIMANG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MALOAIMANG_KeyDown);
            this.txt_MALOAIMANG.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MALOAIMANG_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "Loại màng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "Rộng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "Độ dày";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_TENCTPT
            // 
            this.txt_TENCTPT.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENCTPT.BannerText = null;
            this.txt_TENCTPT.Enabled = false;
            this.txt_TENCTPT.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENCTPT.FormNametoShow = "";
            this.txt_TENCTPT.Is_DateTime = false;
            this.txt_TENCTPT.IsShowForm = false;
            this.txt_TENCTPT.Location = new System.Drawing.Point(258, 188);
            this.txt_TENCTPT.Name = "txt_TENCTPT";
            this.txt_TENCTPT.ReadOnly = true;
            this.txt_TENCTPT.Regular_Expression = null;
            this.txt_TENCTPT.Size = new System.Drawing.Size(205, 20);
            this.txt_TENCTPT.TabIndex = 13;
            this.txt_TENCTPT.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MACTPT_Validating);
            // 
            // txt_MACTPT
            // 
            this.txt_MACTPT.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MACTPT.BannerText = null;
            this.txt_MACTPT.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MACTPT.FormNametoShow = "";
            this.txt_MACTPT.Is_DateTime = false;
            this.txt_MACTPT.IsShowForm = false;
            this.txt_MACTPT.Location = new System.Drawing.Point(78, 188);
            this.txt_MACTPT.Name = "txt_MACTPT";
            this.txt_MACTPT.Regular_Expression = null;
            this.txt_MACTPT.Size = new System.Drawing.Size(138, 20);
            this.txt_MACTPT.TabIndex = 12;
            this.txt_MACTPT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MACTPTMANG_KeyDown);
            this.txt_MACTPT.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MACTPT_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 130;
            this.label5.Text = "Mã CTPT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 128;
            this.label4.Text = "Trọng lượng";
            // 
            // txt_KICHTHUOC
            // 
            this.txt_KICHTHUOC.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KICHTHUOC.BannerText = null;
            this.txt_KICHTHUOC.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_KICHTHUOC.FormNametoShow = "";
            this.txt_KICHTHUOC.Is_DateTime = false;
            this.txt_KICHTHUOC.IsShowForm = false;
            this.txt_KICHTHUOC.Location = new System.Drawing.Point(78, 84);
            this.txt_KICHTHUOC.Name = "txt_KICHTHUOC";
            this.txt_KICHTHUOC.Regular_Expression = null;
            this.txt_KICHTHUOC.Size = new System.Drawing.Size(138, 20);
            this.txt_KICHTHUOC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Kích thước";
            // 
            // txt_TENKHACH
            // 
            this.txt_TENKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKHACH.BannerText = null;
            this.txt_TENKHACH.Enabled = false;
            this.txt_TENKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENKHACH.FormNametoShow = "";
            this.txt_TENKHACH.Is_DateTime = false;
            this.txt_TENKHACH.IsShowForm = false;
            this.txt_TENKHACH.Location = new System.Drawing.Point(258, 58);
            this.txt_TENKHACH.Name = "txt_TENKHACH";
            this.txt_TENKHACH.ReadOnly = true;
            this.txt_TENKHACH.Regular_Expression = null;
            this.txt_TENKHACH.Size = new System.Drawing.Size(205, 20);
            this.txt_TENKHACH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // txt_MAKHACH
            // 
            this.txt_MAKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKHACH.BannerText = null;
            this.txt_MAKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAKHACH.FormNametoShow = "";
            this.txt_MAKHACH.Is_DateTime = false;
            this.txt_MAKHACH.IsShowForm = false;
            this.txt_MAKHACH.Location = new System.Drawing.Point(78, 58);
            this.txt_MAKHACH.Name = "txt_MAKHACH";
            this.txt_MAKHACH.Regular_Expression = null;
            this.txt_MAKHACH.Size = new System.Drawing.Size(138, 20);
            this.txt_MAKHACH.TabIndex = 2;
            this.txt_MAKHACH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MAKHACH_KeyDown);
            this.txt_MAKHACH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAKHACH_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Khách hàng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.Location = new System.Drawing.Point(421, 242);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 19;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_KHOIPHUC
            // 
            this.btn_KHOIPHUC.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_KHOIPHUC.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_KHOIPHUC.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_KHOIPHUC.Location = new System.Drawing.Point(174, 242);
            this.btn_KHOIPHUC.Name = "btn_KHOIPHUC";
            this.btn_KHOIPHUC.Size = new System.Drawing.Size(75, 23);
            this.btn_KHOIPHUC.TabIndex = 16;
            this.btn_KHOIPHUC.Text = "&Khôi phục";
            this.btn_KHOIPHUC.UseVisualStyleBackColor = true;
            this.btn_KHOIPHUC.Click += new System.EventHandler(this.btn_KHOIPHUC_Click);
            // 
            // btn_LUULAI
            // 
            this.btn_LUULAI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_LUULAI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_LUULAI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_LUULAI.Location = new System.Drawing.Point(14, 242);
            this.btn_LUULAI.Name = "btn_LUULAI";
            this.btn_LUULAI.Size = new System.Drawing.Size(75, 23);
            this.btn_LUULAI.TabIndex = 14;
            this.btn_LUULAI.Text = "&Lưu lại";
            this.btn_LUULAI.UseVisualStyleBackColor = true;
            this.btn_LUULAI.Click += new System.EventHandler(this.btn_LUULAI_Click);
            // 
            // btn_XOA
            // 
            this.btn_XOA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_XOA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_XOA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_XOA.Location = new System.Drawing.Point(93, 242);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 23);
            this.btn_XOA.TabIndex = 15;
            this.btn_XOA.Text = "&Xóa";
            this.btn_XOA.UseVisualStyleBackColor = true;
            this.btn_XOA.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // btn_THEMMOI
            // 
            this.btn_THEMMOI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THEMMOI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THEMMOI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THEMMOI.Location = new System.Drawing.Point(339, 242);
            this.btn_THEMMOI.Name = "btn_THEMMOI";
            this.btn_THEMMOI.Size = new System.Drawing.Size(75, 23);
            this.btn_THEMMOI.TabIndex = 18;
            this.btn_THEMMOI.Text = "Thêm &mới";
            this.btn_THEMMOI.UseVisualStyleBackColor = true;
            this.btn_THEMMOI.Click += new System.EventHandler(this.btn_THEMMOI_Click);
            // 
            // btn_SUA
            // 
            this.btn_SUA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_SUA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_SUA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_SUA.Location = new System.Drawing.Point(258, 242);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 23);
            this.btn_SUA.TabIndex = 17;
            this.btn_SUA.Text = "&Sửa";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // txt_TENHIEU
            // 
            this.txt_TENHIEU.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENHIEU.BannerText = null;
            this.txt_TENHIEU.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENHIEU.FormNametoShow = "";
            this.txt_TENHIEU.Is_DateTime = false;
            this.txt_TENHIEU.IsShowForm = false;
            this.txt_TENHIEU.Location = new System.Drawing.Point(325, 32);
            this.txt_TENHIEU.Name = "txt_TENHIEU";
            this.txt_TENHIEU.Regular_Expression = null;
            this.txt_TENHIEU.Size = new System.Drawing.Size(138, 20);
            this.txt_TENHIEU.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(255, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 120;
            this.label21.Text = "Tên màng";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // txt_MAHIEU
            // 
            this.txt_MAHIEU.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAHIEU.BannerText = null;
            this.txt_MAHIEU.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAHIEU.FormNametoShow = "";
            this.txt_MAHIEU.Is_DateTime = false;
            this.txt_MAHIEU.IsShowForm = false;
            this.txt_MAHIEU.Location = new System.Drawing.Point(78, 32);
            this.txt_MAHIEU.Name = "txt_MAHIEU";
            this.txt_MAHIEU.Regular_Expression = null;
            this.txt_MAHIEU.Size = new System.Drawing.Size(138, 20);
            this.txt_MAHIEU.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 119;
            this.label22.Text = "Mã màng";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // txt_RONG
            // 
            this.txt_RONG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RONG.BannerText = null;
            this.txt_RONG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_RONG.Giatrithapphan = 0;
            this.txt_RONG.IsSoNguyen = false;
            this.txt_RONG.Location = new System.Drawing.Point(325, 110);
            this.txt_RONG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_RONG.Name = "txt_RONG";
            this.txt_RONG.Regular_Expression = "";
            this.txt_RONG.Size = new System.Drawing.Size(138, 20);
            this.txt_RONG.TabIndex = 7;
            this.txt_RONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_DODAY
            // 
            this.txt_DODAY.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DODAY.BannerText = null;
            this.txt_DODAY.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_DODAY.Giatrithapphan = 0;
            this.txt_DODAY.IsSoNguyen = false;
            this.txt_DODAY.Location = new System.Drawing.Point(78, 110);
            this.txt_DODAY.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_DODAY.Name = "txt_DODAY";
            this.txt_DODAY.Regular_Expression = "";
            this.txt_DODAY.Size = new System.Drawing.Size(138, 20);
            this.txt_DODAY.TabIndex = 6;
            this.txt_DODAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TRONGLUONG
            // 
            this.txt_TRONGLUONG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TRONGLUONG.BannerText = null;
            this.txt_TRONGLUONG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TRONGLUONG.Giatrithapphan = 0;
            this.txt_TRONGLUONG.IsSoNguyen = false;
            this.txt_TRONGLUONG.Location = new System.Drawing.Point(325, 84);
            this.txt_TRONGLUONG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_TRONGLUONG.Name = "txt_TRONGLUONG";
            this.txt_TRONGLUONG.Regular_Expression = "";
            this.txt_TRONGLUONG.Size = new System.Drawing.Size(138, 20);
            this.txt_TRONGLUONG.TabIndex = 5;
            this.txt_TRONGLUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FRM_DMMANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 565);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_DMMANG";
            this.Text = "DANH MỤC CHƯƠNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_DMMANG_FormClosing);
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
        private GD.BBPH.CONTROL.TEXTBOX txt_TENHIEU;
        private GD.BBPH.CONTROL.LABEL label21;
        private GD.BBPH.CONTROL.TEXTBOX txt_MAHIEU;
        private GD.BBPH.CONTROL.LABEL label22;
        private GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC;
        private GD.BBPH.CONTROL.BUTTON btn_LUULAI;
        private GD.BBPH.CONTROL.BUTTON btn_XOA;
        private GD.BBPH.CONTROL.BUTTON btn_THEMMOI;
        private GD.BBPH.CONTROL.BUTTON btn_SUA;
        private GD.BBPH.CONTROL.BUTTON btn_Thoat;
        private CONTROL.TEXTBOX txt_MACTPT;
        private CONTROL.LABEL label5;
        private CONTROL.LABEL label4;
        private CONTROL.TEXTBOX txt_KICHTHUOC;
        private CONTROL.LABEL label3;
        private CONTROL.TEXTBOX txt_TENKHACH;
        private CONTROL.LABEL label2;
        private CONTROL.TEXTBOX txt_MAKHACH;
        private CONTROL.LABEL label1;
        private CONTROL.TEXTBOX txt_TENCTPT;
        private CONTROL.LABEL label6;
        private CONTROL.LABEL label7;
        private CONTROL.TEXTBOX txt_TENQUYCACHMANG;
        private CONTROL.TEXTBOX txt_MAQUYCACHMANG;
        private CONTROL.LABEL label9;
        private CONTROL.TEXTBOX txt_TENLOAIMANG;
        private CONTROL.TEXTBOX txt_MALOAIMANG;
        private CONTROL.LABEL label8;
        private CONTROL.TEXTBOXNUMBER txt_TRONGLUONG;
        private CONTROL.TEXTBOXNUMBER txt_DODAY;
        private CONTROL.TEXTBOXNUMBER txt_RONG;
    }
}