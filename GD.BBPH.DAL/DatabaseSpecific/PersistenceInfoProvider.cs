﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, October 12, 2022 10:14:00 AM
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.DatabaseSpecific
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			base.InitClass((46 + 0));
			InitBaogiaDEntityMappings();
			InitBaogiaHEntityMappings();
			InitCongsuatmayEntityMappings();
			InitCtptmangDEntityMappings();
			InitCtptmangHEntityMappings();
			InitDinhmucthoigianEntityMappings();
			InitDmbophanEntityMappings();
			InitDmcapmaEntityMappings();
			InitDmchucvuEntityMappings();
			InitDmchungloaiEntityMappings();
			InitDmcongdoanEntityMappings();
			InitDmcongnhanEntityMappings();
			InitDmdongmayEntityMappings();
			InitDmhangEntityMappings();
			InitDmkhachEntityMappings();
			InitDmkhoEntityMappings();
			InitDmlydonhapxuatEntityMappings();
			InitDmmangEntityMappings();
			InitDmmauEntityMappings();
			InitDmmayEntityMappings();
			InitDmnguyenlieuEntityMappings();
			InitDmnhomnguyenlieuEntityMappings();
			InitDmnhomquycachEntityMappings();
			InitDmquycachEntityMappings();
			InitDmtaikhoanEntityMappings();
			InitDonhangDEntityMappings();
			InitDonhangHEntityMappings();
			InitHangtralaiEntityMappings();
			InitKetquachiaEntityMappings();
			InitKetquaghepEntityMappings();
			InitKetquainEntityMappings();
			InitKetquainmauEntityMappings();
			InitKetquathoiEntityMappings();
			InitKetquatuaEntityMappings();
			InitLogbackupEntityMappings();
			InitMaucuahangEntityMappings();
			InitMenuEntityMappings();
			InitMenuroleEntityMappings();
			InitPhieugiaohangDEntityMappings();
			InitPhieugiaohangHEntityMappings();
			InitRolesEntityMappings();
			InitThamsoEntityMappings();
			InitThanhphanmauEntityMappings();
			InitTknguyenlieuthoiEntityMappings();
			InitTruccuahangEntityMappings();
			InitUsersEntityMappings();

		}


		/// <summary>Inits BaogiaDEntity's mappings</summary>
		private void InitBaogiaDEntityMappings()
		{
			base.AddElementMapping( "BaogiaDEntity", "BBPH", @"dbo", "baogia_d", 15 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Sobaogia", "Sobaogia", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Machungloai", "Machungloai", true, (int)SqlDbType.BigInt, 0, 0, 19, false, "", null, typeof(System.Int64), 2 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Tenchungloai", "Tenchungloai", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Masp", "Masp", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Tenhang", "Tenhang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Kichthuoc", "Kichthuoc", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Trongluong", "Trongluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Mota", "Mota", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "BaogiaDEntity", "DongiakhongVat", "DongiakhongVAT", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
			base.AddElementFieldMapping( "BaogiaDEntity", "DongiaVat", "DongiaVAT", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			base.AddElementFieldMapping( "BaogiaDEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 14 );
		}
		/// <summary>Inits BaogiaHEntity's mappings</summary>
		private void InitBaogiaHEntityMappings()
		{
			base.AddElementMapping( "BaogiaHEntity", "BBPH", @"dbo", "baogia_h", 12 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Sobaogia", "Sobaogia", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Ngaybaogia", "Ngaybaogia", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Ngayhieuluc", "Ngayhieuluc", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Makhach", "Makhach", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Tenkhach", "Tenkhach", false, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Noidung", "Noidung", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Phuongthuctt", "Phuongthuctt", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Diadiemgiao", "Diadiemgiao", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "BaogiaHEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
		}
		/// <summary>Inits CongsuatmayEntity's mappings</summary>
		private void InitCongsuatmayEntityMappings()
		{
			base.AddElementMapping( "CongsuatmayEntity", "BBPH", @"dbo", "congsuatmay", 19 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Macongsuat", "Macongsuat", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Tencongsuat", "Tencongsuat", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Mamay", "Mamay", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Madongmay", "Madongmay", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Macongdoan", "Macongdoan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Maquycach1", "Maquycach1", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Maquycach2", "Maquycach2", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Maquycach3", "Maquycach3", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Khotu", "Khotu", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Khoden", "Khoden", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Chieudaitu", "Chieudaitu", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Chieudaiden", "Chieudaiden", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Dodaytu", "Dodaytu", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Dodayden", "Dodayden", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 13 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Tocdo", "Tocdo", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 14 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 16 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 17 );
			base.AddElementFieldMapping( "CongsuatmayEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 18 );
		}
		/// <summary>Inits CtptmangDEntity's mappings</summary>
		private void InitCtptmangDEntityMappings()
		{
			base.AddElementMapping( "CtptmangDEntity", "BBPH", @"dbo", "ctptmang_d", 12 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Id", "id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "CtptmangDEntity", "IdH", "id_h", true, (int)SqlDbType.BigInt, 0, 0, 19, false, "", null, typeof(System.Int64), 1 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Mact", "Mact", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Tenct", "Tenct", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Manl", "Manl", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Tennguyenlieu", "Tennguyenlieu", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Trongluong", "Trongluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Tyle", "Tyle", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "CtptmangDEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
		}
		/// <summary>Inits CtptmangHEntity's mappings</summary>
		private void InitCtptmangHEntityMappings()
		{
			base.AddElementMapping( "CtptmangHEntity", "BBPH", @"dbo", "ctptmang_h", 8 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Id", "id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Mactpt", "Mactpt", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Tenctpt", "Tenctpt", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Ngayapdung", "Ngayapdung", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "CtptmangHEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits DinhmucthoigianEntity's mappings</summary>
		private void InitDinhmucthoigianEntityMappings()
		{
			base.AddElementMapping( "DinhmucthoigianEntity", "BBPH", @"dbo", "dinhmucthoigian", 14 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Madmtg", "Madmtg", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Tendinhmuc", "Tendinhmuc", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Mamay", "Mamay", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Madm", "Madm", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Dauca", "Dauca", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 4 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Doilenh", "Doilenh", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Lencuon", "Lencuon", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Xuongcuon", "Xuongcuon", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Thaythietbi", "Thaythietbi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Dungmay", "Dungmay", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "DinhmucthoigianEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
		}
		/// <summary>Inits DmbophanEntity's mappings</summary>
		private void InitDmbophanEntityMappings()
		{
			base.AddElementMapping( "DmbophanEntity", "BBPH", @"dbo", "dmbophan", 6 );
			base.AddElementFieldMapping( "DmbophanEntity", "Mabp", "Mabp", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmbophanEntity", "Tenbophan", "Tenbophan", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmbophanEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "DmbophanEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmbophanEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "DmbophanEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits DmcapmaEntity's mappings</summary>
		private void InitDmcapmaEntityMappings()
		{
			base.AddElementMapping( "DmcapmaEntity", "BBPH", @"dbo", "Dmcapma", 3 );
			base.AddElementFieldMapping( "DmcapmaEntity", "Macappk", "Macappk", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmcapmaEntity", "Loaima", "Loaima", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmcapmaEntity", "Mastart", "Mastart", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits DmchucvuEntity's mappings</summary>
		private void InitDmchucvuEntityMappings()
		{
			base.AddElementMapping( "DmchucvuEntity", "BBPH", @"dbo", "dmchucvu", 6 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Macv", "Macv", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Tenchucvu", "Tenchucvu", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits DmchungloaiEntity's mappings</summary>
		private void InitDmchungloaiEntityMappings()
		{
			base.AddElementMapping( "DmchungloaiEntity", "BBPH", @"dbo", "Dmchungloai", 8 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Tenchungloai", "Tenchungloai", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Kichthuoc", "Kichthuoc", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Trongluong", "Trongluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 3 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Somau", "Somau", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Sohinh", "Sohinh", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Loaimuc", "Loaimuc", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DmchungloaiEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits DmcongdoanEntity's mappings</summary>
		private void InitDmcongdoanEntityMappings()
		{
			base.AddElementMapping( "DmcongdoanEntity", "BBPH", @"dbo", "dmcongdoan", 7 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Macd", "Macd", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Tencongdoan", "Tencongdoan", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Sothutucongdoan", "Sothutucongdoan", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DmcongnhanEntity's mappings</summary>
		private void InitDmcongnhanEntityMappings()
		{
			base.AddElementMapping( "DmcongnhanEntity", "BBPH", @"dbo", "dmcongnhan", 14 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Macn", "Macn", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Hovatencongnhan", "Hovatencongnhan", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Tencongnhan", "Tencongnhan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Mabp", "Mabp", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Macv", "Macv", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Sodienthoai", "Sodienthoai", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Tinhtrang", "Tinhtrang", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Phongban", "Phongban", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Chucvu", "Chucvu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Danghi", "Danghi", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
		}
		/// <summary>Inits DmdongmayEntity's mappings</summary>
		private void InitDmdongmayEntityMappings()
		{
			base.AddElementMapping( "DmdongmayEntity", "BBPH", @"dbo", "dmdongmay", 7 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Madm", "Madm", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Tendongmay", "Tendongmay", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Macd", "Macd", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DmhangEntity's mappings</summary>
		private void InitDmhangEntityMappings()
		{
			base.AddElementMapping( "DmhangEntity", "BBPH", @"dbo", "dmhang", 35 );
			base.AddElementFieldMapping( "DmhangEntity", "Masp", "Masp", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmhangEntity", "Tensp", "Tensp", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmhangEntity", "Maspcuakhach", "Maspcuakhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmhangEntity", "Machungloai", "Machungloai", true, (int)SqlDbType.BigInt, 0, 0, 19, false, "", null, typeof(System.Int64), 3 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenchungloai", "Tenchungloai", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmhangEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DmhangEntity", "Kichthuoc", "Kichthuoc", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DmhangEntity", "Trongluong", "Trongluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "DmhangEntity", "Sohinh", "Sohinh", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
			base.AddElementFieldMapping( "DmhangEntity", "Somau", "Somau", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 10 );
			base.AddElementFieldMapping( "DmhangEntity", "Loaimuc", "Loaimuc", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DmhangEntity", "Khoiluongmuc", "Khoiluongmuc", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "DmhangEntity", "Cautrucin", "Cautrucin", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "DmhangEntity", "Mamang1", "Mamang1", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenmang1", "Tenmang1", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "DmhangEntity", "Tlmanglop1", "Tlmanglop1", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 16 );
			base.AddElementFieldMapping( "DmhangEntity", "Tlkeolop1", "Tlkeolop1", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 17 );
			base.AddElementFieldMapping( "DmhangEntity", "Mamang2", "Mamang2", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 18 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenmang2", "Tenmang2", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 19 );
			base.AddElementFieldMapping( "DmhangEntity", "Tlmanglop2", "Tlmanglop2", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "DmhangEntity", "Tlkeolop2", "Tlkeolop2", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 21 );
			base.AddElementFieldMapping( "DmhangEntity", "Dinhluongkeo", "Dinhluongkeo", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 22 );
			base.AddElementFieldMapping( "DmhangEntity", "Kichthuoctruc", "Kichthuoctruc", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 23 );
			base.AddElementFieldMapping( "DmhangEntity", "Vitri", "Vitri", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 24 );
			base.AddElementFieldMapping( "DmhangEntity", "Maqcdonggoi", "Maqcdonggoi", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 25 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenqcdonggoi", "Tenqcdonggoi", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 26 );
			base.AddElementFieldMapping( "DmhangEntity", "Maqcloaithung", "Maqcloaithung", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 27 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenqcloaithung", "Tenqcloaithung", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 28 );
			base.AddElementFieldMapping( "DmhangEntity", "Maqcthanhpham", "Maqcthanhpham", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 29 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenqcthanhpham", "Tenqcthanhpham", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 30 );
			base.AddElementFieldMapping( "DmhangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 31 );
			base.AddElementFieldMapping( "DmhangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 32 );
			base.AddElementFieldMapping( "DmhangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 33 );
			base.AddElementFieldMapping( "DmhangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 34 );
		}
		/// <summary>Inits DmkhachEntity's mappings</summary>
		private void InitDmkhachEntityMappings()
		{
			base.AddElementMapping( "DmkhachEntity", "BBPH", @"dbo", "dmkhach", 18 );
			base.AddElementFieldMapping( "DmkhachEntity", "Makhach", "Makhach", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmkhachEntity", "Tenkhach", "Tenkhach", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmkhachEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmkhachEntity", "Truyenthong", "Truyenthong", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			base.AddElementFieldMapping( "DmkhachEntity", "Diachi", "Diachi", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmkhachEntity", "Sodienthoai", "Sodienthoai", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmkhachEntity", "Email", "Email", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DmkhachEntity", "Tknganhang", "Tknganhang", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DmkhachEntity", "Tennganhang", "Tennganhang", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "DmkhachEntity", "Noidia", "Noidia", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			base.AddElementFieldMapping( "DmkhachEntity", "Tennguoilh", "Tennguoilh", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "DmkhachEntity", "Chucvu", "chucvu", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DmkhachEntity", "Sodienthoailh", "Sodienthoailh", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "DmkhachEntity", "Thongtinbosung", "thongtinbosung", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "DmkhachEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "DmkhachEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 15 );
			base.AddElementFieldMapping( "DmkhachEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			base.AddElementFieldMapping( "DmkhachEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 17 );
		}
		/// <summary>Inits DmkhoEntity's mappings</summary>
		private void InitDmkhoEntityMappings()
		{
			base.AddElementMapping( "DmkhoEntity", "BBPH", @"dbo", "dmkho", 7 );
			base.AddElementFieldMapping( "DmkhoEntity", "Makho", "Makho", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmkhoEntity", "Tenkho", "Tenkho", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmkhoEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmkhoEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DmkhoEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmkhoEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DmkhoEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DmlydonhapxuatEntity's mappings</summary>
		private void InitDmlydonhapxuatEntityMappings()
		{
			base.AddElementMapping( "DmlydonhapxuatEntity", "BBPH", @"dbo", "dmlydonhapxuat", 8 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Malydo", "Malydo", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Tenlydo", "Tenlydo", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Manhom", "Manhom", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Tennhom", "Tennhom", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "DmlydonhapxuatEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits DmmangEntity's mappings</summary>
		private void InitDmmangEntityMappings()
		{
			base.AddElementMapping( "DmmangEntity", "BBPH", @"dbo", "dmmang", 11 );
			base.AddElementFieldMapping( "DmmangEntity", "Mamang", "Mamang", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmmangEntity", "Tenmang", "Tenmang", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmmangEntity", "Makhach", "Makhach", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmmangEntity", "Tenkhach", "Tenkhach", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmmangEntity", "Kichthuoc", "Kichthuoc", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmmangEntity", "Trongluong", "Trongluong", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmmangEntity", "Mactpt", "Mactpt", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DmmangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "DmmangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "DmmangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			base.AddElementFieldMapping( "DmmangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits DmmauEntity's mappings</summary>
		private void InitDmmauEntityMappings()
		{
			base.AddElementMapping( "DmmauEntity", "BBPH", @"dbo", "dmmau", 7 );
			base.AddElementFieldMapping( "DmmauEntity", "Mamau", "Mamau", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmmauEntity", "Tenmau", "Tenmau", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmmauEntity", "Lamaugoc", "Lamaugoc", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			base.AddElementFieldMapping( "DmmauEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DmmauEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmmauEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DmmauEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DmmayEntity's mappings</summary>
		private void InitDmmayEntityMappings()
		{
			base.AddElementMapping( "DmmayEntity", "BBPH", @"dbo", "dmmay", 8 );
			base.AddElementFieldMapping( "DmmayEntity", "Mamay", "Mamay", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmmayEntity", "Tenmay", "Tenmay", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmmayEntity", "Madm", "Madm", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmmayEntity", "Vitri", "Vitri", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmmayEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "DmmayEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmmayEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "DmmayEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
		}
		/// <summary>Inits DmnguyenlieuEntity's mappings</summary>
		private void InitDmnguyenlieuEntityMappings()
		{
			base.AddElementMapping( "DmnguyenlieuEntity", "BBPH", @"dbo", "dmnguyenlieu", 14 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Manl", "Manl", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Tenrutgon", "Tenrutgon", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Manhom", "Manhom", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Tennhom", "Tennhom", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Tennl", "Tennl", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Gia", "Gia", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Ngay", "Ngay", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Giahientai", "Giahientai", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Tang", "Tang", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Giam", "Giam", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "DmnguyenlieuEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
		}
		/// <summary>Inits DmnhomnguyenlieuEntity's mappings</summary>
		private void InitDmnhomnguyenlieuEntityMappings()
		{
			base.AddElementMapping( "DmnhomnguyenlieuEntity", "BBPH", @"dbo", "dmnhomnguyenlieu", 7 );
			base.AddElementFieldMapping( "DmnhomnguyenlieuEntity", "Manhom", "Manhom", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmnhomnguyenlieuEntity", "Tennhomnguyenlieu", "Tennhomnguyenlieu", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmnhomnguyenlieuEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmnhomnguyenlieuEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DmnhomnguyenlieuEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmnhomnguyenlieuEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DmnhomnguyenlieuEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DmnhomquycachEntity's mappings</summary>
		private void InitDmnhomquycachEntityMappings()
		{
			base.AddElementMapping( "DmnhomquycachEntity", "BBPH", @"dbo", "Dmnhomquycach", 7 );
			base.AddElementFieldMapping( "DmnhomquycachEntity", "Manhom", "Manhom", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmnhomquycachEntity", "Tennhom", "Tennhom", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmnhomquycachEntity", "Tenrutgon", "Tenrutgon", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmnhomquycachEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "DmnhomquycachEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmnhomquycachEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DmnhomquycachEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DmquycachEntity's mappings</summary>
		private void InitDmquycachEntityMappings()
		{
			base.AddElementMapping( "DmquycachEntity", "BBPH", @"dbo", "Dmquycach", 10 );
			base.AddElementFieldMapping( "DmquycachEntity", "Maquycach", "Maquycach", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmquycachEntity", "Tenquycach", "Tenquycach", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmquycachEntity", "Macongdoan", "Macongdoan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmquycachEntity", "Tencongdoan", "Tencongdoan", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmquycachEntity", "Manhom", "Manhom", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmquycachEntity", "Tennhom", "Tennhom", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmquycachEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "DmquycachEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DmquycachEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "DmquycachEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits DmtaikhoanEntity's mappings</summary>
		private void InitDmtaikhoanEntityMappings()
		{
			base.AddElementMapping( "DmtaikhoanEntity", "BBPH", @"dbo", "dmtaikhoan", 12 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Matk", "Matk", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Tentk", "Tentk", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Bactk", "Bactk", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Tinhchattk", "Tinhchattk", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Matkcha", "Matkcha", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Trongbang", "Trongbang", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 5 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Doituongtd", "Doituongtd", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Khoanmuctd", "Khoanmuctd", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "DmtaikhoanEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
		}
		/// <summary>Inits DonhangDEntity's mappings</summary>
		private void InitDonhangDEntityMappings()
		{
			base.AddElementMapping( "DonhangDEntity", "BBPH", @"dbo", "donhang_d", 16 );
			base.AddElementFieldMapping( "DonhangDEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "DonhangDEntity", "Madon", "Madon", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DonhangDEntity", "Ngaydat", "Ngaydat", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "DonhangDEntity", "Makhach", "Makhach", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DonhangDEntity", "Sobaogia", "Sobaogia", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DonhangDEntity", "Loaihang", "Loaihang", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "DonhangDEntity", "Masp", "Masp", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DonhangDEntity", "Tenhang", "Tenhang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DonhangDEntity", "Soluong", "Soluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "DonhangDEntity", "Dongia", "Dongia", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "DonhangDEntity", "Ngaygiao", "Ngaygiao", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "DonhangDEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DonhangDEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "DonhangDEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
			base.AddElementFieldMapping( "DonhangDEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "DonhangDEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 15 );
		}
		/// <summary>Inits DonhangHEntity's mappings</summary>
		private void InitDonhangHEntityMappings()
		{
			base.AddElementMapping( "DonhangHEntity", "BBPH", @"dbo", "donhang_h", 13 );
			base.AddElementFieldMapping( "DonhangHEntity", "Madon", "Madon", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DonhangHEntity", "Ngaydat", "Ngaydat", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "DonhangHEntity", "Makhach", "Makhach", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DonhangHEntity", "Tenkhach", "Tenkhach", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DonhangHEntity", "Sobaogia", "Sobaogia", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DonhangHEntity", "Ngaybaogia", "Ngaybaogia", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "DonhangHEntity", "Userid", "Userid", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "DonhangHEntity", "Tennv", "Tennv", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DonhangHEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "DonhangHEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			base.AddElementFieldMapping( "DonhangHEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "DonhangHEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "DonhangHEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 12 );
		}
		/// <summary>Inits HangtralaiEntity's mappings</summary>
		private void InitHangtralaiEntityMappings()
		{
			base.AddElementMapping( "HangtralaiEntity", "BBPH", @"dbo", "hangtralai", 17 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Sophieugiao", "Sophieugiao", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Ngaygiao", "Ngaygiao", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Madon", "Madon", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Ngaydat", "Ngaydat", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Masp", "Masp", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Tenhang", "Tenhang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Soluonggiao", "Soluonggiao", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Soluongtralai", "Soluongtralai", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Ngaytra", "Ngaytra", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Nguyennhan", "Nguyennhan", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "HangtralaiEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 16 );
		}
		/// <summary>Inits KetquachiaEntity's mappings</summary>
		private void InitKetquachiaEntityMappings()
		{
			base.AddElementMapping( "KetquachiaEntity", "BBPH", @"dbo", "Ketquachia", 27 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Ngay", "Ngay", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Ca", "Ca", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Lenh", "Lenh", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Masanpham", "Masanpham", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Macongnhan", "Macongnhan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Dauraghep", "Dauraghep", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Sometvao", "Sometvao", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Sokgvao", "Sokgvao", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Socon", "Socon", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 9 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Thoigianbatdau", "Thoigianbatdau", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Thoigianketthuc", "Thoigianketthuc", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Thoigianlencuon", "Thoigianlencuon", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Thoigianhacuon", "Thoigianhacuon", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Solanhacuon", "Solanhacuon", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Thoigiancatdau", "Thoigiancatdau", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Thoigiandoilenh", "Thoigiandoilenh", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Thoigiansuco", "Thoigiansuco", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 17 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Phein", "Phein", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 18 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Pheghep", "Pheghep", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 19 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Phechia", "Phechia", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "KetquachiaEntity", "PhethoiNcc", "PhethoiNCC", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 21 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Phesx", "Phesx", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 22 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 23 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 24 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 25 );
			base.AddElementFieldMapping( "KetquachiaEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 26 );
		}
		/// <summary>Inits KetquaghepEntity's mappings</summary>
		private void InitKetquaghepEntityMappings()
		{
			base.AddElementMapping( "KetquaghepEntity", "BBPH", @"dbo", "Ketquaghep", 35 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Ngay", "Ngay", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Ca", "Ca", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Mamay", "Mamay", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Lenhghep", "Lenhghep", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Masanpham", "Masanpham", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Macongnhan", "Macongnhan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Dauratua", "Dauratua", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "KetquaghepEntity", "ManginMet", "ManginMet", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "KetquaghepEntity", "ManginKg", "ManginKg", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "KetquaghepEntity", "MangcapMet", "MangcapMet", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "KetquaghepEntity", "MangcapKg", "MangcapKg", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Solopghep", "Solopghep", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 12 );
			base.AddElementFieldMapping( "KetquaghepEntity", "ThucteMet", "ThucteMet", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 13 );
			base.AddElementFieldMapping( "KetquaghepEntity", "ThucteKg", "ThucteKg", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 14 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Thoigianbatdau", "Thoigianbatdau", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Thoigianketthuc", "Thoigianketthuc", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 16 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Thoigianchuanbi", "Thoigianchuanbi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 17 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Thoigiansuco", "Thoigiansuco", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 18 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Thuctekeo", "Thuctekeo", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 19 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Thuctedongran", "Thuctedongran", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Thuctedungmoi", "Thuctedungmoi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 21 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Phein", "Phein", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 22 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Pheghep", "Pheghep", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 23 );
			base.AddElementFieldMapping( "KetquaghepEntity", "PheNcc", "PheNCC", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 24 );
			base.AddElementFieldMapping( "KetquaghepEntity", "PheSx", "PheSX", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 25 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Phethoi", "Phethoi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 26 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Pheintui", "Pheintui", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 27 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Phegheptui", "Phegheptui", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 28 );
			base.AddElementFieldMapping( "KetquaghepEntity", "PhethoiNcc", "Phethoi_NCC", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 29 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Phesxtui", "Phesxtui", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 30 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 31 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 32 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 33 );
			base.AddElementFieldMapping( "KetquaghepEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 34 );
		}
		/// <summary>Inits KetquainEntity's mappings</summary>
		private void InitKetquainEntityMappings()
		{
			base.AddElementMapping( "KetquainEntity", "BBPH", @"dbo", "Ketquain", 25 );
			base.AddElementFieldMapping( "KetquainEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "KetquainEntity", "Ngay", "Ngay", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "KetquainEntity", "Ca", "Ca", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "KetquainEntity", "Mamay", "Mamay", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "KetquainEntity", "Lenhin", "Lenhin", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "KetquainEntity", "Masanpham", "Masanpham", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "KetquainEntity", "Macongnhan", "Macongnhan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "KetquainEntity", "SometLsx", "SometLSX", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "KetquainEntity", "Sometcap", "Sometcap", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "KetquainEntity", "Sokgcap", "Sokgcap", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "KetquainEntity", "Thuctein", "Thuctein", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "KetquainEntity", "Sokgin", "Sokgin", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "KetquainEntity", "Saihongthucte", "Saihongthucte", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "KetquainEntity", "Thoigianbatdau", "Thoigianbatdau", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			base.AddElementFieldMapping( "KetquainEntity", "Thoigianketthuc", "Thoigianketthuc", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "KetquainEntity", "Thoigianchuanbi", "Thoigianchuanbi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 15 );
			base.AddElementFieldMapping( "KetquainEntity", "Thoigiansuco", "Thoigiansuco", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 16 );
			base.AddElementFieldMapping( "KetquainEntity", "PheNcc", "PheNCC", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 17 );
			base.AddElementFieldMapping( "KetquainEntity", "PheSx", "PheSX", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 18 );
			base.AddElementFieldMapping( "KetquainEntity", "Tongm2dm", "Tongm2dm", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 19 );
			base.AddElementFieldMapping( "KetquainEntity", "M2saihongtt", "M2saihongtt", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "KetquainEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 21 );
			base.AddElementFieldMapping( "KetquainEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 22 );
			base.AddElementFieldMapping( "KetquainEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 23 );
			base.AddElementFieldMapping( "KetquainEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 24 );
		}
		/// <summary>Inits KetquainmauEntity's mappings</summary>
		private void InitKetquainmauEntityMappings()
		{
			base.AddElementMapping( "KetquainmauEntity", "BBPH", @"dbo", "Ketquainmau", 14 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "KetquainmauEntity", "KetquainId", "KetquainId", true, (int)SqlDbType.BigInt, 0, 0, 19, false, "", null, typeof(System.Int64), 1 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Masp", "Masp", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Tensp", "Tensp", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Mamau", "Mamau", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Tenmau", "Tenmau", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Xuatdodang", "Xuatdodang", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 6 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Xuatnguyen", "Xuatnguyen", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Nhapdodang", "Nhapdodang", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Nhapnguyen", "Nhapnguyen", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "KetquainmauEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 13 );
		}
		/// <summary>Inits KetquathoiEntity's mappings</summary>
		private void InitKetquathoiEntityMappings()
		{
			base.AddElementMapping( "KetquathoiEntity", "BBPH", @"dbo", "Ketquathoi", 26 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Ngay", "Ngay", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Ca", "Ca", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Mamay", "Mamay", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Lenhthoi", "Lenhthoi", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Mamang", "Mamang", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Macongnhan", "Macongnhan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Somet", "Somet", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Sokg", "Sokg", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Sokgquydoi", "Sokgquydoi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Chenhlechkg", "Chenhlechkg", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Chatluong", "Chatluong", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Phelieuthucte", "Phelieuthucte", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Tongsp", "Tongsp", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 13 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Thoigianbatdau", "Thoigianbatdau", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Thoigianketthuc", "Thoigianketthuc", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Thoigianchuanbi", "Thoigianchuanbi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 16 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Thoigiansuco", "Thoigiansuco", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 17 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Sokgdukiendat", "Sokgdukiendat", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 18 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 19 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 20 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 21 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 22 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Tenmang", "Tenmang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 23 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Tenmay", "Tenmay", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 24 );
			base.AddElementFieldMapping( "KetquathoiEntity", "Tencongnhan", "Tencongnhan", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 25 );
		}
		/// <summary>Inits KetquatuaEntity's mappings</summary>
		private void InitKetquatuaEntityMappings()
		{
			base.AddElementMapping( "KetquatuaEntity", "BBPH", @"dbo", "Ketquatua", 28 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Ngay", "Ngay", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Ca", "Ca", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Mamay", "Mamay", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Lenhtua", "Lenhtua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Masanpham", "Masanpham", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Macongnhan", "Macongnhan", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Daurain", "Daurain", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 7 );
			base.AddElementFieldMapping( "KetquatuaEntity", "SoMetvao", "SoMetvao", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 8 );
			base.AddElementFieldMapping( "KetquatuaEntity", "SoKgvao", "SoKgvao", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 9 );
			base.AddElementFieldMapping( "KetquatuaEntity", "SoMetra", "SoMetra", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 10 );
			base.AddElementFieldMapping( "KetquatuaEntity", "SoKgra", "SoKgra", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Saihongthucte", "Saihongthucte", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Thoigianbatdau", "Thoigianbatdau", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 13 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Thoigianketthuc", "Thoigianketthuc", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 14 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Thoigianchuanbi", "Thoigianchuanbi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 15 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Thoigianhacuon", "Thoigianhacuon", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 16 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Thoigiancatdau", "Thoigiancatdau", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 17 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Thoigiandoilenh", "Thoigiandoilenh", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 18 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Thoigiansuco", "Thoigiansuco", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 19 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Phein", "Phein", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 20 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Pheghep", "Pheghep", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 21 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Phethoi", "Phethoi", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 22 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Phesx", "Phesx", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 23 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 24 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 25 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 26 );
			base.AddElementFieldMapping( "KetquatuaEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 27 );
		}
		/// <summary>Inits LogbackupEntity's mappings</summary>
		private void InitLogbackupEntityMappings()
		{
			base.AddElementMapping( "LogbackupEntity", "BBPH", @"dbo", "Logbackup", 4 );
			base.AddElementFieldMapping( "LogbackupEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "LogbackupEntity", "Nam", "Nam", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "LogbackupEntity", "Duongdan", "Duongdan", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "LogbackupEntity", "Ngay", "Ngay", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits MaucuahangEntity's mappings</summary>
		private void InitMaucuahangEntityMappings()
		{
			base.AddElementMapping( "MaucuahangEntity", "BBPH", @"dbo", "maucuahang", 10 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Masp", "Masp", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Tensp", "Tensp", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Mamau", "Mamau", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Tenmau", "Tenmau", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Klmau", "Klmau", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "MaucuahangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits MenuEntity's mappings</summary>
		private void InitMenuEntityMappings()
		{
			base.AddElementMapping( "MenuEntity", "BBPH", @"dbo", "Menu", 11 );
			base.AddElementFieldMapping( "MenuEntity", "MenuId", "MenuId", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MenuEntity", "MenuName", "MenuName", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "MenuEntity", "Icon", "Icon", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "MenuEntity", "Issudung", "Issudung", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "MenuEntity", "Istrangthai", "Istrangthai", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "MenuEntity", "Menuparent", "Menuparent", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "MenuEntity", "Thutu", "Thutu", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "MenuEntity", "FormName", "FormName", true, (int)SqlDbType.NVarChar, 1000, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "MenuEntity", "LoaiMenu", "LoaiMenu", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "MenuEntity", "Param", "Param", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "MenuEntity", "Maphanhe", "Maphanhe", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits MenuroleEntity's mappings</summary>
		private void InitMenuroleEntityMappings()
		{
			base.AddElementMapping( "MenuroleEntity", "BBPH", @"dbo", "Menurole", 2 );
			base.AddElementFieldMapping( "MenuroleEntity", "Menuid", "Menuid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MenuroleEntity", "Rolesid", "Rolesid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits PhieugiaohangDEntity's mappings</summary>
		private void InitPhieugiaohangDEntityMappings()
		{
			base.AddElementMapping( "PhieugiaohangDEntity", "BBPH", @"dbo", "phieugiaohang_d", 19 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Sophieu", "Sophieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Ngaygiao", "Ngaygiao", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Madon", "Madon", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "DonchitietId", "Donchitiet_Id", true, (int)SqlDbType.BigInt, 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Ngaydat", "Ngaydat", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Loaihang", "Loaihang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Masp", "Masp", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Tenhang", "Tenhang", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Soluong", "Soluong", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 11 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Dongia", "Dongia", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 12 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Thanhtien", "Thanhtien", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 13 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 14 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 15 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 16 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 17 );
			base.AddElementFieldMapping( "PhieugiaohangDEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 18 );
		}
		/// <summary>Inits PhieugiaohangHEntity's mappings</summary>
		private void InitPhieugiaohangHEntityMappings()
		{
			base.AddElementMapping( "PhieugiaohangHEntity", "BBPH", @"dbo", "phieugiaohang_h", 13 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Sophieu", "Sophieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Ngaygiao", "Ngaygiao", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Madon", "Madon", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Ngaydat", "Ngaydat", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Makhach", "Makhach", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Tenkhach", "Tenkhach", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Tongtien", "Tongtien", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Vat", "VAT", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "PhieugiaohangHEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 12 );
		}
		/// <summary>Inits RolesEntity's mappings</summary>
		private void InitRolesEntityMappings()
		{
			base.AddElementMapping( "RolesEntity", "BBPH", @"dbo", "Roles", 3 );
			base.AddElementFieldMapping( "RolesEntity", "Rolesid", "Rolesid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "RolesEntity", "Rolesname", "Rolesname", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "RolesEntity", "Description", "Description", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits ThamsoEntity's mappings</summary>
		private void InitThamsoEntityMappings()
		{
			base.AddElementMapping( "ThamsoEntity", "BBPH", @"dbo", "Thamso", 9 );
			base.AddElementFieldMapping( "ThamsoEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "ThamsoEntity", "Stt", "Stt", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ThamsoEntity", "Tenthamso", "Tenthamso", false, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ThamsoEntity", "Giatri", "Giatri", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ThamsoEntity", "Thaydoi", "Thaydoi", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "ThamsoEntity", "Kieudulieu", "Kieudulieu", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "ThamsoEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ThamsoEntity", "Loaithamso", "Loaithamso", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "ThamsoEntity", "An", "An", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
		}
		/// <summary>Inits ThanhphanmauEntity's mappings</summary>
		private void InitThanhphanmauEntityMappings()
		{
			base.AddElementMapping( "ThanhphanmauEntity", "BBPH", @"dbo", "thanhphanmau", 10 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Mamau", "Mamau", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Tenmau", "Tenmau", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Mausudung", "Mausudung", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Tenmausudung", "Tenmausudung", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Tyle", "Tyle", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 8 );
			base.AddElementFieldMapping( "ThanhphanmauEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits TknguyenlieuthoiEntity's mappings</summary>
		private void InitTknguyenlieuthoiEntityMappings()
		{
			base.AddElementMapping( "TknguyenlieuthoiEntity", "BBPH", @"dbo", "Tknguyenlieuthoi", 7 );
			base.AddElementFieldMapping( "TknguyenlieuthoiEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "TknguyenlieuthoiEntity", "Ngay", "Ngay", true, (int)SqlDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "TknguyenlieuthoiEntity", "Ca", "Ca", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "TknguyenlieuthoiEntity", "Manguyenlieu", "Manguyenlieu", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "TknguyenlieuthoiEntity", "Tennguyenlieu", "Tennguyenlieu", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "TknguyenlieuthoiEntity", "Klnhap", "Klnhap", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 5 );
			base.AddElementFieldMapping( "TknguyenlieuthoiEntity", "Klxuat", "Klxuat", true, (int)SqlDbType.Decimal, 0, 2, 20, false, "", null, typeof(System.Decimal), 6 );
		}
		/// <summary>Inits TruccuahangEntity's mappings</summary>
		private void InitTruccuahangEntityMappings()
		{
			base.AddElementMapping( "TruccuahangEntity", "BBPH", @"dbo", "truccuahang", 9 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Id", "Id", false, (int)SqlDbType.BigInt, 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Masp", "Masp", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Tensp", "Tensp", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Stttruc", "Stttruc", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 3 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Matruc", "Matruc", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Ngaytao", "Ngaytao", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Nguoitao", "Nguoitao", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Ngaysua", "Ngaysua", true, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "TruccuahangEntity", "Nguoisua", "Nguoisua", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 8 );
		}
		/// <summary>Inits UsersEntity's mappings</summary>
		private void InitUsersEntityMappings()
		{
			base.AddElementMapping( "UsersEntity", "BBPH", @"dbo", "Users", 8 );
			base.AddElementFieldMapping( "UsersEntity", "Userid", "Userid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "UsersEntity", "Rolesid", "Rolesid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "UsersEntity", "Username", "Username", false, (int)SqlDbType.NVarChar, 150, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "UsersEntity", "Fullname", "Fullname", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "UsersEntity", "Phone", "Phone", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "UsersEntity", "Address", "Address", true, (int)SqlDbType.NVarChar, 500, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "UsersEntity", "Password", "Password", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "UsersEntity", "Active", "Active", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 7 );
		}

	}
}













