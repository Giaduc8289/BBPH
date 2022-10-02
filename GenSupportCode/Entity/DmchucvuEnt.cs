
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmchucvuEnt
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
	public class DmchucvuEnt : DmchucvuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmchucvuEnt()
		{
			// Nothing for now.
		}

		void BS_Dmchucvu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmchucvu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmchucvu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmchucvuFields.Macv.Name].ToString();
					
					txt_Macv.Text = _Rowview.Row[DmchucvuFields.Macv.Name].ToString();
					txt_Tenchucvu.Text = _Rowview.Row[DmchucvuFields.Tenchucvu.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmchucvu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmchucvu_PK)
		{
			DmchucvuEntity _dmchucvuEntity = new DmchucvuEntity();
			
			_dmchucvu.Macv = txt_Macv.Text.Trim();
			_dmchucvu.Tenchucvu = txt_Tenchucvu.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmchucvu_PK = _DmchucvuManager.InsertV2(_DmchucvuEntity, r_Insert, DT_Dmchucvu, BS_Dmchucvu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_dmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmchucvu.ResetCurrentItem();
			}
			else
			{
				_DmchucvuManager.Update(_dmchucvuEntity);
				
				GRID_Dmchucvu.CurrentRow.Cells[DmchucvuFields.Macv.Name].Value = _dmchucvuEntity.Macv;
				GRID_Dmchucvu.CurrentRow.Cells[DmchucvuFields.Tenchucvu.Name].Value = _dmchucvuEntity.Tenchucvu;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_dmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmchucvu_PK;
		}

	}
}
