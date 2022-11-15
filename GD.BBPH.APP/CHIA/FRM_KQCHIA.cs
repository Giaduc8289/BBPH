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

namespace GD.BBPH.APP.CHIA
{
    public partial class FRM_KQCHIA : FRM_DMPARENT
    {
        private KetquachiaManager _KetquachiaManager = new KetquachiaManager();
        private KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KQCHIA = new DataTable(), DT_KQCHIA_CHITIET = new DataTable(), DT_KQCHIA_CHITIET_FILL = new DataTable();
        private BindingSource BS_KQCHIA = new BindingSource(), BS_KQCHIA_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQCHIA = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQCHIACHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private string MASP = "", CA = "0";
        private bool ADDROW = false;

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQCHIA");
                        DT_KQCHIA = LIB.Procedures.Danhsachketquachia(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty, string.Empty); // LIB.SESSION_START.DT_KQCHIA;
                        DT_KQCHIA_CHITIET = LIB.SESSION_START.DT_KQCHIA;

                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("KT");// LIB.SESSION_START.DT_DMMAY;
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

        public FRM_KQCHIA()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            //DataTable dt111 = LIB.Procedures.Danhsachketquachia(Ngaydauthang, Ngaycuoithang, 0, string.Empty, string.Empty);
            ////GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQCHIA.xml");
            //dt111 = new KetquachiaManager().Clone();
            ////GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQCHIACHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQCHIA.xml", GRID_KQCHIA, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQCHIACHITIET.xml", GRID_KQCHIACHITIET, pne_CHITIET);
            //GRID_KQCHIA.RootTable.Groups.Add(GRID_KQCHIA.Tables[0].Columns[KetquachiaFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_KQCHIA);
            BS_KQCHIA = new BindingSource();
            BS_KQCHIA.DataSource = Source_View;
            GRID_KQCHIA.DataSource = BS_KQCHIA;
            BS_KQCHIA.CurrentChanged += new EventHandler(BS_KQCHIA_CurrentChanged);
            BS_KQCHIA_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_KQCHIA_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_KQCHIA.UpdateData();
                if (BS_KQCHIA.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQCHIA.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KetquachiaFields.Ngay.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquachiaFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquachiaFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquachiaFields.Mamay.Name].ToString();

                    //txt_TENKHO.Text = _Rowview.Row[KetquachiaFields.Tenkho.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KQCHIA_CurrentChanged"); }
        }

        void BS_KQCHIA_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_KQCHIA_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQCHIA_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[KetquachiaFields.Id.Name].ToString();

                    txt_LENH.Text = _Rowview.Row[KetquachiaFields.Lenh.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquachiaFields.Mamay.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquachiaFields.Macongnhan.Name].ToString();
                    txt_MACONGNHAN_Validating(new object(), new CancelEventArgs());
                    txt_MASANPHAM.Text = _Rowview.Row[KetquachiaFields.Masanpham.Name].ToString();
                    txt_MASANPHAM_Validating(new object(), new CancelEventArgs());

                    txt_SOMVAO.Text = _Rowview.Row[KetquachiaFields.Sometvao.Name].ToString();
                    txt_SOKGVAO.Text = _Rowview.Row[KetquachiaFields.Sokgvao.Name].ToString();
                    txt_DAURAGHEP.Text = _Rowview.Row[KetquachiaFields.Dauraghep.Name].ToString();

                    txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquachiaFields.Thoigiancatdau.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquachiaFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquachiaFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANDOILENH.Text = _Rowview.Row[KetquachiaFields.Thoigiandoilenh.Name].ToString();
                    txt_SOLANHACUON.Text = _Rowview.Row[KetquachiaFields.Solanhacuon.Name].ToString();
                    txt_THOIGIANLENCUON.Text = _Rowview.Row[KetquachiaFields.Thoigianlencuon.Name].ToString();
                    txt_THOIGIANHACUON.Text = _Rowview.Row[KetquachiaFields.Thoigianhacuon.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquachiaFields.Thoigiansuco.Name].ToString();

                    txt_PHEIN.Text = _Rowview.Row[KetquachiaFields.Phein.Name].ToString();
                    txt_PHEGHEP.Text = _Rowview.Row[KetquachiaFields.Pheghep.Name].ToString();
                    txt_PHECHIA.Text = _Rowview.Row[KetquachiaFields.Phechia.Name].ToString();
                    txt_PHETHOI.Text = _Rowview.Row[KetquachiaFields.PhethoiNcc.Name].ToString();
                    txt_PHESANXUAT.Text = _Rowview.Row[KetquachiaFields.Phesx.Name].ToString();

                    txt_NANGSUAT.Text = _Rowview.Row[KetquachiaFields.Nangsuat.Name].ToString();
                    txt_TYLESAIHONG.Text = _Rowview.Row[KetquachiaFields.Tylesaihong.Name].ToString();
                    txt_SOCUON.Text = _Rowview.Row[KetquachiaFields.Socuon.Name].ToString();
                    txt_TOCDODINHMUC.Text = _Rowview.Row[KetquachiaFields.Tocdodinhmuc.Name].ToString();
                    txt_MATRUONGCA.Text = _Rowview.Row[KetquachiaFields.Matruongca.Name].ToString();
                    txt_TENTRUONGCA.Text = _Rowview.Row[KetquachiaFields.Tentruongca.Name].ToString();

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
                DT_KQCHIA_CHITIET_FILL = new KetquachiaManager().Clone();
                BS_KQCHIA_CHITIET = new BindingSource(DT_KQCHIA_CHITIET_FILL, null);
                GRID_KQCHIACHITIET.DataSource = BS_KQCHIA_CHITIET;
            }
            else
            {
                DT_KQCHIA_CHITIET_FILL = new KetquachiaManager().SelectByNgayCaMamayRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), Convert.ToInt32(txt_CA.Text.Trim()), txt_MAMAY.Text.Trim());

                DataView Source_View = new DataView(DT_KQCHIA_CHITIET_FILL);
                BS_KQCHIA_CHITIET = new BindingSource();
                BS_KQCHIA_CHITIET.DataSource = Source_View;
                GRID_KQCHIACHITIET.DataSource = BS_KQCHIA_CHITIET;
            }
            BS_KQCHIA_CHITIET.CurrentChanged += new EventHandler(BS_KQCHIA_CHITIET_CurrentChanged);
            BS_KQCHIA_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            ADDROW = true;
            DataRow r_Detail = DT_KQCHIA_CHITIET_FILL.NewRow();
            r_Detail[KetquachiaFields.Lenh.Name] = txt_LENH.Text;
            r_Detail[KetquachiaFields.Macongnhan.Name] = txt_MACONGNHAN.Text;
            r_Detail[KetquachiaFields.Tencongnhan.Name] = txt_TENCONGNHAN.Text;
            r_Detail[KetquachiaFields.Masanpham.Name] = txt_MASANPHAM.Text;
            r_Detail[KetquachiaFields.Tensanpham.Name] = txt_TENSANPHAM.Text;
            r_Detail[KetquachiaFields.Mamay.Name] = txt_MAMAY.Text;
            r_Detail[KetquachiaFields.Tenmay.Name] = txt_TENMAY.Text;
            try { r_Detail[KetquachiaFields.Ca.Name] = LIB.ConvertString.NumbertoDB(txt_CA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Sometvao.Name] = LIB.ConvertString.NumbertoDB(txt_SOMVAO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Sokgvao.Name] = LIB.ConvertString.NumbertoDB(txt_SOKGVAO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Dauraghep.Name] = LIB.ConvertString.NumbertoDB(txt_DAURAGHEP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Thoigiancatdau.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCATDAU.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Thoigiandoilenh.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANDOILENH.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Solanhacuon.Name] = LIB.ConvertString.NumbertoDB(txt_SOLANHACUON.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Thoigianlencuon.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANLENCUON.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Thoigianhacuon.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANHACUON.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Thoigiansuco.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Phein.Name] = LIB.ConvertString.NumbertoDB(txt_PHEIN.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Pheghep.Name] = LIB.ConvertString.NumbertoDB(txt_PHEGHEP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Phechia.Name] = LIB.ConvertString.NumbertoDB(txt_PHECHIA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.PhethoiNcc.Name] = LIB.ConvertString.NumbertoDB(txt_PHETHOI.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Phesx.Name] = LIB.ConvertString.NumbertoDB(txt_PHESANXUAT.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Nangsuat.Name] = LIB.ConvertString.NumbertoDB(txt_NANGSUAT.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Tylesaihong.Name] = LIB.ConvertString.NumbertoDB(txt_TYLESAIHONG.Text.Trim()); }
            catch { }
            try { r_Detail[KetquachiaFields.Socuon.Name] = LIB.ConvertString.NumbertoDB(txt_SOCUON.Text.Trim()); }
            catch { }

            r_Detail[KetquachiaFields.Thoigianbatdau.Name] = txt_THOIGIANBATDAU.Text;
            r_Detail[KetquachiaFields.Thoigianketthuc.Name] = txt_THOIGIANKETTHUC.Text;
            r_Detail[KetquachiaFields.Tocdodinhmuc.Name] = LIB.ConvertString.NumbertoDB(txt_TOCDODINHMUC.Text.Trim());
            r_Detail[KetquachiaFields.Matruongca.Name] = txt_MATRUONGCA.Text;
            r_Detail[KetquachiaFields.Tentruongca.Name] = txt_TENTRUONGCA.Text;

            DT_KQCHIA_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_KQCHIA_CHITIET_FILL);
            BS_KQCHIA_CHITIET = new BindingSource();
            BS_KQCHIA_CHITIET.DataSource = Source_View;
            GRID_KQCHIACHITIET.DataSource = BS_KQCHIA_CHITIET;
            BS_KQCHIA_CHITIET.Position = DT_KQCHIA_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
            ADDROW = false;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_KQCHIACHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[KetquachiaFields.Id.Name].ToString();
            string _MAMANG = _view[KetquachiaFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_KQCHIACHITIET.CurrentRow.Delete();
            }
            else
            {
                KetquachiaManager _KetquachiaManager = new KetquachiaManager();
                KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
                try { _KetquachiaEntity = _KetquachiaManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_KetquachiaEntity != null && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _KetquachiaManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_KQCHIA_CHITIET_FILL.Select(KetquachiaFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_KQCHIA_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_KQCHIA_CHITIET.ResetCurrentItem();
                    GRID_KQCHIACHITIET.DataSource = BS_KQCHIA_CHITIET;
                }
                GRID_KQCHIACHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngayxuat = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _KetquachiaEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_KQCHIACHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
                _KetquachiaEntity.Ngay = _ngayxuat;
                _KetquachiaEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim());
                _KetquachiaEntity.Mamay = txt_MAMAY.Text.Trim();
                _KetquachiaEntity.Tenmay = txt_TENMAY.Text.Trim();
                _KetquachiaEntity.Lenh = _view.Row[KetquachiaFields.Lenh.Name].ToString();
                _KetquachiaEntity.Macongnhan = _view.Row[KetquachiaFields.Macongnhan.Name].ToString();
                _KetquachiaEntity.Tencongnhan = _view.Row[KetquachiaFields.Tencongnhan.Name].ToString();
                _KetquachiaEntity.Masanpham = _view.Row[KetquachiaFields.Masanpham.Name].ToString();
                _KetquachiaEntity.Tensanpham = _view.Row[KetquachiaFields.Tensanpham.Name].ToString();
                _KetquachiaEntity.Sometvao = Convert.ToDecimal(_view.Row[KetquachiaFields.Sometvao.Name].ToString());
                _KetquachiaEntity.Sokgvao = Convert.ToDecimal(_view.Row[KetquachiaFields.Sokgvao.Name].ToString());
                _KetquachiaEntity.Dauraghep = Convert.ToDecimal(_view.Row[KetquachiaFields.Dauraghep.Name].ToString());
                _KetquachiaEntity.Thoigiancatdau = Convert.ToDecimal(_view.Row[KetquachiaFields.Thoigiancatdau.Name].ToString());
                _KetquachiaEntity.Thoigianbatdau = Convert.ToDateTime(_view.Row[KetquachiaFields.Thoigianbatdau.Name].ToString());
                _KetquachiaEntity.Thoigianketthuc = Convert.ToDateTime(_view.Row[KetquachiaFields.Thoigianketthuc.Name].ToString());
                _KetquachiaEntity.Thoigiandoilenh = Convert.ToDecimal(_view.Row[KetquachiaFields.Thoigiandoilenh.Name].ToString());
                _KetquachiaEntity.Solanhacuon = Convert.ToInt32(_view.Row[KetquachiaFields.Solanhacuon.Name].ToString());
                _KetquachiaEntity.Thoigianlencuon = Convert.ToDecimal(_view.Row[KetquachiaFields.Thoigianlencuon.Name].ToString());
                _KetquachiaEntity.Thoigianhacuon = Convert.ToDecimal(_view.Row[KetquachiaFields.Thoigianhacuon.Name].ToString());
                _KetquachiaEntity.Thoigiansuco = Convert.ToDecimal(_view.Row[KetquachiaFields.Thoigiansuco.Name].ToString());
                _KetquachiaEntity.Phein = Convert.ToDecimal(_view.Row[KetquachiaFields.Phein.Name].ToString());
                _KetquachiaEntity.Pheghep = Convert.ToDecimal(_view.Row[KetquachiaFields.Pheghep.Name].ToString());
                _KetquachiaEntity.Phechia = Convert.ToDecimal(_view.Row[KetquachiaFields.Phechia.Name].ToString());
                _KetquachiaEntity.PhethoiNcc = Convert.ToDecimal(_view.Row[KetquachiaFields.PhethoiNcc.Name].ToString());
                _KetquachiaEntity.Phesx = Convert.ToDecimal(_view.Row[KetquachiaFields.Phesx.Name].ToString());
                _KetquachiaEntity.Nangsuat = Convert.ToDecimal(_view.Row[KetquachiaFields.Nangsuat.Name].ToString());
                _KetquachiaEntity.Tylesaihong = Convert.ToDecimal(_view.Row[KetquachiaFields.Tylesaihong.Name].ToString());
                _KetquachiaEntity.Socuon = Convert.ToInt32(_view.Row[KetquachiaFields.Socuon.Name].ToString());
                _KetquachiaEntity.Matruongca = _view.Row[KetquachiaFields.Matruongca.Name].ToString();
                _KetquachiaEntity.Tentruongca = _view.Row[KetquachiaFields.Tentruongca.Name].ToString();

                try { _KetquachiaEntity.Tocdodinhmuc = System.Decimal.Parse(_view.Row[KetquachiaFields.Tocdodinhmuc.Name].ToString()); }
                catch { }

                #region xét isnew
                try { _KetquachiaEntity.Id = Convert.ToInt64(_view[KetquachiaFields.Id.Name].ToString()); }
                catch { }

                _KetquachiaEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_KetquachiaEntity.IsNew)
                {
                    EntityCollection drDHCT = (new KetquachiaManager()).SelectById(_KetquachiaEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _KetquachiaEntity.Ngaysua = DateTime.Now;
                        _KetquachiaEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _KetquachiaEntity.IsNew = false;
                    }
                    else
                    {
                        _KetquachiaEntity.Ngaytao = DateTime.Now;
                        _KetquachiaEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }
                #endregion

                if (!string.IsNullOrEmpty(_KetquachiaEntity.Masanpham))
                    _KetquachiaEntityCol.Add(_KetquachiaEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (KetquachiaEntity _KetquachiaEntity in _KetquachiaEntityCol)
            {
                if (_KetquachiaEntity.IsNew)
                {
                    DataRow _r_Insert = DT_KQCHIA_CHITIET.NewRow();
                    DT_KQCHIA_CHITIET.Rows.Add(_r_Insert);
                    _KetquachiaManager.InsertV2(_KetquachiaEntity, _r_Insert, DT_KQCHIA_CHITIET, BS_KQCHIA_CHITIET);
                }
                else _KetquachiaManager.Update(_KetquachiaEntity);
            }

            GRID_KQCHIA.CurrentRow.Cells[KetquachiaFields.Ngay.Name].Value = _ngayxuat;
            GRID_KQCHIA.CurrentRow.Cells[KetquachiaFields.Ca.Name].Value = txt_CA.Text.Trim();
            GRID_KQCHIA.CurrentRow.Cells[KetquachiaFields.Mamay.Name].Value = txt_MAMAY.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_KetquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENCONGNHAN.Text = txt_TENSANPHAM.Text = txt_TENMAY.Text = txt_MATRUONGCA.Text = txt_TENTRUONGCA.Text = string.Empty;
            r_Insert = DT_KQCHIA.NewRow();
            DT_KQCHIA.Rows.Add(r_Insert);
            BS_KQCHIA.Position = DT_KQCHIA.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY, txt_MATRUONGCA, txt_TENTRUONGCA, txt_TOCDODINHMUC }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_KQCHIA.Enabled = false;

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
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY, txt_MATRUONGCA, txt_TENTRUONGCA, txt_TOCDODINHMUC }));
            }
            GRID_KQCHIACHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_KQCHIACHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQCHIACHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQCHIACHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQCHIACHITIET.Enabled = true;
            GRID_KQCHIA.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQCHIA.Rows.Remove(r_Insert);
            }
            BS_KQCHIA_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_KQCHIA.Enabled = true;
            GRID_KQCHIACHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQCHIACHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQCHIACHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            //_KetquachiaEntity = _KetquachiaManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquachiaEntity != null && MessageBox.Show("Xóa kết quả chia: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_KQCHIACHITIET.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[KetquachiaFields.Id.Name].ToString()))
                        {
                            try { _KetquachiaManager.Delete(Convert.ToInt64(_view[KetquachiaFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_KetquachiaManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    try { GRID_KQCHIA.CurrentRow.Delete(); }
                    catch { }
                    BS_KQCHIA_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_KetquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa kết quả chia: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KQCHIA.Enabled = true;
            GRID_KQCHIACHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQCHIACHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQCHIACHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
                GRID_KQCHIA.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_KQCHIACHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQCHIACHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQCHIACHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD;

            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Validate

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

        //private void txt_LENHTHOI_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_LENHTHOI.Text.Trim()) || DT_LENHTHOI == null || DT_LENHTHOI.Rows.Count == 0) return;
        //    string _str_MACANTIM = txt_LENHTHOI.Text.Trim().ToUpper();
        //    _RowViewSelect = checklenhthoi(_str_MACANTIM, DT_LENHTHOI);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
        //                DT_LENHTHOI, DmkhachFields.Makhach.Name, _str_MACANTIM);
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
        //private DataRow checklenhthoi(string macantim, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(.Mamay.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}


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
        #endregion

        #region  Tính năng suất, số cuộn, tỷ lệ sai hỏng
        private void Tinhnangsuat()
        {
            try
            {
                decimal _timerun = 0, _tocdo = 0, _somet = 0, _nangsuat = 0;
                _somet = LIB.ConvertString.NumbertoDB(txt_SOMVAO.Text.Trim());
                _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MASANPHAM.Text);
                _timerun = Convert.ToDecimal((Convert.ToDateTime(txt_THOIGIANKETTHUC.Text) - Convert.ToDateTime(txt_THOIGIANBATDAU.Text)).TotalMinutes)
                    - (Convert.ToDecimal(txt_THOIGIANLENCUON.Text.Trim()) + Convert.ToDecimal(txt_THOIGIANHACUON.Text.Trim()) + Convert.ToDecimal(txt_THOIGIANCATDAU.Text.Trim()) + Convert.ToDecimal(txt_THOIGIANDOILENH.Text.Trim()))
                    - LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
                _nangsuat = _somet / _tocdo / _timerun * 100;
                txt_NANGSUAT.Text = Math.Round(_nangsuat).ToString();
            }
            catch { }
        }
        private void Tinhsocuon()
        {
            try
            {
                decimal _solanha = 0, _sohinh = 0, _socuon = 0;
                _solanha = LIB.ConvertString.NumbertoDB(txt_SOLANHACUON.Text.Trim());
                DmhangEntity _DmhangEntity = new DmhangManager().SelectOne(txt_MASANPHAM.Text.Trim());
                _sohinh = Convert.ToInt32(_DmhangEntity.Sohinh);
                _socuon = _solanha / _sohinh;
                txt_SOCUON.Text = Math.Floor(_socuon+Convert.ToDecimal(0.99)).ToString();
            }
            catch { }
        }
        private void Tinhtylesaihong()
        {
            try
            {
                decimal _dinhmuckg = 0, _thuctekg = 0, _tyle = 0;
                _dinhmuckg = LIB.ConvertString.NumbertoDB(txt_SOKGVAO.Text.Trim());
                _thuctekg = LIB.ConvertString.NumbertoDB(txt_PHECHIA.Text.Trim());
                _tyle = _thuctekg / _dinhmuckg * 100;
                txt_TYLESAIHONG.Text = Math.Round(_tyle).ToString();
            }
            catch { }
        }
        private void txt_NANGSUAT_Validated(object sender, EventArgs e)
        {
            Tinhnangsuat();
        }
        private void txt_TYLESAIHONG_Validated(object sender, EventArgs e)
        {
            Tinhtylesaihong();
        }
        private void txt_SOCUON_Validated(object sender, EventArgs e)
        {
            Tinhsocuon();
            Tinhthoigianxuongcuon();
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
                    decimal _thoigiancatdau = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Daucuon.Name);
                    txt_THOIGIANCATDAU.Text = Math.Round(_thoigiancatdau).ToString();
                    decimal _thoigiandoilenh = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Doilenh.Name);
                    txt_THOIGIANDOILENH.Text = Math.Round(_thoigiandoilenh).ToString();
                }
            }
            catch { }
        }
        private void Tinhthoigianlencuon()
        {
            try
            {
                decimal _socuon = 0, _thoigianlencuon = 0;
                decimal _thoigianlencuondm = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Lencuon.Name);
                _socuon = LIB.ConvertString.NumbertoDB(txt_SOCUON.Text.Trim());
                _thoigianlencuon = _socuon * _thoigianlencuondm;
                txt_THOIGIANLENCUON.Text = Math.Round(_thoigianlencuon).ToString();
            }
            catch { }
        }
        private void Tinhthoigianxuongcuon()
        {
            try
            {
                decimal _solanhacuon = 0, _thoigianhacuon = 0;
                decimal _thoigianhacuondm = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Xuongcuon.Name);
                _thoigianhacuon = _solanhacuon * _thoigianhacuondm;
                txt_THOIGIANHACUON.Text = Math.Round(_thoigianhacuon).ToString();
            }
            catch { }
        }
        private void txt_THOIGIANLENCUON_Validated(object sender, EventArgs e)
        {
            Tinhthoigianlencuon();
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

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_KQCHIA.ColumnAutoResize = true;
            else
                GRID_KQCHIA.ColumnAutoResize = false;
        }

        private void FRM_KQCHIA_FormClosing(object sender, FormClosingEventArgs e)
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
