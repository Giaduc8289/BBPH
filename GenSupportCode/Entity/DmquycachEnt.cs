﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmquycachEnt
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
	public class DmquycachEnt : DmquycachEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmquycachEnt()
		{
			// Nothing for now.
		}

		void BS_Dmquycach_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmquycach.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmquycach.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmquycachFields.Maqc.Name].ToString();
					
					txt_Maqc.Text = _Rowview.Row[DmquycachFields.Maqc.Name].ToString();
					txt_Tenquycach.Text = _Rowview.Row[DmquycachFields.Tenquycach.Name].ToString();
					txt_Macd.Text = _Rowview.Row[DmquycachFields.Macd.Name].ToString();
					txt_Maqccha.Text = _Rowview.Row[DmquycachFields.Maqccha.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmquycach_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmquycach_PK)
		{
			DmquycachEntity _dmquycachEntity = new DmquycachEntity();
			
			_dmquycach.Maqc = txt_Maqc.Text.Trim();
			_dmquycach.Tenquycach = txt_Tenquycach.Text.Trim();
			_dmquycach.Macd = txt_Macd.Text.Trim();
			_dmquycach.Maqccha = txt_Maqccha.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmquycach_PK = _DmquycachManager.InsertV2(_DmquycachEntity, r_Insert, DT_Dmquycach, BS_Dmquycach);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_dmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmquycach.ResetCurrentItem();
			}
			else
			{
				_DmquycachManager.Update(_dmquycachEntity);
				
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Maqc.Name].Value = _dmquycachEntity.Maqc;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Tenquycach.Name].Value = _dmquycachEntity.Tenquycach;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Macd.Name].Value = _dmquycachEntity.Macd;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Maqccha.Name].Value = _dmquycachEntity.Maqccha;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_dmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmquycach_PK;
		}

	}
}
