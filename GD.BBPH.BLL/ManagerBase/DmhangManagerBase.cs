


/*
'===============================================================================
'  GD.BBPH.BL.DmhangManagerBase
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
	public class DmhangManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Masp="Masp";				
		
		public const String Field_Tensp="Tensp";				
		
		public const String Field_Maspcuakhach="Maspcuakhach";				
		
		public const String Field_Machungloai="Machungloai";				
		
		public const String Field_Tenchungloai="Tenchungloai";				
		
		public const String Field_Makhach="Makhach";				
		
		public const String Field_Tenkhach="Tenkhach";				
		
		public const String Field_Trongluong="Trongluong";				
		
		public const String Field_Sohinh="Sohinh";				
		
		public const String Field_Somau="Somau";				
		
		public const String Field_Loaimuc="Loaimuc";				
		
		public const String Field_Khoiluongmuc="Khoiluongmuc";				
		
		public const String Field_Kichthuoctruc="Kichthuoctruc";				
		
		public const String Field_Vitri="Vitri";				
		
		public const String Field_Maqcdonggoi="Maqcdonggoi";				
		
		public const String Field_Tenqcdonggoi="Tenqcdonggoi";				
		
		public const String Field_Maqcloaithung="Maqcloaithung";				
		
		public const String Field_Tenqcloaithung="Tenqcloaithung";				
		
		public const String Field_Maqcthanhpham="Maqcthanhpham";				
		
		public const String Field_Tenqcthanhpham="Tenqcthanhpham";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Rong="Rong";				
		
		public const String Field_Dai="Dai";				
		
		public const String Field_Somauma="Somauma";				
		
		public const String Field_Sohinhma="Sohinhma";				
		
		public const String Field_Maloaimuc="Maloaimuc";				
		
		public const String Field_Solopghepma="Solopghepma";				
		
		public const String Field_Solopghep="Solopghep";				
		
		public const String Field_Khomang="Khomang";				
		
		public const String Field_Rongcuon="Rongcuon";				
		
		public const String Field_Daicuon="Daicuon";				
		
		public const String Field_Hong="Hong";				
		
		public const String Field_Bangdinhdan="Bangdinhdan";				
		
		public const String Field_Cautruc="Cautruc";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DmhangManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Masp,typeof(System.String));
			
			dt.Columns.Add(Field_Tensp,typeof(System.String));
			
			dt.Columns.Add(Field_Maspcuakhach,typeof(System.String));
			
			dt.Columns.Add(Field_Machungloai,typeof(System.String));
			
			dt.Columns.Add(Field_Tenchungloai,typeof(System.String));
			
			dt.Columns.Add(Field_Makhach,typeof(System.String));
			
			dt.Columns.Add(Field_Tenkhach,typeof(System.String));
			
			dt.Columns.Add(Field_Trongluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sohinh,typeof(System.Int32));
			
			dt.Columns.Add(Field_Somau,typeof(System.Int32));
			
			dt.Columns.Add(Field_Loaimuc,typeof(System.String));
			
			dt.Columns.Add(Field_Khoiluongmuc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Kichthuoctruc,typeof(System.String));
			
			dt.Columns.Add(Field_Vitri,typeof(System.String));
			
			dt.Columns.Add(Field_Maqcdonggoi,typeof(System.String));
			
			dt.Columns.Add(Field_Tenqcdonggoi,typeof(System.String));
			
			dt.Columns.Add(Field_Maqcloaithung,typeof(System.String));
			
			dt.Columns.Add(Field_Tenqcloaithung,typeof(System.String));
			
			dt.Columns.Add(Field_Maqcthanhpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tenqcthanhpham,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Rong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dai,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Somauma,typeof(System.String));
			
			dt.Columns.Add(Field_Sohinhma,typeof(System.String));
			
			dt.Columns.Add(Field_Maloaimuc,typeof(System.String));
			
			dt.Columns.Add(Field_Solopghepma,typeof(System.String));
			
			dt.Columns.Add(Field_Solopghep,typeof(System.Int32));
			
			dt.Columns.Add(Field_Khomang,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Rongcuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Daicuon,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Hong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Bangdinhdan,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Cautruc,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(DmhangEntity _DmhangEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Masp]=_DmhangEntity.Masp;
			}
			catch { }
			
			try
			{
				r[Field_Tensp]=_DmhangEntity.Tensp;
			}
			catch { }
			
			try
			{
				r[Field_Maspcuakhach]=_DmhangEntity.Maspcuakhach;
			}
			catch { }
			
			try
			{
				r[Field_Machungloai]=_DmhangEntity.Machungloai;
			}
			catch { }
			
			try
			{
				r[Field_Tenchungloai]=_DmhangEntity.Tenchungloai;
			}
			catch { }
			
			try
			{
				r[Field_Makhach]=_DmhangEntity.Makhach;
			}
			catch { }
			
			try
			{
				r[Field_Tenkhach]=_DmhangEntity.Tenkhach;
			}
			catch { }
			
			try
			{
				r[Field_Trongluong]=_DmhangEntity.Trongluong;
			}
			catch { }
			
			try
			{
				r[Field_Sohinh]=_DmhangEntity.Sohinh;
			}
			catch { }
			
			try
			{
				r[Field_Somau]=_DmhangEntity.Somau;
			}
			catch { }
			
			try
			{
				r[Field_Loaimuc]=_DmhangEntity.Loaimuc;
			}
			catch { }
			
			try
			{
				r[Field_Khoiluongmuc]=_DmhangEntity.Khoiluongmuc;
			}
			catch { }
			
			try
			{
				r[Field_Kichthuoctruc]=_DmhangEntity.Kichthuoctruc;
			}
			catch { }
			
			try
			{
				r[Field_Vitri]=_DmhangEntity.Vitri;
			}
			catch { }
			
			try
			{
				r[Field_Maqcdonggoi]=_DmhangEntity.Maqcdonggoi;
			}
			catch { }
			
			try
			{
				r[Field_Tenqcdonggoi]=_DmhangEntity.Tenqcdonggoi;
			}
			catch { }
			
			try
			{
				r[Field_Maqcloaithung]=_DmhangEntity.Maqcloaithung;
			}
			catch { }
			
			try
			{
				r[Field_Tenqcloaithung]=_DmhangEntity.Tenqcloaithung;
			}
			catch { }
			
			try
			{
				r[Field_Maqcthanhpham]=_DmhangEntity.Maqcthanhpham;
			}
			catch { }
			
			try
			{
				r[Field_Tenqcthanhpham]=_DmhangEntity.Tenqcthanhpham;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_DmhangEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_DmhangEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_DmhangEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_DmhangEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Rong]=_DmhangEntity.Rong;
			}
			catch { }
			
			try
			{
				r[Field_Dai]=_DmhangEntity.Dai;
			}
			catch { }
			
			try
			{
				r[Field_Somauma]=_DmhangEntity.Somauma;
			}
			catch { }
			
			try
			{
				r[Field_Sohinhma]=_DmhangEntity.Sohinhma;
			}
			catch { }
			
			try
			{
				r[Field_Maloaimuc]=_DmhangEntity.Maloaimuc;
			}
			catch { }
			
			try
			{
				r[Field_Solopghepma]=_DmhangEntity.Solopghepma;
			}
			catch { }
			
			try
			{
				r[Field_Solopghep]=_DmhangEntity.Solopghep;
			}
			catch { }
			
			try
			{
				r[Field_Khomang]=_DmhangEntity.Khomang;
			}
			catch { }
			
			try
			{
				r[Field_Rongcuon]=_DmhangEntity.Rongcuon;
			}
			catch { }
			
			try
			{
				r[Field_Daicuon]=_DmhangEntity.Daicuon;
			}
			catch { }
			
			try
			{
				r[Field_Hong]=_DmhangEntity.Hong;
			}
			catch { }
			
			try
			{
				r[Field_Bangdinhdan]=_DmhangEntity.Bangdinhdan;
			}
			catch { }
			
			try
			{
				r[Field_Cautruc]=_DmhangEntity.Cautruc;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public DmhangEntity Convert(DataRow r)
		{	
			
			DmhangEntity _DmhangEntity=new DmhangEntity(r[Field_Masp].ToString());					
						
			
			
			try
			{
				_DmhangEntity.Tensp= r[Field_Tensp].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Maspcuakhach= r[Field_Maspcuakhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Machungloai= r[Field_Machungloai].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenchungloai= r[Field_Tenchungloai].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Makhach= r[Field_Makhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenkhach= r[Field_Tenkhach].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Trongluong= System.Decimal.Parse(r[Field_Trongluong].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Sohinh= System.Int32.Parse(r[Field_Sohinh].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Somau= System.Int32.Parse(r[Field_Somau].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Loaimuc= r[Field_Loaimuc].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Khoiluongmuc= System.Decimal.Parse(r[Field_Khoiluongmuc].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Kichthuoctruc= r[Field_Kichthuoctruc].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Vitri= r[Field_Vitri].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Maqcdonggoi= r[Field_Maqcdonggoi].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenqcdonggoi= r[Field_Tenqcdonggoi].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Maqcloaithung= r[Field_Maqcloaithung].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenqcloaithung= r[Field_Tenqcloaithung].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Maqcthanhpham= r[Field_Maqcthanhpham].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenqcthanhpham= r[Field_Tenqcthanhpham].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Rong= System.Decimal.Parse(r[Field_Rong].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Dai= System.Decimal.Parse(r[Field_Dai].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Somauma= r[Field_Somauma].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Sohinhma= r[Field_Sohinhma].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Maloaimuc= r[Field_Maloaimuc].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Solopghepma= r[Field_Solopghepma].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Solopghep= System.Int32.Parse(r[Field_Solopghep].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Khomang= System.Decimal.Parse(r[Field_Khomang].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Rongcuon= System.Decimal.Parse(r[Field_Rongcuon].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Daicuon= System.Decimal.Parse(r[Field_Daicuon].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Hong= System.Decimal.Parse(r[Field_Hong].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Bangdinhdan= System.Decimal.Parse(r[Field_Bangdinhdan].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Cautruc= r[Field_Cautruc].ToString();						
			}
			catch { }
									
									
			return _DmhangEntity;
		}			
		
		public DmhangEntity Convert_Entity(DmhangEntity _DmhangEntity,DmhangEntity _DmhangEntity_XML)
		{	
			
			
			_DmhangEntity.Masp= _DmhangEntity_XML.Masp;
			
			_DmhangEntity.Tensp= _DmhangEntity_XML.Tensp;
			
			_DmhangEntity.Maspcuakhach= _DmhangEntity_XML.Maspcuakhach;
			
			_DmhangEntity.Machungloai= _DmhangEntity_XML.Machungloai;
			
			_DmhangEntity.Tenchungloai= _DmhangEntity_XML.Tenchungloai;
			
			_DmhangEntity.Makhach= _DmhangEntity_XML.Makhach;
			
			_DmhangEntity.Tenkhach= _DmhangEntity_XML.Tenkhach;
			
			_DmhangEntity.Trongluong= _DmhangEntity_XML.Trongluong;
			
			_DmhangEntity.Sohinh= _DmhangEntity_XML.Sohinh;
			
			_DmhangEntity.Somau= _DmhangEntity_XML.Somau;
			
			_DmhangEntity.Loaimuc= _DmhangEntity_XML.Loaimuc;
			
			_DmhangEntity.Khoiluongmuc= _DmhangEntity_XML.Khoiluongmuc;
			
			_DmhangEntity.Kichthuoctruc= _DmhangEntity_XML.Kichthuoctruc;
			
			_DmhangEntity.Vitri= _DmhangEntity_XML.Vitri;
			
			_DmhangEntity.Maqcdonggoi= _DmhangEntity_XML.Maqcdonggoi;
			
			_DmhangEntity.Tenqcdonggoi= _DmhangEntity_XML.Tenqcdonggoi;
			
			_DmhangEntity.Maqcloaithung= _DmhangEntity_XML.Maqcloaithung;
			
			_DmhangEntity.Tenqcloaithung= _DmhangEntity_XML.Tenqcloaithung;
			
			_DmhangEntity.Maqcthanhpham= _DmhangEntity_XML.Maqcthanhpham;
			
			_DmhangEntity.Tenqcthanhpham= _DmhangEntity_XML.Tenqcthanhpham;
			
			_DmhangEntity.Ngaytao= _DmhangEntity_XML.Ngaytao;
			
			_DmhangEntity.Nguoitao= _DmhangEntity_XML.Nguoitao;
			
			_DmhangEntity.Ngaysua= _DmhangEntity_XML.Ngaysua;
			
			_DmhangEntity.Nguoisua= _DmhangEntity_XML.Nguoisua;
			
			_DmhangEntity.Rong= _DmhangEntity_XML.Rong;
			
			_DmhangEntity.Dai= _DmhangEntity_XML.Dai;
			
			_DmhangEntity.Somauma= _DmhangEntity_XML.Somauma;
			
			_DmhangEntity.Sohinhma= _DmhangEntity_XML.Sohinhma;
			
			_DmhangEntity.Maloaimuc= _DmhangEntity_XML.Maloaimuc;
			
			_DmhangEntity.Solopghepma= _DmhangEntity_XML.Solopghepma;
			
			_DmhangEntity.Solopghep= _DmhangEntity_XML.Solopghep;
			
			_DmhangEntity.Khomang= _DmhangEntity_XML.Khomang;
			
			_DmhangEntity.Rongcuon= _DmhangEntity_XML.Rongcuon;
			
			_DmhangEntity.Daicuon= _DmhangEntity_XML.Daicuon;
			
			_DmhangEntity.Hong= _DmhangEntity_XML.Hong;
			
			_DmhangEntity.Bangdinhdan= _DmhangEntity_XML.Bangdinhdan;
			
			_DmhangEntity.Cautruc= _DmhangEntity_XML.Cautruc;
									
				
			return _DmhangEntity;
		}	
		
		public String InsertV2(DmhangEntity _DmhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new DmhangManagerBase()).Insert(_DmhangEntity).Masp.ToString();
			
			
			try
			{
				r.SetField(Field_Masp,_DmhangEntity.Masp);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Tensp,_DmhangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maspcuakhach,_DmhangEntity.Maspcuakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Machungloai,_DmhangEntity.Machungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenchungloai,_DmhangEntity.Tenchungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmhangEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinh,_DmhangEntity.Sohinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somau,_DmhangEntity.Somau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaimuc,_DmhangEntity.Loaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoiluongmuc,_DmhangEntity.Khoiluongmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoctruc,_DmhangEntity.Kichthuoctruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vitri,_DmhangEntity.Vitri);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcdonggoi,_DmhangEntity.Maqcdonggoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcdonggoi,_DmhangEntity.Tenqcdonggoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcloaithung,_DmhangEntity.Maqcloaithung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcloaithung,_DmhangEntity.Tenqcloaithung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhpham,_DmhangEntity.Maqcthanhpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcthanhpham,_DmhangEntity.Tenqcthanhpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmhangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Rong,_DmhangEntity.Rong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dai,_DmhangEntity.Dai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somauma,_DmhangEntity.Somauma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinhma,_DmhangEntity.Sohinhma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimuc,_DmhangEntity.Maloaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solopghepma,_DmhangEntity.Solopghepma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solopghep,_DmhangEntity.Solopghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khomang,_DmhangEntity.Khomang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Rongcuon,_DmhangEntity.Rongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daicuon,_DmhangEntity.Daicuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hong,_DmhangEntity.Hong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bangdinhdan,_DmhangEntity.Bangdinhdan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Cautruc,_DmhangEntity.Cautruc);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(DmhangEntity _DmhangEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new DmhangManagerBase()).Update(_DmhangEntity);
			r.SetField(Field_Masp,_DmhangEntity.Masp);
									
			
			
			
			try
			{
				r.SetField(Field_Tensp,_DmhangEntity.Tensp);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maspcuakhach,_DmhangEntity.Maspcuakhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Machungloai,_DmhangEntity.Machungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenchungloai,_DmhangEntity.Tenchungloai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Makhach,_DmhangEntity.Makhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenkhach,_DmhangEntity.Tenkhach);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Trongluong,_DmhangEntity.Trongluong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinh,_DmhangEntity.Sohinh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somau,_DmhangEntity.Somau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Loaimuc,_DmhangEntity.Loaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khoiluongmuc,_DmhangEntity.Khoiluongmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Kichthuoctruc,_DmhangEntity.Kichthuoctruc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Vitri,_DmhangEntity.Vitri);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcdonggoi,_DmhangEntity.Maqcdonggoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcdonggoi,_DmhangEntity.Tenqcdonggoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcloaithung,_DmhangEntity.Maqcloaithung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcloaithung,_DmhangEntity.Tenqcloaithung);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maqcthanhpham,_DmhangEntity.Maqcthanhpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenqcthanhpham,_DmhangEntity.Tenqcthanhpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_DmhangEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_DmhangEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_DmhangEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_DmhangEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Rong,_DmhangEntity.Rong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dai,_DmhangEntity.Dai);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Somauma,_DmhangEntity.Somauma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sohinhma,_DmhangEntity.Sohinhma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Maloaimuc,_DmhangEntity.Maloaimuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solopghepma,_DmhangEntity.Solopghepma);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solopghep,_DmhangEntity.Solopghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Khomang,_DmhangEntity.Khomang);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Rongcuon,_DmhangEntity.Rongcuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Daicuon,_DmhangEntity.Daicuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Hong,_DmhangEntity.Hong);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Bangdinhdan,_DmhangEntity.Bangdinhdan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Cautruc,_DmhangEntity.Cautruc);
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

		public DmhangEntity Insert(DmhangEntity DmhangEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(DmhangEntity, true);
			}
			return DmhangEntity;
		}

		public DmhangEntity Insert(System.String  Masp, System.String  Tensp, System.String  Maspcuakhach, System.String  Machungloai, System.String  Tenchungloai, System.String  Makhach, System.String  Tenkhach, System.Decimal  Trongluong, System.Int32  Sohinh, System.Int32  Somau, System.String  Loaimuc, System.Decimal  Khoiluongmuc, System.String  Kichthuoctruc, System.String  Vitri, System.String  Maqcdonggoi, System.String  Tenqcdonggoi, System.String  Maqcloaithung, System.String  Tenqcloaithung, System.String  Maqcthanhpham, System.String  Tenqcthanhpham, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Rong, System.Decimal  Dai, System.String  Somauma, System.String  Sohinhma, System.String  Maloaimuc, System.String  Solopghepma, System.Int32  Solopghep, System.Decimal  Khomang, System.Decimal  Rongcuon, System.Decimal  Daicuon, System.Decimal  Hong, System.Decimal  Bangdinhdan, System.String  Cautruc)
		{
			DmhangEntity _DmhangEntity = new DmhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DmhangEntity.Masp = Masp;
				
				_DmhangEntity.Tensp = Tensp;
				
				_DmhangEntity.Maspcuakhach = Maspcuakhach;
				
				_DmhangEntity.Machungloai = Machungloai;
				
				_DmhangEntity.Tenchungloai = Tenchungloai;
				
				_DmhangEntity.Makhach = Makhach;
				
				_DmhangEntity.Tenkhach = Tenkhach;
				
				_DmhangEntity.Trongluong = Trongluong;
				
				_DmhangEntity.Sohinh = Sohinh;
				
				_DmhangEntity.Somau = Somau;
				
				_DmhangEntity.Loaimuc = Loaimuc;
				
				_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
				
				_DmhangEntity.Kichthuoctruc = Kichthuoctruc;
				
				_DmhangEntity.Vitri = Vitri;
				
				_DmhangEntity.Maqcdonggoi = Maqcdonggoi;
				
				_DmhangEntity.Tenqcdonggoi = Tenqcdonggoi;
				
				_DmhangEntity.Maqcloaithung = Maqcloaithung;
				
				_DmhangEntity.Tenqcloaithung = Tenqcloaithung;
				
				_DmhangEntity.Maqcthanhpham = Maqcthanhpham;
				
				_DmhangEntity.Tenqcthanhpham = Tenqcthanhpham;
				
				_DmhangEntity.Ngaytao = Ngaytao;
				
				_DmhangEntity.Nguoitao = Nguoitao;
				
				_DmhangEntity.Ngaysua = Ngaysua;
				
				_DmhangEntity.Nguoisua = Nguoisua;
				
				_DmhangEntity.Rong = Rong;
				
				_DmhangEntity.Dai = Dai;
				
				_DmhangEntity.Somauma = Somauma;
				
				_DmhangEntity.Sohinhma = Sohinhma;
				
				_DmhangEntity.Maloaimuc = Maloaimuc;
				
				_DmhangEntity.Solopghepma = Solopghepma;
				
				_DmhangEntity.Solopghep = Solopghep;
				
				_DmhangEntity.Khomang = Khomang;
				
				_DmhangEntity.Rongcuon = Rongcuon;
				
				_DmhangEntity.Daicuon = Daicuon;
				
				_DmhangEntity.Hong = Hong;
				
				_DmhangEntity.Bangdinhdan = Bangdinhdan;
				
				_DmhangEntity.Cautruc = Cautruc;
					
					
				adapter.SaveEntity(_DmhangEntity, true);
			}
			return _DmhangEntity;
		}

		public DmhangEntity Insert(System.String Tensp, System.String Maspcuakhach, System.String Machungloai, System.String Tenchungloai, System.String Makhach, System.String Tenkhach, System.Decimal Trongluong, System.Int32 Sohinh, System.Int32 Somau, System.String Loaimuc, System.Decimal Khoiluongmuc, System.String Kichthuoctruc, System.String Vitri, System.String Maqcdonggoi, System.String Tenqcdonggoi, System.String Maqcloaithung, System.String Tenqcloaithung, System.String Maqcthanhpham, System.String Tenqcthanhpham, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Rong, System.Decimal Dai, System.String Somauma, System.String Sohinhma, System.String Maloaimuc, System.String Solopghepma, System.Int32 Solopghep, System.Decimal Khomang, System.Decimal Rongcuon, System.Decimal Daicuon, System.Decimal Hong, System.Decimal Bangdinhdan, System.String Cautruc)//ko co mahieu
		{
			DmhangEntity _DmhangEntity = new DmhangEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_DmhangEntity.Tensp = Tensp;
				
				_DmhangEntity.Maspcuakhach = Maspcuakhach;
				
				_DmhangEntity.Machungloai = Machungloai;
				
				_DmhangEntity.Tenchungloai = Tenchungloai;
				
				_DmhangEntity.Makhach = Makhach;
				
				_DmhangEntity.Tenkhach = Tenkhach;
				
				_DmhangEntity.Trongluong = Trongluong;
				
				_DmhangEntity.Sohinh = Sohinh;
				
				_DmhangEntity.Somau = Somau;
				
				_DmhangEntity.Loaimuc = Loaimuc;
				
				_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
				
				_DmhangEntity.Kichthuoctruc = Kichthuoctruc;
				
				_DmhangEntity.Vitri = Vitri;
				
				_DmhangEntity.Maqcdonggoi = Maqcdonggoi;
				
				_DmhangEntity.Tenqcdonggoi = Tenqcdonggoi;
				
				_DmhangEntity.Maqcloaithung = Maqcloaithung;
				
				_DmhangEntity.Tenqcloaithung = Tenqcloaithung;
				
				_DmhangEntity.Maqcthanhpham = Maqcthanhpham;
				
				_DmhangEntity.Tenqcthanhpham = Tenqcthanhpham;
				
				_DmhangEntity.Ngaytao = Ngaytao;
				
				_DmhangEntity.Nguoitao = Nguoitao;
				
				_DmhangEntity.Ngaysua = Ngaysua;
				
				_DmhangEntity.Nguoisua = Nguoisua;
				
				_DmhangEntity.Rong = Rong;
				
				_DmhangEntity.Dai = Dai;
				
				_DmhangEntity.Somauma = Somauma;
				
				_DmhangEntity.Sohinhma = Sohinhma;
				
				_DmhangEntity.Maloaimuc = Maloaimuc;
				
				_DmhangEntity.Solopghepma = Solopghepma;
				
				_DmhangEntity.Solopghep = Solopghep;
				
				_DmhangEntity.Khomang = Khomang;
				
				_DmhangEntity.Rongcuon = Rongcuon;
				
				_DmhangEntity.Daicuon = Daicuon;
				
				_DmhangEntity.Hong = Hong;
				
				_DmhangEntity.Bangdinhdan = Bangdinhdan;
				
				_DmhangEntity.Cautruc = Cautruc;
					

				adapter.SaveEntity(_DmhangEntity, true);
			}
			return _DmhangEntity;
		}

		public bool Update(DmhangEntity _DmhangEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(DmhangFields.Masp == _DmhangEntity.Masp);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DmhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DmhangEntity _DmhangEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DmhangEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.String Masp, System.String Tensp, System.String Maspcuakhach, System.String Machungloai, System.String Tenchungloai, System.String Makhach, System.String Tenkhach, System.Decimal Trongluong, System.Int32 Sohinh, System.Int32 Somau, System.String Loaimuc, System.Decimal Khoiluongmuc, System.String Kichthuoctruc, System.String Vitri, System.String Maqcdonggoi, System.String Tenqcdonggoi, System.String Maqcloaithung, System.String Tenqcloaithung, System.String Maqcthanhpham, System.String Tenqcthanhpham, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Rong, System.Decimal Dai, System.String Somauma, System.String Sohinhma, System.String Maloaimuc, System.String Solopghepma, System.Int32 Solopghep, System.Decimal Khomang, System.Decimal Rongcuon, System.Decimal Daicuon, System.Decimal Hong, System.Decimal Bangdinhdan, System.String Cautruc)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmhangEntity _DmhangEntity = new DmhangEntity(Masp);
				if (adapter.FetchEntity(_DmhangEntity))
				{
				
					
					
					_DmhangEntity.Tensp = Tensp;
					
					_DmhangEntity.Maspcuakhach = Maspcuakhach;
					
					_DmhangEntity.Machungloai = Machungloai;
					
					_DmhangEntity.Tenchungloai = Tenchungloai;
					
					_DmhangEntity.Makhach = Makhach;
					
					_DmhangEntity.Tenkhach = Tenkhach;
					
					_DmhangEntity.Trongluong = Trongluong;
					
					_DmhangEntity.Sohinh = Sohinh;
					
					_DmhangEntity.Somau = Somau;
					
					_DmhangEntity.Loaimuc = Loaimuc;
					
					_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
					
					_DmhangEntity.Kichthuoctruc = Kichthuoctruc;
					
					_DmhangEntity.Vitri = Vitri;
					
					_DmhangEntity.Maqcdonggoi = Maqcdonggoi;
					
					_DmhangEntity.Tenqcdonggoi = Tenqcdonggoi;
					
					_DmhangEntity.Maqcloaithung = Maqcloaithung;
					
					_DmhangEntity.Tenqcloaithung = Tenqcloaithung;
					
					_DmhangEntity.Maqcthanhpham = Maqcthanhpham;
					
					_DmhangEntity.Tenqcthanhpham = Tenqcthanhpham;
					
					_DmhangEntity.Ngaytao = Ngaytao;
					
					_DmhangEntity.Nguoitao = Nguoitao;
					
					_DmhangEntity.Ngaysua = Ngaysua;
					
					_DmhangEntity.Nguoisua = Nguoisua;
					
					_DmhangEntity.Rong = Rong;
					
					_DmhangEntity.Dai = Dai;
					
					_DmhangEntity.Somauma = Somauma;
					
					_DmhangEntity.Sohinhma = Sohinhma;
					
					_DmhangEntity.Maloaimuc = Maloaimuc;
					
					_DmhangEntity.Solopghepma = Solopghepma;
					
					_DmhangEntity.Solopghep = Solopghep;
					
					_DmhangEntity.Khomang = Khomang;
					
					_DmhangEntity.Rongcuon = Rongcuon;
					
					_DmhangEntity.Daicuon = Daicuon;
					
					_DmhangEntity.Hong = Hong;
					
					_DmhangEntity.Bangdinhdan = Bangdinhdan;
					
					_DmhangEntity.Cautruc = Cautruc;
						

					adapter.SaveEntity(_DmhangEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(System.String Masp)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmhangEntity _DmhangEntity = new DmhangEntity(Masp);
				if (adapter.FetchEntity(_DmhangEntity))
				{
					adapter.DeleteEntity(_DmhangEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DmhangEntity", null);
			}
		}
		
		
		
		public int DeleteByMasp(System.String Masp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensp(System.String Tensp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaspcuakhach(System.String Maspcuakhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maspcuakhach == Maspcuakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMachungloai(System.String Machungloai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenchungloai(System.String Tenchungloai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMakhach(System.String Makhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenkhach(System.String Tenkhach)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTrongluong(System.Decimal Trongluong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohinh(System.Int32 Sohinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomau(System.Int32 Somau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLoaimuc(System.String Loaimuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhoiluongmuc(System.Decimal Khoiluongmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khoiluongmuc == Khoiluongmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKichthuoctruc(System.String Kichthuoctruc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoctruc == Kichthuoctruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByVitri(System.String Vitri)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqcdonggoi(System.String Maqcdonggoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcdonggoi == Maqcdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenqcdonggoi(System.String Tenqcdonggoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcdonggoi == Tenqcdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqcloaithung(System.String Maqcloaithung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcloaithung == Maqcloaithung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenqcloaithung(System.String Tenqcloaithung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcloaithung == Tenqcloaithung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaqcthanhpham(System.String Maqcthanhpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcthanhpham == Maqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenqcthanhpham(System.String Tenqcthanhpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcthanhpham == Tenqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByRong(System.Decimal Rong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Rong == Rong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDai(System.Decimal Dai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Dai == Dai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySomauma(System.String Somauma)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somauma == Somauma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySohinhma(System.String Sohinhma)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinhma == Sohinhma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMaloaimuc(System.String Maloaimuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maloaimuc == Maloaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolopghepma(System.String Solopghepma)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Solopghepma == Solopghepma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolopghep(System.Int32 Solopghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Solopghep == Solopghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByKhomang(System.Decimal Khomang)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khomang == Khomang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByRongcuon(System.Decimal Rongcuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Rongcuon == Rongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDaicuon(System.Decimal Daicuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Daicuon == Daicuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByHong(System.Decimal Hong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Hong == Hong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByBangdinhdan(System.Decimal Bangdinhdan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Bangdinhdan == Bangdinhdan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCautruc(System.String Cautruc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautruc == Cautruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
			
		
		public DmhangEntity SelectOne(System.String Masp)
		{
			DmhangEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DmhangEntity _DmhangEntity = new DmhangEntity(Masp);
				if (adapter.FetchEntity(_DmhangEntity))
				{
					toReturn = _DmhangEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _DmhangCollection = new EntityCollection( new DmhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, null, 0, null);
			}
			return _DmhangCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectByMasp(System.String Masp)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspRDT(System.String Masp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Masp == Masp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensp(System.String Tensp)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenspRDT(System.String Tensp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tensp == Tensp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaspcuakhach(System.String Maspcuakhach)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maspcuakhach == Maspcuakhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaspcuakhachRDT(System.String Maspcuakhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maspcuakhach == Maspcuakhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMachungloai(System.String Machungloai)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMachungloaiRDT(System.String Machungloai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Machungloai == Machungloai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenchungloai(System.String Tenchungloai)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenchungloaiRDT(System.String Tenchungloai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenchungloai == Tenchungloai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMakhach(System.String Makhach)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMakhachRDT(System.String Makhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Makhach == Makhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenkhach(System.String Tenkhach)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenkhachRDT(System.String Tenkhach)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenkhach == Tenkhach);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTrongluong(System.Decimal Trongluong)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTrongluongRDT(System.Decimal Trongluong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Trongluong == Trongluong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohinh(System.Int32 Sohinh)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySohinhRDT(System.Int32 Sohinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinh == Sohinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomau(System.Int32 Somau)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySomauRDT(System.Int32 Somau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somau == Somau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLoaimuc(System.String Loaimuc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByLoaimucRDT(System.String Loaimuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Loaimuc == Loaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhoiluongmuc(System.Decimal Khoiluongmuc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khoiluongmuc == Khoiluongmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByKhoiluongmucRDT(System.Decimal Khoiluongmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khoiluongmuc == Khoiluongmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKichthuoctruc(System.String Kichthuoctruc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoctruc == Kichthuoctruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuoctrucRDT(System.String Kichthuoctruc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoctruc == Kichthuoctruc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByVitri(System.String Vitri)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByVitriRDT(System.String Vitri)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Vitri == Vitri);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqcdonggoi(System.String Maqcdonggoi)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcdonggoi == Maqcdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcdonggoiRDT(System.String Maqcdonggoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcdonggoi == Maqcdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenqcdonggoi(System.String Tenqcdonggoi)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcdonggoi == Tenqcdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenqcdonggoiRDT(System.String Tenqcdonggoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcdonggoi == Tenqcdonggoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqcloaithung(System.String Maqcloaithung)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcloaithung == Maqcloaithung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcloaithungRDT(System.String Maqcloaithung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcloaithung == Maqcloaithung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenqcloaithung(System.String Tenqcloaithung)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcloaithung == Tenqcloaithung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenqcloaithungRDT(System.String Tenqcloaithung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcloaithung == Tenqcloaithung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaqcthanhpham(System.String Maqcthanhpham)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcthanhpham == Maqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaqcthanhphamRDT(System.String Maqcthanhpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maqcthanhpham == Maqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenqcthanhpham(System.String Tenqcthanhpham)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcthanhpham == Tenqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenqcthanhphamRDT(System.String Tenqcthanhpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenqcthanhpham == Tenqcthanhpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByRong(System.Decimal Rong)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Rong == Rong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByRongRDT(System.Decimal Rong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Rong == Rong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDai(System.Decimal Dai)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Dai == Dai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByDaiRDT(System.Decimal Dai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Dai == Dai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySomauma(System.String Somauma)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somauma == Somauma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySomaumaRDT(System.String Somauma)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Somauma == Somauma);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySohinhma(System.String Sohinhma)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinhma == Sohinhma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySohinhmaRDT(System.String Sohinhma)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Sohinhma == Sohinhma);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMaloaimuc(System.String Maloaimuc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maloaimuc == Maloaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMaloaimucRDT(System.String Maloaimuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Maloaimuc == Maloaimuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolopghepma(System.String Solopghepma)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Solopghepma == Solopghepma);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySolopghepmaRDT(System.String Solopghepma)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Solopghepma == Solopghepma);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolopghep(System.Int32 Solopghep)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Solopghep == Solopghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectBySolopghepRDT(System.Int32 Solopghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Solopghep == Solopghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByKhomang(System.Decimal Khomang)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khomang == Khomang);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByKhomangRDT(System.Decimal Khomang)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Khomang == Khomang);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByRongcuon(System.Decimal Rongcuon)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Rongcuon == Rongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByRongcuonRDT(System.Decimal Rongcuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Rongcuon == Rongcuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDaicuon(System.Decimal Daicuon)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Daicuon == Daicuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByDaicuonRDT(System.Decimal Daicuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Daicuon == Daicuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByHong(System.Decimal Hong)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Hong == Hong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByHongRDT(System.Decimal Hong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Hong == Hong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByBangdinhdan(System.Decimal Bangdinhdan)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Bangdinhdan == Bangdinhdan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByBangdinhdanRDT(System.Decimal Bangdinhdan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Bangdinhdan == Bangdinhdan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCautruc(System.String Cautruc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautruc == Cautruc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByCautrucRDT(System.String Cautruc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautruc == Cautruc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(DmhangFields.Masp.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
