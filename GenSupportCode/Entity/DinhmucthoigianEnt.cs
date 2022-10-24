
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
					txt_MADONGMAY.Text = _Rowview.Row[DinhmucthoigianFields.Madongmay.Name].ToString();
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
			DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
			
			_DinhmucthoigianEntity.Madmtg = txt_MADMTG.Text.Trim();
			_DinhmucthoigianEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
			_DinhmucthoigianEntity.Mamay = txt_MAMAY.Text.Trim();
			_DinhmucthoigianEntity.Madongmay = txt_MADONGMAY.Text.Trim();
			_DinhmucthoigianEntity.Macongdoan = txt_MACONGDOAN.Text.Trim();
			_DinhmucthoigianEntity.Dodaytu = txt_DODAYTU.Text.Trim();
			_DinhmucthoigianEntity.Dodayden = txt_DODAYDEN.Text.Trim();
			_DinhmucthoigianEntity.Khotu = txt_KHOTU.Text.Trim();
			_DinhmucthoigianEntity.Khoden = txt_KHODEN.Text.Trim();
			_DinhmucthoigianEntity.Chieudaitu = txt_CHIEUDAITU.Text.Trim();
			_DinhmucthoigianEntity.Chieudaiden = txt_CHIEUDAIDEN.Text.Trim();
			_DinhmucthoigianEntity.Somauma = txt_SOMAUMA.Text.Trim();
			_DinhmucthoigianEntity.Sohinhma = txt_SOHINHMA.Text.Trim();
			_DinhmucthoigianEntity.Maloaimang = txt_MALOAIMANG.Text.Trim();
			_DinhmucthoigianEntity.Maqcthanhpham = txt_MAQCTHANHPHAM.Text.Trim();
			_DinhmucthoigianEntity.Dauca = txt_DAUCA.Text.Trim();
			_DinhmucthoigianEntity.Daucuon = txt_DAUCUON.Text.Trim();
			_DinhmucthoigianEntity.Doilenh = txt_DOILENH.Text.Trim();
			_DinhmucthoigianEntity.Lencuon = txt_LENCUON.Text.Trim();
			_DinhmucthoigianEntity.Xuongcuon = txt_XUONGCUON.Text.Trim();
			_DinhmucthoigianEntity.Thaythietbi = txt_THAYTHIETBI.Text.Trim();
			_DinhmucthoigianEntity.Dungmay = txt_DUNGMAY.Text.Trim();
			_DinhmucthoigianEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_DinhmucthoigianEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_DinhmucthoigianEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_DinhmucthoigianEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DINHMUCTHOIGIAN_PK))
			{
				_str_DINHMUCTHOIGIAN_PK = _DinhmucthoigianManager.InsertV2(_DinhmucthoigianEntity, r_Insert, DT_DINHMUCTHOIGIAN, BS_DINHMUCTHOIGIAN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DINHMUCTHOIGIAN.ResetCurrentItem();
			}
			else
			{
				_DinhmucthoigianManager.Update(_DinhmucthoigianEntity);
				
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madmtg.Name].Value = _DinhmucthoigianEntity.Madmtg;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Tendinhmuc.Name].Value = _DinhmucthoigianEntity.Tendinhmuc;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Mamay.Name].Value = _DinhmucthoigianEntity.Mamay;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madongmay.Name].Value = _DinhmucthoigianEntity.Madongmay;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Macongdoan.Name].Value = _DinhmucthoigianEntity.Macongdoan;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodaytu.Name].Value = _DinhmucthoigianEntity.Dodaytu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodayden.Name].Value = _DinhmucthoigianEntity.Dodayden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khotu.Name].Value = _DinhmucthoigianEntity.Khotu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khoden.Name].Value = _DinhmucthoigianEntity.Khoden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaitu.Name].Value = _DinhmucthoigianEntity.Chieudaitu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaiden.Name].Value = _DinhmucthoigianEntity.Chieudaiden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Somauma.Name].Value = _DinhmucthoigianEntity.Somauma;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Sohinhma.Name].Value = _DinhmucthoigianEntity.Sohinhma;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maloaimang.Name].Value = _DinhmucthoigianEntity.Maloaimang;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maqcthanhpham.Name].Value = _DinhmucthoigianEntity.Maqcthanhpham;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dauca.Name].Value = _DinhmucthoigianEntity.Dauca;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Daucuon.Name].Value = _DinhmucthoigianEntity.Daucuon;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Doilenh.Name].Value = _DinhmucthoigianEntity.Doilenh;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Lencuon.Name].Value = _DinhmucthoigianEntity.Lencuon;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Xuongcuon.Name].Value = _DinhmucthoigianEntity.Xuongcuon;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Thaythietbi.Name].Value = _DinhmucthoigianEntity.Thaythietbi;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dungmay.Name].Value = _DinhmucthoigianEntity.Dungmay;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Ngaytao.Name].Value = _DinhmucthoigianEntity.Ngaytao;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Nguoitao.Name].Value = _DinhmucthoigianEntity.Nguoitao;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Ngaysua.Name].Value = _DinhmucthoigianEntity.Ngaysua;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Nguoisua.Name].Value = _DinhmucthoigianEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmucthoigianManager.Convert(_DinhmucthoigianEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DINHMUCTHOIGIAN_PK;
		}

	}
}
