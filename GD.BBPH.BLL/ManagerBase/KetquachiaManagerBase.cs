﻿


/*
'===============================================================================
'  GD.BBPH.BL.KetquachiaManagerBase
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
	public class KetquachiaManagerBase
	{
	    
		#region ColumnNames
		
		
		public const String Field_Id="Id";				
		
		public const String Field_Ngay="Ngay";				
		
		public const String Field_Ca="Ca";				
		
		public const String Field_Lenh="Lenh";				
		
		public const String Field_Masanpham="Masanpham";				
		
		public const String Field_Macongnhan="Macongnhan";				
		
		public const String Field_Dauraghep="Dauraghep";				
		
		public const String Field_Sometvao="Sometvao";				
		
		public const String Field_Sokgvao="Sokgvao";				
		
		public const String Field_Socon="Socon";				
		
		public const String Field_Thoigianbatdau="Thoigianbatdau";				
		
		public const String Field_Thoigianketthuc="Thoigianketthuc";				
		
		public const String Field_Thoigianlencuon="Thoigianlencuon";				
		
		public const String Field_Thoigianhacuon="Thoigianhacuon";				
		
		public const String Field_Solanhacuon="Solanhacuon";				
		
		public const String Field_Thoigiancatdau="Thoigiancatdau";				
		
		public const String Field_Thoigiandoilenh="Thoigiandoilenh";				
		
		public const String Field_Thoigiansuco="Thoigiansuco";				
		
		public const String Field_Phein="Phein";				
		
		public const String Field_Pheghep="Pheghep";				
		
		public const String Field_Phechia="Phechia";				
		
		public const String Field_PhethoiNcc="PhethoiNcc";				
		
		public const String Field_Phesx="Phesx";				
		
		public const String Field_Ngaytao="Ngaytao";				
		
		public const String Field_Nguoitao="Nguoitao";				
		
		public const String Field_Ngaysua="Ngaysua";				
		
		public const String Field_Nguoisua="Nguoisua";				
		
				
		#endregion	

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public KetquachiaManagerBase()
		{
			// Nothing for now.
		}
		public DataTable Clone()
		{
			DataTable dt = new DataTable();
			
			
			dt.Columns.Add(Field_Id,typeof(System.Int64));
			
			dt.Columns.Add(Field_Ngay,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Ca,typeof(System.Int32));
			
			dt.Columns.Add(Field_Lenh,typeof(System.String));
			
			dt.Columns.Add(Field_Masanpham,typeof(System.String));
			
			dt.Columns.Add(Field_Macongnhan,typeof(System.String));
			
			dt.Columns.Add(Field_Dauraghep,typeof(System.String));
			
			dt.Columns.Add(Field_Sometvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Sokgvao,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Socon,typeof(System.Int32));
			
			dt.Columns.Add(Field_Thoigianbatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianketthuc,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianlencuon,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigianhacuon,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Solanhacuon,typeof(System.Int32));
			
			dt.Columns.Add(Field_Thoigiancatdau,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigiandoilenh,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Thoigiansuco,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Phein,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Pheghep,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phechia,typeof(System.Decimal));
			
			dt.Columns.Add(Field_PhethoiNcc,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Phesx,typeof(System.Decimal));
			
			dt.Columns.Add(Field_Ngaytao,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoitao,typeof(System.String));
			
			dt.Columns.Add(Field_Ngaysua,typeof(System.DateTime));
			
			dt.Columns.Add(Field_Nguoisua,typeof(System.String));
									
		            
			return dt;			
		}
		public DataRow Convert(KetquachiaEntity _KetquachiaEntity)
		{			
			DataTable dt = new DataTable();
			dt=Clone();
			DataRow r=dt.NewRow();
			
			
			try
			{
				r[Field_Id]=_KetquachiaEntity.Id;
			}
			catch { }
			
			try
			{
				r[Field_Ngay]=_KetquachiaEntity.Ngay;
			}
			catch { }
			
			try
			{
				r[Field_Ca]=_KetquachiaEntity.Ca;
			}
			catch { }
			
			try
			{
				r[Field_Lenh]=_KetquachiaEntity.Lenh;
			}
			catch { }
			
			try
			{
				r[Field_Masanpham]=_KetquachiaEntity.Masanpham;
			}
			catch { }
			
			try
			{
				r[Field_Macongnhan]=_KetquachiaEntity.Macongnhan;
			}
			catch { }
			
			try
			{
				r[Field_Dauraghep]=_KetquachiaEntity.Dauraghep;
			}
			catch { }
			
			try
			{
				r[Field_Sometvao]=_KetquachiaEntity.Sometvao;
			}
			catch { }
			
			try
			{
				r[Field_Sokgvao]=_KetquachiaEntity.Sokgvao;
			}
			catch { }
			
			try
			{
				r[Field_Socon]=_KetquachiaEntity.Socon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianbatdau]=_KetquachiaEntity.Thoigianbatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianketthuc]=_KetquachiaEntity.Thoigianketthuc;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianlencuon]=_KetquachiaEntity.Thoigianlencuon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigianhacuon]=_KetquachiaEntity.Thoigianhacuon;
			}
			catch { }
			
			try
			{
				r[Field_Solanhacuon]=_KetquachiaEntity.Solanhacuon;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiancatdau]=_KetquachiaEntity.Thoigiancatdau;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiandoilenh]=_KetquachiaEntity.Thoigiandoilenh;
			}
			catch { }
			
			try
			{
				r[Field_Thoigiansuco]=_KetquachiaEntity.Thoigiansuco;
			}
			catch { }
			
			try
			{
				r[Field_Phein]=_KetquachiaEntity.Phein;
			}
			catch { }
			
			try
			{
				r[Field_Pheghep]=_KetquachiaEntity.Pheghep;
			}
			catch { }
			
			try
			{
				r[Field_Phechia]=_KetquachiaEntity.Phechia;
			}
			catch { }
			
			try
			{
				r[Field_PhethoiNcc]=_KetquachiaEntity.PhethoiNcc;
			}
			catch { }
			
			try
			{
				r[Field_Phesx]=_KetquachiaEntity.Phesx;
			}
			catch { }
			
			try
			{
				r[Field_Ngaytao]=_KetquachiaEntity.Ngaytao;
			}
			catch { }
			
			try
			{
				r[Field_Nguoitao]=_KetquachiaEntity.Nguoitao;
			}
			catch { }
			
			try
			{
				r[Field_Ngaysua]=_KetquachiaEntity.Ngaysua;
			}
			catch { }
			
			try
			{
				r[Field_Nguoisua]=_KetquachiaEntity.Nguoisua;
			}
			catch { }
									
						
			dt.Rows.Add(r);
			return r;
		}		
		
		public KetquachiaEntity Convert(DataRow r)
		{	
			
			KetquachiaEntity _KetquachiaEntity=new KetquachiaEntity(System.Int64.Parse(r[Field_Id].ToString()));					
						
			
			
			try
			{
				_KetquachiaEntity.Ngay= System.DateTime.Parse(r[Field_Ngay].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Ca= System.Int32.Parse(r[Field_Ca].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Lenh= r[Field_Lenh].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Masanpham= r[Field_Masanpham].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Macongnhan= r[Field_Macongnhan].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Dauraghep= r[Field_Dauraghep].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Sometvao= System.Decimal.Parse(r[Field_Sometvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Sokgvao= System.Decimal.Parse(r[Field_Sokgvao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Socon= System.Int32.Parse(r[Field_Socon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianbatdau= System.DateTime.Parse(r[Field_Thoigianbatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianketthuc= System.DateTime.Parse(r[Field_Thoigianketthuc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianlencuon= System.DateTime.Parse(r[Field_Thoigianlencuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigianhacuon= System.DateTime.Parse(r[Field_Thoigianhacuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Solanhacuon= System.Int32.Parse(r[Field_Solanhacuon].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigiancatdau= System.DateTime.Parse(r[Field_Thoigiancatdau].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigiandoilenh= System.DateTime.Parse(r[Field_Thoigiandoilenh].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Thoigiansuco= System.DateTime.Parse(r[Field_Thoigiansuco].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Phein= System.Decimal.Parse(r[Field_Phein].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Pheghep= System.Decimal.Parse(r[Field_Pheghep].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Phechia= System.Decimal.Parse(r[Field_Phechia].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.PhethoiNcc= System.Decimal.Parse(r[Field_PhethoiNcc].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Phesx= System.Decimal.Parse(r[Field_Phesx].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Ngaytao= System.DateTime.Parse(r[Field_Ngaytao].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Nguoitao= r[Field_Nguoitao].ToString();						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Ngaysua= System.DateTime.Parse(r[Field_Ngaysua].ToString());						
			}
			catch { }
			
			try
			{
				_KetquachiaEntity.Nguoisua= r[Field_Nguoisua].ToString();						
			}
			catch { }
									
									
			return _KetquachiaEntity;
		}			
		
		public KetquachiaEntity Convert_Entity(KetquachiaEntity _KetquachiaEntity,KetquachiaEntity _KetquachiaEntity_XML)
		{	
			
			
			_KetquachiaEntity.Id= _KetquachiaEntity_XML.Id;
			
			_KetquachiaEntity.Ngay= _KetquachiaEntity_XML.Ngay;
			
			_KetquachiaEntity.Ca= _KetquachiaEntity_XML.Ca;
			
			_KetquachiaEntity.Lenh= _KetquachiaEntity_XML.Lenh;
			
			_KetquachiaEntity.Masanpham= _KetquachiaEntity_XML.Masanpham;
			
			_KetquachiaEntity.Macongnhan= _KetquachiaEntity_XML.Macongnhan;
			
			_KetquachiaEntity.Dauraghep= _KetquachiaEntity_XML.Dauraghep;
			
			_KetquachiaEntity.Sometvao= _KetquachiaEntity_XML.Sometvao;
			
			_KetquachiaEntity.Sokgvao= _KetquachiaEntity_XML.Sokgvao;
			
			_KetquachiaEntity.Socon= _KetquachiaEntity_XML.Socon;
			
			_KetquachiaEntity.Thoigianbatdau= _KetquachiaEntity_XML.Thoigianbatdau;
			
			_KetquachiaEntity.Thoigianketthuc= _KetquachiaEntity_XML.Thoigianketthuc;
			
			_KetquachiaEntity.Thoigianlencuon= _KetquachiaEntity_XML.Thoigianlencuon;
			
			_KetquachiaEntity.Thoigianhacuon= _KetquachiaEntity_XML.Thoigianhacuon;
			
			_KetquachiaEntity.Solanhacuon= _KetquachiaEntity_XML.Solanhacuon;
			
			_KetquachiaEntity.Thoigiancatdau= _KetquachiaEntity_XML.Thoigiancatdau;
			
			_KetquachiaEntity.Thoigiandoilenh= _KetquachiaEntity_XML.Thoigiandoilenh;
			
			_KetquachiaEntity.Thoigiansuco= _KetquachiaEntity_XML.Thoigiansuco;
			
			_KetquachiaEntity.Phein= _KetquachiaEntity_XML.Phein;
			
			_KetquachiaEntity.Pheghep= _KetquachiaEntity_XML.Pheghep;
			
			_KetquachiaEntity.Phechia= _KetquachiaEntity_XML.Phechia;
			
			_KetquachiaEntity.PhethoiNcc= _KetquachiaEntity_XML.PhethoiNcc;
			
			_KetquachiaEntity.Phesx= _KetquachiaEntity_XML.Phesx;
			
			_KetquachiaEntity.Ngaytao= _KetquachiaEntity_XML.Ngaytao;
			
			_KetquachiaEntity.Nguoitao= _KetquachiaEntity_XML.Nguoitao;
			
			_KetquachiaEntity.Ngaysua= _KetquachiaEntity_XML.Ngaysua;
			
			_KetquachiaEntity.Nguoisua= _KetquachiaEntity_XML.Nguoisua;
									
				
			return _KetquachiaEntity;
		}	
		
		public String InsertV2(KetquachiaEntity _KetquachiaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			String id =(new KetquachiaManagerBase()).Insert(_KetquachiaEntity).Id.ToString();
			
			
			try
			{
				r.SetField(Field_Id,_KetquachiaEntity.Id);
			}
			catch { }
			
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquachiaEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquachiaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenh,_KetquachiaEntity.Lenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquachiaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquachiaEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauraghep,_KetquachiaEntity.Dauraghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometvao,_KetquachiaEntity.Sometvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgvao,_KetquachiaEntity.Sokgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Socon,_KetquachiaEntity.Socon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquachiaEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquachiaEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianlencuon,_KetquachiaEntity.Thoigianlencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquachiaEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solanhacuon,_KetquachiaEntity.Solanhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquachiaEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiandoilenh,_KetquachiaEntity.Thoigiandoilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquachiaEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquachiaEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquachiaEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquachiaEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PhethoiNcc,_KetquachiaEntity.PhethoiNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phesx,_KetquachiaEntity.Phesx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquachiaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquachiaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquachiaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquachiaEntity.Nguoisua);
			}
			catch { }
									
			
			_BindingSource.ResetCurrentItem();
			return id;
		}
		
		public void UpdateV2(KetquachiaEntity _KetquachiaEntity,DataRow r,DataTable dt,BindingSource _BindingSource)
		{
		
			
			(new KetquachiaManagerBase()).Update(_KetquachiaEntity);
			r.SetField(Field_Id,_KetquachiaEntity.Id);
									
			
			
			
			try
			{
				r.SetField(Field_Ngay,_KetquachiaEntity.Ngay);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ca,_KetquachiaEntity.Ca);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Lenh,_KetquachiaEntity.Lenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Masanpham,_KetquachiaEntity.Masanpham);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Macongnhan,_KetquachiaEntity.Macongnhan);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Dauraghep,_KetquachiaEntity.Dauraghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sometvao,_KetquachiaEntity.Sometvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Sokgvao,_KetquachiaEntity.Sokgvao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Socon,_KetquachiaEntity.Socon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianbatdau,_KetquachiaEntity.Thoigianbatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianketthuc,_KetquachiaEntity.Thoigianketthuc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianlencuon,_KetquachiaEntity.Thoigianlencuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigianhacuon,_KetquachiaEntity.Thoigianhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Solanhacuon,_KetquachiaEntity.Solanhacuon);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiancatdau,_KetquachiaEntity.Thoigiancatdau);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiandoilenh,_KetquachiaEntity.Thoigiandoilenh);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Thoigiansuco,_KetquachiaEntity.Thoigiansuco);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phein,_KetquachiaEntity.Phein);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Pheghep,_KetquachiaEntity.Pheghep);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phechia,_KetquachiaEntity.Phechia);
			}
			catch { }
			
			try
			{
				r.SetField(Field_PhethoiNcc,_KetquachiaEntity.PhethoiNcc);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Phesx,_KetquachiaEntity.Phesx);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaytao,_KetquachiaEntity.Ngaytao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoitao,_KetquachiaEntity.Nguoitao);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Ngaysua,_KetquachiaEntity.Ngaysua);
			}
			catch { }
			
			try
			{
				r.SetField(Field_Nguoisua,_KetquachiaEntity.Nguoisua);
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

		public KetquachiaEntity Insert(KetquachiaEntity KetquachiaEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(KetquachiaEntity, true);
			}
			return KetquachiaEntity;
		}

		public KetquachiaEntity Insert(System.Int64  Id, System.DateTime  Ngay, System.Int32  Ca, System.String  Lenh, System.String  Masanpham, System.String  Macongnhan, System.String  Dauraghep, System.Decimal  Sometvao, System.Decimal  Sokgvao, System.Int32  Socon, System.DateTime  Thoigianbatdau, System.DateTime  Thoigianketthuc, System.DateTime  Thoigianlencuon, System.DateTime  Thoigianhacuon, System.Int32  Solanhacuon, System.DateTime  Thoigiancatdau, System.DateTime  Thoigiandoilenh, System.DateTime  Thoigiansuco, System.Decimal  Phein, System.Decimal  Pheghep, System.Decimal  Phechia, System.Decimal  PhethoiNcc, System.Decimal  Phesx, System.DateTime  Ngaytao, System.String  Nguoitao, System.DateTime  Ngaysua, System.String  Nguoisua)
		{
			KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_KetquachiaEntity.Id = Id;
				
				_KetquachiaEntity.Ngay = Ngay;
				
				_KetquachiaEntity.Ca = Ca;
				
				_KetquachiaEntity.Lenh = Lenh;
				
				_KetquachiaEntity.Masanpham = Masanpham;
				
				_KetquachiaEntity.Macongnhan = Macongnhan;
				
				_KetquachiaEntity.Dauraghep = Dauraghep;
				
				_KetquachiaEntity.Sometvao = Sometvao;
				
				_KetquachiaEntity.Sokgvao = Sokgvao;
				
				_KetquachiaEntity.Socon = Socon;
				
				_KetquachiaEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquachiaEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquachiaEntity.Thoigianlencuon = Thoigianlencuon;
				
				_KetquachiaEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquachiaEntity.Solanhacuon = Solanhacuon;
				
				_KetquachiaEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquachiaEntity.Thoigiandoilenh = Thoigiandoilenh;
				
				_KetquachiaEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquachiaEntity.Phein = Phein;
				
				_KetquachiaEntity.Pheghep = Pheghep;
				
				_KetquachiaEntity.Phechia = Phechia;
				
				_KetquachiaEntity.PhethoiNcc = PhethoiNcc;
				
				_KetquachiaEntity.Phesx = Phesx;
				
				_KetquachiaEntity.Ngaytao = Ngaytao;
				
				_KetquachiaEntity.Nguoitao = Nguoitao;
				
				_KetquachiaEntity.Ngaysua = Ngaysua;
				
				_KetquachiaEntity.Nguoisua = Nguoisua;
					
					
				adapter.SaveEntity(_KetquachiaEntity, true);
			}
			return _KetquachiaEntity;
		}

		public KetquachiaEntity Insert(System.DateTime Ngay, System.Int32 Ca, System.String Lenh, System.String Masanpham, System.String Macongnhan, System.String Dauraghep, System.Decimal Sometvao, System.Decimal Sokgvao, System.Int32 Socon, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.DateTime Thoigianlencuon, System.DateTime Thoigianhacuon, System.Int32 Solanhacuon, System.DateTime Thoigiancatdau, System.DateTime Thoigiandoilenh, System.DateTime Thoigiansuco, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal PhethoiNcc, System.Decimal Phesx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)//ko co mahieu
		{
			KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				
				_KetquachiaEntity.Ngay = Ngay;
				
				_KetquachiaEntity.Ca = Ca;
				
				_KetquachiaEntity.Lenh = Lenh;
				
				_KetquachiaEntity.Masanpham = Masanpham;
				
				_KetquachiaEntity.Macongnhan = Macongnhan;
				
				_KetquachiaEntity.Dauraghep = Dauraghep;
				
				_KetquachiaEntity.Sometvao = Sometvao;
				
				_KetquachiaEntity.Sokgvao = Sokgvao;
				
				_KetquachiaEntity.Socon = Socon;
				
				_KetquachiaEntity.Thoigianbatdau = Thoigianbatdau;
				
				_KetquachiaEntity.Thoigianketthuc = Thoigianketthuc;
				
				_KetquachiaEntity.Thoigianlencuon = Thoigianlencuon;
				
				_KetquachiaEntity.Thoigianhacuon = Thoigianhacuon;
				
				_KetquachiaEntity.Solanhacuon = Solanhacuon;
				
				_KetquachiaEntity.Thoigiancatdau = Thoigiancatdau;
				
				_KetquachiaEntity.Thoigiandoilenh = Thoigiandoilenh;
				
				_KetquachiaEntity.Thoigiansuco = Thoigiansuco;
				
				_KetquachiaEntity.Phein = Phein;
				
				_KetquachiaEntity.Pheghep = Pheghep;
				
				_KetquachiaEntity.Phechia = Phechia;
				
				_KetquachiaEntity.PhethoiNcc = PhethoiNcc;
				
				_KetquachiaEntity.Phesx = Phesx;
				
				_KetquachiaEntity.Ngaytao = Ngaytao;
				
				_KetquachiaEntity.Nguoitao = Nguoitao;
				
				_KetquachiaEntity.Ngaysua = Ngaysua;
				
				_KetquachiaEntity.Nguoisua = Nguoisua;
					

				adapter.SaveEntity(_KetquachiaEntity, true);
			}
			return _KetquachiaEntity;
		}

		public bool Update(KetquachiaEntity _KetquachiaEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				
				_PredicateExpression.Add(KetquachiaFields.Id == _KetquachiaEntity.Id);
				
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_KetquachiaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(KetquachiaEntity _KetquachiaEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_KetquachiaEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(System.Int64 Id, System.DateTime Ngay, System.Int32 Ca, System.String Lenh, System.String Masanpham, System.String Macongnhan, System.String Dauraghep, System.Decimal Sometvao, System.Decimal Sokgvao, System.Int32 Socon, System.DateTime Thoigianbatdau, System.DateTime Thoigianketthuc, System.DateTime Thoigianlencuon, System.DateTime Thoigianhacuon, System.Int32 Solanhacuon, System.DateTime Thoigiancatdau, System.DateTime Thoigiandoilenh, System.DateTime Thoigiansuco, System.Decimal Phein, System.Decimal Pheghep, System.Decimal Phechia, System.Decimal PhethoiNcc, System.Decimal Phesx, System.DateTime Ngaytao, System.String Nguoitao, System.DateTime Ngaysua, System.String Nguoisua)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity(Id);
				if (adapter.FetchEntity(_KetquachiaEntity))
				{
				
					
					
					_KetquachiaEntity.Ngay = Ngay;
					
					_KetquachiaEntity.Ca = Ca;
					
					_KetquachiaEntity.Lenh = Lenh;
					
					_KetquachiaEntity.Masanpham = Masanpham;
					
					_KetquachiaEntity.Macongnhan = Macongnhan;
					
					_KetquachiaEntity.Dauraghep = Dauraghep;
					
					_KetquachiaEntity.Sometvao = Sometvao;
					
					_KetquachiaEntity.Sokgvao = Sokgvao;
					
					_KetquachiaEntity.Socon = Socon;
					
					_KetquachiaEntity.Thoigianbatdau = Thoigianbatdau;
					
					_KetquachiaEntity.Thoigianketthuc = Thoigianketthuc;
					
					_KetquachiaEntity.Thoigianlencuon = Thoigianlencuon;
					
					_KetquachiaEntity.Thoigianhacuon = Thoigianhacuon;
					
					_KetquachiaEntity.Solanhacuon = Solanhacuon;
					
					_KetquachiaEntity.Thoigiancatdau = Thoigiancatdau;
					
					_KetquachiaEntity.Thoigiandoilenh = Thoigiandoilenh;
					
					_KetquachiaEntity.Thoigiansuco = Thoigiansuco;
					
					_KetquachiaEntity.Phein = Phein;
					
					_KetquachiaEntity.Pheghep = Pheghep;
					
					_KetquachiaEntity.Phechia = Phechia;
					
					_KetquachiaEntity.PhethoiNcc = PhethoiNcc;
					
					_KetquachiaEntity.Phesx = Phesx;
					
					_KetquachiaEntity.Ngaytao = Ngaytao;
					
					_KetquachiaEntity.Nguoitao = Nguoitao;
					
					_KetquachiaEntity.Ngaysua = Ngaysua;
					
					_KetquachiaEntity.Nguoisua = Nguoisua;
						

					adapter.SaveEntity(_KetquachiaEntity, true);
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
				KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity(Id);
				if (adapter.FetchEntity(_KetquachiaEntity))
				{
					adapter.DeleteEntity(_KetquachiaEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("KetquachiaEntity", null);
			}
		}
		
		
		
		public int DeleteById(System.Int64 Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgay(System.DateTime Ngay)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByCa(System.Int32 Ca)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByLenh(System.String Lenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Lenh == Lenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMasanpham(System.String Masanpham)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByMacongnhan(System.String Macongnhan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByDauraghep(System.String Dauraghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Dauraghep == Dauraghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySometvao(System.Decimal Sometvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometvao == Sometvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySokgvao(System.Decimal Sokgvao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgvao == Sokgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySocon(System.Int32 Socon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Socon == Socon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianlencuon(System.DateTime Thoigianlencuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianlencuon == Thoigianlencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigianhacuon(System.DateTime Thoigianhacuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteBySolanhacuon(System.Int32 Solanhacuon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solanhacuon == Solanhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiancatdau(System.DateTime Thoigiancatdau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiandoilenh(System.DateTime Thoigiandoilenh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByThoigiansuco(System.DateTime Thoigiansuco)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhein(System.Decimal Phein)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPheghep(System.Decimal Pheghep)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhechia(System.Decimal Phechia)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhethoiNcc(System.Decimal PhethoiNcc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.PhethoiNcc == PhethoiNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByPhesx(System.Decimal Phesx)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaytao(System.DateTime Ngaytao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoitao(System.String Nguoitao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNgaysua(System.DateTime Ngaysua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
		
		public int DeleteByNguoisua(System.String Nguoisua)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("KetquachiaEntity", filter);
			}
			return toReturn;
		}		
			
		
		public KetquachiaEntity SelectOne(System.Int64 Id)
		{
			KetquachiaEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				KetquachiaEntity _KetquachiaEntity = new KetquachiaEntity(Id);
				if (adapter.FetchEntity(_KetquachiaEntity))
				{
					toReturn = _KetquachiaEntity;
				}
			}
			return toReturn;
		}

		// Return EntityCollection
		public EntityCollection SelectAll()
		{
			EntityCollection _KetquachiaCollection = new EntityCollection( new KetquachiaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, null, 0, null);
			}
			return _KetquachiaCollection;
		}
		
		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}

		
		
		// Return EntityCollection
		public EntityCollection SelectById(System.Int64 Id)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByIdRDT(System.Int64 Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgay(System.DateTime Ngay)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgayRDT(System.DateTime Ngay)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngay == Ngay);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByCa(System.Int32 Ca)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByCaRDT(System.Int32 Ca)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ca == Ca);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByLenh(System.String Lenh)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Lenh == Lenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByLenhRDT(System.String Lenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Lenh == Lenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMasanpham(System.String Masanpham)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMasanphamRDT(System.String Masanpham)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Masanpham == Masanpham);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByMacongnhan(System.String Macongnhan)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByMacongnhanRDT(System.String Macongnhan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Macongnhan == Macongnhan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByDauraghep(System.String Dauraghep)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Dauraghep == Dauraghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByDauraghepRDT(System.String Dauraghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Dauraghep == Dauraghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySometvao(System.Decimal Sometvao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometvao == Sometvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySometvaoRDT(System.Decimal Sometvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sometvao == Sometvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySokgvao(System.Decimal Sokgvao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgvao == Sokgvao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySokgvaoRDT(System.Decimal Sokgvao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Sokgvao == Sokgvao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySocon(System.Int32 Socon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Socon == Socon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySoconRDT(System.Int32 Socon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Socon == Socon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianbatdau(System.DateTime Thoigianbatdau)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianbatdauRDT(System.DateTime Thoigianbatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianbatdau == Thoigianbatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianketthuc(System.DateTime Thoigianketthuc)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianketthucRDT(System.DateTime Thoigianketthuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianketthuc == Thoigianketthuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianlencuon(System.DateTime Thoigianlencuon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianlencuon == Thoigianlencuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianlencuonRDT(System.DateTime Thoigianlencuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianlencuon == Thoigianlencuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigianhacuon(System.DateTime Thoigianhacuon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigianhacuonRDT(System.DateTime Thoigianhacuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigianhacuon == Thoigianhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectBySolanhacuon(System.Int32 Solanhacuon)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solanhacuon == Solanhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectBySolanhacuonRDT(System.Int32 Solanhacuon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Solanhacuon == Solanhacuon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiancatdau(System.DateTime Thoigiancatdau)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiancatdauRDT(System.DateTime Thoigiancatdau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiancatdau == Thoigiancatdau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiandoilenh(System.DateTime Thoigiandoilenh)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiandoilenhRDT(System.DateTime Thoigiandoilenh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiandoilenh == Thoigiandoilenh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByThoigiansuco(System.DateTime Thoigiansuco)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByThoigiansucoRDT(System.DateTime Thoigiansuco)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Thoigiansuco == Thoigiansuco);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhein(System.Decimal Phein)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPheinRDT(System.Decimal Phein)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phein == Phein);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPheghep(System.Decimal Pheghep)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPheghepRDT(System.Decimal Pheghep)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Pheghep == Pheghep);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhechia(System.Decimal Phechia)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhechiaRDT(System.Decimal Phechia)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phechia == Phechia);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhethoiNcc(System.Decimal PhethoiNcc)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.PhethoiNcc == PhethoiNcc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhethoiNccRDT(System.Decimal PhethoiNcc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.PhethoiNcc == PhethoiNcc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByPhesx(System.Decimal Phesx)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByPhesxRDT(System.Decimal Phesx)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Phesx == Phesx);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaytao(System.DateTime Ngaytao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaytaoRDT(System.DateTime Ngaytao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaytao == Ngaytao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoitao(System.String Nguoitao)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoitaoRDT(System.String Nguoitao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoitao == Nguoitao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNgaysua(System.DateTime Ngaysua)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNgaysuaRDT(System.DateTime Ngaysua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Ngaysua == Ngaysua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection
		public EntityCollection SelectByNguoisua(System.String Nguoisua)
		{
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_KetquachiaCollection, filter, 0, null);
			}
			return _KetquachiaCollection;
		}
		// Return DataTable
		public DataTable SelectByNguoisuaRDT(System.String Nguoisua)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _KetquachiaCollection = new EntityCollection(new KetquachiaEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(KetquachiaFields.Nguoisua == Nguoisua);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_KetquachiaCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
			

	}
}
