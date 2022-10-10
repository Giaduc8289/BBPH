
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
					txt_Ngaytao.Text = _Rowview.Row[DmcongnhanFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmcongnhanFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmcongnhanFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmcongnhanFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmcongnhan_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmcongnhan_PK)
		{
			DmcongnhanEntity _dmcongnhanEntity = new DmcongnhanEntity();
			
			_dmcongnhanEntity.Macn = txt_Macn.Text.Trim();
			_dmcongnhanEntity.Hovatencongnhan = txt_Hovatencongnhan.Text.Trim();
			_dmcongnhanEntity.Tencongnhan = txt_Tencongnhan.Text.Trim();
			_dmcongnhanEntity.Mabp = txt_Mabp.Text.Trim();
			_dmcongnhanEntity.Macv = txt_Macv.Text.Trim();
			_dmcongnhanEntity.Sodienthoai = txt_Sodienthoai.Text.Trim();
			_dmcongnhanEntity.Tinhtrang = txt_Tinhtrang.Text.Trim();
			_dmcongnhanEntity.Phongban = txt_Phongban.Text.Trim();
			_dmcongnhanEntity.Chucvu = txt_Chucvu.Text.Trim();
			_dmcongnhanEntity.Danghi = txt_Danghi.Text.Trim();
			_dmcongnhanEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmcongnhanEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmcongnhanEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmcongnhanEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
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
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Ngaytao.Name].Value = _dmcongnhanEntity.Ngaytao;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Nguoitao.Name].Value = _dmcongnhanEntity.Nguoitao;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Ngaysua.Name].Value = _dmcongnhanEntity.Ngaysua;
				GRID_Dmcongnhan.CurrentRow.Cells[DmcongnhanFields.Nguoisua.Name].Value = _dmcongnhanEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_dmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmcongnhan_PK;
		}

	}
}
