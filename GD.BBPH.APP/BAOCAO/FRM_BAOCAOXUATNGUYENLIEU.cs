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
    public partial class FRM_BAOCAOXUATNGUYENLIEU : FRM_DMPARENT
    {
        private DataTable DT_DMKHO = new DataTable(), DT_DMNGUYENLIEU = new DataTable(), DT_DMNHOMNGUYENLIEU = new DataTable();
        private DataRow _RowViewSelect = null;
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private string FUNCTION = "LOAD";
        public FRM_BAOCAOXUATNGUYENLIEU()
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_XUATNGUYENLIEU");
                        DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
                        DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
                        
                        DT_DMKHO = new DmkhoManager().SelectAllRDT();
                        DT_DMNGUYENLIEU = LIB.SESSION_START.DT_DMNGUYENLIEU;
                        DT_DMNHOMNGUYENLIEU = new DmnhomnguyenlieuManager().SelectAllRDT();

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
            string _Makho = "", _Manguyenlieu = "", _Manhomnguyenlieu = "";
            DateTime _Tungay = new DateTime(), _Denngay = new DateTime();
            DataSet dsKetqua = new DataSet();

            try
            {
                #region Lay thong tin cac tham so
                _Tungay = Convert.ToDateTime(txt_TUNGAY.Text);
                _Denngay = Convert.ToDateTime(txt_DENNGAY.Text);
                _Makho = txt_MAKHO.Text.Trim();
                _Manhomnguyenlieu = txt_MANHOMNL.Text.Trim();
                _Manguyenlieu = txt_MANGUYENLIEU.Text.Trim();
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@Tungay", _Tungay);
                parameters[1] = new SqlParameter("@Denngay", _Denngay);
                parameters[2] = new SqlParameter("@Makho", _Makho);
                parameters[3] = new SqlParameter("@Manguyenlieu", _Manhomnguyenlieu);
                parameters[4] = new SqlParameter("@Manhomnguyenlieu", _Manguyenlieu);
                _DataAccessAdapter.CallRetrievalStoredProcedure("Baocaoxuatnguyenlieu", parameters, dsKetqua, 0);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Ketqua";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Thoigian");
                dtThamso.Columns.Add("Kho");
                dtThamso.Columns.Add("Nguyenlieu");
                dtThamso.Columns.Add("Nhomnguyenlieu");
                DataRow dr = dtThamso.NewRow();
                if (_Tungay == _Denngay)
                    dr["Thoigian"] = "Ngày " + _Tungay.ToString("dd/MM/yyyy");
                else
                    dr["Thoigian"] = "Từ ngày " + _Tungay.ToString("dd/MM/yyyy") + " Đến ngày " + _Denngay.ToString("dd/MM/yyyy");
                if (!string.IsNullOrEmpty(_Makho))
                    dr["Kho"] = txt_TENKHO.Text;
                if (!string.IsNullOrEmpty(_Manhomnguyenlieu))
                    dr["Nhomnguyenlieu"] = txt_TENNHOMNL.Text;
                if (!string.IsNullOrEmpty(_Manhomnguyenlieu))
                    dr["Nguyenlieu"] = txt_TENNGUYENLIEU.Text;
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\BAOCAOXUATNGUYENLIEU.rdlc", "Ketqua", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validate
        private void txt_MAKHO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENKHO.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MAKHO.Text.Trim()) || DT_DMKHO == null || DT_DMKHO.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAKHO.Text.Trim().ToUpper();
            _RowViewSelect = checkmaMay(_str_MACANTIM, DT_DMKHO);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHO.xml",
                        DT_DMKHO, DmkhoFields.Makho.Name, _str_MACANTIM);
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
        private DataRow checkmaMay(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhoFields.Makho.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MANHOMNGUYENLIEU_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENNHOMNL.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MANHOMNL.Text.Trim()) || DT_DMNHOMNGUYENLIEU == null || DT_DMNHOMNGUYENLIEU.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MANHOMNL.Text.Trim().ToUpper();
            _RowViewSelect = checknhomnguyenlieu(_str_MACANTIM, DT_DMNHOMNGUYENLIEU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMNGUYENLIEU.xml",
                        DT_DMNHOMNGUYENLIEU, DmnhomnguyenlieuFields.Manhom.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MANHOMNL.Text = _RowViewSelect[DmnhomnguyenlieuFields.Manhom.Name].ToString();
                txt_TENNHOMNL.Text = _RowViewSelect[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();

            }
            else
            {
                txt_TENNHOMNL.Text = _RowViewSelect[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
            }
        }
        private DataRow checknhomnguyenlieu(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmnhomnguyenlieuFields.Manhom.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MANGUYENLIEU_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            txt_TENNGUYENLIEU.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MANGUYENLIEU.Text.Trim()) || DT_DMNGUYENLIEU == null || DT_DMNGUYENLIEU.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MANGUYENLIEU.Text.Trim().ToUpper();
            _RowViewSelect = checkmanguyenlieu(_str_MACANTIM, DT_DMNGUYENLIEU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU_H.xml",
                        DT_DMNGUYENLIEU, DmnguyenlieuFields.Manl.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MANGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Manl.Name].ToString();
                txt_TENNGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
            }
            else
            {
                txt_TENNGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
            }
        }
        private DataRow checkmanguyenlieu(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmnguyenlieuFields.Manl.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
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
