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
    public partial class FRM_NHAPMANG : FRM_DMPARENT
    {
        private NhapkhomangManager _NhapkhomangManager = new NhapkhomangManager();
        private NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_NHAPMANG = new DataTable(), DT_NHAPMANG_CHITIET = new DataTable(), DT_NHAPMANG_CHITIET_FILL = new DataTable();
        private BindingSource BS_NHAPMANG = new BindingSource(), BS_NHAPMANG_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_NHAPMANG = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_NHAPMANGCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MAMANG = "", MAKHO = "";
        private DataTable DT_DMMANG = new DataTable(), DT_DMKHO = new DataTable(), DT_DMLYDONHAPXUAT = new DataTable();



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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_NHAPMANG");
                        DT_NHAPMANG = LIB.Procedures.Danhsachnhapmang(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, string.Empty);
                        DT_NHAPMANG_CHITIET = LIB.SESSION_START.DT_NHAPMANG;

                        DT_DMKHO = LIB.SESSION_START.DT_DMKHO;
                        DT_DMMANG = LIB.SESSION_START.DT_DMMANG;
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

        public FRM_NHAPMANG()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            NhapkhomangManager _NhapkhomangManager = new NhapkhomangManager();
            DataTable dt111 = LIB.Procedures.Danhsachnhapmang(Ngaydauthang, Ngaycuoithang, MAKHO);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPMANG.xml");
            dt111 = LIB.Procedures.Danhsachnhapmangchitiet(MAHIEU_PK, MAMANG);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPMANGCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPMANG.xml", GRID_NHAPMANG, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_NHAPMANGCHITIET.xml", GRID_NHAPMANGCHITIET, pne_CHITIET);
            GRID_NHAPMANGCHITIET.DeletingRecord += GRID_NHAPMANGCHITIET_DeletingRecord;

            //GRID_NHAPMANG.RootTable.Groups.Add(GRID_NHAPMANG.Tables[0].Columns[NhapkhomangFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_NHAPMANG);
            BS_NHAPMANG = new BindingSource();
            BS_NHAPMANG.DataSource = Source_View;
            GRID_NHAPMANG.DataSource = BS_NHAPMANG;
            BS_NHAPMANG.CurrentChanged += new EventHandler(BS_NHAPMANG_CurrentChanged);
            BS_NHAPMANG_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_NHAPMANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_NHAPMANG.UpdateData();
                if (BS_NHAPMANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_NHAPMANG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[NhapkhomangFields.Ngaynhap.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[NhapkhomangFields.Ngaynhap.Name].ToString();
                    txt_MAKHO.Text = _Rowview.Row[NhapkhomangFields.Makho.Name].ToString();
                    //txt_TENKHO.Text = _Rowview.Row[NhapkhomangFields.Tenkho.Name].ToString();
                    txt_MAKHO_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_NHAPMANG_CurrentChanged"); }
        }

        void BS_NHAPMANG_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_NHAPMANG_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_NHAPMANG_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[NhapkhomangFields.Id.Name].ToString();

                    txt_MAMANG.Text = _Rowview.Row[NhapkhomangFields.Mamang.Name].ToString();
                    txt_TENMANG.Text = _Rowview.Row[NhapkhomangFields.Tenmang.Name].ToString();
                    txt_SOM.Text = _Rowview.Row[NhapkhomangFields.Somet.Name].ToString();
                    txt_SOKG.Text = _Rowview.Row[NhapkhomangFields.Sokg.Name].ToString();
                    txt_MALYDO.Text = _Rowview.Row[NhapkhomangFields.Malydo.Name].ToString();
                    txt_TENLYDO.Text = _Rowview.Row[NhapkhomangFields.Tenlydo.Name].ToString();
                    txt_LENHSX.Text = _Rowview.Row[NhapkhomangFields.Lenhsx.Name].ToString();
                    txt_SOHD.Text = _Rowview.Row[NhapkhomangFields.Sohopdongmua.Name].ToString();

                    txt_MAMANG_Validating(new object(), new CancelEventArgs());
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
                DT_NHAPMANG_CHITIET_FILL = new NhapkhomangManager().Clone();
                BS_NHAPMANG_CHITIET = new BindingSource(DT_NHAPMANG_CHITIET_FILL, null);
                GRID_NHAPMANGCHITIET.DataSource = BS_NHAPMANG_CHITIET;
            }
            else
            {
                DT_NHAPMANG_CHITIET_FILL = new NhapkhomangManager().SelectByNgaynhapMakhoRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), txt_MAKHO.Text.Trim());

                DataView Source_View = new DataView(DT_NHAPMANG_CHITIET_FILL);
                BS_NHAPMANG_CHITIET = new BindingSource();
                BS_NHAPMANG_CHITIET.DataSource = Source_View;
                GRID_NHAPMANGCHITIET.DataSource = BS_NHAPMANG_CHITIET;
            }
            BS_NHAPMANG_CHITIET.CurrentChanged += new EventHandler(BS_NHAPMANG_CHITIET_CurrentChanged);
            BS_NHAPMANG_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }


        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_NHAPMANG_CHITIET_FILL.NewRow();
            r_Detail[NhapkhomangFields.Mamang.Name] = txt_MAMANG.Text;
            r_Detail[NhapkhomangFields.Tenmang.Name] = txt_TENMANG.Text;
            try { r_Detail[NhapkhomangFields.Somet.Name] = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim()); }
            catch { }
            try { r_Detail[NhapkhomangFields.Sokg.Name] = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim()); }
            catch { }
            r_Detail[NhapkhomangFields.Malydo.Name] = txt_MALYDO.Text;
            r_Detail[NhapkhomangFields.Tenlydo.Name] = txt_TENLYDO.Text;
            r_Detail[NhapkhomangFields.Lenhsx.Name] = txt_LENHSX.Text;
            r_Detail[NhapkhomangFields.Sohopdongmua.Name] = txt_SOHD.Text;

            DT_NHAPMANG_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_NHAPMANG_CHITIET_FILL);
            BS_NHAPMANG_CHITIET = new BindingSource();
            BS_NHAPMANG_CHITIET.DataSource = Source_View;
            GRID_NHAPMANGCHITIET.DataSource = BS_NHAPMANG_CHITIET;
            BS_NHAPMANG_CHITIET.Position = DT_NHAPMANG_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_NHAPMANGCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[NhapkhomangFields.Id.Name].ToString();
            string _MAMANG = _view[NhapkhomangFields.Mamang.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_NHAPMANGCHITIET.CurrentRow.Delete();
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
                        DataRow[] drArr = DT_NHAPMANG_CHITIET_FILL.Select(NhapkhomangFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_NHAPMANG_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_NHAPMANG_CHITIET.ResetCurrentItem();
                    GRID_NHAPMANGCHITIET.DataSource = BS_NHAPMANG_CHITIET;
                }
                GRID_NHAPMANGCHITIET.Enabled = true;
            }
            //Tinhtong();
        }

        private void GRID_NHAPMANGCHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }


        #endregion



        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngaynhap = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _NhapkhomangEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_NHAPMANGCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity();
                _NhapkhomangEntity.Ngaynhap = _ngaynhap;
                _NhapkhomangEntity.Makho = txt_MAKHO.Text.Trim();
                _NhapkhomangEntity.Tenkho = txt_TENKHO.Text.Trim();
                _NhapkhomangEntity.Mamang = _view.Row[NhapkhomangFields.Mamang.Name].ToString();
                _NhapkhomangEntity.Tenmang = _view.Row[NhapkhomangFields.Tenmang.Name].ToString();
                _NhapkhomangEntity.Somet = Convert.ToDecimal(_view.Row[NhapkhomangFields.Somet.Name].ToString());
                _NhapkhomangEntity.Sokg = Convert.ToDecimal(_view.Row[NhapkhomangFields.Sokg.Name].ToString());
                _NhapkhomangEntity.Malydo = _view.Row[NhapkhomangFields.Malydo.Name].ToString();
                _NhapkhomangEntity.Tenlydo = _view.Row[NhapkhomangFields.Tenlydo.Name].ToString();
                _NhapkhomangEntity.Lenhsx = _view.Row[NhapkhomangFields.Lenhsx.Name].ToString();
                _NhapkhomangEntity.Sohopdongmua = _view.Row[NhapkhomangFields.Sohopdongmua.Name].ToString();

                #region xét isnew
                try { _NhapkhomangEntity.Id = Convert.ToInt64(_view[NhapkhomangFields.Id.Name].ToString()); }
                catch { }

                _NhapkhomangEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_NhapkhomangEntity.IsNew)
                {
                    EntityCollection drDHCT = (new NhapkhomangManager()).SelectById(_NhapkhomangEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _NhapkhomangEntity.Ngaysua = DateTime.Now;
                        _NhapkhomangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _NhapkhomangEntity.IsNew = false;
                    }
                    else
                    {
                        _NhapkhomangEntity.Ngaytao = DateTime.Now;
                        _NhapkhomangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }
                #endregion

                if (!string.IsNullOrEmpty(_NhapkhomangEntity.Mamang))
                    _NhapkhomangEntityCol.Add(_NhapkhomangEntity);
            }

            foreach (NhapkhomangEntity _NhapkhomangEntity in _NhapkhomangEntityCol)
            {
                if (_NhapkhomangEntity.IsNew)
                {
                    DataRow _r_Insert = DT_NHAPMANG_CHITIET.NewRow();
                    DT_NHAPMANG_CHITIET.Rows.Add(_r_Insert);
                    _NhapkhomangManager.InsertV2(_NhapkhomangEntity, _r_Insert, DT_NHAPMANG_CHITIET, BS_NHAPMANG_CHITIET);
                }
                else _NhapkhomangManager.Update(_NhapkhomangEntity);
            }

            GRID_NHAPMANG.CurrentRow.Cells[NhapkhomangFields.Ngaynhap.Name].Value = _ngaynhap;
            GRID_NHAPMANG.CurrentRow.Cells[NhapkhomangFields.Makho.Name].Value = txt_MAKHO.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_NhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            NhapkhomangManager _NhapkhomangManager = new NhapkhomangManager();
            NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity();
            r_Insert = DT_NHAPMANG.NewRow();
            DT_NHAPMANG.Rows.Add(r_Insert);
            BS_NHAPMANG.Position = DT_NHAPMANG.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            txt_MAKHO.Text = txt_TENKHO.Text = txt_SOKG.Text = txt_SOM.Text = txt_MAMANG.Text = txt_TENMANG.Text = txt_MALYDO.Text = txt_TENLYDO.Text = txt_LENHSX.Text = txt_SOHD.Text = string.Empty;
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHO, txt_TENMANG }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_NHAPMANG.Enabled = false;

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
                txt_LENHSX.Focus();
            }
            GRID_NHAPMANGCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_NHAPMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_NHAPMANGCHITIET.Enabled = true;
            GRID_NHAPMANG.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_NHAPMANG.Rows.Remove(r_Insert);
            }
            BS_NHAPMANG_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_NHAPMANG.Enabled = true;
            GRID_NHAPMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            NhapkhomangManager _NhapkhomangManager = new NhapkhomangManager();
            NhapkhomangEntity _NhapkhomangEntity = new NhapkhomangEntity();
            _NhapkhomangEntity = _NhapkhomangManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_NhapkhomangEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_LENHSX.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _NhapkhomangManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_NHAPMANG.CurrentRow.Delete();
                    BS_NHAPMANG_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhomangManager.Convert(_NhapkhomangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_NHAPMANG.Enabled = true;
            GRID_NHAPMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_NHAPMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _NhapkhomangManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
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
                GRID_NHAPMANG.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_NHAPMANGCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_NHAPMANGCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_NHAPMANGCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate

        private void txt_LYDO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MALYDO.Text.Trim()) || DT_DMLYDONHAPXUAT == null || DT_DMLYDONHAPXUAT.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MALYDO.Text.Trim().ToUpper();
            _RowViewSelect = checkmalydo(Str_MASIEUTHI, DT_DMLYDONHAPXUAT);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LYDONHAPXUAT.xml",
                        DT_DMLYDONHAPXUAT, DmlydonhapxuatFields.Malydo.Name, Str_MASIEUTHI);
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
        private DataRow checkmalydo(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmlydonhapxuatFields.Malydo.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
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
        private void txt_MAMANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMANG frm_Dm = new FRM_DMMANG();
                frm_Dm.Text = "Danh mục màng";
                frm_Dm.ShowDialog();
                DT_DMMANG = new DmmangManager().SelectAllRDT();
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
                GRID_NHAPMANG.ColumnAutoResize = true;
            else
                GRID_NHAPMANG.ColumnAutoResize = false;
        }

        private void FRM_NHAPMANG_FormClosing(object sender, FormClosingEventArgs e)
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
