


/*
'===============================================================================
'  GD.BBPH.BL.DmchungloaiManagerBase
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
	public class DmchungloaiManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Machungloai="Machungloai";				
		
		public const String Field_Tenchungloai="Tenchungloai";				
		
		public const String Field_Kichthuoc="Kichthuoc";				
		
		public const String Field_Trongluong="Trongluong";				
		
		public const String Field_Somau="Somau";				
		
		public const String Field_Sohinh="Sohinh";				
		
		public const String Field_Loaimuc="Loaimuc";				
		
		public const String Field_Ghichu="Ghichu";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmchungloaiManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Machungloai,typeof(System.String));
			
			dt.Columns.Add(Field_Tenchungloai,typeof(System.String));
			
			dt.Columns.Add(Field_Kichthuoc,typeof(System.String));
			
			dt.Columns.Add(Field_Trongluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Somau,typeof(System.Int32));
			
			dt.Columns.Add(Field_Sohinh,typeof(System.Int32));
			
			dt.Columns.Add(Field_Loaimuc,typeof(System.String));
			
			dt.Columns.Add(Field_Ghichu,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmchungloaiEntity _DmchungloaiEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Machungloai]=_DmchungloaiEntity.Machungloai;
			}
			catch { }
			
			try
			{
				r[Field_Tenchungloai]=_DmchungloaiEntity.Tenchungloai;
			}
			catch { }
			
			try
			{
				r[Field_Kichthuoc]=_DmchungloaiEntity.Kichthuoc;
			}
			catch { }
			
			try
			{
				r[Field_Trongluong]=_DmchungloaiEntity.Trongluong;
			}
			catch { }
			
			try
			{
				r[Field_Somau]=_DmchungloaiEntity.Somau;
			}
			catch { }
			
			try
			{
				r[Field_Sohinh]=_DmchungloaiEntity.Sohinh;
			}
			catch { }
			
			try
			{
				r[Field_Loaimuc]=_DmchungloaiEntity.Loaimuc;
			}
			catch { }
			
			try
			{
				r[Field_Ghichu]=_DmchungloaiEntity.Ghichu;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmchungloaiEntity Convert(DataRow r)
		{	
			
			DmchungloaiEntity _DmchungloaiEntity=new DmchungloaiEntity(r[Field_Machungloai].ToString());					
						
			
			
			try
			{
				_DmchungloaiEntity.Tenchungloai= r[Field_Tenchungloai].ToString();						
			}
			catch { }
			
			try
			{
				_DmchungloaiEntity.Kichthuoc= r[Field_Kichthuoc].ToString();						
			}
			catch { }
			
			try
			{
				_DmchungloaiEntity.Trongluong= System.Decimal.Parse(r[Field_Trongluong].ToString());						
			}
			catch { }
			
			try
			{
				_DmchungloaiEntity.Somau= System.Int32.Parse(r[Field_Somau].ToString());						
			}
			catch { }
			
			try
			{
				_DmchungloaiEntity.Sohinh= System.Int32.Parse(r[Field_Sohinh].ToString());						
			}
			catch { }
			
			try
			{
				_DmchungloaiEntity.Loaimuc= r[Field_Loaimuc].ToString();						
			}
			catch { }
			
			try
			{
				_DmchungloaiEntity.Ghichu= r[Field_Ghichu].ToString();						
			}
			catch { }
									
									
			return _DmchungloaiEntity;
		}			
		
		public DmchungloaiEntity Convert_Entity(DmchungloaiEntity _DmchungloaiEntity,DmchungloaiEntity _DmchungloaiEntity_XML)
		{	
			
			
			_DmchungloaiEntity.Machungloai= _DmchungloaiEntity_XML.Machungloai;
			
			_DmchungloaiEntity.Tenchungloai= _DmchungloaiEntity_XML.Tenchungloai;
			
			_DmchungloaiEntity.Kichthuoc= _DmchungloaiEntity_XML.Kichthuoc;
			
			_DmchungloaiEntity.Trongluong= _DmchungloaiEntity_XML.Trongluong;
			
			_DmchungloaiEntity.Somau= _DmchungloaiEntity_XML.Somau;
			
			_DmchungloaiEntity.Sohinh= _DmchungloaiEntity_XML.Sohinh;
			
			_DmchungloaiEntity.Loaimuc= _DmchungloaiEntity_XML.Loaimuc;
			
			_DmchungloaiEntity.Ghichu= _DmchungloaiEntity_XML.Ghichu;
									
				
			return _DmchungloaiEntity;
		}	
		
		public String InsertV2(DmchungloaiEntity _DmchungloaiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmchungloaiManagerBase()).Insert(_DmchungloaiEntity).Machungloai.ToString();
			
			
			try
			{
				r.SetField(Field_Machungloai,_DmchungloaiEntity.Machungloai);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenchungloai,_DmchungloaiEntity.Tenchungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmchungloaiEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmchungloaiEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somau,_DmchungloaiEntity.Somau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinh,_DmchungloaiEntity.Sohinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaimuc,_DmchungloaiEntity.Loaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DmchungloaiEntity.Ghichu);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmchungloaiEntity _DmchungloaiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmchungloaiManagerBase()).Update(_DmchungloaiEntity);
			r.SetField(Field_Machungloai,_DmchungloaiEntity.Machungloai);
									
			
			
			
			try
			{
				r.SetField(Field_Tenchungloai,_DmchungloaiEntity.Tenchungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmchungloaiEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmchungloaiEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somau,_DmchungloaiEntity.Somau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinh,_DmchungloaiEntity.Sohinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaimuc,_DmchungloaiEntity.Loaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ghichu,_DmchungloaiEntity.Ghichu);
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

		public DmchungloaiEntity Insert(DmchungloaiEntity DmchungloaiEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmchungloaiEntity, true);
			}
			return DmchungloaiEntity;
		}

		public DmchungloaiEntity Insert(System.String  Machungloai, System.String  Tenchungloai, System.String  Kichthuoc, System.Decimal  Trongluong, System.Int32  Somau, System.Int32  Sohinh, System.String  Loaimuc, System.String  Ghichu)
		{
			DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmchungloaiEntity.Machungloai = Machungloai;
				
				_DmchungloaiEntity.Tenchungloai = Tenchungloai;
				
				_DmchungloaiEntity.Kichthuoc = Kichthuoc;
				
				_DmchungloaiEntity.Trongluong = Trongluong;
				
				_DmchungloaiEntity.Somau = Somau;
				
				_DmchungloaiEntity.Sohinh = Sohinh;
				
				_DmchungloaiEntity.Loaimuc = Loaimuc;
				
				_DmchungloaiEntity.Ghichu = Ghichu;
					
					
				adapter.SaveEntity(_DmchungloaiEntity, true);
			}
			return _DmchungloaiEntity;
		}

		public DmchungloaiEntity Insert(System.String Tenchungloai, System.String Kichthuoc, System.Decimal Trongluong, System.Int32 Somau, System.Int32 Sohinh, System.String Loaimuc, System.String Ghichu, )//ko co mahieu
		{
			DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmchungloaiEntity.Tenchungloai = Tenchungloai;
				
				_DmchungloaiEntity.Kichthuoc = Kichthuoc;
				
				_DmchungloaiEntity.Trongluong = Trongluong;
				
				_DmchungloaiEntity.Somau = Somau;
				
				_DmchungloaiEntity.Sohinh = Sohinh;
				
				_DmchungloaiEntity.Loaimuc = Loaimuc;
				
				_DmchungloaiEntity.Ghichu = Ghichu;
					

				adapter.SaveEntity(_DmchungloaiEntity, true);
			}
			return _DmchungloaiEntity;
		}

		public bool Update(DmchungloaiEntity _DmchungloaiEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmchungloaiFields.Machungloai == _DmchungloaiEntity.Machungloai);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmchungloaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmchungloaiEntity _DmchungloaiEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmchungloaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Machungloai, System.String Tenchungloai, System.String Kichthuoc, System.Decimal Trongluong, System.Int32 Somau, System.Int32 Sohinh, System.String Loaimuc, System.String Ghichu)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity(Machungloai);
				if (adapter.FetchEntity(_DmchungloaiEntity))
				{
				
					
					
					_DmchungloaiEntity.Tenchungloai = Tenchungloai;
					
					_DmchungloaiEntity.Kichthuoc = Kichthuoc;
					
					_DmchungloaiEntity.Trongluong = Trongluong;
					
					_DmchungloaiEntity.Somau = Somau;
					
					_DmchungloaiEntity.Sohinh = Sohinh;
					
					_DmchungloaiEntity.Loaimuc = Loaimuc;
					
					_DmchungloaiEntity.Ghichu = Ghichu;
						

					adapter.SaveEntity(_DmchungloaiEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Machungloai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity(Machungloai);
				if (adapter.FetchEntity(_DmchungloaiEntity))
				{
					adapter.DeleteEntity(_DmchungloaiEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmchungloaiEntity", null);
			}
		}
		
		
		
		public int DeleteByMachungloai(System.String Machungloai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenchungloai(System.String Tenchungloai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKichthuoc(System.String Kichthuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrongluong(System.Decimal Trongluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomau(System.Int32 Somau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohinh(System.Int32 Sohinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaimuc(System.String Loaimuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByGhichu(System.String Ghichu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmchungloaiEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmchungloaiEntity SelectOne(System.String Machungloai)
		{
			DmchungloaiEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmchungloaiEntity _DmchungloaiEntity = new DmchungloaiEntity(Machungloai);
				if (adapter.FetchEntity(_DmchungloaiEntity))
				{
					toReturn = _DmchungloaiEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection( new DmchungloaiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, null, 0, null);
			}
			return _DmchungloaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMachungloai(System.String Machungloai)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectByMachungloaiRDT(System.String Machungloai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenchungloai(System.String Tenchungloai)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectByTenchungloaiRDT(System.String Tenchungloai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKichthuoc(System.String Kichthuoc)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuocRDT(System.String Kichthuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrongluong(System.Decimal Trongluong)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectByTrongluongRDT(System.Decimal Trongluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomau(System.Int32 Somau)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectBySomauRDT(System.Int32 Somau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohinh(System.Int32 Sohinh)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectBySohinhRDT(System.Int32 Sohinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaimuc(System.String Loaimuc)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaimucRDT(System.String Loaimuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByGhichu(System.String Ghichu)
		{
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmchungloaiCollection, filter, 0, null);
			}
			return _DmchungloaiCollection;
		}
		// Return DataTable
		public DataTable SelectByGhichuRDT(System.String Ghichu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmchungloaiCollection = new EntityCollection(new DmchungloaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmchungloaiFields.Ghichu == Ghichu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmchungloaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
