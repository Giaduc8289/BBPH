
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
					txt_Ngaytao.Text = _Rowview.Row[DmlydonhapxuatFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmlydonhapxuatFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmlydonhapxuatFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmlydonhapxuatFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmlydonhapxuat_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmlydonhapxuat_PK)
		{
			DmlydonhapxuatEntity _dmlydonhapxuatEntity = new DmlydonhapxuatEntity();
			
			_dmlydonhapxuatEntity.Malydo = txt_Malydo.Text.Trim();
			_dmlydonhapxuatEntity.Tenlydo = txt_Tenlydo.Text.Trim();
			_dmlydonhapxuatEntity.Manhom = txt_Manhom.Text.Trim();
			_dmlydonhapxuatEntity.Tennhom = txt_Tennhom.Text.Trim();
			_dmlydonhapxuatEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmlydonhapxuatEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmlydonhapxuatEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmlydonhapxuatEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
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
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Ngaytao.Name].Value = _dmlydonhapxuatEntity.Ngaytao;
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Nguoitao.Name].Value = _dmlydonhapxuatEntity.Nguoitao;
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Ngaysua.Name].Value = _dmlydonhapxuatEntity.Ngaysua;
				GRID_Dmlydonhapxuat.CurrentRow.Cells[DmlydonhapxuatFields.Nguoisua.Name].Value = _dmlydonhapxuatEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_dmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmlydonhapxuat_PK;
		}

	}
}
