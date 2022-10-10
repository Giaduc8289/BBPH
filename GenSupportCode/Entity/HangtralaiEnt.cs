
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.HangtralaiEnt
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
	public class HangtralaiEnt : HangtralaiEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HangtralaiEnt()
		{
			// Nothing for now.
		}

		void BS_Hangtralai_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_Hangtralai.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_Hangtralai.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
					
					txt_Id.Text = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
					txt_Sophieugiao.Text = _Rowview.Row[HangtralaiFields.Sophieugiao.Name].ToString();
					txt_Ngaygiao.Text = _Rowview.Row[HangtralaiFields.Ngaygiao.Name].ToString();
					txt_Madon.Text = _Rowview.Row[HangtralaiFields.Madon.Name].ToString();
					txt_Makhach.Text = _Rowview.Row[HangtralaiFields.Makhach.Name].ToString();
					txt_Tenkhach.Text = _Rowview.Row[HangtralaiFields.Tenkhach.Name].ToString();
					txt_Ngaydat.Text = _Rowview.Row[HangtralaiFields.Ngaydat.Name].ToString();
					txt_Masp.Text = _Rowview.Row[HangtralaiFields.Masp.Name].ToString();
					txt_Tenhang.Text = _Rowview.Row[HangtralaiFields.Tenhang.Name].ToString();
					txt_Soluonggiao.Text = _Rowview.Row[HangtralaiFields.Soluonggiao.Name].ToString();
					txt_Soluongtralai.Text = _Rowview.Row[HangtralaiFields.Soluongtralai.Name].ToString();
					txt_Ngaytra.Text = _Rowview.Row[HangtralaiFields.Ngaytra.Name].ToString();
					txt_Nguyennhan.Text = _Rowview.Row[HangtralaiFields.Nguyennhan.Name].ToString();
					txt_Ngaytao.Text = _Rowview.Row[HangtralaiFields.Ngaytao.Name].ToString();
					txt_Nguoitao.Text = _Rowview.Row[HangtralaiFields.Nguoitao.Name].ToString();
					txt_Ngaysua.Text = _Rowview.Row[HangtralaiFields.Ngaysua.Name].ToString();
					txt_Nguoisua.Text = _Rowview.Row[HangtralaiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_Hangtralai_CurrentChanged"); }
		}

		private string Save_Data(string _str_Hangtralai_PK)
		{
			HangtralaiEntity _hangtralaiEntity = new HangtralaiEntity();
			
			_hangtralaiEntity.Id = txt_Id.Text.Trim();
			_hangtralaiEntity.Sophieugiao = txt_Sophieugiao.Text.Trim();
			_hangtralaiEntity.Ngaygiao = txt_Ngaygiao.Text.Trim();
			_hangtralaiEntity.Madon = txt_Madon.Text.Trim();
			_hangtralaiEntity.Makhach = txt_Makhach.Text.Trim();
			_hangtralaiEntity.Tenkhach = txt_Tenkhach.Text.Trim();
			_hangtralaiEntity.Ngaydat = txt_Ngaydat.Text.Trim();
			_hangtralaiEntity.Masp = txt_Masp.Text.Trim();
			_hangtralaiEntity.Tenhang = txt_Tenhang.Text.Trim();
			_hangtralaiEntity.Soluonggiao = txt_Soluonggiao.Text.Trim();
			_hangtralaiEntity.Soluongtralai = txt_Soluongtralai.Text.Trim();
			_hangtralaiEntity.Ngaytra = txt_Ngaytra.Text.Trim();
			_hangtralaiEntity.Nguyennhan = txt_Nguyennhan.Text.Trim();
			_hangtralaiEntity.Ngaytao = txt_Ngaytao.Text.Trim();
			_hangtralaiEntity.Nguoitao = txt_Nguoitao.Text.Trim();
			_hangtralaiEntity.Ngaysua = txt_Ngaysua.Text.Trim();
			_hangtralaiEntity.Nguoisua = txt_Nguoisua.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DMBANSOI_PK))
			{
				_str_Hangtralai_PK = _HangtralaiManager.InsertV2(_HangtralaiEntity, r_Insert, DT_Hangtralai, BS_Hangtralai);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_hangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_Hangtralai.ResetCurrentItem();
			}
			else
			{
				_HangtralaiManager.Update(_hangtralaiEntity);
				
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Id.Name].Value = _hangtralaiEntity.Id;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Sophieugiao.Name].Value = _hangtralaiEntity.Sophieugiao;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Ngaygiao.Name].Value = _hangtralaiEntity.Ngaygiao;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Madon.Name].Value = _hangtralaiEntity.Madon;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Makhach.Name].Value = _hangtralaiEntity.Makhach;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Tenkhach.Name].Value = _hangtralaiEntity.Tenkhach;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Ngaydat.Name].Value = _hangtralaiEntity.Ngaydat;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Masp.Name].Value = _hangtralaiEntity.Masp;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Tenhang.Name].Value = _hangtralaiEntity.Tenhang;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Soluonggiao.Name].Value = _hangtralaiEntity.Soluonggiao;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Soluongtralai.Name].Value = _hangtralaiEntity.Soluongtralai;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Ngaytra.Name].Value = _hangtralaiEntity.Ngaytra;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Nguyennhan.Name].Value = _hangtralaiEntity.Nguyennhan;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Ngaytao.Name].Value = _hangtralaiEntity.Ngaytao;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Nguoitao.Name].Value = _hangtralaiEntity.Nguoitao;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Ngaysua.Name].Value = _hangtralaiEntity.Ngaysua;
				GRID_Hangtralai.CurrentRow.Cells[HangtralaiFields.Nguoisua.Name].Value = _hangtralaiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_hangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_Hangtralai_PK;
		}

	}
}
