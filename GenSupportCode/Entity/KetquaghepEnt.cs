
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
					txt_PHEINTUI.Text = _Rowview.Row[KetquaghepFields.Pheintui.Name].ToString();
					txt_PHEGHEPTUI.Text = _Rowview.Row[KetquaghepFields.Phegheptui.Name].ToString();
					txt_PHETHOINCC.Text = _Rowview.Row[KetquaghepFields.PhethoiNcc.Name].ToString();
					txt_PHESXTUI.Text = _Rowview.Row[KetquaghepFields.Phesxtui.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquaghepFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquaghepFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquaghepFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquaghepFields.Nguoisua.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquaghepFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquaghepFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquaghepFields.Tencongnhan.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUAGHEP_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUAGHEP_PK)
		{
			KetquaghepEntity _ketquaghepEntity = new KetquaghepEntity();
			
			_ketquaghepEntity.Id = txt_ID.Text.Trim();
			_ketquaghepEntity.Ngay = txt_NGAY.Text.Trim();
			_ketquaghepEntity.Ca = txt_CA.Text.Trim();
			_ketquaghepEntity.Mamay = txt_MAMAY.Text.Trim();
			_ketquaghepEntity.Lenhghep = txt_LENHGHEP.Text.Trim();
			_ketquaghepEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_ketquaghepEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_ketquaghepEntity.Dauratua = txt_DAURATUA.Text.Trim();
			_ketquaghepEntity.ManginMet = txt_MANGINMET.Text.Trim();
			_ketquaghepEntity.ManginKg = txt_MANGINKG.Text.Trim();
			_ketquaghepEntity.MangcapMet = txt_MANGCAPMET.Text.Trim();
			_ketquaghepEntity.MangcapKg = txt_MANGCAPKG.Text.Trim();
			_ketquaghepEntity.Solopghep = txt_SOLOPGHEP.Text.Trim();
			_ketquaghepEntity.ThucteMet = txt_THUCTEMET.Text.Trim();
			_ketquaghepEntity.ThucteKg = txt_THUCTEKG.Text.Trim();
			_ketquaghepEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_ketquaghepEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_ketquaghepEntity.Thoigianchuanbi = txt_THOIGIANCHUANBI.Text.Trim();
			_ketquaghepEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_ketquaghepEntity.Thuctekeo = txt_THUCTEKEO.Text.Trim();
			_ketquaghepEntity.Thuctedongran = txt_THUCTEDONGRAN.Text.Trim();
			_ketquaghepEntity.Thuctedungmoi = txt_THUCTEDUNGMOI.Text.Trim();
			_ketquaghepEntity.Phein = txt_PHEIN.Text.Trim();
			_ketquaghepEntity.Pheghep = txt_PHEGHEP.Text.Trim();
			_ketquaghepEntity.PheNcc = txt_PHENCC.Text.Trim();
			_ketquaghepEntity.PheSx = txt_PHESX.Text.Trim();
			_ketquaghepEntity.Phethoi = txt_PHETHOI.Text.Trim();
			_ketquaghepEntity.Pheintui = txt_PHEINTUI.Text.Trim();
			_ketquaghepEntity.Phegheptui = txt_PHEGHEPTUI.Text.Trim();
			_ketquaghepEntity.PhethoiNcc = txt_PHETHOINCC.Text.Trim();
			_ketquaghepEntity.Phesxtui = txt_PHESXTUI.Text.Trim();
			_ketquaghepEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_ketquaghepEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_ketquaghepEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_ketquaghepEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_ketquaghepEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_ketquaghepEntity.Tenmay = txt_TENMAY.Text.Trim();
			_ketquaghepEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUAGHEP_PK))
			{
				_str_KETQUAGHEP_PK = _KetquaghepManager.InsertV2(_ketquaghepEntity, r_Insert, DT_KETQUAGHEP, BS_KETQUAGHEP);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_ketquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUAGHEP.ResetCurrentItem();
			}
			else
			{
				_KetquaghepManager.Update(_ketquaghepEntity);
				
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Id.Name].Value = _ketquaghepEntity.Id;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ngay.Name].Value = _ketquaghepEntity.Ngay;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ca.Name].Value = _ketquaghepEntity.Ca;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Mamay.Name].Value = _ketquaghepEntity.Mamay;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Lenhghep.Name].Value = _ketquaghepEntity.Lenhghep;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Masanpham.Name].Value = _ketquaghepEntity.Masanpham;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Macongnhan.Name].Value = _ketquaghepEntity.Macongnhan;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Dauratua.Name].Value = _ketquaghepEntity.Dauratua;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ManginMet.Name].Value = _ketquaghepEntity.ManginMet;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ManginKg.Name].Value = _ketquaghepEntity.ManginKg;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.MangcapMet.Name].Value = _ketquaghepEntity.MangcapMet;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.MangcapKg.Name].Value = _ketquaghepEntity.MangcapKg;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Solopghep.Name].Value = _ketquaghepEntity.Solopghep;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ThucteMet.Name].Value = _ketquaghepEntity.ThucteMet;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.ThucteKg.Name].Value = _ketquaghepEntity.ThucteKg;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianbatdau.Name].Value = _ketquaghepEntity.Thoigianbatdau;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianketthuc.Name].Value = _ketquaghepEntity.Thoigianketthuc;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigianchuanbi.Name].Value = _ketquaghepEntity.Thoigianchuanbi;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thoigiansuco.Name].Value = _ketquaghepEntity.Thoigiansuco;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thuctekeo.Name].Value = _ketquaghepEntity.Thuctekeo;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thuctedongran.Name].Value = _ketquaghepEntity.Thuctedongran;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Thuctedungmoi.Name].Value = _ketquaghepEntity.Thuctedungmoi;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Phein.Name].Value = _ketquaghepEntity.Phein;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Pheghep.Name].Value = _ketquaghepEntity.Pheghep;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.PheNcc.Name].Value = _ketquaghepEntity.PheNcc;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.PheSx.Name].Value = _ketquaghepEntity.PheSx;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Phethoi.Name].Value = _ketquaghepEntity.Phethoi;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Pheintui.Name].Value = _ketquaghepEntity.Pheintui;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Phegheptui.Name].Value = _ketquaghepEntity.Phegheptui;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.PhethoiNcc.Name].Value = _ketquaghepEntity.PhethoiNcc;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Phesxtui.Name].Value = _ketquaghepEntity.Phesxtui;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ngaytao.Name].Value = _ketquaghepEntity.Ngaytao;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Nguoitao.Name].Value = _ketquaghepEntity.Nguoitao;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Ngaysua.Name].Value = _ketquaghepEntity.Ngaysua;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Nguoisua.Name].Value = _ketquaghepEntity.Nguoisua;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tensanpham.Name].Value = _ketquaghepEntity.Tensanpham;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tenmay.Name].Value = _ketquaghepEntity.Tenmay;
				GRID_KETQUAGHEP.CurrentRow.Cells[KetquaghepFields.Tencongnhan.Name].Value = _ketquaghepEntity.Tencongnhan;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquaghepManager.Convert(_ketquaghepEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUAGHEP_PK;
		}

	}
}
