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
        private DataTable DT_KQTHOI = new DataTable();
        private BindingSource BS_KQTHOI = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQTHOI = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQTHOICHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";
        private string MAMANG = "";

        private DataTable DT_DMMAY = new DataTable(), DT_LENHTHOI = new DataTable(), DT_DMMANG = new DataTable(), DT_NHANVIEN = new DataTable(), DT_DMKHACH = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQTHOI");
                        DT_KQTHOI = LIB.SESSION_START.DT_KQTHOI;

                        //DT_DMPHONGBAN = LIB.SESSION_START.DT_DMPHONGBAN;
                        DT_DMMAY = LIB.SESSION_START.DT_DMMAY;
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
            KetquathoiManager _KetquathoiManager = new KetquathoiManager();
            DataTable dt111 = LIB.Procedures.Danhsachketquathoi(Ngaydauthang, Ngaycuoithang, MAMANG);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOI.xml");
            dt111 = LIB.Procedures.Danhsachketquathoichitiet(MAHIEU_PK, MAMANG);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOICHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOI.xml", GRID_KQTHOI, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQTHOICHITIET.xml", GRID_KQTHOICHITIET, pne_CHITIET);
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
                        MAHIEU_PK = _Rowview.Row[KetquathoiFields.Id.Name].ToString();
                    txt_NGAY.Text = _Rowview.Row[KetquathoiFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquathoiFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquathoiFields.Mamay.Name].ToString();
                    txt_LENHTHOI.Text = _Rowview.Row[KetquathoiFields.Lenhthoi.Name].ToString();
                    txt_MAMANG.Text = _Rowview.Row[KetquathoiFields.Mamang.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquathoiFields.Macongnhan.Name].ToString();
                    txt_SOM.Text = _Rowview.Row[KetquathoiFields.Somet.Name].ToString();
                    txt_SOKG.Text = _Rowview.Row[KetquathoiFields.Sokg.Name].ToString();
                    txt_SOKGQUYDOI.Text = _Rowview.Row[KetquathoiFields.Sokgquydoi.Name].ToString();
                    txt_CHENHLECHKG.Text = _Rowview.Row[KetquathoiFields.Chenhlechkg.Name].ToString();
                    txt_CHATLUONG.Text = _Rowview.Row[KetquathoiFields.Chatluong.Name].ToString();
                    txt_PHELIEUTHUCTE.Text = _Rowview.Row[KetquathoiFields.Phelieuthucte.Name].ToString();
                    txt_TONGSP.Text = _Rowview.Row[KetquathoiFields.Tongsp.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquathoiFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquathoiFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquathoiFields.Thoigianchuanbi.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquathoiFields.Thoigiansuco.Name].ToString();
                    txt_SOKGDUKIEN.Text = _Rowview.Row[KetquathoiFields.Sokgdukiendat.Name].ToString();
                    txt_TENMAY.Text = _Rowview.Row[KetquathoiFields.Tenmay.Name].ToString();
                    txt_TENMANG.Text = _Rowview.Row[KetquathoiFields.Tenmang.Name].ToString();
                    txt_TENCONGNHAN.Text = _Rowview.Row[KetquathoiFields.Tencongnhan.Name].ToString();

                    txt_MAMAY_Validating(new object(), new CancelEventArgs());
                    txt_MAMANG_Validating(new object(), new CancelEventArgs());
                    txt_MACONGNHAN_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KQTHOI_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
            _KetquathoiEntity.Ngay = Convert.ToDateTime( txt_NGAY.Text.Trim());
            try {_KetquathoiEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim()); }
            catch { }
            _KetquathoiEntity.Mamay = txt_MAMAY.Text.Trim();
            _KetquathoiEntity.Lenhthoi = txt_LENHTHOI.Text.Trim();
            _KetquathoiEntity.Mamang = txt_MAMANG.Text.Trim();
            _KetquathoiEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
            _KetquathoiEntity.Somet = Convert.ToDecimal(txt_SOM.Text.Trim());
            _KetquathoiEntity.Sokg = Convert.ToDecimal(txt_SOKG.Text.Trim());
            _KetquathoiEntity.Sokgquydoi = Convert.ToDecimal(txt_SOKGQUYDOI.Text.Trim());
            _KetquathoiEntity.Chenhlechkg = Convert.ToDecimal(txt_CHENHLECHKG.Text.Trim());
            _KetquathoiEntity.Chatluong = txt_CHATLUONG.Text.Trim();
            _KetquathoiEntity.Phelieuthucte = Convert.ToDecimal(txt_PHELIEUTHUCTE.Text.Trim());
            _KetquathoiEntity.Tongsp = Convert.ToDecimal(txt_TONGSP.Text.Trim());
            _KetquathoiEntity.Thoigianbatdau = Convert.ToDateTime(txt_THOIGIANBATDAU.Text.Trim());
            _KetquathoiEntity.Thoigianketthuc = Convert.ToDateTime(txt_THOIGIANKETTHUC.Text.Trim());
            _KetquathoiEntity.Thoigianchuanbi = Convert.ToDecimal(txt_THOIGIANCHUANBI.Text.Trim());
            _KetquathoiEntity.Thoigiansuco = Convert.ToDecimal(txt_THOIGIANSUCO.Text.Trim());
            _KetquathoiEntity.Sokgdukiendat = Convert.ToDecimal(txt_SOKGDUKIEN.Text.Trim());
            _KetquathoiEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
            _KetquathoiEntity.Tenmay = txt_TENMAY.Text.Trim();
            _KetquathoiEntity.Tenmang = txt_TENMANG.Text.Trim();


            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _KetquathoiEntity.Ngaytao = DateTime.Now;
                _KetquathoiEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _KetquathoiManager.InsertV2(_KetquathoiEntity, r_Insert, DT_KQTHOI, BS_KQTHOI);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_KQTHOI.ResetCurrentItem();
            }
            else
            {
                _KetquathoiEntity.Ngaysua = DateTime.Now;
                _KetquathoiEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _KetquathoiManager.Update(_KetquathoiEntity);
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Ngay.Name].Value = _KetquathoiEntity.Ngay;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Ca.Name].Value = _KetquathoiEntity.Ca;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Mamay.Name].Value = _KetquathoiEntity.Mamay;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Lenhthoi.Name].Value = _KetquathoiEntity.Lenhthoi;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Mamang.Name].Value = _KetquathoiEntity.Mamang;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Macongnhan.Name].Value = _KetquathoiEntity.Macongnhan;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Somet.Name].Value = _KetquathoiEntity.Somet;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Sokg.Name].Value = _KetquathoiEntity.Sokg;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Sokgquydoi.Name].Value = _KetquathoiEntity.Sokgquydoi;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Chenhlechkg.Name].Value = _KetquathoiEntity.Chenhlechkg;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Chatluong.Name].Value = _KetquathoiEntity.Chatluong;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Phelieuthucte.Name].Value = _KetquathoiEntity.Phelieuthucte;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Tongsp.Name].Value = _KetquathoiEntity.Tongsp;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Thoigianbatdau.Name].Value = _KetquathoiEntity.Thoigianbatdau;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Thoigianketthuc.Name].Value = _KetquathoiEntity.Thoigianketthuc;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Thoigianchuanbi.Name].Value = _KetquathoiEntity.Thoigianchuanbi;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Thoigiansuco.Name].Value = _KetquathoiEntity.Thoigiansuco;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Sokgdukiendat.Name].Value = _KetquathoiEntity.Sokgdukiendat;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Tencongnhan.Name].Value = _KetquathoiEntity.Tencongnhan;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Tenmay.Name].Value = _KetquathoiEntity.Tenmay;
                GRID_KQTHOI.CurrentRow.Cells[KetquathoiFields.Tenmang.Name].Value = _KetquathoiEntity.Tenmang;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            KetquathoiManager _KetquathoiManager = new KetquathoiManager();
            KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
            r_Insert = DT_KQTHOI.NewRow();
            DT_KQTHOI.Rows.Add(r_Insert);
            BS_KQTHOI.Position = DT_KQTHOI.Rows.Count;
            MAHIEU_PK = "";
            txt_MAMAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENMANG, txt_TENMAY }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_KQTHOI.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {txt_TENCONGNHAN, txt_TENMANG, txt_TENMAY }));
                txt_LENHTHOI.Focus();
            }
            GRID_KQTHOI.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQTHOI.Rows.Remove(r_Insert);
            }
            BS_KQTHOI_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_KQTHOI.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            KetquathoiManager _KetquathoiManager = new KetquathoiManager();
            KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
            _KetquathoiEntity = _KetquathoiManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquathoiEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_LENHTHOI.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _KetquathoiManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_KQTHOI.CurrentRow.Delete();
                    BS_KQTHOI_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KQTHOI.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _KetquathoiManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
            //{
            //    MessageBox.Show("Mã công nhân bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_MAMAY.Focus();
            //    return;
            //}
            if (txt_MAMAY.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAMAY.Focus();
                return;
            }
            else if (txt_LENHTHOI.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_LENHTHOI.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_KQTHOI.Enabled = true;
                btn_THEMMOI.Focus();
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
                txt_MAMAY.Text = _RowViewSelect[DmmayFields.Mamay.Name].ToString();
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
                txt_MAMANG.Text = _RowViewSelect[DmmangFields.Mamang.Name].ToString();
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
                txt_MACONGNHAN.Text = _RowViewSelect[DmcongnhanFields.Macn.Name].ToString();
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
