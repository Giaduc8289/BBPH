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
    public partial class FRM_BAOCAOTONSP : FRM_DMPARENT
    {
        private DataTable DT_DMKHO = new DataTable(), DT_DMHANG = new DataTable();
        private DataRow _RowViewSelect = null;
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private string FUNCTION = "LOAD";
        public FRM_BAOCAOTONSP()
        {
            InitializeComponent();
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THOAT, btn_THOAT.Name + ".xml");
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
                        //_MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_XUATSANPHAM");
                        DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
                        DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
                        
                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
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
            string _Makho = "", _Masanpham = "";
            DateTime _Tungay = new DateTime(), _Denngay = new DateTime();
            DataSet dsKetqua = new DataSet();

            try
            {
                #region Lay thong tin cac tham so
                _Denngay = Convert.ToDateTime(txt_DENNGAY.Text);
                _Makho = txt_MAKHO.Text.Trim();
                _Masanpham = txt_MAHANG.Text.Trim();
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@Ngay", _Denngay);
                parameters[1] = new SqlParameter("@Makho", _Makho);
                parameters[2] = new SqlParameter("@Masanpham", _Masanpham);
                _DataAccessAdapter.CallRetrievalStoredProcedure("Baocaotonkhosp", parameters, dsKetqua, 0);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Ketqua";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Thoigian");
                dtThamso.Columns.Add("Kho");
                dtThamso.Columns.Add("Sanpham");
                DataRow dr = dtThamso.NewRow();

                dr["Thoigian"] = "Tồn kho đến ngày " + _Denngay.ToString("dd/MM/yyyy");
                if (!string.IsNullOrEmpty(_Makho))
                    dr["Kho"] = txt_TENKHO.Text;
                if (!string.IsNullOrEmpty(_Masanpham))
                    dr["Sanpham"] = txt_MAHANG.Text;
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\BAOCAOTONKHOSP.rdlc", "Ketqua", this.Text, true).Show();
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
