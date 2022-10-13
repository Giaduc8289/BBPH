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

namespace GD.BBPH.APP.IN
{
    public partial class FRM_KQIN : FRM_DMPARENT
    {
        private KetquainManager _KetquainManager = new KetquainManager();
        private KetquainEntity _KetquainEntity = new KetquainEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KQIN = new DataTable();
        private BindingSource BS_KQIN = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQIN = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQINCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";
        private string MASP = "";
        private DataTable DT_DMMAY = new DataTable(), DT_LENHIN = new DataTable(), DT_DMSP = new DataTable(), DT_NHANVIEN = new DataTable(), DT_DMKHACH = new DataTable();



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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQIN");
                        DT_KQIN = LIB.SESSION_START.DT_KQIN;
                        DT_DMMAY = LIB.SESSION_START.DT_DMMAY;
                        DT_DMSP = LIB.SESSION_START.DM_HANG;
                        DT_NHANVIEN = LIB.SESSION_START.DT_DMCONGNHAN;

                        //DT_DMPHONGBAN = LIB.SESSION_START.DT_DMPHONGBAN;
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

        public FRM_KQIN()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            KetquainManager _KetquainManager = new KetquainManager();
            DataTable dt111 = LIB.Procedures.Danhsachketquain(Ngaydauthang, Ngaycuoithang, MASP);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQIN.xml");
            dt111 = LIB.Procedures.Danhsachketquainchitiet(MAHIEU_PK, MASP);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQINCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQIN.xml", GRID_KQIN, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQINCHITIET.xml", GRID_KQINCHITIET, pne_CHITIET);
            //GRID_KQIN.RootTable.Groups.Add(GRID_KQIN.Tables[0].Columns[KetquainFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_KQIN);
            BS_KQIN = new BindingSource();
            BS_KQIN.DataSource = Source_View;
            GRID_KQIN.DataSource = BS_KQIN;
            BS_KQIN.CurrentChanged += new EventHandler(BS_KQIN_CurrentChanged);
            BS_KQIN_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_KQIN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_KQIN.UpdateData();
                if (BS_KQIN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQIN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KetquainFields.Id.Name].ToString();
                    txt_NGAY.Text = _Rowview.Row[KetquainFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquainFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquainFields.Mamay.Name].ToString();
                    txt_LENHIN.Text = _Rowview.Row[KetquainFields.Lenhin.Name].ToString();
                    txt_MASP.Text = _Rowview.Row[KetquainFields.Masanpham.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquainFields.Macongnhan.Name].ToString();
                    txt_SOMLSX.Text = _Rowview.Row[KetquainFields.SometLsx.Name].ToString();
                    txt_SOMCAP.Text = _Rowview.Row[KetquainFields.Sometcap.Name].ToString();
                    txt_SOKGCAP.Text = _Rowview.Row[KetquainFields.Sokgcap.Name].ToString();
                    txt_THUCTEIN.Text = _Rowview.Row[KetquainFields.Thuctein.Name].ToString();
                    txt_SOKGIN.Text = _Rowview.Row[KetquainFields.Sokgin.Name].ToString();
                    txt_SAIHONGTHUCTE.Text = _Rowview.Row[KetquainFields.Saihongthucte.Name].ToString();
                    txt_PHENCC.Text = _Rowview.Row[KetquainFields.PheNcc.Name].ToString();
                    txt_PHESX.Text = _Rowview.Row[KetquainFields.PheSx.Name].ToString();
                    txt_TONGM2DM.Text = _Rowview.Row[KetquainFields.Tongm2dm.Name].ToString();
                    txt_M2SAIHONGTT.Text = _Rowview.Row[KetquainFields.M2saihongtt.Name].ToString();
                    txt_TENMAY.Text = _Rowview.Row[KetquainFields.Tenmay.Name].ToString();
                    txt_TENSP.Text = _Rowview.Row[KetquainFields.Tensanpham.Name].ToString();
                    txt_TENCONGNHAN.Text = _Rowview.Row[KetquainFields.Tencongnhan.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquainFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquainFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquainFields.Thoigianchuanbi.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquainFields.Thoigiansuco.Name].ToString();

                    txt_MAMAY_Validating(new object(), new CancelEventArgs());
                    txt_MASP_Validating(new object(), new CancelEventArgs());
                    txt_MACONGNHAN_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KQIN_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            KetquainEntity _KetquainEntity = new KetquainEntity();
            _KetquainEntity.Ngay = Convert.ToDateTime( txt_NGAY.Text.Trim());
            try {_KetquainEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim()); }
            catch { }
            _KetquainEntity.Mamay = txt_MAMAY.Text.Trim();
            _KetquainEntity.Lenhin = txt_LENHIN.Text.Trim();
            _KetquainEntity.Masanpham = txt_MASP.Text.Trim();
            _KetquainEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
            _KetquainEntity.SometLsx = Convert.ToDecimal(txt_SOMLSX.Text.Trim());
            _KetquainEntity.Sometcap = Convert.ToDecimal(txt_SOMCAP.Text.Trim());
            _KetquainEntity.Sokgcap = Convert.ToDecimal(txt_SOKGCAP.Text.Trim());
            _KetquainEntity.Thuctein = Convert.ToDecimal(txt_THUCTEIN.Text.Trim());
            _KetquainEntity.Sokgin = Convert.ToDecimal(txt_SOKGIN.Text.Trim());
            _KetquainEntity.Saihongthucte = Convert.ToDecimal(txt_SAIHONGTHUCTE.Text.Trim());
            _KetquainEntity.Thoigianbatdau = Convert.ToDateTime(txt_THOIGIANBATDAU.Text.Trim());
            _KetquainEntity.Thoigianketthuc = Convert.ToDateTime(txt_THOIGIANKETTHUC.Text.Trim());
            _KetquainEntity.Thoigianchuanbi = Convert.ToDecimal(txt_THOIGIANCHUANBI.Text.Trim());
            _KetquainEntity.Thoigiansuco = Convert.ToDecimal(txt_THOIGIANSUCO.Text.Trim());
            _KetquainEntity.PheNcc = Convert.ToDecimal(txt_PHENCC.Text.Trim());
            _KetquainEntity.PheSx = Convert.ToDecimal(txt_PHESX.Text.Trim());
            _KetquainEntity.M2saihongtt = Convert.ToDecimal(txt_M2SAIHONGTT.Text.Trim());
            _KetquainEntity.Tongm2dm = Convert.ToDecimal(txt_TONGM2DM.Text.Trim());
            _KetquainEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
            _KetquainEntity.Tenmay = txt_TENMAY.Text.Trim();
            _KetquainEntity.Tensanpham = txt_TENSP.Text.Trim();


            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _KetquainEntity.Ngaytao = DateTime.Now;
                _KetquainEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _KetquainManager.InsertV2(_KetquainEntity, r_Insert, DT_KQIN, BS_KQIN);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_KQIN.ResetCurrentItem();
            }
            else
            {
                _KetquainEntity.Ngaysua = DateTime.Now;
                _KetquainEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _KetquainManager.Update(_KetquainEntity);
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Ngay.Name].Value = _KetquainEntity.Ngay;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Ca.Name].Value = _KetquainEntity.Ca;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Mamay.Name].Value = _KetquainEntity.Mamay;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Lenhin.Name].Value = _KetquainEntity.Lenhin;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Masanpham.Name].Value = _KetquainEntity.Masanpham;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Macongnhan.Name].Value = _KetquainEntity.Macongnhan;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.SometLsx.Name].Value = _KetquainEntity.SometLsx;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Sometcap.Name].Value = _KetquainEntity.Sometcap;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Sokgcap.Name].Value = _KetquainEntity.Sokgcap;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Thuctein.Name].Value = _KetquainEntity.Thuctein;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Sokgin.Name].Value = _KetquainEntity.Sokgin;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Saihongthucte.Name].Value = _KetquainEntity.Saihongthucte;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.PheNcc.Name].Value = _KetquainEntity.PheNcc;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Thoigianbatdau.Name].Value = _KetquainEntity.Thoigianbatdau;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Thoigianketthuc.Name].Value = _KetquainEntity.Thoigianketthuc;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Thoigianchuanbi.Name].Value = _KetquainEntity.Thoigianchuanbi;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Thoigiansuco.Name].Value = _KetquainEntity.Thoigiansuco;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.PheSx.Name].Value = _KetquainEntity.PheSx;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.M2saihongtt.Name].Value = _KetquainEntity.M2saihongtt;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Tongm2dm.Name].Value = _KetquainEntity.Tongm2dm;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Tencongnhan.Name].Value = _KetquainEntity.Tencongnhan;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Tenmay.Name].Value = _KetquainEntity.Tenmay;
                GRID_KQIN.CurrentRow.Cells[KetquainFields.Tensanpham.Name].Value = _KetquainEntity.Tensanpham;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            KetquainManager _KetquainManager = new KetquainManager();
            KetquainEntity _KetquainEntity = new KetquainEntity();
            r_Insert = DT_KQIN.NewRow();
            DT_KQIN.Rows.Add(r_Insert);
            BS_KQIN.Position = DT_KQIN.Rows.Count;
            MAHIEU_PK = "";
            txt_MAMAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSP, txt_TENMAY }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_KQIN.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] {txt_TENCONGNHAN, txt_TENSP, txt_TENMAY }));
                txt_LENHIN.Focus();
            }
            GRID_KQIN.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQIN.Rows.Remove(r_Insert);
            }
            BS_KQIN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_KQIN.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            KetquainManager _KetquainManager = new KetquainManager();
            KetquainEntity _KetquainEntity = new KetquainEntity();
            _KetquainEntity = _KetquainManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquainEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_LENHIN.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _KetquainManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_KQIN.CurrentRow.Delete();
                    BS_KQIN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KQIN.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(MAHIEU_PK) && _KetquainManager.SelectOne(txt_MAMAY.Text.Trim()) != null)
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
            else if (txt_LENHIN.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_LENHIN.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_KQIN.Enabled = true;
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


        private void txt_MASP_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MASP.Text.Trim()) || DT_DMSP == null || DT_DMSP.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MASP.Text.Trim().ToUpper();
            _RowViewSelect = checkmasp(Str_MASIEUTHI, DT_DMSP);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml",
                        DT_DMSP, DmhangFields.Masp.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MASP.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENSP.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();

            }
            else
            {
                txt_TENSP.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
            }
        }
        private DataRow checkmasp(string masieuthi, DataTable dt)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_KQIN.ColumnAutoResize = true;
            else
                GRID_KQIN.ColumnAutoResize = false;
        }

        private void FRM_KQIN_FormClosing(object sender, FormClosingEventArgs e)
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
