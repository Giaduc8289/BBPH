
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmcongnhanEnt
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
	public class DmcongnhanEnt : DmcongnhanEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmcongnhanEnt()
		{
			// Nothing for now.
		}

		void BS_Dmcongnhan_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmcongnhan.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmcongnhan.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmcongnhanFields.Macn.Name].ToString();
					
					txt_Macn.Text = _Rowview.Row[DmcongnhanFields.Macn.Name].ToString();
					txt_Hovatencongnhan.Text = _Rowview.Row[DmcongnhanFields.Hovatencongnhan.Name].ToString();
					txt_Tencongnhan.Text = _Rowview.Row[DmcongnhanFields.Tencongnhan.Name].ToString();
					txt_Mabp.Text = _Rowview.Row[DmcongnhanFields.Mabp.Name].ToString();
					txt_Macv.Text = _Rowview.Row[DmcongnhanFields.Macv.Name].ToString();
					txt_Sodienthoai.Text = _Rowview.Row[DmcongnhanFields.Sodienthoai.Name].ToString();
					txt_Tinhtrang.Text = _Rowview.Row[DmcongnhanFields.Tinhtrang.Name].ToString();
					txt_Phongban.Text = _Rowview.Row[DmcongnhanFields.Phongban.Name].ToString();
					txt_Chucvu.Text = _Rowview.Row[DmcongnhanFields.Chucvu.Name].ToString();
					txt_Danghi.Text = _Rowview.Row[DmcongnhanFields.Danghi.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmcongnhan_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmcongnhan_PK)
		{
			DmcongnhanEntity _dmcongnhanEntity = new DmcongnhanEntity();
			
			_dmcongnhan.Macn = txt_Macn.Text.Trim();
			_dmcongnhan.Hovatencongnhan = txt_Hovatencongnhan.Text.Trim();
			_dmcongnhan.Tencongnhan = txt_Tencongnhan.Text.Trim();
			_dmcongnhan.Mabp = txt_Mabp.Text.Trim();
			_dmcongnhan.Macv = txt_Macv.Text.Trim();
			_dmcongnhan.Sodienthoai = txt_Sodienthoai.Text.Trim();
			_dmcongnhan.Tinhtrang = txt_Tinhtrang.Text.Trim();
			_dmcongnhan.Phongban = txt_Phongban.Text.Trim();
			_dmcongnhan.Chucvu = txt_Chucvu.Text.Trim();
			_dmcongnhan.Danghi = txt_Danghi.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmcongnhan_PK = _DmcongnhanManager.InsertV2(_DmcongnhanEntity, r_Insert, DT_Dmcongnhan, BS_Dmcongnhan);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_dmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmcongnhan.ResetCurrentItem();
			}
			else
			{
				_DmcongnhanManager.Update(_dmcongnhanEntity);
				
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Macn.Name].Value = _dmcongnhanEntity.Macn;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Hovatencongnhan.Name].Value = _dmcongnhanEntity.Hovatencongnhan;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Tencongnhan.Name].Value = _dmcongnhanEntity.Tencongnhan;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Mabp.Name].Value = _dmcongnhanEntity.Mabp;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Macv.Name].Value = _dmcongnhanEntity.Macv;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Sodienthoai.Name].Value = _dmcongnhanEntity.Sodienthoai;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Tinhtrang.Name].Value = _dmcongnhanEntity.Tinhtrang;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Phongban.Name].Value = _dmcongnhanEntity.Phongban;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Chucvu.Name].Value = _dmcongnhanEntity.Chucvu;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Danghi.Name].Value = _dmcongnhanEntity.Danghi;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_dmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmcongnhan_PK;
		}

	}
}
