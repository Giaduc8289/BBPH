
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
						MAHIEU_PK = _Rowview.Row[CongsuatmayFields.Macs.Name].ToString();
					
					txt_Macs.Text = _Rowview.Row[CongsuatmayFields.Macs.Name].ToString();
					txt_Tencongsuat.Text = _Rowview.Row[CongsuatmayFields.Tencongsuat.Name].ToString();
					txt_Macd.Text = _Rowview.Row[CongsuatmayFields.Macd.Name].ToString();
					txt_Maqc.Text = _Rowview.Row[CongsuatmayFields.Maqc.Name].ToString();
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
			
			_congsuatmayEntity.Macs = txt_Macs.Text.Trim();
			_congsuatmayEntity.Tencongsuat = txt_Tencongsuat.Text.Trim();
			_congsuatmayEntity.Macd = txt_Macd.Text.Trim();
			_congsuatmayEntity.Maqc = txt_Maqc.Text.Trim();
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
				
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Macs.Name].Value = _congsuatmayEntity.Macs;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Tencongsuat.Name].Value = _congsuatmayEntity.Tencongsuat;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Macd.Name].Value = _congsuatmayEntity.Macd;
				GRID_Congsuatmay.CurrentRow.Cells[CongsuatmayFields.Maqc.Name].Value = _congsuatmayEntity.Maqc;
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
