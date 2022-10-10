
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.LogbackupEnt
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
	public class LogbackupEnt : LogbackupEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LogbackupEnt()
		{
			// Nothing for now.
		}

		void BS_Logbackup_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Logbackup.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Logbackup.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[LogbackupFields.Mahieu.Name].ToString();
					
					txt_Mahieu.Text = _Rowview.Row[LogbackupFields.Mahieu.Name].ToString();
					txt_Nam.Text = _Rowview.Row[LogbackupFields.Nam.Name].ToString();
					txt_Duongdan.Text = _Rowview.Row[LogbackupFields.Duongdan.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[LogbackupFields.Ngay.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Logbackup_CurrentChanged"); }
		}

		private string Save_Data(string _str_Logbackup_PK)
		{
			LogbackupEntity _logbackupEntity = new LogbackupEntity();
			
			_logbackupEntity.Mahieu = txt_Mahieu.Text.Trim();
			_logbackupEntity.Nam = txt_Nam.Text.Trim();
			_logbackupEntity.Duongdan = txt_Duongdan.Text.Trim();
			_logbackupEntity.Ngay = txt_Ngay.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Logbackup_PK = _LogbackupManager.InsertV2(_LogbackupEntity, r_Insert, DT_Logbackup, BS_Logbackup);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LogbackupManager.Convert(_logbackupEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Logbackup.ResetCurrentItem();
			}
			else
			{
				_LogbackupManager.Update(_logbackupEntity);
				
				GRID_Logbackup.CurrentRow.Cells[LogbackupFields.Mahieu.Name].Value = _logbackupEntity.Mahieu;
				GRID_Logbackup.CurrentRow.Cells[LogbackupFields.Nam.Name].Value = _logbackupEntity.Nam;
				GRID_Logbackup.CurrentRow.Cells[LogbackupFields.Duongdan.Name].Value = _logbackupEntity.Duongdan;
				GRID_Logbackup.CurrentRow.Cells[LogbackupFields.Ngay.Name].Value = _logbackupEntity.Ngay;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LogbackupManager.Convert(_logbackupEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Logbackup_PK;
		}

	}
}
