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
    public partial class FRM_DMMANG : FRM_DMPARENT
    {
        private DmmangManager _DmmangManager = new DmmangManager();
        private DmmangEntity _DmmangEntity = new DmmangEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMMANG = new DataTable();
        private BindingSource BS_DMMANG = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMMANG = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMKHACH = new DataTable(), DT_CTPT = new DataTable(), DT_QCMANG= new DataTable(), DT_LOAIMANG = new DataTable() ;
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMMANG");
                        DT_DMMANG = LIB.SESSION_START.DT_DMMANG;

                        DT_DMKHACH = LIB.SESSION_START.DT_DMKHACH;
                        DT_CTPT = LIB.Procedures.Danhsachctpt();
                        DT_QCMANG = new DmquycachManager().SelectByManhomRDT("N10");
                        DT_LOAIMANG = new DmquycachManager().SelectByManhomRDT("N09");
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
            DT_CTPT = LIB.Procedures.Danhsachctpt();
            DT_QCMANG = new DmquycachManager().SelectByManhomRDT("N10");
            DT_LOAIMANG = new DmquycachManager().SelectByManhomRDT("N09");
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //  ErrorTrapper.ErrorHandler.HandleError(e.Exception);
        }

        public FRM_DMMANG()
        {
            InitializeComponent();
            DmmangManager _DmmangManager = new DmmangManager();
            DataTable dt111 = _DmmangManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMANG.xml", GRID_DMMANG, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMMANG);
            BS_DMMANG = new BindingSource();
            BS_DMMANG.DataSource = Source_View;
            GRID_DMMANG.DataSource = BS_DMMANG;
            BS_DMMANG.CurrentChanged += new EventHandler(BS_DMMANG_CurrentChanged);
            BS_DMMANG_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMMANG_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMMANG.UpdateData();
                if (BS_DMMANG.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMMANG.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmmangFields.Mamang.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmmangFields.Tenmang.Name].ToString();
                    txt_MAKHACH.Text = _Rowview.Row[DmmangFields.Makhach.Name].ToString();
                    txt_KICHTHUOC.Text = _Rowview.Row[DmmangFields.Kichthuoc.Name].ToString();
                    txt_TRONGLUONG.Text = _Rowview.Row[DmmangFields.Trongluong.Name].ToString();
                    txt_MACTPT.Text = _Rowview.Row[DmmangFields.Mactpt.Name].ToString();
                    txt_DODAY.Text = _Rowview.Row[DmmangFields.Doday.Name].ToString();
                    txt_RONG.Text = _Rowview.Row[DmmangFields.Rong.Name].ToString();
                    txt_MALOAIMANG.Text = _Rowview.Row[DmmangFields.Maloaimang.Name].ToString();
                    txt_MAQUYCACHMANG.Text = _Rowview.Row[DmmangFields.Maqcmang.Name].ToString();

                    txt_MAKHACH_Validating(new object(), new CancelEventArgs());
                    txt_MACTPT_Validating(new object(), new CancelEventArgs());
                    txt_MALOAIMANG_Validating(new object(), new CancelEventArgs());
                    txt_MAQUYCACHMANG_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMMANG_CurrentChanged"); }
        }

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DmmangEntity _DmmangEntity = new DmmangEntity();
            _DmmangEntity.Mamang = txt_MAHIEU.Text.Trim();
            _DmmangEntity.Tenmang = txt_TENHIEU.Text.Trim();
            _DmmangEntity.Makhach = txt_MAKHACH.Text.Trim();
            _DmmangEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            _DmmangEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
            _DmmangEntity.Trongluong = LIB.ConvertString.NumbertoDB(txt_TRONGLUONG.Text.Trim());
            _DmmangEntity.Mactpt = txt_MACTPT.Text.Trim();
            _DmmangEntity.Doday = LIB.ConvertString.NumbertoDB(txt_DODAY.Text.Trim());
            _DmmangEntity.Rong = LIB.ConvertString.NumbertoDB(txt_RONG.Text.Trim());
            _DmmangEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
            _DmmangEntity.Tenloaimang = txt_TENLOAIMANG.Text.Trim();
            _DmmangEntity.Maqcmang = txt_MAQUYCACHMANG.Text.Trim();
            _DmmangEntity.Tenqcmang = txt_TENQUYCACHMANG.Text.Trim();

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DmmangEntity.Ngaytao = DateTime.Now;
                _DmmangEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DmmangManager.InsertV2(_DmmangEntity, r_Insert, DT_DMMANG, BS_DMMANG);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMMANG.ResetCurrentItem();
            }
            else
            {
                _DmmangEntity.Ngaysua = DateTime.Now;
                _DmmangEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmmangManager.Update(_DmmangEntity);
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mamang.Name].Value = _DmmangEntity.Mamang;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenmang.Name].Value = _DmmangEntity.Tenmang;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Makhach.Name].Value = _DmmangEntity.Makhach;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenkhach.Name].Value = _DmmangEntity.Tenkhach;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Kichthuoc.Name].Value = _DmmangEntity.Kichthuoc;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Trongluong.Name].Value = _DmmangEntity.Trongluong;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Mactpt.Name].Value = _DmmangEntity.Mactpt;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Doday.Name].Value = _DmmangEntity.Doday;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Rong.Name].Value = _DmmangEntity.Rong;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Maloaimang.Name].Value = _DmmangEntity.Maloaimang;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenloaimang.Name].Value = _DmmangEntity.Tenloaimang;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Maqcmang.Name].Value = _DmmangEntity.Maqcmang;
                GRID_DMMANG.CurrentRow.Cells[DmmangFields.Tenqcmang.Name].Value = _DmmangEntity.Tenqcmang;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_DMMANG.NewRow();
            DT_DMMANG.Rows.Add(r_Insert);
            BS_DMMANG.Position = DT_DMMANG.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMMANG.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAHIEU }));
                txt_TENHIEU.Focus();
            }
            GRID_DMMANG.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMMANG.Rows.Remove(r_Insert);
            }
            BS_DMMANG_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMMANG.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmmangManager _DmmangManager = new DmmangManager();
            DmmangEntity _DmmangEntity = new DmmangEntity();
            _DmmangEntity = _DmmangManager.SelectOne(MAHIEU_PK);
            if (_DmmangEntity != null && MessageBox.Show("Xóa khách hàng: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmmangManager.Delete(MAHIEU_PK);
                    GRID_DMMANG.CurrentRow.Delete();
                    BS_DMMANG_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmangManager.Convert(_DmmangEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa khách hàng " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMMANG.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmmangManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã khách hàng bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMMANG.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAKHACH_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKHACH.Text.Trim()) || DT_DMKHACH == null || DT_DMKHACH.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAKHACH.Text.Trim().ToUpper();
            _RowViewSelect = checkmaKhach(_str_MACANTIM, DT_DMKHACH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMKHACH.xml",
                        DT_DMKHACH, DmkhachFields.Makhach.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKHACH.Text = _RowViewSelect[DmkhachFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
            }
            else
                txt_TENKHACH.Text = _RowViewSelect[DmkhachFields.Tenkhach.Name].ToString();
        }
        private DataRow checkmaKhach(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmkhachFields.Makhach.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACTPT_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MACTPT.Text.Trim()) || DT_CTPT == null || DT_CTPT.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MACTPT.Text.Trim().ToUpper();
            _RowViewSelect = checkmaCtpt(_str_MACANTIM, DT_CTPT);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_CTPTMANG.xml",
                        DT_CTPT, CtptmangHFields.Mactpt.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACTPT.Text = _RowViewSelect[CtptmangHFields.Mactpt.Name].ToString();
                txt_TENCTPT.Text = _RowViewSelect[CtptmangHFields.Tenctpt.Name].ToString();
            }
            else
                txt_TENCTPT.Text = _RowViewSelect[CtptmangHFields.Tenctpt.Name].ToString();

        }
        private DataRow checkmaCtpt(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(CtptmangHFields.Mactpt.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MALOAIMANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MALOAIMANG.Text.Trim()) || DT_LOAIMANG == null || DT_LOAIMANG.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MALOAIMANG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaLoaimang(_str_MACANTIM, DT_LOAIMANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_LOAIMANG, DmquycachFields.Maquycach.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MALOAIMANG.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENLOAIMANG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENLOAIMANG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }
        private DataRow checkmaLoaimang(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmquycachFields.Maquycach.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MAQUYCACHMANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQUYCACHMANG.Text.Trim()) || DT_QCMANG == null || DT_QCMANG.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MAQUYCACHMANG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQCloaimang(_str_MACANTIM, DT_QCMANG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_QCMANG, DmquycachFields.Maquycach.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQUYCACHMANG.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENQUYCACHMANG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENQUYCACHMANG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }
        private DataRow checkmaQCloaimang(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DmquycachFields.Maquycach.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }



        #endregion

        #region Shortcut Key
        private void txt_MAKHACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMKHACH frm_Dm = new FRM_DMKHACH();
                frm_Dm.Text = "Danh sách khách hàng";
                frm_Dm.ShowDialog();
                DT_DMKHACH = new DmkhachManager().SelectAllRDT();
            }
        }
        private void txt_MALOAIMANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục loại màng";
                frm_Dm.ShowDialog();
                DT_LOAIMANG = new DmquycachManager().SelectAllRDT();
            }
        }
        private void txt_MAQCMANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách màng";
                frm_Dm.ShowDialog();
                DT_QCMANG = new DmquycachManager().SelectAllRDT();
            }
        }

        private void txt_MACTPTMANG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_CTPTMANG frm_Dm = new FRM_CTPTMANG();
                frm_Dm.Text = "Danh mục công thức phối trộn";
                frm_Dm.ShowDialog();
                DT_CTPT = new CtptmangHManager().SelectAllRDT();
            }
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMMANG.ColumnAutoResize = true;
            else
                GRID_DMMANG.ColumnAutoResize = false;
        }

        private void FRM_DMMANG_FormClosing(object sender, FormClosingEventArgs e)
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
