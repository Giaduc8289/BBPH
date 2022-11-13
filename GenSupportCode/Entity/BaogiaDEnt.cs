
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
					txt_MASP.Text = _Rowview.Row[BaogiaDFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[BaogiaDFields.Tensp.Name].ToString();
					txt_MASPCUAKHACH.Text = _Rowview.Row[BaogiaDFields.Maspcuakhach.Name].ToString();
					txt_DODAY.Text = _Rowview.Row[BaogiaDFields.Doday.Name].ToString();
					txt_RONG.Text = _Rowview.Row[BaogiaDFields.Rong.Name].ToString();
					txt_DAI.Text = _Rowview.Row[BaogiaDFields.Dai.Name].ToString();
					txt_TRONGLUONG.Text = _Rowview.Row[BaogiaDFields.Trongluong.Name].ToString();
					txt_LOAIMUC.Text = _Rowview.Row[BaogiaDFields.Loaimuc.Name].ToString();
					txt_TENQCDONGGOI.Text = _Rowview.Row[BaogiaDFields.Tenqcdonggoi.Name].ToString();
					txt_TENQCLOAITHUNG.Text = _Rowview.Row[BaogiaDFields.Tenqcloaithung.Name].ToString();
					txt_TENQCTHANHPHAM.Text = _Rowview.Row[BaogiaDFields.Tenqcthanhpham.Name].ToString();
					txt_MOTA.Text = _Rowview.Row[BaogiaDFields.Mota.Name].ToString();
					txt_DONGIAKHONGVAT.Text = _Rowview.Row[BaogiaDFields.DongiakhongVat.Name].ToString();
					txt_DONGIAVAT.Text = _Rowview.Row[BaogiaDFields.DongiaVat.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[BaogiaDFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[BaogiaDFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[BaogiaDFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[BaogiaDFields.Nguoisua.Name].ToString();
					txt_CAUTRUC.Text = _Rowview.Row[BaogiaDFields.Cautruc.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_BAOGIAD_CurrentChanged"); }
		}

		private string Save_Data(string _str_BAOGIAD_PK)
		{
			BaogiaDEntity _BaogiaDEntity = new BaogiaDEntity();
			try { _BaogiaDEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			_BaogiaDEntity.Sobaogia = txt_SOBAOGIA.Text.Trim();
			_BaogiaDEntity.Masp = txt_MASP.Text.Trim();
			_BaogiaDEntity.Tensp = txt_TENSP.Text.Trim();
			_BaogiaDEntity.Maspcuakhach = txt_MASPCUAKHACH.Text.Trim();
			try { _BaogiaDEntity.Doday = System.Decimal.Parse(txt_DODAY.Text.Trim()); } 
			catch { }
			try { _BaogiaDEntity.Rong = System.Decimal.Parse(txt_RONG.Text.Trim()); } 
			catch { }
			try { _BaogiaDEntity.Dai = System.Decimal.Parse(txt_DAI.Text.Trim()); } 
			catch { }
			try { _BaogiaDEntity.Trongluong = System.Decimal.Parse(txt_TRONGLUONG.Text.Trim()); } 
			catch { }
			_BaogiaDEntity.Loaimuc = txt_LOAIMUC.Text.Trim();
			_BaogiaDEntity.Tenqcdonggoi = txt_TENQCDONGGOI.Text.Trim();
			_BaogiaDEntity.Tenqcloaithung = txt_TENQCLOAITHUNG.Text.Trim();
			_BaogiaDEntity.Tenqcthanhpham = txt_TENQCTHANHPHAM.Text.Trim();
			_BaogiaDEntity.Mota = txt_MOTA.Text.Trim();
			try { _BaogiaDEntity.DongiakhongVat = System.Int32.Parse(txt_DONGIAKHONGVAT.Text.Trim()); } 
			catch { }
			try { _BaogiaDEntity.DongiaVat = System.Int32.Parse(txt_DONGIAVAT.Text.Trim()); } 
			catch { }
			try { _BaogiaDEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_BaogiaDEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _BaogiaDEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_BaogiaDEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_BaogiaDEntity.Cautruc = txt_CAUTRUC.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_BAOGIAD_PK))
			{
				_str_BAOGIAD_PK = _BaogiaDManager.InsertV2(_BaogiaDEntity, r_Insert, DT_BAOGIAD, BS_BAOGIAD);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaDManager.Convert(_BaogiaDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_BAOGIAD.ResetCurrentItem();
			}
			else
			{
				_BaogiaDManager.Update(_BaogiaDEntity);
				
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Id.Name].Value = _BaogiaDEntity.Id;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Sobaogia.Name].Value = _BaogiaDEntity.Sobaogia;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Masp.Name].Value = _BaogiaDEntity.Masp;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Tensp.Name].Value = _BaogiaDEntity.Tensp;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Maspcuakhach.Name].Value = _BaogiaDEntity.Maspcuakhach;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Doday.Name].Value = _BaogiaDEntity.Doday;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Rong.Name].Value = _BaogiaDEntity.Rong;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Dai.Name].Value = _BaogiaDEntity.Dai;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Trongluong.Name].Value = _BaogiaDEntity.Trongluong;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Loaimuc.Name].Value = _BaogiaDEntity.Loaimuc;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Tenqcdonggoi.Name].Value = _BaogiaDEntity.Tenqcdonggoi;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Tenqcloaithung.Name].Value = _BaogiaDEntity.Tenqcloaithung;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Tenqcthanhpham.Name].Value = _BaogiaDEntity.Tenqcthanhpham;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Mota.Name].Value = _BaogiaDEntity.Mota;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.DongiakhongVat.Name].Value = _BaogiaDEntity.DongiakhongVat;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.DongiaVat.Name].Value = _BaogiaDEntity.DongiaVat;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Ngaytao.Name].Value = _BaogiaDEntity.Ngaytao;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Nguoitao.Name].Value = _BaogiaDEntity.Nguoitao;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Ngaysua.Name].Value = _BaogiaDEntity.Ngaysua;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Nguoisua.Name].Value = _BaogiaDEntity.Nguoisua;
				GRID_BAOGIAD.CurrentRow.Cells[BaogiaDFields.Cautruc.Name].Value = _BaogiaDEntity.Cautruc;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_BaogiaDManager.Convert(_BaogiaDEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_BAOGIAD_PK;
		}

	}
}
