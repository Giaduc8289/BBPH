


/*
'===============================================================================
'  GD.BBPH.BL.CautruccuahangManagerBase
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
using System.Windows.Forms;
namespace GD.BBPH.BLL
{
	public class CautruccuahangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tensp="Tensp";				
		
		public const String Field_Mangin="Mangin";				
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Tenmang="Tenmang";				
		
		public const String Field_Maloaikeo="Maloaikeo";				
		
		public const String Field_Tenloaikeo="Tenloaikeo";				
		
		public const String Field_Maloaidongran="Maloaidongran";				
		
		public const String Field_Tenloaidongran="Tenloaidongran";				
		
		public const String Field_Dinhmuckeokho="Dinhmuckeokho";				
		
		public const String Field_Dinhmucdongrankho="Dinhmucdongrankho";				
		
		public const String Field_Tylekeokho="Tylekeokho";				
		
		public const String Field_Tyledongrankho="Tyledongrankho";				
		
		public const String Field_Tylekeo="Tylekeo";				
		
		public const String Field_Tyledongran="Tyledongran";				
		
		public const String Field_Dinhmuckeouot="Dinhmuckeouot";				
		
		public const String Field_Dinhmucdongranuot="Dinhmucdongranuot";				
		
		public const String Field_Dinhmucdungmoi="Dinhmucdungmoi";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CautruccuahangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tensp,typeof(System.String));
			
			dt.Columns.Add(Field_Mangin,typeof(System.Boolean));
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang,typeof(System.String));
			
			dt.Columns.Add(Field_Maloaikeo,typeof(System.String));
			
			dt.Columns.Add(Field_Tenloaikeo,typeof(System.String));
			
			dt.Columns.Add(Field_Maloaidongran,typeof(System.String));
			
			dt.Columns.Add(Field_Tenloaidongran,typeof(System.String));
			
			dt.Columns.Add(Field_Dinhmuckeokho,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dinhmucdongrankho,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tylekeokho,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tyledongrankho,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tylekeo,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tyledongran,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dinhmuckeouot,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dinhmucdongranuot,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dinhmucdungmoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(CautruccuahangEntity _CautruccuahangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_CautruccuahangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_CautruccuahangEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_CautruccuahangEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_Mangin]=_CautruccuahangEntity.Mangin;
			}
			catch { }
			
			try
			{
				r[Field_Mamang]=_CautruccuahangEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_CautruccuahangEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Maloaikeo]=_CautruccuahangEntity.Maloaikeo;
			}
			catch { }
			
			try
			{
				r[Field_Tenloaikeo]=_CautruccuahangEntity.Tenloaikeo;
			}
			catch { }
			
			try
			{
				r[Field_Maloaidongran]=_CautruccuahangEntity.Maloaidongran;
			}
			catch { }
			
			try
			{
				r[Field_Tenloaidongran]=_CautruccuahangEntity.Tenloaidongran;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmuckeokho]=_CautruccuahangEntity.Dinhmuckeokho;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmucdongrankho]=_CautruccuahangEntity.Dinhmucdongrankho;
			}
			catch { }
			
			try
			{
				r[Field_Tylekeokho]=_CautruccuahangEntity.Tylekeokho;
			}
			catch { }
			
			try
			{
				r[Field_Tyledongrankho]=_CautruccuahangEntity.Tyledongrankho;
			}
			catch { }
			
			try
			{
				r[Field_Tylekeo]=_CautruccuahangEntity.Tylekeo;
			}
			catch { }
			
			try
			{
				r[Field_Tyledongran]=_CautruccuahangEntity.Tyledongran;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmuckeouot]=_CautruccuahangEntity.Dinhmuckeouot;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmucdongranuot]=_CautruccuahangEntity.Dinhmucdongranuot;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmucdungmoi]=_CautruccuahangEntity.Dinhmucdungmoi;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_CautruccuahangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_CautruccuahangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_CautruccuahangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_CautruccuahangEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public CautruccuahangEntity Convert(DataRow r)
		{	
			
			CautruccuahangEntity _CautruccuahangEntity=new CautruccuahangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_CautruccuahangEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Mangin= System.Boolean.Parse(r[Field_Mangin].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Mamang= r[Field_Mamang].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Maloaikeo= r[Field_Maloaikeo].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tenloaikeo= r[Field_Tenloaikeo].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Maloaidongran= r[Field_Maloaidongran].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tenloaidongran= r[Field_Tenloaidongran].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Dinhmuckeokho= System.Decimal.Parse(r[Field_Dinhmuckeokho].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Dinhmucdongrankho= System.Decimal.Parse(r[Field_Dinhmucdongrankho].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tylekeokho= System.Decimal.Parse(r[Field_Tylekeokho].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tyledongrankho= System.Decimal.Parse(r[Field_Tyledongrankho].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tylekeo= System.Decimal.Parse(r[Field_Tylekeo].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Tyledongran= System.Decimal.Parse(r[Field_Tyledongran].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Dinhmuckeouot= System.Decimal.Parse(r[Field_Dinhmuckeouot].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Dinhmucdongranuot= System.Decimal.Parse(r[Field_Dinhmucdongranuot].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Dinhmucdungmoi= System.Decimal.Parse(r[Field_Dinhmucdungmoi].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_CautruccuahangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _CautruccuahangEntity;
		}			
		
		public CautruccuahangEntity Convert_Entity(CautruccuahangEntity _CautruccuahangEntity,CautruccuahangEntity _CautruccuahangEntity_XML)
		{	
			
			
			_CautruccuahangEntity.Id= _CautruccuahangEntity_XML.Id;
			
			_CautruccuahangEntity.Masp= _CautruccuahangEntity_XML.Masp;
			
			_CautruccuahangEntity.Tensp= _CautruccuahangEntity_XML.Tensp;
			
			_CautruccuahangEntity.Mangin= _CautruccuahangEntity_XML.Mangin;
			
			_CautruccuahangEntity.Mamang= _CautruccuahangEntity_XML.Mamang;
			
			_CautruccuahangEntity.Tenmang= _CautruccuahangEntity_XML.Tenmang;
			
			_CautruccuahangEntity.Maloaikeo= _CautruccuahangEntity_XML.Maloaikeo;
			
			_CautruccuahangEntity.Tenloaikeo= _CautruccuahangEntity_XML.Tenloaikeo;
			
			_CautruccuahangEntity.Maloaidongran= _CautruccuahangEntity_XML.Maloaidongran;
			
			_CautruccuahangEntity.Tenloaidongran= _CautruccuahangEntity_XML.Tenloaidongran;
			
			_CautruccuahangEntity.Dinhmuckeokho= _CautruccuahangEntity_XML.Dinhmuckeokho;
			
			_CautruccuahangEntity.Dinhmucdongrankho= _CautruccuahangEntity_XML.Dinhmucdongrankho;
			
			_CautruccuahangEntity.Tylekeokho= _CautruccuahangEntity_XML.Tylekeokho;
			
			_CautruccuahangEntity.Tyledongrankho= _CautruccuahangEntity_XML.Tyledongrankho;
			
			_CautruccuahangEntity.Tylekeo= _CautruccuahangEntity_XML.Tylekeo;
			
			_CautruccuahangEntity.Tyledongran= _CautruccuahangEntity_XML.Tyledongran;
			
			_CautruccuahangEntity.Dinhmuckeouot= _CautruccuahangEntity_XML.Dinhmuckeouot;
			
			_CautruccuahangEntity.Dinhmucdongranuot= _CautruccuahangEntity_XML.Dinhmucdongranuot;
			
			_CautruccuahangEntity.Dinhmucdungmoi= _CautruccuahangEntity_XML.Dinhmucdungmoi;
			
			_CautruccuahangEntity.Ngaytao= _CautruccuahangEntity_XML.Ngaytao;
			
			_CautruccuahangEntity.Nguoitao= _CautruccuahangEntity_XML.Nguoitao;
			
			_CautruccuahangEntity.Ngaysua= _CautruccuahangEntity_XML.Ngaysua;
			
			_CautruccuahangEntity.Nguoisua= _CautruccuahangEntity_XML.Nguoisua;
									
				
			return _CautruccuahangEntity;
		}	
		
		public String InsertV2(CautruccuahangEntity _CautruccuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new CautruccuahangManagerBase()).Insert(_CautruccuahangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_CautruccuahangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Masp,_CautruccuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_CautruccuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mangin,_CautruccuahangEntity.Mangin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_CautruccuahangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_CautruccuahangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaikeo,_CautruccuahangEntity.Maloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaikeo,_CautruccuahangEntity.Tenloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaidongran,_CautruccuahangEntity.Maloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaidongran,_CautruccuahangEntity.Tenloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeokho,_CautruccuahangEntity.Dinhmuckeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongrankho,_CautruccuahangEntity.Dinhmucdongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeokho,_CautruccuahangEntity.Tylekeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongrankho,_CautruccuahangEntity.Tyledongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeo,_CautruccuahangEntity.Tylekeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongran,_CautruccuahangEntity.Tyledongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeouot,_CautruccuahangEntity.Dinhmuckeouot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongranuot,_CautruccuahangEntity.Dinhmucdongranuot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdungmoi,_CautruccuahangEntity.Dinhmucdungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_CautruccuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CautruccuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CautruccuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CautruccuahangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(CautruccuahangEntity _CautruccuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new CautruccuahangManagerBase()).Update(_CautruccuahangEntity);
			r.SetField(Field_Id,_CautruccuahangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Masp,_CautruccuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_CautruccuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mangin,_CautruccuahangEntity.Mangin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_CautruccuahangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_CautruccuahangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaikeo,_CautruccuahangEntity.Maloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaikeo,_CautruccuahangEntity.Tenloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaidongran,_CautruccuahangEntity.Maloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaidongran,_CautruccuahangEntity.Tenloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeokho,_CautruccuahangEntity.Dinhmuckeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongrankho,_CautruccuahangEntity.Dinhmucdongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeokho,_CautruccuahangEntity.Tylekeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongrankho,_CautruccuahangEntity.Tyledongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeo,_CautruccuahangEntity.Tylekeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongran,_CautruccuahangEntity.Tyledongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeouot,_CautruccuahangEntity.Dinhmuckeouot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongranuot,_CautruccuahangEntity.Dinhmucdongranuot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdungmoi,_CautruccuahangEntity.Dinhmucdungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_CautruccuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_CautruccuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_CautruccuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_CautruccuahangEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
		}

		public void InsertCollection(EntityCollection _Collection)
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntityCollection(_Collection);
			}
		}

		public CautruccuahangEntity Insert(CautruccuahangEntity CautruccuahangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(CautruccuahangEntity, true);
			}
			return CautruccuahangEntity;
		}

		public CautruccuahangEntity Insert(System.Int64  Id, System.String  Masp, System.String  Tensp, System.Boolean  Mangin, System.String  Mamang, System.String  Tenmang, System.String  Maloaikeo, System.String  Tenloaikeo, System.String  Maloaidongran, System.String  Tenloaidongran, System.Decimal  Dinhmuckeokho, System.Decimal  Dinhmucdongrankho, System.Decimal  Tylekeokho, System.Decimal  Tyledongrankho, System.Decimal  Tylekeo, System.Decimal  Tyledongran, System.Decimal  Dinhmuckeouot, System.Decimal  Dinhmucdongranuot, System.Decimal  Dinhmucdungmoi, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			CautruccuahangEntity _CautruccuahangEntity = new CautruccuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CautruccuahangEntity.Id = Id;
				
				_CautruccuahangEntity.Masp = Masp;
				
				_CautruccuahangEntity.Tensp = Tensp;
				
				_CautruccuahangEntity.Mangin = Mangin;
				
				_CautruccuahangEntity.Mamang = Mamang;
				
				_CautruccuahangEntity.Tenmang = Tenmang;
				
				_CautruccuahangEntity.Maloaikeo = Maloaikeo;
				
				_CautruccuahangEntity.Tenloaikeo = Tenloaikeo;
				
				_CautruccuahangEntity.Maloaidongran = Maloaidongran;
				
				_CautruccuahangEntity.Tenloaidongran = Tenloaidongran;
				
				_CautruccuahangEntity.Dinhmuckeokho = Dinhmuckeokho;
				
				_CautruccuahangEntity.Dinhmucdongrankho = Dinhmucdongrankho;
				
				_CautruccuahangEntity.Tylekeokho = Tylekeokho;
				
				_CautruccuahangEntity.Tyledongrankho = Tyledongrankho;
				
				_CautruccuahangEntity.Tylekeo = Tylekeo;
				
				_CautruccuahangEntity.Tyledongran = Tyledongran;
				
				_CautruccuahangEntity.Dinhmuckeouot = Dinhmuckeouot;
				
				_CautruccuahangEntity.Dinhmucdongranuot = Dinhmucdongranuot;
				
				_CautruccuahangEntity.Dinhmucdungmoi = Dinhmucdungmoi;
				
				_CautruccuahangEntity.Ngaytao = Ngaytao;
				
				_CautruccuahangEntity.Nguoitao = Nguoitao;
				
				_CautruccuahangEntity.Ngaysua = Ngaysua;
				
				_CautruccuahangEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_CautruccuahangEntity, true);
			}
			return _CautruccuahangEntity;
		}

		public CautruccuahangEntity Insert(System.String Masp, System.String Tensp, System.Boolean Mangin, System.String Mamang, System.String Tenmang, System.String Maloaikeo, System.String Tenloaikeo, System.String Maloaidongran, System.String Tenloaidongran, System.Decimal Dinhmuckeokho, System.Decimal Dinhmucdongrankho, System.Decimal Tylekeokho, System.Decimal Tyledongrankho, System.Decimal Tylekeo, System.Decimal Tyledongran, System.Decimal Dinhmuckeouot, System.Decimal Dinhmucdongranuot, System.Decimal Dinhmucdungmoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			CautruccuahangEntity _CautruccuahangEntity = new CautruccuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_CautruccuahangEntity.Masp = Masp;
				
				_CautruccuahangEntity.Tensp = Tensp;
				
				_CautruccuahangEntity.Mangin = Mangin;
				
				_CautruccuahangEntity.Mamang = Mamang;
				
				_CautruccuahangEntity.Tenmang = Tenmang;
				
				_CautruccuahangEntity.Maloaikeo = Maloaikeo;
				
				_CautruccuahangEntity.Tenloaikeo = Tenloaikeo;
				
				_CautruccuahangEntity.Maloaidongran = Maloaidongran;
				
				_CautruccuahangEntity.Tenloaidongran = Tenloaidongran;
				
				_CautruccuahangEntity.Dinhmuckeokho = Dinhmuckeokho;
				
				_CautruccuahangEntity.Dinhmucdongrankho = Dinhmucdongrankho;
				
				_CautruccuahangEntity.Tylekeokho = Tylekeokho;
				
				_CautruccuahangEntity.Tyledongrankho = Tyledongrankho;
				
				_CautruccuahangEntity.Tylekeo = Tylekeo;
				
				_CautruccuahangEntity.Tyledongran = Tyledongran;
				
				_CautruccuahangEntity.Dinhmuckeouot = Dinhmuckeouot;
				
				_CautruccuahangEntity.Dinhmucdongranuot = Dinhmucdongranuot;
				
				_CautruccuahangEntity.Dinhmucdungmoi = Dinhmucdungmoi;
				
				_CautruccuahangEntity.Ngaytao = Ngaytao;
				
				_CautruccuahangEntity.Nguoitao = Nguoitao;
				
				_CautruccuahangEntity.Ngaysua = Ngaysua;
				
				_CautruccuahangEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_CautruccuahangEntity, true);
			}
			return _CautruccuahangEntity;
		}

		public bool Update(CautruccuahangEntity _CautruccuahangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(CautruccuahangFields.Id == _CautruccuahangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CautruccuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CautruccuahangEntity _CautruccuahangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CautruccuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Masp, System.String Tensp, System.Boolean Mangin, System.String Mamang, System.String Tenmang, System.String Maloaikeo, System.String Tenloaikeo, System.String Maloaidongran, System.String Tenloaidongran, System.Decimal Dinhmuckeokho, System.Decimal Dinhmucdongrankho, System.Decimal Tylekeokho, System.Decimal Tyledongrankho, System.Decimal Tylekeo, System.Decimal Tyledongran, System.Decimal Dinhmuckeouot, System.Decimal Dinhmucdongranuot, System.Decimal Dinhmucdungmoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CautruccuahangEntity _CautruccuahangEntity = new CautruccuahangEntity(Id);
				if (adapter.FetchEntity(_CautruccuahangEntity))
				{
				
					
					
					_CautruccuahangEntity.Masp = Masp;
					
					_CautruccuahangEntity.Tensp = Tensp;
					
					_CautruccuahangEntity.Mangin = Mangin;
					
					_CautruccuahangEntity.Mamang = Mamang;
					
					_CautruccuahangEntity.Tenmang = Tenmang;
					
					_CautruccuahangEntity.Maloaikeo = Maloaikeo;
					
					_CautruccuahangEntity.Tenloaikeo = Tenloaikeo;
					
					_CautruccuahangEntity.Maloaidongran = Maloaidongran;
					
					_CautruccuahangEntity.Tenloaidongran = Tenloaidongran;
					
					_CautruccuahangEntity.Dinhmuckeokho = Dinhmuckeokho;
					
					_CautruccuahangEntity.Dinhmucdongrankho = Dinhmucdongrankho;
					
					_CautruccuahangEntity.Tylekeokho = Tylekeokho;
					
					_CautruccuahangEntity.Tyledongrankho = Tyledongrankho;
					
					_CautruccuahangEntity.Tylekeo = Tylekeo;
					
					_CautruccuahangEntity.Tyledongran = Tyledongran;
					
					_CautruccuahangEntity.Dinhmuckeouot = Dinhmuckeouot;
					
					_CautruccuahangEntity.Dinhmucdongranuot = Dinhmucdongranuot;
					
					_CautruccuahangEntity.Dinhmucdungmoi = Dinhmucdungmoi;
					
					_CautruccuahangEntity.Ngaytao = Ngaytao;
					
					_CautruccuahangEntity.Nguoitao = Nguoitao;
					
					_CautruccuahangEntity.Ngaysua = Ngaysua;
					
					_CautruccuahangEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_CautruccuahangEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.Int64 Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CautruccuahangEntity _CautruccuahangEntity = new CautruccuahangEntity(Id);
				if (adapter.FetchEntity(_CautruccuahangEntity))
				{
					adapter.DeleteEntity(_CautruccuahangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CautruccuahangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMangin(System.Boolean Mangin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Mangin == Mangin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaikeo(System.String Maloaikeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Maloaikeo == Maloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenloaikeo(System.String Tenloaikeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenloaikeo == Tenloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaidongran(System.String Maloaidongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Maloaidongran == Maloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenloaidongran(System.String Tenloaidongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenloaidongran == Tenloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmuckeokho(System.Decimal Dinhmuckeokho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmuckeokho == Dinhmuckeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmucdongrankho(System.Decimal Dinhmucdongrankho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdongrankho == Dinhmucdongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylekeokho(System.Decimal Tylekeokho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tylekeokho == Tylekeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTyledongrankho(System.Decimal Tyledongrankho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tyledongrankho == Tyledongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylekeo(System.Decimal Tylekeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tylekeo == Tylekeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTyledongran(System.Decimal Tyledongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tyledongran == Tyledongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmuckeouot(System.Decimal Dinhmuckeouot)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmuckeouot == Dinhmuckeouot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmucdongranuot(System.Decimal Dinhmucdongranuot)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdongranuot == Dinhmucdongranuot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmucdungmoi(System.Decimal Dinhmucdungmoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdungmoi == Dinhmucdungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CautruccuahangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public CautruccuahangEntity SelectOne(System.Int64 Id)
		{
			CautruccuahangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CautruccuahangEntity _CautruccuahangEntity = new CautruccuahangEntity(Id);
				if (adapter.FetchEntity(_CautruccuahangEntity))
				{
					toReturn = _CautruccuahangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection( new CautruccuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, null, 0, null);
			}
			return _CautruccuahangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMangin(System.Boolean Mangin)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Mangin == Mangin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByManginRDT(System.Boolean Mangin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Mangin == Mangin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaikeo(System.String Maloaikeo)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Maloaikeo == Maloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaikeoRDT(System.String Maloaikeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Maloaikeo == Maloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenloaikeo(System.String Tenloaikeo)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenloaikeo == Tenloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenloaikeoRDT(System.String Tenloaikeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenloaikeo == Tenloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaidongran(System.String Maloaidongran)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Maloaidongran == Maloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaidongranRDT(System.String Maloaidongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Maloaidongran == Maloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenloaidongran(System.String Tenloaidongran)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenloaidongran == Tenloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenloaidongranRDT(System.String Tenloaidongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tenloaidongran == Tenloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmuckeokho(System.Decimal Dinhmuckeokho)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmuckeokho == Dinhmuckeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmuckeokhoRDT(System.Decimal Dinhmuckeokho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmuckeokho == Dinhmuckeokho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmucdongrankho(System.Decimal Dinhmucdongrankho)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdongrankho == Dinhmucdongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmucdongrankhoRDT(System.Decimal Dinhmucdongrankho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdongrankho == Dinhmucdongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylekeokho(System.Decimal Tylekeokho)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tylekeokho == Tylekeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTylekeokhoRDT(System.Decimal Tylekeokho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tylekeokho == Tylekeokho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTyledongrankho(System.Decimal Tyledongrankho)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tyledongrankho == Tyledongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTyledongrankhoRDT(System.Decimal Tyledongrankho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tyledongrankho == Tyledongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylekeo(System.Decimal Tylekeo)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tylekeo == Tylekeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTylekeoRDT(System.Decimal Tylekeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tylekeo == Tylekeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTyledongran(System.Decimal Tyledongran)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tyledongran == Tyledongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTyledongranRDT(System.Decimal Tyledongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Tyledongran == Tyledongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmuckeouot(System.Decimal Dinhmuckeouot)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmuckeouot == Dinhmuckeouot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmuckeouotRDT(System.Decimal Dinhmuckeouot)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmuckeouot == Dinhmuckeouot);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmucdongranuot(System.Decimal Dinhmucdongranuot)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdongranuot == Dinhmucdongranuot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmucdongranuotRDT(System.Decimal Dinhmucdongranuot)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdongranuot == Dinhmucdongranuot);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmucdungmoi(System.Decimal Dinhmucdungmoi)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdungmoi == Dinhmucdungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmucdungmoiRDT(System.Decimal Dinhmucdungmoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Dinhmucdungmoi == Dinhmucdungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CautruccuahangCollection, filter, 0, null);
			}
			return _CautruccuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CautruccuahangCollection = new EntityCollection(new CautruccuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CautruccuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CautruccuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
