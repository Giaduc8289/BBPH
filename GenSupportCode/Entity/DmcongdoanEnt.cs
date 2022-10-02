
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmcongdoanEnt
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
	public class DmcongdoanEnt : DmcongdoanEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcongdoanEnt()
		{
			// Nothing for now.
		}

		void BS_Dmcongdoan_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmcongdoan.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmcongdoan.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
					
					txt_Macd.Text = _Rowview.Row[DmcongdoanFields.Macd.Name].ToString();
					txt_Tencongdoan.Text = _Rowview.Row[DmcongdoanFields.Tencongdoan.Name].ToString();
					txt_Sothutucongdoan.Text = _Rowview.Row[DmcongdoanFields.Sothutucongdoan.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmcongdoan_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmcongdoan_PK)
		{
			DmcongdoanEntity _dmcongdoanEntity = new DmcongdoanEntity();
			
			_dmcongdoan.Macd = txt_Macd.Text.Trim();
			_dmcongdoan.Tencongdoan = txt_Tencongdoan.Text.Trim();
			_dmcongdoan.Sothutucongdoan = txt_Sothutucongdoan.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmcongdoan_PK = _DmcongdoanManager.InsertV2(_DmcongdoanEntity, r_Insert, DT_Dmcongdoan, BS_Dmcongdoan);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_dmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmcongdoan.ResetCurrentItem();
			}
			else
			{
				_DmcongdoanManager.Update(_dmcongdoanEntity);
				
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Macd.Name].Value = _dmcongdoanEntity.Macd;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Tencongdoan.Name].Value = _dmcongdoanEntity.Tencongdoan;
				GRID_Dmcongdoan.CurrentRow.Cells[DmcongdoanFields.Sothutucongdoan.Name].Value = _dmcongdoanEntity.Sothutucongdoan;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongdoanManager.Convert(_dmcongdoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmcongdoan_PK;
		}

	}
}
