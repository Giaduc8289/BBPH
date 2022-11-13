
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
			DmkhachEntity _DmkhachEntity = new DmkhachEntity();
			_DmkhachEntity.Makhach = txt_MAKHACH.Text.Trim();
			_DmkhachEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_DmkhachEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			try { _DmkhachEntity.Truyenthong = System.Boolean.Parse(txt_TRUYENTHONG.Text.Trim()); } 
			catch { }
			_DmkhachEntity.Diachi = txt_DIACHI.Text.Trim();
			_DmkhachEntity.Sodienthoai = txt_SODIENTHOAI.Text.Trim();
			_DmkhachEntity.Email = txt_EMAIL.Text.Trim();
			_DmkhachEntity.Tknganhang = txt_TKNGANHANG.Text.Trim();
			_DmkhachEntity.Tennganhang = txt_TENNGANHANG.Text.Trim();
			try { _DmkhachEntity.Noidia = System.Boolean.Parse(txt_NOIDIA.Text.Trim()); } 
			catch { }
			_DmkhachEntity.Tennguoilh = txt_TENNGUOILH.Text.Trim();
			_DmkhachEntity.Chucvu = txt_CHUCVU.Text.Trim();
			_DmkhachEntity.Sodienthoailh = txt_SODIENTHOAILH.Text.Trim();
			_DmkhachEntity.Thongtinbosung = txt_THONGTINBOSUNG.Text.Trim();
			try { _DmkhachEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_DmkhachEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _DmkhachEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_DmkhachEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_DMKHACH_PK))
			{
				_str_DMKHACH_PK = _DmkhachManager.InsertV2(_DmkhachEntity, r_Insert, DT_DMKHACH, BS_DMKHACH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_DmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMKHACH.ResetCurrentItem();
			}
			else
			{
				_DmkhachManager.Update(_DmkhachEntity);
				
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Makhach.Name].Value = _DmkhachEntity.Makhach;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tenkhach.Name].Value = _DmkhachEntity.Tenkhach;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tenrutgon.Name].Value = _DmkhachEntity.Tenrutgon;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Truyenthong.Name].Value = _DmkhachEntity.Truyenthong;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Diachi.Name].Value = _DmkhachEntity.Diachi;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Sodienthoai.Name].Value = _DmkhachEntity.Sodienthoai;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Email.Name].Value = _DmkhachEntity.Email;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tknganhang.Name].Value = _DmkhachEntity.Tknganhang;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tennganhang.Name].Value = _DmkhachEntity.Tennganhang;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Noidia.Name].Value = _DmkhachEntity.Noidia;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Tennguoilh.Name].Value = _DmkhachEntity.Tennguoilh;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Chucvu.Name].Value = _DmkhachEntity.Chucvu;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Sodienthoailh.Name].Value = _DmkhachEntity.Sodienthoailh;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Thongtinbosung.Name].Value = _DmkhachEntity.Thongtinbosung;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Ngaytao.Name].Value = _DmkhachEntity.Ngaytao;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Nguoitao.Name].Value = _DmkhachEntity.Nguoitao;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Ngaysua.Name].Value = _DmkhachEntity.Ngaysua;
				GRID_DMKHACH.CurrentRow.Cells[DmkhachFields.Nguoisua.Name].Value = _DmkhachEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmkhachManager.Convert(_DmkhachEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMKHACH_PK;
		}

	}
}
