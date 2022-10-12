
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmquycachEnt
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
	public class DmquycachEnt : DmquycachEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmquycachEnt()
		{
			// Nothing for now.
		}

		void BS_Dmquycach_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmquycach.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmquycach.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmquycachFields.Maquycach.Name].ToString();
					
					txt_Maquycach.Text = _Rowview.Row[DmquycachFields.Maquycach.Name].ToString();
					txt_Tenquycach.Text = _Rowview.Row[DmquycachFields.Tenquycach.Name].ToString();
					txt_Macongdoan.Text = _Rowview.Row[DmquycachFields.Macongdoan.Name].ToString();
					txt_Tencongdoan.Text = _Rowview.Row[DmquycachFields.Tencongdoan.Name].ToString();
					txt_Manhom.Text = _Rowview.Row[DmquycachFields.Manhom.Name].ToString();
					txt_Tennhom.Text = _Rowview.Row[DmquycachFields.Tennhom.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmquycachFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmquycachFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmquycachFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmquycachFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmquycach_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmquycach_PK)
		{
			DmquycachEntity _dmquycachEntity = new DmquycachEntity();
			
			_dmquycachEntity.Maquycach = txt_Maquycach.Text.Trim();
			_dmquycachEntity.Tenquycach = txt_Tenquycach.Text.Trim();
			_dmquycachEntity.Macongdoan = txt_Macongdoan.Text.Trim();
			_dmquycachEntity.Tencongdoan = txt_Tencongdoan.Text.Trim();
			_dmquycachEntity.Manhom = txt_Manhom.Text.Trim();
			_dmquycachEntity.Tennhom = txt_Tennhom.Text.Trim();
			_dmquycachEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmquycachEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmquycachEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmquycachEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmquycach_PK = _DmquycachManager.InsertV2(_DmquycachEntity, r_Insert, DT_Dmquycach, BS_Dmquycach);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_dmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmquycach.ResetCurrentItem();
			}
			else
			{
				_DmquycachManager.Update(_dmquycachEntity);
				
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Maquycach.Name].Value = _dmquycachEntity.Maquycach;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Tenquycach.Name].Value = _dmquycachEntity.Tenquycach;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Macongdoan.Name].Value = _dmquycachEntity.Macongdoan;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Tencongdoan.Name].Value = _dmquycachEntity.Tencongdoan;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Manhom.Name].Value = _dmquycachEntity.Manhom;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Tennhom.Name].Value = _dmquycachEntity.Tennhom;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Ngaytao.Name].Value = _dmquycachEntity.Ngaytao;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Nguoitao.Name].Value = _dmquycachEntity.Nguoitao;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Ngaysua.Name].Value = _dmquycachEntity.Ngaysua;
				GRID_Dmquycach.CurrentRow.Cells[DmquycachFields.Nguoisua.Name].Value = _dmquycachEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_dmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmquycach_PK;
		}

	}
}
