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

namespace GD.BBPH.APP.THOI
{
    public partial class FRM_TKNLTHOI : FRM_DMPARENT
    {
        private TknguyenlieuthoiManager _TknguyenlieuthoiManager = new TknguyenlieuthoiManager();
        private TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_TKNLTHOI = new DataTable(), DT_TKNLTHOI_CHITIET = new DataTable(), DT_TKNLTHOI_CHITIET_FILL = new DataTable();
        private BindingSource BS_TKNLTHOI = new BindingSource(), BS_TKNLTHOI_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_TKNLTHOI = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_TKNLTHOI_CHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";

        private DataTable DT_DMNGUYENLIEU = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_TKNLTHOI");
                        DT_TKNLTHOI = LIB.Procedures.Danhsachthongkenguyenlieu(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty); //LIB.SESSION_START.DT_TKNLTHOI;
                        DT_TKNLTHOI_CHITIET = LIB.SESSION_START.DT_TKNLTHOI;

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

        public FRM_TKNLTHOI()
        {
            InitializeComponent();
            TknguyenlieuthoiManager _TknguyenlieuthoiManager = new TknguyenlieuthoiManager();
            DataTable dt111 = LIB.Procedures.Danhsachthongkenguyenlieu(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKNLTHOI.xml");
            dt111 = _TknguyenlieuthoiManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKNLTHOI_CHITIET.xml");

            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKNLTHOI.xml", GRID_TKNLTHOI, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKNLTHOI_CHITIET.xml", GRID_TKNLTHOI_CHITIET, pne_CHITIET);
            GRID_TKNLTHOI.RootTable.SortKeys.Add(TknguyenlieuthoiFields.Ngay.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GRID_TKNLTHOI_CHITIET.FilterMode = FilterMode.None;
            GRID_TKNLTHOI_CHITIET.GroupByBoxVisible = false;
            FORM_PROCESS();
            //GRID_TKNLTHOI_CHITIET.COMBO_MULTICOLUMN(GRID_TKNLTHOI_CHITIET, TknguyenlieuthoiFields.Masp.Name, DanhmuchanghoaFields.Tenhieu.Name, DanhmuchanghoaFields.Mahieu.Name, DanhmuchanghoaFields.Mahieu.Name, DT_DMHANG);
            //GRID_TKNLTHOI_CHITIET.CellEdited += GRID_TKNLTHOI_CHITIET_CellEdited;
            //GRID_TKNLTHOI_CHITIET.RecordsDeleted += GRID_TKNLTHOI_CHITIET_RecordsDeleted;
            //GRID_TKNLTHOI_CHITIET.RecordUpdated += GRID_TKNLTHOI_CHITIET_RecordUpdated;
            //GRID_TKNLTHOI_CHITIET.DeletingRecord += GRID_TKNLTHOI_CHITIET_DeletingRecord;
            ////GRID_TKNLTHOI_CHITIET.Click += GRID_TKNLTHOI_CHITIET_Click;
            //GRID_TKNLTHOI_CHITIET.RootTable.Columns["Thanhtien"].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_TKNLTHOI);
            BS_TKNLTHOI = new BindingSource();
            BS_TKNLTHOI.DataSource = Source_View;
            GRID_TKNLTHOI.DataSource = BS_TKNLTHOI;
            BS_TKNLTHOI.CurrentChanged += new EventHandler(BS_TKNLTHOI_CurrentChanged);
            BS_TKNLTHOI_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_TKNLTHOI_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_TKNLTHOI.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_TKNLTHOI.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[TknguyenlieuthoiFields.Ngay.Name].ToString();

                    //txt_MAHIEU.Text = _Rowview.Row[TknguyenlieuthoiFields.Id.Name].ToString();
                    txt_Ngaythongke.Text = _Rowview.Row[TknguyenlieuthoiFields.Ngay.Name].ToString();
                    txt_Ca.Text = _Rowview.Row[TknguyenlieuthoiFields.Ca.Name].ToString();

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_TKNLTHOI_CurrentChanged"); }
        }
        void BS_TKNLTHOI_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_TKNLTHOI_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_TKNLTHOI_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[TknguyenlieuthoiFields.Id.Name].ToString();
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
                DT_TKNLTHOI_CHITIET_FILL = new TknguyenlieuthoiManager().Clone();
                BS_TKNLTHOI_CHITIET = new BindingSource(DT_TKNLTHOI_CHITIET_FILL, null);
                GRID_TKNLTHOI_CHITIET.DataSource = BS_TKNLTHOI_CHITIET;
            }
            else
            {
                DT_TKNLTHOI_CHITIET_FILL = new TknguyenlieuthoiManager().SelectByNgayCaRDT(Convert.ToDateTime(txt_Ngaythongke.Text.Trim()), Convert.ToInt32(txt_Ca.Text.Trim()));

                DataView Source_View = new DataView(DT_TKNLTHOI_CHITIET_FILL);
                BS_TKNLTHOI_CHITIET = new BindingSource();
                BS_TKNLTHOI_CHITIET.DataSource = Source_View;
                GRID_TKNLTHOI_CHITIET.DataSource = BS_TKNLTHOI_CHITIET;
            }
            BS_TKNLTHOI_CHITIET.CurrentChanged += new EventHandler(BS_TKNLTHOI_CHITIET_CurrentChanged);
            BS_TKNLTHOI_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_TKNLTHOI_CHITIET_FILL.NewRow();
            r_Detail[TknguyenlieuthoiFields.Manguyenlieu.Name] = txt_Manguyenlieu.Text;
            r_Detail[TknguyenlieuthoiFields.Tennguyenlieu.Name] = txt_Tennguyenlieu.Text;
            //r_Detail[TknguyenlieuthoiFields.Klnhap.Name] = txt_Klnhap.Text;
            //try { r_Detail[TknguyenlieuthoiFields.Manguyenlieu.Name] = Convert.ToInt64(txt_Manguyenlieu.Text.Trim()); }
            //catch { }
            //r_Detail[TknguyenlieuthoiFields.Loaihang.Name] = txt_LOAIHANG.Text;
            //r_Detail[TknguyenlieuthoiFields.Klxuat.Name] = txt_Klxuat.Text;
            //r_Detail[TknguyenlieuthoiFields.Mauin.Name] = txt_MAUIN.Text;
            //r_Detail[TknguyenlieuthoiFields.Loai.Name] = txt_LOAI.Text;
            try { r_Detail[TknguyenlieuthoiFields.Klnhap.Name] = LIB.ConvertString.NumbertoDB(txt_Klnhap.Text.Trim()); }
            catch { }
            try { r_Detail[TknguyenlieuthoiFields.Klxuat.Name] = LIB.ConvertString.NumbertoDB(txt_Klxuat.Text.Trim()); }
            catch { }

            DT_TKNLTHOI_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_TKNLTHOI_CHITIET_FILL);
            BS_TKNLTHOI_CHITIET = new BindingSource();
            BS_TKNLTHOI_CHITIET.DataSource = Source_View;
            GRID_TKNLTHOI_CHITIET.DataSource = BS_TKNLTHOI_CHITIET;
            BS_TKNLTHOI_CHITIET.Position = DT_TKNLTHOI_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_TKNLTHOI_CHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[TknguyenlieuthoiFields.Id.Name].ToString();
            string _MANGUYENLIEU = _view[TknguyenlieuthoiFields.Manguyenlieu.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_TKNLTHOI_CHITIET.CurrentRow.Delete();
            }
            else
            {
                TknguyenlieuthoiManager _TknguyenlieuthoiManager = new TknguyenlieuthoiManager();
                TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
                try { _TknguyenlieuthoiEntity = _TknguyenlieuthoiManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_TknguyenlieuthoiEntity != null && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _TknguyenlieuthoiManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_TKNLTHOI_CHITIET_FILL.Select(TknguyenlieuthoiFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_TKNLTHOI_CHITIET_FILL.Rows.Remove(drArr[0]);
                        //GRID_TKNLTHOI_CHITIET.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MANGUYENLIEU + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_TKNLTHOI_CHITIET.ResetCurrentItem();
                    GRID_TKNLTHOI_CHITIET.DataSource = BS_TKNLTHOI_CHITIET;
                }
                GRID_TKNLTHOI_CHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        #endregion
        private string Save_Data(string _str_Tknguyenlieuthoi_PK)
        {
            DateTime _ngay = Convert.ToDateTime(txt_Ngaythongke.Text.Trim());
            int _ca = Convert.ToInt32(txt_Ca.Text.Trim());
          
            EntityCollection _TknguyenlieuthoiEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_TKNLTHOI_CHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                TknguyenlieuthoiEntity _tknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
                _tknguyenlieuthoiEntity.Ngay = _ngay;
                _tknguyenlieuthoiEntity.Ca = _ca;
                _tknguyenlieuthoiEntity.Manguyenlieu = _view.Row[TknguyenlieuthoiFields.Manguyenlieu.Name].ToString();
                _tknguyenlieuthoiEntity.Tennguyenlieu = _view.Row[TknguyenlieuthoiFields.Tennguyenlieu.Name].ToString();
                try { _tknguyenlieuthoiEntity.Klnhap = Convert.ToDecimal(_view.Row[TknguyenlieuthoiFields.Klnhap.Name].ToString()); }
                catch { }
                try { _tknguyenlieuthoiEntity.Klxuat = Convert.ToDecimal(_view.Row[TknguyenlieuthoiFields.Klxuat.Name].ToString()); }
                catch { }
                if (!string.IsNullOrEmpty(_tknguyenlieuthoiEntity.Manguyenlieu))
                    _TknguyenlieuthoiEntityCol.Add(_tknguyenlieuthoiEntity);
            }
            //if (string.IsNullOrEmpty(_str_Tknguyenlieuthoi_PK))
            //{
            //    //_TknguyenlieuthoiEntity.Ngaytao = DateTime.Now;
            //    //_TknguyenlieuthoiEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
            //    _str_Tknguyenlieuthoi_PK = _TknguyenlieuthoiManager.InsertV2(_TknguyenlieuthoiEntity, r_Insert, DT_TKNLTHOI, BS_TKNLTHOI);
            //    _TknguyenlieuthoiManager.InsertCollection(_TknguyenlieuthoiEntityCol);
            //    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TknguyenlieuthoiManager.Convert(_TknguyenlieuthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            //    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //    BS_TKNLTHOI.ResetCurrentItem();
            //}
            //else
            //{
                //_TknguyenlieuthoiManager.Update(_TknguyenlieuthoiEntity);
                foreach (TknguyenlieuthoiEntity _tknguyenlieuthoiEntity in _TknguyenlieuthoiEntityCol)
                {
                    if (_tknguyenlieuthoiEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_TKNLTHOI_CHITIET.NewRow();
                        DT_TKNLTHOI_CHITIET.Rows.Add(_r_Insert);
                        _TknguyenlieuthoiManager.InsertV2(_tknguyenlieuthoiEntity, _r_Insert, DT_TKNLTHOI_CHITIET, BS_TKNLTHOI_CHITIET);
                    }
                    else _TknguyenlieuthoiManager.Update(_tknguyenlieuthoiEntity);
                }
            //GRID_TKNLTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Id.Name].Value = _tknguyenlieuthoiEntity.Id;
                GRID_TKNLTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Ngay.Name].Value = _ngay;
                GRID_TKNLTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Ca.Name].Value = _ca;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TknguyenlieuthoiManager.Convert(_TknguyenlieuthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //}
            return _str_Tknguyenlieuthoi_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            TknguyenlieuthoiManager _TknguyenlieuthoiManager = new TknguyenlieuthoiManager();
            TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
            r_Insert = DT_TKNLTHOI.NewRow();
            DT_TKNLTHOI.Rows.Add(r_Insert);
            BS_TKNLTHOI.Position = DT_TKNLTHOI.Rows.Count;
            GRID_TKNLTHOI_CHITIET.Enabled = true;
            GRID_TKNLTHOI_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKNLTHOI_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKNLTHOI_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKNLTHOI_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            //txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_TKNLTHOI.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_Ngaythongke }));
                //txt_TENHIEU.Focus();
            }
            GRID_TKNLTHOI_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_TKNLTHOI_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKNLTHOI_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKNLTHOI_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKNLTHOI_CHITIET.Enabled = true;
            GRID_TKNLTHOI.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_TKNLTHOI.Rows.Remove(r_Insert);
            }
            BS_TKNLTHOI_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_TKNLTHOI.Enabled = true;
            GRID_TKNLTHOI_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKNLTHOI_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKNLTHOI_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            TknguyenlieuthoiManager _TknguyenlieuthoiManager = new TknguyenlieuthoiManager();
            TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
            _TknguyenlieuthoiEntity = _TknguyenlieuthoiManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_TknguyenlieuthoiEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - "/* + txt_TENHIEU.Text*/, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _TknguyenlieuthoiManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_TKNLTHOI.CurrentRow.Delete();
                    BS_TKNLTHOI_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TknguyenlieuthoiManager.Convert(_TknguyenlieuthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_TKNLTHOI.Enabled = true;
            GRID_TKNLTHOI_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKNLTHOI_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKNLTHOI_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _TknguyenlieuthoiManager.SelectOne(Convert.ToInt64(txt_MAHIEU.Text.Trim())) != null)
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
                GRID_TKNLTHOI.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_TKNLTHOI_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TKNLTHOI_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TKNLTHOI_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

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
            if (string.IsNullOrEmpty(txt_Manguyenlieu.Text.Trim()) || DT_DMNGUYENLIEU == null || DT_DMNGUYENLIEU.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_Manguyenlieu.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNguyenlieu(Str_MASIEUTHI, DT_DMNGUYENLIEU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU.xml",
                        DT_DMNGUYENLIEU, DmnguyenlieuFields.Manl.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_Manguyenlieu.Text = _RowViewSelect[DmnguyenlieuFields.Manl.Name].ToString();
                txt_Tennguyenlieu.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
            }
            else
                txt_Tennguyenlieu.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
        }
        private DataRow checkmaNguyenlieu(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmnguyenlieuFields.Manl.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_TKNLTHOI.ColumnAutoResize = true;
            else
                GRID_TKNLTHOI.ColumnAutoResize = false;
        }

        private void FRM_TKNLTHOI_FormClosing(object sender, FormClosingEventArgs e)
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
