
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquathoiEnt
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
	public class KetquathoiEnt : KetquathoiEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquathoiEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUATHOI_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUATHOI.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUATHOI.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquathoiFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquathoiFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[KetquathoiFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KetquathoiFields.Ca.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KetquathoiFields.Mamay.Name].ToString();
					txt_LENHTHOI.Text = _Rowview.Row[KetquathoiFields.Lenhthoi.Name].ToString();
					txt_MAMANG.Text = _Rowview.Row[KetquathoiFields.Mamang.Name].ToString();
					txt_MACONGNHAN.Text = _Rowview.Row[KetquathoiFields.Macongnhan.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[KetquathoiFields.Tenmang.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquathoiFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquathoiFields.Tencongnhan.Name].ToString();
					txt_SOMET.Text = _Rowview.Row[KetquathoiFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KetquathoiFields.Sokg.Name].ToString();
					txt_PHELIEUTHUCTE.Text = _Rowview.Row[KetquathoiFields.Phelieuthucte.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquathoiFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquathoiFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquathoiFields.Thoigianchuanbi.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquathoiFields.Thoigiansuco.Name].ToString();
					txt_CHATLUONG.Text = _Rowview.Row[KetquathoiFields.Chatluong.Name].ToString();
					txt_NANGSUAT.Text = _Rowview.Row[KetquathoiFields.Nangsuat.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquathoiFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquathoiFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquathoiFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquathoiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUATHOI_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUATHOI_PK)
		{
			KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
			try { _KetquathoiEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			_KetquathoiEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquathoiEntity.Lenhthoi = txt_LENHTHOI.Text.Trim();
			_KetquathoiEntity.Mamang = txt_MAMANG.Text.Trim();
			_KetquathoiEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquathoiEntity.Tenmang = txt_TENMANG.Text.Trim();
			_KetquathoiEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquathoiEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			try { _KetquathoiEntity.Somet = System.Decimal.Parse(txt_SOMET.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Sokg = System.Decimal.Parse(txt_SOKG.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Phelieuthucte = System.Decimal.Parse(txt_PHELIEUTHUCTE.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Thoigianbatdau = System.DateTime.Parse(txt_THOIGIANBATDAU.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Thoigianketthuc = System.DateTime.Parse(txt_THOIGIANKETTHUC.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Thoigianchuanbi = System.Decimal.Parse(txt_THOIGIANCHUANBI.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Thoigiansuco = System.Decimal.Parse(txt_THOIGIANSUCO.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Chatluong = System.Decimal.Parse(txt_CHATLUONG.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Nangsuat = System.Decimal.Parse(txt_NANGSUAT.Text.Trim()); } 
			catch { }
			try { _KetquathoiEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KetquathoiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KetquathoiEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KetquathoiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KETQUATHOI_PK))
			{
				_str_KETQUATHOI_PK = _KetquathoiManager.InsertV2(_KetquathoiEntity, r_Insert, DT_KETQUATHOI, BS_KETQUATHOI);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUATHOI.ResetCurrentItem();
			}
			else
			{
				_KetquathoiManager.Update(_KetquathoiEntity);
				
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Id.Name].Value = _KetquathoiEntity.Id;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngay.Name].Value = _KetquathoiEntity.Ngay;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ca.Name].Value = _KetquathoiEntity.Ca;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Mamay.Name].Value = _KetquathoiEntity.Mamay;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Lenhthoi.Name].Value = _KetquathoiEntity.Lenhthoi;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Mamang.Name].Value = _KetquathoiEntity.Mamang;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Macongnhan.Name].Value = _KetquathoiEntity.Macongnhan;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tenmang.Name].Value = _KetquathoiEntity.Tenmang;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tenmay.Name].Value = _KetquathoiEntity.Tenmay;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tencongnhan.Name].Value = _KetquathoiEntity.Tencongnhan;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Somet.Name].Value = _KetquathoiEntity.Somet;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Sokg.Name].Value = _KetquathoiEntity.Sokg;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Phelieuthucte.Name].Value = _KetquathoiEntity.Phelieuthucte;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianbatdau.Name].Value = _KetquathoiEntity.Thoigianbatdau;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianketthuc.Name].Value = _KetquathoiEntity.Thoigianketthuc;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianchuanbi.Name].Value = _KetquathoiEntity.Thoigianchuanbi;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigiansuco.Name].Value = _KetquathoiEntity.Thoigiansuco;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Chatluong.Name].Value = _KetquathoiEntity.Chatluong;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nangsuat.Name].Value = _KetquathoiEntity.Nangsuat;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngaytao.Name].Value = _KetquathoiEntity.Ngaytao;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nguoitao.Name].Value = _KetquathoiEntity.Nguoitao;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngaysua.Name].Value = _KetquathoiEntity.Ngaysua;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nguoisua.Name].Value = _KetquathoiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUATHOI_PK;
		}

	}
}
