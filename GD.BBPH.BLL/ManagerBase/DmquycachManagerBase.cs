


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
		
		
		public const String Field_Maquycach="Maquycach";				
		
		public const String Field_Tenquycach="Tenquycach";				
		
		public const String Field_Macongdoan="Macongdoan";				
		
		public const String Field_Tencongdoan="Tencongdoan";				
		
		public const String Field_Manhom="Manhom";				
		
		public const String Field_Tennhom="Tennhom";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Hesorieng="Hesorieng";				
		
		public const String Field_Nhomqcthanhpham="Nhomqcthanhpham";				
		
				
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
			
			
			dt.Columns.Add(Field_Maquycach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenquycach,typeof(System.String));
			
			dt.Columns.Add(Field_Macongdoan,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongdoan,typeof(System.String));
			
			dt.Columns.Add(Field_Manhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhom,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Hesorieng,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Nhomqcthanhpham,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmquycachEntity _DmquycachEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Maquycach]=_DmquycachEntity.Maquycach;
			}
			catch { }
			
			try
			{
				r[Field_Tenquycach]=_DmquycachEntity.Tenquycach;
			}
			catch { }
			
			try
			{
				r[Field_Macongdoan]=_DmquycachEntity.Macongdoan;
			}
			catch { }
			
			try
			{
				r[Field_Tencongdoan]=_DmquycachEntity.Tencongdoan;
			}
			catch { }
			
			try
			{
				r[Field_Manhom]=_DmquycachEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhom]=_DmquycachEntity.Tennhom;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmquycachEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmquycachEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmquycachEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmquycachEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Hesorieng]=_DmquycachEntity.Hesorieng;
			}
			catch { }
			
			try
			{
				r[Field_Nhomqcthanhpham]=_DmquycachEntity.Nhomqcthanhpham;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmquycachEntity Convert(DataRow r)
		{	
			
			DmquycachEntity _DmquycachEntity=new DmquycachEntity(r[Field_Maquycach].ToString());					
						
			
			
			try
			{
				_DmquycachEntity.Tenquycach= r[Field_Tenquycach].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Macongdoan= r[Field_Macongdoan].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Tencongdoan= r[Field_Tencongdoan].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Manhom= r[Field_Manhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Tennhom= r[Field_Tennhom].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Hesorieng= System.Decimal.Parse(r[Field_Hesorieng].ToString());						
			}
			catch { }
			
			try
			{
				_DmquycachEntity.Nhomqcthanhpham= r[Field_Nhomqcthanhpham].ToString();						
			}
			catch { }
									
									
			return _DmquycachEntity;
		}			
		
		public DmquycachEntity Convert_Entity(DmquycachEntity _DmquycachEntity,DmquycachEntity _DmquycachEntity_XML)
		{	
			
			
			_DmquycachEntity.Maquycach= _DmquycachEntity_XML.Maquycach;
			
			_DmquycachEntity.Tenquycach= _DmquycachEntity_XML.Tenquycach;
			
			_DmquycachEntity.Macongdoan= _DmquycachEntity_XML.Macongdoan;
			
			_DmquycachEntity.Tencongdoan= _DmquycachEntity_XML.Tencongdoan;
			
			_DmquycachEntity.Manhom= _DmquycachEntity_XML.Manhom;
			
			_DmquycachEntity.Tennhom= _DmquycachEntity_XML.Tennhom;
			
			_DmquycachEntity.Ngaytao= _DmquycachEntity_XML.Ngaytao;
			
			_DmquycachEntity.Nguoitao= _DmquycachEntity_XML.Nguoitao;
			
			_DmquycachEntity.Ngaysua= _DmquycachEntity_XML.Ngaysua;
			
			_DmquycachEntity.Nguoisua= _DmquycachEntity_XML.Nguoisua;
			
			_DmquycachEntity.Hesorieng= _DmquycachEntity_XML.Hesorieng;
			
			_DmquycachEntity.Nhomqcthanhpham= _DmquycachEntity_XML.Nhomqcthanhpham;
									
				
			return _DmquycachEntity;
		}	
		
		public String InsertV2(DmquycachEntity _DmquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmquycachManagerBase()).Insert(_DmquycachEntity).Maquycach.ToString();
			
			
			try
			{
				r.SetField(Field_Maquycach,_DmquycachEntity.Maquycach);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tenquycach,_DmquycachEntity.Tenquycach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoan,_DmquycachEntity.Macongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongdoan,_DmquycachEntity.Tencongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmquycachEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmquycachEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmquycachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmquycachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmquycachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmquycachEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hesorieng,_DmquycachEntity.Hesorieng);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nhomqcthanhpham,_DmquycachEntity.Nhomqcthanhpham);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmquycachEntity _DmquycachEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmquycachManagerBase()).Update(_DmquycachEntity);
			r.SetField(Field_Maquycach,_DmquycachEntity.Maquycach);
									
			
			
			
			try
			{
				r.SetField(Field_Tenquycach,_DmquycachEntity.Tenquycach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoan,_DmquycachEntity.Macongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongdoan,_DmquycachEntity.Tencongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DmquycachEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DmquycachEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmquycachEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmquycachEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmquycachEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmquycachEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hesorieng,_DmquycachEntity.Hesorieng);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nhomqcthanhpham,_DmquycachEntity.Nhomqcthanhpham);
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

		public DmquycachEntity Insert(System.String  Maquycach, System.String  Tenquycach, System.String  Macongdoan, System.String  Tencongdoan, System.String  Manhom, System.String  Tennhom, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Hesorieng, System.String  Nhomqcthanhpham)
		{
			DmquycachEntity _DmquycachEntity = new DmquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmquycachEntity.Maquycach = Maquycach;
				
				_DmquycachEntity.Tenquycach = Tenquycach;
				
				_DmquycachEntity.Macongdoan = Macongdoan;
				
				_DmquycachEntity.Tencongdoan = Tencongdoan;
				
				_DmquycachEntity.Manhom = Manhom;
				
				_DmquycachEntity.Tennhom = Tennhom;
				
				_DmquycachEntity.Ngaytao = Ngaytao;
				
				_DmquycachEntity.Nguoitao = Nguoitao;
				
				_DmquycachEntity.Ngaysua = Ngaysua;
				
				_DmquycachEntity.Nguoisua = Nguoisua;
				
				_DmquycachEntity.Hesorieng = Hesorieng;
				
				_DmquycachEntity.Nhomqcthanhpham = Nhomqcthanhpham;
					
					
				adapter.SaveEntity(_DmquycachEntity, true);
			}
			return _DmquycachEntity;
		}

		public DmquycachEntity Insert(System.String Tenquycach, System.String Macongdoan, System.String Tencongdoan, System.String Manhom, System.String Tennhom, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Hesorieng, System.String Nhomqcthanhpham)//ko co mahieu
		{
			DmquycachEntity _DmquycachEntity = new DmquycachEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmquycachEntity.Tenquycach = Tenquycach;
				
				_DmquycachEntity.Macongdoan = Macongdoan;
				
				_DmquycachEntity.Tencongdoan = Tencongdoan;
				
				_DmquycachEntity.Manhom = Manhom;
				
				_DmquycachEntity.Tennhom = Tennhom;
				
				_DmquycachEntity.Ngaytao = Ngaytao;
				
				_DmquycachEntity.Nguoitao = Nguoitao;
				
				_DmquycachEntity.Ngaysua = Ngaysua;
				
				_DmquycachEntity.Nguoisua = Nguoisua;
				
				_DmquycachEntity.Hesorieng = Hesorieng;
				
				_DmquycachEntity.Nhomqcthanhpham = Nhomqcthanhpham;
					

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
				
				_PredicateExpression.Add(DmquycachFields.Maquycach == _DmquycachEntity.Maquycach);
				
					
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

		public bool Update(System.String Maquycach, System.String Tenquycach, System.String Macongdoan, System.String Tencongdoan, System.String Manhom, System.String Tennhom, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Hesorieng, System.String Nhomqcthanhpham)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maquycach);
				if (adapter.FetchEntity(_DmquycachEntity))
				{
				
					
					
					_DmquycachEntity.Tenquycach = Tenquycach;
					
					_DmquycachEntity.Macongdoan = Macongdoan;
					
					_DmquycachEntity.Tencongdoan = Tencongdoan;
					
					_DmquycachEntity.Manhom = Manhom;
					
					_DmquycachEntity.Tennhom = Tennhom;
					
					_DmquycachEntity.Ngaytao = Ngaytao;
					
					_DmquycachEntity.Nguoitao = Nguoitao;
					
					_DmquycachEntity.Ngaysua = Ngaysua;
					
					_DmquycachEntity.Nguoisua = Nguoisua;
					
					_DmquycachEntity.Hesorieng = Hesorieng;
					
					_DmquycachEntity.Nhomqcthanhpham = Nhomqcthanhpham;
						

					adapter.SaveEntity(_DmquycachEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Maquycach)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maquycach);
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
		
		
		
		public int DeleteByMaquycach(System.String Maquycach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maquycach == Maquycach);
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
		
		public int DeleteByMacongdoan(System.String Macongdoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macongdoan == Macongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongdoan(System.String Tencongdoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tencongdoan == Tencongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhom(System.String Tennhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHesorieng(System.Decimal Hesorieng)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Hesorieng == Hesorieng);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNhomqcthanhpham(System.String Nhomqcthanhpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nhomqcthanhpham == Nhomqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmquycachEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmquycachEntity SelectOne(System.String Maquycach)
		{
			DmquycachEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmquycachEntity _DmquycachEntity = new DmquycachEntity(Maquycach);
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
		public EntityCollection SelectByMaquycach(System.String Maquycach)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maquycach == Maquycach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMaquycachRDT(System.String Maquycach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Maquycach == Maquycach);
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
		public EntityCollection SelectByMacongdoan(System.String Macongdoan)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macongdoan == Macongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongdoanRDT(System.String Macongdoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Macongdoan == Macongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongdoan(System.String Tencongdoan)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tencongdoan == Tencongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongdoanRDT(System.String Tencongdoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tencongdoan == Tencongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhom(System.String Tennhom)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomRDT(System.String Tennhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHesorieng(System.Decimal Hesorieng)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Hesorieng == Hesorieng);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByHesoriengRDT(System.Decimal Hesorieng)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Hesorieng == Hesorieng);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNhomqcthanhpham(System.String Nhomqcthanhpham)
		{
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nhomqcthanhpham == Nhomqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmquycachCollection, filter, 0, null);
			}
			return _DmquycachCollection;
		}
		// Return DataTable
		public DataTable SelectByNhomqcthanhphamRDT(System.String Nhomqcthanhpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmquycachCollection = new EntityCollection(new DmquycachEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmquycachFields.Nhomqcthanhpham == Nhomqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmquycachCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmquycachFields.Maquycach.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
