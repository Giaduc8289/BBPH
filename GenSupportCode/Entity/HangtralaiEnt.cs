
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

		void BS_HANGTRALAI_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_HANGTRALAI.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_HANGTRALAI.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
					
					txt_ID.Text = _Rowview.Row[HangtralaiFields.Id.Name].ToString();
					txt_SOPHIEUGIAO.Text = _Rowview.Row[HangtralaiFields.Sophieugiao.Name].ToString();
					txt_NGAYGIAO.Text = _Rowview.Row[HangtralaiFields.Ngaygiao.Name].ToString();
					txt_MADON.Text = _Rowview.Row[HangtralaiFields.Madon.Name].ToString();
					txt_MAKHACH.Text = _Rowview.Row[HangtralaiFields.Makhach.Name].ToString();
					txt_TENKHACH.Text = _Rowview.Row[HangtralaiFields.Tenkhach.Name].ToString();
					txt_NGAYDAT.Text = _Rowview.Row[HangtralaiFields.Ngaydat.Name].ToString();
					txt_MASP.Text = _Rowview.Row[HangtralaiFields.Masp.Name].ToString();
					txt_TENHANG.Text = _Rowview.Row[HangtralaiFields.Tenhang.Name].ToString();
					txt_SOLUONGGIAO.Text = _Rowview.Row[HangtralaiFields.Soluonggiao.Name].ToString();
					txt_SOLUONGTRALAI.Text = _Rowview.Row[HangtralaiFields.Soluongtralai.Name].ToString();
					txt_NGAYTRA.Text = _Rowview.Row[HangtralaiFields.Ngaytra.Name].ToString();
					txt_NGUYENNHAN.Text = _Rowview.Row[HangtralaiFields.Nguyennhan.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[HangtralaiFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[HangtralaiFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[HangtralaiFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[HangtralaiFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_HANGTRALAI_CurrentChanged"); }
		}

		private string Save_Data(string _str_HANGTRALAI_PK)
		{
			HangtralaiEntity _hangtralaiEntity = new HangtralaiEntity();
			
			_hangtralaiEntity.Id = txt_ID.Text.Trim();
			_hangtralaiEntity.Sophieugiao = txt_SOPHIEUGIAO.Text.Trim();
			_hangtralaiEntity.Ngaygiao = txt_NGAYGIAO.Text.Trim();
			_hangtralaiEntity.Madon = txt_MADON.Text.Trim();
			_hangtralaiEntity.Makhach = txt_MAKHACH.Text.Trim();
			_hangtralaiEntity.Tenkhach = txt_TENKHACH.Text.Trim();
			_hangtralaiEntity.Ngaydat = txt_NGAYDAT.Text.Trim();
			_hangtralaiEntity.Masp = txt_MASP.Text.Trim();
			_hangtralaiEntity.Tenhang = txt_TENHANG.Text.Trim();
			_hangtralaiEntity.Soluonggiao = txt_SOLUONGGIAO.Text.Trim();
			_hangtralaiEntity.Soluongtralai = txt_SOLUONGTRALAI.Text.Trim();
			_hangtralaiEntity.Ngaytra = txt_NGAYTRA.Text.Trim();
			_hangtralaiEntity.Nguyennhan = txt_NGUYENNHAN.Text.Trim();
			_hangtralaiEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_hangtralaiEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_hangtralaiEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_hangtralaiEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_HANGTRALAI_PK))
			{
				_str_HANGTRALAI_PK = _HangtralaiManager.InsertV2(_hangtralaiEntity, r_Insert, DT_HANGTRALAI, BS_HANGTRALAI);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_hangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_HANGTRALAI.ResetCurrentItem();
			}
			else
			{
				_HangtralaiManager.Update(_hangtralaiEntity);
				
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Id.Name].Value = _hangtralaiEntity.Id;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Sophieugiao.Name].Value = _hangtralaiEntity.Sophieugiao;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaygiao.Name].Value = _hangtralaiEntity.Ngaygiao;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Madon.Name].Value = _hangtralaiEntity.Madon;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Makhach.Name].Value = _hangtralaiEntity.Makhach;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Tenkhach.Name].Value = _hangtralaiEntity.Tenkhach;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaydat.Name].Value = _hangtralaiEntity.Ngaydat;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Masp.Name].Value = _hangtralaiEntity.Masp;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Tenhang.Name].Value = _hangtralaiEntity.Tenhang;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Soluonggiao.Name].Value = _hangtralaiEntity.Soluonggiao;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Soluongtralai.Name].Value = _hangtralaiEntity.Soluongtralai;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaytra.Name].Value = _hangtralaiEntity.Ngaytra;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Nguyennhan.Name].Value = _hangtralaiEntity.Nguyennhan;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaytao.Name].Value = _hangtralaiEntity.Ngaytao;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Nguoitao.Name].Value = _hangtralaiEntity.Nguoitao;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Ngaysua.Name].Value = _hangtralaiEntity.Ngaysua;
				GRID_HANGTRALAI.CurrentRow.Cells[HangtralaiFields.Nguoisua.Name].Value = _hangtralaiEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_HangtralaiManager.Convert(_hangtralaiEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_HANGTRALAI_PK;
		}

	}
}
