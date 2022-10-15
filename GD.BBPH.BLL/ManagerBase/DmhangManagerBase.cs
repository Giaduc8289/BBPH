


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
		
		public const String Field_Kichthuoc="Kichthuoc";				
		
		public const String Field_Trongluong="Trongluong";				
		
		public const String Field_Sohinh="Sohinh";				
		
		public const String Field_Somau="Somau";				
		
		public const String Field_Loaimuc="Loaimuc";				
		
		public const String Field_Khoiluongmuc="Khoiluongmuc";				
		
		public const String Field_Cautrucin="Cautrucin";				
		
		public const String Field_Mamang1="Mamang1";				
		
		public const String Field_Tenmang1="Tenmang1";				
		
		public const String Field_Tlmanglop1="Tlmanglop1";				
		
		public const String Field_Tlkeolop1="Tlkeolop1";				
		
		public const String Field_Mamang2="Mamang2";				
		
		public const String Field_Tenmang2="Tenmang2";				
		
		public const String Field_Tlmanglop2="Tlmanglop2";				
		
		public const String Field_Tlkeolop2="Tlkeolop2";				
		
		public const String Field_Dinhluongkeo="Dinhluongkeo";				
		
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
			
			dt.Columns.Add(Field_Kichthuoc,typeof(System.String));
			
			dt.Columns.Add(Field_Trongluong,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sohinh,typeof(System.Int32));
			
			dt.Columns.Add(Field_Somau,typeof(System.Int32));
			
			dt.Columns.Add(Field_Loaimuc,typeof(System.String));
			
			dt.Columns.Add(Field_Khoiluongmuc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Cautrucin,typeof(System.String));
			
			dt.Columns.Add(Field_Mamang1,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang1,typeof(System.String));
			
			dt.Columns.Add(Field_Tlmanglop1,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tlkeolop1,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Mamang2,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmang2,typeof(System.String));
			
			dt.Columns.Add(Field_Tlmanglop2,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Tlkeolop2,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Dinhluongkeo,typeof(System.Decimal));
			
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
				r[Field_Kichthuoc]=_DmhangEntity.Kichthuoc;
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
				r[Field_Cautrucin]=_DmhangEntity.Cautrucin;
			}
			catch { }
			
			try
			{
				r[Field_Mamang1]=_DmhangEntity.Mamang1;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang1]=_DmhangEntity.Tenmang1;
			}
			catch { }
			
			try
			{
				r[Field_Tlmanglop1]=_DmhangEntity.Tlmanglop1;
			}
			catch { }
			
			try
			{
				r[Field_Tlkeolop1]=_DmhangEntity.Tlkeolop1;
			}
			catch { }
			
			try
			{
				r[Field_Mamang2]=_DmhangEntity.Mamang2;
			}
			catch { }
			
			try
			{
				r[Field_Tenmang2]=_DmhangEntity.Tenmang2;
			}
			catch { }
			
			try
			{
				r[Field_Tlmanglop2]=_DmhangEntity.Tlmanglop2;
			}
			catch { }
			
			try
			{
				r[Field_Tlkeolop2]=_DmhangEntity.Tlkeolop2;
			}
			catch { }
			
			try
			{
				r[Field_Dinhluongkeo]=_DmhangEntity.Dinhluongkeo;
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
				_DmhangEntity.Kichthuoc= r[Field_Kichthuoc].ToString();						
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
				_DmhangEntity.Cautrucin= r[Field_Cautrucin].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Mamang1= r[Field_Mamang1].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenmang1= r[Field_Tenmang1].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tlmanglop1= System.Decimal.Parse(r[Field_Tlmanglop1].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tlkeolop1= System.Decimal.Parse(r[Field_Tlkeolop1].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Mamang2= r[Field_Mamang2].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tenmang2= r[Field_Tenmang2].ToString();						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tlmanglop2= System.Decimal.Parse(r[Field_Tlmanglop2].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Tlkeolop2= System.Decimal.Parse(r[Field_Tlkeolop2].ToString());						
			}
			catch { }
			
			try
			{
				_DmhangEntity.Dinhluongkeo= System.Decimal.Parse(r[Field_Dinhluongkeo].ToString());						
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
			
			_DmhangEntity.Kichthuoc= _DmhangEntity_XML.Kichthuoc;
			
			_DmhangEntity.Trongluong= _DmhangEntity_XML.Trongluong;
			
			_DmhangEntity.Sohinh= _DmhangEntity_XML.Sohinh;
			
			_DmhangEntity.Somau= _DmhangEntity_XML.Somau;
			
			_DmhangEntity.Loaimuc= _DmhangEntity_XML.Loaimuc;
			
			_DmhangEntity.Khoiluongmuc= _DmhangEntity_XML.Khoiluongmuc;
			
			_DmhangEntity.Cautrucin= _DmhangEntity_XML.Cautrucin;
			
			_DmhangEntity.Mamang1= _DmhangEntity_XML.Mamang1;
			
			_DmhangEntity.Tenmang1= _DmhangEntity_XML.Tenmang1;
			
			_DmhangEntity.Tlmanglop1= _DmhangEntity_XML.Tlmanglop1;
			
			_DmhangEntity.Tlkeolop1= _DmhangEntity_XML.Tlkeolop1;
			
			_DmhangEntity.Mamang2= _DmhangEntity_XML.Mamang2;
			
			_DmhangEntity.Tenmang2= _DmhangEntity_XML.Tenmang2;
			
			_DmhangEntity.Tlmanglop2= _DmhangEntity_XML.Tlmanglop2;
			
			_DmhangEntity.Tlkeolop2= _DmhangEntity_XML.Tlkeolop2;
			
			_DmhangEntity.Dinhluongkeo= _DmhangEntity_XML.Dinhluongkeo;
			
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
				r.SetField(Field_Kichthuoc,_DmhangEntity.Kichthuoc);
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
				r.SetField(Field_Cautrucin,_DmhangEntity.Cautrucin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang1,_DmhangEntity.Mamang1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang1,_DmhangEntity.Tenmang1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlmanglop1,_DmhangEntity.Tlmanglop1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlkeolop1,_DmhangEntity.Tlkeolop1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang2,_DmhangEntity.Mamang2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang2,_DmhangEntity.Tenmang2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlmanglop2,_DmhangEntity.Tlmanglop2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlkeolop2,_DmhangEntity.Tlkeolop2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhluongkeo,_DmhangEntity.Dinhluongkeo);
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
				r.SetField(Field_Kichthuoc,_DmhangEntity.Kichthuoc);
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
				r.SetField(Field_Cautrucin,_DmhangEntity.Cautrucin);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang1,_DmhangEntity.Mamang1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang1,_DmhangEntity.Tenmang1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlmanglop1,_DmhangEntity.Tlmanglop1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlkeolop1,_DmhangEntity.Tlkeolop1);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamang2,_DmhangEntity.Mamang2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmang2,_DmhangEntity.Tenmang2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlmanglop2,_DmhangEntity.Tlmanglop2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tlkeolop2,_DmhangEntity.Tlkeolop2);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dinhluongkeo,_DmhangEntity.Dinhluongkeo);
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

		public DmhangEntity Insert(System.String  Masp, System.String  Tensp, System.String  Maspcuakhach, System.String  Machungloai, System.String  Tenchungloai, System.String  Makhach, System.String  Tenkhach, System.String  Kichthuoc, System.Decimal  Trongluong, System.Int32  Sohinh, System.Int32  Somau, System.String  Loaimuc, System.Decimal  Khoiluongmuc, System.String  Cautrucin, System.String  Mamang1, System.String  Tenmang1, System.Decimal  Tlmanglop1, System.Decimal  Tlkeolop1, System.String  Mamang2, System.String  Tenmang2, System.Decimal  Tlmanglop2, System.Decimal  Tlkeolop2, System.Decimal  Dinhluongkeo, System.String  Kichthuoctruc, System.String  Vitri, System.String  Maqcdonggoi, System.String  Tenqcdonggoi, System.String  Maqcloaithung, System.String  Tenqcloaithung, System.String  Maqcthanhpham, System.String  Tenqcthanhpham, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.Decimal  Rong, System.Decimal  Dai, System.String  Somauma, System.String  Sohinhma, System.String  Maloaimuc)
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
				
				_DmhangEntity.Kichthuoc = Kichthuoc;
				
				_DmhangEntity.Trongluong = Trongluong;
				
				_DmhangEntity.Sohinh = Sohinh;
				
				_DmhangEntity.Somau = Somau;
				
				_DmhangEntity.Loaimuc = Loaimuc;
				
				_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
				
				_DmhangEntity.Cautrucin = Cautrucin;
				
				_DmhangEntity.Mamang1 = Mamang1;
				
				_DmhangEntity.Tenmang1 = Tenmang1;
				
				_DmhangEntity.Tlmanglop1 = Tlmanglop1;
				
				_DmhangEntity.Tlkeolop1 = Tlkeolop1;
				
				_DmhangEntity.Mamang2 = Mamang2;
				
				_DmhangEntity.Tenmang2 = Tenmang2;
				
				_DmhangEntity.Tlmanglop2 = Tlmanglop2;
				
				_DmhangEntity.Tlkeolop2 = Tlkeolop2;
				
				_DmhangEntity.Dinhluongkeo = Dinhluongkeo;
				
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
					
					
				adapter.SaveEntity(_DmhangEntity, true);
			}
			return _DmhangEntity;
		}

		public DmhangEntity Insert(System.String Tensp, System.String Maspcuakhach, System.String Machungloai, System.String Tenchungloai, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.Decimal Trongluong, System.Int32 Sohinh, System.Int32 Somau, System.String Loaimuc, System.Decimal Khoiluongmuc, System.String Cautrucin, System.String Mamang1, System.String Tenmang1, System.Decimal Tlmanglop1, System.Decimal Tlkeolop1, System.String Mamang2, System.String Tenmang2, System.Decimal Tlmanglop2, System.Decimal Tlkeolop2, System.Decimal Dinhluongkeo, System.String Kichthuoctruc, System.String Vitri, System.String Maqcdonggoi, System.String Tenqcdonggoi, System.String Maqcloaithung, System.String Tenqcloaithung, System.String Maqcthanhpham, System.String Tenqcthanhpham, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Rong, System.Decimal Dai, System.String Somauma, System.String Sohinhma, System.String Maloaimuc)//ko co mahieu
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
				
				_DmhangEntity.Kichthuoc = Kichthuoc;
				
				_DmhangEntity.Trongluong = Trongluong;
				
				_DmhangEntity.Sohinh = Sohinh;
				
				_DmhangEntity.Somau = Somau;
				
				_DmhangEntity.Loaimuc = Loaimuc;
				
				_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
				
				_DmhangEntity.Cautrucin = Cautrucin;
				
				_DmhangEntity.Mamang1 = Mamang1;
				
				_DmhangEntity.Tenmang1 = Tenmang1;
				
				_DmhangEntity.Tlmanglop1 = Tlmanglop1;
				
				_DmhangEntity.Tlkeolop1 = Tlkeolop1;
				
				_DmhangEntity.Mamang2 = Mamang2;
				
				_DmhangEntity.Tenmang2 = Tenmang2;
				
				_DmhangEntity.Tlmanglop2 = Tlmanglop2;
				
				_DmhangEntity.Tlkeolop2 = Tlkeolop2;
				
				_DmhangEntity.Dinhluongkeo = Dinhluongkeo;
				
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

		public bool Update(System.String Masp, System.String Tensp, System.String Maspcuakhach, System.String Machungloai, System.String Tenchungloai, System.String Makhach, System.String Tenkhach, System.String Kichthuoc, System.Decimal Trongluong, System.Int32 Sohinh, System.Int32 Somau, System.String Loaimuc, System.Decimal Khoiluongmuc, System.String Cautrucin, System.String Mamang1, System.String Tenmang1, System.Decimal Tlmanglop1, System.Decimal Tlkeolop1, System.String Mamang2, System.String Tenmang2, System.Decimal Tlmanglop2, System.Decimal Tlkeolop2, System.Decimal Dinhluongkeo, System.String Kichthuoctruc, System.String Vitri, System.String Maqcdonggoi, System.String Tenqcdonggoi, System.String Maqcloaithung, System.String Tenqcloaithung, System.String Maqcthanhpham, System.String Tenqcthanhpham, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.Decimal Rong, System.Decimal Dai, System.String Somauma, System.String Sohinhma, System.String Maloaimuc)
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
					
					_DmhangEntity.Kichthuoc = Kichthuoc;
					
					_DmhangEntity.Trongluong = Trongluong;
					
					_DmhangEntity.Sohinh = Sohinh;
					
					_DmhangEntity.Somau = Somau;
					
					_DmhangEntity.Loaimuc = Loaimuc;
					
					_DmhangEntity.Khoiluongmuc = Khoiluongmuc;
					
					_DmhangEntity.Cautrucin = Cautrucin;
					
					_DmhangEntity.Mamang1 = Mamang1;
					
					_DmhangEntity.Tenmang1 = Tenmang1;
					
					_DmhangEntity.Tlmanglop1 = Tlmanglop1;
					
					_DmhangEntity.Tlkeolop1 = Tlkeolop1;
					
					_DmhangEntity.Mamang2 = Mamang2;
					
					_DmhangEntity.Tenmang2 = Tenmang2;
					
					_DmhangEntity.Tlmanglop2 = Tlmanglop2;
					
					_DmhangEntity.Tlkeolop2 = Tlkeolop2;
					
					_DmhangEntity.Dinhluongkeo = Dinhluongkeo;
					
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
		
		public int DeleteByKichthuoc(System.String Kichthuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoc == Kichthuoc);
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
		
		public int DeleteByCautrucin(System.String Cautrucin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautrucin == Cautrucin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang1(System.String Mamang1)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Mamang1 == Mamang1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang1(System.String Tenmang1)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenmang1 == Tenmang1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTlmanglop1(System.Decimal Tlmanglop1)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlmanglop1 == Tlmanglop1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTlkeolop1(System.Decimal Tlkeolop1)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlkeolop1 == Tlkeolop1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamang2(System.String Mamang2)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Mamang2 == Mamang2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmang2(System.String Tenmang2)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenmang2 == Tenmang2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTlmanglop2(System.Decimal Tlmanglop2)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlmanglop2 == Tlmanglop2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTlkeolop2(System.Decimal Tlkeolop2)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlkeolop2 == Tlkeolop2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DmhangEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDinhluongkeo(System.Decimal Dinhluongkeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Dinhluongkeo == Dinhluongkeo);
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
		public EntityCollection SelectByKichthuoc(System.String Kichthuoc)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoc == Kichthuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByKichthuocRDT(System.String Kichthuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Kichthuoc == Kichthuoc);
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
		public EntityCollection SelectByCautrucin(System.String Cautrucin)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautrucin == Cautrucin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByCautrucinRDT(System.String Cautrucin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Cautrucin == Cautrucin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang1(System.String Mamang1)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Mamang1 == Mamang1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamang1RDT(System.String Mamang1)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Mamang1 == Mamang1);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang1(System.String Tenmang1)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenmang1 == Tenmang1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmang1RDT(System.String Tenmang1)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenmang1 == Tenmang1);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTlmanglop1(System.Decimal Tlmanglop1)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlmanglop1 == Tlmanglop1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTlmanglop1RDT(System.Decimal Tlmanglop1)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlmanglop1 == Tlmanglop1);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTlkeolop1(System.Decimal Tlkeolop1)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlkeolop1 == Tlkeolop1);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTlkeolop1RDT(System.Decimal Tlkeolop1)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlkeolop1 == Tlkeolop1);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamang2(System.String Mamang2)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Mamang2 == Mamang2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByMamang2RDT(System.String Mamang2)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Mamang2 == Mamang2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmang2(System.String Tenmang2)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenmang2 == Tenmang2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmang2RDT(System.String Tenmang2)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tenmang2 == Tenmang2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTlmanglop2(System.Decimal Tlmanglop2)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlmanglop2 == Tlmanglop2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTlmanglop2RDT(System.Decimal Tlmanglop2)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlmanglop2 == Tlmanglop2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTlkeolop2(System.Decimal Tlkeolop2)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlkeolop2 == Tlkeolop2);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByTlkeolop2RDT(System.Decimal Tlkeolop2)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Tlkeolop2 == Tlkeolop2);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DmhangCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDinhluongkeo(System.Decimal Dinhluongkeo)
		{
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Dinhluongkeo == Dinhluongkeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DmhangCollection, filter, 0, null);
			}
			return _DmhangCollection;
		}
		// Return DataTable
		public DataTable SelectByDinhluongkeoRDT(System.Decimal Dinhluongkeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DmhangCollection = new EntityCollection(new DmhangEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DmhangFields.Dinhluongkeo == Dinhluongkeo);
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
			

	}
}
