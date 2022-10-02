
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmnguyenlieuEnt
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
	public class DmnguyenlieuEnt : DmnguyenlieuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnguyenlieuEnt()
		{
			// Nothing for now.
		}

		void BS_Dmnguyenlieu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmnguyenlieu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmnguyenlieu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
					
					txt_Manl.Text = _Rowview.Row[DmnguyenlieuFields.Manl.Name].ToString();
					txt_Tenrutgon.Text = _Rowview.Row[DmnguyenlieuFields.Tenrutgon.Name].ToString();
					txt_Manhom.Text = _Rowview.Row[DmnguyenlieuFields.Manhom.Name].ToString();
					txt_Tennhom.Text = _Rowview.Row[DmnguyenlieuFields.Tennhom.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmnguyenlieu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmnguyenlieu_PK)
		{
			DmnguyenlieuEntity _dmnguyenlieuEntity = new DmnguyenlieuEntity();
			
			_dmnguyenlieu.Manl = txt_Manl.Text.Trim();
			_dmnguyenlieu.Tenrutgon = txt_Tenrutgon.Text.Trim();
			_dmnguyenlieu.Manhom = txt_Manhom.Text.Trim();
			_dmnguyenlieu.Tennhom = txt_Tennhom.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmnguyenlieu_PK = _DmnguyenlieuManager.InsertV2(_DmnguyenlieuEntity, r_Insert, DT_Dmnguyenlieu, BS_Dmnguyenlieu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_dmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmnguyenlieu.ResetCurrentItem();
			}
			else
			{
				_DmnguyenlieuManager.Update(_dmnguyenlieuEntity);
				
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Manl.Name].Value = _dmnguyenlieuEntity.Manl;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Tenrutgon.Name].Value = _dmnguyenlieuEntity.Tenrutgon;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Manhom.Name].Value = _dmnguyenlieuEntity.Manhom;
				GRID_Dmnguyenlieu.CurrentRow.Cells[DmnguyenlieuFields.Tennhom.Name].Value = _dmnguyenlieuEntity.Tennhom;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmnguyenlieuManager.Convert(_dmnguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmnguyenlieu_PK;
		}

	}
}
