
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

		void BS_LOGBACKUP_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_LOGBACKUP.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_LOGBACKUP.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[LogbackupFields.Mahieu.Name].ToString();
					
					txt_MAHIEU.Text = _Rowview.Row[LogbackupFields.Mahieu.Name].ToString();
					txt_NAM.Text = _Rowview.Row[LogbackupFields.Nam.Name].ToString();
					txt_DUONGDAN.Text = _Rowview.Row[LogbackupFields.Duongdan.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[LogbackupFields.Ngay.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_LOGBACKUP_CurrentChanged"); }
		}

		private string Save_Data(string _str_LOGBACKUP_PK)
		{
			LogbackupEntity _logbackupEntity = new LogbackupEntity();
			
			_logbackupEntity.Mahieu = txt_MAHIEU.Text.Trim();
			_logbackupEntity.Nam = txt_NAM.Text.Trim();
			_logbackupEntity.Duongdan = txt_DUONGDAN.Text.Trim();
			_logbackupEntity.Ngay = txt_NGAY.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_LOGBACKUP_PK))
			{
				_str_LOGBACKUP_PK = _LogbackupManager.InsertV2(_logbackupEntity, r_Insert, DT_LOGBACKUP, BS_LOGBACKUP);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LogbackupManager.Convert(_logbackupEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_LOGBACKUP.ResetCurrentItem();
			}
			else
			{
				_LogbackupManager.Update(_logbackupEntity);
				
				GRID_LOGBACKUP.CurrentRow.Cells[LogbackupFields.Mahieu.Name].Value = _logbackupEntity.Mahieu;
				GRID_LOGBACKUP.CurrentRow.Cells[LogbackupFields.Nam.Name].Value = _logbackupEntity.Nam;
				GRID_LOGBACKUP.CurrentRow.Cells[LogbackupFields.Duongdan.Name].Value = _logbackupEntity.Duongdan;
				GRID_LOGBACKUP.CurrentRow.Cells[LogbackupFields.Ngay.Name].Value = _logbackupEntity.Ngay;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_LogbackupManager.Convert(_logbackupEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_LOGBACKUP_PK;
		}

	}
}
