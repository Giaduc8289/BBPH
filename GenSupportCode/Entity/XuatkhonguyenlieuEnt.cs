
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

		void BS_Xuatkhonguyenlieu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Xuatkhonguyenlieu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Xuatkhonguyenlieu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[XuatkhonguyenlieuFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[XuatkhonguyenlieuFields.Id.Name].ToString();
					txt_Ngayxuat.Text = _Rowview.Row[XuatkhonguyenlieuFields.Ngayxuat.Name].ToString();
					txt_Makho.Text = _Rowview.Row[XuatkhonguyenlieuFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tenkho.Name].ToString();
					txt_Manguyenlieu.Text = _Rowview.Row[XuatkhonguyenlieuFields.Manguyenlieu.Name].ToString();
					txt_Tennguyenlieu.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tennguyenlieu.Name].ToString();
					txt_Donvitinh.Text = _Rowview.Row[XuatkhonguyenlieuFields.Donvitinh.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[XuatkhonguyenlieuFields.Soluong.Name].ToString();
					txt_Malydo.Text = _Rowview.Row[XuatkhonguyenlieuFields.Malydo.Name].ToString();
					txt_Tenlydo.Text = _Rowview.Row[XuatkhonguyenlieuFields.Tenlydo.Name].ToString();
					txt_Lenhxuat.Text = _Rowview.Row[XuatkhonguyenlieuFields.Lenhxuat.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[XuatkhonguyenlieuFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[XuatkhonguyenlieuFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[XuatkhonguyenlieuFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[XuatkhonguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Xuatkhonguyenlieu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Xuatkhonguyenlieu_PK)
		{
			XuatkhonguyenlieuEntity _xuatkhonguyenlieuEntity = new XuatkhonguyenlieuEntity();
			
			_xuatkhonguyenlieuEntity.Id = txt_Id.Text.Trim();
			_xuatkhonguyenlieuEntity.Ngayxuat = txt_Ngayxuat.Text.Trim();
			_xuatkhonguyenlieuEntity.Makho = txt_Makho.Text.Trim();
			_xuatkhonguyenlieuEntity.Tenkho = txt_Tenkho.Text.Trim();
			_xuatkhonguyenlieuEntity.Manguyenlieu = txt_Manguyenlieu.Text.Trim();
			_xuatkhonguyenlieuEntity.Tennguyenlieu = txt_Tennguyenlieu.Text.Trim();
			_xuatkhonguyenlieuEntity.Donvitinh = txt_Donvitinh.Text.Trim();
			_xuatkhonguyenlieuEntity.Soluong = txt_Soluong.Text.Trim();
			_xuatkhonguyenlieuEntity.Malydo = txt_Malydo.Text.Trim();
			_xuatkhonguyenlieuEntity.Tenlydo = txt_Tenlydo.Text.Trim();
			_xuatkhonguyenlieuEntity.Lenhxuat = txt_Lenhxuat.Text.Trim();
			_xuatkhonguyenlieuEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_xuatkhonguyenlieuEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_xuatkhonguyenlieuEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_xuatkhonguyenlieuEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Xuatkhonguyenlieu_PK = _XuatkhonguyenlieuManager.InsertV2(_XuatkhonguyenlieuEntity, r_Insert, DT_Xuatkhonguyenlieu, BS_Xuatkhonguyenlieu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhonguyenlieuManager.Convert(_xuatkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Xuatkhonguyenlieu.ResetCurrentItem();
			}
			else
			{
				_XuatkhonguyenlieuManager.Update(_xuatkhonguyenlieuEntity);
				
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Id.Name].Value = _xuatkhonguyenlieuEntity.Id;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Ngayxuat.Name].Value = _xuatkhonguyenlieuEntity.Ngayxuat;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Makho.Name].Value = _xuatkhonguyenlieuEntity.Makho;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Tenkho.Name].Value = _xuatkhonguyenlieuEntity.Tenkho;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Manguyenlieu.Name].Value = _xuatkhonguyenlieuEntity.Manguyenlieu;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Tennguyenlieu.Name].Value = _xuatkhonguyenlieuEntity.Tennguyenlieu;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Donvitinh.Name].Value = _xuatkhonguyenlieuEntity.Donvitinh;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Soluong.Name].Value = _xuatkhonguyenlieuEntity.Soluong;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Malydo.Name].Value = _xuatkhonguyenlieuEntity.Malydo;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Tenlydo.Name].Value = _xuatkhonguyenlieuEntity.Tenlydo;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Lenhxuat.Name].Value = _xuatkhonguyenlieuEntity.Lenhxuat;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Ngaytao.Name].Value = _xuatkhonguyenlieuEntity.Ngaytao;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Nguoitao.Name].Value = _xuatkhonguyenlieuEntity.Nguoitao;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Ngaysua.Name].Value = _xuatkhonguyenlieuEntity.Ngaysua;
				GRID_Xuatkhonguyenlieu.CurrentRow.Cells[XuatkhonguyenlieuFields.Nguoisua.Name].Value = _xuatkhonguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_XuatkhonguyenlieuManager.Convert(_xuatkhonguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Xuatkhonguyenlieu_PK;
		}

	}
}
