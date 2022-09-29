using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GD.SXBB.BLL;
using GD.SXBB.DAL;
using GD.SXBB.DAL.EntityClasses;
using GD.SXBB.DAL.FactoryClasses;
using GD.SXBB.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using GD.SXBB.LIB;
using Janus.Data;
using Janus.Windows.GridEX;
using Janus.Windows.Common;
using Microsoft.Office.Core;

namespace GD.SXBB.APP.DANHMUC
{
    public partial class FRM_THANHPHANSOI : FRM_DMPARENT
    {
        private ThanhphansoiManager _ThanhphansoiManager = new ThanhphansoiManager();
        private ThanhphansoiEntity _ThanhphansoiEntity = new ThanhphansoiEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_THANHPHANSOI_H = new DataTable(), DT_THANHPHANSOI_D = new DataTable(), DT_THANHPHANSOI_D_FILL = new DataTable();
        private BindingSource BS_THANHPHANSOI_H = new BindingSource(), BS_THANHPHANSOI_D = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null, _RowDanhmuchanghoa = null;
        private GD.SXBB.CONTROL.JGridEX GRID_THANHPHANSOI_H = new GD.SXBB.CONTROL.JGridEX();
        private GD.SXBB.CONTROL.JGridEX GRID_THANHPHANSOI_D = new GD.SXBB.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";

        private DataTable DT_DMSOI = new DataTable(), DT_DMNGUYENLIEU = new DataTable();

        private void TEXTBOX_Only_Control(bool _isbool, GD.SXBB.CONTROL.TEXTBOX _Textbox)
        {
            GD.SXBB.LIB.FORM_PROCESS_UTIL.enableControls(!_isbool, uiPanel1Container, new List<Control>(new Control[] { _Textbox }));
        }

        private void FORM_PROCESS()
        {
            using (System.Windows.Forms.Form f = new System.Windows.Forms.Form())
            using (PictureBox _PictureBox = new PictureBox())
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                Image _image = Image.FromFile(LIB.PATH.SXBB_PATH + @"\IMG\waiting.xml");
                _PictureBox.Image = _image;
                _PictureBox.Width = _image.Width;
                _PictureBox.Height = _image.Height;
                worker.DoWork += delegate
                {
                    if (FUNCTION == "LOAD")
                    {
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_THANHPHANSOI");
                        DT_THANHPHANSOI_H = LIB.Procedures.Danhsachthanhphansoi();
                        DT_THANHPHANSOI_D = LIB.SESSION_START.DT_THANHPHANSOI;
                        DT_THANHPHANSOI_D_FILL = DT_THANHPHANSOI_D.Clone();

                        DT_DMSOI = LIB.SESSION_START.DT_DMSOI;
                        DT_DMNGUYENLIEU = LIB.SESSION_START.DT_DMNGUYENLIEU;
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

        public FRM_THANHPHANSOI()
        {
            InitializeComponent();
            ThanhphansoiManager _ThanhphansoiManager = new ThanhphansoiManager();
            DataTable dt111 = _ThanhphansoiManager.Clone();
            //GD.SXBB.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.SXBB_PATH + @"\XMLCONFIG\FRM_THANHPHANSOICHITIET.xml");
            GD.SXBB.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.SXBB.CONTROL.BUTTON.Loadimage(LIB.PATH.SXBB_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.SXBB.CONTROL.BUTTON.Loadimage(LIB.PATH.SXBB_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.SXBB.CONTROL.BUTTON.Loadimage(LIB.PATH.SXBB_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.SXBB.CONTROL.BUTTON.Loadimage(LIB.PATH.SXBB_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.SXBB.CONTROL.BUTTON.Loadimage(LIB.PATH.SXBB_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.SXBB.CONTROL.BUTTON.Loadimage(LIB.PATH.SXBB_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.SXBB.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.SXBB_PATH + @"\XMLCONFIG\FRM_THANHPHANSOI.xml", GRID_THANHPHANSOI_H, uiPanel0Container);
            //GRID_THANHPHANSOI.RootTable.Groups.Add(GRID_THANHPHANSOI.Tables[0].Columns[ThanhphansoiFields.Ngay.Name]).Collapse();
            GD.SXBB.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.SXBB_PATH + @"\XMLCONFIG\FRM_THANHPHANSOICHITIET.xml", GRID_THANHPHANSOI_D, pne_CHITIET);
            GRID_THANHPHANSOI_D.FilterMode = FilterMode.None;
            GRID_THANHPHANSOI_D.GroupByBoxVisible = false;
            FORM_PROCESS();
            GRID_THANHPHANSOI_D.COMBO_MULTICOLUMN(GRID_THANHPHANSOI_D,ThanhphansoiFields.Tennguyenlieu.Name, DanhmucnguyenlieuFields.Mahieu.Name, DanhmucnguyenlieuFields.Tenhieu.Name, DanhmucnguyenlieuFields.Tenhieu.Name, DT_DMNGUYENLIEU);
            GRID_THANHPHANSOI_D.CellEdited += GRID_THANHPHANSOI_D_CellEdited;
            GRID_THANHPHANSOI_D.RecordsDeleted += GRID_THANHPHANSOI_D_RecordsDeleted;
            GRID_THANHPHANSOI_D.RecordUpdated += GRID_THANHPHANSOI_D_RecordUpdated;
            GRID_THANHPHANSOI_D.DeletingRecord += GRID_THANHPHANSOI_D_DeletingRecord;
            GRID_THANHPHANSOI_D.RootTable.Columns[ThanhphansoiFields.Tylephantram.Name].EditType = EditType.NoEdit;
            GRID_THANHPHANSOI_D.RootTable.Columns["Dongia"].EditType = EditType.NoEdit;
            GRID_THANHPHANSOI_D.RootTable.Columns["Thanhtien"].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_THANHPHANSOI_H);
            BS_THANHPHANSOI_H = new BindingSource();
            BS_THANHPHANSOI_H.DataSource = Source_View;
            GRID_THANHPHANSOI_H.DataSource = BS_THANHPHANSOI_H;
            BS_THANHPHANSOI_H.CurrentChanged += new EventHandler(BS_THANHPHANSOI_H_CurrentChanged);
            BS_THANHPHANSOI_H_CurrentChanged((new object()), (new EventArgs()));
            GD.SXBB.BLL.MenuroleManager.set_Enable_controls(GD.SXBB.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Xử lý Grid Detail
        private void GRID_THANHPHANSOI_D_RecordUpdated(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Tinhtongkhoiluong();
        }

        private void GRID_THANHPHANSOI_D_RecordsDeleted(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Tinhtongkhoiluong();
        }
        private void GRID_THANHPHANSOI_D_CellEdited(object sender, ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == ThanhphansoiFields.Tennguyenlieu.Name)
            {
                string tennguyenlieu = GRID_THANHPHANSOI_D.CurrentRow.Cells[ThanhphansoiFields.Tennguyenlieu.Name].Value.ToString();
                DataTable dt = new DanhmucnguyenlieuManager().SelectByTenhieuRDT(tennguyenlieu);
                GRID_THANHPHANSOI_D.CurrentRow.Cells[ThanhphansoiFields.Manguyenlieu.Name].Value = dt.Rows[0][DanhmucnguyenlieuFields.Mahieu.Name].ToString();
                if (e.Column.DataMember == ThanhphansoiFields.Khoiluong.Name)
                {
                    GRID_THANHPHANSOI_D.CurrentRow.Cells[ThanhphansoiFields.Khoiluong.Name].Value = Convert.ToDecimal(ThanhphansoiFields.Khoiluong.Name).ToString("#.###,##", new System.Globalization.CultureInfo("vi-VN"));
                }
            }
            Tinhtongkhoiluong();
        }
        private void GRID_THANHPHANSOI_D_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {           
            btn_XOADONG_Click(new object(), new EventArgs());
            Tinhtongkhoiluong();
        }
        private void Tinhtongkhoiluong()
        {
            decimal tongkl = 0, tongtt = 0;
            try
            {
                GRID_THANHPHANSOI_D.UpdateData();
                GridEXRow[] listGrid = GRID_THANHPHANSOI_D.GetDataRows();
                //-------Tính tổng khối lượng, Điền đơn giá và tính thành tiền
                foreach (GridEXRow _grid in listGrid)
                {
                    DataRowView _view = (DataRowView)_grid.DataRow;
                    if (_view == null) continue;
                    decimal _dongia = 0, _kluong = 0;
                    DataRow[] arrDr = DT_DMNGUYENLIEU.Select(DanhmucnguyenlieuFields.Mahieu.Name + "='" + _view[ThanhphansoiFields.Manguyenlieu.Name].ToString() + "'");
                    if (arrDr.Length > 0)
                    {
                        _dongia = LIB.ConvertString.NumbertoDB(arrDr[0][DanhmucnguyenlieuFields.Gia.Name].ToString());
                        _view["Dongia"] = _dongia;
                    }
                    _kluong = LIB.ConvertString.NumbertoDB(_view[ThanhphansoiFields.Khoiluong.Name].ToString());
                    _view["Thanhtien"] = _dongia * _kluong;
                    tongkl += _kluong;
                    tongtt += _dongia * _kluong;
                }
                txt_TONGKL.Text = tongkl.ToString("#.###,00", new System.Globalization.CultureInfo("vi-VN"));
                txt_TONGTIEN.Text = tongtt.ToString("#.###,00", new System.Globalization.CultureInfo("vi-VN"));
                txt_DONGIA.Text = (tongtt / tongkl).ToString("#.###,00", new System.Globalization.CultureInfo("vi-VN"));
                //-------Tính tỷ lệ phần trăm khối lượng
                foreach (GridEXRow _grid in listGrid)
                {
                    DataRowView _view = (DataRowView)_grid.DataRow;
                    if (_view == null) continue;
                    _view[ThanhphansoiFields.Tylephantram.Name] = LIB.ConvertString.NumbertoDB(_view[ThanhphansoiFields.Khoiluong.Name].ToString()) / tongkl * 100;
                }
            }
            catch { }
        }
        #endregion

        void BS_THANHPHANSOI_H_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_THANHPHANSOI_H.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_THANHPHANSOI_H.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[ThanhphansoiFields.Macongthuc.Name].ToString();

                    SHOWGRID(MAHIEU_PK);
                    #region Load grid
                    //try
                    //{
                    //    DataRow[] drArr = DT_THANHPHANSOI_D.Select(ThanhphansoiFields.Macongthuc.Name + "='" + MAHIEU_PK + "'");
                    //    if (drArr.Length != 0)
                    //    {
                    //        DT_THANHPHANSOI_D_FILL = drArr.CopyToDataTable();
                    //    }
                    //    else DT_THANHPHANSOI_D_FILL.Clear();
                    //    GRID_THANHPHANSOI_D.DataSource = DT_THANHPHANSOI_D_FILL;
                    //}
                    //catch (Exception ex) { }
                    #endregion

                    txt_MACONGTHUC.Text = _Rowview.Row[ThanhphansoiFields.Macongthuc.Name].ToString();
                    txt_TENCONGTHUC.Text = _Rowview.Row[ThanhphansoiFields.Tencongthuc.Name].ToString();
                    txt_Doben.Text = _Rowview.Row[ThanhphansoiFields.Doben.Name].ToString();
                    txt_Dodandai.Text = _Rowview.Row[ThanhphansoiFields.Dodandai.Name].ToString();
                }
                else 
                {
                    SHOWGRID("");
                    GD.SXBB.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.SXBB.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container)); 
                }
                Tinhtongkhoiluong();
            }
            catch {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng, xin mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void BS_THANHPHANSOI_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.SXBB.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.SXBB.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_THANHPHANSOI_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_THANHPHANSOI_D.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[ThanhphansoiFields.Id.Name].ToString();
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
                //DT_THANHPHANSOI_D_FILL.Clear();
                DT_THANHPHANSOI_D = new ThanhphansoiManager().Clone();
                DT_THANHPHANSOI_D.Columns.Add("Dongia", Type.GetType("System.Decimal"));
                DT_THANHPHANSOI_D.Columns.Add("Thanhtien", Type.GetType("System.Decimal"));
                BS_THANHPHANSOI_D = new BindingSource(DT_THANHPHANSOI_D, null);
                GRID_THANHPHANSOI_D.DataSource = BS_THANHPHANSOI_D;
            }
            else
            {
                DT_THANHPHANSOI_D = new ThanhphansoiManager().SelectByMacongthucRDT(MAHIEU_PK);
                DT_THANHPHANSOI_D.Columns.Add("Dongia", Type.GetType("System.Decimal"));
                DT_THANHPHANSOI_D.Columns.Add("Thanhtien", Type.GetType("System.Decimal"));

                DataView Source_View = new DataView(DT_THANHPHANSOI_D);
                BS_THANHPHANSOI_D = new BindingSource();
                BS_THANHPHANSOI_D.DataSource = Source_View;
                GRID_THANHPHANSOI_D.DataSource = BS_THANHPHANSOI_D;
            }
            BS_THANHPHANSOI_D.CurrentChanged += new EventHandler(BS_THANHPHANSOI_D_CurrentChanged);
            BS_THANHPHANSOI_D_CurrentChanged((new object()), (new EventArgs()));
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            EntityCollection _ThanhphansoiEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_THANHPHANSOI_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                ThanhphansoiEntity _ThanhphansoiEntity = new ThanhphansoiEntity();
                _ThanhphansoiEntity.Macongthuc = txt_MACONGTHUC.Text.Trim();
                _ThanhphansoiEntity.Tencongthuc = txt_TENCONGTHUC.Text.Trim();
                try { _ThanhphansoiEntity.Doben = Convert.ToDecimal(txt_Doben.Text.Trim()); }
                catch { }
                try { _ThanhphansoiEntity.Dodandai = Convert.ToDecimal(txt_Dodandai.Text.Trim()); }
                catch { }
                _ThanhphansoiEntity.Manguyenlieu = _view[ThanhphansoiFields.Manguyenlieu.Name].ToString();
                _ThanhphansoiEntity.Tennguyenlieu = _view[ThanhphansoiFields.Tennguyenlieu.Name].ToString();
                try { _ThanhphansoiEntity.Khoiluong = Convert.ToDecimal(_view[ThanhphansoiFields.Khoiluong.Name].ToString()); }
                catch { }
                try { _ThanhphansoiEntity.Tylephantram = Convert.ToDecimal(_view[ThanhphansoiFields.Tylephantram.Name].ToString()); }
                catch { }
                try { _ThanhphansoiEntity.Id = Convert.ToInt64(_view[ThanhphansoiFields.Id.Name].ToString()); }
                catch { }

                _ThanhphansoiEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_ThanhphansoiEntity.IsNew && _ThanhphansoiManager.SelectOne(_ThanhphansoiEntity.Id) != null)
                    _ThanhphansoiEntity.IsNew = false;

                _ThanhphansoiEntityCol.Add(_ThanhphansoiEntity);
            }

            if (_ThanhphansoiEntityCol.Count > 0)
            {
                foreach (ThanhphansoiEntity _tpsEntity in _ThanhphansoiEntityCol)
                {
                    if (_tpsEntity.IsNew)
                        _ThanhphansoiManager.Insert(_tpsEntity);
                    else
                        _ThanhphansoiManager.Update(_tpsEntity);
                }

                _ThanhphansoiEntity.Macongthuc = txt_MACONGTHUC.Text.Trim();
                _ThanhphansoiEntity.Tencongthuc = txt_TENCONGTHUC.Text.Trim();
                _ThanhphansoiEntity.Doben = LIB.ConvertString.NumbertoDB(txt_Doben.Text.Trim());
                _ThanhphansoiEntity.Dodandai = LIB.ConvertString.NumbertoDB(txt_Dodandai.Text.Trim());
                if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
                {
                    _str_DMCHUONG_PK = _ThanhphansoiEntity.Macongthuc; //_ThanhphansoiManager.InsertV2(_ThanhphansoiEntity, r_Insert, DT_THANHPHANSOI, BS_THANHPHANSOI);
                    r_Insert[ThanhphansoiFields.Macongthuc.Name] = _ThanhphansoiEntity.Macongthuc;
                    r_Insert[ThanhphansoiFields.Tencongthuc.Name] = _ThanhphansoiEntity.Tencongthuc;
                    r_Insert[ThanhphansoiFields.Doben.Name] = _ThanhphansoiEntity.Doben;
                    r_Insert[ThanhphansoiFields.Dodandai.Name] = _ThanhphansoiEntity.Dodandai;
                    GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                    GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                    GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                    GD.SXBB.BLL.MenuroleManager.set_Enable_controls(_ThanhphansoiManager.Convert(_ThanhphansoiEntity), GD.SXBB.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    BS_THANHPHANSOI_H.ResetCurrentItem();
                    btn_XOADONG.Enabled = false;
                    BS_THANHPHANSOI_H_CurrentChanged(new object(), new EventArgs());
                }
                else
                {
                    GRID_THANHPHANSOI_H.CurrentRow.Cells[ThanhphansoiFields.Macongthuc.Name].Value = _ThanhphansoiEntity.Macongthuc;
                    GRID_THANHPHANSOI_H.CurrentRow.Cells[ThanhphansoiFields.Tencongthuc.Name].Value = _ThanhphansoiEntity.Tencongthuc;
                    GRID_THANHPHANSOI_H.CurrentRow.Cells[ThanhphansoiFields.Doben.Name].Value = _ThanhphansoiEntity.Doben;
                    GRID_THANHPHANSOI_H.CurrentRow.Cells[ThanhphansoiFields.Dodandai.Name].Value = _ThanhphansoiEntity.Dodandai;
                    GD.SXBB.BLL.MenuroleManager.set_Enable_controls(_ThanhphansoiManager.Convert(_ThanhphansoiEntity), GD.SXBB.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                    GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                    GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                    BS_THANHPHANSOI_H.ResetCurrentItem();
                    BS_THANHPHANSOI_H_CurrentChanged(new object(), new EventArgs());
                    btn_XOADONG.Enabled = false;
                }
            }
            else
                btn_KHOIPHUC_Click(new object(), new EventArgs());
            return _str_DMCHUONG_PK;      
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            string _Maydet = txt_MACONGTHUC.Text.Trim();
            GD.SXBB.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENCONGTHUC.Text = string.Empty;
            ThanhphansoiManager _ThanhphansoiManager = new ThanhphansoiManager();
            ThanhphansoiEntity _ThanhphansoiEntity = new ThanhphansoiEntity();
            r_Insert = DT_THANHPHANSOI_H.NewRow();
            DT_THANHPHANSOI_H.Rows.Add(r_Insert);
            BS_THANHPHANSOI_H.Position = DT_THANHPHANSOI_H.Rows.Count;
            GRID_THANHPHANSOI_D.Enabled = true;
            GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_THANHPHANSOI_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_MACONGTHUC.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.SXBB.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.SXBB.BLL.MenuroleManager.set_Enable_controls(GD.SXBB.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_THANHPHANSOI_H.Enabled = false;
            btn_XOADONG.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.SXBB.BLL.MenuroleManager.set_Enable_controls(GD.SXBB.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.SXBB.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {  }));
                btn_XOADONG.Enabled = true;
            }
            GRID_THANHPHANSOI_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_THANHPHANSOI_D.Enabled = true;
            GRID_THANHPHANSOI_H.Enabled = false;
            btn_XOADONG.Enabled = true;
            btn_SAOCHEP.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_THANHPHANSOI_H.Rows.Remove(r_Insert);
            }
            BS_THANHPHANSOI_H_CurrentChanged(new object(), new EventArgs());
            GD.SXBB.BLL.MenuroleManager.set_Enable_controls(GD.SXBB.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_THANHPHANSOI_H.Enabled = true;
            btn_XOADONG.Enabled = false;
            btn_SAOCHEP.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.SXBB.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            ThanhphansoiManager _ThanhphansoiManager = new ThanhphansoiManager();
            ThanhphansoiEntity _ThanhphansoiEntity = new ThanhphansoiEntity();
            //_ThanhphansoiEntity = _ThanhphansoiManager.SelectOne(MAHIEU_PK);
            if (_ThanhphansoiEntity != null && MessageBox.Show("Xóa thành phần sợi: " + txt_MACONGTHUC.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_THANHPHANSOI_D.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[ThanhphansoiFields.Id.Name].ToString()))
                        {
                            try { _ThanhphansoiManager.Delete(Convert.ToInt64(_view[ThanhphansoiFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_ThanhphansoiManager.Delete(MAHIEU_PK);
                    try { GRID_THANHPHANSOI_H.CurrentRow.Delete(); }
                    catch { }
                    BS_THANHPHANSOI_H_CurrentChanged(new object(), new EventArgs());
                    GD.SXBB.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.SXBB.BLL.MenuroleManager.set_Enable_controls(_ThanhphansoiManager.Convert(_ThanhphansoiEntity), GD.SXBB.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa thành phần sợi: " + txt_MACONGTHUC.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_THANHPHANSOI_H.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (txt_MACONGTHUC.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập loại sợi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACONGTHUC.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(MAHIEU_PK) && _ThanhphansoiManager.SelectByMacongthucRDT(txt_MACONGTHUC.Text).Rows.Count > 0)
            {
                MessageBox.Show("Loại sợi bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACONGTHUC.Focus();
                return;
            }
            else
            {
                GD.SXBB.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.SXBB.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_THANHPHANSOI_H.Enabled = true;
                //BS_THANHPHANSOI_H.MoveLast();
                btn_THEMMOI.Focus();
                GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
            DataRowView _view = (DataRowView)GRID_THANHPHANSOI_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[ThanhphansoiFields.Id.Name].ToString();
            string _MANGUYENLIEU = _view[ThanhphansoiFields.Manguyenlieu.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK)) return;
            ThanhphansoiManager _ThanhphansoiManager = new ThanhphansoiManager();
            ThanhphansoiEntity _ThanhphansoiEntity = new ThanhphansoiEntity();
            try { _ThanhphansoiEntity = _ThanhphansoiManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
            catch { }
            if (_ThanhphansoiEntity != null && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _ThanhphansoiManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                    DataRow[] drArr = DT_THANHPHANSOI_D.Select(ThanhphansoiFields.Id.Name + "='" + _MAHIEU_PK + "'");
                    DT_THANHPHANSOI_D.Rows.Remove(drArr[0]);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa dòng " + _MANGUYENLIEU + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                BS_THANHPHANSOI_D.ResetCurrentItem();
                GRID_THANHPHANSOI_D.DataSource = BS_THANHPHANSOI_D;
            }
            GRID_THANHPHANSOI_D.Enabled = true;
        }

        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                SXBB.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                ThanhphansoiManager _ThanhphansoiManager = new ThanhphansoiManager();
                ThanhphansoiEntity _ThanhphansoiEntity = new ThanhphansoiEntity();
                r_Insert = DT_THANHPHANSOI_H.NewRow();
                DT_THANHPHANSOI_H.Rows.Add(r_Insert);
                DataTable dt = new ThanhphansoiManager().SelectByMacongthucRDT(MAHIEU_PK);
                DataRow[] drCopy = DT_THANHPHANSOI_H.Select(ThanhphansoiFields.Macongthuc.Name + "= '" + MAHIEU_PK + "'");
                BS_THANHPHANSOI_H.Position = DT_THANHPHANSOI_H.Rows.Count;
                GRID_THANHPHANSOI_D.Enabled = true;
                GRID_THANHPHANSOI_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_THANHPHANSOI_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_THANHPHANSOI_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
                GRID_THANHPHANSOI_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;

                txt_MACONGTHUC.Text = drCopy[0][ThanhphansoiFields.Macongthuc.Name].ToString();
                txt_TENCONGTHUC.Text = drCopy[0][ThanhphansoiFields.Tencongthuc.Name].ToString();
                txt_Dodandai.Text = drCopy[0][ThanhphansoiFields.Dodandai.Name].ToString();

                foreach (DataRow dr in dt.Rows)
                {
                    DataRow r_Detail = DT_THANHPHANSOI_D.NewRow();
                    r_Detail[ThanhphansoiFields.Manguyenlieu.Name] = dr[ThanhphansoiFields.Manguyenlieu.Name];
                    r_Detail[ThanhphansoiFields.Tennguyenlieu.Name] = dr[ThanhphansoiFields.Tennguyenlieu.Name];
                    r_Detail[ThanhphansoiFields.Khoiluong.Name] = dr[ThanhphansoiFields.Khoiluong.Name];
                    r_Detail[ThanhphansoiFields.Tylephantram.Name] = dr[ThanhphansoiFields.Tylephantram.Name];
                    DT_THANHPHANSOI_D.Rows.Add(r_Detail);
                }

                MAHIEU_PK = "";
                txt_MACONGTHUC.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                SXBB.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                SXBB.BLL.MenuroleManager.set_Enable_controls(SXBB.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_THANHPHANSOI_H.Enabled = false;
            }
            catch { }
            btn_SAOCHEP.Enabled = false;
        }
        #endregion

        private void FRM_THANHPHANSOI_FormClosing(object sender, FormClosingEventArgs e)
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
