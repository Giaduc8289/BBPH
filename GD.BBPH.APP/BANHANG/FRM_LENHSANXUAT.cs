﻿using System;
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
using System.Data.SqlClient;

namespace GD.BBPH.APP.BANHANG
{
    public partial class FRM_LENHSANXUAT : FRM_DMPARENT
    {
        private LenhsanxuatManager _LenhsanxuatManager = new LenhsanxuatManager();
        private LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_LENHSANXUAT = new DataTable(), DT_DONHANG_H = new DataTable(), DT_DONHANG_D = new DataTable();
        private BindingSource BS_LENHSANXUAT = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_LENHSANXUAT = new GD.BBPH.CONTROL.JGridEX();
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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_LENHSANXUAT");
                        DT_LENHSANXUAT = LIB.Procedures.Loclenhsanxuat(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG);
                        DT_DONHANG_H = LIB.SESSION_START.DT_DONHANG_H;
                        //DT_DONHANG_D = LIB.SESSION_START.DT_DONHANG_D; //new DonhangDManager().SelectByMadonRDT();

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

        public FRM_LENHSANXUAT()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            LenhsanxuatManager _LenhsanxuatManager = new LenhsanxuatManager();
            //DataTable dt111 = LIB.Procedures.Loclenhsanxuat(Ngaydauthang, Ngaycuoithang);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LENHSANXUAT.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_LENHSANXUAT.xml", GRID_LENHSANXUAT, uiPanel0Container);
            //GRID_LENHSANXUAT.RootTable.Groups.Add(GRID_LENHSANXUAT.Tables[0].Columns[LenhsanxuatFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_LENHSANXUAT);
            BS_LENHSANXUAT = new BindingSource();
            BS_LENHSANXUAT.DataSource = Source_View;
            GRID_LENHSANXUAT.DataSource = BS_LENHSANXUAT;
            BS_LENHSANXUAT.CurrentChanged += new EventHandler(BS_LENHSANXUAT_CurrentChanged);
            BS_LENHSANXUAT_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_LENHSANXUAT_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_LENHSANXUAT.UpdateData();
                if (BS_LENHSANXUAT.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_LENHSANXUAT.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[LenhsanxuatFields.Solenhsx.Name].ToString();
                    txt_SOLSX.Text = _Rowview.Row[LenhsanxuatFields.Solenhsx.Name].ToString();
                    txt_NGAYPHATLENH.Text = _Rowview.Row[LenhsanxuatFields.Ngayphatlenh.Name].ToString();
                    txt_NGAYBATDAU.Text = _Rowview.Row[LenhsanxuatFields.Ngaybatdausx.Name].ToString();
                    txt_NGAYHOANTHANH.Text = _Rowview.Row[LenhsanxuatFields.Ngayhoanthanhsx.Name].ToString();

                    txt_MADON.Text = _Rowview.Row[LenhsanxuatFields.Madon.Name].ToString();
                    txt_NGAYDAT.Text = _Rowview.Row[LenhsanxuatFields.Ngaydat.Name].ToString();

                    txt_MAKHACH.Text = _Rowview.Row[LenhsanxuatFields.Makhach.Name].ToString();
                    txt_TENKHACH.Text = _Rowview.Row[LenhsanxuatFields.Tenkhach.Name].ToString();
                    txt_MADONCHITIET.Text = _Rowview.Row[LenhsanxuatFields.Madonhangchitiet.Name].ToString();
                    txt_MASP.Text = _Rowview.Row[LenhsanxuatFields.Masp.Name].ToString();
                    txt_TENSP.Text = _Rowview.Row[LenhsanxuatFields.Tenhang.Name].ToString();
                    txt_SOLUONG.Text = _Rowview.Row[LenhsanxuatFields.Soluong.Name].ToString();
                    txt_NGAYGIAO.Text = _Rowview.Row[LenhsanxuatFields.Ngaygiao.Name].ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_LENHSANXUAT_CurrentChanged"); }
        }

        private string Save_Data(string _str_MAHIEU_PK)
        {
            LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity();
            _LenhsanxuatEntity.Solenhsx = txt_SOLSX.Text.Trim();
            _LenhsanxuatEntity.Ngayphatlenh = Convert.ToDateTime(txt_NGAYPHATLENH.Text.Trim());
            _LenhsanxuatEntity.Ngaybatdausx = Convert.ToDateTime(txt_NGAYBATDAU.Text.Trim());
            _LenhsanxuatEntity.Ngayhoanthanhsx = Convert.ToDateTime(txt_NGAYHOANTHANH.Text.Trim());
            _LenhsanxuatEntity.Madon = txt_MADON.Text.Trim();
            _LenhsanxuatEntity.Ngaydat = Convert.ToDateTime(txt_NGAYDAT.Text.Trim());
            _LenhsanxuatEntity.Makhach = txt_MAKHACH.Text.Trim();
            _LenhsanxuatEntity.Tenkhach = txt_TENKHACH.Text.Trim();
            try { _LenhsanxuatEntity.Madonhangchitiet = Convert.ToInt64(txt_MADONCHITIET.Text.Trim()); }
            catch { }
            _LenhsanxuatEntity.Masp = txt_MASP.Text.Trim();
            _LenhsanxuatEntity.Tenhang = txt_TENSP.Text.Trim();
            try { _LenhsanxuatEntity.Soluong = System.Decimal.Parse(txt_SOLUONG.Text.Trim()); }
            catch { }
            try { _LenhsanxuatEntity.Ngaygiao = Convert.ToDateTime(txt_NGAYGIAO.Text.Trim()); }
            catch { }

            if (string.IsNullOrEmpty(_str_MAHIEU_PK))
            {
                _LenhsanxuatEntity.Ngaytao = DateTime.Now;
                _LenhsanxuatEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                _str_MAHIEU_PK = _LenhsanxuatManager.InsertV2(_LenhsanxuatEntity, r_Insert, DT_LENHSANXUAT, BS_LENHSANXUAT);
                 GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LenhsanxuatManager.Convert(_LenhsanxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                BS_LENHSANXUAT.ResetCurrentItem();
            }
            else
            {
                _LenhsanxuatEntity.Ngaysua = DateTime.Now;
                _LenhsanxuatEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                _LenhsanxuatManager.Update(_LenhsanxuatEntity);
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Solenhsx.Name].Value = _LenhsanxuatEntity.Solenhsx;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngayphatlenh.Name].Value = _LenhsanxuatEntity.Ngayphatlenh;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaybatdausx.Name].Value = _LenhsanxuatEntity.Ngaybatdausx;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngayhoanthanhsx.Name].Value = _LenhsanxuatEntity.Ngayhoanthanhsx;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Madon.Name].Value = _LenhsanxuatEntity.Madon;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaydat.Name].Value = _LenhsanxuatEntity.Ngaydat;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Makhach.Name].Value = _LenhsanxuatEntity.Makhach;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Tenkhach.Name].Value = _LenhsanxuatEntity.Tenkhach;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Madonhangchitiet.Name].Value = _LenhsanxuatEntity.Madonhangchitiet;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Masp.Name].Value = _LenhsanxuatEntity.Masp;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Tenhang.Name].Value = _LenhsanxuatEntity.Tenhang;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Soluong.Name].Value = _LenhsanxuatEntity.Soluong;
                GRID_LENHSANXUAT.CurrentRow.Cells[LenhsanxuatFields.Ngaygiao.Name].Value = _LenhsanxuatEntity.Ngaygiao;

                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LenhsanxuatManager.Convert(_LenhsanxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            }
            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            r_Insert = DT_LENHSANXUAT.NewRow();
            DT_LENHSANXUAT.Rows.Add(r_Insert);
            BS_LENHSANXUAT.Position = DT_LENHSANXUAT.Rows.Count;
            MAHIEU_PK = "";
            txt_SOLSX.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_NGAYDAT, txt_MAKHACH, txt_TENKHACH, txt_TENSP, txt_SOLUONG, txt_NGAYGIAO }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            GRID_LENHSANXUAT.Enabled = false;
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_SOLSX, txt_NGAYDAT, txt_MAKHACH, txt_TENKHACH, txt_TENSP, txt_SOLUONG, txt_NGAYGIAO }));
                txt_MADON.Focus();
            }
            GRID_LENHSANXUAT.Enabled = false;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_LENHSANXUAT.Rows.Remove(r_Insert);
            }
            BS_LENHSANXUAT_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_LENHSANXUAT.Enabled = true;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            LenhsanxuatManager _LenhsanxuatManager = new LenhsanxuatManager();
            LenhsanxuatEntity _LenhsanxuatEntity = new LenhsanxuatEntity();
            _LenhsanxuatEntity = _LenhsanxuatManager.SelectOne(MAHIEU_PK);
            if (_LenhsanxuatEntity != null && MessageBox.Show("Xóa công nhân: " + MAHIEU_PK + " - " + txt_MADON.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _LenhsanxuatManager.Delete(MAHIEU_PK);
                    GRID_LENHSANXUAT.CurrentRow.Delete();
                    BS_LENHSANXUAT_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LenhsanxuatManager.Convert(_LenhsanxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa công nhân " + MAHIEU_PK + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_LENHSANXUAT.Enabled = true;
        }


        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && _LenhsanxuatManager.SelectOne(txt_SOLSX.Text.Trim()) != null)
            {
                MessageBox.Show("Mã công nhân bị trùng! \nNhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOLSX.Focus();
                return;
            }
            else if (txt_SOLSX.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập mã công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SOLSX.Focus();
                return;
            }
            else if (txt_MADON.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập tên công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MADON.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_LENHSANXUAT.Enabled = true;
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

        #region Validate

        private void txt_MADONHANG_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MADON.Text.Trim()) || DT_DONHANG_H == null || DT_DONHANG_H.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MADON.Text.Trim().ToUpper();
            _RowViewSelect = checkmadon(_str_MACANTIM, DT_DONHANG_H);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONHANG_H.xml",
                        DT_DONHANG_H, DonhangHFields.Madon.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MADON.Text = _RowViewSelect[DonhangHFields.Madon.Name].ToString();
                txt_NGAYDAT.Text = _RowViewSelect[DonhangHFields.Ngaydat.Name].ToString();
                txt_MAKHACH.Text = _RowViewSelect[DonhangHFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DonhangHFields.Tenkhach.Name].ToString();

                DT_DONHANG_D = new DonhangDManager().SelectByMadonRDT(txt_MADON.Text);
            }
            else
            {
                txt_NGAYDAT.Text = _RowViewSelect[DonhangHFields.Ngaydat.Name].ToString();
                txt_MAKHACH.Text = _RowViewSelect[DonhangHFields.Makhach.Name].ToString();
                txt_TENKHACH.Text = _RowViewSelect[DonhangHFields.Tenkhach.Name].ToString();

                DT_DONHANG_D = new DonhangDManager().SelectByMadonRDT(txt_MADON.Text);
            }
        }
        private DataRow checkmadon(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DonhangHFields.Madon.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void uiPanel1Container_Click(object sender, EventArgs e)
        {

        }

        private void txt_MASPCHITIET_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MASP.Text.Trim()) || DT_DONHANG_D == null || DT_DONHANG_D.Rows.Count == 0) return;
            string _str_MACANTIM = txt_MASP.Text.Trim().ToUpper();
            _RowViewSelect = checkmadonchitiet(_str_MACANTIM, DT_DONHANG_D);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DONHANG_D.xml",
                        DT_DONHANG_D, DonhangDFields.Madon.Name, _str_MACANTIM);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MASP.Text = _RowViewSelect[DonhangDFields.Masp.Name].ToString();
                txt_TENSP.Text = _RowViewSelect[DonhangDFields.Tenhang.Name].ToString();
                txt_SOLUONG.Text = _RowViewSelect[DonhangDFields.Soluong.Name].ToString();
                txt_NGAYGIAO.Text = _RowViewSelect[DonhangDFields.Ngaygiao.Name].ToString();
                txt_MADONCHITIET.Text = _RowViewSelect[DonhangDFields.Id.Name].ToString();
            }
            else
            {
                txt_TENSP.Text = _RowViewSelect[DonhangDFields.Tenhang.Name].ToString();
                txt_SOLUONG.Text = _RowViewSelect[DonhangDFields.Soluong.Name].ToString();
                txt_NGAYGIAO.Text = _RowViewSelect[DonhangDFields.Ngaygiao.Name].ToString();
                txt_MADONCHITIET.Text = _RowViewSelect[DonhangDFields.Id.Name].ToString();
            }
        }
        private DataRow checkmadonchitiet(string macantim, DataTable dt)
        {
            try
            {
                return dt.Select(DonhangDFields.Madon.Name + "=" + "'" + macantim + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion


        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_LENHSANXUAT.ColumnAutoResize = true;
            else
                GRID_LENHSANXUAT.ColumnAutoResize = false;
        }

        private void FRM_LENHSANXUAT_FormClosing(object sender, FormClosingEventArgs e)
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
