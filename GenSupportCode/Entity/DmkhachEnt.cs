
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmkhachEnt
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
	public class DmkhachEnt : DmkhachEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmkhachEnt()
		{
			// Nothing for now.
		}

		void BS_DMKHACH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMKHACH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMKHACH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmkhachFields.Makhach.Name].ToString();
					
					txt_MAKHACH.Text = _Rowview.Row[DmkhachFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[DmkhachFields.Tenkhach.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DmkhachFields.Tenrutgon.Name].ToString();
					txt_TRUYENTHONG.Text = _Rowview.Row[DmkhachFields.Truyenthong.Name].ToString();
					txt_DIACHI.Text = _Rowview.Row[DmkhachFields.Diachi.Name].ToString();
					txt_SODIENTHOAI.Text = _Rowview.Row[DmkhachFields.Sodienthoai.Name].ToString();
					txt_EMAIL.Text = _Rowview.Row[DmkhachFields.Email.Name].ToString();
					txt_TKNGANHANG.Text = _Rowview.Row[DmkhachFields.Tknganhang.Name].ToString();
					txt_TENNGANHANG.Text = _Rowview.Row[DmkhachFields.Tennganhang.Name].ToString();
					txt_NOIDIA.Text = _Rowview.Row[DmkhachFields.Noidia.Name].ToString();
					txt_TENNGUOILH.Text = _Rowview.Row[DmkhachFields.Tennguoilh.Name].ToString();
					txt_CHUCVU.Text = _Rowview.Row[DmkhachFields.Chucvu.Name].ToString();
					txt_SODIENTHOAILH.Text = _Rowview.Row[DmkhachFields.Sodienthoailh.Name].ToString();
					txt_THONGTINBOSUNG.Text = _Rowview.Row[DmkhachFields.Thongtinbosung.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmkhachFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmkhachFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmkhachFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmkhachFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMKHACH_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMKHACH_PK)
		{
			DmkhachEntity _dmkhachEntity = new DmkhachEntity();
			
			_dmkhachEntity.Makhach = txt_MAKHACH.Text.Trim();
			_dmkhachEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_dmkhachEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			_dmkhachEntity.Truyenthong = txt_TRUYENTHONG.Text.Trim();
			_dmkhachEntity.Diachi = txt_DIACHI.Text.Trim();
			_dmkhachEntity.Sodienthoai = txt_SODIENTHOAI.Text.Trim();
			_dmkhachEntity.Email = txt_EMAIL.Text.Trim();
			_dmkhachEntity.Tknganhang = txt_TKNGANHANG.Text.Trim();
			_dmkhachEntity.Tennganhang = txt_TENNGANHANG.Text.Trim();
			_dmkhachEntity.Noidia = txt_NOIDIA.Text.Trim();
			_dmkhachEntity.Tennguoilh = txt_TENNGUOILH.Text.Trim();
			_dmkhachEntity.Chucvu = txt_CHUCVU.Text.Trim();
			_dmkhachEntity.Sodienthoailh = txt_SODIENTHOAILH.Text.Trim();
			_dmkhachEntity.Thongtinbosung = txt_THONGTINBOSUNG.Text.Trim();
			_dmkhachEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmkhachEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmkhachEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmkhachEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMKHACH_PK))
			{
				_str_DMKHACH_PK = _DmkhachManager.InsertV2(_dmkhachEntity, r_Insert, DT_DMKHACH, BS_DMKHACH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_dmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMKHACH.ResetCurrentItem();
			}
			else
			{
				_DmkhachManager.Update(_dmkhachEntity);
				
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Makhach.Name].Value = _dmkhachEntity.Makhach;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tenkhach.Name].Value = _dmkhachEntity.Tenkhach;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tenrutgon.Name].Value = _dmkhachEntity.Tenrutgon;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Truyenthong.Name].Value = _dmkhachEntity.Truyenthong;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Diachi.Name].Value = _dmkhachEntity.Diachi;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Sodienthoai.Name].Value = _dmkhachEntity.Sodienthoai;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Email.Name].Value = _dmkhachEntity.Email;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tknganhang.Name].Value = _dmkhachEntity.Tknganhang;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tennganhang.Name].Value = _dmkhachEntity.Tennganhang;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Noidia.Name].Value = _dmkhachEntity.Noidia;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tennguoilh.Name].Value = _dmkhachEntity.Tennguoilh;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Chucvu.Name].Value = _dmkhachEntity.Chucvu;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Sodienthoailh.Name].Value = _dmkhachEntity.Sodienthoailh;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Thongtinbosung.Name].Value = _dmkhachEntity.Thongtinbosung;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Ngaytao.Name].Value = _dmkhachEntity.Ngaytao;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Nguoitao.Name].Value = _dmkhachEntity.Nguoitao;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Ngaysua.Name].Value = _dmkhachEntity.Ngaysua;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Nguoisua.Name].Value = _dmkhachEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_dmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMKHACH_PK;
		}

	}
}
