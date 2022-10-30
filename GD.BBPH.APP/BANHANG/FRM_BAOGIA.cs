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
    public partial class FRM_BAOGIA : FRM_DMPARENT
    {
        private BaogiaHManager _BaogiaHManager = new BaogiaHManager();
        private BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity();
        private BaogiaDManager _BaogiaDManager = new BaogiaDManager();
        private BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_BAOGIA_H = new DataTable(), DT_BAOGIA_D = new DataTable(), DT_BAOGIA_D_FILL = new DataTable();
        private BindingSource BS_BAOGIA_H = new BindingSource(), BS_BAOGIA_D = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.BBPH.CONTROL.JGridEX GRID_BAOGIA_H = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_BAOGIA_D = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MAKHACHHANG = "", MAHANG = "";
        //private bool _Noidia = false, _Truyenthong = false;
        private decimal _Vat = 10;
        private DataTable DT_DMKHACH = new DataTable(), DT_DMHANG = new DataTable();//, DT_DMCHUNGLOAI = new DataTable(), DT_DMPE = new DataTable(), DT_DMMANH_SOI = new DataTable();
        //public DataTable DT_HANGCHON = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_BAOGIA");
                        DT_BAOGIA_H = LIB.Procedures.Danhsachbaogia(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG);
                        DT_BAOGIA_D = LIB.Procedures.Danhsachbaogiachitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG);
                        DT_BAOGIA_D_FILL = DT_BAOGIA_D.Clone();

                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
                        DT_DMHANG = LIB.SESSION_START.DM_HANG;
                        //DT_DMCHUNGLOAI = LIB.SESSION_START.DT_DMCHUNGLOAI;
                        //DT_DMPE = LIB.SESSION_START.DT_DMPE;
                        //DT_DMMANH_SOI = LIB.SESSION_START.DT_DMMANH_SOI;
                        _Vat = LIB.ConvertString.NumbertoDB(LIB.Procedures.Laygiatrithamso("Vat"));
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

        public FRM_BAOGIA()
        {
            InitializeComponent();
            //DataTable dt111 = new BaogiaHManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_BAOGIA_H.xml");
            //dt111 = new BaogiaDManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_BAOGIA_D.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LAMMOI, btn_LAMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SAOCHEP, btn_SAOCHEP.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_TIMKIEM, btn_TIMKIEM.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_IN, btn_IN.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_BAOGIA_H.xml", GRID_BAOGIA_H, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_BAOGIA_D.xml", GRID_BAOGIA_D, pne_CHITIET);
            GRID_BAOGIA_D.FilterMode = FilterMode.None;
            //GRID_BAOGIA_D.GroupByBoxVisible = false;
            //GRID_BAOGIA_D.RootTable.Groups.Add(GRID_BAOGIA_D.Tables[0].Columns[BaogiaDFields.Machungloai.Name]);
            FORM_PROCESS();
            GRID_BAOGIA_D.COMBO_MULTICOLUMN(GRID_BAOGIA_D, BaogiaDFields.Masp.Name, DmhangFields.Tensp.Name, DmhangFields.Masp.Name, DmhangFields.Masp.Name, DT_DMHANG);
            //GRID_BAOGIA_D.RootTable.Columns["Mahang"].EditType = EditType.NoEdit;
            GRID_BAOGIA_D.CellEdited += GRID_BAOGIA_D_CellEdited;
            GRID_BAOGIA_D.RecordsDeleted += GRID_BAOGIA_D_RecordsDeleted;
            GRID_BAOGIA_D.RecordUpdated += GRID_BAOGIA_D_RecordUpdated;
            GRID_BAOGIA_D.DeletingRecord += GRID_BAOGIA_D_DeletingRecord;
            GRID_BAOGIA_D.Click += GRID_BAOGIA_D_Click;
            DataView Source_View = new DataView(DT_BAOGIA_H);
            BS_BAOGIA_H = new BindingSource();
            BS_BAOGIA_H.DataSource = Source_View;
            GRID_BAOGIA_H.DataSource = BS_BAOGIA_H;
            BS_BAOGIA_H.CurrentChanged += new EventHandler(BS_BAOGIA_H_CurrentChanged);
            BS_BAOGIA_H_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMSP.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid Detail

        private void GRID_BAOGIA_D_RecordUpdated(object sender, EventArgs e)
        {

        }
        private void GRID_BAOGIA_D_RecordsDeleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
        private void GRID_BAOGIA_D_CellEdited(object sender, ColumnActionEventArgs e)
        {
            // Tính VAT
            GRID_BAOGIA_D.UpdateData();
            GridEXRow[] listGrid = GRID_BAOGIA_D.GetDataRows();
            // tính giá có VAT
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                //_view[BaogiaDFields.Dongiapechuavat.Name] = LIB.ConvertString.NumbertoDB(_view[BaogiaDFields.Dongiapecovat.Name].ToString()) / (1 + _Vat / 100);
                //_view[BaogiaDFields.Dongiabaochuavat.Name] = LIB.ConvertString.NumbertoDB(_view[BaogiaDFields.Dongiabaocovat.Name].ToString()) / (1 + _Vat / 100);
                //_view[BaogiaDFields.Dongiatongchuavat.Name] = LIB.ConvertString.NumbertoDB(_view[BaogiaDFields.Dongiatongcovat.Name].ToString()) / (1 + _Vat / 100);
            }
        }
        private void GRID_BAOGIA_D_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            //throw new NotImplementedException();
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        private void GRID_BAOGIA_D_Click(object sender, EventArgs e)
        {
            //int _Tongsoluong = 0;

            //for (int i = 0; i < DT_BAOGIA_D.Rows.Count; i++)
            //{
            //    try { _Tongsoluong += Convert.ToInt32(DT_BAOGIA_D.Rows[i][BaogiaDFields.Soluong.Name]); }
            //    catch { }               
            //}

            //txt_TONGSOLUONG.Text = _Tongsoluong.ToString();
        }
        #endregion

        void BS_BAOGIA_H_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                // GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_BAOGIA_H.UpdateData();
                if (BS_BAOGIA_H.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_BAOGIA_H.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[BaogiaHFields.Sobaogia.Name].ToString();

                    txt_SOBAOGIA.Text = _Rowview.Row[BaogiaHFields.Sobaogia.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[BaogiaHFields.Makhach.Name].ToString();
                    txt_NGAYBAOGIA.Text = _Rowview.Row[BaogiaHFields.Ngaybaogia.Name].ToString();
                    txt_PHUONGTHUCTT.Text = _Rowview.Row[BaogiaHFields.Phuongthuctt.Name].ToString();
                    txt_DIADIEMGIAO.Text = _Rowview.Row[BaogiaHFields.Diadiemgiao.Name].ToString();
                    txt_NGAYHIEULUC.Text = _Rowview.Row[BaogiaHFields.Ngayhieuluc.Name].ToString();
                    txt_NOIDUNG.Text = _Rowview.Row[BaogiaHFields.Noidung.Name].ToString();
                    txt_MAKHACH_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                {
                    SHOWGRID("");
                }
            }
            catch
            {
            }
        }

        void BS_BAOGIA_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_BAOGIA_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_BAOGIA_D.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[BaogiaDFields.Id.Name].ToString();
                }
                //else
                //{
                //    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                //}
            }
            catch
            {
            }
        }
        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_BAOGIA_D_FILL = new BaogiaDManager().Clone();
                BS_BAOGIA_D = new BindingSource(DT_BAOGIA_D_FILL, null);
                GRID_BAOGIA_D.DataSource = BS_BAOGIA_D;
            }
            else
            {
                DT_BAOGIA_D_FILL = LIB.Procedures.Danhsachbaogiachitiet(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG);

                DataView Source_View = new DataView(DT_BAOGIA_D_FILL);
                BS_BAOGIA_D = new BindingSource();
                BS_BAOGIA_D.DataSource = Source_View;
                GRID_BAOGIA_D.DataSource = BS_BAOGIA_D;
            }
            BS_BAOGIA_D.CurrentChanged += new EventHandler(BS_BAOGIA_D_CurrentChanged);
            BS_BAOGIA_D_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm_MultiRows_Select = 
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG_CHON.xml", DT_DMHANG, DmhangFields.Makhach.Name, txt_MAKHACH.Text.Trim());
            _frm_MultiRows_Select.ShowDialog();
            if (_frm_MultiRows_Select._RowsViewSelect == null) return;

            foreach(DataRowView drv in _frm_MultiRows_Select._RowsViewSelect)
            { 
                DataRow r_Detail = DT_BAOGIA_D_FILL.NewRow();
                //r_Detail[BaogiaDFields.Loaihang.Name] = 0;
                r_Detail[BaogiaDFields.Masp.Name] = drv.Row[DmhangFields.Masp.Name].ToString();
                r_Detail[BaogiaDFields.Tensp.Name] = drv.Row[DmhangFields.Tensp.Name].ToString();
                r_Detail[BaogiaDFields.Maspcuakhach.Name] = drv.Row[DmhangFields.Maspcuakhach.Name].ToString();
                try { r_Detail[BaogiaDFields.Doday.Name] = LIB.ConvertString.NumbertoDB(drv.Row[DmhangFields.Doday.Name].ToString()); }
                catch { }
                try { r_Detail[BaogiaDFields.Rong.Name] = LIB.ConvertString.NumbertoDB(drv.Row[DmhangFields.Rong.Name].ToString()); }
                catch { }
                try { r_Detail[BaogiaDFields.Dai.Name] = LIB.ConvertString.NumbertoDB(drv.Row[DmhangFields.Dai.Name].ToString()); }
                catch { }
                try { r_Detail[BaogiaDFields.Trongluong.Name] = LIB.ConvertString.NumbertoDB(drv.Row[DmhangFields.Trongluong.Name].ToString()); }
                catch { }
                r_Detail[BaogiaDFields.Loaimuc.Name] = drv.Row[DmhangFields.Loaimuc.Name].ToString();
                r_Detail[BaogiaDFields.Cautrucin.Name] = drv.Row[DmhangFields.Cautrucin.Name].ToString();
                r_Detail[BaogiaDFields.Tenqcthanhpham.Name] = drv.Row[DmhangFields.Tenqcthanhpham.Name].ToString();
                r_Detail[BaogiaDFields.Tenqcloaithung.Name] = drv.Row[DmhangFields.Tenqcloaithung.Name].ToString();
                r_Detail[BaogiaDFields.Tenqcdonggoi.Name] = drv.Row[DmhangFields.Tenqcdonggoi.Name].ToString();
                ////------------Lấy sau từ module Tinhgia (thiết kế bảng)
                //try { _BaogiaDEntity.Giavon = LIB.ConvertString.NumbertoDB(drv.Row[DanhmuchanghoaFields.Gia.Name].ToString()); }
                //catch { }

                DT_BAOGIA_D_FILL.Rows.Add(r_Detail);
            }

            DataView Source_View = new DataView(DT_BAOGIA_D_FILL);
            BS_BAOGIA_D = new BindingSource();
            BS_BAOGIA_D.DataSource = Source_View;
            GRID_BAOGIA_D.DataSource = BS_BAOGIA_D;
            BS_BAOGIA_D.Position = DT_BAOGIA_D_FILL.Rows.Count;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_BAOGIA_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[BaogiaDFields.Id.Name].ToString();
            string _MAHANG = _view[BaogiaDFields.Masp.Name].ToString();
            string _Sobaogia = _view[BaogiaDFields.Sobaogia.Name].ToString();
            string _Chungloai = _view[BaogiaDFields.Tensp.Name].ToString();
            if(new DonhangDManager().SelectByMahangRDT(_MAHANG).Rows.Count>0)
            {
                MessageBox.Show("Đã sử dụng trong đơn đặt hàng." + '\n' + "Không thể xóa hàng " + _MAHANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_BAOGIA_D.CurrentRow.Delete();
            }
            else
            {
                BaogiaDManager _BaogiaDManager = new BaogiaDManager();
                BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity();
                try { _BaogiaDEntity = _BaogiaDManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_BaogiaDEntity != null && MessageBox.Show("Xóa dòng: " + _MAHANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _BaogiaDManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_BAOGIA_D_FILL.Select(BaogiaDFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_BAOGIA_D_FILL.Rows.Remove(drArr[0]);
                        //GRID_BAOGIA_D.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_BaogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MAHANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_BAOGIA_D.ResetCurrentItem();
                    GRID_BAOGIA_D.DataSource = BS_BAOGIA_D;
                }
                GRID_BAOGIA_D.Enabled = true;
            }

        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity();
            _BaogiaHEntity.Sobaogia = txt_SOBAOGIA.Text.Trim();
            _BaogiaHEntity.Makhach = txt_MAKHACH.Text.Trim();
            _BaogiaHEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            try { _BaogiaHEntity.Ngaybaogia = Convert.ToDateTime(txt_NGAYBAOGIA.Text.Trim()); }
            catch { }
            _BaogiaHEntity.Phuongthuctt = txt_PHUONGTHUCTT.Text.Trim();
            _BaogiaHEntity.Diadiemgiao = txt_DIADIEMGIAO.Text.Trim();
            _BaogiaHEntity.Noidung = txt_NOIDUNG.Text.Trim();
            try { _BaogiaHEntity.Ngayhieuluc = Convert.ToDateTime(txt_NGAYHIEULUC.Text.Trim()); }
            catch { }

            EntityCollection _BaogiaDEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_BAOGIA_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity();
                _BaogiaDEntity.Sobaogia = _BaogiaHEntity.Sobaogia;
                _BaogiaDEntity.Ngaytao = _BaogiaHEntity.Ngaybaogia;
                _BaogiaDEntity.Ngaytao = _BaogiaHEntity.Ngayhieuluc;
                _BaogiaDEntity.Masp = _view[BaogiaDFields.Masp.Name].ToString();
                _BaogiaDEntity.Tensp = _view[BaogiaDFields.Tensp.Name].ToString();
                _BaogiaDEntity.Maspcuakhach = _view[BaogiaDFields.Maspcuakhach.Name].ToString();
                _BaogiaDEntity.Loaimuc = _view[BaogiaDFields.Loaimuc.Name].ToString();
                _BaogiaDEntity.Cautrucin = _view[BaogiaDFields.Cautrucin.Name].ToString();
                _BaogiaDEntity.Tenqcthanhpham = _view[BaogiaDFields.Tenqcthanhpham.Name].ToString();
                _BaogiaDEntity.Tenqcloaithung = _view[BaogiaDFields.Tenqcloaithung.Name].ToString();
                _BaogiaDEntity.Tenqcdonggoi = _view[BaogiaDFields.Tenqcdonggoi.Name].ToString();
                _BaogiaDEntity.Mota = _view[BaogiaDFields.Mota.Name].ToString();
                try { _BaogiaDEntity.Doday = Convert.ToDecimal(_view[BaogiaDFields.Doday.Name].ToString()); }
                catch { }
                try { _BaogiaDEntity.Rong = Convert.ToDecimal(_view[BaogiaDFields.Rong.Name].ToString()); }
                catch { }
                try { _BaogiaDEntity.Dai = Convert.ToDecimal(_view[BaogiaDFields.Dai.Name].ToString()); }
                catch { }
                try { _BaogiaDEntity.Trongluong = Convert.ToDecimal(_view[BaogiaDFields.Trongluong.Name].ToString()); }
                catch { }
                try { _BaogiaDEntity.DongiakhongVat = Convert.ToInt32(_view[BaogiaDFields.DongiakhongVat.Name].ToString()); }
                catch { }
                try { _BaogiaDEntity.DongiaVat = Convert.ToInt32(_view[BaogiaDFields.DongiaVat.Name].ToString()); }
                catch { }

                try { _BaogiaDEntity.Id = Convert.ToInt64(_view[BaogiaDFields.Id.Name].ToString()); }
                catch { }

                _BaogiaDEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_BaogiaDEntity.IsNew)
                {
                    EntityCollection drDHCT = (new BaogiaDManager()).SelectById(_BaogiaDEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _BaogiaDEntity.Ngaysua = DateTime.Now;
                        _BaogiaDEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _BaogiaDEntity.IsNew = false;
                    }
                    else
                    {
                        _BaogiaDEntity.Ngaytao = DateTime.Now;
                        _BaogiaDEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if (!string.IsNullOrEmpty(_BaogiaDEntity.Tensp))
                    _BaogiaDEntityCol.Add(_BaogiaDEntity);
            }

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _BaogiaHEntity.Ngaytao = DateTime.Now;
                _BaogiaHEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _BaogiaHManager.InsertV2(_BaogiaHEntity, r_Insert, DT_BAOGIA_H, BS_BAOGIA_H);
                _BaogiaDManager.InsertCollection(_BaogiaDEntityCol);
                GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_BaogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMSP.Enabled = btn_XOADONG.Enabled = false;
                BS_BAOGIA_H.ResetCurrentItem();
                BS_BAOGIA_H_CurrentChanged(new object(), new EventArgs());
                BS_BAOGIA_H.Position = DT_BAOGIA_H.Rows.Count - 1;
            }
            else
            {
                _BaogiaHEntity.Ngaysua = DateTime.Now;
                _BaogiaHEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _BaogiaHManager.Update(_BaogiaHEntity);
                foreach (BaogiaDEntity _BaogiaDEntity in _BaogiaDEntityCol)
                {
                    if (_BaogiaDEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_BAOGIA_D.NewRow();
                        DT_BAOGIA_D.Rows.Add(_r_Insert);
                        _BaogiaDManager.InsertV2(_BaogiaDEntity, _r_Insert, DT_BAOGIA_D, BS_BAOGIA_D);
                    }
                    else _BaogiaDManager.Update(_BaogiaDEntity);
                }
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Sobaogia.Name].Value = _BaogiaHEntity.Sobaogia;
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Makhach.Name].Value = _BaogiaHEntity.Makhach;
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Tenkhach.Name].Value = _BaogiaHEntity.Tenkhach;
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Ngaybaogia.Name].Value = _BaogiaHEntity.Ngaybaogia;
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Phuongthuctt.Name].Value = _BaogiaHEntity.Phuongthuctt;
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Diadiemgiao.Name].Value = _BaogiaHEntity.Diadiemgiao;
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Ngayhieuluc.Name].Value = _BaogiaHEntity.Ngayhieuluc;
                GRID_BAOGIA_H.CurrentRow.Cells[BaogiaHFields.Noidung.Name].Value = _BaogiaHEntity.Noidung;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_BaogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMSP.Enabled = btn_XOADONG.Enabled = false;
                BS_BAOGIA_H.ResetCurrentItem();
                BS_BAOGIA_H_CurrentChanged(new object(), new EventArgs());
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_SOBAOGIA.Text = txt_MAKHACH.Text = txt_TENKHACH.Text = string.Empty;
            txt_PHUONGTHUCTT.Text = txt_DIADIEMGIAO.Text = txt_NOIDUNG.Text = string.Empty;
            r_Insert = DT_BAOGIA_H.NewRow();
            DT_BAOGIA_H.Rows.Add(r_Insert);
            BS_BAOGIA_H.Position = DT_BAOGIA_H.Rows.Count;
            GRID_BAOGIA_D.Enabled = true;
            GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_BAOGIA_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_SOBAOGIA.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHACH }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMSP.Enabled = btn_XOADONG.Enabled = true;
            GRID_BAOGIA_H.Enabled = false;
            btn_TIMKIEM.Enabled = btn_IN.Enabled = false;
            txt_NGAYBAOGIA.Text = txt_NGAYHIEULUC.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMSP.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_SOBAOGIA, txt_TENKHACH }));
                //txt_TENHIEU.Focus();
            }
            GRID_BAOGIA_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_BAOGIA_D.Enabled = true;
            GRID_BAOGIA_H.Enabled = false;
            //btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            btn_TIMKIEM.Enabled = btn_IN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_BAOGIA_H.Rows.Remove(r_Insert);
            }
            BS_BAOGIA_H_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMSP.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            btn_TIMKIEM.Enabled = btn_IN.Enabled = btn_LAMMOI.Enabled = true;
            GRID_BAOGIA_H.Enabled = true;
            GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            btn_SAOCHEP.Enabled = btn_LAMMOI.Enabled = btn_IN.Enabled = true;
            btn_THEMSP.Enabled = btn_XOADONG.Enabled = false;
        }

        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BaogiaHManager _BaogiaHManager = new BaogiaHManager();
                BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity();
                r_Insert = DT_BAOGIA_H.NewRow();
                DT_BAOGIA_H.Rows.Add(r_Insert);
                DataTable dt = new BaogiaDManager().SelectBySobaogiaRDT(MAHIEU_PK);
                DataRow[] drCopy = DT_BAOGIA_H.Select(BaogiaHFields.Sobaogia.Name + "= '" + MAHIEU_PK + "'");
                BS_BAOGIA_H.Position = DT_BAOGIA_H.Rows.Count;
                GRID_BAOGIA_D.Enabled = true;
                GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_BAOGIA_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;

                txt_SOBAOGIA.Text = drCopy[0][BaogiaHFields.Sobaogia.Name].ToString();
                txt_NGAYBAOGIA.Text = drCopy[0][BaogiaHFields.Ngaybaogia.Name].ToString();
                txt_MAKHACH.Text = drCopy[0][BaogiaHFields.Makhach.Name].ToString();
                txt_PHUONGTHUCTT.Text = drCopy[0][BaogiaHFields.Phuongthuctt.Name].ToString();
                txt_DIADIEMGIAO.Text = drCopy[0][BaogiaHFields.Diadiemgiao.Name].ToString();
                txt_NGAYHIEULUC.Text = drCopy[0][BaogiaHFields.Ngayhieuluc.Name].ToString();
                txt_NOIDUNG.Text = drCopy[0][BaogiaHFields.Noidung.Name].ToString();

                txt_MAKHACH_Validating(new object(), new CancelEventArgs());

                foreach (DataRow dr in dt.Rows)
                {
                    DataRow r_Detail = DT_BAOGIA_D_FILL.NewRow();
                    r_Detail[BaogiaDFields.Sobaogia.Name] = dr[BaogiaDFields.Sobaogia.Name];
                    r_Detail[BaogiaDFields.Ngaytao.Name] = dr[BaogiaDFields.Ngaytao.Name];
                    r_Detail[BaogiaDFields.Ngaysua.Name] = dr[BaogiaDFields.Ngaysua.Name];
                    r_Detail[BaogiaDFields.Masp.Name] = dr[BaogiaDFields.Masp.Name];
                    r_Detail[BaogiaDFields.Tensp.Name] = dr[BaogiaDFields.Tensp.Name];
                    r_Detail[BaogiaDFields.Maspcuakhach.Name] = dr[BaogiaDFields.Maspcuakhach.Name];
                    r_Detail[BaogiaDFields.Doday.Name] = dr[BaogiaDFields.Doday.Name];
                    r_Detail[BaogiaDFields.Rong.Name] = dr[BaogiaDFields.Rong.Name];
                    r_Detail[BaogiaDFields.Dai.Name] = dr[BaogiaDFields.Dai.Name];
                    r_Detail[BaogiaDFields.Loaimuc.Name] = dr[BaogiaDFields.Loaimuc.Name];
                    r_Detail[BaogiaDFields.Cautrucin.Name] = dr[BaogiaDFields.Cautrucin.Name];
                    r_Detail[BaogiaDFields.Tenqcthanhpham.Name] = dr[BaogiaDFields.Tenqcthanhpham.Name];
                    r_Detail[BaogiaDFields.Tenqcloaithung.Name] = dr[BaogiaDFields.Tenqcloaithung.Name];
                    r_Detail[BaogiaDFields.Tenqcdonggoi.Name] = dr[BaogiaDFields.Tenqcdonggoi.Name];
                    r_Detail[BaogiaDFields.Mota.Name] = dr[BaogiaDFields.Mota.Name];
                    r_Detail[BaogiaDFields.DongiakhongVat.Name] = dr[BaogiaDFields.DongiakhongVat.Name];
                    r_Detail[BaogiaDFields.DongiaVat.Name] = dr[BaogiaDFields.DongiaVat.Name];
                    DT_BAOGIA_D_FILL.Rows.Add(r_Detail);
                }

                MAHIEU_PK = "";
                txt_SOBAOGIA.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_BAOGIA_H.Enabled = false;
            }
            catch { }
            btn_SAOCHEP.Enabled = btn_IN.Enabled = false;
            btn_THEMSP.Enabled = btn_XOADONG.Enabled = true;
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            if (new DonhangDManager().SelectBySobaogiaRDT(MAHIEU_PK).Rows.Count > 0)
            {
                MessageBox.Show("Đã sử dụng trong đơn đặt hàng." + '\n' + "Không thể xóa báo giá " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BaogiaHManager _BaogiaHManager = new BaogiaHManager();
            BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity();
            _BaogiaHEntity = _BaogiaHManager.SelectOne(MAHIEU_PK);
            if (_BaogiaHEntity != null && MessageBox.Show("Xóa báo giá: " + MAHIEU_PK, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _BaogiaDManager.DeleteBySobaogia(MAHIEU_PK);
                    _BaogiaHManager.Delete(MAHIEU_PK);
                    GRID_BAOGIA_H.CurrentRow.Delete();
                    BS_BAOGIA_H_CurrentChanged(new object(), new EventArgs());
                    //GD.BBPH.LIB.TrayPopup.PoupStringMessage(GD.BBPH.APP.Properties.Resources.MessageTitle, GD.BBPH.APP.Properties.Resources.MessageContent_T);
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_BaogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMSP.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Đã cập nhật hàng hóa chi tiết, không thể xóa báo giá " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            btn_TIMKIEM.Enabled = btn_IN.Enabled = btn_LAMMOI.Enabled = true;
            GRID_BAOGIA_H.Enabled = true;
            GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            //DT_DMCHUNGLOAI = LIB.SESSION_START.DT_DMCHUNGLOAI;
            if (btn_SUA.Enabled == true || btn_THEMMOI.Enabled == true)
            {
                MAKHACHHANG = "";
                MAHANG = "";
                MAHIEU_PK = "";
                DT_BAOGIA_H = LIB.Procedures.Danhsachbaogia(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG);
                DataView Source_View = new DataView(DT_BAOGIA_H);
                BS_BAOGIA_H = new BindingSource();
                BS_BAOGIA_H.DataSource = Source_View;
                GRID_BAOGIA_H.DataSource = BS_BAOGIA_H;
                BS_BAOGIA_H.CurrentChanged += new EventHandler(BS_BAOGIA_H_CurrentChanged);
                BS_BAOGIA_H_CurrentChanged((new object()), (new EventArgs()));
            }
        }

        private void btn_IN_Click(object sender, EventArgs e)
        {
            DataSet dsKetqua = new DataSet();
            DateTime _Ngaybaogia = new DateTime(), _Ngayhieuluc = new DateTime();
            string _Sobaogia = "", _Khachhang = "", _Phuongthuctt = "", _Diadiemgiao = "", _Noidung = "";

            try
            {
                #region Lay thong tin cac tham so
                _Ngaybaogia = Convert.ToDateTime(txt_NGAYBAOGIA.Text);
                _Sobaogia = txt_SOBAOGIA.Text;
                #endregion

                #region Chay procedure
                DAL.DatabaseSpecific.DataAccessAdapter _DataAccessAdapter = new DAL.DatabaseSpecific.DataAccessAdapter(LIB.SESSION_START.ConnectionStringKeyName);
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@Ngaybaogia", _Ngaybaogia);
                parameters[1] = new SqlParameter("@Sobaogia", _Sobaogia);

                _DataAccessAdapter.CallRetrievalStoredProcedure("Inbaogia", parameters, dsKetqua);
                _DataAccessAdapter.CloseConnection();
                dsKetqua.Tables[0].TableName = "Inbaogia";
                #endregion

                #region Tham so
                DataTable dtThamso = new DataTable("Thamso");
                dtThamso.Columns.Add("Khachhang");
                dtThamso.Columns.Add("Phuongthuctt");
                dtThamso.Columns.Add("Diadiemgiao");
                dtThamso.Columns.Add("Ngayhieuluc", Type.GetType("System.DateTime"));
                dtThamso.Columns.Add("Noidung");
                dtThamso.Columns.Add("Sobaogia");

                DataRow dr = dtThamso.NewRow();
                dr["Khachhang"] = txt_TENKHACH.Text;
                dr["Phuongthuctt"] = txt_PHUONGTHUCTT.Text;
                dr["Diadiemgiao"] = txt_DIADIEMGIAO.Text;
                dr["Ngayhieuluc"] = Convert.ToDateTime(txt_NGAYHIEULUC.Text);
                dr["Noidung"] = txt_NOIDUNG.Text;
                dr["Sobaogia"] = txt_SOBAOGIA.Text;

                dtThamso.Rows.Add(dr);
                dsKetqua.Tables.Add(dtThamso);
                #endregion

                #region Hien bao cao
                new BAOCAO.FRM_REPORTVIEWER(dsKetqua, LIB.PATH.BBPH_PATH + @"\RDLC\BAOGIA.rdlc", "Inbaogia", this.Text, true).Show();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TIMKIEM_Click(object sender, EventArgs e)
        {
            //FRM_TIMKIEM frm = new FRM_TIMKIEM();
            //frm.ShowDialog();
            //if (frm._DialogResult == DialogResult.No) return;
            //DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            ////DT_DMCHUNGLOAI = LIB.SESSION_START.DT_DMCHUNGLOAI;
            //MAKHACHHANG = frm._Makhachhang;
            //MAHANG = frm._Mahang;
            //MAHIEU_PK = frm._Sobaogia;
            //DT_BAOGIA_H = LIB.Procedures.Danhsachbaogia(LIB.SESSION_START.TS_NGAYDAUNAM, LIB.SESSION_START.TS_NGAYCUOINAM, MAHIEU_PK, MAKHACHHANG, MAHANG);
            //DataView Source_View = new DataView(DT_BAOGIA_H);
            //BS_BAOGIA_H = new BindingSource();
            //BS_BAOGIA_H.DataSource = Source_View;
            //GRID_BAOGIA_H.DataSource = BS_BAOGIA_H;
            //BS_BAOGIA_H.CurrentChanged += new EventHandler(BS_BAOGIA_H_CurrentChanged);
            //BS_BAOGIA_H_CurrentChanged((new object()), (new EventArgs()));
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _BaogiaHManager.SelectOne(txt_SOBAOGIA.Text.Trim()) != null)
            {
                MessageBox.Show("Mã báo giá bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOBAOGIA.Focus();
                return;
            }
            else if (txt_SOBAOGIA.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOBAOGIA.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_BAOGIA_H.Enabled = true;
                btn_TIMKIEM.Enabled = btn_IN.Enabled = btn_LAMMOI.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_BAOGIA_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_BAOGIA_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_BAOGIA_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
            btn_SAOCHEP.Enabled = btn_LAMMOI.Enabled = btn_IN.Enabled = true;
            btn_THEMSP.Enabled = btn_XOADONG.Enabled = false;
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
                //_Noidia = Convert.ToBoolean(_RowViewSelect[DmkhachFields.Noidia.Name].ToString());
                //_Truyenthong = Convert.ToBoolean(_RowViewSelect[DmkhachFields.Truyenthong.Name].ToString());
                //DT_DMCHUNGLOAI = new DanhmucchungloaiManager().SelectByMakhachRDT(txt_MAKHACH.Text);
            }
            else
            {
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
                //_Noidia = Convert.ToBoolean(_RowViewSelect[DmkhachFields.Noidia.Name].ToString());
                //_Truyenthong = Convert.ToBoolean(_RowViewSelect[DmkhachFields.Truyenthong.Name].ToString());
                //DT_DMCHUNGLOAI = new DanhmucchungloaiManager().SelectByMakhachRDT(txt_MAKHACH.Text);
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
        #endregion

        #region Shortcut Key
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
        #endregion

        private void FRM_BAOGIA_KeyDown(object sender, KeyEventArgs e)
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
