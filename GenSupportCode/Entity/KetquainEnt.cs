
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquainEnt
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
	public class KetquainEnt : KetquainEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquainEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUAIN_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUAIN.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUAIN.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquainFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquainFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[KetquainFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KetquainFields.Ca.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KetquainFields.Mamay.Name].ToString();
					txt_LENHIN.Text = _Rowview.Row[KetquainFields.Lenhin.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KetquainFields.Masanpham.Name].ToString();
					txt_MACONGNHAN.Text = _Rowview.Row[KetquainFields.Macongnhan.Name].ToString();
					txt_SOMETLSX.Text = _Rowview.Row[KetquainFields.SometLsx.Name].ToString();
					txt_SOMETCAP.Text = _Rowview.Row[KetquainFields.Sometcap.Name].ToString();
					txt_SOKGCAP.Text = _Rowview.Row[KetquainFields.Sokgcap.Name].ToString();
					txt_THUCTEIN.Text = _Rowview.Row[KetquainFields.Thuctein.Name].ToString();
					txt_SOKGIN.Text = _Rowview.Row[KetquainFields.Sokgin.Name].ToString();
					txt_SAIHONGTHUCTE.Text = _Rowview.Row[KetquainFields.Saihongthucte.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquainFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquainFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquainFields.Thoigianchuanbi.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquainFields.Thoigiansuco.Name].ToString();
					txt_PHENCC.Text = _Rowview.Row[KetquainFields.PheNcc.Name].ToString();
					txt_PHESX.Text = _Rowview.Row[KetquainFields.PheSx.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquainFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquainFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquainFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquainFields.Nguoisua.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquainFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquainFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquainFields.Tencongnhan.Name].ToString();
					txt_NANGSUAT.Text = _Rowview.Row[KetquainFields.Nangsuat.Name].ToString();
					txt_TYLESAIHONG.Text = _Rowview.Row[KetquainFields.Tylesaihong.Name].ToString();
					txt_TONGMDM.Text = _Rowview.Row[KetquainFields.Tongmdm.Name].ToString();
					txt_MATRUONGCA.Text = _Rowview.Row[KetquainFields.Matruongca.Name].ToString();
					txt_TENTRUONGCA.Text = _Rowview.Row[KetquainFields.Tentruongca.Name].ToString();
					txt_TOCDODINHMUC.Text = _Rowview.Row[KetquainFields.Tocdodinhmuc.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUAIN_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUAIN_PK)
		{
			KetquainEntity _KetquainEntity = new KetquainEntity();
			try { _KetquainEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			_KetquainEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquainEntity.Lenhin = txt_LENHIN.Text.Trim();
			_KetquainEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquainEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			try { _KetquainEntity.SometLsx = System.Decimal.Parse(txt_SOMETLSX.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Sometcap = System.Decimal.Parse(txt_SOMETCAP.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Sokgcap = System.Decimal.Parse(txt_SOKGCAP.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Thuctein = System.Decimal.Parse(txt_THUCTEIN.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Sokgin = System.Decimal.Parse(txt_SOKGIN.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Saihongthucte = System.Decimal.Parse(txt_SAIHONGTHUCTE.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Thoigianbatdau = System.DateTime.Parse(txt_THOIGIANBATDAU.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Thoigianketthuc = System.DateTime.Parse(txt_THOIGIANKETTHUC.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Thoigianchuanbi = System.Decimal.Parse(txt_THOIGIANCHUANBI.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Thoigiansuco = System.Decimal.Parse(txt_THOIGIANSUCO.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.PheNcc = System.Decimal.Parse(txt_PHENCC.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.PheSx = System.Decimal.Parse(txt_PHESX.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KetquainEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KetquainEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KetquainEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquainEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquainEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquainEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			try { _KetquainEntity.Nangsuat = System.Decimal.Parse(txt_NANGSUAT.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Tylesaihong = System.Decimal.Parse(txt_TYLESAIHONG.Text.Trim()); } 
			catch { }
			try { _KetquainEntity.Tongmdm = System.Decimal.Parse(txt_TONGMDM.Text.Trim()); } 
			catch { }
			_KetquainEntity.Matruongca = txt_MATRUONGCA.Text.Trim();
			_KetquainEntity.Tentruongca = txt_TENTRUONGCA.Text.Trim();
			try { _KetquainEntity.Tocdodinhmuc = System.Decimal.Parse(txt_TOCDODINHMUC.Text.Trim()); } 
			catch { }
			
			
			if (string.IsNullOrEmpty(_str_KETQUAIN_PK))
			{
				_str_KETQUAIN_PK = _KetquainManager.InsertV2(_KetquainEntity, r_Insert, DT_KETQUAIN, BS_KETQUAIN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUAIN.ResetCurrentItem();
			}
			else
			{
				_KetquainManager.Update(_KetquainEntity);
				
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Id.Name].Value = _KetquainEntity.Id;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngay.Name].Value = _KetquainEntity.Ngay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ca.Name].Value = _KetquainEntity.Ca;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Mamay.Name].Value = _KetquainEntity.Mamay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Lenhin.Name].Value = _KetquainEntity.Lenhin;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Masanpham.Name].Value = _KetquainEntity.Masanpham;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Macongnhan.Name].Value = _KetquainEntity.Macongnhan;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.SometLsx.Name].Value = _KetquainEntity.SometLsx;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sometcap.Name].Value = _KetquainEntity.Sometcap;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sokgcap.Name].Value = _KetquainEntity.Sokgcap;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thuctein.Name].Value = _KetquainEntity.Thuctein;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sokgin.Name].Value = _KetquainEntity.Sokgin;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Saihongthucte.Name].Value = _KetquainEntity.Saihongthucte;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianbatdau.Name].Value = _KetquainEntity.Thoigianbatdau;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianketthuc.Name].Value = _KetquainEntity.Thoigianketthuc;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianchuanbi.Name].Value = _KetquainEntity.Thoigianchuanbi;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigiansuco.Name].Value = _KetquainEntity.Thoigiansuco;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.PheNcc.Name].Value = _KetquainEntity.PheNcc;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.PheSx.Name].Value = _KetquainEntity.PheSx;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngaytao.Name].Value = _KetquainEntity.Ngaytao;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nguoitao.Name].Value = _KetquainEntity.Nguoitao;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngaysua.Name].Value = _KetquainEntity.Ngaysua;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nguoisua.Name].Value = _KetquainEntity.Nguoisua;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tensanpham.Name].Value = _KetquainEntity.Tensanpham;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tenmay.Name].Value = _KetquainEntity.Tenmay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tencongnhan.Name].Value = _KetquainEntity.Tencongnhan;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nangsuat.Name].Value = _KetquainEntity.Nangsuat;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tylesaihong.Name].Value = _KetquainEntity.Tylesaihong;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tongmdm.Name].Value = _KetquainEntity.Tongmdm;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Matruongca.Name].Value = _KetquainEntity.Matruongca;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tentruongca.Name].Value = _KetquainEntity.Tentruongca;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tocdodinhmuc.Name].Value = _KetquainEntity.Tocdodinhmuc;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUAIN_PK;
		}

	}
}
