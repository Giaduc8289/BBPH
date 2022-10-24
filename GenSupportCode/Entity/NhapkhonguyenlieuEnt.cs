
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

		void BS_NHAPKHONGUYENLIEU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_NHAPKHONGUYENLIEU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_NHAPKHONGUYENLIEU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[NhapkhonguyenlieuFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[NhapkhonguyenlieuFields.Id.Name].ToString();
					txt_NGAYNHAP.Text = _Rowview.Row[NhapkhonguyenlieuFields.Ngaynhap.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Tenkho.Name].ToString();
					txt_MANGUYENLIEU.Text = _Rowview.Row[NhapkhonguyenlieuFields.Manguyenlieu.Name].ToString();
					txt_TENNGUYENLIEU.Text = _Rowview.Row[NhapkhonguyenlieuFields.Tennguyenlieu.Name].ToString();
					txt_DONVITINH.Text = _Rowview.Row[NhapkhonguyenlieuFields.Donvitinh.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[NhapkhonguyenlieuFields.Soluong.Name].ToString();
					txt_MALYDO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Malydo.Name].ToString();
					txt_TENLYDO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Tenlydo.Name].ToString();
					txt_SOHOPDONGMUA.Text = _Rowview.Row[NhapkhonguyenlieuFields.Sohopdongmua.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[NhapkhonguyenlieuFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[NhapkhonguyenlieuFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[NhapkhonguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_NHAPKHONGUYENLIEU_CurrentChanged"); }
		}

		private string Save_Data(string _str_NHAPKHONGUYENLIEU_PK)
		{
			NhapkhonguyenlieuEntity _NhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
			
			_NhapkhonguyenlieuEntity.Id = txt_ID.Text.Trim();
			_NhapkhonguyenlieuEntity.Ngaynhap = txt_NGAYNHAP.Text.Trim();
			_NhapkhonguyenlieuEntity.Makho = txt_MAKHO.Text.Trim();
			_NhapkhonguyenlieuEntity.Tenkho = txt_TENKHO.Text.Trim();
			_NhapkhonguyenlieuEntity.Manguyenlieu = txt_MANGUYENLIEU.Text.Trim();
			_NhapkhonguyenlieuEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			_NhapkhonguyenlieuEntity.Donvitinh = txt_DONVITINH.Text.Trim();
			_NhapkhonguyenlieuEntity.Soluong = txt_SOLUONG.Text.Trim();
			_NhapkhonguyenlieuEntity.Malydo = txt_MALYDO.Text.Trim();
			_NhapkhonguyenlieuEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_NhapkhonguyenlieuEntity.Sohopdongmua = txt_SOHOPDONGMUA.Text.Trim();
			_NhapkhonguyenlieuEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_NhapkhonguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_NhapkhonguyenlieuEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_NhapkhonguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_NHAPKHONGUYENLIEU_PK))
			{
				_str_NHAPKHONGUYENLIEU_PK = _NhapkhonguyenlieuManager.InsertV2(_NhapkhonguyenlieuEntity, r_Insert, DT_NHAPKHONGUYENLIEU, BS_NHAPKHONGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_NhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_NHAPKHONGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_NhapkhonguyenlieuManager.Update(_NhapkhonguyenlieuEntity);
				
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Id.Name].Value = _NhapkhonguyenlieuEntity.Id;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaynhap.Name].Value = _NhapkhonguyenlieuEntity.Ngaynhap;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Makho.Name].Value = _NhapkhonguyenlieuEntity.Makho;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Tenkho.Name].Value = _NhapkhonguyenlieuEntity.Tenkho;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Manguyenlieu.Name].Value = _NhapkhonguyenlieuEntity.Manguyenlieu;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Tennguyenlieu.Name].Value = _NhapkhonguyenlieuEntity.Tennguyenlieu;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Donvitinh.Name].Value = _NhapkhonguyenlieuEntity.Donvitinh;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Soluong.Name].Value = _NhapkhonguyenlieuEntity.Soluong;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Malydo.Name].Value = _NhapkhonguyenlieuEntity.Malydo;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Tenlydo.Name].Value = _NhapkhonguyenlieuEntity.Tenlydo;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Sohopdongmua.Name].Value = _NhapkhonguyenlieuEntity.Sohopdongmua;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaytao.Name].Value = _NhapkhonguyenlieuEntity.Ngaytao;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Nguoitao.Name].Value = _NhapkhonguyenlieuEntity.Nguoitao;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaysua.Name].Value = _NhapkhonguyenlieuEntity.Ngaysua;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Nguoisua.Name].Value = _NhapkhonguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_NhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_NHAPKHONGUYENLIEU_PK;
		}

	}
}
