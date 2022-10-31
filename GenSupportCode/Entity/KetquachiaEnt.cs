
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
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUACHIA_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUACHIA_PK)
		{
			KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
			
			_KetquachiaEntity.Id = txt_ID.Text.Trim();
			_KetquachiaEntity.Ngay = txt_NGAY.Text.Trim();
			_KetquachiaEntity.Ca = txt_CA.Text.Trim();
			_KetquachiaEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquachiaEntity.Lenh = txt_LENH.Text.Trim();
			_KetquachiaEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquachiaEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquachiaEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquachiaEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquachiaEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_KetquachiaEntity.Dauraghep = txt_DAURAGHEP.Text.Trim();
			_KetquachiaEntity.Sometvao = txt_SOMETVAO.Text.Trim();
			_KetquachiaEntity.Sokgvao = txt_SOKGVAO.Text.Trim();
			_KetquachiaEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_KetquachiaEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_KetquachiaEntity.Thoigianlencuon = txt_THOIGIANLENCUON.Text.Trim();
			_KetquachiaEntity.Thoigianhacuon = txt_THOIGIANHACUON.Text.Trim();
			_KetquachiaEntity.Solanhacuon = txt_SOLANHACUON.Text.Trim();
			_KetquachiaEntity.Thoigiancatdau = txt_THOIGIANCATDAU.Text.Trim();
			_KetquachiaEntity.Thoigiandoilenh = txt_THOIGIANDOILENH.Text.Trim();
			_KetquachiaEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_KetquachiaEntity.Phein = txt_PHEIN.Text.Trim();
			_KetquachiaEntity.Pheghep = txt_PHEGHEP.Text.Trim();
			_KetquachiaEntity.Phechia = txt_PHECHIA.Text.Trim();
			_KetquachiaEntity.PhethoiNcc = txt_PHETHOINCC.Text.Trim();
			_KetquachiaEntity.Phesx = txt_PHESX.Text.Trim();
			_KetquachiaEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_KetquachiaEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_KetquachiaEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_KetquachiaEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquachiaEntity.Nangsuat = txt_NANGSUAT.Text.Trim();
			_KetquachiaEntity.Tylesaihong = txt_TYLESAIHONG.Text.Trim();
			_KetquachiaEntity.Socuon = txt_SOCUON.Text.Trim();
			
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
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_KetquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUACHIA_PK;
		}

	}
}
