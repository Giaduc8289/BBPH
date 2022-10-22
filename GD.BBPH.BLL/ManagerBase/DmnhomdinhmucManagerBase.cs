


/*
'===============================================================================
'  GD.BBPH.BL.DmnhomdinhmucManagerBase
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
	public class DmnhomdinhmucManagerBase
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
		public DmnhomdinhmucManagerBase()
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
		public DataRow Convert(DmnhomdinhmucEntity _DmnhomdinhmucEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Manhom]=_DmnhomdinhmucEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhom]=_DmnhomdinhmucEntity.Tennhom;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DmnhomdinhmucEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmnhomdinhmucEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmnhomdinhmucEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmnhomdinhmucEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmnhomdinhmucEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmnhomdinhmucEntity Convert(DataRow r)
		{	
			
			DmnhomdinhmucEntity _DmnhomdinhmucEntity=new DmnhomdinhmucEntity(r[Field_Manhom].ToString());					
						
			
			
			try
			{
				_DmnhomdinhmucEntity.Tennhom= r[Field_Tennhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmnhomdinhmucEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DmnhomdinhmucEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmnhomdinhmucEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmnhomdinhmucEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmnhomdinhmucEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DmnhomdinhmucEntity;
		}			
		
		public DmnhomdinhmucEntity Convert_Entity(DmnhomdinhmucEntity _DmnhomdinhmucEntity,DmnhomdinhmucEntity _DmnhomdinhmucEntity_XML)
		{	
			
			
			_DmnhomdinhmucEntity.Manhom= _DmnhomdinhmucEntity_XML.Manhom;
			
			_DmnhomdinhmucEntity.Tennhom= _DmnhomdinhmucEntity_XML.Tennhom;
			
			_DmnhomdinhmucEntity.Tenrutgon= _DmnhomdinhmucEntity_XML.Tenrutgon;
			
			_DmnhomdinhmucEntity.Ngaytao= _DmnhomdinhmucEntity_XML.Ngaytao;
			
			_DmnhomdinhmucEntity.Nguoitao= _DmnhomdinhmucEntity_XML.Nguoitao;
			
			_DmnhomdinhmucEntity.Ngaysua= _DmnhomdinhmucEntity_XML.Ngaysua;
			
			_DmnhomdinhmucEntity.Nguoisua= _DmnhomdinhmucEntity_XML.Nguoisua;
									
				
			return _DmnhomdinhmucEntity;
		}	
		
		public String InsertV2(DmnhomdinhmucEntity _DmnhomdinhmucEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmnhomdinhmucManagerBase()).Insert(_DmnhomdinhmucEntity).Manhom.ToString();
			
			
			try
			{
				r.SetField(Field_Manhom,_DmnhomdinhmucEntity.Manhom);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tennhom,_DmnhomdinhmucEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnhomdinhmucEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmnhomdinhmucEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmnhomdinhmucEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmnhomdinhmucEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmnhomdinhmucEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmnhomdinhmucEntity _DmnhomdinhmucEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmnhomdinhmucManagerBase()).Update(_DmnhomdinhmucEntity);
			r.SetField(Field_Manhom,_DmnhomdinhmucEntity.Manhom);
									
			
			
			
			try
			{
				r.SetField(Field_Tennhom,_DmnhomdinhmucEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DmnhomdinhmucEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmnhomdinhmucEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmnhomdinhmucEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmnhomdinhmucEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmnhomdinhmucEntity.Nguoisua);
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

		public DmnhomdinhmucEntity Insert(DmnhomdinhmucEntity DmnhomdinhmucEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmnhomdinhmucEntity, true);
			}
			return DmnhomdinhmucEntity;
		}

		public DmnhomdinhmucEntity Insert(System.String  Manhom, System.String  Tennhom, System.String  Tenrutgon, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DmnhomdinhmucEntity _DmnhomdinhmucEntity = new DmnhomdinhmucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmnhomdinhmucEntity.Manhom = Manhom;
				
				_DmnhomdinhmucEntity.Tennhom = Tennhom;
				
				_DmnhomdinhmucEntity.Tenrutgon = Tenrutgon;
				
				_DmnhomdinhmucEntity.Ngaytao = Ngaytao;
				
				_DmnhomdinhmucEntity.Nguoitao = Nguoitao;
				
				_DmnhomdinhmucEntity.Ngaysua = Ngaysua;
				
				_DmnhomdinhmucEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DmnhomdinhmucEntity, true);
			}
			return _DmnhomdinhmucEntity;
		}

		public DmnhomdinhmucEntity Insert(System.String Tennhom, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DmnhomdinhmucEntity _DmnhomdinhmucEntity = new DmnhomdinhmucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmnhomdinhmucEntity.Tennhom = Tennhom;
				
				_DmnhomdinhmucEntity.Tenrutgon = Tenrutgon;
				
				_DmnhomdinhmucEntity.Ngaytao = Ngaytao;
				
				_DmnhomdinhmucEntity.Nguoitao = Nguoitao;
				
				_DmnhomdinhmucEntity.Ngaysua = Ngaysua;
				
				_DmnhomdinhmucEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DmnhomdinhmucEntity, true);
			}
			return _DmnhomdinhmucEntity;
		}

		public bool Update(DmnhomdinhmucEntity _DmnhomdinhmucEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmnhomdinhmucFields.Manhom == _DmnhomdinhmucEntity.Manhom);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmnhomdinhmucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmnhomdinhmucEntity _DmnhomdinhmucEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmnhomdinhmucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Manhom, System.String Tennhom, System.String Tenrutgon, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomdinhmucEntity _DmnhomdinhmucEntity = new DmnhomdinhmucEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomdinhmucEntity))
				{
				
					
					
					_DmnhomdinhmucEntity.Tennhom = Tennhom;
					
					_DmnhomdinhmucEntity.Tenrutgon = Tenrutgon;
					
					_DmnhomdinhmucEntity.Ngaytao = Ngaytao;
					
					_DmnhomdinhmucEntity.Nguoitao = Nguoitao;
					
					_DmnhomdinhmucEntity.Ngaysua = Ngaysua;
					
					_DmnhomdinhmucEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DmnhomdinhmucEntity, true);
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
				DmnhomdinhmucEntity _DmnhomdinhmucEntity = new DmnhomdinhmucEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomdinhmucEntity))
				{
					adapter.DeleteEntity(_DmnhomdinhmucEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", null);
			}
		}
		
		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhom(System.String Tennhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmnhomdinhmucEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmnhomdinhmucEntity SelectOne(System.String Manhom)
		{
			DmnhomdinhmucEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmnhomdinhmucEntity _DmnhomdinhmucEntity = new DmnhomdinhmucEntity(Manhom);
				if (adapter.FetchEntity(_DmnhomdinhmucEntity))
				{
					toReturn = _DmnhomdinhmucEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection( new DmnhomdinhmucEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, null, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, filter, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhom(System.String Tennhom)
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, filter, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomRDT(System.String Tennhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, filter, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, filter, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, filter, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, filter, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmnhomdinhmucCollection, filter, 0, null);
			}
			return _DmnhomdinhmucCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmnhomdinhmucCollection = new EntityCollection(new DmnhomdinhmucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmnhomdinhmucFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmnhomdinhmucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
