
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquatuaEnt
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
	public class KetquatuaEnt : KetquatuaEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquatuaEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUATUA_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUATUA.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUATUA.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquatuaFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquatuaFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[KetquatuaFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KetquatuaFields.Ca.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KetquatuaFields.Mamay.Name].ToString();
					txt_LENHTUA.Text = _Rowview.Row[KetquatuaFields.Lenhtua.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KetquatuaFields.Masanpham.Name].ToString();
					txt_MACONGNHAN.Text = _Rowview.Row[KetquatuaFields.Macongnhan.Name].ToString();
					txt_DAURAIN.Text = _Rowview.Row[KetquatuaFields.Daurain.Name].ToString();
					txt_SOMETVAO.Text = _Rowview.Row[KetquatuaFields.SoMetvao.Name].ToString();
					txt_SOKGVAO.Text = _Rowview.Row[KetquatuaFields.SoKgvao.Name].ToString();
					txt_SOMETRA.Text = _Rowview.Row[KetquatuaFields.SoMetra.Name].ToString();
					txt_SOKGRA.Text = _Rowview.Row[KetquatuaFields.SoKgra.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquatuaFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquatuaFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANHACUON.Text = _Rowview.Row[KetquatuaFields.Thoigianhacuon.Name].ToString();
					txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquatuaFields.Thoigiancatdau.Name].ToString();
					txt_THOIGIANDOILENH.Text = _Rowview.Row[KetquatuaFields.Thoigiandoilenh.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquatuaFields.Thoigiansuco.Name].ToString();
					txt_PHEIN.Text = _Rowview.Row[KetquatuaFields.Phein.Name].ToString();
					txt_PHEGHEP.Text = _Rowview.Row[KetquatuaFields.Pheghep.Name].ToString();
					txt_PHETHOI.Text = _Rowview.Row[KetquatuaFields.Phethoi.Name].ToString();
					txt_PHESX.Text = _Rowview.Row[KetquatuaFields.Phesx.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquatuaFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquatuaFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquatuaFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquatuaFields.Nguoisua.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquatuaFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquatuaFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquatuaFields.Tencongnhan.Name].ToString();
					txt_NANGSUAT.Text = _Rowview.Row[KetquatuaFields.Nangsuat.Name].ToString();
					txt_THOIGIANDAUCA.Text = _Rowview.Row[KetquatuaFields.Thoigiandauca.Name].ToString();
					txt_CHENHLECHKG.Text = _Rowview.Row[KetquatuaFields.Chenhlechkg.Name].ToString();
					txt_MATRUONGCA.Text = _Rowview.Row[KetquatuaFields.Matruongca.Name].ToString();
					txt_TENTRUONGCA.Text = _Rowview.Row[KetquatuaFields.Tentruongca.Name].ToString();
					txt_TOCDODINHMUC.Text = _Rowview.Row[KetquatuaFields.Tocdodinhmuc.Name].ToString();
					txt_LYDOSUCO.Text = _Rowview.Row[KetquatuaFields.Lydosuco.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUATUA_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUATUA_PK)
		{
			KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity();
			try { _KetquatuaEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			_KetquatuaEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquatuaEntity.Lenhtua = txt_LENHTUA.Text.Trim();
			_KetquatuaEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquatuaEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			try { _KetquatuaEntity.Daurain = System.Decimal.Parse(txt_DAURAIN.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.SoMetvao = System.Decimal.Parse(txt_SOMETVAO.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.SoKgvao = System.Decimal.Parse(txt_SOKGVAO.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.SoMetra = System.Decimal.Parse(txt_SOMETRA.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.SoKgra = System.Decimal.Parse(txt_SOKGRA.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Thoigianbatdau = System.DateTime.Parse(txt_THOIGIANBATDAU.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Thoigianketthuc = System.DateTime.Parse(txt_THOIGIANKETTHUC.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Thoigianhacuon = System.Decimal.Parse(txt_THOIGIANHACUON.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Thoigiancatdau = System.Decimal.Parse(txt_THOIGIANCATDAU.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Thoigiandoilenh = System.Decimal.Parse(txt_THOIGIANDOILENH.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Thoigiansuco = System.Decimal.Parse(txt_THOIGIANSUCO.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Phein = System.Decimal.Parse(txt_PHEIN.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Pheghep = System.Decimal.Parse(txt_PHEGHEP.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Phethoi = System.Decimal.Parse(txt_PHETHOI.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Phesx = System.Decimal.Parse(txt_PHESX.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KetquatuaEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KetquatuaEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KetquatuaEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquatuaEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquatuaEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquatuaEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			try { _KetquatuaEntity.Nangsuat = System.Decimal.Parse(txt_NANGSUAT.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Thoigiandauca = System.Decimal.Parse(txt_THOIGIANDAUCA.Text.Trim()); } 
			catch { }
			try { _KetquatuaEntity.Chenhlechkg = System.Decimal.Parse(txt_CHENHLECHKG.Text.Trim()); } 
			catch { }
			_KetquatuaEntity.Matruongca = txt_MATRUONGCA.Text.Trim();
			_KetquatuaEntity.Tentruongca = txt_TENTRUONGCA.Text.Trim();
			try { _KetquatuaEntity.Tocdodinhmuc = System.Decimal.Parse(txt_TOCDODINHMUC.Text.Trim()); } 
			catch { }
			_KetquatuaEntity.Lydosuco = txt_LYDOSUCO.Text.Trim();
			
			
			if (string.IsNullOrEmpty(_str_KETQUATUA_PK))
			{
				_str_KETQUATUA_PK = _KetquatuaManager.InsertV2(_KetquatuaEntity, r_Insert, DT_KETQUATUA, BS_KETQUATUA);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquatuaManager.Convert(_KetquatuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUATUA.ResetCurrentItem();
			}
			else
			{
				_KetquatuaManager.Update(_KetquatuaEntity);
				
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Id.Name].Value = _KetquatuaEntity.Id;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Ngay.Name].Value = _KetquatuaEntity.Ngay;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Ca.Name].Value = _KetquatuaEntity.Ca;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Mamay.Name].Value = _KetquatuaEntity.Mamay;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Lenhtua.Name].Value = _KetquatuaEntity.Lenhtua;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Masanpham.Name].Value = _KetquatuaEntity.Masanpham;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Macongnhan.Name].Value = _KetquatuaEntity.Macongnhan;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Daurain.Name].Value = _KetquatuaEntity.Daurain;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.SoMetvao.Name].Value = _KetquatuaEntity.SoMetvao;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.SoKgvao.Name].Value = _KetquatuaEntity.SoKgvao;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.SoMetra.Name].Value = _KetquatuaEntity.SoMetra;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.SoKgra.Name].Value = _KetquatuaEntity.SoKgra;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Thoigianbatdau.Name].Value = _KetquatuaEntity.Thoigianbatdau;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Thoigianketthuc.Name].Value = _KetquatuaEntity.Thoigianketthuc;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Thoigianhacuon.Name].Value = _KetquatuaEntity.Thoigianhacuon;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Thoigiancatdau.Name].Value = _KetquatuaEntity.Thoigiancatdau;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Thoigiandoilenh.Name].Value = _KetquatuaEntity.Thoigiandoilenh;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Thoigiansuco.Name].Value = _KetquatuaEntity.Thoigiansuco;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Phein.Name].Value = _KetquatuaEntity.Phein;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Pheghep.Name].Value = _KetquatuaEntity.Pheghep;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Phethoi.Name].Value = _KetquatuaEntity.Phethoi;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Phesx.Name].Value = _KetquatuaEntity.Phesx;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Ngaytao.Name].Value = _KetquatuaEntity.Ngaytao;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Nguoitao.Name].Value = _KetquatuaEntity.Nguoitao;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Ngaysua.Name].Value = _KetquatuaEntity.Ngaysua;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Nguoisua.Name].Value = _KetquatuaEntity.Nguoisua;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Tensanpham.Name].Value = _KetquatuaEntity.Tensanpham;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Tenmay.Name].Value = _KetquatuaEntity.Tenmay;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Tencongnhan.Name].Value = _KetquatuaEntity.Tencongnhan;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Nangsuat.Name].Value = _KetquatuaEntity.Nangsuat;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Thoigiandauca.Name].Value = _KetquatuaEntity.Thoigiandauca;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Chenhlechkg.Name].Value = _KetquatuaEntity.Chenhlechkg;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Matruongca.Name].Value = _KetquatuaEntity.Matruongca;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Tentruongca.Name].Value = _KetquatuaEntity.Tentruongca;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Tocdodinhmuc.Name].Value = _KetquatuaEntity.Tocdodinhmuc;
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Lydosuco.Name].Value = _KetquatuaEntity.Lydosuco;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquatuaManager.Convert(_KetquatuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUATUA_PK;
		}

	}
}
