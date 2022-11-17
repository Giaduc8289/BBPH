


/*
'===============================================================================
'  GD.BBPH.BL.DinhmucthoigianManagerBase
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
	public class DinhmucthoigianManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Madinhmuc="Madinhmuc";				
		
		public const String Field_Tendinhmuc="Tendinhmuc";				
		
		public const String Field_Dodaytu="Dodaytu";				
		
		public const String Field_Dodayden="Dodayden";				
		
		public const String Field_Khotu="Khotu";				
		
		public const String Field_Khoden="Khoden";				
		
		public const String Field_Chieudaitu="Chieudaitu";				
		
		public const String Field_Chieudaiden="Chieudaiden";				
		
		public const String Field_Mamays="Mamays";				
		
		public const String Field_Macongdoans="Macongdoans";				
		
		public const String Field_Somaumas="Somaumas";				
		
		public const String Field_Sohinhmas="Sohinhmas";				
		
		public const String Field_Maloaimangs="Maloaimangs";				
		
		public const String Field_Maqcthanhphams="Maqcthanhphams";				
		
		public const String Field_Makhachs="Makhachs";				
		
		public const String Field_Mahangs="Mahangs";				
		
		public const String Field_Dauca="Dauca";				
		
		public const String Field_Chuanbi="Chuanbi";				
		
		public const String Field_Daucuon="Daucuon";				
		
		public const String Field_Doilenh="Doilenh";				
		
		public const String Field_Lencuon="Lencuon";				
		
		public const String Field_Xuongcuon="Xuongcuon";				
		
		public const String Field_Thaythietbi="Thaythietbi";				
		
		public const String Field_Dungmay="Dungmay";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DinhmucthoigianManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Madinhmuc,typeof(System.String));
			
			dt.Columns.Add(Field_Tendinhmuc,typeof(System.String));
			
			dt.Columns.Add(Field_Dodaytu,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dodayden,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Khotu,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Khoden,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chieudaitu,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chieudaiden,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Mamays,typeof(System.String));
			
			dt.Columns.Add(Field_Macongdoans,typeof(System.String));
			
			dt.Columns.Add(Field_Somaumas,typeof(System.String));
			
			dt.Columns.Add(Field_Sohinhmas,typeof(System.String));
			
			dt.Columns.Add(Field_Maloaimangs,typeof(System.String));
			
			dt.Columns.Add(Field_Maqcthanhphams,typeof(System.String));
			
			dt.Columns.Add(Field_Makhachs,typeof(System.String));
			
			dt.Columns.Add(Field_Mahangs,typeof(System.String));
			
			dt.Columns.Add(Field_Dauca,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Chuanbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Daucuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Doilenh,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Lencuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Xuongcuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thaythietbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dungmay,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DinhmucthoigianEntity _DinhmucthoigianEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Madinhmuc]=_DinhmucthoigianEntity.Madinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Tendinhmuc]=_DinhmucthoigianEntity.Tendinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Dodaytu]=_DinhmucthoigianEntity.Dodaytu;
			}
			catch { }
			
			try
			{
				r[Field_Dodayden]=_DinhmucthoigianEntity.Dodayden;
			}
			catch { }
			
			try
			{
				r[Field_Khotu]=_DinhmucthoigianEntity.Khotu;
			}
			catch { }
			
			try
			{
				r[Field_Khoden]=_DinhmucthoigianEntity.Khoden;
			}
			catch { }
			
			try
			{
				r[Field_Chieudaitu]=_DinhmucthoigianEntity.Chieudaitu;
			}
			catch { }
			
			try
			{
				r[Field_Chieudaiden]=_DinhmucthoigianEntity.Chieudaiden;
			}
			catch { }
			
			try
			{
				r[Field_Mamays]=_DinhmucthoigianEntity.Mamays;
			}
			catch { }
			
			try
			{
				r[Field_Macongdoans]=_DinhmucthoigianEntity.Macongdoans;
			}
			catch { }
			
			try
			{
				r[Field_Somaumas]=_DinhmucthoigianEntity.Somaumas;
			}
			catch { }
			
			try
			{
				r[Field_Sohinhmas]=_DinhmucthoigianEntity.Sohinhmas;
			}
			catch { }
			
			try
			{
				r[Field_Maloaimangs]=_DinhmucthoigianEntity.Maloaimangs;
			}
			catch { }
			
			try
			{
				r[Field_Maqcthanhphams]=_DinhmucthoigianEntity.Maqcthanhphams;
			}
			catch { }
			
			try
			{
				r[Field_Makhachs]=_DinhmucthoigianEntity.Makhachs;
			}
			catch { }
			
			try
			{
				r[Field_Mahangs]=_DinhmucthoigianEntity.Mahangs;
			}
			catch { }
			
			try
			{
				r[Field_Dauca]=_DinhmucthoigianEntity.Dauca;
			}
			catch { }
			
			try
			{
				r[Field_Chuanbi]=_DinhmucthoigianEntity.Chuanbi;
			}
			catch { }
			
			try
			{
				r[Field_Daucuon]=_DinhmucthoigianEntity.Daucuon;
			}
			catch { }
			
			try
			{
				r[Field_Doilenh]=_DinhmucthoigianEntity.Doilenh;
			}
			catch { }
			
			try
			{
				r[Field_Lencuon]=_DinhmucthoigianEntity.Lencuon;
			}
			catch { }
			
			try
			{
				r[Field_Xuongcuon]=_DinhmucthoigianEntity.Xuongcuon;
			}
			catch { }
			
			try
			{
				r[Field_Thaythietbi]=_DinhmucthoigianEntity.Thaythietbi;
			}
			catch { }
			
			try
			{
				r[Field_Dungmay]=_DinhmucthoigianEntity.Dungmay;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DinhmucthoigianEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DinhmucthoigianEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DinhmucthoigianEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DinhmucthoigianEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DinhmucthoigianEntity Convert(DataRow r)
		{	
			
			DinhmucthoigianEntity _DinhmucthoigianEntity=new DinhmucthoigianEntity(r[Field_Madinhmuc].ToString());					
						
			
			
			try
			{
				_DinhmucthoigianEntity.Tendinhmuc= r[Field_Tendinhmuc].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Dodaytu= System.Decimal.Parse(r[Field_Dodaytu].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Dodayden= System.Decimal.Parse(r[Field_Dodayden].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Khotu= System.Decimal.Parse(r[Field_Khotu].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Khoden= System.Decimal.Parse(r[Field_Khoden].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Chieudaitu= System.Decimal.Parse(r[Field_Chieudaitu].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Chieudaiden= System.Decimal.Parse(r[Field_Chieudaiden].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Mamays= r[Field_Mamays].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Macongdoans= r[Field_Macongdoans].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Somaumas= r[Field_Somaumas].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Sohinhmas= r[Field_Sohinhmas].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Maloaimangs= r[Field_Maloaimangs].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Maqcthanhphams= r[Field_Maqcthanhphams].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Makhachs= r[Field_Makhachs].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Mahangs= r[Field_Mahangs].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Dauca= System.Decimal.Parse(r[Field_Dauca].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Chuanbi= System.Decimal.Parse(r[Field_Chuanbi].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Daucuon= System.Decimal.Parse(r[Field_Daucuon].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Doilenh= System.Decimal.Parse(r[Field_Doilenh].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Lencuon= System.Decimal.Parse(r[Field_Lencuon].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Xuongcuon= System.Decimal.Parse(r[Field_Xuongcuon].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Thaythietbi= System.Decimal.Parse(r[Field_Thaythietbi].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Dungmay= System.Decimal.Parse(r[Field_Dungmay].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DinhmucthoigianEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _DinhmucthoigianEntity;
		}			
		
		public DinhmucthoigianEntity Convert_Entity(DinhmucthoigianEntity _DinhmucthoigianEntity,DinhmucthoigianEntity _DinhmucthoigianEntity_XML)
		{	
			
			
			_DinhmucthoigianEntity.Madinhmuc= _DinhmucthoigianEntity_XML.Madinhmuc;
			
			_DinhmucthoigianEntity.Tendinhmuc= _DinhmucthoigianEntity_XML.Tendinhmuc;
			
			_DinhmucthoigianEntity.Dodaytu= _DinhmucthoigianEntity_XML.Dodaytu;
			
			_DinhmucthoigianEntity.Dodayden= _DinhmucthoigianEntity_XML.Dodayden;
			
			_DinhmucthoigianEntity.Khotu= _DinhmucthoigianEntity_XML.Khotu;
			
			_DinhmucthoigianEntity.Khoden= _DinhmucthoigianEntity_XML.Khoden;
			
			_DinhmucthoigianEntity.Chieudaitu= _DinhmucthoigianEntity_XML.Chieudaitu;
			
			_DinhmucthoigianEntity.Chieudaiden= _DinhmucthoigianEntity_XML.Chieudaiden;
			
			_DinhmucthoigianEntity.Mamays= _DinhmucthoigianEntity_XML.Mamays;
			
			_DinhmucthoigianEntity.Macongdoans= _DinhmucthoigianEntity_XML.Macongdoans;
			
			_DinhmucthoigianEntity.Somaumas= _DinhmucthoigianEntity_XML.Somaumas;
			
			_DinhmucthoigianEntity.Sohinhmas= _DinhmucthoigianEntity_XML.Sohinhmas;
			
			_DinhmucthoigianEntity.Maloaimangs= _DinhmucthoigianEntity_XML.Maloaimangs;
			
			_DinhmucthoigianEntity.Maqcthanhphams= _DinhmucthoigianEntity_XML.Maqcthanhphams;
			
			_DinhmucthoigianEntity.Makhachs= _DinhmucthoigianEntity_XML.Makhachs;
			
			_DinhmucthoigianEntity.Mahangs= _DinhmucthoigianEntity_XML.Mahangs;
			
			_DinhmucthoigianEntity.Dauca= _DinhmucthoigianEntity_XML.Dauca;
			
			_DinhmucthoigianEntity.Chuanbi= _DinhmucthoigianEntity_XML.Chuanbi;
			
			_DinhmucthoigianEntity.Daucuon= _DinhmucthoigianEntity_XML.Daucuon;
			
			_DinhmucthoigianEntity.Doilenh= _DinhmucthoigianEntity_XML.Doilenh;
			
			_DinhmucthoigianEntity.Lencuon= _DinhmucthoigianEntity_XML.Lencuon;
			
			_DinhmucthoigianEntity.Xuongcuon= _DinhmucthoigianEntity_XML.Xuongcuon;
			
			_DinhmucthoigianEntity.Thaythietbi= _DinhmucthoigianEntity_XML.Thaythietbi;
			
			_DinhmucthoigianEntity.Dungmay= _DinhmucthoigianEntity_XML.Dungmay;
			
			_DinhmucthoigianEntity.Ngaytao= _DinhmucthoigianEntity_XML.Ngaytao;
			
			_DinhmucthoigianEntity.Nguoitao= _DinhmucthoigianEntity_XML.Nguoitao;
			
			_DinhmucthoigianEntity.Ngaysua= _DinhmucthoigianEntity_XML.Ngaysua;
			
			_DinhmucthoigianEntity.Nguoisua= _DinhmucthoigianEntity_XML.Nguoisua;
									
				
			return _DinhmucthoigianEntity;
		}	
		
		public String InsertV2(DinhmucthoigianEntity _DinhmucthoigianEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DinhmucthoigianManagerBase()).Insert(_DinhmucthoigianEntity).Madinhmuc.ToString();
			
			
			try
			{
				r.SetField(Field_Madinhmuc,_DinhmucthoigianEntity.Madinhmuc);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmucthoigianEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodaytu,_DinhmucthoigianEntity.Dodaytu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodayden,_DinhmucthoigianEntity.Dodayden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khotu,_DinhmucthoigianEntity.Khotu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoden,_DinhmucthoigianEntity.Khoden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaitu,_DinhmucthoigianEntity.Chieudaitu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaiden,_DinhmucthoigianEntity.Chieudaiden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamays,_DinhmucthoigianEntity.Mamays);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoans,_DinhmucthoigianEntity.Macongdoans);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somaumas,_DinhmucthoigianEntity.Somaumas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinhmas,_DinhmucthoigianEntity.Sohinhmas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimangs,_DinhmucthoigianEntity.Maloaimangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhphams,_DinhmucthoigianEntity.Maqcthanhphams);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhachs,_DinhmucthoigianEntity.Makhachs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangs,_DinhmucthoigianEntity.Mahangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauca,_DinhmucthoigianEntity.Dauca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chuanbi,_DinhmucthoigianEntity.Chuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daucuon,_DinhmucthoigianEntity.Daucuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doilenh,_DinhmucthoigianEntity.Doilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lencuon,_DinhmucthoigianEntity.Lencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuongcuon,_DinhmucthoigianEntity.Xuongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaythietbi,_DinhmucthoigianEntity.Thaythietbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmay,_DinhmucthoigianEntity.Dungmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmucthoigianEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmucthoigianEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmucthoigianEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmucthoigianEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DinhmucthoigianEntity _DinhmucthoigianEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DinhmucthoigianManagerBase()).Update(_DinhmucthoigianEntity);
			r.SetField(Field_Madinhmuc,_DinhmucthoigianEntity.Madinhmuc);
									
			
			
			
			try
			{
				r.SetField(Field_Tendinhmuc,_DinhmucthoigianEntity.Tendinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodaytu,_DinhmucthoigianEntity.Dodaytu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dodayden,_DinhmucthoigianEntity.Dodayden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khotu,_DinhmucthoigianEntity.Khotu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoden,_DinhmucthoigianEntity.Khoden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaitu,_DinhmucthoigianEntity.Chieudaitu);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chieudaiden,_DinhmucthoigianEntity.Chieudaiden);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamays,_DinhmucthoigianEntity.Mamays);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongdoans,_DinhmucthoigianEntity.Macongdoans);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somaumas,_DinhmucthoigianEntity.Somaumas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinhmas,_DinhmucthoigianEntity.Sohinhmas);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimangs,_DinhmucthoigianEntity.Maloaimangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhphams,_DinhmucthoigianEntity.Maqcthanhphams);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhachs,_DinhmucthoigianEntity.Makhachs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mahangs,_DinhmucthoigianEntity.Mahangs);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauca,_DinhmucthoigianEntity.Dauca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Chuanbi,_DinhmucthoigianEntity.Chuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daucuon,_DinhmucthoigianEntity.Daucuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Doilenh,_DinhmucthoigianEntity.Doilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lencuon,_DinhmucthoigianEntity.Lencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Xuongcuon,_DinhmucthoigianEntity.Xuongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thaythietbi,_DinhmucthoigianEntity.Thaythietbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dungmay,_DinhmucthoigianEntity.Dungmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DinhmucthoigianEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DinhmucthoigianEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DinhmucthoigianEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DinhmucthoigianEntity.Nguoisua);
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

		public DinhmucthoigianEntity Insert(DinhmucthoigianEntity DinhmucthoigianEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DinhmucthoigianEntity, true);
			}
			return DinhmucthoigianEntity;
		}

		public DinhmucthoigianEntity Insert(System.String  Madinhmuc, System.String  Tendinhmuc, System.Decimal  Dodaytu, System.Decimal  Dodayden, System.Decimal  Khotu, System.Decimal  Khoden, System.Decimal  Chieudaitu, System.Decimal  Chieudaiden, System.String  Mamays, System.String  Macongdoans, System.String  Somaumas, System.String  Sohinhmas, System.String  Maloaimangs, System.String  Maqcthanhphams, System.String  Makhachs, System.String  Mahangs, System.Decimal  Dauca, System.Decimal  Chuanbi, System.Decimal  Daucuon, System.Decimal  Doilenh, System.Decimal  Lencuon, System.Decimal  Xuongcuon, System.Decimal  Thaythietbi, System.Decimal  Dungmay, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DinhmucthoigianEntity.Madinhmuc = Madinhmuc;
				
				_DinhmucthoigianEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmucthoigianEntity.Dodaytu = Dodaytu;
				
				_DinhmucthoigianEntity.Dodayden = Dodayden;
				
				_DinhmucthoigianEntity.Khotu = Khotu;
				
				_DinhmucthoigianEntity.Khoden = Khoden;
				
				_DinhmucthoigianEntity.Chieudaitu = Chieudaitu;
				
				_DinhmucthoigianEntity.Chieudaiden = Chieudaiden;
				
				_DinhmucthoigianEntity.Mamays = Mamays;
				
				_DinhmucthoigianEntity.Macongdoans = Macongdoans;
				
				_DinhmucthoigianEntity.Somaumas = Somaumas;
				
				_DinhmucthoigianEntity.Sohinhmas = Sohinhmas;
				
				_DinhmucthoigianEntity.Maloaimangs = Maloaimangs;
				
				_DinhmucthoigianEntity.Maqcthanhphams = Maqcthanhphams;
				
				_DinhmucthoigianEntity.Makhachs = Makhachs;
				
				_DinhmucthoigianEntity.Mahangs = Mahangs;
				
				_DinhmucthoigianEntity.Dauca = Dauca;
				
				_DinhmucthoigianEntity.Chuanbi = Chuanbi;
				
				_DinhmucthoigianEntity.Daucuon = Daucuon;
				
				_DinhmucthoigianEntity.Doilenh = Doilenh;
				
				_DinhmucthoigianEntity.Lencuon = Lencuon;
				
				_DinhmucthoigianEntity.Xuongcuon = Xuongcuon;
				
				_DinhmucthoigianEntity.Thaythietbi = Thaythietbi;
				
				_DinhmucthoigianEntity.Dungmay = Dungmay;
				
				_DinhmucthoigianEntity.Ngaytao = Ngaytao;
				
				_DinhmucthoigianEntity.Nguoitao = Nguoitao;
				
				_DinhmucthoigianEntity.Ngaysua = Ngaysua;
				
				_DinhmucthoigianEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_DinhmucthoigianEntity, true);
			}
			return _DinhmucthoigianEntity;
		}

		public DinhmucthoigianEntity Insert(System.String Tendinhmuc, System.Decimal Dodaytu, System.Decimal Dodayden, System.Decimal Khotu, System.Decimal Khoden, System.Decimal Chieudaitu, System.Decimal Chieudaiden, System.String Mamays, System.String Macongdoans, System.String Somaumas, System.String Sohinhmas, System.String Maloaimangs, System.String Maqcthanhphams, System.String Makhachs, System.String Mahangs, System.Decimal Dauca, System.Decimal Chuanbi, System.Decimal Daucuon, System.Decimal Doilenh, System.Decimal Lencuon, System.Decimal Xuongcuon, System.Decimal Thaythietbi, System.Decimal Dungmay, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DinhmucthoigianEntity.Tendinhmuc = Tendinhmuc;
				
				_DinhmucthoigianEntity.Dodaytu = Dodaytu;
				
				_DinhmucthoigianEntity.Dodayden = Dodayden;
				
				_DinhmucthoigianEntity.Khotu = Khotu;
				
				_DinhmucthoigianEntity.Khoden = Khoden;
				
				_DinhmucthoigianEntity.Chieudaitu = Chieudaitu;
				
				_DinhmucthoigianEntity.Chieudaiden = Chieudaiden;
				
				_DinhmucthoigianEntity.Mamays = Mamays;
				
				_DinhmucthoigianEntity.Macongdoans = Macongdoans;
				
				_DinhmucthoigianEntity.Somaumas = Somaumas;
				
				_DinhmucthoigianEntity.Sohinhmas = Sohinhmas;
				
				_DinhmucthoigianEntity.Maloaimangs = Maloaimangs;
				
				_DinhmucthoigianEntity.Maqcthanhphams = Maqcthanhphams;
				
				_DinhmucthoigianEntity.Makhachs = Makhachs;
				
				_DinhmucthoigianEntity.Mahangs = Mahangs;
				
				_DinhmucthoigianEntity.Dauca = Dauca;
				
				_DinhmucthoigianEntity.Chuanbi = Chuanbi;
				
				_DinhmucthoigianEntity.Daucuon = Daucuon;
				
				_DinhmucthoigianEntity.Doilenh = Doilenh;
				
				_DinhmucthoigianEntity.Lencuon = Lencuon;
				
				_DinhmucthoigianEntity.Xuongcuon = Xuongcuon;
				
				_DinhmucthoigianEntity.Thaythietbi = Thaythietbi;
				
				_DinhmucthoigianEntity.Dungmay = Dungmay;
				
				_DinhmucthoigianEntity.Ngaytao = Ngaytao;
				
				_DinhmucthoigianEntity.Nguoitao = Nguoitao;
				
				_DinhmucthoigianEntity.Ngaysua = Ngaysua;
				
				_DinhmucthoigianEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_DinhmucthoigianEntity, true);
			}
			return _DinhmucthoigianEntity;
		}

		public bool Update(DinhmucthoigianEntity _DinhmucthoigianEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DinhmucthoigianFields.Madinhmuc == _DinhmucthoigianEntity.Madinhmuc);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DinhmucthoigianEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DinhmucthoigianEntity _DinhmucthoigianEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DinhmucthoigianEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Madinhmuc, System.String Tendinhmuc, System.Decimal Dodaytu, System.Decimal Dodayden, System.Decimal Khotu, System.Decimal Khoden, System.Decimal Chieudaitu, System.Decimal Chieudaiden, System.String Mamays, System.String Macongdoans, System.String Somaumas, System.String Sohinhmas, System.String Maloaimangs, System.String Maqcthanhphams, System.String Makhachs, System.String Mahangs, System.Decimal Dauca, System.Decimal Chuanbi, System.Decimal Daucuon, System.Decimal Doilenh, System.Decimal Lencuon, System.Decimal Xuongcuon, System.Decimal Thaythietbi, System.Decimal Dungmay, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmucthoigianEntity))
				{
				
					
					
					_DinhmucthoigianEntity.Tendinhmuc = Tendinhmuc;
					
					_DinhmucthoigianEntity.Dodaytu = Dodaytu;
					
					_DinhmucthoigianEntity.Dodayden = Dodayden;
					
					_DinhmucthoigianEntity.Khotu = Khotu;
					
					_DinhmucthoigianEntity.Khoden = Khoden;
					
					_DinhmucthoigianEntity.Chieudaitu = Chieudaitu;
					
					_DinhmucthoigianEntity.Chieudaiden = Chieudaiden;
					
					_DinhmucthoigianEntity.Mamays = Mamays;
					
					_DinhmucthoigianEntity.Macongdoans = Macongdoans;
					
					_DinhmucthoigianEntity.Somaumas = Somaumas;
					
					_DinhmucthoigianEntity.Sohinhmas = Sohinhmas;
					
					_DinhmucthoigianEntity.Maloaimangs = Maloaimangs;
					
					_DinhmucthoigianEntity.Maqcthanhphams = Maqcthanhphams;
					
					_DinhmucthoigianEntity.Makhachs = Makhachs;
					
					_DinhmucthoigianEntity.Mahangs = Mahangs;
					
					_DinhmucthoigianEntity.Dauca = Dauca;
					
					_DinhmucthoigianEntity.Chuanbi = Chuanbi;
					
					_DinhmucthoigianEntity.Daucuon = Daucuon;
					
					_DinhmucthoigianEntity.Doilenh = Doilenh;
					
					_DinhmucthoigianEntity.Lencuon = Lencuon;
					
					_DinhmucthoigianEntity.Xuongcuon = Xuongcuon;
					
					_DinhmucthoigianEntity.Thaythietbi = Thaythietbi;
					
					_DinhmucthoigianEntity.Dungmay = Dungmay;
					
					_DinhmucthoigianEntity.Ngaytao = Ngaytao;
					
					_DinhmucthoigianEntity.Nguoitao = Nguoitao;
					
					_DinhmucthoigianEntity.Ngaysua = Ngaysua;
					
					_DinhmucthoigianEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_DinhmucthoigianEntity, true);
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
				DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmucthoigianEntity))
				{
					adapter.DeleteEntity(_DinhmucthoigianEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", null);
			}
		}
		
		
		
		public int DeleteByMadinhmuc(System.String Madinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTendinhmuc(System.String Tendinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDodaytu(System.Decimal Dodaytu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dodaytu == Dodaytu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDodayden(System.Decimal Dodayden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dodayden == Dodayden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhotu(System.Decimal Khotu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Khotu == Khotu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhoden(System.Decimal Khoden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Khoden == Khoden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChieudaitu(System.Decimal Chieudaitu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chieudaitu == Chieudaitu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChieudaiden(System.Decimal Chieudaiden)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chieudaiden == Chieudaiden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamays(System.String Mamays)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mamays == Mamays);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongdoans(System.String Macongdoans)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Macongdoans == Macongdoans);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomaumas(System.String Somaumas)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Somaumas == Somaumas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohinhmas(System.String Sohinhmas)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Sohinhmas == Sohinhmas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaimangs(System.String Maloaimangs)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Maloaimangs == Maloaimangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqcthanhphams(System.String Maqcthanhphams)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Maqcthanhphams == Maqcthanhphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhachs(System.String Makhachs)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Makhachs == Makhachs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMahangs(System.String Mahangs)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mahangs == Mahangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauca(System.Decimal Dauca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByChuanbi(System.Decimal Chuanbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chuanbi == Chuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDaucuon(System.Decimal Daucuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Daucuon == Daucuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDoilenh(System.Decimal Doilenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLencuon(System.Decimal Lencuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByXuongcuon(System.Decimal Xuongcuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThaythietbi(System.Decimal Thaythietbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDungmay(System.Decimal Dungmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DinhmucthoigianEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DinhmucthoigianEntity SelectOne(System.String Madinhmuc)
		{
			DinhmucthoigianEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DinhmucthoigianEntity _DinhmucthoigianEntity = new DinhmucthoigianEntity(Madinhmuc);
				if (adapter.FetchEntity(_DinhmucthoigianEntity))
				{
					toReturn = _DinhmucthoigianEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection( new DinhmucthoigianEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, null, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMadinhmuc(System.String Madinhmuc)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMadinhmucRDT(System.String Madinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Madinhmuc == Madinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTendinhmuc(System.String Tendinhmuc)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByTendinhmucRDT(System.String Tendinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Tendinhmuc == Tendinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDodaytu(System.Decimal Dodaytu)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dodaytu == Dodaytu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDodaytuRDT(System.Decimal Dodaytu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dodaytu == Dodaytu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDodayden(System.Decimal Dodayden)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dodayden == Dodayden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDodaydenRDT(System.Decimal Dodayden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dodayden == Dodayden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhotu(System.Decimal Khotu)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Khotu == Khotu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByKhotuRDT(System.Decimal Khotu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Khotu == Khotu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhoden(System.Decimal Khoden)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Khoden == Khoden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByKhodenRDT(System.Decimal Khoden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Khoden == Khoden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChieudaitu(System.Decimal Chieudaitu)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chieudaitu == Chieudaitu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByChieudaituRDT(System.Decimal Chieudaitu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chieudaitu == Chieudaitu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChieudaiden(System.Decimal Chieudaiden)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chieudaiden == Chieudaiden);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByChieudaidenRDT(System.Decimal Chieudaiden)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chieudaiden == Chieudaiden);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamays(System.String Mamays)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mamays == Mamays);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMamaysRDT(System.String Mamays)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mamays == Mamays);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongdoans(System.String Macongdoans)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Macongdoans == Macongdoans);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongdoansRDT(System.String Macongdoans)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Macongdoans == Macongdoans);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomaumas(System.String Somaumas)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Somaumas == Somaumas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectBySomaumasRDT(System.String Somaumas)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Somaumas == Somaumas);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohinhmas(System.String Sohinhmas)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Sohinhmas == Sohinhmas);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectBySohinhmasRDT(System.String Sohinhmas)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Sohinhmas == Sohinhmas);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaimangs(System.String Maloaimangs)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Maloaimangs == Maloaimangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaimangsRDT(System.String Maloaimangs)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Maloaimangs == Maloaimangs);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqcthanhphams(System.String Maqcthanhphams)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Maqcthanhphams == Maqcthanhphams);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcthanhphamsRDT(System.String Maqcthanhphams)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Maqcthanhphams == Maqcthanhphams);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhachs(System.String Makhachs)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Makhachs == Makhachs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachsRDT(System.String Makhachs)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Makhachs == Makhachs);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMahangs(System.String Mahangs)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mahangs == Mahangs);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByMahangsRDT(System.String Mahangs)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Mahangs == Mahangs);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauca(System.Decimal Dauca)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDaucaRDT(System.Decimal Dauca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dauca == Dauca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByChuanbi(System.Decimal Chuanbi)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chuanbi == Chuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByChuanbiRDT(System.Decimal Chuanbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Chuanbi == Chuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDaucuon(System.Decimal Daucuon)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Daucuon == Daucuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDaucuonRDT(System.Decimal Daucuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Daucuon == Daucuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDoilenh(System.Decimal Doilenh)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDoilenhRDT(System.Decimal Doilenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Doilenh == Doilenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLencuon(System.Decimal Lencuon)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByLencuonRDT(System.Decimal Lencuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Lencuon == Lencuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByXuongcuon(System.Decimal Xuongcuon)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByXuongcuonRDT(System.Decimal Xuongcuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Xuongcuon == Xuongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThaythietbi(System.Decimal Thaythietbi)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByThaythietbiRDT(System.Decimal Thaythietbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Thaythietbi == Thaythietbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDungmay(System.Decimal Dungmay)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByDungmayRDT(System.Decimal Dungmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Dungmay == Dungmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DinhmucthoigianCollection, filter, 0, null);
			}
			return _DinhmucthoigianCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DinhmucthoigianCollection = new EntityCollection(new DinhmucthoigianEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DinhmucthoigianFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DinhmucthoigianCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DinhmucthoigianFields.Madinhmuc.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
