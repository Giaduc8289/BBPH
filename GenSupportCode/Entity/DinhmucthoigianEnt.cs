
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DinhmucthoigianEnt
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
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
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
					txt_Ngaytao.Text = _Rowview.Row[DinhmucthoigianFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DinhmucthoigianFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DinhmucthoigianFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DinhmucthoigianFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dinhmucthoigian_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dinhmucthoigian_PK)
		{
			DinhmucthoigianEntity _dinhmucthoigianEntity = new DinhmucthoigianEntity();
			
			_dinhmucthoigianEntity.Madmtg = txt_Madmtg.Text.Trim();
			_dinhmucthoigianEntity.Tendinhmuc = txt_Tendinhmuc.Text.Trim();
			_dinhmucthoigianEntity.Mamay = txt_Mamay.Text.Trim();
			_dinhmucthoigianEntity.Madm = txt_Madm.Text.Trim();
			_dinhmucthoigianEntity.Dauca = txt_Dauca.Text.Trim();
			_dinhmucthoigianEntity.Doilenh = txt_Doilenh.Text.Trim();
			_dinhmucthoigianEntity.Lencuon = txt_Lencuon.Text.Trim();
			_dinhmucthoigianEntity.Xuongcuon = txt_Xuongcuon.Text.Trim();
			_dinhmucthoigianEntity.Thaythietbi = txt_Thaythietbi.Text.Trim();
			_dinhmucthoigianEntity.Dungmay = txt_Dungmay.Text.Trim();
			_dinhmucthoigianEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dinhmucthoigianEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dinhmucthoigianEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dinhmucthoigianEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dinhmucthoigian_PK = _DinhmucthoigianManager.InsertV2(_DinhmucthoigianEntity, r_Insert, DT_Dinhmucthoigian, BS_Dinhmucthoigian);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_dinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
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
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Ngaytao.Name].Value = _dinhmucthoigianEntity.Ngaytao;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Nguoitao.Name].Value = _dinhmucthoigianEntity.Nguoitao;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Ngaysua.Name].Value = _dinhmucthoigianEntity.Ngaysua;
				GRID_Dinhmucthoigian.CurrentRow.Cells[DinhmucthoigianFields.Nguoisua.Name].Value = _dinhmucthoigianEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_dinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dinhmucthoigian_PK;
		}

	}
}
