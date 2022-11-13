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
    public partial class FRM_XUATNGUYENLIEU : FRM_DMPARENT
    {
        private XuatkhonguyenlieuManager _XuatkhonguyenlieuManager = new XuatkhonguyenlieuManager();
        private XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_XUATNGUYENLIEU = new DataTable(), DT_XUATNGUYENLIEU_CHITIET = new DataTable(), DT_XUATNGUYENLIEU_CHITIET_FILL = new DataTable();
        private BindingSource BS_XUATNGUYENLIEU = new BindingSource(), BS_XUATNGUYENLIEU_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_XUATNGUYENLIEU = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_XUATNGUYENLIEUCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MANGUYENLIEU = "", MAKHO = "";
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_XUATNGUYENLIEU");
                        DT_XUATNGUYENLIEU = LIB.Procedures.Danhsachxuatnguyenlieu(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty); // LIB.SESSION_START.DT_XUATNGUYENLIEU;
                        DT_XUATNGUYENLIEU_CHITIET = LIB.SESSION_START.DT_XUATNGUYENLIEU;

                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
                        DT_DMNGUYENLIEU = LIB.SESSION_START.DT_DMNGUYENLIEU;
                        DT_DMLYDONHAPXUAT = LIB.SESSION_START.DT_DMLYDONHAPXUAT;
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

        public FRM_XUATNGUYENLIEU()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            XuatkhonguyenlieuManager _XuatkhonguyenlieuManager = new XuatkhonguyenlieuManager();
            DataTable dt111 = LIB.Procedures.Danhsachxuatnguyenlieu(Ngaydauthang, Ngaycuoithang, MAKHO);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATNGUYENLIEU.xml");
            dt111 = LIB.Procedures.Danhsachxuatnguyenlieuchitiet(MAHIEU_PK, MANGUYENLIEU);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATNGUYENLIEUCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATNGUYENLIEU.xml", GRID_XUATNGUYENLIEU, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATNGUYENLIEUCHITIET.xml", GRID_XUATNGUYENLIEUCHITIET, pne_CHITIET);
            GRID_XUATNGUYENLIEUCHITIET.DeletingRecord += GRID_XUATNGUYENLIEUCHITIET_DeletingRecord;

            //GRID_XUATNGUYENLIEU.RootTable.Groups.Add(GRID_XUATNGUYENLIEU.Tables[0].Columns[XuatkhonguyenlieuFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_XUATNGUYENLIEU);
            BS_XUATNGUYENLIEU = new BindingSource();
            BS_XUATNGUYENLIEU.DataSource = Source_View;
            GRID_XUATNGUYENLIEU.DataSource = BS_XUATNGUYENLIEU;
            BS_XUATNGUYENLIEU.CurrentChanged += new EventHandler(BS_XUATNGUYENLIEU_CurrentChanged);
            BS_XUATNGUYENLIEU_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_XUATNGUYENLIEU_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_XUATNGUYENLIEU.UpdateData();
                if (BS_XUATNGUYENLIEU.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_XUATNGUYENLIEU.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[XuatkhonguyenlieuFields.Ngayxuat.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[XuatkhonguyenlieuFields.Ngayxuat.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Makho.Name].ToString();
                    //txt_TENKHO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tenkho.Name].ToString();
                    txt_MAKHO_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_XUATNGUYENLIEU_CurrentChanged"); }
        }

        void BS_XUATNGUYENLIEU_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_XUATNGUYENLIEU_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_XUATNGUYENLIEU_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[XuatkhonguyenlieuFields.Id.Name].ToString();

                    txt_MANGUYENLIEU.Text = _Rowview.Row[XuatkhonguyenlieuFields.Manguyenlieu.Name].ToString();
                    txt_TENNGUYENLIEU.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tennguyenlieu.Name].ToString();
                    txt_DVTINH.Text = _Rowview.Row[XuatkhonguyenlieuFields.Donvitinh.Name].ToString();
                    txt_SOLUONG.Text = _Rowview.Row[XuatkhonguyenlieuFields.Soluong.Name].ToString();
                    txt_MALYDO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Malydo.Name].ToString();
                    txt_TENLYDO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tenlydo.Name].ToString();
                    txt_LENHXUAT.Text = _Rowview.Row[XuatkhonguyenlieuFields.Lenhxuat.Name].ToString();

                    txt_MANGUYENLIEU_Validating(new object(), new CancelEventArgs());
                    txt_LYDO_Validating(new object(), new CancelEventArgs());
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
                DT_XUATNGUYENLIEU_CHITIET_FILL = new XuatkhonguyenlieuManager().Clone();
                BS_XUATNGUYENLIEU_CHITIET = new BindingSource(DT_XUATNGUYENLIEU_CHITIET_FILL, null);
                GRID_XUATNGUYENLIEUCHITIET.DataSource = BS_XUATNGUYENLIEU_CHITIET;
            }
            else
            {
                DT_XUATNGUYENLIEU_CHITIET_FILL = new XuatkhonguyenlieuManager().SelectByNgayxuatMakhoRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), txt_MAKHO.Text.Trim());

                DataView Source_View = new DataView(DT_XUATNGUYENLIEU_CHITIET_FILL);
                BS_XUATNGUYENLIEU_CHITIET = new BindingSource();
                BS_XUATNGUYENLIEU_CHITIET.DataSource = Source_View;
                GRID_XUATNGUYENLIEUCHITIET.DataSource = BS_XUATNGUYENLIEU_CHITIET;
            }
            BS_XUATNGUYENLIEU_CHITIET.CurrentChanged += new EventHandler(BS_XUATNGUYENLIEU_CHITIET_CurrentChanged);
            BS_XUATNGUYENLIEU_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_XUATNGUYENLIEU_CHITIET_FILL.NewRow();
            r_Detail[XuatkhonguyenlieuFields.Manguyenlieu.Name] = txt_MANGUYENLIEU.Text;
            r_Detail[XuatkhonguyenlieuFields.Tennguyenlieu.Name] = txt_TENNGUYENLIEU.Text;
            r_Detail[XuatkhonguyenlieuFields.Donvitinh.Name] = txt_DVTINH.Text;
            try { r_Detail[XuatkhonguyenlieuFields.Soluong.Name] = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim()); }
            catch { }
            r_Detail[XuatkhonguyenlieuFields.Malydo.Name] = txt_MALYDO.Text;
            r_Detail[XuatkhonguyenlieuFields.Tenlydo.Name] = txt_TENLYDO.Text;
            r_Detail[XuatkhonguyenlieuFields.Lenhxuat.Name] = txt_LENHXUAT.Text;

            DT_XUATNGUYENLIEU_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_XUATNGUYENLIEU_CHITIET_FILL);
            BS_XUATNGUYENLIEU_CHITIET = new BindingSource();
            BS_XUATNGUYENLIEU_CHITIET.DataSource = Source_View;
            GRID_XUATNGUYENLIEUCHITIET.DataSource = BS_XUATNGUYENLIEU_CHITIET;
            BS_XUATNGUYENLIEU_CHITIET.Position = DT_XUATNGUYENLIEU_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_XUATNGUYENLIEUCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[XuatkhonguyenlieuFields.Id.Name].ToString();
            string _MASANPHAM = _view[XuatkhonguyenlieuFields.Manguyenlieu.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_XUATNGUYENLIEUCHITIET.CurrentRow.Delete();
            }
            else
            {
                XuatkhonguyenlieuManager _XuatkhonguyenlieuManager = new XuatkhonguyenlieuManager();
                XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
                try { _XuatkhonguyenlieuEntity = _XuatkhonguyenlieuManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_XuatkhonguyenlieuEntity != null && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _XuatkhonguyenlieuManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_XUATNGUYENLIEU_CHITIET_FILL.Select(XuatkhonguyenlieuFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_XUATNGUYENLIEU_CHITIET_FILL.Rows.Remove(drArr[0]);
                        //GRID_TKNLTHOI_CHITIET.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MASANPHAM + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_XUATNGUYENLIEU_CHITIET.ResetCurrentItem();
                    GRID_XUATNGUYENLIEUCHITIET.DataSource = BS_XUATNGUYENLIEU_CHITIET;
                }
                GRID_XUATNGUYENLIEUCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        private void GRID_XUATNGUYENLIEUCHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        #endregion


        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngayxuat = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _XuatkhonguyenlieuEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_XUATNGUYENLIEUCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
                _XuatkhonguyenlieuEntity.Ngayxuat = _ngayxuat;
                _XuatkhonguyenlieuEntity.Makho = txt_MAKHO.Text.Trim();
                _XuatkhonguyenlieuEntity.Tenkho = txt_TENKHO.Text.Trim();
                _XuatkhonguyenlieuEntity.Manguyenlieu = _view.Row[XuatkhonguyenlieuFields.Manguyenlieu.Name].ToString();
                _XuatkhonguyenlieuEntity.Tennguyenlieu = _view.Row[XuatkhonguyenlieuFields.Tennguyenlieu.Name].ToString();
                _XuatkhonguyenlieuEntity.Donvitinh = _view.Row[XuatkhonguyenlieuFields.Donvitinh.Name].ToString();
                _XuatkhonguyenlieuEntity.Soluong = Convert.ToDecimal(_view.Row[XuatkhonguyenlieuFields.Soluong.Name].ToString());
                _XuatkhonguyenlieuEntity.Malydo = _view.Row[XuatkhonguyenlieuFields.Malydo.Name].ToString();
                _XuatkhonguyenlieuEntity.Tenlydo = _view.Row[XuatkhonguyenlieuFields.Tenlydo.Name].ToString();
                _XuatkhonguyenlieuEntity.Lenhxuat = _view.Row[XuatkhonguyenlieuFields.Lenhxuat.Name].ToString();

                try { _XuatkhonguyenlieuEntity.Id = Convert.ToInt64(_view[XuatkhonguyenlieuFields.Id.Name].ToString()); }
                catch { }
                _XuatkhonguyenlieuEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_XuatkhonguyenlieuEntity.IsNew)
                {
                    EntityCollection drDHCT = (new XuatkhonguyenlieuManager()).SelectById(_XuatkhonguyenlieuEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _XuatkhonguyenlieuEntity.Ngaysua = DateTime.Now;
                        _XuatkhonguyenlieuEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _XuatkhonguyenlieuEntity.IsNew = false;
                    }
                    else
                    {
                        _XuatkhonguyenlieuEntity.Ngaytao = DateTime.Now;
                        _XuatkhonguyenlieuEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if (!string.IsNullOrEmpty(_XuatkhonguyenlieuEntity.Manguyenlieu))
                    _XuatkhonguyenlieuEntityCol.Add(_XuatkhonguyenlieuEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity in _XuatkhonguyenlieuEntityCol)
            {
                if (_XuatkhonguyenlieuEntity.IsNew)
                {
                    DataRow _r_Insert = DT_XUATNGUYENLIEU_CHITIET.NewRow();
                    DT_XUATNGUYENLIEU_CHITIET.Rows.Add(_r_Insert);
                    _XuatkhonguyenlieuManager.InsertV2(_XuatkhonguyenlieuEntity, _r_Insert, DT_XUATNGUYENLIEU_CHITIET, BS_XUATNGUYENLIEU_CHITIET);
                }
                else _XuatkhonguyenlieuManager.Update(_XuatkhonguyenlieuEntity);
            }

            GRID_XUATNGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Ngayxuat.Name].Value = _ngayxuat;
            GRID_XUATNGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Makho.Name].Value = txt_MAKHO.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhonguyenlieuManager.Convert(_XuatkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }


        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_NGAY.Text = txt_MAKHO.Text = txt_TENKHO.Text = txt_MANGUYENLIEU.Text = txt_TENNGUYENLIEU.Text = txt_DVTINH.Text = txt_SOLUONG.Text = txt_MALYDO.Text = txt_TENLYDO.Text = txt_LENHXUAT.Text = string.Empty;
            r_Insert = DT_XUATNGUYENLIEU.NewRow();
            DT_XUATNGUYENLIEU.Rows.Add(r_Insert);
            BS_XUATNGUYENLIEU.Position = DT_XUATNGUYENLIEU.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            txt_MAKHO.Text = txt_TENKHO.Text = txt_SOLUONG.Text = txt_DVTINH.Text = txt_MANGUYENLIEU.Text = txt_TENNGUYENLIEU.Text = txt_MALYDO.Text = txt_TENLYDO.Text = txt_LENHXUAT.Text = string.Empty;
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENNGUYENLIEU }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_XUATNGUYENLIEU.Enabled = false;

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
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENNGUYENLIEU }));
            }
            GRID_XUATNGUYENLIEUCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_XUATNGUYENLIEUCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATNGUYENLIEUCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATNGUYENLIEUCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATNGUYENLIEUCHITIET.Enabled = true;
            GRID_XUATNGUYENLIEU.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_XUATNGUYENLIEU.Rows.Remove(r_Insert);
            }
            BS_XUATNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_XUATNGUYENLIEU.Enabled = true;
            GRID_XUATNGUYENLIEUCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATNGUYENLIEUCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATNGUYENLIEUCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            XuatkhonguyenlieuManager _XuatkhonguyenlieuManager = new XuatkhonguyenlieuManager();
            XuatkhonguyenlieuEntity _XuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
            _XuatkhonguyenlieuEntity = _XuatkhonguyenlieuManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_XuatkhonguyenlieuEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_LENHXUAT.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _XuatkhonguyenlieuManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_XUATNGUYENLIEU.CurrentRow.Delete();
                    BS_XUATNGUYENLIEU_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhonguyenlieuManager.Convert(_XuatkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_XUATNGUYENLIEU.Enabled = true;
            GRID_XUATNGUYENLIEUCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATNGUYENLIEUCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATNGUYENLIEUCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _XuatkhonguyenlieuManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
            //{
            //    MessageBox.Show("Mã công nhân bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_MAMAY.Focus();
            //    return;
            //}
            if (txt_NGAY.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập ngày xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NGAY.Focus();
                return;
            }
            else if (txt_MAKHO.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập kho xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAKHO.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_XUATNGUYENLIEU.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_XUATNGUYENLIEUCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_XUATNGUYENLIEUCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_XUATNGUYENLIEUCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
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
            _RowViewSelect = checkmanguyenlieu(_str_MACANTIM, DT_DMNGUYENLIEU);
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
            {
                txt_TENNGUYENLIEU.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
            }
        }
        private DataRow checkmanguyenlieu(string macantim, DataTable dt)
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
            string _str_MACANTIM = txt_MAKHO.Text.Trim().ToUpper();
            _RowViewSelect = checkmacongnnhang(_str_MACANTIM, DT_DMKHO);
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
            {
                txt_TENKHO.Text = _RowViewSelect[DmkhoFields.Tenkho.Name].ToString();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private DataRow checkmacongnnhang(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhoFields.Makho.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_LYDO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MALYDO.Text.Trim()) || DT_DMLYDONHAPXUAT == null || DT_DMLYDONHAPXUAT.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MALYDO.Text.Trim().ToUpper();
            _RowViewSelect = checkmalydo(_str_MACANTIM, DT_DMLYDONHAPXUAT);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LYDONHAPXUAT.xml",
                        DT_DMLYDONHAPXUAT, DmlydonhapxuatFields.Malydo.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MALYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Malydo.Name].ToString();
                txt_TENLYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Tenlydo.Name].ToString();

            }
            else
            {
                txt_TENLYDO.Text = _RowViewSelect[DmlydonhapxuatFields.Tenlydo.Name].ToString();

            }
        }
        private DataRow checkmalydo(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmlydonhapxuatFields.Malydo.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region Shortcut Key
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
            FRM_DMNGUYENLIEU frm_Dm = new FRM_DMNGUYENLIEU();
            frm_Dm.Text = "Danh mục nguyên liệu";
            frm_Dm.ShowDialog();
            DT_DMNGUYENLIEU = new DmnguyenlieuManager().SelectAllRDT();
        }

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

        #endregion

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_XUATNGUYENLIEU.ColumnAutoResize = true;
            else
                GRID_XUATNGUYENLIEU.ColumnAutoResize = false;
        }

        private void FRM_XUATNGUYENLIEU_FormClosing(object sender, FormClosingEventArgs e)
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
