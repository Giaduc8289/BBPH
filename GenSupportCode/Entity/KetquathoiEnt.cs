
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
					txt_SOMET.Text = _Rowview.Row[KetquathoiFields.Somet.Name].ToString();
					txt_SOKG.Text = _Rowview.Row[KetquathoiFields.Sokg.Name].ToString();
					txt_SOKGQUYDOI.Text = _Rowview.Row[KetquathoiFields.Sokgquydoi.Name].ToString();
					txt_CHENHLECHKG.Text = _Rowview.Row[KetquathoiFields.Chenhlechkg.Name].ToString();
					txt_CHATLUONG.Text = _Rowview.Row[KetquathoiFields.Chatluong.Name].ToString();
					txt_PHELIEUTHUCTE.Text = _Rowview.Row[KetquathoiFields.Phelieuthucte.Name].ToString();
					txt_TONGSP.Text = _Rowview.Row[KetquathoiFields.Tongsp.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquathoiFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquathoiFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquathoiFields.Thoigianchuanbi.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquathoiFields.Thoigiansuco.Name].ToString();
					txt_SOKGDUKIENDAT.Text = _Rowview.Row[KetquathoiFields.Sokgdukiendat.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquathoiFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquathoiFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquathoiFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquathoiFields.Nguoisua.Name].ToString();
					txt_TENMANG.Text = _Rowview.Row[KetquathoiFields.Tenmang.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquathoiFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquathoiFields.Tencongnhan.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUATHOI_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUATHOI_PK)
		{
			KetquathoiEntity _ketquathoiEntity = new KetquathoiEntity();
			
			_ketquathoiEntity.Id = txt_ID.Text.Trim();
			_ketquathoiEntity.Ngay = txt_NGAY.Text.Trim();
			_ketquathoiEntity.Ca = txt_CA.Text.Trim();
			_ketquathoiEntity.Mamay = txt_MAMAY.Text.Trim();
			_ketquathoiEntity.Lenhthoi = txt_LENHTHOI.Text.Trim();
			_ketquathoiEntity.Mamang = txt_MAMANG.Text.Trim();
			_ketquathoiEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_ketquathoiEntity.Somet = txt_SOMET.Text.Trim();
			_ketquathoiEntity.Sokg = txt_SOKG.Text.Trim();
			_ketquathoiEntity.Sokgquydoi = txt_SOKGQUYDOI.Text.Trim();
			_ketquathoiEntity.Chenhlechkg = txt_CHENHLECHKG.Text.Trim();
			_ketquathoiEntity.Chatluong = txt_CHATLUONG.Text.Trim();
			_ketquathoiEntity.Phelieuthucte = txt_PHELIEUTHUCTE.Text.Trim();
			_ketquathoiEntity.Tongsp = txt_TONGSP.Text.Trim();
			_ketquathoiEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_ketquathoiEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_ketquathoiEntity.Thoigianchuanbi = txt_THOIGIANCHUANBI.Text.Trim();
			_ketquathoiEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_ketquathoiEntity.Sokgdukiendat = txt_SOKGDUKIENDAT.Text.Trim();
			_ketquathoiEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_ketquathoiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_ketquathoiEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_ketquathoiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_ketquathoiEntity.Tenmang = txt_TENMANG.Text.Trim();
			_ketquathoiEntity.Tenmay = txt_TENMAY.Text.Trim();
			_ketquathoiEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUATHOI_PK))
			{
				_str_KETQUATHOI_PK = _KetquathoiManager.InsertV2(_ketquathoiEntity, r_Insert, DT_KETQUATHOI, BS_KETQUATHOI);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_ketquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUATHOI.ResetCurrentItem();
			}
			else
			{
				_KetquathoiManager.Update(_ketquathoiEntity);
				
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Id.Name].Value = _ketquathoiEntity.Id;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngay.Name].Value = _ketquathoiEntity.Ngay;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ca.Name].Value = _ketquathoiEntity.Ca;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Mamay.Name].Value = _ketquathoiEntity.Mamay;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Lenhthoi.Name].Value = _ketquathoiEntity.Lenhthoi;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Mamang.Name].Value = _ketquathoiEntity.Mamang;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Macongnhan.Name].Value = _ketquathoiEntity.Macongnhan;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Somet.Name].Value = _ketquathoiEntity.Somet;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Sokg.Name].Value = _ketquathoiEntity.Sokg;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Sokgquydoi.Name].Value = _ketquathoiEntity.Sokgquydoi;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Chenhlechkg.Name].Value = _ketquathoiEntity.Chenhlechkg;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Chatluong.Name].Value = _ketquathoiEntity.Chatluong;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Phelieuthucte.Name].Value = _ketquathoiEntity.Phelieuthucte;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tongsp.Name].Value = _ketquathoiEntity.Tongsp;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianbatdau.Name].Value = _ketquathoiEntity.Thoigianbatdau;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianketthuc.Name].Value = _ketquathoiEntity.Thoigianketthuc;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianchuanbi.Name].Value = _ketquathoiEntity.Thoigianchuanbi;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigiansuco.Name].Value = _ketquathoiEntity.Thoigiansuco;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Sokgdukiendat.Name].Value = _ketquathoiEntity.Sokgdukiendat;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngaytao.Name].Value = _ketquathoiEntity.Ngaytao;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nguoitao.Name].Value = _ketquathoiEntity.Nguoitao;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngaysua.Name].Value = _ketquathoiEntity.Ngaysua;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nguoisua.Name].Value = _ketquathoiEntity.Nguoisua;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tenmang.Name].Value = _ketquathoiEntity.Tenmang;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tenmay.Name].Value = _ketquathoiEntity.Tenmay;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tencongnhan.Name].Value = _ketquathoiEntity.Tencongnhan;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_ketquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUATHOI_PK;
		}

	}
}
