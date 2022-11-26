namespace GD.BBPH.APP.DANHMUC
{
    partial class FRM_DMQUYCACH
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
            this.txt_TENNHOMQC = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_TENCD = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MANHOMQC = new GD.BBPH.CONTROL.TEXTBOX();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MACD = new GD.BBPH.CONTROL.TEXTBOX();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.btn_Thoat = new GD.BBPH.CONTROL.BUTTON();
            this.btn_KHOIPHUC = new GD.BBPH.CONTROL.BUTTON();
            this.btn_LUULAI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_XOA = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THEMMOI = new GD.BBPH.CONTROL.BUTTON();
            this.btn_SUA = new GD.BBPH.CONTROL.BUTTON();
            this.txt_TENQUYCACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.label21 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MAQC = new GD.BBPH.CONTROL.TEXTBOX();
            this.label22 = new GD.BBPH.CONTROL.LABEL();
            this.txt_HESORIENG = new GD.BBPH.CONTROL.TEXTBOX();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
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
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("07a915f4-063b-4962-a538-f0e669e38ca3"), Janus.Windows.UI.Dock.PanelDockStyle.Left, new System.Drawing.Size(471, 542), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("43b1eac6-97d8-4025-b6ba-6cafc1f384ad"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(515, 542), true);
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
            this.uiPanel0.Size = new System.Drawing.Size(471, 542);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "Danh sách";
            this.uiPanel0.Resize += new System.EventHandler(this.uiPanel0_Resize);
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(465, 518);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.ContainerPanel;
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(474, 3);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(515, 542);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Chi tiết";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.txt_HESORIENG);
            this.uiPanel1Container.Controls.Add(this.label3);
            this.uiPanel1Container.Controls.Add(this.txt_TENNHOMQC);
            this.uiPanel1Container.Controls.Add(this.txt_TENCD);
            this.uiPanel1Container.Controls.Add(this.txt_MANHOMQC);
            this.uiPanel1Container.Controls.Add(this.label2);
            this.uiPanel1Container.Controls.Add(this.txt_MACD);
            this.uiPanel1Container.Controls.Add(this.label1);
            this.uiPanel1Container.Controls.Add(this.btn_Thoat);
            this.uiPanel1Container.Controls.Add(this.btn_KHOIPHUC);
            this.uiPanel1Container.Controls.Add(this.btn_LUULAI);
            this.uiPanel1Container.Controls.Add(this.btn_XOA);
            this.uiPanel1Container.Controls.Add(this.btn_THEMMOI);
            this.uiPanel1Container.Controls.Add(this.btn_SUA);
            this.uiPanel1Container.Controls.Add(this.txt_TENQUYCACH);
            this.uiPanel1Container.Controls.Add(this.label21);
            this.uiPanel1Container.Controls.Add(this.txt_MAQC);
            this.uiPanel1Container.Controls.Add(this.label22);
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(513, 518);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // txt_TENNHOMQC
            // 
            this.txt_TENNHOMQC.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENNHOMQC.BannerText = null;
            this.txt_TENNHOMQC.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENNHOMQC.FormNametoShow = "";
            this.txt_TENNHOMQC.Is_DateTime = false;
            this.txt_TENNHOMQC.IsShowForm = false;
            this.txt_TENNHOMQC.Location = new System.Drawing.Point(255, 86);
            this.txt_TENNHOMQC.Name = "txt_TENNHOMQC";
            this.txt_TENNHOMQC.Regular_Expression = null;
            this.txt_TENNHOMQC.Size = new System.Drawing.Size(242, 20);
            this.txt_TENNHOMQC.TabIndex = 127;
            // 
            // txt_TENCD
            // 
            this.txt_TENCD.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENCD.BannerText = null;
            this.txt_TENCD.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENCD.FormNametoShow = "";
            this.txt_TENCD.Is_DateTime = false;
            this.txt_TENCD.IsShowForm = false;
            this.txt_TENCD.Location = new System.Drawing.Point(255, 121);
            this.txt_TENCD.Name = "txt_TENCD";
            this.txt_TENCD.Regular_Expression = null;
            this.txt_TENCD.Size = new System.Drawing.Size(242, 20);
            this.txt_TENCD.TabIndex = 125;
            // 
            // txt_MANHOMQC
            // 
            this.txt_MANHOMQC.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANHOMQC.BannerText = null;
            this.txt_MANHOMQC.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MANHOMQC.FormNametoShow = "";
            this.txt_MANHOMQC.Is_DateTime = false;
            this.txt_MANHOMQC.IsShowForm = false;
            this.txt_MANHOMQC.Location = new System.Drawing.Point(136, 86);
            this.txt_MANHOMQC.Name = "txt_MANHOMQC";
            this.txt_MANHOMQC.Regular_Expression = null;
            this.txt_MANHOMQC.Size = new System.Drawing.Size(114, 20);
            this.txt_MANHOMQC.TabIndex = 2;
            this.txt_MANHOMQC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MANHOMQC_KeyDown);
            this.txt_MANHOMQC.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MANHOMQC_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Nhóm quy cách";
            // 
            // txt_MACD
            // 
            this.txt_MACD.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MACD.BannerText = null;
            this.txt_MACD.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MACD.FormNametoShow = "";
            this.txt_MACD.Is_DateTime = false;
            this.txt_MACD.IsShowForm = false;
            this.txt_MACD.Location = new System.Drawing.Point(136, 121);
            this.txt_MACD.Name = "txt_MACD";
            this.txt_MACD.Regular_Expression = null;
            this.txt_MACD.Size = new System.Drawing.Size(114, 20);
            this.txt_MACD.TabIndex = 3;
            this.txt_MACD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MACD_KeyDown);
            this.txt_MACD.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MACD_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Công đoạn";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.Location = new System.Drawing.Point(422, 190);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_KHOIPHUC
            // 
            this.btn_KHOIPHUC.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_KHOIPHUC.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_KHOIPHUC.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_KHOIPHUC.Location = new System.Drawing.Point(175, 190);
            this.btn_KHOIPHUC.Name = "btn_KHOIPHUC";
            this.btn_KHOIPHUC.Size = new System.Drawing.Size(75, 23);
            this.btn_KHOIPHUC.TabIndex = 6;
            this.btn_KHOIPHUC.Text = "&Khôi phục";
            this.btn_KHOIPHUC.UseVisualStyleBackColor = true;
            this.btn_KHOIPHUC.Click += new System.EventHandler(this.btn_KHOIPHUC_Click);
            // 
            // btn_LUULAI
            // 
            this.btn_LUULAI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_LUULAI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_LUULAI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_LUULAI.Location = new System.Drawing.Point(15, 190);
            this.btn_LUULAI.Name = "btn_LUULAI";
            this.btn_LUULAI.Size = new System.Drawing.Size(75, 23);
            this.btn_LUULAI.TabIndex = 4;
            this.btn_LUULAI.Text = "&Lưu lại";
            this.btn_LUULAI.UseVisualStyleBackColor = true;
            this.btn_LUULAI.Click += new System.EventHandler(this.btn_LUULAI_Click);
            // 
            // btn_XOA
            // 
            this.btn_XOA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_XOA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_XOA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_XOA.Location = new System.Drawing.Point(94, 190);
            this.btn_XOA.Name = "btn_XOA";
            this.btn_XOA.Size = new System.Drawing.Size(75, 23);
            this.btn_XOA.TabIndex = 5;
            this.btn_XOA.Text = "&Xóa";
            this.btn_XOA.UseVisualStyleBackColor = true;
            this.btn_XOA.Click += new System.EventHandler(this.btn_XOA_Click);
            // 
            // btn_THEMMOI
            // 
            this.btn_THEMMOI.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THEMMOI.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THEMMOI.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THEMMOI.Location = new System.Drawing.Point(340, 190);
            this.btn_THEMMOI.Name = "btn_THEMMOI";
            this.btn_THEMMOI.Size = new System.Drawing.Size(75, 23);
            this.btn_THEMMOI.TabIndex = 8;
            this.btn_THEMMOI.Text = "Thêm &mới";
            this.btn_THEMMOI.UseVisualStyleBackColor = true;
            this.btn_THEMMOI.Click += new System.EventHandler(this.btn_THEMMOI_Click);
            // 
            // btn_SUA
            // 
            this.btn_SUA.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_SUA.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_SUA.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_SUA.Location = new System.Drawing.Point(259, 190);
            this.btn_SUA.Name = "btn_SUA";
            this.btn_SUA.Size = new System.Drawing.Size(75, 23);
            this.btn_SUA.TabIndex = 7;
            this.btn_SUA.Text = "&Sửa";
            this.btn_SUA.UseVisualStyleBackColor = true;
            this.btn_SUA.Click += new System.EventHandler(this.btn_SUA_Click);
            // 
            // txt_TENQUYCACH
            // 
            this.txt_TENQUYCACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENQUYCACH.BannerText = null;
            this.txt_TENQUYCACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENQUYCACH.FormNametoShow = "";
            this.txt_TENQUYCACH.Is_DateTime = false;
            this.txt_TENQUYCACH.IsShowForm = false;
            this.txt_TENQUYCACH.Location = new System.Drawing.Point(136, 50);
            this.txt_TENQUYCACH.Name = "txt_TENQUYCACH";
            this.txt_TENQUYCACH.Regular_Expression = null;
            this.txt_TENQUYCACH.Size = new System.Drawing.Size(361, 20);
            this.txt_TENQUYCACH.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 120;
            this.label21.Text = "Tên quy cách";
            // 
            // txt_MAQC
            // 
            this.txt_MAQC.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAQC.BannerText = null;
            this.txt_MAQC.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAQC.FormNametoShow = "";
            this.txt_MAQC.Is_DateTime = false;
            this.txt_MAQC.IsShowForm = false;
            this.txt_MAQC.Location = new System.Drawing.Point(136, 17);
            this.txt_MAQC.Name = "txt_MAQC";
            this.txt_MAQC.Regular_Expression = null;
            this.txt_MAQC.Size = new System.Drawing.Size(114, 20);
            this.txt_MAQC.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 119;
            this.label22.Text = "Mã quy cách";
            // 
            // txt_HESORIENG
            // 
            this.txt_HESORIENG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HESORIENG.BannerText = null;
            this.txt_HESORIENG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_HESORIENG.FormNametoShow = "";
            this.txt_HESORIENG.Is_DateTime = false;
            this.txt_HESORIENG.IsShowForm = false;
            this.txt_HESORIENG.Location = new System.Drawing.Point(136, 149);
            this.txt_HESORIENG.Name = "txt_HESORIENG";
            this.txt_HESORIENG.Regular_Expression = null;
            this.txt_HESORIENG.Size = new System.Drawing.Size(114, 20);
            this.txt_HESORIENG.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 129;
            this.label3.Text = "Hệ số riêng";
            // 
            // FRM_DMQUYCACH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 548);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_DMQUYCACH";
            this.Text = "DANH MỤC CHƯƠNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_DMQUYCACH_FormClosing);
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
        private GD.BBPH.CONTROL.TEXTBOX txt_TENQUYCACH;
        private GD.BBPH.CONTROL.LABEL label21;
        private GD.BBPH.CONTROL.TEXTBOX txt_MAQC;
        private GD.BBPH.CONTROL.LABEL label22;
        private GD.BBPH.CONTROL.BUTTON btn_KHOIPHUC;
        private GD.BBPH.CONTROL.BUTTON btn_LUULAI;
        private GD.BBPH.CONTROL.BUTTON btn_XOA;
        private GD.BBPH.CONTROL.BUTTON btn_THEMMOI;
        private GD.BBPH.CONTROL.BUTTON btn_SUA;
        private GD.BBPH.CONTROL.BUTTON btn_Thoat;
        protected internal CONTROL.TEXTBOX txt_MACD;
        protected internal CONTROL.LABEL label1;
        protected internal CONTROL.TEXTBOX txt_MANHOMQC;
        protected internal CONTROL.LABEL label2;
        protected internal CONTROL.TEXTBOX txt_TENNHOMQC;
        protected internal CONTROL.TEXTBOX txt_TENCD;
        protected internal CONTROL.TEXTBOX txt_HESORIENG;
        protected internal CONTROL.LABEL label3;
    }
}