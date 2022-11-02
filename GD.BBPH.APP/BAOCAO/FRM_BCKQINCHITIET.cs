using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;
using Microsoft.Reporting.WinForms;
using GD.BBPH.APP.DANHMUC;
using GD.BBPH.LIB;

namespace GD.BBPH.APP.BAOCAO
{
    public partial class FRM_BCKQINCHITIET : FRM_DMPARENT
    {
        private DataTable DT_DMMAY = new DataTable(), DT_DMKHACH = new DataTable(), DT_DMHANG = new DataTable();
        private DataRow _RowViewSelect = null;
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private string FUNCTION = "LOAD";
        public FRM_BCKQINCHITIET()
        {
            InitializeComponent();
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THOAT, btn_THOAT.Name + ".xml");
            txt_TUNGAY.Text = LIB.SESSION_START.TS_NGAYDAUTHANG.ToString("dd/MM/yyyy");
            txt_DENNGAY.Text = LIB.SESSION_START.TS_NGAYCUOITHANG.ToString("dd/MM/yyyy");
            FORM_PROCESS();
        }
        private void FORM_PROCESS()
        {
            using (System.Windows.Forms.Form f = new System.Windows.Forms.Form())
            using (PictureBox _PictureBox = new PictureBox())
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                Image _image = Image.FromFile(LIB.PATH.BBPH_PATH + @"\IMG\waiting.xml");
                _PictureBox.Image = _image;
                _PictureBox.Width = _image.Width;
                _PictureBox.Height = _image.Height;
                worker.DoWork += delegate
                {
                    if (FUNCTION == "LOAD")
                    {
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQIN");
                        DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
                        DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
                        
                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("IN");
                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
                        DT_DMHANG = LIB.SESSION_START.DM_HANG;
                    }
                };
                worker.RunWorkerCompleted += delegate
                {
                    f.Dispose();   // exit the modal dialog
                };
                f.Load += delegate
                {
                    worker.RunWorkerAsync();
                };
                Point a = new Point(10, 10);
                _PictureBox.Location = a;
                f.Controls.Add(_PictureBox);
                f.Text = "Chờ xử lý";
                f.ShowIcon = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowInTaskbar = false;
                f.ControlBox = false;
                //f.BackColor = Color.Blue;
                f.MaximumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.MinimumSize = new System.Drawing.Size(_PictureBox.Width + 20, _PictureBox.Height + 20);
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
            };
        }
        private void btn_IN_Click(object sender, EventArgs e)
        {
            string _Mamay = "", _Makhach = "", _Masanpham = "";
            DateTime _Tungay = new DateTime(), _Denngay = new DateTime();
            DataSet dsKetqua = new DataSet();

            try
            {
                #region Lay thong tin cac tham so
                _Tungay = Convert.ToDateTime(txt_TUNGAY.Text);
                _Denngay = Convert.ToDateTime(txt_DENNGAY.Text);
                _Mamay = txt_MAMAY.Text.Trim();
                _Makhach = txt_MAKHACH.Text.Trim();
                _Masanpham = txt_MAHANG.Text.Trim();
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@Tungay", _Tungay);
                parameters[1] = new SqlParameter("@Denngay", _Denngay);
                parameters[2] = new SqlParameter("@Mamay", _Mamay);
                parameters[3] = new SqlParameter("@Makhach", _Makhach);
                parameters[4] = new SqlParameter("@Masanpham", _Masanpham);
                _DataAccessAdapter.CallRetrievalStoredProcedure("Baocaoketquainchitiet", parameters, dsKetqua, 0);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Ketqua";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Thoigian");
                dtThamso.Columns.Add("Maymoc");
                dtThamso.Columns.Add("Khachhang");
                dtThamso.Columns.Add("Sanpham");
                DataRow dr = dtThamso.NewRow();
                if (_Tungay == _Denngay)
                    dr["Thoigian"] = "Ngày " + _Tungay.ToString("dd/MM/yyyy");
                else
                    dr["Thoigian"] = "Từ ngày " + _Tungay.ToString("dd/MM/yyyy") + " Đến ngày " + _Denngay.ToString("dd/MM/yyyy");
                if (!string.IsNullOrEmpty(_Mamay))
                    dr["Maymoc"] = txt_TENMAY.Text;
                if (!string.IsNullOrEmpty(_Makhach))
                    dr["Khachhang"] = txt_TENKHACH.Text;
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\KQINCHITIET.rdlc", "Ketqua", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validate
        private void txt_MAYIN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENMAY.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmaMay(Str_MASIEUTHI, DT_DMMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAY.xml",
                        DT_DMMAY, DmmayFields.Mamay.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMAY.Text = _RowViewSelect[DmmayFields.Mamay.Name].ToString();
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
            else
            {
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
        }
        private DataRow checkmaMay(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmmayFields.Mamay.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENKHACH.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAKHACH.Text.Trim()) || DT_DMKHACH == null || DT_DMKHACH.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKhach(Str_MASIEUTHI, DT_DMKHACH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
                        DT_DMKHACH, DmkhachFields.Makhach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHACH.Text = _RowViewSelect[DmkhachFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();

                DT_DMHANG = new DmhangManager().SelectByMakhachRDT(txt_MAKHACH.Text.Trim());
            }
            else
            {
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
                DT_DMHANG = new DmhangManager().SelectByMakhachRDT(txt_MAKHACH.Text.Trim());
            }
        }
        private DataRow checkmaKhach(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhachFields.Makhach.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MATHANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_MASPKHACH.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAHANG.Text.Trim()) || DT_DMHANG == null || DT_DMHANG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAHANG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaHang(Str_MASIEUTHI, DT_DMHANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMHANG, DmhangFields.Masp.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAHANG.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_MASPKHACH.Text = _RowViewSelect[DmhangFields.Maspcuakhach.Name].ToString();
            }
            else
            {
                txt_MASPKHACH.Text = _RowViewSelect[DmhangFields.Maspcuakhach.Name].ToString();
            }
        }
        private DataRow checkmaHang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmhangFields.Masp.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void btn_THOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
