
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DinhmuathoigianEnt
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
	public class DinhmuathoigianEnt : DinhmuathoigianEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmuathoigianEnt()
		{
			// Nothing for now.
		}

		void BS_Dinhmuathoigian_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dinhmuathoigian.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dinhmuathoigian.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DinhmuathoigianFields.Madmtg.Name].ToString();
					
					txt_Madmtg.Text = _Rowview.Row[DinhmuathoigianFields.Madmtg.Name].ToString();
					txt_Tendinhmuc.Text = _Rowview.Row[DinhmuathoigianFields.Tendinhmuc.Name].ToString();
					txt_Mamay.Text = _Rowview.Row[DinhmuathoigianFields.Mamay.Name].ToString();
					txt_Madm.Text = _Rowview.Row[DinhmuathoigianFields.Madm.Name].ToString();
					txt_Dauca.Text = _Rowview.Row[DinhmuathoigianFields.Dauca.Name].ToString();
					txt_Doilenh.Text = _Rowview.Row[DinhmuathoigianFields.Doilenh.Name].ToString();
					txt_Lencuon.Text = _Rowview.Row[DinhmuathoigianFields.Lencuon.Name].ToString();
					txt_Xuongcuon.Text = _Rowview.Row[DinhmuathoigianFields.Xuongcuon.Name].ToString();
					txt_Thaythietbi.Text = _Rowview.Row[DinhmuathoigianFields.Thaythietbi.Name].ToString();
					txt_Dungmay.Text = _Rowview.Row[DinhmuathoigianFields.Dungmay.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dinhmuathoigian_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dinhmuathoigian_PK)
		{
			DinhmuathoigianEntity _dinhmuathoigianEntity = new DinhmuathoigianEntity();
			
			_dinhmuathoigian.Madmtg = txt_Madmtg.Text.Trim();
			_dinhmuathoigian.Tendinhmuc = txt_Tendinhmuc.Text.Trim();
			_dinhmuathoigian.Mamay = txt_Mamay.Text.Trim();
			_dinhmuathoigian.Madm = txt_Madm.Text.Trim();
			_dinhmuathoigian.Dauca = txt_Dauca.Text.Trim();
			_dinhmuathoigian.Doilenh = txt_Doilenh.Text.Trim();
			_dinhmuathoigian.Lencuon = txt_Lencuon.Text.Trim();
			_dinhmuathoigian.Xuongcuon = txt_Xuongcuon.Text.Trim();
			_dinhmuathoigian.Thaythietbi = txt_Thaythietbi.Text.Trim();
			_dinhmuathoigian.Dungmay = txt_Dungmay.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dinhmuathoigian_PK = _DinhmuathoigianManager.InsertV2(_DinhmuathoigianEntity, r_Insert, DT_Dinhmuathoigian, BS_Dinhmuathoigian);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmuathoigianManager.Convert(_dinhmuathoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dinhmuathoigian.ResetCurrentItem();
			}
			else
			{
				_DinhmuathoigianManager.Update(_dinhmuathoigianEntity);
				
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Madmtg.Name].Value = _dinhmuathoigianEntity.Madmtg;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Tendinhmuc.Name].Value = _dinhmuathoigianEntity.Tendinhmuc;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Mamay.Name].Value = _dinhmuathoigianEntity.Mamay;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Madm.Name].Value = _dinhmuathoigianEntity.Madm;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Dauca.Name].Value = _dinhmuathoigianEntity.Dauca;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Doilenh.Name].Value = _dinhmuathoigianEntity.Doilenh;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Lencuon.Name].Value = _dinhmuathoigianEntity.Lencuon;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Xuongcuon.Name].Value = _dinhmuathoigianEntity.Xuongcuon;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Thaythietbi.Name].Value = _dinhmuathoigianEntity.Thaythietbi;
				GRID_Dinhmuathoigian.CurrentRow.Cells[DinhmuathoigianFields.Dungmay.Name].Value = _dinhmuathoigianEntity.Dungmay;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmuathoigianManager.Convert(_dinhmuathoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dinhmuathoigian_PK;
		}

	}
}
