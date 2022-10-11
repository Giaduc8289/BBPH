
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

		void BS_Congsuatmay_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Congsuatmay.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Congsuatmay.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
					
					txt_Macongsuat.Text = _Rowview.Row[CongsuatmayFields.Macongsuat.Name].ToString();
					txt_Tencongsuat.Text = _Rowview.Row[CongsuatmayFields.Tencongsuat.Name].ToString();
					txt_Mamay.Text = _Rowview.Row[CongsuatmayFields.Mamay.Name].ToString();
					txt_Madongmay.Text = _Rowview.Row[CongsuatmayFields.Madongmay.Name].ToString();
					txt_Macongdoan.Text = _Rowview.Row[CongsuatmayFields.Macongdoan.Name].ToString();
					txt_Maquycach1.Text = _Rowview.Row[CongsuatmayFields.Maquycach1.Name].ToString();
					txt_Maquycach2.Text = _Rowview.Row[CongsuatmayFields.Maquycach2.Name].ToString();
					txt_Maquycach3.Text = _Rowview.Row[CongsuatmayFields.Maquycach3.Name].ToString();
					txt_Khotu.Text = _Rowview.Row[CongsuatmayFields.Khotu.Name].ToString();
					txt_Khoden.Text = _Rowview.Row[CongsuatmayFields.Khoden.Name].ToString();
					txt_Chieudaitu.Text = _Rowview.Row[CongsuatmayFields.Chieudaitu.Name].ToString();
					txt_Chieudaiden.Text = _Rowview.Row[CongsuatmayFields.Chieudaiden.Name].ToString();
					txt_Dodaytu.Text = _Rowview.Row[CongsuatmayFields.Dodaytu.Name].ToString();
					txt_Dodayden.Text = _Rowview.Row[CongsuatmayFields.Dodayden.Name].ToString();
					txt_Tocdo.Text = _Rowview.Row[CongsuatmayFields.Tocdo.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[CongsuatmayFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[CongsuatmayFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[CongsuatmayFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[CongsuatmayFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Congsuatmay_CurrentChanged"); }
		}

		private string Save_Data(string _str_Congsuatmay_PK)
		{
			CongsuatmayEntity _congsuatmayEntity = new CongsuatmayEntity();
			
			_congsuatmayEntity.Macongsuat = txt_Macongsuat.Text.Trim();
			_congsuatmayEntity.Tencongsuat = txt_Tencongsuat.Text.Trim();
			_congsuatmayEntity.Mamay = txt_Mamay.Text.Trim();
			_congsuatmayEntity.Madongmay = txt_Madongmay.Text.Trim();
			_congsuatmayEntity.Macongdoan = txt_Macongdoan.Text.Trim();
			_congsuatmayEntity.Maquycach1 = txt_Maquycach1.Text.Trim();
			_congsuatmayEntity.Maquycach2 = txt_Maquycach2.Text.Trim();
			_congsuatmayEntity.Maquycach3 = txt_Maquycach3.Text.Trim();
			_congsuatmayEntity.Khotu = txt_Khotu.Text.Trim();
			_congsuatmayEntity.Khoden = txt_Khoden.Text.Trim();
			_congsuatmayEntity.Chieudaitu = txt_Chieudaitu.Text.Trim();
			_congsuatmayEntity.Chieudaiden = txt_Chieudaiden.Text.Trim();
			_congsuatmayEntity.Dodaytu = txt_Dodaytu.Text.Trim();
			_congsuatmayEntity.Dodayden = txt_Dodayden.Text.Trim();
			_congsuatmayEntity.Tocdo = txt_Tocdo.Text.Trim();
			_congsuatmayEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_congsuatmayEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_congsuatmayEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_congsuatmayEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Congsuatmay_PK = _CongsuatmayManager.InsertV2(_CongsuatmayEntity, r_Insert, DT_Congsuatmay, BS_Congsuatmay);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_congsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Congsuatmay.ResetCurrentItem();
			}
			else
			{
				_CongsuatmayManager.Update(_congsuatmayEntity);
				
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Macongsuat.Name].Value = _congsuatmayEntity.Macongsuat;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Tencongsuat.Name].Value = _congsuatmayEntity.Tencongsuat;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Mamay.Name].Value = _congsuatmayEntity.Mamay;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Madongmay.Name].Value = _congsuatmayEntity.Madongmay;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Macongdoan.Name].Value = _congsuatmayEntity.Macongdoan;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Maquycach1.Name].Value = _congsuatmayEntity.Maquycach1;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Maquycach2.Name].Value = _congsuatmayEntity.Maquycach2;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Maquycach3.Name].Value = _congsuatmayEntity.Maquycach3;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Khotu.Name].Value = _congsuatmayEntity.Khotu;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Khoden.Name].Value = _congsuatmayEntity.Khoden;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Chieudaitu.Name].Value = _congsuatmayEntity.Chieudaitu;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Chieudaiden.Name].Value = _congsuatmayEntity.Chieudaiden;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Dodaytu.Name].Value = _congsuatmayEntity.Dodaytu;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Dodayden.Name].Value = _congsuatmayEntity.Dodayden;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Tocdo.Name].Value = _congsuatmayEntity.Tocdo;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Ngaytao.Name].Value = _congsuatmayEntity.Ngaytao;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Nguoitao.Name].Value = _congsuatmayEntity.Nguoitao;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Ngaysua.Name].Value = _congsuatmayEntity.Ngaysua;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Nguoisua.Name].Value = _congsuatmayEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CongsuatmayManager.Convert(_congsuatmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Congsuatmay_PK;
		}

	}
}
