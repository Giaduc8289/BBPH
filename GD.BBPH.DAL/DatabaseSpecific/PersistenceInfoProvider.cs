///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, September 30, 2022 9:36:18 AM
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
			base.InitClass((15 + 0));
			InitDmbophanEntityMappings();
			InitDmcapmaEntityMappings();
			InitDmchucvuEntityMappings();
			InitDmcongdoanEntityMappings();
			InitDmcongnhanEntityMappings();
			InitDmdongmayEntityMappings();
			InitDmhangEntityMappings();
			InitDmkhachEntityMappings();
			InitDmmayEntityMappings();
			InitLogbackupEntityMappings();
			InitMenuEntityMappings();
			InitMenuroleEntityMappings();
			InitRolesEntityMappings();
			InitThamsoEntityMappings();
			InitUsersEntityMappings();

		}


		/// <summary>Inits DmbophanEntity's mappings</summary>
		private void InitDmbophanEntityMappings()
		{
			base.AddElementMapping( "DmbophanEntity", "BBPH", @"dbo", "dmbophan", 2 );
			base.AddElementFieldMapping( "DmbophanEntity", "Mabp", "Mabp", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmbophanEntity", "Tenbophan", "Tenbophan", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
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
			base.AddElementMapping( "DmchucvuEntity", "BBPH", @"dbo", "dmchucvu", 2 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Macv", "Macv", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmchucvuEntity", "Tenchucvu", "Tenchucvu", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits DmcongdoanEntity's mappings</summary>
		private void InitDmcongdoanEntityMappings()
		{
			base.AddElementMapping( "DmcongdoanEntity", "BBPH", @"dbo", "dmcongdoan", 3 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Macd", "Macd", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Tencongdoan", "Tencongdoan", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmcongdoanEntity", "Sothutucongdoan", "Sothutucongdoan", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
		}
		/// <summary>Inits DmcongnhanEntity's mappings</summary>
		private void InitDmcongnhanEntityMappings()
		{
			base.AddElementMapping( "DmcongnhanEntity", "BBPH", @"dbo", "dmcongnhan", 7 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Macn", "Macn", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Hovatencongnhan", "Hovatencongnhan", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Tencongnhan", "Tencongnhan", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Mabp", "Mabp", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Macv", "Macv", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Sodienthoai", "Sodienthoai", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "DmcongnhanEntity", "Tinhtrang", "Tinhtrang", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits DmdongmayEntity's mappings</summary>
		private void InitDmdongmayEntityMappings()
		{
			base.AddElementMapping( "DmdongmayEntity", "BBPH", @"dbo", "dmdongmay", 3 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Madm", "Madm", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Tendongmay", "Tendongmay", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmdongmayEntity", "Macd", "Macd", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits DmhangEntity's mappings</summary>
		private void InitDmhangEntityMappings()
		{
			base.AddElementMapping( "DmhangEntity", "BBPH", @"dbo", "dmhang", 14 );
			base.AddElementFieldMapping( "DmhangEntity", "Masp", "Masp", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmhangEntity", "Tensp", "Tensp", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmhangEntity", "Makhach", "Makhach", true, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmhangEntity", "Tenkhach", "Tenkhach", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "DmhangEntity", "Kichthuoc", "kichthuoc", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
			base.AddElementFieldMapping( "DmhangEntity", "Khoiluongmuc", "Khoiluongmuc", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "DmhangEntity", "Sohinh", "Sohinh", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "DmhangEntity", "Cautrucin", "Cautrucin", true, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "DmhangEntity", "Somau", "Somau", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 8 );
			base.AddElementFieldMapping( "DmhangEntity", "Loaimuc", "Loaimuc", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 9 );
			base.AddElementFieldMapping( "DmhangEntity", "Kichthuoctruc", "Kichthuoctruc", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "DmhangEntity", "Vitri", "Vitri", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 11 );
			base.AddElementFieldMapping( "DmhangEntity", "Quycachdonggoi", "Quycachdonggoi", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 12 );
			base.AddElementFieldMapping( "DmhangEntity", "Loaithung", "Loaithung", true, (int)SqlDbType.NVarChar, 100, 0, 0, false, "", null, typeof(System.String), 13 );
		}
		/// <summary>Inits DmkhachEntity's mappings</summary>
		private void InitDmkhachEntityMappings()
		{
			base.AddElementMapping( "DmkhachEntity", "BBPH", @"dbo", "dmkhach", 14 );
			base.AddElementFieldMapping( "DmkhachEntity", "Makhach", "Makhach", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
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
		}
		/// <summary>Inits DmmayEntity's mappings</summary>
		private void InitDmmayEntityMappings()
		{
			base.AddElementMapping( "DmmayEntity", "BBPH", @"dbo", "dmmay", 4 );
			base.AddElementFieldMapping( "DmmayEntity", "Mamay", "Mamay", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "DmmayEntity", "Tenmay", "Tenmay", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "DmmayEntity", "Madm", "Madm", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "DmmayEntity", "Vitri", "Vitri", false, (int)SqlDbType.NVarChar, 250, 0, 0, false, "", null, typeof(System.String), 3 );
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
		/// <summary>Inits MenuEntity's mappings</summary>
		private void InitMenuEntityMappings()
		{
			base.AddElementMapping( "MenuEntity", "BBPH", @"dbo", "Menu", 11 );
			base.AddElementFieldMapping( "MenuEntity", "MenuId", "MenuId", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
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
			base.AddElementFieldMapping( "MenuroleEntity", "Menuid", "Menuid", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MenuroleEntity", "Rolesid", "Rolesid", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
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
			base.AddElementFieldMapping( "ThamsoEntity", "Mahieu", "Mahieu", false, (int)SqlDbType.NVarChar, 20, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "ThamsoEntity", "Stt", "Stt", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ThamsoEntity", "Tenthamso", "Tenthamso", false, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "ThamsoEntity", "Giatri", "Giatri", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "ThamsoEntity", "Thaydoi", "Thaydoi", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "ThamsoEntity", "Kieudulieu", "Kieudulieu", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 5 );
			base.AddElementFieldMapping( "ThamsoEntity", "Ghichu", "Ghichu", true, (int)SqlDbType.NVarChar, 200, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "ThamsoEntity", "Loaithamso", "Loaithamso", true, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 7 );
			base.AddElementFieldMapping( "ThamsoEntity", "An", "An", true, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 8 );
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













