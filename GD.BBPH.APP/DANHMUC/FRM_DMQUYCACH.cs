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
    public partial class FRM_DMQUYCACH : FRM_DMPARENT
    {
        private DmquycachManager _DmquycachManager = new DmquycachManager();
        private DmquycachEntity _DmquycachEntity = new DmquycachEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_DMQUYCACH = new DataTable();
        private BindingSource BS_DMQUYCACH = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_DMQUYCACH = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_DMQUYCACH");
                        DT_DMQUYCACH = LIB.SESSION_START.DT_DMQUYCACH;
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

        public FRM_DMQUYCACH()
        {
            InitializeComponent();
            DmquycachManager _DmquycachManager = new DmquycachManager();
            DataTable dt111 = _DmquycachManager.Clone();
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml", GRID_DMQUYCACH, uiPanel0Container);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_DMQUYCACH);
            BS_DMQUYCACH = new BindingSource();
            BS_DMQUYCACH.DataSource = Source_View;
            GRID_DMQUYCACH.DataSource = BS_DMQUYCACH;
            BS_DMQUYCACH.CurrentChanged += new EventHandler(BS_DMQUYCACH_CurrentChanged);
            BS_DMQUYCACH_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_DMQUYCACH_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                if (BS_DMQUYCACH.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_DMQUYCACH.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[DmquycachFields.Maqc.Name].ToString();
                    txt_MAQC.Text = _Rowview.Row[DmquycachFields.Maqc.Name].ToString();
                    txt_TENQUYCACH.Text = _Rowview.Row[DmquycachFields.Tenquycach.Name].ToString();
                    txt_MACD.Text = _Rowview.Row[DmquycachFields.Macd.Name].ToString();
                    txt_MAQCCHA.Text = _Rowview.Row[DmquycachFields.Maqccha.Name].ToString();

                    //try { chk_COSUDUNGMAY.Checked = Convert.ToBoolean(_Rowview.Row[DmquycachFields.Cosudungmay.Name].ToString()); }
                    //catch { }
                    //try { chk_TRUOCCAT.Checked = Convert.ToBoolean(_Rowview.Row[DmquycachFields.Truoccat.Name].ToString()); }
                    //catch { }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMQUYCACH_CurrentChanged"); }
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            DmquycachManager _DmquycachManager = new DmquycachManager();
            DmquycachEntity _DmquycachEntity = new DmquycachEntity();
            r_Insert = DT_DMQUYCACH.NewRow();
            DT_DMQUYCACH.Rows.Add(r_Insert);
            BS_DMQUYCACH.Position = DT_DMQUYCACH.Rows.Count;
            MAHIEU_PK = "";
            txt_MAQC.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMQUYCACH.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MAQC }));
                txt_TENQUYCACH.Focus();
            }
            GRID_DMQUYCACH.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_DMQUYCACH.Rows.Remove(r_Insert);
            }
            BS_DMQUYCACH_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_DMQUYCACH.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            DmquycachManager _DmquycachManager = new DmquycachManager();
            DmquycachEntity _DmquycachEntity = new DmquycachEntity();
            _DmquycachEntity = _DmquycachManager.SelectOne(MAHIEU_PK);
            if (_DmquycachEntity != null && MessageBox.Show("Xóa công đoạn: " + MAHIEU_PK + " - " + txt_TENQUYCACH.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _DmquycachManager.Delete(MAHIEU_PK);
                    GRID_DMQUYCACH.CurrentRow.Delete();
                    BS_DMQUYCACH_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_DmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công đoạn " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_DMQUYCACH.Enabled = true;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _DmquycachManager.SelectOne(txt_MAQC.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công đoạn bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAQC.Focus();
                return;
            }
            else if (txt_MAQC.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAQC.Focus();
                return;
            }
            else if (txt_TENQUYCACH.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công đoạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TENQUYCACH.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_DMQUYCACH.Enabled = true;
                btn_THEMMOI.Focus();
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private string Save_Data(string _str_DMCHUONG_PK)
        {
            DmquycachEntity _DmquycachEntity = new DmquycachEntity();
            _DmquycachEntity.Maqc = txt_MAQC.Text.Trim();
            _DmquycachEntity.Tenquycach = txt_TENQUYCACH.Text.Trim();
            _DmquycachEntity.Macd = txt_MACD.Text.Trim();
            _DmquycachEntity.Maqccha = txt_MAQCCHA.Text.Trim();
           

            if (string.IsNullOrEmpty(_str_DMCHUONG_PK))
            {
                _str_DMCHUONG_PK = _DmquycachManager.InsertV2(_DmquycachEntity, r_Insert, DT_DMQUYCACH, BS_DMQUYCACH);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_DmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMQUYCACH.ResetCurrentItem();
            }
            else
            {
                _DmquycachManager.Update(_DmquycachEntity);
                GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Macd.Name].Value = _DmquycachEntity.Maqc;
                GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Tenquycach.Name].Value = _DmquycachEntity.Tenquycach;
                GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Macd.Name].Value = _DmquycachEntity.Macd;
                GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Tenquycach.Name].Value = _DmquycachEntity.Maqccha;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_DmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_DMCHUONG_PK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_DMQUYCACH.ColumnAutoResize = true;
            else
                GRID_DMQUYCACH.ColumnAutoResize = false;
        }

        private void FRM_DMQUYCACH_FormClosing(object sender, FormClosingEventArgs e)
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
