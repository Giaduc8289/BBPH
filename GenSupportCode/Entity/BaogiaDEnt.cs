
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.BaogiaDEnt
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
	public class BaogiaDEnt : BaogiaDEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BaogiaDEnt()
		{
			// Nothing for now.
		}

		void BS_BaogiaD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_BaogiaD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_BaogiaD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[BaogiaDFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[BaogiaDFields.Id.Name].ToString();
					txt_Sobaogia.Text = _Rowview.Row[BaogiaDFields.Sobaogia.Name].ToString();
					txt_Machungloai.Text = _Rowview.Row[BaogiaDFields.Machungloai.Name].ToString();
					txt_Tenchungloai.Text = _Rowview.Row[BaogiaDFields.Tenchungloai.Name].ToString();
					txt_Masp.Text = _Rowview.Row[BaogiaDFields.Masp.Name].ToString();
					txt_Tenhang.Text = _Rowview.Row[BaogiaDFields.Tenhang.Name].ToString();
					txt_Kichthuoc.Text = _Rowview.Row[BaogiaDFields.Kichthuoc.Name].ToString();
					txt_Trongluong.Text = _Rowview.Row[BaogiaDFields.Trongluong.Name].ToString();
					txt_Mota.Text = _Rowview.Row[BaogiaDFields.Mota.Name].ToString();
					txt_DongiakhongVat.Text = _Rowview.Row[BaogiaDFields.DongiakhongVat.Name].ToString();
					txt_DongiaVat.Text = _Rowview.Row[BaogiaDFields.DongiaVat.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[BaogiaDFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[BaogiaDFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[BaogiaDFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[BaogiaDFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_BaogiaD_CurrentChanged"); }
		}

		private string Save_Data(string _str_BaogiaD_PK)
		{
			BaogiaDEntity _baogiaDEntity = new BaogiaDEntity();
			
			_baogiaDEntity.Id = txt_Id.Text.Trim();
			_baogiaDEntity.Sobaogia = txt_Sobaogia.Text.Trim();
			_baogiaDEntity.Machungloai = txt_Machungloai.Text.Trim();
			_baogiaDEntity.Tenchungloai = txt_Tenchungloai.Text.Trim();
			_baogiaDEntity.Masp = txt_Masp.Text.Trim();
			_baogiaDEntity.Tenhang = txt_Tenhang.Text.Trim();
			_baogiaDEntity.Kichthuoc = txt_Kichthuoc.Text.Trim();
			_baogiaDEntity.Trongluong = txt_Trongluong.Text.Trim();
			_baogiaDEntity.Mota = txt_Mota.Text.Trim();
			_baogiaDEntity.DongiakhongVat = txt_DongiakhongVat.Text.Trim();
			_baogiaDEntity.DongiaVat = txt_DongiaVat.Text.Trim();
			_baogiaDEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_baogiaDEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_baogiaDEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_baogiaDEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_BaogiaD_PK = _BaogiaDManager.InsertV2(_BaogiaDEntity, r_Insert, DT_BaogiaD, BS_BaogiaD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaDManager.Convert(_baogiaDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_BaogiaD.ResetCurrentItem();
			}
			else
			{
				_BaogiaDManager.Update(_baogiaDEntity);
				
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Id.Name].Value = _baogiaDEntity.Id;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Sobaogia.Name].Value = _baogiaDEntity.Sobaogia;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Machungloai.Name].Value = _baogiaDEntity.Machungloai;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Tenchungloai.Name].Value = _baogiaDEntity.Tenchungloai;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Masp.Name].Value = _baogiaDEntity.Masp;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Tenhang.Name].Value = _baogiaDEntity.Tenhang;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Kichthuoc.Name].Value = _baogiaDEntity.Kichthuoc;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Trongluong.Name].Value = _baogiaDEntity.Trongluong;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Mota.Name].Value = _baogiaDEntity.Mota;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.DongiakhongVat.Name].Value = _baogiaDEntity.DongiakhongVat;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.DongiaVat.Name].Value = _baogiaDEntity.DongiaVat;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Ngaytao.Name].Value = _baogiaDEntity.Ngaytao;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Nguoitao.Name].Value = _baogiaDEntity.Nguoitao;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Ngaysua.Name].Value = _baogiaDEntity.Ngaysua;
				GRID_BaogiaD.CurrentRow.Cells[BaogiaDFields.Nguoisua.Name].Value = _baogiaDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaDManager.Convert(_baogiaDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_BaogiaD_PK;
		}

	}
}
