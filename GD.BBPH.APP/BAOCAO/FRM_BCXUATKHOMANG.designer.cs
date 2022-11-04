namespace GD.BBPH.APP.BAOCAO
{
    partial class FRM_BCXUATKHOMANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BCXUATKHOMANG));
            this.btn_IN = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THOAT = new GD.BBPH.CONTROL.BUTTON();
            this.txt_DENNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TUNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENMANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MAMANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.label10 = new GD.BBPH.CONTROL.LABEL();
            this.SuspendLayout();
            // 
            // btn_IN
            // 
            this.btn_IN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_IN.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_IN.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_IN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_IN.Location = new System.Drawing.Point(126, 133);
            this.btn_IN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_IN.Name = "btn_IN";
            this.btn_IN.Size = new System.Drawing.Size(100, 28);
            this.btn_IN.TabIndex = 6;
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
            this.btn_THOAT.Location = new System.Drawing.Point(234, 133);
            this.btn_THOAT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(100, 28);
            this.btn_THOAT.TabIndex = 7;
            this.btn_THOAT.Text = "&Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // txt_DENNGAY
            // 
            this.txt_DENNGAY.Location = new System.Drawing.Point(347, 20);
            this.txt_DENNGAY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DENNGAY.Mask = "00/00/0000";
            this.txt_DENNGAY.Name = "txt_DENNGAY";
            this.txt_DENNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DENNGAY.Size = new System.Drawing.Size(97, 22);
            this.txt_DENNGAY.TabIndex = 1;
            this.txt_DENNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 172;
            this.label1.Text = "Đến ngày";
            // 
            // txt_TUNGAY
            // 
            this.txt_TUNGAY.Location = new System.Drawing.Point(90, 22);
            this.txt_TUNGAY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TUNGAY.Mask = "00/00/0000";
            this.txt_TUNGAY.Name = "txt_TUNGAY";
            this.txt_TUNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TUNGAY.Size = new System.Drawing.Size(97, 22);
            this.txt_TUNGAY.TabIndex = 0;
            this.txt_TUNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 171;
            this.label3.Text = "Từ ngày";
            // 
            // txt_TENMANG
            // 
            this.txt_TENMANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENMANG.BannerText = null;
            this.txt_TENMANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENMANG.FormNametoShow = "";
            this.txt_TENMANG.Is_DateTime = false;
            this.txt_TENMANG.IsShowForm = false;
            this.txt_TENMANG.Location = new System.Drawing.Point(194, 56);
            this.txt_TENMANG.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TENMANG.Name = "txt_TENMANG";
            this.txt_TENMANG.ReadOnly = true;
            this.txt_TENMANG.Regular_Expression = null;
            this.txt_TENMANG.Size = new System.Drawing.Size(250, 22);
            this.txt_TENMANG.TabIndex = 3;
            this.txt_TENMANG.TabStop = false;
            // 
            // txt_MAMANG
            // 
            this.txt_MAMANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAMANG.BannerText = null;
            this.txt_MAMANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAMANG.FormNametoShow = "";
            this.txt_MAMANG.Is_DateTime = false;
            this.txt_MAMANG.IsShowForm = false;
            this.txt_MAMANG.Location = new System.Drawing.Point(90, 56);
            this.txt_MAMANG.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MAMANG.Name = "txt_MAMANG";
            this.txt_MAMANG.Regular_Expression = null;
            this.txt_MAMANG.Size = new System.Drawing.Size(96, 22);
            this.txt_MAMANG.TabIndex = 2;
            this.txt_MAMANG.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAMANG_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 175;
            this.label10.Text = "Loại màng";
            // 
            // FRM_BCXUATKHOMANG
            // 
            this.AcceptButton = this.btn_IN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(461, 181);
            this.Controls.Add(this.txt_TENMANG);
            this.Controls.Add(this.txt_MAMANG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_DENNGAY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TUNGAY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_IN);
            this.Controls.Add(this.btn_THOAT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_BCXUATKHOMANG";
            this.Text = "FRM_BCKHSXMANH";
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
        private CONTROL.TEXTBOX txt_TENMANG;
        private CONTROL.TEXTBOX txt_MAMANG;
        private CONTROL.LABEL label10;
    }
}