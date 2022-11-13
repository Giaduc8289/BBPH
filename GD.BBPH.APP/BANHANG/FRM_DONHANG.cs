using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using GD.BBPH.LIB;
using Janus.Data;
using Janus.Windows.GridEX;
using Janus.Windows.Common;
using GD.BBPH.APP.DANHMUC;
using System.Data.SqlClient;

namespace GD.BBPH.APP.BANHANG
{
    public partial class FRM_DONHANG : FRM_DMPARENT
    {
        private DonhangHManager _DonhangHManager = new DonhangHManager();
        private DonhangHEntity _DonhangHEntity = new DonhangHEntity();
        private DonhangDManager _DonhangDManager = new DonhangDManager();
        private DonhangDEntity _DonhangDEntity = new DonhangDEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DONDATHANG_H = new DataTable(), DT_DONDATHANG_D = new DataTable(), DT_DONDATHANG_D_FILL = new DataTable();
        private BindingSource BS_DONDATHANG_H = new BindingSource(), BS_DONDATHANG_D = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DONHANG_H = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_DONHANG_D = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string SoPO = "", MAKHACHHANG = "", Masp = "", SOBAOGIA = "";

        private DataTable DT_DMKHACH = new DataTable(), DT_DMHANG = new DataTable(), DT_BAOGIA_H = new DataTable(), DT_BAOGIA_D = new DataTable(), DT_NHANVIEN = new DataTable();
        public DataTable DM_HANGCHON = new DataTable();

        private void TEXTBOX_Only_Control(bool _isbool, GD.BBPH.CONTROL.TEXTBOX _Textbox)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(!_isbool, uiPanel1Container, new List<Control>(new Control[] { _Textbox }));
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DONHANG");
                        DT_DONDATHANG_H = LIB.Procedures.Danhsachdonhang(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, SOBAOGIA, MAKHACHHANG, Masp);
                        DT_DONDATHANG_D = LIB.Procedures.Danhsachdonhangchitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, SOBAOGIA, MAKHACHHANG, Masp);
                        DT_DONDATHANG_D_FILL = DT_DONDATHANG_D.Clone();

                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
                        DT_DMHANG = LIB.SESSION_START.DM_HANG;
                        DT_BAOGIA_H = new BaogiaHManager().SelectAllRDT();
                        //DT_BAOGIA_D = LIB.SESSION_START.DT_BAOGIA_D;
                        DT_NHANVIEN = new DmcongnhanManager().SelectPhongbanChuanghi(new string[] {"KD"});//LIB.SESSION_START.DT_NHANVIEN;
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

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //  ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }

        public FRM_DONHANG()
        {
            InitializeComponent();
            DonhangHManager _DonhangHManager = new DonhangHManager();
            DataTable dt111 = _DonhangHManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONHANG_H.xml");
            dt111 = _DonhangDManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONHANG_D.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_TIMKIEM, btn_TIMKIEM.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LAMMOI, btn_LAMMOI.Name + ".xml");
            //GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_TIMKIEM, btn_TIMKIEM.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONHANG_H.xml", GRID_DONHANG_H, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONHANG_D.xml", GRID_DONHANG_D, pne_CHITIET);
            GRID_DONHANG_H.RootTable.SortKeys.Add(DonhangHFields.Ngaydat.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GRID_DONHANG_D.FilterMode = FilterMode.None;
            GRID_DONHANG_D.GroupByBoxVisible = false;
            //GRID_DONHANG_D.RootTable.Columns["Chungloai"].EditType = EditType.NoEdit;
            //GRID_DONHANG_D.RootTable.Columns["Mauin"].EditType = EditType.NoEdit;
            GRID_DONHANG_D.RootTable.Columns["Sobaogia"].EditType = EditType.NoEdit;
            GRID_DONHANG_D.RootTable.Columns["Dongia"].EditType = EditType.NoEdit;
            //GRID_DONHANG_D.RootTable.Groups.Add(GRID_DONHANG_D.Tables[0].Columns[DonhangDFields.Masp.Name]);
            FORM_PROCESS();
            GRID_DONHANG_D.COMBO_MULTICOLUMN(GRID_DONHANG_D, DonhangDFields.Masp.Name, DmhangFields.Tensp.Name, DmhangFields.Masp.Name, DmhangFields.Masp.Name, DT_DMHANG);
            GRID_DONHANG_D.CellEdited += GRID_DONHANG_D_CellEdited;
            GRID_DONHANG_D.RecordsDeleted += GRID_DONHANG_D_RecordsDeleted;
            GRID_DONHANG_D.RecordUpdated += GRID_DONHANG_D_RecordUpdated;
            GRID_DONHANG_D.DeletingRecord += GRID_DONHANG_D_DeletingRecord;
            GRID_DONHANG_D.Click += GRID_DONHANG_D_Click;
            DataView Source_View = new DataView(DT_DONDATHANG_H);
            BS_DONDATHANG_H = new BindingSource();
            BS_DONDATHANG_H.DataSource = Source_View;
            GRID_DONHANG_H.DataSource = BS_DONDATHANG_H;
            BS_DONDATHANG_H.CurrentChanged += new EventHandler(BS_DONDATHANG_H_CurrentChanged);
            BS_DONDATHANG_H_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_DIEUCHINH.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid Detail
        private void GRID_DONHANG_D_RecordUpdated(object sender, EventArgs e)
        {

        }
        private void GRID_DONHANG_D_RecordsDeleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        private void GRID_DONHANG_D_CellEdited(object sender, ColumnActionEventArgs e)
        {
            //// Binding báo giá từ form báo giá
            //if (e.Column.DataMember == DonhangDFields.Sobaogiadieuchinh.Name)
            //{
            //    _RowViewSelect = null;
            //    string strSobaogiadc = GRID_DONHANG_D.CurrentRow.Cells[DonhangDFields.Sobaogiadieuchinh.Name].Value.ToString();
            //    string strMasp = GRID_DONHANG_D.CurrentRow.Cells[DonhangDFields.Masp.Name].Value.ToString();
            //    DataTable dtBaogiaH = LIB.Procedures.Danhsachbaogia(LIB.SESSION_START.TS_NGAYDAUTHANG.AddMonths(-2), LIB.SESSION_START.TS_NGAYCUOITHANG, "", txt_MAKHACH.Text, strMasp);
            //    if (string.IsNullOrEmpty(strSobaogiadc.Trim()) || dtBaogiaH == null || dtBaogiaH.Rows.Count == 0) return;
            //    string _str_MACANTIM = strSobaogiadc.ToUpper();
            //    _RowViewSelect = checkmaBaogia(_str_MACANTIM, dtBaogiaH);
            //    if (_RowViewSelect == null)
            //    {
            //        ListviewJanus _frm_SingerRows_Select =
            //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_BAOGIA_H.xml",
            //                dtBaogiaH, BaogiaHFields.Sobaogia.Name, _str_MACANTIM);
            //        _frm_SingerRows_Select.ShowDialog();
            //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
            //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
            //        strSobaogiadc = _RowViewSelect[BaogiaHFields.Sobaogia.Name].ToString();
            //        GRID_DONHANG_D.CurrentRow.Cells[DonhangDFields.Sobaogiadieuchinh.Name].Value = strSobaogiadc;
            //        DataTable dtBaogiaD = LIB.Procedures.Danhsachbaogiachitiet(LIB.SESSION_START.TS_NGAYDAUTHANG.AddMonths(-2), LIB.SESSION_START.TS_NGAYCUOITHANG, strSobaogiadc, txt_MAKHACH.Text, strMasp);
            //        if (dtBaogiaD.Rows.Count > 0)
            //            GRID_DONHANG_D.CurrentRow.Cells[DonhangDFields.Dongiadieuchinh.Name].Value = Convert.ToDecimal(dtBaogiaD.Rows[0][BaogiaDFields.Dongiatongcovat.Name].ToString());
            //    }
            //    else
            //    {
            //        DataTable dtBaogiaD = LIB.Procedures.Danhsachbaogiachitiet(LIB.SESSION_START.TS_NGAYDAUTHANG.AddMonths(-2), LIB.SESSION_START.TS_NGAYCUOITHANG, strSobaogiadc, txt_MAKHACH.Text, strMasp);
            //        if (dtBaogiaD.Rows.Count > 0)
            //            GRID_DONHANG_D.CurrentRow.Cells[DonhangDFields.Dongiadieuchinh.Name].Value = Convert.ToDecimal(dtBaogiaD.Rows[0][BaogiaDFields.Dongiatongcovat.Name].ToString());
            //    }
            //}
        }
        private void GRID_DONHANG_D_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            //throw new NotImplementedException();
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        private void GRID_DONHANG_D_Click(object sender, EventArgs e)
        {
            //int _Tongsoluong = 0;

            //for (int i = 0; i < DT_DONDATHANG_D.Rows.Count; i++)
            //{
            //    try { _Tongsoluong += Convert.ToInt32(DT_DONDATHANG_D.Rows[i][DonhangDFields.Soluong.Name]); }
            //    catch { }               
            //}

            //txt_TONGSOLUONG.Text = _Tongsoluong.ToString();
        }
        #endregion

        void BS_DONDATHANG_H_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                // GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DONHANG_H.UpdateData();
                if (BS_DONDATHANG_H.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DONDATHANG_H.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DonhangHFields.Madon.Name].ToString();

                    txt_MADONDATHANG.Text = _Rowview.Row[DonhangHFields.Madon.Name].ToString();
                    txt_NGAYDAT.Text = _Rowview.Row[DonhangHFields.Ngaydat.Name].ToString();
                    //txt_SOPO.Text = _Rowview.Row[DonhangHFields.Sopo.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[DonhangHFields.Makhach.Name].ToString();
                    txt_SOBAOGIA.Text = _Rowview.Row[DonhangHFields.Sobaogia.Name].ToString();
                    txt_MANHANVIEN.Text = _Rowview.Row[DonhangHFields.Userid.Name].ToString();
                    txt_GHICHU.Text = _Rowview.Row[DonhangHFields.Ghichu.Name].ToString();

                    txt_MAKHACH_Validating(new object(), new CancelEventArgs());
                    txt_SOBAOGIA_Validating(new object(), new CancelEventArgs());
                    txt_MANHANVIEN_Validating(new object(), new CancelEventArgs());
                    SHOWGRID(MAHIEU_PK);

                    #region Load grid
                    //try
                    //{
                    //    DataRow[] drArr = DT_DONDATHANG_D.Select(DonhangHFields.Madon.Name + "='" + MAHIEU_PK + "'");
                    //    if (drArr.Length != 0)
                    //    {
                    //        DT_DONDATHANG_D_FILL = drArr.CopyToDataTable();
                    //    }
                    //    else DT_DONDATHANG_D_FILL.Clear();
                    //    GRID_DONHANG_D.DataSource = DT_DONDATHANG_D_FILL;
                    //}
                    //catch (Exception ex) { }
                    #endregion
                }
                else
                    SHOWGRID("");
            }
            catch
            { }
        }

        void BS_DONDATHANG_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_DONDATHANG_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DONDATHANG_D.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[DonhangDFields.Id.Name].ToString();
                }
                //else
                //{
                //    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                //}
            }
            catch
            { }
        }
        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_DONDATHANG_D_FILL = new DonhangDManager().Clone();
                BS_DONDATHANG_D = new BindingSource(DT_DONDATHANG_D_FILL, null);
                GRID_DONHANG_D.DataSource = BS_DONDATHANG_D;
            }
            else
            {
                DT_DONDATHANG_D_FILL = LIB.Procedures.Danhsachdonhangchitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, SOBAOGIA, /*SoPO,*/ MAKHACHHANG, Masp);

                DataView Source_View = new DataView(DT_DONDATHANG_D_FILL);
                BS_DONDATHANG_D = new BindingSource();
                BS_DONDATHANG_D.DataSource = Source_View;
                GRID_DONHANG_D.DataSource = BS_DONDATHANG_D;
            }
            BS_DONDATHANG_D.CurrentChanged += new EventHandler(BS_DONDATHANG_D_CurrentChanged);
            BS_DONDATHANG_D_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataTable DT_BAOGIA_D = new DataTable();
            string strSobaogia = txt_SOBAOGIA.Text.ToString();
            if(string.IsNullOrEmpty(strSobaogia))
            {
                MessageBox.Show("Yêu cầu nhập số báo giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOBAOGIA.Focus();
                return;
            }
            DT_BAOGIA_D = LIB.Procedures.Danhsachbaogiachon(strSobaogia);//.Select(DmhangFields.Makhach.Name + "='"+txt_MAKHACH.Text.Trim()+"'").CopyToDataTable();
            DT_BAOGIA_D.Columns.Add("Time");
            ListviewJanusC _frm_MultiRows_Select =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_BAOGIA_D_CHON.xml", DT_BAOGIA_D, BaogiaDFields.Sobaogia.Name, string.Empty);
            _frm_MultiRows_Select.ShowDialog();
            if (_frm_MultiRows_Select._RowsViewSelect == null) return;

            DataTable dt = new DataTable(); dt = DT_BAOGIA_D.Clone();
            foreach (DataRowView drv in _frm_MultiRows_Select._RowsViewSelect)
            {
                DataRow dr = dt.NewRow();
                dr.ItemArray = drv.Row.ItemArray;
                dt.Rows.Add(dr);
            }
            DataRow[] arrDr = dt.Select("", "Time");
            foreach(DataRow dr in arrDr)
            {
                DataRow r_Detail = DT_DONDATHANG_D_FILL.NewRow();
                //r_Detail[DonhangDFields.Loaihang.Name] = dr[BaogiaDFields.Loaihang.Name].ToString();
                r_Detail[DonhangDFields.Masp.Name] = dr[BaogiaDFields.Masp.Name].ToString();
                r_Detail[DonhangDFields.Tenhang.Name] = dr[BaogiaDFields.Tensp.Name].ToString();
                //r_Detail[DonhangDFields.Soluong.Name] = dr[BaogiaDFields..Name].ToString();
                //r_Detail[DonhangDFields.Mauin.Name] = dr[DmhangFields.Mauin.Name].ToString();
                //r_Detail[DonhangDFields.Loai.Name] = dr[DmhangFields.Loai.Name].ToString();
                //try
                //{
                //    if (!string.IsNullOrEmpty(dr[DmhangFields.Ngaymarket.Name].ToString()))
                //        r_Detail[DonhangDFields.Ghichu.Name] = "Mk " + Convert.ToDateTime(dr[DmhangFields.Ngaymarket.Name].ToString()).ToString("dd/MM/yy");
                //}
                //catch { }
                try { r_Detail[DonhangDFields.Dongia.Name] = LIB.ConvertString.NumbertoDB(dr[BaogiaDFields.DongiaVat.Name].ToString()); }
                catch { }
                r_Detail[DonhangDFields.Sobaogia.Name] = dr[BaogiaDFields.Sobaogia.Name].ToString();

                DT_DONDATHANG_D_FILL.Rows.Add(r_Detail);
            }

            DataView Source_View = new DataView(DT_DONDATHANG_D_FILL);
            BS_DONDATHANG_D = new BindingSource();
            BS_DONDATHANG_D.DataSource = Source_View;
            GRID_DONHANG_D.DataSource = BS_DONDATHANG_D;
            BS_DONDATHANG_D.Position = DT_DONDATHANG_D_FILL.Rows.Count;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_DONHANG_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[DonhangDFields.Id.Name].ToString();
            string _Masp = _view[DonhangDFields.Masp.Name].ToString();
            if (new PhieugiaohangDManager().SelectByDonchitietIdRDT(Convert.ToInt64(_MAHIEU_PK)).Rows.Count > 0)
            {
                MessageBox.Show("Đã sử dụng trong phiếu xuất hàng bán." + '\n' + "Không thể xóa hàng " + _Masp + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _Masp, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_DONHANG_D.CurrentRow.Delete();
            }
            else
            {
                DonhangDManager _DonhangDManager = new DonhangDManager();
                DonhangDEntity _DonhangDEntity = new DonhangDEntity();
                try { _DonhangDEntity = _DonhangDManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_DonhangDEntity != null && MessageBox.Show("Xóa dòng: " + _Masp, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _DonhangDManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_DONDATHANG_D_FILL.Select(DonhangDFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_DONDATHANG_D_FILL.Rows.Remove(drArr[0]);
                        //GRID_DONHANG_D.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_DonhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _Masp + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_DONDATHANG_D.ResetCurrentItem();
                    GRID_DONHANG_D.DataSource = BS_DONDATHANG_D;
                }
                GRID_DONHANG_D.Enabled = true;
            }
        }
        private void btn_DIEUCHINH_Click(object sender, EventArgs e)
        {
            //DataRowView _view = (DataRowView)GRID_DONHANG_D.CurrentRow.DataRow;

            ////------Lấy thông tin lần điều chỉnh cuối cùng của mã hàng
            //DataRow[] drArr = DT_DONDATHANG_D_FILL.Select(DonhangDFields.Masp.Name + "='" + _view.Row[DonhangDFields.Masp.Name].ToString() + "'", DonhangDFields.Iddieuchinhtruoc.Name + " Desc");
            //if (drArr.Length == 0) return;

            //DataRow r_Detail = DT_DONDATHANG_D_FILL.NewRow();
            //r_Detail[DonhangDFields.Madon.Name] = _view.Row[DonhangDFields.Madon.Name].ToString();
            //r_Detail[DonhangDFields.Masp.Name] = _view.Row[DonhangDFields.Masp.Name].ToString();
            ////r_Detail[DonhangDFields.Tenhang.Name] = _view.Row[DonhangDFields.Tenhang.Name].ToString();
            //r_Detail[DonhangDFields.Chungloai.Name] = _view.Row[DonhangDFields.Chungloai.Name].ToString();
            //r_Detail[DonhangDFields.Mauin.Name] = _view.Row[DonhangDFields.Mauin.Name].ToString();
            //r_Detail[DonhangDFields.Loai.Name] = _view.Row[DonhangDFields.Loai.Name].ToString();
            //r_Detail[DonhangDFields.Makhach.Name] = _view.Row[DonhangDFields.Makhach.Name].ToString();
            //r_Detail[DonhangDFields.Sopo.Name] = _view.Row[DonhangDFields.Sopo.Name].ToString();

            //try { r_Detail[DonhangDFields.Ngaydat.Name] = Convert.ToDateTime(drArr[0][DonhangDFields.Ngaydat.Name].ToString()); }
            //catch { }
            //try { r_Detail[DonhangDFields.Iddieuchinhtruoc.Name] = Convert.ToInt64(drArr[0][DonhangDFields.Id.Name].ToString()); }
            //catch { }
            //r_Detail[DonhangDFields.Sobaogia.Name] = string.IsNullOrEmpty(drArr[0][DonhangDFields.Sobaogiadieuchinh.Name].ToString()) ?
            //    drArr[0][DonhangDFields.Sobaogia.Name].ToString() : drArr[0][DonhangDFields.Sobaogiadieuchinh.Name].ToString();
            //try
            //{
            //    r_Detail[DonhangDFields.Dongia.Name] = string.IsNullOrEmpty(drArr[0][DonhangDFields.Dongiadieuchinh.Name].ToString()) ?
            //  LIB.ConvertString.NumbertoDB(drArr[0][DonhangDFields.Dongia.Name].ToString()) : LIB.ConvertString.NumbertoDB(drArr[0][DonhangDFields.Dongiadieuchinh.Name].ToString());
            //}
            //catch { }
            //try
            //{
            //    r_Detail[DonhangDFields.Soluong.Name] = string.IsNullOrEmpty(drArr[0][DonhangDFields.Soluongdieuchinh.Name].ToString()) ?
            //  LIB.ConvertString.NumbertoDB(drArr[0][DonhangDFields.Soluong.Name].ToString()) : LIB.ConvertString.NumbertoDB(drArr[0][DonhangDFields.Soluongdieuchinh.Name].ToString());
            //}
            //catch { }
            //try
            //{
            //    r_Detail[DonhangDFields.Ngaygiao.Name] = string.IsNullOrEmpty(drArr[0][DonhangDFields.Ngaygiaodieuchinh.Name].ToString()) ?
            //  Convert.ToDateTime(drArr[0][DonhangDFields.Ngaygiao.Name].ToString()) : Convert.ToDateTime(drArr[0][DonhangDFields.Ngaygiaodieuchinh.Name].ToString());
            //}
            //catch { }
            //try
            //{
            //    r_Detail[DonhangDFields.Ngayhethanpo.Name] = Convert.ToDateTime(drArr[0][DonhangDFields.Ngayhethanpo.Name].ToString());
            //}
            //catch { }
            //try
            //{
            //    r_Detail[DonhangDFields.Ngaymarket.Name] = Convert.ToDateTime(drArr[0][DonhangDFields.Ngaymarket.Name].ToString());
            //}
            //catch { }

            //r_Detail[DonhangDFields.Ngaydieuchinh.Name] = DateTime.Now.ToString("dd/MM/yyyy");

            //DT_DONDATHANG_D_FILL.Rows.Add(r_Detail);

            //DataView Source_View = new DataView(DT_DONDATHANG_D_FILL);
            //BS_DONDATHANG_D = new BindingSource();
            //BS_DONDATHANG_D.DataSource = Source_View;
            //GRID_DONHANG_D.DataSource = BS_DONDATHANG_D;
            //BS_DONDATHANG_D.Position = DT_DONDATHANG_D_FILL.Rows.Count;
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DonhangHEntity _DonhangHEntity = new DonhangHEntity();
            _DonhangHEntity.Madon = txt_MADONDATHANG.Text.Trim();
            try { _DonhangHEntity.Ngaydat = Convert.ToDateTime(txt_NGAYDAT.Text.Trim()); }
            catch { }
            //_DonhangHEntity.Sopo = txt_SOPO.Text.Trim();
            _DonhangHEntity.Makhach = txt_MAKHACH.Text.Trim();
            _DonhangHEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            _DonhangHEntity.Sobaogia = txt_SOBAOGIA.Text.Trim();
            try { _DonhangHEntity.Ngaybaogia = Convert.ToDateTime(txt_NGAYBAOGIA.Text.Trim()); }
            catch { }
            _DonhangHEntity.Userid = txt_MANHANVIEN.Text.Trim();
            _DonhangHEntity.Tennv = txt_HOTEN.Text.Trim();
            _DonhangHEntity.Ghichu = txt_GHICHU.Text.Trim();

            EntityCollection _DonhangDEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_DONHANG_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                DonhangDEntity _DonhangDEntity = new DonhangDEntity();
                _DonhangDEntity.Madon = _DonhangHEntity.Madon;
                _DonhangDEntity.Ngaydat = _DonhangHEntity.Ngaydat;
                //_DonhangDEntity.Sopo = _view[DonhangDFields.Sopo.Name].ToString(); //_DonhangHEntity.Sopo;
                _DonhangDEntity.Makhach = _DonhangHEntity.Makhach;
                try { _DonhangDEntity.Loaihang = Convert.ToInt32(_view[DonhangDFields.Loaihang.Name].ToString()); }
                catch { }
                _DonhangDEntity.Masp = _view[DonhangDFields.Masp.Name].ToString();
                _DonhangDEntity.Tenhang = _view[DonhangDFields.Tenhang.Name].ToString();
                //_DonhangDEntity.Chungloai = _view[DonhangDFields.Chungloai.Name].ToString();
                //_DonhangDEntity.Mauin = _view[DonhangDFields.Mauin.Name].ToString();
                //_DonhangDEntity.Loai = _view[DonhangDFields.Loai.Name].ToString();
                _DonhangDEntity.Sobaogia = _view[DonhangDFields.Sobaogia.Name].ToString();
                try { _DonhangDEntity.Soluong = Convert.ToInt32(_view[DonhangDFields.Soluong.Name].ToString()); }
                catch { }
                try { _DonhangDEntity.Dongia = Convert.ToDecimal(_view[DonhangDFields.Dongia.Name].ToString()); }
                catch { }
                try { _DonhangDEntity.Ngaygiao = Convert.ToDateTime(_view[DonhangDFields.Ngaygiao.Name].ToString()); }
                catch { }
                _DonhangDEntity.Ghichu = _view[DonhangDFields.Ghichu.Name].ToString();

                try { _DonhangDEntity.Id = Convert.ToInt64(_view[DonhangDFields.Id.Name].ToString()); }
                catch { }

                _DonhangDEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_DonhangDEntity.IsNew)
                {
                    EntityCollection drDHCT = (new DonhangDManager()).SelectById(_DonhangDEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _DonhangDEntity.Ngaysua = DateTime.Now;
                        _DonhangDEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _DonhangDEntity.IsNew = false;
                    }
                    else
                    {
                        _DonhangDEntity.Ngaytao = DateTime.Now;
                        _DonhangDEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if(!string.IsNullOrEmpty(_DonhangDEntity.Masp))
                    _DonhangDEntityCol.Add(_DonhangDEntity);
            }

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DonhangHEntity.Ngaytao = DateTime.Now;
                _DonhangHEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DonhangHManager.InsertV2(_DonhangHEntity, r_Insert, DT_DONDATHANG_H, BS_DONDATHANG_H);
                _DonhangDManager.InsertCollection(_DonhangDEntityCol);
                GRID_DONHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DONHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DONHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_DonhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_DIEUCHINH.Enabled = false;
                BS_DONDATHANG_H.ResetCurrentItem();
                BS_DONDATHANG_H_CurrentChanged(new object(), new EventArgs());
                //BS_DONDATHANG_H.Position = DT_DONDATHANG_H.Rows.Count - 1;
            }
            else
            {
                _DonhangHEntity.Ngaysua = DateTime.Now;
                _DonhangHEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DonhangHManager.Update(_DonhangHEntity);
                foreach (DonhangDEntity _DonhangDEntity in _DonhangDEntityCol)
                {
                    if (_DonhangDEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_DONDATHANG_D.NewRow();
                        DT_DONDATHANG_D.Rows.Add(_r_Insert);
                        _DonhangDManager.InsertV2(_DonhangDEntity, _r_Insert, DT_DONDATHANG_D, BS_DONDATHANG_D);
                    }
                    else _DonhangDManager.Update(_DonhangDEntity);
                }
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Madon.Name].Value = _DonhangHEntity.Madon;
                //GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Sopo.Name].Value = _DonhangHEntity.Sopo;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Makhach.Name].Value = _DonhangHEntity.Makhach;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Tenkhach.Name].Value = _DonhangHEntity.Tenkhach;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Userid.Name].Value = _DonhangHEntity.Userid;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Tennv.Name].Value = _DonhangHEntity.Tennv;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Ngaydat.Name].Value = _DonhangHEntity.Ngaydat;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Sobaogia.Name].Value = _DonhangHEntity.Sobaogia;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Ngaybaogia.Name].Value = _DonhangHEntity.Ngaybaogia;
                GRID_DONHANG_H.CurrentRow.Cells[DonhangHFields.Ghichu.Name].Value = _DonhangHEntity.Ghichu;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_DonhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DONHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DONHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DONHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_DIEUCHINH.Enabled = false;
                BS_DONDATHANG_H.ResetCurrentItem();
                BS_DONDATHANG_H_CurrentChanged(new object(), new EventArgs());
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_MADONDATHANG.Text = txt_MAKHACH.Text = txt_TENKHACH.Text = txt_NGAYBAOGIA.Text = txt_HOTEN.Text = string.Empty;
            r_Insert = DT_DONDATHANG_H.NewRow();
            DT_DONDATHANG_H.Rows.Add(r_Insert);
            BS_DONDATHANG_H.Position = DT_DONDATHANG_H.Rows.Count;
            GRID_DONHANG_D.Enabled = true;
            GRID_DONHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DONHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DONHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DONHANG_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_MADONDATHANG.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHACH, txt_NGAYBAOGIA, txt_HOTEN }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_DIEUCHINH.Enabled = true;
            GRID_DONHANG_H.Enabled = false;
            //btn_TIMKIEM.Enabled = false;
            txt_NGAYDAT.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_DIEUCHINH.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHACH, txt_NGAYBAOGIA, txt_HOTEN }));
                //txt_TENHIEU.Focus();
            }
            GRID_DONHANG_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_DONHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DONHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DONHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DONHANG_D.Enabled = true;
            GRID_DONHANG_H.Enabled = false;
            btn_XOADONG.Enabled = true;
            //btn_TIMKIEM.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DONDATHANG_H.Rows.Remove(r_Insert);
            }
            BS_DONDATHANG_H_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_DIEUCHINH.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            //btn_TIMKIEM.Enabled = btn_IN.Enabled = btn_LAMMOI.Enabled = true;
            GRID_DONHANG_H.Enabled = true;
            GRID_DONHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DONHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DONHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            if (new PhieugiaohangDManager().SelectByMadonRDT(MAHIEU_PK).Rows.Count > 0)
            {
                MessageBox.Show("Đã sử dụng trong phiếu xuất hàng bán." + '\n' + "Không thể xóa đơn đặt hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DonhangHManager _DonhangHManager = new DonhangHManager();
            DonhangHEntity _DonhangHEntity = new DonhangHEntity();
            _DonhangHEntity = _DonhangHManager.SelectOne(MAHIEU_PK);
            if (_DonhangHEntity != null && MessageBox.Show("Xóa đơn đặt hàng: " + MAHIEU_PK, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DonhangDManager.DeleteByMadon(MAHIEU_PK);
                    _DonhangHManager.Delete(MAHIEU_PK);
                    GRID_DONHANG_H.CurrentRow.Delete();
                    BS_DONDATHANG_H_CurrentChanged(new object(), new EventArgs());
                    //GD.BBPH.LIB.TrayPopup.PoupStringMessage(GD.BBPH.APP.Properties.Resources.MessageTitle, GD.BBPH.APP.Properties.Resources.MessageContent_T);
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_DonhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_DIEUCHINH.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //btn_TIMKIEM.Enabled = btn_LAMMOI.Enabled = true;
            GRID_DONHANG_H.Enabled = true;
            GRID_DONHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DONHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DONHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TENKHACH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            DT_DMHANG = LIB.SESSION_START.DM_HANG;
            //DT_BAOGIA_H = LIB.SESSION_START.DT_BAOGIA_H;
            //DT_BAOGIA_D = LIB.SESSION_START.DT_BAOGIA_D;
            DT_NHANVIEN = new DmcongnhanManager().SelectPhongbanChuanghi(new string[] { "KD" }); /*LIB.SESSION_START.DT_NHANVIEN;*/
            if (btn_SUA.Enabled == true || btn_THEMMOI.Enabled == true)
            {
                MAHIEU_PK = "";
                SOBAOGIA = "";
                SoPO = "";
                MAKHACHHANG = "";
                Masp = "";
                DT_DONDATHANG_H = LIB.Procedures.Danhsachdonhang(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, SOBAOGIA, /*SoPO,*/ MAKHACHHANG, Masp);
                DataView Source_View = new DataView(DT_DONDATHANG_H);
                BS_DONDATHANG_H = new BindingSource();
                BS_DONDATHANG_H.DataSource = Source_View;
                GRID_DONHANG_H.DataSource = BS_DONDATHANG_H;
                BS_DONDATHANG_H.CurrentChanged += new EventHandler(BS_DONDATHANG_H_CurrentChanged);
                BS_DONDATHANG_H_CurrentChanged((new object()), (new EventArgs()));
            }
        }

        private void btn_IN_Click(object sender, EventArgs e)
        {
            DataSet dsKetqua = new DataSet();
            string _Madondathang = "";

            try
            {
                #region Lay thong tin cac tham so
                _Madondathang = txt_MADONDATHANG.Text;
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@Madondathang", _Madondathang);

                _DataAccessAdapter.CallRetrievalStoredProcedure("Indondathang", parameters, dsKetqua);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Dondathang";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Khachhang");
                dtThamso.Columns.Add("Ghichu");
                dtThamso.Columns.Add("Thoigianbaocao");
                dtThamso.Columns.Add("Tennhanvien");
                DataRow dr = dtThamso.NewRow();
                dr["Khachhang"] = txt_TENKHACH.Text;
                dr["Ghichu"] = txt_GHICHU.Text;
                dr["Thoigianbaocao"] = "Hà Nội, ngày " + txt_NGAYDAT.Text;
                dr["Tennhanvien"] = txt_HOTEN.Text;
                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                //new BAOCAO.FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\NHUCAUSANXUAT.rdlc", "Dondathang", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void btn_TIMKIEM_Click(object sender, EventArgs e)
        //{
        //    FRM_TIMKIEM frm = new FRM_TIMKIEM();
        //    frm.ShowDialog();
        //    if (frm._DialogResult == DialogResult.No) return;
        //    DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
        //    DT_DMHANG = LIB.SESSION_START.DM_HANG;
        //    MAKHACHHANG = frm._Makhachhang;
        //    Masp = frm._Masp;
        //    SOBAOGIA = frm._Sobaogia;
        //    MAHIEU_PK = frm._Madondathang;
        //    DT_DONDATHANG_H = LIB.Procedures.Danhsachdonhang(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, SOBAOGIA, /*SoPO,*/ MAKHACHHANG, Masp);
        //    DataView Source_View = new DataView(DT_DONDATHANG_H);
        //    BS_DONDATHANG_H = new BindingSource();
        //    BS_DONDATHANG_H.DataSource = Source_View;
        //    GRID_DONHANG_H.DataSource = BS_DONDATHANG_H;
        //    BS_DONDATHANG_H.CurrentChanged += new EventHandler(BS_DONDATHANG_H_CurrentChanged);
        //    BS_DONDATHANG_H_CurrentChanged((new object()), (new EventArgs()));
        //}
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DonhangHManager.SelectOne(txt_MADONDATHANG.Text.Trim()) != null)
            {
                MessageBox.Show("Mã đơn hàng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADONDATHANG.Focus();
                return;
            }
            else if (txt_MADONDATHANG.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADONDATHANG.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DONHANG_H.Enabled = true;
                //btn_TIMKIEM.Enabled = btn_LAMMOI.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_DONHANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DONHANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DONHANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHACH.Text.Trim()) || DT_DMKHACH == null || DT_DMKHACH.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKhach(_str_MACANTIM, DT_DMKHACH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
                        DT_DMKHACH, DmkhachFields.Makhach.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHACH.Text = _RowViewSelect[DmkhachFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();

                DT_DMHANG = new DmhangManager().SelectByMakhachRDT(txt_MAKHACH.Text);
                DT_BAOGIA_H = new BaogiaHManager().SelectByMakhachRDT(txt_MAKHACH.Text);
            }
            else
            {
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
                DT_DMHANG = new DmhangManager().SelectByMakhachRDT(txt_MAKHACH.Text);
                DT_BAOGIA_H = new BaogiaHManager().SelectByMakhachRDT(txt_MAKHACH.Text);
            }
        }
        private DataRow checkmaKhach(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhachFields.Makhach.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_SOBAOGIA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOBAOGIA.Text.Trim()) || DT_BAOGIA_H == null || DT_BAOGIA_H.Rows.Count == 0) return;
            string _str_MACANTIM = txt_SOBAOGIA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaBaogia(_str_MACANTIM, DT_BAOGIA_H);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_BAOGIA_H.xml",
                        DT_BAOGIA_H, BaogiaHFields.Sobaogia.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOBAOGIA.Text = _RowViewSelect[BaogiaHFields.Sobaogia.Name].ToString();
                txt_NGAYBAOGIA.Text = _RowViewSelect[BaogiaHFields.Ngayhieuluc.Name].ToString();
            }
            else
            {
                txt_NGAYBAOGIA.Text = _RowViewSelect[BaogiaHFields.Ngayhieuluc.Name].ToString();
            }
        }
        private DataRow checkmaBaogia(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(BaogiaHFields.Sobaogia.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MANHANVIEN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MANHANVIEN.Text.Trim()) || DT_NHANVIEN == null || DT_NHANVIEN.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MANHANVIEN.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNhanvien(_str_MACANTIM, DT_NHANVIEN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGNHAN.xml",
                        DT_NHANVIEN, DmcongnhanFields.Macn.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MANHANVIEN.Text = _RowViewSelect[DmcongnhanFields.Macn.Name].ToString();
                txt_HOTEN.Text = _RowViewSelect[DmcongnhanFields.Tencongnhan.Name].ToString();
            }
            else
            {
                txt_HOTEN.Text = _RowViewSelect[DmcongnhanFields.Tencongnhan.Name].ToString();
            }
        }
        private DataRow checkmaNhanvien(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmcongnhanFields.Macn.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region   Shortcut Key
        private void txt_MAKHACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMKHACH frm_Dm = new FRM_DMKHACH();
                frm_Dm.Text = "Danh mục khách hàng";
                frm_Dm.ShowDialog();
                DT_DMKHACH = new DmkhachManager().SelectAllRDT();
            }
        }
        private void txt_SOBAOGIA_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.F4)
            //{
            //    FRM_BAOGIA frm_Dm = new FRM_BAOGIA();
            //    frm_Dm.Text = "Danh mục báo giá";
            //    frm_Dm.ShowDialog();
            //    DT_BAOGIA_H = new BaogiaHManager().SelectAllRDT();
            //}
        }

        #endregion
        private void FRM_DONHANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void FRM_BAOGIA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_LUULAI.Enabled)
            {
                DialogResult Dlog = MessageBox.Show("Dữ liệu đã được thay đổi! Bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (Dlog == DialogResult.Yes)
                {
                    btn_LUULAI_Click(new object(), new EventArgs());
                    return;
                }
                if (Dlog == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

    }
}
