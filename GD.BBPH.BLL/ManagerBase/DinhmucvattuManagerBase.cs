


/*
'===============================================================================
'  GD.BBPH.BL.DinhmucvattuManagerBase
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
	public class DinhmucvattuManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Madinhmuc="Madinhmuc";				
		
		public const String Field_Tendinhmuc="Tendinhmuc";				
		
		public const String Field_Manhom="Manhom";				
		
		public const String Field_Tennhom="Tennhom";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Madongmay="Madongmay";				
		
		public const String Field_Macongdoan="Macongdoan";				
		
		public const String Field_Somauma="Somauma";				
		
		public const String Field_Maloaimuc="Maloaimuc";				
		
		public const String Field_Mamau="Mamau";				
		
		public const String Field_Maloaimang="Maloaimang";				
		
		public const String Field_Maqcthanhpham="Maqcthanhpham";				
		
		public const String Field_Dinhmuc="Dinhmuc";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmucvattuManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Madinhmuc,typeof(System.String));
			
			dt.Columns.Add(Field_Tendinhmuc,typeof(System.String));
			
			dt.Columns.Add(Field_Manhom,typeof(System.String));
			
			dt.Columns.Add(Field_Tennhom,typeof(System.String));
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Madongmay,typeof(System.String));
			
			dt.Columns.Add(Field_Macongdoan,typeof(System.String));
			
			dt.Columns.Add(Field_Somauma,typeof(System.String));
			
			dt.Columns.Add(Field_Maloaimuc,typeof(System.String));
			
			dt.Columns.Add(Field_Mamau,typeof(System.String));
			
			dt.Columns.Add(Field_Maloaimang,typeof(System.String));
			
			dt.Columns.Add(Field_Maqcthanhpham,typeof(System.String));
			
			dt.Columns.Add(Field_Dinhmuc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DinhmucvattuEntity _DinhmucvattuEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Madinhmuc]=_DinhmucvattuEntity.Madinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Tendinhmuc]=_DinhmucvattuEntity.Tendinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Manhom]=_DinhmucvattuEntity.Manhom;
			}
			catch { }
			
			try
			{
				r[Field_Tennhom]=_DinhmucvattuEntity.Tennhom;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_DinhmucvattuEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Madongmay]=_DinhmucvattuEntity.Madongmay;
			}
			catch { }
			
			try
			{
				r[Field_Macongdoan]=_DinhmucvattuEntity.Macongdoan;
			}
			catch { }
			
			try
			{
				r[Field_Somauma]=_DinhmucvattuEntity.Somauma;
			}
			catch { }
			
			try
			{
				r[Field_Maloaimuc]=_DinhmucvattuEntity.Maloaimuc;
			}
			catch { }
			
			try
			{
				r[Field_Mamau]=_DinhmucvattuEntity.Mamau;
			}
			catch { }
			
			try
			{
				r[Field_Maloaimang]=_DinhmucvattuEntity.Maloaimang;
			}
			catch { }
			
			try
			{
				r[Field_Maqcthanhpham]=_DinhmucvattuEntity.Maqcthanhpham;
			}
			catch { }
			
			try
			{
				r[Field_Dinhmuc]=_DinhmucvattuEntity.Dinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DinhmucvattuEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DinhmucvattuEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DinhmucvattuEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DinhmucvattuEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DinhmucvattuEntity Convert(DataRow r)
		{	
			
			DinhmucvattuEntity _DinhmucvattuEntity=new DinhmucvattuEntity(r[Field_Madinhmuc].ToString());					
						
			
			
			try
			{
				_DinhmucvattuEntity.Tendinhmuc= r[Field_Tendinhmuc].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Manhom= r[Field_Manhom].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Tennhom= r[Field_Tennhom].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Madongmay= r[Field_Madongmay].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Macongdoan= r[Field_Macongdoan].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Somauma= r[Field_Somauma].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Maloaimuc= r[Field_Maloaimuc].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Mamau= r[Field_Mamau].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Maloaimang= r[Field_Maloaimang].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Maqcthanhpham= r[Field_Maqcthanhpham].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Dinhmuc= System.Decimal.Parse(r[Field_Dinhmuc].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucvattuEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DinhmucvattuEntity;
		}			
		
		public DinhmucvattuEntity Convert_Entity(DinhmucvattuEntity _DinhmucvattuEntity,DinhmucvattuEntity _DinhmucvattuEntity_XML)
		{	
			
			
			_DinhmucvattuEntity.Madinhmuc= _DinhmucvattuEntity_XML.Madinhmuc;
			
			_DinhmucvattuEntity.Tendinhmuc= _DinhmucvattuEntity_XML.Tendinhmuc;
			
			_DinhmucvattuEntity.Manhom= _DinhmucvattuEntity_XML.Manhom;
			
			_DinhmucvattuEntity.Tennhom= _DinhmucvattuEntity_XML.Tennhom;
			
			_DinhmucvattuEntity.Mamay= _DinhmucvattuEntity_XML.Mamay;
			
			_DinhmucvattuEntity.Madongmay= _DinhmucvattuEntity_XML.Madongmay;
			
			_DinhmucvattuEntity.Macongdoan= _DinhmucvattuEntity_XML.Macongdoan;
			
			_DinhmucvattuEntity.Somauma= _DinhmucvattuEntity_XML.Somauma;
			
			_DinhmucvattuEntity.Maloaimuc= _DinhmucvattuEntity_XML.Maloaimuc;
			
			_DinhmucvattuEntity.Mamau= _DinhmucvattuEntity_XML.Mamau;
			
			_DinhmucvattuEntity.Maloaimang= _DinhmucvattuEntity_XML.Maloaimang;
			
			_DinhmucvattuEntity.Maqcthanhpham= _DinhmucvattuEntity_XML.Maqcthanhpham;
			
			_DinhmucvattuEntity.Dinhmuc= _DinhmucvattuEntity_XML.Dinhmuc;
			
			_DinhmucvattuEntity.Ngaytao= _DinhmucvattuEntity_XML.Ngaytao;
			
			_DinhmucvattuEntity.Nguoitao= _DinhmucvattuEntity_XML.Nguoitao;
			
			_DinhmucvattuEntity.Ngaysua= _DinhmucvattuEntity_XML.Ngaysua;
			
			_DinhmucvattuEntity.Nguoisua= _DinhmucvattuEntity_XML.Nguoisua;
									
				
			return _DinhmucvattuEntity;
		}	
		
		public String InsertV2(DinhmucvattuEntity _DinhmucvattuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DinhmucvattuManagerBase()).Insert(_DinhmucvattuEntity).Madinhmuc.ToString();
			
			
			try
			{
				r.SetField(Field_Madinhmuc,_DinhmucvattuEntity.Madinhmuc);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmucvattuEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DinhmucvattuEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DinhmucvattuEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_DinhmucvattuEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madongmay,_DinhmucvattuEntity.Madongmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoan,_DinhmucvattuEntity.Macongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somauma,_DinhmucvattuEntity.Somauma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimuc,_DinhmucvattuEntity.Maloaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamau,_DinhmucvattuEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimang,_DinhmucvattuEntity.Maloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhpham,_DinhmucvattuEntity.Maqcthanhpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuc,_DinhmucvattuEntity.Dinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmucvattuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmucvattuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmucvattuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmucvattuEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DinhmucvattuEntity _DinhmucvattuEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DinhmucvattuManagerBase()).Update(_DinhmucvattuEntity);
			r.SetField(Field_Madinhmuc,_DinhmucvattuEntity.Madinhmuc);
									
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmucvattuEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Manhom,_DinhmucvattuEntity.Manhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tennhom,_DinhmucvattuEntity.Tennhom);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_DinhmucvattuEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madongmay,_DinhmucvattuEntity.Madongmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoan,_DinhmucvattuEntity.Macongdoan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somauma,_DinhmucvattuEntity.Somauma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimuc,_DinhmucvattuEntity.Maloaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamau,_DinhmucvattuEntity.Mamau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimang,_DinhmucvattuEntity.Maloaimang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhpham,_DinhmucvattuEntity.Maqcthanhpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhmuc,_DinhmucvattuEntity.Dinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmucvattuEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmucvattuEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmucvattuEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmucvattuEntity.Nguoisua);
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

		public DinhmucvattuEntity Insert(DinhmucvattuEntity DinhmucvattuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DinhmucvattuEntity, true);
			}
			return DinhmucvattuEntity;
		}

		public DinhmucvattuEntity Insert(System.String  Madinhmuc, System.String  Tendinhmuc, System.String  Manhom, System.String  Tennhom, System.String  Mamay, System.String  Madongmay, System.String  Macongdoan, System.String  Somauma, System.String  Maloaimuc, System.String  Mamau, System.String  Maloaimang, System.String  Maqcthanhpham, System.Decimal  Dinhmuc, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DinhmucvattuEntity.Madinhmuc = Madinhmuc;
				
				_DinhmucvattuEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmucvattuEntity.Manhom = Manhom;
				
				_DinhmucvattuEntity.Tennhom = Tennhom;
				
				_DinhmucvattuEntity.Mamay = Mamay;
				
				_DinhmucvattuEntity.Madongmay = Madongmay;
				
				_DinhmucvattuEntity.Macongdoan = Macongdoan;
				
				_DinhmucvattuEntity.Somauma = Somauma;
				
				_DinhmucvattuEntity.Maloaimuc = Maloaimuc;
				
				_DinhmucvattuEntity.Mamau = Mamau;
				
				_DinhmucvattuEntity.Maloaimang = Maloaimang;
				
				_DinhmucvattuEntity.Maqcthanhpham = Maqcthanhpham;
				
				_DinhmucvattuEntity.Dinhmuc = Dinhmuc;
				
				_DinhmucvattuEntity.Ngaytao = Ngaytao;
				
				_DinhmucvattuEntity.Nguoitao = Nguoitao;
				
				_DinhmucvattuEntity.Ngaysua = Ngaysua;
				
				_DinhmucvattuEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DinhmucvattuEntity, true);
			}
			return _DinhmucvattuEntity;
		}

		public DinhmucvattuEntity Insert(System.String Tendinhmuc, System.String Manhom, System.String Tennhom, System.String Mamay, System.String Madongmay, System.String Macongdoan, System.String Somauma, System.String Maloaimuc, System.String Mamau, System.String Maloaimang, System.String Maqcthanhpham, System.Decimal Dinhmuc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DinhmucvattuEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmucvattuEntity.Manhom = Manhom;
				
				_DinhmucvattuEntity.Tennhom = Tennhom;
				
				_DinhmucvattuEntity.Mamay = Mamay;
				
				_DinhmucvattuEntity.Madongmay = Madongmay;
				
				_DinhmucvattuEntity.Macongdoan = Macongdoan;
				
				_DinhmucvattuEntity.Somauma = Somauma;
				
				_DinhmucvattuEntity.Maloaimuc = Maloaimuc;
				
				_DinhmucvattuEntity.Mamau = Mamau;
				
				_DinhmucvattuEntity.Maloaimang = Maloaimang;
				
				_DinhmucvattuEntity.Maqcthanhpham = Maqcthanhpham;
				
				_DinhmucvattuEntity.Dinhmuc = Dinhmuc;
				
				_DinhmucvattuEntity.Ngaytao = Ngaytao;
				
				_DinhmucvattuEntity.Nguoitao = Nguoitao;
				
				_DinhmucvattuEntity.Ngaysua = Ngaysua;
				
				_DinhmucvattuEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DinhmucvattuEntity, true);
			}
			return _DinhmucvattuEntity;
		}

		public bool Update(DinhmucvattuEntity _DinhmucvattuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DinhmucvattuFields.Madinhmuc == _DinhmucvattuEntity.Madinhmuc);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DinhmucvattuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DinhmucvattuEntity _DinhmucvattuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DinhmucvattuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Madinhmuc, System.String Tendinhmuc, System.String Manhom, System.String Tennhom, System.String Mamay, System.String Madongmay, System.String Macongdoan, System.String Somauma, System.String Maloaimuc, System.String Mamau, System.String Maloaimang, System.String Maqcthanhpham, System.Decimal Dinhmuc, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmucvattuEntity))
				{
				
					
					
					_DinhmucvattuEntity.Tendinhmuc = Tendinhmuc;
					
					_DinhmucvattuEntity.Manhom = Manhom;
					
					_DinhmucvattuEntity.Tennhom = Tennhom;
					
					_DinhmucvattuEntity.Mamay = Mamay;
					
					_DinhmucvattuEntity.Madongmay = Madongmay;
					
					_DinhmucvattuEntity.Macongdoan = Macongdoan;
					
					_DinhmucvattuEntity.Somauma = Somauma;
					
					_DinhmucvattuEntity.Maloaimuc = Maloaimuc;
					
					_DinhmucvattuEntity.Mamau = Mamau;
					
					_DinhmucvattuEntity.Maloaimang = Maloaimang;
					
					_DinhmucvattuEntity.Maqcthanhpham = Maqcthanhpham;
					
					_DinhmucvattuEntity.Dinhmuc = Dinhmuc;
					
					_DinhmucvattuEntity.Ngaytao = Ngaytao;
					
					_DinhmucvattuEntity.Nguoitao = Nguoitao;
					
					_DinhmucvattuEntity.Ngaysua = Ngaysua;
					
					_DinhmucvattuEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DinhmucvattuEntity, true);
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
				DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmucvattuEntity))
				{
					adapter.DeleteEntity(_DinhmucvattuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", null);
			}
		}
		
		
		
		public int DeleteByMadinhmuc(System.String Madinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTendinhmuc(System.String Tendinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManhom(System.String Manhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTennhom(System.String Tennhom)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadongmay(System.String Madongmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Madongmay == Madongmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongdoan(System.String Macongdoan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Macongdoan == Macongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomauma(System.String Somauma)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Somauma == Somauma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaimuc(System.String Maloaimuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maloaimuc == Maloaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamau(System.String Mamau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaimang(System.String Maloaimang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqcthanhpham(System.String Maqcthanhpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maqcthanhpham == Maqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhmuc(System.Decimal Dinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Dinhmuc == Dinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucvattuEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DinhmucvattuEntity SelectOne(System.String Madinhmuc)
		{
			DinhmucvattuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmucvattuEntity _DinhmucvattuEntity = new DinhmucvattuEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmucvattuEntity))
				{
					toReturn = _DinhmucvattuEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection( new DinhmucvattuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, null, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMadinhmuc(System.String Madinhmuc)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMadinhmucRDT(System.String Madinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTendinhmuc(System.String Tendinhmuc)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByTendinhmucRDT(System.String Tendinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManhom(System.String Manhom)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByManhomRDT(System.String Manhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Manhom == Manhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTennhom(System.String Tennhom)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByTennhomRDT(System.String Tennhom)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Tennhom == Tennhom);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadongmay(System.String Madongmay)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Madongmay == Madongmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMadongmayRDT(System.String Madongmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Madongmay == Madongmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongdoan(System.String Macongdoan)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Macongdoan == Macongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongdoanRDT(System.String Macongdoan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Macongdoan == Macongdoan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomauma(System.String Somauma)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Somauma == Somauma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectBySomaumaRDT(System.String Somauma)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Somauma == Somauma);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaimuc(System.String Maloaimuc)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maloaimuc == Maloaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaimucRDT(System.String Maloaimuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maloaimuc == Maloaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamau(System.String Mamau)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMamauRDT(System.String Mamau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Mamau == Mamau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaimang(System.String Maloaimang)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaimangRDT(System.String Maloaimang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maloaimang == Maloaimang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqcthanhpham(System.String Maqcthanhpham)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maqcthanhpham == Maqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcthanhphamRDT(System.String Maqcthanhpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Maqcthanhpham == Maqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhmuc(System.Decimal Dinhmuc)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Dinhmuc == Dinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhmucRDT(System.Decimal Dinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Dinhmuc == Dinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucvattuCollection, filter, 0, null);
			}
			return _DinhmucvattuCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucvattuCollection = new EntityCollection(new DinhmucvattuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucvattuFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucvattuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DinhmucvattuFields.Madinhmuc.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
