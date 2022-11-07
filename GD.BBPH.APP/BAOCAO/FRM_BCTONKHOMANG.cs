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
    public partial class FRM_BCTONKHOMANG : FRM_DMPARENT
    {
        private DataTable DT_DMMANG = new DataTable();

        public FRM_BCTONKHOMANG()
        {
            InitializeComponent();
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THOAT, btn_THOAT.Name + ".xml");
            txt_NGAYBAOCAO.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
            DT_DMMANG = new DmmangManager().SelectAllRDT();
        }

        private void btn_IN_Click(object sender, EventArgs e)
        {
            DateTime _Ngay = new DateTime();
            string _Mamang = "";
            DataSet dsKetqua = new DataSet();

            try
            {
                #region Lay thong tin cac tham so
                _Ngay = Convert.ToDateTime(txt_NGAYBAOCAO.Text);
                _Mamang = txt_MAMANG.Text;
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@Ngay", _Ngay);
                parameters[1] = new SqlParameter("@Mamang", _Mamang);
                _DataAccessAdapter.CallRetrievalStoredProcedure("Baocaotonkhomang", parameters, dsKetqua, 0);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Ketqua";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Thoigian");
                DataRow dr = dtThamso.NewRow();
                dr["Thoigian"] = "Ngày " + _Ngay.ToString("dd/MM/yyyy");
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\BAOCAOTONKHOMANG.rdlc", "Ketqua", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Validate
        private void txt_MAMANG_Validating(object sender, CancelEventArgs e)
        {
            DataRow _RowViewSelect = null;
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
                txt_TENMANG.Text = _RowViewSelect[DmmangFields.Tenmang.Name].ToString();
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
