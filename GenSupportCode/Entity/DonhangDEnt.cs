
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DonhangDEnt
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
	public class DonhangDEnt : DonhangDEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonhangDEnt()
		{
			// Nothing for now.
		}

		void BS_DonhangD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DonhangD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DonhangD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DonhangDFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[DonhangDFields.Id.Name].ToString();
					txt_Madon.Text = _Rowview.Row[DonhangDFields.Madon.Name].ToString();
					txt_Ngaydat.Text = _Rowview.Row[DonhangDFields.Ngaydat.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[DonhangDFields.Makhach.Name].ToString();
					txt_Sobaogia.Text = _Rowview.Row[DonhangDFields.Sobaogia.Name].ToString();
					txt_Loaihang.Text = _Rowview.Row[DonhangDFields.Loaihang.Name].ToString();
					txt_Masp.Text = _Rowview.Row[DonhangDFields.Masp.Name].ToString();
					txt_Tenhang.Text = _Rowview.Row[DonhangDFields.Tenhang.Name].ToString();
					txt_Soluong.Text = _Rowview.Row[DonhangDFields.Soluong.Name].ToString();
					txt_Dongia.Text = _Rowview.Row[DonhangDFields.Dongia.Name].ToString();
					txt_Ngaygiao.Text = _Rowview.Row[DonhangDFields.Ngaygiao.Name].ToString();
					txt_Ghichu.Text = _Rowview.Row[DonhangDFields.Ghichu.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DonhangDFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DonhangDFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DonhangDFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DonhangDFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DonhangD_CurrentChanged"); }
		}

		private string Save_Data(string _str_DonhangD_PK)
		{
			DonhangDEntity _donhangDEntity = new DonhangDEntity();
			
			_donhangD.Id = txt_Id.Text.Trim();
			_donhangD.Madon = txt_Madon.Text.Trim();
			_donhangD.Ngaydat = txt_Ngaydat.Text.Trim();
			_donhangD.Makhach = txt_Makhach.Text.Trim();
			_donhangD.Sobaogia = txt_Sobaogia.Text.Trim();
			_donhangD.Loaihang = txt_Loaihang.Text.Trim();
			_donhangD.Masp = txt_Masp.Text.Trim();
			_donhangD.Tenhang = txt_Tenhang.Text.Trim();
			_donhangD.Soluong = txt_Soluong.Text.Trim();
			_donhangD.Dongia = txt_Dongia.Text.Trim();
			_donhangD.Ngaygiao = txt_Ngaygiao.Text.Trim();
			_donhangD.Ghichu = txt_Ghichu.Text.Trim();
			_donhangD.Ngaytao = txt_Ngaytao.Text.Trim();
			_donhangD.Nguoitao = txt_Nguoitao.Text.Trim();
			_donhangD.Ngaysua = txt_Ngaysua.Text.Trim();
			_donhangD.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_DonhangD_PK = _DonhangDManager.InsertV2(_DonhangDEntity, r_Insert, DT_DonhangD, BS_DonhangD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangDManager.Convert(_donhangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DonhangD.ResetCurrentItem();
			}
			else
			{
				_DonhangDManager.Update(_donhangDEntity);
				
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Id.Name].Value = _donhangDEntity.Id;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Madon.Name].Value = _donhangDEntity.Madon;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Ngaydat.Name].Value = _donhangDEntity.Ngaydat;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Makhach.Name].Value = _donhangDEntity.Makhach;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Sobaogia.Name].Value = _donhangDEntity.Sobaogia;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Loaihang.Name].Value = _donhangDEntity.Loaihang;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Masp.Name].Value = _donhangDEntity.Masp;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Tenhang.Name].Value = _donhangDEntity.Tenhang;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Soluong.Name].Value = _donhangDEntity.Soluong;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Dongia.Name].Value = _donhangDEntity.Dongia;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Ngaygiao.Name].Value = _donhangDEntity.Ngaygiao;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Ghichu.Name].Value = _donhangDEntity.Ghichu;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Ngaytao.Name].Value = _donhangDEntity.Ngaytao;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Nguoitao.Name].Value = _donhangDEntity.Nguoitao;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Ngaysua.Name].Value = _donhangDEntity.Ngaysua;
				GRID_DonhangD.CurrentRow.Cells[DonhangDFields.Nguoisua.Name].Value = _donhangDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangDManager.Convert(_donhangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DonhangD_PK;
		}

	}
}
