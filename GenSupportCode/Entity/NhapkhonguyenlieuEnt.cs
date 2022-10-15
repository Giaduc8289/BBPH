
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
			NhapkhonguyenlieuEntity _nhapkhonguyenlieuEntity = new NhapkhonguyenlieuEntity();
			
			_nhapkhonguyenlieuEntity.Id = txt_ID.Text.Trim();
			_nhapkhonguyenlieuEntity.Ngaynhap = txt_NGAYNHAP.Text.Trim();
			_nhapkhonguyenlieuEntity.Makho = txt_MAKHO.Text.Trim();
			_nhapkhonguyenlieuEntity.Tenkho = txt_TENKHO.Text.Trim();
			_nhapkhonguyenlieuEntity.Manguyenlieu = txt_MANGUYENLIEU.Text.Trim();
			_nhapkhonguyenlieuEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			_nhapkhonguyenlieuEntity.Donvitinh = txt_DONVITINH.Text.Trim();
			_nhapkhonguyenlieuEntity.Soluong = txt_SOLUONG.Text.Trim();
			_nhapkhonguyenlieuEntity.Malydo = txt_MALYDO.Text.Trim();
			_nhapkhonguyenlieuEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_nhapkhonguyenlieuEntity.Sohopdongmua = txt_SOHOPDONGMUA.Text.Trim();
			_nhapkhonguyenlieuEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_nhapkhonguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_nhapkhonguyenlieuEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_nhapkhonguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_NHAPKHONGUYENLIEU_PK))
			{
				_str_NHAPKHONGUYENLIEU_PK = _NhapkhonguyenlieuManager.InsertV2(_nhapkhonguyenlieuEntity, r_Insert, DT_NHAPKHONGUYENLIEU, BS_NHAPKHONGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_nhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_NHAPKHONGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_NhapkhonguyenlieuManager.Update(_nhapkhonguyenlieuEntity);
				
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Id.Name].Value = _nhapkhonguyenlieuEntity.Id;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaynhap.Name].Value = _nhapkhonguyenlieuEntity.Ngaynhap;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Makho.Name].Value = _nhapkhonguyenlieuEntity.Makho;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Tenkho.Name].Value = _nhapkhonguyenlieuEntity.Tenkho;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Manguyenlieu.Name].Value = _nhapkhonguyenlieuEntity.Manguyenlieu;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Tennguyenlieu.Name].Value = _nhapkhonguyenlieuEntity.Tennguyenlieu;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Donvitinh.Name].Value = _nhapkhonguyenlieuEntity.Donvitinh;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Soluong.Name].Value = _nhapkhonguyenlieuEntity.Soluong;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Malydo.Name].Value = _nhapkhonguyenlieuEntity.Malydo;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Tenlydo.Name].Value = _nhapkhonguyenlieuEntity.Tenlydo;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Sohopdongmua.Name].Value = _nhapkhonguyenlieuEntity.Sohopdongmua;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaytao.Name].Value = _nhapkhonguyenlieuEntity.Ngaytao;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Nguoitao.Name].Value = _nhapkhonguyenlieuEntity.Nguoitao;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Ngaysua.Name].Value = _nhapkhonguyenlieuEntity.Ngaysua;
				GRID_NHAPKHONGUYENLIEU.CurrentRow.Cells[NhapkhonguyenlieuFields.Nguoisua.Name].Value = _nhapkhonguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_NhapkhonguyenlieuManager.Convert(_nhapkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_NHAPKHONGUYENLIEU_PK;
		}

	}
}
