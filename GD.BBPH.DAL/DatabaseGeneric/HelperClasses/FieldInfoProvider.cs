﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, September 30, 2022 9:36:17 AM
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
			base.InitClass( (15 + 0));
			InitDmbophanEntityInfos();
			InitDmcapmaEntityInfos();
			InitDmchucvuEntityInfos();
			InitDmcongdoanEntityInfos();
			InitDmcongnhanEntityInfos();
			InitDmdongmayEntityInfos();
			InitDmhangEntityInfos();
			InitDmkhachEntityInfos();
			InitDmmayEntityInfos();
			InitLogbackupEntityInfos();
			InitMenuEntityInfos();
			InitMenuroleEntityInfos();
			InitRolesEntityInfos();
			InitThamsoEntityInfos();
			InitUsersEntityInfos();

			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits DmbophanEntity's FieldInfo objects</summary>
		private void InitDmbophanEntityInfos()
		{
			base.AddElementFieldInfo("DmbophanEntity", "Mabp", typeof(System.String), true, false, false, false,  (int)DmbophanFieldIndex.Mabp, 20, 0, 0);
			base.AddElementFieldInfo("DmbophanEntity", "Tenbophan", typeof(System.String), false, false, false, false,  (int)DmbophanFieldIndex.Tenbophan, 250, 0, 0);
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
			base.AddElementFieldInfo("DmchucvuEntity", "Macv", typeof(System.String), true, false, false, false,  (int)DmchucvuFieldIndex.Macv, 20, 0, 0);
			base.AddElementFieldInfo("DmchucvuEntity", "Tenchucvu", typeof(System.String), false, false, false, false,  (int)DmchucvuFieldIndex.Tenchucvu, 250, 0, 0);
		}
		/// <summary>Inits DmcongdoanEntity's FieldInfo objects</summary>
		private void InitDmcongdoanEntityInfos()
		{
			base.AddElementFieldInfo("DmcongdoanEntity", "Macd", typeof(System.String), true, false, false, false,  (int)DmcongdoanFieldIndex.Macd, 20, 0, 0);
			base.AddElementFieldInfo("DmcongdoanEntity", "Tencongdoan", typeof(System.String), false, false, false, false,  (int)DmcongdoanFieldIndex.Tencongdoan, 250, 0, 0);
			base.AddElementFieldInfo("DmcongdoanEntity", "Sothutucongdoan", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmcongdoanFieldIndex.Sothutucongdoan, 0, 0, 10);
		}
		/// <summary>Inits DmcongnhanEntity's FieldInfo objects</summary>
		private void InitDmcongnhanEntityInfos()
		{
			base.AddElementFieldInfo("DmcongnhanEntity", "Macn", typeof(System.String), true, false, false, false,  (int)DmcongnhanFieldIndex.Macn, 20, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Hovatencongnhan", typeof(System.String), false, false, false, false,  (int)DmcongnhanFieldIndex.Hovatencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Tencongnhan", typeof(System.String), false, false, false, false,  (int)DmcongnhanFieldIndex.Tencongnhan, 50, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Mabp", typeof(System.String), false, true, false, false,  (int)DmcongnhanFieldIndex.Mabp, 20, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Macv", typeof(System.String), false, true, false, false,  (int)DmcongnhanFieldIndex.Macv, 20, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Sodienthoai", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Sodienthoai, 100, 0, 0);
			base.AddElementFieldInfo("DmcongnhanEntity", "Tinhtrang", typeof(System.String), false, false, false, true,  (int)DmcongnhanFieldIndex.Tinhtrang, 100, 0, 0);
		}
		/// <summary>Inits DmdongmayEntity's FieldInfo objects</summary>
		private void InitDmdongmayEntityInfos()
		{
			base.AddElementFieldInfo("DmdongmayEntity", "Madm", typeof(System.String), true, true, false, false,  (int)DmdongmayFieldIndex.Madm, 20, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Tendongmay", typeof(System.String), false, false, false, false,  (int)DmdongmayFieldIndex.Tendongmay, 250, 0, 0);
			base.AddElementFieldInfo("DmdongmayEntity", "Macd", typeof(System.String), false, false, false, false,  (int)DmdongmayFieldIndex.Macd, 20, 0, 0);
		}
		/// <summary>Inits DmhangEntity's FieldInfo objects</summary>
		private void InitDmhangEntityInfos()
		{
			base.AddElementFieldInfo("DmhangEntity", "Masp", typeof(System.String), true, false, false, false,  (int)DmhangFieldIndex.Masp, 20, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tensp", typeof(System.String), false, false, false, false,  (int)DmhangFieldIndex.Tensp, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Makhach, 20, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Kichthuoc", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Kichthuoc, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Khoiluongmuc", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Khoiluongmuc, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Sohinh", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Sohinh, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Cautrucin", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Cautrucin, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Somau", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Somau, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Loaimuc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Loaimuc, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Kichthuoctruc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Kichthuoctruc, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Vitri", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Vitri, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Quycachdonggoi", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Quycachdonggoi, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Loaithung", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Loaithung, 100, 0, 0);
		}
		/// <summary>Inits DmkhachEntity's FieldInfo objects</summary>
		private void InitDmkhachEntityInfos()
		{
			base.AddElementFieldInfo("DmkhachEntity", "Makhach", typeof(System.String), true, false, false, false,  (int)DmkhachFieldIndex.Makhach, 20, 0, 0);
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
		}
		/// <summary>Inits DmmayEntity's FieldInfo objects</summary>
		private void InitDmmayEntityInfos()
		{
			base.AddElementFieldInfo("DmmayEntity", "Mamay", typeof(System.String), true, true, false, false,  (int)DmmayFieldIndex.Mamay, 20, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Tenmay", typeof(System.String), false, false, false, false,  (int)DmmayFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Madm", typeof(System.String), false, false, false, false,  (int)DmmayFieldIndex.Madm, 20, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Vitri", typeof(System.String), false, false, false, false,  (int)DmmayFieldIndex.Vitri, 250, 0, 0);
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
			base.AddElementFieldInfo("MenuEntity", "MenuId", typeof(System.String), true, false, false, false,  (int)MenuFieldIndex.MenuId, 20, 0, 0);
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
			base.AddElementFieldInfo("MenuroleEntity", "Menuid", typeof(System.String), true, true, false, false,  (int)MenuroleFieldIndex.Menuid, 20, 0, 0);
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
			base.AddElementFieldInfo("ThamsoEntity", "Mahieu", typeof(System.String), true, false, false, false,  (int)ThamsoFieldIndex.Mahieu, 20, 0, 0);
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




