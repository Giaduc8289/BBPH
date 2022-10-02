
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmbophanEnt
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
	public class DmbophanEnt : DmbophanEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmbophanEnt()
		{
			// Nothing for now.
		}

		void BS_Dmbophan_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmbophan.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmbophan.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmbophanFields.Mabp.Name].ToString();
					
					txt_Mabp.Text = _Rowview.Row[DmbophanFields.Mabp.Name].ToString();
					txt_Tenbophan.Text = _Rowview.Row[DmbophanFields.Tenbophan.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmbophan_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmbophan_PK)
		{
			DmbophanEntity _dmbophanEntity = new DmbophanEntity();
			
			_dmbophan.Mabp = txt_Mabp.Text.Trim();
			_dmbophan.Tenbophan = txt_Tenbophan.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmbophan_PK = _DmbophanManager.InsertV2(_DmbophanEntity, r_Insert, DT_Dmbophan, BS_Dmbophan);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmbophanManager.Convert(_dmbophanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmbophan.ResetCurrentItem();
			}
			else
			{
				_DmbophanManager.Update(_dmbophanEntity);
				
				GRID_Dmbophan.CurrentRow.Cells[DmbophanFields.Mabp.Name].Value = _dmbophanEntity.Mabp;
				GRID_Dmbophan.CurrentRow.Cells[DmbophanFields.Tenbophan.Name].Value = _dmbophanEntity.Tenbophan;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmbophanManager.Convert(_dmbophanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmbophan_PK;
		}

	}
}
