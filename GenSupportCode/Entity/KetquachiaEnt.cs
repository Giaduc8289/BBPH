
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

		void BS_Ketquachia_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Ketquachia.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Ketquachia.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquachiaFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[KetquachiaFields.Id.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[KetquachiaFields.Ngay.Name].ToString();
					txt_Ca.Text = _Rowview.Row[KetquachiaFields.Ca.Name].ToString();
					txt_Lenh.Text = _Rowview.Row[KetquachiaFields.Lenh.Name].ToString();
					txt_Masanpham.Text = _Rowview.Row[KetquachiaFields.Masanpham.Name].ToString();
					txt_Macongnhan.Text = _Rowview.Row[KetquachiaFields.Macongnhan.Name].ToString();
					txt_Dauraghep.Text = _Rowview.Row[KetquachiaFields.Dauraghep.Name].ToString();
					txt_Sometvao.Text = _Rowview.Row[KetquachiaFields.Sometvao.Name].ToString();
					txt_Sokgvao.Text = _Rowview.Row[KetquachiaFields.Sokgvao.Name].ToString();
					txt_Socon.Text = _Rowview.Row[KetquachiaFields.Socon.Name].ToString();
					txt_Thoigianbatdau.Text = _Rowview.Row[KetquachiaFields.Thoigianbatdau.Name].ToString();
					txt_Thoigianketthuc.Text = _Rowview.Row[KetquachiaFields.Thoigianketthuc.Name].ToString();
					txt_Thoigianlencuon.Text = _Rowview.Row[KetquachiaFields.Thoigianlencuon.Name].ToString();
					txt_Thoigianhacuon.Text = _Rowview.Row[KetquachiaFields.Thoigianhacuon.Name].ToString();
					txt_Solanhacuon.Text = _Rowview.Row[KetquachiaFields.Solanhacuon.Name].ToString();
					txt_Thoigiancatdau.Text = _Rowview.Row[KetquachiaFields.Thoigiancatdau.Name].ToString();
					txt_Thoigiandoilenh.Text = _Rowview.Row[KetquachiaFields.Thoigiandoilenh.Name].ToString();
					txt_Thoigiansuco.Text = _Rowview.Row[KetquachiaFields.Thoigiansuco.Name].ToString();
					txt_Phein.Text = _Rowview.Row[KetquachiaFields.Phein.Name].ToString();
					txt_Pheghep.Text = _Rowview.Row[KetquachiaFields.Pheghep.Name].ToString();
					txt_Phechia.Text = _Rowview.Row[KetquachiaFields.Phechia.Name].ToString();
					txt_PhethoiNcc.Text = _Rowview.Row[KetquachiaFields.PhethoiNcc.Name].ToString();
					txt_Phesx.Text = _Rowview.Row[KetquachiaFields.Phesx.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[KetquachiaFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[KetquachiaFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[KetquachiaFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[KetquachiaFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Ketquachia_CurrentChanged"); }
		}

		private string Save_Data(string _str_Ketquachia_PK)
		{
			KetquachiaEntity _ketquachiaEntity = new KetquachiaEntity();
			
			_ketquachiaEntity.Id = txt_Id.Text.Trim();
			_ketquachiaEntity.Ngay = txt_Ngay.Text.Trim();
			_ketquachiaEntity.Ca = txt_Ca.Text.Trim();
			_ketquachiaEntity.Lenh = txt_Lenh.Text.Trim();
			_ketquachiaEntity.Masanpham = txt_Masanpham.Text.Trim();
			_ketquachiaEntity.Macongnhan = txt_Macongnhan.Text.Trim();
			_ketquachiaEntity.Dauraghep = txt_Dauraghep.Text.Trim();
			_ketquachiaEntity.Sometvao = txt_Sometvao.Text.Trim();
			_ketquachiaEntity.Sokgvao = txt_Sokgvao.Text.Trim();
			_ketquachiaEntity.Socon = txt_Socon.Text.Trim();
			_ketquachiaEntity.Thoigianbatdau = txt_Thoigianbatdau.Text.Trim();
			_ketquachiaEntity.Thoigianketthuc = txt_Thoigianketthuc.Text.Trim();
			_ketquachiaEntity.Thoigianlencuon = txt_Thoigianlencuon.Text.Trim();
			_ketquachiaEntity.Thoigianhacuon = txt_Thoigianhacuon.Text.Trim();
			_ketquachiaEntity.Solanhacuon = txt_Solanhacuon.Text.Trim();
			_ketquachiaEntity.Thoigiancatdau = txt_Thoigiancatdau.Text.Trim();
			_ketquachiaEntity.Thoigiandoilenh = txt_Thoigiandoilenh.Text.Trim();
			_ketquachiaEntity.Thoigiansuco = txt_Thoigiansuco.Text.Trim();
			_ketquachiaEntity.Phein = txt_Phein.Text.Trim();
			_ketquachiaEntity.Pheghep = txt_Pheghep.Text.Trim();
			_ketquachiaEntity.Phechia = txt_Phechia.Text.Trim();
			_ketquachiaEntity.PhethoiNcc = txt_PhethoiNcc.Text.Trim();
			_ketquachiaEntity.Phesx = txt_Phesx.Text.Trim();
			_ketquachiaEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_ketquachiaEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_ketquachiaEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_ketquachiaEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Ketquachia_PK = _KetquachiaManager.InsertV2(_KetquachiaEntity, r_Insert, DT_Ketquachia, BS_Ketquachia);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_ketquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Ketquachia.ResetCurrentItem();
			}
			else
			{
				_KetquachiaManager.Update(_ketquachiaEntity);
				
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Id.Name].Value = _ketquachiaEntity.Id;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Ngay.Name].Value = _ketquachiaEntity.Ngay;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Ca.Name].Value = _ketquachiaEntity.Ca;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Lenh.Name].Value = _ketquachiaEntity.Lenh;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Masanpham.Name].Value = _ketquachiaEntity.Masanpham;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Macongnhan.Name].Value = _ketquachiaEntity.Macongnhan;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Dauraghep.Name].Value = _ketquachiaEntity.Dauraghep;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Sometvao.Name].Value = _ketquachiaEntity.Sometvao;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Sokgvao.Name].Value = _ketquachiaEntity.Sokgvao;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Socon.Name].Value = _ketquachiaEntity.Socon;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Thoigianbatdau.Name].Value = _ketquachiaEntity.Thoigianbatdau;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Thoigianketthuc.Name].Value = _ketquachiaEntity.Thoigianketthuc;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Thoigianlencuon.Name].Value = _ketquachiaEntity.Thoigianlencuon;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Thoigianhacuon.Name].Value = _ketquachiaEntity.Thoigianhacuon;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Solanhacuon.Name].Value = _ketquachiaEntity.Solanhacuon;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Thoigiancatdau.Name].Value = _ketquachiaEntity.Thoigiancatdau;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Thoigiandoilenh.Name].Value = _ketquachiaEntity.Thoigiandoilenh;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Thoigiansuco.Name].Value = _ketquachiaEntity.Thoigiansuco;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Phein.Name].Value = _ketquachiaEntity.Phein;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Pheghep.Name].Value = _ketquachiaEntity.Pheghep;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Phechia.Name].Value = _ketquachiaEntity.Phechia;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.PhethoiNcc.Name].Value = _ketquachiaEntity.PhethoiNcc;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Phesx.Name].Value = _ketquachiaEntity.Phesx;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Ngaytao.Name].Value = _ketquachiaEntity.Ngaytao;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Nguoitao.Name].Value = _ketquachiaEntity.Nguoitao;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Ngaysua.Name].Value = _ketquachiaEntity.Ngaysua;
				GRID_Ketquachia.CurrentRow.Cells[KetquachiaFields.Nguoisua.Name].Value = _ketquachiaEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquachiaManager.Convert(_ketquachiaEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Ketquachia_PK;
		}

	}
}
