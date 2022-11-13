﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.TknguyenlieuthoiEnt
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
	public class TknguyenlieuthoiEnt : TknguyenlieuthoiEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TknguyenlieuthoiEnt()
		{
			// Nothing for now.
		}

		void BS_TKNGUYENLIEUTHOI_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_TKNGUYENLIEUTHOI.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_TKNGUYENLIEUTHOI.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[TknguyenlieuthoiFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[TknguyenlieuthoiFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[TknguyenlieuthoiFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[TknguyenlieuthoiFields.Ca.Name].ToString();
					txt_MANGUYENLIEU.Text = _Rowview.Row[TknguyenlieuthoiFields.Manguyenlieu.Name].ToString();
					txt_TENNGUYENLIEU.Text = _Rowview.Row[TknguyenlieuthoiFields.Tennguyenlieu.Name].ToString();
					txt_KLNHAP.Text = _Rowview.Row[TknguyenlieuthoiFields.Klnhap.Name].ToString();
					txt_KLXUAT.Text = _Rowview.Row[TknguyenlieuthoiFields.Klxuat.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[TknguyenlieuthoiFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[TknguyenlieuthoiFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[TknguyenlieuthoiFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[TknguyenlieuthoiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_TKNGUYENLIEUTHOI_CurrentChanged"); }
		}

		private string Save_Data(string _str_TKNGUYENLIEUTHOI_PK)
		{
			TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
			try { _TknguyenlieuthoiEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _TknguyenlieuthoiEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _TknguyenlieuthoiEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			_TknguyenlieuthoiEntity.Manguyenlieu = txt_MANGUYENLIEU.Text.Trim();
			_TknguyenlieuthoiEntity.Tennguyenlieu = txt_TENNGUYENLIEU.Text.Trim();
			try { _TknguyenlieuthoiEntity.Klnhap = System.Decimal.Parse(txt_KLNHAP.Text.Trim()); } 
			catch { }
			try { _TknguyenlieuthoiEntity.Klxuat = System.Decimal.Parse(txt_KLXUAT.Text.Trim()); } 
			catch { }
			try { _TknguyenlieuthoiEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_TknguyenlieuthoiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _TknguyenlieuthoiEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_TknguyenlieuthoiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_TKNGUYENLIEUTHOI_PK))
			{
				_str_TKNGUYENLIEUTHOI_PK = _TknguyenlieuthoiManager.InsertV2(_TknguyenlieuthoiEntity, r_Insert, DT_TKNGUYENLIEUTHOI, BS_TKNGUYENLIEUTHOI);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TknguyenlieuthoiManager.Convert(_TknguyenlieuthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_TKNGUYENLIEUTHOI.ResetCurrentItem();
			}
			else
			{
				_TknguyenlieuthoiManager.Update(_TknguyenlieuthoiEntity);
				
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Id.Name].Value = _TknguyenlieuthoiEntity.Id;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Ngay.Name].Value = _TknguyenlieuthoiEntity.Ngay;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Ca.Name].Value = _TknguyenlieuthoiEntity.Ca;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Manguyenlieu.Name].Value = _TknguyenlieuthoiEntity.Manguyenlieu;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Tennguyenlieu.Name].Value = _TknguyenlieuthoiEntity.Tennguyenlieu;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Klnhap.Name].Value = _TknguyenlieuthoiEntity.Klnhap;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Klxuat.Name].Value = _TknguyenlieuthoiEntity.Klxuat;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Ngaytao.Name].Value = _TknguyenlieuthoiEntity.Ngaytao;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Nguoitao.Name].Value = _TknguyenlieuthoiEntity.Nguoitao;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Ngaysua.Name].Value = _TknguyenlieuthoiEntity.Ngaysua;
				GRID_TKNGUYENLIEUTHOI.CurrentRow.Cells[TknguyenlieuthoiFields.Nguoisua.Name].Value = _TknguyenlieuthoiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_TknguyenlieuthoiManager.Convert(_TknguyenlieuthoiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_TKNGUYENLIEUTHOI_PK;
		}

	}
}
