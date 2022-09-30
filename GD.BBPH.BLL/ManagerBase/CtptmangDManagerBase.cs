﻿


/*
'===============================================================================
'  GD.BBPH.BL.CtptmangDManagerBase
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
	public class CtptmangDManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_IdH="IdH";				
		
		public const String Field_Mact="Mact";				
		
		public const String Field_Tenct="Tenct";				
		
		public const String Field_Manl="Manl";				
		
		public const String Field_Tennguyenlieu="Tennguyenlieu";				
		
		public const String Field_Trongluong="Trongluong";				
		
		public const String Field_Tile="Tile";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CtptmangDManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.String));
			
			dt.Columns.Add(Field_IdH,typeof(System.String));
			
			dt.Columns.Add(Field_Mact,typeof(System.String));
			
			dt.Columns.Add(Field_Tenct,typeof(System.String));
			
			dt.Columns.Add(Field_Manl,typeof(System.String));
			
			dt.Columns.Add(Field_Tennguyenlieu,typeof(System.String));
			
			dt.Columns.Add(Field_Trongluong,typeof(System.String));
			
			dt.Columns.Add(Field_Tile,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(CtptmangDEntity _CtptmangDEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_CtptmangDEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_IdH]=_CtptmangDEntity.IdH;
			}
			catch { }
			
			try
			{
				r[Field_Mact]=_CtptmangDEntity.Mact;
			}
			catch { }
			
			try
			{
				r[Field_Tenct]=_CtptmangDEntity.Tenct;
			}
			catch { }
			
			try
			{
				r[Field_Manl]=_CtptmangDEntity.Manl;
			}
			catch { }
			
			try
			{
				r[Field_Tennguyenlieu]=_CtptmangDEntity.Tennguyenlieu;
			}
			catch { }
			
			try
			{
				r[Field_Trongluong]=_CtptmangDEntity.Trongluong;
			}
			catch { }
			
			try
			{
				r[Field_Tile]=_CtptmangDEntity.Tile;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public CtptmangDEntity Convert(DataRow r)
		{	
			
			CtptmangDEntity _CtptmangDEntity=new CtptmangDEntity(r[Field_Id].ToString());					
						
			
			
			try
			{
				_CtptmangDEntity.IdH= r[Field_IdH].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangDEntity.Mact= r[Field_Mact].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangDEntity.Tenct= r[Field_Tenct].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangDEntity.Manl= r[Field_Manl].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangDEntity.Tennguyenlieu= r[Field_Tennguyenlieu].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangDEntity.Trongluong= r[Field_Trongluong].ToString();						
			}
			catch { }
			
			try
			{
				_CtptmangDEntity.Tile= r[Field_Tile].ToString();						
			}
			catch { }
									
									
			return _CtptmangDEntity;
		}			
		
		public CtptmangDEntity Convert_Entity(CtptmangDEntity _CtptmangDEntity,CtptmangDEntity _CtptmangDEntity_XML)
		{	
			
			
			_CtptmangDEntity.Id= _CtptmangDEntity_XML.Id;
			
			_CtptmangDEntity.IdH= _CtptmangDEntity_XML.IdH;
			
			_CtptmangDEntity.Mact= _CtptmangDEntity_XML.Mact;
			
			_CtptmangDEntity.Tenct= _CtptmangDEntity_XML.Tenct;
			
			_CtptmangDEntity.Manl= _CtptmangDEntity_XML.Manl;
			
			_CtptmangDEntity.Tennguyenlieu= _CtptmangDEntity_XML.Tennguyenlieu;
			
			_CtptmangDEntity.Trongluong= _CtptmangDEntity_XML.Trongluong;
			
			_CtptmangDEntity.Tile= _CtptmangDEntity_XML.Tile;
									
				
			return _CtptmangDEntity;
		}	
		
		public String InsertV2(CtptmangDEntity _CtptmangDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new CtptmangDManagerBase()).Insert(_CtptmangDEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_CtptmangDEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_IdH,_CtptmangDEntity.IdH);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mact,_CtptmangDEntity.Mact);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenct,_CtptmangDEntity.Tenct);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manl,_CtptmangDEntity.Manl);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_CtptmangDEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_CtptmangDEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tile,_CtptmangDEntity.Tile);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(CtptmangDEntity _CtptmangDEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new CtptmangDManagerBase()).Update(_CtptmangDEntity);
			r.SetField(Field_Id,_CtptmangDEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_IdH,_CtptmangDEntity.IdH);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mact,_CtptmangDEntity.Mact);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenct,_CtptmangDEntity.Tenct);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manl,_CtptmangDEntity.Manl);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennguyenlieu,_CtptmangDEntity.Tennguyenlieu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_CtptmangDEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tile,_CtptmangDEntity.Tile);
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

		public CtptmangDEntity Insert(CtptmangDEntity CtptmangDEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(CtptmangDEntity, true);
			}
			return CtptmangDEntity;
		}

		public CtptmangDEntity Insert(System.String  Id, System.String  IdH, System.String  Mact, System.String  Tenct, System.String  Manl, System.String  Tennguyenlieu, System.String  Trongluong, System.String  Tile)
		{
			CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CtptmangDEntity.Id = Id;
				
				_CtptmangDEntity.IdH = IdH;
				
				_CtptmangDEntity.Mact = Mact;
				
				_CtptmangDEntity.Tenct = Tenct;
				
				_CtptmangDEntity.Manl = Manl;
				
				_CtptmangDEntity.Tennguyenlieu = Tennguyenlieu;
				
				_CtptmangDEntity.Trongluong = Trongluong;
				
				_CtptmangDEntity.Tile = Tile;
					
					
				adapter.SaveEntity(_CtptmangDEntity, true);
			}
			return _CtptmangDEntity;
		}

		public CtptmangDEntity Insert(System.String IdH, System.String Mact, System.String Tenct, System.String Manl, System.String Tennguyenlieu, System.String Trongluong, System.String Tile)//ko co mahieu
		{
			CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_CtptmangDEntity.IdH = IdH;
				
				_CtptmangDEntity.Mact = Mact;
				
				_CtptmangDEntity.Tenct = Tenct;
				
				_CtptmangDEntity.Manl = Manl;
				
				_CtptmangDEntity.Tennguyenlieu = Tennguyenlieu;
				
				_CtptmangDEntity.Trongluong = Trongluong;
				
				_CtptmangDEntity.Tile = Tile;
					

				adapter.SaveEntity(_CtptmangDEntity, true);
			}
			return _CtptmangDEntity;
		}

		public bool Update(CtptmangDEntity _CtptmangDEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(CtptmangDFields.Id == _CtptmangDEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CtptmangDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CtptmangDEntity _CtptmangDEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CtptmangDEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Id, System.String IdH, System.String Mact, System.String Tenct, System.String Manl, System.String Tennguyenlieu, System.String Trongluong, System.String Tile)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity(Id);
				if (adapter.FetchEntity(_CtptmangDEntity))
				{
				
					
					
					_CtptmangDEntity.IdH = IdH;
					
					_CtptmangDEntity.Mact = Mact;
					
					_CtptmangDEntity.Tenct = Tenct;
					
					_CtptmangDEntity.Manl = Manl;
					
					_CtptmangDEntity.Tennguyenlieu = Tennguyenlieu;
					
					_CtptmangDEntity.Trongluong = Trongluong;
					
					_CtptmangDEntity.Tile = Tile;
						

					adapter.SaveEntity(_CtptmangDEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity(Id);
				if (adapter.FetchEntity(_CtptmangDEntity))
				{
					adapter.DeleteEntity(_CtptmangDEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CtptmangDEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.String Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByIdH(System.String IdH)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.IdH == IdH);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMact(System.String Mact)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Mact == Mact);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenct(System.String Tenct)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tenct == Tenct);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManl(System.String Manl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennguyenlieu(System.String Tennguyenlieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrongluong(System.String Trongluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTile(System.String Tile)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tile == Tile);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CtptmangDEntity", filter);
			}
			return toReturn;
		}		
			
		
		public CtptmangDEntity SelectOne(System.String Id)
		{
			CtptmangDEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CtptmangDEntity _CtptmangDEntity = new CtptmangDEntity(Id);
				if (adapter.FetchEntity(_CtptmangDEntity))
				{
					toReturn = _CtptmangDEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _CtptmangDCollection = new EntityCollection( new CtptmangDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, null, 0, null);
			}
			return _CtptmangDCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.String Id)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.String Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByIdH(System.String IdH)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.IdH == IdH);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByIdHRDT(System.String IdH)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.IdH == IdH);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMact(System.String Mact)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Mact == Mact);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByMactRDT(System.String Mact)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Mact == Mact);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenct(System.String Tenct)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tenct == Tenct);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByTenctRDT(System.String Tenct)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tenct == Tenct);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManl(System.String Manl)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByManlRDT(System.String Manl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Manl == Manl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennguyenlieu(System.String Tennguyenlieu)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByTennguyenlieuRDT(System.String Tennguyenlieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tennguyenlieu == Tennguyenlieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrongluong(System.String Trongluong)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByTrongluongRDT(System.String Trongluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTile(System.String Tile)
		{
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tile == Tile);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CtptmangDCollection, filter, 0, null);
			}
			return _CtptmangDCollection;
		}
		// Return DataTable
		public DataTable SelectByTileRDT(System.String Tile)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CtptmangDCollection = new EntityCollection(new CtptmangDEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CtptmangDFields.Tile == Tile);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CtptmangDCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
