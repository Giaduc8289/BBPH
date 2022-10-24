
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

		void BS_BAOGIAH_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_BAOGIAH.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_BAOGIAH.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[BaogiaHFields.Sobaogia.Name].ToString();
					
					txt_SOBAOGIA.Text = _Rowview.Row[BaogiaHFields.Sobaogia.Name].ToString();
					txt_NGAYBAOGIA.Text = _Rowview.Row[BaogiaHFields.Ngaybaogia.Name].ToString();
					txt_NGAYHIEULUC.Text = _Rowview.Row[BaogiaHFields.Ngayhieuluc.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[BaogiaHFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[BaogiaHFields.Tenkhach.Name].ToString();
					txt_NOIDUNG.Text = _Rowview.Row[BaogiaHFields.Noidung.Name].ToString();
					txt_PHUONGTHUCTT.Text = _Rowview.Row[BaogiaHFields.Phuongthuctt.Name].ToString();
					txt_DIADIEMGIAO.Text = _Rowview.Row[BaogiaHFields.Diadiemgiao.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[BaogiaHFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[BaogiaHFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[BaogiaHFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[BaogiaHFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_BAOGIAH_CurrentChanged"); }
		}

		private string Save_Data(string _str_BAOGIAH_PK)
		{
			BaogiaHEntity _BaogiaHEntity = new BaogiaHEntity();
			
			_BaogiaHEntity.Sobaogia = txt_SOBAOGIA.Text.Trim();
			_BaogiaHEntity.Ngaybaogia = txt_NGAYBAOGIA.Text.Trim();
			_BaogiaHEntity.Ngayhieuluc = txt_NGAYHIEULUC.Text.Trim();
			_BaogiaHEntity.Makhach = txt_MAKHACH.Text.Trim();
			_BaogiaHEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_BaogiaHEntity.Noidung = txt_NOIDUNG.Text.Trim();
			_BaogiaHEntity.Phuongthuctt = txt_PHUONGTHUCTT.Text.Trim();
			_BaogiaHEntity.Diadiemgiao = txt_DIADIEMGIAO.Text.Trim();
			_BaogiaHEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_BaogiaHEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_BaogiaHEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_BaogiaHEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_BAOGIAH_PK))
			{
				_str_BAOGIAH_PK = _BaogiaHManager.InsertV2(_BaogiaHEntity, r_Insert, DT_BAOGIAH, BS_BAOGIAH);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_BaogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_BAOGIAH.ResetCurrentItem();
			}
			else
			{
				_BaogiaHManager.Update(_BaogiaHEntity);
				
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Sobaogia.Name].Value = _BaogiaHEntity.Sobaogia;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Ngaybaogia.Name].Value = _BaogiaHEntity.Ngaybaogia;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Ngayhieuluc.Name].Value = _BaogiaHEntity.Ngayhieuluc;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Makhach.Name].Value = _BaogiaHEntity.Makhach;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Tenkhach.Name].Value = _BaogiaHEntity.Tenkhach;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Noidung.Name].Value = _BaogiaHEntity.Noidung;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Phuongthuctt.Name].Value = _BaogiaHEntity.Phuongthuctt;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Diadiemgiao.Name].Value = _BaogiaHEntity.Diadiemgiao;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Ngaytao.Name].Value = _BaogiaHEntity.Ngaytao;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Nguoitao.Name].Value = _BaogiaHEntity.Nguoitao;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Ngaysua.Name].Value = _BaogiaHEntity.Ngaysua;
				GRID_BAOGIAH.CurrentRow.Cells[BaogiaHFields.Nguoisua.Name].Value = _BaogiaHEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaHManager.Convert(_BaogiaHEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_BAOGIAH_PK;
		}

	}
}
