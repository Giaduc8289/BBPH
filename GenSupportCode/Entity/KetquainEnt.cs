
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
					txt_NGAYTAO.Text = _Rowview.Row[KetquainFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquainFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquainFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquainFields.Nguoisua.Name].ToString();
					txt_TENSANPHAM.Text = _Rowview.Row[KetquainFields.Tensanpham.Name].ToString();
					txt_TENMAY.Text = _Rowview.Row[KetquainFields.Tenmay.Name].ToString();
					txt_TENCONGNHAN.Text = _Rowview.Row[KetquainFields.Tencongnhan.Name].ToString();
					txt_NANGSUAT.Text = _Rowview.Row[KetquainFields.Nangsuat.Name].ToString();
					txt_TYLESAIHONG.Text = _Rowview.Row[KetquainFields.Tylesaihong.Name].ToString();
					txt_TONGMDM.Text = _Rowview.Row[KetquainFields.Tongmdm.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUAIN_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUAIN_PK)
		{
			KetquainEntity _KetquainEntity = new KetquainEntity();
			
			_KetquainEntity.Id = txt_ID.Text.Trim();
			_KetquainEntity.Ngay = txt_NGAY.Text.Trim();
			_KetquainEntity.Ca = txt_CA.Text.Trim();
			_KetquainEntity.Mamay = txt_MAMAY.Text.Trim();
			_KetquainEntity.Lenhin = txt_LENHIN.Text.Trim();
			_KetquainEntity.Masanpham = txt_MASANPHAM.Text.Trim();
			_KetquainEntity.Macongnhan = txt_MACONGNHAN.Text.Trim();
			_KetquainEntity.SometLsx = txt_SOMETLSX.Text.Trim();
			_KetquainEntity.Sometcap = txt_SOMETCAP.Text.Trim();
			_KetquainEntity.Sokgcap = txt_SOKGCAP.Text.Trim();
			_KetquainEntity.Thuctein = txt_THUCTEIN.Text.Trim();
			_KetquainEntity.Sokgin = txt_SOKGIN.Text.Trim();
			_KetquainEntity.Saihongthucte = txt_SAIHONGTHUCTE.Text.Trim();
			_KetquainEntity.Thoigianbatdau = txt_THOIGIANBATDAU.Text.Trim();
			_KetquainEntity.Thoigianketthuc = txt_THOIGIANKETTHUC.Text.Trim();
			_KetquainEntity.Thoigianchuanbi = txt_THOIGIANCHUANBI.Text.Trim();
			_KetquainEntity.Thoigiansuco = txt_THOIGIANSUCO.Text.Trim();
			_KetquainEntity.PheNcc = txt_PHENCC.Text.Trim();
			_KetquainEntity.PheSx = txt_PHESX.Text.Trim();
			_KetquainEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_KetquainEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_KetquainEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_KetquainEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			_KetquainEntity.Tensanpham = txt_TENSANPHAM.Text.Trim();
			_KetquainEntity.Tenmay = txt_TENMAY.Text.Trim();
			_KetquainEntity.Tencongnhan = txt_TENCONGNHAN.Text.Trim();
			_KetquainEntity.Nangsuat = txt_NANGSUAT.Text.Trim();
			_KetquainEntity.Tylesaihong = txt_TYLESAIHONG.Text.Trim();
			_KetquainEntity.Tongmdm = txt_TONGMDM.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUAIN_PK))
			{
				_str_KETQUAIN_PK = _KetquainManager.InsertV2(_KetquainEntity, r_Insert, DT_KETQUAIN, BS_KETQUAIN);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUAIN.ResetCurrentItem();
			}
			else
			{
				_KetquainManager.Update(_KetquainEntity);
				
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Id.Name].Value = _KetquainEntity.Id;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngay.Name].Value = _KetquainEntity.Ngay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ca.Name].Value = _KetquainEntity.Ca;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Mamay.Name].Value = _KetquainEntity.Mamay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Lenhin.Name].Value = _KetquainEntity.Lenhin;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Masanpham.Name].Value = _KetquainEntity.Masanpham;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Macongnhan.Name].Value = _KetquainEntity.Macongnhan;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.SometLsx.Name].Value = _KetquainEntity.SometLsx;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sometcap.Name].Value = _KetquainEntity.Sometcap;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sokgcap.Name].Value = _KetquainEntity.Sokgcap;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thuctein.Name].Value = _KetquainEntity.Thuctein;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Sokgin.Name].Value = _KetquainEntity.Sokgin;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Saihongthucte.Name].Value = _KetquainEntity.Saihongthucte;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianbatdau.Name].Value = _KetquainEntity.Thoigianbatdau;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianketthuc.Name].Value = _KetquainEntity.Thoigianketthuc;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigianchuanbi.Name].Value = _KetquainEntity.Thoigianchuanbi;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Thoigiansuco.Name].Value = _KetquainEntity.Thoigiansuco;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.PheNcc.Name].Value = _KetquainEntity.PheNcc;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.PheSx.Name].Value = _KetquainEntity.PheSx;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngaytao.Name].Value = _KetquainEntity.Ngaytao;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nguoitao.Name].Value = _KetquainEntity.Nguoitao;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Ngaysua.Name].Value = _KetquainEntity.Ngaysua;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nguoisua.Name].Value = _KetquainEntity.Nguoisua;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tensanpham.Name].Value = _KetquainEntity.Tensanpham;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tenmay.Name].Value = _KetquainEntity.Tenmay;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tencongnhan.Name].Value = _KetquainEntity.Tencongnhan;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Nangsuat.Name].Value = _KetquainEntity.Nangsuat;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tylesaihong.Name].Value = _KetquainEntity.Tylesaihong;
				GRID_KETQUAIN.CurrentRow.Cells[KetquainFields.Tongmdm.Name].Value = _KetquainEntity.Tongmdm;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainManager.Convert(_KetquainEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUAIN_PK;
		}

	}
}
