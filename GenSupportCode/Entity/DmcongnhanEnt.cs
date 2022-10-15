
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

		void BS_DMCONGNHAN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMCONGNHAN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMCONGNHAN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmcongnhanFields.Macn.Name].ToString();
					
					txt_MACN.Text = _Rowview.Row[DmcongnhanFields.Macn.Name].ToString();
					txt_HOVATENCONGNHAN.Text = _Rowview.Row[DmcongnhanFields.Hovatencongnhan.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[DmcongnhanFields.Tencongnhan.Name].ToString();
					txt_MABP.Text = _Rowview.Row[DmcongnhanFields.Mabp.Name].ToString();
					txt_MACV.Text = _Rowview.Row[DmcongnhanFields.Macv.Name].ToString();
					txt_SODIENTHOAI.Text = _Rowview.Row[DmcongnhanFields.Sodienthoai.Name].ToString();
					txt_TINHTRANG.Text = _Rowview.Row[DmcongnhanFields.Tinhtrang.Name].ToString();
					txt_PHONGBAN.Text = _Rowview.Row[DmcongnhanFields.Phongban.Name].ToString();
					txt_CHUCVU.Text = _Rowview.Row[DmcongnhanFields.Chucvu.Name].ToString();
					txt_DANGHI.Text = _Rowview.Row[DmcongnhanFields.Danghi.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmcongnhanFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmcongnhanFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmcongnhanFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmcongnhanFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMCONGNHAN_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMCONGNHAN_PK)
		{
			DmcongnhanEntity _dmcongnhanEntity = new DmcongnhanEntity();
			
			_dmcongnhanEntity.Macn = txt_MACN.Text.Trim();
			_dmcongnhanEntity.Hovatencongnhan = txt_HOVATENCONGNHAN.Text.Trim();
			_dmcongnhanEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_dmcongnhanEntity.Mabp = txt_MABP.Text.Trim();
			_dmcongnhanEntity.Macv = txt_MACV.Text.Trim();
			_dmcongnhanEntity.Sodienthoai = txt_SODIENTHOAI.Text.Trim();
			_dmcongnhanEntity.Tinhtrang = txt_TINHTRANG.Text.Trim();
			_dmcongnhanEntity.Phongban = txt_PHONGBAN.Text.Trim();
			_dmcongnhanEntity.Chucvu = txt_CHUCVU.Text.Trim();
			_dmcongnhanEntity.Danghi = txt_DANGHI.Text.Trim();
			_dmcongnhanEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmcongnhanEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmcongnhanEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmcongnhanEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMCONGNHAN_PK))
			{
				_str_DMCONGNHAN_PK = _DmcongnhanManager.InsertV2(_dmcongnhanEntity, r_Insert, DT_DMCONGNHAN, BS_DMCONGNHAN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_dmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMCONGNHAN.ResetCurrentItem();
			}
			else
			{
				_DmcongnhanManager.Update(_dmcongnhanEntity);
				
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Macn.Name].Value = _dmcongnhanEntity.Macn;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Hovatencongnhan.Name].Value = _dmcongnhanEntity.Hovatencongnhan;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Tencongnhan.Name].Value = _dmcongnhanEntity.Tencongnhan;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Mabp.Name].Value = _dmcongnhanEntity.Mabp;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Macv.Name].Value = _dmcongnhanEntity.Macv;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Sodienthoai.Name].Value = _dmcongnhanEntity.Sodienthoai;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Tinhtrang.Name].Value = _dmcongnhanEntity.Tinhtrang;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Phongban.Name].Value = _dmcongnhanEntity.Phongban;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Chucvu.Name].Value = _dmcongnhanEntity.Chucvu;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Danghi.Name].Value = _dmcongnhanEntity.Danghi;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Ngaytao.Name].Value = _dmcongnhanEntity.Ngaytao;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Nguoitao.Name].Value = _dmcongnhanEntity.Nguoitao;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Ngaysua.Name].Value = _dmcongnhanEntity.Ngaysua;
				GRID_DMCONGNHAN.CurrentRow.Cells[DmcongnhanFields.Nguoisua.Name].Value = _dmcongnhanEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmcongnhanManager.Convert(_dmcongnhanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMCONGNHAN_PK;
		}

	}
}
