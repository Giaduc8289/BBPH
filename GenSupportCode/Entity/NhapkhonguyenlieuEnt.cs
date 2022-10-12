
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.NhapkhonguyenlieuEnt
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
	public class NhapkhonguyenlieuEnt : NhapkhonguyenlieuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NhapkhonguyenlieuEnt()
		{
			// Nothing for now.
		}

		void BS_Nhapkhonguyenlieu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Nhapkhonguyenlieu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Nhapkhonguyenlieu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[NhapkhonguyenlieuFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[NhapkhonguyenlieuFields.Id.Name].ToString();
					txt_Ngaynhap.Text = _Rowview.Row[NhapkhonguyenlieuFields.Ngaynhap.Name].ToString();
					txt_Makho.Text = _Rowview.Row[NhapkhonguyenlieuFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[NhapkhonguyenlieuFields.Tenkho.Name].ToString();
					txt_Manguyenlieu.Text = _Rowview.Row[NhapkhonguyenlieuFields.Manguyenlieu.Name].ToString();
					txt_Tennguyenlieu.Text = _Rowview.Row[NhapkhonguyenlieuFields.Tennguyenlieu.Name].ToString();
					txt_Donvitinh.Text = _Rowview.Row[NhapkhonguyenlieuFields.Donvitinh.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[NhapkhonguyenlieuFields.Soluong.Name].ToString();
					txt_Malydo.Text = _Rowview.Row[NhapkhonguyenlieuFields.Malydo.Name].ToString();
					txt_Tenlydo.Text = _Rowview.Row[NhapkhonguyenlieuFields.Tenlydo.Name].ToString();
					txt_Sohopdongmua.Text = _Rowview.Row[NhapkhonguyenlieuFields.Sohopdongmua.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[NhapkhonguyenlieuFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[NhapkhonguyenlieuFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[NhapkhonguyenlieuFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[NhapkhonguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Nhapkhonguyenlieu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Nhapkhonguyenlieu_PK)
		{
			NhapkhonguyenlieuEntity _nhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
			
			_nhapkhonguyenlieuEntity.Id = txt_Id.Text.Trim();
			_nhapkhonguyenlieuEntity.Ngaynhap = txt_Ngaynhap.Text.Trim();
			_nhapkhonguyenlieuEntity.Makho = txt_Makho.Text.Trim();
			_nhapkhonguyenlieuEntity.Tenkho = txt_Tenkho.Text.Trim();
			_nhapkhonguyenlieuEntity.Manguyenlieu = txt_Manguyenlieu.Text.Trim();
			_nhapkhonguyenlieuEntity.Tennguyenlieu = txt_Tennguyenlieu.Text.Trim();
			_nhapkhonguyenlieuEntity.Donvitinh = txt_Donvitinh.Text.Trim();
			_nhapkhonguyenlieuEntity.Soluong = txt_Soluong.Text.Trim();
			_nhapkhonguyenlieuEntity.Malydo = txt_Malydo.Text.Trim();
			_nhapkhonguyenlieuEntity.Tenlydo = txt_Tenlydo.Text.Trim();
			_nhapkhonguyenlieuEntity.Sohopdongmua = txt_Sohopdongmua.Text.Trim();
			_nhapkhonguyenlieuEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_nhapkhonguyenlieuEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_nhapkhonguyenlieuEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_nhapkhonguyenlieuEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Nhapkhonguyenlieu_PK = _NhapkhonguyenlieuManager.InsertV2(_NhapkhonguyenlieuEntity, r_Insert, DT_Nhapkhonguyenlieu, BS_Nhapkhonguyenlieu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_nhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Nhapkhonguyenlieu.ResetCurrentItem();
			}
			else
			{
				_NhapkhonguyenlieuManager.Update(_nhapkhonguyenlieuEntity);
				
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Id.Name].Value = _nhapkhonguyenlieuEntity.Id;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaynhap.Name].Value = _nhapkhonguyenlieuEntity.Ngaynhap;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Makho.Name].Value = _nhapkhonguyenlieuEntity.Makho;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Tenkho.Name].Value = _nhapkhonguyenlieuEntity.Tenkho;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Manguyenlieu.Name].Value = _nhapkhonguyenlieuEntity.Manguyenlieu;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Tennguyenlieu.Name].Value = _nhapkhonguyenlieuEntity.Tennguyenlieu;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Donvitinh.Name].Value = _nhapkhonguyenlieuEntity.Donvitinh;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Soluong.Name].Value = _nhapkhonguyenlieuEntity.Soluong;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Malydo.Name].Value = _nhapkhonguyenlieuEntity.Malydo;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Tenlydo.Name].Value = _nhapkhonguyenlieuEntity.Tenlydo;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Sohopdongmua.Name].Value = _nhapkhonguyenlieuEntity.Sohopdongmua;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaytao.Name].Value = _nhapkhonguyenlieuEntity.Ngaytao;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Nguoitao.Name].Value = _nhapkhonguyenlieuEntity.Nguoitao;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaysua.Name].Value = _nhapkhonguyenlieuEntity.Ngaysua;
				GRID_Nhapkhonguyenlieu.CurrentRow.Cells[NhapkhonguyenlieuFields.Nguoisua.Name].Value = _nhapkhonguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_nhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Nhapkhonguyenlieu_PK;
		}

	}
}
