﻿namespace GD.BBPH.APP.BAOCAO
{
    partial class FRM_BAOCAONHAPKHOSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BAOCAONHAPKHOSP));
            this.btn_IN = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THOAT = new GD.BBPH.CONTROL.BUTTON();
            this.txt_DENNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TUNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENKHO = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MAKHO = new GD.BBPH.CONTROL.TEXTBOX();
            this.label22 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MAHANG = new GD.BBPH.CONTROL.TEXTBOX();
            this.label25 = new GD.BBPH.CONTROL.LABEL();
            this.label5 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MASPKHACH = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MALYDO = new GD.BBPH.CONTROL.TEXTBOX();
            this.label15 = new GD.BBPH.CONTROL.LABEL();
            this.txt_LYDO = new GD.BBPH.CONTROL.TEXTBOX();
            this.SuspendLayout();
            // 
            // btn_IN
            // 
            this.btn_IN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_IN.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_IN.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_IN.Location = new System.Drawing.Point(117, 178);
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
            this.btn_THOAT.Location = new System.Drawing.Point(198, 178);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(75, 23);
            this.btn_THOAT.TabIndex = 9;
            this.btn_THOAT.Text = "&Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // txt_DENNGAY
            // 
            this.txt_DENNGAY.Location = new System.Drawing.Point(260, 22);
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
            this.label1.Location = new System.Drawing.Point(204, 24);
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
            this.label3.Location = new System.Drawing.Point(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 175;
            this.label3.Text = "Từ ngày";
            // 
            // txt_TENKHO
            // 
            this.txt_TENKHO.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKHO.BannerText = null;
            this.txt_TENKHO.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENKHO.FormNametoShow = "";
            this.txt_TENKHO.Is_DateTime = false;
            this.txt_TENKHO.IsShowForm = false;
            this.txt_TENKHO.Location = new System.Drawing.Point(181, 51);
            this.txt_TENKHO.Name = "txt_TENKHO";
            this.txt_TENKHO.ReadOnly = true;
            this.txt_TENKHO.Regular_Expression = null;
            this.txt_TENKHO.Size = new System.Drawing.Size(165, 20);
            this.txt_TENKHO.TabIndex = 3;
            this.txt_TENKHO.TabStop = false;
            // 
            // txt_MAKHO
            // 
            this.txt_MAKHO.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKHO.BannerText = null;
            this.txt_MAKHO.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAKHO.FormNametoShow = "";
            this.txt_MAKHO.Is_DateTime = false;
            this.txt_MAKHO.IsShowForm = false;
            this.txt_MAKHO.Location = new System.Drawing.Point(89, 51);
            this.txt_MAKHO.Name = "txt_MAKHO";
            this.txt_MAKHO.Regular_Expression = null;
            this.txt_MAKHO.Size = new System.Drawing.Size(86, 20);
            this.txt_MAKHO.TabIndex = 2;
            this.txt_MAKHO.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAYKHO_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(24, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 179;
            this.label22.Text = "Kho";
            // 
            // txt_MAHANG
            // 
            this.txt_MAHANG.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAHANG.BannerText = null;
            this.txt_MAHANG.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MAHANG.FormNametoShow = "";
            this.txt_MAHANG.Is_DateTime = false;
            this.txt_MAHANG.IsShowForm = false;
            this.txt_MAHANG.Location = new System.Drawing.Point(89, 86);
            this.txt_MAHANG.Name = "txt_MAHANG";
            this.txt_MAHANG.Regular_Expression = null;
            this.txt_MAHANG.Size = new System.Drawing.Size(86, 20);
            this.txt_MAHANG.TabIndex = 4;
            this.txt_MAHANG.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MATHANG_Validating);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(24, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 238;
            this.label25.Text = "Mã hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 237;
            this.label5.Text = "Mã của khách";
            // 
            // txt_MASPKHACH
            // 
            this.txt_MASPKHACH.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MASPKHACH.BannerText = null;
            this.txt_MASPKHACH.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MASPKHACH.FormNametoShow = "";
            this.txt_MASPKHACH.Is_DateTime = false;
            this.txt_MASPKHACH.IsShowForm = false;
            this.txt_MASPKHACH.Location = new System.Drawing.Point(260, 86);
            this.txt_MASPKHACH.Name = "txt_MASPKHACH";
            this.txt_MASPKHACH.ReadOnly = true;
            this.txt_MASPKHACH.Regular_Expression = null;
            this.txt_MASPKHACH.Size = new System.Drawing.Size(86, 20);
            this.txt_MASPKHACH.TabIndex = 5;
            this.txt_MASPKHACH.TabStop = false;
            // 
            // txt_MALYDO
            // 
            this.txt_MALYDO.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MALYDO.BannerText = null;
            this.txt_MALYDO.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MALYDO.FormNametoShow = "";
            this.txt_MALYDO.Is_DateTime = false;
            this.txt_MALYDO.IsShowForm = false;
            this.txt_MALYDO.Location = new System.Drawing.Point(89, 123);
            this.txt_MALYDO.Name = "txt_MALYDO";
            this.txt_MALYDO.Regular_Expression = null;
            this.txt_MALYDO.Size = new System.Drawing.Size(86, 20);
            this.txt_MALYDO.TabIndex = 6;
            this.txt_MALYDO.TabStop = false;
            this.txt_MALYDO.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MALYDO_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 236;
            this.label15.Text = "Lý do";
            // 
            // txt_LYDO
            // 
            this.txt_LYDO.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LYDO.BannerText = null;
            this.txt_LYDO.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_LYDO.FormNametoShow = "";
            this.txt_LYDO.Is_DateTime = false;
            this.txt_LYDO.IsShowForm = false;
            this.txt_LYDO.Location = new System.Drawing.Point(181, 123);
            this.txt_LYDO.Name = "txt_LYDO";
            this.txt_LYDO.ReadOnly = true;
            this.txt_LYDO.Regular_Expression = null;
            this.txt_LYDO.Size = new System.Drawing.Size(165, 20);
            this.txt_LYDO.TabIndex = 7;
            this.txt_LYDO.TabStop = false;
            // 
            // FRM_BAOCAONHAPKHOSP
            // 
            this.AcceptButton = this.btn_IN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(391, 219);
            this.Controls.Add(this.txt_MAHANG);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MASPKHACH);
            this.Controls.Add(this.txt_LYDO);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_MALYDO);
            this.Controls.Add(this.txt_TENKHO);
            this.Controls.Add(this.txt_MAKHO);
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
            this.Name = "FRM_BAOCAONHAPKHOSP";
            this.Text = "FRM_BAOCAONHAPKHOSP";
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
        private CONTROL.TEXTBOX txt_TENKHO;
        private CONTROL.TEXTBOX txt_MAKHO;
        private CONTROL.LABEL label22;
        private CONTROL.TEXTBOX txt_MAHANG;
        private CONTROL.LABEL label25;
        private CONTROL.LABEL label5;
        private CONTROL.TEXTBOX txt_MASPKHACH;
        private CONTROL.TEXTBOX txt_MALYDO;
        private CONTROL.LABEL label15;
        private CONTROL.TEXTBOX txt_LYDO;
    }
}