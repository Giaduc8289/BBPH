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
    public partial class FRM_LYDONHAPXUAT : FRM_DMPARENT
    {
        private DmlydonhapxuatManager _DmlydonhapxuatManager = new DmlydonhapxuatManager();
        private DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMLYDONHAPXUAT = new DataTable();
        private BindingSource BS_LYDONHAPXUAT = new BindingSource();
        private DataRow r_Insert = null;
        private GD.BBPH.CONTROL.JGridEX GRID_LYDONHAPXUAT = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "";
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_LYDONHAPXUAT");
                        DT_DMLYDONHAPXUAT = LIB.SESSION_START.DT_DMLYDONHAPXUAT;
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

        public FRM_LYDONHAPXUAT()
        {
            InitializeComponent();
            DmlydonhapxuatManager _DmlydonhapxuatManager = new DmlydonhapxuatManager();
            DataTable dt111 = _DmlydonhapxuatManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LYDONHAPXUAT.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LYDONHAPXUAT.xml", GRID_LYDONHAPXUAT, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMLYDONHAPXUAT);
            BS_LYDONHAPXUAT = new BindingSource();
            BS_LYDONHAPXUAT.DataSource = Source_View;
            GRID_LYDONHAPXUAT.DataSource = BS_LYDONHAPXUAT;
            BS_LYDONHAPXUAT.CurrentChanged += new EventHandler(BS_LYDONHAPXUAT_CurrentChanged);
            BS_LYDONHAPXUAT_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_LYDONHAPXUAT_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_LYDONHAPXUAT.UpdateData();
                if (BS_LYDONHAPXUAT.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_LYDONHAPXUAT.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmlydonhapxuatFields.Malydo.Name].ToString();
                    txt_MAHIEU.Text = _Rowview.Row[DmlydonhapxuatFields.Malydo.Name].ToString();
                    txt_TENHIEU.Text = _Rowview.Row[DmlydonhapxuatFields.Tenlydo.Name].ToString();
                    txt_MANHOM.Text = _Rowview.Row[DmlydonhapxuatFields.Manhom.Name].ToString();
                    txt_TENNHOM.Text = _Rowview.Row[DmlydonhapxuatFields.Tennhom.Name].ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_LYDONHAPXUAT_CurrentChanged"); }
        }

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity();
            _DmlydonhapxuatEntity.Malydo = txt_MAHIEU.Text.Trim();
            _DmlydonhapxuatEntity.Tenlydo = txt_TENHIEU.Text.Trim();
            _DmlydonhapxuatEntity.Manhom = txt_MANHOM.Text.Trim();
            _DmlydonhapxuatEntity.Tennhom = txt_TENNHOM.Text.Trim();
            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _str_DMCHUONG_PK = _DmlydonhapxuatManager.InsertV2(_DmlydonhapxuatEntity, r_Insert, DT_DMLYDONHAPXUAT, BS_LYDONHAPXUAT);
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_DmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_LYDONHAPXUAT.ResetCurrentItem();
            }
            else
            {
                _DmlydonhapxuatManager.Update(_DmlydonhapxuatEntity);
                GRID_LYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Malydo.Name].Value = _DmlydonhapxuatEntity.Malydo;
                GRID_LYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Tenlydo.Name].Value = _DmlydonhapxuatEntity.Tenlydo;
                GRID_LYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Manhom.Name].Value = _DmlydonhapxuatEntity.Manhom;
                GRID_LYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Tennhom.Name].Value = _DmlydonhapxuatEntity.Tennhom;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_DmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmlydonhapxuatManager _DmlydonhapxuatManager = new DmlydonhapxuatManager();
            DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity();
            r_Insert = DT_DMLYDONHAPXUAT.NewRow();
            DT_DMLYDONHAPXUAT.Rows.Add(r_Insert);
            BS_LYDONHAPXUAT.Position = DT_DMLYDONHAPXUAT.Rows.Count;
            MAHIEU_PK = "";
            txt_MAHIEU.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_LYDONHAPXUAT.Enabled = false;
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
            GRID_LYDONHAPXUAT.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMLYDONHAPXUAT.Rows.Remove(r_Insert);
            }
            BS_LYDONHAPXUAT_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_LYDONHAPXUAT.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmlydonhapxuatManager _DmlydonhapxuatManager = new DmlydonhapxuatManager();
            DmlydonhapxuatEntity _DmlydonhapxuatEntity = new DmlydonhapxuatEntity();
            _DmlydonhapxuatEntity = _DmlydonhapxuatManager.SelectOne(MAHIEU_PK);
            if (_DmlydonhapxuatEntity != null && MessageBox.Show("Xóa lý do: " + MAHIEU_PK + " - " + txt_TENHIEU.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmlydonhapxuatManager.Delete(MAHIEU_PK);
                    GRID_LYDONHAPXUAT.CurrentRow.Delete();
                    BS_LYDONHAPXUAT_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_DmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa lý do " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_LYDONHAPXUAT.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmlydonhapxuatManager.SelectOne(txt_MAHIEU.Text.Trim()) != null)
            {
                MessageBox.Show("Mã lý do bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_MAHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAHIEU.Focus();
                return;
            }
            else if (txt_TENHIEU.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENHIEU.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_LYDONHAPXUAT.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_LYDONHAPXUAT.ColumnAutoResize = true;
            else
                GRID_LYDONHAPXUAT.ColumnAutoResize = false;
        }

        private void FRM_LYDONHAPXUAT_FormClosing(object sender, FormClosingEventArgs e)
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
