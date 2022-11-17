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

namespace GD.BBPH.APP.KHO
{
    public partial class FRM_NHAPKHONGUYENLIEU : FRM_DMPARENT
    {
        private NhapkhonguyenlieuManager _NhapkhonguyenlieuManager = new NhapkhonguyenlieuManager();
        private NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_NHAPKHONGUYENLIEU = new DataTable(), DT_NHAPKHONGUYENLIEU_CHITIET = new DataTable(), DT_NHAPKHONGUYENLIEU_CHITIET_FILL = new DataTable();
        private BindingSource BS_NHAPKHONGUYENLIEU = new BindingSource(), BS_NHAPKHONGUYENLIEU_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_NHAPKHONGUYENLIEU = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_NHAPKHONGUYENLIEU_CHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";

        private DataTable DT_DMNGUYENLIEU = new DataTable(), DT_DMKHO = new DataTable(), DT_DMLYDONHAPXUAT = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_NHAPKHONGUYENLIEU");
                        DT_NHAPKHONGUYENLIEU = LIB.Procedures.Danhsachnhapkhonguyenlieu(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty); //LIB.SESSION_START.DT_NHAPKHONGUYENLIEU;
                        DT_NHAPKHONGUYENLIEU_CHITIET = LIB.SESSION_START.DT_NHAPKHONGUYENLIEU;

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

        public FRM_NHAPKHONGUYENLIEU()
        {
            InitializeComponent();
            NhapkhonguyenlieuManager _NhapkhonguyenlieuManager = new NhapkhonguyenlieuManager();
            DataTable dt111 = LIB.Procedures.Danhsachnhapkhonguyenlieu(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPKHONGUYENLIEU.xml");
            dt111 = _NhapkhonguyenlieuManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPKHONGUYENLIEU_CHITIET.xml");

            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPKHONGUYENLIEU.xml", GRID_NHAPKHONGUYENLIEU, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPKHONGUYENLIEU_CHITIET.xml", GRID_NHAPKHONGUYENLIEU_CHITIET, pne_CHITIET);
            GRID_NHAPKHONGUYENLIEU.RootTable.SortKeys.Add(NhapkhonguyenlieuFields.Ngaynhap.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GRID_NHAPKHONGUYENLIEU_CHITIET.FilterMode = FilterMode.None;
            GRID_NHAPKHONGUYENLIEU_CHITIET.GroupByBoxVisible = false;
            GRID_NHAPKHONGUYENLIEU_CHITIET.DeletingRecord += GRID_NHAPKHONGUYENLIEU_CHITIET_DeletingRecord;

            FORM_PROCESS();
            //GRID_NHAPKHONGUYENLIEU_CHITIET.COMBO_MULTICOLUMN(GRID_NHAPKHONGUYENLIEU_CHITIET, NhapkhonguyenlieuFields.Masp.Name, DanhmuchanghoaFields.Tenhieu.Name, DanhmuchanghoaFields.Mahieu.Name, DanhmuchanghoaFields.Mahieu.Name, DT_DMHANG);
            //GRID_NHAPKHONGUYENLIEU_CHITIET.CellEdited += GRID_NHAPKHONGUYENLIEU_CHITIET_CellEdited;
            //GRID_NHAPKHONGUYENLIEU_CHITIET.RecordsDeleted += GRID_NHAPKHONGUYENLIEU_CHITIET_RecordsDeleted;
            //GRID_NHAPKHONGUYENLIEU_CHITIET.RecordUpdated += GRID_NHAPKHONGUYENLIEU_CHITIET_RecordUpdated;
            //GRID_NHAPKHONGUYENLIEU_CHITIET.DeletingRecord += GRID_NHAPKHONGUYENLIEU_CHITIET_DeletingRecord;
            ////GRID_NHAPKHONGUYENLIEU_CHITIET.Click += GRID_NHAPKHONGUYENLIEU_CHITIET_Click;
            //GRID_NHAPKHONGUYENLIEU_CHITIET.RootTable.Columns["Thanhtien"].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_NHAPKHONGUYENLIEU);
            BS_NHAPKHONGUYENLIEU = new BindingSource();
            BS_NHAPKHONGUYENLIEU.DataSource = Source_View;
            GRID_NHAPKHONGUYENLIEU.DataSource = BS_NHAPKHONGUYENLIEU;
            BS_NHAPKHONGUYENLIEU.CurrentChanged += new EventHandler(BS_NHAPKHONGUYENLIEU_CurrentChanged);
            BS_NHAPKHONGUYENLIEU_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_NHAPKHONGUYENLIEU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_NHAPKHONGUYENLIEU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_NHAPKHONGUYENLIEU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[NhapkhonguyenlieuFields.Ngaynhap.Name].ToString();

                    //txt_MAHIEU.Text = _Rowview.Row[NhapkhonguyenlieuFields.Id.Name].ToString();
                    txt_NGAY.Text = _Rowview.Row[NhapkhonguyenlieuFields.Ngaynhap.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Makho.Name].ToString();
                    txt_MALYDO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Malydo.Name].ToString();

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_NHAPKHONGUYENLIEU_CurrentChanged"); }
        }
        void BS_NHAPKHONGUYENLIEU_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_NHAPKHONGUYENLIEU_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_NHAPKHONGUYENLIEU_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[NhapkhonguyenlieuFields.Id.Name].ToString();
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
                DT_NHAPKHONGUYENLIEU_CHITIET_FILL = new NhapkhonguyenlieuManager().Clone();
                BS_NHAPKHONGUYENLIEU_CHITIET = new BindingSource(DT_NHAPKHONGUYENLIEU_CHITIET_FILL, null);
                GRID_NHAPKHONGUYENLIEU_CHITIET.DataSource = BS_NHAPKHONGUYENLIEU_CHITIET;
            }
            else
            {
                DT_NHAPKHONGUYENLIEU_CHITIET_FILL = new NhapkhonguyenlieuManager().SelectByNgayKhoLydoRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), txt_MAKHO.Text.Trim(), txt_MALYDO.Text.Trim());

                DataView Source_View = new DataView(DT_NHAPKHONGUYENLIEU_CHITIET_FILL);
                BS_NHAPKHONGUYENLIEU_CHITIET = new BindingSource();
                BS_NHAPKHONGUYENLIEU_CHITIET.DataSource = Source_View;
                GRID_NHAPKHONGUYENLIEU_CHITIET.DataSource = BS_NHAPKHONGUYENLIEU_CHITIET;
            }
            BS_NHAPKHONGUYENLIEU_CHITIET.CurrentChanged += new EventHandler(BS_NHAPKHONGUYENLIEU_CHITIET_CurrentChanged);
            BS_NHAPKHONGUYENLIEU_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_NHAPKHONGUYENLIEU_CHITIET_FILL.NewRow();
            r_Detail[NhapkhonguyenlieuFields.Manguyenlieu.Name] = txt_MANGUYENLIEU.Text;
            r_Detail[NhapkhonguyenlieuFields.Tennguyenlieu.Name] = txt_TENNGUYENLIEU.Text;
            r_Detail[NhapkhonguyenlieuFields.Soluong.Name] = txt_SOLUONG.Text;
            try { r_Detail[NhapkhonguyenlieuFields.Manguyenlieu.Name] = Convert.ToInt64(txt_MANGUYENLIEU.Text.Trim()); }
            catch { }
            r_Detail[NhapkhonguyenlieuFields.Donvitinh.Name] = txt_DONVITINH.Text;
            r_Detail[NhapkhonguyenlieuFields.Malydo.Name] = txt_MALYDO.Text;
            r_Detail[NhapkhonguyenlieuFields.Tenlydo.Name] = txt_TENLYDO.Text;
            //r_Detail[NhapkhonguyenlieuFields.Loai.Name] = txt_LOAI.Text;
            try { r_Detail[NhapkhonguyenlieuFields.Soluong.Name] = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim()); }
            catch { }
            //try { r_Detail[NhapkhonguyenlieuFields.Klxuat.Name] = LIB.ConvertString.NumbertoDB(txt_Klxuat.Text.Trim()); }
            //catch { }

            DT_NHAPKHONGUYENLIEU_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_NHAPKHONGUYENLIEU_CHITIET_FILL);
            BS_NHAPKHONGUYENLIEU_CHITIET = new BindingSource();
            BS_NHAPKHONGUYENLIEU_CHITIET.DataSource = Source_View;
            GRID_NHAPKHONGUYENLIEU_CHITIET.DataSource = BS_NHAPKHONGUYENLIEU_CHITIET;
            BS_NHAPKHONGUYENLIEU_CHITIET.Position = DT_NHAPKHONGUYENLIEU_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_NHAPKHONGUYENLIEU_CHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[NhapkhonguyenlieuFields.Id.Name].ToString();
            string _MANGUYENLIEU = _view[NhapkhonguyenlieuFields.Manguyenlieu.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_NHAPKHONGUYENLIEU_CHITIET.CurrentRow.Delete();
            }
            else
            {
                NhapkhonguyenlieuManager _NhapkhonguyenlieuManager = new NhapkhonguyenlieuManager();
                NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
                try { _NhapkhonguyenlieuEntity = _NhapkhonguyenlieuManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_NhapkhonguyenlieuEntity != null && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _NhapkhonguyenlieuManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_NHAPKHONGUYENLIEU_CHITIET_FILL.Select(NhapkhonguyenlieuFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_NHAPKHONGUYENLIEU_CHITIET_FILL.Rows.Remove(drArr[0]);
                        //GRID_NHAPKHONGUYENLIEU_CHITIET.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MANGUYENLIEU + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_NHAPKHONGUYENLIEU_CHITIET.ResetCurrentItem();
                    GRID_NHAPKHONGUYENLIEU_CHITIET.DataSource = BS_NHAPKHONGUYENLIEU_CHITIET;
                }
                GRID_NHAPKHONGUYENLIEU_CHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        private void GRID_NHAPKHONGUYENLIEU_CHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }
        #endregion
        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngay = Convert.ToDateTime(txt_NGAY.Text.Trim());
            String _kho = txt_MAKHO.Text.Trim();
            String _tenkho = txt_TENKHO.Text.Trim();

            EntityCollection _NhapkhonguyenlieuEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_NHAPKHONGUYENLIEU_CHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
                _NhapkhonguyenlieuEntity.Ngaynhap = _ngay;
                _NhapkhonguyenlieuEntity.Makho = _kho;
                _NhapkhonguyenlieuEntity.Makho = _tenkho;
                _NhapkhonguyenlieuEntity.Manguyenlieu = _view.Row[NhapkhonguyenlieuFields.Manguyenlieu.Name].ToString();
                _NhapkhonguyenlieuEntity.Tennguyenlieu = _view.Row[NhapkhonguyenlieuFields.Tennguyenlieu.Name].ToString();
                try { _NhapkhonguyenlieuEntity.Soluong = Convert.ToDecimal(_view.Row[NhapkhonguyenlieuFields.Soluong.Name].ToString()); }
                catch { }
                _NhapkhonguyenlieuEntity.Donvitinh = _view.Row[NhapkhonguyenlieuFields.Donvitinh.Name].ToString();
                _NhapkhonguyenlieuEntity.Malydo = _view.Row[NhapkhonguyenlieuFields.Malydo.Name].ToString();
                _NhapkhonguyenlieuEntity.Tenlydo = _view.Row[NhapkhonguyenlieuFields.Tenlydo.Name].ToString();

                #region xét isnew
                try { _NhapkhonguyenlieuEntity.Id = Convert.ToInt64(_view[NhapkhonguyenlieuFields.Id.Name].ToString()); }
                catch { }

                _NhapkhonguyenlieuEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_NhapkhonguyenlieuEntity.IsNew)
                {
                    EntityCollection drDHCT = (new NhapkhonguyenlieuManager()).SelectById(_NhapkhonguyenlieuEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _NhapkhonguyenlieuEntity.Ngaysua = DateTime.Now;
                        _NhapkhonguyenlieuEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _NhapkhonguyenlieuEntity.IsNew = false;
                    }
                    else
                    {
                        _NhapkhonguyenlieuEntity.Ngaytao = DateTime.Now;
                        _NhapkhonguyenlieuEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }
                #endregion

                if (!string.IsNullOrEmpty(_NhapkhonguyenlieuEntity.Manguyenlieu))
                    _NhapkhonguyenlieuEntityCol.Add(_NhapkhonguyenlieuEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity in _NhapkhonguyenlieuEntityCol)
            {
                if (_NhapkhonguyenlieuEntity.IsNew)
                {
                    DataRow _r_Insert = DT_NHAPKHONGUYENLIEU_CHITIET.NewRow();
                    DT_NHAPKHONGUYENLIEU_CHITIET.Rows.Add(_r_Insert);
                    _NhapkhonguyenlieuManager.InsertV2(_NhapkhonguyenlieuEntity, _r_Insert, DT_NHAPKHONGUYENLIEU_CHITIET, BS_NHAPKHONGUYENLIEU_CHITIET);
                }
                else _NhapkhonguyenlieuManager.Update(_NhapkhonguyenlieuEntity);
            }

            GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaynhap.Name].Value = _ngay;
            GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Makho.Name].Value = _kho;
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_NhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_NHAPKHONGUYENLIEU.NewRow();
            DT_NHAPKHONGUYENLIEU.Rows.Add(r_Insert);
            BS_NHAPKHONGUYENLIEU.Position = DT_NHAPKHONGUYENLIEU.Rows.Count;
            GRID_NHAPKHONGUYENLIEU_CHITIET.Enabled = true;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPKHONGUYENLIEU_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            txt_MAKHO.Text = txt_TENKHO.Text = txt_SOLUONG.Text = txt_DONVITINH.Text = txt_MANGUYENLIEU.Text = txt_TENNGUYENLIEU.Text = txt_MALYDO.Text = txt_TENLYDO.Text = string.Empty;
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_NHAPKHONGUYENLIEU.Enabled = false;

            //---tu dong dien tham so
            txt_NGAY.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_NGAY }));
                //txt_TENHIEU.Focus();
            }
            GRID_NHAPKHONGUYENLIEU_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPKHONGUYENLIEU_CHITIET.Enabled = true;
            GRID_NHAPKHONGUYENLIEU.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_NHAPKHONGUYENLIEU.Rows.Remove(r_Insert);
            }
            BS_NHAPKHONGUYENLIEU_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_NHAPKHONGUYENLIEU.Enabled = true;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            NhapkhonguyenlieuManager _NhapkhonguyenlieuManager = new NhapkhonguyenlieuManager();
            NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
            _NhapkhonguyenlieuEntity = _NhapkhonguyenlieuManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_NhapkhonguyenlieuEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - "/* + txt_TENHIEU.Text*/, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _NhapkhonguyenlieuManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_NHAPKHONGUYENLIEU.CurrentRow.Delete();
                    BS_NHAPKHONGUYENLIEU_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_NhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_NHAPKHONGUYENLIEU.Enabled = true;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _NhapkhonguyenlieuManager.SelectOne(Convert.ToInt64(txt_MAHIEU.Text.Trim())) != null)
            //{
            //    MessageBox.Show("Mã khách hàng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_MAHIEU.Focus();
            //    return;
            //}
            //else if (txt_MAHIEU.Text == "")
            //{
            //    MessageBox.Show("Yêu cầu nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_MAHIEU.Focus();
            //    return;
            //}
            ////else if (txt_TENHIEU.Text == "")
            ////{
            ////    MessageBox.Show("Yêu cầu nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ////    txt_TENHIEU.Focus();
            ////    return;
            ////}
            //else
            //{
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            MAHIEU_PK = Save_Data(MAHIEU_PK);
            GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
            GRID_NHAPKHONGUYENLIEU.Enabled = true;
            btn_THEMMOI.Focus();
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPKHONGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

            //}
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MANGUYENLIEU_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MANGUYENLIEU.Text.Trim()) || DT_DMNGUYENLIEU == null || DT_DMNGUYENLIEU.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MANGUYENLIEU.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNguyenlieu(_str_MACANTIM, DT_DMNGUYENLIEU);
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
                txt_TENNGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
        }

        private DataRow checkmaNguyenlieu(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmnguyenlieuFields.Manl.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAKHO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHO.Text.Trim()) || DT_DMKHO == null || DT_DMKHO.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MANGUYENLIEU.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKho(_str_MACANTIM, DT_DMKHO);
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
                txt_TENKHO.Text = _RowViewSelect[DmkhoFields.Tenkho.Name].ToString();
        }
        private DataRow checkmaKho(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhoFields.Makho.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MALYDO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MALYDO.Text.Trim()) || DT_DMLYDONHAPXUAT == null || DT_DMLYDONHAPXUAT.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MALYDO.Text.Trim().ToUpper();
            _RowViewSelect = checkmaLydo(_str_MACANTIM, DT_DMLYDONHAPXUAT);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMLYDOXUATKHO.xml",
                        DT_DMLYDONHAPXUAT, DmlydonhapxuatFields.Malydo.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MALYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Malydo.Name].ToString();
                txt_TENLYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Tenlydo.Name].ToString();
            }
            else
                txt_TENLYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Tenlydo.Name].ToString();
        }

        private DataRow checkmaLydo(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmlydonhapxuatFields.Malydo.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        #endregion

        #region Shortcut Key
        private void txt_MALYDO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_LYDONHAPXUAT frm_Dm = new FRM_LYDONHAPXUAT();
                frm_Dm.Text = "Danh mục lý do";
                frm_Dm.ShowDialog();
                DT_DMLYDONHAPXUAT = new DmlydonhapxuatManager().SelectAllRDT();
            }
        }

        private void txt_MAKHO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMKHO frm_Dm = new FRM_DMKHO();
                frm_Dm.Text = "Danh mục kho";
                frm_Dm.ShowDialog();
                DT_DMKHO = new DmkhoManager().SelectAllRDT();
            }
        }
        private void txt_MANGUYENLIEU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMNGUYENLIEU frm_Dm = new FRM_DMNGUYENLIEU();
                frm_Dm.Text = "Danh mục nguyên liệu";
                frm_Dm.ShowDialog();
                DT_DMNGUYENLIEU = new DmnguyenlieuManager().SelectAllRDT();
            }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_NHAPKHONGUYENLIEU.ColumnAutoResize = true;
            else
                GRID_NHAPKHONGUYENLIEU.ColumnAutoResize = false;
        }

        private void FRM_NHAPKHONGUYENLIEU_FormClosing(object sender, FormClosingEventArgs e)
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
