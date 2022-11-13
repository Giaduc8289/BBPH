


/*
'===============================================================================
'  GD.BBPH.BL.DmnhomquycachManagerBase
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
	public class DmnhomquycachManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Manhom="Manhom";				
		
		public const String Field_Tennhom="Tennhom";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmnhomquycachManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Manhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmnhomquycachEntity _DmnhomquycachEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Manhom]=_DmnhomquycachEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhom]=_DmnhomquycachEntity.Tennhom;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DmnhomquycachEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmnhomquycachEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmnhomquycachEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmnhomquycachEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmnhomquycachEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmnhomquycachEntity Convert(DataRow r)
		{	
			
			DmnhomquycachEntity _DmnhomquycachEntity=new DmnhomquycachEntity(r[Field_Manhom].ToString());					
						
			
			
			try
			{
				_DmnhomquycachEntity.Tennhom= r[Field_Tennhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmnhomquycachEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DmnhomquycachEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmnhomquycachEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmnhomquycachEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmnhomquycachEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmnhomquycachEntity;
		}			
		
		public DmnhomquycachEntity Convert_Entity(DmnhomquycachEntity _DmnhomquycachEntity,DmnhomquycachEntity _DmnhomquycachEntity_XML)
		{	
			
			
			_DmnhomquycachEntity.Manhom= _DmnhomquycachEntity_XML.Manhom;
			
			_DmnhomquycachEntity.Tennhom= _DmnhomquycachEntity_XML.Tennhom;
			
			_DmnhomquycachEntity.Tenrutgon= _DmnhomquycachEntity_XML.Tenrutgon;
			
			_DmnhomquycachEntity.Ngaytao= _DmnhomquycachEntity_XML.Ngaytao;
			
			_DmnhomquycachEntity.Nguoitao= _DmnhomquycachEntity_XML.Nguoitao;
			
			_DmnhomquycachEntity.Ngaysua= _DmnhomquycachEntity_XML.Ngaysua;
			
			_DmnhomquycachEntity.Nguoisua= _DmnhomquycachEntity_XML.Nguoisua;
									
				
			return _DmnhomquycachEntity;
		}	
		
		public String InsertV2(DmnhomquycachEntity _DmnhomquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmnhomquycachManagerBase()).Insert(_DmnhomquycachEntity).Manhom.ToString();
			
			
			try
			{
				r.SetField(Field_Manhom,_DmnhomquycachEntity.Manhom);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tennhom,_DmnhomquycachEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnhomquycachEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmnhomquycachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmnhomquycachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmnhomquycachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmnhomquycachEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmnhomquycachEntity _DmnhomquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmnhomquycachManagerBase()).Update(_DmnhomquycachEntity);
			r.SetField(Field_Manhom,_DmnhomquycachEntity.Manhom);
									
			
			
			
			try
			{
				r.SetField(Field_Tennhom,_DmnhomquycachEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnhomquycachEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmnhomquycachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmnhomquycachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmnhomquycachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmnhomquycachEntity.Nguoisua);
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

		public DmnhomquycachEntity Insert(DmnhomquycachEntity DmnhomquycachEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmnhomquycachEntity, true);
			}
			return DmnhomquycachEntity;
		}

		public DmnhomquycachEntity Insert(System.String  Manhom, System.String  Tennhom, System.String  Tenrutgon, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmnhomquycachEntity.Manhom = Manhom;
				
				_DmnhomquycachEntity.Tennhom = Tennhom;
				
				_DmnhomquycachEntity.Tenrutgon = Tenrutgon;
				
				_DmnhomquycachEntity.Ngaytao = Ngaytao;
				
				_DmnhomquycachEntity.Nguoitao = Nguoitao;
				
				_DmnhomquycachEntity.Ngaysua = Ngaysua;
				
				_DmnhomquycachEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmnhomquycachEntity, true);
			}
			return _DmnhomquycachEntity;
		}

		public DmnhomquycachEntity Insert(System.String Tennhom, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmnhomquycachEntity.Tennhom = Tennhom;
				
				_DmnhomquycachEntity.Tenrutgon = Tenrutgon;
				
				_DmnhomquycachEntity.Ngaytao = Ngaytao;
				
				_DmnhomquycachEntity.Nguoitao = Nguoitao;
				
				_DmnhomquycachEntity.Ngaysua = Ngaysua;
				
				_DmnhomquycachEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmnhomquycachEntity, true);
			}
			return _DmnhomquycachEntity;
		}

		public bool Update(DmnhomquycachEntity _DmnhomquycachEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmnhomquycachFields.Manhom == _DmnhomquycachEntity.Manhom);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmnhomquycachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmnhomquycachEntity _DmnhomquycachEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmnhomquycachEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Manhom, System.String Tennhom, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomquycachEntity))
				{
				
					
					
					_DmnhomquycachEntity.Tennhom = Tennhom;
					
					_DmnhomquycachEntity.Tenrutgon = Tenrutgon;
					
					_DmnhomquycachEntity.Ngaytao = Ngaytao;
					
					_DmnhomquycachEntity.Nguoitao = Nguoitao;
					
					_DmnhomquycachEntity.Ngaysua = Ngaysua;
					
					_DmnhomquycachEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmnhomquycachEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Manhom)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomquycachEntity))
				{
					adapter.DeleteEntity(_DmnhomquycachEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", null);
			}
		}
		
		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhom(System.String Tennhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomquycachEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmnhomquycachEntity SelectOne(System.String Manhom)
		{
			DmnhomquycachEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomquycachEntity _DmnhomquycachEntity = new DmnhomquycachEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomquycachEntity))
				{
					toReturn = _DmnhomquycachEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection( new DmnhomquycachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, null, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, filter, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhom(System.String Tennhom)
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, filter, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomRDT(System.String Tennhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, filter, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, filter, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, filter, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, filter, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomquycachCollection, filter, 0, null);
			}
			return _DmnhomquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomquycachCollection = new EntityCollection(new DmnhomquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmnhomquycachFields.Manhom.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
