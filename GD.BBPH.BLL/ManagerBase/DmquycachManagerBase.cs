


/*
'===============================================================================
'  GD.BBPH.BL.DmquycachManagerBase
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
	public class DmquycachManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Maqc="Maqc";				
		
		public const String Field_Tenquycach="Tenquycach";				
		
		public const String Field_Macd="Macd";				
		
		public const String Field_Maqccha="Maqccha";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmquycachManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Maqc,typeof(System.String));
			
			dt.Columns.Add(Field_Tenquycach,typeof(System.String));
			
			dt.Columns.Add(Field_Macd,typeof(System.String));
			
			dt.Columns.Add(Field_Maqccha,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmquycachEntity _DmquycachEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Maqc]=_DmquycachEntity.Maqc;
			}
			catch { }
			
			try
			{
				r[Field_Tenquycach]=_DmquycachEntity.Tenquycach;
			}
			catch { }
			
			try
			{
				r[Field_Macd]=_DmquycachEntity.Macd;
			}
			catch { }
			
			try
			{
				r[Field_Maqccha]=_DmquycachEntity.Maqccha;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmquycachEntity Convert(DataRow r)
		{	
			
			DmquycachEntity _DmquycachEntity=new DmquycachEntity(r[Field_Maqc].ToString());					
						
			
			
			try
			{
				_DmquycachEntity.Tenquycach= r[Field_Tenquycach].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Macd= r[Field_Macd].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Maqccha= r[Field_Maqccha].ToString();						
			}
			catch { }
									
									
			return _DmquycachEntity;
		}			
		
		public DmquycachEntity Convert_Entity(DmquycachEntity _DmquycachEntity,DmquycachEntity _DmquycachEntity_XML)
		{	
			
			
			_DmquycachEntity.Maqc= _DmquycachEntity_XML.Maqc;
			
			_DmquycachEntity.Tenquycach= _DmquycachEntity_XML.Tenquycach;
			
			_DmquycachEntity.Macd= _DmquycachEntity_XML.Macd;
			
			_DmquycachEntity.Maqccha= _DmquycachEntity_XML.Maqccha;
									
				
			return _DmquycachEntity;
		}	
		
		public String InsertV2(DmquycachEntity _DmquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmquycachManagerBase()).Insert(_DmquycachEntity).Maqc.ToString();
			
			
			try
			{
				r.SetField(Field_Maqc,_DmquycachEntity.Maqc);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenquycach,_DmquycachEntity.Tenquycach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_DmquycachEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqccha,_DmquycachEntity.Maqccha);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmquycachEntity _DmquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmquycachManagerBase()).Update(_DmquycachEntity);
			r.SetField(Field_Maqc,_DmquycachEntity.Maqc);
									
			
			
			
			try
			{
				r.SetField(Field_Tenquycach,_DmquycachEntity.Tenquycach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macd,_DmquycachEntity.Macd);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqccha,_DmquycachEntity.Maqccha);
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

		public DmquycachEntity Insert(DmquycachEntity DmquycachEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmquycachEntity, true);
			}
			return DmquycachEntity;
		}

		public DmquycachEntity Insert(System.String  Maqc, System.String  Tenquycach, System.String  Macd, System.String  Maqccha)
		{
			DmquycachEntity _DmquycachEntity = new DmquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmquycachEntity.Maqc = Maqc;
				
				_DmquycachEntity.Tenquycach = Tenquycach;
				
				_DmquycachEntity.Macd = Macd;
				
				_DmquycachEntity.Maqccha = Maqccha;
					
					
				adapter.SaveEntity(_DmquycachEntity, true);
			}
			return _DmquycachEntity;
		}

		public DmquycachEntity Insert(System.String Tenquycach, System.String Macd, System.String Maqccha)//ko co mahieu
		{
			DmquycachEntity _DmquycachEntity = new DmquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmquycachEntity.Tenquycach = Tenquycach;
				
				_DmquycachEntity.Macd = Macd;
				
				_DmquycachEntity.Maqccha = Maqccha;
					

				adapter.SaveEntity(_DmquycachEntity, true);
			}
			return _DmquycachEntity;
		}

		public bool Update(DmquycachEntity _DmquycachEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmquycachFields.Maqc == _DmquycachEntity.Maqc);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmquycachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmquycachEntity _DmquycachEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmquycachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Maqc, System.String Tenquycach, System.String Macd, System.String Maqccha)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maqc);
				if (adapter.FetchEntity(_DmquycachEntity))
				{
				
					
					
					_DmquycachEntity.Tenquycach = Tenquycach;
					
					_DmquycachEntity.Macd = Macd;
					
					_DmquycachEntity.Maqccha = Maqccha;
						

					adapter.SaveEntity(_DmquycachEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Maqc)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maqc);
				if (adapter.FetchEntity(_DmquycachEntity))
				{
					adapter.DeleteEntity(_DmquycachEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmquycachEntity", null);
			}
		}
		
		
		
		public int DeleteByMaqc(System.String Maqc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqc == Maqc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenquycach(System.String Tenquycach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tenquycach == Tenquycach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacd(System.String Macd)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqccha(System.String Maqccha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqccha == Maqccha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmquycachEntity SelectOne(System.String Maqc)
		{
			DmquycachEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maqc);
				if (adapter.FetchEntity(_DmquycachEntity))
				{
					toReturn = _DmquycachEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmquycachCollection = new EntityCollection( new DmquycachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, null, 0, null);
			}
			return _DmquycachCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMaqc(System.String Maqc)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqc == Maqc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcRDT(System.String Maqc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqc == Maqc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenquycach(System.String Tenquycach)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tenquycach == Tenquycach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByTenquycachRDT(System.String Tenquycach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tenquycach == Tenquycach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacd(System.String Macd)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMacdRDT(System.String Macd)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macd == Macd);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqccha(System.String Maqccha)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqccha == Maqccha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcchaRDT(System.String Maqccha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maqccha == Maqccha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
