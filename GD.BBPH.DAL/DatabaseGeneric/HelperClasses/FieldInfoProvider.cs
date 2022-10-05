﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, October 5, 2022 3:24:51 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			base.InitClass( (27 + 0));
			InitCongsuatmayEntityInfos();
			InitCtptmangDEntityInfos();
			InitCtptmangHEntityInfos();
			InitDinhmucthoigianEntityInfos();
			InitDmbophanEntityInfos();
			InitDmcapmaEntityInfos();
			InitDmchucvuEntityInfos();
			InitDmcongdoanEntityInfos();
			InitDmcongnhanEntityInfos();
			InitDmdongmayEntityInfos();
			InitDmhangEntityInfos();
			InitDmkhachEntityInfos();
			InitDmkhoEntityInfos();
			InitDmlydonhapxuatEntityInfos();
			InitDmmangEntityInfos();
			InitDmmauEntityInfos();
			InitDmmayEntityInfos();
			InitDmnguyenlieuEntityInfos();
			InitDmnhomnguyenlieuEntityInfos();
			InitDmquycachEntityInfos();
			InitDmtaikhoanEntityInfos();
			InitLogbackupEntityInfos();
			InitMenuEntityInfos();
			InitMenuroleEntityInfos();
			InitRolesEntityInfos();
			InitThamsoEntityInfos();
			InitUsersEntityInfos();

			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits CongsuatmayEntity's FieldInfo objects</summary>
		private void InitCongsuatmayEntityInfos()
		{
			base.AddElementFieldInfo("CongsuatmayEntity", "Macs", typeof(System.String), true, false, false, false,  (int)CongsuatmayFieldIndex.Macs, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Tencongsuat", typeof(System.String), false, false, false, false,  (int)CongsuatmayFieldIndex.Tencongsuat, 250, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Macd", typeof(System.String), false, true, false, true,  (int)CongsuatmayFieldIndex.Macd, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Maqc", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Maqc, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CongsuatmayFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CongsuatmayFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits CtptmangDEntity's FieldInfo objects</summary>
		private void InitCtptmangDEntityInfos()
		{
			base.AddElementFieldInfo("CtptmangDEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)CtptmangDFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("CtptmangDEntity", "IdH", typeof(Nullable<System.Int64>), false, true, false, true,  (int)CtptmangDFieldIndex.IdH, 0, 0, 19);
			base.AddElementFieldInfo("CtptmangDEntity", "Mact", typeof(System.String), false, false, false, false,  (int)CtptmangDFieldIndex.Mact, 50, 0, 0);
			base.AddElementFieldInfo("CtptmangDEntity", "Tenct", typeof(System.String), false, false, false, false,  (int)CtptmangDFieldIndex.Tenct, 250, 0, 0);
			base.AddElementFieldInfo("CtptmangDEntity", "Manl", typeof(System.String), false, true, false, false,  (int)CtptmangDFieldIndex.Manl, 50, 0, 0);
			base.AddElementFieldInfo("CtptmangDEntity", "Tennguyenlieu", typeof(System.String), false, false, false, false,  (int)CtptmangDFieldIndex.Tennguyenlieu, 250, 0, 0);
			base.AddElementFieldInfo("CtptmangDEntity", "Trongluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CtptmangDFieldIndex.Trongluong, 0, 2, 20);
			base.AddElementFieldInfo("CtptmangDEntity", "Tyle", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CtptmangDFieldIndex.Tyle, 0, 2, 20);
			base.AddElementFieldInfo("CtptmangDEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CtptmangDFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("CtptmangDEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)CtptmangDFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("CtptmangDEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CtptmangDFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("CtptmangDEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)CtptmangDFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits CtptmangHEntity's FieldInfo objects</summary>
		private void InitCtptmangHEntityInfos()
		{
			base.AddElementFieldInfo("CtptmangHEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)CtptmangHFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("CtptmangHEntity", "Mactpt", typeof(System.String), false, false, false, false,  (int)CtptmangHFieldIndex.Mactpt, 50, 0, 0);
			base.AddElementFieldInfo("CtptmangHEntity", "Tenctpt", typeof(System.String), false, false, false, false,  (int)CtptmangHFieldIndex.Tenctpt, 250, 0, 0);
			base.AddElementFieldInfo("CtptmangHEntity", "Ngayapdung", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CtptmangHFieldIndex.Ngayapdung, 0, 0, 0);
			base.AddElementFieldInfo("CtptmangHEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CtptmangHFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("CtptmangHEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)CtptmangHFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("CtptmangHEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CtptmangHFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("CtptmangHEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)CtptmangHFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DinhmucthoigianEntity's FieldInfo objects</summary>
		private void InitDinhmucthoigianEntityInfos()
		{
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Madmtg", typeof(System.String), true, false, false, false,  (int)DinhmucthoigianFieldIndex.Madmtg, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Tendinhmuc", typeof(System.String), false, false, false, false,  (int)DinhmucthoigianFieldIndex.Tendinhmuc, 250, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Mamay", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Madm", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Madm, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Dauca", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Dauca, 0, 2, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Doilenh", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Doilenh, 0, 2, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Lencuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Lencuon, 0, 2, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Xuongcuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Xuongcuon, 0, 2, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Thaythietbi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Thaythietbi, 0, 2, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Dungmay", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Dungmay, 0, 2, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmbophanEntity's FieldInfo objects</summary>
		private void InitDmbophanEntityInfos()
		{
			base.AddElementFieldInfo("DmbophanEntity", "Mabp", typeof(System.String), true, false, false, false,  (int)DmbophanFieldIndex.Mabp, 50, 0, 0);
			base.AddElementFieldInfo("DmbophanEntity", "Tenbophan", typeof(System.String), false, false, false, false,  (int)DmbophanFieldIndex.Tenbophan, 250, 0, 0);
			base.AddElementFieldInfo("DmbophanEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmbophanFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmbophanEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmbophanFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmbophanEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmbophanFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmbophanEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmbophanFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmcapmaEntity's FieldInfo objects</summary>
		private void InitDmcapmaEntityInfos()
		{
			base.AddElementFieldInfo("DmcapmaEntity", "Macappk", typeof(System.String), false, false, false, false,  (int)DmcapmaFieldIndex.Macappk, 50, 0, 0);
			base.AddElementFieldInfo("DmcapmaEntity", "Loaima", typeof(System.String), true, false, false, false,  (int)DmcapmaFieldIndex.Loaima, 50, 0, 0);
			base.AddElementFieldInfo("DmcapmaEntity", "Mastart", typeof(System.String), false, false, false, true,  (int)DmcapmaFieldIndex.Mastart, 50, 0, 0);
		}
		/// <summary>Inits DmchucvuEntity's FieldInfo objects</summary>
		private void InitDmchucvuEntityInfos()
		{
			base.AddElementFieldInfo("DmchucvuEntity", "Macv", typeof(System.String), true, false, false, false,  (int)DmchucvuFieldIndex.Macv, 50, 0, 0);
			base.AddElementFieldInfo("DmchucvuEntity", "Tenchucvu", typeof(System.String), false, false, false, false,  (int)DmchucvuFieldIndex.Tenchucvu, 250, 0, 0);
			base.AddElementFieldInfo("DmchucvuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmchucvuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmchucvuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmchucvuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmchucvuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmchucvuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmchucvuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmchucvuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmcongdoanEntity's FieldInfo objects</summary>
		private void InitDmcongdoanEntityInfos()
		{
			base.AddElementFieldInfo("DmcongdoanEntity", "Macd", typeof(System.String), true, false, false, false,  (int)DmcongdoanFieldIndex.Macd, 50, 0, 0);
			base.AddElementFieldInfo("DmcongdoanEntity", "Tencongdoan", typeof(System.String), false, false, false, false,  (int)DmcongdoanFieldIndex.Tencongdoan, 250, 0, 0);
			base.AddElementFieldInfo("DmcongdoanEntity", "Sothutucongdoan", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmcongdoanFieldIndex.Sothutucongdoan, 0, 0, 10);
			base.AddElementFieldInfo("DmcongdoanEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmcongdoanFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmcongdoanEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmcongdoanFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmcongdoanEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmcongdoanFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmcongdoanEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmcongdoanFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmcongnhanEntity's FieldInfo objects</summary>
		private void InitDmcongnhanEntityInfos()
		{
			base.AddElementFieldInfo("DmcongnhanEntity", "Macn", typeof(System.String), true, false, false, false,  (int)DmcongnhanFieldIndex.Macn, 50, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Hovatencongnhan", typeof(System.String), false, false, false, false,  (int)DmcongnhanFieldIndex.Hovatencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Tencongnhan", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Tencongnhan, 50, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Mabp", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Mabp, 50, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Macv", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Macv, 50, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Sodienthoai", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Sodienthoai, 100, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Tinhtrang", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Tinhtrang, 100, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Phongban", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Phongban, 250, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Chucvu", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Chucvu, 250, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Danghi", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DmcongnhanFieldIndex.Danghi, 0, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmcongnhanFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmcongnhanFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmdongmayEntity's FieldInfo objects</summary>
		private void InitDmdongmayEntityInfos()
		{
			base.AddElementFieldInfo("DmdongmayEntity", "Madm", typeof(System.String), true, false, false, false,  (int)DmdongmayFieldIndex.Madm, 50, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Tendongmay", typeof(System.String), false, false, false, false,  (int)DmdongmayFieldIndex.Tendongmay, 250, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Macd", typeof(System.String), false, true, false, true,  (int)DmdongmayFieldIndex.Macd, 50, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmdongmayFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmdongmayFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmdongmayFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmdongmayFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmhangEntity's FieldInfo objects</summary>
		private void InitDmhangEntityInfos()
		{
			base.AddElementFieldInfo("DmhangEntity", "Masp", typeof(System.String), true, false, false, false,  (int)DmhangFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tensp", typeof(System.String), false, false, false, false,  (int)DmhangFieldIndex.Tensp, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Makhach, 20, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Kichthuoc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Kichthuoc, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Khoiluongmuc", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Khoiluongmuc, 0, 2, 20);
			base.AddElementFieldInfo("DmhangEntity", "Sohinh", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Sohinh, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Cautrucin", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Cautrucin, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Somau", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Somau, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Loaimuc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Loaimuc, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Kichthuoctruc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Kichthuoctruc, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Vitri", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Vitri, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Quycachdonggoi", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Quycachdonggoi, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Loaithung", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Loaithung, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmhangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmhangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmkhachEntity's FieldInfo objects</summary>
		private void InitDmkhachEntityInfos()
		{
			base.AddElementFieldInfo("DmkhachEntity", "Makhach", typeof(System.String), true, false, false, false,  (int)DmkhachFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Tenkhach", typeof(System.String), false, false, false, false,  (int)DmkhachFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Tenrutgon, 250, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Truyenthong", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DmkhachFieldIndex.Truyenthong, 0, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Diachi", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Diachi, 250, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Sodienthoai", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Sodienthoai, 100, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Email", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Email, 100, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Tknganhang", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Tknganhang, 100, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Tennganhang", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Tennganhang, 100, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Noidia", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DmkhachFieldIndex.Noidia, 0, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Tennguoilh", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Tennguoilh, 250, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Chucvu", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Chucvu, 100, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Sodienthoailh", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Sodienthoailh, 100, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Thongtinbosung", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Thongtinbosung, 250, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmkhachFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmkhachFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmkhachEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmkhachFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmkhoEntity's FieldInfo objects</summary>
		private void InitDmkhoEntityInfos()
		{
			base.AddElementFieldInfo("DmkhoEntity", "Makho", typeof(System.String), true, false, false, false,  (int)DmkhoFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("DmkhoEntity", "Tenkho", typeof(System.String), false, false, false, false,  (int)DmkhoFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("DmkhoEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DmkhoFieldIndex.Tenrutgon, 250, 0, 0);
			base.AddElementFieldInfo("DmkhoEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmkhoFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmkhoEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmkhoFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmkhoEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmkhoFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmkhoEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmkhoFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmlydonhapxuatEntity's FieldInfo objects</summary>
		private void InitDmlydonhapxuatEntityInfos()
		{
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Malydo", typeof(System.String), true, false, false, false,  (int)DmlydonhapxuatFieldIndex.Malydo, 50, 0, 0);
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Tenlydo", typeof(System.String), false, false, false, false,  (int)DmlydonhapxuatFieldIndex.Tenlydo, 250, 0, 0);
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Manhom", typeof(System.String), false, false, false, true,  (int)DmlydonhapxuatFieldIndex.Manhom, 50, 0, 0);
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Tennhom", typeof(System.String), false, false, false, true,  (int)DmlydonhapxuatFieldIndex.Tennhom, 250, 0, 0);
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmlydonhapxuatFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmlydonhapxuatFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmlydonhapxuatFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmlydonhapxuatEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmlydonhapxuatFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmmangEntity's FieldInfo objects</summary>
		private void InitDmmangEntityInfos()
		{
			base.AddElementFieldInfo("DmmangEntity", "Mamang", typeof(System.String), true, false, false, false,  (int)DmmangFieldIndex.Mamang, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Tenmang", typeof(System.String), false, false, false, false,  (int)DmmangFieldIndex.Tenmang, 250, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Makhach", typeof(System.String), false, false, false, false,  (int)DmmangFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Tenkhach", typeof(System.String), false, false, false, false,  (int)DmmangFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Kichthuoc", typeof(System.String), false, false, false, false,  (int)DmmangFieldIndex.Kichthuoc, 250, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Trongluong", typeof(System.String), false, false, false, false,  (int)DmmangFieldIndex.Trongluong, 250, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Mactpt", typeof(System.String), false, false, false, false,  (int)DmmangFieldIndex.Mactpt, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmmauEntity's FieldInfo objects</summary>
		private void InitDmmauEntityInfos()
		{
			base.AddElementFieldInfo("DmmauEntity", "Mamau", typeof(System.String), true, false, false, false,  (int)DmmauFieldIndex.Mamau, 50, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Tenmau", typeof(System.String), false, false, false, false,  (int)DmmauFieldIndex.Tenmau, 250, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "ChisoRgb", typeof(System.String), false, false, false, false,  (int)DmmauFieldIndex.ChisoRgb, 250, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmauFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmmauFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmauFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmmauFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmmayEntity's FieldInfo objects</summary>
		private void InitDmmayEntityInfos()
		{
			base.AddElementFieldInfo("DmmayEntity", "Mamay", typeof(System.String), true, false, false, false,  (int)DmmayFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Tenmay", typeof(System.String), false, false, false, false,  (int)DmmayFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Madm", typeof(System.String), false, true, false, true,  (int)DmmayFieldIndex.Madm, 50, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Vitri", typeof(System.String), false, false, false, true,  (int)DmmayFieldIndex.Vitri, 250, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmayFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmmayFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmayFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmmayFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmnguyenlieuEntity's FieldInfo objects</summary>
		private void InitDmnguyenlieuEntityInfos()
		{
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Manl", typeof(System.String), true, false, false, false,  (int)DmnguyenlieuFieldIndex.Manl, 50, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Tenrutgon", typeof(System.String), false, false, false, false,  (int)DmnguyenlieuFieldIndex.Tenrutgon, 250, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Manhom", typeof(System.String), false, true, false, true,  (int)DmnguyenlieuFieldIndex.Manhom, 50, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Tennhom", typeof(System.String), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Tennhom, 250, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Tennl", typeof(System.String), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Tennl, 100, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Gia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Gia, 0, 2, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Giahientai", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Giahientai, 0, 2, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Tang", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Tang, 0, 2, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Giam", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Giam, 0, 2, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmnhomnguyenlieuEntity's FieldInfo objects</summary>
		private void InitDmnhomnguyenlieuEntityInfos()
		{
			base.AddElementFieldInfo("DmnhomnguyenlieuEntity", "Manhom", typeof(System.String), true, false, false, false,  (int)DmnhomnguyenlieuFieldIndex.Manhom, 50, 0, 0);
			base.AddElementFieldInfo("DmnhomnguyenlieuEntity", "Tennhomnguyenlieu", typeof(System.String), false, false, false, false,  (int)DmnhomnguyenlieuFieldIndex.Tennhomnguyenlieu, 250, 0, 0);
			base.AddElementFieldInfo("DmnhomnguyenlieuEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DmnhomnguyenlieuFieldIndex.Tenrutgon, 250, 0, 0);
			base.AddElementFieldInfo("DmnhomnguyenlieuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnhomnguyenlieuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmnhomnguyenlieuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmnhomnguyenlieuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmnhomnguyenlieuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnhomnguyenlieuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmnhomnguyenlieuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmnhomnguyenlieuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmquycachEntity's FieldInfo objects</summary>
		private void InitDmquycachEntityInfos()
		{
			base.AddElementFieldInfo("DmquycachEntity", "Maqc", typeof(System.String), true, false, false, false,  (int)DmquycachFieldIndex.Maqc, 50, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Tenquycach", typeof(System.String), false, false, false, false,  (int)DmquycachFieldIndex.Tenquycach, 250, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Macd", typeof(System.String), false, true, false, true,  (int)DmquycachFieldIndex.Macd, 50, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Maqccha", typeof(System.String), false, false, false, true,  (int)DmquycachFieldIndex.Maqccha, 50, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmquycachFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmquycachFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmquycachFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmquycachFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmtaikhoanEntity's FieldInfo objects</summary>
		private void InitDmtaikhoanEntityInfos()
		{
			base.AddElementFieldInfo("DmtaikhoanEntity", "Matk", typeof(System.String), true, false, false, false,  (int)DmtaikhoanFieldIndex.Matk, 50, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Tentk", typeof(System.String), false, false, false, false,  (int)DmtaikhoanFieldIndex.Tentk, 250, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Bactk", typeof(System.String), false, false, false, false,  (int)DmtaikhoanFieldIndex.Bactk, 250, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Tinhchattk", typeof(System.String), false, false, false, false,  (int)DmtaikhoanFieldIndex.Tinhchattk, 250, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Matkcha", typeof(System.String), false, false, false, false,  (int)DmtaikhoanFieldIndex.Matkcha, 50, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "ChisoRgb", typeof(System.String), false, false, false, false,  (int)DmtaikhoanFieldIndex.ChisoRgb, 250, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmtaikhoanFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmtaikhoanFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits LogbackupEntity's FieldInfo objects</summary>
		private void InitLogbackupEntityInfos()
		{
			base.AddElementFieldInfo("LogbackupEntity", "Mahieu", typeof(System.Int64), true, false, true, false,  (int)LogbackupFieldIndex.Mahieu, 0, 0, 19);
			base.AddElementFieldInfo("LogbackupEntity", "Nam", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LogbackupFieldIndex.Nam, 0, 0, 10);
			base.AddElementFieldInfo("LogbackupEntity", "Duongdan", typeof(System.String), false, false, false, true,  (int)LogbackupFieldIndex.Duongdan, 250, 0, 0);
			base.AddElementFieldInfo("LogbackupEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LogbackupFieldIndex.Ngay, 0, 0, 0);
		}
		/// <summary>Inits MenuEntity's FieldInfo objects</summary>
		private void InitMenuEntityInfos()
		{
			base.AddElementFieldInfo("MenuEntity", "MenuId", typeof(System.String), true, false, false, false,  (int)MenuFieldIndex.MenuId, 50, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "MenuName", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.MenuName, 500, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Icon", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Icon, 500, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Issudung", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.Issudung, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "Istrangthai", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.Istrangthai, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "Menuparent", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Menuparent, 50, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Thutu", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.Thutu, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "FormName", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.FormName, 1000, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "LoaiMenu", typeof(Nullable<System.Int32>), false, false, false, true,  (int)MenuFieldIndex.LoaiMenu, 0, 0, 10);
			base.AddElementFieldInfo("MenuEntity", "Param", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Param, 500, 0, 0);
			base.AddElementFieldInfo("MenuEntity", "Maphanhe", typeof(System.String), false, false, false, true,  (int)MenuFieldIndex.Maphanhe, 50, 0, 0);
		}
		/// <summary>Inits MenuroleEntity's FieldInfo objects</summary>
		private void InitMenuroleEntityInfos()
		{
			base.AddElementFieldInfo("MenuroleEntity", "Menuid", typeof(System.String), true, true, false, false,  (int)MenuroleFieldIndex.Menuid, 50, 0, 0);
			base.AddElementFieldInfo("MenuroleEntity", "Rolesid", typeof(System.String), true, true, false, false,  (int)MenuroleFieldIndex.Rolesid, 50, 0, 0);
		}
		/// <summary>Inits RolesEntity's FieldInfo objects</summary>
		private void InitRolesEntityInfos()
		{
			base.AddElementFieldInfo("RolesEntity", "Rolesid", typeof(System.String), true, false, false, false,  (int)RolesFieldIndex.Rolesid, 50, 0, 0);
			base.AddElementFieldInfo("RolesEntity", "Rolesname", typeof(System.String), false, false, false, true,  (int)RolesFieldIndex.Rolesname, 50, 0, 0);
			base.AddElementFieldInfo("RolesEntity", "Description", typeof(System.String), false, false, false, true,  (int)RolesFieldIndex.Description, 200, 0, 0);
		}
		/// <summary>Inits ThamsoEntity's FieldInfo objects</summary>
		private void InitThamsoEntityInfos()
		{
			base.AddElementFieldInfo("ThamsoEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)ThamsoFieldIndex.Mahieu, 50, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Stt", typeof(System.Int32), false, false, false, false,  (int)ThamsoFieldIndex.Stt, 0, 0, 10);
			base.AddElementFieldInfo("ThamsoEntity", "Tenthamso", typeof(System.String), false, false, false, false,  (int)ThamsoFieldIndex.Tenthamso, 200, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Giatri", typeof(System.String), false, false, false, true,  (int)ThamsoFieldIndex.Giatri, 200, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Thaydoi", typeof(System.Boolean), false, false, false, false,  (int)ThamsoFieldIndex.Thaydoi, 0, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Kieudulieu", typeof(System.Int32), false, false, false, false,  (int)ThamsoFieldIndex.Kieudulieu, 0, 0, 10);
			base.AddElementFieldInfo("ThamsoEntity", "Ghichu", typeof(System.String), false, false, false, true,  (int)ThamsoFieldIndex.Ghichu, 200, 0, 0);
			base.AddElementFieldInfo("ThamsoEntity", "Loaithamso", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ThamsoFieldIndex.Loaithamso, 0, 0, 10);
			base.AddElementFieldInfo("ThamsoEntity", "An", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)ThamsoFieldIndex.An, 0, 0, 0);
		}
		/// <summary>Inits UsersEntity's FieldInfo objects</summary>
		private void InitUsersEntityInfos()
		{
			base.AddElementFieldInfo("UsersEntity", "Userid", typeof(System.String), true, false, false, false,  (int)UsersFieldIndex.Userid, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Rolesid", typeof(System.String), false, true, false, false,  (int)UsersFieldIndex.Rolesid, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Username", typeof(System.String), false, false, false, false,  (int)UsersFieldIndex.Username, 150, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Fullname", typeof(System.String), false, false, false, true,  (int)UsersFieldIndex.Fullname, 500, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Phone", typeof(System.String), false, false, false, true,  (int)UsersFieldIndex.Phone, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Address", typeof(System.String), false, false, false, true,  (int)UsersFieldIndex.Address, 500, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Password", typeof(System.String), false, false, false, false,  (int)UsersFieldIndex.Password, 50, 0, 0);
			base.AddElementFieldInfo("UsersEntity", "Active", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)UsersFieldIndex.Active, 0, 0, 0);
		}
		
	}
}




