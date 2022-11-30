using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;
using Microsoft.Reporting.WinForms;
using GD.BBPH.APP.DANHMUC;
using GD.BBPH.LIB;

namespace GD.BBPH.APP.DANHMUC
{
    public partial class FRM_THOIGIANDCKH : FRM_DMPARENT
    {
        public string Tungay = "", Denngay = "";
        public DialogResult _DialogResult = DialogResult.No;

        public FRM_THOIGIANDCKH()
        {
            InitializeComponent();
            txt_TUNGAY.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
            txt_DENNGAY.Text = LIB.SESSION_START.TS_NGAYCUOITHANG.ToString("dd/MM/yyyy");
        }

        private void btn_CHON_Click(object sender, EventArgs e)
        {
            Tungay = txt_TUNGAY.Text;
            Denngay = txt_DENNGAY.Text;
            _DialogResult = DialogResult.Yes;
            this.Dispose();
        }

        private void btn_THOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
