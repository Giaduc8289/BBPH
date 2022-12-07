
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquahoanthienEnt
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.BBPH.BLL;
using GD.BBPH.DAL;
using GD.BBPH.DAL.EntityClasses;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.EntityClasses
{
	public class KetquahoanthienEnt : KetquahoanthienEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquahoanthienEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUAHOANTHIEN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUAHOANTHIEN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUAHOANTHIEN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquahoanthienFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquahoanthienFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[KetquahoanthienFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KetquahoanthienFields.Ca.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KetquahoanthienFields.Mamay.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquahoanthienFields.Tenmay.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KetquahoanthienFields.Masanpham.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquahoanthienFields.Tensanpham.Name].ToString();
					txt_MACONGNHAN.Text = _Rowview.Row[KetquahoanthienFields.Macongnhan.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquahoanthienFields.Tencongnhan.Name].ToString();
					txt_DAURACHIAGHEP.Text = _Rowview.Row[KetquahoanthienFields.Daurachiaghep.Name].ToString();
					txt_DAUVAOMET.Text = _Rowview.Row[KetquahoanthienFields.Dauvaomet.Name].ToString();
					txt_DAUVAOKG.Text = _Rowview.Row[KetquahoanthienFields.Dauvaokg.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquahoanthienFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquahoanthienFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquahoanthienFields.Thoigianchuanbi.Name].ToString();
					txt_THOIGIANLENHACUON.Text = _Rowview.Row[KetquahoanthienFields.Thoigianlenhacuon.Name].ToString();
					txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquahoanthienFields.Thoigiancatdau.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquahoanthienFields.Thoigiansuco.Name].ToString();
					txt_KETQUATUI.Text = _Rowview.Row[KetquahoanthienFields.Ketquatui.Name].ToString();
					txt_PHEIN.Text = _Rowview.Row[KetquahoanthienFields.Phein.Name].ToString();
					txt_PHEGHEP.Text = _Rowview.Row[KetquahoanthienFields.Pheghep.Name].ToString();
					txt_PHECHIA.Text = _Rowview.Row[KetquahoanthienFields.Phechia.Name].ToString();
					txt_PHEBIEN.Text = _Rowview.Row[KetquahoanthienFields.Phebien.Name].ToString();
					txt_PHETHOI.Text = _Rowview.Row[KetquahoanthienFields.Phethoi.Name].ToString();
					txt_PHECHINHMAY.Text = _Rowview.Row[KetquahoanthienFields.Phechinhmay.Name].ToString();
					txt_PHEKHAC.Text = _Rowview.Row[KetquahoanthienFields.Phekhac.Name].ToString();
					txt_KIEMTRA.Text = _Rowview.Row[KetquahoanthienFields.Kiemtra.Name].ToString();
					txt_CHATLUONGTUI.Text = _Rowview.Row[KetquahoanthienFields.Chatluongtui.Name].ToString();
					txt_NANGSUAT.Text = _Rowview.Row[KetquahoanthienFields.Nangsuat.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquahoanthienFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquahoanthienFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquahoanthienFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquahoanthienFields.Nguoisua.Name].ToString();
					txt_MATRUONGCA.Text = _Rowview.Row[KetquahoanthienFields.Matruongca.Name].ToString();
					txt_TENTRUONGCA.Text = _Rowview.Row[KetquahoanthienFields.Tentruongca.Name].ToString();
					txt_TOCDODINHMUC.Text = _Rowview.Row[KetquahoanthienFields.Tocdodinhmuc.Name].ToString();
					txt_LYDOSUCO.Text = _Rowview.Row[KetquahoanthienFields.Lydosuco.Name].ToString();
					txt_SOLENHSX.Text = _Rowview.Row[KetquahoanthienFields.Solenhsx.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUAHOANTHIEN_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUAHOANTHIEN_PK)
		{
			KetquahoanthienEntity _KetquahoanthienEntity = new KetquahoanthienEntity();
			try { _KetquahoanthienEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			_KetquahoanthienEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquahoanthienEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquahoanthienEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquahoanthienEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquahoanthienEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquahoanthienEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			try { _KetquahoanthienEntity.Daurachiaghep = System.Decimal.Parse(txt_DAURACHIAGHEP.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Dauvaomet = System.Decimal.Parse(txt_DAUVAOMET.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Dauvaokg = System.Decimal.Parse(txt_DAUVAOKG.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Thoigianbatdau = System.DateTime.Parse(txt_THOIGIANBATDAU.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Thoigianketthuc = System.DateTime.Parse(txt_THOIGIANKETTHUC.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Thoigianchuanbi = System.Decimal.Parse(txt_THOIGIANCHUANBI.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Thoigianlenhacuon = System.Decimal.Parse(txt_THOIGIANLENHACUON.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Thoigiancatdau = System.Decimal.Parse(txt_THOIGIANCATDAU.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Thoigiansuco = System.Decimal.Parse(txt_THOIGIANSUCO.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Ketquatui = System.Decimal.Parse(txt_KETQUATUI.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Phein = System.Decimal.Parse(txt_PHEIN.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Pheghep = System.Decimal.Parse(txt_PHEGHEP.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Phechia = System.Decimal.Parse(txt_PHECHIA.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Phebien = System.Decimal.Parse(txt_PHEBIEN.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Phethoi = System.Decimal.Parse(txt_PHETHOI.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Phechinhmay = System.Decimal.Parse(txt_PHECHINHMAY.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Phekhac = System.Decimal.Parse(txt_PHEKHAC.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Kiemtra = System.Decimal.Parse(txt_KIEMTRA.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Chatluongtui = System.Decimal.Parse(txt_CHATLUONGTUI.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Nangsuat = System.Decimal.Parse(txt_NANGSUAT.Text.Trim()); } 
			catch { }
			try { _KetquahoanthienEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KetquahoanthienEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KetquahoanthienEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KetquahoanthienEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquahoanthienEntity.Matruongca = txt_MATRUONGCA.Text.Trim();
			_KetquahoanthienEntity.Tentruongca = txt_TENTRUONGCA.Text.Trim();
			try { _KetquahoanthienEntity.Tocdodinhmuc = System.Decimal.Parse(txt_TOCDODINHMUC.Text.Trim()); } 
			catch { }
			_KetquahoanthienEntity.Lydosuco = txt_LYDOSUCO.Text.Trim();
			_KetquahoanthienEntity.Solenhsx = txt_SOLENHSX.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KETQUAHOANTHIEN_PK))
			{
				_str_KETQUAHOANTHIEN_PK = _KetquahoanthienManager.InsertV2(_KetquahoanthienEntity, r_Insert, DT_KETQUAHOANTHIEN, BS_KETQUAHOANTHIEN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquahoanthienManager.Convert(_KetquahoanthienEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUAHOANTHIEN.ResetCurrentItem();
			}
			else
			{
				_KetquahoanthienManager.Update(_KetquahoanthienEntity);
				
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Id.Name].Value = _KetquahoanthienEntity.Id;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Ngay.Name].Value = _KetquahoanthienEntity.Ngay;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Ca.Name].Value = _KetquahoanthienEntity.Ca;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Mamay.Name].Value = _KetquahoanthienEntity.Mamay;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Tenmay.Name].Value = _KetquahoanthienEntity.Tenmay;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Masanpham.Name].Value = _KetquahoanthienEntity.Masanpham;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Tensanpham.Name].Value = _KetquahoanthienEntity.Tensanpham;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Macongnhan.Name].Value = _KetquahoanthienEntity.Macongnhan;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Tencongnhan.Name].Value = _KetquahoanthienEntity.Tencongnhan;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Daurachiaghep.Name].Value = _KetquahoanthienEntity.Daurachiaghep;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Dauvaomet.Name].Value = _KetquahoanthienEntity.Dauvaomet;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Dauvaokg.Name].Value = _KetquahoanthienEntity.Dauvaokg;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Thoigianbatdau.Name].Value = _KetquahoanthienEntity.Thoigianbatdau;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Thoigianketthuc.Name].Value = _KetquahoanthienEntity.Thoigianketthuc;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Thoigianchuanbi.Name].Value = _KetquahoanthienEntity.Thoigianchuanbi;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Thoigianlenhacuon.Name].Value = _KetquahoanthienEntity.Thoigianlenhacuon;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Thoigiancatdau.Name].Value = _KetquahoanthienEntity.Thoigiancatdau;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Thoigiansuco.Name].Value = _KetquahoanthienEntity.Thoigiansuco;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Ketquatui.Name].Value = _KetquahoanthienEntity.Ketquatui;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Phein.Name].Value = _KetquahoanthienEntity.Phein;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Pheghep.Name].Value = _KetquahoanthienEntity.Pheghep;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Phechia.Name].Value = _KetquahoanthienEntity.Phechia;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Phebien.Name].Value = _KetquahoanthienEntity.Phebien;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Phethoi.Name].Value = _KetquahoanthienEntity.Phethoi;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Phechinhmay.Name].Value = _KetquahoanthienEntity.Phechinhmay;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Phekhac.Name].Value = _KetquahoanthienEntity.Phekhac;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Kiemtra.Name].Value = _KetquahoanthienEntity.Kiemtra;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Chatluongtui.Name].Value = _KetquahoanthienEntity.Chatluongtui;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Nangsuat.Name].Value = _KetquahoanthienEntity.Nangsuat;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Ngaytao.Name].Value = _KetquahoanthienEntity.Ngaytao;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Nguoitao.Name].Value = _KetquahoanthienEntity.Nguoitao;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Ngaysua.Name].Value = _KetquahoanthienEntity.Ngaysua;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Nguoisua.Name].Value = _KetquahoanthienEntity.Nguoisua;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Matruongca.Name].Value = _KetquahoanthienEntity.Matruongca;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Tentruongca.Name].Value = _KetquahoanthienEntity.Tentruongca;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Tocdodinhmuc.Name].Value = _KetquahoanthienEntity.Tocdodinhmuc;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Lydosuco.Name].Value = _KetquahoanthienEntity.Lydosuco;
				GRID_KETQUAHOANTHIEN.CurrentRow.Cells[KetquahoanthienFields.Solenhsx.Name].Value = _KetquahoanthienEntity.Solenhsx;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquahoanthienManager.Convert(_KetquahoanthienEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUAHOANTHIEN_PK;
		}

	}
}
