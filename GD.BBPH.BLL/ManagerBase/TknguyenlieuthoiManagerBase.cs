


/*
'===============================================================================
'  GD.BBPH.BL.TknguyenlieuthoiManagerBase
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
	public class TknguyenlieuthoiManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Manguyenlieu="Manguyenlieu";				
		
		public const String Field_Tennguyenlieu="Tennguyenlieu";				
		
		public const String Field_Klnhap="Klnhap";				
		
		public const String Field_Klxuat="Klxuat";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TknguyenlieuthoiManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ca,typeof(System.Int32));
			
			dt.Columns.Add(Field_Manguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Tennguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Klnhap,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Klxuat,typeof(System.Decimal));
									
		            
			return dt;			
		}
		public DataRow Convert(TknguyenlieuthoiEntity _TknguyenlieuthoiEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_TknguyenlieuthoiEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_TknguyenlieuthoiEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_TknguyenlieuthoiEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Manguyenlieu]=_TknguyenlieuthoiEntity.Manguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Tennguyenlieu]=_TknguyenlieuthoiEntity.Tennguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Klnhap]=_TknguyenlieuthoiEntity.Klnhap;
			}
			catch { }
			
			try
			{
				r[Field_Klxuat]=_TknguyenlieuthoiEntity.Klxuat;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public TknguyenlieuthoiEntity Convert(DataRow r)
		{	
			
			TknguyenlieuthoiEntity _TknguyenlieuthoiEntity=new TknguyenlieuthoiEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_TknguyenlieuthoiEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_TknguyenlieuthoiEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_TknguyenlieuthoiEntity.Manguyenlieu= r[Field_Manguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_TknguyenlieuthoiEntity.Tennguyenlieu= r[Field_Tennguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_TknguyenlieuthoiEntity.Klnhap= System.Decimal.Parse(r[Field_Klnhap].ToString());						
			}
			catch { }
			
			try
			{
				_TknguyenlieuthoiEntity.Klxuat= System.Decimal.Parse(r[Field_Klxuat].ToString());						
			}
			catch { }
									
									
			return _TknguyenlieuthoiEntity;
		}			
		
		public TknguyenlieuthoiEntity Convert_Entity(TknguyenlieuthoiEntity _TknguyenlieuthoiEntity,TknguyenlieuthoiEntity _TknguyenlieuthoiEntity_XML)
		{	
			
			
			_TknguyenlieuthoiEntity.Id= _TknguyenlieuthoiEntity_XML.Id;
			
			_TknguyenlieuthoiEntity.Ngay= _TknguyenlieuthoiEntity_XML.Ngay;
			
			_TknguyenlieuthoiEntity.Ca= _TknguyenlieuthoiEntity_XML.Ca;
			
			_TknguyenlieuthoiEntity.Manguyenlieu= _TknguyenlieuthoiEntity_XML.Manguyenlieu;
			
			_TknguyenlieuthoiEntity.Tennguyenlieu= _TknguyenlieuthoiEntity_XML.Tennguyenlieu;
			
			_TknguyenlieuthoiEntity.Klnhap= _TknguyenlieuthoiEntity_XML.Klnhap;
			
			_TknguyenlieuthoiEntity.Klxuat= _TknguyenlieuthoiEntity_XML.Klxuat;
									
				
			return _TknguyenlieuthoiEntity;
		}	
		
		public String InsertV2(TknguyenlieuthoiEntity _TknguyenlieuthoiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new TknguyenlieuthoiManagerBase()).Insert(_TknguyenlieuthoiEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_TknguyenlieuthoiEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_TknguyenlieuthoiEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_TknguyenlieuthoiEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_TknguyenlieuthoiEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_TknguyenlieuthoiEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Klnhap,_TknguyenlieuthoiEntity.Klnhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Klxuat,_TknguyenlieuthoiEntity.Klxuat);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(TknguyenlieuthoiEntity _TknguyenlieuthoiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new TknguyenlieuthoiManagerBase()).Update(_TknguyenlieuthoiEntity);
			r.SetField(Field_Id,_TknguyenlieuthoiEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_TknguyenlieuthoiEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_TknguyenlieuthoiEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manguyenlieu,_TknguyenlieuthoiEntity.Manguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_TknguyenlieuthoiEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Klnhap,_TknguyenlieuthoiEntity.Klnhap);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Klxuat,_TknguyenlieuthoiEntity.Klxuat);
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

		public TknguyenlieuthoiEntity Insert(TknguyenlieuthoiEntity TknguyenlieuthoiEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(TknguyenlieuthoiEntity, true);
			}
			return TknguyenlieuthoiEntity;
		}

		public TknguyenlieuthoiEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Manguyenlieu, System.String  Tennguyenlieu, System.Decimal  Klnhap, System.Decimal  Klxuat)
		{
			TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TknguyenlieuthoiEntity.Id = Id;
				
				_TknguyenlieuthoiEntity.Ngay = Ngay;
				
				_TknguyenlieuthoiEntity.Ca = Ca;
				
				_TknguyenlieuthoiEntity.Manguyenlieu = Manguyenlieu;
				
				_TknguyenlieuthoiEntity.Tennguyenlieu = Tennguyenlieu;
				
				_TknguyenlieuthoiEntity.Klnhap = Klnhap;
				
				_TknguyenlieuthoiEntity.Klxuat = Klxuat;
					
					
				adapter.SaveEntity(_TknguyenlieuthoiEntity, true);
			}
			return _TknguyenlieuthoiEntity;
		}

		public TknguyenlieuthoiEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Manguyenlieu, System.String Tennguyenlieu, System.Decimal Klnhap, System.Decimal Klxuat)//ko co mahieu
		{
			TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_TknguyenlieuthoiEntity.Ngay = Ngay;
				
				_TknguyenlieuthoiEntity.Ca = Ca;
				
				_TknguyenlieuthoiEntity.Manguyenlieu = Manguyenlieu;
				
				_TknguyenlieuthoiEntity.Tennguyenlieu = Tennguyenlieu;
				
				_TknguyenlieuthoiEntity.Klnhap = Klnhap;
				
				_TknguyenlieuthoiEntity.Klxuat = Klxuat;
					

				adapter.SaveEntity(_TknguyenlieuthoiEntity, true);
			}
			return _TknguyenlieuthoiEntity;
		}

		public bool Update(TknguyenlieuthoiEntity _TknguyenlieuthoiEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(TknguyenlieuthoiFields.Id == _TknguyenlieuthoiEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TknguyenlieuthoiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TknguyenlieuthoiEntity _TknguyenlieuthoiEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TknguyenlieuthoiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Manguyenlieu, System.String Tennguyenlieu, System.Decimal Klnhap, System.Decimal Klxuat)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity(Id);
				if (adapter.FetchEntity(_TknguyenlieuthoiEntity))
				{
				
					
					
					_TknguyenlieuthoiEntity.Ngay = Ngay;
					
					_TknguyenlieuthoiEntity.Ca = Ca;
					
					_TknguyenlieuthoiEntity.Manguyenlieu = Manguyenlieu;
					
					_TknguyenlieuthoiEntity.Tennguyenlieu = Tennguyenlieu;
					
					_TknguyenlieuthoiEntity.Klnhap = Klnhap;
					
					_TknguyenlieuthoiEntity.Klxuat = Klxuat;
						

					adapter.SaveEntity(_TknguyenlieuthoiEntity, true);
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
				TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity(Id);
				if (adapter.FetchEntity(_TknguyenlieuthoiEntity))
				{
					adapter.DeleteEntity(_TknguyenlieuthoiEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManguyenlieu(System.String Manguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennguyenlieu(System.String Tennguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKlnhap(System.Decimal Klnhap)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Klnhap == Klnhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKlxuat(System.Decimal Klxuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Klxuat == Klxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TknguyenlieuthoiEntity", filter);
			}
			return toReturn;
		}		
			
		
		public TknguyenlieuthoiEntity SelectOne(System.Int64 Id)
		{
			TknguyenlieuthoiEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TknguyenlieuthoiEntity _TknguyenlieuthoiEntity = new TknguyenlieuthoiEntity(Id);
				if (adapter.FetchEntity(_TknguyenlieuthoiEntity))
				{
					toReturn = _TknguyenlieuthoiEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection( new TknguyenlieuthoiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, null, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, filter, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, filter, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, filter, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManguyenlieu(System.String Manguyenlieu)
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, filter, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByManguyenlieuRDT(System.String Manguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Manguyenlieu == Manguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennguyenlieu(System.String Tennguyenlieu)
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, filter, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByTennguyenlieuRDT(System.String Tennguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKlnhap(System.Decimal Klnhap)
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Klnhap == Klnhap);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, filter, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByKlnhapRDT(System.Decimal Klnhap)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Klnhap == Klnhap);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKlxuat(System.Decimal Klxuat)
		{
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Klxuat == Klxuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TknguyenlieuthoiCollection, filter, 0, null);
			}
			return _TknguyenlieuthoiCollection;
		}
		// Return DataTable
		public DataTable SelectByKlxuatRDT(System.Decimal Klxuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TknguyenlieuthoiCollection = new EntityCollection(new TknguyenlieuthoiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TknguyenlieuthoiFields.Klxuat == Klxuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TknguyenlieuthoiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
