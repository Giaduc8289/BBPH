
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
					txt_SAIHONGTHUCTE.Text = _Rowview.Row[KetquatuaFields.Saihongthucte.Name].ToString();
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
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUATUA_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUATUA_PK)
		{
			KetquatuaEntity _KetquatuaEntity = new KetquatuaEntity();
			
			_KetquatuaEntity.Id = txt_ID.Text.Trim();
			_KetquatuaEntity.Ngay = txt_NGAY.Text.Trim();
			_KetquatuaEntity.Ca = txt_CA.Text.Trim();
			_KetquatuaEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquatuaEntity.Lenhtua = txt_LENHTUA.Text.Trim();
			_KetquatuaEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquatuaEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquatuaEntity.Daurain = txt_DAURAIN.Text.Trim();
			_KetquatuaEntity.SoMetvao = txt_SOMETVAO.Text.Trim();
			_KetquatuaEntity.SoKgvao = txt_SOKGVAO.Text.Trim();
			_KetquatuaEntity.SoMetra = txt_SOMETRA.Text.Trim();
			_KetquatuaEntity.SoKgra = txt_SOKGRA.Text.Trim();
			_KetquatuaEntity.Saihongthucte = txt_SAIHONGTHUCTE.Text.Trim();
			_KetquatuaEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_KetquatuaEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_KetquatuaEntity.Thoigianhacuon = txt_THOIGIANHACUON.Text.Trim();
			_KetquatuaEntity.Thoigiancatdau = txt_THOIGIANCATDAU.Text.Trim();
			_KetquatuaEntity.Thoigiandoilenh = txt_THOIGIANDOILENH.Text.Trim();
			_KetquatuaEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_KetquatuaEntity.Phein = txt_PHEIN.Text.Trim();
			_KetquatuaEntity.Pheghep = txt_PHEGHEP.Text.Trim();
			_KetquatuaEntity.Phethoi = txt_PHETHOI.Text.Trim();
			_KetquatuaEntity.Phesx = txt_PHESX.Text.Trim();
			_KetquatuaEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_KetquatuaEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_KetquatuaEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_KetquatuaEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquatuaEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquatuaEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquatuaEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_KetquatuaEntity.Nangsuat = txt_NANGSUAT.Text.Trim();
			_KetquatuaEntity.Thoigiandauca = txt_THOIGIANDAUCA.Text.Trim();
			
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
				GRID_KETQUATUA.CurrentRow.Cells[KetquatuaFields.Saihongthucte.Name].Value = _KetquatuaEntity.Saihongthucte;
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
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquatuaManager.Convert(_KetquatuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUATUA_PK;
		}

	}
}
