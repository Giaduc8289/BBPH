
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
					txt_SOCON.Text = _Rowview.Row[KetquachiaFields.Socon.Name].ToString();
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
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUACHIA_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUACHIA_PK)
		{
			KetquachiaEntity _ketquachiaEntity = new KetquachiaEntity();
			
			_ketquachiaEntity.Id = txt_ID.Text.Trim();
			_ketquachiaEntity.Ngay = txt_NGAY.Text.Trim();
			_ketquachiaEntity.Ca = txt_CA.Text.Trim();
			_ketquachiaEntity.Mamay = txt_MAMAY.Text.Trim();
			_ketquachiaEntity.Lenh = txt_LENH.Text.Trim();
			_ketquachiaEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_ketquachiaEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_ketquachiaEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_ketquachiaEntity.Tenmay = txt_TENMAY.Text.Trim();
			_ketquachiaEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_ketquachiaEntity.Dauraghep = txt_DAURAGHEP.Text.Trim();
			_ketquachiaEntity.Sometvao = txt_SOMETVAO.Text.Trim();
			_ketquachiaEntity.Sokgvao = txt_SOKGVAO.Text.Trim();
			_ketquachiaEntity.Socon = txt_SOCON.Text.Trim();
			_ketquachiaEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_ketquachiaEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_ketquachiaEntity.Thoigianlencuon = txt_THOIGIANLENCUON.Text.Trim();
			_ketquachiaEntity.Thoigianhacuon = txt_THOIGIANHACUON.Text.Trim();
			_ketquachiaEntity.Solanhacuon = txt_SOLANHACUON.Text.Trim();
			_ketquachiaEntity.Thoigiancatdau = txt_THOIGIANCATDAU.Text.Trim();
			_ketquachiaEntity.Thoigiandoilenh = txt_THOIGIANDOILENH.Text.Trim();
			_ketquachiaEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_ketquachiaEntity.Phein = txt_PHEIN.Text.Trim();
			_ketquachiaEntity.Pheghep = txt_PHEGHEP.Text.Trim();
			_ketquachiaEntity.Phechia = txt_PHECHIA.Text.Trim();
			_ketquachiaEntity.PhethoiNcc = txt_PHETHOINCC.Text.Trim();
			_ketquachiaEntity.Phesx = txt_PHESX.Text.Trim();
			_ketquachiaEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_ketquachiaEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_ketquachiaEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_ketquachiaEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUACHIA_PK))
			{
				_str_KETQUACHIA_PK = _KetquachiaManager.InsertV2(_ketquachiaEntity, r_Insert, DT_KETQUACHIA, BS_KETQUACHIA);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_ketquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUACHIA.ResetCurrentItem();
			}
			else
			{
				_KetquachiaManager.Update(_ketquachiaEntity);
				
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Id.Name].Value = _ketquachiaEntity.Id;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ngay.Name].Value = _ketquachiaEntity.Ngay;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ca.Name].Value = _ketquachiaEntity.Ca;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Mamay.Name].Value = _ketquachiaEntity.Mamay;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Lenh.Name].Value = _ketquachiaEntity.Lenh;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Masanpham.Name].Value = _ketquachiaEntity.Masanpham;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Macongnhan.Name].Value = _ketquachiaEntity.Macongnhan;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tensanpham.Name].Value = _ketquachiaEntity.Tensanpham;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tenmay.Name].Value = _ketquachiaEntity.Tenmay;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Tencongnhan.Name].Value = _ketquachiaEntity.Tencongnhan;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Dauraghep.Name].Value = _ketquachiaEntity.Dauraghep;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Sometvao.Name].Value = _ketquachiaEntity.Sometvao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Sokgvao.Name].Value = _ketquachiaEntity.Sokgvao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Socon.Name].Value = _ketquachiaEntity.Socon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianbatdau.Name].Value = _ketquachiaEntity.Thoigianbatdau;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianketthuc.Name].Value = _ketquachiaEntity.Thoigianketthuc;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianlencuon.Name].Value = _ketquachiaEntity.Thoigianlencuon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigianhacuon.Name].Value = _ketquachiaEntity.Thoigianhacuon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Solanhacuon.Name].Value = _ketquachiaEntity.Solanhacuon;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigiancatdau.Name].Value = _ketquachiaEntity.Thoigiancatdau;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigiandoilenh.Name].Value = _ketquachiaEntity.Thoigiandoilenh;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Thoigiansuco.Name].Value = _ketquachiaEntity.Thoigiansuco;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Phein.Name].Value = _ketquachiaEntity.Phein;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Pheghep.Name].Value = _ketquachiaEntity.Pheghep;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Phechia.Name].Value = _ketquachiaEntity.Phechia;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.PhethoiNcc.Name].Value = _ketquachiaEntity.PhethoiNcc;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Phesx.Name].Value = _ketquachiaEntity.Phesx;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ngaytao.Name].Value = _ketquachiaEntity.Ngaytao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Nguoitao.Name].Value = _ketquachiaEntity.Nguoitao;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Ngaysua.Name].Value = _ketquachiaEntity.Ngaysua;
				GRID_KETQUACHIA.CurrentRow.Cells[KetquachiaFields.Nguoisua.Name].Value = _ketquachiaEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_ketquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUACHIA_PK;
		}

	}
}
