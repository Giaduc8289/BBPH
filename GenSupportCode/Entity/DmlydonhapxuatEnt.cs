
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmlydonhapxuatEnt
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
	public class DmlydonhapxuatEnt : DmlydonhapxuatEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmlydonhapxuatEnt()
		{
			// Nothing for now.
		}

		void BS_Dmlydonhapxuat_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmlydonhapxuat.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmlydonhapxuat.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmlydonhapxuatFields.Malydo.Name].ToString();
					
					txt_Malydo.Text = _Rowview.Row[DmlydonhapxuatFields.Malydo.Name].ToString();
					txt_Tenlydo.Text = _Rowview.Row[DmlydonhapxuatFields.Tenlydo.Name].ToString();
					txt_Manhom.Text = _Rowview.Row[DmlydonhapxuatFields.Manhom.Name].ToString();
					txt_Tennhom.Text = _Rowview.Row[DmlydonhapxuatFields.Tennhom.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmlydonhapxuat_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmlydonhapxuat_PK)
		{
			DmlydonhapxuatEntity _dmlydonhapxuatEntity = new DmlydonhapxuatEntity();
			
			_dmlydonhapxuat.Malydo = txt_Malydo.Text.Trim();
			_dmlydonhapxuat.Tenlydo = txt_Tenlydo.Text.Trim();
			_dmlydonhapxuat.Manhom = txt_Manhom.Text.Trim();
			_dmlydonhapxuat.Tennhom = txt_Tennhom.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmlydonhapxuat_PK = _DmlydonhapxuatManager.InsertV2(_DmlydonhapxuatEntity, r_Insert, DT_Dmlydonhapxuat, BS_Dmlydonhapxuat);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_dmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmlydonhapxuat.ResetCurrentItem();
			}
			else
			{
				_DmlydonhapxuatManager.Update(_dmlydonhapxuatEntity);
				
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Malydo.Name].Value = _dmlydonhapxuatEntity.Malydo;
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Tenlydo.Name].Value = _dmlydonhapxuatEntity.Tenlydo;
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Manhom.Name].Value = _dmlydonhapxuatEntity.Manhom;
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Tennhom.Name].Value = _dmlydonhapxuatEntity.Tennhom;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_dmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmlydonhapxuat_PK;
		}

	}
}
