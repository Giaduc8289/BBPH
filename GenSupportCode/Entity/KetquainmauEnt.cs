
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.KetquainmauEnt
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
	public class KetquainmauEnt : KetquainmauEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquainmauEnt()
		{
			// Nothing for now.
		}

		void BS_KETQUAINMAU_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_KETQUAINMAU.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_KETQUAINMAU.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquainmauFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[KetquainmauFields.Id.Name].ToString();
					txt_KETQUAINID.Text = _Rowview.Row[KetquainmauFields.KetquainId.Name].ToString();
					txt_MASP.Text = _Rowview.Row[KetquainmauFields.Masp.Name].ToString();
					txt_TENSP.Text = _Rowview.Row[KetquainmauFields.Tensp.Name].ToString();
					txt_MAMAU.Text = _Rowview.Row[KetquainmauFields.Mamau.Name].ToString();
					txt_TENMAU.Text = _Rowview.Row[KetquainmauFields.Tenmau.Name].ToString();
					txt_XUATDODANG.Text = _Rowview.Row[KetquainmauFields.Xuatdodang.Name].ToString();
					txt_XUATNGUYEN.Text = _Rowview.Row[KetquainmauFields.Xuatnguyen.Name].ToString();
					txt_NHAPDODANG.Text = _Rowview.Row[KetquainmauFields.Nhapdodang.Name].ToString();
					txt_NHAPNGUYEN.Text = _Rowview.Row[KetquainmauFields.Nhapnguyen.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[KetquainmauFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[KetquainmauFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[KetquainmauFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[KetquainmauFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_KETQUAINMAU_CurrentChanged"); }
		}

		private string Save_Data(string _str_KETQUAINMAU_PK)
		{
			KetquainmauEntity _KetquainmauEntity = new KetquainmauEntity();
			
			_KetquainmauEntity.Id = txt_ID.Text.Trim();
			_KetquainmauEntity.KetquainId = txt_KETQUAINID.Text.Trim();
			_KetquainmauEntity.Masp = txt_MASP.Text.Trim();
			_KetquainmauEntity.Tensp = txt_TENSP.Text.Trim();
			_KetquainmauEntity.Mamau = txt_MAMAU.Text.Trim();
			_KetquainmauEntity.Tenmau = txt_TENMAU.Text.Trim();
			_KetquainmauEntity.Xuatdodang = txt_XUATDODANG.Text.Trim();
			_KetquainmauEntity.Xuatnguyen = txt_XUATNGUYEN.Text.Trim();
			_KetquainmauEntity.Nhapdodang = txt_NHAPDODANG.Text.Trim();
			_KetquainmauEntity.Nhapnguyen = txt_NHAPNGUYEN.Text.Trim();
			_KetquainmauEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_KetquainmauEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_KetquainmauEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_KetquainmauEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_KETQUAINMAU_PK))
			{
				_str_KETQUAINMAU_PK = _KetquainmauManager.InsertV2(_KetquainmauEntity, r_Insert, DT_KETQUAINMAU, BS_KETQUAINMAU);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainmauManager.Convert(_KetquainmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_KETQUAINMAU.ResetCurrentItem();
			}
			else
			{
				_KetquainmauManager.Update(_KetquainmauEntity);
				
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Id.Name].Value = _KetquainmauEntity.Id;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.KetquainId.Name].Value = _KetquainmauEntity.KetquainId;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Masp.Name].Value = _KetquainmauEntity.Masp;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Tensp.Name].Value = _KetquainmauEntity.Tensp;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Mamau.Name].Value = _KetquainmauEntity.Mamau;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Tenmau.Name].Value = _KetquainmauEntity.Tenmau;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Xuatdodang.Name].Value = _KetquainmauEntity.Xuatdodang;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Xuatnguyen.Name].Value = _KetquainmauEntity.Xuatnguyen;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Nhapdodang.Name].Value = _KetquainmauEntity.Nhapdodang;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Nhapnguyen.Name].Value = _KetquainmauEntity.Nhapnguyen;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Ngaytao.Name].Value = _KetquainmauEntity.Ngaytao;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Nguoitao.Name].Value = _KetquainmauEntity.Nguoitao;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Ngaysua.Name].Value = _KetquainmauEntity.Ngaysua;
				GRID_KETQUAINMAU.CurrentRow.Cells[KetquainmauFields.Nguoisua.Name].Value = _KetquainmauEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainmauManager.Convert(_KetquainmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_KETQUAINMAU_PK;
		}

	}
}
