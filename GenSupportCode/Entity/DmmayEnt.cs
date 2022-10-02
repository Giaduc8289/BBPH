
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmmayEnt
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
	public class DmmayEnt : DmmayEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmayEnt()
		{
			// Nothing for now.
		}

		void BS_Dmmay_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmmay.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmmay.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmmayFields.Mamay.Name].ToString();
					
					txt_Mamay.Text = _Rowview.Row[DmmayFields.Mamay.Name].ToString();
					txt_Tenmay.Text = _Rowview.Row[DmmayFields.Tenmay.Name].ToString();
					txt_Madm.Text = _Rowview.Row[DmmayFields.Madm.Name].ToString();
					txt_Vitri.Text = _Rowview.Row[DmmayFields.Vitri.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmmay_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmmay_PK)
		{
			DmmayEntity _dmmayEntity = new DmmayEntity();
			
			_dmmay.Mamay = txt_Mamay.Text.Trim();
			_dmmay.Tenmay = txt_Tenmay.Text.Trim();
			_dmmay.Madm = txt_Madm.Text.Trim();
			_dmmay.Vitri = txt_Vitri.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmmay_PK = _DmmayManager.InsertV2(_DmmayEntity, r_Insert, DT_Dmmay, BS_Dmmay);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmayManager.Convert(_dmmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmmay.ResetCurrentItem();
			}
			else
			{
				_DmmayManager.Update(_dmmayEntity);
				
				GRID_Dmmay.CurrentRow.Cells[DmmayFields.Mamay.Name].Value = _dmmayEntity.Mamay;
				GRID_Dmmay.CurrentRow.Cells[DmmayFields.Tenmay.Name].Value = _dmmayEntity.Tenmay;
				GRID_Dmmay.CurrentRow.Cells[DmmayFields.Madm.Name].Value = _dmmayEntity.Madm;
				GRID_Dmmay.CurrentRow.Cells[DmmayFields.Vitri.Name].Value = _dmmayEntity.Vitri;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmmayManager.Convert(_dmmayEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmmay_PK;
		}

	}
}
