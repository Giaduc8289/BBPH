
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

		void BS_DMLYDONHAPXUAT_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMLYDONHAPXUAT.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMLYDONHAPXUAT.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmlydonhapxuatFields.Malydo.Name].ToString();
					
					txt_MALYDO.Text = _Rowview.Row[DmlydonhapxuatFields.Malydo.Name].ToString();
					txt_TENLYDO.Text = _Rowview.Row[DmlydonhapxuatFields.Tenlydo.Name].ToString();
					txt_MANHOM.Text = _Rowview.Row[DmlydonhapxuatFields.Manhom.Name].ToString();
					txt_TENNHOM.Text = _Rowview.Row[DmlydonhapxuatFields.Tennhom.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmlydonhapxuatFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmlydonhapxuatFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmlydonhapxuatFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmlydonhapxuatFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMLYDONHAPXUAT_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMLYDONHAPXUAT_PK)
		{
			DmlydonhapxuatEntity _dmlydonhapxuatEntity = new DmlydonhapxuatEntity();
			
			_dmlydonhapxuatEntity.Malydo = txt_MALYDO.Text.Trim();
			_dmlydonhapxuatEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_dmlydonhapxuatEntity.Manhom = txt_MANHOM.Text.Trim();
			_dmlydonhapxuatEntity.Tennhom = txt_TENNHOM.Text.Trim();
			_dmlydonhapxuatEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmlydonhapxuatEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmlydonhapxuatEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmlydonhapxuatEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMLYDONHAPXUAT_PK))
			{
				_str_DMLYDONHAPXUAT_PK = _DmlydonhapxuatManager.InsertV2(_dmlydonhapxuatEntity, r_Insert, DT_DMLYDONHAPXUAT, BS_DMLYDONHAPXUAT);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_dmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMLYDONHAPXUAT.ResetCurrentItem();
			}
			else
			{
				_DmlydonhapxuatManager.Update(_dmlydonhapxuatEntity);
				
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Malydo.Name].Value = _dmlydonhapxuatEntity.Malydo;
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Tenlydo.Name].Value = _dmlydonhapxuatEntity.Tenlydo;
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Manhom.Name].Value = _dmlydonhapxuatEntity.Manhom;
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Tennhom.Name].Value = _dmlydonhapxuatEntity.Tennhom;
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Ngaytao.Name].Value = _dmlydonhapxuatEntity.Ngaytao;
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Nguoitao.Name].Value = _dmlydonhapxuatEntity.Nguoitao;
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Ngaysua.Name].Value = _dmlydonhapxuatEntity.Ngaysua;
				GRID_DMLYDONHAPXUAT.CurrentRow.Cells[DmlydonhapxuatFields.Nguoisua.Name].Value = _dmlydonhapxuatEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmlydonhapxuatManager.Convert(_dmlydonhapxuatEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMLYDONHAPXUAT_PK;
		}

	}
}
