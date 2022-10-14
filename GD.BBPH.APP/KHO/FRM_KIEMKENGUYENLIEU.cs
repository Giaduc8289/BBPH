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
    public partial class FRM_KIEMKENGUYENLIEU : FRM_DMPARENT
    {
        private SodunguyenlieuManager _SodunguyenlieuManager = new SodunguyenlieuManager();
        private SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_SODUNGUYENLIEU = new DataTable(), DT_SODUNGUYENLIEU_CHITIET = new DataTable(), DT_SODUNGUYENLIEU_CHITIET_FILL = new DataTable();
        private BindingSource BS_SODUNGUYENLIEU = new BindingSource(), BS_SODUNGUYENLIEU_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_SODUNGUYENLIEU = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_SODUNGUYENLIEU_CHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";

        private DataTable DT_DMNGUYENLIEU = new DataTable(), DT_DMKHO = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KIEMKENGUYENLIEU");
                        DT_SODUNGUYENLIEU = LIB.Procedures.Danhsachkiemkenguyenlieu(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty); //LIB.SESSION_START.DT_SODUNGUYENLIEU;
                        DT_SODUNGUYENLIEU_CHITIET = LIB.SESSION_START.DT_SODUNGUYENLIEU;
                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
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

        public FRM_KIEMKENGUYENLIEU()
        {
            InitializeComponent();
            SodunguyenlieuManager _SodunguyenlieuManager = new SodunguyenlieuManager();
            DataTable dt111 = LIB.Procedures.Danhsachkiemkenguyenlieu(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKENGUYENLIEU.xml");
            dt111 = _SodunguyenlieuManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKENGUYENLIEU_CHITIET.xml");

            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKENGUYENLIEU.xml", GRID_SODUNGUYENLIEU, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKENGUYENLIEU_CHITIET.xml", GRID_SODUNGUYENLIEU_CHITIET, pne_CHITIET);
            //GRID_SODUNGUYENLIEU.RootTable.SortKeys.Add(SodunguyenlieuFields.Ngaykiemke.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GRID_SODUNGUYENLIEU_CHITIET.FilterMode = FilterMode.None;
            GRID_SODUNGUYENLIEU_CHITIET.GroupByBoxVisible = false;
            FORM_PROCESS();
            //GRID_SODUNGUYENLIEU_CHITIET.COMBO_MULTICOLUMN(GRID_SODUNGUYENLIEU_CHITIET, SodunguyenlieuFields.Masp.Name, DanhmuchanghoaFields.Tenhieu.Name, DanhmuchanghoaFields.Mahieu.Name, DanhmuchanghoaFields.Mahieu.Name, DT_DMHANG);
            //GRID_SODUNGUYENLIEU_CHITIET.CellEdited += GRID_SODUNGUYENLIEU_CHITIET_CellEdited;
            //GRID_SODUNGUYENLIEU_CHITIET.RecordsDeleted += GRID_SODUNGUYENLIEU_CHITIET_RecordsDeleted;
            //GRID_SODUNGUYENLIEU_CHITIET.RecordUpdated += GRID_SODUNGUYENLIEU_CHITIET_RecordUpdated;
            //GRID_SODUNGUYENLIEU_CHITIET.DeletingRecord += GRID_SODUNGUYENLIEU_CHITIET_DeletingRecord;
            ////GRID_SODUNGUYENLIEU_CHITIET.Click += GRID_SODUNGUYENLIEU_CHITIET_Click;
            //GRID_SODUNGUYENLIEU_CHITIET.RootTable.Columns["Thanhtien"].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_SODUNGUYENLIEU);
            BS_SODUNGUYENLIEU = new BindingSource();
            BS_SODUNGUYENLIEU.DataSource = Source_View;
            GRID_SODUNGUYENLIEU.DataSource = BS_SODUNGUYENLIEU;
            BS_SODUNGUYENLIEU.CurrentChanged += new EventHandler(BS_SODUNGUYENLIEU_CurrentChanged);
            BS_SODUNGUYENLIEU_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_SODUNGUYENLIEU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_SODUNGUYENLIEU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_SODUNGUYENLIEU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[SodunguyenlieuFields.Ngaykiemke.Name].ToString();

                    //txt_MAHIEU.Text = _Rowview.Row[SodunguyenlieuFields.Id.Name].ToString();
                    txt_NGAYNHAP.Text = _Rowview.Row[SodunguyenlieuFields.Ngaykiemke.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[SodunguyenlieuFields.Makho.Name].ToString();
                    //txt_MALYDO.Text = _Rowview.Row[SodunguyenlieuFields.Malydo.Name].ToString();

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_SODUNGUYENLIEU_CurrentChanged"); }
        }
        void BS_SODUNGUYENLIEU_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_SODUNGUYENLIEU_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_SODUNGUYENLIEU_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[SodunguyenlieuFields.Id.Name].ToString();
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
                DT_SODUNGUYENLIEU_CHITIET_FILL = new SodunguyenlieuManager().Clone();
                BS_SODUNGUYENLIEU_CHITIET = new BindingSource(DT_SODUNGUYENLIEU_CHITIET_FILL, null);
                GRID_SODUNGUYENLIEU_CHITIET.DataSource = BS_SODUNGUYENLIEU_CHITIET;
            }
            else
            {
                DT_SODUNGUYENLIEU_CHITIET_FILL = new SodunguyenlieuManager().SelectByNgaykiemkhoRDT(Convert.ToDateTime(txt_NGAYNHAP.Text.Trim()), txt_MAKHO.Text.Trim());

                DataView Source_View = new DataView(DT_SODUNGUYENLIEU_CHITIET_FILL);
                BS_SODUNGUYENLIEU_CHITIET = new BindingSource();
                BS_SODUNGUYENLIEU_CHITIET.DataSource = Source_View;
                GRID_SODUNGUYENLIEU_CHITIET.DataSource = BS_SODUNGUYENLIEU_CHITIET;
            }
            BS_SODUNGUYENLIEU_CHITIET.CurrentChanged += new EventHandler(BS_SODUNGUYENLIEU_CHITIET_CurrentChanged);
            BS_SODUNGUYENLIEU_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_SODUNGUYENLIEU_CHITIET_FILL.NewRow();
            r_Detail[SodunguyenlieuFields.Manguyenlieu.Name] = txt_MANGUYENLIEU.Text;
            r_Detail[SodunguyenlieuFields.Tennguyenlieu.Name] = txt_TENNGUYENLIEU.Text;
            r_Detail[SodunguyenlieuFields.Soluong.Name] = txt_SOLUONG.Text;
            try { r_Detail[SodunguyenlieuFields.Manguyenlieu.Name] = Convert.ToInt64(txt_MANGUYENLIEU.Text.Trim()); }
            catch { }
            r_Detail[SodunguyenlieuFields.Donvitinh.Name] = txt_DONVITINH.Text;
            //r_Detail[SodunguyenlieuFields.Malydo.Name] = txt_MALYDO.Text;
            //r_Detail[SodunguyenlieuFields.Tenlydo.Name] = txt_TENLYDO.Text;
            //r_Detail[SodunguyenlieuFields.Loai.Name] = txt_LOAI.Text;
            try { r_Detail[SodunguyenlieuFields.Soluong.Name] = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim()); }
            catch { }
            //try { r_Detail[SodunguyenlieuFields.Klxuat.Name] = LIB.ConvertString.NumbertoDB(txt_Klxuat.Text.Trim()); }
            //catch { }

            DT_SODUNGUYENLIEU_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_SODUNGUYENLIEU_CHITIET_FILL);
            BS_SODUNGUYENLIEU_CHITIET = new BindingSource();
            BS_SODUNGUYENLIEU_CHITIET.DataSource = Source_View;
            GRID_SODUNGUYENLIEU_CHITIET.DataSource = BS_SODUNGUYENLIEU_CHITIET;
            BS_SODUNGUYENLIEU_CHITIET.Position = DT_SODUNGUYENLIEU_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_SODUNGUYENLIEU_CHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[SodunguyenlieuFields.Id.Name].ToString();
            string _MANGUYENLIEU = _view[SodunguyenlieuFields.Manguyenlieu.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_SODUNGUYENLIEU_CHITIET.CurrentRow.Delete();
            }
            else
            {
                SodunguyenlieuManager _SodunguyenlieuManager = new SodunguyenlieuManager();
                SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
                try { _SodunguyenlieuEntity = _SodunguyenlieuManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_SodunguyenlieuEntity != null && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _SodunguyenlieuManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_SODUNGUYENLIEU_CHITIET_FILL.Select(SodunguyenlieuFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_SODUNGUYENLIEU_CHITIET_FILL.Rows.Remove(drArr[0]);
                        //GRID_SODUNGUYENLIEU_CHITIET.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MANGUYENLIEU + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_SODUNGUYENLIEU_CHITIET.ResetCurrentItem();
                    GRID_SODUNGUYENLIEU_CHITIET.DataSource = BS_SODUNGUYENLIEU_CHITIET;
                }
                GRID_SODUNGUYENLIEU_CHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        #endregion
        private string Save_Data(string _str_Tknguyenlieuthoi_PK)
        {
            DateTime _ngaynhap = Convert.ToDateTime(txt_NGAYNHAP.Text.Trim());
            String _kho = txt_MAKHO.Text.Trim();
            String _tenkho = txt_TENKHO.Text.Trim();
          
            EntityCollection _SodunguyenlieuEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_SODUNGUYENLIEU_CHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
                _SodunguyenlieuEntity.Ngaykiemke = _ngaynhap;
                _SodunguyenlieuEntity.Makho = _kho;
                _SodunguyenlieuEntity.Makho = _tenkho;
                _SodunguyenlieuEntity.Manguyenlieu = _view.Row[SodunguyenlieuFields.Manguyenlieu.Name].ToString();
                _SodunguyenlieuEntity.Tennguyenlieu = _view.Row[SodunguyenlieuFields.Tennguyenlieu.Name].ToString();
                try { _SodunguyenlieuEntity.Soluong = Convert.ToDecimal(_view.Row[SodunguyenlieuFields.Soluong.Name].ToString()); }
                catch { }
                 _SodunguyenlieuEntity.Donvitinh = _view.Row[SodunguyenlieuFields.Donvitinh.Name].ToString();
                //_SodunguyenlieuEntity.Malydo = _view.Row[SodunguyenlieuFields.Malydo.Name].ToString();
                //_SodunguyenlieuEntity.Tenlydo = _view.Row[SodunguyenlieuFields.Tenlydo.Name].ToString();

                if (!string.IsNullOrEmpty(_SodunguyenlieuEntity.Manguyenlieu))
                    _SodunguyenlieuEntityCol.Add(_SodunguyenlieuEntity);
            }
            //if (string.IsNullOrEmpty(_str_Tknguyenlieuthoi_PK))
            //{
            //    //_SodunguyenlieuEntity.Ngaytao = DateTime.Now;
            //    //_SodunguyenlieuEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
            //    _str_Tknguyenlieuthoi_PK = _SodunguyenlieuManager.InsertV2(_SodunguyenlieuEntity, r_Insert, DT_SODUNGUYENLIEU, BS_SODUNGUYENLIEU);
            //    _SodunguyenlieuManager.InsertCollection(_SodunguyenlieuEntityCol);
            //    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_SodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            //    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //    BS_SODUNGUYENLIEU.ResetCurrentItem();
            //}
            //else
            //{
                //_SodunguyenlieuManager.Update(_SodunguyenlieuEntity);
                foreach (SodunguyenlieuEntity _SodunguyenlieuEntity in _SodunguyenlieuEntityCol)
                {
                    if (_SodunguyenlieuEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_SODUNGUYENLIEU_CHITIET.NewRow();
                        DT_SODUNGUYENLIEU_CHITIET.Rows.Add(_r_Insert);
                        _SodunguyenlieuManager.InsertV2(_SodunguyenlieuEntity, _r_Insert, DT_SODUNGUYENLIEU_CHITIET, BS_SODUNGUYENLIEU_CHITIET);
                    }
                    else _SodunguyenlieuManager.Update(_SodunguyenlieuEntity);
                }
            //GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Id.Name].Value = _SodunguyenlieuEntity.Id;
                GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Ngaykiemke.Name].Value = _ngaynhap;
                GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Makho.Name].Value = txt_MAKHO.Text.Trim(); ;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_SodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //}
            return _str_Tknguyenlieuthoi_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            SodunguyenlieuManager _SodunguyenlieuManager = new SodunguyenlieuManager();
            SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
            r_Insert = DT_SODUNGUYENLIEU.NewRow();
            DT_SODUNGUYENLIEU.Rows.Add(r_Insert);
            BS_SODUNGUYENLIEU.Position = DT_SODUNGUYENLIEU.Rows.Count;
            GRID_SODUNGUYENLIEU_CHITIET.Enabled = true;
            GRID_SODUNGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUNGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUNGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUNGUYENLIEU_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_NGAYNHAP.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_SODUNGUYENLIEU.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_NGAYNHAP }));
                //txt_TENHIEU.Focus();
            }
            GRID_SODUNGUYENLIEU_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_SODUNGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUNGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUNGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUNGUYENLIEU_CHITIET.Enabled = true;
            GRID_SODUNGUYENLIEU.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_SODUNGUYENLIEU.Rows.Remove(r_Insert);
            }
            BS_SODUNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_SODUNGUYENLIEU.Enabled = true;
            GRID_SODUNGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUNGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUNGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            SodunguyenlieuManager _SodunguyenlieuManager = new SodunguyenlieuManager();
            SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
            _SodunguyenlieuEntity = _SodunguyenlieuManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_SodunguyenlieuEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - "/* + txt_TENHIEU.Text*/, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _SodunguyenlieuManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_SODUNGUYENLIEU.CurrentRow.Delete();
                    BS_SODUNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_SodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_SODUNGUYENLIEU.Enabled = true;
            GRID_SODUNGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUNGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUNGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _SodunguyenlieuManager.SelectOne(Convert.ToInt64(txt_MAHIEU.Text.Trim())) != null)
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
                GRID_SODUNGUYENLIEU.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_SODUNGUYENLIEU_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_SODUNGUYENLIEU_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_SODUNGUYENLIEU_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

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
            string Str_MASIEUTHI = txt_MANGUYENLIEU.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNguyenlieu(Str_MASIEUTHI, DT_DMNGUYENLIEU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU.xml",
                        DT_DMNGUYENLIEU, DmnguyenlieuFields.Manl.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MANGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Manl.Name].ToString();
                txt_TENNGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
            }
            else
                txt_TENNGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
        }

        private DataRow checkmaNguyenlieu(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmnguyenlieuFields.Manl.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAKHO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHO.Text.Trim()) || DT_DMKHO == null || DT_DMKHO.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MANGUYENLIEU.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKho(Str_MASIEUTHI, DT_DMKHO);
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
                txt_TENKHO.Text = _RowViewSelect[DmkhoFields.Tenkho.Name].ToString();
        }
        private DataRow checkmaKho(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhoFields.Makho.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_SODUNGUYENLIEU.ColumnAutoResize = true;
            else
                GRID_SODUNGUYENLIEU.ColumnAutoResize = false;
        }

        private void FRM_KIEMKENGUYENLIEU_FormClosing(object sender, FormClosingEventArgs e)
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
