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
    public partial class FRM_DMHANG : FRM_DMPARENT
    {
        private DmhangManager _DmhangManager = new DmhangManager();
        private DmhangEntity _DmhangEntity = new DmhangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMHANGHOA = new DataTable();
        private BindingSource BS_DMHANGHOA = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMHANGHOA = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMKHACH = new DataTable(), DT_DMLOAI = new DataTable(),
            DT_DMMANH = new DataTable(), DT_DMSOI = new DataTable(), DT_DMDONGMAYIN = new DataTable(), DT_DMPE = new DataTable(),
            DT_QCGAP = new DataTable(), DT_QCMAYDAY = new DataTable(), DT_QCVIENMIENG = new DataTable(), DT_QCDONGKIEN = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMHANG");
                        DT_DMHANGHOA = LIB.SESSION_START.DM_HANG;

                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
                        //DT_DMLOAI = LIB.SESSION_START.DT_DMLOAI;
                        //DT_DMMANH = LIB.SESSION_START.DT_DMMANH;
                        //DT_DMSOI = LIB.SESSION_START.DT_DMSOI;
                        //DT_DMDONGMAYIN = LIB.SESSION_START.DT_DMDONGMAYIN;
                        //DT_QCGAP = LIB.SESSION_START.DT_QCGAP;
                        //DT_QCMAYDAY = LIB.SESSION_START.DT_QCMAYDAY;
                        //DT_QCVIENMIENG = LIB.SESSION_START.DT_QCVIENMIENG;
                        //DT_QCDONGKIEN = LIB.SESSION_START.DT_QCDONGKIEN;
                        //DT_DMPE = LIB.SESSION_START.DT_DMPE;
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

        private void LoadDanhMuc()
        {
            DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
            //    DT_DMLOAI = LIB.SESSION_START.DT_DMLOAI;
            //    DT_DMMANH = LIB.SESSION_START.DT_DMMANH;
            //    DT_DMSOI = LIB.SESSION_START.DT_DMSOI;
            //    DT_DMDONGMAYIN = LIB.SESSION_START.DT_DMDONGMAYIN;
            //    DT_QCGAP = LIB.SESSION_START.DT_QCGAP;
            //    DT_QCMAYDAY = LIB.SESSION_START.DT_QCMAYDAY;
            //    DT_QCVIENMIENG = LIB.SESSION_START.DT_QCVIENMIENG;
            //    DT_QCDONGKIEN = LIB.SESSION_START.DT_QCDONGKIEN;
            //    DT_DMPE = LIB.SESSION_START.DT_DMPE;
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //  ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }

        public FRM_DMHANG()
        {
            InitializeComponent();
            DmhangManager _DmhangManager = new DmhangManager();
            DataTable dt111 = _DmhangManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LAMMOI, btn_LAMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml", GRID_DMHANGHOA, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMHANGHOA);
            BS_DMHANGHOA = new BindingSource();
            BS_DMHANGHOA.DataSource = Source_View;
            GRID_DMHANGHOA.DataSource = BS_DMHANGHOA;
            BS_DMHANGHOA.CurrentChanged += new EventHandler(BS_DMHANGHOA_CurrentChanged);
            BS_DMHANGHOA_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMHANGHOA_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMHANGHOA.UpdateData();
                if (BS_DMHANGHOA.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMHANGHOA.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmhangFields.Masp.Name].ToString();

                    txt_MASP.Text = _Rowview.Row[DmhangFields.Masp.Name].ToString();
                    txt_TENSP.Text = _Rowview.Row[DmhangFields.Tensp.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[DmhangFields.Makhach.Name].ToString();
                    txt_TENKHACH.Text = _Rowview.Row[DmhangFields.Tenkhach.Name].ToString();
                    txt_KICHTHUOC.Text = _Rowview.Row[DmhangFields.Kichthuoc.Name].ToString();
                    txt_KHOILUONGMUC.Text = _Rowview.Row[DmhangFields.Khoiluongmuc.Name].ToString();
                    txt_SOHINH.Text = _Rowview.Row[DmhangFields.Sohinh.Name].ToString();
                    txt_CAUTRUCIN.Text = _Rowview.Row[DmhangFields.Cautrucin.Name].ToString();
                    txt_SOMAU.Text = _Rowview.Row[DmhangFields.Somau.Name].ToString();
                    txt_MALOAIMUC.Text = _Rowview.Row[DmhangFields.Loaimuc.Name].ToString();
                    txt_KICHTHUOCTRUC.Text = _Rowview.Row[DmhangFields.Kichthuoctruc.Name].ToString();
                    txt_VITRI.Text = _Rowview.Row[DmhangFields.Vitri.Name].ToString();
                    txt_MAQCDONGGOI.Text = _Rowview.Row[DmhangFields.Maqcdonggoi.Name].ToString();
                    txt_MAQCLOAITHUNG.Text = _Rowview.Row[DmhangFields.Maqcloaithung.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmhang_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmhangEntity _dmhangEntity = new DmhangEntity();

            _dmhangEntity.Masp = txt_MASP.Text.Trim();
            _dmhangEntity.Tensp = txt_TENSP.Text.Trim();
            _dmhangEntity.Makhach = txt_MAKHACH.Text.Trim();
            _dmhangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            _dmhangEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
            _dmhangEntity.Khoiluongmuc = Int32.Parse(txt_KHOILUONGMUC.Text.Trim());
            _dmhangEntity.Sohinh = Int32.Parse(txt_SOHINH.Text.Trim());
            _dmhangEntity.Cautrucin = txt_CAUTRUCIN.Text.Trim();
            _dmhangEntity.Somau = Int32.Parse(txt_SOMAU.Text.Trim());
            _dmhangEntity.Loaimuc = txt_MALOAIMUC.Text.Trim();
            _dmhangEntity.Kichthuoctruc = txt_KICHTHUOCTRUC.Text.Trim();
            _dmhangEntity.Vitri = txt_VITRI.Text.Trim();
            _dmhangEntity.Maqcdonggoi = txt_MAQCDONGGOI.Text.Trim();
            _dmhangEntity.Maqcloaithung = txt_MAQCLOAITHUNG.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _str_DMCHUONG_PK = _DmhangManager.InsertV2(_dmhangEntity, r_Insert, DT_DMHANGHOA, BS_DMHANGHOA);
                _dmhangEntity.Ngaytao = DateTime.Now;
                _dmhangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DmhangManager.InsertV2(_DmhangEntity, r_Insert, DT_DMHANGHOA, BS_DMHANGHOA);
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_dmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMHANGHOA.ResetCurrentItem();
            }
            else
            {
                _dmhangEntity.Ngaysua = DateTime.Now;
                _dmhangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmhangManager.Update(_dmhangEntity);

                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Masp.Name].Value = _dmhangEntity.Masp;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tensp.Name].Value = _dmhangEntity.Tensp;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Makhach.Name].Value = _dmhangEntity.Makhach;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Tenkhach.Name].Value = _dmhangEntity.Tenkhach;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Kichthuoc.Name].Value = _dmhangEntity.Kichthuoc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Khoiluongmuc.Name].Value = _dmhangEntity.Khoiluongmuc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Sohinh.Name].Value = _dmhangEntity.Sohinh;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Cautrucin.Name].Value = _dmhangEntity.Cautrucin;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Somau.Name].Value = _dmhangEntity.Somau;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Loaimuc.Name].Value = _dmhangEntity.Loaimuc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Kichthuoctruc.Name].Value = _dmhangEntity.Kichthuoctruc;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Vitri.Name].Value = _dmhangEntity.Vitri;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Maqcdonggoi.Name].Value = _dmhangEntity.Maqcdonggoi;
                GRID_DMHANGHOA.CurrentRow.Cells[DmhangFields.Maqcloaithung.Name].Value = _dmhangEntity.Maqcloaithung;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_dmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENKHACH.Text = string.Empty;
            DmhangManager _DmhangManager = new DmhangManager();
            DmhangEntity _DmhangEntity = new DmhangEntity();
            r_Insert = DT_DMHANGHOA.NewRow();
            DT_DMHANGHOA.Rows.Add(r_Insert);
            BS_DMHANGHOA.Position = DT_DMHANGHOA.Rows.Count;
            MAHIEU_PK = "";
            txt_MASP.Focus();
            TEXTBOX_Only_Control(false, null);
            //GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKHACH, txt_TENSP }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMHANGHOA.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MASP }));
                //txt_TENHIEU.Focus();
                //txt_MAKHO.Focus();

            }
            GRID_DMHANGHOA.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMHANGHOA.Rows.Remove(r_Insert);
            }
            BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMHANGHOA.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmhangManager _DmhangManager = new DmhangManager();
            DmhangEntity _DmhangEntity = new DmhangEntity();
            _DmhangEntity = _DmhangManager.SelectOne(MAHIEU_PK);
            if (_DmhangEntity != null && MessageBox.Show("Xóa hàng: " + MAHIEU_PK + " - " + txt_TENSP.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmhangManager.Delete(MAHIEU_PK);
                    GRID_DMHANGHOA.CurrentRow.Delete();
                    BS_DMHANGHOA_CurrentChanged(new object(), new EventArgs());
                    //GD.BBPH.LIB.TrayPopup.PoupStringMessage(GD.BBPH.APP.Properties.Resources.MessageTitle, GD.BBPH.APP.Properties.Resources.MessageContent_T);
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmhangManager.Convert(_DmhangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMHANGHOA.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmhangManager.SelectOne(txt_MASP.Text.Trim()) != null)
            {
                MessageBox.Show("Mã hàng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MASP.Focus();
                return;
            }
            else if (txt_MASP.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MASP.Focus();
                return;
            }
            else if (txt_TENSP.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENSP.Focus();
                return;
            }
            else if (txt_MAKHACH.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAKHACH.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMHANGHOA.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_SAOCHEP_Click(object sender, EventArgs e)
        {
            try
            {
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                DmhangManager _DmhangManager = new DmhangManager();
                DmhangEntity _DmhangEntity = new DmhangEntity();
                r_Insert = DT_DMHANGHOA.NewRow();
                DT_DMHANGHOA.Rows.Add(r_Insert);
                DataRow[] drCopy = DT_DMHANGHOA.Select(DmhangFields.Masp.Name + "= '" + MAHIEU_PK + "'");
                BS_DMHANGHOA.Position = DT_DMHANGHOA.Rows.Count;

                txt_MASP.Text = drCopy[0][DmhangFields.Masp.Name].ToString();
                txt_TENSP.Text = drCopy[0][DmhangFields.Tensp.Name].ToString();
                txt_MAKHACH.Text = drCopy[0][DmhangFields.Makhach.Name].ToString();
                txt_MAKHACH_Validating(new object(), new CancelEventArgs());

                txt_TENKHACH.Text = drCopy[0][DmhangFields.Tenkhach.Name].ToString();
                txt_KICHTHUOC.Text = drCopy[0][DmhangFields.Kichthuoc.Name].ToString();
                txt_KHOILUONGMUC.Text = drCopy[0][DmhangFields.Khoiluongmuc.Name].ToString();
                txt_SOHINH.Text = drCopy[0][DmhangFields.Sohinh.Name].ToString();
                txt_CAUTRUCIN.Text = drCopy[0][DmhangFields.Cautrucin.Name].ToString();
                txt_SOMAU.Text = drCopy[0][DmhangFields.Somau.Name].ToString();
                txt_MALOAIMUC.Text = drCopy[0][DmhangFields.Loaimuc.Name].ToString();
                txt_KICHTHUOCTRUC.Text = drCopy[0][DmhangFields.Kichthuoctruc.Name].ToString();
                txt_VITRI.Text = drCopy[0][DmhangFields.Vitri.Name].ToString();
                txt_MAQCDONGGOI.Text = drCopy[0][DmhangFields.Maqcdonggoi.Name].ToString();
                txt_MAQCLOAITHUNG.Text = drCopy[0][DmhangFields.Maqcloaithung.Name].ToString();
                //try
                //{
                //    txt_TLPHOI.Text = double.Parse(drCopy[0][DmhangFields.Trongluongphoi.Name].ToString()).ToString("#,###", new System.Globalization.CultureInfo("vi-VN"));
                //    txt_TLKHONGPE.Text = double.Parse(drCopy[0][DmhangFields.TrongluongkhongPe.Name].ToString()).ToString("#,###", new System.Globalization.CultureInfo("vi-VN"));
                //    txt_TONGTL.Text = double.Parse(drCopy[0][DmhangFields.Tongtrongluong.Name].ToString()).ToString("#,###", new System.Globalization.CultureInfo("vi-VN"));
                //    txt_CHIEUDAICAT.Text = double.Parse(drCopy[0][DmhangFields.Chieudaicat.Name].ToString()).ToString("#,###", new System.Globalization.CultureInfo("vi-VN"));
                //}
                //catch { }
                //txt_KTBAO.Text = drCopy[0][DmhangFields.Kichthuocbao.Name].ToString();
                //txt_KTCAT.Text = drCopy[0][DmhangFields.Kichthuoccat.Name].ToString();
                //txt_MAMANH.Text = drCopy[0][DmhangFields.Mamanh.Name].ToString();
                //txt_MAMANH_Validating(new object(), new CancelEventArgs());
                //txt_MASOI.Text = drCopy[0][DmhangFields.Masoi.Name].ToString();
                //txt_MASOI_Validating(new object(), new CancelEventArgs());
                //txt_DONGMAYIN.Text = drCopy[0][DmhangFields.Loaimayin.Name].ToString();
                //txt_DONGMAYIN_Validating(new object(), new CancelEventArgs());
                //txt_LOAICHIMAY.Text = drCopy[0][DmhangFields.Loaichimay.Name].ToString();
                //txt_MAPE.Text = drCopy[0][DmhangFields.LongHdpe.Name].ToString();
                //txt_KIEUGAP.Text = drCopy[0][DmhangFields.Kieugap.Name].ToString();
                //txt_KIEUMAYDAY.Text = drCopy[0][DmhangFields.Kieumayday.Name].ToString();
                //txt_KIEUVIENMIENG.Text = drCopy[0][DmhangFields.Kieuvienmieng.Name].ToString();
                //txt_KIEUDONGKIEN.Text = drCopy[0][DmhangFields.Kieudongkien.Name].ToString();

                //txt_KIEUGAP_Validating(new object(), new CancelEventArgs());
                //txt_KIEUMAYDAY_Validating(new object(), new CancelEventArgs());
                //txt_KIEUVIENMIENG_Validating(new object(), new CancelEventArgs());
                //txt_KIEUDONGKIEN_Validating(new object(), new CancelEventArgs());

                MAHIEU_PK = "";
                txt_MASP.Focus();
                //TEXTBOX_Only_Control(false, null);
                // txt_MAHIEU.Text = DmcapmaManager.GET_MA_INT(DmcapmaManager.LOAI_MA_HIEU, false, KTXPT.DATA);
                BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
                BBPH.BLL.MenuroleManager.set_Enable_controls(BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GRID_DMHANGHOA.Enabled = false;
            }
            catch { }
        }
        private void btn_LAMMOI_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        //#region Validate
        private void txt_MAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHACH.Text.Trim()) || DT_DMKHACH == null || DT_DMKHACH.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKhach(Str_MASIEUTHI, DT_DMKHACH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
                        DT_DMKHACH, DmkhachFields.Makhach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHACH.Text = _RowViewSelect[DmkhachFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
            }
            else
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
        }
        private DataRow checkmaKhach(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhachFields.Makhach.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        //private void txt_MALOAI_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_MALOAI.Text.Trim()) || DT_DMLOAI == null || DT_DMLOAI.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_MALOAI.Text.Trim().ToUpper();
        //    _RowViewSelect = checkmaLoai(Str_MASIEUTHI, DT_DMLOAI);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMLOAI.xml",
        //                DT_DMLOAI, DanhmucloaiFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_MALOAI.Text = _RowViewSelect[DanhmucloaiFields.Mahieu.Name].ToString();
        //        txt_LOAI.Text = _RowViewSelect[DanhmucloaiFields.Tenhieu.Name].ToString();
        //    }
        //    else
        //        txt_LOAI.Text = _RowViewSelect[DanhmucloaiFields.Tenhieu.Name].ToString();
        //}
        //private DataRow checkmaLoai(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DanhmucloaiFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_MAMANH_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_MAMANH.Text.Trim()) || DT_DMMANH == null || DT_DMMANH.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_MAMANH.Text.Trim().ToUpper();
        //    _RowViewSelect = checkmaManh(Str_MASIEUTHI, DT_DMMANH);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANH.xml",
        //                DT_DMMANH, DanhmucmanhFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_MAMANH.Text = _RowViewSelect[DanhmucmanhFields.Mahieu.Name].ToString();
        //        txt_TENMANH.Text = _RowViewSelect[DanhmucmanhFields.Tenhieu.Name].ToString();
        //        txt_MASOI.Text = _RowViewSelect[DanhmucmanhFields.Masoi.Name].ToString(); 
        //        txt_MASOI_Validating(new object(), new CancelEventArgs());
        //    }
        //    else
        //    {
        //        txt_TENMANH.Text = _RowViewSelect[DanhmucmanhFields.Tenhieu.Name].ToString();
        //        txt_MASOI.Text = _RowViewSelect[DanhmucmanhFields.Masoi.Name].ToString();
        //        txt_MASOI_Validating(new object(), new CancelEventArgs());
        //    }
        //}
        //private DataRow checkmaManh(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DanhmucmanhFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_MASOI_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_MASOI.Text.Trim()) || DT_DMSOI == null || DT_DMSOI.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_MASOI.Text.Trim().ToUpper();
        //    _RowViewSelect = checkmaSoi(Str_MASIEUTHI, DT_DMSOI);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMSOI.xml",
        //                DT_DMSOI, DanhmucsoiFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_MASOI.Text = _RowViewSelect[DanhmucsoiFields.Mahieu.Name].ToString();
        //        txt_TENSOI.Text = _RowViewSelect[DanhmucsoiFields.Tenhieu.Name].ToString();
        //    }
        //    else
        //        txt_TENSOI.Text = _RowViewSelect[DanhmucsoiFields.Tenhieu.Name].ToString();
        //}
        //private DataRow checkmaSoi(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DanhmucsoiFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_DONGMAYIN_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_DONGMAYIN.Text.Trim()) || DT_DMDONGMAYIN == null || DT_DMDONGMAYIN.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_DONGMAYIN.Text.Trim().ToUpper();
        //    _RowViewSelect = checkmaHinhthuc(Str_MASIEUTHI, DT_DMDONGMAYIN);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMDONGMAYIN.xml",
        //                DT_DMDONGMAYIN, DongmayinFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_DONGMAYIN.Text = _RowViewSelect[DongmayinFields.Mahieu.Name].ToString();
        //        txt_TENDONGMAYIN.Text = _RowViewSelect[DongmayinFields.Tenhieu.Name].ToString();
        //    }
        //    else
        //        txt_TENDONGMAYIN.Text = _RowViewSelect[DongmayinFields.Tenhieu.Name].ToString();
        //}
        //private DataRow checkmaHinhthuc(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DongmayinFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_KIEUGAP_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_KIEUGAP.Text.Trim()) || DT_QCGAP == null || DT_QCGAP.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_KIEUGAP.Text.Trim().ToUpper();
        //    _RowViewSelect = checkKieugap(Str_MASIEUTHI, DT_QCGAP);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_QCGAP.xml",
        //                DT_QCGAP, QuycachgapFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_KIEUGAP.Text = _RowViewSelect[QuycachgapFields.Mahieu.Name].ToString();
        //        txt_QCGAP.Text = _RowViewSelect[QuycachgapFields.Tenhieu.Name].ToString();
        //    }
        //    else
        //        txt_QCGAP.Text = _RowViewSelect[QuycachgapFields.Tenhieu.Name].ToString();
        //}

        //private DataRow checkKieugap(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(QuycachgapFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_KIEUMAYDAY_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_KIEUMAYDAY.Text.Trim()) || DT_QCMAYDAY == null || DT_QCMAYDAY.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_KIEUMAYDAY.Text.Trim().ToUpper();
        //    _RowViewSelect = checkKieumayday(Str_MASIEUTHI, DT_QCMAYDAY);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_QCMAYDAY.xml",
        //                DT_QCMAYDAY, QuycachmaydayFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_KIEUMAYDAY.Text = _RowViewSelect[QuycachmaydayFields.Mahieu.Name].ToString();
        //        txt_QCMAYDAY.Text = _RowViewSelect[QuycachmaydayFields.Tenhieu.Name].ToString();
        //    }
        //    else
        //        txt_QCMAYDAY.Text = _RowViewSelect[QuycachmaydayFields.Tenhieu.Name].ToString();
        //}
        //private DataRow checkKieumayday(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(QuycachmaydayFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_KIEUVIENMIENG_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_KIEUVIENMIENG.Text.Trim()) || DT_QCVIENMIENG == null || DT_QCVIENMIENG.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_KIEUVIENMIENG.Text.Trim().ToUpper();
        //    _RowViewSelect = checkKieuvienmieng(Str_MASIEUTHI, DT_QCVIENMIENG);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_QCVIENMIENG.xml",
        //                DT_QCVIENMIENG, QuycachvienmiengFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_KIEUVIENMIENG.Text = _RowViewSelect[QuycachvienmiengFields.Mahieu.Name].ToString();
        //        txt_QCVIENMIENG.Text = _RowViewSelect[QuycachvienmiengFields.Tenhieu.Name].ToString();
        //    }
        //    else
        //        txt_QCVIENMIENG.Text = _RowViewSelect[QuycachvienmiengFields.Tenhieu.Name].ToString();
        //}
        //private DataRow checkKieuvienmieng(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(QuycachvienmiengFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_KIEUDONGKIEN_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    if (string.IsNullOrEmpty(txt_KIEUDONGKIEN.Text.Trim()) || DT_QCDONGKIEN == null || DT_QCDONGKIEN.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_KIEUDONGKIEN.Text.Trim().ToUpper();
        //    _RowViewSelect = checkKieudongkien(Str_MASIEUTHI, DT_QCDONGKIEN);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_QCDONGKIEN.xml",
        //                DT_QCDONGKIEN, QuycachdongkienFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_KIEUDONGKIEN.Text = _RowViewSelect[QuycachdongkienFields.Mahieu.Name].ToString();
        //        txt_QCDONGKIEN.Text = _RowViewSelect[QuycachdongkienFields.Tenhieu.Name].ToString();
        //    }
        //    else
        //        txt_QCDONGKIEN.Text = _RowViewSelect[QuycachdongkienFields.Tenhieu.Name].ToString();
        //}
        //private DataRow checkKieudongkien(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(QuycachdongkienFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}

        //private void txt_MAPE_Validating(object sender, CancelEventArgs e)
        //{
        //    _RowViewSelect = null;
        //    txt_KTPE.Text = txt_TLPE.Text = string.Empty;
        //    if (string.IsNullOrEmpty(txt_MAPE.Text.Trim()) || DT_DMPE == null || DT_DMPE.Rows.Count == 0) return;
        //    string Str_MASIEUTHI = txt_MAPE.Text.Trim().ToUpper();
        //    _RowViewSelect = checkMaPE(Str_MASIEUTHI, DT_DMPE);
        //    if (_RowViewSelect == null)
        //    {
        //        ListviewJanus _frm_SingerRows_Select =
        //            new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMPE_TIM.xml",
        //                DT_DMPE, DanhmucpeFields.Mahieu.Name, Str_MASIEUTHI);
        //        _frm_SingerRows_Select.ShowDialog();
        //        if (_frm_SingerRows_Select._RowViewSelect == null) return;
        //        _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
        //        txt_MAPE.Text = _RowViewSelect[DanhmucpeFields.Mahieu.Name].ToString();
        //        txt_KTPE.Text = _RowViewSelect[DanhmucpeFields.Kichthuoc.Name].ToString();
        //        txt_TLPE.Text = _RowViewSelect[DanhmucpeFields.Trongluong.Name].ToString();
        //        txt_MALOAIPE.Text = _RowViewSelect[DanhmucpeFields.Maloaipe.Name].ToString();
        //    }
        //    else
        //    {
        //        txt_KTPE.Text = _RowViewSelect[DanhmucpeFields.Kichthuoc.Name].ToString();
        //        txt_TLPE.Text = _RowViewSelect[DanhmucpeFields.Trongluong.Name].ToString();
        //        txt_MALOAIPE.Text = _RowViewSelect[DanhmucpeFields.Maloaipe.Name].ToString();
        //    }
        //}
        //private DataRow checkMaPE(string masieuthi, DataTable dt)
        //{
        //    try
        //    {
        //        return dt.Select(DanhmucpeFields.Mahieu.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
        //    }
        //    catch { return null; }
        //}
        //#endregion

        //#region Shortcut Key
        //private void txt_MAKHACH_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMKHACH frm_Dm = new FRM_DMKHACH();
        //        frm_Dm.Text = "Danh mục khách hàng";
        //        frm_Dm.ShowDialog();
        //        DT_DMKHACH = new DanhmuckhachManager().SelectAllRDT();
        //    }
        //}
        //private void txt_MAMANH_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMMANH frm_Dm = new FRM_DMMANH();
        //        frm_Dm.Text = "Danh mục manh";
        //        frm_Dm.ShowDialog();
        //        DT_DMMANH = new DanhmucmanhManager().SelectAllRDT();
        //    }
        //}
        //private void txt_MASOI_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMSOI frm_Dm = new FRM_DMSOI();
        //        frm_Dm.Text = "Danh mục sợi";
        //        frm_Dm.ShowDialog();
        //        DT_DMSOI = new DanhmucsoiManager().SelectAllRDT();
        //    }
        //}
        //private void txt_DONGMAYIN_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMDONGMAYIN frm_Dm = new FRM_DMDONGMAYIN();
        //        frm_Dm.Text = "Danh mục dòng máy in";
        //        frm_Dm.ShowDialog();
        //        DT_DMDONGMAYIN = new DongmayinManager().SelectAllRDT();
        //    }
        //}

        //private void txt_KIEUGAP_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_QCGAP frm_Dm = new FRM_QCGAP();
        //        frm_Dm.Text = "Danh mục quy cách gấp";
        //        frm_Dm.ShowDialog();
        //        DT_QCGAP = new QuycachgapManager().SelectAllRDT();
        //    }
        //}

        //private void txt_KIEUVIENMIENG_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_QCVIENMIENG frm_Dm = new FRM_QCVIENMIENG();
        //        frm_Dm.Text = "Danh mục quy cách viền miệng";
        //        frm_Dm.ShowDialog();
        //        DT_QCVIENMIENG = new QuycachvienmiengManager().SelectAllRDT();
        //    }
        //}

        //private void txt_KIEUMAYDAY_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_QCMAYDAY frm_Dm = new FRM_QCMAYDAY();
        //        frm_Dm.Text = "Danh mục quy cách may đáy";
        //        frm_Dm.ShowDialog();
        //        DT_QCMAYDAY = new QuycachmaydayManager().SelectAllRDT();
        //    }
        //}

        //private void txt_KIEUDONGKIEN_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_QCDONGKIEN frm_Dm = new FRM_QCDONGKIEN();
        //        frm_Dm.Text = "Danh mục quy cách đóng kiện";
        //        frm_Dm.ShowDialog();
        //        DT_QCDONGKIEN = new QuycachdongkienManager().SelectAllRDT();
        //    }
        //}

        //private void txt_MALOAI_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMLOAI frm_Dm = new FRM_DMLOAI();
        //        frm_Dm.Text = "Danh mục loại";
        //        frm_Dm.ShowDialog();
        //        DT_DMLOAI = new DanhmucloaiManager().SelectAllRDT();
        //    }
        //}
        //private void txt_MAPE_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.F4)
        //    {
        //        FRM_DMPE frm_Dm = new FRM_DMPE();
        //        frm_Dm.Text = "Danh mục túi";
        //        frm_Dm.ShowDialog();
        //        DT_DMPE = new DanhmucpeManager().SelectAllRDT();
        //    }
        //}
        //#endregion

        private void FRM_DMHANG_FormClosing(object sender, FormClosingEventArgs e)
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
