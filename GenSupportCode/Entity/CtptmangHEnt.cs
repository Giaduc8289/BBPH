
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.CtptmangHEnt
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
	public class CtptmangHEnt : CtptmangHEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CtptmangHEnt()
		{
			// Nothing for now.
		}

		void BS_CtptmangH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_CtptmangH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_CtptmangH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[CtptmangHFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[CtptmangHFields.Id.Name].ToString();
					txt_Mactpt.Text = _Rowview.Row[CtptmangHFields.Mactpt.Name].ToString();
					txt_Tenctpt.Text = _Rowview.Row[CtptmangHFields.Tenctpt.Name].ToString();
					txt_Ngayapdung.Text = _Rowview.Row[CtptmangHFields.Ngayapdung.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_CtptmangH_CurrentChanged"); }
		}

		private string Save_Data(string _str_CtptmangH_PK)
		{
			CtptmangHEntity _ctptmangHEntity = new CtptmangHEntity();
			
			_ctptmangH.Id = txt_Id.Text.Trim();
			_ctptmangH.Mactpt = txt_Mactpt.Text.Trim();
			_ctptmangH.Tenctpt = txt_Tenctpt.Text.Trim();
			_ctptmangH.Ngayapdung = txt_Ngayapdung.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_CtptmangH_PK = _CtptmangHManager.InsertV2(_CtptmangHEntity, r_Insert, DT_CtptmangH, BS_CtptmangH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangHManager.Convert(_ctptmangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_CtptmangH.ResetCurrentItem();
			}
			else
			{
				_CtptmangHManager.Update(_ctptmangHEntity);
				
				GRID_CtptmangH.CurrentRow.Cells[CtptmangHFields.Id.Name].Value = _ctptmangHEntity.Id;
				GRID_CtptmangH.CurrentRow.Cells[CtptmangHFields.Mactpt.Name].Value = _ctptmangHEntity.Mactpt;
				GRID_CtptmangH.CurrentRow.Cells[CtptmangHFields.Tenctpt.Name].Value = _ctptmangHEntity.Tenctpt;
				GRID_CtptmangH.CurrentRow.Cells[CtptmangHFields.Ngayapdung.Name].Value = _ctptmangHEntity.Ngayapdung;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_CtptmangHManager.Convert(_ctptmangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_CtptmangH_PK;
		}

	}
}
