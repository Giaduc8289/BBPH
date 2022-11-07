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
    public partial class FRM_DINHMUCKEO : FRM_DMPARENT
    {
        private DinhmuckeoManager _DinhmuckeoManager = new DinhmuckeoManager();
        private DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DINHMUCKEO = new DataTable();
        private BindingSource BS_DINHMUCKEO = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DINHMUCKEO = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

        private DataTable DT_DMKEO = new DataTable(), DT_DMDONGRAN = new DataTable();

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DINHMUCKEO");
                        DT_DINHMUCKEO = new DinhmuckeoManager().SelectAllRDT();

                        DT_DMKEO = new DmnguyenlieuManager().SelectByManhomRDT("KEO");
                        DT_DMDONGRAN = new DmnguyenlieuManager().SelectByManhomRDT("DONGRAN");
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

        public FRM_DINHMUCKEO()
        {
            InitializeComponent();
            DinhmuckeoManager _DinhmuckeoManager = new DinhmuckeoManager();
            DataTable dt111 = _DinhmuckeoManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DINHMUCKEO.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DINHMUCKEO.xml", GRID_DINHMUCKEO, uiPanel0Container);
            FORM_PROCESS();
            //GRID_DINHMUCKEO.RootTable.Groups.Add(GRID_DINHMUCKEO.Tables[0].Columns[DinhmuckeoFields.Tennhom.Name]);
            //GRID_DINHMUCKEO.RootTable.Columns[DinhmuckeoFields.Tencd.Name].EditType = EditType.NoEdit;
            //GRID_DINHMUCKEO.RootTable.Columns[DinhmuckeoFields.Tenqccha.Name].EditType = EditType.NoEdit;
            DataView Source_View = new DataView(DT_DINHMUCKEO);
            BS_DINHMUCKEO = new BindingSource();
            BS_DINHMUCKEO.DataSource = Source_View;
            GRID_DINHMUCKEO.DataSource = BS_DINHMUCKEO;
            BS_DINHMUCKEO.CurrentChanged += new EventHandler(BS_DINHMUCKEO_CurrentChanged);
            BS_DINHMUCKEO_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DINHMUCKEO_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DINHMUCKEO.UpdateData();
                if (BS_DINHMUCKEO.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DINHMUCKEO.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DinhmuckeoFields.Madinhmuc.Name].ToString();
                    txt_MADINHMUC.Text = _Rowview.Row[DinhmuckeoFields.Madinhmuc.Name].ToString();
                    txt_TENDINHMUC.Text = _Rowview.Row[DinhmuckeoFields.Tendinhmuc.Name].ToString();
                    txt_TENRUTGON.Text = _Rowview.Row[DinhmuckeoFields.Tenrutgon.Name].ToString();
                    txt_MAKEO.Text = _Rowview.Row[DinhmuckeoFields.Makeo.Name].ToString();
                    txt_MADONGRAN.Text = _Rowview.Row[DinhmuckeoFields.Madongran.Name].ToString();
                    txt_HAMLUONGKEO.Text = _Rowview.Row[DinhmuckeoFields.Hamluongkeo.Name].ToString();
                    txt_HAMLUONGDONGRAN.Text = _Rowview.Row[DinhmuckeoFields.Hamluongdongran.Name].ToString();
                    txt_TYLEPHAKEO.Text = _Rowview.Row[DinhmuckeoFields.Tylephakeo.Name].ToString();
                    txt_TYLEPHADONGRAN.Text = _Rowview.Row[DinhmuckeoFields.Tylephadongran.Name].ToString();
                    txt_DUNGMOI.Text = _Rowview.Row[DinhmuckeoFields.Dungmoi.Name].ToString();

                    txt_MAKEO_Validating(new object(), new CancelEventArgs());
                    txt_MADONGRAN_Validating(new object(), new CancelEventArgs());

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DINHMUCKEO_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_TENKEO.Text = txt_TENDONGRAN.Text = string.Empty;
            r_Insert = DT_DINHMUCKEO.NewRow();
            DT_DINHMUCKEO.Rows.Add(r_Insert);
            BS_DINHMUCKEO.Position = DT_DINHMUCKEO.Rows.Count;
            MAHIEU_PK = "";
            txt_MADINHMUC.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENKEO, txt_TENDONGRAN }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DINHMUCKEO.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MADINHMUC, txt_TENKEO, txt_TENDONGRAN }));
                txt_TENDINHMUC.Focus();
            }
            GRID_DINHMUCKEO.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DINHMUCKEO.Rows.Remove(r_Insert);
            }
            BS_DINHMUCKEO_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DINHMUCKEO.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DinhmuckeoManager _DinhmuckeoManager = new DinhmuckeoManager();
            DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity();
            _DinhmuckeoEntity = _DinhmuckeoManager.SelectOne(MAHIEU_PK);
            if (_DinhmuckeoEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENDINHMUC.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DinhmuckeoManager.Delete(MAHIEU_PK);
                    GRID_DINHMUCKEO.CurrentRow.Delete();
                    BS_DINHMUCKEO_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmuckeoManager.Convert(_DinhmuckeoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DINHMUCKEO.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DinhmuckeoManager.SelectOne(txt_MADINHMUC.Text.Trim()) != null)
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
                GRID_DINHMUCKEO.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate
        private void txt_MAKEO_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAKEO.Text.Trim()) || DT_DMKEO == null || DT_DMKEO.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAKEO.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNguyelieu(Str_MASIEUTHI, DT_DMKEO);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU.xml",
                        DT_DMKEO, DmnguyenlieuFields.Manl.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAKEO.Text = _RowViewSelect[DmnguyenlieuFields.Manl.Name].ToString();
                txt_TENKEO.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
            }
            else
                txt_TENKEO.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
        }
        private DataRow checkmaNguyelieu(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmnguyenlieuFields.Manl.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MADONGRAN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MADONGRAN.Text.Trim()) || DT_DMDONGRAN == null || DT_DMDONGRAN.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MADONGRAN.Text.Trim().ToUpper();
            _RowViewSelect = checkmaNguyelieu(Str_MASIEUTHI, DT_DMDONGRAN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMNGUYENLIEU.xml",
                        DT_DMDONGRAN, DmnguyenlieuFields.Manl.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MADONGRAN.Text = _RowViewSelect[DmnguyenlieuFields.Manl.Name].ToString();
                txt_TENDONGRAN.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
            }
            else
                txt_TENDONGRAN.Text = _RowViewSelect[DmnguyenlieuFields.Tennl.Name].ToString();
        }
        #endregion

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity();
            _DinhmuckeoEntity.Madinhmuc = txt_MADINHMUC.Text.Trim();
            _DinhmuckeoEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
            _DinhmuckeoEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
            _DinhmuckeoEntity.Makeo = txt_MAKEO.Text.Trim();
            _DinhmuckeoEntity.Tenkeo = txt_TENKEO.Text.Trim();
            _DinhmuckeoEntity.Madongran = txt_MADONGRAN.Text.Trim();
            _DinhmuckeoEntity.Tendongran = txt_TENDONGRAN.Text.Trim();
            _DinhmuckeoEntity.Hamluongkeo = LIB.ConvertString.NumbertoDB(txt_HAMLUONGKEO.Text.Trim());
            _DinhmuckeoEntity.Hamluongdongran = LIB.ConvertString.NumbertoDB(txt_HAMLUONGDONGRAN.Text.Trim());
            _DinhmuckeoEntity.Tylephakeo = LIB.ConvertString.NumbertoDB(txt_TYLEPHAKEO.Text.Trim());
            _DinhmuckeoEntity.Tylephadongran = LIB.ConvertString.NumbertoDB(txt_TYLEPHADONGRAN.Text.Trim());
            _DinhmuckeoEntity.Dungmoi = LIB.ConvertString.NumbertoDB(txt_DUNGMOI.Text.Trim());

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DinhmuckeoEntity.Ngaytao = DateTime.Now;
                _DinhmuckeoEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DinhmuckeoManager.InsertV2(_DinhmuckeoEntity, r_Insert, DT_DINHMUCKEO, BS_DINHMUCKEO);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmuckeoManager.Convert(_DinhmuckeoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DINHMUCKEO.ResetCurrentItem();
            }
            else
            {
                _DinhmuckeoEntity.Ngaysua = DateTime.Now;
                _DinhmuckeoEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DinhmuckeoManager.Update(_DinhmuckeoEntity);
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Madinhmuc.Name].Value = _DinhmuckeoEntity.Madinhmuc;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tendinhmuc.Name].Value = _DinhmuckeoEntity.Tendinhmuc;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tenrutgon.Name].Value = _DinhmuckeoEntity.Tenrutgon;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Makeo.Name].Value = _DinhmuckeoEntity.Makeo;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tenkeo.Name].Value = _DinhmuckeoEntity.Tenkeo;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Madongran.Name].Value = _DinhmuckeoEntity.Madongran;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tendongran.Name].Value = _DinhmuckeoEntity.Tendongran;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Hamluongkeo.Name].Value = _DinhmuckeoEntity.Hamluongkeo;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Hamluongdongran.Name].Value = _DinhmuckeoEntity.Hamluongdongran;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tylephakeo.Name].Value = _DinhmuckeoEntity.Tylephakeo;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tylephadongran.Name].Value = _DinhmuckeoEntity.Tylephadongran;
                GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Dungmoi.Name].Value = _DinhmuckeoEntity.Dungmoi;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmuckeoManager.Convert(_DinhmuckeoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DINHMUCKEO.ColumnAutoResize = true;
            else
                GRID_DINHMUCKEO.ColumnAutoResize = false;
        }

        private void FRM_DINHMUCKEO_FormClosing(object sender, FormClosingEventArgs e)
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
