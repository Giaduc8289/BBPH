
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquachiaEnt
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
	public class KetquachiaEnt : KetquachiaEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquachiaEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUACHIA_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUACHIA.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUACHIA.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquachiaFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquachiaFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[KetquachiaFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KetquachiaFields.Ca.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KetquachiaFields.Mamay.Name].ToString();
					txt_LENH.Text = _Rowview.Row[KetquachiaFields.Lenh.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KetquachiaFields.Masanpham.Name].ToString();
					txt_MACONGNHAN.Text = _Rowview.Row[KetquachiaFields.Macongnhan.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquachiaFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquachiaFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquachiaFields.Tencongnhan.Name].ToString();
					txt_DAURAGHEP.Text = _Rowview.Row[KetquachiaFields.Dauraghep.Name].ToString();
					txt_SOMETVAO.Text = _Rowview.Row[KetquachiaFields.Sometvao.Name].ToString();
					txt_SOKGVAO.Text = _Rowview.Row[KetquachiaFields.Sokgvao.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquachiaFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquachiaFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANLENCUON.Text = _Rowview.Row[KetquachiaFields.Thoigianlencuon.Name].ToString();
					txt_THOIGIANHACUON.Text = _Rowview.Row[KetquachiaFields.Thoigianhacuon.Name].ToString();
					txt_SOLANHACUON.Text = _Rowview.Row[KetquachiaFields.Solanhacuon.Name].ToString();
					txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquachiaFields.Thoigiancatdau.Name].ToString();
					txt_THOIGIANDOILENH.Text = _Rowview.Row[KetquachiaFields.Thoigiandoilenh.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquachiaFields.Thoigiansuco.Name].ToString();
					txt_PHEIN.Text = _Rowview.Row[KetquachiaFields.Phein.Name].ToString();
					txt_PHEGHEP.Text = _Rowview.Row[KetquachiaFields.Pheghep.Name].ToString();
					txt_PHECHIA.Text = _Rowview.Row[KetquachiaFields.Phechia.Name].ToString();
					txt_PHETHOINCC.Text = _Rowview.Row[KetquachiaFields.PhethoiNcc.Name].ToString();
					txt_PHESX.Text = _Rowview.Row[KetquachiaFields.Phesx.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquachiaFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquachiaFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquachiaFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquachiaFields.Nguoisua.Name].ToString();
					txt_NANGSUAT.Text = _Rowview.Row[KetquachiaFields.Nangsuat.Name].ToString();
					txt_TYLESAIHONG.Text = _Rowview.Row[KetquachiaFields.Tylesaihong.Name].ToString();
					txt_SOCUON.Text = _Rowview.Row[KetquachiaFields.Socuon.Name].ToString();
					txt_MATRUONGCA.Text = _Rowview.Row[KetquachiaFields.Matruongca.Name].ToString();
					txt_TENTRUONGCA.Text = _Rowview.Row[KetquachiaFields.Tentruongca.Name].ToString();
					txt_TOCDODINHMUC.Text = _Rowview.Row[KetquachiaFields.Tocdodinhmuc.Name].ToString();
					txt_LYDOSUCO.Text = _Rowview.Row[KetquachiaFields.Lydosuco.Name].ToString();
					txt_SOMETRA.Text = _Rowview.Row[KetquachiaFields.Sometra.Name].ToString();
					txt_SOKGRA.Text = _Rowview.Row[KetquachiaFields.Sokgra.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUACHIA_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUACHIA_PK)
		{
			KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
			try { _KetquachiaEntity.Id = System.Int64.Parse(txt_ID.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Ngay = System.DateTime.Parse(txt_NGAY.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Ca = System.Int32.Parse(txt_CA.Text.Trim()); } 
			catch { }
			_KetquachiaEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquachiaEntity.Lenh = txt_LENH.Text.Trim();
			_KetquachiaEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquachiaEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquachiaEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquachiaEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquachiaEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			try { _KetquachiaEntity.Dauraghep = System.Decimal.Parse(txt_DAURAGHEP.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Sometvao = System.Decimal.Parse(txt_SOMETVAO.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Sokgvao = System.Decimal.Parse(txt_SOKGVAO.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Thoigianbatdau = System.DateTime.Parse(txt_THOIGIANBATDAU.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Thoigianketthuc = System.DateTime.Parse(txt_THOIGIANKETTHUC.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Thoigianlencuon = System.Decimal.Parse(txt_THOIGIANLENCUON.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Thoigianhacuon = System.Decimal.Parse(txt_THOIGIANHACUON.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Solanhacuon = System.Int32.Parse(txt_SOLANHACUON.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Thoigiancatdau = System.Decimal.Parse(txt_THOIGIANCATDAU.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Thoigiandoilenh = System.Decimal.Parse(txt_THOIGIANDOILENH.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Thoigiansuco = System.Decimal.Parse(txt_THOIGIANSUCO.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Phein = System.Decimal.Parse(txt_PHEIN.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Pheghep = System.Decimal.Parse(txt_PHEGHEP.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Phechia = System.Decimal.Parse(txt_PHECHIA.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.PhethoiNcc = System.Decimal.Parse(txt_PHETHOINCC.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Phesx = System.Decimal.Parse(txt_PHESX.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Ngaytao = System.DateTime.Parse(txt_NGAYTAO.Text.Trim()); } 
			catch { }
			_KetquachiaEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			try { _KetquachiaEntity.Ngaysua = System.DateTime.Parse(txt_NGAYSUA.Text.Trim()); } 
			catch { }
			_KetquachiaEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			try { _KetquachiaEntity.Nangsuat = System.Decimal.Parse(txt_NANGSUAT.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Tylesaihong = System.Decimal.Parse(txt_TYLESAIHONG.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Socuon = System.Int32.Parse(txt_SOCUON.Text.Trim()); } 
			catch { }
			_KetquachiaEntity.Matruongca = txt_MATRUONGCA.Text.Trim();
			_KetquachiaEntity.Tentruongca = txt_TENTRUONGCA.Text.Trim();
			try { _KetquachiaEntity.Tocdodinhmuc = System.Decimal.Parse(txt_TOCDODINHMUC.Text.Trim()); } 
			catch { }
			_KetquachiaEntity.Lydosuco = txt_LYDOSUCO.Text.Trim();
			try { _KetquachiaEntity.Sometra = System.Decimal.Parse(txt_SOMETRA.Text.Trim()); } 
			catch { }
			try { _KetquachiaEntity.Sokgra = System.Decimal.Parse(txt_SOKGRA.Text.Trim()); } 
			catch { }
			
			
			if (string.IsNullOrEmpty(_str_KETQUACHIA_PK))
			{
				_str_KETQUACHIA_PK = _KetquachiaManager.InsertV2(_KetquachiaEntity, r_Insert, DT_KETQUACHIA, BS_KETQUACHIA);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_KetquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUACHIA.ResetCurrentItem();
			}
			else
			{
				_KetquachiaManager.Update(_KetquachiaEntity);
				
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Id.Name].Value = _KetquachiaEntity.Id;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ngay.Name].Value = _KetquachiaEntity.Ngay;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ca.Name].Value = _KetquachiaEntity.Ca;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Mamay.Name].Value = _KetquachiaEntity.Mamay;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Lenh.Name].Value = _KetquachiaEntity.Lenh;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Masanpham.Name].Value = _KetquachiaEntity.Masanpham;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Macongnhan.Name].Value = _KetquachiaEntity.Macongnhan;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tensanpham.Name].Value = _KetquachiaEntity.Tensanpham;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tenmay.Name].Value = _KetquachiaEntity.Tenmay;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tencongnhan.Name].Value = _KetquachiaEntity.Tencongnhan;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Dauraghep.Name].Value = _KetquachiaEntity.Dauraghep;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Sometvao.Name].Value = _KetquachiaEntity.Sometvao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Sokgvao.Name].Value = _KetquachiaEntity.Sokgvao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianbatdau.Name].Value = _KetquachiaEntity.Thoigianbatdau;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianketthuc.Name].Value = _KetquachiaEntity.Thoigianketthuc;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianlencuon.Name].Value = _KetquachiaEntity.Thoigianlencuon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianhacuon.Name].Value = _KetquachiaEntity.Thoigianhacuon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Solanhacuon.Name].Value = _KetquachiaEntity.Solanhacuon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigiancatdau.Name].Value = _KetquachiaEntity.Thoigiancatdau;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigiandoilenh.Name].Value = _KetquachiaEntity.Thoigiandoilenh;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigiansuco.Name].Value = _KetquachiaEntity.Thoigiansuco;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Phein.Name].Value = _KetquachiaEntity.Phein;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Pheghep.Name].Value = _KetquachiaEntity.Pheghep;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Phechia.Name].Value = _KetquachiaEntity.Phechia;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.PhethoiNcc.Name].Value = _KetquachiaEntity.PhethoiNcc;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Phesx.Name].Value = _KetquachiaEntity.Phesx;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ngaytao.Name].Value = _KetquachiaEntity.Ngaytao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Nguoitao.Name].Value = _KetquachiaEntity.Nguoitao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ngaysua.Name].Value = _KetquachiaEntity.Ngaysua;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Nguoisua.Name].Value = _KetquachiaEntity.Nguoisua;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Nangsuat.Name].Value = _KetquachiaEntity.Nangsuat;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tylesaihong.Name].Value = _KetquachiaEntity.Tylesaihong;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Socuon.Name].Value = _KetquachiaEntity.Socuon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Matruongca.Name].Value = _KetquachiaEntity.Matruongca;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tentruongca.Name].Value = _KetquachiaEntity.Tentruongca;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tocdodinhmuc.Name].Value = _KetquachiaEntity.Tocdodinhmuc;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Lydosuco.Name].Value = _KetquachiaEntity.Lydosuco;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Sometra.Name].Value = _KetquachiaEntity.Sometra;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Sokgra.Name].Value = _KetquachiaEntity.Sokgra;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_KetquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUACHIA_PK;
		}

	}
}
