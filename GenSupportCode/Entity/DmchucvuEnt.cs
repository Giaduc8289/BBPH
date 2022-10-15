
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmchucvuEnt
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
	public class DmchucvuEnt : DmchucvuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmchucvuEnt()
		{
			// Nothing for now.
		}

		void BS_DMCHUCVU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMCHUCVU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMCHUCVU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmchucvuFields.Macv.Name].ToString();
					
					txt_MACV.Text = _Rowview.Row[DmchucvuFields.Macv.Name].ToString();
					txt_TENCHUCVU.Text = _Rowview.Row[DmchucvuFields.Tenchucvu.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmchucvuFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmchucvuFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmchucvuFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmchucvuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCHUCVU_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMCHUCVU_PK)
		{
			DmchucvuEntity _dmchucvuEntity = new DmchucvuEntity();
			
			_dmchucvuEntity.Macv = txt_MACV.Text.Trim();
			_dmchucvuEntity.Tenchucvu = txt_TENCHUCVU.Text.Trim();
			_dmchucvuEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmchucvuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmchucvuEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmchucvuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMCHUCVU_PK))
			{
				_str_DMCHUCVU_PK = _DmchucvuManager.InsertV2(_dmchucvuEntity, r_Insert, DT_DMCHUCVU, BS_DMCHUCVU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_dmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMCHUCVU.ResetCurrentItem();
			}
			else
			{
				_DmchucvuManager.Update(_dmchucvuEntity);
				
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Macv.Name].Value = _dmchucvuEntity.Macv;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Tenchucvu.Name].Value = _dmchucvuEntity.Tenchucvu;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Ngaytao.Name].Value = _dmchucvuEntity.Ngaytao;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Nguoitao.Name].Value = _dmchucvuEntity.Nguoitao;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Ngaysua.Name].Value = _dmchucvuEntity.Ngaysua;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Nguoisua.Name].Value = _dmchucvuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_dmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMCHUCVU_PK;
		}

	}
}
