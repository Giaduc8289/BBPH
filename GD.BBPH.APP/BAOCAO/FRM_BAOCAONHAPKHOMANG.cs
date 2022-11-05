﻿using System;
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
    public partial class FRM_BAOCAONHAPKHOMANG : FRM_DMPARENT
    {
        private DataTable DT_DMKHO = new DataTable(), DT_DMMANG = new DataTable(), DT_DMLYDONHAPXUAT = new DataTable();
        private DataRow _RowViewSelect = null;
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private string FUNCTION = "LOAD";
        public FRM_BAOCAONHAPKHOMANG()
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_NHAPMANG");
                        DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
                        DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
                        
                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
                        DT_DMMANG = LIB.SESSION_START.DT_DMMANG;
                        DT_DMLYDONHAPXUAT = LIB.SESSION_START.DT_DMLYDONHAPXUAT;

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
            string _Makho = "", _Mamang = "", _Malydo = "";
            DateTime _Tungay = new DateTime(), _Denngay = new DateTime();
            DataSet dsKetqua = new DataSet();

            try
            {
                #region Lay thong tin cac tham so
                _Tungay = Convert.ToDateTime(txt_TUNGAY.Text);
                _Denngay = Convert.ToDateTime(txt_DENNGAY.Text);
                _Makho = txt_MAKHO.Text.Trim();
                _Mamang = txt_MAMANG.Text.Trim();
                _Malydo = txt_MALYDO.Text.Trim();
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@Tungay", _Tungay);
                parameters[1] = new SqlParameter("@Denngay", _Denngay);
                parameters[2] = new SqlParameter("@Makho", _Makho);
                parameters[3] = new SqlParameter("@Malydo", _Malydo);
                parameters[4] = new SqlParameter("@Mamang", _Mamang);
                _DataAccessAdapter.CallRetrievalStoredProcedure("Baocaonhapkhomang", parameters, dsKetqua, 0);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Ketqua";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Thoigian");
                dtThamso.Columns.Add("Kho");
                dtThamso.Columns.Add("Lydo");
                dtThamso.Columns.Add("Mang");
                DataRow dr = dtThamso.NewRow();
                if (_Tungay == _Denngay)
                    dr["Thoigian"] = "Ngày " + _Tungay.ToString("dd/MM/yyyy");
                else
                    dr["Thoigian"] = "Từ ngày " + _Tungay.ToString("dd/MM/yyyy") + " Đến ngày " + _Denngay.ToString("dd/MM/yyyy");
                if (!string.IsNullOrEmpty(_Makho))
                    dr["Kho"] = txt_TENKHO.Text;
                if (!string.IsNullOrEmpty(_Malydo))
                    dr["Lydo"] = txt_LYDO.Text;
                if (!string.IsNullOrEmpty(_Mamang))
                    dr["Mang"] = txt_TENMANG.Text;
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\BAOCAONHAPKHOMANG.rdlc", "Ketqua", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validate
        private void txt_MAYKHO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENKHO.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAKHO.Text.Trim()) || DT_DMKHO == null || DT_DMKHO.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAKHO.Text.Trim().ToUpper();
            _RowViewSelect = checkmaMay(Str_MASIEUTHI, DT_DMKHO);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHO.xml",
                        DT_DMKHO, DmkhoFields.Makho.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHO.Text = _RowViewSelect[DmkhoFields.Makho.Name].ToString();
                txt_TENKHO.Text = _RowViewSelect[DmkhoFields.Tenkho.Name].ToString();
            }
            else
            {
                txt_TENKHO.Text = _RowViewSelect[DmkhoFields.Tenkho.Name].ToString();
            }
        }
        private DataRow checkmaMay(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhoFields.Makho.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MALYDO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_LYDO.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MALYDO.Text.Trim()) || DT_DMLYDONHAPXUAT == null || DT_DMLYDONHAPXUAT.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MALYDO.Text.Trim().ToUpper();
            _RowViewSelect = checkmaLydo(Str_MASIEUTHI, DT_DMLYDONHAPXUAT);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LYDONHAPXUAT.xml",
                        DT_DMLYDONHAPXUAT, DmlydonhapxuatFields.Malydo.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MALYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Malydo.Name].ToString();
                txt_LYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Tenlydo.Name].ToString();

            }
            else
            {
                txt_LYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Tenlydo.Name].ToString();
            }
        }
        private DataRow checkmaLydo(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmlydonhapxuatFields.Malydo.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MATHANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENMANG.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAMANG.Text.Trim()) || DT_DMMANG == null || DT_DMMANG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAMANG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaMang(Str_MASIEUTHI, DT_DMMANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml",
                        DT_DMMANG, DmmangFields.Mamang.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMANG.Text = _RowViewSelect[DmmangFields.Mamang.Name].ToString();
                txt_TENMANG.Text = _RowViewSelect[DmmangFields.Tenmang.Name].ToString();
            }
            else
            {
                txt_TENMANG.Text = _RowViewSelect[DmmangFields.Tenmang.Name].ToString();
            }
        }
        private DataRow checkmaMang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmmangFields.Mamang.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
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
