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

namespace GD.BBPH.APP.THOI
{
    public partial class FRM_KQTHOI : FRM_DMPARENT
    {
        private KetquathoiManager _KetquathoiManager = new KetquathoiManager();
        private KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KQTHOI = new DataTable(), DT_KQTHOI_CHITIET = new DataTable(), DT_KQTHOI_CHITIET_FILL = new DataTable();
        private BindingSource BS_KQTHOI = new BindingSource(), BS_KQTHOI_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQTHOI = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQTHOICHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET="";
        private string MAMANG = "", CA= "0";
        private bool ADDROW = false;

        private DataTable DT_DMMAY = new DataTable(), DT_LENHTHOI = new DataTable(), DT_DMMANG = new DataTable(), DT_NHANVIEN = new DataTable(), DT_DMKHACH = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQTHOI");
                        DT_KQTHOI = LIB.Procedures.Danhsachketquathoi(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty, string.Empty); // LIB.SESSION_START.DT_KQTHOI;
                        DT_KQTHOI_CHITIET = LIB.SESSION_START.DT_KQTHOI;

                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("TH");// LIB.SESSION_START.DT_DMMAY;
                        DT_DMMANG = LIB.SESSION_START.DT_DMMANG;
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

        public FRM_KQTHOI()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            //DataTable dt111 = LIB.Procedures.Danhsachketquathoi(Ngaydauthang, Ngaycuoithang, 0, string.Empty, string.Empty);
            ////GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOI.xml");
            //dt111 = new KetquathoiManager().Clone();
            ////GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOICHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOI.xml", GRID_KQTHOI, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOICHITIET.xml", GRID_KQTHOICHITIET, pne_CHITIET);
            GRID_KQTHOICHITIET.DeletingRecord += GRID_KQTHOICHITIET_DeletingRecord;
            //GRID_KQTHOI.RootTable.Groups.Add(GRID_KQTHOI.Tables[0].Columns[KetquathoiFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_KQTHOI);
            BS_KQTHOI = new BindingSource();
            BS_KQTHOI.DataSource = Source_View;
            GRID_KQTHOI.DataSource = BS_KQTHOI;
            BS_KQTHOI.CurrentChanged += new EventHandler(BS_KQTHOI_CurrentChanged);
            BS_KQTHOI_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        #region Load dữ liệu
        void BS_KQTHOI_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_KQTHOI.UpdateData();
                if (BS_KQTHOI.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQTHOI.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KetquathoiFields.Ngay.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquathoiFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquathoiFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquathoiFields.Mamay.Name].ToString();

                    //txt_TENKHO.Text = _Rowview.Row[KetquathoiFields.Tenkho.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KQTHOI_CurrentChanged"); }
        }
        void BS_KQTHOI_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GRID_KQTHOICHITIET.UpdateData();
                if (BS_KQTHOI_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQTHOI_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[KetquathoiFields.Id.Name].ToString();

                    txt_LENHTHOI.Text = _Rowview.Row[KetquathoiFields.Lenhthoi.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquathoiFields.Macongnhan.Name].ToString();
                    txt_TENCONGNHAN.Text = _Rowview.Row[KetquathoiFields.Tencongnhan.Name].ToString();
                    txt_MAMANG.Text = _Rowview.Row[KetquathoiFields.Mamang.Name].ToString();
                    txt_MAMANG_Validating(new object(), new CancelEventArgs());
                    txt_SOM.Text = _Rowview.Row[KetquathoiFields.Somet.Name].ToString();
                    txt_SOKG.Text = _Rowview.Row[KetquathoiFields.Sokg.Name].ToString();
                    txt_PHELIEUTHUCTE.Text = _Rowview.Row[KetquathoiFields.Phelieuthucte.Name].ToString();
                    //txt_SOKGQUYDOI.Text = _Rowview.Row[KetquathoiFields.Sokgquydoi.Name].ToString();
                    //txt_CHATLUONG.Text = _Rowview.Row[KetquathoiFields.Chenhlechkg.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquathoiFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquathoiFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquathoiFields.Thoigianchuanbi.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquathoiFields.Thoigiansuco.Name].ToString();
                    //txt_SOKGDUKIEN.Text = _Rowview.Row[KetquathoiFields.Sokgdukiendat.Name].ToString();
                    txt_MATRUONGCA.Text = _Rowview.Row[KetquathoiFields.Matruongca.Name].ToString();
                    txt_TENTRUONGCA.Text = _Rowview.Row[KetquathoiFields.Tentruongca.Name].ToString();
                    txt_TOCDODINHMUC.Text = _Rowview.Row[KetquathoiFields.Tocdodinhmuc.Name].ToString();
                    txt_LYDOSUCO.Text = _Rowview.Row[KetquathoiFields.Lydosuco.Name].ToString();

                    txt_CHATLUONG.Text = _Rowview.Row[KetquathoiFields.Chatluong.Name].ToString();
                    txt_NANGSUAT.Text = _Rowview.Row[KetquathoiFields.Nangsuat.Name].ToString();
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
                DT_KQTHOI_CHITIET_FILL = new KetquathoiManager().Clone();
                BS_KQTHOI_CHITIET = new BindingSource(DT_KQTHOI_CHITIET_FILL, null);
                GRID_KQTHOICHITIET.DataSource = BS_KQTHOI_CHITIET;
            }
            else
            {
                DT_KQTHOI_CHITIET_FILL = new KetquathoiManager().SelectByNgayCaMamayRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), Convert.ToInt32(txt_CA.Text.Trim()) ,txt_MAMAY.Text.Trim());

                DataView Source_View = new DataView(DT_KQTHOI_CHITIET_FILL);
                BS_KQTHOI_CHITIET = new BindingSource();
                BS_KQTHOI_CHITIET.DataSource = Source_View;
                GRID_KQTHOICHITIET.DataSource = BS_KQTHOI_CHITIET;
            }
            BS_KQTHOI_CHITIET.CurrentChanged += new EventHandler(BS_KQTHOI_CHITIET_CurrentChanged);
            BS_KQTHOI_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }
        #endregion

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            ADDROW = true;
            DataRow r_Detail = DT_KQTHOI_CHITIET_FILL.NewRow();
            r_Detail[KetquathoiFields.Lenhthoi.Name] = txt_LENHTHOI.Text;
            r_Detail[KetquathoiFields.Macongnhan.Name] = txt_MACONGNHAN.Text;
            r_Detail[KetquathoiFields.Tencongnhan.Name] = txt_TENCONGNHAN.Text;
            r_Detail[KetquathoiFields.Matruongca.Name] = txt_MATRUONGCA.Text;
            r_Detail[KetquathoiFields.Tentruongca.Name] = txt_TENTRUONGCA.Text;
            r_Detail[KetquathoiFields.Mamang.Name] = txt_MAMANG.Text;
            r_Detail[KetquathoiFields.Tenmang.Name] = txt_TENMANG.Text;
            r_Detail[KetquathoiFields.Somet.Name] = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim()); 
            r_Detail[KetquathoiFields.Sokg.Name] = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim()); 
            r_Detail[KetquathoiFields.Phelieuthucte.Name] = LIB.ConvertString.NumbertoDB(txt_PHELIEUTHUCTE.Text.Trim()); 
            r_Detail[KetquathoiFields.Thoigianbatdau.Name] = txt_THOIGIANBATDAU.Text;
            r_Detail[KetquathoiFields.Thoigianketthuc.Name] = txt_THOIGIANKETTHUC.Text;
            r_Detail[KetquathoiFields.Thoigianchuanbi.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim());
            r_Detail[KetquathoiFields.Thoigiansuco.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());

            r_Detail[KetquathoiFields.Chatluong.Name] = LIB.ConvertString.NumbertoDB(txt_CHATLUONG.Text.Trim()); 
            r_Detail[KetquathoiFields.Nangsuat.Name] = LIB.ConvertString.NumbertoDB(txt_NANGSUAT.Text.Trim());
            r_Detail[KetquathoiFields.Tocdodinhmuc.Name] = LIB.ConvertString.NumbertoDB(txt_TOCDODINHMUC.Text.Trim());
            r_Detail[KetquathoiFields.Lydosuco.Name] = txt_LYDOSUCO.Text.Trim();

            DT_KQTHOI_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_KQTHOI_CHITIET_FILL);
            BS_KQTHOI_CHITIET = new BindingSource();
            BS_KQTHOI_CHITIET.DataSource = Source_View;
            GRID_KQTHOICHITIET.DataSource = BS_KQTHOI_CHITIET;
            BS_KQTHOI_CHITIET.Position = DT_KQTHOI_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
            ADDROW = false;
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_KQTHOICHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[KetquathoiFields.Id.Name].ToString();
            string _MAMANG = _view[KetquathoiFields.Mamang.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_KQTHOICHITIET.CurrentRow.Delete();
            }
            else
            {
                KetquathoiManager _KetquathoiManager = new KetquathoiManager();
                KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
                try { _KetquathoiEntity = _KetquathoiManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_KetquathoiEntity != null && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _KetquathoiManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_KQTHOI_CHITIET_FILL.Select(KetquathoiFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_KQTHOI_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_KQTHOI_CHITIET.ResetCurrentItem();
                    GRID_KQTHOICHITIET.DataSource = BS_KQTHOI_CHITIET;
                }
                GRID_KQTHOICHITIET.Enabled = true;
            }
            //Tinhtong();
        }

        private void btn_SUADONG_Click(object sender, EventArgs e)
        {
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Lenhthoi.Name].Value = txt_LENHTHOI.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Macongnhan.Name].Value = txt_MACONGNHAN.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Tencongnhan.Name].Value = txt_TENCONGNHAN.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Matruongca.Name].Value = txt_MATRUONGCA.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Tentruongca.Name].Value = txt_TENTRUONGCA.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Mamang.Name].Value = txt_MAMANG.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Tenmang.Name].Value = txt_TENMANG.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Somet.Name].Value = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Sokg.Name].Value = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Phelieuthucte.Name].Value = LIB.ConvertString.NumbertoDB(txt_PHELIEUTHUCTE.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Thoigianbatdau.Name].Value = txt_THOIGIANBATDAU.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Thoigianketthuc.Name].Value = txt_THOIGIANKETTHUC.Text;
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Thoigianchuanbi.Name].Value = LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Thoigiansuco.Name].Value = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Chatluong.Name].Value = LIB.ConvertString.NumbertoDB(txt_CHATLUONG.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Nangsuat.Name].Value = LIB.ConvertString.NumbertoDB(txt_NANGSUAT.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Tocdodinhmuc.Name].Value = LIB.ConvertString.NumbertoDB(txt_TOCDODINHMUC.Text.Trim());
            GRID_KQTHOICHITIET.CurrentRow.Cells[KetquathoiFields.Lydosuco.Name].Value = txt_LYDOSUCO.Text.Trim();
        }

        private void GRID_KQTHOICHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }

        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngaysx = Convert.ToDateTime(txt_NGAY.Text.Trim());

            GRID_KQTHOICHITIET.UpdateData();
            EntityCollection _KetquathoiEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_KQTHOICHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
                _KetquathoiEntity.Ngay = _ngaysx;
                _KetquathoiEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim());
                _KetquathoiEntity.Mamay = txt_MAMAY.Text.Trim();
                _KetquathoiEntity.Tenmay = txt_TENMAY.Text.Trim();
                _KetquathoiEntity.Lenhthoi = _view.Row[KetquathoiFields.Lenhthoi.Name].ToString();
                _KetquathoiEntity.Macongnhan = _view.Row[KetquathoiFields.Macongnhan.Name].ToString();
                _KetquathoiEntity.Tencongnhan = _view.Row[KetquathoiFields.Tencongnhan.Name].ToString();
                _KetquathoiEntity.Mamang = _view.Row[KetquathoiFields.Mamang.Name].ToString();
                _KetquathoiEntity.Tenmang = _view.Row[KetquathoiFields.Tenmang.Name].ToString();
                _KetquathoiEntity.Somet = LIB.ConvertString.NumbertoDB(_view.Row[KetquathoiFields.Somet.Name].ToString());
                _KetquathoiEntity.Sokg = LIB.ConvertString.NumbertoDB(_view.Row[KetquathoiFields.Sokg.Name].ToString());
                _KetquathoiEntity.Phelieuthucte = LIB.ConvertString.NumbertoDB(_view.Row[KetquathoiFields.Phelieuthucte.Name].ToString());
                _KetquathoiEntity.Thoigianbatdau = Convert.ToDateTime(_view.Row[KetquathoiFields.Thoigianbatdau.Name].ToString());
                _KetquathoiEntity.Thoigianketthuc = Convert.ToDateTime(_view.Row[KetquathoiFields.Thoigianketthuc.Name].ToString());
                _KetquathoiEntity.Thoigianchuanbi = LIB.ConvertString.NumbertoDB(_view.Row[KetquathoiFields.Thoigianchuanbi.Name].ToString());
                _KetquathoiEntity.Thoigiansuco = LIB.ConvertString.NumbertoDB(_view.Row[KetquathoiFields.Thoigiansuco.Name].ToString());
                _KetquathoiEntity.Chatluong = LIB.ConvertString.NumbertoDB(_view.Row[KetquathoiFields.Chatluong.Name].ToString());
                _KetquathoiEntity.Nangsuat = LIB.ConvertString.NumbertoDB(_view.Row[KetquathoiFields.Nangsuat.Name].ToString());
                _KetquathoiEntity.Matruongca = _view.Row[KetquathoiFields.Matruongca.Name].ToString();
                _KetquathoiEntity.Tentruongca = _view.Row[KetquathoiFields.Tentruongca.Name].ToString();
                try { _KetquathoiEntity.Tocdodinhmuc = System.Decimal.Parse(_view.Row[KetquathoiFields.Tocdodinhmuc.Name].ToString()); }
                catch { }
                _KetquathoiEntity.Lydosuco = _view.Row[KetquathoiFields.Lydosuco.Name].ToString();

                try { _KetquathoiEntity.Id = Convert.ToInt64(_view[KetquathoiFields.Id.Name].ToString()); }
                catch { }

                _KetquathoiEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_KetquathoiEntity.IsNew)
                {
                    EntityCollection drDHCT = (new KetquathoiManager()).SelectById(_KetquathoiEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _KetquathoiEntity.Ngaysua = DateTime.Now;
                        _KetquathoiEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _KetquathoiEntity.IsNew = false;
                    }
                    else
                    {
                        _KetquathoiEntity.Ngaytao = DateTime.Now;
                        _KetquathoiEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }

                if (!string.IsNullOrEmpty(_KetquathoiEntity.Mamang))
                    _KetquathoiEntityCol.Add(_KetquathoiEntity);
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (KetquathoiEntity _KetquathoiEntity in _KetquathoiEntityCol)
            {
                if (_KetquathoiEntity.IsNew)
                {
                    DataRow _r_Insert = DT_KQTHOI_CHITIET.NewRow();
                    DT_KQTHOI_CHITIET.Rows.Add(_r_Insert);
                    _KetquathoiManager.InsertV2(_KetquathoiEntity, _r_Insert, DT_KQTHOI_CHITIET, BS_KQTHOI_CHITIET);
                }
                else _KetquathoiManager.Update(_KetquathoiEntity);
            }

            GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Ngay.Name].Value = _ngaysx;
            GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Ca.Name].Value = txt_CA.Text.Trim();
            GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Mamay.Name].Value = txt_MAMAY.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENMAY.Text = txt_TENCONGNHAN.Text = txt_TENMANG.Text = txt_MATRUONGCA.Text = txt_TENTRUONGCA.Text = string.Empty;
            r_Insert = DT_KQTHOI.NewRow();
            DT_KQTHOI.Rows.Add(r_Insert);
            BS_KQTHOI.Position = DT_KQTHOI.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENMANG, txt_TENMAY, txt_CHATLUONG, txt_NANGSUAT, txt_MATRUONGCA, txt_TENTRUONGCA, txt_TOCDODINHMUC }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = true;
            GRID_KQTHOI.Enabled = false;

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
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {txt_TENCONGNHAN, txt_TENMANG, txt_TENMAY, txt_CHATLUONG, txt_NANGSUAT, txt_MATRUONGCA, txt_TENTRUONGCA, txt_TOCDODINHMUC }));
            }
            GRID_KQTHOICHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_KQTHOICHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQTHOICHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQTHOICHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQTHOICHITIET.Enabled = true;
            GRID_KQTHOI.Enabled = false;
            btn_XOADONG.Enabled = btn_SUADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQTHOI.Rows.Remove(r_Insert);
            }
            BS_KQTHOI_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL;
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_KQTHOI.Enabled = true;
            GRID_KQTHOICHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQTHOICHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQTHOICHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            //_KetquathoiEntity = _KetquathoiManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquathoiEntity != null && MessageBox.Show("Xóa kết quả thổi: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_KQTHOICHITIET.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[KetquathoiFields.Id.Name].ToString()))
                        {
                            try { _KetquathoiManager.Delete(Convert.ToInt64(_view[KetquathoiFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_KetquathoiManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    try { GRID_KQTHOI.CurrentRow.Delete(); }
                    catch { }
                    BS_KQTHOI_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = btn_SUADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa kết quả thổi: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KQTHOI.Enabled = true;
            GRID_KQTHOICHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQTHOICHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQTHOICHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
                GRID_KQTHOI.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_KQTHOICHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQTHOICHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQTHOICHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
                FUNCTION = GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD;
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
            {
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
        }

        private void txt_MAMANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMANG.Text.Trim()) || DT_DMMANG == null || DT_DMMANG.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAMANG.Text.Trim().ToUpper();
            _RowViewSelect = new DmmangManager().CheckMa(_str_MACANTIM, DT_DMMANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml",
                        DT_DMMANG, DmmangFields.Mamang.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMANG.Text = _RowViewSelect[DmmangFields.Mamang.Name].ToString();
                txt_TENMANG.Text = _RowViewSelect[DmmangFields.Tenmang.Name].ToString();
                Tinhtocdodinhmuc();
            }
            else
            {
                txt_TENMANG.Text = _RowViewSelect[DmmangFields.Tenmang.Name].ToString();
                Tinhtocdodinhmuc();
            }
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
                if(drv.Row[DmcongnhanFields.Macv.Name].ToString()=="TC")
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

        #region Tính năng suất và chất lượng
        private void Tinhnangsuat()
        {
            try
            {
                decimal _timerun = 0, _tocdo = 0, _sokg = 0, _nangsuat = 0;
                _sokg = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim());
                _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MAMANG.Text);
                _timerun = Convert.ToDecimal((Convert.ToDateTime(txt_THOIGIANKETTHUC.Text) - Convert.ToDateTime(txt_THOIGIANBATDAU.Text)).TotalMinutes)
                    - LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim()) - LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
                _nangsuat = (_sokg / ((_tocdo/60) * _timerun)) * 100;
                txt_NANGSUAT.Text = Math.Round(_nangsuat).ToString();
            }
            catch { }
        }
        private void Tinhchatluong()
        {
            try
            {
                decimal _doday = 0, _rong = 0, _sokg = 0, _somet = 0, _sokgtieuchuan = 0, _chatluong = 0;
                _sokg = LIB.ConvertString.NumbertoDB(txt_SOKG.Text.Trim());
                _somet = LIB.ConvertString.NumbertoDB(txt_SOM.Text.Trim());
                DmmangEntity _DmmangEntity = new DmmangManager().SelectOne(txt_MAMANG.Text);
                _doday = Convert.ToDecimal(_DmmangEntity.Doday);
                _rong = Convert.ToDecimal(_DmmangEntity.Rong);
                _sokgtieuchuan = _doday * _rong * _somet * Convert.ToDecimal(0.925) / 1000000;
                _chatluong = (_sokg - _sokgtieuchuan) / _sokgtieuchuan * 100;
                txt_CHATLUONG.Text = Math.Round(_chatluong).ToString();
            }
            catch { }
        }
        private void txt_NANGSUAT_CHATLUONG_Validated(object sender, EventArgs e)
        {
            Tinhnangsuat();
            Tinhchatluong();
        }
        private void Tinhtocdodinhmuc()
        {
            try
            {
                decimal _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MAMANG.Text);
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
                    decimal _thoigiancb = LIB.Procedures.fTinhdinhmucthoigian(txt_MAMAY.Text, txt_MAMANG.Text, DinhmucthoigianFields.Chuanbi.Name);
                    txt_THOIGIANCHUANBI.Text = Math.Round(_thoigiancb).ToString();
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

        private void txt_MANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMANG frm_Dm = new FRM_DMMANG();
                frm_Dm.Text = "Danh mục màng";
                frm_Dm.ShowDialog();
                DT_DMMANG = new DmmangManager().SelectAllRDT();
            }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_KQTHOI.ColumnAutoResize = true;
            else
                GRID_KQTHOI.ColumnAutoResize = false;
        }

        private void FRM_KQTHOI_FormClosing(object sender, FormClosingEventArgs e)
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
