
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

		void BS_Ketquathoi_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Ketquathoi.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Ketquathoi.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquathoiFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[KetquathoiFields.Id.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[KetquathoiFields.Ngay.Name].ToString();
					txt_Ca.Text = _Rowview.Row[KetquathoiFields.Ca.Name].ToString();
					txt_Mamay.Text = _Rowview.Row[KetquathoiFields.Mamay.Name].ToString();
					txt_Lenhthoi.Text = _Rowview.Row[KetquathoiFields.Lenhthoi.Name].ToString();
					txt_Mamang.Text = _Rowview.Row[KetquathoiFields.Mamang.Name].ToString();
					txt_Macongnhan.Text = _Rowview.Row[KetquathoiFields.Macongnhan.Name].ToString();
					txt_Somet.Text = _Rowview.Row[KetquathoiFields.Somet.Name].ToString();
					txt_Sokg.Text = _Rowview.Row[KetquathoiFields.Sokg.Name].ToString();
					txt_Sokgquydoi.Text = _Rowview.Row[KetquathoiFields.Sokgquydoi.Name].ToString();
					txt_Chenhlechkg.Text = _Rowview.Row[KetquathoiFields.Chenhlechkg.Name].ToString();
					txt_Chatluong.Text = _Rowview.Row[KetquathoiFields.Chatluong.Name].ToString();
					txt_Phelieuthucte.Text = _Rowview.Row[KetquathoiFields.Phelieuthucte.Name].ToString();
					txt_Tongsp.Text = _Rowview.Row[KetquathoiFields.Tongsp.Name].ToString();
					txt_Thoigianbatdau.Text = _Rowview.Row[KetquathoiFields.Thoigianbatdau.Name].ToString();
					txt_Thoigianketthuc.Text = _Rowview.Row[KetquathoiFields.Thoigianketthuc.Name].ToString();
					txt_Thoigianchuanbi.Text = _Rowview.Row[KetquathoiFields.Thoigianchuanbi.Name].ToString();
					txt_Thoigiansuco.Text = _Rowview.Row[KetquathoiFields.Thoigiansuco.Name].ToString();
					txt_Sokgdukiendat.Text = _Rowview.Row[KetquathoiFields.Sokgdukiendat.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[KetquathoiFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[KetquathoiFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[KetquathoiFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[KetquathoiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Ketquathoi_CurrentChanged"); }
		}

		private string Save_Data(string _str_Ketquathoi_PK)
		{
			KetquathoiEntity _ketquathoiEntity = new KetquathoiEntity();
			
			_ketquathoiEntity.Id = txt_Id.Text.Trim();
			_ketquathoiEntity.Ngay = txt_Ngay.Text.Trim();
			_ketquathoiEntity.Ca = txt_Ca.Text.Trim();
			_ketquathoiEntity.Mamay = txt_Mamay.Text.Trim();
			_ketquathoiEntity.Lenhthoi = txt_Lenhthoi.Text.Trim();
			_ketquathoiEntity.Mamang = txt_Mamang.Text.Trim();
			_ketquathoiEntity.Macongnhan = txt_Macongnhan.Text.Trim();
			_ketquathoiEntity.Somet = txt_Somet.Text.Trim();
			_ketquathoiEntity.Sokg = txt_Sokg.Text.Trim();
			_ketquathoiEntity.Sokgquydoi = txt_Sokgquydoi.Text.Trim();
			_ketquathoiEntity.Chenhlechkg = txt_Chenhlechkg.Text.Trim();
			_ketquathoiEntity.Chatluong = txt_Chatluong.Text.Trim();
			_ketquathoiEntity.Phelieuthucte = txt_Phelieuthucte.Text.Trim();
			_ketquathoiEntity.Tongsp = txt_Tongsp.Text.Trim();
			_ketquathoiEntity.Thoigianbatdau = txt_Thoigianbatdau.Text.Trim();
			_ketquathoiEntity.Thoigianketthuc = txt_Thoigianketthuc.Text.Trim();
			_ketquathoiEntity.Thoigianchuanbi = txt_Thoigianchuanbi.Text.Trim();
			_ketquathoiEntity.Thoigiansuco = txt_Thoigiansuco.Text.Trim();
			_ketquathoiEntity.Sokgdukiendat = txt_Sokgdukiendat.Text.Trim();
			_ketquathoiEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_ketquathoiEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_ketquathoiEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_ketquathoiEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Ketquathoi_PK = _KetquathoiManager.InsertV2(_KetquathoiEntity, r_Insert, DT_Ketquathoi, BS_Ketquathoi);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_ketquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Ketquathoi.ResetCurrentItem();
			}
			else
			{
				_KetquathoiManager.Update(_ketquathoiEntity);
				
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Id.Name].Value = _ketquathoiEntity.Id;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Ngay.Name].Value = _ketquathoiEntity.Ngay;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Ca.Name].Value = _ketquathoiEntity.Ca;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Mamay.Name].Value = _ketquathoiEntity.Mamay;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Lenhthoi.Name].Value = _ketquathoiEntity.Lenhthoi;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Mamang.Name].Value = _ketquathoiEntity.Mamang;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Macongnhan.Name].Value = _ketquathoiEntity.Macongnhan;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Somet.Name].Value = _ketquathoiEntity.Somet;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Sokg.Name].Value = _ketquathoiEntity.Sokg;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Sokgquydoi.Name].Value = _ketquathoiEntity.Sokgquydoi;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Chenhlechkg.Name].Value = _ketquathoiEntity.Chenhlechkg;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Chatluong.Name].Value = _ketquathoiEntity.Chatluong;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Phelieuthucte.Name].Value = _ketquathoiEntity.Phelieuthucte;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Tongsp.Name].Value = _ketquathoiEntity.Tongsp;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Thoigianbatdau.Name].Value = _ketquathoiEntity.Thoigianbatdau;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Thoigianketthuc.Name].Value = _ketquathoiEntity.Thoigianketthuc;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Thoigianchuanbi.Name].Value = _ketquathoiEntity.Thoigianchuanbi;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Thoigiansuco.Name].Value = _ketquathoiEntity.Thoigiansuco;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Sokgdukiendat.Name].Value = _ketquathoiEntity.Sokgdukiendat;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Ngaytao.Name].Value = _ketquathoiEntity.Ngaytao;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Nguoitao.Name].Value = _ketquathoiEntity.Nguoitao;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Ngaysua.Name].Value = _ketquathoiEntity.Ngaysua;
				GRID_Ketquathoi.CurrentRow.Cells[KetquathoiFields.Nguoisua.Name].Value = _ketquathoiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_ketquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Ketquathoi_PK;
		}

	}
}
