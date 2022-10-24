
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
					txt_NANGSUAT.Text = _Rowview.Row[KetquathoiFields.Nangsuat.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUATHOI_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUATHOI_PK)
		{
			KetquathoiEntity _KetquathoiEntity = new KetquathoiEntity();
			
			_KetquathoiEntity.Id = txt_ID.Text.Trim();
			_KetquathoiEntity.Ngay = txt_NGAY.Text.Trim();
			_KetquathoiEntity.Ca = txt_CA.Text.Trim();
			_KetquathoiEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquathoiEntity.Lenhthoi = txt_LENHTHOI.Text.Trim();
			_KetquathoiEntity.Mamang = txt_MAMANG.Text.Trim();
			_KetquathoiEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquathoiEntity.Somet = txt_SOMET.Text.Trim();
			_KetquathoiEntity.Sokg = txt_SOKG.Text.Trim();
			_KetquathoiEntity.Sokgquydoi = txt_SOKGQUYDOI.Text.Trim();
			_KetquathoiEntity.Chenhlechkg = txt_CHENHLECHKG.Text.Trim();
			_KetquathoiEntity.Chatluong = txt_CHATLUONG.Text.Trim();
			_KetquathoiEntity.Phelieuthucte = txt_PHELIEUTHUCTE.Text.Trim();
			_KetquathoiEntity.Tongsp = txt_TONGSP.Text.Trim();
			_KetquathoiEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_KetquathoiEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_KetquathoiEntity.Thoigianchuanbi = txt_THOIGIANCHUANBI.Text.Trim();
			_KetquathoiEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_KetquathoiEntity.Sokgdukiendat = txt_SOKGDUKIENDAT.Text.Trim();
			_KetquathoiEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_KetquathoiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_KetquathoiEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_KetquathoiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquathoiEntity.Tenmang = txt_TENMANG.Text.Trim();
			_KetquathoiEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquathoiEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_KetquathoiEntity.Nangsuat = txt_NANGSUAT.Text.Trim();
			
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
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Somet.Name].Value = _KetquathoiEntity.Somet;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Sokg.Name].Value = _KetquathoiEntity.Sokg;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Sokgquydoi.Name].Value = _KetquathoiEntity.Sokgquydoi;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Chenhlechkg.Name].Value = _KetquathoiEntity.Chenhlechkg;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Chatluong.Name].Value = _KetquathoiEntity.Chatluong;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Phelieuthucte.Name].Value = _KetquathoiEntity.Phelieuthucte;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tongsp.Name].Value = _KetquathoiEntity.Tongsp;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianbatdau.Name].Value = _KetquathoiEntity.Thoigianbatdau;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianketthuc.Name].Value = _KetquathoiEntity.Thoigianketthuc;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigianchuanbi.Name].Value = _KetquathoiEntity.Thoigianchuanbi;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Thoigiansuco.Name].Value = _KetquathoiEntity.Thoigiansuco;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Sokgdukiendat.Name].Value = _KetquathoiEntity.Sokgdukiendat;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngaytao.Name].Value = _KetquathoiEntity.Ngaytao;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nguoitao.Name].Value = _KetquathoiEntity.Nguoitao;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Ngaysua.Name].Value = _KetquathoiEntity.Ngaysua;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nguoisua.Name].Value = _KetquathoiEntity.Nguoisua;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tenmang.Name].Value = _KetquathoiEntity.Tenmang;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tenmay.Name].Value = _KetquathoiEntity.Tenmay;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Tencongnhan.Name].Value = _KetquathoiEntity.Tencongnhan;
				GRID_KETQUATHOI.CurrentRow.Cells[KetquathoiFields.Nangsuat.Name].Value = _KetquathoiEntity.Nangsuat;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathoiManager.Convert(_KetquathoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUATHOI_PK;
		}

	}
}
