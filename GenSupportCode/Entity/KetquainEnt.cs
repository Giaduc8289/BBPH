
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
					txt_TONGM2DM.Text = _Rowview.Row[KetquainFields.Tongm2dm.Name].ToString();
					txt_M2SAIHONGTT.Text = _Rowview.Row[KetquainFields.M2saihongtt.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquainFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquainFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquainFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquainFields.Nguoisua.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquainFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquainFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquainFields.Tencongnhan.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUAIN_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUAIN_PK)
		{
			KetquainEntity _ketquainEntity = new KetquainEntity();
			
			_ketquainEntity.Id = txt_ID.Text.Trim();
			_ketquainEntity.Ngay = txt_NGAY.Text.Trim();
			_ketquainEntity.Ca = txt_CA.Text.Trim();
			_ketquainEntity.Mamay = txt_MAMAY.Text.Trim();
			_ketquainEntity.Lenhin = txt_LENHIN.Text.Trim();
			_ketquainEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_ketquainEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_ketquainEntity.SometLsx = txt_SOMETLSX.Text.Trim();
			_ketquainEntity.Sometcap = txt_SOMETCAP.Text.Trim();
			_ketquainEntity.Sokgcap = txt_SOKGCAP.Text.Trim();
			_ketquainEntity.Thuctein = txt_THUCTEIN.Text.Trim();
			_ketquainEntity.Sokgin = txt_SOKGIN.Text.Trim();
			_ketquainEntity.Saihongthucte = txt_SAIHONGTHUCTE.Text.Trim();
			_ketquainEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_ketquainEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_ketquainEntity.Thoigianchuanbi = txt_THOIGIANCHUANBI.Text.Trim();
			_ketquainEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_ketquainEntity.PheNcc = txt_PHENCC.Text.Trim();
			_ketquainEntity.PheSx = txt_PHESX.Text.Trim();
			_ketquainEntity.Tongm2dm = txt_TONGM2DM.Text.Trim();
			_ketquainEntity.M2saihongtt = txt_M2SAIHONGTT.Text.Trim();
			_ketquainEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_ketquainEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_ketquainEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_ketquainEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_ketquainEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_ketquainEntity.Tenmay = txt_TENMAY.Text.Trim();
			_ketquainEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUAIN_PK))
			{
				_str_KETQUAIN_PK = _KetquainManager.InsertV2(_ketquainEntity, r_Insert, DT_KETQUAIN, BS_KETQUAIN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_ketquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUAIN.ResetCurrentItem();
			}
			else
			{
				_KetquainManager.Update(_ketquainEntity);
				
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Id.Name].Value = _ketquainEntity.Id;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngay.Name].Value = _ketquainEntity.Ngay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ca.Name].Value = _ketquainEntity.Ca;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Mamay.Name].Value = _ketquainEntity.Mamay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Lenhin.Name].Value = _ketquainEntity.Lenhin;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Masanpham.Name].Value = _ketquainEntity.Masanpham;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Macongnhan.Name].Value = _ketquainEntity.Macongnhan;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.SometLsx.Name].Value = _ketquainEntity.SometLsx;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sometcap.Name].Value = _ketquainEntity.Sometcap;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sokgcap.Name].Value = _ketquainEntity.Sokgcap;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thuctein.Name].Value = _ketquainEntity.Thuctein;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sokgin.Name].Value = _ketquainEntity.Sokgin;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Saihongthucte.Name].Value = _ketquainEntity.Saihongthucte;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianbatdau.Name].Value = _ketquainEntity.Thoigianbatdau;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianketthuc.Name].Value = _ketquainEntity.Thoigianketthuc;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianchuanbi.Name].Value = _ketquainEntity.Thoigianchuanbi;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigiansuco.Name].Value = _ketquainEntity.Thoigiansuco;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.PheNcc.Name].Value = _ketquainEntity.PheNcc;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.PheSx.Name].Value = _ketquainEntity.PheSx;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tongm2dm.Name].Value = _ketquainEntity.Tongm2dm;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.M2saihongtt.Name].Value = _ketquainEntity.M2saihongtt;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngaytao.Name].Value = _ketquainEntity.Ngaytao;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nguoitao.Name].Value = _ketquainEntity.Nguoitao;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngaysua.Name].Value = _ketquainEntity.Ngaysua;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nguoisua.Name].Value = _ketquainEntity.Nguoisua;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tensanpham.Name].Value = _ketquainEntity.Tensanpham;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tenmay.Name].Value = _ketquainEntity.Tenmay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tencongnhan.Name].Value = _ketquainEntity.Tencongnhan;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_ketquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUAIN_PK;
		}

	}
}
