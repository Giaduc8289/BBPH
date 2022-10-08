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

namespace GD.BBPH.APP.BANHANG
{
    public partial class FRM_HANGTRALAI : FRM_DMPARENT
    {
        private HangtralaiManager _HangtralaiManager = new HangtralaiManager();
        private HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_HANGTRALAI = new DataTable();
        private BindingSource BS_HANGTRALAI = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_HANGTRALAI = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_HANGTRALAI");
                        DT_HANGTRALAI = LIB.SESSION_START.DT_HANGTRALAI;

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

        public FRM_HANGTRALAI()
        {
            InitializeComponent();
            HangtralaiManager _HangtralaiManager = new HangtralaiManager();
            DataTable dt111 = _HangtralaiManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_HANGTRALAI.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_HANGTRALAI.xml", GRID_HANGTRALAI, uiPanel0Container);
            //GRID_HANGTRALAI.RootTable.Groups.Add(GRID_HANGTRALAI.Tables[0].Columns[HangtralaiFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_HANGTRALAI);
            BS_HANGTRALAI = new BindingSource();
            BS_HANGTRALAI.DataSource = Source_View;
            GRID_HANGTRALAI.DataSource = BS_HANGTRALAI;
            BS_HANGTRALAI.CurrentChanged += new EventHandler(BS_HANGTRALAI_CurrentChanged);
            BS_HANGTRALAI_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_HANGTRALAI_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_HANGTRALAI.UpdateData();
                if (BS_HANGTRALAI.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_HANGTRALAI.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[HangtralaiFields.Sophieugiao.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[HangtralaiFields.Tenhang.Name].ToString();

                    //txt_Id.Text = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
                    //txt_Sophieugiao.Text = _Rowview.Row[HangtralaiFields.Sophieugiao.Name].ToString();
                    //txt_Ngaygiao.Text = _Rowview.Row[HangtralaiFields.Ngaygiao.Name].ToString();
                    //txt_Madon.Text = _Rowview.Row[HangtralaiFields.Madon.Name].ToString();
                    //txt_Makhach.Text = _Rowview.Row[HangtralaiFields.Makhach.Name].ToString();
                    //txt_Tenkhach.Text = _Rowview.Row[HangtralaiFields.Tenkhach.Name].ToString();
                    //txt_Ngaydat.Text = _Rowview.Row[HangtralaiFields.Ngaydat.Name].ToString();
                    //txt_Masp.Text = _Rowview.Row[HangtralaiFields.Masp.Name].ToString();
                    //txt_Tenhang.Text = _Rowview.Row[HangtralaiFields.Tenhang.Name].ToString();
                    //txt_Soluonggiao.Text = _Rowview.Row[HangtralaiFields.Soluonggiao.Name].ToString();
                    //txt_Soluongtralai.Text = _Rowview.Row[HangtralaiFields.Soluongtralai.Name].ToString();
                    //txt_Ngaytra.Text = _Rowview.Row[HangtralaiFields.Ngaytra.Name].ToString();
                    //txt_Nguyennhan.Text = _Rowview.Row[HangtralaiFields.Nguyennhan.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_HANGTRALAI_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            HangtralaiEntity _hangtralaiEntity = new HangtralaiEntity();
            _hangtralaiEntity.Sophieugiao = txt_MAHIEU.Text.Trim();
            _hangtralaiEntity.Tenhang = txt_TENHIEU.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _hangtralaiEntity.Ngaytao = DateTime.Now;
                _hangtralaiEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_DMCHUONG_PK = _HangtralaiManager.InsertV2(_hangtralaiEntity, r_Insert, DT_HANGTRALAI, BS_HANGTRALAI);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_hangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_HANGTRALAI.ResetCurrentItem();
            }
            else
            {
                _hangtralaiEntity.Ngaysua = DateTime.Now;
                _hangtralaiEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _HangtralaiManager.Update(_hangtralaiEntity);
                GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Sophieugiao.Name].Value = _hangtralaiEntity.Sophieugiao;
                GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Tenhang.Name].Value = _hangtralaiEntity.Tenhang;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_hangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            //txt_PHONGBAN.Text = string.Empty;
            //txt_CHUCVU.Text = string.Empty;
            HangtralaiManager _HangtralaiManager = new HangtralaiManager();
            HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
            r_Insert = DT_HANGTRALAI.NewRow();
            DT_HANGTRALAI.Rows.Add(r_Insert);
            BS_HANGTRALAI.Position = DT_HANGTRALAI.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            //GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_PHONGBAN, txt_CHUCVU }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_HANGTRALAI.Enabled = false;
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
            GRID_HANGTRALAI.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_HANGTRALAI.Rows.Remove(r_Insert);
            }
            BS_HANGTRALAI_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_HANGTRALAI.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            HangtralaiManager _HangtralaiManager = new HangtralaiManager();
            HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
            _HangtralaiEntity = _HangtralaiManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_HangtralaiEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _HangtralaiManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    GRID_HANGTRALAI.CurrentRow.Delete();
                    BS_HANGTRALAI_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_HangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_HANGTRALAI.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _HangtralaiManager.SelectOne(Convert.ToInt64(txt_MAHIEU.Text.Trim())) != null)
            {
                MessageBox.Show("Mã công nhân bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_HANGTRALAI.Enabled = true;
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
                GRID_HANGTRALAI.ColumnAutoResize = true;
            else
                GRID_HANGTRALAI.ColumnAutoResize = false;
        }

        private void FRM_HANGTRALAI_FormClosing(object sender, FormClosingEventArgs e)
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
