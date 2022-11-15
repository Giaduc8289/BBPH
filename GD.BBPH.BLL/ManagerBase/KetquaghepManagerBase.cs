﻿


/*
'===============================================================================
'  GD.BBPH.BL.KetquaghepManagerBase
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
	public class KetquaghepManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Mamay="Mamay";				
		
		public const String Field_Lenhghep="Lenhghep";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_Dauratua="Dauratua";				
		
		public const String Field_ManginMet="ManginMet";				
		
		public const String Field_ManginKg="ManginKg";				
		
		public const String Field_MangcapMet="MangcapMet";				
		
		public const String Field_MangcapKg="MangcapKg";				
		
		public const String Field_Solopghep="Solopghep";				
		
		public const String Field_ThucteMet="ThucteMet";				
		
		public const String Field_ThucteKg="ThucteKg";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianchuanbi="Thoigianchuanbi";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_Thuctekeo="Thuctekeo";				
		
		public const String Field_Thuctedongran="Thuctedongran";				
		
		public const String Field_Thuctedungmoi="Thuctedungmoi";				
		
		public const String Field_Phein="Phein";				
		
		public const String Field_Pheghep="Pheghep";				
		
		public const String Field_PheNcc="PheNcc";				
		
		public const String Field_PheSx="PheSx";				
		
		public const String Field_Phethoi="Phethoi";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
		public const String Field_Tensanpham="Tensanpham";				
		
		public const String Field_Tenmay="Tenmay";				
		
		public const String Field_Tencongnhan="Tencongnhan";				
		
		public const String Field_Nangsuat="Nangsuat";				
		
		public const String Field_Matruongca="Matruongca";				
		
		public const String Field_Tentruongca="Tentruongca";				
		
		public const String Field_Tocdodinhmuc="Tocdodinhmuc";				
		
		public const String Field_Lydosuco="Lydosuco";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquaghepManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ca,typeof(System.Int32));
			
			dt.Columns.Add(Field_Mamay,typeof(System.String));
			
			dt.Columns.Add(Field_Lenhghep,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Dauratua,typeof(System.Decimal));
			
			dt.Columns.Add(Field_ManginMet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_ManginKg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_MangcapMet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_MangcapKg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Solopghep,typeof(System.Int32));
			
			dt.Columns.Add(Field_ThucteMet,typeof(System.Decimal));
			
			dt.Columns.Add(Field_ThucteKg,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianchuanbi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thuctekeo,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thuctedongran,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Thuctedungmoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phein,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Pheghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_PheNcc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_PheSx,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phethoi,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
			
			dt.Columns.Add(Field_Tensanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Tenmay,typeof(System.String));
			
			dt.Columns.Add(Field_Tencongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Nangsuat,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Matruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tentruongca,typeof(System.String));
			
			dt.Columns.Add(Field_Tocdodinhmuc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Lydosuco,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquaghepEntity _KetquaghepEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquaghepEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquaghepEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquaghepEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Mamay]=_KetquaghepEntity.Mamay;
			}
			catch { }
			
			try
			{
				r[Field_Lenhghep]=_KetquaghepEntity.Lenhghep;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KetquaghepEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquaghepEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Dauratua]=_KetquaghepEntity.Dauratua;
			}
			catch { }
			
			try
			{
				r[Field_ManginMet]=_KetquaghepEntity.ManginMet;
			}
			catch { }
			
			try
			{
				r[Field_ManginKg]=_KetquaghepEntity.ManginKg;
			}
			catch { }
			
			try
			{
				r[Field_MangcapMet]=_KetquaghepEntity.MangcapMet;
			}
			catch { }
			
			try
			{
				r[Field_MangcapKg]=_KetquaghepEntity.MangcapKg;
			}
			catch { }
			
			try
			{
				r[Field_Solopghep]=_KetquaghepEntity.Solopghep;
			}
			catch { }
			
			try
			{
				r[Field_ThucteMet]=_KetquaghepEntity.ThucteMet;
			}
			catch { }
			
			try
			{
				r[Field_ThucteKg]=_KetquaghepEntity.ThucteKg;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquaghepEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquaghepEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianchuanbi]=_KetquaghepEntity.Thoigianchuanbi;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquaghepEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_Thuctekeo]=_KetquaghepEntity.Thuctekeo;
			}
			catch { }
			
			try
			{
				r[Field_Thuctedongran]=_KetquaghepEntity.Thuctedongran;
			}
			catch { }
			
			try
			{
				r[Field_Thuctedungmoi]=_KetquaghepEntity.Thuctedungmoi;
			}
			catch { }
			
			try
			{
				r[Field_Phein]=_KetquaghepEntity.Phein;
			}
			catch { }
			
			try
			{
				r[Field_Pheghep]=_KetquaghepEntity.Pheghep;
			}
			catch { }
			
			try
			{
				r[Field_PheNcc]=_KetquaghepEntity.PheNcc;
			}
			catch { }
			
			try
			{
				r[Field_PheSx]=_KetquaghepEntity.PheSx;
			}
			catch { }
			
			try
			{
				r[Field_Phethoi]=_KetquaghepEntity.Phethoi;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquaghepEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquaghepEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquaghepEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquaghepEntity.Nguoisua;
			}
			catch { }
			
			try
			{
				r[Field_Tensanpham]=_KetquaghepEntity.Tensanpham;
			}
			catch { }
			
			try
			{
				r[Field_Tenmay]=_KetquaghepEntity.Tenmay;
			}
			catch { }
			
			try
			{
				r[Field_Tencongnhan]=_KetquaghepEntity.Tencongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Nangsuat]=_KetquaghepEntity.Nangsuat;
			}
			catch { }
			
			try
			{
				r[Field_Matruongca]=_KetquaghepEntity.Matruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tentruongca]=_KetquaghepEntity.Tentruongca;
			}
			catch { }
			
			try
			{
				r[Field_Tocdodinhmuc]=_KetquaghepEntity.Tocdodinhmuc;
			}
			catch { }
			
			try
			{
				r[Field_Lydosuco]=_KetquaghepEntity.Lydosuco;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquaghepEntity Convert(DataRow r)
		{	
			
			KetquaghepEntity _KetquaghepEntity=new KetquaghepEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquaghepEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Mamay= r[Field_Mamay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Lenhghep= r[Field_Lenhghep].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Dauratua= System.Decimal.Parse(r[Field_Dauratua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.ManginMet= System.Decimal.Parse(r[Field_ManginMet].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.ManginKg= System.Decimal.Parse(r[Field_ManginKg].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.MangcapMet= System.Decimal.Parse(r[Field_MangcapMet].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.MangcapKg= System.Decimal.Parse(r[Field_MangcapKg].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Solopghep= System.Int32.Parse(r[Field_Solopghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.ThucteMet= System.Decimal.Parse(r[Field_ThucteMet].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.ThucteKg= System.Decimal.Parse(r[Field_ThucteKg].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Thoigianchuanbi= System.Decimal.Parse(r[Field_Thoigianchuanbi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Thoigiansuco= System.Decimal.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Thuctekeo= System.Decimal.Parse(r[Field_Thuctekeo].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Thuctedongran= System.Decimal.Parse(r[Field_Thuctedongran].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Thuctedungmoi= System.Decimal.Parse(r[Field_Thuctedungmoi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Phein= System.Decimal.Parse(r[Field_Phein].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Pheghep= System.Decimal.Parse(r[Field_Pheghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.PheNcc= System.Decimal.Parse(r[Field_PheNcc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.PheSx= System.Decimal.Parse(r[Field_PheSx].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Phethoi= System.Decimal.Parse(r[Field_Phethoi].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Tensanpham= r[Field_Tensanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Tenmay= r[Field_Tenmay].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Tencongnhan= r[Field_Tencongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Nangsuat= System.Decimal.Parse(r[Field_Nangsuat].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Matruongca= r[Field_Matruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Tentruongca= r[Field_Tentruongca].ToString();						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Tocdodinhmuc= System.Decimal.Parse(r[Field_Tocdodinhmuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquaghepEntity.Lydosuco= r[Field_Lydosuco].ToString();						
			}
			catch { }
									
									
			return _KetquaghepEntity;
		}			
		
		public KetquaghepEntity Convert_Entity(KetquaghepEntity _KetquaghepEntity,KetquaghepEntity _KetquaghepEntity_XML)
		{	
			
			
			_KetquaghepEntity.Id= _KetquaghepEntity_XML.Id;
			
			_KetquaghepEntity.Ngay= _KetquaghepEntity_XML.Ngay;
			
			_KetquaghepEntity.Ca= _KetquaghepEntity_XML.Ca;
			
			_KetquaghepEntity.Mamay= _KetquaghepEntity_XML.Mamay;
			
			_KetquaghepEntity.Lenhghep= _KetquaghepEntity_XML.Lenhghep;
			
			_KetquaghepEntity.Masanpham= _KetquaghepEntity_XML.Masanpham;
			
			_KetquaghepEntity.Macongnhan= _KetquaghepEntity_XML.Macongnhan;
			
			_KetquaghepEntity.Dauratua= _KetquaghepEntity_XML.Dauratua;
			
			_KetquaghepEntity.ManginMet= _KetquaghepEntity_XML.ManginMet;
			
			_KetquaghepEntity.ManginKg= _KetquaghepEntity_XML.ManginKg;
			
			_KetquaghepEntity.MangcapMet= _KetquaghepEntity_XML.MangcapMet;
			
			_KetquaghepEntity.MangcapKg= _KetquaghepEntity_XML.MangcapKg;
			
			_KetquaghepEntity.Solopghep= _KetquaghepEntity_XML.Solopghep;
			
			_KetquaghepEntity.ThucteMet= _KetquaghepEntity_XML.ThucteMet;
			
			_KetquaghepEntity.ThucteKg= _KetquaghepEntity_XML.ThucteKg;
			
			_KetquaghepEntity.Thoigianbatdau= _KetquaghepEntity_XML.Thoigianbatdau;
			
			_KetquaghepEntity.Thoigianketthuc= _KetquaghepEntity_XML.Thoigianketthuc;
			
			_KetquaghepEntity.Thoigianchuanbi= _KetquaghepEntity_XML.Thoigianchuanbi;
			
			_KetquaghepEntity.Thoigiansuco= _KetquaghepEntity_XML.Thoigiansuco;
			
			_KetquaghepEntity.Thuctekeo= _KetquaghepEntity_XML.Thuctekeo;
			
			_KetquaghepEntity.Thuctedongran= _KetquaghepEntity_XML.Thuctedongran;
			
			_KetquaghepEntity.Thuctedungmoi= _KetquaghepEntity_XML.Thuctedungmoi;
			
			_KetquaghepEntity.Phein= _KetquaghepEntity_XML.Phein;
			
			_KetquaghepEntity.Pheghep= _KetquaghepEntity_XML.Pheghep;
			
			_KetquaghepEntity.PheNcc= _KetquaghepEntity_XML.PheNcc;
			
			_KetquaghepEntity.PheSx= _KetquaghepEntity_XML.PheSx;
			
			_KetquaghepEntity.Phethoi= _KetquaghepEntity_XML.Phethoi;
			
			_KetquaghepEntity.Ngaytao= _KetquaghepEntity_XML.Ngaytao;
			
			_KetquaghepEntity.Nguoitao= _KetquaghepEntity_XML.Nguoitao;
			
			_KetquaghepEntity.Ngaysua= _KetquaghepEntity_XML.Ngaysua;
			
			_KetquaghepEntity.Nguoisua= _KetquaghepEntity_XML.Nguoisua;
			
			_KetquaghepEntity.Tensanpham= _KetquaghepEntity_XML.Tensanpham;
			
			_KetquaghepEntity.Tenmay= _KetquaghepEntity_XML.Tenmay;
			
			_KetquaghepEntity.Tencongnhan= _KetquaghepEntity_XML.Tencongnhan;
			
			_KetquaghepEntity.Nangsuat= _KetquaghepEntity_XML.Nangsuat;
			
			_KetquaghepEntity.Matruongca= _KetquaghepEntity_XML.Matruongca;
			
			_KetquaghepEntity.Tentruongca= _KetquaghepEntity_XML.Tentruongca;
			
			_KetquaghepEntity.Tocdodinhmuc= _KetquaghepEntity_XML.Tocdodinhmuc;
			
			_KetquaghepEntity.Lydosuco= _KetquaghepEntity_XML.Lydosuco;
									
				
			return _KetquaghepEntity;
		}	
		
		public String InsertV2(KetquaghepEntity _KetquaghepEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquaghepManagerBase()).Insert(_KetquaghepEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquaghepEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquaghepEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquaghepEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquaghepEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhghep,_KetquaghepEntity.Lenhghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquaghepEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquaghepEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauratua,_KetquaghepEntity.Dauratua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ManginMet,_KetquaghepEntity.ManginMet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ManginKg,_KetquaghepEntity.ManginKg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MangcapMet,_KetquaghepEntity.MangcapMet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MangcapKg,_KetquaghepEntity.MangcapKg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solopghep,_KetquaghepEntity.Solopghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ThucteMet,_KetquaghepEntity.ThucteMet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ThucteKg,_KetquaghepEntity.ThucteKg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquaghepEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquaghepEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquaghepEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquaghepEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctekeo,_KetquaghepEntity.Thuctekeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctedongran,_KetquaghepEntity.Thuctedongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctedungmoi,_KetquaghepEntity.Thuctedungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquaghepEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquaghepEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheNcc,_KetquaghepEntity.PheNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheSx,_KetquaghepEntity.PheSx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquaghepEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquaghepEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquaghepEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquaghepEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquaghepEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquaghepEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquaghepEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquaghepEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquaghepEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquaghepEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquaghepEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquaghepEntity.Tocdodinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lydosuco,_KetquaghepEntity.Lydosuco);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquaghepEntity _KetquaghepEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquaghepManagerBase()).Update(_KetquaghepEntity);
			r.SetField(Field_Id,_KetquaghepEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquaghepEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquaghepEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Mamay,_KetquaghepEntity.Mamay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenhghep,_KetquaghepEntity.Lenhghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquaghepEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquaghepEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauratua,_KetquaghepEntity.Dauratua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ManginMet,_KetquaghepEntity.ManginMet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ManginKg,_KetquaghepEntity.ManginKg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MangcapMet,_KetquaghepEntity.MangcapMet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_MangcapKg,_KetquaghepEntity.MangcapKg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solopghep,_KetquaghepEntity.Solopghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ThucteMet,_KetquaghepEntity.ThucteMet);
			}
			catch { }
			
			try
			{
				r.SetField(Field_ThucteKg,_KetquaghepEntity.ThucteKg);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquaghepEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquaghepEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianchuanbi,_KetquaghepEntity.Thoigianchuanbi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquaghepEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctekeo,_KetquaghepEntity.Thuctekeo);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctedongran,_KetquaghepEntity.Thuctedongran);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thuctedungmoi,_KetquaghepEntity.Thuctedungmoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquaghepEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquaghepEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheNcc,_KetquaghepEntity.PheNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PheSx,_KetquaghepEntity.PheSx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phethoi,_KetquaghepEntity.Phethoi);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquaghepEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquaghepEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquaghepEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquaghepEntity.Nguoisua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tensanpham,_KetquaghepEntity.Tensanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tenmay,_KetquaghepEntity.Tenmay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tencongnhan,_KetquaghepEntity.Tencongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nangsuat,_KetquaghepEntity.Nangsuat);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Matruongca,_KetquaghepEntity.Matruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tentruongca,_KetquaghepEntity.Tentruongca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Tocdodinhmuc,_KetquaghepEntity.Tocdodinhmuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lydosuco,_KetquaghepEntity.Lydosuco);
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

		public KetquaghepEntity Insert(KetquaghepEntity KetquaghepEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquaghepEntity, true);
			}
			return KetquaghepEntity;
		}

		public KetquaghepEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Mamay, System.String  Lenhghep, System.String  Masanpham, System.String  Macongnhan, System.Decimal  Dauratua, System.Decimal  ManginMet, System.Decimal  ManginKg, System.Decimal  MangcapMet, System.Decimal  MangcapKg, System.Int32  Solopghep, System.Decimal  ThucteMet, System.Decimal  ThucteKg, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.Decimal  Thoigianchuanbi, System.Decimal  Thoigiansuco, System.Decimal  Thuctekeo, System.Decimal  Thuctedongran, System.Decimal  Thuctedungmoi, System.Decimal  Phein, System.Decimal  Pheghep, System.Decimal  PheNcc, System.Decimal  PheSx, System.Decimal  Phethoi, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua, System.String  Tensanpham, System.String  Tenmay, System.String  Tencongnhan, System.Decimal  Nangsuat, System.String  Matruongca, System.String  Tentruongca, System.Decimal  Tocdodinhmuc, System.String  Lydosuco)
		{
			KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquaghepEntity.Id = Id;
				
				_KetquaghepEntity.Ngay = Ngay;
				
				_KetquaghepEntity.Ca = Ca;
				
				_KetquaghepEntity.Mamay = Mamay;
				
				_KetquaghepEntity.Lenhghep = Lenhghep;
				
				_KetquaghepEntity.Masanpham = Masanpham;
				
				_KetquaghepEntity.Macongnhan = Macongnhan;
				
				_KetquaghepEntity.Dauratua = Dauratua;
				
				_KetquaghepEntity.ManginMet = ManginMet;
				
				_KetquaghepEntity.ManginKg = ManginKg;
				
				_KetquaghepEntity.MangcapMet = MangcapMet;
				
				_KetquaghepEntity.MangcapKg = MangcapKg;
				
				_KetquaghepEntity.Solopghep = Solopghep;
				
				_KetquaghepEntity.ThucteMet = ThucteMet;
				
				_KetquaghepEntity.ThucteKg = ThucteKg;
				
				_KetquaghepEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquaghepEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquaghepEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquaghepEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquaghepEntity.Thuctekeo = Thuctekeo;
				
				_KetquaghepEntity.Thuctedongran = Thuctedongran;
				
				_KetquaghepEntity.Thuctedungmoi = Thuctedungmoi;
				
				_KetquaghepEntity.Phein = Phein;
				
				_KetquaghepEntity.Pheghep = Pheghep;
				
				_KetquaghepEntity.PheNcc = PheNcc;
				
				_KetquaghepEntity.PheSx = PheSx;
				
				_KetquaghepEntity.Phethoi = Phethoi;
				
				_KetquaghepEntity.Ngaytao = Ngaytao;
				
				_KetquaghepEntity.Nguoitao = Nguoitao;
				
				_KetquaghepEntity.Ngaysua = Ngaysua;
				
				_KetquaghepEntity.Nguoisua = Nguoisua;
				
				_KetquaghepEntity.Tensanpham = Tensanpham;
				
				_KetquaghepEntity.Tenmay = Tenmay;
				
				_KetquaghepEntity.Tencongnhan = Tencongnhan;
				
				_KetquaghepEntity.Nangsuat = Nangsuat;
				
				_KetquaghepEntity.Matruongca = Matruongca;
				
				_KetquaghepEntity.Tentruongca = Tentruongca;
				
				_KetquaghepEntity.Tocdodinhmuc = Tocdodinhmuc;
				
				_KetquaghepEntity.Lydosuco = Lydosuco;
					
					
				adapter.SaveEntity(_KetquaghepEntity, true);
			}
			return _KetquaghepEntity;
		}

		public KetquaghepEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhghep, System.String Masanpham, System.String Macongnhan, System.Decimal Dauratua, System.Decimal ManginMet, System.Decimal ManginKg, System.Decimal MangcapMet, System.Decimal MangcapKg, System.Int32 Solopghep, System.Decimal ThucteMet, System.Decimal ThucteKg, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigiansuco, System.Decimal Thuctekeo, System.Decimal Thuctedongran, System.Decimal Thuctedungmoi, System.Decimal Phein, System.Decimal Pheghep, System.Decimal PheNcc, System.Decimal PheSx, System.Decimal Phethoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Nangsuat, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc, System.String Lydosuco)//ko co mahieu
		{
			KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquaghepEntity.Ngay = Ngay;
				
				_KetquaghepEntity.Ca = Ca;
				
				_KetquaghepEntity.Mamay = Mamay;
				
				_KetquaghepEntity.Lenhghep = Lenhghep;
				
				_KetquaghepEntity.Masanpham = Masanpham;
				
				_KetquaghepEntity.Macongnhan = Macongnhan;
				
				_KetquaghepEntity.Dauratua = Dauratua;
				
				_KetquaghepEntity.ManginMet = ManginMet;
				
				_KetquaghepEntity.ManginKg = ManginKg;
				
				_KetquaghepEntity.MangcapMet = MangcapMet;
				
				_KetquaghepEntity.MangcapKg = MangcapKg;
				
				_KetquaghepEntity.Solopghep = Solopghep;
				
				_KetquaghepEntity.ThucteMet = ThucteMet;
				
				_KetquaghepEntity.ThucteKg = ThucteKg;
				
				_KetquaghepEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquaghepEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquaghepEntity.Thoigianchuanbi = Thoigianchuanbi;
				
				_KetquaghepEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquaghepEntity.Thuctekeo = Thuctekeo;
				
				_KetquaghepEntity.Thuctedongran = Thuctedongran;
				
				_KetquaghepEntity.Thuctedungmoi = Thuctedungmoi;
				
				_KetquaghepEntity.Phein = Phein;
				
				_KetquaghepEntity.Pheghep = Pheghep;
				
				_KetquaghepEntity.PheNcc = PheNcc;
				
				_KetquaghepEntity.PheSx = PheSx;
				
				_KetquaghepEntity.Phethoi = Phethoi;
				
				_KetquaghepEntity.Ngaytao = Ngaytao;
				
				_KetquaghepEntity.Nguoitao = Nguoitao;
				
				_KetquaghepEntity.Ngaysua = Ngaysua;
				
				_KetquaghepEntity.Nguoisua = Nguoisua;
				
				_KetquaghepEntity.Tensanpham = Tensanpham;
				
				_KetquaghepEntity.Tenmay = Tenmay;
				
				_KetquaghepEntity.Tencongnhan = Tencongnhan;
				
				_KetquaghepEntity.Nangsuat = Nangsuat;
				
				_KetquaghepEntity.Matruongca = Matruongca;
				
				_KetquaghepEntity.Tentruongca = Tentruongca;
				
				_KetquaghepEntity.Tocdodinhmuc = Tocdodinhmuc;
				
				_KetquaghepEntity.Lydosuco = Lydosuco;
					

				adapter.SaveEntity(_KetquaghepEntity, true);
			}
			return _KetquaghepEntity;
		}

		public bool Update(KetquaghepEntity _KetquaghepEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquaghepFields.Id == _KetquaghepEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquaghepEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquaghepEntity _KetquaghepEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquaghepEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Mamay, System.String Lenhghep, System.String Masanpham, System.String Macongnhan, System.Decimal Dauratua, System.Decimal ManginMet, System.Decimal ManginKg, System.Decimal MangcapMet, System.Decimal MangcapKg, System.Int32 Solopghep, System.Decimal ThucteMet, System.Decimal ThucteKg, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.Decimal Thoigianchuanbi, System.Decimal Thoigiansuco, System.Decimal Thuctekeo, System.Decimal Thuctedongran, System.Decimal Thuctedungmoi, System.Decimal Phein, System.Decimal Pheghep, System.Decimal PheNcc, System.Decimal PheSx, System.Decimal Phethoi, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua, System.String Tensanpham, System.String Tenmay, System.String Tencongnhan, System.Decimal Nangsuat, System.String Matruongca, System.String Tentruongca, System.Decimal Tocdodinhmuc, System.String Lydosuco)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity(Id);
				if (adapter.FetchEntity(_KetquaghepEntity))
				{
				
					
					
					_KetquaghepEntity.Ngay = Ngay;
					
					_KetquaghepEntity.Ca = Ca;
					
					_KetquaghepEntity.Mamay = Mamay;
					
					_KetquaghepEntity.Lenhghep = Lenhghep;
					
					_KetquaghepEntity.Masanpham = Masanpham;
					
					_KetquaghepEntity.Macongnhan = Macongnhan;
					
					_KetquaghepEntity.Dauratua = Dauratua;
					
					_KetquaghepEntity.ManginMet = ManginMet;
					
					_KetquaghepEntity.ManginKg = ManginKg;
					
					_KetquaghepEntity.MangcapMet = MangcapMet;
					
					_KetquaghepEntity.MangcapKg = MangcapKg;
					
					_KetquaghepEntity.Solopghep = Solopghep;
					
					_KetquaghepEntity.ThucteMet = ThucteMet;
					
					_KetquaghepEntity.ThucteKg = ThucteKg;
					
					_KetquaghepEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquaghepEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquaghepEntity.Thoigianchuanbi = Thoigianchuanbi;
					
					_KetquaghepEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquaghepEntity.Thuctekeo = Thuctekeo;
					
					_KetquaghepEntity.Thuctedongran = Thuctedongran;
					
					_KetquaghepEntity.Thuctedungmoi = Thuctedungmoi;
					
					_KetquaghepEntity.Phein = Phein;
					
					_KetquaghepEntity.Pheghep = Pheghep;
					
					_KetquaghepEntity.PheNcc = PheNcc;
					
					_KetquaghepEntity.PheSx = PheSx;
					
					_KetquaghepEntity.Phethoi = Phethoi;
					
					_KetquaghepEntity.Ngaytao = Ngaytao;
					
					_KetquaghepEntity.Nguoitao = Nguoitao;
					
					_KetquaghepEntity.Ngaysua = Ngaysua;
					
					_KetquaghepEntity.Nguoisua = Nguoisua;
					
					_KetquaghepEntity.Tensanpham = Tensanpham;
					
					_KetquaghepEntity.Tenmay = Tenmay;
					
					_KetquaghepEntity.Tencongnhan = Tencongnhan;
					
					_KetquaghepEntity.Nangsuat = Nangsuat;
					
					_KetquaghepEntity.Matruongca = Matruongca;
					
					_KetquaghepEntity.Tentruongca = Tentruongca;
					
					_KetquaghepEntity.Tocdodinhmuc = Tocdodinhmuc;
					
					_KetquaghepEntity.Lydosuco = Lydosuco;
						

					adapter.SaveEntity(_KetquaghepEntity, true);
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
				KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity(Id);
				if (adapter.FetchEntity(_KetquaghepEntity))
				{
					adapter.DeleteEntity(_KetquaghepEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquaghepEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMamay(System.String Mamay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenhghep(System.String Lenhghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Lenhghep == Lenhghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauratua(System.Decimal Dauratua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Dauratua == Dauratua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManginMet(System.Decimal ManginMet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ManginMet == ManginMet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByManginKg(System.Decimal ManginKg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ManginKg == ManginKg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMangcapMet(System.Decimal MangcapMet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.MangcapMet == MangcapMet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMangcapKg(System.Decimal MangcapKg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.MangcapKg == MangcapKg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolopghep(System.Int32 Solopghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Solopghep == Solopghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThucteMet(System.Decimal ThucteMet)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ThucteMet == ThucteMet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThucteKg(System.Decimal ThucteKg)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ThucteKg == ThucteKg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.Decimal Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThuctekeo(System.Decimal Thuctekeo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctekeo == Thuctekeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThuctedongran(System.Decimal Thuctedongran)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctedongran == Thuctedongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThuctedungmoi(System.Decimal Thuctedungmoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctedungmoi == Thuctedungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhein(System.Decimal Phein)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheghep(System.Decimal Pheghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheNcc(System.Decimal PheNcc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.PheNcc == PheNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheSx(System.Decimal PheSx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.PheSx == PheSx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhethoi(System.Decimal Phethoi)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTensanpham(System.String Tensanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTenmay(System.String Tenmay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTencongnhan(System.String Tencongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNangsuat(System.Decimal Nangsuat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMatruongca(System.String Matruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTentruongca(System.String Tentruongca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLydosuco(System.String Lydosuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquaghepEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquaghepEntity SelectOne(System.Int64 Id)
		{
			KetquaghepEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquaghepEntity _KetquaghepEntity = new KetquaghepEntity(Id);
				if (adapter.FetchEntity(_KetquaghepEntity))
				{
					toReturn = _KetquaghepEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquaghepCollection = new EntityCollection( new KetquaghepEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, null, 0, null);
			}
			return _KetquaghepCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMamay(System.String Mamay)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMamayRDT(System.String Mamay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Mamay == Mamay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenhghep(System.String Lenhghep)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Lenhghep == Lenhghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhghepRDT(System.String Lenhghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Lenhghep == Lenhghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauratua(System.Decimal Dauratua)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Dauratua == Dauratua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByDauratuaRDT(System.Decimal Dauratua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Dauratua == Dauratua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManginMet(System.Decimal ManginMet)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ManginMet == ManginMet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByManginMetRDT(System.Decimal ManginMet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ManginMet == ManginMet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByManginKg(System.Decimal ManginKg)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ManginKg == ManginKg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByManginKgRDT(System.Decimal ManginKg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ManginKg == ManginKg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMangcapMet(System.Decimal MangcapMet)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.MangcapMet == MangcapMet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMangcapMetRDT(System.Decimal MangcapMet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.MangcapMet == MangcapMet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMangcapKg(System.Decimal MangcapKg)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.MangcapKg == MangcapKg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMangcapKgRDT(System.Decimal MangcapKg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.MangcapKg == MangcapKg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolopghep(System.Int32 Solopghep)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Solopghep == Solopghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectBySolopghepRDT(System.Int32 Solopghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Solopghep == Solopghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThucteMet(System.Decimal ThucteMet)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ThucteMet == ThucteMet);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThucteMetRDT(System.Decimal ThucteMet)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ThucteMet == ThucteMet);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThucteKg(System.Decimal ThucteKg)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ThucteKg == ThucteKg);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThucteKgRDT(System.Decimal ThucteKg)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.ThucteKg == ThucteKg);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianchuanbi(System.Decimal Thoigianchuanbi)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianchuanbiRDT(System.Decimal Thoigianchuanbi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigianchuanbi == Thoigianchuanbi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.Decimal Thoigiansuco)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.Decimal Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThuctekeo(System.Decimal Thuctekeo)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctekeo == Thuctekeo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThuctekeoRDT(System.Decimal Thuctekeo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctekeo == Thuctekeo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThuctedongran(System.Decimal Thuctedongran)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctedongran == Thuctedongran);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThuctedongranRDT(System.Decimal Thuctedongran)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctedongran == Thuctedongran);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThuctedungmoi(System.Decimal Thuctedungmoi)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctedungmoi == Thuctedungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByThuctedungmoiRDT(System.Decimal Thuctedungmoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Thuctedungmoi == Thuctedungmoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhein(System.Decimal Phein)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByPheinRDT(System.Decimal Phein)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheghep(System.Decimal Pheghep)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByPheghepRDT(System.Decimal Pheghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheNcc(System.Decimal PheNcc)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.PheNcc == PheNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByPheNccRDT(System.Decimal PheNcc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.PheNcc == PheNcc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheSx(System.Decimal PheSx)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.PheSx == PheSx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByPheSxRDT(System.Decimal PheSx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.PheSx == PheSx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhethoi(System.Decimal Phethoi)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByPhethoiRDT(System.Decimal Phethoi)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Phethoi == Phethoi);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTensanpham(System.String Tensanpham)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByTensanphamRDT(System.String Tensanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tensanpham == Tensanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTenmay(System.String Tenmay)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByTenmayRDT(System.String Tenmay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tenmay == Tenmay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTencongnhan(System.String Tencongnhan)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByTencongnhanRDT(System.String Tencongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tencongnhan == Tencongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNangsuat(System.Decimal Nangsuat)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByNangsuatRDT(System.Decimal Nangsuat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Nangsuat == Nangsuat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMatruongca(System.String Matruongca)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByMatruongcaRDT(System.String Matruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Matruongca == Matruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTentruongca(System.String Tentruongca)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByTentruongcaRDT(System.String Tentruongca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tentruongca == Tentruongca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByTocdodinhmuc(System.Decimal Tocdodinhmuc)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByTocdodinhmucRDT(System.Decimal Tocdodinhmuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Tocdodinhmuc == Tocdodinhmuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLydosuco(System.String Lydosuco)
		{
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquaghepCollection, filter, 0, null);
			}
			return _KetquaghepCollection;
		}
		// Return DataTable
		public DataTable SelectByLydosucoRDT(System.String Lydosuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquaghepCollection = new EntityCollection(new KetquaghepEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquaghepFields.Lydosuco == Lydosuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquaghepCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

		// Return DataRow
		public DataRow CheckMa(string macantim, DataTable dt)
		{
			try
			{
				
				return dt.Select(KetquaghepFields.Id.Name + "='" + macantim + "'").CopyToDataTable().Rows[0];
				
			}
			catch { return null; }
		}

	}
}
