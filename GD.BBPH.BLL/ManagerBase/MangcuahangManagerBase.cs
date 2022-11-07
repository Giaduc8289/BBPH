


/*
'===============================================================================
'  GD.BBPH.BL.MangcuahangManagerBase
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
	public class MangcuahangManagerBase
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
		
		public const String Field_Doday="Doday";				
		
		public const String Field_Maloaimang="Maloaimang";				
		
		public const String Field_Tenloaimang="Tenloaimang";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MangcuahangManagerBase()
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
			
			dt.Columns.Add(Field_Doday,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Maloaimang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenloaimang,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(MangcuahangEntity _MangcuahangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_MangcuahangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_MangcuahangEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_MangcuahangEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_Mangin]=_MangcuahangEntity.Mangin;
			}
			catch { }
			
			try
			{
				r[Field_Mamang]=_MangcuahangEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_MangcuahangEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Maloaikeo]=_MangcuahangEntity.Maloaikeo;
			}
			catch { }
			
			try
			{
				r[Field_Tenloaikeo]=_MangcuahangEntity.Tenloaikeo;
			}
			catch { }
			
			try
			{
				r[Field_Maloaidongran]=_MangcuahangEntity.Maloaidongran;
			}
			catch { }
			
			try
			{
				r[Field_Tenloaidongran]=_MangcuahangEntity.Tenloaidongran;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmuckeokho]=_MangcuahangEntity.Dinhmuckeokho;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmucdongrankho]=_MangcuahangEntity.Dinhmucdongrankho;
			}
			catch { }
			
			try
			{
				r[Field_Tylekeokho]=_MangcuahangEntity.Tylekeokho;
			}
			catch { }
			
			try
			{
				r[Field_Tyledongrankho]=_MangcuahangEntity.Tyledongrankho;
			}
			catch { }
			
			try
			{
				r[Field_Tylekeo]=_MangcuahangEntity.Tylekeo;
			}
			catch { }
			
			try
			{
				r[Field_Tyledongran]=_MangcuahangEntity.Tyledongran;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmuckeouot]=_MangcuahangEntity.Dinhmuckeouot;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmucdongranuot]=_MangcuahangEntity.Dinhmucdongranuot;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmucdungmoi]=_MangcuahangEntity.Dinhmucdungmoi;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_MangcuahangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_MangcuahangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_MangcuahangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_MangcuahangEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Doday]=_MangcuahangEntity.Doday;
			}
			catch { }
			
			try
			{
				r[Field_Maloaimang]=_MangcuahangEntity.Maloaimang;
			}
			catch { }
			
			try
			{
				r[Field_Tenloaimang]=_MangcuahangEntity.Tenloaimang;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public MangcuahangEntity Convert(DataRow r)
		{	
			
			MangcuahangEntity _MangcuahangEntity=new MangcuahangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_MangcuahangEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Mangin= System.Boolean.Parse(r[Field_Mangin].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Mamang= r[Field_Mamang].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Maloaikeo= r[Field_Maloaikeo].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tenloaikeo= r[Field_Tenloaikeo].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Maloaidongran= r[Field_Maloaidongran].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tenloaidongran= r[Field_Tenloaidongran].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Dinhmuckeokho= System.Decimal.Parse(r[Field_Dinhmuckeokho].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Dinhmucdongrankho= System.Decimal.Parse(r[Field_Dinhmucdongrankho].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tylekeokho= System.Decimal.Parse(r[Field_Tylekeokho].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tyledongrankho= System.Decimal.Parse(r[Field_Tyledongrankho].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tylekeo= System.Decimal.Parse(r[Field_Tylekeo].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tyledongran= System.Decimal.Parse(r[Field_Tyledongran].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Dinhmuckeouot= System.Decimal.Parse(r[Field_Dinhmuckeouot].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Dinhmucdongranuot= System.Decimal.Parse(r[Field_Dinhmucdongranuot].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Dinhmucdungmoi= System.Decimal.Parse(r[Field_Dinhmucdungmoi].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Doday= System.Decimal.Parse(r[Field_Doday].ToString());						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Maloaimang= r[Field_Maloaimang].ToString();						
			}
			catch { }
			
			try
			{
				_MangcuahangEntity.Tenloaimang= r[Field_Tenloaimang].ToString();						
			}
			catch { }
									
									
			return _MangcuahangEntity;
		}			
		
		public MangcuahangEntity Convert_Entity(MangcuahangEntity _MangcuahangEntity,MangcuahangEntity _MangcuahangEntity_XML)
		{	
			
			
			_MangcuahangEntity.Id= _MangcuahangEntity_XML.Id;
			
			_MangcuahangEntity.Masp= _MangcuahangEntity_XML.Masp;
			
			_MangcuahangEntity.Tensp= _MangcuahangEntity_XML.Tensp;
			
			_MangcuahangEntity.Mangin= _MangcuahangEntity_XML.Mangin;
			
			_MangcuahangEntity.Mamang= _MangcuahangEntity_XML.Mamang;
			
			_MangcuahangEntity.Tenmang= _MangcuahangEntity_XML.Tenmang;
			
			_MangcuahangEntity.Maloaikeo= _MangcuahangEntity_XML.Maloaikeo;
			
			_MangcuahangEntity.Tenloaikeo= _MangcuahangEntity_XML.Tenloaikeo;
			
			_MangcuahangEntity.Maloaidongran= _MangcuahangEntity_XML.Maloaidongran;
			
			_MangcuahangEntity.Tenloaidongran= _MangcuahangEntity_XML.Tenloaidongran;
			
			_MangcuahangEntity.Dinhmuckeokho= _MangcuahangEntity_XML.Dinhmuckeokho;
			
			_MangcuahangEntity.Dinhmucdongrankho= _MangcuahangEntity_XML.Dinhmucdongrankho;
			
			_MangcuahangEntity.Tylekeokho= _MangcuahangEntity_XML.Tylekeokho;
			
			_MangcuahangEntity.Tyledongrankho= _MangcuahangEntity_XML.Tyledongrankho;
			
			_MangcuahangEntity.Tylekeo= _MangcuahangEntity_XML.Tylekeo;
			
			_MangcuahangEntity.Tyledongran= _MangcuahangEntity_XML.Tyledongran;
			
			_MangcuahangEntity.Dinhmuckeouot= _MangcuahangEntity_XML.Dinhmuckeouot;
			
			_MangcuahangEntity.Dinhmucdongranuot= _MangcuahangEntity_XML.Dinhmucdongranuot;
			
			_MangcuahangEntity.Dinhmucdungmoi= _MangcuahangEntity_XML.Dinhmucdungmoi;
			
			_MangcuahangEntity.Ngaytao= _MangcuahangEntity_XML.Ngaytao;
			
			_MangcuahangEntity.Nguoitao= _MangcuahangEntity_XML.Nguoitao;
			
			_MangcuahangEntity.Ngaysua= _MangcuahangEntity_XML.Ngaysua;
			
			_MangcuahangEntity.Nguoisua= _MangcuahangEntity_XML.Nguoisua;
			
			_MangcuahangEntity.Doday= _MangcuahangEntity_XML.Doday;
			
			_MangcuahangEntity.Maloaimang= _MangcuahangEntity_XML.Maloaimang;
			
			_MangcuahangEntity.Tenloaimang= _MangcuahangEntity_XML.Tenloaimang;
									
				
			return _MangcuahangEntity;
		}	
		
		public String InsertV2(MangcuahangEntity _MangcuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new MangcuahangManagerBase()).Insert(_MangcuahangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_MangcuahangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Masp,_MangcuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_MangcuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mangin,_MangcuahangEntity.Mangin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_MangcuahangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_MangcuahangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaikeo,_MangcuahangEntity.Maloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaikeo,_MangcuahangEntity.Tenloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaidongran,_MangcuahangEntity.Maloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaidongran,_MangcuahangEntity.Tenloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeokho,_MangcuahangEntity.Dinhmuckeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongrankho,_MangcuahangEntity.Dinhmucdongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeokho,_MangcuahangEntity.Tylekeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongrankho,_MangcuahangEntity.Tyledongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeo,_MangcuahangEntity.Tylekeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongran,_MangcuahangEntity.Tyledongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeouot,_MangcuahangEntity.Dinhmuckeouot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongranuot,_MangcuahangEntity.Dinhmucdongranuot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdungmoi,_MangcuahangEntity.Dinhmucdungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_MangcuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_MangcuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_MangcuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_MangcuahangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doday,_MangcuahangEntity.Doday);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimang,_MangcuahangEntity.Maloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaimang,_MangcuahangEntity.Tenloaimang);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(MangcuahangEntity _MangcuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new MangcuahangManagerBase()).Update(_MangcuahangEntity);
			r.SetField(Field_Id,_MangcuahangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Masp,_MangcuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_MangcuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mangin,_MangcuahangEntity.Mangin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang,_MangcuahangEntity.Mamang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang,_MangcuahangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaikeo,_MangcuahangEntity.Maloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaikeo,_MangcuahangEntity.Tenloaikeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaidongran,_MangcuahangEntity.Maloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaidongran,_MangcuahangEntity.Tenloaidongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeokho,_MangcuahangEntity.Dinhmuckeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongrankho,_MangcuahangEntity.Dinhmucdongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeokho,_MangcuahangEntity.Tylekeokho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongrankho,_MangcuahangEntity.Tyledongrankho);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylekeo,_MangcuahangEntity.Tylekeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyledongran,_MangcuahangEntity.Tyledongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuckeouot,_MangcuahangEntity.Dinhmuckeouot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdongranuot,_MangcuahangEntity.Dinhmucdongranuot);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmucdungmoi,_MangcuahangEntity.Dinhmucdungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_MangcuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_MangcuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_MangcuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_MangcuahangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doday,_MangcuahangEntity.Doday);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimang,_MangcuahangEntity.Maloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaimang,_MangcuahangEntity.Tenloaimang);
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

		public MangcuahangEntity Insert(MangcuahangEntity MangcuahangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(MangcuahangEntity, true);
			}
			return MangcuahangEntity;
		}

		public MangcuahangEntity Insert(System.Int64  Id, System.String  Masp, System.String  Tensp, System.Boolean  Mangin, System.String  Mamang, System.String  Tenmang, System.String  Maloaikeo, System.String  Tenloaikeo, System.String  Maloaidongran, System.String  Tenloaidongran, System.Decimal  Dinhmuckeokho, System.Decimal  Dinhmucdongrankho, System.Decimal  Tylekeokho, System.Decimal  Tyledongrankho, System.Decimal  Tylekeo, System.Decimal  Tyledongran, System.Decimal  Dinhmuckeouot, System.Decimal  Dinhmucdongranuot, System.Decimal  Dinhmucdungmoi, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Doday, System.String  Maloaimang, System.String  Tenloaimang)
		{
			MangcuahangEntity _MangcuahangEntity = new MangcuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MangcuahangEntity.Id = Id;
				
				_MangcuahangEntity.Masp = Masp;
				
				_MangcuahangEntity.Tensp = Tensp;
				
				_MangcuahangEntity.Mangin = Mangin;
				
				_MangcuahangEntity.Mamang = Mamang;
				
				_MangcuahangEntity.Tenmang = Tenmang;
				
				_MangcuahangEntity.Maloaikeo = Maloaikeo;
				
				_MangcuahangEntity.Tenloaikeo = Tenloaikeo;
				
				_MangcuahangEntity.Maloaidongran = Maloaidongran;
				
				_MangcuahangEntity.Tenloaidongran = Tenloaidongran;
				
				_MangcuahangEntity.Dinhmuckeokho = Dinhmuckeokho;
				
				_MangcuahangEntity.Dinhmucdongrankho = Dinhmucdongrankho;
				
				_MangcuahangEntity.Tylekeokho = Tylekeokho;
				
				_MangcuahangEntity.Tyledongrankho = Tyledongrankho;
				
				_MangcuahangEntity.Tylekeo = Tylekeo;
				
				_MangcuahangEntity.Tyledongran = Tyledongran;
				
				_MangcuahangEntity.Dinhmuckeouot = Dinhmuckeouot;
				
				_MangcuahangEntity.Dinhmucdongranuot = Dinhmucdongranuot;
				
				_MangcuahangEntity.Dinhmucdungmoi = Dinhmucdungmoi;
				
				_MangcuahangEntity.Ngaytao = Ngaytao;
				
				_MangcuahangEntity.Nguoitao = Nguoitao;
				
				_MangcuahangEntity.Ngaysua = Ngaysua;
				
				_MangcuahangEntity.Nguoisua = Nguoisua;
				
				_MangcuahangEntity.Doday = Doday;
				
				_MangcuahangEntity.Maloaimang = Maloaimang;
				
				_MangcuahangEntity.Tenloaimang = Tenloaimang;
					
					
				adapter.SaveEntity(_MangcuahangEntity, true);
			}
			return _MangcuahangEntity;
		}

		public MangcuahangEntity Insert(System.String Masp, System.String Tensp, System.Boolean Mangin, System.String Mamang, System.String Tenmang, System.String Maloaikeo, System.String Tenloaikeo, System.String Maloaidongran, System.String Tenloaidongran, System.Decimal Dinhmuckeokho, System.Decimal Dinhmucdongrankho, System.Decimal Tylekeokho, System.Decimal Tyledongrankho, System.Decimal Tylekeo, System.Decimal Tyledongran, System.Decimal Dinhmuckeouot, System.Decimal Dinhmucdongranuot, System.Decimal Dinhmucdungmoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Doday, System.String Maloaimang, System.String Tenloaimang)//ko co mahieu
		{
			MangcuahangEntity _MangcuahangEntity = new MangcuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_MangcuahangEntity.Masp = Masp;
				
				_MangcuahangEntity.Tensp = Tensp;
				
				_MangcuahangEntity.Mangin = Mangin;
				
				_MangcuahangEntity.Mamang = Mamang;
				
				_MangcuahangEntity.Tenmang = Tenmang;
				
				_MangcuahangEntity.Maloaikeo = Maloaikeo;
				
				_MangcuahangEntity.Tenloaikeo = Tenloaikeo;
				
				_MangcuahangEntity.Maloaidongran = Maloaidongran;
				
				_MangcuahangEntity.Tenloaidongran = Tenloaidongran;
				
				_MangcuahangEntity.Dinhmuckeokho = Dinhmuckeokho;
				
				_MangcuahangEntity.Dinhmucdongrankho = Dinhmucdongrankho;
				
				_MangcuahangEntity.Tylekeokho = Tylekeokho;
				
				_MangcuahangEntity.Tyledongrankho = Tyledongrankho;
				
				_MangcuahangEntity.Tylekeo = Tylekeo;
				
				_MangcuahangEntity.Tyledongran = Tyledongran;
				
				_MangcuahangEntity.Dinhmuckeouot = Dinhmuckeouot;
				
				_MangcuahangEntity.Dinhmucdongranuot = Dinhmucdongranuot;
				
				_MangcuahangEntity.Dinhmucdungmoi = Dinhmucdungmoi;
				
				_MangcuahangEntity.Ngaytao = Ngaytao;
				
				_MangcuahangEntity.Nguoitao = Nguoitao;
				
				_MangcuahangEntity.Ngaysua = Ngaysua;
				
				_MangcuahangEntity.Nguoisua = Nguoisua;
				
				_MangcuahangEntity.Doday = Doday;
				
				_MangcuahangEntity.Maloaimang = Maloaimang;
				
				_MangcuahangEntity.Tenloaimang = Tenloaimang;
					

				adapter.SaveEntity(_MangcuahangEntity, true);
			}
			return _MangcuahangEntity;
		}

		public bool Update(MangcuahangEntity _MangcuahangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(MangcuahangFields.Id == _MangcuahangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MangcuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MangcuahangEntity _MangcuahangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MangcuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Masp, System.String Tensp, System.Boolean Mangin, System.String Mamang, System.String Tenmang, System.String Maloaikeo, System.String Tenloaikeo, System.String Maloaidongran, System.String Tenloaidongran, System.Decimal Dinhmuckeokho, System.Decimal Dinhmucdongrankho, System.Decimal Tylekeokho, System.Decimal Tyledongrankho, System.Decimal Tylekeo, System.Decimal Tyledongran, System.Decimal Dinhmuckeouot, System.Decimal Dinhmucdongranuot, System.Decimal Dinhmucdungmoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Doday, System.String Maloaimang, System.String Tenloaimang)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MangcuahangEntity _MangcuahangEntity = new MangcuahangEntity(Id);
				if (adapter.FetchEntity(_MangcuahangEntity))
				{
				
					
					
					_MangcuahangEntity.Masp = Masp;
					
					_MangcuahangEntity.Tensp = Tensp;
					
					_MangcuahangEntity.Mangin = Mangin;
					
					_MangcuahangEntity.Mamang = Mamang;
					
					_MangcuahangEntity.Tenmang = Tenmang;
					
					_MangcuahangEntity.Maloaikeo = Maloaikeo;
					
					_MangcuahangEntity.Tenloaikeo = Tenloaikeo;
					
					_MangcuahangEntity.Maloaidongran = Maloaidongran;
					
					_MangcuahangEntity.Tenloaidongran = Tenloaidongran;
					
					_MangcuahangEntity.Dinhmuckeokho = Dinhmuckeokho;
					
					_MangcuahangEntity.Dinhmucdongrankho = Dinhmucdongrankho;
					
					_MangcuahangEntity.Tylekeokho = Tylekeokho;
					
					_MangcuahangEntity.Tyledongrankho = Tyledongrankho;
					
					_MangcuahangEntity.Tylekeo = Tylekeo;
					
					_MangcuahangEntity.Tyledongran = Tyledongran;
					
					_MangcuahangEntity.Dinhmuckeouot = Dinhmuckeouot;
					
					_MangcuahangEntity.Dinhmucdongranuot = Dinhmucdongranuot;
					
					_MangcuahangEntity.Dinhmucdungmoi = Dinhmucdungmoi;
					
					_MangcuahangEntity.Ngaytao = Ngaytao;
					
					_MangcuahangEntity.Nguoitao = Nguoitao;
					
					_MangcuahangEntity.Ngaysua = Ngaysua;
					
					_MangcuahangEntity.Nguoisua = Nguoisua;
					
					_MangcuahangEntity.Doday = Doday;
					
					_MangcuahangEntity.Maloaimang = Maloaimang;
					
					_MangcuahangEntity.Tenloaimang = Tenloaimang;
						

					adapter.SaveEntity(_MangcuahangEntity, true);
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
				MangcuahangEntity _MangcuahangEntity = new MangcuahangEntity(Id);
				if (adapter.FetchEntity(_MangcuahangEntity))
				{
					adapter.DeleteEntity(_MangcuahangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MangcuahangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMangin(System.Boolean Mangin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Mangin == Mangin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaikeo(System.String Maloaikeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaikeo == Maloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenloaikeo(System.String Tenloaikeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaikeo == Tenloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaidongran(System.String Maloaidongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaidongran == Maloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenloaidongran(System.String Tenloaidongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaidongran == Tenloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmuckeokho(System.Decimal Dinhmuckeokho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmuckeokho == Dinhmuckeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmucdongrankho(System.Decimal Dinhmucdongrankho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdongrankho == Dinhmucdongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylekeokho(System.Decimal Tylekeokho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tylekeokho == Tylekeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTyledongrankho(System.Decimal Tyledongrankho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tyledongrankho == Tyledongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylekeo(System.Decimal Tylekeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tylekeo == Tylekeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTyledongran(System.Decimal Tyledongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tyledongran == Tyledongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmuckeouot(System.Decimal Dinhmuckeouot)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmuckeouot == Dinhmuckeouot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmucdongranuot(System.Decimal Dinhmucdongranuot)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdongranuot == Dinhmucdongranuot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmucdungmoi(System.Decimal Dinhmucdungmoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdungmoi == Dinhmucdungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDoday(System.Decimal Doday)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Doday == Doday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaimang(System.String Maloaimang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenloaimang(System.String Tenloaimang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaimang == Tenloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MangcuahangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public MangcuahangEntity SelectOne(System.Int64 Id)
		{
			MangcuahangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MangcuahangEntity _MangcuahangEntity = new MangcuahangEntity(Id);
				if (adapter.FetchEntity(_MangcuahangEntity))
				{
					toReturn = _MangcuahangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _MangcuahangCollection = new EntityCollection( new MangcuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, null, 0, null);
			}
			return _MangcuahangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMangin(System.Boolean Mangin)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Mangin == Mangin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByManginRDT(System.Boolean Mangin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Mangin == Mangin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaikeo(System.String Maloaikeo)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaikeo == Maloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaikeoRDT(System.String Maloaikeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaikeo == Maloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenloaikeo(System.String Tenloaikeo)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaikeo == Tenloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenloaikeoRDT(System.String Tenloaikeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaikeo == Tenloaikeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaidongran(System.String Maloaidongran)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaidongran == Maloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaidongranRDT(System.String Maloaidongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaidongran == Maloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenloaidongran(System.String Tenloaidongran)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaidongran == Tenloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenloaidongranRDT(System.String Tenloaidongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaidongran == Tenloaidongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmuckeokho(System.Decimal Dinhmuckeokho)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmuckeokho == Dinhmuckeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmuckeokhoRDT(System.Decimal Dinhmuckeokho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmuckeokho == Dinhmuckeokho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmucdongrankho(System.Decimal Dinhmucdongrankho)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdongrankho == Dinhmucdongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmucdongrankhoRDT(System.Decimal Dinhmucdongrankho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdongrankho == Dinhmucdongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylekeokho(System.Decimal Tylekeokho)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tylekeokho == Tylekeokho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTylekeokhoRDT(System.Decimal Tylekeokho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tylekeokho == Tylekeokho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTyledongrankho(System.Decimal Tyledongrankho)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tyledongrankho == Tyledongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTyledongrankhoRDT(System.Decimal Tyledongrankho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tyledongrankho == Tyledongrankho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylekeo(System.Decimal Tylekeo)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tylekeo == Tylekeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTylekeoRDT(System.Decimal Tylekeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tylekeo == Tylekeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTyledongran(System.Decimal Tyledongran)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tyledongran == Tyledongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTyledongranRDT(System.Decimal Tyledongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tyledongran == Tyledongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmuckeouot(System.Decimal Dinhmuckeouot)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmuckeouot == Dinhmuckeouot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmuckeouotRDT(System.Decimal Dinhmuckeouot)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmuckeouot == Dinhmuckeouot);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmucdongranuot(System.Decimal Dinhmucdongranuot)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdongranuot == Dinhmucdongranuot);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmucdongranuotRDT(System.Decimal Dinhmucdongranuot)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdongranuot == Dinhmucdongranuot);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmucdungmoi(System.Decimal Dinhmucdungmoi)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdungmoi == Dinhmucdungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmucdungmoiRDT(System.Decimal Dinhmucdungmoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Dinhmucdungmoi == Dinhmucdungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDoday(System.Decimal Doday)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Doday == Doday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByDodayRDT(System.Decimal Doday)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Doday == Doday);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaimang(System.String Maloaimang)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaimangRDT(System.String Maloaimang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenloaimang(System.String Tenloaimang)
		{
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaimang == Tenloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MangcuahangCollection, filter, 0, null);
			}
			return _MangcuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenloaimangRDT(System.String Tenloaimang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MangcuahangCollection = new EntityCollection(new MangcuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MangcuahangFields.Tenloaimang == Tenloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MangcuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
