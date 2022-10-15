﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.XuatkhonguyenlieuEnt
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
	public class XuatkhonguyenlieuEnt : XuatkhonguyenlieuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public XuatkhonguyenlieuEnt()
		{
			// Nothing for now.
		}

		void BS_XUATKHONGUYENLIEU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_XUATKHONGUYENLIEU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_XUATKHONGUYENLIEU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[XuatkhonguyenlieuFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[XuatkhonguyenlieuFields.Id.Name].ToString();
					txt_NGAYXUAT.Text = _Rowview.Row[XuatkhonguyenlieuFields.Ngayxuat.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tenkho.Name].ToString();
					txt_MANGUYENLIEU.Text = _Rowview.Row[XuatkhonguyenlieuFields.Manguyenlieu.Name].ToString();
					txt_TENNGUYENLIEU.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tennguyenlieu.Name].ToString();
					txt_DONVITINH.Text = _Rowview.Row[XuatkhonguyenlieuFields.Donvitinh.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[XuatkhonguyenlieuFields.Soluong.Name].ToString();
					txt_MALYDO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Malydo.Name].ToString();
					txt_TENLYDO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tenlydo.Name].ToString();
					txt_LENHXUAT.Text = _Rowview.Row[XuatkhonguyenlieuFields.Lenhxuat.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[XuatkhonguyenlieuFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[XuatkhonguyenlieuFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[XuatkhonguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_XUATKHONGUYENLIEU_CurrentChanged"); }
		}

		private string Save_Data(string _str_XUATKHONGUYENLIEU_PK)
		{
			XuatkhonguyenlieuEntity _xuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
			
			_xuatkhonguyenlieuEntity.Id = txt_ID.Text.Trim();
			_xuatkhonguyenlieuEntity.Ngayxuat = txt_NGAYXUAT.Text.Trim();
			_xuatkhonguyenlieuEntity.Makho = txt_MAKHO.Text.Trim();
			_xuatkhonguyenlieuEntity.Tenkho = txt_TENKHO.Text.Trim();
			_xuatkhonguyenlieuEntity.Manguyenlieu = txt_MANGUYENLIEU.Text.Trim();
			_xuatkhonguyenlieuEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			_xuatkhonguyenlieuEntity.Donvitinh = txt_DONVITINH.Text.Trim();
			_xuatkhonguyenlieuEntity.Soluong = txt_SOLUONG.Text.Trim();
			_xuatkhonguyenlieuEntity.Malydo = txt_MALYDO.Text.Trim();
			_xuatkhonguyenlieuEntity.Tenlydo = txt_TENLYDO.Text.Trim();
			_xuatkhonguyenlieuEntity.Lenhxuat = txt_LENHXUAT.Text.Trim();
			_xuatkhonguyenlieuEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_xuatkhonguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_xuatkhonguyenlieuEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_xuatkhonguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_XUATKHONGUYENLIEU_PK))
			{
				_str_XUATKHONGUYENLIEU_PK = _XuatkhonguyenlieuManager.InsertV2(_xuatkhonguyenlieuEntity, r_Insert, DT_XUATKHONGUYENLIEU, BS_XUATKHONGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhonguyenlieuManager.Convert(_xuatkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_XUATKHONGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_XuatkhonguyenlieuManager.Update(_xuatkhonguyenlieuEntity);
				
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Id.Name].Value = _xuatkhonguyenlieuEntity.Id;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Ngayxuat.Name].Value = _xuatkhonguyenlieuEntity.Ngayxuat;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Makho.Name].Value = _xuatkhonguyenlieuEntity.Makho;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Tenkho.Name].Value = _xuatkhonguyenlieuEntity.Tenkho;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Manguyenlieu.Name].Value = _xuatkhonguyenlieuEntity.Manguyenlieu;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Tennguyenlieu.Name].Value = _xuatkhonguyenlieuEntity.Tennguyenlieu;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Donvitinh.Name].Value = _xuatkhonguyenlieuEntity.Donvitinh;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Soluong.Name].Value = _xuatkhonguyenlieuEntity.Soluong;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Malydo.Name].Value = _xuatkhonguyenlieuEntity.Malydo;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Tenlydo.Name].Value = _xuatkhonguyenlieuEntity.Tenlydo;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Lenhxuat.Name].Value = _xuatkhonguyenlieuEntity.Lenhxuat;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Ngaytao.Name].Value = _xuatkhonguyenlieuEntity.Ngaytao;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Nguoitao.Name].Value = _xuatkhonguyenlieuEntity.Nguoitao;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Ngaysua.Name].Value = _xuatkhonguyenlieuEntity.Ngaysua;
				GRID_XUATKHONGUYENLIEU.CurrentRow.Cells[XuatkhonguyenlieuFields.Nguoisua.Name].Value = _xuatkhonguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhonguyenlieuManager.Convert(_xuatkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_XUATKHONGUYENLIEU_PK;
		}

	}
}
