
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
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CONGSUATMAY_CurrentChanged"); }
		}

		private string Save_Data(string _str_CONGSUATMAY_PK)
		{
			CongsuatmayEntity _congsuatmayEntity = new CongsuatmayEntity();
			
			_congsuatmayEntity.Macongsuat = txt_MACONGSUAT.Text.Trim();
			_congsuatmayEntity.Tencongsuat = txt_TENCONGSUAT.Text.Trim();
			_congsuatmayEntity.Mamay = txt_MAMAY.Text.Trim();
			_congsuatmayEntity.Madongmay = txt_MADONGMAY.Text.Trim();
			_congsuatmayEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
			_congsuatmayEntity.Khotu = txt_KHOTU.Text.Trim();
			_congsuatmayEntity.Khoden = txt_KHODEN.Text.Trim();
			_congsuatmayEntity.Chieudaitu = txt_CHIEUDAITU.Text.Trim();
			_congsuatmayEntity.Chieudaiden = txt_CHIEUDAIDEN.Text.Trim();
			_congsuatmayEntity.Dodaytu = txt_DODAYTU.Text.Trim();
			_congsuatmayEntity.Dodayden = txt_DODAYDEN.Text.Trim();
			_congsuatmayEntity.Tocdo = txt_TOCDO.Text.Trim();
			_congsuatmayEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_congsuatmayEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_congsuatmayEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_congsuatmayEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_congsuatmayEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_congsuatmayEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
			_congsuatmayEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_congsuatmayEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_CONGSUATMAY_PK))
			{
				_str_CONGSUATMAY_PK = _CongsuatmayManager.InsertV2(_congsuatmayEntity, r_Insert, DT_CONGSUATMAY, BS_CONGSUATMAY);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_congsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CONGSUATMAY.ResetCurrentItem();
			}
			else
			{
				_CongsuatmayManager.Update(_congsuatmayEntity);
				
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongsuat.Name].Value = _congsuatmayEntity.Macongsuat;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tencongsuat.Name].Value = _congsuatmayEntity.Tencongsuat;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Mamay.Name].Value = _congsuatmayEntity.Mamay;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Madongmay.Name].Value = _congsuatmayEntity.Madongmay;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Macongdoan.Name].Value = _congsuatmayEntity.Macongdoan;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khotu.Name].Value = _congsuatmayEntity.Khotu;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Khoden.Name].Value = _congsuatmayEntity.Khoden;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaitu.Name].Value = _congsuatmayEntity.Chieudaitu;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Chieudaiden.Name].Value = _congsuatmayEntity.Chieudaiden;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodaytu.Name].Value = _congsuatmayEntity.Dodaytu;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Dodayden.Name].Value = _congsuatmayEntity.Dodayden;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Tocdo.Name].Value = _congsuatmayEntity.Tocdo;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Ngaytao.Name].Value = _congsuatmayEntity.Ngaytao;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Nguoitao.Name].Value = _congsuatmayEntity.Nguoitao;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Ngaysua.Name].Value = _congsuatmayEntity.Ngaysua;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Nguoisua.Name].Value = _congsuatmayEntity.Nguoisua;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Somauma.Name].Value = _congsuatmayEntity.Somauma;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Sohinhma.Name].Value = _congsuatmayEntity.Sohinhma;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maloaimang.Name].Value = _congsuatmayEntity.Maloaimang;
				GRID_CONGSUATMAY.CurrentRow.Cells[CongsuatmayFields.Maqcthanhpham.Name].Value = _congsuatmayEntity.Maqcthanhpham;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_congsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CONGSUATMAY_PK;
		}

	}
}
