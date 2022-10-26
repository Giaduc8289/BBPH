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

namespace GD.BBPH.APP.HOANTHIEN
{
    public partial class FRM_KQHOANTHIEN : FRM_DMPARENT
    {
        private KetquathanhphamManager _KetquathanhphamManager = new KetquathanhphamManager();
        private KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KQHOANTHIEN = new DataTable(), DT_KQHOANTHIEN_CHITIET = new DataTable(), DT_KQHOANTHIEN_CHITIET_FILL = new DataTable();
        private BindingSource BS_KQHOANTHIEN = new BindingSource(), BS_KQHOANTHIEN_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQHOANTHIEN = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQHOANTHIENCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET="";
        private string MASP = "", CA= "0";

        private DataTable DT_DMMAY = new DataTable(), DT_LENHTHOI = new DataTable(), DT_DMHANG = new DataTable(), DT_NHANVIEN = new DataTable(), DT_DMKHACH = new DataTable();

        //private DataTable DT_DMPHONGBAN = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQHOANTHIEN");
                        DT_KQHOANTHIEN = LIB.Procedures.Danhsachketquahoanthien(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty); // LIB.SESSION_START.DT_KQHOANTHIEN;
                        DT_KQHOANTHIEN_CHITIET = LIB.SESSION_START.DT_KQHOANTHIEN;

                        //DT_DMPHONGBAN = LIB.SESSION_START.DT_DMPHONGBAN;
                        DT_DMMAY = LIB.SESSION_START.DT_DMMAY;
                        DT_DMHANG = LIB.SESSION_START.DM_HANG;
                        DT_NHANVIEN = LIB.SESSION_START.DT_DMCONGNHAN;
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

        public FRM_KQHOANTHIEN()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            KetquathanhphamManager _KetquathanhphamManager = new KetquathanhphamManager();
            DataTable dt111 = LIB.Procedures.Danhsachketquahoanthien(Ngaydauthang, Ngaycuoithang, Convert.ToInt32(CA), MASP);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQHOANTHIEN.xml");
            dt111 = LIB.Procedures.Danhsachketquahoanthienchitiet(MAHIEU_PK, Convert.ToInt32(CA), MASP);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQHOANTHIENCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQHOANTHIEN.xml", GRID_KQHOANTHIEN, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQHOANTHIENCHITIET.xml", GRID_KQHOANTHIENCHITIET, pne_CHITIET);
            //GRID_KQHOANTHIEN.RootTable.Groups.Add(GRID_KQHOANTHIEN.Tables[0].Columns[KetquathanhphamFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_KQHOANTHIEN);
            BS_KQHOANTHIEN = new BindingSource();
            BS_KQHOANTHIEN.DataSource = Source_View;
            GRID_KQHOANTHIEN.DataSource = BS_KQHOANTHIEN;
            BS_KQHOANTHIEN.CurrentChanged += new EventHandler(BS_KQHOANTHIEN_CurrentChanged);
            BS_KQHOANTHIEN_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_KQHOANTHIEN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_KQHOANTHIEN.UpdateData();
                if (BS_KQHOANTHIEN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQHOANTHIEN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KetquathanhphamFields.Ngay.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquathanhphamFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquathanhphamFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquathanhphamFields.Mamay.Name].ToString();

                    //txt_TENKHO.Text = _Rowview.Row[KetquathanhphamFields.Tenkho.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KQHOANTHIEN_CurrentChanged"); }
        }

        void BS_KQHOANTHIEN_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_KQHOANTHIEN_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQHOANTHIEN_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[KetquathanhphamFields.Id.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquathanhphamFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquathanhphamFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquathanhphamFields.Mamay.Name].ToString();
                    txt_SOLSX.Text = _Rowview.Row[KetquathanhphamFields.SoLsx.Name].ToString();
                    txt_MASANPHAM.Text = _Rowview.Row[KetquathanhphamFields.Masanpham.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquathanhphamFields.Macongnhan.Name].ToString();
                    txt_TENSANPHAM.Text = _Rowview.Row[KetquathanhphamFields.Tensanpham.Name].ToString();
                    txt_TENMAY.Text = _Rowview.Row[KetquathanhphamFields.Tenmay.Name].ToString();
                    txt_TENCONGNHAN.Text = _Rowview.Row[KetquathanhphamFields.Tencongnhan.Name].ToString();
                    txt_SOMETVAO.Text = _Rowview.Row[KetquathanhphamFields.SoMetvao.Name].ToString();
                    txt_SOKGVAO.Text = _Rowview.Row[KetquathanhphamFields.SoKgvao.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquathanhphamFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquathanhphamFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquathanhphamFields.Thoigianchuanbi.Name].ToString();
                    txt_THOIGIANHACUON.Text = _Rowview.Row[KetquathanhphamFields.Thoigianhacuon.Name].ToString();
                    txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquathanhphamFields.Thoigiancatdau.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquathanhphamFields.Thoigiansuco.Name].ToString();
                    txt_DGNANGSUAT.Text = _Rowview.Row[KetquathanhphamFields.Dgnangsuat.Name].ToString();
                    txt_DMTUI.Text = _Rowview.Row[KetquathanhphamFields.Dmtui.Name].ToString();
                    txt_TTETUI.Text = _Rowview.Row[KetquathanhphamFields.Ttetui.Name].ToString();
                    txt_KIEMTRA.Text = _Rowview.Row[KetquathanhphamFields.Kiemtra.Name].ToString();
                    txt_PHEIN.Text = _Rowview.Row[KetquathanhphamFields.Phein.Name].ToString();
                    txt_PHEGHEP.Text = _Rowview.Row[KetquathanhphamFields.Pheghep.Name].ToString();
                    txt_PHECHIA.Text = _Rowview.Row[KetquathanhphamFields.Phechia.Name].ToString();
                    txt_PHEBIEN.Text = _Rowview.Row[KetquathanhphamFields.Phebien.Name].ToString();
                    txt_PHETHOI.Text = _Rowview.Row[KetquathanhphamFields.Phethoi.Name].ToString();
                    txt_PHECHINHMAY.Text = _Rowview.Row[KetquathanhphamFields.Phechinhmay.Name].ToString();
                    txt_PHEKHAC.Text = _Rowview.Row[KetquathanhphamFields.Phekhac.Name].ToString();
                    txt_TITRONGTUI.Text = _Rowview.Row[KetquathanhphamFields.Titrongtui.Name].ToString();
                    txt_SOCON.Text = _Rowview.Row[KetquathanhphamFields.Socon.Name].ToString();

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
                DT_KQHOANTHIEN_CHITIET_FILL = new KetquathanhphamManager().Clone();
                BS_KQHOANTHIEN_CHITIET = new BindingSource(DT_KQHOANTHIEN_CHITIET_FILL, null);
                GRID_KQHOANTHIENCHITIET.DataSource = BS_KQHOANTHIEN_CHITIET;
            }
            else
            {
                DT_KQHOANTHIEN_CHITIET_FILL = new KetquathanhphamManager().SelectByNgayCaMamayRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), Convert.ToInt32(txt_CA.Text.Trim()) ,txt_MAMAY.Text.Trim());

                DataView Source_View = new DataView(DT_KQHOANTHIEN_CHITIET_FILL);
                BS_KQHOANTHIEN_CHITIET = new BindingSource();
                BS_KQHOANTHIEN_CHITIET.DataSource = Source_View;
                GRID_KQHOANTHIENCHITIET.DataSource = BS_KQHOANTHIEN_CHITIET;
            }
            BS_KQHOANTHIEN_CHITIET.CurrentChanged += new EventHandler(BS_KQHOANTHIEN_CHITIET_CurrentChanged);
            BS_KQHOANTHIEN_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_KQHOANTHIEN_CHITIET_FILL.NewRow();
            r_Detail[KetquathanhphamFields.SoLsx.Name] = txt_SOLSX.Text;
            r_Detail[KetquathanhphamFields.Macongnhan.Name] = txt_MACONGNHAN.Text;
            r_Detail[KetquathanhphamFields.Tencongnhan.Name] = txt_TENCONGNHAN.Text;
            r_Detail[KetquathanhphamFields.Masanpham.Name] = txt_MASANPHAM.Text;
            r_Detail[KetquathanhphamFields.Tensanpham.Name] = txt_TENSANPHAM.Text;
            r_Detail[KetquathanhphamFields.Mamay.Name] = txt_MAMAY.Text;
            r_Detail[KetquathanhphamFields.Tenmay.Name] = txt_TENMAY.Text;
            try { r_Detail[KetquathanhphamFields.Ca.Name] = LIB.ConvertString.NumbertoDB(txt_CA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.SoMetvao.Name] = LIB.ConvertString.NumbertoDB(txt_SOMETVAO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.SoKgvao.Name] = LIB.ConvertString.NumbertoDB(txt_SOKGVAO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Socon.Name] = LIB.ConvertString.NumbertoDB(txt_SOCON.Text.Trim()); }
            catch { }
            //try { r_Detail[KetquathanhphamFields.Dauraghep.Name] = LIB.ConvertString.NumbertoDB(txt_DAURAGHEP.Text.Trim()); }
            //catch { }
            try { r_Detail[KetquathanhphamFields.Thoigiancatdau.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCATDAU.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Thoigianchuanbi.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim()); }
            catch { }
            //try { r_Detail[KetquathanhphamFields.Solanhacuon.Name] = LIB.ConvertString.NumbertoDB(txt_SOLANHACUON.Text.Trim()); }
            //catch { }
            //try { r_Detail[KetquathanhphamFields.Thoigianlencuon.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANLENCUON.Text.Trim()); }
            //catch { }
            try { r_Detail[KetquathanhphamFields.Thoigianhacuon.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANHACUON.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Thoigiansuco.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Phein.Name] = LIB.ConvertString.NumbertoDB(txt_PHEIN.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Pheghep.Name] = LIB.ConvertString.NumbertoDB(txt_PHEGHEP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Phechia.Name] = LIB.ConvertString.NumbertoDB(txt_PHECHIA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Phethoi.Name] = LIB.ConvertString.NumbertoDB(txt_PHETHOI.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Phekhac.Name] = LIB.ConvertString.NumbertoDB(txt_PHEKHAC.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Phechinhmay.Name] = LIB.ConvertString.NumbertoDB(txt_PHECHINHMAY.Text.Trim()); }
            catch { }
            try { r_Detail[KetquathanhphamFields.Phebien.Name] = LIB.ConvertString.NumbertoDB(txt_PHEBIEN.Text.Trim()); }
            catch { }
            r_Detail[KetquathanhphamFields.Dgnangsuat.Name] = txt_DGNANGSUAT.Text;
            r_Detail[KetquathanhphamFields.Dmtui.Name] = txt_DMTUI.Text;
            r_Detail[KetquathanhphamFields.Kiemtra.Name] = txt_KIEMTRA.Text;
            r_Detail[KetquathanhphamFields.Thoigianbatdau.Name] = txt_THOIGIANBATDAU.Text;
            r_Detail[KetquathanhphamFields.Thoigianketthuc.Name] = txt_THOIGIANKETTHUC.Text;
            r_Detail[KetquathanhphamFields.Titrongtui.Name] = txt_TITRONGTUI.Text;
            //r_Detail[KetquathanhphamFields.Thoigiansuco.Name] = txt_THOIGIANSUCO.Text;
            //try { r_Detail[KetquathanhphamFields.Sokgdukiendat.Name] = LIB.ConvertString.NumbertoDB(txt_SOKGDUKIEN.Text.Trim()); }
            //catch { }

            DT_KQHOANTHIEN_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_KQHOANTHIEN_CHITIET_FILL);
            BS_KQHOANTHIEN_CHITIET = new BindingSource();
            BS_KQHOANTHIEN_CHITIET.DataSource = Source_View;
            GRID_KQHOANTHIENCHITIET.DataSource = BS_KQHOANTHIEN_CHITIET;
            BS_KQHOANTHIEN_CHITIET.Position = DT_KQHOANTHIEN_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_KQHOANTHIENCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[KetquathanhphamFields.Id.Name].ToString();
            string _MAMANG = _view[KetquathanhphamFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_KQHOANTHIENCHITIET.CurrentRow.Delete();
            }
            else
            {
                KetquathanhphamManager _KetquathanhphamManager = new KetquathanhphamManager();
                KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity();
                try { _KetquathanhphamEntity = _KetquathanhphamManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_KetquathanhphamEntity != null && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _KetquathanhphamManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_KQHOANTHIEN_CHITIET_FILL.Select(KetquathanhphamFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_KQHOANTHIEN_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_KQHOANTHIEN_CHITIET.ResetCurrentItem();
                    GRID_KQHOANTHIENCHITIET.DataSource = BS_KQHOANTHIEN_CHITIET;
                }
                GRID_KQHOANTHIENCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DateTime _ngayxuat = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _KetquathanhphamEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_KQHOANTHIENCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity();
                _KetquathanhphamEntity.Ngay = _ngayxuat;
                _KetquathanhphamEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim());
                _KetquathanhphamEntity.Mamay = txt_MAMAY.Text.Trim();
                _KetquathanhphamEntity.Tenmay = txt_TENMAY.Text.Trim();
                _KetquathanhphamEntity.SoLsx = _view.Row[KetquathanhphamFields.SoLsx.Name].ToString();
                _KetquathanhphamEntity.Macongnhan = _view.Row[KetquathanhphamFields.Macongnhan.Name].ToString();
                _KetquathanhphamEntity.Tencongnhan = _view.Row[KetquathanhphamFields.Tencongnhan.Name].ToString();
                _KetquathanhphamEntity.Masanpham = _view.Row[KetquathanhphamFields.Masanpham.Name].ToString();
                _KetquathanhphamEntity.Tensanpham = _view.Row[KetquathanhphamFields.Tensanpham.Name].ToString();
                _KetquathanhphamEntity.SoMetvao = Convert.ToDecimal(_view.Row[KetquathanhphamFields.SoMetvao.Name].ToString());
                _KetquathanhphamEntity.SoKgvao = Convert.ToDecimal(_view.Row[KetquathanhphamFields.SoKgvao.Name].ToString());
                _KetquathanhphamEntity.Socon = Convert.ToInt32(_view.Row[KetquathanhphamFields.Socon.Name].ToString());
                _KetquathanhphamEntity.Dmtui = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Dmtui.Name].ToString());
                _KetquathanhphamEntity.Ttetui = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Ttetui.Name].ToString());
                //_KetquathanhphamEntity.Phelieuthucte = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Phelieuthucte.Name].ToString());
                //_KetquathanhphamEntity.Tongsp = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Tongsp.Name].ToString());
                _KetquathanhphamEntity.Thoigiancatdau = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Thoigiancatdau.Name].ToString());
                _KetquathanhphamEntity.Thoigianbatdau = Convert.ToDateTime(_view.Row[KetquathanhphamFields.Thoigianbatdau.Name].ToString());
                _KetquathanhphamEntity.Thoigianketthuc = Convert.ToDateTime(_view.Row[KetquathanhphamFields.Thoigianketthuc.Name].ToString());
                _KetquathanhphamEntity.Thoigianchuanbi = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Thoigianchuanbi.Name].ToString());
                _KetquathanhphamEntity.Titrongtui = Convert.ToInt32(_view.Row[KetquathanhphamFields.Titrongtui.Name].ToString());
                _KetquathanhphamEntity.Dgnangsuat = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Dgnangsuat.Name].ToString());
                _KetquathanhphamEntity.Kiemtra = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Kiemtra.Name].ToString());
                _KetquathanhphamEntity.Thoigianhacuon = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Thoigianhacuon.Name].ToString());
                _KetquathanhphamEntity.Thoigiansuco = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Thoigiansuco.Name].ToString());
                //_KetquathanhphamEntity.Sokgdukiendat = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Sokgdukiendat.Name].ToString());
                _KetquathanhphamEntity.Phein = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Phein.Name].ToString());
                _KetquathanhphamEntity.Pheghep = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Pheghep.Name].ToString());
                _KetquathanhphamEntity.Phechia = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Phechia.Name].ToString());
                _KetquathanhphamEntity.Phethoi = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Phethoi.Name].ToString());
                _KetquathanhphamEntity.Phebien = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Phebien.Name].ToString());
                _KetquathanhphamEntity.Phekhac = Convert.ToDecimal(_view.Row[KetquathanhphamFields.Phekhac.Name].ToString());


                if (!string.IsNullOrEmpty(_KetquathanhphamEntity.Masanpham))
                    _KetquathanhphamEntityCol.Add(_KetquathanhphamEntity);
            }

            foreach (KetquathanhphamEntity _KetquathanhphamEntity in _KetquathanhphamEntityCol)
            {
                if (_KetquathanhphamEntity.IsNew)
                {
                    DataRow _r_Insert = DT_KQHOANTHIEN_CHITIET.NewRow();
                    DT_KQHOANTHIEN_CHITIET.Rows.Add(_r_Insert);
                    _KetquathanhphamManager.InsertV2(_KetquathanhphamEntity, _r_Insert, DT_KQHOANTHIEN_CHITIET, BS_KQHOANTHIEN_CHITIET);
                }
                else _KetquathanhphamManager.Update(_KetquathanhphamEntity);
            }

            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquathanhphamFields.Ngay.Name].Value = _ngayxuat;
            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquathanhphamFields.Ca.Name].Value = txt_CA.Text.Trim();
            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquathanhphamFields.Mamay.Name].Value = txt_MAMAY.Text.Trim();
            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquathanhphamFields.Masanpham.Name].Value = txt_MASANPHAM.Text.Trim();
            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquathanhphamFields.Tensanpham.Name].Value = txt_TENSANPHAM.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathanhphamManager.Convert(_KetquathanhphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //}
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_NGAY.Text = txt_CA.Text = txt_MAMAY.Text = txt_TENMAY.Text = txt_SOLSX.Text = txt_MACONGNHAN.Text = txt_TENCONGNHAN.Text = txt_MASANPHAM.Text = txt_TENSANPHAM.Text = txt_SOMETVAO.Text = txt_SOKGVAO.Text = txt_SOCON.Text = txt_THOIGIANCATDAU.Text = txt_THOIGIANBATDAU.Text = txt_THOIGIANKETTHUC.Text = txt_THOIGIANCHUANBI.Text = txt_TITRONGTUI.Text = txt_THOIGIANLENCUON.Text = txt_THOIGIANHACUON.Text = txt_THOIGIANSUCO.Text = txt_PHEIN.Text = txt_PHEGHEP.Text = txt_PHETHOI.Text = txt_PHEBIEN.Text = txt_PHEKHAC.Text = txt_PHECHINHMAY.Text= string.Empty;
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            KetquathanhphamManager _KetquathanhphamManager = new KetquathanhphamManager();
            KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity();
            r_Insert = DT_KQHOANTHIEN.NewRow();
            DT_KQHOANTHIEN.Rows.Add(r_Insert);
            BS_KQHOANTHIEN.Position = DT_KQHOANTHIEN.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY}));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_KQHOANTHIEN.Enabled = false;

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
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY}));
            }
            GRID_KQHOANTHIENCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_KQHOANTHIENCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQHOANTHIENCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQHOANTHIENCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQHOANTHIENCHITIET.Enabled = true;
            GRID_KQHOANTHIEN.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQHOANTHIEN.Rows.Remove(r_Insert);
            }
            BS_KQHOANTHIEN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_KQHOANTHIEN.Enabled = true;
            GRID_KQHOANTHIENCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQHOANTHIENCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQHOANTHIENCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            //_KetquathanhphamEntity = _KetquathanhphamManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquathanhphamEntity != null && MessageBox.Show("Xóa kết quả hoàn thiện: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_KQHOANTHIENCHITIET.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[KetquathanhphamFields.Id.Name].ToString()))
                        {
                            try { _KetquathanhphamManager.Delete(Convert.ToInt64(_view[KetquathanhphamFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_KetquathanhphamManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    try { GRID_KQHOANTHIEN.CurrentRow.Delete(); }
                    catch { }
                    BS_KQHOANTHIEN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathanhphamManager.Convert(_KetquathanhphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa kết quả hoàn thiện: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KQHOANTHIEN.Enabled = true;
            GRID_KQHOANTHIENCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQHOANTHIENCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQHOANTHIENCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (txt_NGAY.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NGAY.Focus();
                return;
            }
            else if (txt_CA.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập ca!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CA.Focus();
                return;
            }
            else if (txt_MAMAY.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAMAY.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_KQHOANTHIEN.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_KQHOANTHIENCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQHOANTHIENCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQHOANTHIENCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate

        private void txt_MAMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmamay(Str_MASIEUTHI, DT_DMMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAY.xml",
                        DT_DMMAY, DmmayFields.Mamay.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMAY.Text = _RowViewSelect[DmmayFields.Mamay.Name].ToString();
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
            else
            {
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
        }
        private DataRow checkmamay(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmmayFields.Mamay.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        //private void txt_LENHTHOI_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_LENHTHOI.Text.Trim()) || DT_LENHTHOI == null || DT_LENHTHOI.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_LENHTHOI.Text.Trim().ToUpper();
        //    _RowViewSelect = checklenhthoi(Str_MASIEUTHI, DT_LENHTHOI);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
        //                DT_LENHTHOI, DmkhachFields.Makhach.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_LENHTHOI.Text = _RowViewSelect[DmkhachFields.Makhach.Name].ToString();
        //        txt_LENHTHOI.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();

        //        DT_LENHTHOI = new DmhangManager().SelectByMakhachRDT(txt_LENHTHOI.Text);

        //    }
        //    else
        //    {
        //        txt_LENHTHOI.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
        //        DT_LENHTHOI = new DmhangManager().SelectByMakhachRDT(txt_LENHTHOI.Text);

        //    }
        //}
        //private DataRow checklenhthoi(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(.Mamay.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}


        private void txt_MASANPHAM_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MASANPHAM.Text.Trim()) || DT_DMHANG == null || DT_DMHANG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MASANPHAM.Text.Trim().ToUpper();
            _RowViewSelect = checksanpham(Str_MASIEUTHI, DT_DMHANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMHANG, DmhangFields.Masp.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MASANPHAM.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENSANPHAM.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();

            }
            else
            {
                txt_TENSANPHAM.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
            }
        }
        private DataRow checksanpham(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmhangFields.Masp.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACONGNHAN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MACONGNHAN.Text.Trim()) || DT_NHANVIEN == null || DT_NHANVIEN.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MACONGNHAN.Text.Trim().ToUpper();
            _RowViewSelect = checkmacongnnhang(Str_MASIEUTHI, DT_NHANVIEN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGNHAN.xml",
                        DT_NHANVIEN, DmcongnhanFields.Macn.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACONGNHAN.Text = _RowViewSelect[DmcongnhanFields.Macn.Name].ToString();
                txt_TENCONGNHAN.Text = _RowViewSelect[DmcongnhanFields.Tencongnhan.Name].ToString();

            }
            else
            {
                txt_TENCONGNHAN.Text = _RowViewSelect[DmcongnhanFields.Tencongnhan.Name].ToString();

            }
        }
        private DataRow checkmacongnnhang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmcongnhanFields.Macn.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
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

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_KQHOANTHIEN.ColumnAutoResize = true;
            else
                GRID_KQHOANTHIEN.ColumnAutoResize = false;
        }

        private void FRM_KQHOANTHIEN_FormClosing(object sender, FormClosingEventArgs e)
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
