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

namespace GD.BBPH.APP.IN
{
    public partial class FRM_KQIN : FRM_DMPARENT
    {
        private KetquainManager _KetquainManager = new KetquainManager();
        private KetquainEntity _KetquainEntity = new KetquainEntity();
        private MenuroleEntity _MenuroleEntity = new MenuroleEntity();
        private DataTable DT_KQIN = new DataTable(), DT_KQIN_CHITIET_FILL = new DataTable(), DT_KQIN_CHITIET = new DataTable();
        private BindingSource BS_KQIN = new BindingSource(), BS_KQIN_CHITIET = new BindingSource();
        private DataRow r_Insert = null, _RowViewSelect = null;
        private GD.BBPH.CONTROL.JGridEX GRID_KQIN = new GD.BBPH.CONTROL.JGridEX();
        private GD.BBPH.CONTROL.JGridEX GRID_KQINCHITIET = new GD.BBPH.CONTROL.JGridEX();
        private string FUNCTION = "LOAD", MAHIEU_PK = "", MACHITIET="";
        private string MASP = "", CA="0";
        private DataTable DT_DMMAY = new DataTable(), DT_LENHIN = new DataTable(), DT_DMSP = new DataTable(), DT_NHANVIEN = new DataTable(), DT_DMKHACH = new DataTable();



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
                        _MenuroleEntity = MenuroleManager.Return_Current_Menurole("FRM_KQIN");
                        DT_KQIN = LIB.Procedures.Danhsachketquain(LIB.SESSION_START.TS_NGAYDAUTHANG, LIB.SESSION_START.TS_NGAYCUOITHANG, 0, string.Empty); // LIB.SESSION_START.DT_KQIN;
                        DT_KQIN_CHITIET = LIB.SESSION_START.DT_KQIN;

                        DT_DMMAY = new DmmayManager().SelectByMadmRDT("IN");// LIB.SESSION_START.DT_DMMAY;
                        DT_DMSP = LIB.SESSION_START.DM_HANG;
                        DT_NHANVIEN = LIB.SESSION_START.DT_DMCONGNHAN;
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

        public FRM_KQIN()
        {
            DateTime Ngaydauthang = LIB.SESSION_START.TS_NGAYDAUTHANG;
            DateTime Ngaycuoithang = LIB.SESSION_START.TS_NGAYCUOITHANG;
            InitializeComponent();
            KetquainManager _KetquainManager = new KetquainManager();
            DataTable dt111 = LIB.Procedures.Danhsachketquain(Ngaydauthang, Ngaycuoithang, Convert.ToInt32(CA), MASP);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQIN.xml");
            dt111 = LIB.Procedures.Danhsachketquainchitiet(MAHIEU_PK, Convert.ToInt32(CA), MASP);
            //GD.BBPH.LIB.GRID_COMM.Create_GRID_CONIG(dt111, LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQINCHITIET.xml");
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMDONG, btn_THEMDONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOADONG, btn_XOADONG.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_LUULAI, btn_LUULAI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_SUA, btn_SUA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_THEMMOI, btn_THEMMOI.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_XOA, btn_XOA.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_KHOIPHUC, btn_KHOIPHUC.Name + ".xml");
            GD.BBPH.CONTROL.BUTTON.Loadimage(LIB.PATH.BBPH_PATH, btn_Thoat, btn_Thoat.Name + ".xml");
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQIN.xml", GRID_KQIN, uiPanel0Container);
            GD.BBPH.LIB.GRID_COMM.LOAD_GRID_UIPanel(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_KQINCHITIET.xml", GRID_KQINCHITIET, pne_CHITIET);
            GRID_KQINCHITIET.DeletingRecord += GRID_KQINCHITIET_DeletingRecord;
            //GRID_KQIN.RootTable.Groups.Add(GRID_KQIN.Tables[0].Columns[KetquainFields.Phongban.Name]);
            FORM_PROCESS();
            DataView Source_View = new DataView(DT_KQIN);
            BS_KQIN = new BindingSource();
            BS_KQIN.DataSource = Source_View;
            GRID_KQIN.DataSource = BS_KQIN;
            BS_KQIN.CurrentChanged += new EventHandler(BS_KQIN_CurrentChanged);
            BS_KQIN_CurrentChanged((new object()), (new EventArgs()));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_LOAD, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            btn_THEMMOI.Focus();
        }

        void BS_KQIN_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
                GRID_KQIN.UpdateData();
                if (BS_KQIN.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQIN.Current;
                    if (_Rowview != null)
                        MAHIEU_PK = _Rowview.Row[KetquainFields.Ngay.Name].ToString();

                    txt_NGAY.Text = _Rowview.Row[KetquainFields.Ngay.Name].ToString();
                    txt_CA.Text = _Rowview.Row[KetquainFields.Ca.Name].ToString();
                    txt_MAMAY.Text = _Rowview.Row[KetquainFields.Mamay.Name].ToString();

                    //txt_TENKHO.Text = _Rowview.Row[KetquainFields.Tenkho.Name].ToString();
                    txt_MAMAY_Validating(new object(), new CancelEventArgs());

                    SHOWGRID(MAHIEU_PK);
                }
                else
                    SHOWGRID("");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KQIN_CurrentChanged"); }
        }

        void BS_KQIN_CHITIET_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (BS_KQIN_CHITIET.Current != null)
                {
                    DataRowView _Rowview = (DataRowView)this.BS_KQIN_CHITIET.Current;
                    if (_Rowview != null)
                        MACHITIET = _Rowview.Row[KetquainFields.Id.Name].ToString();

                    txt_LENHIN.Text = _Rowview.Row[KetquainFields.Lenhin.Name].ToString();
                    txt_MACONGNHAN.Text = _Rowview.Row[KetquainFields.Macongnhan.Name].ToString();
                    txt_MACONGNHAN_Validating(new object(), new CancelEventArgs());
                    txt_MASP.Text = _Rowview.Row[KetquainFields.Masanpham.Name].ToString();
                    txt_MASP_Validating(new object(), new CancelEventArgs());
                    txt_SOMLSX.Text = _Rowview.Row[KetquainFields.SometLsx.Name].ToString();
                    txt_SOMCAP.Text = _Rowview.Row[KetquainFields.Sometcap.Name].ToString();
                    txt_SOKGCAP.Text = _Rowview.Row[KetquainFields.Sokgcap.Name].ToString();
                    txt_THUCTEIN.Text = _Rowview.Row[KetquainFields.Thuctein.Name].ToString();
                    txt_SOKGIN.Text = _Rowview.Row[KetquainFields.Sokgin.Name].ToString();
                    txt_SAIHONGTHUCTE.Text = _Rowview.Row[KetquainFields.Saihongthucte.Name].ToString();
                    txt_PHENCC.Text = _Rowview.Row[KetquainFields.PheNcc.Name].ToString();
                    txt_PHESX.Text = _Rowview.Row[KetquainFields.PheSx.Name].ToString();
                    //txt_TONGM2DM.Text = _Rowview.Row[KetquainFields.Tongm2dm.Name].ToString();
                    //txt_M2SAIHONGTT.Text = _Rowview.Row[KetquainFields.M2saihongtt.Name].ToString();
                    txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquainFields.Thoigianbatdau.Name].ToString();
                    txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquainFields.Thoigianketthuc.Name].ToString();
                    txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquainFields.Thoigianchuanbi.Name].ToString();
                    txt_THOIGIANSUCO.Text = _Rowview.Row[KetquainFields.Thoigiansuco.Name].ToString();

                    txt_NANGSUAT.Text = _Rowview.Row[KetquainFields.Nangsuat.Name].ToString();
                    txt_TILESAIHONG.Text = _Rowview.Row[KetquainFields.Tylesaihong.Name].ToString();

                }
            }
            catch
            { }
        }
        private void SHOWGRID(string MAHIEU_PK)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK))
            {
                DT_KQIN_CHITIET_FILL = new KetquainManager().Clone();
                BS_KQIN_CHITIET = new BindingSource(DT_KQIN_CHITIET_FILL, null);
                GRID_KQINCHITIET.DataSource = BS_KQIN_CHITIET;
            }
            else
            {
                DT_KQIN_CHITIET_FILL = new KetquainManager().SelectByNgayCaMamayRDT(Convert.ToDateTime(txt_NGAY.Text.Trim()), Convert.ToInt32(txt_CA.Text.Trim()), txt_MAMAY.Text.Trim());

                DataView Source_View = new DataView(DT_KQIN_CHITIET_FILL);
                BS_KQIN_CHITIET = new BindingSource();
                BS_KQIN_CHITIET.DataSource = Source_View;
                GRID_KQINCHITIET.DataSource = BS_KQIN_CHITIET;
            }
            BS_KQIN_CHITIET.CurrentChanged += new EventHandler(BS_KQIN_CHITIET_CurrentChanged);
            BS_KQIN_CHITIET_CurrentChanged((new object()), (new EventArgs()));
        }

        #region Xu ly dong chi tiet
        private void btn_THEMDONG_Click(object sender, EventArgs e)
        {
            DataRow r_Detail = DT_KQIN_CHITIET_FILL.NewRow();
            r_Detail[KetquainFields.Lenhin.Name] = txt_LENHIN.Text;
            r_Detail[KetquainFields.Macongnhan.Name] = txt_MACONGNHAN.Text;
            r_Detail[KetquainFields.Tencongnhan.Name] = txt_TENCONGNHAN.Text;
            r_Detail[KetquainFields.Masanpham.Name] = txt_MASP.Text;
            r_Detail[KetquainFields.Tensanpham.Name] = txt_TENSP.Text;
            try { r_Detail[KetquainFields.SometLsx.Name] = LIB.ConvertString.NumbertoDB(txt_SOMLSX.Text.Trim()); }
            catch { }
            try { r_Detail[KetquainFields.Sometcap.Name] = LIB.ConvertString.NumbertoDB(txt_SOMCAP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquainFields.Sokgcap.Name] = LIB.ConvertString.NumbertoDB(txt_SOKGCAP.Text.Trim()); }
            catch { }
            try { r_Detail[KetquainFields.Thuctein.Name] = LIB.ConvertString.NumbertoDB(txt_THUCTEIN.Text.Trim()); }
            catch { }
            try { r_Detail[KetquainFields.Sokgin.Name] = LIB.ConvertString.NumbertoDB(txt_SOKGIN.Text.Trim()); }
            catch { }
            r_Detail[KetquainFields.Saihongthucte.Name] = LIB.ConvertString.NumbertoDB(txt_SAIHONGTHUCTE.Text.Trim());
            r_Detail[KetquainFields.PheNcc.Name] = LIB.ConvertString.NumbertoDB(txt_PHENCC.Text.Trim());
            r_Detail[KetquainFields.PheSx.Name] = LIB.ConvertString.NumbertoDB(txt_PHESX.Text.Trim());
            //r_Detail[KetquainFields.Tongm2dm.Name] = LIB.ConvertString.NumbertoDB(txt_TONGM2DM.Text.Trim());
            //r_Detail[KetquainFields.M2saihongtt.Name] = LIB.ConvertString.NumbertoDB(txt_M2SAIHONGTT.Text.Trim());
            r_Detail[KetquainFields.Thoigianbatdau.Name] = txt_THOIGIANBATDAU.Text;
            r_Detail[KetquainFields.Thoigianketthuc.Name] = txt_THOIGIANKETTHUC.Text;
            r_Detail[KetquainFields.Thoigianchuanbi.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim());
            r_Detail[KetquainFields.Thoigiansuco.Name] = LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
            r_Detail[KetquainFields.Nangsuat.Name] = LIB.ConvertString.NumbertoDB(txt_NANGSUAT.Text.Trim());
            r_Detail[KetquainFields.Tylesaihong.Name] = LIB.ConvertString.NumbertoDB(txt_TILESAIHONG.Text.Trim());


            DT_KQIN_CHITIET_FILL.Rows.Add(r_Detail);

            DataView Source_View = new DataView(DT_KQIN_CHITIET_FILL);
            BS_KQIN_CHITIET = new BindingSource();
            BS_KQIN_CHITIET.DataSource = Source_View;
            GRID_KQINCHITIET.DataSource = BS_KQIN_CHITIET;
            BS_KQIN_CHITIET.Position = DT_KQIN_CHITIET_FILL.Rows.Count;
            //Tinhtong();
            //txt_MAHANG.Focus();
        }
        private void btn_XOADONG_Click(object sender, EventArgs e)
        {
            DataRowView _view = (DataRowView)GRID_KQINCHITIET.CurrentRow.DataRow;
            string _MAHIEU_PK = _view[KetquainFields.Id.Name].ToString();
            string _MAMANG = _view[KetquainFields.Masanpham.Name].ToString();
            if (string.IsNullOrEmpty(_MAHIEU_PK) && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                GRID_KQINCHITIET.CurrentRow.Delete();
            }
            else
            {
                KetquainManager _KetquainManager = new KetquainManager();
                KetquainEntity _KetquainEntity = new KetquainEntity();
                try { _KetquainEntity = _KetquainManager.SelectOne(Convert.ToInt64(_MAHIEU_PK)); }
                catch { }
                if (_KetquainEntity != null && MessageBox.Show("Xóa dòng: " + _MAMANG, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                       System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        _KetquainManager.Delete(Convert.ToInt64(_MAHIEU_PK));
                        DataRow[] drArr = DT_KQIN_CHITIET_FILL.Select(KetquainFields.Id.Name + "='" + _MAHIEU_PK + "'");
                        DT_KQIN_CHITIET_FILL.Rows.Remove(drArr[0]);
                        //GRID_KQINCHITIET.CurrentRow.Delete();
                        //GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_PhieugiaohangHManager.Convert(_PhieugiaohangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa dòng " + _MAMANG + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    BS_KQIN_CHITIET.ResetCurrentItem();
                    GRID_KQINCHITIET.DataSource = BS_KQIN_CHITIET;
                }
                GRID_KQINCHITIET.Enabled = true;
            }
            //Tinhtong();
        }
        private void GRID_KQINCHITIET_DeletingRecord(object sender, RowActionCancelEventArgs e)
        {
            btn_XOADONG_Click(new object(), new EventArgs());
        }
        #endregion


        private string Save_Data(string _str_MAHIEU_PK)
        {
            DateTime _ngay = Convert.ToDateTime(txt_NGAY.Text.Trim());

            EntityCollection _KetquainEntityCol = new EntityCollection();
            GridEXRow[] listGrid = GRID_KQINCHITIET.GetDataRows();
            foreach (GridEXRow _grid in listGrid)
            {
                DataRowView _view = (DataRowView)_grid.DataRow;
                if (_view == null) continue;
                KetquainEntity _KetquainEntity = new KetquainEntity();
                _KetquainEntity.Ngay = _ngay;
                _KetquainEntity.Ca = Convert.ToInt32(txt_CA.Text.Trim());
                _KetquainEntity.Mamay = txt_MAMAY.Text.Trim();
                _KetquainEntity.Tenmay = txt_TENMAY.Text.Trim();
                _KetquainEntity.Lenhin = _view.Row[KetquainFields.Lenhin.Name].ToString();
                _KetquainEntity.Macongnhan = _view.Row[KetquainFields.Macongnhan.Name].ToString();
                _KetquainEntity.Tencongnhan = _view.Row[KetquainFields.Tencongnhan.Name].ToString();
                _KetquainEntity.Masanpham = _view.Row[KetquainFields.Masanpham.Name].ToString();
                _KetquainEntity.Tensanpham = _view.Row[KetquainFields.Tensanpham.Name].ToString();
                _KetquainEntity.SometLsx = Convert.ToDecimal(_view.Row[KetquainFields.SometLsx.Name].ToString());
                _KetquainEntity.Sometcap = Convert.ToDecimal(_view.Row[KetquainFields.Sometcap.Name].ToString());
                _KetquainEntity.Sokgcap = Convert.ToDecimal(_view.Row[KetquainFields.Sokgcap.Name].ToString());
                _KetquainEntity.Thuctein = Convert.ToDecimal(_view.Row[KetquainFields.Thuctein.Name].ToString());
                _KetquainEntity.Sokgin = Convert.ToDecimal(_view.Row[KetquainFields.Sokgin.Name].ToString());
                _KetquainEntity.Saihongthucte = Convert.ToDecimal(_view.Row[KetquainFields.Saihongthucte.Name].ToString());
                _KetquainEntity.PheNcc = Convert.ToDecimal(_view.Row[KetquainFields.PheNcc.Name].ToString());
                _KetquainEntity.PheSx = Convert.ToDecimal(_view.Row[KetquainFields.PheSx.Name].ToString());
                //_KetquainEntity.Tongm2dm = Convert.ToDecimal(_view.Row[KetquainFields.Tongm2dm.Name].ToString());
                //_KetquainEntity.M2saihongtt = Convert.ToDecimal(_view.Row[KetquainFields.M2saihongtt.Name].ToString());
                _KetquainEntity.Thoigianbatdau = Convert.ToDateTime(_view.Row[KetquainFields.Thoigianbatdau.Name].ToString());
                _KetquainEntity.Thoigianketthuc = Convert.ToDateTime(_view.Row[KetquainFields.Thoigianketthuc.Name].ToString());
                _KetquainEntity.Thoigianchuanbi = Convert.ToDecimal(_view.Row[KetquainFields.Thoigianchuanbi.Name].ToString());
                _KetquainEntity.Thoigiansuco = Convert.ToDecimal(_view.Row[KetquainFields.Thoigiansuco.Name].ToString());
                _KetquainEntity.Nangsuat = Convert.ToDecimal(_view.Row[KetquainFields.Nangsuat.Name].ToString());
                _KetquainEntity.Tylesaihong = Convert.ToDecimal(_view.Row[KetquainFields.Tylesaihong.Name].ToString());


                #region xét isnew
                try { _KetquainEntity.Id = Convert.ToInt64(_view[KetquainFields.Id.Name].ToString()); }
                catch { }

                _KetquainEntity.IsNew = _view.Row.RowState == DataRowState.Added ? true : false;
                if (_KetquainEntity.IsNew)
                {
                    EntityCollection drDHCT = (new KetquainManager()).SelectById(_KetquainEntity.Id);
                    if (drDHCT.Count > 0)
                    {
                        _KetquainEntity.Ngaysua = DateTime.Now;
                        _KetquainEntity.Nguoisua = LIB.SESSION_START.TS_USER_LOGIN;
                        _KetquainEntity.IsNew = false;
                    }
                    else
                    {
                        _KetquainEntity.Ngaytao = DateTime.Now;
                        _KetquainEntity.Nguoitao = LIB.SESSION_START.TS_USER_LOGIN;
                    }
                }
                #endregion
                if (!string.IsNullOrEmpty(_KetquainEntity.Masanpham))
                    _KetquainEntityCol.Add(_KetquainEntity);
               
            }

            _str_MAHIEU_PK = txt_NGAY.Text.Trim();

            foreach (KetquainEntity _KetquainEntity in _KetquainEntityCol)
            {
                if (_KetquainEntity.IsNew)
                {
                    DataRow _r_Insert = DT_KQIN_CHITIET.NewRow();
                    DT_KQIN_CHITIET.Rows.Add(_r_Insert);
                    _KetquainManager.InsertV2(_KetquainEntity, _r_Insert, DT_KQIN_CHITIET, BS_KQIN_CHITIET);
                }
                else _KetquainManager.Update(_KetquainEntity);
            }

            GRID_KQIN.CurrentRow.Cells[KetquainFields.Ngay.Name].Value = _ngay;
            GRID_KQIN.CurrentRow.Cells[KetquainFields.Ca.Name].Value = txt_CA.Text.Trim();
            GRID_KQIN.CurrentRow.Cells[KetquainFields.Mamay.Name].Value = txt_MAMAY.Text.Trim();

            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;

            return _str_MAHIEU_PK;
        }

        #region Button
        private void btn_THEMMOI_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { }));
            txt_NGAY.Text = txt_CA.Text = txt_MAMAY.Text = txt_TENMAY.Text = txt_LENHIN.Text = txt_MACONGNHAN.Text = txt_TENCONGNHAN.Text = txt_MASP.Text = txt_TENSP.Text = txt_SOMLSX.Text = txt_SOMCAP.Text = txt_SOKGCAP.Text = txt_THUCTEIN.Text = txt_SOKGIN.Text = txt_SAIHONGTHUCTE.Text = txt_PHENCC.Text = txt_PHESX.Text =
               /*txt_TONGM2DM.Text = txt_M2SAIHONGTT.Text = */txt_THOIGIANBATDAU.Text = txt_THOIGIANKETTHUC.Text = txt_THOIGIANCHUANBI.Text = txt_THOIGIANSUCO.Text = txt_NANGSUAT.Text = txt_TILESAIHONG.Text = string.Empty;
            r_Insert = DT_KQIN.NewRow();
            DT_KQIN.Rows.Add(r_Insert);
            BS_KQIN.Position = DT_KQIN.Rows.Count;
            MAHIEU_PK = "";
            txt_NGAY.Focus();
            TEXTBOX_Only_Control(false, null);
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSP, txt_TENMAY, txt_TILESAIHONG, txt_NANGSUAT }));
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_THEMMOI, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
            GRID_KQIN.Enabled = false;

            //---tu dong dien tham so
            txt_NGAY.Text = LIB.SESSION_START.TS_NGAYLAMVIEC.ToString("dd/MM/yyyy");
        }
        private void btn_SUA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK)) { return; }
            else
            {
                GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_SUA, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                btn_THEMDONG.Enabled = btn_XOADONG.Enabled = true;
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(true, uiPanel1Container, new List<Control>(new Control[] { txt_TENCONGNHAN, txt_TENSP, txt_TENMAY, txt_TILESAIHONG, txt_NANGSUAT }));
            }
            GRID_KQINCHITIET.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            GRID_KQINCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQINCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQINCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            GRID_KQINCHITIET.Enabled = true;
            GRID_KQIN.Enabled = false;
            btn_XOADONG.Enabled = true;
        }
        private void btn_KHOIPHUC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MAHIEU_PK) && r_Insert != null)
            {
                DT_KQIN.Rows.Remove(r_Insert);
            }
            BS_KQIN_CurrentChanged(new object(), new EventArgs());
            GD.BBPH.BLL.MenuroleManager.set_Enable_controls(GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_CANCEL, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
            btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
            FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, new List<Control>(new Control[] { }));
            GRID_KQIN.Enabled = true;
            GRID_KQINCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQINCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQINCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_XOA_Click(object sender, EventArgs e)
        {
            GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
            if (string.IsNullOrEmpty(MAHIEU_PK)) return;
            //_KetquainEntity = _KetquainManager.SelectOne(Convert.ToInt64(MAHIEU_PK));
            if (_KetquainEntity != null && MessageBox.Show("Xóa kết quả in: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text, "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                   System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    GridEXRow[] listGrid = GRID_KQINCHITIET.GetDataRows();
                    foreach (GridEXRow _grid in listGrid)
                    {
                        DataRowView _view = (DataRowView)_grid.DataRow;
                        if (_view == null) continue;
                        if (!string.IsNullOrEmpty(_view[KetquainFields.Id.Name].ToString()))
                        {
                            try { _KetquainManager.Delete(Convert.ToInt64(_view[KetquainFields.Id.Name].ToString())); }
                            catch { }
                        }
                    }
                    //_KetquainManager.Delete(Convert.ToInt64(MAHIEU_PK));
                    try { GRID_KQIN.CurrentRow.Delete(); }
                    catch { }
                    BS_KQIN_CurrentChanged(new object(), new EventArgs());
                    GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Đã xóa thành công!");
                    GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_DELETE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
                    btn_THEMDONG.Enabled = btn_XOADONG.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Không thể xóa kết quả in: Ngày " + txt_NGAY.Text + " Máy " + txt_MAMAY.Text + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            GRID_KQIN.Enabled = true;
            GRID_KQINCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQINCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            GRID_KQINCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
        private void btn_LUULAI_Click(object sender, EventArgs e)
        {
            if (txt_NGAY.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NGAY.Focus();
                return;
            }
            else if (txt_CA.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập ca!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_CA.Focus();
                return;
            }
            else if (txt_MAMAY.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MAMAY.Focus();
                return;
            }
            else
            {
                GD.BBPH.LIB.FORM_PROCESS_UTIL.enableControls(false, uiPanel1Container, null);
                MAHIEU_PK = Save_Data(MAHIEU_PK);
                GD.BBPH.LIB.TrayPopup.PoupStringMessage("Thông báo", "Lưu lại thành công");
                GRID_KQIN.Enabled = true;
                btn_THEMMOI.Focus();
                GRID_KQINCHITIET.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQINCHITIET.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
                GRID_KQINCHITIET.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validate

        private void txt_MAMAY_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MAMAY.Text.Trim()) || DT_DMMAY == null || DT_DMMAY.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MAMAY.Text.Trim().ToUpper();
            _RowViewSelect = checkmamay(Str_MASIEUTHI, DT_DMMAY);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMMAY.xml",
                        DT_DMMAY, DmmayFields.Mamay.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MAMAY.Text = _RowViewSelect[DmmayFields.Mamay.Name].ToString();
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
            else
            {
                txt_TENMAY.Text = _RowViewSelect[DmmayFields.Tenmay.Name].ToString();
            }
        }
        private DataRow checkmamay(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmmayFields.Mamay.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MASP_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MASP.Text.Trim()) || DT_DMSP == null || DT_DMSP.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MASP.Text.Trim().ToUpper();
            _RowViewSelect = checkmasp(Str_MASIEUTHI, DT_DMSP);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMHANG.xml",
                        DT_DMSP, DmhangFields.Masp.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MASP.Text = _RowViewSelect[DmhangFields.Masp.Name].ToString();
                txt_TENSP.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();

            }
            else
            {
                txt_TENSP.Text = _RowViewSelect[DmhangFields.Tensp.Name].ToString();
            }
        }
        private DataRow checkmasp(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmhangFields.Masp.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }

        private void txt_MACONGNHAN_Validating(object sender, CancelEventArgs e)
        {
            _RowViewSelect = null;
            if (string.IsNullOrEmpty(txt_MACONGNHAN.Text.Trim()) || DT_NHANVIEN == null || DT_NHANVIEN.Rows.Count == 0) return;
            string Str_MASIEUTHI = txt_MACONGNHAN.Text.Trim().ToUpper();
            _RowViewSelect = checkmacongnnhang(Str_MASIEUTHI, DT_NHANVIEN);
            if (_RowViewSelect == null)
            {
                ListviewJanus _frm_SingerRows_Select =
                    new ListviewJanus(LIB.PATH.BBPH_PATH + @"\XMLCONFIG\FRM_DMCONGNHAN.xml",
                        DT_NHANVIEN, DmcongnhanFields.Macn.Name, Str_MASIEUTHI);
                _frm_SingerRows_Select.ShowDialog();
                if (_frm_SingerRows_Select._RowViewSelect == null) return;
                _RowViewSelect = _frm_SingerRows_Select._RowViewSelect.Row;
                txt_MACONGNHAN.Text = _RowViewSelect[DmcongnhanFields.Macn.Name].ToString();
                txt_TENCONGNHAN.Text = _RowViewSelect[DmcongnhanFields.Tencongnhan.Name].ToString();

            }
            else
            {
                txt_TENCONGNHAN.Text = _RowViewSelect[DmcongnhanFields.Tencongnhan.Name].ToString();

            }
        }
        private DataRow checkmacongnnhang(string masieuthi, DataTable dt)
        {
            try
            {
                return dt.Select(DmcongnhanFields.Macn.Name + "=" + "'" + masieuthi + "'").CopyToDataTable().Rows[0];
            }
            catch { return null; }
        }
        #endregion

        #region  Text change
        private void Tinhnangsuat()
        {
            try
            {
                decimal _timerun = 0, _tocdo = 0, _somet = 0, _nangsuat = 0;
                _somet = LIB.ConvertString.NumbertoDB(txt_THUCTEIN.Text.Trim());
                _tocdo = LIB.Procedures.fTinhtocdomay(txt_MAMAY.Text, txt_MASP.Text);
                _timerun = Convert.ToDecimal((Convert.ToDateTime(txt_THOIGIANKETTHUC.Text) - Convert.ToDateTime(txt_THOIGIANBATDAU.Text)).TotalMinutes)
                    - LIB.ConvertString.NumbertoDB(txt_THOIGIANCHUANBI.Text.Trim()) - LIB.ConvertString.NumbertoDB(txt_THOIGIANSUCO.Text.Trim());
                _nangsuat = _somet / _tocdo / _timerun * 100;
                txt_NANGSUAT.Text = Math.Round(_nangsuat).ToString();
            }
            catch { }
        }

        private void txt_THOIGIAN_Validating(object sender, CancelEventArgs e)
        {
            Tinhnangsuat();
        }

        private void Tinhtylesaihong()
        {
            try
            {
                decimal _doday = 0, _rong = 0, _saihongthucte = 0, _tylesaihong = 0, _saihongdm = 0, _saihongphamuc = 0, _sangcuon = 0, _xulyloi = 0;
                _saihongthucte = LIB.ConvertString.NumbertoDB(txt_SAIHONGTHUCTE.Text.Trim());
                DmhangEntity _DmhangEntity = new DmhangManager().SelectOne(txt_MASP.Text);

                _doday = Convert.ToDecimal(_DmhangEntity.Doday);
                _rong = Convert.ToDecimal(_DmhangEntity.Rong);
                _saihongphamuc = LIB.Procedures.fTinhdinhmucsaihong(txt_MAMAY.Text, txt_MASP.Text, "DM03");
                _sangcuon = LIB.Procedures.fTinhdinhmucsaihong(txt_MAMAY.Text, txt_MASP.Text, "DM01");
                _xulyloi = LIB.Procedures.fTinhdinhmucsaihong(txt_MAMAY.Text, txt_MASP.Text, "DM02");
                _saihongdm = _doday / 1000 * _rong / 1000 * (_saihongphamuc + _sangcuon + _xulyloi) * Convert.ToDecimal(1.4);

                _tylesaihong = _saihongthucte / _saihongdm * 100;
                txt_TILESAIHONG.Text = Math.Round(_tylesaihong).ToString();
            }
            catch { }
        }

        private void txt_TYLESAIHONG_Validated(object sender, EventArgs e)
        {
            Tinhtylesaihong();
        }
        #endregion

        #region Shortcut Key
        private void txt_MAMAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMMAY frm_Dm = new FRM_DMMAY();
                frm_Dm.Text = "Danh mục máy";
                frm_Dm.ShowDialog();
                DT_DMMAY = new DmmayManager().SelectAllRDT();
            }
        }

        private void txt_MACONGNHAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMCONGNHAN frm_Dm = new FRM_DMCONGNHAN();
                frm_Dm.Text = "Danh mục công nhân";
                frm_Dm.ShowDialog();
                DT_NHANVIEN = new DmcongnhanManager().SelectAllRDT();
            }
        }

        private void txt_MASP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F4)
            {
                FRM_DMHANG frm_Dm = new FRM_DMHANG();
                frm_Dm.Text = "Danh mục hàng";
                frm_Dm.ShowDialog();
                DT_DMSP = new DmhangManager().SelectAllRDT();
            }
        }
        #endregion

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel0_Resize(object sender, EventArgs e)
        {
            if (uiPanel0.Width > 820)
                GRID_KQIN.ColumnAutoResize = true;
            else
                GRID_KQIN.ColumnAutoResize = false;
        }

        private void FRM_KQIN_FormClosing(object sender, FormClosingEventArgs e)
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
