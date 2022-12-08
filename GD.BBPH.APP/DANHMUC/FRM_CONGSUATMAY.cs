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

namespace GD.BBPH.APP.DANHMUC
{
    public partial class FRM_CONGSUATMAY : FRM_DMPARENT
    {
        private CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
        private CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_CONGSUATMAY = new DataTable();
        private BindingSource BS_CONGSUATMAY = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_CONGSUATMAY = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMMAY = new DataTable(), DT_DMDONGMAY = new DataTable(), DT_DMCONGDOAN = new DataTable()
            , DT_SOMAU = new DataTable(), DT_SOHINH = new DataTable()//, DT_CAUTRUCIN = new DataTable()
            , DT_LOAIMANG = new DataTable(), DT_QCTHANHPHAM = new DataTable(), DT_DMKHACH = new DataTable(), DT_DMHANG = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_CONGSUATMAY");
                        DT_CONGSUATMAY = new CongsuatmayManager().SelectAllRDT();
                        DT_DMMAY = new DmmayManager().SelectAllRDT();
                        DT_DMDONGMAY = new DmdongmayManager().SelectAllRDT();
                        DT_DMCONGDOAN =  new DmcongdoanManager().SelectAllRDT();

                        DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
                        DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
                        //DT_CAUTRUCIN = new DmquycachManager().SelectByManhomRDT("N02");
                        DT_LOAIMANG = new DmquycachManager().SelectByManhomRDT("N09");
                        DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
                        DT_DMKHACH = new DmkhachManager().SelectAllRDT();
                        DT_DMHANG = new DmhangManager().SelectAllRDT();
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

        public FRM_CONGSUATMAY()
        {
            InitializeComponent();
            CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
            DataTable dt111 = _CongsuatmayManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CONGSUATMAY.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SAOCHEP, btn_SAOCHEP.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CONGSUATMAY.xml", GRID_CONGSUATMAY, uiPanel0Container);
            //GRID_CONGSUATMAY.RootTable.SortKeys.Add(CongsuatmayFields.Sothutucongdoan.Name, Janus.Windows.GridEX.SortOrder.Ascending);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_CONGSUATMAY);
            BS_CONGSUATMAY = new BindingSource();
            BS_CONGSUATMAY.DataSource = Source_View;
            GRID_CONGSUATMAY.DataSource = BS_CONGSUATMAY;
            BS_CONGSUATMAY.CurrentChanged += new EventHandler(BS_CONGSUATMAY_CurrentChanged);
            BS_CONGSUATMAY_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_CONGSUATMAY_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_CONGSUATMAY.UpdateData();
                if (BS_CONGSUATMAY.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_CONGSUATMAY.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
                    txt_MACONGSUAT.Text = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
                    txt_TENCONGSUAT.Text = _Rowview.Row[CongsuatmayFields.Tencongsuat.Name].ToString();
                    txt_MAMAYS.Text = _Rowview.Row[CongsuatmayFields.Mamays.Name].ToString();
                    txt_MACONGDOANS.Text = _Rowview.Row[CongsuatmayFields.Macongdoans.Name].ToString();
                    txt_DODAYTU.Text = _Rowview.Row[CongsuatmayFields.Dodaytu.Name].ToString();
                    txt_DODAYDEN.Text = _Rowview.Row[CongsuatmayFields.Dodayden.Name].ToString();
                    txt_KHOTU.Text = _Rowview.Row[CongsuatmayFields.Khotu.Name].ToString();
                    txt_KHODEN.Text = _Rowview.Row[CongsuatmayFields.Khoden.Name].ToString();
                    txt_CHIEUDAITU.Text = _Rowview.Row[CongsuatmayFields.Chieudaitu.Name].ToString();
                    txt_CHIEUDAIDEN.Text = _Rowview.Row[CongsuatmayFields.Chieudaiden.Name].ToString();
                    txt_SOMAUMAS.Text = _Rowview.Row[CongsuatmayFields.Somaumas.Name].ToString();
                    txt_SOHINHMAS.Text = _Rowview.Row[CongsuatmayFields.Sohinhmas.Name].ToString();
                    txt_MALOAIMANGS1.Text = _Rowview.Row[CongsuatmayFields.Maloaimangs1.Name].ToString();
                    txt_MALOAIMANGS2.Text = _Rowview.Row[CongsuatmayFields.Maloaimangs2.Name].ToString();
                    txt_MAQCTHANHPHAMS.Text = _Rowview.Row[CongsuatmayFields.Maqcthanhphams.Name].ToString();
                    txt_TOCDO.Text = _Rowview.Row[CongsuatmayFields.Tocdo.Name].ToString();
                    txt_MAKHACHS.Text = _Rowview.Row[CongsuatmayFields.Makhachs.Name].ToString();
                    txt_MAHANGS.Text = _Rowview.Row[CongsuatmayFields.Mahangs.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CONGSUATMAY_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_CONGSUATMAY.NewRow();
            DT_CONGSUATMAY.Rows.Add(r_Insert);
            BS_CONGSUATMAY.Position = DT_CONGSUATMAY.Rows.Count;
            MAHIEU_PK = "";
            txt_MACONGSUAT.Text = LIB.Procedures.GetMadanhmuc(new CongsuatmayManager().SelectAllRDT(), CongsuatmayFields.Macongsuat.Name, "CS", 3);
            txt_MACONGSUAT.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_CONGSUATMAY.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = true;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MACONGSUAT }));
                txt_TENCONGSUAT.Focus();
            }
            GRID_CONGSUATMAY.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = true;
        }
        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
                CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
                r_Insert = DT_CONGSUATMAY.NewRow();
                DT_CONGSUATMAY.Rows.Add(r_Insert);
                DataRow[] drCopy = DT_CONGSUATMAY.Select(CongsuatmayFields.Macongsuat.Name + "= '" + MAHIEU_PK + "'");
                BS_CONGSUATMAY.Position = DT_CONGSUATMAY.Rows.Count;

                txt_MACONGSUAT.Text = drCopy[0][CongsuatmayFields.Macongsuat.Name].ToString();
                txt_TENCONGSUAT.Text = drCopy[0][CongsuatmayFields.Tencongsuat.Name].ToString();
                txt_MAMAYS.Text = drCopy[0][CongsuatmayFields.Mamays.Name].ToString();
                txt_MACONGDOANS.Text = drCopy[0][CongsuatmayFields.Macongdoans.Name].ToString();
                txt_DODAYTU.Text = drCopy[0][CongsuatmayFields.Dodaytu.Name].ToString();
                txt_DODAYDEN.Text = drCopy[0][CongsuatmayFields.Dodayden.Name].ToString();
                txt_KHOTU.Text = drCopy[0][CongsuatmayFields.Khotu.Name].ToString();
                txt_KHODEN.Text = drCopy[0][CongsuatmayFields.Khoden.Name].ToString();
                txt_CHIEUDAITU.Text = drCopy[0][CongsuatmayFields.Chieudaitu.Name].ToString();
                txt_CHIEUDAIDEN.Text = drCopy[0][CongsuatmayFields.Chieudaiden.Name].ToString();
                txt_SOMAUMAS.Text = drCopy[0][CongsuatmayFields.Somaumas.Name].ToString();
                txt_SOHINHMAS.Text = drCopy[0][CongsuatmayFields.Sohinhmas.Name].ToString();
                txt_MALOAIMANGS1.Text = drCopy[0][CongsuatmayFields.Maloaimangs1.Name].ToString();
                txt_MALOAIMANGS2.Text = drCopy[0][CongsuatmayFields.Maloaimangs2.Name].ToString();
                txt_MAQCTHANHPHAMS.Text = drCopy[0][CongsuatmayFields.Maqcthanhphams.Name].ToString();
                txt_TOCDO.Text = drCopy[0][CongsuatmayFields.Tocdo.Name].ToString();
                txt_MAKHACHS.Text = drCopy[0][CongsuatmayFields.Makhachs.Name].ToString();

                MAHIEU_PK = "";
                txt_MACONGSUAT.Text = LIB.Procedures.GetMadanhmuc(new CongsuatmayManager().SelectAllRDT(), CongsuatmayFields.Macongsuat.Name, "CS", 3);
                txt_MACONGSUAT.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_CONGSUATMAY.Enabled = false;
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = true;
            }
            catch { }
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_CONGSUATMAY.Rows.Remove(r_Insert);
            }
            BS_CONGSUATMAY_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_CONGSUATMAY.Enabled = true;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            CongsuatmayManager _CongsuatmayManager = new CongsuatmayManager();
            CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
            _CongsuatmayEntity = _CongsuatmayManager.SelectOne(MAHIEU_PK);
            if (_CongsuatmayEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENCONGSUAT.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _CongsuatmayManager.Delete(MAHIEU_PK);
                    GRID_CONGSUATMAY.CurrentRow.Delete();
                    BS_CONGSUATMAY_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_CONGSUATMAY.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _CongsuatmayManager.SelectOne(txt_MACONGSUAT.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công đoạn bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACONGSUAT.Focus();
                return;
            }
            else if (txt_MACONGSUAT.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACONGSUAT.Focus();
                return;
            }
            else if (txt_TENCONGSUAT.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENCONGSUAT.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_CONGSUATMAY.Enabled = true;
                btn_THEMMOI.Focus();
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();

            _CongsuatmayEntity.Macongsuat = txt_MACONGSUAT.Text.Trim();
            _CongsuatmayEntity.Tencongsuat = txt_TENCONGSUAT.Text.Trim();
            _CongsuatmayEntity.Mamays = txt_MAMAYS.Text.Trim();
            _CongsuatmayEntity.Macongdoans = txt_MACONGDOANS.Text.Trim();
            _CongsuatmayEntity.Khotu = LIB.ConvertString.NumbertoDB(txt_KHOTU.Text.Trim());
            _CongsuatmayEntity.Khoden = LIB.ConvertString.NumbertoDB(txt_KHODEN.Text.Trim());
            _CongsuatmayEntity.Chieudaitu = LIB.ConvertString.NumbertoDB(txt_CHIEUDAITU.Text.Trim());
            _CongsuatmayEntity.Chieudaiden = LIB.ConvertString.NumbertoDB(txt_CHIEUDAIDEN.Text.Trim());
            _CongsuatmayEntity.Dodaytu = LIB.ConvertString.NumbertoDB(txt_DODAYTU.Text.Trim());
            _CongsuatmayEntity.Dodayden = LIB.ConvertString.NumbertoDB(txt_DODAYDEN.Text.Trim());
            _CongsuatmayEntity.Somaumas = txt_SOMAUMAS.Text.Trim();
            _CongsuatmayEntity.Sohinhmas = txt_SOHINHMAS.Text.Trim();
            _CongsuatmayEntity.Maloaimangs1 = txt_MALOAIMANGS1.Text.Trim();
            _CongsuatmayEntity.Maloaimangs2 = txt_MALOAIMANGS2.Text.Trim();
            _CongsuatmayEntity.Maqcthanhphams = txt_MAQCTHANHPHAMS.Text.Trim();
            _CongsuatmayEntity.Tocdo = LIB.ConvertString.NumbertoDB(txt_TOCDO.Text.Trim());
            _CongsuatmayEntity.Makhachs = txt_MAKHACHS.Text.Trim();
            _CongsuatmayEntity.Mahangs = txt_MAHANGS.Text.Trim();

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _CongsuatmayEntity.Ngaytao = DateTime.Now;
                _CongsuatmayEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _CongsuatmayManager.InsertV2(_CongsuatmayEntity, r_Insert, DT_CONGSUATMAY, BS_CONGSUATMAY);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
                BS_CONGSUATMAY.ResetCurrentItem();
            }
            else
            {
                _CongsuatmayEntity.Ngaysua = DateTime.Now;
                _CongsuatmayEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _CongsuatmayManager.Update(_CongsuatmayEntity);
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongsuat.Name].Value = _CongsuatmayEntity.Macongsuat;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tencongsuat.Name].Value = _CongsuatmayEntity.Tencongsuat;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Mamays.Name].Value = _CongsuatmayEntity.Mamays;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongdoans.Name].Value = _CongsuatmayEntity.Macongdoans;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khotu.Name].Value = _CongsuatmayEntity.Khotu;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khoden.Name].Value = _CongsuatmayEntity.Khoden;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaitu.Name].Value = _CongsuatmayEntity.Chieudaitu;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaiden.Name].Value = _CongsuatmayEntity.Chieudaiden;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodaytu.Name].Value = _CongsuatmayEntity.Dodaytu;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodayden.Name].Value = _CongsuatmayEntity.Dodayden;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Somaumas.Name].Value = _CongsuatmayEntity.Somaumas;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Sohinhmas.Name].Value = _CongsuatmayEntity.Sohinhmas;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maloaimangs1.Name].Value = _CongsuatmayEntity.Maloaimangs1;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maloaimangs2.Name].Value = _CongsuatmayEntity.Maloaimangs2;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maqcthanhphams.Name].Value = _CongsuatmayEntity.Maqcthanhphams;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tocdo.Name].Value = _CongsuatmayEntity.Tocdo;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Makhachs.Name].Value = _CongsuatmayEntity.Makhachs;
                GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Mahangs.Name].Value = _CongsuatmayEntity.Mahangs;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  = btn_CHONLOAIMANG1.Enabled = btn_CHONLOAIMANG2.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
            }
            return _str_MAHIEU_PK;
        }

        #region Validate
        private void btn_CHONMAY_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAY_CHON.xml", DT_DMMAY, DmmayFields.Mamay.Name, txt_MAMAYS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmmayFields.Mamay.Name].ToString() + ",";

            txt_MAMAYS.Text = str;
        }

        private void btn_CHONCONGDOAN_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGDOAN_CHON.xml", DT_DMCONGDOAN, DmcongdoanFields.Macd.Name, txt_MACONGDOANS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmcongdoanFields.Macd.Name].ToString() + ",";

            txt_MACONGDOANS.Text = str;
        }

        private void btn_CHONSOMAU_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách số màu", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_SOMAU, DmquycachFields.Maquycach.Name, txt_SOMAUMAS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_SOMAUMAS.Text = str;
        }

        private void btn_CHONSOHINH_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách số hình", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_SOHINH, DmquycachFields.Maquycach.Name, txt_SOHINHMAS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_SOHINHMAS.Text = str;
        }

        private void btn_CHONKHACH_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH_CHON.xml", DT_DMKHACH, DmkhachFields.Makhach.Name, txt_MAKHACHS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmkhachFields.Makhach.Name].ToString() + ",";

            txt_MAKHACHS.Text = str;
        }

        private void btn_CHONSANPHAM_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG_CHON.xml", DT_DMHANG, DmhangFields.Masp.Name, txt_MAHANGS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmhangFields.Masp.Name].ToString() + ",";

            txt_MAHANGS.Text = str;
        }

        private void btn_CHONLOAIMANG1_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách loại màng", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_LOAIMANG, DmquycachFields.Maquycach.Name, txt_MALOAIMANGS1.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MALOAIMANGS1.Text = str;
        }

        private void btn_CHONLOAIMANG2_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách loại màng", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_LOAIMANG, DmquycachFields.Maquycach.Name, txt_MALOAIMANGS2.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MALOAIMANGS2.Text = str;
        }

        private void btn_CHONQCTHANHPHAM_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách quy cách thành phẩm", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_QCTHANHPHAM, DmquycachFields.Maquycach.Name, txt_MAQCTHANHPHAMS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MAQCTHANHPHAMS.Text = str;
        }

        #endregion

        #region Shortcut Key
        private void txt_MAMAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMAY frm_Dm = new FRM_DMMAY();
                frm_Dm.Text = "Danh sách máy";
                frm_Dm.ShowDialog();
                DT_DMMAY = new DmmayManager().SelectAllRDT();
            }
        }
        private void txt_MADONGMAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMDONGMAY frm_Dm = new FRM_DMDONGMAY();
                frm_Dm.Text = "Danh mục dòng máy";
                frm_Dm.ShowDialog();
                DT_DMDONGMAY = new DmdongmayManager().SelectAllRDT();
            }
        }
        private void txt_MACONGDOAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCONGDOAN frm_Dm = new FRM_DMCONGDOAN();
                frm_Dm.Text = "Danh mục công đoạn";
                frm_Dm.ShowDialog();
                DT_DMCONGDOAN = new DmcongdoanManager().SelectAllRDT();
            }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_CONGSUATMAY.ColumnAutoResize = true;
            else
                GRID_CONGSUATMAY.ColumnAutoResize = false;
        }

        private void FRM_CONGSUATMAY_FormClosing(object sender, FormClosingEventArgs e)
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
