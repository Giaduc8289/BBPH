


/*
'===============================================================================
'  GD.BBPH.BL.DmbophanManagerBase
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
	public class DmbophanManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mabp="Mabp";				
		
		public const String Field_Tenbophan="Tenbophan";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmbophanManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mabp,typeof(System.String));
			
			dt.Columns.Add(Field_Tenbophan,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmbophanEntity _DmbophanEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mabp]=_DmbophanEntity.Mabp;
			}
			catch { }
			
			try
			{
				r[Field_Tenbophan]=_DmbophanEntity.Tenbophan;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmbophanEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmbophanEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmbophanEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmbophanEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmbophanEntity Convert(DataRow r)
		{	
			
			DmbophanEntity _DmbophanEntity=new DmbophanEntity(r[Field_Mabp].ToString());					
						
			
			
			try
			{
				_DmbophanEntity.Tenbophan= r[Field_Tenbophan].ToString();						
			}
			catch { }
			
			try
			{
				_DmbophanEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmbophanEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmbophanEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmbophanEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmbophanEntity;
		}			
		
		public DmbophanEntity Convert_Entity(DmbophanEntity _DmbophanEntity,DmbophanEntity _DmbophanEntity_XML)
		{	
			
			
			_DmbophanEntity.Mabp= _DmbophanEntity_XML.Mabp;
			
			_DmbophanEntity.Tenbophan= _DmbophanEntity_XML.Tenbophan;
			
			_DmbophanEntity.Ngaytao= _DmbophanEntity_XML.Ngaytao;
			
			_DmbophanEntity.Nguoitao= _DmbophanEntity_XML.Nguoitao;
			
			_DmbophanEntity.Ngaysua= _DmbophanEntity_XML.Ngaysua;
			
			_DmbophanEntity.Nguoisua= _DmbophanEntity_XML.Nguoisua;
									
				
			return _DmbophanEntity;
		}	
		
		public String InsertV2(DmbophanEntity _DmbophanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmbophanManagerBase()).Insert(_DmbophanEntity).Mabp.ToString();
			
			
			try
			{
				r.SetField(Field_Mabp,_DmbophanEntity.Mabp);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenbophan,_DmbophanEntity.Tenbophan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmbophanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmbophanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmbophanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmbophanEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmbophanEntity _DmbophanEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmbophanManagerBase()).Update(_DmbophanEntity);
			r.SetField(Field_Mabp,_DmbophanEntity.Mabp);
									
			
			
			
			try
			{
				r.SetField(Field_Tenbophan,_DmbophanEntity.Tenbophan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmbophanEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmbophanEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmbophanEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmbophanEntity.Nguoisua);
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

		public DmbophanEntity Insert(DmbophanEntity DmbophanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmbophanEntity, true);
			}
			return DmbophanEntity;
		}

		public DmbophanEntity Insert(System.String  Mabp, System.String  Tenbophan, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmbophanEntity _DmbophanEntity = new DmbophanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmbophanEntity.Mabp = Mabp;
				
				_DmbophanEntity.Tenbophan = Tenbophan;
				
				_DmbophanEntity.Ngaytao = Ngaytao;
				
				_DmbophanEntity.Nguoitao = Nguoitao;
				
				_DmbophanEntity.Ngaysua = Ngaysua;
				
				_DmbophanEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmbophanEntity, true);
			}
			return _DmbophanEntity;
		}

		public DmbophanEntity Insert(System.String Tenbophan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmbophanEntity _DmbophanEntity = new DmbophanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmbophanEntity.Tenbophan = Tenbophan;
				
				_DmbophanEntity.Ngaytao = Ngaytao;
				
				_DmbophanEntity.Nguoitao = Nguoitao;
				
				_DmbophanEntity.Ngaysua = Ngaysua;
				
				_DmbophanEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmbophanEntity, true);
			}
			return _DmbophanEntity;
		}

		public bool Update(DmbophanEntity _DmbophanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmbophanFields.Mabp == _DmbophanEntity.Mabp);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmbophanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmbophanEntity _DmbophanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmbophanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mabp, System.String Tenbophan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmbophanEntity _DmbophanEntity = new DmbophanEntity(Mabp);
				if (adapter.FetchEntity(_DmbophanEntity))
				{
				
					
					
					_DmbophanEntity.Tenbophan = Tenbophan;
					
					_DmbophanEntity.Ngaytao = Ngaytao;
					
					_DmbophanEntity.Nguoitao = Nguoitao;
					
					_DmbophanEntity.Ngaysua = Ngaysua;
					
					_DmbophanEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmbophanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Mabp)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmbophanEntity _DmbophanEntity = new DmbophanEntity(Mabp);
				if (adapter.FetchEntity(_DmbophanEntity))
				{
					adapter.DeleteEntity(_DmbophanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmbophanEntity", null);
			}
		}
		
		
		
		public int DeleteByMabp(System.String Mabp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenbophan(System.String Tenbophan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Tenbophan == Tenbophan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmbophanEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmbophanEntity SelectOne(System.String Mabp)
		{
			DmbophanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmbophanEntity _DmbophanEntity = new DmbophanEntity(Mabp);
				if (adapter.FetchEntity(_DmbophanEntity))
				{
					toReturn = _DmbophanEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmbophanCollection = new EntityCollection( new DmbophanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, null, 0, null);
			}
			return _DmbophanCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMabp(System.String Mabp)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByMabpRDT(System.String Mabp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Mabp == Mabp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenbophan(System.String Tenbophan)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Tenbophan == Tenbophan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByTenbophanRDT(System.String Tenbophan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Tenbophan == Tenbophan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmbophanCollection, filter, 0, null);
			}
			return _DmbophanCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmbophanCollection = new EntityCollection(new DmbophanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmbophanFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmbophanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmbophanFields.Mabp.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
