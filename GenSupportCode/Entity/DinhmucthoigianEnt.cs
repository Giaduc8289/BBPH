﻿
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DinhmucthoigianEnt
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
	public class DinhmucthoigianEnt : DinhmucthoigianEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmucthoigianEnt()
		{
			// Nothing for now.
		}

		void BS_DINHMUCTHOIGIAN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DINHMUCTHOIGIAN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DINHMUCTHOIGIAN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DinhmucthoigianFields.Madmtg.Name].ToString();
					
					txt_MADMTG.Text = _Rowview.Row[DinhmucthoigianFields.Madmtg.Name].ToString();
					txt_TENDINHMUC.Text = _Rowview.Row[DinhmucthoigianFields.Tendinhmuc.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[DinhmucthoigianFields.Mamay.Name].ToString();
					txt_MADM.Text = _Rowview.Row[DinhmucthoigianFields.Madm.Name].ToString();
					txt_MACONGDOAN.Text = _Rowview.Row[DinhmucthoigianFields.Macongdoan.Name].ToString();
					txt_DODAYTU.Text = _Rowview.Row[DinhmucthoigianFields.Dodaytu.Name].ToString();
					txt_DODAYDEN.Text = _Rowview.Row[DinhmucthoigianFields.Dodayden.Name].ToString();
					txt_KHOTU.Text = _Rowview.Row[DinhmucthoigianFields.Khotu.Name].ToString();
					txt_KHODEN.Text = _Rowview.Row[DinhmucthoigianFields.Khoden.Name].ToString();
					txt_CHIEUDAITU.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaitu.Name].ToString();
					txt_CHIEUDAIDEN.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaiden.Name].ToString();
					txt_SOMAUMA.Text = _Rowview.Row[DinhmucthoigianFields.Somauma.Name].ToString();
					txt_SOHINHMA.Text = _Rowview.Row[DinhmucthoigianFields.Sohinhma.Name].ToString();
					txt_MALOAIMANG.Text = _Rowview.Row[DinhmucthoigianFields.Maloaimang.Name].ToString();
					txt_MAQCTHANHPHAM.Text = _Rowview.Row[DinhmucthoigianFields.Maqcthanhpham.Name].ToString();
					txt_DAUCA.Text = _Rowview.Row[DinhmucthoigianFields.Dauca.Name].ToString();
					txt_DAUCUON.Text = _Rowview.Row[DinhmucthoigianFields.Daucuon.Name].ToString();
					txt_DOILENH.Text = _Rowview.Row[DinhmucthoigianFields.Doilenh.Name].ToString();
					txt_LENCUON.Text = _Rowview.Row[DinhmucthoigianFields.Lencuon.Name].ToString();
					txt_XUONGCUON.Text = _Rowview.Row[DinhmucthoigianFields.Xuongcuon.Name].ToString();
					txt_THAYTHIETBI.Text = _Rowview.Row[DinhmucthoigianFields.Thaythietbi.Name].ToString();
					txt_DUNGMAY.Text = _Rowview.Row[DinhmucthoigianFields.Dungmay.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DinhmucthoigianFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DinhmucthoigianFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DinhmucthoigianFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DinhmucthoigianFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DINHMUCTHOIGIAN_CurrentChanged"); }
		}

		private string Save_Data(string _str_DINHMUCTHOIGIAN_PK)
		{
			DinhmucthoigianEntity _dinhmucthoigianEntity = new DinhmucthoigianEntity();
			
			_dinhmucthoigianEntity.Madmtg = txt_MADMTG.Text.Trim();
			_dinhmucthoigianEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
			_dinhmucthoigianEntity.Mamay = txt_MAMAY.Text.Trim();
			_dinhmucthoigianEntity.Madm = txt_MADM.Text.Trim();
			_dinhmucthoigianEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
			_dinhmucthoigianEntity.Dodaytu = txt_DODAYTU.Text.Trim();
			_dinhmucthoigianEntity.Dodayden = txt_DODAYDEN.Text.Trim();
			_dinhmucthoigianEntity.Khotu = txt_KHOTU.Text.Trim();
			_dinhmucthoigianEntity.Khoden = txt_KHODEN.Text.Trim();
			_dinhmucthoigianEntity.Chieudaitu = txt_CHIEUDAITU.Text.Trim();
			_dinhmucthoigianEntity.Chieudaiden = txt_CHIEUDAIDEN.Text.Trim();
			_dinhmucthoigianEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_dinhmucthoigianEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
			_dinhmucthoigianEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_dinhmucthoigianEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			_dinhmucthoigianEntity.Dauca = txt_DAUCA.Text.Trim();
			_dinhmucthoigianEntity.Daucuon = txt_DAUCUON.Text.Trim();
			_dinhmucthoigianEntity.Doilenh = txt_DOILENH.Text.Trim();
			_dinhmucthoigianEntity.Lencuon = txt_LENCUON.Text.Trim();
			_dinhmucthoigianEntity.Xuongcuon = txt_XUONGCUON.Text.Trim();
			_dinhmucthoigianEntity.Thaythietbi = txt_THAYTHIETBI.Text.Trim();
			_dinhmucthoigianEntity.Dungmay = txt_DUNGMAY.Text.Trim();
			_dinhmucthoigianEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_dinhmucthoigianEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_dinhmucthoigianEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_dinhmucthoigianEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DINHMUCTHOIGIAN_PK))
			{
				_str_DINHMUCTHOIGIAN_PK = _DinhmucthoigianManager.InsertV2(_dinhmucthoigianEntity, r_Insert, DT_DINHMUCTHOIGIAN, BS_DINHMUCTHOIGIAN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_dinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DINHMUCTHOIGIAN.ResetCurrentItem();
			}
			else
			{
				_DinhmucthoigianManager.Update(_dinhmucthoigianEntity);
				
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madmtg.Name].Value = _dinhmucthoigianEntity.Madmtg;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Tendinhmuc.Name].Value = _dinhmucthoigianEntity.Tendinhmuc;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Mamay.Name].Value = _dinhmucthoigianEntity.Mamay;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madm.Name].Value = _dinhmucthoigianEntity.Madm;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Macongdoan.Name].Value = _dinhmucthoigianEntity.Macongdoan;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodaytu.Name].Value = _dinhmucthoigianEntity.Dodaytu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodayden.Name].Value = _dinhmucthoigianEntity.Dodayden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khotu.Name].Value = _dinhmucthoigianEntity.Khotu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khoden.Name].Value = _dinhmucthoigianEntity.Khoden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaitu.Name].Value = _dinhmucthoigianEntity.Chieudaitu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaiden.Name].Value = _dinhmucthoigianEntity.Chieudaiden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Somauma.Name].Value = _dinhmucthoigianEntity.Somauma;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Sohinhma.Name].Value = _dinhmucthoigianEntity.Sohinhma;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maloaimang.Name].Value = _dinhmucthoigianEntity.Maloaimang;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maqcthanhpham.Name].Value = _dinhmucthoigianEntity.Maqcthanhpham;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dauca.Name].Value = _dinhmucthoigianEntity.Dauca;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Daucuon.Name].Value = _dinhmucthoigianEntity.Daucuon;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Doilenh.Name].Value = _dinhmucthoigianEntity.Doilenh;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Lencuon.Name].Value = _dinhmucthoigianEntity.Lencuon;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Xuongcuon.Name].Value = _dinhmucthoigianEntity.Xuongcuon;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Thaythietbi.Name].Value = _dinhmucthoigianEntity.Thaythietbi;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dungmay.Name].Value = _dinhmucthoigianEntity.Dungmay;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Ngaytao.Name].Value = _dinhmucthoigianEntity.Ngaytao;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Nguoitao.Name].Value = _dinhmucthoigianEntity.Nguoitao;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Ngaysua.Name].Value = _dinhmucthoigianEntity.Ngaysua;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Nguoisua.Name].Value = _dinhmucthoigianEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_dinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DINHMUCTHOIGIAN_PK;
		}

	}
}
