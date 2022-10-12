
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

		void BS_Sodunguyenlieu_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Sodunguyenlieu.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Sodunguyenlieu.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[SodunguyenlieuFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[SodunguyenlieuFields.Id.Name].ToString();
					txt_Ngaykiemke.Text = _Rowview.Row[SodunguyenlieuFields.Ngaykiemke.Name].ToString();
					txt_Makho.Text = _Rowview.Row[SodunguyenlieuFields.Makho.Name].ToString();
					txt_Tenkho.Text = _Rowview.Row[SodunguyenlieuFields.Tenkho.Name].ToString();
					txt_Manguyenlieu.Text = _Rowview.Row[SodunguyenlieuFields.Manguyenlieu.Name].ToString();
					txt_Tennguyenlieu.Text = _Rowview.Row[SodunguyenlieuFields.Tennguyenlieu.Name].ToString();
					txt_Donvitinh.Text = _Rowview.Row[SodunguyenlieuFields.Donvitinh.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[SodunguyenlieuFields.Soluong.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[SodunguyenlieuFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[SodunguyenlieuFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[SodunguyenlieuFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[SodunguyenlieuFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Sodunguyenlieu_CurrentChanged"); }
		}

		private string Save_Data(string _str_Sodunguyenlieu_PK)
		{
			SodunguyenlieuEntity _sodunguyenlieuEntity = new SodunguyenlieuEntity();
			
			_sodunguyenlieuEntity.Id = txt_Id.Text.Trim();
			_sodunguyenlieuEntity.Ngaykiemke = txt_Ngaykiemke.Text.Trim();
			_sodunguyenlieuEntity.Makho = txt_Makho.Text.Trim();
			_sodunguyenlieuEntity.Tenkho = txt_Tenkho.Text.Trim();
			_sodunguyenlieuEntity.Manguyenlieu = txt_Manguyenlieu.Text.Trim();
			_sodunguyenlieuEntity.Tennguyenlieu = txt_Tennguyenlieu.Text.Trim();
			_sodunguyenlieuEntity.Donvitinh = txt_Donvitinh.Text.Trim();
			_sodunguyenlieuEntity.Soluong = txt_Soluong.Text.Trim();
			_sodunguyenlieuEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_sodunguyenlieuEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_sodunguyenlieuEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_sodunguyenlieuEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Sodunguyenlieu_PK = _SodunguyenlieuManager.InsertV2(_SodunguyenlieuEntity, r_Insert, DT_Sodunguyenlieu, BS_Sodunguyenlieu);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_sodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Sodunguyenlieu.ResetCurrentItem();
			}
			else
			{
				_SodunguyenlieuManager.Update(_sodunguyenlieuEntity);
				
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Id.Name].Value = _sodunguyenlieuEntity.Id;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Ngaykiemke.Name].Value = _sodunguyenlieuEntity.Ngaykiemke;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Makho.Name].Value = _sodunguyenlieuEntity.Makho;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Tenkho.Name].Value = _sodunguyenlieuEntity.Tenkho;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Manguyenlieu.Name].Value = _sodunguyenlieuEntity.Manguyenlieu;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Tennguyenlieu.Name].Value = _sodunguyenlieuEntity.Tennguyenlieu;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Donvitinh.Name].Value = _sodunguyenlieuEntity.Donvitinh;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Soluong.Name].Value = _sodunguyenlieuEntity.Soluong;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Ngaytao.Name].Value = _sodunguyenlieuEntity.Ngaytao;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Nguoitao.Name].Value = _sodunguyenlieuEntity.Nguoitao;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Ngaysua.Name].Value = _sodunguyenlieuEntity.Ngaysua;
				GRID_Sodunguyenlieu.CurrentRow.Cells[SodunguyenlieuFields.Nguoisua.Name].Value = _sodunguyenlieuEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_SodunguyenlieuManager.Convert(_sodunguyenlieuEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Sodunguyenlieu_PK;
		}

	}
}
