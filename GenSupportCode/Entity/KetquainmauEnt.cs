
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

		void BS_Ketquainmau_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Ketquainmau.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Ketquainmau.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[KetquainmauFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[KetquainmauFields.Id.Name].ToString();
					txt_KetquainId.Text = _Rowview.Row[KetquainmauFields.KetquainId.Name].ToString();
					txt_Masp.Text = _Rowview.Row[KetquainmauFields.Masp.Name].ToString();
					txt_Tensp.Text = _Rowview.Row[KetquainmauFields.Tensp.Name].ToString();
					txt_Mamau.Text = _Rowview.Row[KetquainmauFields.Mamau.Name].ToString();
					txt_Tenmau.Text = _Rowview.Row[KetquainmauFields.Tenmau.Name].ToString();
					txt_Xuatdodang.Text = _Rowview.Row[KetquainmauFields.Xuatdodang.Name].ToString();
					txt_Xuatnguyen.Text = _Rowview.Row[KetquainmauFields.Xuatnguyen.Name].ToString();
					txt_Nhapdodang.Text = _Rowview.Row[KetquainmauFields.Nhapdodang.Name].ToString();
					txt_Nhapnguyen.Text = _Rowview.Row[KetquainmauFields.Nhapnguyen.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[KetquainmauFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[KetquainmauFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[KetquainmauFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[KetquainmauFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Ketquainmau_CurrentChanged"); }
		}

		private string Save_Data(string _str_Ketquainmau_PK)
		{
			KetquainmauEntity _ketquainmauEntity = new KetquainmauEntity();
			
			_ketquainmauEntity.Id = txt_Id.Text.Trim();
			_ketquainmauEntity.KetquainId = txt_KetquainId.Text.Trim();
			_ketquainmauEntity.Masp = txt_Masp.Text.Trim();
			_ketquainmauEntity.Tensp = txt_Tensp.Text.Trim();
			_ketquainmauEntity.Mamau = txt_Mamau.Text.Trim();
			_ketquainmauEntity.Tenmau = txt_Tenmau.Text.Trim();
			_ketquainmauEntity.Xuatdodang = txt_Xuatdodang.Text.Trim();
			_ketquainmauEntity.Xuatnguyen = txt_Xuatnguyen.Text.Trim();
			_ketquainmauEntity.Nhapdodang = txt_Nhapdodang.Text.Trim();
			_ketquainmauEntity.Nhapnguyen = txt_Nhapnguyen.Text.Trim();
			_ketquainmauEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_ketquainmauEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_ketquainmauEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_ketquainmauEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Ketquainmau_PK = _KetquainmauManager.InsertV2(_KetquainmauEntity, r_Insert, DT_Ketquainmau, BS_Ketquainmau);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainmauManager.Convert(_ketquainmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Ketquainmau.ResetCurrentItem();
			}
			else
			{
				_KetquainmauManager.Update(_ketquainmauEntity);
				
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Id.Name].Value = _ketquainmauEntity.Id;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.KetquainId.Name].Value = _ketquainmauEntity.KetquainId;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Masp.Name].Value = _ketquainmauEntity.Masp;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Tensp.Name].Value = _ketquainmauEntity.Tensp;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Mamau.Name].Value = _ketquainmauEntity.Mamau;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Tenmau.Name].Value = _ketquainmauEntity.Tenmau;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Xuatdodang.Name].Value = _ketquainmauEntity.Xuatdodang;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Xuatnguyen.Name].Value = _ketquainmauEntity.Xuatnguyen;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Nhapdodang.Name].Value = _ketquainmauEntity.Nhapdodang;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Nhapnguyen.Name].Value = _ketquainmauEntity.Nhapnguyen;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Ngaytao.Name].Value = _ketquainmauEntity.Ngaytao;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Nguoitao.Name].Value = _ketquainmauEntity.Nguoitao;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Ngaysua.Name].Value = _ketquainmauEntity.Ngaysua;
				GRID_Ketquainmau.CurrentRow.Cells[KetquainmauFields.Nguoisua.Name].Value = _ketquainmauEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_KetquainmauManager.Convert(_ketquainmauEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Ketquainmau_PK;
		}

	}
}
