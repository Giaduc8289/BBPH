


/*
'===============================================================================
'  GD.BBPH.BL.DmmangManagerBase
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
	public class DmmangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Mamang="Mamang";				
		
		public const String Field_Tenmang="Tenmang";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Kichthuoc="Kichthuoc";				
		
		public const String Field_Mactpt="Mactpt";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Doday="Doday";				
		
		public const String Field_Rong="Rong";				
		
		public const String Field_Maloaimang="Maloaimang";				
		
		public const String Field_Tenloaimang="Tenloaimang";				
		
		public const String Field_Maqcmang="Maqcmang";				
		
		public const String Field_Tenqcmang="Tenqcmang";				
		
		public const String Field_Trongluong="Trongluong";				
		
		public const String Field_Hesoquydoi="Hesoquydoi";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmmangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Mamang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang,typeof(System.String));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Kichthuoc,typeof(System.String));
			
			dt.Columns.Add(Field_Mactpt,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Doday,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Rong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Maloaimang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenloaimang,typeof(System.String));
			
			dt.Columns.Add(Field_Maqcmang,typeof(System.String));
			
			dt.Columns.Add(Field_Tenqcmang,typeof(System.String));
			
			dt.Columns.Add(Field_Trongluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Hesoquydoi,typeof(System.Decimal));
									
		            
			return dt;			
		}
		public DataRow Convert(DmmangEntity _DmmangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Mamang]=_DmmangEntity.Mamang;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang]=_DmmangEntity.Tenmang;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_DmmangEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_DmmangEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Kichthuoc]=_DmmangEntity.Kichthuoc;
			}
			catch { }
			
			try
			{
				r[Field_Mactpt]=_DmmangEntity.Mactpt;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmmangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmmangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmmangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmmangEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Doday]=_DmmangEntity.Doday;
			}
			catch { }
			
			try
			{
				r[Field_Rong]=_DmmangEntity.Rong;
			}
			catch { }
			
			try
			{
				r[Field_Maloaimang]=_DmmangEntity.Maloaimang;
			}
			catch { }
			
			try
			{
				r[Field_Tenloaimang]=_DmmangEntity.Tenloaimang;
			}
			catch { }
			
			try
			{
				r[Field_Maqcmang]=_DmmangEntity.Maqcmang;
			}
			catch { }
			
			try
			{
				r[Field_Tenqcmang]=_DmmangEntity.Tenqcmang;
			}
			catch { }
			
			try
			{
				r[Field_Trongluong]=_DmmangEntity.Trongluong;
			}
			catch { }
			
			try
			{
				r[Field_Hesoquydoi]=_DmmangEntity.Hesoquydoi;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmmangEntity Convert(DataRow r)
		{	
			
			DmmangEntity _DmmangEntity=new DmmangEntity(r[Field_Mamang].ToString());					
						
			
			
			try
			{
				_DmmangEntity.Tenmang= r[Field_Tenmang].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Kichthuoc= r[Field_Kichthuoc].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Mactpt= r[Field_Mactpt].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Doday= System.Decimal.Parse(r[Field_Doday].ToString());						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Rong= System.Decimal.Parse(r[Field_Rong].ToString());						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Maloaimang= r[Field_Maloaimang].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Tenloaimang= r[Field_Tenloaimang].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Maqcmang= r[Field_Maqcmang].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Tenqcmang= r[Field_Tenqcmang].ToString();						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Trongluong= System.Decimal.Parse(r[Field_Trongluong].ToString());						
			}
			catch { }
			
			try
			{
				_DmmangEntity.Hesoquydoi= System.Decimal.Parse(r[Field_Hesoquydoi].ToString());						
			}
			catch { }
									
									
			return _DmmangEntity;
		}			
		
		public DmmangEntity Convert_Entity(DmmangEntity _DmmangEntity,DmmangEntity _DmmangEntity_XML)
		{	
			
			
			_DmmangEntity.Mamang= _DmmangEntity_XML.Mamang;
			
			_DmmangEntity.Tenmang= _DmmangEntity_XML.Tenmang;
			
			_DmmangEntity.Makhach= _DmmangEntity_XML.Makhach;
			
			_DmmangEntity.Tenkhach= _DmmangEntity_XML.Tenkhach;
			
			_DmmangEntity.Kichthuoc= _DmmangEntity_XML.Kichthuoc;
			
			_DmmangEntity.Mactpt= _DmmangEntity_XML.Mactpt;
			
			_DmmangEntity.Ngaytao= _DmmangEntity_XML.Ngaytao;
			
			_DmmangEntity.Nguoitao= _DmmangEntity_XML.Nguoitao;
			
			_DmmangEntity.Ngaysua= _DmmangEntity_XML.Ngaysua;
			
			_DmmangEntity.Nguoisua= _DmmangEntity_XML.Nguoisua;
			
			_DmmangEntity.Doday= _DmmangEntity_XML.Doday;
			
			_DmmangEntity.Rong= _DmmangEntity_XML.Rong;
			
			_DmmangEntity.Maloaimang= _DmmangEntity_XML.Maloaimang;
			
			_DmmangEntity.Tenloaimang= _DmmangEntity_XML.Tenloaimang;
			
			_DmmangEntity.Maqcmang= _DmmangEntity_XML.Maqcmang;
			
			_DmmangEntity.Tenqcmang= _DmmangEntity_XML.Tenqcmang;
			
			_DmmangEntity.Trongluong= _DmmangEntity_XML.Trongluong;
			
			_DmmangEntity.Hesoquydoi= _DmmangEntity_XML.Hesoquydoi;
									
				
			return _DmmangEntity;
		}	
		
		public String InsertV2(DmmangEntity _DmmangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmmangManagerBase()).Insert(_DmmangEntity).Mamang.ToString();
			
			
			try
			{
				r.SetField(Field_Mamang,_DmmangEntity.Mamang);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenmang,_DmmangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmmangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmmangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmmangEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mactpt,_DmmangEntity.Mactpt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmmangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmmangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmmangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmmangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doday,_DmmangEntity.Doday);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Rong,_DmmangEntity.Rong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimang,_DmmangEntity.Maloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaimang,_DmmangEntity.Tenloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcmang,_DmmangEntity.Maqcmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcmang,_DmmangEntity.Tenqcmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmmangEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hesoquydoi,_DmmangEntity.Hesoquydoi);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmmangEntity _DmmangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmmangManagerBase()).Update(_DmmangEntity);
			r.SetField(Field_Mamang,_DmmangEntity.Mamang);
									
			
			
			
			try
			{
				r.SetField(Field_Tenmang,_DmmangEntity.Tenmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmmangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmmangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoc,_DmmangEntity.Kichthuoc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mactpt,_DmmangEntity.Mactpt);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmmangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmmangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmmangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmmangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doday,_DmmangEntity.Doday);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Rong,_DmmangEntity.Rong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimang,_DmmangEntity.Maloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenloaimang,_DmmangEntity.Tenloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcmang,_DmmangEntity.Maqcmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcmang,_DmmangEntity.Tenqcmang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmmangEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hesoquydoi,_DmmangEntity.Hesoquydoi);
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

		public DmmangEntity Insert(DmmangEntity DmmangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmmangEntity, true);
			}
			return DmmangEntity;
		}

		public DmmangEntity Insert(System.String  Mamang, System.String  Tenmang, System.String  Makhach, System.String  Tenkhach, System.String  Kichthuoc, System.String  Mactpt, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Doday, System.Decimal  Rong, System.String  Maloaimang, System.String  Tenloaimang, System.String  Maqcmang, System.String  Tenqcmang, System.Decimal  Trongluong, System.Decimal  Hesoquydoi)
		{
			DmmangEntity _DmmangEntity = new DmmangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmmangEntity.Mamang = Mamang;
				
				_DmmangEntity.Tenmang = Tenmang;
				
				_DmmangEntity.Makhach = Makhach;
				
				_DmmangEntity.Tenkhach = Tenkhach;
				
				_DmmangEntity.Kichthuoc = Kichthuoc;
				
				_DmmangEntity.Mactpt = Mactpt;
				
				_DmmangEntity.Ngaytao = Ngaytao;
				
				_DmmangEntity.Nguoitao = Nguoitao;
				
				_DmmangEntity.Ngaysua = Ngaysua;
				
				_DmmangEntity.Nguoisua = Nguoisua;
				
				_DmmangEntity.Doday = Doday;
				
				_DmmangEntity.Rong = Rong;
				
				_DmmangEntity.Maloaimang = Maloaimang;
				
				_DmmangEntity.Tenloaimang = Tenloaimang;
				
				_DmmangEntity.Maqcmang = Maqcmang;
				
				_DmmangEntity.Tenqcmang = Tenqcmang;
				
				_DmmangEntity.Trongluong = Trongluong;
				
				_DmmangEntity.Hesoquydoi = Hesoquydoi;
					
					
				adapter.SaveEntity(_DmmangEntity, true);
			}
			return _DmmangEntity;
		}

		public DmmangEntity Insert(System.String Tenmang, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.String Mactpt, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Doday, System.Decimal Rong, System.String Maloaimang, System.String Tenloaimang, System.String Maqcmang, System.String Tenqcmang, System.Decimal Trongluong, System.Decimal Hesoquydoi)//ko co mahieu
		{
			DmmangEntity _DmmangEntity = new DmmangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmmangEntity.Tenmang = Tenmang;
				
				_DmmangEntity.Makhach = Makhach;
				
				_DmmangEntity.Tenkhach = Tenkhach;
				
				_DmmangEntity.Kichthuoc = Kichthuoc;
				
				_DmmangEntity.Mactpt = Mactpt;
				
				_DmmangEntity.Ngaytao = Ngaytao;
				
				_DmmangEntity.Nguoitao = Nguoitao;
				
				_DmmangEntity.Ngaysua = Ngaysua;
				
				_DmmangEntity.Nguoisua = Nguoisua;
				
				_DmmangEntity.Doday = Doday;
				
				_DmmangEntity.Rong = Rong;
				
				_DmmangEntity.Maloaimang = Maloaimang;
				
				_DmmangEntity.Tenloaimang = Tenloaimang;
				
				_DmmangEntity.Maqcmang = Maqcmang;
				
				_DmmangEntity.Tenqcmang = Tenqcmang;
				
				_DmmangEntity.Trongluong = Trongluong;
				
				_DmmangEntity.Hesoquydoi = Hesoquydoi;
					

				adapter.SaveEntity(_DmmangEntity, true);
			}
			return _DmmangEntity;
		}

		public bool Update(DmmangEntity _DmmangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmmangFields.Mamang == _DmmangEntity.Mamang);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmmangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmmangEntity _DmmangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmmangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Mamang, System.String Tenmang, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.String Mactpt, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Doday, System.Decimal Rong, System.String Maloaimang, System.String Tenloaimang, System.String Maqcmang, System.String Tenqcmang, System.Decimal Trongluong, System.Decimal Hesoquydoi)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmangEntity _DmmangEntity = new DmmangEntity(Mamang);
				if (adapter.FetchEntity(_DmmangEntity))
				{
				
					
					
					_DmmangEntity.Tenmang = Tenmang;
					
					_DmmangEntity.Makhach = Makhach;
					
					_DmmangEntity.Tenkhach = Tenkhach;
					
					_DmmangEntity.Kichthuoc = Kichthuoc;
					
					_DmmangEntity.Mactpt = Mactpt;
					
					_DmmangEntity.Ngaytao = Ngaytao;
					
					_DmmangEntity.Nguoitao = Nguoitao;
					
					_DmmangEntity.Ngaysua = Ngaysua;
					
					_DmmangEntity.Nguoisua = Nguoisua;
					
					_DmmangEntity.Doday = Doday;
					
					_DmmangEntity.Rong = Rong;
					
					_DmmangEntity.Maloaimang = Maloaimang;
					
					_DmmangEntity.Tenloaimang = Tenloaimang;
					
					_DmmangEntity.Maqcmang = Maqcmang;
					
					_DmmangEntity.Tenqcmang = Tenqcmang;
					
					_DmmangEntity.Trongluong = Trongluong;
					
					_DmmangEntity.Hesoquydoi = Hesoquydoi;
						

					adapter.SaveEntity(_DmmangEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Mamang)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmangEntity _DmmangEntity = new DmmangEntity(Mamang);
				if (adapter.FetchEntity(_DmmangEntity))
				{
					adapter.DeleteEntity(_DmmangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmmangEntity", null);
			}
		}
		
		
		
		public int DeleteByMamang(System.String Mamang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang(System.String Tenmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKichthuoc(System.String Kichthuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMactpt(System.String Mactpt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDoday(System.Decimal Doday)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Doday == Doday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByRong(System.Decimal Rong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Rong == Rong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaimang(System.String Maloaimang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenloaimang(System.String Tenloaimang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenloaimang == Tenloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqcmang(System.String Maqcmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Maqcmang == Maqcmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenqcmang(System.String Tenqcmang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenqcmang == Tenqcmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrongluong(System.Decimal Trongluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHesoquydoi(System.Decimal Hesoquydoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Hesoquydoi == Hesoquydoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmmangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmmangEntity SelectOne(System.String Mamang)
		{
			DmmangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmmangEntity _DmmangEntity = new DmmangEntity(Mamang);
				if (adapter.FetchEntity(_DmmangEntity))
				{
					toReturn = _DmmangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmmangCollection = new EntityCollection( new DmmangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, null, 0, null);
			}
			return _DmmangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMamang(System.String Mamang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamangRDT(System.String Mamang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mamang == Mamang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang(System.String Tenmang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmangRDT(System.String Tenmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenmang == Tenmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKichthuoc(System.String Kichthuoc)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuocRDT(System.String Kichthuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMactpt(System.String Mactpt)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMactptRDT(System.String Mactpt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Mactpt == Mactpt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDoday(System.Decimal Doday)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Doday == Doday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByDodayRDT(System.Decimal Doday)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Doday == Doday);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByRong(System.Decimal Rong)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Rong == Rong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByRongRDT(System.Decimal Rong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Rong == Rong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaimang(System.String Maloaimang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaimangRDT(System.String Maloaimang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenloaimang(System.String Tenloaimang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenloaimang == Tenloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenloaimangRDT(System.String Tenloaimang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenloaimang == Tenloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqcmang(System.String Maqcmang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Maqcmang == Maqcmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcmangRDT(System.String Maqcmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Maqcmang == Maqcmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenqcmang(System.String Tenqcmang)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenqcmang == Tenqcmang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenqcmangRDT(System.String Tenqcmang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Tenqcmang == Tenqcmang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrongluong(System.Decimal Trongluong)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByTrongluongRDT(System.Decimal Trongluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHesoquydoi(System.Decimal Hesoquydoi)
		{
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Hesoquydoi == Hesoquydoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmmangCollection, filter, 0, null);
			}
			return _DmmangCollection;
		}
		// Return DataTable
		public DataTable SelectByHesoquydoiRDT(System.Decimal Hesoquydoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmmangCollection = new EntityCollection(new DmmangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmmangFields.Hesoquydoi == Hesoquydoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmmangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmmangFields.Mamang.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
