﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquaghepEnt
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
	public class KetquaghepEnt : KetquaghepEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquaghepEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUAGHEP_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUAGHEP.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUAGHEP.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquaghepFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquaghepFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[KetquaghepFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KetquaghepFields.Ca.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KetquaghepFields.Mamay.Name].ToString();
					txt_LENHGHEP.Text = _Rowview.Row[KetquaghepFields.Lenhghep.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KetquaghepFields.Masanpham.Name].ToString();
					txt_MACONGNHAN.Text = _Rowview.Row[KetquaghepFields.Macongnhan.Name].ToString();
					txt_DAURATUA.Text = _Rowview.Row[KetquaghepFields.Dauratua.Name].ToString();
					txt_MANGINMET.Text = _Rowview.Row[KetquaghepFields.ManginMet.Name].ToString();
					txt_MANGINKG.Text = _Rowview.Row[KetquaghepFields.ManginKg.Name].ToString();
					txt_MANGCAPMET.Text = _Rowview.Row[KetquaghepFields.MangcapMet.Name].ToString();
					txt_MANGCAPKG.Text = _Rowview.Row[KetquaghepFields.MangcapKg.Name].ToString();
					txt_SOLOPGHEP.Text = _Rowview.Row[KetquaghepFields.Solopghep.Name].ToString();
					txt_THUCTEMET.Text = _Rowview.Row[KetquaghepFields.ThucteMet.Name].ToString();
					txt_THUCTEKG.Text = _Rowview.Row[KetquaghepFields.ThucteKg.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquaghepFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquaghepFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquaghepFields.Thoigianchuanbi.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquaghepFields.Thoigiansuco.Name].ToString();
					txt_THUCTEKEO.Text = _Rowview.Row[KetquaghepFields.Thuctekeo.Name].ToString();
					txt_THUCTEDONGRAN.Text = _Rowview.Row[KetquaghepFields.Thuctedongran.Name].ToString();
					txt_THUCTEDUNGMOI.Text = _Rowview.Row[KetquaghepFields.Thuctedungmoi.Name].ToString();
					txt_PHEIN.Text = _Rowview.Row[KetquaghepFields.Phein.Name].ToString();
					txt_PHEGHEP.Text = _Rowview.Row[KetquaghepFields.Pheghep.Name].ToString();
					txt_PHENCC.Text = _Rowview.Row[KetquaghepFields.PheNcc.Name].ToString();
					txt_PHESX.Text = _Rowview.Row[KetquaghepFields.PheSx.Name].ToString();
					txt_PHETHOI.Text = _Rowview.Row[KetquaghepFields.Phethoi.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquaghepFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquaghepFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquaghepFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquaghepFields.Nguoisua.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquaghepFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquaghepFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquaghepFields.Tencongnhan.Name].ToString();
					txt_NANGSUAT.Text = _Rowview.Row[KetquaghepFields.Nangsuat.Name].ToString();
					txt_MATRUONGCA.Text = _Rowview.Row[KetquaghepFields.Matruongca.Name].ToString();
					txt_TENTRUONGCA.Text = _Rowview.Row[KetquaghepFields.Tentruongca.Name].ToString();
					txt_TOCDODINHMUC.Text = _Rowview.Row[KetquaghepFields.Tocdodinhmuc.Name].ToString();
					txt_LYDOSUCO.Text = _Rowview.Row[KetquaghepFields.Lydosuco.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[KetquaghepFields.Mamang.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[KetquaghepFields.Tenmang.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUAGHEP_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUAGHEP_PK)
		{
			KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity();
			try { _KetquaghepEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			_KetquaghepEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquaghepEntity.Lenhghep = txt_LENHGHEP.Text.Trim();
			_KetquaghepEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquaghepEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			try { _KetquaghepEntity.Dauratua = System.Decimal.Parse(txt_DAURATUA.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.ManginMet = System.Decimal.Parse(txt_MANGINMET.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.ManginKg = System.Decimal.Parse(txt_MANGINKG.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.MangcapMet = System.Decimal.Parse(txt_MANGCAPMET.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.MangcapKg = System.Decimal.Parse(txt_MANGCAPKG.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Solopghep = System.Int32.Parse(txt_SOLOPGHEP.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.ThucteMet = System.Decimal.Parse(txt_THUCTEMET.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.ThucteKg = System.Decimal.Parse(txt_THUCTEKG.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Thoigianbatdau = System.DateTime.Parse(txt_THOIGIANBATDAU.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Thoigianketthuc = System.DateTime.Parse(txt_THOIGIANKETTHUC.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Thoigianchuanbi = System.Decimal.Parse(txt_THOIGIANCHUANBI.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Thoigiansuco = System.Decimal.Parse(txt_THOIGIANSUCO.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Thuctekeo = System.Decimal.Parse(txt_THUCTEKEO.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Thuctedongran = System.Decimal.Parse(txt_THUCTEDONGRAN.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Thuctedungmoi = System.Decimal.Parse(txt_THUCTEDUNGMOI.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Phein = System.Decimal.Parse(txt_PHEIN.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Pheghep = System.Decimal.Parse(txt_PHEGHEP.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.PheNcc = System.Decimal.Parse(txt_PHENCC.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.PheSx = System.Decimal.Parse(txt_PHESX.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Phethoi = System.Decimal.Parse(txt_PHETHOI.Text.Trim()); } 
			catch { }
			try { _KetquaghepEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KetquaghepEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KetquaghepEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KetquaghepEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquaghepEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquaghepEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquaghepEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			try { _KetquaghepEntity.Nangsuat = System.Decimal.Parse(txt_NANGSUAT.Text.Trim()); } 
			catch { }
			_KetquaghepEntity.Matruongca = txt_MATRUONGCA.Text.Trim();
			_KetquaghepEntity.Tentruongca = txt_TENTRUONGCA.Text.Trim();
			try { _KetquaghepEntity.Tocdodinhmuc = System.Decimal.Parse(txt_TOCDODINHMUC.Text.Trim()); } 
			catch { }
			_KetquaghepEntity.Lydosuco = txt_LYDOSUCO.Text.Trim();
			_KetquaghepEntity.Mamang = txt_MAMANG.Text.Trim();
			_KetquaghepEntity.Tenmang = txt_TENMANG.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KETQUAGHEP_PK))
			{
				_str_KETQUAGHEP_PK = _KetquaghepManager.InsertV2(_KetquaghepEntity, r_Insert, DT_KETQUAGHEP, BS_KETQUAGHEP);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_KetquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUAGHEP.ResetCurrentItem();
			}
			else
			{
				_KetquaghepManager.Update(_KetquaghepEntity);
				
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Id.Name].Value = _KetquaghepEntity.Id;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ngay.Name].Value = _KetquaghepEntity.Ngay;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ca.Name].Value = _KetquaghepEntity.Ca;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Mamay.Name].Value = _KetquaghepEntity.Mamay;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Lenhghep.Name].Value = _KetquaghepEntity.Lenhghep;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Masanpham.Name].Value = _KetquaghepEntity.Masanpham;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Macongnhan.Name].Value = _KetquaghepEntity.Macongnhan;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Dauratua.Name].Value = _KetquaghepEntity.Dauratua;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ManginMet.Name].Value = _KetquaghepEntity.ManginMet;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ManginKg.Name].Value = _KetquaghepEntity.ManginKg;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.MangcapMet.Name].Value = _KetquaghepEntity.MangcapMet;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.MangcapKg.Name].Value = _KetquaghepEntity.MangcapKg;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Solopghep.Name].Value = _KetquaghepEntity.Solopghep;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ThucteMet.Name].Value = _KetquaghepEntity.ThucteMet;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ThucteKg.Name].Value = _KetquaghepEntity.ThucteKg;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianbatdau.Name].Value = _KetquaghepEntity.Thoigianbatdau;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianketthuc.Name].Value = _KetquaghepEntity.Thoigianketthuc;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianchuanbi.Name].Value = _KetquaghepEntity.Thoigianchuanbi;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigiansuco.Name].Value = _KetquaghepEntity.Thoigiansuco;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thuctekeo.Name].Value = _KetquaghepEntity.Thuctekeo;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thuctedongran.Name].Value = _KetquaghepEntity.Thuctedongran;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thuctedungmoi.Name].Value = _KetquaghepEntity.Thuctedungmoi;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Phein.Name].Value = _KetquaghepEntity.Phein;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Pheghep.Name].Value = _KetquaghepEntity.Pheghep;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.PheNcc.Name].Value = _KetquaghepEntity.PheNcc;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.PheSx.Name].Value = _KetquaghepEntity.PheSx;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Phethoi.Name].Value = _KetquaghepEntity.Phethoi;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ngaytao.Name].Value = _KetquaghepEntity.Ngaytao;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Nguoitao.Name].Value = _KetquaghepEntity.Nguoitao;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ngaysua.Name].Value = _KetquaghepEntity.Ngaysua;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Nguoisua.Name].Value = _KetquaghepEntity.Nguoisua;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tensanpham.Name].Value = _KetquaghepEntity.Tensanpham;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tenmay.Name].Value = _KetquaghepEntity.Tenmay;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tencongnhan.Name].Value = _KetquaghepEntity.Tencongnhan;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Nangsuat.Name].Value = _KetquaghepEntity.Nangsuat;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Matruongca.Name].Value = _KetquaghepEntity.Matruongca;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tentruongca.Name].Value = _KetquaghepEntity.Tentruongca;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tocdodinhmuc.Name].Value = _KetquaghepEntity.Tocdodinhmuc;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Lydosuco.Name].Value = _KetquaghepEntity.Lydosuco;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Mamang.Name].Value = _KetquaghepEntity.Mamang;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tenmang.Name].Value = _KetquaghepEntity.Tenmang;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_KetquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUAGHEP_PK;
		}

	}
}
