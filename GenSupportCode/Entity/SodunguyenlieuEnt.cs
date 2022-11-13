
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.SodunguyenlieuEnt
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
	public class SodunguyenlieuEnt : SodunguyenlieuEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SodunguyenlieuEnt()
		{
			// Nothing for now.
		}

		void BS_SODUNGUYENLIEU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_SODUNGUYENLIEU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_SODUNGUYENLIEU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[SodunguyenlieuFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[SodunguyenlieuFields.Id.Name].ToString();
					txt_NGAYKIEMKE.Text = _Rowview.Row[SodunguyenlieuFields.Ngaykiemke.Name].ToString();
					txt_MAKHO.Text = _Rowview.Row[SodunguyenlieuFields.Makho.Name].ToString();
					txt_TENKHO.Text = _Rowview.Row[SodunguyenlieuFields.Tenkho.Name].ToString();
					txt_MANGUYENLIEU.Text = _Rowview.Row[SodunguyenlieuFields.Manguyenlieu.Name].ToString();
					txt_TENNGUYENLIEU.Text = _Rowview.Row[SodunguyenlieuFields.Tennguyenlieu.Name].ToString();
					txt_DONVITINH.Text = _Rowview.Row[SodunguyenlieuFields.Donvitinh.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[SodunguyenlieuFields.Soluong.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[SodunguyenlieuFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[SodunguyenlieuFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[SodunguyenlieuFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[SodunguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_SODUNGUYENLIEU_CurrentChanged"); }
		}

		private string Save_Data(string _str_SODUNGUYENLIEU_PK)
		{
			SodunguyenlieuEntity _SodunguyenlieuEntity = new SodunguyenlieuEntity();
			try { _SodunguyenlieuEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _SodunguyenlieuEntity.Ngaykiemke = System.DateTime.Parse(txt_NGAYKIEMKE.Text.Trim()); } 
			catch { }
			_SodunguyenlieuEntity.Makho = txt_MAKHO.Text.Trim();
			_SodunguyenlieuEntity.Tenkho = txt_TENKHO.Text.Trim();
			_SodunguyenlieuEntity.Manguyenlieu = txt_MANGUYENLIEU.Text.Trim();
			_SodunguyenlieuEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			_SodunguyenlieuEntity.Donvitinh = txt_DONVITINH.Text.Trim();
			try { _SodunguyenlieuEntity.Soluong = System.Decimal.Parse(txt_SOLUONG.Text.Trim()); } 
			catch { }
			try { _SodunguyenlieuEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_SodunguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _SodunguyenlieuEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_SodunguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_SODUNGUYENLIEU_PK))
			{
				_str_SODUNGUYENLIEU_PK = _SodunguyenlieuManager.InsertV2(_SodunguyenlieuEntity, r_Insert, DT_SODUNGUYENLIEU, BS_SODUNGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_SodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_SODUNGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_SodunguyenlieuManager.Update(_SodunguyenlieuEntity);
				
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Id.Name].Value = _SodunguyenlieuEntity.Id;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Ngaykiemke.Name].Value = _SodunguyenlieuEntity.Ngaykiemke;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Makho.Name].Value = _SodunguyenlieuEntity.Makho;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Tenkho.Name].Value = _SodunguyenlieuEntity.Tenkho;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Manguyenlieu.Name].Value = _SodunguyenlieuEntity.Manguyenlieu;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Tennguyenlieu.Name].Value = _SodunguyenlieuEntity.Tennguyenlieu;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Donvitinh.Name].Value = _SodunguyenlieuEntity.Donvitinh;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Soluong.Name].Value = _SodunguyenlieuEntity.Soluong;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Ngaytao.Name].Value = _SodunguyenlieuEntity.Ngaytao;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Nguoitao.Name].Value = _SodunguyenlieuEntity.Nguoitao;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Ngaysua.Name].Value = _SodunguyenlieuEntity.Ngaysua;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Nguoisua.Name].Value = _SodunguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_SodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_SODUNGUYENLIEU_PK;
		}

	}
}
