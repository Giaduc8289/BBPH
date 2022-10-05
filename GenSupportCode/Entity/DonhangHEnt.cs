
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DonhangHEnt
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
	public class DonhangHEnt : DonhangHEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DonhangHEnt()
		{
			// Nothing for now.
		}

		void BS_DonhangH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DonhangH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DonhangH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DonhangHFields.Madon.Name].ToString();
					
					txt_Madon.Text = _Rowview.Row[DonhangHFields.Madon.Name].ToString();
					txt_Ngaydat.Text = _Rowview.Row[DonhangHFields.Ngaydat.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[DonhangHFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[DonhangHFields.Tenkhach.Name].ToString();
					txt_Sobaogia.Text = _Rowview.Row[DonhangHFields.Sobaogia.Name].ToString();
					txt_Ngaybaogia.Text = _Rowview.Row[DonhangHFields.Ngaybaogia.Name].ToString();
					txt_Userid.Text = _Rowview.Row[DonhangHFields.Userid.Name].ToString();
					txt_Tennv.Text = _Rowview.Row[DonhangHFields.Tennv.Name].ToString();
					txt_Ghichu.Text = _Rowview.Row[DonhangHFields.Ghichu.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DonhangHFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DonhangHFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DonhangHFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DonhangHFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DonhangH_CurrentChanged"); }
		}

		private string Save_Data(string _str_DonhangH_PK)
		{
			DonhangHEntity _donhangHEntity = new DonhangHEntity();
			
			_donhangH.Madon = txt_Madon.Text.Trim();
			_donhangH.Ngaydat = txt_Ngaydat.Text.Trim();
			_donhangH.Makhach = txt_Makhach.Text.Trim();
			_donhangH.Tenkhach = txt_Tenkhach.Text.Trim();
			_donhangH.Sobaogia = txt_Sobaogia.Text.Trim();
			_donhangH.Ngaybaogia = txt_Ngaybaogia.Text.Trim();
			_donhangH.Userid = txt_Userid.Text.Trim();
			_donhangH.Tennv = txt_Tennv.Text.Trim();
			_donhangH.Ghichu = txt_Ghichu.Text.Trim();
			_donhangH.Ngaytao = txt_Ngaytao.Text.Trim();
			_donhangH.Nguoitao = txt_Nguoitao.Text.Trim();
			_donhangH.Ngaysua = txt_Ngaysua.Text.Trim();
			_donhangH.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_DonhangH_PK = _DonhangHManager.InsertV2(_DonhangHEntity, r_Insert, DT_DonhangH, BS_DonhangH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_donhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DonhangH.ResetCurrentItem();
			}
			else
			{
				_DonhangHManager.Update(_donhangHEntity);
				
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Madon.Name].Value = _donhangHEntity.Madon;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Ngaydat.Name].Value = _donhangHEntity.Ngaydat;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Makhach.Name].Value = _donhangHEntity.Makhach;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Tenkhach.Name].Value = _donhangHEntity.Tenkhach;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Sobaogia.Name].Value = _donhangHEntity.Sobaogia;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Ngaybaogia.Name].Value = _donhangHEntity.Ngaybaogia;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Userid.Name].Value = _donhangHEntity.Userid;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Tennv.Name].Value = _donhangHEntity.Tennv;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Ghichu.Name].Value = _donhangHEntity.Ghichu;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Ngaytao.Name].Value = _donhangHEntity.Ngaytao;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Nguoitao.Name].Value = _donhangHEntity.Nguoitao;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Ngaysua.Name].Value = _donhangHEntity.Ngaysua;
				GRID_DonhangH.CurrentRow.Cells[DonhangHFields.Nguoisua.Name].Value = _donhangHEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DonhangHManager.Convert(_donhangHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DonhangH_PK;
		}

	}
}
