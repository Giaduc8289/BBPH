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

namespace GD.BBPH.APP.GHEP
{
    public partial class FRM_KQGHEP : FRM_DMPARENT
    {
        private KetquaghepManager _KetquaghepManager = new KetquaghepManager();
        private KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KQGHEP = new DataTable(), DT_KQGHEP_CHITIET = new DataTable(), DT_KQGHEP_CHITIET_FILL = new DataTable();
        private BindingSource BS_KQGHEP = new BindingSource(), BS_KQGHEP_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQGHEP = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQGHEPCHITIET = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQGHEP");
                        DT_KQGHEP = LIB.Procedures.Danhsachketquaghep(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty); // LIB.SESSION_START.DT_KQGHEP;
                        DT_KQGHEP_CHITIET = LIB.SESSION_START.DT_KQGHEP;

                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("GH");// LIB.SESSION_START.DT_DMMAY;
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

        public FRM_KQGHEP()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            KetquaghepManager _KetquaghepManager = new KetquaghepManager();
            DataTable dt111 = LIB.Procedures.Danhsachketquaghep(Ngaydauthang, Ngaycuoithang, Convert.ToInt32(CA), MASP);
            GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQGHEP.xml");
            dt111 = LIB.Procedures.Danhsachketquaghepchitiet(MAHIEU_PK, Convert.ToInt32(CA), MASP);
            GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQGHEPCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQGHEP.xml", GRID_KQGHEP, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQGHEPCHITIET.xml", GRID_KQGHEPCHITIET, pne_CHITIET);
            //GRID_KQGHEP.RootTable.Groups.Add(GRID_KQGHEP.Tables[0].Columns[KetquaghepFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_KQGHEP);
            BS_KQGHEP = new BindingSource();
            BS_KQGHEP.DataSource = Source_View;
            GRID_KQGHEP.DataSource = BS_KQGHEP;
            BS_KQGHEP.CurrentChanged += new EventHandler(BS_KQGHEP_CurrentChanged);
            BS_KQGHEP_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_KQGHEP_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_KQGHEP.UpdateData();
                if (BS_KQGHEP.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQGHEP.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KetquaghepFields.Ngay.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquaghepFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquaghepFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquaghepFields.Mamay.Name].ToString();

                    //txt_TENKHO.Text = _Rowview.Row[KetquaghepFields.Tenkho.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KQGHEP_CurrentChanged"); }
        }

        void BS_KQGHEP_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_KQGHEP_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQGHEP_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[KetquaghepFields.Id.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquaghepFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquaghepFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquaghepFields.Mamay.Name].ToString();
                    txt_SOLSX.Text = _Rowview.Row[KetquaghepFields.Lenhghep.Name].ToString();
                    txt_MASANPHAM.Text = _Rowview.Row[KetquaghepFields.Masanpham.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquaghepFields.Macongnhan.Name].ToString();
                    txt_DAURATUA.Text = _Rowview.Row[KetquaghepFields.Dauratua.Name].ToString();
                    txt_MANGINMET.Text = _Rowview.Row[KetquaghepFields.ManginMet.Name].ToString();
                    txt_MANGINKG.Text = _Rowview.Row[KetquaghepFields.ManginKg.Name].ToString();
                    txt_MANGCAPMET.Text = _Rowview.Row[KetquaghepFields.MangcapMet.Name].ToString();
                    txt_MANGCAPKG.Text = _Rowview.Row[KetquaghepFields.MangcapKg.Name].ToString();
                    txt_SOLOPGHEP.Text = _Rowview.Row[KetquaghepFields.Solopghep.Name].ToString();
                    txt_THUCTEMET.Text = _Rowview.Row[KetquaghepFields.ThucteMet.Name].ToString();
                    txt_THUCTEKG.Text = _Rowview.Row[KetquaghepFields.ThucteKg.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquaghepFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquaghepFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquaghepFields.Thoigianchuanbi.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquaghepFields.Thoigiansuco.Name].ToString();
                    txt_THUCTEKEO.Text = _Rowview.Row[KetquaghepFields.Thuctekeo.Name].ToString();
                    txt_THUCTEDONGRAN.Text = _Rowview.Row[KetquaghepFields.Thuctedongran.Name].ToString();
                    txt_THUCTEDUNGMOI.Text = _Rowview.Row[KetquaghepFields.Thuctedungmoi.Name].ToString();
                    txt_PHEIN.Text = _Rowview.Row[KetquaghepFields.Phein.Name].ToString();
                    txt_PHEGHEP.Text = _Rowview.Row[KetquaghepFields.Pheghep.Name].ToString();
                    txt_PHENCC.Text = _Rowview.Row[KetquaghepFields.PheNcc.Name].ToString();
                    txt_PHESX.Text = _Rowview.Row[KetquaghepFields.PheSx.Name].ToString();
                    txt_PHENCC.Text = _Rowview.Row[KetquaghepFields.Phethoi.Name].ToString();
                    txt_PHEINTUI.Text = _Rowview.Row[KetquaghepFields.Pheintui.Name].ToString();
                    txt_PHEGHEPTUI.Text = _Rowview.Row[KetquaghepFields.Phegheptui.Name].ToString();
                    txt_PHETHOI_NCC.Text = _Rowview.Row[KetquaghepFields.PhethoiNcc.Name].ToString();
                    txt_PHESXTUI.Text = _Rowview.Row[KetquaghepFields.Phesxtui.Name].ToString();
                    //txt_NGAYTAO.Text = _Rowview.Row[KetquaghepFields.Ngaytao.Name].ToString();
                    //txt_NGUOITAO.Text = _Rowview.Row[KetquaghepFields.Nguoitao.Name].ToString();
                    //txt_NGAYSUA.Text = _Rowview.Row[KetquaghepFields.Ngaysua.Name].ToString();
                    //txt_NGUOISUA.Text = _Rowview.Row[KetquaghepFields.Nguoisua.Name].ToString();
                    txt_TENSANPHAM.Text = _Rowview.Row[KetquaghepFields.Tensanpham.Name].ToString();
                    txt_TENMAY.Text = _Rowview.Row[KetquaghepFields.Tenmay.Name].ToString();
                    txt_TENCONGNHAN.Text = _Rowview.Row[KetquaghepFields.Tencongnhan.Name].ToString();
                    txt_NANGSUAT.Text = _Rowview.Row[KetquaghepFields.Nangsuat.Name].ToString();


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
                DT_KQGHEP_CHITIET_FILL = new KetquaghepManager().Clone();
                BS_KQGHEP_CHITIET = new BindingSource(DT_KQGHEP_CHITIET_FILL, null);
                GRID_KQGHEPCHITIET.DataSource = BS_KQGHEP_CHITIET;
            }
            else
            {
                DT_KQGHEP_CHITIET_FILL = new KetquaghepManager().SelectByNgayCaMamayRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), Convert.ToInt32(txt_CA.Text.Trim()) ,txt_MAMAY.Text.Trim());

                DataView Source_View = new DataView(DT_KQGHEP_CHITIET_FILL);
                BS_KQGHEP_CHITIET = new BindingSource();
                BS_KQGHEP_CHITIET.DataSource = Source_View;
                GRID_KQGHEPCHITIET.DataSource = BS_KQGHEP_CHITIET;
            }
            BS_KQGHEP_CHITIET.CurrentChanged += new EventHandler(BS_KQGHEP_CHITIET_CurrentChanged);
            BS_KQGHEP_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_KQGHEP_CHITIET_FILL.NewRow();
            r_Detail[KetquaghepFields.Lenhghep.Name] = txt_SOLSX.Text;
            r_Detail[KetquaghepFields.Macongnhan.Name] = txt_MACONGNHAN.Text;
            r_Detail[KetquaghepFields.Tencongnhan.Name] = txt_TENCONGNHAN.Text;
            r_Detail[KetquaghepFields.Masanpham.Name] = txt_MASANPHAM.Text;
            r_Detail[KetquaghepFields.Tensanpham.Name] = txt_TENSANPHAM.Text;
            r_Detail[KetquaghepFields.Mamay.Name] = txt_MAMAY.Text;
            r_Detail[KetquaghepFields.Tenmay.Name] = txt_TENMAY.Text;
            try { r_Detail[KetquaghepFields.Ca.Name] = LIB.ConvertString.NumbertoDB(txt_CA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.ManginMet.Name] = LIB.ConvertString.NumbertoDB(txt_MANGINMET.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.MangcapMet.Name] = LIB.ConvertString.NumbertoDB(txt_MANGCAPMET.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.ThucteMet.Name] = LIB.ConvertString.NumbertoDB(txt_THUCTEMET.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.ManginKg.Name] = LIB.ConvertString.NumbertoDB(txt_MANGINKG.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.MangcapKg.Name] = LIB.ConvertString.NumbertoDB(txt_MANGCAPKG.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.ThucteKg.Name] = LIB.ConvertString.NumbertoDB(txt_THUCTEKG.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Solopghep.Name] = LIB.ConvertString.NumbertoDB(txt_SOLOPGHEP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Dauratua.Name] = LIB.ConvertString.NumbertoDB(txt_DAURATUA.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Thuctekeo.Name] = LIB.ConvertString.NumbertoDB(txt_THUCTEKEO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Thuctedongran.Name] = LIB.ConvertString.NumbertoDB(txt_THUCTEDONGRAN.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Thuctedungmoi.Name] = LIB.ConvertString.NumbertoDB(txt_THUCTEDUNGMOI.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Thoigiansuco.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Phein.Name] = LIB.ConvertString.NumbertoDB(txt_PHEIN.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Pheintui.Name] = LIB.ConvertString.NumbertoDB(txt_PHEINTUI.Text.Trim()); }
            catch { }

            try { r_Detail[KetquaghepFields.Pheghep.Name] = LIB.ConvertString.NumbertoDB(txt_PHEGHEP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Phegheptui.Name] = LIB.ConvertString.NumbertoDB(txt_PHEGHEPTUI.Text.Trim()); }
            catch { }

            try { r_Detail[KetquaghepFields.Phethoi.Name] = LIB.ConvertString.NumbertoDB(txt_PHENCC.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.PhethoiNcc.Name] = LIB.ConvertString.NumbertoDB(txt_PHETHOI_NCC.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.PheSx.Name] = LIB.ConvertString.NumbertoDB(txt_PHESX.Text.Trim()); }
            catch { }
            try { r_Detail[KetquaghepFields.Phesxtui.Name] = LIB.ConvertString.NumbertoDB(txt_PHESXTUI.Text.Trim()); }
            catch { }
            //r_Detail[KetquaghepFields.Chatluong.Name] = txt_CHATLUONG.Text;
            //r_Detail[KetquaghepFields.Phelieuthucte.Name] = txt_PHELIEUTHUCTE.Text;
            //r_Detail[KetquaghepFields.Tongsp.Name] = txt_TONGSP.Text;
            r_Detail[KetquaghepFields.Thoigianbatdau.Name] = txt_THOIGIANBATDAU.Text;
            r_Detail[KetquaghepFields.Thoigianketthuc.Name] = txt_THOIGIANKETTHUC.Text;
            r_Detail[KetquaghepFields.Thoigianchuanbi.Name] = txt_THOIGIANCHUANBI.Text;
            r_Detail[KetquaghepFields.Thoigiansuco.Name] = txt_THOIGIANSUCO.Text;
            //try { r_Detail[KetquaghepFields.Sokgdukiendat.Name] = LIB.ConvertString.NumbertoDB(txt_SOKGDUKIEN.Text.Trim()); }
            //catch { }

            DT_KQGHEP_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_KQGHEP_CHITIET_FILL);
            BS_KQGHEP_CHITIET = new BindingSource();
            BS_KQGHEP_CHITIET.DataSource = Source_View;
            GRID_KQGHEPCHITIET.DataSource = BS_KQGHEP_CHITIET;
            BS_KQGHEP_CHITIET.Position = DT_KQGHEP_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_KQGHEPCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[KetquaghepFields.Id.Name].ToString();
            string _MAMANG = _view[KetquaghepFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_KQGHEPCHITIET.CurrentRow.Delete();
            }
            else
            {
                KetquaghepManager _KetquaghepManager = new KetquaghepManager();
                KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity();
                try { _KetquaghepEntity = _KetquaghepManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_KetquaghepEntity != null && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _KetquaghepManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_KQGHEP_CHITIET_FILL.Select(KetquaghepFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_KQGHEP_CHITIET_FILL.Rows.Remove(drArr[0]);
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
                    BS_KQGHEP_CHITIET.ResetCurrentItem();
                    GRID_KQGHEPCHITIET.DataSource = BS_KQGHEP_CHITIET;
                }
                GRID_KQGHEPCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DateTime _ngayxuat = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _KetquaghepEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_KQGHEPCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity();
                //_KetquaghepEntity.Id = txt_ID.Text.Trim();
                _KetquaghepEntity.Ngay = _ngayxuat;
                _KetquaghepEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim());
                _KetquaghepEntity.Mamay = txt_MAMAY.Text.Trim();
                _KetquaghepEntity.Lenhghep = txt_SOLSX.Text.Trim();
                _KetquaghepEntity.Masanpham = txt_MASANPHAM.Text.Trim();
                _KetquaghepEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
                _KetquaghepEntity.Dauratua = Convert.ToDecimal(_view.Row[KetquaghepFields.Dauratua.Name].ToString());
                _KetquaghepEntity.ManginMet = Convert.ToDecimal(_view.Row[KetquaghepFields.ManginMet.Name].ToString());
                _KetquaghepEntity.ManginKg = Convert.ToDecimal(_view.Row[KetquaghepFields.ManginMet.Name].ToString());
                _KetquaghepEntity.MangcapMet = Convert.ToDecimal(_view.Row[KetquaghepFields.MangcapMet.Name].ToString());
                _KetquaghepEntity.MangcapKg = Convert.ToDecimal(_view.Row[KetquaghepFields.MangcapKg.Name].ToString());
                _KetquaghepEntity.Solopghep = Convert.ToInt32(_view.Row[KetquaghepFields.Solopghep.Name].ToString());
                _KetquaghepEntity.ThucteMet = Convert.ToDecimal(_view.Row[KetquaghepFields.ThucteMet.Name].ToString());
                _KetquaghepEntity.ThucteKg = Convert.ToDecimal(_view.Row[KetquaghepFields.ThucteKg.Name].ToString());
                _KetquaghepEntity.Thoigianbatdau = Convert.ToDateTime(_view.Row[KetquaghepFields.Thoigianbatdau.Name].ToString());
                _KetquaghepEntity.Thoigianketthuc = Convert.ToDateTime(_view.Row[KetquaghepFields.Thoigianketthuc.Name].ToString());
                _KetquaghepEntity.Thoigianchuanbi = Convert.ToDecimal(_view.Row[KetquaghepFields.Thoigianchuanbi.Name].ToString());
                _KetquaghepEntity.Thoigiansuco = Convert.ToDecimal(_view.Row[KetquaghepFields.Thoigiansuco.Name].ToString());
                _KetquaghepEntity.Thuctekeo = Convert.ToDecimal(_view.Row[KetquaghepFields.Thuctekeo.Name].ToString());
                _KetquaghepEntity.Thuctedongran = Convert.ToDecimal(_view.Row[KetquaghepFields.Thuctedongran.Name].ToString());
                _KetquaghepEntity.Thuctedungmoi = Convert.ToDecimal(_view.Row[KetquaghepFields.Thuctedungmoi.Name].ToString());
                _KetquaghepEntity.Phein = Convert.ToDecimal(_view.Row[KetquaghepFields.Phein.Name].ToString());
                _KetquaghepEntity.Pheghep = Convert.ToDecimal(_view.Row[KetquaghepFields.Pheghep.Name].ToString());
                _KetquaghepEntity.PheNcc = Convert.ToDecimal(_view.Row[KetquaghepFields.PheNcc.Name].ToString());
                _KetquaghepEntity.PheSx = Convert.ToDecimal(_view.Row[KetquaghepFields.PheSx.Name].ToString());
                _KetquaghepEntity.Phethoi = Convert.ToDecimal(_view.Row[KetquaghepFields.Phethoi.Name].ToString());
                _KetquaghepEntity.Pheintui = Convert.ToDecimal(_view.Row[KetquaghepFields.Pheintui.Name].ToString());
                _KetquaghepEntity.Phegheptui = Convert.ToDecimal(_view.Row[KetquaghepFields.Phegheptui.Name].ToString());
                _KetquaghepEntity.PhethoiNcc = Convert.ToDecimal(_view.Row[KetquaghepFields.PhethoiNcc.Name].ToString());
                _KetquaghepEntity.Phesxtui = Convert.ToDecimal(_view.Row[KetquaghepFields.Phesxtui.Name].ToString());
                //_KetquaghepEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
                //_KetquaghepEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
                //_KetquaghepEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
                //_KetquaghepEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
                _KetquaghepEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
                _KetquaghepEntity.Tenmay = txt_TENMAY.Text.Trim();
                _KetquaghepEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
                _KetquaghepEntity.Nangsuat = Convert.ToDecimal(_view.Row[KetquaghepFields.Nangsuat.Name].ToString());

                if (!string.IsNullOrEmpty(_KetquaghepEntity.Masanpham))
                    _KetquaghepEntityCol.Add(_KetquaghepEntity);
            }

            foreach (KetquaghepEntity _KetquaghepEntity in _KetquaghepEntityCol)
            {
                if (_KetquaghepEntity.IsNew)
                {
                    DataRow _r_Insert = DT_KQGHEP_CHITIET.NewRow();
                    DT_KQGHEP_CHITIET.Rows.Add(_r_Insert);
                    _KetquaghepManager.InsertV2(_KetquaghepEntity, _r_Insert, DT_KQGHEP_CHITIET, BS_KQGHEP_CHITIET);
                }
                else _KetquaghepManager.Update(_KetquaghepEntity);
            }

            _KetquaghepManager.Update(_KetquaghepEntity);

            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Id.Name].Value = _KetquaghepEntity.Id;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Ngay.Name].Value = _KetquaghepEntity.Ngay;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Ca.Name].Value = _KetquaghepEntity.Ca;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Mamay.Name].Value = _KetquaghepEntity.Mamay;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Lenhghep.Name].Value = _KetquaghepEntity.Lenhghep;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Masanpham.Name].Value = _KetquaghepEntity.Masanpham;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Macongnhan.Name].Value = _KetquaghepEntity.Macongnhan;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Dauratua.Name].Value = _KetquaghepEntity.Dauratua;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.ManginMet.Name].Value = _KetquaghepEntity.ManginMet;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.ManginKg.Name].Value = _KetquaghepEntity.ManginKg;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.MangcapMet.Name].Value = _KetquaghepEntity.MangcapMet;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.MangcapKg.Name].Value = _KetquaghepEntity.MangcapKg;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Solopghep.Name].Value = _KetquaghepEntity.Solopghep;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.ThucteMet.Name].Value = _KetquaghepEntity.ThucteMet;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.ThucteKg.Name].Value = _KetquaghepEntity.ThucteKg;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianbatdau.Name].Value = _KetquaghepEntity.Thoigianbatdau;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianketthuc.Name].Value = _KetquaghepEntity.Thoigianketthuc;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianchuanbi.Name].Value = _KetquaghepEntity.Thoigianchuanbi;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Thoigiansuco.Name].Value = _KetquaghepEntity.Thoigiansuco;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Thuctekeo.Name].Value = _KetquaghepEntity.Thuctekeo;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Thuctedongran.Name].Value = _KetquaghepEntity.Thuctedongran;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Thuctedungmoi.Name].Value = _KetquaghepEntity.Thuctedungmoi;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Phein.Name].Value = _KetquaghepEntity.Phein;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Pheghep.Name].Value = _KetquaghepEntity.Pheghep;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.PheNcc.Name].Value = _KetquaghepEntity.PheNcc;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.PheSx.Name].Value = _KetquaghepEntity.PheSx;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Phethoi.Name].Value = _KetquaghepEntity.Phethoi;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Pheintui.Name].Value = _KetquaghepEntity.Pheintui;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Phegheptui.Name].Value = _KetquaghepEntity.Phegheptui;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.PhethoiNcc.Name].Value = _KetquaghepEntity.PhethoiNcc;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Phesxtui.Name].Value = _KetquaghepEntity.Phesxtui;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Ngaytao.Name].Value = _KetquaghepEntity.Ngaytao;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Nguoitao.Name].Value = _KetquaghepEntity.Nguoitao;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Ngaysua.Name].Value = _KetquaghepEntity.Ngaysua;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Nguoisua.Name].Value = _KetquaghepEntity.Nguoisua;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Tensanpham.Name].Value = _KetquaghepEntity.Tensanpham;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Tenmay.Name].Value = _KetquaghepEntity.Tenmay;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Tencongnhan.Name].Value = _KetquaghepEntity.Tencongnhan;
            GRID_KQGHEP.CurrentRow.Cells[KetquaghepFields.Nangsuat.Name].Value = _KetquaghepEntity.Nangsuat;
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_KetquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            //}
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_NGAY.Text = txt_CA.Text = txt_MAMAY.Text = txt_TENMAY.Text = txt_SOLSX.Text = txt_MACONGNHAN.Text = txt_TENCONGNHAN.Text = txt_MASANPHAM.Text = txt_TENSANPHAM.Text = txt_MANGINMET.Text = txt_MANGINKG.Text = txt_MANGCAPMET.Text = txt_MANGCAPKG.Text = txt_THUCTEKEO.Text = txt_DAURATUA.Text = txt_THUCTEKG.Text = txt_THUCTEMET.Text = txt_THUCTEKEO.Text = txt_THUCTEDONGRAN.Text = txt_THUCTEDUNGMOI.Text =  txt_THOIGIANBATDAU.Text = txt_THOIGIANKETTHUC.Text = txt_THOIGIANCHUANBI.Text = txt_SOLOPGHEP.Text = txt_THOIGIANSUCO.Text = txt_PHEIN.Text = txt_PHEINTUI.Text = txt_PHEGHEP.Text = txt_PHEGHEPTUI.Text = txt_PHESXTUI.Text = txt_PHESX.Text = txt_PHENCC.Text = txt_PHETHOI_NCC.Text = txt_NANGSUAT.Text= string.Empty;
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            KetquaghepManager _KetquaghepManager = new KetquaghepManager();
            KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity();
            r_Insert = DT_KQGHEP.NewRow();
            DT_KQGHEP.Rows.Add(r_Insert);
            BS_KQGHEP.Position = DT_KQGHEP.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_KQGHEP.Enabled = false;

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
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSANPHAM, txt_TENMAY }));
            }
            GRID_KQGHEPCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_KQGHEPCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQGHEPCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQGHEPCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQGHEPCHITIET.Enabled = true;
            GRID_KQGHEP.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQGHEP.Rows.Remove(r_Insert);
            }
            BS_KQGHEP_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_KQGHEP.Enabled = true;
            GRID_KQGHEPCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQGHEPCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQGHEPCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            //_KetquaghepEntity = _KetquaghepManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquaghepEntity != null && MessageBox.Show("Xóa kết quả ghép: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_KQGHEPCHITIET.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[KetquaghepFields.Id.Name].ToString()))
                        {
                            try { _KetquaghepManager.Delete(Convert.ToInt64(_view[KetquaghepFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_KetquaghepManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    try { GRID_KQGHEP.CurrentRow.Delete(); }
                    catch { }
                    BS_KQGHEP_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_KetquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa kết quả ghép: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KQGHEP.Enabled = true;
            GRID_KQGHEPCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQGHEPCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQGHEPCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
                GRID_KQGHEP.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_KQGHEPCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQGHEPCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQGHEPCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

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

        #region  Text change
        private void Tinhnangsuat()
        {
            try
            {
                decimal _timerun = 0, _tocdo = 0, _somet = 0, _nangsuat = 0;
                _somet = LIB.ConvertString.NumbertoDB(txt_THUCTEMET.Text.Trim());
                _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MASANPHAM.Text);
                _timerun = Convert.ToDecimal((Convert.ToDateTime(txt_THOIGIANKETTHUC.Text) - Convert.ToDateTime(txt_THOIGIANBATDAU.Text)).TotalMinutes)
                    - LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim()) - LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
                _nangsuat = _somet / _tocdo / _timerun * 100;
                txt_NANGSUAT.Text = Math.Round(_nangsuat).ToString();
            }
            catch { }
        }
        private void txt_THOIGIAN_Validating(object sender, CancelEventArgs e)
        {
            Tinhnangsuat();
        }
        #endregion

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_KQGHEP.ColumnAutoResize = true;
            else
                GRID_KQGHEP.ColumnAutoResize = false;
        }

        private void FRM_KQGHEP_FormClosing(object sender, FormClosingEventArgs e)
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
