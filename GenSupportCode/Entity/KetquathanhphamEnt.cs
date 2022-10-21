
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquathanhphamEnt
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
	public class KetquathanhphamEnt : KetquathanhphamEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquathanhphamEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUATHANHPHAM_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUATHANHPHAM.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUATHANHPHAM.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquathanhphamFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquathanhphamFields.Id.Name].ToString();
					txt_NGAY.Text = _Rowview.Row[KetquathanhphamFields.Ngay.Name].ToString();
					txt_CA.Text = _Rowview.Row[KetquathanhphamFields.Ca.Name].ToString();
					txt_MAMAY.Text = _Rowview.Row[KetquathanhphamFields.Mamay.Name].ToString();
					txt_SOLSX.Text = _Rowview.Row[KetquathanhphamFields.SoLsx.Name].ToString();
					txt_MASANPHAM.Text = _Rowview.Row[KetquathanhphamFields.Masanpham.Name].ToString();
					txt_MACONGNHAN.Text = _Rowview.Row[KetquathanhphamFields.Macongnhan.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquathanhphamFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquathanhphamFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquathanhphamFields.Tencongnhan.Name].ToString();
					txt_SOMETVAO.Text = _Rowview.Row[KetquathanhphamFields.SoMetvao.Name].ToString();
					txt_SOKGVAO.Text = _Rowview.Row[KetquathanhphamFields.SoKgvao.Name].ToString();
					txt_THOIGIANBATDAU.Text = _Rowview.Row[KetquathanhphamFields.Thoigianbatdau.Name].ToString();
					txt_THOIGIANKETTHUC.Text = _Rowview.Row[KetquathanhphamFields.Thoigianketthuc.Name].ToString();
					txt_THOIGIANCHUANBI.Text = _Rowview.Row[KetquathanhphamFields.Thoigianchuanbi.Name].ToString();
					txt_THOIGIANHACUON.Text = _Rowview.Row[KetquathanhphamFields.Thoigianhacuon.Name].ToString();
					txt_THOIGIANCATDAU.Text = _Rowview.Row[KetquathanhphamFields.Thoigiancatdau.Name].ToString();
					txt_THOIGIANSUCO.Text = _Rowview.Row[KetquathanhphamFields.Thoigiansuco.Name].ToString();
					txt_DGNANGSUAT.Text = _Rowview.Row[KetquathanhphamFields.Dgnangsuat.Name].ToString();
					txt_DMTUI.Text = _Rowview.Row[KetquathanhphamFields.Dmtui.Name].ToString();
					txt_TTETUI.Text = _Rowview.Row[KetquathanhphamFields.Ttetui.Name].ToString();
					txt_KIEMTRA.Text = _Rowview.Row[KetquathanhphamFields.Kiemtra.Name].ToString();
					txt_PHEIN.Text = _Rowview.Row[KetquathanhphamFields.Phein.Name].ToString();
					txt_PHEGHEP.Text = _Rowview.Row[KetquathanhphamFields.Pheghep.Name].ToString();
					txt_PHECHIA.Text = _Rowview.Row[KetquathanhphamFields.Phechia.Name].ToString();
					txt_PHEBIEN.Text = _Rowview.Row[KetquathanhphamFields.Phebien.Name].ToString();
					txt_PHETHOI.Text = _Rowview.Row[KetquathanhphamFields.Phethoi.Name].ToString();
					txt_PHECHINHMAY.Text = _Rowview.Row[KetquathanhphamFields.Phechinhmay.Name].ToString();
					txt_PHEKHAC.Text = _Rowview.Row[KetquathanhphamFields.Phekhac.Name].ToString();
					txt_TITRONGTUI.Text = _Rowview.Row[KetquathanhphamFields.Titrongtui.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquathanhphamFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquathanhphamFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquathanhphamFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquathanhphamFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUATHANHPHAM_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUATHANHPHAM_PK)
		{
			KetquathanhphamEntity _ketquathanhphamEntity = new KetquathanhphamEntity();
			
			_ketquathanhphamEntity.Id = txt_ID.Text.Trim();
			_ketquathanhphamEntity.Ngay = txt_NGAY.Text.Trim();
			_ketquathanhphamEntity.Ca = txt_CA.Text.Trim();
			_ketquathanhphamEntity.Mamay = txt_MAMAY.Text.Trim();
			_ketquathanhphamEntity.SoLsx = txt_SOLSX.Text.Trim();
			_ketquathanhphamEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_ketquathanhphamEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_ketquathanhphamEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_ketquathanhphamEntity.Tenmay = txt_TENMAY.Text.Trim();
			_ketquathanhphamEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_ketquathanhphamEntity.SoMetvao = txt_SOMETVAO.Text.Trim();
			_ketquathanhphamEntity.SoKgvao = txt_SOKGVAO.Text.Trim();
			_ketquathanhphamEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_ketquathanhphamEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_ketquathanhphamEntity.Thoigianchuanbi = txt_THOIGIANCHUANBI.Text.Trim();
			_ketquathanhphamEntity.Thoigianhacuon = txt_THOIGIANHACUON.Text.Trim();
			_ketquathanhphamEntity.Thoigiancatdau = txt_THOIGIANCATDAU.Text.Trim();
			_ketquathanhphamEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_ketquathanhphamEntity.Dgnangsuat = txt_DGNANGSUAT.Text.Trim();
			_ketquathanhphamEntity.Dmtui = txt_DMTUI.Text.Trim();
			_ketquathanhphamEntity.Ttetui = txt_TTETUI.Text.Trim();
			_ketquathanhphamEntity.Kiemtra = txt_KIEMTRA.Text.Trim();
			_ketquathanhphamEntity.Phein = txt_PHEIN.Text.Trim();
			_ketquathanhphamEntity.Pheghep = txt_PHEGHEP.Text.Trim();
			_ketquathanhphamEntity.Phechia = txt_PHECHIA.Text.Trim();
			_ketquathanhphamEntity.Phebien = txt_PHEBIEN.Text.Trim();
			_ketquathanhphamEntity.Phethoi = txt_PHETHOI.Text.Trim();
			_ketquathanhphamEntity.Phechinhmay = txt_PHECHINHMAY.Text.Trim();
			_ketquathanhphamEntity.Phekhac = txt_PHEKHAC.Text.Trim();
			_ketquathanhphamEntity.Titrongtui = txt_TITRONGTUI.Text.Trim();
			_ketquathanhphamEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_ketquathanhphamEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_ketquathanhphamEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_ketquathanhphamEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUATHANHPHAM_PK))
			{
				_str_KETQUATHANHPHAM_PK = _KetquathanhphamManager.InsertV2(_ketquathanhphamEntity, r_Insert, DT_KETQUATHANHPHAM, BS_KETQUATHANHPHAM);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathanhphamManager.Convert(_ketquathanhphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUATHANHPHAM.ResetCurrentItem();
			}
			else
			{
				_KetquathanhphamManager.Update(_ketquathanhphamEntity);
				
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Id.Name].Value = _ketquathanhphamEntity.Id;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ngay.Name].Value = _ketquathanhphamEntity.Ngay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ca.Name].Value = _ketquathanhphamEntity.Ca;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Mamay.Name].Value = _ketquathanhphamEntity.Mamay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.SoLsx.Name].Value = _ketquathanhphamEntity.SoLsx;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Masanpham.Name].Value = _ketquathanhphamEntity.Masanpham;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Macongnhan.Name].Value = _ketquathanhphamEntity.Macongnhan;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Tensanpham.Name].Value = _ketquathanhphamEntity.Tensanpham;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Tenmay.Name].Value = _ketquathanhphamEntity.Tenmay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Tencongnhan.Name].Value = _ketquathanhphamEntity.Tencongnhan;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.SoMetvao.Name].Value = _ketquathanhphamEntity.SoMetvao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.SoKgvao.Name].Value = _ketquathanhphamEntity.SoKgvao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianbatdau.Name].Value = _ketquathanhphamEntity.Thoigianbatdau;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianketthuc.Name].Value = _ketquathanhphamEntity.Thoigianketthuc;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianchuanbi.Name].Value = _ketquathanhphamEntity.Thoigianchuanbi;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianhacuon.Name].Value = _ketquathanhphamEntity.Thoigianhacuon;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigiancatdau.Name].Value = _ketquathanhphamEntity.Thoigiancatdau;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigiansuco.Name].Value = _ketquathanhphamEntity.Thoigiansuco;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Dgnangsuat.Name].Value = _ketquathanhphamEntity.Dgnangsuat;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Dmtui.Name].Value = _ketquathanhphamEntity.Dmtui;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ttetui.Name].Value = _ketquathanhphamEntity.Ttetui;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Kiemtra.Name].Value = _ketquathanhphamEntity.Kiemtra;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phein.Name].Value = _ketquathanhphamEntity.Phein;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Pheghep.Name].Value = _ketquathanhphamEntity.Pheghep;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phechia.Name].Value = _ketquathanhphamEntity.Phechia;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phebien.Name].Value = _ketquathanhphamEntity.Phebien;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phethoi.Name].Value = _ketquathanhphamEntity.Phethoi;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phechinhmay.Name].Value = _ketquathanhphamEntity.Phechinhmay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phekhac.Name].Value = _ketquathanhphamEntity.Phekhac;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Titrongtui.Name].Value = _ketquathanhphamEntity.Titrongtui;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ngaytao.Name].Value = _ketquathanhphamEntity.Ngaytao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Nguoitao.Name].Value = _ketquathanhphamEntity.Nguoitao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ngaysua.Name].Value = _ketquathanhphamEntity.Ngaysua;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Nguoisua.Name].Value = _ketquathanhphamEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathanhphamManager.Convert(_ketquathanhphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUATHANHPHAM_PK;
		}

	}
}
