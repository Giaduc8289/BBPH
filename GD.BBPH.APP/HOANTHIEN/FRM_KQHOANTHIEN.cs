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
        private KetquahoanthienManager _KetquahoanthienManager = new KetquahoanthienManager();
        private KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KQHOANTHIEN = new DataTable(), DT_KQHOANTHIEN_CHITIET = new DataTable(), DT_KQHOANTHIEN_CHITIET_FILL = new DataTable();
        private BindingSource BS_KQHOANTHIEN = new BindingSource(), BS_KQHOANTHIEN_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQHOANTHIEN = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQHOANTHIENCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MASP = "", CA = "0";
        private bool ADDROW = false;

        private DataTable DT_DMMAY = new DataTable(), DT_LENHTHOI = new DataTable(), DT_DMHANG = new DataTable(), DT_NHANVIEN = new DataTable()
                        , DT_DMKHACH = new DataTable(), DT_LENHSANXUAT = new DataTable();

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
                        DT_KQHOANTHIEN = LIB.Procedures.Danhsachketquahoanthien(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty, string.Empty); // new KetquahoanthienManager().SelectAllRDT();
                        DT_KQHOANTHIEN_CHITIET = new KetquahoanthienManager().SelectAllRDT();

                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("CA");// new DmmayManager().SelectAllRDT();
                        DT_DMHANG = new DmhangManager().SelectAllRDT();
                        DT_LENHSANXUAT = new LenhsanxuatManager().SelectAllRDT();
                        DT_NHANVIEN =  new DmcongnhanManager().SelectAllRDT();
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
            DataTable dt111 = LIB.Procedures.Danhsachketquahoanthien(Ngaydauthang, Ngaycuoithang, 0, string.Empty, string.Empty);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQHOANTHIEN.xml");
            dt111 = new KetquahoanthienManager().Clone();
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
            GRID_KQHOANTHIENCHITIET.DeletingRecord += GRID_KQHOANTHIENCHITIET_DeletingRecord;
            //GRID_KQHOANTHIEN.RootTable.Groups.Add(GRID_KQHOANTHIEN.Tables[0].Columns[KetquahoanthienFields.Phongban.Name]);
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

        #region Load dữ liệu
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
                        MAHIEU_PK = _Rowview.Row[KetquahoanthienFields.Ngay.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquahoanthienFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquahoanthienFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquahoanthienFields.Mamay.Name].ToString();

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
                        MACHITIET = _Rowview.Row[KetquahoanthienFields.Id.Name].ToString();

                    txt_SOLENHSX.Text = _Rowview.Row[KetquahoanthienFields.Solenhsx.Name].ToString();
                    txt_MASANPHAM.Text = _Rowview.Row[KetquahoanthienFields.Masanpham.Name].ToString();
                    txt_TENSANPHAM.Text = _Rowview.Row[KetquahoanthienFields.Tensanpham.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquahoanthienFields.Macongnhan.Name].ToString();
                    txt_TENCONGNHAN.Text = _Rowview.Row[KetquahoanthienFields.Tencongnhan.Name].ToString();
                    txt_DAURACHIAGHEP.Text = _Rowview.Row[KetquahoanthienFields.Daurachiaghep.Name].ToString();
                    txt_DAUVAOMET.Text = _Rowview.Row[KetquahoanthienFields.Dauvaomet.Name].ToString();
                    txt_DAUVAOKG.Text = _Rowview.Row[KetquahoanthienFields.Dauvaokg.Name].ToString();
                    txt_THOIGIANBATDAU.Text = Convert.ToDateTime(_Rowview.Row[KetquachiaFields.Thoigianbatdau.Name].ToString()).ToString("hh:mm tt dd/MM/yyyy");
                    txt_THOIGIANKETTHUC.Text = Convert.ToDateTime(_Rowview.Row[KetquachiaFields.Thoigianketthuc.Name].ToString()).ToString("hh:mm tt dd/MM/yyyy");
                    txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquahoanthienFields.Thoigianchuanbi.Name].ToString();
                    txt_THOIGIANLENHACUON.Text = _Rowview.Row[KetquahoanthienFields.Thoigianlenhacuon.Name].ToString();
                    txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquahoanthienFields.Thoigiancatdau.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquahoanthienFields.Thoigiansuco.Name].ToString();
                    txt_KETQUATUI.Text = _Rowview.Row[KetquahoanthienFields.Ketquatui.Name].ToString();
                    txt_PHEIN.Text = _Rowview.Row[KetquahoanthienFields.Phein.Name].ToString();
                    txt_PHEGHEP.Text = _Rowview.Row[KetquahoanthienFields.Pheghep.Name].ToString();
                    txt_PHECHIA.Text = _Rowview.Row[KetquahoanthienFields.Phechia.Name].ToString();
                    txt_PHEBIEN.Text = _Rowview.Row[KetquahoanthienFields.Phebien.Name].ToString();
                    txt_PHETHOI.Text = _Rowview.Row[KetquahoanthienFields.Phethoi.Name].ToString();
                    txt_PHECHINHMAY.Text = _Rowview.Row[KetquahoanthienFields.Phechinhmay.Name].ToString();
                    txt_PHEKHAC.Text = _Rowview.Row[KetquahoanthienFields.Phekhac.Name].ToString();
                    txt_CHATLUONGTUI.Text = _Rowview.Row[KetquahoanthienFields.Kiemtra.Name].ToString();
                    txt_CHATLUONGTUI.Text = _Rowview.Row[KetquahoanthienFields.Chatluongtui.Name].ToString();
                    txt_NANGSUAT.Text = _Rowview.Row[KetquahoanthienFields.Nangsuat.Name].ToString();
                    txt_MATRUONGCA.Text = _Rowview.Row[KetquahoanthienFields.Matruongca.Name].ToString();
                    txt_TENTRUONGCA.Text = _Rowview.Row[KetquahoanthienFields.Tentruongca.Name].ToString();
                    txt_TOCDODINHMUC.Text = _Rowview.Row[KetquahoanthienFields.Tocdodinhmuc.Name].ToString();
                    txt_LYDOSUCO.Text = _Rowview.Row[KetquahoanthienFields.Lydosuco.Name].ToString();

                    txt_MASANPHAM_Validating(new object(), new CancelEventArgs());
                    txt_MACONGNHAN_Validating(new object(), new CancelEventArgs());
                }
                else
                {
                    GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                }
            }
            catch
            { }
        }
        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_KQHOANTHIEN_CHITIET_FILL = new KetquahoanthienManager().Clone();
                BS_KQHOANTHIEN_CHITIET = new BindingSource(DT_KQHOANTHIEN_CHITIET_FILL, null);
                GRID_KQHOANTHIENCHITIET.DataSource = BS_KQHOANTHIEN_CHITIET;
            }
            else
            {
                DT_KQHOANTHIEN_CHITIET_FILL = new KetquahoanthienManager().SelectByNgayCaMamayRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), Convert.ToInt32(txt_CA.Text.Trim()), txt_MAMAY.Text.Trim());

                DataView Source_View = new DataView(DT_KQHOANTHIEN_CHITIET_FILL);
                BS_KQHOANTHIEN_CHITIET = new BindingSource();
                BS_KQHOANTHIEN_CHITIET.DataSource = Source_View;
                GRID_KQHOANTHIENCHITIET.DataSource = BS_KQHOANTHIEN_CHITIET;
            }
            BS_KQHOANTHIEN_CHITIET.CurrentChanged += new EventHandler(BS_KQHOANTHIEN_CHITIET_CurrentChanged);
            BS_KQHOANTHIEN_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }
        #endregion

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            ADDROW = true;
            DataRow r_Detail = DT_KQHOANTHIEN_CHITIET_FILL.NewRow();
            r_Detail[KetquahoanthienFields.Solenhsx.Name] = txt_SOLENHSX.Text;
            r_Detail[KetquahoanthienFields.Macongnhan.Name] = txt_MACONGNHAN.Text;
            r_Detail[KetquahoanthienFields.Tencongnhan.Name] = txt_TENCONGNHAN.Text;
            r_Detail[KetquahoanthienFields.Masanpham.Name] = txt_MASANPHAM.Text;
            r_Detail[KetquahoanthienFields.Tensanpham.Name] = txt_TENSANPHAM.Text;
            r_Detail[KetquahoanthienFields.Mamay.Name] = txt_MAMAY.Text;
            r_Detail[KetquahoanthienFields.Tenmay.Name] = txt_TENMAY.Text;
            try { r_Detail[KetquahoanthienFields.Ca.Name] = LIB.ConvertString.NumbertoDB(txt_CA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Daurachiaghep.Name] = LIB.ConvertString.NumbertoDB(txt_DAURACHIAGHEP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Dauvaomet.Name] = LIB.ConvertString.NumbertoDB(txt_DAUVAOMET.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Dauvaokg.Name] = LIB.ConvertString.NumbertoDB(txt_DAUVAOKG.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Ketquatui.Name] = LIB.ConvertString.NumbertoDB(txt_KETQUATUI.Text.Trim()); }
            catch { }
            r_Detail[KetquahoanthienFields.Thoigianbatdau.Name] = txt_THOIGIANBATDAU.Text;
            r_Detail[KetquahoanthienFields.Thoigianketthuc.Name] = txt_THOIGIANKETTHUC.Text;
            try { r_Detail[KetquahoanthienFields.Thoigianchuanbi.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Thoigianlenhacuon.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANLENHACUON.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Thoigiancatdau.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCATDAU.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Thoigiansuco.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Phein.Name] = LIB.ConvertString.NumbertoDB(txt_PHEIN.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Pheghep.Name] = LIB.ConvertString.NumbertoDB(txt_PHEGHEP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Phechia.Name] = LIB.ConvertString.NumbertoDB(txt_PHECHIA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Phebien.Name] = LIB.ConvertString.NumbertoDB(txt_PHEBIEN.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Phethoi.Name] = LIB.ConvertString.NumbertoDB(txt_PHETHOI.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Phechinhmay.Name] = LIB.ConvertString.NumbertoDB(txt_PHECHINHMAY.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Phekhac.Name] = LIB.ConvertString.NumbertoDB(txt_PHEKHAC.Text.Trim()); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Chatluongtui.Name] = LIB.ConvertString.NumbertoDB(txt_CHATLUONGTUI.Text); }
            catch { }
            try { r_Detail[KetquahoanthienFields.Nangsuat.Name] = LIB.ConvertString.NumbertoDB(txt_NANGSUAT.Text); }
            catch { }
            r_Detail[KetquahoanthienFields.Matruongca.Name] = txt_MATRUONGCA.Text.Trim();
            r_Detail[KetquahoanthienFields.Tentruongca.Name] = txt_TENTRUONGCA.Text.Trim();
            try { r_Detail[KetquahoanthienFields.Tocdodinhmuc.Name] = System.Decimal.Parse(txt_TOCDODINHMUC.Text.Trim()); }
            catch { }
            r_Detail[KetquahoanthienFields.Lydosuco.Name] = txt_LYDOSUCO.Text.Trim();

            DT_KQHOANTHIEN_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_KQHOANTHIEN_CHITIET_FILL);
            BS_KQHOANTHIEN_CHITIET = new BindingSource();
            BS_KQHOANTHIEN_CHITIET.DataSource = Source_View;
            GRID_KQHOANTHIENCHITIET.DataSource = BS_KQHOANTHIEN_CHITIET;
            BS_KQHOANTHIEN_CHITIET.Position = DT_KQHOANTHIEN_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
            ADDROW = false;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_KQHOANTHIENCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[KetquahoanthienFields.Id.Name].ToString();
            string _MAMANG = _view[KetquahoanthienFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_KQHOANTHIENCHITIET.CurrentRow.Delete();
            }
            else
            {
                KetquahoanthienManager _KetquahoanthienManager = new KetquahoanthienManager();
                KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity();
                try { _KetquahoanthienEntity = _KetquahoanthienManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_KetquahoanthienEntity != null && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _KetquahoanthienManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_KQHOANTHIEN_CHITIET_FILL.Select(KetquahoanthienFields.Id.Name + "='" + _MAHIEU_PK + "'");
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
        private void btn_SUADONG_Click(object sender, EventArgs e)
        {
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Solenhsx.Name].Value = txt_SOLENHSX.Text;
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Macongnhan.Name].Value = txt_MACONGNHAN.Text;
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Tencongnhan.Name].Value = txt_TENCONGNHAN.Text;
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Masanpham.Name].Value = txt_MASANPHAM.Text;
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Tensanpham.Name].Value = txt_TENSANPHAM.Text;
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Mamay.Name].Value = txt_MAMAY.Text;
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Tenmay.Name].Value = txt_TENMAY.Text;
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Ca.Name].Value = LIB.ConvertString.NumbertoDB(txt_CA.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Daurachiaghep.Name].Value = LIB.ConvertString.NumbertoDB(txt_DAURACHIAGHEP.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Dauvaomet.Name].Value = LIB.ConvertString.NumbertoDB(txt_DAUVAOMET.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Dauvaokg.Name].Value = LIB.ConvertString.NumbertoDB(txt_DAUVAOKG.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Ketquatui.Name].Value = LIB.ConvertString.NumbertoDB(txt_KETQUATUI.Text.Trim()); }
            catch { }
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Thoigianbatdau.Name].Value = txt_THOIGIANBATDAU.Text;
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Thoigianketthuc.Name].Value = txt_THOIGIANKETTHUC.Text;
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Thoigianchuanbi.Name].Value = LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Thoigianlenhacuon.Name].Value = LIB.ConvertString.NumbertoDB(txt_THOIGIANLENHACUON.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Thoigiancatdau.Name].Value = LIB.ConvertString.NumbertoDB(txt_THOIGIANCATDAU.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Thoigiansuco.Name].Value = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Phein.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHEIN.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Pheghep.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHEGHEP.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Phechia.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHECHIA.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Phebien.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHEBIEN.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Phethoi.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHETHOI.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Phechinhmay.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHECHINHMAY.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Phekhac.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHEKHAC.Text.Trim()); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Chatluongtui.Name].Value = LIB.ConvertString.NumbertoDB(txt_CHATLUONGTUI.Text); }
            catch { }
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Nangsuat.Name].Value = LIB.ConvertString.NumbertoDB(txt_NANGSUAT.Text); }
            catch { }
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Matruongca.Name].Value = txt_MATRUONGCA.Text.Trim();
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Tentruongca.Name].Value = txt_TENTRUONGCA.Text.Trim();
            try { GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Tocdodinhmuc.Name].Value = System.Decimal.Parse(txt_TOCDODINHMUC.Text.Trim()); }
            catch { }
            GRID_KQHOANTHIENCHITIET.CurrentRow.Cells[KetquahoanthienFields.Lydosuco.Name].Value = txt_LYDOSUCO.Text.Trim();
        }

        private void GRID_KQHOANTHIENCHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngay = Convert.ToDateTime(txt_NGAY.Text.Trim());

            GRID_KQHOANTHIENCHITIET.UpdateData();
            EntityCollection _KetquahoanthienEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_KQHOANTHIENCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity();
                _KetquahoanthienEntity.Ngay = _ngay;
                _KetquahoanthienEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim());
                _KetquahoanthienEntity.Mamay = txt_MAMAY.Text.Trim();
                _KetquahoanthienEntity.Tenmay = txt_TENMAY.Text.Trim();
                _KetquahoanthienEntity.Solenhsx = _view.Row[KetquahoanthienFields.Solenhsx.Name].ToString();
                _KetquahoanthienEntity.Masanpham = _view.Row[KetquahoanthienFields.Masanpham.Name].ToString();
                _KetquahoanthienEntity.Tensanpham = _view.Row[KetquahoanthienFields.Tensanpham.Name].ToString();
                _KetquahoanthienEntity.Macongnhan = _view.Row[KetquahoanthienFields.Macongnhan.Name].ToString();
                _KetquahoanthienEntity.Tencongnhan = _view.Row[KetquahoanthienFields.Tencongnhan.Name].ToString();
                _KetquahoanthienEntity.Daurachiaghep = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Daurachiaghep.Name].ToString());
                _KetquahoanthienEntity.Dauvaomet = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Dauvaomet.Name].ToString());
                _KetquahoanthienEntity.Dauvaokg = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Dauvaokg.Name].ToString());
                _KetquahoanthienEntity.Ketquatui = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Ketquatui.Name].ToString());
                _KetquahoanthienEntity.Thoigianbatdau = Convert.ToDateTime(_view.Row[KetquahoanthienFields.Thoigianbatdau.Name].ToString());
                _KetquahoanthienEntity.Thoigianketthuc = Convert.ToDateTime(_view.Row[KetquahoanthienFields.Thoigianketthuc.Name].ToString());
                _KetquahoanthienEntity.Thoigianchuanbi = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Thoigianchuanbi.Name].ToString());
                _KetquahoanthienEntity.Thoigianlenhacuon = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Thoigianlenhacuon.Name].ToString());
                _KetquahoanthienEntity.Thoigiancatdau = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Thoigiancatdau.Name].ToString());
                _KetquahoanthienEntity.Thoigiansuco = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Thoigiansuco.Name].ToString());
                _KetquahoanthienEntity.Phein = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Phein.Name].ToString());
                _KetquahoanthienEntity.Pheghep = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Pheghep.Name].ToString());
                _KetquahoanthienEntity.Phechia = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Phechia.Name].ToString());
                _KetquahoanthienEntity.Phebien = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Phebien.Name].ToString());
                _KetquahoanthienEntity.Phethoi = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Phethoi.Name].ToString());
                _KetquahoanthienEntity.Phechinhmay = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Phechinhmay.Name].ToString());
                _KetquahoanthienEntity.Phekhac = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Phekhac.Name].ToString());
                _KetquahoanthienEntity.Matruongca = _view.Row[KetquahoanthienFields.Matruongca.Name].ToString();
                _KetquahoanthienEntity.Tentruongca = _view.Row[KetquahoanthienFields.Tentruongca.Name].ToString();
                try { _KetquahoanthienEntity.Tocdodinhmuc = System.Decimal.Parse(_view.Row[KetquahoanthienFields.Tocdodinhmuc.Name].ToString()); }
                catch { }
                _KetquahoanthienEntity.Lydosuco = _view.Row[KetquahoanthienFields.Lydosuco.Name].ToString();

                _KetquahoanthienEntity.Chatluongtui = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Chatluongtui.Name].ToString());
                _KetquahoanthienEntity.Nangsuat = Convert.ToDecimal(_view.Row[KetquahoanthienFields.Nangsuat.Name].ToString());

                #region xét isnew
                try { _KetquahoanthienEntity.Id = Convert.ToInt64(_view[KetquahoanthienFields.Id.Name].ToString()); }
                catch { }

                _KetquahoanthienEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_KetquahoanthienEntity.IsNew)
                {
                    EntityCollection drDHCT = (new KetquahoanthienManager()).SelectById(_KetquahoanthienEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _KetquahoanthienEntity.Ngaysua = DateTime.Now;
                        _KetquahoanthienEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _KetquahoanthienEntity.IsNew = false;
                    }
                    else
                    {
                        _KetquahoanthienEntity.Ngaytao = DateTime.Now;
                        _KetquahoanthienEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }
                #endregion

                if (!string.IsNullOrEmpty(_KetquahoanthienEntity.Masanpham))
                    _KetquahoanthienEntityCol.Add(_KetquahoanthienEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (KetquahoanthienEntity _KetquahoanthienEntity in _KetquahoanthienEntityCol)
            {
                if (_KetquahoanthienEntity.IsNew)
                {
                    DataRow _r_Insert = DT_KQHOANTHIEN_CHITIET.NewRow();
                    DT_KQHOANTHIEN_CHITIET.Rows.Add(_r_Insert);
                    _KetquahoanthienManager.InsertV2(_KetquahoanthienEntity, _r_Insert, DT_KQHOANTHIEN_CHITIET, BS_KQHOANTHIEN_CHITIET);
                }
                else _KetquahoanthienManager.Update(_KetquahoanthienEntity);
            }

            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Ngay.Name].Value = _ngay;
            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Ca.Name].Value = txt_CA.Text.Trim();
            GRID_KQHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Mamay.Name].Value = txt_MAMAY.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquahoanthienManager.Convert(_KetquahoanthienEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENMAY.Text = txt_TENCONGNHAN.Text = txt_TENSANPHAM.Text = string.Empty;
            r_Insert = DT_KQHOANTHIEN.NewRow();
            DT_KQHOANTHIEN.Rows.Add(r_Insert);
            BS_KQHOANTHIEN.Position = DT_KQHOANTHIEN.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = true;
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
                FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA;
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY }));
            }
            GRID_KQHOANTHIENCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_KQHOANTHIENCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQHOANTHIENCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQHOANTHIENCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQHOANTHIENCHITIET.Enabled = true;
            GRID_KQHOANTHIEN.Enabled = false;
            btn_XOADONG.Enabled = btn_SUADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQHOANTHIEN.Rows.Remove(r_Insert);
            }
            BS_KQHOANTHIEN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;
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
            //_KetquahoanthienEntity = _KetquahoanthienManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquahoanthienEntity != null && MessageBox.Show("Xóa kết quả hoàn thiện: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_KQHOANTHIENCHITIET.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[KetquahoanthienFields.Id.Name].ToString()))
                        {
                            try { _KetquahoanthienManager.Delete(Convert.ToInt64(_view[KetquahoanthienFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_KetquahoanthienManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    try { GRID_KQHOANTHIEN.CurrentRow.Delete(); }
                    catch { }
                    BS_KQHOANTHIEN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquahoanthienManager.Convert(_KetquahoanthienEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;
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
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD;
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
                FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate

        private void txt_SOLENHSX_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOLENHSX.Text.Trim()) || DT_LENHSANXUAT == null || DT_LENHSANXUAT.Rows.Count == 0) return;
            string _str_MACANTIM = txt_SOLENHSX.Text.Trim().ToUpper();
            _RowViewSelect = checklenhsx(_str_MACANTIM, DT_LENHSANXUAT);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LENHSANXUAT.xml",
                        DT_LENHSANXUAT, LenhsanxuatFields.Solenhsx.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOLENHSX.Text = _RowViewSelect[LenhsanxuatFields.Solenhsx.Name].ToString();
                txt_MASANPHAM.Text = _RowViewSelect[LenhsanxuatFields.Masanpham.Name].ToString();
                txt_MASANPHAM_Validating(new object(), new CancelEventArgs());
            }
            else
            {
                txt_MASANPHAM.Text = _RowViewSelect[LenhsanxuatFields.Masanpham.Name].ToString();
                txt_MASANPHAM_Validating(new object(), new CancelEventArgs());
            }
        }
        private DataRow checklenhsx(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(LenhsanxuatFields.Solenhsx.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmamay(_str_MACANTIM, DT_DMMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAY.xml",
                        DT_DMMAY, DmmayFields.Mamay.Name, _str_MACANTIM);
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
        private DataRow checkmamay(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmmayFields.Mamay.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MASANPHAM_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MASANPHAM.Text.Trim()) || DT_DMHANG == null || DT_DMHANG.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MASANPHAM.Text.Trim().ToUpper();
            _RowViewSelect = checksanpham(_str_MACANTIM, DT_DMHANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMHANG, DmhangFields.Masp.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MASANPHAM.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENSANPHAM.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
                Tinhtocdodinhmuc();
                Tinhthoigianchuanbi();
            }
            else
            {
                txt_TENSANPHAM.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
                Tinhtocdodinhmuc();
                Tinhthoigianchuanbi();
            }
        }
        private DataRow checksanpham(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmhangFields.Masp.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACONGNHAN_Validating(object sender, CancelEventArgs e)
        {
            if (ADDROW) return;
            if (string.IsNullOrEmpty(txt_MACONGNHAN.Text) || !btn_LUULAI.Enabled) return;
            txt_TENCONGNHAN.Text = txt_MATRUONGCA.Text = txt_TENTRUONGCA.Text = string.Empty;
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGNHAN_CHON.xml", DT_NHANVIEN, DmcongnhanFields.Macn.Name, txt_MACONGNHAN.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string strMa = "", strTen = "", strMaTC = "", strTenTC = "";
            foreach (DataRowView drv in _frm._RowsViewSelect)
            {
                strMa += drv.Row[DmcongnhanFields.Macn.Name].ToString() + ",";
                strTen += drv.Row[DmcongnhanFields.Tencongnhan.Name].ToString() + ",";
                if (drv.Row[DmcongnhanFields.Macv.Name].ToString() == "TC")
                {
                    strMaTC = drv.Row[DmcongnhanFields.Macn.Name].ToString();
                    strTenTC = drv.Row[DmcongnhanFields.Tencongnhan.Name].ToString();
                }
            }

            txt_MACONGNHAN.Text = strMa;
            txt_TENCONGNHAN.Text = strTen;
            txt_MATRUONGCA.Text = strMaTC;
            txt_TENTRUONGCA.Text = strTenTC;
        }
        private DataRow checkmacongnnhang(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmcongnhanFields.Macn.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region  Tính năng suất, chất lượng
        private void Tinhnangsuat()
        {
            try
            {
                decimal _timerun = 0, _tocdo = 0, _somet = 0, _nangsuat = 0;
                _somet = LIB.ConvertString.NumbertoDB(txt_DAUVAOMET.Text.Trim());
                _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MASANPHAM.Text);
                _timerun = Convert.ToDecimal((Convert.ToDateTime(txt_THOIGIANKETTHUC.Text) - Convert.ToDateTime(txt_THOIGIANBATDAU.Text)).TotalMinutes)
                    - (Convert.ToDecimal(txt_THOIGIANCHUANBI.Text.Trim()) + Convert.ToDecimal(txt_THOIGIANLENHACUON.Text.Trim()) 
                    + Convert.ToDecimal(txt_THOIGIANCATDAU.Text.Trim()))
                    - LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
                _nangsuat = _somet / _tocdo / _timerun * 100;

                txt_NANGSUAT.Text = Math.Round(_nangsuat).ToString(); ;
            }
            catch { }
        }
        private void Tinhchatluong()
        {
            try
            {
                decimal _somet = 0, _dai = 0, _sohinh = 0, _sotuitt = 0, _dmlensp = 0, _dmsaihong = 0, _sotuidm = 0, _chatluong = 0;
                _sotuitt = LIB.ConvertString.NumbertoDB(txt_KETQUATUI.Text.Trim());
                _somet = LIB.ConvertString.NumbertoDB(txt_DAUVAOMET.Text.Trim());
                DmhangEntity _DmhangEntity = new DmhangManager().SelectOne(txt_MASANPHAM.Text.Trim());
                _dai = Convert.ToDecimal(_DmhangEntity.Dai) / 1000;
                _sohinh = Convert.ToDecimal(_DmhangEntity.Sohinh);
                _dmlensp = LIB.Procedures.fTinhdinhmucsaihong(txt_MAMAY.Text, txt_MASANPHAM.Text, "DM15");
                _somet = _somet - _dmlensp;
                _dmsaihong = LIB.Procedures.fTinhdinhmucsaihong(txt_MAMAY.Text, txt_MASANPHAM.Text, "DM14");
                _somet = _somet - _somet * _dmsaihong / 100;
                _sotuidm = _somet / _dai;

                _chatluong = _sotuitt / _sotuidm * 100;
                txt_CHATLUONGTUI.Text = Math.Round(_chatluong).ToString(); 
            }
            catch { }
        }
        private void txt_NANGSUAT_Validated(object sender, EventArgs e)
        {
            Tinhnangsuat();
        }
        private void txt_CHATLUONG_Validated(object sender, EventArgs e)
        {
            Tinhchatluong();
        }
        private void Tinhtocdodinhmuc()
        {
            try
            {
                decimal _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MASANPHAM.Text);
                txt_TOCDODINHMUC.Text = Math.Round(_tocdo).ToString();
            }
            catch { }
        }
        private void Tinhthoigianchuanbi()
        {
            try
            {
                if (FUNCTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
                {
                    decimal _thoigianchuanbi = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Chuanbi.Name);
                    txt_THOIGIANCHUANBI.Text = Math.Round(_thoigianchuanbi).ToString();
                    decimal _thoigiancatdau = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Daucuon.Name);
                    txt_THOIGIANCATDAU.Text = Math.Round(_thoigiancatdau).ToString();
                    decimal _thoigianlencuon = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Lencuon.Name);
                    decimal _thoigianhacuon = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Xuongcuon.Name);
                    txt_THOIGIANLENHACUON.Text = Math.Round(_thoigianlencuon + _thoigianhacuon).ToString();
                }
            }
            catch { }
        }
        #endregion

        #region Shortcut Key
        private void txt_MAMAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMAY frm_Dm = new FRM_DMMAY();
                frm_Dm.Text = "Danh mục máy";
                frm_Dm.ShowDialog();
                DT_DMMAY = new DmmayManager().SelectAllRDT();
            }
        }


        private void txt_MAHANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMHANG frm_Dm = new FRM_DMHANG();
                frm_Dm.Text = "Danh mục hàng hoá";
                frm_Dm.ShowDialog();
                DT_DMHANG = new DmhangManager().SelectAllRDT();
            }
        }

        private void txt_MACONGNHAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCONGNHAN frm_Dm = new FRM_DMCONGNHAN();
                frm_Dm.Text = "Danh mục công nhân";
                frm_Dm.ShowDialog();
                DT_NHANVIEN = new DmcongnhanManager().SelectAllRDT();
            }
        }
        private void txt_CALCULATOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F3)
            {
                System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
                p.WaitForInputIdle();
                //NativeMethods.SetParent(p.MainWindowHandle, this.Handle);
            }
        }
        #endregion

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
