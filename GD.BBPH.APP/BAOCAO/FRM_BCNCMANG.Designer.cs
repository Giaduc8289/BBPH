namespace GD.BBPH.APP.BAOCAO
{
    partial class FRM_BCNCMANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BCNCMANG));
            this.btn_IN = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THOAT = new GD.BBPH.CONTROL.BUTTON();
            this.txt_DENNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TUNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MADON = new GD.BBPH.CONTROL.TEXTBOX();
            this.label22 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MASANPHAM = new GD.BBPH.CONTROL.TEXTBOX();
            this.label25 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENSANPHAM = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_TENKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.label15 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MAKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_NGAYDAT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.SuspendLayout();
            // 
            // btn_IN
            // 
            this.btn_IN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_IN.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_IN.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_IN.Location = new System.Drawing.Point(179, 178);
            this.btn_IN.Name = "btn_IN";
            this.btn_IN.Size = new System.Drawing.Size(75, 23);
            this.btn_IN.TabIndex = 8;
            this.btn_IN.Text = "&In";
            this.btn_IN.UseVisualStyleBackColor = true;
            this.btn_IN.Click += new System.EventHandler(this.btn_IN_Click);
            // 
            // btn_THOAT
            // 
            this.btn_THOAT.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THOAT.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THOAT.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_THOAT.Location = new System.Drawing.Point(260, 178);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(75, 23);
            this.btn_THOAT.TabIndex = 9;
            this.btn_THOAT.Text = "&Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // txt_DENNGAY
            // 
            this.txt_DENNGAY.Location = new System.Drawing.Point(400, 22);
            this.txt_DENNGAY.Mask = "00/00/0000";
            this.txt_DENNGAY.Name = "txt_DENNGAY";
            this.txt_DENNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DENNGAY.Size = new System.Drawing.Size(86, 20);
            this.txt_DENNGAY.TabIndex = 1;
            this.txt_DENNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 176;
            this.label1.Text = "Đến ngày";
            // 
            // txt_TUNGAY
            // 
            this.txt_TUNGAY.Location = new System.Drawing.Point(89, 22);
            this.txt_TUNGAY.Mask = "00/00/0000";
            this.txt_TUNGAY.Name = "txt_TUNGAY";
            this.txt_TUNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TUNGAY.Size = new System.Drawing.Size(86, 20);
            this.txt_TUNGAY.TabIndex = 0;
            this.txt_TUNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 175;
            this.label3.Text = "Từ ngày";
            // 
            // txt_MADON
            // 
            this.txt_MADON.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MADON.BannerText = null;
            this.txt_MADON.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MADON.FormNametoShow = "";
            this.txt_MADON.Is_DateTime = false;
            this.txt_MADON.IsShowForm = false;
            this.txt_MADON.Location = new System.Drawing.Point(89, 53);
            this.txt_MADON.Name = "txt_MADON";
            this.txt_MADON.Regular_Expression = null;
            this.txt_MADON.Size = new System.Drawing.Size(86, 20);
            this.txt_MADON.TabIndex = 2;
            this.txt_MADON.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MADON_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 57);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 179;
            this.label22.Text = "Đơn hàng";
            // 
            // txt_MASANPHAM
            // 
            this.txt_MASANPHAM.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MASANPHAM.BannerText = null;
            this.txt_MASANPHAM.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MASANPHAM.FormNametoShow = "";
            this.txt_MASANPHAM.Is_DateTime = false;
            this.txt_MASANPHAM.IsShowForm = false;
            this.txt_MASANPHAM.Location = new System.Drawing.Point(89, 115);
            this.txt_MASANPHAM.Name = "txt_MASANPHAM";
            this.txt_MASANPHAM.Regular_Expression = null;
            this.txt_MASANPHAM.Size = new System.Drawing.Size(86, 20);
            this.txt_MASANPHAM.TabIndex = 6;
            this.txt_MASANPHAM.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MATHANG_Validating);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(24, 119);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 238;
            this.label25.Text = "Sản phẩm";
            // 
            // txt_TENSANPHAM
            // 
            this.txt_TENSANPHAM.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENSANPHAM.BannerText = null;
            this.txt_TENSANPHAM.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENSANPHAM.FormNametoShow = "";
            this.txt_TENSANPHAM.Is_DateTime = false;
            this.txt_TENSANPHAM.IsShowForm = false;
            this.txt_TENSANPHAM.Location = new System.Drawing.Point(181, 115);
            this.txt_TENSANPHAM.Name = "txt_TENSANPHAM";
            this.txt_TENSANPHAM.ReadOnly = true;
            this.txt_TENSANPHAM.Regular_Expression = null;
            this.txt_TENSANPHAM.Size = new System.Drawing.Size(305, 20);
            this.txt_TENSANPHAM.TabIndex = 7;
            this.txt_TENSANPHAM.TabStop = false;
            // 
            // txt_TENKHACH
            // 
            this.txt_TENKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKHACH.BannerText = null;
            this.txt_TENKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENKHACH.FormNametoShow = "";
            this.txt_TENKHACH.Is_DateTime = false;
            this.txt_TENKHACH.IsShowForm = false;
            this.txt_TENKHACH.Location = new System.Drawing.Point(181, 84);
            this.txt_TENKHACH.Name = "txt_TENKHACH";
            this.txt_TENKHACH.ReadOnly = true;
            this.txt_TENKHACH.Regular_Expression = null;
            this.txt_TENKHACH.Size = new System.Drawing.Size(305, 20);
            this.txt_TENKHACH.TabIndex = 5;
            this.txt_TENKHACH.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 236;
            this.label15.Text = "Khách hàng";
            // 
            // txt_MAKHACH
            // 
            this.txt_MAKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKHACH.BannerText = null;
            this.txt_MAKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAKHACH.FormNametoShow = "";
            this.txt_MAKHACH.Is_DateTime = false;
            this.txt_MAKHACH.IsShowForm = false;
            this.txt_MAKHACH.Location = new System.Drawing.Point(89, 84);
            this.txt_MAKHACH.Name = "txt_MAKHACH";
            this.txt_MAKHACH.Regular_Expression = null;
            this.txt_MAKHACH.Size = new System.Drawing.Size(86, 20);
            this.txt_MAKHACH.TabIndex = 4;
            this.txt_MAKHACH.TabStop = false;
            this.txt_MAKHACH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAKHACH_Validating);
            // 
            // txt_NGAYDAT
            // 
            this.txt_NGAYDAT.Location = new System.Drawing.Point(400, 53);
            this.txt_NGAYDAT.Mask = "00/00/0000";
            this.txt_NGAYDAT.Name = "txt_NGAYDAT";
            this.txt_NGAYDAT.ReadOnly = true;
            this.txt_NGAYDAT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NGAYDAT.Size = new System.Drawing.Size(86, 20);
            this.txt_NGAYDAT.TabIndex = 3;
            this.txt_NGAYDAT.TabStop = false;
            this.txt_NGAYDAT.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 240;
            this.label2.Text = "Ngày đặt";
            // 
            // FRM_BCNCMANG
            // 
            this.AcceptButton = this.btn_IN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(514, 219);
            this.Controls.Add(this.txt_NGAYDAT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MASANPHAM);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txt_TENSANPHAM);
            this.Controls.Add(this.txt_TENKHACH);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_MAKHACH);
            this.Controls.Add(this.txt_MADON);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_DENNGAY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TUNGAY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_IN);
            this.Controls.Add(this.btn_THOAT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_BCNCMANG";
            this.Text = "FRM_BCNCMANG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CONTROL.BUTTON btn_IN;
        private CONTROL.BUTTON btn_THOAT;
        private System.Windows.Forms.MaskedTextBox txt_DENNGAY;
        private CONTROL.LABEL label1;
        private System.Windows.Forms.MaskedTextBox txt_TUNGAY;
        private CONTROL.LABEL label3;
        private CONTROL.TEXTBOX txt_MADON;
        private CONTROL.LABEL label22;
        private CONTROL.TEXTBOX txt_MASANPHAM;
        private CONTROL.LABEL label25;
        private CONTROL.TEXTBOX txt_TENSANPHAM;
        private CONTROL.TEXTBOX txt_TENKHACH;
        private CONTROL.LABEL label15;
        private CONTROL.TEXTBOX txt_MAKHACH;
        private System.Windows.Forms.MaskedTextBox txt_NGAYDAT;
        private CONTROL.LABEL label2;
    }
}