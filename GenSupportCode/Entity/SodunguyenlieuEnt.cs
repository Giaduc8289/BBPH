
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
			SodunguyenlieuEntity _sodunguyenlieuEntity = new SodunguyenlieuEntity();
			
			_sodunguyenlieuEntity.Id = txt_ID.Text.Trim();
			_sodunguyenlieuEntity.Ngaykiemke = txt_NGAYKIEMKE.Text.Trim();
			_sodunguyenlieuEntity.Makho = txt_MAKHO.Text.Trim();
			_sodunguyenlieuEntity.Tenkho = txt_TENKHO.Text.Trim();
			_sodunguyenlieuEntity.Manguyenlieu = txt_MANGUYENLIEU.Text.Trim();
			_sodunguyenlieuEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			_sodunguyenlieuEntity.Donvitinh = txt_DONVITINH.Text.Trim();
			_sodunguyenlieuEntity.Soluong = txt_SOLUONG.Text.Trim();
			_sodunguyenlieuEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_sodunguyenlieuEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_sodunguyenlieuEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_sodunguyenlieuEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_SODUNGUYENLIEU_PK))
			{
				_str_SODUNGUYENLIEU_PK = _SodunguyenlieuManager.InsertV2(_sodunguyenlieuEntity, r_Insert, DT_SODUNGUYENLIEU, BS_SODUNGUYENLIEU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_sodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_SODUNGUYENLIEU.ResetCurrentItem();
			}
			else
			{
				_SodunguyenlieuManager.Update(_sodunguyenlieuEntity);
				
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Id.Name].Value = _sodunguyenlieuEntity.Id;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Ngaykiemke.Name].Value = _sodunguyenlieuEntity.Ngaykiemke;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Makho.Name].Value = _sodunguyenlieuEntity.Makho;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Tenkho.Name].Value = _sodunguyenlieuEntity.Tenkho;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Manguyenlieu.Name].Value = _sodunguyenlieuEntity.Manguyenlieu;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Tennguyenlieu.Name].Value = _sodunguyenlieuEntity.Tennguyenlieu;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Donvitinh.Name].Value = _sodunguyenlieuEntity.Donvitinh;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Soluong.Name].Value = _sodunguyenlieuEntity.Soluong;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Ngaytao.Name].Value = _sodunguyenlieuEntity.Ngaytao;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Nguoitao.Name].Value = _sodunguyenlieuEntity.Nguoitao;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Ngaysua.Name].Value = _sodunguyenlieuEntity.Ngaysua;
				GRID_SODUNGUYENLIEU.CurrentRow.Cells[SodunguyenlieuFields.Nguoisua.Name].Value = _sodunguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_sodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_SODUNGUYENLIEU_PK;
		}

	}
}
