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
using Microsoft.Office.Core;

namespace GD.BBPH.APP.DANHMUC
{
    public partial class FRM_CTPTMANG : FRM_DMPARENT
    {
        private CtptmangHManager _CtptmangHManager = new CtptmangHManager();
        private CtptmangHEntity _CtptmangHEntity = new CtptmangHEntity();
        private CtptmangDManager _CtptmangDManager = new CtptmangDManager();
        private CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_CTPTMANG_H = new DataTable(), DT_CTPTMANG_D = new DataTable(), DT_CTPTMANG_D_FILL = new DataTable();
        private BindingSource BS_CTPTMANG_H = new BindingSource(), BS_CTPTMANG_D = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.BBPH.CONTROL.JGridEX GRID_CTPTMANG_H = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_CTPTMANG_D = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";

        private DataTable DT_DMSOI = new DataTable(), DT_DMNGUYENLIEU = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_CTPTMANG");
                        DT_CTPTMANG_H = LIB.SESSION_START.DT_CTPTMANG_H;// LIB.Procedures.DanhsachCTPTMANG();
                        DT_CTPTMANG_D = LIB.SESSION_START.DT_CTPTMANG_D;
                        DT_CTPTMANG_D_FILL = DT_CTPTMANG_D.Clone();

                        //DT_DMSOI = LIB.SESSION_START.DT_DMSOI;
                        DT_DMNGUYENLIEU = new DmnguyenlieuManager().SelectAllRDT();// LIB.SESSION_START.DT_DMNGUYENLIEU;
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

        public FRM_CTPTMANG()
        {
            InitializeComponent();
            CtptmangHManager _CtptmangHManager = new CtptmangHManager();
            DataTable dt111 = _CtptmangHManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CTPTMANG.xml");
            CtptmangDManager _CtptmangDManager = new CtptmangDManager();
            dt111 = _CtptmangDManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CTPTMANGCHITIET.xml");

            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CTPTMANG.xml", GRID_CTPTMANG_H, uiPanel0Container);
            GRID_CTPTMANG_H.RootTable.Groups.Add(GRID_CTPTMANG_H.Tables[0].Columns[CtptmangHFields.Mactpt.Name]);
            GRID_CTPTMANG_H.RootTable.SortKeys.Add(CtptmangHFields.Ngayapdung.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CTPTMANGCHITIET.xml", GRID_CTPTMANG_D, pne_CHITIET);
            GRID_CTPTMANG_D.FilterMode = FilterMode.None;
            GRID_CTPTMANG_D.GroupByBoxVisible = false;
            FORM_PROCESS();
            GRID_CTPTMANG_D.COMBO_MULTICOLUMN(GRID_CTPTMANG_D,CtptmangDFields.Tennguyenlieu.Name, DmnguyenlieuFields.Manl.Name, DmnguyenlieuFields.Tenrutgon.Name, DmnguyenlieuFields.Tenrutgon.Name, DT_DMNGUYENLIEU);
            GRID_CTPTMANG_D.CellEdited += GRID_CTPTMANG_D_CellEdited;
            GRID_CTPTMANG_D.RecordsDeleted += GRID_CTPTMANG_D_RecordsDeleted;
            GRID_CTPTMANG_D.RecordUpdated += GRID_CTPTMANG_D_RecordUpdated;
            GRID_CTPTMANG_D.DeletingRecord += GRID_CTPTMANG_DeletingRecord;
            GRID_CTPTMANG_D.RootTable.Columns[CtptmangDFields.Tyle.Name].EditType = EditType.NoEdit;
            GRID_CTPTMANG_D.RootTable.Columns[CtptmangDFields.Manl.Name].EditType = EditType.NoEdit;
            GRID_CTPTMANG_D.RootTable.Columns["Dongia"].EditType = EditType.NoEdit;
            GRID_CTPTMANG_D.RootTable.Columns["Thanhtien"].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_CTPTMANG_H);
            BS_CTPTMANG_H = new BindingSource();
            BS_CTPTMANG_H.DataSource = Source_View;
            GRID_CTPTMANG_H.DataSource = BS_CTPTMANG_H;
            BS_CTPTMANG_H.CurrentChanged += new EventHandler(BS_CTPTMANG_H_CurrentChanged);
            BS_CTPTMANG_H_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid Detail
        private void GRID_CTPTMANG_D_RecordUpdated(object sender, EventArgs e)
        {
            TinhtongTrongluong();
        }

        private void GRID_CTPTMANG_D_RecordsDeleted(object sender, EventArgs e)
        {
            TinhtongTrongluong();
        }
        private void GRID_CTPTMANG_D_CellEdited(object sender, ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == CtptmangDFields.Tennguyenlieu.Name)
            {
                string tennguyenlieu = GRID_CTPTMANG_D.CurrentRow.Cells[CtptmangDFields.Tennguyenlieu.Name].Value.ToString();
                DataTable dt = new DmnguyenlieuManager().SelectByTenrutgonRDT(tennguyenlieu);
                GRID_CTPTMANG_D.CurrentRow.Cells[CtptmangDFields.Manl.Name].Value = dt.Rows[0][DmnguyenlieuFields.Manl.Name].ToString();
                if (e.Column.DataMember == CtptmangDFields.Trongluong.Name)
                {
                    GRID_CTPTMANG_D.CurrentRow.Cells[CtptmangDFields.Trongluong.Name].Value = Convert.ToDecimal(CtptmangDFields.Trongluong.Name).ToString("#.###,##", new System.Globalization.CultureInfo("vi-VN"));
                }
            }
            TinhtongTrongluong();
        }
        private void GRID_CTPTMANG_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {           
            btn_XOADONG_Click(new object(), new EventArgs());
            TinhtongTrongluong();
        }
        private void TinhtongTrongluong()
        {
            decimal tongkl = 0, tongtt = 0;
            try
            {
                GRID_CTPTMANG_D.UpdateData();
                GridEXRow[] listGrid = GRID_CTPTMANG_D.GetDataRows();
                //-------Tính tổng khối lượng, Điền đơn giá và tính thành tiền
                foreach (GridEXRow _grid in listGrid)
                {
                    DataRowView _view = (DataRowView)_grid.DataRow;
                    if (_view == null) continue;
                    decimal _dongia = 0, _kluong = 0;
                    DataRow[] arrDr = DT_DMNGUYENLIEU.Select(DmnguyenlieuFields.Manl.Name + "='" + _view[CtptmangDFields.Manl.Name].ToString() + "'");
                    if (arrDr.Length > 0)
                    {
                        _dongia = LIB.ConvertString.NumbertoDB(arrDr[0][DmnguyenlieuFields.Gia.Name].ToString());
                        _view["Dongia"] = _dongia;
                    }
                    _kluong = LIB.ConvertString.NumbertoDB(_view[CtptmangDFields.Trongluong.Name].ToString());
                    _view["Thanhtien"] = _dongia * _kluong;
                    tongkl += _kluong;
                    tongtt += _dongia * _kluong;
                }
                txt_TONGKL.Text = tongkl.ToString("#.00", new System.Globalization.CultureInfo("vi-VN"));
                txt_TONGTIEN.Text = tongtt.ToString("#.00", new System.Globalization.CultureInfo("vi-VN"));
                txt_DONGIA.Text = (tongtt / tongkl).ToString("#.00", new System.Globalization.CultureInfo("vi-VN"));
                //-------Tính tỷ lệ phần trăm khối lượng
                foreach (GridEXRow _grid in listGrid)
                {
                    DataRowView _view = (DataRowView)_grid.DataRow;
                    if (_view == null) continue;
                    _view[CtptmangDFields.Tyle.Name] = LIB.ConvertString.NumbertoDB(_view[CtptmangDFields.Trongluong.Name].ToString()) / tongkl * 100;
                }
            }
            catch { }
        }
        #endregion

        void BS_CTPTMANG_H_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GRID_CTPTMANG_H.UpdateData();
                if (BS_CTPTMANG_H.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_CTPTMANG_H.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[CtptmangHFields.Id.Name].ToString();

                    SHOWGRID(MAHIEU_PK);

                    txt_MACONGTHUC.Text = _Rowview.Row[CtptmangHFields.Mactpt.Name].ToString();
                    txt_TENCONGTHUC.Text = _Rowview.Row[CtptmangHFields.Tenctpt.Name].ToString();
                    txt_NGAYAPDUNG.Text = _Rowview.Row[CtptmangHFields.Ngayapdung.Name].ToString();
                }
                else 
                {
                    SHOWGRID("");
                    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container)); 
                }
                TinhtongTrongluong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BS_CTPTMANG_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_CTPTMANG_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_CTPTMANG_D.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[CtptmangDFields.Id.Name].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_CTPTMANG_D = new CtptmangDManager().Clone();
                DT_CTPTMANG_D.Columns.Add("Dongia", Type.GetType("System.Decimal"));
                DT_CTPTMANG_D.Columns.Add("Thanhtien", Type.GetType("System.Decimal"));
                BS_CTPTMANG_D = new BindingSource(DT_CTPTMANG_D, null);
                GRID_CTPTMANG_D.DataSource = BS_CTPTMANG_D;
            }
            else
            {
                DT_CTPTMANG_D = new CtptmangDManager().SelectByIdHRDT(Convert.ToInt64(MAHIEU_PK));
                DT_CTPTMANG_D.Columns.Add("Dongia", Type.GetType("System.Decimal"));
                DT_CTPTMANG_D.Columns.Add("Thanhtien", Type.GetType("System.Decimal"));

                DataView Source_View = new DataView(DT_CTPTMANG_D);
                BS_CTPTMANG_D = new BindingSource();
                BS_CTPTMANG_D.DataSource = Source_View;
                GRID_CTPTMANG_D.DataSource = BS_CTPTMANG_D;
            }
            BS_CTPTMANG_D.CurrentChanged += new EventHandler(BS_CTPTMANG_D_CurrentChanged);
            BS_CTPTMANG_D_CurrentChanged((new object()), (new EventArgs()));
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            CtptmangHEntity _ctptmangHEntity = new CtptmangHEntity();
            _ctptmangHEntity.Mactpt = txt_MACONGTHUC.Text.Trim();
            _ctptmangHEntity.Tenctpt = txt_TENCONGTHUC.Text.Trim();
            try { _ctptmangHEntity.Ngayapdung = Convert.ToDateTime(txt_NGAYAPDUNG.Text.Trim()); }
            catch { }
            try { _ctptmangHEntity.Id = Convert.ToInt64(_str_DMCHUONG_PK); }
            catch { }

            EntityCollection _CtptmangDEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_CTPTMANG_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                CtptmangDEntity _ctptmangDEntity = new CtptmangDEntity();
                _ctptmangDEntity.Mact = txt_MACONGTHUC.Text.Trim();
                _ctptmangDEntity.Tenct = txt_TENCONGTHUC.Text.Trim();
                //_ctptmangDEntity.Ngayapdung = _CtptmangHEntity.Ngayapdung;
                _ctptmangDEntity.Manl = _view[CtptmangDFields.Manl.Name].ToString();
                _ctptmangDEntity.Tennguyenlieu = _view[CtptmangDFields.Tennguyenlieu.Name].ToString();
                try { _ctptmangDEntity.Trongluong = Convert.ToDecimal(_view[CtptmangDFields.Trongluong.Name].ToString()); }
                catch { }
                try { _ctptmangDEntity.Tyle = Convert.ToDecimal(_view[CtptmangDFields.Tyle.Name].ToString()); }
                catch { }
                try { _ctptmangDEntity.Id = Convert.ToInt64(_view[CtptmangDFields.Id.Name].ToString()); }
                catch { }

                _ctptmangDEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_ctptmangDEntity.IsNew)
                {
                    EntityCollection drDHCT = (new CtptmangDManager()).SelectById(_ctptmangDEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _ctptmangDEntity.Ngaysua = DateTime.Now;
                        _ctptmangDEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _ctptmangDEntity.IsNew = false;
                    }
                    else
                    {
                        _ctptmangDEntity.Ngaytao = DateTime.Now;
                        _ctptmangDEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }


                _CtptmangDEntityCol.Add(_ctptmangDEntity);
            }

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _ctptmangHEntity.Ngaytao = DateTime.Now;
                _ctptmangHEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _CtptmangHManager.InsertV2(_ctptmangHEntity, r_Insert, DT_CTPTMANG_H, BS_CTPTMANG_H);
                foreach (CtptmangDEntity _tpsEntity in _CtptmangDEntityCol)
                    _tpsEntity.IdH = _CtptmangHEntity.Id;
                _CtptmangDManager.InsertCollection(_CtptmangDEntityCol);
                GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangHManager.Convert(_ctptmangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_XOADONG.Enabled = false;
                BS_CTPTMANG_H.ResetCurrentItem();
                BS_CTPTMANG_H_CurrentChanged(new object(), new EventArgs());
                BS_CTPTMANG_H.Position = DT_CTPTMANG_H.Rows.Count - 1;
            }
            else
            {
                _ctptmangHEntity.Ngaysua = DateTime.Now;
                _ctptmangHEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _CtptmangHManager.Update(_ctptmangHEntity);
                foreach (CtptmangDEntity _tpsEntity in _CtptmangDEntityCol)
                    _tpsEntity.IdH = _CtptmangHEntity.Id;
                foreach (CtptmangDEntity _ctptmangDEntity in _CtptmangDEntityCol)
                {
                    if (_CtptmangDEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_CTPTMANG_D.NewRow();
                        DT_CTPTMANG_D.Rows.Add(_r_Insert);
                        _CtptmangDManager.InsertV2(_ctptmangDEntity, _r_Insert, DT_CTPTMANG_D, BS_CTPTMANG_D);
                    }
                    else _CtptmangDManager.Update(_ctptmangDEntity);
                }
                GRID_CTPTMANG_H.CurrentRow.Cells[CtptmangHFields.Ngayapdung.Name].Value = _ctptmangHEntity.Ngayapdung;
                GRID_CTPTMANG_H.CurrentRow.Cells[CtptmangHFields.Mactpt.Name].Value = _ctptmangHEntity.Mactpt;
                GRID_CTPTMANG_H.CurrentRow.Cells[CtptmangHFields.Tenctpt.Name].Value = _ctptmangHEntity.Tenctpt;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangHManager.Convert(_ctptmangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_XOADONG.Enabled = false;
                BS_CTPTMANG_H.ResetCurrentItem();
                BS_CTPTMANG_H_CurrentChanged(new object(), new EventArgs());
            }

            return _str_DMCHUONG_PK;      
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            string _Maydet = txt_MACONGTHUC.Text.Trim();
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENCONGTHUC.Text = string.Empty;
            CtptmangDManager _CtptmangDManager = new CtptmangDManager();
            CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
            r_Insert = DT_CTPTMANG_H.NewRow();
            DT_CTPTMANG_H.Rows.Add(r_Insert);
            BS_CTPTMANG_H.Position = DT_CTPTMANG_H.Rows.Count;
            GRID_CTPTMANG_D.Enabled = true;
            GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_CTPTMANG_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_MACONGTHUC.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_CTPTMANG_H.Enabled = false;
            btn_XOADONG.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {  }));
                btn_XOADONG.Enabled = true;
            }
            GRID_CTPTMANG_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_CTPTMANG_D.Enabled = true;
            GRID_CTPTMANG_H.Enabled = false;
            btn_XOADONG.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_CTPTMANG_H.Rows.Remove(r_Insert);
            }
            BS_CTPTMANG_H_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_CTPTMANG_H.Enabled = true;
            btn_XOADONG.Enabled = false;
            btn_SAOCHEP.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            CtptmangDManager _CtptmangDManager = new CtptmangDManager();
            CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
            //_CtptmangDEntity = _CtptmangDManager.SelectOne(MAHIEU_PK);
            if (_CtptmangDEntity != null && MessageBox.Show("Xóa thành phần sợi: " + txt_MACONGTHUC.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_CTPTMANG_D.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[CtptmangDFields.Id.Name].ToString()))
                        {
                            try { _CtptmangDManager.Delete(Convert.ToInt64(_view[CtptmangDFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_CtptmangDManager.Delete(MAHIEU_PK);
                    try { GRID_CTPTMANG_H.CurrentRow.Delete(); }
                    catch { }
                    BS_CTPTMANG_H_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangDManager.Convert(_CtptmangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa thành phần sợi: " + txt_MACONGTHUC.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_CTPTMANG_H.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (txt_MACONGTHUC.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công thức!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACONGTHUC.Focus();
                return;
            }
            //else if (string.IsNullOrEmpty(MAHIEU_PK) && _CtptmangDManager.SelectByMactptRDT(txt_Mactpt.Text).Rows.Count > 0)
            //{
            //    MessageBox.Show("Công thức bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_Mactpt.Focus();
            //    return;
            //}
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_CTPTMANG_H.Enabled = true;
                //BS_CTPTMANG_H.MoveLast();
                btn_THEMMOI.Focus();
                GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_XOADONG.Enabled = false;
                btn_SAOCHEP.Enabled = true;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_CTPTMANG_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[CtptmangDFields.Id.Name].ToString();
            string _MANGUYENLIEU = _view[CtptmangDFields.Manl.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK)) return;
            CtptmangDManager _CtptmangDManager = new CtptmangDManager();
            CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
            try { _CtptmangDEntity = _CtptmangDManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
            catch { }
            if (_CtptmangDEntity != null && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _CtptmangDManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                    DataRow[] drArr = DT_CTPTMANG_D.Select(CtptmangDFields.Id.Name + "='" + _MAHIEU_PK + "'");
                    DT_CTPTMANG_D.Rows.Remove(drArr[0]);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa dòng " + _MANGUYENLIEU + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                BS_CTPTMANG_D.ResetCurrentItem();
                GRID_CTPTMANG_D.DataSource = BS_CTPTMANG_D;
            }
            GRID_CTPTMANG_D.Enabled = true;
        }

        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                CtptmangDManager _CtptmangDManager = new CtptmangDManager();
                CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
                r_Insert = DT_CTPTMANG_H.NewRow();
                DT_CTPTMANG_H.Rows.Add(r_Insert);
                DataTable dt = new CtptmangDManager().SelectByIdHRDT(Convert.ToInt64(MAHIEU_PK));
                DataRow[] drCopy = DT_CTPTMANG_H.Select(CtptmangHFields.Id.Name + "= '" + MAHIEU_PK + "'");
                BS_CTPTMANG_H.Position = DT_CTPTMANG_H.Rows.Count;
                GRID_CTPTMANG_D.Enabled = true;
                GRID_CTPTMANG_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_CTPTMANG_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_CTPTMANG_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_CTPTMANG_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;

                txt_MACONGTHUC.Text = drCopy[0][CtptmangHFields.Mactpt.Name].ToString();
                txt_TENCONGTHUC.Text = drCopy[0][CtptmangHFields.Tenctpt.Name].ToString();
                txt_NGAYAPDUNG.Text = drCopy[0][CtptmangHFields.Ngayapdung.Name].ToString();

                foreach (DataRow dr in dt.Rows)
                {
                    DataRow r_Detail = DT_CTPTMANG_D.NewRow();
                    r_Detail[CtptmangDFields.Manl.Name] = dr[CtptmangDFields.Manl.Name];
                    r_Detail[CtptmangDFields.Tennguyenlieu.Name] = dr[CtptmangDFields.Tennguyenlieu.Name];
                    //r_Detail[CtptmangDFields.Ngayapdung.Name] = dr[CtptmangDFields.Ngayapdung.Name];
                    r_Detail[CtptmangDFields.Trongluong.Name] = dr[CtptmangDFields.Trongluong.Name];
                    r_Detail[CtptmangDFields.Tyle.Name] = dr[CtptmangDFields.Tyle.Name];
                    DT_CTPTMANG_D.Rows.Add(r_Detail);
                }

                MAHIEU_PK = "";
                txt_NGAYAPDUNG.Focus();
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_CTPTMANG_H.Enabled = false;
            }
            catch { }
            btn_SAOCHEP.Enabled = false;
        }
        #endregion

        private void FRM_CTPTMANG_FormClosing(object sender, FormClosingEventArgs e)
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
