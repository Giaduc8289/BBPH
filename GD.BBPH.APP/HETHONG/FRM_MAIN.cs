﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GD.BBPH.DAL.HelperClasses;
using GD.BBPH.BLL;
using XceedZipLib;
using System.Data.SqlClient;
using GD.BBPH.APP.LIB;
using GD.BBPH.CONTROL.MENUITEM;

namespace GD.BBPH.APP.HETHONG
{
    public partial class FRM_MAIN : GD.BBPH.APP.DANHMUC.FRM_DMPARENT
    {
        private System.Windows.Forms.MenuStrip _MenuStrip = new MenuStrip();
        private string isFunction = "LOAD", FORM_TITLE = "";
        private static DateTime _Ngaybanquyen = Convert.ToDateTime("30/03/2020"), _Ngayphathanh = Convert.ToDateTime("30/03/2020");
        private DataTable dt_MENU;
        private DataTable dt_MENU_Roles, DT_Logbackup = new DataTable();
        private DataRow r_Insert = null;

        public FRM_MAIN()
        {
            InitializeComponent();
            uiPanel_MENU.Height = 22;
            GetInfoVersion();
            uiPanel_MENU.Controls.Add(_MenuStrip);
            Form_Process();
            CreateMenu();
            _MenuStrip.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());
            //_MenuStrip.Renderer = new MyRenderer();
        }
        private void FRM_MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void Form_Process()
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
                    if (isFunction == "LOAD")
                    {
                        Giai();
                        dt_MENU = new MenuManager().SelectByIssudungRDT(1);//LIB.SESSION_START.DM_MENU;//_MenuManager.SelectByMadonviRDT(GD.BBPH.DATA.DMDONVI._Current.Madonvi);
                        dt_MENU_Roles = new MenuroleManager().SelectByRolesidRDT(GD.BBPH.APP.LIB.USERS._Rolesid);
                        //uiStatusBar1.Panels.
                        Janus.Windows.UI.StatusBar.UIStatusBarPanel panelNLV = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
                        panelNLV.Text = "Ngày làm việc: " + LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
                        panelNLV.Width = 180;
                        uiStatusBar2.Panels.Add(panelNLV);

                        Janus.Windows.UI.StatusBar.UIStatusBarPanel panelUser = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
                        panelUser.Text = "Người dùng: " + LIB.SESSION_START.TS_USER_LOGIN;
                        panelUser.Width = 180;
                        uiStatusBar2.Panels.Add(panelUser);

                        //Janus.Windows.UI.StatusBar.UIStatusBarPanel panelDonVi = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
                        //panelDonVi.Text = "Đơn vị: ";// +LIB.SESSION_START.TS_DONVISUDUNG;
                        //panelDonVi.AutoSize = StatusBarPanelAutoSize.Spring;
                        //uiStatusBar2.Panels.Add(panelDonVi);

                        Janus.Windows.UI.StatusBar.UIStatusBarPanel panelPhienBan = new Janus.Windows.UI.StatusBar.UIStatusBarPanel();
                        panelPhienBan.Text = string.Format("Phiên bản: {0}. {1}", SysInfo.VersionID, SysInfo.ProductDescription); ;
                        panelPhienBan.AutoSize = StatusBarPanelAutoSize.Spring;
                        uiStatusBar2.Panels.Add(panelPhienBan);

                        //// 2015-06-01 khanh comment 6 lines : update 'M_TEN_CQ1' va 'M_TEN_CQ2'

                        //GD.BBPH.DAL.EntityClasses.ThamsoEntity _ThamsoEntity = new DAL.EntityClasses.ThamsoEntity();
                        //_ThamsoEntity = new ThamsoManager().SelectOne("M_TEN_CQ1");
                        //_ThamsoEntity.Giatri = "";// LIB.SESSION_START.TS_DONVIQUANLY;
                        //new ThamsoManager().Update(_ThamsoEntity);
                        //_ThamsoEntity = new ThamsoManager().SelectOne("M_TEN_CQ2");
                        //_ThamsoEntity.Giatri = "";// LIB.SESSION_START.TS_DONVISUDUNG;
                        //new ThamsoManager().Update(_ThamsoEntity);

                        //MessageBox.Show("Ngày phát hành phiên bản là: " + _Ngayphathanh.ToShortDateString()
                        //    + "\nNgày cấp bản quyền là: " + _Ngaybanquyen.ToShortDateString()
                        //    + "\nSố ngày đã sử dụng đến khi phát hành phiên bản này là: " + (_Ngayphathanh - _Ngaybanquyen).TotalDays.ToString(), "Thông báo!");

                        #region Sao luu tu dong
                        try
                        {
                            string _thumucsaoluu = LIB.Procedures.Laygiatrithamso("Thumucsaoluu");
                            if (!System.IO.Directory.Exists(_thumucsaoluu))
                                System.IO.Directory.CreateDirectory(_thumucsaoluu);
                            if (!string.IsNullOrEmpty(_thumucsaoluu))
                            {
                                string _filebackup = _thumucsaoluu + "\\" + Properties.Settings.Default.ApplicationName
                                    + "_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0')
                                    + "_" + DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + ".bak";

                                int _maxMahieu = 1;
                                DataRow[] drLog = new LogbackupManager().SelectAllRDT().Select("", LogbackupFields.Mahieu.Name + " Desc");
                                if (drLog.Length > 0)
                                    _maxMahieu = Convert.ToInt32(drLog[0][LogbackupFields.Mahieu.Name].ToString()) + 1;
                                int _dinhkysaoluu = 0;
                                try
                                {
                                    _dinhkysaoluu = Convert.ToInt32(LIB.Procedures.Laygiatrithamso("Dinhkysaoluu"));
                                }
                                catch { }
                                DT_Logbackup = new LogbackupManager().SelectAllRDT();//.SelectByNamRDT(LIB.SESSION_START.TS_NGAYLAMVIEC);
                                if (DT_Logbackup.Rows.Count == 0)
                                {
                                    Cursor curr = this.Cursor;
                                    try
                                    {
                                        this.Cursor = Cursors.WaitCursor;
                                        GD.BBPH.APP.LIB.Procedures.Saoluudulieu(_filebackup);

                                        DT_Logbackup = new LogbackupManager().Clone();
                                        r_Insert = DT_Logbackup.NewRow();
                                        r_Insert[LogbackupFields.Mahieu.Name] = _maxMahieu;
                                        //r_Insert[LogbackupFields.Nam.Name] = LIB.SESSION_START.TS_NGAYLAMVIEC;
                                        r_Insert[LogbackupFields.Duongdan.Name] = _thumucsaoluu;
                                        r_Insert[LogbackupFields.Ngay.Name] = System.DateTime.Now.ToShortDateString();
                                        DT_Logbackup.Rows.Add(r_Insert);
                                        new LogbackupManager().Insert(new LogbackupManager().Convert(r_Insert));
                                        GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã sao lưu thành công CSDL!");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Sao lưu không thành công. Thực hiện lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        MessageBox.Show(ex.Message);
                                    }
                                    this.Cursor = curr;
                                }
                                else
                                {
                                    DataRow[] arrDt = DT_Logbackup.Select("", LogbackupFields.Ngay.Name + " Desc");
                                    DateTime _lastDate = Convert.ToDateTime(arrDt[0][LogbackupFields.Ngay.Name].ToString());
                                    if ((System.DateTime.Now.Date - _lastDate).TotalDays >= _dinhkysaoluu)
                                    {
                                        Cursor curr = this.Cursor;
                                        try
                                        {
                                            this.Cursor = Cursors.WaitCursor;
                                            GD.BBPH.APP.LIB.Procedures.Saoluudulieu(_filebackup);
                                            GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã sao lưu thành công CSDL!");

                                            r_Insert = DT_Logbackup.NewRow();
                                            r_Insert[LogbackupFields.Mahieu.Name] = _maxMahieu;
                                            //r_Insert[LogbackupFields.Nam.Name] = LIB.SESSION_START.TS_NGAYLAMVIEC;
                                            r_Insert[LogbackupFields.Duongdan.Name] = _thumucsaoluu;
                                            r_Insert[LogbackupFields.Ngay.Name] = System.DateTime.Now.ToShortDateString();
                                            DT_Logbackup.Rows.Add(r_Insert);
                                            new LogbackupManager().Insert(new LogbackupManager().Convert(r_Insert));
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Sao lưu không thành công. Thực hiện lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            MessageBox.Show(ex.Message);
                                        }
                                        this.Cursor = curr;
                                    }
                                }
                            }
                        }
                        catch { }
                        #endregion
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
                f.StartPosition = FormStartPosition.CenterScreen;
                f.ShowDialog();
            };
        }

        private void GetInfoVersion()
        {
            string CompanyName = SysInfo.CompanyName;
            string ProductVersion = SysInfo.ProductVersion;
            string VersionID = SysInfo.VersionID;
            string ProductName = SysInfo.ProductName;
            string ProductDescription = SysInfo.ProductDescription;
            string ProductTitle = SysInfo.ProductTitle;
            string CopyRightsDetail = SysInfo.CopyRightsDetail;

        }

        private void UnZip(string resFile, string desPath)
        {
            XceedZip _XceedZip = new XceedZip();
            _XceedZip.License("SFX45-GS44C-STWAN-YAAA");
            _XceedZip.ZipFilename = resFile;
            _XceedZip.PreservePaths = false;
            _XceedZip.UnzipToFolder = desPath;
            _XceedZip.FilesToProcess = "*.*";
            _XceedZip.EncryptionPassword = "CTHH­ngTrÇnV¨nNgäcNamX·2016";
            _XceedZip.Unzip();
        }

        private void UnZip(string resFile, string desPath, string encryptionPassword)
        {
            XceedZip _XceedZip = new XceedZip();
            _XceedZip.License("SFX45-GS44C-STWAN-YAAA");
            _XceedZip.ZipFilename = resFile;
            _XceedZip.PreservePaths = false;
            _XceedZip.UnzipToFolder = desPath;
            _XceedZip.FilesToProcess = "*.*";
            _XceedZip.EncryptionPassword = encryptionPassword;
            _XceedZip.Unzip();
        }

        private void Giai()
        {
            string filename = "";
            try
            {
                string tempPath = LIB.PATH.BBPH_PATH;//Path.GetTempPath();
                UnZip(LIB.PATH.BBPH_PATH + "\\GD.BBPHLIC.BIN", tempPath);
                string str = "", str1 = "", str2 = "", str11 = "", str21 = "", ngay = "";
                filename = tempPath + "\\VOS.LIC";
                if (!System.IO.File.Exists(filename)) return;
                StreamReader srd = new StreamReader(filename);
                try
                {
                    str = srd.ReadToEnd();
                    srd.Close();
                    System.IO.File.Delete(filename);
                }
                catch { }
                finally
                {
                    srd.Close();
                }
                System.IO.File.Delete(filename);

                if (!string.IsNullOrEmpty(str))
                {
                    ngay = str.Substring(0, 8);
                    try
                    {
                        _Ngaybanquyen = Convert.ToDateTime(ngay.Substring(0, 2) + "/" + ngay.Substring(2, 2) + "/" + ngay.Substring(4));
                    }
                    catch { }

                    str = str.Substring(8);
                    str1 = str.Substring(0, str.IndexOf("A")).Replace("\r\n", "");
                    str2 = str.Substring(str.IndexOf("A") + 1).Replace("\r\n", "");
                    int len = str1.Length / 50;
                    for (int i = 1; i <= len; i++)
                    {
                        string _str = str1.Substring((i - 1) * 50, 10);
                        _str = _str.Substring(5, 5) + _str.Substring(0, 5);
                        _str = Convert.ToChar((int.Parse(_str) - 1000000000) / i / 501).ToString();
                        str11 += _str;
                    }
                    //LIB.SESSION_START.TS_DONVIQUANLY = str11;
                    len = str2.Length / 50;
                    for (int i = 1; i <= len; i++)
                    {
                        string _str = str2.Substring((i - 1) * 50, 10);
                        _str = _str.Substring(5, 5) + _str.Substring(0, 5);
                        _str = Convert.ToChar((int.Parse(_str) - 1000000000) / (len - i + 1) / 521).ToString();
                        str21 += _str;
                    }
                    //LIB.SESSION_START.TS_DONVISUDUNG = str21;
                }
            }
            catch (Exception ex)
            {
                try
                {
                    System.IO.File.Delete(filename);
                }
                catch { }
            }
        }

        public void UpdateDB()
        {
            string filename = "";
            try
            {
                string tempPath = LIB.PATH.BBPH_PATH;// Path.GetTempPath();
                UnZip(LIB.PATH.BBPH_PATH + "\\UpdateDB.dat", tempPath, "CTHH­ngTrÇnV¨nNgäcNamX·2016");
                string str = "";
                filename = tempPath + "\\UpdateDB.sql";
                if (!System.IO.File.Exists(filename))
                {
                    MessageBox.Show("Cập nhật CSDL gặp lỗi, do tệp dữ liệu không tồn tại");
                    return;
                }
                //StreamReader srd = new StreamReader(filename);
                //try
                //{
                //    str = srd.ReadToEnd();
                //    srd.Close();
                //    System.IO.File.Delete(filename);
                //}
                //catch { }
                //finally
                //{
                //    srd.Close();
                //}
                //System.IO.File.Delete(filename);

                using (StreamReader sR = new StreamReader(filename))
                {
                    SqlConnection conn1 = new SqlConnection(LIB.SESSION_START.ConnectionStringKeyName);
                    conn1.Open();

                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = conn1;
                    string strCommand = "";
                    while (!sR.EndOfStream)
                    {
                        string strLine = sR.ReadLine();
                        if (strLine.Trim().ToUpper() != "GO") strCommand += '\n' + strLine;
                        if (strLine.Trim().ToUpper() == "GO" || sR.EndOfStream)
                        {
                            try
                            {
                                cmd1.CommandText = strCommand;
                                strCommand = "";
                                cmd1.ExecuteNonQuery();
                            }
                            catch { }
                        }
                    }

                    sR.Close();
                    conn1.Close();
                }

                System.IO.File.Delete(filename);
                MessageBox.Show("Cập nhật CSDL thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                System.IO.File.Delete(filename);
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateMenu()
        {
            try
            {
                DataTable dt_MENU_tem = dt_MENU.Select("MENUPARENT=''", MenuFields.Thutu.Name + " ASC").CopyToDataTable();
                foreach (DataRow drTemp in dt_MENU_tem.Rows)
                {
                    CreateMenuItem(drTemp);
                }
            }
            catch { }
        }
        private void CreateMenuItem(DataRow r)
        {
            string strMenu = r["MENUID"].ToString();
            ToolStripMenuItem mmru = new ToolStripMenuItem(GetMenuName(strMenu), null, new EventHandler(Menu_Click));
            //mmru.BackColor = Properties.Settings.Default.MenuColor;
            mmru.Name = strMenu;
            string filterExpression = "";
            filterExpression = "[Menuid] like '" + mmru.Name + "*'";//"[Menuid] ='" + mmru.Name + "'";
            DataRow[] rows = dt_MENU_Roles.Select(filterExpression);
            if (rows.Length > 0)
            {
                mmru.Enabled = true;
            }
            else
            {
                mmru.Enabled = false;
            }
            mmru.Name = strMenu;
            mmru.Tag = r[MenuFields.FormName.Name].ToString() + ";" + r[MenuFields.Param.Name].ToString(); ;

            try
            {
                mmru.Image = Image.FromFile(LIB.PATH.BBPH_PATH + @"\IMG\Icon\Menu\" + r[MenuFields.Icon.Name].ToString());
            }
            catch { }
            //tao menu cha
            _MenuStrip.Items.Add(mmru);
            //tao menu con 
            if (dt_MENU.Select("MENUPARENT='" + strMenu + "'").Length > 0)
            {
                foreach (DataRow drTemp in dt_MENU.Select("MENUPARENT='" + strMenu + "'"))
                {
                    //tao menu cap 3
                    CreateMenuItems(mmru, drTemp);
                }
            }
        }
        private string CreateMenuItems(ToolStripMenuItem mnuItem, DataRow r)
        {
            string strMenu = r["MENUID"].ToString();
            if (dt_MENU.Select("MENUPARENT='" + strMenu + "'").Length > 0)
            {
                ToolStripMenuItem mmru = new ToolStripMenuItem(GetMenuName(strMenu), null, new EventHandler(Menu_Click));
                //mmru.BackColor = Properties.Settings.Default.MenuColor;
                mmru.Name = strMenu;
                mmru.Tag = r[MenuFields.FormName.Name].ToString() + ";" + r[MenuFields.Param.Name].ToString(); //icon menu cap 1
                string filterExpression = "";
                filterExpression = "[Menuid] ='" + mmru.Name + "'";
                DataRow[] rows = dt_MENU_Roles.Select(filterExpression);
                if (rows.Length > 0)
                {
                    mmru.Enabled = true;
                }
                else
                {
                    mmru.Enabled = false;
                }
                try
                {
                    mmru.Image = Image.FromFile(LIB.PATH.BBPH_PATH + @"\IMG\Icon\Menu\" + r[MenuFields.Icon.Name].ToString());//icon menu cap 2
                }
                catch { }
                switch (r[MenuFields.LoaiMenu.Name].ToString())
                {
                    case "1":
                        mnuItem.DropDownItems.Add(mmru);
                        break;
                    case "2":
                        ExtendedToolStripSeparator _ToolStripSeparator = new ExtendedToolStripSeparator();
                        //_ToolStripSeparator.BackColor = Properties.Settings.Default.SeparatorColor;
                        mnuItem.DropDownItems.Add(_ToolStripSeparator);
                        break;
                }

                foreach (DataRow drTemp1 in dt_MENU.Select("MENUPARENT='" + strMenu + "'"))
                {
                    // gan bien public
                    //if (drTemp1[MenuFields.FormName.Name].ToString().Equals("  "))
                    //{
                    //    GD.BBPH.LIB.STATIC_PARAM.MANHOMKHACHANG = drTemp1[MenuFields.Param.Name].ToString();
                    //}
                    //if (drTemp1[MenuFields.FormName.Name].ToString().Equals("FRM_GIAODICHXUATSANXUAT"))
                    //{
                    //    GD.BBPH.LIB.STATIC_PARAM.MANHOMPHANXUONG = drTemp1[MenuFields.Param.Name].ToString();
                    //}
                    //if (drTemp1[MenuFields.FormName.Name].ToString().Equals("FRM_GIAODICHXUATSANXUAT"))
                    //{
                    //    GD.BBPH.LIB.STATIC_PARAM.MANHOMPHANXUONG = drTemp1[MenuFields.Param.Name].ToString();
                    //}
                    //if (drTemp1[MenuFields.FormName.Name].ToString().Equals("FRM_GIAODICHNHAPNGUYENLIEUDD"))
                    //{
                    //    GD.BBPH.LIB.STATIC_PARAM.MANHOMPHANXUONG = drTemp1[MenuFields.Param.Name].ToString();
                    //}
                    CreateMenuItems(mmru, drTemp1);
                }
            }
            else
            {
                ToolStripMenuItem mmru = new ToolStripMenuItem(GetMenuName(strMenu), null, new EventHandler(Menu_Click));
                //mmru.BackColor = Properties.Settings.Default.MenuColor;
                //mmru.Enabled = true;//GetMenuEnable(strMenu);
                mmru.Name = strMenu;
                mmru.Tag = r[MenuFields.FormName.Name].ToString() + ";" + r[MenuFields.Param.Name].ToString(); ;
                string filterExpression = "";
                filterExpression = "[Menuid] ='" + mmru.Name + "'";
                DataRow[] rows = dt_MENU_Roles.Select(filterExpression);
                if (rows.Length > 0)
                {
                    mmru.Enabled = true;
                }
                else
                {
                    mmru.Enabled = false;
                }
                try
                {
                    mmru.Image = Image.FromFile(LIB.PATH.BBPH_PATH + @"\IMG\Icon\Menu\" + r[MenuFields.Icon.Name].ToString());
                }
                catch { }
                switch (r[MenuFields.LoaiMenu.Name].ToString())
                {
                    case "1":
                        mnuItem.DropDownItems.Add(mmru);
                        break;
                    case "2":
                        ExtendedToolStripSeparator _ToolStripSeparator = new ExtendedToolStripSeparator();
                        //_ToolStripSeparator.ForeColor = Properties.Settings.Default.SeparatorColor;
                        mnuItem.DropDownItems.Add(_ToolStripSeparator);
                        break;
                }
                return strMenu;
            }
            return strMenu;
        }
        private string GetMenuName(string MenuID)
        {
            try
            {
                //lay ra ten menu theo ID truyen vao
                string MenuName = dt_MENU.Select("MENUID='" + MenuID + "'")[0][MenuFields.MenuName.Name].ToString();
                return MenuName;
                #region CAT BO KY TU DAU
                //string Value = MenuID;
                ////-----------khi ki tu dau la chu
                //string var11 = Value.Substring(0, 1);
                //string var12 = Value.Substring(1, 3);
                //try
                //{
                //    int t = int.Parse(var12);
                //    return "&" + var11 + " " + MenuName;
                //}
                //catch { }

                ////-----------khi ki tu dau va ki tu 2 la chu
                //string var21 = Value.Substring(0, 2);
                //string var22 = Value.Substring(2, 2);
                //try
                //{
                //    int t = int.Parse(var22);
                //    return "&" + var21.Substring(1,1) + " " + MenuName;
                //}
                //catch { }

                ////-----------khi ki tu dau va 2 ki tu nua la chu
                //string var31 = Value.Substring(0, 3);
                //string var32 = Value.Substring(3, 1);
                //try
                //{
                //    int t = int.Parse(var32);
                //    return "&" + var31.Substring(2, 1) + " " + MenuName;
                //}
                //catch { }
                #endregion

            }
            catch { }
            return "";
        }
        private void Menu_Click(object sender, System.EventArgs e)
        {
            Cursor curr;
            ToolStripMenuItem mmru = (ToolStripMenuItem)sender;
            DialogResult result = new DialogResult();
            string PTNX = "", MATKVTU = "";
            string menu_tag = ""; try { menu_tag = mmru.Tag.ToString().Split(';')[0]; }
            catch { }
            string menu_tag_param = ""; try { menu_tag_param = mmru.Tag.ToString().Split(';')[1]; }
            catch { }
            FORM_TITLE = mmru.Text;
            switch (menu_tag)
            {

                #region Hệ thống
                case "FRM_USERS":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_USERS") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.HETHONG.FRM_USERS()), mmru.Text);
                    break;
                case "RE":
                    //result = MessageBox.Show("Bạn có muốn đăng nhập lại chương trình?", "Thông báo", MessageBoxButtons.YesNo);
                    //if (result.Equals(DialogResult.Yes))
                    //{
                    //    Application.Restart();
                    //    break;
                    //}
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_CHONNGAYLAMVIEC") { frm.Activate(); return; }
                    }
                    ShowAsMDIChild((new GD.BBPH.APP.HETHONG.FRM_CHONNGAYLAMVIEC()), mmru.Text);
                    break;
                case "EX": //thoat chuong trinh 
                    result = MessageBox.Show("Thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo);
                    if (result.Equals(DialogResult.Yes))
                    {
                        //LIB.Procedures.Capnhatmanhdaha(LIB.SESSION_START.TS_NGAYLAMVIEC, LIB.SESSION_START.TS_NGAYLAMVIEC);
                        Application.Exit();
                        break;
                    }
                    break;
                case "FRM_MENU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_MENU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.HETHONG.FRM_MENU()), mmru.Text);
                    break;
                case "FRM_ROLES":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_ROLES") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.HETHONG.FRM_ROLES()), mmru.Text);
                    break;
                case "FRM_ROLES_MENU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_ROLES_MENU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.HETHONG.FRM_ROLES_MENU()), mmru.Text);
                    break;
                case "FRM_THAMSO":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_THAMSO") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.HETHONG.FRM_THAMSO()), mmru.Text);
                    break;
                case "FRM_SAOLUU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_SAOLUU") { frm.Activate(); return; }
                    }
                    ShowAsMDIChild((new GD.BBPH.APP.HETHONG.FRM_SAOLUU()), mmru.Text);
                    break;
                case "FRM_DOIMATKHAU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DOIMATKHAU") { frm.Activate(); return; }
                    }
                    ShowAsMDIChild((new GD.BBPH.APP.HETHONG.FRM_DOIMATKHAU()), mmru.Text);
                    break;
                #endregion

                #region Danh mục
                case "FRM_DMKHACH":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMKHACH") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMKHACH()), mmru.Text);
                    break;

                case "FRM_DMCHUNGLOAI":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMCHUNGLOAI") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMCHUNGLOAI()), mmru.Text);
                    break;


                case "FRM_CTPTMANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_CTPTMANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_CTPTMANG()), mmru.Text);
                    break;
                #region Danh mục bộ phận
                case "FRM_DMBOPHAN":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMBOPHAN") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMBOPHAN()), mmru.Text);
                    break;
                #endregion
                #region Danh mục dòng máy
                case "FRM_DMDONGMAY":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMDONGMAY") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMDONGMAY()), mmru.Text);
                    break;
                #endregion
                case "FRM_DMMAY":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMMAY") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMMAY()), mmru.Text);
                    break;
                case "FRM_CONGSUATMAY":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_CONGSUATMAY") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_CONGSUATMAY()), mmru.Text);
                    break;

                case "FRM_DMNHOMQUYCACH":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMNHOMQUYCACH") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMNHOMQUYCACH()), mmru.Text);
                    break;
                case "FRM_DMQUYCACH":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMQUYCACH") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMQUYCACH()), mmru.Text);
                    break;

                case "FRM_DMKHO":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMKHO") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMKHO()), mmru.Text);
                    break;

                case "FRM_LYDONHAPXUAT":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_LYDONHAPXUAT") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_LYDONHAPXUAT()), mmru.Text);
                    break;
                case "FRM_DMNHOMDINHMUC":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMNHOMDINHMUC") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMNHOMDINHMUC()), mmru.Text);
                    break;
                case "FRM_DMVATTUSAIHONG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMVATTUSAIHONG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMVATTUSAIHONG()), mmru.Text);
                    break;

                case "FRM_DINHMUCTHOIGIAN":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DINHMUCTHOIGIAN") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DINHMUCTHOIGIAN()), mmru.Text);
                    break;

                #region Danh mục công đoạn
                case "FRM_DMCONGDOAN":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMCONGDOAN") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMCONGDOAN()), mmru.Text);
                    break;
                #endregion
                #region Danh mục màng
                case "FRM_DMMANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMMANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMMANG()), mmru.Text);
                    break;
                #endregion

                #region Danh mục sản phẩm
                case "FRM_DMHANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMHANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMHANG()), mmru.Text);
                    break;
                #endregion

                #region Danh mục nhóm nguyên liệu
                case "FRM_DMNHOMNGUYENLIEU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMNHOMNGUYENLIEU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMNHOMNGUYENLIEU()), mmru.Text);
                    break;
                #endregion
                #region Danh mục nguyên liệu
                case "FRM_DMNGUYENLIEU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMNGUYENLIEU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMNGUYENLIEU()), mmru.Text);
                    break;
                #endregion

                case "FRM_DMCHUCVU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMCHUCVU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMCHUCVU()), mmru.Text);
                    break;

                #region Danh mục công nhân
                case "FRM_DMCONGNHAN":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMCONGNHAN") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMCONGNHAN()), mmru.Text);
                    break;
                #endregion

                case "FRM_DMMAU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DMMAU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.DANHMUC.FRM_DMMAU()), mmru.Text);
                    break;
                #endregion

                #region Bán hàng

                case "FRM_BAOGIA":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_BAOGIA") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.BANHANG.FRM_BAOGIA()), mmru.Text);
                    break;

                case "FRM_DONHANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_DONHANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.BANHANG.FRM_DONHANG()), mmru.Text);
                    break;

                case "FRM_HANGTRALAI":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_HANGTRALAI") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.BANHANG.FRM_HANGTRALAI()), mmru.Text);
                    break;

                case "FRM_PHIEUGIAOHANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_PHIEUGIAOHANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.BANHANG.FRM_PHIEUGIAOHANG()), mmru.Text);
                    break;
                #endregion

                #region Mua hàng
                #endregion

                #region Thổi
                case "FRM_KQTHOI":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KQTHOI") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.THOI.FRM_KQTHOI()), mmru.Text);
                    break;
                case "FRM_TKNLTHOI":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_TKNLTHOI") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.THOI.FRM_TKNLTHOI()), mmru.Text);
                    break;
                #endregion

                #region In
                case "FRM_KQIN":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KQIN") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.IN.FRM_KQIN()), mmru.Text);
                    break;

                #endregion

                #region Lọc
                #endregion

                #region Ghép
                case "FRM_KQGHEP":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KQGHEP") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.GHEP.FRM_KQGHEP()), mmru.Text);
                    break;
                #endregion

                #region Tua
                case "FRM_TKKQTUA":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_TKKQTUA") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.TUA.FRM_TKKQTUA()), mmru.Text);
                    break;
                #endregion

                #region Chia
                case "FRM_KQCHIA":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KQCHIA") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.CHIA.FRM_KQCHIA()), mmru.Text);
                    break;
                #endregion

                #region Hoàn thiện
                case "FRM_KQHOANTHIEN":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KQHOANTHIEN") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.HOANTHIEN.FRM_KQHOANTHIEN()), mmru.Text);
                    break;
                #endregion

                #region Kho

                case "FRM_NHAPSANPHAM":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_NHAPSANPHAM") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_NHAPSANPHAM()), mmru.Text);
                    break;

                case "FRM_KIEMKESANPHAM":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KIEMKESANPHAM") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_KIEMKESANPHAM()), mmru.Text);
                    break;

                case "FRM_XUATSANPHAM":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_XUATSANPHAM") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_XUATSANPHAM()), mmru.Text);
                    break;

                case "FRM_NHAPMANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_NHAPMANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_NHAPMANG()), mmru.Text);
                    break;

                case "FRM_KIEMKEMANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KIEMKEMANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_KIEMKEMANG()), mmru.Text);
                    break;

                case "FRM_NHAPKHONGUYENLIEU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_NHAPKHONGUYENLIEU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_NHAPKHONGUYENLIEU()), mmru.Text);
                    break;

                case "FRM_KIEMKENGUYENLIEU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_KIEMKENGUYENLIEU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_KIEMKENGUYENLIEU()), mmru.Text);
                    break;

                case "FRM_XUATMANG":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_XUATMANG") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_XUATMANG()), mmru.Text);
                    break;
                case "FRM_XUATNGUYENLIEU":
                    foreach (GD.BBPH.CONTROL.FORM frm in this.MdiChildren)
                    {
                        if (frm.Name == "FRM_XUATNGUYENLIEU") { frm.Activate(); frm.WindowState = FormWindowState.Maximized; return; }
                    }
                    ShowAsMDIChildMax((new GD.BBPH.APP.KHO.FRM_XUATNGUYENLIEU()), mmru.Text);
                    break;
                #endregion

                #region Tính giá
                #endregion

                #region Báo cáo
                #endregion

                #region Cửa sổ
                case "WI_LOP":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "WI_DUNG":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
                    break;
                case "WI_NGANG":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
                #endregion
            }
        }
        private void ShowAsMDIChild(GD.BBPH.CONTROL.FORM child)
        {
            child.Text = FORM_TITLE.ToUpper();
            child.MdiParent = this;
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Show();
        }
        private void ShowAsMDIChildTO(GD.BBPH.CONTROL.FORM child)
        {
            child.Text = FORM_TITLE.ToUpper();
            child.MdiParent = this;
            child.StartPosition = FormStartPosition.CenterScreen;
            //child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private void ShowAsMDIChild(GD.BBPH.CONTROL.FORM child, string _FORM_TITLE)
        {
            //foreach (Form frm in this.MdiChildren) frm.WindowState = FormWindowState.Normal; 
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            child.Text = _FORM_TITLE.ToUpper();
            child.MdiParent = this;
            child.StartPosition = FormStartPosition.CenterScreen;
            child.Show();
        }
        private void ShowAsMDIChildMax(GD.BBPH.CONTROL.FORM child, string _FORM_TITLE)
        {
            child.Text = _FORM_TITLE.ToUpper();
            child.MdiParent = this;
            child.StartPosition = FormStartPosition.CenterScreen;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.Azure : Color.Beige;
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }
    }

    class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Properties.Settings.Default.MenuColor;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Properties.Settings.Default.MenuColor;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Properties.Settings.Default.FormColor;
            }
        }
        //public override Color MenuItemBorder
        //{ get { return Color.Yellow; } }
        public override Color MenuItemPressedGradientBegin
        { get { return Properties.Settings.Default.MenuColor; } }
        public override Color MenuItemPressedGradientEnd
        { get { return Properties.Settings.Default.MenuColor; } }
        public override Color MenuItemPressedGradientMiddle
        { get { return Properties.Settings.Default.MenuColor; } }
        //public override Color MenuItemSelected
        //{ get { return Color.Red; } }
        //public override Color MenuItemSelectedGradientBegin
        //{ get { return Color.Yellow; } }
        //public override Color MenuItemSelectedGradientEnd
        //{ get { return Color.Yellow; } }

        //public override Color ToolStripGradientBegin
        //{ get { return Color.BlueViolet; } }

        //public override Color ToolStripGradientMiddle
        //{ get { return Color.CadetBlue; } }

        //public override Color ToolStripGradientEnd
        //{ get { return Color.CornflowerBlue; } }

        public override Color MenuStripGradientBegin
        { get { return Properties.Settings.Default.MenuColor; /*Color.Salmon;*/ } }

        public override Color MenuStripGradientEnd
        { get { return Properties.Settings.Default.MenuColor; /*Color.OrangeRed;*/ } }
    }


    public class ExtendedToolStripSeparator : ToolStripSeparator
    {
        public ExtendedToolStripSeparator()
        {
            this.Paint += ExtendedToolStripSeparator_Paint;
        }

        private void ExtendedToolStripSeparator_Paint(object sender, PaintEventArgs e)
        {
            // Get the separator's width and height.
            ToolStripSeparator toolStripSeparator = (ToolStripSeparator)sender;
            int width = toolStripSeparator.Width;
            int height = toolStripSeparator.Height;

            // Choose the colors for drawing.
            // I've used Color.White as the foreColor.
            Color foreColor = Properties.Settings.Default.SeparatorColor; //Color.FromName(Utilities.Constants.ControlsRelatedConstants.standardForeColorName);
            // Color.Teal as the backColor.
            Color backColor = Properties.Settings.Default.MenuColor; //Color.FromName(Utilities.Constants.ControlsRelatedConstants.standardBackColorName);

            //// Fill the background.
            //e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);

            // Draw the line.
            e.Graphics.DrawLine(new Pen(foreColor), 28, height / 2, width, height / 2);//4, height / 2, width - 4, height / 2);
        }
    }



}
