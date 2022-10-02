
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmdongmayEnt
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
	public class DmdongmayEnt : DmdongmayEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmdongmayEnt()
		{
			// Nothing for now.
		}

		void BS_Dmdongmay_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmdongmay.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmdongmay.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmdongmayFields.Madm.Name].ToString();
					
					txt_Madm.Text = _Rowview.Row[DmdongmayFields.Madm.Name].ToString();
					txt_Tendongmay.Text = _Rowview.Row[DmdongmayFields.Tendongmay.Name].ToString();
					txt_Macd.Text = _Rowview.Row[DmdongmayFields.Macd.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmdongmay_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmdongmay_PK)
		{
			DmdongmayEntity _dmdongmayEntity = new DmdongmayEntity();
			
			_dmdongmay.Madm = txt_Madm.Text.Trim();
			_dmdongmay.Tendongmay = txt_Tendongmay.Text.Trim();
			_dmdongmay.Macd = txt_Macd.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmdongmay_PK = _DmdongmayManager.InsertV2(_DmdongmayEntity, r_Insert, DT_Dmdongmay, BS_Dmdongmay);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmdongmayManager.Convert(_dmdongmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmdongmay.ResetCurrentItem();
			}
			else
			{
				_DmdongmayManager.Update(_dmdongmayEntity);
				
				GRID_Dmdongmay.CurrentRow.Cells[DmdongmayFields.Madm.Name].Value = _dmdongmayEntity.Madm;
				GRID_Dmdongmay.CurrentRow.Cells[DmdongmayFields.Tendongmay.Name].Value = _dmdongmayEntity.Tendongmay;
				GRID_Dmdongmay.CurrentRow.Cells[DmdongmayFields.Macd.Name].Value = _dmdongmayEntity.Macd;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmdongmayManager.Convert(_dmdongmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmdongmay_PK;
		}

	}
}
