
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

		void BS_DONHANGD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DONHANGD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DONHANGD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DonhangDFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[DonhangDFields.Id.Name].ToString();
					txt_MADON.Text = _Rowview.Row[DonhangDFields.Madon.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[DonhangDFields.Ngaydat.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[DonhangDFields.Makhach.Name].ToString();
					txt_SOBAOGIA.Text = _Rowview.Row[DonhangDFields.Sobaogia.Name].ToString();
					txt_LOAIHANG.Text = _Rowview.Row[DonhangDFields.Loaihang.Name].ToString();
					txt_MASP.Text = _Rowview.Row[DonhangDFields.Masp.Name].ToString();
					txt_TENHANG.Text = _Rowview.Row[DonhangDFields.Tenhang.Name].ToString();
					txt_SOLUONG.Text = _Rowview.Row[DonhangDFields.Soluong.Name].ToString();
					txt_DONGIA.Text = _Rowview.Row[DonhangDFields.Dongia.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[DonhangDFields.Ngaygiao.Name].ToString();
					txt_GHICHU.Text = _Rowview.Row[DonhangDFields.Ghichu.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DonhangDFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DonhangDFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DonhangDFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DonhangDFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DONHANGD_CurrentChanged"); }
		}

		private string Save_Data(string _str_DONHANGD_PK)
		{
			DonhangDEntity _DonhangDEntity = new DonhangDEntity();
			
			_DonhangDEntity.Id = txt_ID.Text.Trim();
			_DonhangDEntity.Madon = txt_MADON.Text.Trim();
			_DonhangDEntity.Ngaydat = txt_NGAYDAT.Text.Trim();
			_DonhangDEntity.Makhach = txt_MAKHACH.Text.Trim();
			_DonhangDEntity.Sobaogia = txt_SOBAOGIA.Text.Trim();
			_DonhangDEntity.Loaihang = txt_LOAIHANG.Text.Trim();
			_DonhangDEntity.Masp = txt_MASP.Text.Trim();
			_DonhangDEntity.Tenhang = txt_TENHANG.Text.Trim();
			_DonhangDEntity.Soluong = txt_SOLUONG.Text.Trim();
			_DonhangDEntity.Dongia = txt_DONGIA.Text.Trim();
			_DonhangDEntity.Ngaygiao = txt_NGAYGIAO.Text.Trim();
			_DonhangDEntity.Ghichu = txt_GHICHU.Text.Trim();
			_DonhangDEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_DonhangDEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_DonhangDEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_DonhangDEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DONHANGD_PK))
			{
				_str_DONHANGD_PK = _DonhangDManager.InsertV2(_DonhangDEntity, r_Insert, DT_DONHANGD, BS_DONHANGD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangDManager.Convert(_DonhangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DONHANGD.ResetCurrentItem();
			}
			else
			{
				_DonhangDManager.Update(_DonhangDEntity);
				
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Id.Name].Value = _DonhangDEntity.Id;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Madon.Name].Value = _DonhangDEntity.Madon;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Ngaydat.Name].Value = _DonhangDEntity.Ngaydat;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Makhach.Name].Value = _DonhangDEntity.Makhach;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Sobaogia.Name].Value = _DonhangDEntity.Sobaogia;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Loaihang.Name].Value = _DonhangDEntity.Loaihang;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Masp.Name].Value = _DonhangDEntity.Masp;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Tenhang.Name].Value = _DonhangDEntity.Tenhang;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Soluong.Name].Value = _DonhangDEntity.Soluong;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Dongia.Name].Value = _DonhangDEntity.Dongia;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Ngaygiao.Name].Value = _DonhangDEntity.Ngaygiao;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Ghichu.Name].Value = _DonhangDEntity.Ghichu;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Ngaytao.Name].Value = _DonhangDEntity.Ngaytao;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Nguoitao.Name].Value = _DonhangDEntity.Nguoitao;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Ngaysua.Name].Value = _DonhangDEntity.Ngaysua;
				GRID_DONHANGD.CurrentRow.Cells[DonhangDFields.Nguoisua.Name].Value = _DonhangDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangDManager.Convert(_DonhangDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DONHANGD_PK;
		}

	}
}
