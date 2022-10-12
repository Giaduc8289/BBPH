
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DmtaikhoanEnt
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
	public class DmtaikhoanEnt : DmtaikhoanEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmtaikhoanEnt()
		{
			// Nothing for now.
		}

		void BS_Dmtaikhoan_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Dmtaikhoan.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Dmtaikhoan.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmtaikhoanFields.Matk.Name].ToString();
					
					txt_Matk.Text = _Rowview.Row[DmtaikhoanFields.Matk.Name].ToString();
					txt_Tentk.Text = _Rowview.Row[DmtaikhoanFields.Tentk.Name].ToString();
					txt_Bactk.Text = _Rowview.Row[DmtaikhoanFields.Bactk.Name].ToString();
					txt_Tinhchattk.Text = _Rowview.Row[DmtaikhoanFields.Tinhchattk.Name].ToString();
					txt_Matkcha.Text = _Rowview.Row[DmtaikhoanFields.Matkcha.Name].ToString();
					txt_Trongbang.Text = _Rowview.Row[DmtaikhoanFields.Trongbang.Name].ToString();
					txt_Doituongtd.Text = _Rowview.Row[DmtaikhoanFields.Doituongtd.Name].ToString();
					txt_Khoanmuctd.Text = _Rowview.Row[DmtaikhoanFields.Khoanmuctd.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[DmtaikhoanFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[DmtaikhoanFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[DmtaikhoanFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[DmtaikhoanFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Dmtaikhoan_CurrentChanged"); }
		}

		private string Save_Data(string _str_Dmtaikhoan_PK)
		{
			DmtaikhoanEntity _dmtaikhoanEntity = new DmtaikhoanEntity();
			
			_dmtaikhoanEntity.Matk = txt_Matk.Text.Trim();
			_dmtaikhoanEntity.Tentk = txt_Tentk.Text.Trim();
			_dmtaikhoanEntity.Bactk = txt_Bactk.Text.Trim();
			_dmtaikhoanEntity.Tinhchattk = txt_Tinhchattk.Text.Trim();
			_dmtaikhoanEntity.Matkcha = txt_Matkcha.Text.Trim();
			_dmtaikhoanEntity.Trongbang = txt_Trongbang.Text.Trim();
			_dmtaikhoanEntity.Doituongtd = txt_Doituongtd.Text.Trim();
			_dmtaikhoanEntity.Khoanmuctd = txt_Khoanmuctd.Text.Trim();
			_dmtaikhoanEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_dmtaikhoanEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_dmtaikhoanEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_dmtaikhoanEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Dmtaikhoan_PK = _DmtaikhoanManager.InsertV2(_DmtaikhoanEntity, r_Insert, DT_Dmtaikhoan, BS_Dmtaikhoan);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmtaikhoanManager.Convert(_dmtaikhoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Dmtaikhoan.ResetCurrentItem();
			}
			else
			{
				_DmtaikhoanManager.Update(_dmtaikhoanEntity);
				
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Matk.Name].Value = _dmtaikhoanEntity.Matk;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Tentk.Name].Value = _dmtaikhoanEntity.Tentk;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Bactk.Name].Value = _dmtaikhoanEntity.Bactk;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Tinhchattk.Name].Value = _dmtaikhoanEntity.Tinhchattk;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Matkcha.Name].Value = _dmtaikhoanEntity.Matkcha;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Trongbang.Name].Value = _dmtaikhoanEntity.Trongbang;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Doituongtd.Name].Value = _dmtaikhoanEntity.Doituongtd;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Khoanmuctd.Name].Value = _dmtaikhoanEntity.Khoanmuctd;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Ngaytao.Name].Value = _dmtaikhoanEntity.Ngaytao;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Nguoitao.Name].Value = _dmtaikhoanEntity.Nguoitao;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Ngaysua.Name].Value = _dmtaikhoanEntity.Ngaysua;
				GRID_Dmtaikhoan.CurrentRow.Cells[DmtaikhoanFields.Nguoisua.Name].Value = _dmtaikhoanEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmtaikhoanManager.Convert(_dmtaikhoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Dmtaikhoan_PK;
		}

	}
}
