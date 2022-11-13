


/*
'===============================================================================
'  GD.BBPH.BL.MaucuahangManagerBase
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
	public class MaucuahangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tensp="Tensp";				
		
		public const String Field_Mamau="Mamau";				
		
		public const String Field_Tenmau="Tenmau";				
		
		public const String Field_Klmau="Klmau";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Tylebaophu="Tylebaophu";				
		
		public const String Field_MaArgb="MaArgb";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MaucuahangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tensp,typeof(System.String));
			
			dt.Columns.Add(Field_Mamau,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmau,typeof(System.String));
			
			dt.Columns.Add(Field_Klmau,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Tylebaophu,typeof(System.Decimal));
			
			dt.Columns.Add(Field_MaArgb,typeof(System.Int64));
									
		            
			return dt;			
		}
		public DataRow Convert(MaucuahangEntity _MaucuahangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_MaucuahangEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_MaucuahangEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_MaucuahangEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_Mamau]=_MaucuahangEntity.Mamau;
			}
			catch { }
			
			try
			{
				r[Field_Tenmau]=_MaucuahangEntity.Tenmau;
			}
			catch { }
			
			try
			{
				r[Field_Klmau]=_MaucuahangEntity.Klmau;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_MaucuahangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_MaucuahangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_MaucuahangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_MaucuahangEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Tylebaophu]=_MaucuahangEntity.Tylebaophu;
			}
			catch { }
			
			try
			{
				r[Field_MaArgb]=_MaucuahangEntity.MaArgb;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public MaucuahangEntity Convert(DataRow r)
		{	
			
			MaucuahangEntity _MaucuahangEntity=new MaucuahangEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_MaucuahangEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Mamau= r[Field_Mamau].ToString();						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Tenmau= r[Field_Tenmau].ToString();						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Klmau= System.Decimal.Parse(r[Field_Klmau].ToString());						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.Tylebaophu= System.Decimal.Parse(r[Field_Tylebaophu].ToString());						
			}
			catch { }
			
			try
			{
				_MaucuahangEntity.MaArgb= System.Int64.Parse(r[Field_MaArgb].ToString());						
			}
			catch { }
									
									
			return _MaucuahangEntity;
		}			
		
		public MaucuahangEntity Convert_Entity(MaucuahangEntity _MaucuahangEntity,MaucuahangEntity _MaucuahangEntity_XML)
		{	
			
			
			_MaucuahangEntity.Id= _MaucuahangEntity_XML.Id;
			
			_MaucuahangEntity.Masp= _MaucuahangEntity_XML.Masp;
			
			_MaucuahangEntity.Tensp= _MaucuahangEntity_XML.Tensp;
			
			_MaucuahangEntity.Mamau= _MaucuahangEntity_XML.Mamau;
			
			_MaucuahangEntity.Tenmau= _MaucuahangEntity_XML.Tenmau;
			
			_MaucuahangEntity.Klmau= _MaucuahangEntity_XML.Klmau;
			
			_MaucuahangEntity.Ngaytao= _MaucuahangEntity_XML.Ngaytao;
			
			_MaucuahangEntity.Nguoitao= _MaucuahangEntity_XML.Nguoitao;
			
			_MaucuahangEntity.Ngaysua= _MaucuahangEntity_XML.Ngaysua;
			
			_MaucuahangEntity.Nguoisua= _MaucuahangEntity_XML.Nguoisua;
			
			_MaucuahangEntity.Tylebaophu= _MaucuahangEntity_XML.Tylebaophu;
			
			_MaucuahangEntity.MaArgb= _MaucuahangEntity_XML.MaArgb;
									
				
			return _MaucuahangEntity;
		}	
		
		public String InsertV2(MaucuahangEntity _MaucuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new MaucuahangManagerBase()).Insert(_MaucuahangEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_MaucuahangEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Masp,_MaucuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_MaucuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamau,_MaucuahangEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmau,_MaucuahangEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Klmau,_MaucuahangEntity.Klmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_MaucuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_MaucuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_MaucuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_MaucuahangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylebaophu,_MaucuahangEntity.Tylebaophu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MaArgb,_MaucuahangEntity.MaArgb);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(MaucuahangEntity _MaucuahangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new MaucuahangManagerBase()).Update(_MaucuahangEntity);
			r.SetField(Field_Id,_MaucuahangEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Masp,_MaucuahangEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensp,_MaucuahangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamau,_MaucuahangEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmau,_MaucuahangEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Klmau,_MaucuahangEntity.Klmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_MaucuahangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_MaucuahangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_MaucuahangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_MaucuahangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylebaophu,_MaucuahangEntity.Tylebaophu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MaArgb,_MaucuahangEntity.MaArgb);
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

		public MaucuahangEntity Insert(MaucuahangEntity MaucuahangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(MaucuahangEntity, true);
			}
			return MaucuahangEntity;
		}

		public MaucuahangEntity Insert(System.Int64  Id, System.String  Masp, System.String  Tensp, System.String  Mamau, System.String  Tenmau, System.Decimal  Klmau, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Tylebaophu, System.Int64  MaArgb)
		{
			MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MaucuahangEntity.Id = Id;
				
				_MaucuahangEntity.Masp = Masp;
				
				_MaucuahangEntity.Tensp = Tensp;
				
				_MaucuahangEntity.Mamau = Mamau;
				
				_MaucuahangEntity.Tenmau = Tenmau;
				
				_MaucuahangEntity.Klmau = Klmau;
				
				_MaucuahangEntity.Ngaytao = Ngaytao;
				
				_MaucuahangEntity.Nguoitao = Nguoitao;
				
				_MaucuahangEntity.Ngaysua = Ngaysua;
				
				_MaucuahangEntity.Nguoisua = Nguoisua;
				
				_MaucuahangEntity.Tylebaophu = Tylebaophu;
				
				_MaucuahangEntity.MaArgb = MaArgb;
					
					
				adapter.SaveEntity(_MaucuahangEntity, true);
			}
			return _MaucuahangEntity;
		}

		public MaucuahangEntity Insert(System.String Masp, System.String Tensp, System.String Mamau, System.String Tenmau, System.Decimal Klmau, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Tylebaophu, System.Int64 MaArgb)//ko co mahieu
		{
			MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_MaucuahangEntity.Masp = Masp;
				
				_MaucuahangEntity.Tensp = Tensp;
				
				_MaucuahangEntity.Mamau = Mamau;
				
				_MaucuahangEntity.Tenmau = Tenmau;
				
				_MaucuahangEntity.Klmau = Klmau;
				
				_MaucuahangEntity.Ngaytao = Ngaytao;
				
				_MaucuahangEntity.Nguoitao = Nguoitao;
				
				_MaucuahangEntity.Ngaysua = Ngaysua;
				
				_MaucuahangEntity.Nguoisua = Nguoisua;
				
				_MaucuahangEntity.Tylebaophu = Tylebaophu;
				
				_MaucuahangEntity.MaArgb = MaArgb;
					

				adapter.SaveEntity(_MaucuahangEntity, true);
			}
			return _MaucuahangEntity;
		}

		public bool Update(MaucuahangEntity _MaucuahangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(MaucuahangFields.Id == _MaucuahangEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MaucuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MaucuahangEntity _MaucuahangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MaucuahangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Masp, System.String Tensp, System.String Mamau, System.String Tenmau, System.Decimal Klmau, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Tylebaophu, System.Int64 MaArgb)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity(Id);
				if (adapter.FetchEntity(_MaucuahangEntity))
				{
				
					
					
					_MaucuahangEntity.Masp = Masp;
					
					_MaucuahangEntity.Tensp = Tensp;
					
					_MaucuahangEntity.Mamau = Mamau;
					
					_MaucuahangEntity.Tenmau = Tenmau;
					
					_MaucuahangEntity.Klmau = Klmau;
					
					_MaucuahangEntity.Ngaytao = Ngaytao;
					
					_MaucuahangEntity.Nguoitao = Nguoitao;
					
					_MaucuahangEntity.Ngaysua = Ngaysua;
					
					_MaucuahangEntity.Nguoisua = Nguoisua;
					
					_MaucuahangEntity.Tylebaophu = Tylebaophu;
					
					_MaucuahangEntity.MaArgb = MaArgb;
						

					adapter.SaveEntity(_MaucuahangEntity, true);
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
				MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity(Id);
				if (adapter.FetchEntity(_MaucuahangEntity))
				{
					adapter.DeleteEntity(_MaucuahangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MaucuahangEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamau(System.String Mamau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmau(System.String Tenmau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKlmau(System.Decimal Klmau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Klmau == Klmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylebaophu(System.Decimal Tylebaophu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tylebaophu == Tylebaophu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaArgb(System.Int64 MaArgb)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.MaArgb == MaArgb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MaucuahangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public MaucuahangEntity SelectOne(System.Int64 Id)
		{
			MaucuahangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MaucuahangEntity _MaucuahangEntity = new MaucuahangEntity(Id);
				if (adapter.FetchEntity(_MaucuahangEntity))
				{
					toReturn = _MaucuahangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _MaucuahangCollection = new EntityCollection( new MaucuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, null, 0, null);
			}
			return _MaucuahangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamau(System.String Mamau)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamauRDT(System.String Mamau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmau(System.String Tenmau)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmauRDT(System.String Tenmau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKlmau(System.Decimal Klmau)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Klmau == Klmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByKlmauRDT(System.Decimal Klmau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Klmau == Klmau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylebaophu(System.Decimal Tylebaophu)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tylebaophu == Tylebaophu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByTylebaophuRDT(System.Decimal Tylebaophu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.Tylebaophu == Tylebaophu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaArgb(System.Int64 MaArgb)
		{
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.MaArgb == MaArgb);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MaucuahangCollection, filter, 0, null);
			}
			return _MaucuahangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaArgbRDT(System.Int64 MaArgb)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MaucuahangCollection = new EntityCollection(new MaucuahangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MaucuahangFields.MaArgb == MaArgb);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MaucuahangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(MaucuahangFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
