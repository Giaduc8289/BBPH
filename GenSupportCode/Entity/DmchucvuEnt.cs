
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
					txt_HESO.Text = _Rowview.Row[DmchucvuFields.Heso.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCHUCVU_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMCHUCVU_PK)
		{
			DmchucvuEntity _DmchucvuEntity = new DmchucvuEntity();
			_DmchucvuEntity.Macv = txt_MACV.Text.Trim();
			_DmchucvuEntity.Tenchucvu = txt_TENCHUCVU.Text.Trim();
			try { _DmchucvuEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_DmchucvuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _DmchucvuEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_DmchucvuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			try { _DmchucvuEntity.Heso = System.Decimal.Parse(txt_HESO.Text.Trim()); } 
			catch { }
			
			
			if (string.IsNullOrEmpty(_str_DMCHUCVU_PK))
			{
				_str_DMCHUCVU_PK = _DmchucvuManager.InsertV2(_DmchucvuEntity, r_Insert, DT_DMCHUCVU, BS_DMCHUCVU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_DmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMCHUCVU.ResetCurrentItem();
			}
			else
			{
				_DmchucvuManager.Update(_DmchucvuEntity);
				
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Macv.Name].Value = _DmchucvuEntity.Macv;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Tenchucvu.Name].Value = _DmchucvuEntity.Tenchucvu;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Ngaytao.Name].Value = _DmchucvuEntity.Ngaytao;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Nguoitao.Name].Value = _DmchucvuEntity.Nguoitao;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Ngaysua.Name].Value = _DmchucvuEntity.Ngaysua;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Nguoisua.Name].Value = _DmchucvuEntity.Nguoisua;
				GRID_DMCHUCVU.CurrentRow.Cells[DmchucvuFields.Heso.Name].Value = _DmchucvuEntity.Heso;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmchucvuManager.Convert(_DmchucvuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMCHUCVU_PK;
		}

	}
}
