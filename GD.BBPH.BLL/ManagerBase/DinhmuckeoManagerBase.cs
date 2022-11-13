


/*
'===============================================================================
'  GD.BBPH.BL.DinhmuckeoManagerBase
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
	public class DinhmuckeoManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Madinhmuc="Madinhmuc";				
		
		public const String Field_Tendinhmuc="Tendinhmuc";				
		
		public const String Field_Tenrutgon="Tenrutgon";				
		
		public const String Field_Makeo="Makeo";				
		
		public const String Field_Tenkeo="Tenkeo";				
		
		public const String Field_Madongran="Madongran";				
		
		public const String Field_Tendongran="Tendongran";				
		
		public const String Field_Hamluongkeo="Hamluongkeo";				
		
		public const String Field_Hamluongdongran="Hamluongdongran";				
		
		public const String Field_Tylephakeo="Tylephakeo";				
		
		public const String Field_Tylephadongran="Tylephadongran";				
		
		public const String Field_Dungmoi="Dungmoi";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmuckeoManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Madinhmuc,typeof(System.String));
			
			dt.Columns.Add(Field_Tendinhmuc,typeof(System.String));
			
			dt.Columns.Add(Field_Tenrutgon,typeof(System.String));
			
			dt.Columns.Add(Field_Makeo,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkeo,typeof(System.String));
			
			dt.Columns.Add(Field_Madongran,typeof(System.String));
			
			dt.Columns.Add(Field_Tendongran,typeof(System.String));
			
			dt.Columns.Add(Field_Hamluongkeo,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Hamluongdongran,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tylephakeo,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tylephadongran,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dungmoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DinhmuckeoEntity _DinhmuckeoEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Madinhmuc]=_DinhmuckeoEntity.Madinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Tendinhmuc]=_DinhmuckeoEntity.Tendinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Tenrutgon]=_DinhmuckeoEntity.Tenrutgon;
			}
			catch { }
			
			try
			{
				r[Field_Makeo]=_DinhmuckeoEntity.Makeo;
			}
			catch { }
			
			try
			{
				r[Field_Tenkeo]=_DinhmuckeoEntity.Tenkeo;
			}
			catch { }
			
			try
			{
				r[Field_Madongran]=_DinhmuckeoEntity.Madongran;
			}
			catch { }
			
			try
			{
				r[Field_Tendongran]=_DinhmuckeoEntity.Tendongran;
			}
			catch { }
			
			try
			{
				r[Field_Hamluongkeo]=_DinhmuckeoEntity.Hamluongkeo;
			}
			catch { }
			
			try
			{
				r[Field_Hamluongdongran]=_DinhmuckeoEntity.Hamluongdongran;
			}
			catch { }
			
			try
			{
				r[Field_Tylephakeo]=_DinhmuckeoEntity.Tylephakeo;
			}
			catch { }
			
			try
			{
				r[Field_Tylephadongran]=_DinhmuckeoEntity.Tylephadongran;
			}
			catch { }
			
			try
			{
				r[Field_Dungmoi]=_DinhmuckeoEntity.Dungmoi;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DinhmuckeoEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DinhmuckeoEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DinhmuckeoEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DinhmuckeoEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DinhmuckeoEntity Convert(DataRow r)
		{	
			
			DinhmuckeoEntity _DinhmuckeoEntity=new DinhmuckeoEntity(r[Field_Madinhmuc].ToString());					
						
			
			
			try
			{
				_DinhmuckeoEntity.Tendinhmuc= r[Field_Tendinhmuc].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Tenrutgon= r[Field_Tenrutgon].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Makeo= r[Field_Makeo].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Tenkeo= r[Field_Tenkeo].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Madongran= r[Field_Madongran].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Tendongran= r[Field_Tendongran].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Hamluongkeo= System.Decimal.Parse(r[Field_Hamluongkeo].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Hamluongdongran= System.Decimal.Parse(r[Field_Hamluongdongran].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Tylephakeo= System.Decimal.Parse(r[Field_Tylephakeo].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Tylephadongran= System.Decimal.Parse(r[Field_Tylephadongran].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Dungmoi= System.Decimal.Parse(r[Field_Dungmoi].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmuckeoEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DinhmuckeoEntity;
		}			
		
		public DinhmuckeoEntity Convert_Entity(DinhmuckeoEntity _DinhmuckeoEntity,DinhmuckeoEntity _DinhmuckeoEntity_XML)
		{	
			
			
			_DinhmuckeoEntity.Madinhmuc= _DinhmuckeoEntity_XML.Madinhmuc;
			
			_DinhmuckeoEntity.Tendinhmuc= _DinhmuckeoEntity_XML.Tendinhmuc;
			
			_DinhmuckeoEntity.Tenrutgon= _DinhmuckeoEntity_XML.Tenrutgon;
			
			_DinhmuckeoEntity.Makeo= _DinhmuckeoEntity_XML.Makeo;
			
			_DinhmuckeoEntity.Tenkeo= _DinhmuckeoEntity_XML.Tenkeo;
			
			_DinhmuckeoEntity.Madongran= _DinhmuckeoEntity_XML.Madongran;
			
			_DinhmuckeoEntity.Tendongran= _DinhmuckeoEntity_XML.Tendongran;
			
			_DinhmuckeoEntity.Hamluongkeo= _DinhmuckeoEntity_XML.Hamluongkeo;
			
			_DinhmuckeoEntity.Hamluongdongran= _DinhmuckeoEntity_XML.Hamluongdongran;
			
			_DinhmuckeoEntity.Tylephakeo= _DinhmuckeoEntity_XML.Tylephakeo;
			
			_DinhmuckeoEntity.Tylephadongran= _DinhmuckeoEntity_XML.Tylephadongran;
			
			_DinhmuckeoEntity.Dungmoi= _DinhmuckeoEntity_XML.Dungmoi;
			
			_DinhmuckeoEntity.Ngaytao= _DinhmuckeoEntity_XML.Ngaytao;
			
			_DinhmuckeoEntity.Nguoitao= _DinhmuckeoEntity_XML.Nguoitao;
			
			_DinhmuckeoEntity.Ngaysua= _DinhmuckeoEntity_XML.Ngaysua;
			
			_DinhmuckeoEntity.Nguoisua= _DinhmuckeoEntity_XML.Nguoisua;
									
				
			return _DinhmuckeoEntity;
		}	
		
		public String InsertV2(DinhmuckeoEntity _DinhmuckeoEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DinhmuckeoManagerBase()).Insert(_DinhmuckeoEntity).Madinhmuc.ToString();
			
			
			try
			{
				r.SetField(Field_Madinhmuc,_DinhmuckeoEntity.Madinhmuc);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmuckeoEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DinhmuckeoEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makeo,_DinhmuckeoEntity.Makeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkeo,_DinhmuckeoEntity.Tenkeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madongran,_DinhmuckeoEntity.Madongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tendongran,_DinhmuckeoEntity.Tendongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hamluongkeo,_DinhmuckeoEntity.Hamluongkeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hamluongdongran,_DinhmuckeoEntity.Hamluongdongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylephakeo,_DinhmuckeoEntity.Tylephakeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylephadongran,_DinhmuckeoEntity.Tylephadongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmoi,_DinhmuckeoEntity.Dungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmuckeoEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmuckeoEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmuckeoEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmuckeoEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DinhmuckeoEntity _DinhmuckeoEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DinhmuckeoManagerBase()).Update(_DinhmuckeoEntity);
			r.SetField(Field_Madinhmuc,_DinhmuckeoEntity.Madinhmuc);
									
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmuckeoEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenrutgon,_DinhmuckeoEntity.Tenrutgon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makeo,_DinhmuckeoEntity.Makeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkeo,_DinhmuckeoEntity.Tenkeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madongran,_DinhmuckeoEntity.Madongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tendongran,_DinhmuckeoEntity.Tendongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hamluongkeo,_DinhmuckeoEntity.Hamluongkeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hamluongdongran,_DinhmuckeoEntity.Hamluongdongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylephakeo,_DinhmuckeoEntity.Tylephakeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tylephadongran,_DinhmuckeoEntity.Tylephadongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmoi,_DinhmuckeoEntity.Dungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmuckeoEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmuckeoEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmuckeoEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmuckeoEntity.Nguoisua);
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

		public DinhmuckeoEntity Insert(DinhmuckeoEntity DinhmuckeoEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DinhmuckeoEntity, true);
			}
			return DinhmuckeoEntity;
		}

		public DinhmuckeoEntity Insert(System.String  Madinhmuc, System.String  Tendinhmuc, System.String  Tenrutgon, System.String  Makeo, System.String  Tenkeo, System.String  Madongran, System.String  Tendongran, System.Decimal  Hamluongkeo, System.Decimal  Hamluongdongran, System.Decimal  Tylephakeo, System.Decimal  Tylephadongran, System.Decimal  Dungmoi, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DinhmuckeoEntity.Madinhmuc = Madinhmuc;
				
				_DinhmuckeoEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmuckeoEntity.Tenrutgon = Tenrutgon;
				
				_DinhmuckeoEntity.Makeo = Makeo;
				
				_DinhmuckeoEntity.Tenkeo = Tenkeo;
				
				_DinhmuckeoEntity.Madongran = Madongran;
				
				_DinhmuckeoEntity.Tendongran = Tendongran;
				
				_DinhmuckeoEntity.Hamluongkeo = Hamluongkeo;
				
				_DinhmuckeoEntity.Hamluongdongran = Hamluongdongran;
				
				_DinhmuckeoEntity.Tylephakeo = Tylephakeo;
				
				_DinhmuckeoEntity.Tylephadongran = Tylephadongran;
				
				_DinhmuckeoEntity.Dungmoi = Dungmoi;
				
				_DinhmuckeoEntity.Ngaytao = Ngaytao;
				
				_DinhmuckeoEntity.Nguoitao = Nguoitao;
				
				_DinhmuckeoEntity.Ngaysua = Ngaysua;
				
				_DinhmuckeoEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DinhmuckeoEntity, true);
			}
			return _DinhmuckeoEntity;
		}

		public DinhmuckeoEntity Insert(System.String Tendinhmuc, System.String Tenrutgon, System.String Makeo, System.String Tenkeo, System.String Madongran, System.String Tendongran, System.Decimal Hamluongkeo, System.Decimal Hamluongdongran, System.Decimal Tylephakeo, System.Decimal Tylephadongran, System.Decimal Dungmoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DinhmuckeoEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmuckeoEntity.Tenrutgon = Tenrutgon;
				
				_DinhmuckeoEntity.Makeo = Makeo;
				
				_DinhmuckeoEntity.Tenkeo = Tenkeo;
				
				_DinhmuckeoEntity.Madongran = Madongran;
				
				_DinhmuckeoEntity.Tendongran = Tendongran;
				
				_DinhmuckeoEntity.Hamluongkeo = Hamluongkeo;
				
				_DinhmuckeoEntity.Hamluongdongran = Hamluongdongran;
				
				_DinhmuckeoEntity.Tylephakeo = Tylephakeo;
				
				_DinhmuckeoEntity.Tylephadongran = Tylephadongran;
				
				_DinhmuckeoEntity.Dungmoi = Dungmoi;
				
				_DinhmuckeoEntity.Ngaytao = Ngaytao;
				
				_DinhmuckeoEntity.Nguoitao = Nguoitao;
				
				_DinhmuckeoEntity.Ngaysua = Ngaysua;
				
				_DinhmuckeoEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DinhmuckeoEntity, true);
			}
			return _DinhmuckeoEntity;
		}

		public bool Update(DinhmuckeoEntity _DinhmuckeoEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DinhmuckeoFields.Madinhmuc == _DinhmuckeoEntity.Madinhmuc);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DinhmuckeoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DinhmuckeoEntity _DinhmuckeoEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DinhmuckeoEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Madinhmuc, System.String Tendinhmuc, System.String Tenrutgon, System.String Makeo, System.String Tenkeo, System.String Madongran, System.String Tendongran, System.Decimal Hamluongkeo, System.Decimal Hamluongdongran, System.Decimal Tylephakeo, System.Decimal Tylephadongran, System.Decimal Dungmoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmuckeoEntity))
				{
				
					
					
					_DinhmuckeoEntity.Tendinhmuc = Tendinhmuc;
					
					_DinhmuckeoEntity.Tenrutgon = Tenrutgon;
					
					_DinhmuckeoEntity.Makeo = Makeo;
					
					_DinhmuckeoEntity.Tenkeo = Tenkeo;
					
					_DinhmuckeoEntity.Madongran = Madongran;
					
					_DinhmuckeoEntity.Tendongran = Tendongran;
					
					_DinhmuckeoEntity.Hamluongkeo = Hamluongkeo;
					
					_DinhmuckeoEntity.Hamluongdongran = Hamluongdongran;
					
					_DinhmuckeoEntity.Tylephakeo = Tylephakeo;
					
					_DinhmuckeoEntity.Tylephadongran = Tylephadongran;
					
					_DinhmuckeoEntity.Dungmoi = Dungmoi;
					
					_DinhmuckeoEntity.Ngaytao = Ngaytao;
					
					_DinhmuckeoEntity.Nguoitao = Nguoitao;
					
					_DinhmuckeoEntity.Ngaysua = Ngaysua;
					
					_DinhmuckeoEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DinhmuckeoEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Madinhmuc)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmuckeoEntity))
				{
					adapter.DeleteEntity(_DinhmuckeoEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", null);
			}
		}
		
		
		
		public int DeleteByMadinhmuc(System.String Madinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTendinhmuc(System.String Tendinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenrutgon(System.String Tenrutgon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakeo(System.String Makeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Makeo == Makeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkeo(System.String Tenkeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tenkeo == Tenkeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadongran(System.String Madongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Madongran == Madongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTendongran(System.String Tendongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tendongran == Tendongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHamluongkeo(System.Decimal Hamluongkeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Hamluongkeo == Hamluongkeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHamluongdongran(System.Decimal Hamluongdongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Hamluongdongran == Hamluongdongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylephakeo(System.Decimal Tylephakeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tylephakeo == Tylephakeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTylephadongran(System.Decimal Tylephadongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tylephadongran == Tylephadongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDungmoi(System.Decimal Dungmoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Dungmoi == Dungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmuckeoEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DinhmuckeoEntity SelectOne(System.String Madinhmuc)
		{
			DinhmuckeoEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmuckeoEntity _DinhmuckeoEntity = new DinhmuckeoEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmuckeoEntity))
				{
					toReturn = _DinhmuckeoEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection( new DinhmuckeoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, null, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMadinhmuc(System.String Madinhmuc)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByMadinhmucRDT(System.String Madinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTendinhmuc(System.String Tendinhmuc)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByTendinhmucRDT(System.String Tendinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenrutgon(System.String Tenrutgon)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByTenrutgonRDT(System.String Tenrutgon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tenrutgon == Tenrutgon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakeo(System.String Makeo)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Makeo == Makeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByMakeoRDT(System.String Makeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Makeo == Makeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkeo(System.String Tenkeo)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tenkeo == Tenkeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkeoRDT(System.String Tenkeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tenkeo == Tenkeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadongran(System.String Madongran)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Madongran == Madongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByMadongranRDT(System.String Madongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Madongran == Madongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTendongran(System.String Tendongran)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tendongran == Tendongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByTendongranRDT(System.String Tendongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tendongran == Tendongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHamluongkeo(System.Decimal Hamluongkeo)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Hamluongkeo == Hamluongkeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByHamluongkeoRDT(System.Decimal Hamluongkeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Hamluongkeo == Hamluongkeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHamluongdongran(System.Decimal Hamluongdongran)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Hamluongdongran == Hamluongdongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByHamluongdongranRDT(System.Decimal Hamluongdongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Hamluongdongran == Hamluongdongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylephakeo(System.Decimal Tylephakeo)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tylephakeo == Tylephakeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByTylephakeoRDT(System.Decimal Tylephakeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tylephakeo == Tylephakeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTylephadongran(System.Decimal Tylephadongran)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tylephadongran == Tylephadongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByTylephadongranRDT(System.Decimal Tylephadongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Tylephadongran == Tylephadongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDungmoi(System.Decimal Dungmoi)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Dungmoi == Dungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByDungmoiRDT(System.Decimal Dungmoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Dungmoi == Dungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmuckeoCollection, filter, 0, null);
			}
			return _DinhmuckeoCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmuckeoCollection = new EntityCollection(new DinhmuckeoEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmuckeoFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmuckeoCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DinhmuckeoFields.Madinhmuc.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
