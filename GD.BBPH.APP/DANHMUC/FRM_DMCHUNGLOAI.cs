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
    public partial class FRM_DMCHUNGLOAI : FRM_DMPARENT
    {
        private DmchungloaiManager _DmchungloaiManager = new DmchungloaiManager();
        private DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMCHUNGLOAI = new DataTable();
        private BindingSource BS_DMCHUNGLOAI = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMCHUNGLOAI = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";

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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMCHUNGLOAI");
                        DT_DMCHUNGLOAI = LIB.SESSION_START.DT_DMCHUNGLOAI;

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

        public FRM_DMCHUNGLOAI()
        {
            InitializeComponent();
            DmchungloaiManager _DmchungloaiManager = new DmchungloaiManager();
            DataTable dt111 = _DmchungloaiManager.Clone();
            GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCHUNGLOAI.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCHUNGLOAI.xml", GRID_DMCHUNGLOAI, uiPanel0Container);
            //GRID_DMCHUNGLOAI.RootTable.Groups.Add(GRID_DMCHUNGLOAI.Tables[0].Columns[DmchungloaiFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMCHUNGLOAI);
            BS_DMCHUNGLOAI = new BindingSource();
            BS_DMCHUNGLOAI.DataSource = Source_View;
            GRID_DMCHUNGLOAI.DataSource = BS_DMCHUNGLOAI;
            BS_DMCHUNGLOAI.CurrentChanged += new EventHandler(BS_DMCHUNGLOAI_CurrentChanged);
            BS_DMCHUNGLOAI_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMCHUNGLOAI_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_DMCHUNGLOAI.UpdateData();
                if (BS_DMCHUNGLOAI.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMCHUNGLOAI.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmchungloaiFields.Machungloai.Name].ToString();
                    txt_MACHUNGLOAI.Text    = _Rowview.Row[DmchungloaiFields.Machungloai.Name].ToString();
                    txt_TENCHUNGLOAI.Text   = _Rowview.Row[DmchungloaiFields.Tenchungloai.Name].ToString();
                    txt_KICHTHUOC.Text      = _Rowview.Row[DmchungloaiFields.Kichthuoc.Name].ToString();
                    txt_TRONGLUONG.Text     = _Rowview.Row[DmchungloaiFields.Trongluong.Name].ToString();
                    txt_SOMAU.Text          = _Rowview.Row[DmchungloaiFields.Somau.Name].ToString();
                    txt_SOHINH.Text         = _Rowview.Row[DmchungloaiFields.Sohinh.Name].ToString();
                    txt_LOAIMUC.Text        = _Rowview.Row[DmchungloaiFields.Loaimuc.Name].ToString();
                    txt_GHICHU.Text         = _Rowview.Row[DmchungloaiFields.Ghichu.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCHUNGLOAI_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmchungloaiEntity _dmchungloaiEntity = new DmchungloaiEntity();
            _dmchungloaiEntity.Machungloai = txt_MACHUNGLOAI.Text.Trim();
            _dmchungloaiEntity.Tenchungloai = txt_TENCHUNGLOAI.Text.Trim();
            _dmchungloaiEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
            _dmchungloaiEntity.Trongluong = Convert.ToDecimal(txt_TRONGLUONG.Text.Trim());
            _dmchungloaiEntity.Somau = Convert.ToInt32(txt_SOMAU.Text.Trim());
            _dmchungloaiEntity.Sohinh = Convert.ToInt32(txt_SOHINH.Text.Trim());
            _dmchungloaiEntity.Loaimuc = txt_LOAIMUC.Text.Trim();
            _dmchungloaiEntity.Ghichu = txt_GHICHU.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _dmchungloaiEntity.Ngaytao = DateTime.Now;
                _dmchungloaiEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _DmchungloaiManager.InsertV2(_dmchungloaiEntity, r_Insert, DT_DMCHUNGLOAI, BS_DMCHUNGLOAI);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_dmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMCHUNGLOAI.ResetCurrentItem();
            }
            else
            {
                _dmchungloaiEntity.Ngaysua = DateTime.Now;
                _dmchungloaiEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmchungloaiManager.Update(_dmchungloaiEntity);
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Machungloai.Name].Value = _dmchungloaiEntity.Machungloai;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenchungloai.Name].Value = _dmchungloaiEntity.Tenchungloai;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Kichthuoc.Name].Value = _dmchungloaiEntity.Kichthuoc;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Trongluong.Name].Value = _dmchungloaiEntity.Trongluong;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Somau.Name].Value = _dmchungloaiEntity.Somau;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Sohinh.Name].Value = _dmchungloaiEntity.Sohinh;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Loaimuc.Name].Value = _dmchungloaiEntity.Loaimuc;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Ghichu.Name].Value = _dmchungloaiEntity.Ghichu;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_DmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            DmchungloaiManager _DmchungloaiManager = new DmchungloaiManager();
            DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity();
            r_Insert = DT_DMCHUNGLOAI.NewRow();
            DT_DMCHUNGLOAI.Rows.Add(r_Insert);
            BS_DMCHUNGLOAI.Position = DT_DMCHUNGLOAI.Rows.Count;
            MAHIEU_PK = "";
            txt_MACHUNGLOAI.Focus();
            TEXTBOX_Only_Control(false, null);
            //GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_PHONGBAN, txt_CHUCVU }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMCHUNGLOAI.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MACHUNGLOAI }));
                txt_TENCHUNGLOAI.Focus();
            }
            GRID_DMCHUNGLOAI.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMCHUNGLOAI.Rows.Remove(r_Insert);
            }
            BS_DMCHUNGLOAI_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMCHUNGLOAI.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmchungloaiManager _DmchungloaiManager = new DmchungloaiManager();
            DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity();
            _DmchungloaiEntity = _DmchungloaiManager.SelectOne(MAHIEU_PK);
            if (_DmchungloaiEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_TENCHUNGLOAI.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmchungloaiManager.Delete(MAHIEU_PK);
                    GRID_DMCHUNGLOAI.CurrentRow.Delete();
                    BS_DMCHUNGLOAI_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_DmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMCHUNGLOAI.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmchungloaiManager.SelectOne(txt_MACHUNGLOAI.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công nhân bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACHUNGLOAI.Focus();
                return;
            }
            else if (txt_MACHUNGLOAI.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MACHUNGLOAI.Focus();
                return;
            }
            else if (txt_TENCHUNGLOAI.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENCHUNGLOAI.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMCHUNGLOAI.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMCHUNGLOAI.ColumnAutoResize = true;
            else
                GRID_DMCHUNGLOAI.ColumnAutoResize = false;
        }

        private void FRM_DMCHUNGLOAI_FormClosing(object sender, FormClosingEventArgs e)
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
