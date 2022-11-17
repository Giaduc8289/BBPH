
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
						MAHIEU_PK = _Rowview.Row[DinhmucthoigianFields.Madinhmuc.Name].ToString();
					
					txt_MADINHMUC.Text = _Rowview.Row[DinhmucthoigianFields.Madinhmuc.Name].ToString();
					txt_TENDINHMUC.Text = _Rowview.Row[DinhmucthoigianFields.Tendinhmuc.Name].ToString();
					txt_DODAYTU.Text = _Rowview.Row[DinhmucthoigianFields.Dodaytu.Name].ToString();
					txt_DODAYDEN.Text = _Rowview.Row[DinhmucthoigianFields.Dodayden.Name].ToString();
					txt_KHOTU.Text = _Rowview.Row[DinhmucthoigianFields.Khotu.Name].ToString();
					txt_KHODEN.Text = _Rowview.Row[DinhmucthoigianFields.Khoden.Name].ToString();
					txt_CHIEUDAITU.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaitu.Name].ToString();
					txt_CHIEUDAIDEN.Text = _Rowview.Row[DinhmucthoigianFields.Chieudaiden.Name].ToString();
					txt_MAMAYS.Text = _Rowview.Row[DinhmucthoigianFields.Mamays.Name].ToString();
					txt_MACONGDOANS.Text = _Rowview.Row[DinhmucthoigianFields.Macongdoans.Name].ToString();
					txt_SOMAUMAS.Text = _Rowview.Row[DinhmucthoigianFields.Somaumas.Name].ToString();
					txt_SOHINHMAS.Text = _Rowview.Row[DinhmucthoigianFields.Sohinhmas.Name].ToString();
					txt_MALOAIMANGS.Text = _Rowview.Row[DinhmucthoigianFields.Maloaimangs.Name].ToString();
					txt_MAQCTHANHPHAMS.Text = _Rowview.Row[DinhmucthoigianFields.Maqcthanhphams.Name].ToString();
					txt_MAKHACHS.Text = _Rowview.Row[DinhmucthoigianFields.Makhachs.Name].ToString();
					txt_MAHANGS.Text = _Rowview.Row[DinhmucthoigianFields.Mahangs.Name].ToString();
					txt_DAUCA.Text = _Rowview.Row[DinhmucthoigianFields.Dauca.Name].ToString();
					txt_CHUANBI.Text = _Rowview.Row[DinhmucthoigianFields.Chuanbi.Name].ToString();
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
			_DinhmucthoigianEntity.Madinhmuc = txt_MADINHMUC.Text.Trim();
			_DinhmucthoigianEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
			try { _DinhmucthoigianEntity.Dodaytu = System.Decimal.Parse(txt_DODAYTU.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Dodayden = System.Decimal.Parse(txt_DODAYDEN.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Khotu = System.Decimal.Parse(txt_KHOTU.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Khoden = System.Decimal.Parse(txt_KHODEN.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Chieudaitu = System.Decimal.Parse(txt_CHIEUDAITU.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Chieudaiden = System.Decimal.Parse(txt_CHIEUDAIDEN.Text.Trim()); } 
			catch { }
			_DinhmucthoigianEntity.Mamays = txt_MAMAYS.Text.Trim();
			_DinhmucthoigianEntity.Macongdoans = txt_MACONGDOANS.Text.Trim();
			_DinhmucthoigianEntity.Somaumas = txt_SOMAUMAS.Text.Trim();
			_DinhmucthoigianEntity.Sohinhmas = txt_SOHINHMAS.Text.Trim();
			_DinhmucthoigianEntity.Maloaimangs = txt_MALOAIMANGS.Text.Trim();
			_DinhmucthoigianEntity.Maqcthanhphams = txt_MAQCTHANHPHAMS.Text.Trim();
			_DinhmucthoigianEntity.Makhachs = txt_MAKHACHS.Text.Trim();
			_DinhmucthoigianEntity.Mahangs = txt_MAHANGS.Text.Trim();
			try { _DinhmucthoigianEntity.Dauca = System.Decimal.Parse(txt_DAUCA.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Chuanbi = System.Decimal.Parse(txt_CHUANBI.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Daucuon = System.Decimal.Parse(txt_DAUCUON.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Doilenh = System.Decimal.Parse(txt_DOILENH.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Lencuon = System.Decimal.Parse(txt_LENCUON.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Xuongcuon = System.Decimal.Parse(txt_XUONGCUON.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Thaythietbi = System.Decimal.Parse(txt_THAYTHIETBI.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Dungmay = System.Decimal.Parse(txt_DUNGMAY.Text.Trim()); } 
			catch { }
			try { _DinhmucthoigianEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_DinhmucthoigianEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _DinhmucthoigianEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
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
				
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Madinhmuc.Name].Value = _DinhmucthoigianEntity.Madinhmuc;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Tendinhmuc.Name].Value = _DinhmucthoigianEntity.Tendinhmuc;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodaytu.Name].Value = _DinhmucthoigianEntity.Dodaytu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dodayden.Name].Value = _DinhmucthoigianEntity.Dodayden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khotu.Name].Value = _DinhmucthoigianEntity.Khotu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Khoden.Name].Value = _DinhmucthoigianEntity.Khoden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaitu.Name].Value = _DinhmucthoigianEntity.Chieudaitu;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chieudaiden.Name].Value = _DinhmucthoigianEntity.Chieudaiden;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Mamays.Name].Value = _DinhmucthoigianEntity.Mamays;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Macongdoans.Name].Value = _DinhmucthoigianEntity.Macongdoans;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Somaumas.Name].Value = _DinhmucthoigianEntity.Somaumas;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Sohinhmas.Name].Value = _DinhmucthoigianEntity.Sohinhmas;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maloaimangs.Name].Value = _DinhmucthoigianEntity.Maloaimangs;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Maqcthanhphams.Name].Value = _DinhmucthoigianEntity.Maqcthanhphams;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Makhachs.Name].Value = _DinhmucthoigianEntity.Makhachs;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Mahangs.Name].Value = _DinhmucthoigianEntity.Mahangs;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Dauca.Name].Value = _DinhmucthoigianEntity.Dauca;
				GRID_DINHMUCTHOIGIAN.CurrentRow.Cells[DinhmucthoigianFields.Chuanbi.Name].Value = _DinhmucthoigianEntity.Chuanbi;
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
