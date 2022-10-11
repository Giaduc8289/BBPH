
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

		void BS_Ketquaghep_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Ketquaghep.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Ketquaghep.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquaghepFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[KetquaghepFields.Id.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[KetquaghepFields.Ngay.Name].ToString();
					txt_Ca.Text = _Rowview.Row[KetquaghepFields.Ca.Name].ToString();
					txt_Mamay.Text = _Rowview.Row[KetquaghepFields.Mamay.Name].ToString();
					txt_Lenhghep.Text = _Rowview.Row[KetquaghepFields.Lenhghep.Name].ToString();
					txt_Masanpham.Text = _Rowview.Row[KetquaghepFields.Masanpham.Name].ToString();
					txt_Macongnhan.Text = _Rowview.Row[KetquaghepFields.Macongnhan.Name].ToString();
					txt_Dauratua.Text = _Rowview.Row[KetquaghepFields.Dauratua.Name].ToString();
					txt_ManginMet.Text = _Rowview.Row[KetquaghepFields.ManginMet.Name].ToString();
					txt_ManginKg.Text = _Rowview.Row[KetquaghepFields.ManginKg.Name].ToString();
					txt_MangcapMet.Text = _Rowview.Row[KetquaghepFields.MangcapMet.Name].ToString();
					txt_MangcapKg.Text = _Rowview.Row[KetquaghepFields.MangcapKg.Name].ToString();
					txt_Solopghep.Text = _Rowview.Row[KetquaghepFields.Solopghep.Name].ToString();
					txt_ThucteMet.Text = _Rowview.Row[KetquaghepFields.ThucteMet.Name].ToString();
					txt_ThucteKg.Text = _Rowview.Row[KetquaghepFields.ThucteKg.Name].ToString();
					txt_Thoigianbatdau.Text = _Rowview.Row[KetquaghepFields.Thoigianbatdau.Name].ToString();
					txt_Thoigianketthuc.Text = _Rowview.Row[KetquaghepFields.Thoigianketthuc.Name].ToString();
					txt_Thoigianchuanbi.Text = _Rowview.Row[KetquaghepFields.Thoigianchuanbi.Name].ToString();
					txt_Thoigiansuco.Text = _Rowview.Row[KetquaghepFields.Thoigiansuco.Name].ToString();
					txt_Thuctekeo.Text = _Rowview.Row[KetquaghepFields.Thuctekeo.Name].ToString();
					txt_Thuctedongran.Text = _Rowview.Row[KetquaghepFields.Thuctedongran.Name].ToString();
					txt_Thuctedungmoi.Text = _Rowview.Row[KetquaghepFields.Thuctedungmoi.Name].ToString();
					txt_Phein.Text = _Rowview.Row[KetquaghepFields.Phein.Name].ToString();
					txt_Pheghep.Text = _Rowview.Row[KetquaghepFields.Pheghep.Name].ToString();
					txt_PheNcc.Text = _Rowview.Row[KetquaghepFields.PheNcc.Name].ToString();
					txt_PheSx.Text = _Rowview.Row[KetquaghepFields.PheSx.Name].ToString();
					txt_Phethoi.Text = _Rowview.Row[KetquaghepFields.Phethoi.Name].ToString();
					txt_Pheintui.Text = _Rowview.Row[KetquaghepFields.Pheintui.Name].ToString();
					txt_Phegheptui.Text = _Rowview.Row[KetquaghepFields.Phegheptui.Name].ToString();
					txt_PhethoiNcc.Text = _Rowview.Row[KetquaghepFields.PhethoiNcc.Name].ToString();
					txt_Phesxtui.Text = _Rowview.Row[KetquaghepFields.Phesxtui.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[KetquaghepFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[KetquaghepFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[KetquaghepFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[KetquaghepFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Ketquaghep_CurrentChanged"); }
		}

		private string Save_Data(string _str_Ketquaghep_PK)
		{
			KetquaghepEntity _ketquaghepEntity = new KetquaghepEntity();
			
			_ketquaghepEntity.Id = txt_Id.Text.Trim();
			_ketquaghepEntity.Ngay = txt_Ngay.Text.Trim();
			_ketquaghepEntity.Ca = txt_Ca.Text.Trim();
			_ketquaghepEntity.Mamay = txt_Mamay.Text.Trim();
			_ketquaghepEntity.Lenhghep = txt_Lenhghep.Text.Trim();
			_ketquaghepEntity.Masanpham = txt_Masanpham.Text.Trim();
			_ketquaghepEntity.Macongnhan = txt_Macongnhan.Text.Trim();
			_ketquaghepEntity.Dauratua = txt_Dauratua.Text.Trim();
			_ketquaghepEntity.ManginMet = txt_ManginMet.Text.Trim();
			_ketquaghepEntity.ManginKg = txt_ManginKg.Text.Trim();
			_ketquaghepEntity.MangcapMet = txt_MangcapMet.Text.Trim();
			_ketquaghepEntity.MangcapKg = txt_MangcapKg.Text.Trim();
			_ketquaghepEntity.Solopghep = txt_Solopghep.Text.Trim();
			_ketquaghepEntity.ThucteMet = txt_ThucteMet.Text.Trim();
			_ketquaghepEntity.ThucteKg = txt_ThucteKg.Text.Trim();
			_ketquaghepEntity.Thoigianbatdau = txt_Thoigianbatdau.Text.Trim();
			_ketquaghepEntity.Thoigianketthuc = txt_Thoigianketthuc.Text.Trim();
			_ketquaghepEntity.Thoigianchuanbi = txt_Thoigianchuanbi.Text.Trim();
			_ketquaghepEntity.Thoigiansuco = txt_Thoigiansuco.Text.Trim();
			_ketquaghepEntity.Thuctekeo = txt_Thuctekeo.Text.Trim();
			_ketquaghepEntity.Thuctedongran = txt_Thuctedongran.Text.Trim();
			_ketquaghepEntity.Thuctedungmoi = txt_Thuctedungmoi.Text.Trim();
			_ketquaghepEntity.Phein = txt_Phein.Text.Trim();
			_ketquaghepEntity.Pheghep = txt_Pheghep.Text.Trim();
			_ketquaghepEntity.PheNcc = txt_PheNcc.Text.Trim();
			_ketquaghepEntity.PheSx = txt_PheSx.Text.Trim();
			_ketquaghepEntity.Phethoi = txt_Phethoi.Text.Trim();
			_ketquaghepEntity.Pheintui = txt_Pheintui.Text.Trim();
			_ketquaghepEntity.Phegheptui = txt_Phegheptui.Text.Trim();
			_ketquaghepEntity.PhethoiNcc = txt_PhethoiNcc.Text.Trim();
			_ketquaghepEntity.Phesxtui = txt_Phesxtui.Text.Trim();
			_ketquaghepEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_ketquaghepEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_ketquaghepEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_ketquaghepEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Ketquaghep_PK = _KetquaghepManager.InsertV2(_KetquaghepEntity, r_Insert, DT_Ketquaghep, BS_Ketquaghep);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_ketquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Ketquaghep.ResetCurrentItem();
			}
			else
			{
				_KetquaghepManager.Update(_ketquaghepEntity);
				
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Id.Name].Value = _ketquaghepEntity.Id;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Ngay.Name].Value = _ketquaghepEntity.Ngay;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Ca.Name].Value = _ketquaghepEntity.Ca;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Mamay.Name].Value = _ketquaghepEntity.Mamay;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Lenhghep.Name].Value = _ketquaghepEntity.Lenhghep;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Masanpham.Name].Value = _ketquaghepEntity.Masanpham;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Macongnhan.Name].Value = _ketquaghepEntity.Macongnhan;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Dauratua.Name].Value = _ketquaghepEntity.Dauratua;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.ManginMet.Name].Value = _ketquaghepEntity.ManginMet;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.ManginKg.Name].Value = _ketquaghepEntity.ManginKg;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.MangcapMet.Name].Value = _ketquaghepEntity.MangcapMet;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.MangcapKg.Name].Value = _ketquaghepEntity.MangcapKg;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Solopghep.Name].Value = _ketquaghepEntity.Solopghep;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.ThucteMet.Name].Value = _ketquaghepEntity.ThucteMet;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.ThucteKg.Name].Value = _ketquaghepEntity.ThucteKg;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Thoigianbatdau.Name].Value = _ketquaghepEntity.Thoigianbatdau;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Thoigianketthuc.Name].Value = _ketquaghepEntity.Thoigianketthuc;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Thoigianchuanbi.Name].Value = _ketquaghepEntity.Thoigianchuanbi;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Thoigiansuco.Name].Value = _ketquaghepEntity.Thoigiansuco;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Thuctekeo.Name].Value = _ketquaghepEntity.Thuctekeo;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Thuctedongran.Name].Value = _ketquaghepEntity.Thuctedongran;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Thuctedungmoi.Name].Value = _ketquaghepEntity.Thuctedungmoi;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Phein.Name].Value = _ketquaghepEntity.Phein;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Pheghep.Name].Value = _ketquaghepEntity.Pheghep;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.PheNcc.Name].Value = _ketquaghepEntity.PheNcc;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.PheSx.Name].Value = _ketquaghepEntity.PheSx;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Phethoi.Name].Value = _ketquaghepEntity.Phethoi;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Pheintui.Name].Value = _ketquaghepEntity.Pheintui;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Phegheptui.Name].Value = _ketquaghepEntity.Phegheptui;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.PhethoiNcc.Name].Value = _ketquaghepEntity.PhethoiNcc;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Phesxtui.Name].Value = _ketquaghepEntity.Phesxtui;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Ngaytao.Name].Value = _ketquaghepEntity.Ngaytao;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Nguoitao.Name].Value = _ketquaghepEntity.Nguoitao;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Ngaysua.Name].Value = _ketquaghepEntity.Ngaysua;
				GRID_Ketquaghep.CurrentRow.Cells[KetquaghepFields.Nguoisua.Name].Value = _ketquaghepEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_ketquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Ketquaghep_PK;
		}

	}
}
