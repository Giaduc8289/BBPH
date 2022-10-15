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
    public partial class FRM_XUATMANG : FRM_DMPARENT
    {
        private XuatkhomangManager _XuatkhomangManager = new XuatkhomangManager();
        private XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_XUATMANG = new DataTable(), DT_XUATMANG_CHITIET = new DataTable(), DT_XUATMANG_CHITIET_FILL = new DataTable();
        private BindingSource BS_XUATMANG = new BindingSource(), BS_XUATMANG_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_XUATMANG = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_XUATMANGCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MAMANG = "", MAKHO ="" ;
        private DataTable DT_DMMANG = new DataTable(), DT_DMKHO = new DataTable();



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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_XUATMANG");
                        DT_XUATMANG = LIB.Procedures.Danhsachxuatmang(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty); // LIB.SESSION_START.DT_XUATMANG;
                        DT_XUATMANG_CHITIET = LIB.SESSION_START.DT_XUATMANG;

                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
                        DT_DMMANG = LIB.SESSION_START.DM_HANG;
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

        public FRM_XUATMANG()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            XuatkhomangManager _XuatkhomangManager = new XuatkhomangManager();
            DataTable dt111 = LIB.Procedures.Danhsachxuatmang(Ngaydauthang, Ngaycuoithang, MAKHO);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATMANG.xml");
            dt111 = LIB.Procedures.Danhsachxuatmangchitiet(MAHIEU_PK, MAMANG);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATMANGCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATMANG.xml", GRID_XUATMANG, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_XUATMANGCHITIET.xml", GRID_XUATMANGCHITIET, pne_CHITIET);
            GRID_XUATMANGCHITIET.DeletingRecord += GRID_XUATMANGCHITIET_DeletingRecord;

            //GRID_XUATMANG.RootTable.Groups.Add(GRID_XUATMANG.Tables[0].Columns[XuatkhomangFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_XUATMANG);
            BS_XUATMANG = new BindingSource();
            BS_XUATMANG.DataSource = Source_View;
            GRID_XUATMANG.DataSource = BS_XUATMANG;
            BS_XUATMANG.CurrentChanged += new EventHandler(BS_XUATMANG_CurrentChanged);
            BS_XUATMANG_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_XUATMANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_XUATMANG.UpdateData();
                if (BS_XUATMANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_XUATMANG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[XuatkhomangFields.Ngayxuat.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[XuatkhomangFields.Ngayxuat.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[XuatkhomangFields.Makho.Name].ToString();
                    //txt_TENKHO.Text = _Rowview.Row[XuatkhomangFields.Tenkho.Name].ToString();
                    txt_MAKHO_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_XUATMANG_CurrentChanged"); }
        }

        void BS_XUATMANG_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_XUATMANG_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_XUATMANG_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[XuatkhomangFields.Id.Name].ToString();

                    txt_MAMANG.Text = _Rowview.Row[XuatkhomangFields.Mamang.Name].ToString();
                    txt_TENMANG.Text = _Rowview.Row[XuatkhomangFields.Tenmang.Name].ToString();
                    txt_SOM.Text = _Rowview.Row[XuatkhomangFields.Somet.Name].ToString();
                    txt_SOKG.Text = _Rowview.Row[XuatkhomangFields.Sokg.Name].ToString();
                    txt_MALYDO.Text = _Rowview.Row[XuatkhomangFields.Malydo.Name].ToString();
                    txt_TENLYDO.Text = _Rowview.Row[XuatkhomangFields.Tenlydo.Name].ToString();
                    txt_LENHSX.Text = _Rowview.Row[XuatkhomangFields.Lenhsx.Name].ToString();
                    txt_SOPHIEUGIAO.Text = _Rowview.Row[XuatkhomangFields.Sophieugiao.Name].ToString();
                    txt_MADH.Text = _Rowview.Row[XuatkhomangFields.Madonhang.Name].ToString();

                    txt_MAMANG_Validating(new object(), new CancelEventArgs());
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
                DT_XUATMANG_CHITIET_FILL = new XuatkhomangManager().Clone();
                BS_XUATMANG_CHITIET = new BindingSource(DT_XUATMANG_CHITIET_FILL, null);
                GRID_XUATMANGCHITIET.DataSource = BS_XUATMANG_CHITIET;
            }
            else
            {
                DT_XUATMANG_CHITIET_FILL = new XuatkhomangManager().SelectByNgayxuatMakhoRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), txt_MAKHO.Text.Trim());

                DataView Source_View = new DataView(DT_XUATMANG_CHITIET_FILL);
                BS_XUATMANG_CHITIET = new BindingSource();
                BS_XUATMANG_CHITIET.DataSource = Source_View;
                GRID_XUATMANGCHITIET.DataSource = BS_XUATMANG_CHITIET;
            }
            BS_XUATMANG_CHITIET.CurrentChanged += new EventHandler(BS_XUATMANG_CHITIET_CurrentChanged);
            BS_XUATMANG_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_XUATMANG_CHITIET_FILL.NewRow();
            r_Detail[XuatkhomangFields.Mamang.Name] = txt_MAMANG.Text;
            r_Detail[XuatkhomangFields.Tenmang.Name] = txt_TENMANG.Text;
            try { r_Detail[XuatkhomangFields.Somet.Name] = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim()); }
            catch { }
            try { r_Detail[XuatkhomangFields.Sokg.Name] = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim()); }
            catch { }
            r_Detail[XuatkhomangFields.Malydo.Name] = txt_MALYDO.Text;
            r_Detail[XuatkhomangFields.Tenlydo.Name] = txt_TENLYDO.Text;
            r_Detail[XuatkhomangFields.Lenhsx.Name] = txt_LENHSX.Text;
            r_Detail[XuatkhomangFields.Sophieugiao.Name] = txt_SOPHIEUGIAO.Text;
            r_Detail[XuatkhomangFields.Madonhang.Name] = txt_MADH.Text;

            DT_XUATMANG_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_XUATMANG_CHITIET_FILL);
            BS_XUATMANG_CHITIET = new BindingSource();
            BS_XUATMANG_CHITIET.DataSource = Source_View;
            GRID_XUATMANGCHITIET.DataSource = BS_XUATMANG_CHITIET;
            BS_XUATMANG_CHITIET.Position = DT_XUATMANG_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_XUATMANGCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[XuatkhomangFields.Id.Name].ToString();
            string _MASANPHAM = _view[XuatkhomangFields.Mamang.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_XUATMANGCHITIET.CurrentRow.Delete();
            }
            else
            {
                XuatkhomangManager _XuatkhomangManager = new XuatkhomangManager();
                XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity();
                try { _XuatkhomangEntity = _XuatkhomangManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_XuatkhomangEntity != null && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _XuatkhomangManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_XUATMANG_CHITIET_FILL.Select(XuatkhomangFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_XUATMANG_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_XUATMANG_CHITIET.ResetCurrentItem();
                    GRID_XUATMANGCHITIET.DataSource = BS_XUATMANG_CHITIET;
                }
                GRID_XUATMANGCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        private void GRID_XUATMANGCHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        #endregion


        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DateTime _ngayxuat = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _XuatkhomangEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_XUATMANGCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                XuatkhomangEntity _xuatkhomangEntity = new XuatkhomangEntity();
                _xuatkhomangEntity.Ngayxuat = _ngayxuat;
                _xuatkhomangEntity.Makho = txt_MAKHO.Text.Trim();
                _xuatkhomangEntity.Tenkho = txt_TENKHO.Text.Trim();
                _xuatkhomangEntity.Mamang = _view.Row[XuatkhomangFields.Mamang.Name].ToString();
                _xuatkhomangEntity.Tenmang = _view.Row[XuatkhomangFields.Tenmang.Name].ToString();
                _xuatkhomangEntity.Somet = Convert.ToDecimal(_view.Row[XuatkhomangFields.Somet.Name].ToString());
                _xuatkhomangEntity.Sokg = Convert.ToDecimal(_view.Row[XuatkhomangFields.Sokg.Name].ToString());
                _xuatkhomangEntity.Malydo = _view.Row[XuatkhomangFields.Malydo.Name].ToString();
                _xuatkhomangEntity.Tenlydo = _view.Row[XuatkhomangFields.Tenlydo.Name].ToString();
                _xuatkhomangEntity.Lenhsx = _view.Row[XuatkhomangFields.Lenhsx.Name].ToString();
                _xuatkhomangEntity.Sophieugiao = _view.Row[XuatkhomangFields.Sophieugiao.Name].ToString();
                _xuatkhomangEntity.Madonhang = _view.Row[XuatkhomangFields.Madonhang.Name].ToString();

                try { _xuatkhomangEntity.Id = Convert.ToInt64(_view[XuatkhomangFields.Id.Name].ToString()); }
                catch { }

                _xuatkhomangEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_xuatkhomangEntity.IsNew)
                {
                    EntityCollection drDHCT = (new XuatkhomangManager()).SelectById(_xuatkhomangEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _xuatkhomangEntity.Ngaysua = DateTime.Now;
                        _xuatkhomangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _xuatkhomangEntity.IsNew = false;
                    }
                    else
                    {
                        _xuatkhomangEntity.Ngaytao = DateTime.Now;
                        _xuatkhomangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if (!string.IsNullOrEmpty(_xuatkhomangEntity.Mamang))
                    _XuatkhomangEntityCol.Add(_xuatkhomangEntity);
            }

            foreach (XuatkhomangEntity _xuatkhomangEntity in _XuatkhomangEntityCol)
            {
                if (_xuatkhomangEntity.IsNew)
                {
                    DataRow _r_Insert = DT_XUATMANG_CHITIET.NewRow();
                    DT_XUATMANG_CHITIET.Rows.Add(_r_Insert);
                    _XuatkhomangManager.InsertV2(_xuatkhomangEntity, _r_Insert, DT_XUATMANG_CHITIET, BS_XUATMANG_CHITIET);
                }
                else _XuatkhomangManager.Update(_xuatkhomangEntity);
            }

            //if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            //{
            //    _XuatkhomangEntity.Ngaytao = DateTime.Now;
            //    _XuatkhomangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
            //    _str_DMCHUONG_PK = _XuatkhomangManager.InsertV2(_XuatkhomangEntity, r_Insert, DT_XUATMANG, BS_XUATMANG);
            //     GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_XuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            //    BS_XUATMANG.ResetCurrentItem();
            //}
            //else
            //{
            //    _XuatkhomangEntity.Ngaysua = DateTime.Now;
            //    _XuatkhomangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
            //    _XuatkhomangManager.Update(_XuatkhomangEntity);
                GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Ngayxuat.Name].Value = _ngayxuat;
                GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Makho.Name].Value = txt_MAKHO.Text.Trim();
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Tenkho.Name].Value = txt_TENKHO.Text.Trim();
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Masanpham.Name].Value = _XuatkhomangEntity.Masanpham;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Tensanpham.Name].Value = _XuatkhomangEntity.Tensanpham;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Soluong.Name].Value = _XuatkhomangEntity.Soluong;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Somet.Name].Value = _XuatkhomangEntity.Somet;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Sokg.Name].Value = _XuatkhomangEntity.Sokg;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Malydo.Name].Value = _XuatkhomangEntity.Malydo;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Tenlydo.Name].Value = _XuatkhomangEntity.Tenlydo;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Lenhsx.Name].Value = _XuatkhomangEntity.Lenhsx;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Sophieugiao.Name].Value = _XuatkhomangEntity.Sophieugiao;
                //GRID_XUATMANG.CurrentRow.Cells[XuatkhomangFields.Madonhang.Name].Value = _XuatkhomangEntity.Madonhang;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_XuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //}
            return _str_DMCHUONG_PK;
        }


        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_NGAY.Text = txt_MAKHO.Text = txt_TENKHO.Text = txt_MAMANG.Text = txt_TENMANG.Text = txt_SOM.Text = txt_SOKG.Text = txt_MALYDO.Text = txt_TENLYDO.Text = txt_LENHSX.Text = txt_SOPHIEUGIAO.Text = txt_MADH.Text = string.Empty;
            XuatkhomangManager _XuatkhomangManager = new XuatkhomangManager();
            XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity();
            r_Insert = DT_XUATMANG.NewRow();
            DT_XUATMANG.Rows.Add(r_Insert);
            BS_XUATMANG.Position = DT_XUATMANG.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {txt_TENKHO, txt_TENMANG }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_XUATMANG.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENMANG }));
            }
            GRID_XUATMANGCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_XUATMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_XUATMANGCHITIET.Enabled = true;
            GRID_XUATMANG.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_XUATMANG.Rows.Remove(r_Insert);
            }
            BS_XUATMANG_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_XUATMANG.Enabled = true;
            GRID_XUATMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            XuatkhomangManager _XuatkhomangManager = new XuatkhomangManager();
            XuatkhomangEntity _XuatkhomangEntity = new XuatkhomangEntity();
            _XuatkhomangEntity = _XuatkhomangManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_XuatkhomangEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_LENHSX.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _XuatkhomangManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_XUATMANG.CurrentRow.Delete();
                    BS_XUATMANG_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhomangManager.Convert(_XuatkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_XUATMANG.Enabled = true;
            GRID_XUATMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_XUATMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _XuatkhomangManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
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
                GRID_XUATMANG.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_XUATMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_XUATMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_XUATMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate


        private void txt_MAMANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMANG.Text.Trim()) || DT_DMMANG == null || DT_DMMANG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAMANG.Text.Trim().ToUpper();
            _RowViewSelect = checkmasp(Str_MASIEUTHI, DT_DMMANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMMANG, DmhangFields.Masp.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMANG.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENMANG.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();

            }
            else
            {
                txt_TENMANG.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
            }
        }
        private DataRow checkmasp(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmhangFields.Masp.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAKHO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHO.Text.Trim()) || DT_DMKHO == null || DT_DMKHO.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAKHO.Text.Trim().ToUpper();
            _RowViewSelect = checkmacongnnhang(Str_MASIEUTHI, DT_DMKHO);
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
            {
                txt_TENKHO.Text = _RowViewSelect[DmkhoFields.Tenkho.Name].ToString();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private DataRow checkmacongnnhang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhoFields.Makho.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region Shortcut Key
        //private void txt_MAPHONGBAN_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMPHONGBAN frm_Dm = new FRM_DMPHONGBAN();
        //        frm_Dm.Text = "Danh mục phòng ban";
        //        frm_Dm.ShowDialog();
        //        DT_DMPHONGBAN = new DanhmucphongbanManager().SelectAllRDT();
        //    }
        //}
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
                GRID_XUATMANG.ColumnAutoResize = true;
            else
                GRID_XUATMANG.ColumnAutoResize = false;
        }

        private void FRM_XUATMANG_FormClosing(object sender, FormClosingEventArgs e)
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
