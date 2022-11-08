namespace GD.BBPH.APP.BAOCAO
{
    partial class FRM_BAOCAOTONNGUYENLIEU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BAOCAOTONNGUYENLIEU));
            this.btn_IN = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THOAT = new GD.BBPH.CONTROL.BUTTON();
            this.txt_DENNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENKHO = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MAKHO = new GD.BBPH.CONTROL.TEXTBOX();
            this.label22 = new GD.BBPH.CONTROL.LABEL();
            this.txt_MANGUYENLIEU = new GD.BBPH.CONTROL.TEXTBOX();
            this.label25 = new GD.BBPH.CONTROL.LABEL();
            this.label5 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENNGUYENLIEU = new GD.BBPH.CONTROL.TEXTBOX();
            this.txt_MANHOMNL = new GD.BBPH.CONTROL.TEXTBOX();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.txt_TENNHOMNL = new GD.BBPH.CONTROL.TEXTBOX();
            this.SuspendLayout();
            // 
            // btn_IN
            // 
            this.btn_IN.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_IN.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_IN.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_IN.Location = new System.Drawing.Point(117, 169);
            this.btn_IN.Name = "btn_IN";
            this.btn_IN.Size = new System.Drawing.Size(75, 23);
            this.btn_IN.TabIndex = 7;
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
            this.btn_THOAT.Location = new System.Drawing.Point(198, 169);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(75, 23);
            this.btn_THOAT.TabIndex = 8;
            this.btn_THOAT.Text = "&Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // txt_DENNGAY
            // 
            this.txt_DENNGAY.Location = new System.Drawing.Point(108, 21);
            this.txt_DENNGAY.Mask = "00/00/0000";
            this.txt_DENNGAY.Name = "txt_DENNGAY";
            this.txt_DENNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DENNGAY.Size = new System.Drawing.Size(86, 20);
            this.txt_DENNGAY.TabIndex = 0;
            this.txt_DENNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 176;
            this.label1.Text = "Đến ngày";
            // 
            // txt_TENKHO
            // 
            this.txt_TENKHO.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKHO.BannerText = null;
            this.txt_TENKHO.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENKHO.FormNametoShow = "";
            this.txt_TENKHO.Is_DateTime = false;
            this.txt_TENKHO.IsShowForm = false;
            this.txt_TENKHO.Location = new System.Drawing.Point(200, 56);
            this.txt_TENKHO.Name = "txt_TENKHO";
            this.txt_TENKHO.ReadOnly = true;
            this.txt_TENKHO.Regular_Expression = null;
            this.txt_TENKHO.Size = new System.Drawing.Size(165, 20);
            this.txt_TENKHO.TabIndex = 2;
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
            this.txt_MAKHO.Location = new System.Drawing.Point(108, 56);
            this.txt_MAKHO.Name = "txt_MAKHO";
            this.txt_MAKHO.Regular_Expression = null;
            this.txt_MAKHO.Size = new System.Drawing.Size(86, 20);
            this.txt_MAKHO.TabIndex = 1;
            this.txt_MAKHO.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MAKHO_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 13);
            this.label22.TabIndex = 179;
            this.label22.Text = "Kho";
            // 
            // txt_MANGUYENLIEU
            // 
            this.txt_MANGUYENLIEU.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANGUYENLIEU.BannerText = null;
            this.txt_MANGUYENLIEU.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MANGUYENLIEU.FormNametoShow = "";
            this.txt_MANGUYENLIEU.Is_DateTime = false;
            this.txt_MANGUYENLIEU.IsShowForm = false;
            this.txt_MANGUYENLIEU.Location = new System.Drawing.Point(108, 120);
            this.txt_MANGUYENLIEU.Name = "txt_MANGUYENLIEU";
            this.txt_MANGUYENLIEU.Regular_Expression = null;
            this.txt_MANGUYENLIEU.Size = new System.Drawing.Size(86, 20);
            this.txt_MANGUYENLIEU.TabIndex = 5;
            this.txt_MANGUYENLIEU.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NGUYENLIEU_Validating);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 238;
            this.label25.Text = "Nguyên liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 237;
            // 
            // txt_TENNGUYENLIEU
            // 
            this.txt_TENNGUYENLIEU.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENNGUYENLIEU.BannerText = null;
            this.txt_TENNGUYENLIEU.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENNGUYENLIEU.FormNametoShow = "";
            this.txt_TENNGUYENLIEU.Is_DateTime = false;
            this.txt_TENNGUYENLIEU.IsShowForm = false;
            this.txt_TENNGUYENLIEU.Location = new System.Drawing.Point(200, 120);
            this.txt_TENNGUYENLIEU.Name = "txt_TENNGUYENLIEU";
            this.txt_TENNGUYENLIEU.ReadOnly = true;
            this.txt_TENNGUYENLIEU.Regular_Expression = null;
            this.txt_TENNGUYENLIEU.Size = new System.Drawing.Size(165, 20);
            this.txt_TENNGUYENLIEU.TabIndex = 6;
            this.txt_TENNGUYENLIEU.TabStop = false;
            // 
            // txt_MANHOMNL
            // 
            this.txt_MANHOMNL.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MANHOMNL.BannerText = null;
            this.txt_MANHOMNL.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_MANHOMNL.FormNametoShow = "";
            this.txt_MANHOMNL.Is_DateTime = false;
            this.txt_MANHOMNL.IsShowForm = false;
            this.txt_MANHOMNL.Location = new System.Drawing.Point(108, 89);
            this.txt_MANHOMNL.Name = "txt_MANHOMNL";
            this.txt_MANHOMNL.Regular_Expression = null;
            this.txt_MANHOMNL.Size = new System.Drawing.Size(86, 20);
            this.txt_MANHOMNL.TabIndex = 3;
            this.txt_MANHOMNL.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MANHOMNGUYENLIEU_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 242;
            this.label2.Text = "Nhóm nguyên liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 241;
            // 
            // txt_TENNHOMNL
            // 
            this.txt_TENNHOMNL.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENNHOMNL.BannerText = null;
            this.txt_TENNHOMNL.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_TENNHOMNL.FormNametoShow = "";
            this.txt_TENNHOMNL.Is_DateTime = false;
            this.txt_TENNHOMNL.IsShowForm = false;
            this.txt_TENNHOMNL.Location = new System.Drawing.Point(200, 89);
            this.txt_TENNHOMNL.Name = "txt_TENNHOMNL";
            this.txt_TENNHOMNL.ReadOnly = true;
            this.txt_TENNHOMNL.Regular_Expression = null;
            this.txt_TENNHOMNL.Size = new System.Drawing.Size(165, 20);
            this.txt_TENNHOMNL.TabIndex = 4;
            this.txt_TENNHOMNL.TabStop = false;
            // 
            // FRM_BAOCAOTONNGUYENLIEU
            // 
            this.AcceptButton = this.btn_IN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(391, 219);
            this.Controls.Add(this.txt_MANHOMNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TENNHOMNL);
            this.Controls.Add(this.txt_MANGUYENLIEU);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TENNGUYENLIEU);
            this.Controls.Add(this.txt_TENKHO);
            this.Controls.Add(this.txt_MAKHO);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_DENNGAY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_IN);
            this.Controls.Add(this.btn_THOAT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_BAOCAOTONNGUYENLIEU";
            this.Text = "FRM_BAOCAOTONNGUYENLIEU";
            this.Load += new System.EventHandler(this.FRM_BAOCAOTONNGUYENLIEU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CONTROL.BUTTON btn_IN;
        private CONTROL.BUTTON btn_THOAT;
        private System.Windows.Forms.MaskedTextBox txt_DENNGAY;
        private CONTROL.LABEL label1;
        private CONTROL.TEXTBOX txt_TENKHO;
        private CONTROL.TEXTBOX txt_MAKHO;
        private CONTROL.LABEL label22;
        private CONTROL.TEXTBOX txt_MANGUYENLIEU;
        private CONTROL.LABEL label25;
        private CONTROL.LABEL label5;
        private CONTROL.TEXTBOX txt_TENNGUYENLIEU;
        private CONTROL.TEXTBOX txt_MANHOMNL;
        private CONTROL.LABEL label2;
        private CONTROL.LABEL label3;
        private CONTROL.TEXTBOX txt_TENNHOMNL;
    }
}