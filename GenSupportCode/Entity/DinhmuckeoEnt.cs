
/*
'===============================================================================
'  GD.BBPH.DAL.EntityClasses.DinhmuckeoEnt
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
	public class DinhmuckeoEnt : DinhmuckeoEntity
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmuckeoEnt()
		{
			// Nothing for now.
		}

		void BS_DINHMUCKEO_CurrentChanged(object sender, EventArgs e)
		{
			try
			{
				GD.BBPH.LIB.FORM_PROCESS_UTIL.clearControls(uiPanel1Container, GD.BBPH.LIB.FORM_PROCESS_UTIL.getAllControl(uiPanel1Container));
				if (BS_DINHMUCKEO.Current != null)
				{
					DataRowView _Rowview = (DataRowView)this.BS_DINHMUCKEO.Current;
					if (_Rowview != null)
						MAHIEU_PK = _Rowview.Row[DinhmuckeoFields.Madinhmuc.Name].ToString();
					
					txt_MADINHMUC.Text = _Rowview.Row[DinhmuckeoFields.Madinhmuc.Name].ToString();
					txt_TENDINHMUC.Text = _Rowview.Row[DinhmuckeoFields.Tendinhmuc.Name].ToString();
					txt_TENRUTGON.Text = _Rowview.Row[DinhmuckeoFields.Tenrutgon.Name].ToString();
					txt_MAKEO.Text = _Rowview.Row[DinhmuckeoFields.Makeo.Name].ToString();
					txt_TENKEO.Text = _Rowview.Row[DinhmuckeoFields.Tenkeo.Name].ToString();
					txt_MADONGRAN.Text = _Rowview.Row[DinhmuckeoFields.Madongran.Name].ToString();
					txt_TENDONGRAN.Text = _Rowview.Row[DinhmuckeoFields.Tendongran.Name].ToString();
					txt_HAMLUONGKEO.Text = _Rowview.Row[DinhmuckeoFields.Hamluongkeo.Name].ToString();
					txt_HAMLUONGDONGRAN.Text = _Rowview.Row[DinhmuckeoFields.Hamluongdongran.Name].ToString();
					txt_TYLEPHAKEO.Text = _Rowview.Row[DinhmuckeoFields.Tylephakeo.Name].ToString();
					txt_TYLEPHADONGRAN.Text = _Rowview.Row[DinhmuckeoFields.Tylephadongran.Name].ToString();
					txt_DUNGMOI.Text = _Rowview.Row[DinhmuckeoFields.Dungmoi.Name].ToString();
					txt_NGAYTAO.Text = _Rowview.Row[DinhmuckeoFields.Ngaytao.Name].ToString();
					txt_NGUOITAO.Text = _Rowview.Row[DinhmuckeoFields.Nguoitao.Name].ToString();
					txt_NGAYSUA.Text = _Rowview.Row[DinhmuckeoFields.Ngaysua.Name].ToString();
					txt_NGUOISUA.Text = _Rowview.Row[DinhmuckeoFields.Nguoisua.Name].ToString();
				}
			}
			catch (Exception ex) { MessageBox.Show(ex.Message, "BS_DINHMUCKEO_CurrentChanged"); }
		}

		private string Save_Data(string _str_DINHMUCKEO_PK)
		{
			DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity();
			
			_DinhmuckeoEntity.Madinhmuc = txt_MADINHMUC.Text.Trim();
			_DinhmuckeoEntity.Tendinhmuc = txt_TENDINHMUC.Text.Trim();
			_DinhmuckeoEntity.Tenrutgon = txt_TENRUTGON.Text.Trim();
			_DinhmuckeoEntity.Makeo = txt_MAKEO.Text.Trim();
			_DinhmuckeoEntity.Tenkeo = txt_TENKEO.Text.Trim();
			_DinhmuckeoEntity.Madongran = txt_MADONGRAN.Text.Trim();
			_DinhmuckeoEntity.Tendongran = txt_TENDONGRAN.Text.Trim();
			_DinhmuckeoEntity.Hamluongkeo = txt_HAMLUONGKEO.Text.Trim();
			_DinhmuckeoEntity.Hamluongdongran = txt_HAMLUONGDONGRAN.Text.Trim();
			_DinhmuckeoEntity.Tylephakeo = txt_TYLEPHAKEO.Text.Trim();
			_DinhmuckeoEntity.Tylephadongran = txt_TYLEPHADONGRAN.Text.Trim();
			_DinhmuckeoEntity.Dungmoi = txt_DUNGMOI.Text.Trim();
			_DinhmuckeoEntity.Ngaytao = txt_NGAYTAO.Text.Trim();
			_DinhmuckeoEntity.Nguoitao = txt_NGUOITAO.Text.Trim();
			_DinhmuckeoEntity.Ngaysua = txt_NGAYSUA.Text.Trim();
			_DinhmuckeoEntity.Nguoisua = txt_NGUOISUA.Text.Trim();
			
			if (string.IsNullOrEmpty(_str_DINHMUCKEO_PK))
			{
				_str_DINHMUCKEO_PK = _DinhmuckeoManager.InsertV2(_DinhmuckeoEntity, r_Insert, DT_DINHMUCKEO, BS_DINHMUCKEO);
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmuckeoManager.Convert(_DinhmuckeoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_INSERT, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
				BS_DINHMUCKEO.ResetCurrentItem();
			}
			else
			{
				_DinhmuckeoManager.Update(_DinhmuckeoEntity);
				
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Madinhmuc.Name].Value = _DinhmuckeoEntity.Madinhmuc;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tendinhmuc.Name].Value = _DinhmuckeoEntity.Tendinhmuc;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tenrutgon.Name].Value = _DinhmuckeoEntity.Tenrutgon;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Makeo.Name].Value = _DinhmuckeoEntity.Makeo;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tenkeo.Name].Value = _DinhmuckeoEntity.Tenkeo;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Madongran.Name].Value = _DinhmuckeoEntity.Madongran;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tendongran.Name].Value = _DinhmuckeoEntity.Tendongran;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Hamluongkeo.Name].Value = _DinhmuckeoEntity.Hamluongkeo;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Hamluongdongran.Name].Value = _DinhmuckeoEntity.Hamluongdongran;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tylephakeo.Name].Value = _DinhmuckeoEntity.Tylephakeo;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Tylephadongran.Name].Value = _DinhmuckeoEntity.Tylephadongran;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Dungmoi.Name].Value = _DinhmuckeoEntity.Dungmoi;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Ngaytao.Name].Value = _DinhmuckeoEntity.Ngaytao;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Nguoitao.Name].Value = _DinhmuckeoEntity.Nguoitao;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Ngaysua.Name].Value = _DinhmuckeoEntity.Ngaysua;
				GRID_DINHMUCKEO.CurrentRow.Cells[DinhmuckeoFields.Nguoisua.Name].Value = _DinhmuckeoEntity.Nguoisua;
				GD.BBPH.BLL.MenuroleManager.set_Enable_controls(_DinhmuckeoManager.Convert(_DinhmuckeoEntity), GD.BBPH.LIB.BUTTONACTION.BUTTONACTION_UPDATE, _MenuroleEntity, ref btn_THEMMOI, ref btn_SUA, ref btn_LUULAI, ref btn_XOA, ref btn_KHOIPHUC);
			}
			return _str_DINHMUCKEO_PK;
		}

	}
}
