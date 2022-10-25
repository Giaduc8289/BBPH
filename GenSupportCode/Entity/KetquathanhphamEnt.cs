
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
					txt_SOCON.Text = _Rowview.Row[KetquathanhphamFields.Socon.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUATHANHPHAM_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUATHANHPHAM_PK)
		{
			KetquathanhphamEntity _KetquathanhphamEntity = new KetquathanhphamEntity();
			
			_KetquathanhphamEntity.Id = txt_ID.Text.Trim();
			_KetquathanhphamEntity.Ngay = txt_NGAY.Text.Trim();
			_KetquathanhphamEntity.Ca = txt_CA.Text.Trim();
			_KetquathanhphamEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquathanhphamEntity.SoLsx = txt_SOLSX.Text.Trim();
			_KetquathanhphamEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquathanhphamEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquathanhphamEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquathanhphamEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquathanhphamEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_KetquathanhphamEntity.SoMetvao = txt_SOMETVAO.Text.Trim();
			_KetquathanhphamEntity.SoKgvao = txt_SOKGVAO.Text.Trim();
			_KetquathanhphamEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_KetquathanhphamEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_KetquathanhphamEntity.Thoigianchuanbi = txt_THOIGIANCHUANBI.Text.Trim();
			_KetquathanhphamEntity.Thoigianhacuon = txt_THOIGIANHACUON.Text.Trim();
			_KetquathanhphamEntity.Thoigiancatdau = txt_THOIGIANCATDAU.Text.Trim();
			_KetquathanhphamEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_KetquathanhphamEntity.Dgnangsuat = txt_DGNANGSUAT.Text.Trim();
			_KetquathanhphamEntity.Dmtui = txt_DMTUI.Text.Trim();
			_KetquathanhphamEntity.Ttetui = txt_TTETUI.Text.Trim();
			_KetquathanhphamEntity.Kiemtra = txt_KIEMTRA.Text.Trim();
			_KetquathanhphamEntity.Phein = txt_PHEIN.Text.Trim();
			_KetquathanhphamEntity.Pheghep = txt_PHEGHEP.Text.Trim();
			_KetquathanhphamEntity.Phechia = txt_PHECHIA.Text.Trim();
			_KetquathanhphamEntity.Phebien = txt_PHEBIEN.Text.Trim();
			_KetquathanhphamEntity.Phethoi = txt_PHETHOI.Text.Trim();
			_KetquathanhphamEntity.Phechinhmay = txt_PHECHINHMAY.Text.Trim();
			_KetquathanhphamEntity.Phekhac = txt_PHEKHAC.Text.Trim();
			_KetquathanhphamEntity.Titrongtui = txt_TITRONGTUI.Text.Trim();
			_KetquathanhphamEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_KetquathanhphamEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_KetquathanhphamEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_KetquathanhphamEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquathanhphamEntity.Socon = txt_SOCON.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUATHANHPHAM_PK))
			{
				_str_KETQUATHANHPHAM_PK = _KetquathanhphamManager.InsertV2(_KetquathanhphamEntity, r_Insert, DT_KETQUATHANHPHAM, BS_KETQUATHANHPHAM);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathanhphamManager.Convert(_KetquathanhphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUATHANHPHAM.ResetCurrentItem();
			}
			else
			{
				_KetquathanhphamManager.Update(_KetquathanhphamEntity);
				
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Id.Name].Value = _KetquathanhphamEntity.Id;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ngay.Name].Value = _KetquathanhphamEntity.Ngay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ca.Name].Value = _KetquathanhphamEntity.Ca;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Mamay.Name].Value = _KetquathanhphamEntity.Mamay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.SoLsx.Name].Value = _KetquathanhphamEntity.SoLsx;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Masanpham.Name].Value = _KetquathanhphamEntity.Masanpham;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Macongnhan.Name].Value = _KetquathanhphamEntity.Macongnhan;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Tensanpham.Name].Value = _KetquathanhphamEntity.Tensanpham;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Tenmay.Name].Value = _KetquathanhphamEntity.Tenmay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Tencongnhan.Name].Value = _KetquathanhphamEntity.Tencongnhan;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.SoMetvao.Name].Value = _KetquathanhphamEntity.SoMetvao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.SoKgvao.Name].Value = _KetquathanhphamEntity.SoKgvao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianbatdau.Name].Value = _KetquathanhphamEntity.Thoigianbatdau;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianketthuc.Name].Value = _KetquathanhphamEntity.Thoigianketthuc;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianchuanbi.Name].Value = _KetquathanhphamEntity.Thoigianchuanbi;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigianhacuon.Name].Value = _KetquathanhphamEntity.Thoigianhacuon;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigiancatdau.Name].Value = _KetquathanhphamEntity.Thoigiancatdau;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Thoigiansuco.Name].Value = _KetquathanhphamEntity.Thoigiansuco;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Dgnangsuat.Name].Value = _KetquathanhphamEntity.Dgnangsuat;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Dmtui.Name].Value = _KetquathanhphamEntity.Dmtui;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ttetui.Name].Value = _KetquathanhphamEntity.Ttetui;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Kiemtra.Name].Value = _KetquathanhphamEntity.Kiemtra;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phein.Name].Value = _KetquathanhphamEntity.Phein;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Pheghep.Name].Value = _KetquathanhphamEntity.Pheghep;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phechia.Name].Value = _KetquathanhphamEntity.Phechia;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phebien.Name].Value = _KetquathanhphamEntity.Phebien;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phethoi.Name].Value = _KetquathanhphamEntity.Phethoi;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phechinhmay.Name].Value = _KetquathanhphamEntity.Phechinhmay;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Phekhac.Name].Value = _KetquathanhphamEntity.Phekhac;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Titrongtui.Name].Value = _KetquathanhphamEntity.Titrongtui;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ngaytao.Name].Value = _KetquathanhphamEntity.Ngaytao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Nguoitao.Name].Value = _KetquathanhphamEntity.Nguoitao;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Ngaysua.Name].Value = _KetquathanhphamEntity.Ngaysua;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Nguoisua.Name].Value = _KetquathanhphamEntity.Nguoisua;
				GRID_KETQUATHANHPHAM.CurrentRow.Cells[KetquathanhphamFields.Socon.Name].Value = _KetquathanhphamEntity.Socon;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquathanhphamManager.Convert(_KetquathanhphamEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUATHANHPHAM_PK;
		}

	}
}
