
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.CongsuatmayEnt
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
	public class CongsuatmayEnt : CongsuatmayEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CongsuatmayEnt()
		{
			// Nothing for now.
		}

		void BS_CONGSUATMAY_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_CONGSUATMAY.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_CONGSUATMAY.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
					
					txt_MACONGSUAT.Text = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
					txt_TENCONGSUAT.Text = _Rowview.Row[CongsuatmayFields.Tencongsuat.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[CongsuatmayFields.Mamay.Name].ToString();
					txt_MADONGMAY.Text = _Rowview.Row[CongsuatmayFields.Madongmay.Name].ToString();
					txt_MACONGDOAN.Text = _Rowview.Row[CongsuatmayFields.Macongdoan.Name].ToString();
					txt_KHOTU.Text = _Rowview.Row[CongsuatmayFields.Khotu.Name].ToString();
					txt_KHODEN.Text = _Rowview.Row[CongsuatmayFields.Khoden.Name].ToString();
					txt_CHIEUDAITU.Text = _Rowview.Row[CongsuatmayFields.Chieudaitu.Name].ToString();
					txt_CHIEUDAIDEN.Text = _Rowview.Row[CongsuatmayFields.Chieudaiden.Name].ToString();
					txt_DODAYTU.Text = _Rowview.Row[CongsuatmayFields.Dodaytu.Name].ToString();
					txt_DODAYDEN.Text = _Rowview.Row[CongsuatmayFields.Dodayden.Name].ToString();
					txt_TOCDO.Text = _Rowview.Row[CongsuatmayFields.Tocdo.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[CongsuatmayFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[CongsuatmayFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[CongsuatmayFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[CongsuatmayFields.Nguoisua.Name].ToString();
					txt_SOMAUMA.Text = _Rowview.Row[CongsuatmayFields.Somauma.Name].ToString();
					txt_SOHINHMA.Text = _Rowview.Row[CongsuatmayFields.Sohinhma.Name].ToString();
					txt_MALOAIMANG.Text = _Rowview.Row[CongsuatmayFields.Maloaimang.Name].ToString();
					txt_MAQCTHANHPHAM.Text = _Rowview.Row[CongsuatmayFields.Maqcthanhpham.Name].ToString();
					txt_MACAUTRUCINS.Text = _Rowview.Row[CongsuatmayFields.Macautrucins.Name].ToString();
					txt_MAKHACHS.Text = _Rowview.Row[CongsuatmayFields.Makhachs.Name].ToString();
					txt_MAHANGS.Text = _Rowview.Row[CongsuatmayFields.Mahangs.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CONGSUATMAY_CurrentChanged"); }
		}

		private string Save_Data(string _str_CONGSUATMAY_PK)
		{
			CongsuatmayEntity _CongsuatmayEntity = new CongsuatmayEntity();
			
			_CongsuatmayEntity.Macongsuat = txt_MACONGSUAT.Text.Trim();
			_CongsuatmayEntity.Tencongsuat = txt_TENCONGSUAT.Text.Trim();
			_CongsuatmayEntity.Mamay = txt_MAMAY.Text.Trim();
			_CongsuatmayEntity.Madongmay = txt_MADONGMAY.Text.Trim();
			_CongsuatmayEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
			_CongsuatmayEntity.Khotu = txt_KHOTU.Text.Trim();
			_CongsuatmayEntity.Khoden = txt_KHODEN.Text.Trim();
			_CongsuatmayEntity.Chieudaitu = txt_CHIEUDAITU.Text.Trim();
			_CongsuatmayEntity.Chieudaiden = txt_CHIEUDAIDEN.Text.Trim();
			_CongsuatmayEntity.Dodaytu = txt_DODAYTU.Text.Trim();
			_CongsuatmayEntity.Dodayden = txt_DODAYDEN.Text.Trim();
			_CongsuatmayEntity.Tocdo = txt_TOCDO.Text.Trim();
			_CongsuatmayEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_CongsuatmayEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_CongsuatmayEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_CongsuatmayEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_CongsuatmayEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_CongsuatmayEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
			_CongsuatmayEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_CongsuatmayEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			_CongsuatmayEntity.Macautrucins = txt_MACAUTRUCINS.Text.Trim();
			_CongsuatmayEntity.Makhachs = txt_MAKHACHS.Text.Trim();
			_CongsuatmayEntity.Mahangs = txt_MAHANGS.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_CONGSUATMAY_PK))
			{
				_str_CONGSUATMAY_PK = _CongsuatmayManager.InsertV2(_CongsuatmayEntity, r_Insert, DT_CONGSUATMAY, BS_CONGSUATMAY);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CONGSUATMAY.ResetCurrentItem();
			}
			else
			{
				_CongsuatmayManager.Update(_CongsuatmayEntity);
				
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongsuat.Name].Value = _CongsuatmayEntity.Macongsuat;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tencongsuat.Name].Value = _CongsuatmayEntity.Tencongsuat;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Mamay.Name].Value = _CongsuatmayEntity.Mamay;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Madongmay.Name].Value = _CongsuatmayEntity.Madongmay;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongdoan.Name].Value = _CongsuatmayEntity.Macongdoan;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khotu.Name].Value = _CongsuatmayEntity.Khotu;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khoden.Name].Value = _CongsuatmayEntity.Khoden;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaitu.Name].Value = _CongsuatmayEntity.Chieudaitu;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaiden.Name].Value = _CongsuatmayEntity.Chieudaiden;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodaytu.Name].Value = _CongsuatmayEntity.Dodaytu;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodayden.Name].Value = _CongsuatmayEntity.Dodayden;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tocdo.Name].Value = _CongsuatmayEntity.Tocdo;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Ngaytao.Name].Value = _CongsuatmayEntity.Ngaytao;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Nguoitao.Name].Value = _CongsuatmayEntity.Nguoitao;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Ngaysua.Name].Value = _CongsuatmayEntity.Ngaysua;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Nguoisua.Name].Value = _CongsuatmayEntity.Nguoisua;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Somauma.Name].Value = _CongsuatmayEntity.Somauma;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Sohinhma.Name].Value = _CongsuatmayEntity.Sohinhma;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maloaimang.Name].Value = _CongsuatmayEntity.Maloaimang;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maqcthanhpham.Name].Value = _CongsuatmayEntity.Maqcthanhpham;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macautrucins.Name].Value = _CongsuatmayEntity.Macautrucins;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Makhachs.Name].Value = _CongsuatmayEntity.Makhachs;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Mahangs.Name].Value = _CongsuatmayEntity.Mahangs;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_CongsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CONGSUATMAY_PK;
		}

	}
}
