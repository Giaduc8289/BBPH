
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

		void BS_BAOGIAD_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_BAOGIAD.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_BAOGIAD.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[BaogiaDFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[BaogiaDFields.Id.Name].ToString();
					txt_SOBAOGIA.Text = _Rowview.Row[BaogiaDFields.Sobaogia.Name].ToString();
					txt_MACHUNGLOAI.Text = _Rowview.Row[BaogiaDFields.Machungloai.Name].ToString();
					txt_TENCHUNGLOAI.Text = _Rowview.Row[BaogiaDFields.Tenchungloai.Name].ToString();
					txt_MASP.Text = _Rowview.Row[BaogiaDFields.Masp.Name].ToString();
					txt_TENHANG.Text = _Rowview.Row[BaogiaDFields.Tenhang.Name].ToString();
					txt_KICHTHUOC.Text = _Rowview.Row[BaogiaDFields.Kichthuoc.Name].ToString();
					txt_TRONGLUONG.Text = _Rowview.Row[BaogiaDFields.Trongluong.Name].ToString();
					txt_MOTA.Text = _Rowview.Row[BaogiaDFields.Mota.Name].ToString();
					txt_DONGIAKHONGVAT.Text = _Rowview.Row[BaogiaDFields.DongiakhongVat.Name].ToString();
					txt_DONGIAVAT.Text = _Rowview.Row[BaogiaDFields.DongiaVat.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[BaogiaDFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[BaogiaDFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[BaogiaDFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[BaogiaDFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_BAOGIAD_CurrentChanged"); }
		}

		private string Save_Data(string _str_BAOGIAD_PK)
		{
			BaogiaDEntity _baogiaDEntity = new BaogiaDEntity();
			
			_baogiaDEntity.Id = txt_ID.Text.Trim();
			_baogiaDEntity.Sobaogia = txt_SOBAOGIA.Text.Trim();
			_baogiaDEntity.Machungloai = txt_MACHUNGLOAI.Text.Trim();
			_baogiaDEntity.Tenchungloai = txt_TENCHUNGLOAI.Text.Trim();
			_baogiaDEntity.Masp = txt_MASP.Text.Trim();
			_baogiaDEntity.Tenhang = txt_TENHANG.Text.Trim();
			_baogiaDEntity.Kichthuoc = txt_KICHTHUOC.Text.Trim();
			_baogiaDEntity.Trongluong = txt_TRONGLUONG.Text.Trim();
			_baogiaDEntity.Mota = txt_MOTA.Text.Trim();
			_baogiaDEntity.DongiakhongVat = txt_DONGIAKHONGVAT.Text.Trim();
			_baogiaDEntity.DongiaVat = txt_DONGIAVAT.Text.Trim();
			_baogiaDEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_baogiaDEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_baogiaDEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_baogiaDEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_BAOGIAD_PK))
			{
				_str_BAOGIAD_PK = _BaogiaDManager.InsertV2(_baogiaDEntity, r_Insert, DT_BAOGIAD, BS_BAOGIAD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaDManager.Convert(_baogiaDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_BAOGIAD.ResetCurrentItem();
			}
			else
			{
				_BaogiaDManager.Update(_baogiaDEntity);
				
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Id.Name].Value = _baogiaDEntity.Id;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Sobaogia.Name].Value = _baogiaDEntity.Sobaogia;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Machungloai.Name].Value = _baogiaDEntity.Machungloai;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Tenchungloai.Name].Value = _baogiaDEntity.Tenchungloai;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Masp.Name].Value = _baogiaDEntity.Masp;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Tenhang.Name].Value = _baogiaDEntity.Tenhang;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Kichthuoc.Name].Value = _baogiaDEntity.Kichthuoc;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Trongluong.Name].Value = _baogiaDEntity.Trongluong;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Mota.Name].Value = _baogiaDEntity.Mota;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.DongiakhongVat.Name].Value = _baogiaDEntity.DongiakhongVat;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.DongiaVat.Name].Value = _baogiaDEntity.DongiaVat;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Ngaytao.Name].Value = _baogiaDEntity.Ngaytao;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Nguoitao.Name].Value = _baogiaDEntity.Nguoitao;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Ngaysua.Name].Value = _baogiaDEntity.Ngaysua;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Nguoisua.Name].Value = _baogiaDEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaDManager.Convert(_baogiaDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_BAOGIAD_PK;
		}

	}
}
