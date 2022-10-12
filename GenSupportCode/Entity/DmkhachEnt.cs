
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

		void BS_Dmkhach_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmkhach.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmkhach.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmkhachFields.Makhach.Name].ToString();
					
					txt_Makhach.Text = _Rowview.Row[DmkhachFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[DmkhachFields.Tenkhach.Name].ToString();
					txt_Tenrutgon.Text = _Rowview.Row[DmkhachFields.Tenrutgon.Name].ToString();
					txt_Truyenthong.Text = _Rowview.Row[DmkhachFields.Truyenthong.Name].ToString();
					txt_Diachi.Text = _Rowview.Row[DmkhachFields.Diachi.Name].ToString();
					txt_Sodienthoai.Text = _Rowview.Row[DmkhachFields.Sodienthoai.Name].ToString();
					txt_Email.Text = _Rowview.Row[DmkhachFields.Email.Name].ToString();
					txt_Tknganhang.Text = _Rowview.Row[DmkhachFields.Tknganhang.Name].ToString();
					txt_Tennganhang.Text = _Rowview.Row[DmkhachFields.Tennganhang.Name].ToString();
					txt_Noidia.Text = _Rowview.Row[DmkhachFields.Noidia.Name].ToString();
					txt_Tennguoilh.Text = _Rowview.Row[DmkhachFields.Tennguoilh.Name].ToString();
					txt_Chucvu.Text = _Rowview.Row[DmkhachFields.Chucvu.Name].ToString();
					txt_Sodienthoailh.Text = _Rowview.Row[DmkhachFields.Sodienthoailh.Name].ToString();
					txt_Thongtinbosung.Text = _Rowview.Row[DmkhachFields.Thongtinbosung.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmkhachFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmkhachFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmkhachFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmkhachFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmkhach_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmkhach_PK)
		{
			DmkhachEntity _dmkhachEntity = new DmkhachEntity();
			
			_dmkhachEntity.Makhach = txt_Makhach.Text.Trim();
			_dmkhachEntity.Tenkhach = txt_Tenkhach.Text.Trim();
			_dmkhachEntity.Tenrutgon = txt_Tenrutgon.Text.Trim();
			_dmkhachEntity.Truyenthong = txt_Truyenthong.Text.Trim();
			_dmkhachEntity.Diachi = txt_Diachi.Text.Trim();
			_dmkhachEntity.Sodienthoai = txt_Sodienthoai.Text.Trim();
			_dmkhachEntity.Email = txt_Email.Text.Trim();
			_dmkhachEntity.Tknganhang = txt_Tknganhang.Text.Trim();
			_dmkhachEntity.Tennganhang = txt_Tennganhang.Text.Trim();
			_dmkhachEntity.Noidia = txt_Noidia.Text.Trim();
			_dmkhachEntity.Tennguoilh = txt_Tennguoilh.Text.Trim();
			_dmkhachEntity.Chucvu = txt_Chucvu.Text.Trim();
			_dmkhachEntity.Sodienthoailh = txt_Sodienthoailh.Text.Trim();
			_dmkhachEntity.Thongtinbosung = txt_Thongtinbosung.Text.Trim();
			_dmkhachEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmkhachEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmkhachEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmkhachEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmkhach_PK = _DmkhachManager.InsertV2(_DmkhachEntity, r_Insert, DT_Dmkhach, BS_Dmkhach);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_dmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmkhach.ResetCurrentItem();
			}
			else
			{
				_DmkhachManager.Update(_dmkhachEntity);
				
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Makhach.Name].Value = _dmkhachEntity.Makhach;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Tenkhach.Name].Value = _dmkhachEntity.Tenkhach;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Tenrutgon.Name].Value = _dmkhachEntity.Tenrutgon;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Truyenthong.Name].Value = _dmkhachEntity.Truyenthong;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Diachi.Name].Value = _dmkhachEntity.Diachi;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Sodienthoai.Name].Value = _dmkhachEntity.Sodienthoai;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Email.Name].Value = _dmkhachEntity.Email;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Tknganhang.Name].Value = _dmkhachEntity.Tknganhang;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Tennganhang.Name].Value = _dmkhachEntity.Tennganhang;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Noidia.Name].Value = _dmkhachEntity.Noidia;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Tennguoilh.Name].Value = _dmkhachEntity.Tennguoilh;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Chucvu.Name].Value = _dmkhachEntity.Chucvu;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Sodienthoailh.Name].Value = _dmkhachEntity.Sodienthoailh;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Thongtinbosung.Name].Value = _dmkhachEntity.Thongtinbosung;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Ngaytao.Name].Value = _dmkhachEntity.Ngaytao;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Nguoitao.Name].Value = _dmkhachEntity.Nguoitao;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Ngaysua.Name].Value = _dmkhachEntity.Ngaysua;
				GRID_Dmkhach.CurrentRow.Cells[DmkhachFields.Nguoisua.Name].Value = _dmkhachEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_dmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmkhach_PK;
		}

	}
}
