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

        private DataTable DT_LOAIMUC = new DataTable(), DT_SOMAU = new DataTable(), DT_SOHINH = new DataTable()
            , DT_QCTHANHPHAM = new DataTable(), DT_QCDONGGOI = new DataTable(), DT_QCLOAITHUNG = new DataTable();

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

                        DT_LOAIMUC = new DmquycachManager().SelectByManhomRDT("N04");
                        DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
                        DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
                        DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
                        DT_QCDONGGOI = new DmquycachManager().SelectByManhomRDT("N07");
                        DT_QCLOAITHUNG = new DmquycachManager().SelectByManhomRDT("N08");
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
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCHUNGLOAI.xml");
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
                    txt_MACHUNGLOAI.Text = _Rowview.Row[DmchungloaiFields.Machungloai.Name].ToString();
                    txt_TENCHUNGLOAI.Text = _Rowview.Row[DmchungloaiFields.Tenchungloai.Name].ToString();
                    txt_KICHTHUOC.Text = _Rowview.Row[DmchungloaiFields.Kichthuoc.Name].ToString();
                    txt_TRONGLUONG.Text = _Rowview.Row[DmchungloaiFields.Trongluong.Name].ToString();
                    txt_GHICHU.Text = _Rowview.Row[DmchungloaiFields.Ghichu.Name].ToString();
                    txt_RONG.Text = _Rowview.Row[DmchungloaiFields.Rong.Name].ToString();
                    txt_DAI.Text = _Rowview.Row[DmchungloaiFields.Dai.Name].ToString();

                    txt_SOMAUMA.Text = _Rowview.Row[DmchungloaiFields.Somauma.Name].ToString();
                    txt_SOHINHMA.Text = _Rowview.Row[DmchungloaiFields.Sohinhma.Name].ToString();
                    txt_MAQCDONGGOI.Text = _Rowview.Row[DmchungloaiFields.Maqcdonggoi.Name].ToString();
                    txt_MAQCLOAITHUNG.Text = _Rowview.Row[DmchungloaiFields.Maqcloaithung.Name].ToString();
                    txt_MAQCTHANHPHAM.Text = _Rowview.Row[DmchungloaiFields.Maqcthanhpham.Name].ToString();
                    txt_MALOAIMUC.Text = _Rowview.Row[DmchungloaiFields.Maloaimuc.Name].ToString();

                    txt_MALOAIMUC_Validating(new object(), new CancelEventArgs());
                    txt_SOMAUMA_Validating(new object(), new CancelEventArgs());
                    txt_SOHINHMA_Validating(new object(), new CancelEventArgs());
                    txt_MAQCTHANHPHAM_Validating(new object(), new CancelEventArgs());
                    txt_MAQCDONGGOI_Validating(new object(), new CancelEventArgs());
                    txt_MAQCLOAITHUNG_Validating(new object(), new CancelEventArgs());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCHUNGLOAI_CurrentChanged"); }
        }

        private string Save_Data(string _str_MAHIEU_PK)
        {
            DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity();
            _DmchungloaiEntity.Machungloai = txt_MACHUNGLOAI.Text.Trim();
            _DmchungloaiEntity.Tenchungloai = txt_TENCHUNGLOAI.Text.Trim();
            _DmchungloaiEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
            _DmchungloaiEntity.Trongluong = LIB.ConvertString.NumbertoDB(txt_TRONGLUONG.Text.Trim());
            try { _DmchungloaiEntity.Somau = Convert.ToInt32(txt_SOMAU.Text.Trim()); }
            catch { }
            try { _DmchungloaiEntity.Sohinh = Convert.ToInt32(txt_SOHINH.Text.Trim()); }
            catch { }
            _DmchungloaiEntity.Loaimuc = txt_LOAIMUC.Text.Trim();
            _DmchungloaiEntity.Ghichu = txt_GHICHU.Text.Trim();
            _DmchungloaiEntity.Rong = LIB.ConvertString.NumbertoDB(txt_RONG.Text.Trim());
            _DmchungloaiEntity.Dai = LIB.ConvertString.NumbertoDB(txt_DAI.Text.Trim());
            _DmchungloaiEntity.Somauma = txt_SOMAUMA.Text.Trim();
            _DmchungloaiEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
            _DmchungloaiEntity.Maqcdonggoi = txt_MAQCDONGGOI.Text.Trim();
            _DmchungloaiEntity.Tenqcdonggoi = txt_TENQCDONGGOI.Text.Trim();
            _DmchungloaiEntity.Maqcloaithung = txt_MAQCLOAITHUNG.Text.Trim();
            _DmchungloaiEntity.Tenqcloaithung = txt_TENQCLOAITHUNG.Text.Trim();
            _DmchungloaiEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
            _DmchungloaiEntity.Tenqcthanhpham = txt_TENQCTHANHPHAM.Text.Trim();
            _DmchungloaiEntity.Maloaimuc = txt_MALOAIMUC.Text.Trim();
            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _DmchungloaiEntity.Ngaytao = DateTime.Now;
                _DmchungloaiEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _DmchungloaiManager.InsertV2(_DmchungloaiEntity, r_Insert, DT_DMCHUNGLOAI, BS_DMCHUNGLOAI);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_DmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_DMCHUNGLOAI.ResetCurrentItem();
            }
            else
            {
                _DmchungloaiEntity.Ngaysua = DateTime.Now;
                _DmchungloaiEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _DmchungloaiManager.Update(_DmchungloaiEntity);
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Machungloai.Name].Value = _DmchungloaiEntity.Machungloai;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenchungloai.Name].Value = _DmchungloaiEntity.Tenchungloai;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Kichthuoc.Name].Value = _DmchungloaiEntity.Kichthuoc;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Trongluong.Name].Value = _DmchungloaiEntity.Trongluong;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Somau.Name].Value = _DmchungloaiEntity.Somau;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Sohinh.Name].Value = _DmchungloaiEntity.Sohinh;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Loaimuc.Name].Value = _DmchungloaiEntity.Loaimuc;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Ghichu.Name].Value = _DmchungloaiEntity.Ghichu;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Rong.Name].Value = _DmchungloaiEntity.Rong;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Dai.Name].Value = _DmchungloaiEntity.Dai;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Somauma.Name].Value = _DmchungloaiEntity.Somauma;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Sohinhma.Name].Value = _DmchungloaiEntity.Sohinhma;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maqcdonggoi.Name].Value = _DmchungloaiEntity.Maqcdonggoi;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenqcdonggoi.Name].Value = _DmchungloaiEntity.Tenqcdonggoi;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maqcloaithung.Name].Value = _DmchungloaiEntity.Maqcloaithung;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenqcloaithung.Name].Value = _DmchungloaiEntity.Tenqcloaithung;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maqcthanhpham.Name].Value = _DmchungloaiEntity.Maqcthanhpham;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Tenqcthanhpham.Name].Value = _DmchungloaiEntity.Tenqcthanhpham;
                GRID_DMCHUNGLOAI.CurrentRow.Cells[DmchungloaiFields.Maloaimuc.Name].Value = _DmchungloaiEntity.Maloaimuc;
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchungloaiManager.Convert(_DmchungloaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_SOMAU.Text = txt_SOHINH.Text = txt_LOAIMUC.Text = txt_TENQCDONGGOI.Text = txt_TENQCLOAITHUNG.Text = txt_TENQCTHANHPHAM.Text = string.Empty;            
            DmchungloaiManager _DmchungloaiManager = new DmchungloaiManager();
            DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity();
            r_Insert = DT_DMCHUNGLOAI.NewRow();
            DT_DMCHUNGLOAI.Rows.Add(r_Insert);
            BS_DMCHUNGLOAI.Position = DT_DMCHUNGLOAI.Rows.Count;
            MAHIEU_PK = "";
            txt_MACHUNGLOAI.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_SOMAU, txt_SOHINH, txt_LOAIMUC, txt_TENQCDONGGOI, txt_TENQCLOAITHUNG, txt_TENQCTHANHPHAM }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_DMCHUNGLOAI.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_MACHUNGLOAI, txt_SOMAU, txt_SOHINH, txt_LOAIMUC, txt_TENQCDONGGOI, txt_TENQCLOAITHUNG, txt_TENQCTHANHPHAM }));
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

        #region Validate
        private void txt_MALOAIMUC_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MALOAIMUC.Text.Trim()) || DT_LOAIMUC == null || DT_LOAIMUC.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MALOAIMUC.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_LOAIMUC);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_LOAIMUC, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MALOAIMUC.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_LOAIMUC.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_LOAIMUC.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }
        private DataRow checkmaQuycach(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmquycachFields.Maquycach.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_SOMAUMA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOMAUMA.Text.Trim()) || DT_SOMAU == null || DT_SOMAU.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_SOMAUMA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_SOMAU);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_SOMAU, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOMAUMA.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_SOMAU.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_SOMAU.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_SOHINHMA_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_SOHINHMA.Text.Trim()) || DT_SOHINH == null || DT_SOHINH.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_SOHINHMA.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_SOHINH);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_SOHINH, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_SOHINHMA.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_SOHINH.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_SOHINH.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_MAQCTHANHPHAM_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQCTHANHPHAM.Text.Trim()) || DT_QCTHANHPHAM == null || DT_QCTHANHPHAM.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQCTHANHPHAM.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_QCTHANHPHAM);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_QCTHANHPHAM, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQCTHANHPHAM.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENQCTHANHPHAM.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENQCTHANHPHAM.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_MAQCDONGGOI_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQCDONGGOI.Text.Trim()) || DT_QCDONGGOI == null || DT_QCDONGGOI.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQCDONGGOI.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_QCDONGGOI);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_QCDONGGOI, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQCDONGGOI.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENQCDONGGOI.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENQCDONGGOI.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }

        private void txt_MAQCLOAITHUNG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAQCLOAITHUNG.Text.Trim()) || DT_QCLOAITHUNG == null || DT_QCLOAITHUNG.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAQCLOAITHUNG.Text.Trim().ToUpper();
            _RowViewSelect = checkmaQuycach(Str_MASIEUTHI, DT_QCLOAITHUNG);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMQUYCACH.xml",
                        DT_QCLOAITHUNG, DmquycachFields.Maquycach.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAQCLOAITHUNG.Text = _RowViewSelect[DmquycachFields.Maquycach.Name].ToString();
                txt_TENQCLOAITHUNG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
            }
            else
                txt_TENQCLOAITHUNG.Text = _RowViewSelect[DmquycachFields.Tenquycach.Name].ToString();
        }
        #endregion

        #region Text Changed
        private void txt_KICHTHUOC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_KICHTHUOC.Text.Length > 0)
                {
                    int vtriX = txt_KICHTHUOC.Text.ToUpper().IndexOf('X');
                    if (vtriX <= 0) return;
                    txt_RONG.Text = txt_KICHTHUOC.Text.Substring(0, vtriX);
                    txt_DAI.Text = txt_KICHTHUOC.Text.Substring(vtriX + 1);
                }
            }
            catch { }
        }

        #endregion

        #region Shortcut Key
        private void txt_MALOAIMUC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_LOAIMUC = new DmquycachManager().SelectByManhomRDT("N04");
            }
        }

        private void txt_SOMAUMA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_SOMAU = new DmquycachManager().SelectByManhomRDT("N01");
            }
        }
        private void txt_SOHINHMA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_SOHINH = new DmquycachManager().SelectByManhomRDT("N03");
            }
        }
        private void txt_MAQCTHANHPHAM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_QCTHANHPHAM = new DmquycachManager().SelectByManhomRDT("N06");
            }
        }
        private void txt_MAQCDONGGOI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_QCDONGGOI = new DmquycachManager().SelectByManhomRDT("N07");
            }
        }
        private void txt_MAQCLOAITHUNG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMQUYCACH frm_Dm = new FRM_DMQUYCACH();
                frm_Dm.Text = "Danh mục quy cách";
                frm_Dm.ShowDialog();
                DT_QCLOAITHUNG = new DmquycachManager().SelectByManhomRDT("N08");
            }
        }
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
