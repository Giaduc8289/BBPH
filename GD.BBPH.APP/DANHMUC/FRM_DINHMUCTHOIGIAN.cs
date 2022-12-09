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
    public partial class FRM_DINHMUCTHOIGIAN : FRM_DMPARENT
    {
        private DinhmucthoigianManager _DinhmucthoigianManager = new DinhmucthoigianManager();
        private DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DINHMUCTHOIGIAN = new DataTable();
        private BindingSource BS_DINHMUCTHOIGIAN = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DINHMUCTHOIGIAN = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DINHMUCTHOIGIAN");
                        DT_DINHMUCTHOIGIAN = new DinhmucthoigianManager().SelectAllRDT();
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

        public FRM_DINHMUCTHOIGIAN()
        {
            InitializeComponent();
            //DataTable dt111 = new DinhmucthoigianManager().Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DINHMUCTHOIGIAN.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SAOCHEP, btn_SAOCHEP.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DINHMUCTHOIGIAN.xml", GRID_DINHMUCTHOIGIAN, uiPanel0Container);
            //GRID_DINHMUCTHOIGIAN.RootTable.SortKeys.Add(DinhmucthoigianFields.Sothutucongdoan.Name, Janus.Windows.GridEX.SortOrder.Ascending);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DINHMUCTHOIGIAN);
            BS_DINHMUCTHOIGIAN = new BindingSource();
            BS_DINHMUCTHOIGIAN.DataSource = Source_View;
            GRID_DINHMUCTHOIGIAN.DataSource = BS_DINHMUCTHOIGIAN;
            BS_DINHMUCTHOIGIAN.CurrentChanged += new EventHandler(BS_DINHMUCTHOIGIAN_CurrentChanged);
            BS_DINHMUCTHOIGIAN_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DINHMUCTHOIGIAN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DINHMUCTHOIGIAN.UpdateData();
                if (BS_DINHMUCTHOIGIAN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DINHMUCTHOIGIAN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DinhmucthoigianFields.Madinhmuc.Name].ToString();
                    txt_MADINHMUC.Text = _Rowview.Row[DinhmucthoigianFields.Madinhmuc.Name].ToString();
                    txt_TENDINHMUC.Text = _Rowview.Row[DinhmucthoigianFields.Tendinhmuc.Name].ToString();
                    txt_DODAYTU.Text = _Rowview.Row[DinhmucthoigianFields.Dodaytu.Name].ToString();
                    txt_DODAYDEN.Text = _Rowview.Row[DinhmucthoigianFields.Dodayden.Name].ToString();
                    txt_KHOTU.Text = _Rowview.Row[DinhmucthoigianFields.Khotu.Name].ToString();
                    txt_KHODEN.Text = _Rowview.Row[DinhmucthoigianFields.Khoden.Name].ToString();
                    txt_CHIEUDAITU.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaitu.Name].ToString();
                    txt_CHIEUDAIDEN.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaiden.Name].ToString();
                    txt_MAMAYS.Text = _Rowview.Row[DinhmucthoigianFields.Mamays.Name].ToString();
                    txt_MACONGDOANS.Text = _Rowview.Row[DinhmucthoigianFields.Macongdoans.Name].ToString();
                    txt_SOMAUMAS.Text = _Rowview.Row[DinhmucthoigianFields.Somaumas.Name].ToString();
                    txt_SOHINHMAS.Text = _Rowview.Row[DinhmucthoigianFields.Sohinhmas.Name].ToString();
                    txt_MALOAIMANGS.Text = _Rowview.Row[DinhmucthoigianFields.Maloaimangs.Name].ToString();
                    txt_MAQCTHANHPHAMS.Text = _Rowview.Row[DinhmucthoigianFields.Maqcthanhphams.Name].ToString();
                    txt_MAKHACHS.Text = _Rowview.Row[DinhmucthoigianFields.Makhachs.Name].ToString();
                    txt_MAHANGS.Text = _Rowview.Row[DinhmucthoigianFields.Mahangs.Name].ToString();
                    txt_DAUCA.Text = _Rowview.Row[DinhmucthoigianFields.Dauca.Name].ToString();
                    txt_CHUANBI.Text = _Rowview.Row[DinhmucthoigianFields.Chuanbi.Name].ToString();
                    txt_DAUCUON.Text = _Rowview.Row[DinhmucthoigianFields.Daucuon.Name].ToString();
                    txt_DOILENH.Text = _Rowview.Row[DinhmucthoigianFields.Doilenh.Name].ToString();
                    txt_LENCUON.Text = _Rowview.Row[DinhmucthoigianFields.Lencuon.Name].ToString();
                    txt_XUONGCUON.Text = _Rowview.Row[DinhmucthoigianFields.Xuongcuon.Name].ToString();
                    txt_THAYTHIETBI.Text = _Rowview.Row[DinhmucthoigianFields.Thaythietbi.Name].ToString();
                    txt_DUNGMAY.Text = _Rowview.Row[DinhmucthoigianFields.Dungmay.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DINHMUCTHOIGIAN_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_DINHMUCTHOIGIAN.NewRow();
            DT_DINHMUCTHOIGIAN.Rows.Add(r_Insert);
            BS_DINHMUCTHOIGIAN.Position = DT_DINHMUCTHOIGIAN.Rows.Count;
            MAHIEU_PK = "";
            txt_MADINHMUC.Text = LIB.Procedures.GetMadanhmuc(new DinhmucthoigianManager().SelectAllRDT(), DinhmucthoigianFields.Madinhmuc.Name, "DM", 3);
            txt_MADINHMUC.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DINHMUCTHOIGIAN.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = true;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MADINHMUC }));
                txt_TENDINHMUC.Focus();
            }
            GRID_DINHMUCTHOIGIAN.Enabled = false;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = true;
        }
        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                DinhmucthoigianManager _DinhmucthoigianManager = new DinhmucthoigianManager();
                DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
                r_Insert = DT_DINHMUCTHOIGIAN.NewRow();
                DT_DINHMUCTHOIGIAN.Rows.Add(r_Insert);
                DataRow[] drCopy = DT_DINHMUCTHOIGIAN.Select(DinhmucthoigianFields.Madinhmuc.Name + "= '" + MAHIEU_PK + "'");
                BS_DINHMUCTHOIGIAN.Position = DT_DINHMUCTHOIGIAN.Rows.Count;

                txt_MADINHMUC.Text = drCopy[0][DinhmucthoigianFields.Madinhmuc.Name].ToString();
                txt_TENDINHMUC.Text = drCopy[0][DinhmucthoigianFields.Tendinhmuc.Name].ToString();
                txt_DODAYTU.Text = drCopy[0][DinhmucthoigianFields.Dodaytu.Name].ToString();
                txt_DODAYDEN.Text = drCopy[0][DinhmucthoigianFields.Dodayden.Name].ToString();
                txt_KHOTU.Text = drCopy[0][DinhmucthoigianFields.Khotu.Name].ToString();
                txt_KHODEN.Text = drCopy[0][DinhmucthoigianFields.Khoden.Name].ToString();
                txt_CHIEUDAITU.Text = drCopy[0][DinhmucthoigianFields.Chieudaitu.Name].ToString();
                txt_CHIEUDAIDEN.Text = drCopy[0][DinhmucthoigianFields.Chieudaiden.Name].ToString();
                txt_MAMAYS.Text = drCopy[0][DinhmucthoigianFields.Mamays.Name].ToString();
                txt_MACONGDOANS.Text = drCopy[0][DinhmucthoigianFields.Macongdoans.Name].ToString();
                txt_SOMAUMAS.Text = drCopy[0][DinhmucthoigianFields.Somaumas.Name].ToString();
                txt_SOHINHMAS.Text = drCopy[0][DinhmucthoigianFields.Sohinhmas.Name].ToString();
                txt_MALOAIMANGS.Text = drCopy[0][DinhmucthoigianFields.Maloaimangs.Name].ToString();
                txt_MAQCTHANHPHAMS.Text = drCopy[0][DinhmucthoigianFields.Maqcthanhphams.Name].ToString();
                txt_MAKHACHS.Text = drCopy[0][DinhmucthoigianFields.Makhachs.Name].ToString();
                txt_DAUCA.Text = drCopy[0][DinhmucthoigianFields.Dauca.Name].ToString();
                txt_CHUANBI.Text = drCopy[0][DinhmucthoigianFields.Chuanbi.Name].ToString();
                txt_DAUCUON.Text = drCopy[0][DinhmucthoigianFields.Daucuon.Name].ToString();
                txt_DOILENH.Text = drCopy[0][DinhmucthoigianFields.Doilenh.Name].ToString();
                txt_LENCUON.Text = drCopy[0][DinhmucthoigianFields.Lencuon.Name].ToString();
                txt_XUONGCUON.Text = drCopy[0][DinhmucthoigianFields.Xuongcuon.Name].ToString();
                txt_THAYTHIETBI.Text = drCopy[0][DinhmucthoigianFields.Thaythietbi.Name].ToString();
                txt_DUNGMAY.Text = drCopy[0][DinhmucthoigianFields.Dungmay.Name].ToString();

                MAHIEU_PK = "";
                txt_MADINHMUC.Text = LIB.Procedures.GetMadanhmuc(new DinhmucthoigianManager().SelectAllRDT(), DinhmucthoigianFields.Madinhmuc.Name, "DM", 3);
                txt_MADINHMUC.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DINHMUCTHOIGIAN.Enabled = false;
                btn_CHONSOMAU.Enabled = btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = btn_CHONSOHINH.Enabled = true;
            }
            catch { }
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DINHMUCTHOIGIAN.Rows.Remove(r_Insert);
            }
            BS_DINHMUCTHOIGIAN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DINHMUCTHOIGIAN.Enabled = true;
            btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DinhmucthoigianManager _DinhmucthoigianManager = new DinhmucthoigianManager();
            DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
            _DinhmucthoigianEntity = _DinhmucthoigianManager.SelectOne(MAHIEU_PK);
            if (_DinhmucthoigianEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENDINHMUC.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DinhmucthoigianManager.Delete(MAHIEU_PK);
                    GRID_DINHMUCTHOIGIAN.CurrentRow.Delete();
                    BS_DINHMUCTHOIGIAN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DINHMUCTHOIGIAN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DinhmucthoigianManager.SelectOne(txt_MADINHMUC.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công đoạn bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADINHMUC.Focus();
                return;
            }
            else if (txt_MADINHMUC.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADINHMUC.Focus();
                return;
            }
            else if (txt_TENDINHMUC.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENDINHMUC.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DINHMUCTHOIGIAN.Enabled = true;
                btn_THEMMOI.Focus();
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();

            _DinhmucthoigianEntity.Madinhmuc = txt_MADINHMUC.Text.Trim();
            _DinhmucthoigianEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
            _DinhmucthoigianEntity.Khotu = LIB.ConvertString.NumbertoDB(txt_KHOTU.Text.Trim());
            _DinhmucthoigianEntity.Khoden = LIB.ConvertString.NumbertoDB(txt_KHODEN.Text.Trim());
            _DinhmucthoigianEntity.Chieudaitu = LIB.ConvertString.NumbertoDB(txt_CHIEUDAITU.Text.Trim());
            _DinhmucthoigianEntity.Chieudaiden = LIB.ConvertString.NumbertoDB(txt_CHIEUDAIDEN.Text.Trim());
            _DinhmucthoigianEntity.Dodaytu = LIB.ConvertString.NumbertoDB(txt_DODAYTU.Text.Trim());
            _DinhmucthoigianEntity.Dodayden = LIB.ConvertString.NumbertoDB(txt_DODAYDEN.Text.Trim());
            _DinhmucthoigianEntity.Mamays = txt_MAMAYS.Text.Trim();
            _DinhmucthoigianEntity.Macongdoans = txt_MACONGDOANS.Text.Trim();
            _DinhmucthoigianEntity.Somaumas = txt_SOMAUMAS.Text.Trim();
            _DinhmucthoigianEntity.Sohinhmas = txt_SOHINHMAS.Text.Trim();
            _DinhmucthoigianEntity.Maloaimangs = txt_MALOAIMANGS.Text.Trim();
            _DinhmucthoigianEntity.Maqcthanhphams = txt_MAQCTHANHPHAMS.Text.Trim();
            _DinhmucthoigianEntity.Makhachs = txt_MAKHACHS.Text.Trim();
            _DinhmucthoigianEntity.Mahangs = txt_MAHANGS.Text.Trim();
            try { _DinhmucthoigianEntity.Dauca = System.Decimal.Parse(txt_DAUCA.Text.Trim()); }
            catch { }
            try { _DinhmucthoigianEntity.Chuanbi = System.Decimal.Parse(txt_CHUANBI.Text.Trim()); }
            catch { }
            try { _DinhmucthoigianEntity.Daucuon = System.Decimal.Parse(txt_DAUCUON.Text.Trim()); }
            catch { }
            try { _DinhmucthoigianEntity.Doilenh = System.Decimal.Parse(txt_DOILENH.Text.Trim()); }
            catch { }
            try { _DinhmucthoigianEntity.Lencuon = System.Decimal.Parse(txt_LENCUON.Text.Trim()); }
            catch { }
            try { _DinhmucthoigianEntity.Xuongcuon = System.Decimal.Parse(txt_XUONGCUON.Text.Trim()); }
            catch { }
            try { _DinhmucthoigianEntity.Thaythietbi = System.Decimal.Parse(txt_THAYTHIETBI.Text.Trim()); }
            catch { }
            try { _DinhmucthoigianEntity.Dungmay = System.Decimal.Parse(txt_DUNGMAY.Text.Trim()); }
            catch { }

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DinhmucthoigianEntity.Ngaytao = DateTime.Now;
                _DinhmucthoigianEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DinhmucthoigianManager.InsertV2(_DinhmucthoigianEntity, r_Insert, DT_DINHMUCTHOIGIAN, BS_DINHMUCTHOIGIAN);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
                BS_DINHMUCTHOIGIAN.ResetCurrentItem();
            }
            else
            {
                _DinhmucthoigianEntity.Ngaysua = DateTime.Now;
                _DinhmucthoigianEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DinhmucthoigianManager.Update(_DinhmucthoigianEntity);
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madinhmuc.Name].Value = _DinhmucthoigianEntity.Madinhmuc;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Tendinhmuc.Name].Value = _DinhmucthoigianEntity.Tendinhmuc;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khotu.Name].Value = _DinhmucthoigianEntity.Khotu;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khoden.Name].Value = _DinhmucthoigianEntity.Khoden;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaitu.Name].Value = _DinhmucthoigianEntity.Chieudaitu;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaiden.Name].Value = _DinhmucthoigianEntity.Chieudaiden;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodaytu.Name].Value = _DinhmucthoigianEntity.Dodaytu;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodayden.Name].Value = _DinhmucthoigianEntity.Dodayden;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Mamays.Name].Value = _DinhmucthoigianEntity.Mamays;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Macongdoans.Name].Value = _DinhmucthoigianEntity.Macongdoans;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Somaumas.Name].Value = _DinhmucthoigianEntity.Somaumas;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Sohinhmas.Name].Value = _DinhmucthoigianEntity.Sohinhmas;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maloaimangs.Name].Value = _DinhmucthoigianEntity.Maloaimangs;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maqcthanhphams.Name].Value = _DinhmucthoigianEntity.Maqcthanhphams;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Makhachs.Name].Value = _DinhmucthoigianEntity.Makhachs;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Mahangs.Name].Value = _DinhmucthoigianEntity.Mahangs;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dauca.Name].Value = _DinhmucthoigianEntity.Dauca;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chuanbi.Name].Value = _DinhmucthoigianEntity.Chuanbi;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Daucuon.Name].Value = _DinhmucthoigianEntity.Daucuon;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Doilenh.Name].Value = _DinhmucthoigianEntity.Doilenh;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Lencuon.Name].Value = _DinhmucthoigianEntity.Lencuon;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Xuongcuon.Name].Value = _DinhmucthoigianEntity.Xuongcuon;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Thaythietbi.Name].Value = _DinhmucthoigianEntity.Thaythietbi;
                GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dungmay.Name].Value = _DinhmucthoigianEntity.Dungmay;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_CHONSOMAU.Enabled = btn_CHONSOHINH.Enabled  =btn_CHONLOAIMANG.Enabled = btn_CHONQCTHANHPHAM.Enabled = btn_CHONKHACH.Enabled = btn_CHONSANPHAM.Enabled = btn_CHONMAY.Enabled = btn_CHONCONGDOAN.Enabled = false;
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

        private void btn_CHONLOAIMANG_Click(object sender, EventArgs e)
        {
            ListviewJanusC _frm =
                new ListviewJanusC("Danh sách loại màng", LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH_CHON.xml", DT_LOAIMANG, DmquycachFields.Maquycach.Name, txt_MALOAIMANGS.Text);
            _frm.ShowDialog();
            if (_frm._RowsViewSelect == null) return;

            string str = string.Empty;
            foreach (DataRowView drv in _frm._RowsViewSelect)
                str += drv.Row[DmquycachFields.Maquycach.Name].ToString() + ",";

            txt_MALOAIMANGS.Text = str;
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
                GRID_DINHMUCTHOIGIAN.ColumnAutoResize = true;
            else
                GRID_DINHMUCTHOIGIAN.ColumnAutoResize = false;
        }

        private void FRM_DINHMUCTHOIGIAN_FormClosing(object sender, FormClosingEventArgs e)
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
