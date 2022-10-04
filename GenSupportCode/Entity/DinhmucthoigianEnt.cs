
/*
'===============================================================================
'  GD.BBPH.DAL.DAL.EntityClasses.DinhmucthoigianEnt
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using GD.BBPH.DAL.BLL;
using GD.BBPH.DAL.DAL;
using GD.BBPH.DAL.DAL.EntityClasses;
using GD.BBPH.DAL.DAL.FactoryClasses;
using GD.BBPH.DAL.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.DAL.EntityClasses
{
	public class DinhmucthoigianEnt : DinhmucthoigianEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmucthoigianEnt()
		{
			// Nothing for now.
		}

		void BS_Dinhmucthoigian_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.DAL.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.DAL.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dinhmucthoigian.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dinhmucthoigian.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DinhmucthoigianFields.Madmtg.Name].ToString();
					
					txt_Madmtg.Text = _Rowview.Row[DinhmucthoigianFields.Madmtg.Name].ToString();
					txt_Tendinhmuc.Text = _Rowview.Row[DinhmucthoigianFields.Tendinhmuc.Name].ToString();
					txt_Mamay.Text = _Rowview.Row[DinhmucthoigianFields.Mamay.Name].ToString();
					txt_Madm.Text = _Rowview.Row[DinhmucthoigianFields.Madm.Name].ToString();
					txt_Dauca.Text = _Rowview.Row[DinhmucthoigianFields.Dauca.Name].ToString();
					txt_Doilenh.Text = _Rowview.Row[DinhmucthoigianFields.Doilenh.Name].ToString();
					txt_Lencuon.Text = _Rowview.Row[DinhmucthoigianFields.Lencuon.Name].ToString();
					txt_Xuongcuon.Text = _Rowview.Row[DinhmucthoigianFields.Xuongcuon.Name].ToString();
					txt_Thaythietbi.Text = _Rowview.Row[DinhmucthoigianFields.Thaythietbi.Name].ToString();
					txt_Dungmay.Text = _Rowview.Row[DinhmucthoigianFields.Dungmay.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dinhmucthoigian_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dinhmucthoigian_PK)
		{
			DinhmucthoigianEntity _dinhmucthoigianEntity = new DinhmucthoigianEntity();
			
			_dinhmucthoigian.Madmtg = txt_Madmtg.Text.Trim();
			_dinhmucthoigian.Tendinhmuc = txt_Tendinhmuc.Text.Trim();
			_dinhmucthoigian.Mamay = txt_Mamay.Text.Trim();
			_dinhmucthoigian.Madm = txt_Madm.Text.Trim();
			_dinhmucthoigian.Dauca = txt_Dauca.Text.Trim();
			_dinhmucthoigian.Doilenh = txt_Doilenh.Text.Trim();
			_dinhmucthoigian.Lencuon = txt_Lencuon.Text.Trim();
			_dinhmucthoigian.Xuongcuon = txt_Xuongcuon.Text.Trim();
			_dinhmucthoigian.Thaythietbi = txt_Thaythietbi.Text.Trim();
			_dinhmucthoigian.Dungmay = txt_Dungmay.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dinhmucthoigian_PK = _DinhmucthoigianManager.InsertV2(_DinhmucthoigianEntity, r_Insert, DT_Dinhmucthoigian, BS_Dinhmucthoigian);
				GD.BBPH.DAL.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_dinhmucthoigianEntity), GD.BBPH.DAL.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dinhmucthoigian.ResetCurrentItem();
			}
			else
			{
				_DinhmucthoigianManager.Update(_dinhmucthoigianEntity);
				
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Madmtg.Name].Value = _dinhmucthoigianEntity.Madmtg;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Tendinhmuc.Name].Value = _dinhmucthoigianEntity.Tendinhmuc;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Mamay.Name].Value = _dinhmucthoigianEntity.Mamay;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Madm.Name].Value = _dinhmucthoigianEntity.Madm;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Dauca.Name].Value = _dinhmucthoigianEntity.Dauca;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Doilenh.Name].Value = _dinhmucthoigianEntity.Doilenh;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Lencuon.Name].Value = _dinhmucthoigianEntity.Lencuon;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Xuongcuon.Name].Value = _dinhmucthoigianEntity.Xuongcuon;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Thaythietbi.Name].Value = _dinhmucthoigianEntity.Thaythietbi;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Dungmay.Name].Value = _dinhmucthoigianEntity.Dungmay;
				GD.BBPH.DAL.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_dinhmucthoigianEntity), GD.BBPH.DAL.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dinhmucthoigian_PK;
		}

	}
}
