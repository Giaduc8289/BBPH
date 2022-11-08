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

namespace GD.BBPH.APP.DANHMUC
{
    public partial class FRM_DMNGUYENLIEU : FRM_DMPARENT
    {
        private DmnguyenlieuManager _DmnguyenlieuManager = new DmnguyenlieuManager();
        private DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMNGUYENLIEU_H = new DataTable(), DT_DMNGUYENLIEU_D = new DataTable();
        private BindingSource BS_DMNGUYENLIEU_H = new BindingSource(), BS_DMNGUYENLIEU_D = new BindingSource();
        private DataRow r_Insert = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMNGUYENLIEU_H = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_DMNGUYENLIEU_D = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";

        private DataTable DT_DMNHOMNGUYENLIEU = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMNGUYENLIEU");
                        DT_DMNGUYENLIEU_H = LIB.Procedures.Danhsachnguyenlieu(string.Empty, string.Empty, LIB.SESSION_START.TS_NGAYCUOITHANG);// LIB.SESSION_START.DT_DMNGUYENLIEU;

                        DT_DMNHOMNGUYENLIEU = LIB.SESSION_START.DT_DMNHOMNGUYENLIEU;
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

        public FRM_DMNGUYENLIEU()
        {
            InitializeComponent();
            //DataTable dt111 = LIB.Procedures.Danhsachnguyenlieu(string.Empty, string.Empty, LIB.SESSION_START.TS_NGAYCUOITHANG); //new DmnguyenlieuManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU_H.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU_H.xml", GRID_DMNGUYENLIEU_H, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU_D.xml", GRID_DMNGUYENLIEU_D, pne_CHITIET);
            GRID_DMNGUYENLIEU_H.RootTable.Groups.Add(GRID_DMNGUYENLIEU_H.Tables[0].Columns[DmnguyenlieuFields.Tennhom.Name]);
            GRID_DMNGUYENLIEU_D.RootTable.SortKeys.Add(DmnguyenlieuFields.Ngay.Name, Janus.Windows.GridEX.SortOrder.Descending);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMNGUYENLIEU_H);
            BS_DMNGUYENLIEU_H = new BindingSource();
            BS_DMNGUYENLIEU_H.DataSource = Source_View;
            GRID_DMNGUYENLIEU_H.DataSource = BS_DMNGUYENLIEU_H;
            BS_DMNGUYENLIEU_H.CurrentChanged += new EventHandler(BS_DMNGUYENLIEU_H_CurrentChanged);
            BS_DMNGUYENLIEU_H_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMNGUYENLIEU_H_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMNGUYENLIEU_H.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMNGUYENLIEU_H.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();

                    txt_MANL.Text = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
                    txt_TENNL.Text = _Rowview.Row[DmnguyenlieuFields.Tennl.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[DmnguyenlieuFields.Tenrutgon.Name].ToString();
                    txt_MANHOM.Text = _Rowview.Row[DmnguyenlieuFields.Manhom.Name].ToString();
                    txt_GIA.Text = _Rowview.Row[DmnguyenlieuFields.Gia.Name].ToString();

                    txt_MANHOM_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMNGUYENLIEU_H_CurrentChanged"); }
        }
        void BS_DMNGUYENLIEU_D_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_DMNGUYENLIEU_D.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMNGUYENLIEU_D.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[DmnguyenlieuFields.Id.Name].ToString();

                    try { txt_GIA.Text = double.Parse(LIB.ConvertString.NumbertoDB(_Rowview.Row[DmnguyenlieuFields.Gia.Name].ToString()).ToString()).ToString("#.00", new System.Globalization.CultureInfo("vi-VN")); }
                    catch { }
                    txt_NGAYAPDUNG.Text = _Rowview.Row[DmnguyenlieuFields.Ngay.Name].ToString();
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
                DT_DMNGUYENLIEU_D = new DmnguyenlieuManager().Clone();
                BS_DMNGUYENLIEU_D = new BindingSource(DT_DMNGUYENLIEU_D, null);
                GRID_DMNGUYENLIEU_D.DataSource = BS_DMNGUYENLIEU_D;
            }
            else
            {
                DT_DMNGUYENLIEU_D = _DmnguyenlieuManager.SelectByManlNgayRDT(MAHIEU_PK, LIB.SESSION_START.TS_NGAYCUOITHANG);//.SelectByMahieuRDT(MAHIEU_PK);  

                DataView Source_View = new DataView(DT_DMNGUYENLIEU_D);
                BS_DMNGUYENLIEU_D = new BindingSource();
                BS_DMNGUYENLIEU_D.DataSource = Source_View;
                GRID_DMNGUYENLIEU_D.DataSource = BS_DMNGUYENLIEU_D;
            }
            BS_DMNGUYENLIEU_D.CurrentChanged += new EventHandler(BS_DMNGUYENLIEU_D_CurrentChanged);
            BS_DMNGUYENLIEU_D_CurrentChanged((new object()), (new EventArgs()));
            BS_DMNGUYENLIEU_D.MoveLast();
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_DMNGUYENLIEU_D.NewRow();
            r_Detail[DmnguyenlieuFields.Manl.Name] = txt_MANL.Text;
            r_Detail[DmnguyenlieuFields.Tennl.Name] = txt_TENNL.Text;
            //r_Detail[DmnguyenlieuFields.Tenrutgon.Name] = txt_TENRUTGON.Text.Trim();
            //r_Detail[DmnguyenlieuFields.Manhom.Name] = txt_MANHOM.Text.Trim();
            //r_Detail[DmnguyenlieuFields.Tennhom.Name] = txt_TENNHOM.Text.Trim();
            try { r_Detail[DmnguyenlieuFields.Gia.Name] = r_Detail[DmnguyenlieuFields.Giahientai.Name] = LIB.ConvertString.NumbertoDB(txt_GIA.Text.Trim()); }
            catch { }
            try { r_Detail[DmnguyenlieuFields.Ngay.Name] = Convert.ToDateTime(txt_NGAYAPDUNG.Text.Trim()); }
            catch { }

            DT_DMNGUYENLIEU_D.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_DMNGUYENLIEU_D);
            BS_DMNGUYENLIEU_D = new BindingSource();
            BS_DMNGUYENLIEU_D.DataSource = Source_View;
            GRID_DMNGUYENLIEU_D.DataSource = BS_DMNGUYENLIEU_D;
            BS_DMNGUYENLIEU_D.Position = DT_DMNGUYENLIEU_D.Rows.Count;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_DMNGUYENLIEU_D.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[DmnguyenlieuFields.Id.Name].ToString();
            string _MANGUYENLIEU = _view[DmnguyenlieuFields.Manl.Name].ToString();
            string _NGAY = string.Empty;
            try { _NGAY = Convert.ToDateTime(_view[DmnguyenlieuFields.Ngay.Name].ToString()).ToString("dd/MM/yyyy"); }
            catch { }
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU + ", Ngày áp dụng "+ _NGAY, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_DMNGUYENLIEU_D.CurrentRow.Delete();
            }
            else
            {
                DmnguyenlieuManager _DmnguyenlieuManager = new DmnguyenlieuManager();
                DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
                try { _DmnguyenlieuEntity = _DmnguyenlieuManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_DmnguyenlieuEntity != null && MessageBox.Show("Xóa dòng: " + _MANGUYENLIEU + ", Ngày áp dụng " + _NGAY, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _DmnguyenlieuManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_DMNGUYENLIEU_D.Select(DmnguyenlieuFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_DMNGUYENLIEU_D.Rows.Remove(drArr[0]);
                        //GRID_DMNGUYENLIEU_D.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DondathangHManager.Convert(_DondathangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MANGUYENLIEU + ", Ngày áp dụng " + _NGAY + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_DMNGUYENLIEU_D.ResetCurrentItem();
                    GRID_DMNGUYENLIEU_D.DataSource = BS_DMNGUYENLIEU_D;
                }
                GRID_DMNGUYENLIEU_D.Enabled = true;
            }
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmnguyenlieuEntity _DmnguyenlieuHEntity = new DmnguyenlieuEntity();

            _DmnguyenlieuHEntity.Manl = txt_MANL.Text.Trim();
            _DmnguyenlieuHEntity.Tennl = txt_TENNL.Text.Trim();
            _DmnguyenlieuHEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
            _DmnguyenlieuHEntity.Manhom = txt_MANHOM.Text.Trim();
            _DmnguyenlieuHEntity.Tennhom = txt_TENNHOM.Text.Trim();

            EntityCollection _DmnguyenlieuEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_DMNGUYENLIEU_D.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
                _DmnguyenlieuEntity.Manl = txt_MANL.Text.Trim();
                _DmnguyenlieuEntity.Tennl = txt_TENNL.Text.Trim();
                _DmnguyenlieuEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
                _DmnguyenlieuEntity.Manhom = txt_MANHOM.Text.Trim();
                _DmnguyenlieuEntity.Tennhom = txt_TENNHOM.Text.Trim();
                try { _DmnguyenlieuEntity.Gia = _DmnguyenlieuEntity.Giahientai = LIB.ConvertString.NumbertoDB(_view[DmnguyenlieuFields.Gia.Name].ToString()); }
                catch { }
                try { _DmnguyenlieuEntity.Ngay = Convert.ToDateTime(_view[DmnguyenlieuFields.Ngay.Name].ToString()); }
                catch { }

                try { _DmnguyenlieuEntity.Id = Convert.ToInt64(_view[DmnguyenlieuFields.Id.Name].ToString()); }
                catch { }

                _DmnguyenlieuEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_DmnguyenlieuEntity.IsNew)
                {
                    EntityCollection drDHCT = (new DmnguyenlieuManager()).SelectById(_DmnguyenlieuEntity.Id);
                    if (drDHCT.Count > 0)
                        _DmnguyenlieuEntity.IsNew = false;
                }

                if (!string.IsNullOrEmpty(_DmnguyenlieuEntity.Manl))
                    _DmnguyenlieuEntityCol.Add(_DmnguyenlieuEntity);
            }

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _DmnguyenlieuManager.InsertCollection(_DmnguyenlieuEntityCol);
                _str_DMCHUONG_PK = _DmnguyenlieuHEntity.Manl;// _DmnguyenlieuManager.InsertV2(_DmnguyenlieuHEntity, r_Insert, DT_DMNGUYENLIEU_H, BS_DMNGUYENLIEU_H);
                r_Insert.SetField(DmnguyenlieuFields.Manl.Name, _DmnguyenlieuHEntity.Manl);
                r_Insert.SetField(DmnguyenlieuFields.Tennl.Name, _DmnguyenlieuHEntity.Tennl);
                r_Insert.SetField(DmnguyenlieuFields.Tenrutgon.Name, _DmnguyenlieuHEntity.Tenrutgon);
                r_Insert.SetField(DmnguyenlieuFields.Manhom.Name, _DmnguyenlieuHEntity.Manhom);
                r_Insert.SetField(DmnguyenlieuFields.Tennhom.Name, _DmnguyenlieuHEntity.Tennhom);
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DMNGUYENLIEU_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DMNGUYENLIEU_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DMNGUYENLIEU_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                BS_DMNGUYENLIEU_H.ResetCurrentItem();
                BS_DMNGUYENLIEU_H_CurrentChanged(new object(), new EventArgs());
            }
            else
            {
                foreach (DmnguyenlieuEntity _DmnguyenlieuEntity in _DmnguyenlieuEntityCol)
                {
                    if (_DmnguyenlieuEntity.IsNew)
                    {
                        DataRow _r_Insert = DT_DMNGUYENLIEU_D.NewRow();
                        DT_DMNGUYENLIEU_D.Rows.Add(_r_Insert);
                        _DmnguyenlieuManager.InsertV2(_DmnguyenlieuEntity, _r_Insert, DT_DMNGUYENLIEU_D, BS_DMNGUYENLIEU_D);
                    }
                    else _DmnguyenlieuManager.Update(_DmnguyenlieuEntity);
                }
                //_DmnguyenlieuManager.Update(_DmnguyenlieuEntity);
                GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Manl.Name].Value = _DmnguyenlieuHEntity.Manl;
                GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Tennl.Name].Value = _DmnguyenlieuHEntity.Tennl;
                GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Tenrutgon.Name].Value = _DmnguyenlieuHEntity.Tenrutgon;
                GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Manhom.Name].Value = _DmnguyenlieuHEntity.Manhom;
                GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Tennhom.Name].Value = _DmnguyenlieuHEntity.Tennhom;
                DataTable dt = LIB.Procedures.Danhsachnguyenlieu(_DmnguyenlieuHEntity.Manl, string.Empty, LIB.SESSION_START.TS_NGAYCUOITHANG);
                if(dt.Rows.Count>0)
                {
                    GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Gia.Name].Value = dt.Rows[0][DmnguyenlieuFields.Gia.Name];
                    GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Tang.Name].Value = dt.Rows[0][DmnguyenlieuFields.Tang.Name];
                    GRID_DMNGUYENLIEU_H.CurrentRow.Cells[DmnguyenlieuFields.Giam.Name].Value = dt.Rows[0][DmnguyenlieuFields.Giam.Name];
                }
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DMNGUYENLIEU_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DMNGUYENLIEU_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_DMNGUYENLIEU_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                BS_DMNGUYENLIEU_H.ResetCurrentItem();
                BS_DMNGUYENLIEU_H_CurrentChanged(new object(), new EventArgs());
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmnguyenlieuManager _DmnguyenlieuManager = new DmnguyenlieuManager();
            DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
            r_Insert = DT_DMNGUYENLIEU_H.NewRow();
            DT_DMNGUYENLIEU_H.Rows.Add(r_Insert);
            BS_DMNGUYENLIEU_H.Position = DT_DMNGUYENLIEU_H.Rows.Count;
            GRID_DMNGUYENLIEU_D.Enabled = true;
            GRID_DMNGUYENLIEU_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DMNGUYENLIEU_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DMNGUYENLIEU_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DMNGUYENLIEU_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            txt_MANL.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENNHOM}));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_DMNGUYENLIEU_H.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MANL , txt_TENNHOM }));
                txt_TENNL.Focus();
            }
            GRID_DMNGUYENLIEU_D.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_DMNGUYENLIEU_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DMNGUYENLIEU_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DMNGUYENLIEU_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_DMNGUYENLIEU_D.Enabled = true;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_DMNGUYENLIEU_H.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMNGUYENLIEU_H.Rows.Remove(r_Insert);
            }
            BS_DMNGUYENLIEU_H_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMNGUYENLIEU_H.Enabled = true;
            GRID_DMNGUYENLIEU_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DMNGUYENLIEU_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DMNGUYENLIEU_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmnguyenlieuManager _DmnguyenlieuManager = new DmnguyenlieuManager();
            DmnguyenlieuEntity _DmnguyenlieuEntity = new DmnguyenlieuEntity();
            if (_DmnguyenlieuManager.SelectByManlRDT(MAHIEU_PK).Rows.Count > 0 && MessageBox.Show("Xóa nguyên liệu: " + MAHIEU_PK + " - " + txt_TENNL.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmnguyenlieuManager.DeleteByManl(MAHIEU_PK);
                    GRID_DMNGUYENLIEU_H.CurrentRow.Delete();
                    BS_DMNGUYENLIEU_H_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_DmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa nguyên liệu " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMNGUYENLIEU_H.Enabled = true;
            GRID_DMNGUYENLIEU_D.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DMNGUYENLIEU_D.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_DMNGUYENLIEU_D.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            EntityCollection _DmnguyenlieuCollection = _DmnguyenlieuManager.SelectByManl(txt_MANL.Text.Trim());
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmnguyenlieuCollection != null && _DmnguyenlieuCollection.Count > 0)
            {
                MessageBox.Show("Mã nguyên liệu bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MANL.Focus();
                return;
            }
            else if (txt_MANL.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MANL.Focus();
                return;
            }
            else if (txt_TENNL.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên nguyên liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENNL.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMNGUYENLIEU_H.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MANHOM_Validating(object sender, CancelEventArgs e)
        {
            DataRow _RowViewSelect = null;
            txt_TENNHOM.Text = string.Empty;
            if (string.IsNullOrEmpty(txt_MANHOM.Text.Trim()) || DT_DMNHOMNGUYENLIEU == null || DT_DMNHOMNGUYENLIEU.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MANHOM.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNhom(Str_MASIEUTHI, DT_DMNHOMNGUYENLIEU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNHOMNGUYENLIEU.xml",
                        DT_DMNHOMNGUYENLIEU, DmnhomnguyenlieuFields.Manhom.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MANHOM.Text = _RowViewSelect[DmnhomnguyenlieuFields.Manhom.Name].ToString();
                txt_TENNHOM.Text = _RowViewSelect[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
            }
            else
                txt_TENNHOM.Text = _RowViewSelect[DmnhomnguyenlieuFields.Tennhomnguyenlieu.Name].ToString();
        }
        private DataRow checkmaNhom(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmnhomnguyenlieuFields.Manhom.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMNGUYENLIEU_H.ColumnAutoResize = true;
            else
                GRID_DMNGUYENLIEU_H.ColumnAutoResize = false;
        }

        private void FRM_DMNGUYENLIEU_FormClosing(object sender, FormClosingEventArgs e)
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
