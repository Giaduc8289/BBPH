
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

		void BS_Ketquain_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Ketquain.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Ketquain.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquainFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[KetquainFields.Id.Name].ToString();
					txt_Ngay.Text = _Rowview.Row[KetquainFields.Ngay.Name].ToString();
					txt_Ca.Text = _Rowview.Row[KetquainFields.Ca.Name].ToString();
					txt_Mamay.Text = _Rowview.Row[KetquainFields.Mamay.Name].ToString();
					txt_Lenhin.Text = _Rowview.Row[KetquainFields.Lenhin.Name].ToString();
					txt_Masanpham.Text = _Rowview.Row[KetquainFields.Masanpham.Name].ToString();
					txt_Macongnhan.Text = _Rowview.Row[KetquainFields.Macongnhan.Name].ToString();
					txt_SometLsx.Text = _Rowview.Row[KetquainFields.SometLsx.Name].ToString();
					txt_Sometcap.Text = _Rowview.Row[KetquainFields.Sometcap.Name].ToString();
					txt_Sokgcap.Text = _Rowview.Row[KetquainFields.Sokgcap.Name].ToString();
					txt_Thuctein.Text = _Rowview.Row[KetquainFields.Thuctein.Name].ToString();
					txt_Sokgin.Text = _Rowview.Row[KetquainFields.Sokgin.Name].ToString();
					txt_Saihongthucte.Text = _Rowview.Row[KetquainFields.Saihongthucte.Name].ToString();
					txt_Thoigianbatdau.Text = _Rowview.Row[KetquainFields.Thoigianbatdau.Name].ToString();
					txt_Thoigianketthuc.Text = _Rowview.Row[KetquainFields.Thoigianketthuc.Name].ToString();
					txt_Thoigianchuanbi.Text = _Rowview.Row[KetquainFields.Thoigianchuanbi.Name].ToString();
					txt_Thoigiansuco.Text = _Rowview.Row[KetquainFields.Thoigiansuco.Name].ToString();
					txt_PheNcc.Text = _Rowview.Row[KetquainFields.PheNcc.Name].ToString();
					txt_PheSx.Text = _Rowview.Row[KetquainFields.PheSx.Name].ToString();
					txt_Tongm2dm.Text = _Rowview.Row[KetquainFields.Tongm2dm.Name].ToString();
					txt_M2saihongtt.Text = _Rowview.Row[KetquainFields.M2saihongtt.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[KetquainFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[KetquainFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[KetquainFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[KetquainFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Ketquain_CurrentChanged"); }
		}

		private string Save_Data(string _str_Ketquain_PK)
		{
			KetquainEntity _ketquainEntity = new KetquainEntity();
			
			_ketquainEntity.Id = txt_Id.Text.Trim();
			_ketquainEntity.Ngay = txt_Ngay.Text.Trim();
			_ketquainEntity.Ca = txt_Ca.Text.Trim();
			_ketquainEntity.Mamay = txt_Mamay.Text.Trim();
			_ketquainEntity.Lenhin = txt_Lenhin.Text.Trim();
			_ketquainEntity.Masanpham = txt_Masanpham.Text.Trim();
			_ketquainEntity.Macongnhan = txt_Macongnhan.Text.Trim();
			_ketquainEntity.SometLsx = txt_SometLsx.Text.Trim();
			_ketquainEntity.Sometcap = txt_Sometcap.Text.Trim();
			_ketquainEntity.Sokgcap = txt_Sokgcap.Text.Trim();
			_ketquainEntity.Thuctein = txt_Thuctein.Text.Trim();
			_ketquainEntity.Sokgin = txt_Sokgin.Text.Trim();
			_ketquainEntity.Saihongthucte = txt_Saihongthucte.Text.Trim();
			_ketquainEntity.Thoigianbatdau = txt_Thoigianbatdau.Text.Trim();
			_ketquainEntity.Thoigianketthuc = txt_Thoigianketthuc.Text.Trim();
			_ketquainEntity.Thoigianchuanbi = txt_Thoigianchuanbi.Text.Trim();
			_ketquainEntity.Thoigiansuco = txt_Thoigiansuco.Text.Trim();
			_ketquainEntity.PheNcc = txt_PheNcc.Text.Trim();
			_ketquainEntity.PheSx = txt_PheSx.Text.Trim();
			_ketquainEntity.Tongm2dm = txt_Tongm2dm.Text.Trim();
			_ketquainEntity.M2saihongtt = txt_M2saihongtt.Text.Trim();
			_ketquainEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_ketquainEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_ketquainEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_ketquainEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Ketquain_PK = _KetquainManager.InsertV2(_KetquainEntity, r_Insert, DT_Ketquain, BS_Ketquain);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_ketquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Ketquain.ResetCurrentItem();
			}
			else
			{
				_KetquainManager.Update(_ketquainEntity);
				
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Id.Name].Value = _ketquainEntity.Id;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Ngay.Name].Value = _ketquainEntity.Ngay;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Ca.Name].Value = _ketquainEntity.Ca;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Mamay.Name].Value = _ketquainEntity.Mamay;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Lenhin.Name].Value = _ketquainEntity.Lenhin;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Masanpham.Name].Value = _ketquainEntity.Masanpham;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Macongnhan.Name].Value = _ketquainEntity.Macongnhan;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.SometLsx.Name].Value = _ketquainEntity.SometLsx;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Sometcap.Name].Value = _ketquainEntity.Sometcap;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Sokgcap.Name].Value = _ketquainEntity.Sokgcap;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Thuctein.Name].Value = _ketquainEntity.Thuctein;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Sokgin.Name].Value = _ketquainEntity.Sokgin;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Saihongthucte.Name].Value = _ketquainEntity.Saihongthucte;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Thoigianbatdau.Name].Value = _ketquainEntity.Thoigianbatdau;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Thoigianketthuc.Name].Value = _ketquainEntity.Thoigianketthuc;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Thoigianchuanbi.Name].Value = _ketquainEntity.Thoigianchuanbi;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Thoigiansuco.Name].Value = _ketquainEntity.Thoigiansuco;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.PheNcc.Name].Value = _ketquainEntity.PheNcc;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.PheSx.Name].Value = _ketquainEntity.PheSx;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Tongm2dm.Name].Value = _ketquainEntity.Tongm2dm;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.M2saihongtt.Name].Value = _ketquainEntity.M2saihongtt;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Ngaytao.Name].Value = _ketquainEntity.Ngaytao;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Nguoitao.Name].Value = _ketquainEntity.Nguoitao;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Ngaysua.Name].Value = _ketquainEntity.Ngaysua;
				GRID_Ketquain.CurrentRow.Cells[KetquainFields.Nguoisua.Name].Value = _ketquainEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_ketquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Ketquain_PK;
		}

	}
}
