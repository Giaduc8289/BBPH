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

namespace GD.BBPH.APP.TUA
{
    public partial class FRM_TKKQTUA : FRM_DMPARENT
    {
        private KetquatuaManager _KetquatuaManager = new KetquatuaManager();
        private KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_TKKQTUA = new DataTable(), DT_TKKQTUA_CHITIET = new DataTable(), DT_TKKQTUA_CHITIET_FILL = new DataTable();
        private BindingSource BS_TKKQTUA = new BindingSource(), BS_TKKQTUA_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_TKKQTUA = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_TKKQTUA_CHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET = "";
        private bool ADDROW = false;

        private DataTable DT_HANG = new DataTable(), DT_DMCONGNHAN = new DataTable(), DT_DMMAY = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_TKKQTUA");
                        DT_TKKQTUA = LIB.Procedures.Danhsachketquatua(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty); //LIB.SESSION_START.DT_TKKQTUA;
                        DT_TKKQTUA_CHITIET = LIB.SESSION_START.DT_TKKQTUA;

                        DT_HANG = LIB.SESSION_START.DM_HANG;
                        DT_DMCONGNHAN = LIB.SESSION_START.DT_DMCONGNHAN;
                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("KT");// LIB.SESSION_START.DT_DMMAY;
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

        public FRM_TKKQTUA()
        {
            InitializeComponent();
            //KetquatuaManager _KetquatuaManager = new KetquatuaManager();
            //DataTable dt111 = LIB.Procedures.Danhsachketquatua(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKKQTUA.xml");
            //dt111 = _KetquatuaManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKKQTUA_CHITIET.xml");

            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKKQTUA.xml", GRID_TKKQTUA, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_TKKQTUA_CHITIET.xml", GRID_TKKQTUA_CHITIET, pne_CHITIET);
            GRID_TKKQTUA.RootTable.SortKeys.Add(KetquatuaFields.Ngay.Name, Janus.Windows.GridEX.SortOrder.Descending);
            GRID_TKKQTUA_CHITIET.FilterMode = FilterMode.None;
            GRID_TKKQTUA_CHITIET.GroupByBoxVisible = false;
            GRID_TKKQTUA_CHITIET.DeletingRecord += GRID_TKKQTUA_CHITIET_DeletingRecord;
            FORM_PROCESS();
            //GRID_TKKQTUA_CHITIET.COMBO_MULTICOLUMN(GRID_TKKQTUA_CHITIET, KetquatuaFields.Masp.Name, DanhmuchanghoaFields.Tenhieu.Name, DanhmuchanghoaFields.Mahieu.Name, DanhmuchanghoaFields.Mahieu.Name, DT_HANG);
            //GRID_TKKQTUA_CHITIET.CellEdited += GRID_TKKQTUA_CHITIET_CellEdited;
            //GRID_TKKQTUA_CHITIET.RecordsDeleted += GRID_TKKQTUA_CHITIET_RecordsDeleted;
            //GRID_TKKQTUA_CHITIET.RecordUpdated += GRID_TKKQTUA_CHITIET_RecordUpdated;
            //GRID_TKKQTUA_CHITIET.DeletingRecord += GRID_TKKQTUA_CHITIET_DeletingRecord;
            ////GRID_TKKQTUA_CHITIET.Click += GRID_TKKQTUA_CHITIET_Click;
            //GRID_TKKQTUA_CHITIET.RootTable.Columns["Thanhtien"].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_TKKQTUA);
            BS_TKKQTUA = new BindingSource();
            BS_TKKQTUA.DataSource = Source_View;
            GRID_TKKQTUA.DataSource = BS_TKKQTUA;
            BS_TKKQTUA.CurrentChanged += new EventHandler(BS_TKKQTUA_CurrentChanged);
            BS_TKKQTUA_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_TKKQTUA_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_TKKQTUA.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_TKKQTUA.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KetquatuaFields.Ngay.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquatuaFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquatuaFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquatuaFields.Mamay.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_TKKQTUA_CurrentChanged"); }
        }
        void BS_TKKQTUA_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_TKKQTUA_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_TKKQTUA_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[KetquatuaFields.Id.Name].ToString();

                    txt_LENHTUA.Text = _Rowview.Row[KetquatuaFields.Lenhtua.Name].ToString();
                    txt_MASANPHAM.Text = _Rowview.Row[KetquatuaFields.Masanpham.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquatuaFields.Macongnhan.Name].ToString();
                    txt_TENCONGNHAN.Text = _Rowview.Row[KetquatuaFields.Tencongnhan.Name].ToString();
                    txt_DAURAIN.Text = _Rowview.Row[KetquatuaFields.Daurain.Name].ToString();
                    txt_SOMETVAO.Text = _Rowview.Row[KetquatuaFields.SoMetvao.Name].ToString();
                    txt_KHOILUONGVAO.Text = _Rowview.Row[KetquatuaFields.SoKgvao.Name].ToString();
                    txt_SOMETRA.Text = _Rowview.Row[KetquatuaFields.SoMetra.Name].ToString();
                    txt_KHOILUONGRA.Text = _Rowview.Row[KetquatuaFields.SoKgra.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquatuaFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquatuaFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANLENHACUON.Text = _Rowview.Row[KetquatuaFields.Thoigianhacuon.Name].ToString();
                    txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquatuaFields.Thoigiancatdau.Name].ToString();
                    txt_THOIGIANDOILENH.Text = _Rowview.Row[KetquatuaFields.Thoigiandoilenh.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquatuaFields.Thoigiansuco.Name].ToString();
                    txt_PHEIN.Text = _Rowview.Row[KetquatuaFields.Phein.Name].ToString();
                    txt_PHEGHEP.Text = _Rowview.Row[KetquatuaFields.Pheghep.Name].ToString();
                    txt_PHETHOI.Text = _Rowview.Row[KetquatuaFields.Phethoi.Name].ToString();
                    txt_PHESANXUAT.Text = _Rowview.Row[KetquatuaFields.Phesx.Name].ToString();
                    txt_TENSANPHAM.Text = _Rowview.Row[KetquatuaFields.Tensanpham.Name].ToString();
                    txt_TENMAY.Text = _Rowview.Row[KetquatuaFields.Tenmay.Name].ToString();
                   
                    txt_NANGSUAT.Text = _Rowview.Row[KetquatuaFields.Nangsuat.Name].ToString();
                    txt_THOIGIANDAUCA.Text = _Rowview.Row[KetquatuaFields.Thoigiandauca.Name].ToString();
                    txt_CHENHLECHKG.Text = _Rowview.Row[KetquatuaFields.Chenhlechkg.Name].ToString();
                    txt_MATRUONGCA.Text = _Rowview.Row[KetquatuaFields.Matruongca.Name].ToString();
                    txt_TENTRUONGCA.Text = _Rowview.Row[KetquatuaFields.Tentruongca.Name].ToString();
                    txt_TOCDODINHMUC.Text = _Rowview.Row[KetquatuaFields.Tocdodinhmuc.Name].ToString();
                    txt_LYDOSUCO.Text = _Rowview.Row[KetquatuaFields.Lydosuco.Name].ToString();
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
                DT_TKKQTUA_CHITIET_FILL = new KetquatuaManager().Clone();
                BS_TKKQTUA_CHITIET = new BindingSource(DT_TKKQTUA_CHITIET_FILL, null);
                GRID_TKKQTUA_CHITIET.DataSource = BS_TKKQTUA_CHITIET;
            }
            else
            {
                DT_TKKQTUA_CHITIET_FILL = LIB.Procedures.Danhsachketquatuachitiet(Convert.ToDateTime(txt_NGAY.Text.Trim()), Convert.ToInt32(txt_CA.Text.Trim()), txt_MAMAY.Text.Trim(), string.Empty);

                DataView Source_View = new DataView(DT_TKKQTUA_CHITIET_FILL);
                BS_TKKQTUA_CHITIET = new BindingSource();
                BS_TKKQTUA_CHITIET.DataSource = Source_View;
                GRID_TKKQTUA_CHITIET.DataSource = BS_TKKQTUA_CHITIET;
            }
            BS_TKKQTUA_CHITIET.CurrentChanged += new EventHandler(BS_TKKQTUA_CHITIET_CurrentChanged);
            BS_TKKQTUA_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            ADDROW = true;
            DataRow r_Detail = DT_TKKQTUA_CHITIET_FILL.NewRow();

            r_Detail[KetquatuaFields.Lenhtua.Name] = txt_LENHTUA.Text;
            r_Detail[KetquatuaFields.Masanpham.Name] = txt_MASANPHAM.Text;
            r_Detail[KetquatuaFields.Tensanpham.Name] = txt_TENSANPHAM.Text;
            r_Detail[KetquatuaFields.Matruongca.Name] = txt_MATRUONGCA.Text;
            r_Detail[KetquatuaFields.Tentruongca.Name] = txt_TENTRUONGCA.Text;
            r_Detail[KetquatuaFields.Macongnhan.Name] = txt_MACONGNHAN.Text;
            r_Detail[KetquatuaFields.Tencongnhan.Name] = txt_TENCONGNHAN.Text;

            r_Detail[KetquatuaFields.SoMetvao.Name] = txt_SOMETVAO.Text.Trim();
            r_Detail[KetquatuaFields.SoMetra.Name] = txt_SOMETRA.Text.Trim();
            r_Detail[KetquatuaFields.SoKgvao.Name] = txt_KHOILUONGVAO.Text.Trim();
            r_Detail[KetquatuaFields.SoKgra.Name] = txt_KHOILUONGRA.Text.Trim();
            r_Detail[KetquatuaFields.Phethoi.Name] = LIB.ConvertString.NumbertoDB(txt_PHETHOI.Text.Trim());
            r_Detail[KetquatuaFields.Pheghep.Name] = LIB.ConvertString.NumbertoDB(txt_PHEGHEP.Text.Trim());
            r_Detail[KetquatuaFields.Phein.Name] = LIB.ConvertString.NumbertoDB(txt_PHEIN.Text.Trim());
            r_Detail[KetquatuaFields.Phesx.Name] = LIB.ConvertString.NumbertoDB(txt_PHESANXUAT.Text.Trim());

            r_Detail[KetquatuaFields.Thoigianbatdau.Name] = txt_THOIGIANBATDAU.Text.Trim();
            r_Detail[KetquatuaFields.Thoigianketthuc.Name] = txt_THOIGIANKETTHUC.Text.Trim();
            r_Detail[KetquatuaFields.Thoigiandauca.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANDAUCA.Text.Trim());
            r_Detail[KetquatuaFields.Thoigianhacuon.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANLENHACUON.Text.Trim());
            r_Detail[KetquatuaFields.Thoigiancatdau.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCATDAU.Text.Trim());
            r_Detail[KetquatuaFields.Thoigiandoilenh.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANDOILENH.Text.Trim());
            r_Detail[KetquatuaFields.Thoigiansuco.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
            r_Detail[KetquatuaFields.Lydosuco.Name] = txt_LYDOSUCO.Text.Trim();

            r_Detail[KetquatuaFields.Nangsuat.Name] = LIB.ConvertString.NumbertoDB(txt_NANGSUAT.Text.Trim());
            r_Detail[KetquatuaFields.Tocdodinhmuc.Name] = LIB.ConvertString.NumbertoDB(txt_TOCDODINHMUC.Text.Trim());

            DT_TKKQTUA_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_TKKQTUA_CHITIET_FILL);
            BS_TKKQTUA_CHITIET = new BindingSource();
            BS_TKKQTUA_CHITIET.DataSource = Source_View;
            GRID_TKKQTUA_CHITIET.DataSource = BS_TKKQTUA_CHITIET;
            BS_TKKQTUA_CHITIET.Position = DT_TKKQTUA_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
            ADDROW = false;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_TKKQTUA_CHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[KetquatuaFields.Id.Name].ToString();
            string _MASANPHAM = _view[KetquatuaFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_TKKQTUA_CHITIET.CurrentRow.Delete();
            }
            else
            {
                KetquatuaManager _KetquatuaManager = new KetquatuaManager();
                KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity();
                try { _KetquatuaEntity = _KetquatuaManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_KetquatuaEntity != null && MessageBox.Show("Xóa dòng: " + _MASANPHAM, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _KetquatuaManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_TKKQTUA_CHITIET_FILL.Select(KetquatuaFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_TKKQTUA_CHITIET_FILL.Rows.Remove(drArr[0]);
                        //GRID_TKKQTUA_CHITIET.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MASANPHAM + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_TKKQTUA_CHITIET.ResetCurrentItem();
                    GRID_TKKQTUA_CHITIET.DataSource = BS_TKKQTUA_CHITIET;
                }
                GRID_TKKQTUA_CHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        private void GRID_TKKQTUA_CHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }
        #endregion
        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngay = Convert.ToDateTime(txt_NGAY.Text.Trim());
            int _ca = Convert.ToInt32(txt_CA.Text.Trim());
            string _mamay = txt_MAMAY.Text.Trim();

            EntityCollection _KetquatuaEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_TKKQTUA_CHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity();
                _KetquatuaEntity.Ngay = _ngay;
                _KetquatuaEntity.Ca = _ca;
                _KetquatuaEntity.Mamay = _mamay;
                _KetquatuaEntity.Tenmay = _view.Row[KetquatuaFields.Tenmay.Name].ToString();
                _KetquatuaEntity.Lenhtua = _view.Row[KetquatuaFields.Lenhtua.Name].ToString();
                _KetquatuaEntity.Lydosuco = _view.Row[KetquatuaFields.Lydosuco.Name].ToString();
                _KetquatuaEntity.Macongnhan = _view.Row[KetquatuaFields.Macongnhan.Name].ToString();
                _KetquatuaEntity.Tencongnhan = _view.Row[KetquatuaFields.Tencongnhan.Name].ToString();
                _KetquatuaEntity.Masanpham = _view.Row[KetquatuaFields.Masanpham.Name].ToString();
                _KetquatuaEntity.Tensanpham = _view.Row[KetquatuaFields.Tensanpham.Name].ToString();
                //_KetquatuaEntity.Tennguyenlieu = _view.Row[KetquatuaFields.Tennguyenlieu.Name].ToString();
                try { _KetquatuaEntity.SoMetvao = Convert.ToDecimal(_view.Row[KetquatuaFields.SoMetvao.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.SoMetra = Convert.ToDecimal(_view.Row[KetquatuaFields.SoMetra.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.SoKgvao = Convert.ToDecimal(_view.Row[KetquatuaFields.SoKgvao.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.SoKgra = Convert.ToDecimal(_view.Row[KetquatuaFields.SoKgra.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.SoMetvao = Convert.ToDecimal(_view.Row[KetquatuaFields.SoMetvao.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Phein = Convert.ToDecimal(_view.Row[KetquatuaFields.Phein.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Pheghep = Convert.ToDecimal(_view.Row[KetquatuaFields.Pheghep.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Phethoi = Convert.ToDecimal(_view.Row[KetquatuaFields.Phethoi.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Phesx = Convert.ToDecimal(_view.Row[KetquatuaFields.Phesx.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Thoigianbatdau = Convert.ToDateTime(_view.Row[KetquatuaFields.Thoigianbatdau.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Thoigianketthuc = Convert.ToDateTime(_view.Row[KetquatuaFields.Thoigianketthuc.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Thoigiandauca = Convert.ToDecimal(_view.Row[KetquatuaFields.Thoigiandauca.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Thoigianhacuon = Convert.ToDecimal(_view.Row[KetquatuaFields.Thoigianhacuon.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Thoigiancatdau = Convert.ToDecimal(_view.Row[KetquatuaFields.Thoigiancatdau.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Thoigiandoilenh = Convert.ToDecimal(_view.Row[KetquatuaFields.Thoigiandoilenh.Name].ToString()); }
                catch { }
                try { _KetquatuaEntity.Thoigiansuco = Convert.ToDecimal(_view.Row[KetquatuaFields.Thoigiansuco.Name].ToString()); }
                catch { }

                #region xét isnew
                try { _KetquatuaEntity.Id = Convert.ToInt64(_view[KetquatuaFields.Id.Name].ToString()); }
                catch { }

                _KetquatuaEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_KetquatuaEntity.IsNew)
                {
                    EntityCollection drDHCT = (new KetquatuaManager()).SelectById(_KetquatuaEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _KetquatuaEntity.Ngaysua = DateTime.Now;
                        _KetquatuaEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _KetquatuaEntity.IsNew = false;
                    }
                    else
                    {
                        _KetquatuaEntity.Ngaytao = DateTime.Now;
                        _KetquatuaEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }
                #endregion

                if (!string.IsNullOrEmpty(_KetquatuaEntity.Masanpham))
                    _KetquatuaEntityCol.Add(_KetquatuaEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (KetquatuaEntity _KetquatuaEntity in _KetquatuaEntityCol)
            {
                if (_KetquatuaEntity.IsNew)
                {
                    DataRow _r_Insert = DT_TKKQTUA_CHITIET.NewRow();
                    DT_TKKQTUA_CHITIET.Rows.Add(_r_Insert);
                    _KetquatuaManager.InsertV2(_KetquatuaEntity, _r_Insert, DT_TKKQTUA_CHITIET, BS_TKKQTUA_CHITIET);
                }
                else _KetquatuaManager.Update(_KetquatuaEntity);
            }

            GRID_TKKQTUA.CurrentRow.Cells[KetquatuaFields.Ngay.Name].Value = _ngay;
            GRID_TKKQTUA.CurrentRow.Cells[KetquatuaFields.Ca.Name].Value = _ca;
            GRID_TKKQTUA.CurrentRow.Cells[KetquatuaFields.Mamay.Name].Value = _mamay;
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquatuaManager.Convert(_KetquatuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENMAY.Text = txt_MATRUONGCA.Text = txt_TENTRUONGCA.Text = txt_TENCONGNHAN.Text = txt_TENSANPHAM.Text = string.Empty;
            r_Insert = DT_TKKQTUA.NewRow();
            DT_TKKQTUA.Rows.Add(r_Insert);
            BS_TKKQTUA.Position = DT_TKKQTUA.Rows.Count;
            GRID_TKKQTUA_CHITIET.Enabled = true;
            GRID_TKKQTUA_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKKQTUA_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKKQTUA_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKKQTUA_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            MAHIEU_PK = "";
            //txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENMAY, txt_TENCONGNHAN, txt_TENSANPHAM, txt_MATRUONGCA, txt_TENTRUONGCA, txt_TOCDODINHMUC }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_TKKQTUA.Enabled = false;

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
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_NGAY, txt_TENMAY, txt_TENCONGNHAN, txt_TENSANPHAM, txt_MATRUONGCA, txt_TENTRUONGCA, txt_TOCDODINHMUC }));
                //txt_TENHIEU.Focus();
            }
            GRID_TKKQTUA_CHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_TKKQTUA_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKKQTUA_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKKQTUA_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_TKKQTUA_CHITIET.Enabled = true;
            GRID_TKKQTUA.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_TKKQTUA.Rows.Remove(r_Insert);
            }
            BS_TKKQTUA_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_TKKQTUA.Enabled = true;
            GRID_TKKQTUA_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKKQTUA_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKKQTUA_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            //_KetquatuaEntity = _KetquatuaManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquatuaEntity != null && MessageBox.Show("Xóa kết quả tua: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_TKKQTUA_CHITIET.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[KetquatuaFields.Id.Name].ToString()))
                        {
                            try { _KetquatuaManager.Delete(Convert.ToInt64(_view[KetquatuaFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_KetquatuaManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    try { GRID_TKKQTUA.CurrentRow.Delete(); }
                    catch { }
                    BS_TKKQTUA_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquatuaManager.Convert(_KetquatuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa kết quả tua: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_TKKQTUA.Enabled = true;
            GRID_TKKQTUA_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKKQTUA_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_TKKQTUA_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
                GRID_TKKQTUA.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_TKKQTUA_CHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TKKQTUA_CHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_TKKQTUA_CHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD;

            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiPanel1Container_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Validate
        private void txt_MAMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = new DmmayManager().CheckMa(_str_MACANTIM, DT_DMMAY);
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
                txt_TENSANPHAM.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
        }
        private DataRow checkmaMay(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmmayFields.Mamay.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACONGNHAN_Validating(object sender, CancelEventArgs e)
        {
            if (ADDROW) return;
            if (string.IsNullOrEmpty(txt_MACONGNHAN.Text) || !btn_LUULAI.Enabled) return;
            txt_TENCONGNHAN.Text = txt_MATRUONGCA.Text = txt_TENTRUONGCA.Text = string.Empty;
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGNHAN_CHON.xml", DT_DMCONGNHAN, DmcongnhanFields.Macn.Name, txt_MACONGNHAN.Text);
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
        private void txt_MASANPHAM_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MASANPHAM.Text.Trim()) || DT_HANG == null || DT_HANG.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MASANPHAM.Text.Trim().ToUpper();
            _RowViewSelect = new DmmayManager().CheckMa(_str_MACANTIM, DT_HANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_HANG, DmhangFields.Masp.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MASANPHAM.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENSANPHAM.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
                Tinhtocdodinhmuc();
            }
            else
                txt_TENSANPHAM.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();

                Tinhtocdodinhmuc();
        }
        private DataRow checkmaSanpham(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmhangFields.Masp.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region Tính năng suất và khối lượng chênh lệch
        private void Tinhnangsuat()
        {
            try
            {
                decimal _timerun = 0, _tocdo = 0, _somet = 0, _nangsuat = 0;
                _somet = LIB.ConvertString.NumbertoDB(txt_SOMETRA.Text.Trim());
                _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MASANPHAM.Text);
                _timerun = Convert.ToDecimal((Convert.ToDateTime(txt_THOIGIANKETTHUC.Text) - Convert.ToDateTime(txt_THOIGIANBATDAU.Text)).TotalMinutes)
                    - LIB.ConvertString.NumbertoDB(txt_THOIGIANDAUCA.Text.Trim()) - LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim())
                    - LIB.ConvertString.NumbertoDB(txt_THOIGIANDOILENH.Text.Trim()) - LIB.ConvertString.NumbertoDB(txt_THOIGIANLENHACUON.Text.Trim()) - LIB.ConvertString.NumbertoDB(txt_THOIGIANCATDAU.Text.Trim());
                _nangsuat = _somet / _tocdo / _timerun * 100;
                txt_NANGSUAT.Text = Math.Round(_nangsuat).ToString();
            }
            catch { }
        }

        private void txt_NANGSUAT_Validated(object sender, EventArgs e)
        {
            Tinhnangsuat();
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

        private void txt_Nguyennhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tinhthoigianchuanbi()
        {
            try
            {
                if (FUNCTION == GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI)
                {
                    decimal _thoigiandc = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Dauca.Name);
                    txt_THOIGIANDAUCA.Text = Math.Round(_thoigiandc).ToString();
                    decimal _thoigianlenhacuon = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Lencuon.Name + DinhmucthoigianFields.Xuongcuon.Name);
                    txt_THOIGIANLENHACUON.Text = Math.Round(_thoigianlenhacuon).ToString();
                    decimal _thoigiancatdau = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Daucuon.Name);
                    txt_THOIGIANDAUCA.Text = Math.Round(_thoigiancatdau).ToString();
                    decimal _thoigiandoilenh = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MASANPHAM.Text, DinhmucthoigianFields.Doilenh.Name);
                    txt_THOIGIANDAUCA.Text = Math.Round(_thoigiandoilenh).ToString();
                }
            }
            catch { }
        }
        private void Tinhchenhlechkg()
        {
            try
            {
                decimal _kgvao = 0, _kgra = 0, _kgphe = 0, _kgchenhlech = 0;
                _kgvao = LIB.ConvertString.NumbertoDB(txt_SOMETVAO.Text.Trim());
                _kgra = LIB.ConvertString.NumbertoDB(txt_SOMETRA.Text.Trim());
                _kgphe = LIB.ConvertString.NumbertoDB(txt_PHEIN.Text.Trim()) + LIB.ConvertString.NumbertoDB(txt_PHEGHEP.Text.Trim())
                    + LIB.ConvertString.NumbertoDB(txt_PHETHOI.Text.Trim()) + LIB.ConvertString.NumbertoDB(txt_PHESANXUAT.Text.Trim());
                _kgchenhlech = _kgvao - _kgra - _kgphe;
                txt_CHENHLECHKG.Text = Math.Round(_kgchenhlech).ToString();
            }
            catch { }
        }
        private void txt_CHENHLECHKG_Validated(object sender, EventArgs e)
        {
            Tinhchenhlechkg();
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

        private void txt_MACONGNHAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCONGNHAN frm_Dm = new FRM_DMCONGNHAN();
                frm_Dm.Text = "Danh mục công nhân";
                frm_Dm.ShowDialog();
                DT_DMCONGNHAN = new DmcongnhanManager().SelectAllRDT();
            }
        }

        private void txt_MASANPHAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMHANG frm_Dm = new FRM_DMHANG();
                frm_Dm.Text = "Danh mục sản phẩm";
                frm_Dm.ShowDialog();
                DT_HANG = new DmhangManager().SelectAllRDT();
            }
        }
        #endregion
        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_TKKQTUA.ColumnAutoResize = true;
            else
                GRID_TKKQTUA.ColumnAutoResize = false;
        }

        private void FRM_TKKQTUA_FormClosing(object sender, FormClosingEventArgs e)
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
