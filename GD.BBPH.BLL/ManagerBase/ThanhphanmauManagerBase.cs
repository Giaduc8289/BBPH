


/*
'===============================================================================
'  GD.BBPH.BL.ThanhphanmauManagerBase
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
	public class ThanhphanmauManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Mamau="Mamau";				
		
		public const String Field_Tenmau="Tenmau";				
		
		public const String Field_Mausudung="Mausudung";				
		
		public const String Field_Tenmausudung="Tenmausudung";				
		
		public const String Field_Tyle="Tyle";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public ThanhphanmauManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Mamau,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmau,typeof(System.String));
			
			dt.Columns.Add(Field_Mausudung,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmausudung,typeof(System.String));
			
			dt.Columns.Add(Field_Tyle,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(ThanhphanmauEntity _ThanhphanmauEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_ThanhphanmauEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Mamau]=_ThanhphanmauEntity.Mamau;
			}
			catch { }
			
			try
			{
				r[Field_Tenmau]=_ThanhphanmauEntity.Tenmau;
			}
			catch { }
			
			try
			{
				r[Field_Mausudung]=_ThanhphanmauEntity.Mausudung;
			}
			catch { }
			
			try
			{
				r[Field_Tenmausudung]=_ThanhphanmauEntity.Tenmausudung;
			}
			catch { }
			
			try
			{
				r[Field_Tyle]=_ThanhphanmauEntity.Tyle;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_ThanhphanmauEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_ThanhphanmauEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_ThanhphanmauEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_ThanhphanmauEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public ThanhphanmauEntity Convert(DataRow r)
		{	
			
			ThanhphanmauEntity _ThanhphanmauEntity=new ThanhphanmauEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_ThanhphanmauEntity.Mamau= r[Field_Mamau].ToString();						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Tenmau= r[Field_Tenmau].ToString();						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Mausudung= r[Field_Mausudung].ToString();						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Tenmausudung= r[Field_Tenmausudung].ToString();						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Tyle= System.Decimal.Parse(r[Field_Tyle].ToString());						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_ThanhphanmauEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _ThanhphanmauEntity;
		}			
		
		public ThanhphanmauEntity Convert_Entity(ThanhphanmauEntity _ThanhphanmauEntity,ThanhphanmauEntity _ThanhphanmauEntity_XML)
		{	
			
			
			_ThanhphanmauEntity.Id= _ThanhphanmauEntity_XML.Id;
			
			_ThanhphanmauEntity.Mamau= _ThanhphanmauEntity_XML.Mamau;
			
			_ThanhphanmauEntity.Tenmau= _ThanhphanmauEntity_XML.Tenmau;
			
			_ThanhphanmauEntity.Mausudung= _ThanhphanmauEntity_XML.Mausudung;
			
			_ThanhphanmauEntity.Tenmausudung= _ThanhphanmauEntity_XML.Tenmausudung;
			
			_ThanhphanmauEntity.Tyle= _ThanhphanmauEntity_XML.Tyle;
			
			_ThanhphanmauEntity.Ngaytao= _ThanhphanmauEntity_XML.Ngaytao;
			
			_ThanhphanmauEntity.Nguoitao= _ThanhphanmauEntity_XML.Nguoitao;
			
			_ThanhphanmauEntity.Ngaysua= _ThanhphanmauEntity_XML.Ngaysua;
			
			_ThanhphanmauEntity.Nguoisua= _ThanhphanmauEntity_XML.Nguoisua;
									
				
			return _ThanhphanmauEntity;
		}	
		
		public String InsertV2(ThanhphanmauEntity _ThanhphanmauEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new ThanhphanmauManagerBase()).Insert(_ThanhphanmauEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_ThanhphanmauEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Mamau,_ThanhphanmauEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmau,_ThanhphanmauEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mausudung,_ThanhphanmauEntity.Mausudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmausudung,_ThanhphanmauEntity.Tenmausudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyle,_ThanhphanmauEntity.Tyle);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_ThanhphanmauEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_ThanhphanmauEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_ThanhphanmauEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_ThanhphanmauEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(ThanhphanmauEntity _ThanhphanmauEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new ThanhphanmauManagerBase()).Update(_ThanhphanmauEntity);
			r.SetField(Field_Id,_ThanhphanmauEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Mamau,_ThanhphanmauEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmau,_ThanhphanmauEntity.Tenmau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mausudung,_ThanhphanmauEntity.Mausudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmausudung,_ThanhphanmauEntity.Tenmausudung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tyle,_ThanhphanmauEntity.Tyle);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_ThanhphanmauEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_ThanhphanmauEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_ThanhphanmauEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_ThanhphanmauEntity.Nguoisua);
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

		public ThanhphanmauEntity Insert(ThanhphanmauEntity ThanhphanmauEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(ThanhphanmauEntity, true);
			}
			return ThanhphanmauEntity;
		}

		public ThanhphanmauEntity Insert(System.Int64  Id, System.String  Mamau, System.String  Tenmau, System.String  Mausudung, System.String  Tenmausudung, System.Decimal  Tyle, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_ThanhphanmauEntity.Id = Id;
				
				_ThanhphanmauEntity.Mamau = Mamau;
				
				_ThanhphanmauEntity.Tenmau = Tenmau;
				
				_ThanhphanmauEntity.Mausudung = Mausudung;
				
				_ThanhphanmauEntity.Tenmausudung = Tenmausudung;
				
				_ThanhphanmauEntity.Tyle = Tyle;
				
				_ThanhphanmauEntity.Ngaytao = Ngaytao;
				
				_ThanhphanmauEntity.Nguoitao = Nguoitao;
				
				_ThanhphanmauEntity.Ngaysua = Ngaysua;
				
				_ThanhphanmauEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_ThanhphanmauEntity, true);
			}
			return _ThanhphanmauEntity;
		}

		public ThanhphanmauEntity Insert(System.String Mamau, System.String Tenmau, System.String Mausudung, System.String Tenmausudung, System.Decimal Tyle, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_ThanhphanmauEntity.Mamau = Mamau;
				
				_ThanhphanmauEntity.Tenmau = Tenmau;
				
				_ThanhphanmauEntity.Mausudung = Mausudung;
				
				_ThanhphanmauEntity.Tenmausudung = Tenmausudung;
				
				_ThanhphanmauEntity.Tyle = Tyle;
				
				_ThanhphanmauEntity.Ngaytao = Ngaytao;
				
				_ThanhphanmauEntity.Nguoitao = Nguoitao;
				
				_ThanhphanmauEntity.Ngaysua = Ngaysua;
				
				_ThanhphanmauEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_ThanhphanmauEntity, true);
			}
			return _ThanhphanmauEntity;
		}

		public bool Update(ThanhphanmauEntity _ThanhphanmauEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(ThanhphanmauFields.Id == _ThanhphanmauEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_ThanhphanmauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(ThanhphanmauEntity _ThanhphanmauEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_ThanhphanmauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Mamau, System.String Tenmau, System.String Mausudung, System.String Tenmausudung, System.Decimal Tyle, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity(Id);
				if (adapter.FetchEntity(_ThanhphanmauEntity))
				{
				
					
					
					_ThanhphanmauEntity.Mamau = Mamau;
					
					_ThanhphanmauEntity.Tenmau = Tenmau;
					
					_ThanhphanmauEntity.Mausudung = Mausudung;
					
					_ThanhphanmauEntity.Tenmausudung = Tenmausudung;
					
					_ThanhphanmauEntity.Tyle = Tyle;
					
					_ThanhphanmauEntity.Ngaytao = Ngaytao;
					
					_ThanhphanmauEntity.Nguoitao = Nguoitao;
					
					_ThanhphanmauEntity.Ngaysua = Ngaysua;
					
					_ThanhphanmauEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_ThanhphanmauEntity, true);
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
				ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity(Id);
				if (adapter.FetchEntity(_ThanhphanmauEntity))
				{
					adapter.DeleteEntity(_ThanhphanmauEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamau(System.String Mamau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmau(System.String Tenmau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMausudung(System.String Mausudung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Mausudung == Mausudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmausudung(System.String Tenmausudung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tenmausudung == Tenmausudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTyle(System.Decimal Tyle)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tyle == Tyle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("ThanhphanmauEntity", filter);
			}
			return toReturn;
		}		
			
		
		public ThanhphanmauEntity SelectOne(System.Int64 Id)
		{
			ThanhphanmauEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				ThanhphanmauEntity _ThanhphanmauEntity = new ThanhphanmauEntity(Id);
				if (adapter.FetchEntity(_ThanhphanmauEntity))
				{
					toReturn = _ThanhphanmauEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection( new ThanhphanmauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, null, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamau(System.String Mamau)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByMamauRDT(System.String Mamau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmau(System.String Tenmau)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmauRDT(System.String Tenmau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tenmau == Tenmau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMausudung(System.String Mausudung)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Mausudung == Mausudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByMausudungRDT(System.String Mausudung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Mausudung == Mausudung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmausudung(System.String Tenmausudung)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tenmausudung == Tenmausudung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmausudungRDT(System.String Tenmausudung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tenmausudung == Tenmausudung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTyle(System.Decimal Tyle)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tyle == Tyle);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByTyleRDT(System.Decimal Tyle)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Tyle == Tyle);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_ThanhphanmauCollection, filter, 0, null);
			}
			return _ThanhphanmauCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _ThanhphanmauCollection = new EntityCollection(new ThanhphanmauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(ThanhphanmauFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_ThanhphanmauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(ThanhphanmauFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
