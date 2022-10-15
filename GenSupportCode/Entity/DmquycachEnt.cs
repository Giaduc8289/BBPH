
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

		void BS_DMQUYCACH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMQUYCACH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMQUYCACH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmquycachFields.Maquycach.Name].ToString();
					
					txt_MAQUYCACH.Text = _Rowview.Row[DmquycachFields.Maquycach.Name].ToString();
					txt_TENQUYCACH.Text = _Rowview.Row[DmquycachFields.Tenquycach.Name].ToString();
					txt_MACONGDOAN.Text = _Rowview.Row[DmquycachFields.Macongdoan.Name].ToString();
					txt_TENCONGDOAN.Text = _Rowview.Row[DmquycachFields.Tencongdoan.Name].ToString();
					txt_MANHOM.Text = _Rowview.Row[DmquycachFields.Manhom.Name].ToString();
					txt_TENNHOM.Text = _Rowview.Row[DmquycachFields.Tennhom.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmquycachFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmquycachFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmquycachFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmquycachFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMQUYCACH_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMQUYCACH_PK)
		{
			DmquycachEntity _dmquycachEntity = new DmquycachEntity();
			
			_dmquycachEntity.Maquycach = txt_MAQUYCACH.Text.Trim();
			_dmquycachEntity.Tenquycach = txt_TENQUYCACH.Text.Trim();
			_dmquycachEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
			_dmquycachEntity.Tencongdoan = txt_TENCONGDOAN.Text.Trim();
			_dmquycachEntity.Manhom = txt_MANHOM.Text.Trim();
			_dmquycachEntity.Tennhom = txt_TENNHOM.Text.Trim();
			_dmquycachEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmquycachEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmquycachEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmquycachEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMQUYCACH_PK))
			{
				_str_DMQUYCACH_PK = _DmquycachManager.InsertV2(_dmquycachEntity, r_Insert, DT_DMQUYCACH, BS_DMQUYCACH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_dmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMQUYCACH.ResetCurrentItem();
			}
			else
			{
				_DmquycachManager.Update(_dmquycachEntity);
				
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Maquycach.Name].Value = _dmquycachEntity.Maquycach;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Tenquycach.Name].Value = _dmquycachEntity.Tenquycach;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Macongdoan.Name].Value = _dmquycachEntity.Macongdoan;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Tencongdoan.Name].Value = _dmquycachEntity.Tencongdoan;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Manhom.Name].Value = _dmquycachEntity.Manhom;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Tennhom.Name].Value = _dmquycachEntity.Tennhom;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Ngaytao.Name].Value = _dmquycachEntity.Ngaytao;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Nguoitao.Name].Value = _dmquycachEntity.Nguoitao;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Ngaysua.Name].Value = _dmquycachEntity.Ngaysua;
				GRID_DMQUYCACH.CurrentRow.Cells[DmquycachFields.Nguoisua.Name].Value = _dmquycachEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmquycachManager.Convert(_dmquycachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMQUYCACH_PK;
		}

	}
}
