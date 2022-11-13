


/*
'===============================================================================
'  GD.BBPH.BL.HangtralaiManagerBase
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
	public class HangtralaiManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Sophieugiao="Sophieugiao";				
		
		public const String Field_Ngaygiao="Ngaygiao";				
		
		public const String Field_Madon="Madon";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Ngaydat="Ngaydat";				
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tenhang="Tenhang";				
		
		public const String Field_Soluonggiao="Soluonggiao";				
		
		public const String Field_Soluongtralai="Soluongtralai";				
		
		public const String Field_Ngaytra="Ngaytra";				
		
		public const String Field_Nguyennhan="Nguyennhan";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HangtralaiManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Sophieugiao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaygiao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Madon,typeof(System.String));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaydat,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tenhang,typeof(System.String));
			
			dt.Columns.Add(Field_Soluonggiao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Soluongtralai,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytra,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguyennhan,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(HangtralaiEntity _HangtralaiEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_HangtralaiEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Sophieugiao]=_HangtralaiEntity.Sophieugiao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaygiao]=_HangtralaiEntity.Ngaygiao;
			}
			catch { }
			
			try
			{
				r[Field_Madon]=_HangtralaiEntity.Madon;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_HangtralaiEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_HangtralaiEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Ngaydat]=_HangtralaiEntity.Ngaydat;
			}
			catch { }
			
			try
			{
				r[Field_Masp]=_HangtralaiEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tenhang]=_HangtralaiEntity.Tenhang;
			}
			catch { }
			
			try
			{
				r[Field_Soluonggiao]=_HangtralaiEntity.Soluonggiao;
			}
			catch { }
			
			try
			{
				r[Field_Soluongtralai]=_HangtralaiEntity.Soluongtralai;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytra]=_HangtralaiEntity.Ngaytra;
			}
			catch { }
			
			try
			{
				r[Field_Nguyennhan]=_HangtralaiEntity.Nguyennhan;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_HangtralaiEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_HangtralaiEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_HangtralaiEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_HangtralaiEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public HangtralaiEntity Convert(DataRow r)
		{	
			
			HangtralaiEntity _HangtralaiEntity=new HangtralaiEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_HangtralaiEntity.Sophieugiao= r[Field_Sophieugiao].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Ngaygiao= System.DateTime.Parse(r[Field_Ngaygiao].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Madon= r[Field_Madon].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Ngaydat= System.DateTime.Parse(r[Field_Ngaydat].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Masp= r[Field_Masp].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Tenhang= r[Field_Tenhang].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Soluonggiao= System.Decimal.Parse(r[Field_Soluonggiao].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Soluongtralai= System.Decimal.Parse(r[Field_Soluongtralai].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Ngaytra= System.DateTime.Parse(r[Field_Ngaytra].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Nguyennhan= r[Field_Nguyennhan].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_HangtralaiEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _HangtralaiEntity;
		}			
		
		public HangtralaiEntity Convert_Entity(HangtralaiEntity _HangtralaiEntity,HangtralaiEntity _HangtralaiEntity_XML)
		{	
			
			
			_HangtralaiEntity.Id= _HangtralaiEntity_XML.Id;
			
			_HangtralaiEntity.Sophieugiao= _HangtralaiEntity_XML.Sophieugiao;
			
			_HangtralaiEntity.Ngaygiao= _HangtralaiEntity_XML.Ngaygiao;
			
			_HangtralaiEntity.Madon= _HangtralaiEntity_XML.Madon;
			
			_HangtralaiEntity.Makhach= _HangtralaiEntity_XML.Makhach;
			
			_HangtralaiEntity.Tenkhach= _HangtralaiEntity_XML.Tenkhach;
			
			_HangtralaiEntity.Ngaydat= _HangtralaiEntity_XML.Ngaydat;
			
			_HangtralaiEntity.Masp= _HangtralaiEntity_XML.Masp;
			
			_HangtralaiEntity.Tenhang= _HangtralaiEntity_XML.Tenhang;
			
			_HangtralaiEntity.Soluonggiao= _HangtralaiEntity_XML.Soluonggiao;
			
			_HangtralaiEntity.Soluongtralai= _HangtralaiEntity_XML.Soluongtralai;
			
			_HangtralaiEntity.Ngaytra= _HangtralaiEntity_XML.Ngaytra;
			
			_HangtralaiEntity.Nguyennhan= _HangtralaiEntity_XML.Nguyennhan;
			
			_HangtralaiEntity.Ngaytao= _HangtralaiEntity_XML.Ngaytao;
			
			_HangtralaiEntity.Nguoitao= _HangtralaiEntity_XML.Nguoitao;
			
			_HangtralaiEntity.Ngaysua= _HangtralaiEntity_XML.Ngaysua;
			
			_HangtralaiEntity.Nguoisua= _HangtralaiEntity_XML.Nguoisua;
									
				
			return _HangtralaiEntity;
		}	
		
		public String InsertV2(HangtralaiEntity _HangtralaiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new HangtralaiManagerBase()).Insert(_HangtralaiEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_HangtralaiEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Sophieugiao,_HangtralaiEntity.Sophieugiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_HangtralaiEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_HangtralaiEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HangtralaiEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HangtralaiEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_HangtralaiEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_HangtralaiEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_HangtralaiEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluonggiao,_HangtralaiEntity.Soluonggiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluongtralai,_HangtralaiEntity.Soluongtralai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytra,_HangtralaiEntity.Ngaytra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguyennhan,_HangtralaiEntity.Nguyennhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HangtralaiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HangtralaiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HangtralaiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HangtralaiEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(HangtralaiEntity _HangtralaiEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new HangtralaiManagerBase()).Update(_HangtralaiEntity);
			r.SetField(Field_Id,_HangtralaiEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Sophieugiao,_HangtralaiEntity.Sophieugiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaygiao,_HangtralaiEntity.Ngaygiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Madon,_HangtralaiEntity.Madon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_HangtralaiEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_HangtralaiEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaydat,_HangtralaiEntity.Ngaydat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masp,_HangtralaiEntity.Masp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenhang,_HangtralaiEntity.Tenhang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluonggiao,_HangtralaiEntity.Soluonggiao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Soluongtralai,_HangtralaiEntity.Soluongtralai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytra,_HangtralaiEntity.Ngaytra);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguyennhan,_HangtralaiEntity.Nguyennhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_HangtralaiEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_HangtralaiEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_HangtralaiEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_HangtralaiEntity.Nguoisua);
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

		public HangtralaiEntity Insert(HangtralaiEntity HangtralaiEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(HangtralaiEntity, true);
			}
			return HangtralaiEntity;
		}

		public HangtralaiEntity Insert(System.Int64  Id, System.String  Sophieugiao, System.DateTime  Ngaygiao, System.String  Madon, System.String  Makhach, System.String  Tenkhach, System.DateTime  Ngaydat, System.String  Masp, System.String  Tenhang, System.Decimal  Soluonggiao, System.Decimal  Soluongtralai, System.DateTime  Ngaytra, System.String  Nguyennhan, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HangtralaiEntity.Id = Id;
				
				_HangtralaiEntity.Sophieugiao = Sophieugiao;
				
				_HangtralaiEntity.Ngaygiao = Ngaygiao;
				
				_HangtralaiEntity.Madon = Madon;
				
				_HangtralaiEntity.Makhach = Makhach;
				
				_HangtralaiEntity.Tenkhach = Tenkhach;
				
				_HangtralaiEntity.Ngaydat = Ngaydat;
				
				_HangtralaiEntity.Masp = Masp;
				
				_HangtralaiEntity.Tenhang = Tenhang;
				
				_HangtralaiEntity.Soluonggiao = Soluonggiao;
				
				_HangtralaiEntity.Soluongtralai = Soluongtralai;
				
				_HangtralaiEntity.Ngaytra = Ngaytra;
				
				_HangtralaiEntity.Nguyennhan = Nguyennhan;
				
				_HangtralaiEntity.Ngaytao = Ngaytao;
				
				_HangtralaiEntity.Nguoitao = Nguoitao;
				
				_HangtralaiEntity.Ngaysua = Ngaysua;
				
				_HangtralaiEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_HangtralaiEntity, true);
			}
			return _HangtralaiEntity;
		}

		public HangtralaiEntity Insert(System.String Sophieugiao, System.DateTime Ngaygiao, System.String Madon, System.String Makhach, System.String Tenkhach, System.DateTime Ngaydat, System.String Masp, System.String Tenhang, System.Decimal Soluonggiao, System.Decimal Soluongtralai, System.DateTime Ngaytra, System.String Nguyennhan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_HangtralaiEntity.Sophieugiao = Sophieugiao;
				
				_HangtralaiEntity.Ngaygiao = Ngaygiao;
				
				_HangtralaiEntity.Madon = Madon;
				
				_HangtralaiEntity.Makhach = Makhach;
				
				_HangtralaiEntity.Tenkhach = Tenkhach;
				
				_HangtralaiEntity.Ngaydat = Ngaydat;
				
				_HangtralaiEntity.Masp = Masp;
				
				_HangtralaiEntity.Tenhang = Tenhang;
				
				_HangtralaiEntity.Soluonggiao = Soluonggiao;
				
				_HangtralaiEntity.Soluongtralai = Soluongtralai;
				
				_HangtralaiEntity.Ngaytra = Ngaytra;
				
				_HangtralaiEntity.Nguyennhan = Nguyennhan;
				
				_HangtralaiEntity.Ngaytao = Ngaytao;
				
				_HangtralaiEntity.Nguoitao = Nguoitao;
				
				_HangtralaiEntity.Ngaysua = Ngaysua;
				
				_HangtralaiEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_HangtralaiEntity, true);
			}
			return _HangtralaiEntity;
		}

		public bool Update(HangtralaiEntity _HangtralaiEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(HangtralaiFields.Id == _HangtralaiEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HangtralaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HangtralaiEntity _HangtralaiEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HangtralaiEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.String Sophieugiao, System.DateTime Ngaygiao, System.String Madon, System.String Makhach, System.String Tenkhach, System.DateTime Ngaydat, System.String Masp, System.String Tenhang, System.Decimal Soluonggiao, System.Decimal Soluongtralai, System.DateTime Ngaytra, System.String Nguyennhan, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity(Id);
				if (adapter.FetchEntity(_HangtralaiEntity))
				{
				
					
					
					_HangtralaiEntity.Sophieugiao = Sophieugiao;
					
					_HangtralaiEntity.Ngaygiao = Ngaygiao;
					
					_HangtralaiEntity.Madon = Madon;
					
					_HangtralaiEntity.Makhach = Makhach;
					
					_HangtralaiEntity.Tenkhach = Tenkhach;
					
					_HangtralaiEntity.Ngaydat = Ngaydat;
					
					_HangtralaiEntity.Masp = Masp;
					
					_HangtralaiEntity.Tenhang = Tenhang;
					
					_HangtralaiEntity.Soluonggiao = Soluonggiao;
					
					_HangtralaiEntity.Soluongtralai = Soluongtralai;
					
					_HangtralaiEntity.Ngaytra = Ngaytra;
					
					_HangtralaiEntity.Nguyennhan = Nguyennhan;
					
					_HangtralaiEntity.Ngaytao = Ngaytao;
					
					_HangtralaiEntity.Nguoitao = Nguoitao;
					
					_HangtralaiEntity.Ngaysua = Ngaysua;
					
					_HangtralaiEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_HangtralaiEntity, true);
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
				HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity(Id);
				if (adapter.FetchEntity(_HangtralaiEntity))
				{
					adapter.DeleteEntity(_HangtralaiEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HangtralaiEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySophieugiao(System.String Sophieugiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaygiao(System.DateTime Ngaygiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMadon(System.String Madon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaydat(System.DateTime Ngaydat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenhang(System.String Tenhang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluonggiao(System.Decimal Soluonggiao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySoluongtralai(System.Decimal Soluongtralai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluongtralai == Soluongtralai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytra(System.DateTime Ngaytra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytra == Ngaytra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguyennhan(System.String Nguyennhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguyennhan == Nguyennhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HangtralaiEntity", filter);
			}
			return toReturn;
		}		
			
		
		public HangtralaiEntity SelectOne(System.Int64 Id)
		{
			HangtralaiEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HangtralaiEntity _HangtralaiEntity = new HangtralaiEntity(Id);
				if (adapter.FetchEntity(_HangtralaiEntity))
				{
					toReturn = _HangtralaiEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _HangtralaiCollection = new EntityCollection( new HangtralaiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, null, 0, null);
			}
			return _HangtralaiCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySophieugiao(System.String Sophieugiao)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectBySophieugiaoRDT(System.String Sophieugiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Sophieugiao == Sophieugiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaygiao(System.DateTime Ngaygiao)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaygiaoRDT(System.DateTime Ngaygiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaygiao == Ngaygiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMadon(System.String Madon)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByMadonRDT(System.String Madon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Madon == Madon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaydat(System.DateTime Ngaydat)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaydatRDT(System.DateTime Ngaydat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaydat == Ngaydat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenhang(System.String Tenhang)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByTenhangRDT(System.String Tenhang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Tenhang == Tenhang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluonggiao(System.Decimal Soluonggiao)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluonggiaoRDT(System.Decimal Soluonggiao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluonggiao == Soluonggiao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySoluongtralai(System.Decimal Soluongtralai)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluongtralai == Soluongtralai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectBySoluongtralaiRDT(System.Decimal Soluongtralai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Soluongtralai == Soluongtralai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytra(System.DateTime Ngaytra)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytra == Ngaytra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytraRDT(System.DateTime Ngaytra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytra == Ngaytra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguyennhan(System.String Nguyennhan)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguyennhan == Nguyennhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguyennhanRDT(System.String Nguyennhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguyennhan == Nguyennhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HangtralaiCollection, filter, 0, null);
			}
			return _HangtralaiCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HangtralaiCollection = new EntityCollection(new HangtralaiEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HangtralaiFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HangtralaiCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(HangtralaiFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
