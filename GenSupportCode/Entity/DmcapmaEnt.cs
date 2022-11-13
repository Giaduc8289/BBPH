
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

		void BS_DMCAPMA_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMCAPMA.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMCAPMA.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmcapmaFields.Loaima.Name].ToString();
					
					txt_MACAPPK.Text = _Rowview.Row[DmcapmaFields.Macappk.Name].ToString();
					txt_LOAIMA.Text = _Rowview.Row[DmcapmaFields.Loaima.Name].ToString();
					txt_MASTART.Text = _Rowview.Row[DmcapmaFields.Mastart.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCAPMA_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMCAPMA_PK)
		{
			DmcapmaEntity _DmcapmaEntity = new DmcapmaEntity();
			_DmcapmaEntity.Macappk = txt_MACAPPK.Text.Trim();
			_DmcapmaEntity.Loaima = txt_LOAIMA.Text.Trim();
			_DmcapmaEntity.Mastart = txt_MASTART.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_DMCAPMA_PK))
			{
				_str_DMCAPMA_PK = _DmcapmaManager.InsertV2(_DmcapmaEntity, r_Insert, DT_DMCAPMA, BS_DMCAPMA);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcapmaManager.Convert(_DmcapmaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMCAPMA.ResetCurrentItem();
			}
			else
			{
				_DmcapmaManager.Update(_DmcapmaEntity);
				
				GRID_DMCAPMA.CurrentRow.Cells[DmcapmaFields.Macappk.Name].Value = _DmcapmaEntity.Macappk;
				GRID_DMCAPMA.CurrentRow.Cells[DmcapmaFields.Loaima.Name].Value = _DmcapmaEntity.Loaima;
				GRID_DMCAPMA.CurrentRow.Cells[DmcapmaFields.Mastart.Name].Value = _DmcapmaEntity.Mastart;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcapmaManager.Convert(_DmcapmaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMCAPMA_PK;
		}

	}
}
