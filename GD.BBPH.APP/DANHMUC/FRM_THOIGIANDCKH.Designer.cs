namespace GD.BBPH.APP.DANHMUC
{
    partial class FRM_THOIGIANDCKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_THOIGIANDCKH));
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.btn_CHON = new GD.BBPH.CONTROL.BUTTON();
            this.btn_THOAT = new GD.BBPH.CONTROL.BUTTON();
            this.txt_TUNGAY = new System.Windows.Forms.MaskedTextBox();
            this.txt_DENNGAY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 162;
            this.label2.Text = "Từ ngày";
            // 
            // btn_CHON
            // 
            this.btn_CHON.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_CHON.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_CHON.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_CHON.Location = new System.Drawing.Point(111, 114);
            this.btn_CHON.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CHON.Name = "btn_CHON";
            this.btn_CHON.Size = new System.Drawing.Size(100, 28);
            this.btn_CHON.TabIndex = 2;
            this.btn_CHON.Text = "&Chọn";
            this.btn_CHON.UseVisualStyleBackColor = true;
            this.btn_CHON.Click += new System.EventHandler(this.btn_CHON_Click);
            // 
            // btn_THOAT
            // 
            this.btn_THOAT.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_THOAT.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_THOAT.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_THOAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_THOAT.Location = new System.Drawing.Point(219, 114);
            this.btn_THOAT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_THOAT.Name = "btn_THOAT";
            this.btn_THOAT.Size = new System.Drawing.Size(100, 28);
            this.btn_THOAT.TabIndex = 3;
            this.btn_THOAT.Text = "&Thoát";
            this.btn_THOAT.UseVisualStyleBackColor = true;
            this.btn_THOAT.Click += new System.EventHandler(this.btn_THOAT_Click);
            // 
            // txt_TUNGAY
            // 
            this.txt_TUNGAY.Location = new System.Drawing.Point(97, 42);
            this.txt_TUNGAY.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TUNGAY.Mask = "00/00/0000";
            this.txt_TUNGAY.Name = "txt_TUNGAY";
            this.txt_TUNGAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TUNGAY.Size = new System.Drawing.Size(97, 22);
            this.txt_TUNGAY.TabIndex = 0;
            this.txt_TUNGAY.ValidatingType = typeof(System.DateTime);
            // 
            // txt_DENNGAY
            // 
            this.txt_DENNGAY.Location = new System.Drawing.Point(299, 42);
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
            this.label1.Location = new System.Drawing.Point(226, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 164;
            this.label1.Text = "Đến ngày";
            // 
            // FRM_THOIGIANDCKH
            // 
            this.AcceptButton = this.btn_CHON;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_THOAT;
            this.ClientSize = new System.Drawing.Size(430, 176);
            this.Controls.Add(this.txt_DENNGAY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TUNGAY);
            this.Controls.Add(this.btn_CHON);
            this.Controls.Add(this.btn_THOAT);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_THOIGIANDCKH";
            this.Text = "Thời gian điều chỉnh KH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CONTROL.LABEL label2;
        private CONTROL.BUTTON btn_CHON;
        private CONTROL.BUTTON btn_THOAT;
        private System.Windows.Forms.MaskedTextBox txt_TUNGAY;
        private System.Windows.Forms.MaskedTextBox txt_DENNGAY;
        private CONTROL.LABEL label1;
    }
}