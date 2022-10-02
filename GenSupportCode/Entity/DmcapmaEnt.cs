
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmcapmaEnt
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
	public class DmcapmaEnt : DmcapmaEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcapmaEnt()
		{
			// Nothing for now.
		}

		void BS_Dmcapma_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmcapma.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmcapma.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmcapmaFields.Loaima.Name].ToString();
					
					txt_Macappk.Text = _Rowview.Row[DmcapmaFields.Macappk.Name].ToString();
					txt_Loaima.Text = _Rowview.Row[DmcapmaFields.Loaima.Name].ToString();
					txt_Mastart.Text = _Rowview.Row[DmcapmaFields.Mastart.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmcapma_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmcapma_PK)
		{
			DmcapmaEntity _dmcapmaEntity = new DmcapmaEntity();
			
			_dmcapma.Macappk = txt_Macappk.Text.Trim();
			_dmcapma.Loaima = txt_Loaima.Text.Trim();
			_dmcapma.Mastart = txt_Mastart.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmcapma_PK = _DmcapmaManager.InsertV2(_DmcapmaEntity, r_Insert, DT_Dmcapma, BS_Dmcapma);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcapmaManager.Convert(_dmcapmaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmcapma.ResetCurrentItem();
			}
			else
			{
				_DmcapmaManager.Update(_dmcapmaEntity);
				
				GRID_Dmcapma.CurrentRow.Cells[DmcapmaFields.Macappk.Name].Value = _dmcapmaEntity.Macappk;
				GRID_Dmcapma.CurrentRow.Cells[DmcapmaFields.Loaima.Name].Value = _dmcapmaEntity.Loaima;
				GRID_Dmcapma.CurrentRow.Cells[DmcapmaFields.Mastart.Name].Value = _dmcapmaEntity.Mastart;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcapmaManager.Convert(_dmcapmaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmcapma_PK;
		}

	}
}
