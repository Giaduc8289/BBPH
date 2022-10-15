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
    public partial class FRM_KIEMKESANPHAM : FRM_DMPARENT
    {
        private SodusanphamManager _SodusanphamManager = new SodusanphamManager();
        private SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_SODUSANPHAM = new DataTable(), DT_SODUSANPHAM_CHITIET = new DataTable(), DT_SODUSANPHAM_CHITIET_FILL = new DataTable();
        private BindingSource BS_SODUSANPHAM = new BindingSource(), BS_SODUSANPHAM_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_SODUSANPHAM = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_SODUSANPHAMCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET="" ;
        private string MASP = "", MAKHO ="" ;
        private DataTable DT_DMSP = new DataTable(), DT_DMKHO = new DataTable();



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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KIEMKESANPHAM");
                        DT_SODUSANPHAM = LIB.Procedures.Danhsachkiemkesanpham(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty);
                        DT_SODUSANPHAM_CHITIET = LIB.SESSION_START.DT_SODUSANPHAM;

                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
                        DT_DMSP = LIB.SESSION_START.DM_HANG;
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

        public FRM_KIEMKESANPHAM()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            SodusanphamManager _SodusanphamManager = new SodusanphamManager();
            DataTable dt111 = LIB.Procedures.Danhsachkiemkesanpham(Ngaydauthang, Ngaycuoithang, MAKHO);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKESANPHAM.xml");
            dt111 = _SodusanphamManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKESANPHAMCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKESANPHAM.xml", GRID_SODUSANPHAM, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKESANPHAMCHITIET.xml", GRID_SODUSANPHAMCHITIET, pne_CHITIET);
            //GRID_SODUSANPHAM.RootTable.Groups.Add(GRID_SODUSANPHAM.Tables[0].Columns[SodusanphamFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_SODUSANPHAM);
            BS_SODUSANPHAM = new BindingSource();
            BS_SODUSANPHAM.DataSource = Source_View;
            GRID_SODUSANPHAM.DataSource = BS_SODUSANPHAM;
            BS_SODUSANPHAM.CurrentChanged += new EventHandler(BS_SODUSANPHAM_CurrentChanged);
            BS_SODUSANPHAM_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_SODUSANPHAM_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_SODUSANPHAM.UpdateData();
                if (BS_SODUSANPHAM.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_SODUSANPHAM.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[SodusanphamFields.Ngaykiemke.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[SodusanphamFields.Ngaykiemke.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[SodusanphamFields.Makho.Name].ToString();
                    //txt_TENKHO.Text = _Rowview.Row[SodusanphamFields.Tenkho.Name].ToString();
                    txt_MAKHO_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_SODUSANPHAM_CurrentChanged"); }
        }

        void BS_SODUSANPHAM_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_SODUSANPHAM_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_SODUSANPHAM_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[SodusanphamFields.Id.Name].ToString();

                    txt_MASP.Text = _Rowview.Row[SodusanphamFields.Masanpham.Name].ToString();
                    txt_TENSP.Text = _Rowview.Row[SodusanphamFields.Tensanpham.Name].ToString();
                    txt_SOLUONG.Text = _Rowview.Row[SodusanphamFields.Soluong.Name].ToString();
                    txt_SOM.Text = _Rowview.Row[SodusanphamFields.Somet.Name].ToString();
                    //txt_SOKG.Text = _Rowview.Row[SodusanphamFields.Sokg.Name].ToString();
                    //txt_MALYDO.Text = _Rowview.Row[SodusanphamFields.Malydo.Name].ToString();
                    //txt_TENLYDO.Text = _Rowview.Row[SodusanphamFields.Tenlydo.Name].ToString();
                    //txt_LENHSX.Text = _Rowview.Row[SodusanphamFields.Lenhsx.Name].ToString();
                    //txt_SOHD.Text = _Rowview.Row[SodusanphamFields.Sohopdongmua.Name].ToString();

                    txt_MASP_Validating(new object(), new CancelEventArgs());
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
                DT_SODUSANPHAM_CHITIET_FILL = new SodusanphamManager().Clone();
                BS_SODUSANPHAM_CHITIET = new BindingSource(DT_SODUSANPHAM_CHITIET_FILL, null);
                GRID_SODUSANPHAMCHITIET.DataSource = BS_SODUSANPHAM_CHITIET;
            }
            else
            {
                DT_SODUSANPHAM_CHITIET_FILL = new SodusanphamManager().SelectByNgaykiemkeMakhoRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), txt_MAKHO.Text.Trim());

                DataView Source_View = new DataView(DT_SODUSANPHAM_CHITIET_FILL);
                BS_SODUSANPHAM_CHITIET = new BindingSource();
                BS_SODUSANPHAM_CHITIET.DataSource = Source_View;
                GRID_SODUSANPHAMCHITIET.DataSource = BS_SODUSANPHAM_CHITIET;
            }
            BS_SODUSANPHAM_CHITIET.CurrentChanged += new EventHandler(BS_SODUSANPHAM_CHITIET_CurrentChanged);
            BS_SODUSANPHAM_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }


        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_SODUSANPHAM_CHITIET_FILL.NewRow();
            r_Detail[SodusanphamFields.Masanpham.Name] = txt_MASP.Text;
            r_Detail[SodusanphamFields.Tensanpham.Name] = txt_TENSP.Text;
            try { r_Detail[SodusanphamFields.Soluong.Name] = LIB.ConvertString.NumbertoDB(txt_SOLUONG.Text.Trim()); }
            catch { }
            try { r_Detail[SodusanphamFields.Somet.Name] = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim()); }
            catch { }

            DT_SODUSANPHAM_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_SODUSANPHAM_CHITIET_FILL);
            BS_SODUSANPHAM_CHITIET = new BindingSource();
            BS_SODUSANPHAM_CHITIET.DataSource = Source_View;
            GRID_SODUSANPHAMCHITIET.DataSource = BS_SODUSANPHAM_CHITIET;
            BS_SODUSANPHAM_CHITIET.Position = DT_SODUSANPHAM_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_SODUSANPHAMCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[SodusanphamFields.Id.Name].ToString();
            string _MASANPHAM = _view[SodusanphamFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_SODUSANPHAMCHITIET.CurrentRow.Delete();
            }
            else
            {
                SodusanphamManager _SodusanphamManager = new SodusanphamManager();
                SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity();
                try { _SodusanphamEntity = _SodusanphamManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_SodusanphamEntity != null && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _SodusanphamManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_SODUSANPHAM_CHITIET_FILL.Select(SodusanphamFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_SODUSANPHAM_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_SODUSANPHAM_CHITIET.ResetCurrentItem();
                    GRID_SODUSANPHAMCHITIET.DataSource = BS_SODUSANPHAM_CHITIET;
                }
                GRID_SODUSANPHAMCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        #endregion


        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DateTime _ngaynhap = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _SodusanphamEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_SODUSANPHAMCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                SodusanphamEntity _nhapkhosanphamEntity = new SodusanphamEntity();
                _nhapkhosanphamEntity.Ngaykiemke = _ngaynhap;
                _nhapkhosanphamEntity.Makho = txt_MAKHO.Text.Trim();
                _nhapkhosanphamEntity.Tenkho = txt_TENKHO.Text.Trim();
                _nhapkhosanphamEntity.Masanpham = _view.Row[SodusanphamFields.Masanpham.Name].ToString();
                _nhapkhosanphamEntity.Tensanpham = _view.Row[SodusanphamFields.Tensanpham.Name].ToString();
                _nhapkhosanphamEntity.Soluong = Convert.ToDecimal(_view.Row[SodusanphamFields.Soluong.Name].ToString());
                _nhapkhosanphamEntity.Somet = Convert.ToDecimal(_view.Row[SodusanphamFields.Somet.Name].ToString());


                if (!string.IsNullOrEmpty(_nhapkhosanphamEntity.Masanpham))
                    _SodusanphamEntityCol.Add(_nhapkhosanphamEntity);
            }

            foreach (SodusanphamEntity _nhapkhosanphamEntity in _SodusanphamEntityCol)
            {
                if (_nhapkhosanphamEntity.IsNew)
                {
                    DataRow _r_Insert = DT_SODUSANPHAM_CHITIET.NewRow();
                    DT_SODUSANPHAM_CHITIET.Rows.Add(_r_Insert);
                    _SodusanphamManager.InsertV2(_nhapkhosanphamEntity, _r_Insert, DT_SODUSANPHAM_CHITIET, BS_SODUSANPHAM_CHITIET);
                }
                else _SodusanphamManager.Update(_nhapkhosanphamEntity);
            }

            //if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            //{
            //    _SodusanphamEntity.Ngaytao = DateTime.Now;
            //    _SodusanphamEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
            //    _str_DMCHUONG_PK = _SodusanphamManager.InsertV2(_SodusanphamEntity, r_Insert, DT_SODUSANPHAM, BS_SODUSANPHAM);
            //     GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_SodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            //    BS_SODUSANPHAM.ResetCurrentItem();
            //}
            //else
            //{
            //    _SodusanphamEntity.Ngaysua = DateTime.Now;
            //    _SodusanphamEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
            //    _SodusanphamManager.Update(_SodusanphamEntity);
            GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Ngaykiemke.Name].Value = _ngaynhap;
            GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Makho.Name].Value = txt_MAKHO.Text.Trim();
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Tenkho.Name].Value = txt_TENKHO.Text.Trim();
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Masanpham.Name].Value = _SodusanphamEntity.Masanpham;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Tensanpham.Name].Value = _SodusanphamEntity.Tensanpham;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Soluong.Name].Value = _SodusanphamEntity.Soluong;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Somet.Name].Value = _SodusanphamEntity.Somet;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Sokg.Name].Value = _SodusanphamEntity.Sokg;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Malydo.Name].Value = _SodusanphamEntity.Malydo;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Tenlydo.Name].Value = _SodusanphamEntity.Tenlydo;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Lenhsx.Name].Value = _SodusanphamEntity.Lenhsx;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Sophieugiao.Name].Value = _SodusanphamEntity.Sophieugiao;
            //GRID_SODUSANPHAM.CurrentRow.Cells[SodusanphamFields.Madonhang.Name].Value = _SodusanphamEntity.Madonhang;

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_SodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //}
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_NGAY.Text = txt_MAKHO.Text = txt_TENKHO.Text = txt_MASP.Text = txt_TENSP.Text = txt_SOLUONG.Text = txt_SOM.Text = txt_SOKG.Text = txt_MALYDO.Text = txt_TENKHO.Text = txt_LENHSX.Text = txt_SOHD.Text = string.Empty;

            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            SodusanphamManager _SodusanphamManager = new SodusanphamManager();
            SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity();
            r_Insert = DT_SODUSANPHAM.NewRow();
            DT_SODUSANPHAM.Rows.Add(r_Insert);
            BS_SODUSANPHAM.Position = DT_SODUSANPHAM.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {txt_TENKHO, txt_TENSP }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_SODUSANPHAM.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENSP }));
                txt_NGAY.Focus();
            }
            GRID_SODUSANPHAMCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_SODUSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUSANPHAMCHITIET.Enabled = true;
            GRID_SODUSANPHAM.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_SODUSANPHAM.Rows.Remove(r_Insert);
            }
            BS_SODUSANPHAM_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_SODUSANPHAM.Enabled = true;
            GRID_SODUSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            SodusanphamManager _SodusanphamManager = new SodusanphamManager();
            SodusanphamEntity _SodusanphamEntity = new SodusanphamEntity();
            _SodusanphamEntity = _SodusanphamManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_SodusanphamEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_NGAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _SodusanphamManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_SODUSANPHAM.CurrentRow.Delete();
                    BS_SODUSANPHAM_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodusanphamManager.Convert(_SodusanphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_SODUSANPHAM.Enabled = true;
            GRID_SODUSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _SodusanphamManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
            //{
            //    MessageBox.Show("Mã công nhân bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_MAMAY.Focus();
            //    return;
            //}
            if (txt_NGAY.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NGAY.Focus();
                return;
            }
            else if (txt_MAKHO.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAKHO.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_SODUSANPHAM.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_SODUSANPHAMCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_SODUSANPHAMCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_SODUSANPHAMCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
            string Str_MASIEUTHI = txt_MASP.Text.Trim().ToUpper();
            _RowViewSelect = checkmasp(Str_MASIEUTHI, DT_DMSP);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMSP, DmhangFields.Masp.Name, Str_MASIEUTHI);
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
                GRID_SODUSANPHAM.ColumnAutoResize = true;
            else
                GRID_SODUSANPHAM.ColumnAutoResize = false;
        }

        private void FRM_KIEMKESANPHAM_FormClosing(object sender, FormClosingEventArgs e)
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
