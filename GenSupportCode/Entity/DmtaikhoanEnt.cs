
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

		void BS_DMTAIKHOAN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DMTAIKHOAN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DMTAIKHOAN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DmtaikhoanFields.Matk.Name].ToString();
					
					txt_MATK.Text = _Rowview.Row[DmtaikhoanFields.Matk.Name].ToString();
					txt_TENTK.Text = _Rowview.Row[DmtaikhoanFields.Tentk.Name].ToString();
					txt_BACTK.Text = _Rowview.Row[DmtaikhoanFields.Bactk.Name].ToString();
					txt_TINHCHATTK.Text = _Rowview.Row[DmtaikhoanFields.Tinhchattk.Name].ToString();
					txt_MATKCHA.Text = _Rowview.Row[DmtaikhoanFields.Matkcha.Name].ToString();
					txt_TRONGBANG.Text = _Rowview.Row[DmtaikhoanFields.Trongbang.Name].ToString();
					txt_DOITUONGTD.Text = _Rowview.Row[DmtaikhoanFields.Doituongtd.Name].ToString();
					txt_KHOANMUCTD.Text = _Rowview.Row[DmtaikhoanFields.Khoanmuctd.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DmtaikhoanFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DmtaikhoanFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DmtaikhoanFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DmtaikhoanFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DMTAIKHOAN_CurrentChanged"); }
		}

		private string Save_Data(string _str_DMTAIKHOAN_PK)
		{
			DmtaikhoanEntity _dmtaikhoanEntity = new DmtaikhoanEntity();
			
			_dmtaikhoanEntity.Matk = txt_MATK.Text.Trim();
			_dmtaikhoanEntity.Tentk = txt_TENTK.Text.Trim();
			_dmtaikhoanEntity.Bactk = txt_BACTK.Text.Trim();
			_dmtaikhoanEntity.Tinhchattk = txt_TINHCHATTK.Text.Trim();
			_dmtaikhoanEntity.Matkcha = txt_MATKCHA.Text.Trim();
			_dmtaikhoanEntity.Trongbang = txt_TRONGBANG.Text.Trim();
			_dmtaikhoanEntity.Doituongtd = txt_DOITUONGTD.Text.Trim();
			_dmtaikhoanEntity.Khoanmuctd = txt_KHOANMUCTD.Text.Trim();
			_dmtaikhoanEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dmtaikhoanEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dmtaikhoanEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dmtaikhoanEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMTAIKHOAN_PK))
			{
				_str_DMTAIKHOAN_PK = _DmtaikhoanManager.InsertV2(_dmtaikhoanEntity, r_Insert, DT_DMTAIKHOAN, BS_DMTAIKHOAN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmtaikhoanManager.Convert(_dmtaikhoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DMTAIKHOAN.ResetCurrentItem();
			}
			else
			{
				_DmtaikhoanManager.Update(_dmtaikhoanEntity);
				
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Matk.Name].Value = _dmtaikhoanEntity.Matk;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Tentk.Name].Value = _dmtaikhoanEntity.Tentk;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Bactk.Name].Value = _dmtaikhoanEntity.Bactk;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Tinhchattk.Name].Value = _dmtaikhoanEntity.Tinhchattk;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Matkcha.Name].Value = _dmtaikhoanEntity.Matkcha;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Trongbang.Name].Value = _dmtaikhoanEntity.Trongbang;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Doituongtd.Name].Value = _dmtaikhoanEntity.Doituongtd;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Khoanmuctd.Name].Value = _dmtaikhoanEntity.Khoanmuctd;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Ngaytao.Name].Value = _dmtaikhoanEntity.Ngaytao;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Nguoitao.Name].Value = _dmtaikhoanEntity.Nguoitao;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Ngaysua.Name].Value = _dmtaikhoanEntity.Ngaysua;
				GRID_DMTAIKHOAN.CurrentRow.Cells[DmtaikhoanFields.Nguoisua.Name].Value = _dmtaikhoanEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DmtaikhoanManager.Convert(_dmtaikhoanEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DMTAIKHOAN_PK;
		}

	}
}
