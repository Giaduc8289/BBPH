
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.BaogiaHEnt
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
	public class BaogiaHEnt : BaogiaHEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BaogiaHEnt()
		{
			// Nothing for now.
		}

		void BS_BaogiaH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_BaogiaH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_BaogiaH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[BaogiaHFields.Sobaogia.Name].ToString();
					
					txt_Sobaogia.Text = _Rowview.Row[BaogiaHFields.Sobaogia.Name].ToString();
					txt_Ngaybaogia.Text = _Rowview.Row[BaogiaHFields.Ngaybaogia.Name].ToString();
					txt_Ngayhieuluc.Text = _Rowview.Row[BaogiaHFields.Ngayhieuluc.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[BaogiaHFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[BaogiaHFields.Tenkhach.Name].ToString();
					txt_Noidung.Text = _Rowview.Row[BaogiaHFields.Noidung.Name].ToString();
					txt_Phuongthuctt.Text = _Rowview.Row[BaogiaHFields.Phuongthuctt.Name].ToString();
					txt_Diadiemgiao.Text = _Rowview.Row[BaogiaHFields.Diadiemgiao.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[BaogiaHFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[BaogiaHFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[BaogiaHFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[BaogiaHFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_BaogiaH_CurrentChanged"); }
		}

		private string Save_Data(string _str_BaogiaH_PK)
		{
			BaogiaHEntity _baogiaHEntity = new BaogiaHEntity();
			
			_baogiaHEntity.Sobaogia = txt_Sobaogia.Text.Trim();
			_baogiaHEntity.Ngaybaogia = txt_Ngaybaogia.Text.Trim();
			_baogiaHEntity.Ngayhieuluc = txt_Ngayhieuluc.Text.Trim();
			_baogiaHEntity.Makhach = txt_Makhach.Text.Trim();
			_baogiaHEntity.Tenkhach = txt_Tenkhach.Text.Trim();
			_baogiaHEntity.Noidung = txt_Noidung.Text.Trim();
			_baogiaHEntity.Phuongthuctt = txt_Phuongthuctt.Text.Trim();
			_baogiaHEntity.Diadiemgiao = txt_Diadiemgiao.Text.Trim();
			_baogiaHEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_baogiaHEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_baogiaHEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_baogiaHEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_BaogiaH_PK = _BaogiaHManager.InsertV2(_BaogiaHEntity, r_Insert, DT_BaogiaH, BS_BaogiaH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_baogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_BaogiaH.ResetCurrentItem();
			}
			else
			{
				_BaogiaHManager.Update(_baogiaHEntity);
				
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Sobaogia.Name].Value = _baogiaHEntity.Sobaogia;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Ngaybaogia.Name].Value = _baogiaHEntity.Ngaybaogia;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Ngayhieuluc.Name].Value = _baogiaHEntity.Ngayhieuluc;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Makhach.Name].Value = _baogiaHEntity.Makhach;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Tenkhach.Name].Value = _baogiaHEntity.Tenkhach;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Noidung.Name].Value = _baogiaHEntity.Noidung;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Phuongthuctt.Name].Value = _baogiaHEntity.Phuongthuctt;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Diadiemgiao.Name].Value = _baogiaHEntity.Diadiemgiao;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Ngaytao.Name].Value = _baogiaHEntity.Ngaytao;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Nguoitao.Name].Value = _baogiaHEntity.Nguoitao;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Ngaysua.Name].Value = _baogiaHEntity.Ngaysua;
				GRID_BaogiaH.CurrentRow.Cells[BaogiaHFields.Nguoisua.Name].Value = _baogiaHEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_baogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_BaogiaH_PK;
		}

	}
}
