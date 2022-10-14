
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

		void BS_Ketquatua_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Ketquatua.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Ketquatua.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquatuaFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[KetquatuaFields.Id.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[KetquatuaFields.Ngay.Name].ToString();
					txt_Ca.Text = _Rowview.Row[KetquatuaFields.Ca.Name].ToString();
					txt_Mamay.Text = _Rowview.Row[KetquatuaFields.Mamay.Name].ToString();
					txt_Lenhtua.Text = _Rowview.Row[KetquatuaFields.Lenhtua.Name].ToString();
					txt_Masanpham.Text = _Rowview.Row[KetquatuaFields.Masanpham.Name].ToString();
					txt_Macongnhan.Text = _Rowview.Row[KetquatuaFields.Macongnhan.Name].ToString();
					txt_Daurain.Text = _Rowview.Row[KetquatuaFields.Daurain.Name].ToString();
					txt_SoMetvao.Text = _Rowview.Row[KetquatuaFields.SoMetvao.Name].ToString();
					txt_SoKgvao.Text = _Rowview.Row[KetquatuaFields.SoKgvao.Name].ToString();
					txt_SoMetra.Text = _Rowview.Row[KetquatuaFields.SoMetra.Name].ToString();
					txt_SoKgra.Text = _Rowview.Row[KetquatuaFields.SoKgra.Name].ToString();
					txt_Saihongthucte.Text = _Rowview.Row[KetquatuaFields.Saihongthucte.Name].ToString();
					txt_Thoigianbatdau.Text = _Rowview.Row[KetquatuaFields.Thoigianbatdau.Name].ToString();
					txt_Thoigianketthuc.Text = _Rowview.Row[KetquatuaFields.Thoigianketthuc.Name].ToString();
					txt_Thoigianchuanbi.Text = _Rowview.Row[KetquatuaFields.Thoigianchuanbi.Name].ToString();
					txt_Thoigianhacuon.Text = _Rowview.Row[KetquatuaFields.Thoigianhacuon.Name].ToString();
					txt_Thoigiancatdau.Text = _Rowview.Row[KetquatuaFields.Thoigiancatdau.Name].ToString();
					txt_Thoigiandoilenh.Text = _Rowview.Row[KetquatuaFields.Thoigiandoilenh.Name].ToString();
					txt_Thoigiansuco.Text = _Rowview.Row[KetquatuaFields.Thoigiansuco.Name].ToString();
					txt_Phein.Text = _Rowview.Row[KetquatuaFields.Phein.Name].ToString();
					txt_Pheghep.Text = _Rowview.Row[KetquatuaFields.Pheghep.Name].ToString();
					txt_Phethoi.Text = _Rowview.Row[KetquatuaFields.Phethoi.Name].ToString();
					txt_Phesx.Text = _Rowview.Row[KetquatuaFields.Phesx.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[KetquatuaFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[KetquatuaFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[KetquatuaFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[KetquatuaFields.Nguoisua.Name].ToString();
					txt_Tensanpham.Text = _Rowview.Row[KetquatuaFields.Tensanpham.Name].ToString();
					txt_Tenmay.Text = _Rowview.Row[KetquatuaFields.Tenmay.Name].ToString();
					txt_Tencongnhan.Text = _Rowview.Row[KetquatuaFields.Tencongnhan.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Ketquatua_CurrentChanged"); }
		}

		private string Save_Data(string _str_Ketquatua_PK)
		{
			KetquatuaEntity _ketquatuaEntity = new KetquatuaEntity();
			
			_ketquatuaEntity.Id = txt_Id.Text.Trim();
			_ketquatuaEntity.Ngay = txt_Ngay.Text.Trim();
			_ketquatuaEntity.Ca = txt_Ca.Text.Trim();
			_ketquatuaEntity.Mamay = txt_Mamay.Text.Trim();
			_ketquatuaEntity.Lenhtua = txt_Lenhtua.Text.Trim();
			_ketquatuaEntity.Masanpham = txt_Masanpham.Text.Trim();
			_ketquatuaEntity.Macongnhan = txt_Macongnhan.Text.Trim();
			_ketquatuaEntity.Daurain = txt_Daurain.Text.Trim();
			_ketquatuaEntity.SoMetvao = txt_SoMetvao.Text.Trim();
			_ketquatuaEntity.SoKgvao = txt_SoKgvao.Text.Trim();
			_ketquatuaEntity.SoMetra = txt_SoMetra.Text.Trim();
			_ketquatuaEntity.SoKgra = txt_SoKgra.Text.Trim();
			_ketquatuaEntity.Saihongthucte = txt_Saihongthucte.Text.Trim();
			_ketquatuaEntity.Thoigianbatdau = txt_Thoigianbatdau.Text.Trim();
			_ketquatuaEntity.Thoigianketthuc = txt_Thoigianketthuc.Text.Trim();
			_ketquatuaEntity.Thoigianchuanbi = txt_Thoigianchuanbi.Text.Trim();
			_ketquatuaEntity.Thoigianhacuon = txt_Thoigianhacuon.Text.Trim();
			_ketquatuaEntity.Thoigiancatdau = txt_Thoigiancatdau.Text.Trim();
			_ketquatuaEntity.Thoigiandoilenh = txt_Thoigiandoilenh.Text.Trim();
			_ketquatuaEntity.Thoigiansuco = txt_Thoigiansuco.Text.Trim();
			_ketquatuaEntity.Phein = txt_Phein.Text.Trim();
			_ketquatuaEntity.Pheghep = txt_Pheghep.Text.Trim();
			_ketquatuaEntity.Phethoi = txt_Phethoi.Text.Trim();
			_ketquatuaEntity.Phesx = txt_Phesx.Text.Trim();
			_ketquatuaEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_ketquatuaEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_ketquatuaEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_ketquatuaEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			_ketquatuaEntity.Tensanpham = txt_Tensanpham.Text.Trim();
			_ketquatuaEntity.Tenmay = txt_Tenmay.Text.Trim();
			_ketquatuaEntity.Tencongnhan = txt_Tencongnhan.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Ketquatua_PK = _KetquatuaManager.InsertV2(_KetquatuaEntity, r_Insert, DT_Ketquatua, BS_Ketquatua);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquatuaManager.Convert(_ketquatuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Ketquatua.ResetCurrentItem();
			}
			else
			{
				_KetquatuaManager.Update(_ketquatuaEntity);
				
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Id.Name].Value = _ketquatuaEntity.Id;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Ngay.Name].Value = _ketquatuaEntity.Ngay;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Ca.Name].Value = _ketquatuaEntity.Ca;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Mamay.Name].Value = _ketquatuaEntity.Mamay;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Lenhtua.Name].Value = _ketquatuaEntity.Lenhtua;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Masanpham.Name].Value = _ketquatuaEntity.Masanpham;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Macongnhan.Name].Value = _ketquatuaEntity.Macongnhan;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Daurain.Name].Value = _ketquatuaEntity.Daurain;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.SoMetvao.Name].Value = _ketquatuaEntity.SoMetvao;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.SoKgvao.Name].Value = _ketquatuaEntity.SoKgvao;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.SoMetra.Name].Value = _ketquatuaEntity.SoMetra;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.SoKgra.Name].Value = _ketquatuaEntity.SoKgra;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Saihongthucte.Name].Value = _ketquatuaEntity.Saihongthucte;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Thoigianbatdau.Name].Value = _ketquatuaEntity.Thoigianbatdau;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Thoigianketthuc.Name].Value = _ketquatuaEntity.Thoigianketthuc;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Thoigianchuanbi.Name].Value = _ketquatuaEntity.Thoigianchuanbi;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Thoigianhacuon.Name].Value = _ketquatuaEntity.Thoigianhacuon;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Thoigiancatdau.Name].Value = _ketquatuaEntity.Thoigiancatdau;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Thoigiandoilenh.Name].Value = _ketquatuaEntity.Thoigiandoilenh;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Thoigiansuco.Name].Value = _ketquatuaEntity.Thoigiansuco;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Phein.Name].Value = _ketquatuaEntity.Phein;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Pheghep.Name].Value = _ketquatuaEntity.Pheghep;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Phethoi.Name].Value = _ketquatuaEntity.Phethoi;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Phesx.Name].Value = _ketquatuaEntity.Phesx;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Ngaytao.Name].Value = _ketquatuaEntity.Ngaytao;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Nguoitao.Name].Value = _ketquatuaEntity.Nguoitao;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Ngaysua.Name].Value = _ketquatuaEntity.Ngaysua;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Nguoisua.Name].Value = _ketquatuaEntity.Nguoisua;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Tensanpham.Name].Value = _ketquatuaEntity.Tensanpham;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Tenmay.Name].Value = _ketquatuaEntity.Tenmay;
				GRID_Ketquatua.CurrentRow.Cells[KetquatuaFields.Tencongnhan.Name].Value = _ketquatuaEntity.Tencongnhan;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquatuaManager.Convert(_ketquatuaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Ketquatua_PK;
		}

	}
}
