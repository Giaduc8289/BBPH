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
    public partial class FRM_KIEMKEMANG : FRM_DMPARENT
    {
        private SodumangManager _SodumangManager = new SodumangManager();
        private SodumangEntity _SodumangEntity = new SodumangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_SODUMANG = new DataTable(), DT_SODUMANG_CHITIET = new DataTable(), DT_SODUMANG_CHITIET_FILL = new DataTable();
        private BindingSource BS_SODUMANG = new BindingSource(), BS_SODUMANG_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_SODUMANG = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_SODUMANGCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MAMANG = "", MAKHO = "";
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KIEMKEMANG");
                        DT_SODUMANG = LIB.Procedures.Danhsachkiemkemang(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty);
                        DT_SODUMANG_CHITIET = LIB.SESSION_START.DT_SODUMANG;

                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
                        DT_DMMANG = LIB.SESSION_START.DT_DMMANG;
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

        public FRM_KIEMKEMANG()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            SodumangManager _SodumangManager = new SodumangManager();
            DataTable dt111 = LIB.Procedures.Danhsachkiemkemang(Ngaydauthang, Ngaycuoithang, MAKHO);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKEMANG.xml");
            dt111 = _SodumangManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKEMANGCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKEMANG.xml", GRID_SODUMANG, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KIEMKEMANGCHITIET.xml", GRID_SODUMANGCHITIET, pne_CHITIET);
            //GRID_SODUMANG.RootTable.Groups.Add(GRID_SODUMANG.Tables[0].Columns[SodumangFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_SODUMANG);
            BS_SODUMANG = new BindingSource();
            BS_SODUMANG.DataSource = Source_View;
            GRID_SODUMANG.DataSource = BS_SODUMANG;
            BS_SODUMANG.CurrentChanged += new EventHandler(BS_SODUMANG_CurrentChanged);
            BS_SODUMANG_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_SODUMANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_SODUMANG.UpdateData();
                if (BS_SODUMANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_SODUMANG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[SodumangFields.Ngaykiemke.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[SodumangFields.Ngaykiemke.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[SodumangFields.Makho.Name].ToString();
                    //txt_TENKHO.Text = _Rowview.Row[SodumangFields.Tenkho.Name].ToString();
                    txt_MAKHO_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_SODUMANG_CurrentChanged"); }
        }

        void BS_SODUMANG_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_SODUMANG_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_SODUMANG_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[SodumangFields.Id.Name].ToString();

                    txt_MAMANG.Text = _Rowview.Row[SodumangFields.Mamang.Name].ToString();
                    txt_TENMANG.Text = _Rowview.Row[SodumangFields.Tenmang.Name].ToString();
                    txt_SOM.Text = _Rowview.Row[SodumangFields.Somet.Name].ToString();
                    txt_SOKG.Text = _Rowview.Row[SodumangFields.Sokg.Name].ToString();

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
                DT_SODUMANG_CHITIET_FILL = new SodumangManager().Clone();
                BS_SODUMANG_CHITIET = new BindingSource(DT_SODUMANG_CHITIET_FILL, null);
                GRID_SODUMANGCHITIET.DataSource = BS_SODUMANG_CHITIET;
            }
            else
            {
                DT_SODUMANG_CHITIET_FILL = new SodumangManager().SelectByNgaykiemkeMakhoRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), txt_MAKHO.Text.Trim());

                DataView Source_View = new DataView(DT_SODUMANG_CHITIET_FILL);
                BS_SODUMANG_CHITIET = new BindingSource();
                BS_SODUMANG_CHITIET.DataSource = Source_View;
                GRID_SODUMANGCHITIET.DataSource = BS_SODUMANG_CHITIET;
            }
            BS_SODUMANG_CHITIET.CurrentChanged += new EventHandler(BS_SODUMANG_CHITIET_CurrentChanged);
            BS_SODUMANG_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }


        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_SODUMANG_CHITIET_FILL.NewRow();
            r_Detail[SodumangFields.Mamang.Name] = txt_MAMANG.Text;
            r_Detail[SodumangFields.Tenmang.Name] = txt_TENMANG.Text;
            try { r_Detail[SodumangFields.Somet.Name] = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim()); }
            catch { }
            try { r_Detail[SodumangFields.Sokg.Name] = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim()); }
            catch { }

            DT_SODUMANG_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_SODUMANG_CHITIET_FILL);
            BS_SODUMANG_CHITIET = new BindingSource();
            BS_SODUMANG_CHITIET.DataSource = Source_View;
            GRID_SODUMANGCHITIET.DataSource = BS_SODUMANG_CHITIET;
            BS_SODUMANG_CHITIET.Position = DT_SODUMANG_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_SODUMANGCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[SodumangFields.Id.Name].ToString();
            string _MAMANG = _view[SodumangFields.Mamang.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_SODUMANGCHITIET.CurrentRow.Delete();
            }
            else
            {
                NhapkhosanphamManager _NhapkhosanphamManager = new NhapkhosanphamManager();
                NhapkhosanphamEntity _NhapkhosanphamEntity = new NhapkhosanphamEntity();
                try { _NhapkhosanphamEntity = _NhapkhosanphamManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_NhapkhosanphamEntity != null && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _NhapkhosanphamManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_SODUMANG_CHITIET_FILL.Select(SodumangFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_SODUMANG_CHITIET_FILL.Rows.Remove(drArr[0]);
                        //GRID_TKNLTHOI_CHITIET.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MAMANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_SODUMANG_CHITIET.ResetCurrentItem();
                    GRID_SODUMANGCHITIET.DataSource = BS_SODUMANG_CHITIET;
                }
                GRID_SODUMANGCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        #endregion



        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngaynhap = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _SodumangEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_SODUMANGCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                SodumangEntity _NhapkhomangEntity = new SodumangEntity();
                _NhapkhomangEntity.Ngaykiemke = _ngaynhap;
                _NhapkhomangEntity.Makho = txt_MAKHO.Text.Trim();
                _NhapkhomangEntity.Tenkho = txt_TENKHO.Text.Trim();
                _NhapkhomangEntity.Mamang = _view.Row[SodumangFields.Mamang.Name].ToString();
                _NhapkhomangEntity.Tenmang = _view.Row[SodumangFields.Tenmang.Name].ToString();
                _NhapkhomangEntity.Somet = Convert.ToDecimal(_view.Row[SodumangFields.Somet.Name].ToString());
                _NhapkhomangEntity.Sokg = Convert.ToDecimal(_view.Row[SodumangFields.Sokg.Name].ToString());


                if (!string.IsNullOrEmpty(_NhapkhomangEntity.Mamang))
                    _SodumangEntityCol.Add(_NhapkhomangEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (SodumangEntity _NhapkhomangEntity in _SodumangEntityCol)
            {
                if (_NhapkhomangEntity.IsNew)
                {
                    DataRow _r_Insert = DT_SODUMANG_CHITIET.NewRow();
                    DT_SODUMANG_CHITIET.Rows.Add(_r_Insert);
                    _SodumangManager.InsertV2(_NhapkhomangEntity, _r_Insert, DT_SODUMANG_CHITIET, BS_SODUMANG_CHITIET);
                }
                else _SodumangManager.Update(_NhapkhomangEntity);
            }

            //if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            //{
            //    _SodumangEntity.Ngaytao = DateTime.Now;
            //    _SodumangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
            //    _str_MAHIEU_PK = _SodumangManager.InsertV2(_SodumangEntity, r_Insert, DT_SODUMANG, BS_SODUMANG);
            //     GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodumangManager.Convert(_SodumangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            //    BS_SODUMANG.ResetCurrentItem();
            //}
            //else
            //{
            //    _SodumangEntity.Ngaysua = DateTime.Now;
            //    _SodumangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
            //    _SodumangManager.Update(_SodumangEntity);
            GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Ngaykiemke.Name].Value = _ngaynhap;
            GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Makho.Name].Value = txt_MAKHO.Text.Trim();
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Tenkho.Name].Value = txt_TENKHO.Text.Trim();
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Mamang.Name].Value = _SodumangEntity.Mamang;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Tenmang.Name].Value = _SodumangEntity.Tenmang;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Soluong.Name].Value = _SodumangEntity.Soluong;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Somet.Name].Value = _SodumangEntity.Somet;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Sokg.Name].Value = _SodumangEntity.Sokg;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Malydo.Name].Value = _SodumangEntity.Malydo;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Tenlydo.Name].Value = _SodumangEntity.Tenlydo;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Lenhsx.Name].Value = _SodumangEntity.Lenhsx;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Sophieugiao.Name].Value = _SodumangEntity.Sophieugiao;
            //GRID_SODUMANG.CurrentRow.Cells[SodumangFields.Madonhang.Name].Value = _SodumangEntity.Madonhang;

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodumangManager.Convert(_SodumangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //}
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            SodumangManager _SodumangManager = new SodumangManager();
            SodumangEntity _SodumangEntity = new SodumangEntity();
            r_Insert = DT_SODUMANG.NewRow();
            DT_SODUMANG.Rows.Add(r_Insert);
            BS_SODUMANG.Position = DT_SODUMANG.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            txt_MAKHO.Text = txt_TENKHO.Text = txt_SOKG.Text = txt_SOM.Text = txt_MAMANG.Text = txt_TENMANG.Text = string.Empty;
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENMANG }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_SODUMANG.Enabled = false;

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
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENMANG }));
                txt_NGAY.Focus();
            }
            GRID_SODUMANGCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_SODUMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_SODUMANGCHITIET.Enabled = true;
            GRID_SODUMANG.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_SODUMANG.Rows.Remove(r_Insert);
            }
            BS_SODUMANG_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_SODUMANG.Enabled = true;
            GRID_SODUMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            SodumangManager _SodumangManager = new SodumangManager();
            SodumangEntity _SodumangEntity = new SodumangEntity();
            _SodumangEntity = _SodumangManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_SodumangEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_NGAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _SodumangManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_SODUMANG.CurrentRow.Delete();
                    BS_SODUMANG_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodumangManager.Convert(_SodumangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_SODUMANG.Enabled = true;
            GRID_SODUMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_SODUMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _SodumangManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
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
                GRID_SODUMANG.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_SODUMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_SODUMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_SODUMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
            _RowViewSelect = checkmamang(Str_MASIEUTHI, DT_DMMANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml",
                        DT_DMMANG, DmmangFields.Mamang.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMANG.Text = _RowViewSelect[DmmangFields.Mamang.Name].ToString();
                txt_TENMANG.Text = _RowViewSelect[DmmangFields.Tenmang.Name].ToString();

            }
            else
            {
                txt_TENMANG.Text = _RowViewSelect[DmmangFields.Tenmang.Name].ToString();
            }
        }
        private DataRow checkmamang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmmangFields.Mamang.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
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
                GRID_SODUMANG.ColumnAutoResize = true;
            else
                GRID_SODUMANG.ColumnAutoResize = false;
        }

        private void FRM_KIEMKEMANG_FormClosing(object sender, FormClosingEventArgs e)
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
