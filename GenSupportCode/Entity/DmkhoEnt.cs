
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmkhoEnt
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
	public class DmkhoEnt : DmkhoEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmkhoEnt()
		{
			// Nothing for now.
		}

		void BS_DMKHO_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMKHO.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMKHO.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmkhoFields.Makho.Name].ToString();
					
					txt_MAKHO.Text = _Rowview.Row[DmkhoFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[DmkhoFields.Tenkho.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DmkhoFields.Tenrutgon.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmkhoFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmkhoFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmkhoFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmkhoFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMKHO_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMKHO_PK)
		{
			DmkhoEntity _dmkhoEntity = new DmkhoEntity();
			
			_dmkhoEntity.Makho = txt_MAKHO.Text.Trim();
			_dmkhoEntity.Tenkho = txt_TENKHO.Text.Trim();
			_dmkhoEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			_dmkhoEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmkhoEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmkhoEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmkhoEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMKHO_PK))
			{
				_str_DMKHO_PK = _DmkhoManager.InsertV2(_dmkhoEntity, r_Insert, DT_DMKHO, BS_DMKHO);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhoManager.Convert(_dmkhoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMKHO.ResetCurrentItem();
			}
			else
			{
				_DmkhoManager.Update(_dmkhoEntity);
				
				GRID_DMKHO.CurrentRow.Cells[DmkhoFields.Makho.Name].Value = _dmkhoEntity.Makho;
				GRID_DMKHO.CurrentRow.Cells[DmkhoFields.Tenkho.Name].Value = _dmkhoEntity.Tenkho;
				GRID_DMKHO.CurrentRow.Cells[DmkhoFields.Tenrutgon.Name].Value = _dmkhoEntity.Tenrutgon;
				GRID_DMKHO.CurrentRow.Cells[DmkhoFields.Ngaytao.Name].Value = _dmkhoEntity.Ngaytao;
				GRID_DMKHO.CurrentRow.Cells[DmkhoFields.Nguoitao.Name].Value = _dmkhoEntity.Nguoitao;
				GRID_DMKHO.CurrentRow.Cells[DmkhoFields.Ngaysua.Name].Value = _dmkhoEntity.Ngaysua;
				GRID_DMKHO.CurrentRow.Cells[DmkhoFields.Nguoisua.Name].Value = _dmkhoEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhoManager.Convert(_dmkhoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMKHO_PK;
		}

	}
}
