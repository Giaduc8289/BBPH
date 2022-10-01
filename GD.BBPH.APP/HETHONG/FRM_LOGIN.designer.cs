namespace GD.BBPH.APP.HETHONG
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.txt_USERNAME = new GD.BBPH.CONTROL.TEXTBOX();
            this.label1 = new GD.BBPH.CONTROL.LABEL();
            this.txt_PASS = new GD.BBPH.CONTROL.TEXTBOX();
            this.label2 = new GD.BBPH.CONTROL.LABEL();
            this.label3 = new GD.BBPH.CONTROL.LABEL();
            this.btn_Thoat = new GD.BBPH.CONTROL.BUTTON();
            this.btnOK = new GD.BBPH.CONTROL.BUTTON();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblNameSoftware = new System.Windows.Forms.Label();
            this.txt_NGAYLAMVIEC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_USERNAME
            // 
            this.txt_USERNAME.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_USERNAME.BannerText = null;
            this.txt_USERNAME.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_USERNAME.FormNametoShow = "";
            this.txt_USERNAME.Is_DateTime = false;
            this.txt_USERNAME.IsShowForm = false;
            this.txt_USERNAME.Location = new System.Drawing.Point(123, 42);
            this.txt_USERNAME.Name = "txt_USERNAME";
            this.txt_USERNAME.Regular_Expression = null;
            this.txt_USERNAME.Size = new System.Drawing.Size(131, 20);
            this.txt_USERNAME.TabIndex = 0;
            this.txt_USERNAME.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txt_PASS
            // 
            this.txt_PASS.BannerFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PASS.BannerText = null;
            this.txt_PASS.FixedSingleLineColor = System.Drawing.Color.CadetBlue;
            this.txt_PASS.FormNametoShow = "";
            this.txt_PASS.Is_DateTime = false;
            this.txt_PASS.IsShowForm = false;
            this.txt_PASS.Location = new System.Drawing.Point(122, 68);
            this.txt_PASS.Name = "txt_PASS";
            this.txt_PASS.PasswordChar = '*';
            this.txt_PASS.Regular_Expression = null;
            this.txt_PASS.Size = new System.Drawing.Size(132, 20);
            this.txt_PASS.TabIndex = 1;
            this.txt_PASS.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày làm việc";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btn_Thoat.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btn_Thoat.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(238, 134);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(86, 29);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btnOK
            // 
            this.btnOK.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.btnOK.BtnShape = GD.BBPH.CONTROL.emunType.BtnShape.Rectangle;
            this.btnOK.BtnStyle = GD.BBPH.CONTROL.emunType.XPStyle.Default;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(121, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 29);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Đăng &nhập";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(3, 176);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 13);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "label4";
            // 
            // lblNameSoftware
            // 
            this.lblNameSoftware.AutoSize = true;
            this.lblNameSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSoftware.ForeColor = System.Drawing.Color.Black;
            this.lblNameSoftware.Location = new System.Drawing.Point(33, 9);
            this.lblNameSoftware.Name = "lblNameSoftware";
            this.lblNameSoftware.Size = new System.Drawing.Size(52, 18);
            this.lblNameSoftware.TabIndex = 8;
            this.lblNameSoftware.Text = "label4";
            // 
            // txt_NGAYLAMVIEC
            // 
            this.txt_NGAYLAMVIEC.Location = new System.Drawing.Point(122, 93);
            this.txt_NGAYLAMVIEC.Mask = "00/00/0000";
            this.txt_NGAYLAMVIEC.Name = "txt_NGAYLAMVIEC";
            this.txt_NGAYLAMVIEC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NGAYLAMVIEC.Size = new System.Drawing.Size(132, 20);
            this.txt_NGAYLAMVIEC.TabIndex = 2;
            this.txt_NGAYLAMVIEC.ValidatingType = typeof(System.DateTime);
            // 
            // FRM_LOGIN
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Thoat;
            this.ClientSize = new System.Drawing.Size(408, 198);
            this.Controls.Add(this.txt_NGAYLAMVIEC);
            this.Controls.Add(this.lblNameSoftware);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PASS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_USERNAME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_LOGIN";
            this.Text = "Đăng nhập hệ thống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD.BBPH.CONTROL.TEXTBOX txt_USERNAME;
        private GD.BBPH.CONTROL.LABEL label1;
        private GD.BBPH.CONTROL.TEXTBOX txt_PASS;
        private GD.BBPH.CONTROL.LABEL label2;
        private GD.BBPH.CONTROL.BUTTON btnOK;
        private GD.BBPH.CONTROL.BUTTON btn_Thoat;
        private GD.BBPH.CONTROL.LABEL label3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblNameSoftware;
        private System.Windows.Forms.MaskedTextBox txt_NGAYLAMVIEC;
    }
}