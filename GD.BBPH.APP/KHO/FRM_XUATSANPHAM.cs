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
    public partial class FRM_XUATSANPHAM : FRM_DMPARENT
    {
        private XuatkhosanphamManager _XuatkhosanphamManager = new XuatkhosanphamManager();
        private XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_XUATSANPHAM = new DataTable(), DT_XUATSANPHAM_CHITIET = new DataTable(), DT_XUATSANPHAM_CHITIET_FILL = new DataTable();
        private BindingSource BS_XUATSANPHAM = new BindingSource(), BS_XUATSANPHAM_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_XUATSANPHAM = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_XUATSANPHAMCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MASP = "", MAKHO = "";
        private DataTable DT_DMSP = new DataTable(), DT_DMKHO = new DataTable(), DT_DMLYDONHAPXUAT = new DataTable();



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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_XUATSANPHAM");
                        DT_XUATSANPHAM = LIB.Procedures.Danhsachxuatsanpham(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty); // LIB.SESSION_START.DT_XUATSANPHAM;
                        DT_XUATSANPHAM_CHITIET = LIB.SESSION_START.DT_XUATSANPHAM;

                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
                        DT_DMSP = LIB.SESSION_START.DM_HANG;
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

        public FRM_XUATSANPHAM()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            XuatkhosanphamManager _XuatkhosanphamManager = new XuatkhosanphamManager();
            DataTable dt111 = LIB.Procedures.Danhsachxuatsanpham(Ngaydauthang, Ngaycuoithang, MAKHO);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATSANPHAM.xml");
            dt111 = LIB.Procedures.Danhsachxuatsanphamchitiet(MAHIEU_PK, MASP);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATSANPHAMCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATSANPHAM.xml", GRID_XUATSANPHAM, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATSANPHAMCHITIET.xml", GRID_XUATSANPHAMCHITIET, pne_CHITIET);
            GRID_XUATSANPHAMCHITIET.DeletingRecord += GRID_XUATSANPHAMCHITIET_DeletingRecord;

            //GRID_XUATSANPHAM.RootTable.Groups.Add(GRID_XUATSANPHAM.Tables[0].Columns[XuatkhosanphamFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_XUATSANPHAM);
            BS_XUATSANPHAM = new BindingSource();
            BS_XUATSANPHAM.DataSource = Source_View;
            GRID_XUATSANPHAM.DataSource = BS_XUATSANPHAM;
            BS_XUATSANPHAM.CurrentChanged += new EventHandler(BS_XUATSANPHAM_CurrentChanged);
            BS_XUATSANPHAM_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_XUATSANPHAM_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_XUATSANPHAM.UpdateData();
                if (BS_XUATSANPHAM.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_XUATSANPHAM.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[XuatkhosanphamFields.Ngayxuat.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[XuatkhosanphamFields.Ngayxuat.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[XuatkhosanphamFields.Makho.Name].ToString();
                    //txt_TENKHO.Text = _Rowview.Row[XuatkhosanphamFields.Tenkho.Name].ToString();
                    txt_MAKHO_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_XUATSANPHAM_CurrentChanged"); }
        }

        void BS_XUATSANPHAM_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_XUATSANPHAM_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_XUATSANPHAM_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[XuatkhosanphamFields.Id.Name].ToString();

                    txt_MASP.Text = _Rowview.Row[XuatkhosanphamFields.Masanpham.Name].ToString();
                    txt_TENSP.Text = _Rowview.Row[XuatkhosanphamFields.Tensanpham.Name].ToString();
                    txt_SOLUONG.Text = _Rowview.Row[XuatkhosanphamFields.Soluong.Name].ToString();
                    txt_SOM.Text = _Rowview.Row[XuatkhosanphamFields.Somet.Name].ToString();
                    txt_SOKG.Text = _Rowview.Row[XuatkhosanphamFields.Sokg.Name].ToString();
                    txt_MALYDO.Text = _Rowview.Row[XuatkhosanphamFields.Malydo.Name].ToString();
                    txt_TENLYDO.Text = _Rowview.Row[XuatkhosanphamFields.Tenlydo.Name].ToString();
                    txt_LENHSX.Text = _Rowview.Row[XuatkhosanphamFields.Lenhsx.Name].ToString();
                    txt_SOPHIEUGIAO.Text = _Rowview.Row[XuatkhosanphamFields.Sophieugiao.Name].ToString();
                    txt_MADH.Text = _Rowview.Row[XuatkhosanphamFields.Madonhang.Name].ToString();

                    txt_MASP_Validating(new object(), new CancelEventArgs());
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
                DT_XUATSANPHAM_CHITIET_FILL = new XuatkhosanphamManager().Clone();
                BS_XUATSANPHAM_CHITIET = new BindingSource(DT_XUATSANPHAM_CHITIET_FILL, null);
                GRID_XUATSANPHAMCHITIET.DataSource = BS_XUATSANPHAM_CHITIET;
            }
            else
            {
                DT_XUATSANPHAM_CHITIET_FILL = new XuatkhosanphamManager().SelectByNgayxuatMakhoRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), txt_MAKHO.Text.Trim());

                DataView Source_View = new DataView(DT_XUATSANPHAM_CHITIET_FILL);
                BS_XUATSANPHAM_CHITIET = new BindingSource();
                BS_XUATSANPHAM_CHITIET.DataSource = Source_View;
                GRID_XUATSANPHAMCHITIET.DataSource = BS_XUATSANPHAM_CHITIET;
            }
            BS_XUATSANPHAM_CHITIET.CurrentChanged += new EventHandler(BS_XUATSANPHAM_CHITIET_CurrentChanged);
            BS_XUATSANPHAM_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_XUATSANPHAM_CHITIET_FILL.NewRow();
            r_Detail[XuatkhosanphamFields.Masanpham.Name] = txt_MASP.Text;
            r_Detail[XuatkhosanphamFields.Tensanpham.Name] = txt_TENSP.Text;
            try { r_Detail[XuatkhosanphamFields.Soluong.Name] = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim()); }
            catch { }
            try { r_Detail[XuatkhosanphamFields.Somet.Name] = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim()); }
            catch { }
            try { r_Detail[XuatkhosanphamFields.Sokg.Name] = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim()); }
            catch { }
            r_Detail[XuatkhosanphamFields.Malydo.Name] = txt_MALYDO.Text;
            r_Detail[XuatkhosanphamFields.Tenlydo.Name] = txt_TENLYDO.Text;
            r_Detail[XuatkhosanphamFields.Lenhsx.Name] = txt_LENHSX.Text;
            r_Detail[XuatkhosanphamFields.Sophieugiao.Name] = txt_SOPHIEUGIAO.Text;
            r_Detail[XuatkhosanphamFields.Madonhang.Name] = txt_MADH.Text;

            DT_XUATSANPHAM_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_XUATSANPHAM_CHITIET_FILL);
            BS_XUATSANPHAM_CHITIET = new BindingSource();
            BS_XUATSANPHAM_CHITIET.DataSource = Source_View;
            GRID_XUATSANPHAMCHITIET.DataSource = BS_XUATSANPHAM_CHITIET;
            BS_XUATSANPHAM_CHITIET.Position = DT_XUATSANPHAM_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_XUATSANPHAMCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[XuatkhosanphamFields.Id.Name].ToString();
            string _MASANPHAM = _view[XuatkhosanphamFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_XUATSANPHAMCHITIET.CurrentRow.Delete();
            }
            else
            {
                XuatkhosanphamManager _XuatkhosanphamManager = new XuatkhosanphamManager();
                XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity();
                try { _XuatkhosanphamEntity = _XuatkhosanphamManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_XuatkhosanphamEntity != null && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _XuatkhosanphamManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_XUATSANPHAM_CHITIET_FILL.Select(XuatkhosanphamFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_XUATSANPHAM_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_XUATSANPHAM_CHITIET.ResetCurrentItem();
                    GRID_XUATSANPHAMCHITIET.DataSource = BS_XUATSANPHAM_CHITIET;
                }
                GRID_XUATSANPHAMCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        private void GRID_XUATSANPHAMCHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        #endregion


        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngayxuat = Convert.ToDateTime(txt_NGAY.Text.Trim());

            GRID_XUATSANPHAMCHITIET.UpdateData();
            EntityCollection _XuatkhosanphamEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_XUATSANPHAMCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity();
                _XuatkhosanphamEntity.Ngayxuat = _ngayxuat;
                _XuatkhosanphamEntity.Makho = txt_MAKHO.Text.Trim();
                _XuatkhosanphamEntity.Tenkho = txt_TENKHO.Text.Trim();
                _XuatkhosanphamEntity.Masanpham = _view.Row[XuatkhosanphamFields.Masanpham.Name].ToString();
                _XuatkhosanphamEntity.Tensanpham = _view.Row[XuatkhosanphamFields.Tensanpham.Name].ToString();
                _XuatkhosanphamEntity.Soluong = Convert.ToDecimal(_view.Row[XuatkhosanphamFields.Soluong.Name].ToString());
                _XuatkhosanphamEntity.Somet = Convert.ToDecimal(_view.Row[XuatkhosanphamFields.Somet.Name].ToString());
                _XuatkhosanphamEntity.Sokg = Convert.ToDecimal(_view.Row[XuatkhosanphamFields.Sokg.Name].ToString());
                _XuatkhosanphamEntity.Malydo = _view.Row[XuatkhosanphamFields.Malydo.Name].ToString();
                _XuatkhosanphamEntity.Tenlydo = _view.Row[XuatkhosanphamFields.Tenlydo.Name].ToString();
                _XuatkhosanphamEntity.Lenhsx = _view.Row[XuatkhosanphamFields.Lenhsx.Name].ToString();
                _XuatkhosanphamEntity.Sophieugiao = _view.Row[XuatkhosanphamFields.Sophieugiao.Name].ToString();
                _XuatkhosanphamEntity.Madonhang = _view.Row[XuatkhosanphamFields.Madonhang.Name].ToString();

                try { _XuatkhosanphamEntity.Id = Convert.ToInt64(_view[XuatkhosanphamFields.Id.Name].ToString()); }
                catch { }
                _XuatkhosanphamEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_XuatkhosanphamEntity.IsNew)
                {
                    EntityCollection drDHCT = (new XuatkhosanphamManager()).SelectById(_XuatkhosanphamEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _XuatkhosanphamEntity.Ngaysua = DateTime.Now;
                        _XuatkhosanphamEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _XuatkhosanphamEntity.IsNew = false;
                    }
                    else
                    {
                        _XuatkhosanphamEntity.Ngaytao = DateTime.Now;
                        _XuatkhosanphamEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if (!string.IsNullOrEmpty(_XuatkhosanphamEntity.Masanpham))
                    _XuatkhosanphamEntityCol.Add(_XuatkhosanphamEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (XuatkhosanphamEntity _XuatkhosanphamEntity in _XuatkhosanphamEntityCol)
            {
                if (_XuatkhosanphamEntity.IsNew)
                {
                    DataRow _r_Insert = DT_XUATSANPHAM_CHITIET.NewRow();
                    DT_XUATSANPHAM_CHITIET.Rows.Add(_r_Insert);
                    _XuatkhosanphamManager.InsertV2(_XuatkhosanphamEntity, _r_Insert, DT_XUATSANPHAM_CHITIET, BS_XUATSANPHAM_CHITIET);
                }
                else _XuatkhosanphamManager.Update(_XuatkhosanphamEntity);
            }

            GRID_XUATSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Ngayxuat.Name].Value = _ngayxuat;
            GRID_XUATSANPHAM.CurrentRow.Cells[XuatkhosanphamFields.Makho.Name].Value = txt_MAKHO.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhosanphamManager.Convert(_XuatkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }


        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_NGAY.Text = txt_MAKHO.Text = txt_TENKHO.Text = txt_MASP.Text = txt_TENSP.Text = txt_SOLUONG.Text = txt_SOM.Text = txt_SOKG.Text = txt_MALYDO.Text = txt_TENLYDO.Text = txt_LENHSX.Text = txt_SOPHIEUGIAO.Text = txt_MADH.Text = string.Empty;
            r_Insert = DT_XUATSANPHAM.NewRow();
            DT_XUATSANPHAM.Rows.Add(r_Insert);
            BS_XUATSANPHAM.Position = DT_XUATSANPHAM.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            txt_MAKHO.Text = txt_TENKHO.Text = txt_SOLUONG.Text = txt_SOKG.Text = txt_SOM.Text = txt_MASP.Text = txt_TENSP.Text = txt_MALYDO.Text
                = txt_TENLYDO.Text = txt_LENHSX.Text = txt_SOPHIEUGIAO.Text = txt_MADH.Text = string.Empty;
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENSP }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_XUATSANPHAM.Enabled = false;
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
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENSP }));
            }
            GRID_XUATSANPHAMCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_XUATSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATSANPHAMCHITIET.Enabled = true;
            GRID_XUATSANPHAM.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_XUATSANPHAM.Rows.Remove(r_Insert);
            }
            BS_XUATSANPHAM_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_XUATSANPHAM.Enabled = true;
            GRID_XUATSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            XuatkhosanphamManager _XuatkhosanphamManager = new XuatkhosanphamManager();
            XuatkhosanphamEntity _XuatkhosanphamEntity = new XuatkhosanphamEntity();
            _XuatkhosanphamEntity = _XuatkhosanphamManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_XuatkhosanphamEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_LENHSX.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _XuatkhosanphamManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_XUATSANPHAM.CurrentRow.Delete();
                    BS_XUATSANPHAM_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhosanphamManager.Convert(_XuatkhosanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_XUATSANPHAM.Enabled = true;
            GRID_XUATSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _XuatkhosanphamManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
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
                GRID_XUATSANPHAM.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_XUATSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_XUATSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_XUATSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate


        private void txt_MASP_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MASP.Text.Trim()) || DT_DMSP == null || DT_DMSP.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MASP.Text.Trim().ToUpper();
            _RowViewSelect = checkmasp(_str_MACANTIM, DT_DMSP);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMSP, DmhangFields.Masp.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MASP.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENSP.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();

            }
            else
            {
                txt_TENSP.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
            }
        }
        private DataRow checkmasp(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmhangFields.Masp.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
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
        private void txt_MASP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMHANG frm_Dm = new FRM_DMHANG();
                frm_Dm.Text = "Danh mục sản phẩm";
                frm_Dm.ShowDialog();
                DT_DMSP = new DmhangManager().SelectAllRDT();
            }
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
                GRID_XUATSANPHAM.ColumnAutoResize = true;
            else
                GRID_XUATSANPHAM.ColumnAutoResize = false;
        }

        private void FRM_XUATSANPHAM_FormClosing(object sender, FormClosingEventArgs e)
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
