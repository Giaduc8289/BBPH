///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, October 27, 2022 10:17:26 AM
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
			base.InitClass( (58 + 0));
			InitBaogiaDEntityInfos();
			InitBaogiaHEntityInfos();
			InitCongsuatmayEntityInfos();
			InitCtptmangDEntityInfos();
			InitCtptmangHEntityInfos();
			InitDinhmucthoigianEntityInfos();
			InitDinhmucvattuEntityInfos();
			InitDmbophanEntityInfos();
			InitDmcapmaEntityInfos();
			InitDmchucvuEntityInfos();
			InitDmchungloaiEntityInfos();
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
			InitDmnhomdinhmucEntityInfos();
			InitDmnhomnguyenlieuEntityInfos();
			InitDmnhomquycachEntityInfos();
			InitDmquycachEntityInfos();
			InitDmtaikhoanEntityInfos();
			InitDonhangDEntityInfos();
			InitDonhangHEntityInfos();
			InitHangtralaiEntityInfos();
			InitKetquachiaEntityInfos();
			InitKetquaghepEntityInfos();
			InitKetquainEntityInfos();
			InitKetquainmauEntityInfos();
			InitKetquathanhphamEntityInfos();
			InitKetquathoiEntityInfos();
			InitKetquatuaEntityInfos();
			InitLogbackupEntityInfos();
			InitMaucuahangEntityInfos();
			InitMenuEntityInfos();
			InitMenuroleEntityInfos();
			InitNhapkhomangEntityInfos();
			InitNhapkhonguyenlieuEntityInfos();
			InitNhapkhosanphamEntityInfos();
			InitPhieugiaohangDEntityInfos();
			InitPhieugiaohangHEntityInfos();
			InitRolesEntityInfos();
			InitSodumangEntityInfos();
			InitSodunguyenlieuEntityInfos();
			InitSodusanphamEntityInfos();
			InitThamsoEntityInfos();
			InitThanhphanmauEntityInfos();
			InitTknguyenlieuthoiEntityInfos();
			InitTruccuahangEntityInfos();
			InitUsersEntityInfos();
			InitXuatkhomangEntityInfos();
			InitXuatkhonguyenlieuEntityInfos();
			InitXuatkhosanphamEntityInfos();

			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits BaogiaDEntity's FieldInfo objects</summary>
		private void InitBaogiaDEntityInfos()
		{
			base.AddElementFieldInfo("BaogiaDEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)BaogiaDFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("BaogiaDEntity", "Sobaogia", typeof(System.String), false, true, false, false,  (int)BaogiaDFieldIndex.Sobaogia, 50, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Masp", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Tensp", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Tensp, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Maspcuakhach", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Maspcuakhach, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Doday", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)BaogiaDFieldIndex.Doday, 0, 3, 20);
			base.AddElementFieldInfo("BaogiaDEntity", "Rong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)BaogiaDFieldIndex.Rong, 0, 3, 20);
			base.AddElementFieldInfo("BaogiaDEntity", "Dai", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)BaogiaDFieldIndex.Dai, 0, 3, 20);
			base.AddElementFieldInfo("BaogiaDEntity", "Trongluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)BaogiaDFieldIndex.Trongluong, 0, 3, 20);
			base.AddElementFieldInfo("BaogiaDEntity", "Loaimuc", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Loaimuc, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Cautrucin", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Cautrucin, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Tenqcdonggoi", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Tenqcdonggoi, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Tenqcloaithung", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Tenqcloaithung, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Tenqcthanhpham", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Tenqcthanhpham, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Mota", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Mota, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "DongiakhongVat", typeof(Nullable<System.Int32>), false, false, false, true,  (int)BaogiaDFieldIndex.DongiakhongVat, 0, 0, 10);
			base.AddElementFieldInfo("BaogiaDEntity", "DongiaVat", typeof(Nullable<System.Int32>), false, false, false, true,  (int)BaogiaDFieldIndex.DongiaVat, 0, 0, 10);
			base.AddElementFieldInfo("BaogiaDEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BaogiaDFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BaogiaDFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("BaogiaDEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)BaogiaDFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits BaogiaHEntity's FieldInfo objects</summary>
		private void InitBaogiaHEntityInfos()
		{
			base.AddElementFieldInfo("BaogiaHEntity", "Sobaogia", typeof(System.String), true, false, false, false,  (int)BaogiaHFieldIndex.Sobaogia, 50, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Ngaybaogia", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BaogiaHFieldIndex.Ngaybaogia, 0, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Ngayhieuluc", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BaogiaHFieldIndex.Ngayhieuluc, 0, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Makhach", typeof(System.String), false, true, false, false,  (int)BaogiaHFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Tenkhach", typeof(System.String), false, false, false, false,  (int)BaogiaHFieldIndex.Tenkhach, 100, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Noidung", typeof(System.String), false, false, false, true,  (int)BaogiaHFieldIndex.Noidung, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Phuongthuctt", typeof(System.String), false, false, false, true,  (int)BaogiaHFieldIndex.Phuongthuctt, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Diadiemgiao", typeof(System.String), false, false, false, true,  (int)BaogiaHFieldIndex.Diadiemgiao, 250, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BaogiaHFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)BaogiaHFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BaogiaHFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("BaogiaHEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)BaogiaHFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits CongsuatmayEntity's FieldInfo objects</summary>
		private void InitCongsuatmayEntityInfos()
		{
			base.AddElementFieldInfo("CongsuatmayEntity", "Macongsuat", typeof(System.String), true, false, false, false,  (int)CongsuatmayFieldIndex.Macongsuat, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Tencongsuat", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Tencongsuat, 250, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Mamay", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Madongmay", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Madongmay, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Macongdoan", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Macongdoan, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Khotu", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CongsuatmayFieldIndex.Khotu, 0, 3, 20);
			base.AddElementFieldInfo("CongsuatmayEntity", "Khoden", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CongsuatmayFieldIndex.Khoden, 0, 3, 20);
			base.AddElementFieldInfo("CongsuatmayEntity", "Chieudaitu", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CongsuatmayFieldIndex.Chieudaitu, 0, 3, 20);
			base.AddElementFieldInfo("CongsuatmayEntity", "Chieudaiden", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CongsuatmayFieldIndex.Chieudaiden, 0, 3, 20);
			base.AddElementFieldInfo("CongsuatmayEntity", "Dodaytu", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CongsuatmayFieldIndex.Dodaytu, 0, 3, 20);
			base.AddElementFieldInfo("CongsuatmayEntity", "Dodayden", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CongsuatmayFieldIndex.Dodayden, 0, 3, 20);
			base.AddElementFieldInfo("CongsuatmayEntity", "Tocdo", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CongsuatmayFieldIndex.Tocdo, 0, 3, 20);
			base.AddElementFieldInfo("CongsuatmayEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CongsuatmayFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)CongsuatmayFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Somauma", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Somauma, 2147483647, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Sohinhma", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Sohinhma, 2147483647, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Maloaimang", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Maloaimang, 2147483647, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Maqcthanhpham", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Maqcthanhpham, 2147483647, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Macautrucins", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Macautrucins, 2147483647, 0, 0);
			base.AddElementFieldInfo("CongsuatmayEntity", "Makhachs", typeof(System.String), false, false, false, true,  (int)CongsuatmayFieldIndex.Makhachs, 2147483647, 0, 0);
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
			base.AddElementFieldInfo("CtptmangDEntity", "Trongluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CtptmangDFieldIndex.Trongluong, 0, 3, 20);
			base.AddElementFieldInfo("CtptmangDEntity", "Tyle", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)CtptmangDFieldIndex.Tyle, 0, 3, 20);
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
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Madongmay", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Madongmay, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Macongdoan", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Macongdoan, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Dodaytu", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Dodaytu, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Dodayden", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Dodayden, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Khotu", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Khotu, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Khoden", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Khoden, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Chieudaitu", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Chieudaitu, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Chieudaiden", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Chieudaiden, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Somauma", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Somauma, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Sohinhma", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Sohinhma, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Maloaimang", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Maloaimang, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Maqcthanhpham", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Maqcthanhpham, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Dauca", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Dauca, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Daucuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Daucuon, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Doilenh", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Doilenh, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Lencuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Lencuon, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Xuongcuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Xuongcuon, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Thaythietbi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Thaythietbi, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Dungmay", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Dungmay, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DinhmucthoigianEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DinhmucthoigianFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DinhmucvattuEntity's FieldInfo objects</summary>
		private void InitDinhmucvattuEntityInfos()
		{
			base.AddElementFieldInfo("DinhmucvattuEntity", "Madinhmuc", typeof(System.String), true, false, false, false,  (int)DinhmucvattuFieldIndex.Madinhmuc, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Tendinhmuc", typeof(System.String), false, false, false, false,  (int)DinhmucvattuFieldIndex.Tendinhmuc, 250, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Manhom", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Manhom, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Tennhom", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Tennhom, 250, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Mamay", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Madongmay", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Madongmay, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Macongdoan", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Macongdoan, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Somauma", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Somauma, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Maloaimuc", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Maloaimuc, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Mamau", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Mamau, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Maloaimang", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Maloaimang, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Maqcthanhpham", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Maqcthanhpham, 2147483647, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Dinhmuc", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DinhmucvattuFieldIndex.Dinhmuc, 0, 3, 20);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DinhmucvattuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DinhmucvattuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DinhmucvattuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DinhmucvattuFieldIndex.Nguoisua, 50, 0, 0);
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
		/// <summary>Inits DmchungloaiEntity's FieldInfo objects</summary>
		private void InitDmchungloaiEntityInfos()
		{
			base.AddElementFieldInfo("DmchungloaiEntity", "Machungloai", typeof(System.String), true, false, false, false,  (int)DmchungloaiFieldIndex.Machungloai, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Tenchungloai", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Tenchungloai, 250, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Kichthuoc", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Kichthuoc, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Trongluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmchungloaiFieldIndex.Trongluong, 0, 3, 20);
			base.AddElementFieldInfo("DmchungloaiEntity", "Somau", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmchungloaiFieldIndex.Somau, 0, 0, 10);
			base.AddElementFieldInfo("DmchungloaiEntity", "Sohinh", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmchungloaiFieldIndex.Sohinh, 0, 0, 10);
			base.AddElementFieldInfo("DmchungloaiEntity", "Loaimuc", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Loaimuc, 250, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Ghichu", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Ghichu, 250, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmchungloaiFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmchungloaiFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Rong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmchungloaiFieldIndex.Rong, 0, 3, 20);
			base.AddElementFieldInfo("DmchungloaiEntity", "Dai", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmchungloaiFieldIndex.Dai, 0, 3, 20);
			base.AddElementFieldInfo("DmchungloaiEntity", "Somauma", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Somauma, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Sohinhma", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Sohinhma, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Maqcdonggoi", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Maqcdonggoi, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Tenqcdonggoi", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Tenqcdonggoi, 250, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Maqcloaithung", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Maqcloaithung, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Tenqcloaithung", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Tenqcloaithung, 250, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Maqcthanhpham", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Maqcthanhpham, 50, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Tenqcthanhpham", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Tenqcthanhpham, 250, 0, 0);
			base.AddElementFieldInfo("DmchungloaiEntity", "Maloaimuc", typeof(System.String), false, false, false, true,  (int)DmchungloaiFieldIndex.Maloaimuc, 50, 0, 0);
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
			base.AddElementFieldInfo("DmhangEntity", "Maspcuakhach", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Maspcuakhach, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Machungloai", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Machungloai, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenchungloai", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenchungloai, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Kichthuoc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Kichthuoc, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Trongluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Trongluong, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Sohinh", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Sohinh, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Somau", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DmhangFieldIndex.Somau, 0, 0, 10);
			base.AddElementFieldInfo("DmhangEntity", "Loaimuc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Loaimuc, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Khoiluongmuc", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Khoiluongmuc, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Cautrucin", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Cautrucin, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Mamang1", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Mamang1, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenmang1", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenmang1, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tlmanglop1", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Tlmanglop1, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Tlkeolop1", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Tlkeolop1, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Mamang2", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Mamang2, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenmang2", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenmang2, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tlmanglop2", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Tlmanglop2, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Tlkeolop2", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Tlkeolop2, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Dinhluongkeo", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Dinhluongkeo, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Kichthuoctruc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Kichthuoctruc, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Vitri", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Vitri, 100, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Maqcdonggoi", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Maqcdonggoi, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenqcdonggoi", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenqcdonggoi, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Maqcloaithung", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Maqcloaithung, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenqcloaithung", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenqcloaithung, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Maqcthanhpham", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Maqcthanhpham, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Tenqcthanhpham", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Tenqcthanhpham, 250, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmhangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmhangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Rong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Rong, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Dai", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Dai, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Somauma", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Somauma, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Sohinhma", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Sohinhma, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Maloaimuc", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Maloaimuc, 50, 0, 0);
			base.AddElementFieldInfo("DmhangEntity", "Doday", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmhangFieldIndex.Doday, 0, 3, 20);
			base.AddElementFieldInfo("DmhangEntity", "Macautrucin", typeof(System.String), false, false, false, true,  (int)DmhangFieldIndex.Macautrucin, 50, 0, 0);
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
			base.AddElementFieldInfo("DmmangEntity", "Kichthuoc", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Kichthuoc, 250, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Trongluong", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Trongluong, 250, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Mactpt", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Mactpt, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Doday", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmmangFieldIndex.Doday, 0, 3, 20);
			base.AddElementFieldInfo("DmmangEntity", "Rong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmmangFieldIndex.Rong, 0, 3, 20);
			base.AddElementFieldInfo("DmmangEntity", "Maloaimang", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Maloaimang, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Tenloaimang", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Tenloaimang, 250, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Maqcmang", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Maqcmang, 50, 0, 0);
			base.AddElementFieldInfo("DmmangEntity", "Tenqcmang", typeof(System.String), false, false, false, true,  (int)DmmangFieldIndex.Tenqcmang, 250, 0, 0);
		}
		/// <summary>Inits DmmauEntity's FieldInfo objects</summary>
		private void InitDmmauEntityInfos()
		{
			base.AddElementFieldInfo("DmmauEntity", "Mamau", typeof(System.String), true, false, false, false,  (int)DmmauFieldIndex.Mamau, 50, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Tenmau", typeof(System.String), false, false, false, false,  (int)DmmauFieldIndex.Tenmau, 250, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Lamaugoc", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DmmauFieldIndex.Lamaugoc, 0, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmauFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmmauFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmmauFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmmauFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("DmmauEntity", "MaArgb", typeof(Nullable<System.Int64>), false, false, false, true,  (int)DmmauFieldIndex.MaArgb, 0, 0, 19);
		}
		/// <summary>Inits DmmayEntity's FieldInfo objects</summary>
		private void InitDmmayEntityInfos()
		{
			base.AddElementFieldInfo("DmmayEntity", "Mamay", typeof(System.String), true, false, false, false,  (int)DmmayFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Tenmay", typeof(System.String), false, false, false, false,  (int)DmmayFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("DmmayEntity", "Madm", typeof(System.String), false, false, false, true,  (int)DmmayFieldIndex.Madm, 50, 0, 0);
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
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Gia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Gia, 0, 3, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Giahientai", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Giahientai, 0, 3, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Tang", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Tang, 0, 3, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Giam", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Giam, 0, 3, 20);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmnguyenlieuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmnguyenlieuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmnhomdinhmucEntity's FieldInfo objects</summary>
		private void InitDmnhomdinhmucEntityInfos()
		{
			base.AddElementFieldInfo("DmnhomdinhmucEntity", "Manhom", typeof(System.String), true, false, false, false,  (int)DmnhomdinhmucFieldIndex.Manhom, 50, 0, 0);
			base.AddElementFieldInfo("DmnhomdinhmucEntity", "Tennhom", typeof(System.String), false, false, false, true,  (int)DmnhomdinhmucFieldIndex.Tennhom, 250, 0, 0);
			base.AddElementFieldInfo("DmnhomdinhmucEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DmnhomdinhmucFieldIndex.Tenrutgon, 250, 0, 0);
			base.AddElementFieldInfo("DmnhomdinhmucEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnhomdinhmucFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmnhomdinhmucEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmnhomdinhmucFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmnhomdinhmucEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnhomdinhmucFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmnhomdinhmucEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmnhomdinhmucFieldIndex.Nguoisua, 50, 0, 0);
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
		/// <summary>Inits DmnhomquycachEntity's FieldInfo objects</summary>
		private void InitDmnhomquycachEntityInfos()
		{
			base.AddElementFieldInfo("DmnhomquycachEntity", "Manhom", typeof(System.String), true, false, false, false,  (int)DmnhomquycachFieldIndex.Manhom, 50, 0, 0);
			base.AddElementFieldInfo("DmnhomquycachEntity", "Tennhom", typeof(System.String), false, false, false, true,  (int)DmnhomquycachFieldIndex.Tennhom, 250, 0, 0);
			base.AddElementFieldInfo("DmnhomquycachEntity", "Tenrutgon", typeof(System.String), false, false, false, true,  (int)DmnhomquycachFieldIndex.Tenrutgon, 250, 0, 0);
			base.AddElementFieldInfo("DmnhomquycachEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnhomquycachFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmnhomquycachEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmnhomquycachFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmnhomquycachEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmnhomquycachFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmnhomquycachEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmnhomquycachFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DmquycachEntity's FieldInfo objects</summary>
		private void InitDmquycachEntityInfos()
		{
			base.AddElementFieldInfo("DmquycachEntity", "Maquycach", typeof(System.String), true, false, false, false,  (int)DmquycachFieldIndex.Maquycach, 50, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Tenquycach", typeof(System.String), false, false, false, false,  (int)DmquycachFieldIndex.Tenquycach, 250, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Macongdoan", typeof(System.String), false, false, false, true,  (int)DmquycachFieldIndex.Macongdoan, 50, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Tencongdoan", typeof(System.String), false, false, false, true,  (int)DmquycachFieldIndex.Tencongdoan, 250, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Manhom", typeof(System.String), false, false, false, true,  (int)DmquycachFieldIndex.Manhom, 50, 0, 0);
			base.AddElementFieldInfo("DmquycachEntity", "Tennhom", typeof(System.String), false, false, false, true,  (int)DmquycachFieldIndex.Tennhom, 250, 0, 0);
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
			base.AddElementFieldInfo("DmtaikhoanEntity", "Bactk", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Bactk, 250, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Tinhchattk", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Tinhchattk, 250, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Matkcha", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Matkcha, 50, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Trongbang", typeof(Nullable<System.Boolean>), false, false, false, true,  (int)DmtaikhoanFieldIndex.Trongbang, 0, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Doituongtd", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Doituongtd, 50, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Khoanmuctd", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Khoanmuctd, 50, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmtaikhoanFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DmtaikhoanFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DmtaikhoanEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DmtaikhoanFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DonhangDEntity's FieldInfo objects</summary>
		private void InitDonhangDEntityInfos()
		{
			base.AddElementFieldInfo("DonhangDEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)DonhangDFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("DonhangDEntity", "Madon", typeof(System.String), false, true, false, false,  (int)DonhangDFieldIndex.Madon, 50, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Ngaydat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangDFieldIndex.Ngaydat, 0, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Makhach", typeof(System.String), false, false, false, false,  (int)DonhangDFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Sobaogia", typeof(System.String), false, false, false, true,  (int)DonhangDFieldIndex.Sobaogia, 50, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Loaihang", typeof(Nullable<System.Int32>), false, false, false, true,  (int)DonhangDFieldIndex.Loaihang, 0, 0, 10);
			base.AddElementFieldInfo("DonhangDEntity", "Masp", typeof(System.String), false, false, false, true,  (int)DonhangDFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Tenhang", typeof(System.String), false, false, false, true,  (int)DonhangDFieldIndex.Tenhang, 250, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DonhangDFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("DonhangDEntity", "Dongia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)DonhangDFieldIndex.Dongia, 0, 3, 20);
			base.AddElementFieldInfo("DonhangDEntity", "Ngaygiao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangDFieldIndex.Ngaygiao, 0, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Ghichu", typeof(System.String), false, false, false, true,  (int)DonhangDFieldIndex.Ghichu, 250, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangDFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DonhangDFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangDFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DonhangDEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DonhangDFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits DonhangHEntity's FieldInfo objects</summary>
		private void InitDonhangHEntityInfos()
		{
			base.AddElementFieldInfo("DonhangHEntity", "Madon", typeof(System.String), true, false, false, false,  (int)DonhangHFieldIndex.Madon, 50, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Ngaydat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangHFieldIndex.Ngaydat, 0, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Makhach", typeof(System.String), false, true, false, false,  (int)DonhangHFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Tenkhach", typeof(System.String), false, false, false, false,  (int)DonhangHFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Sobaogia", typeof(System.String), false, false, false, true,  (int)DonhangHFieldIndex.Sobaogia, 50, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Ngaybaogia", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangHFieldIndex.Ngaybaogia, 0, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Userid", typeof(System.String), false, false, false, true,  (int)DonhangHFieldIndex.Userid, 50, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Tennv", typeof(System.String), false, false, false, true,  (int)DonhangHFieldIndex.Tennv, 250, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Ghichu", typeof(System.String), false, false, false, true,  (int)DonhangHFieldIndex.Ghichu, 250, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangHFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)DonhangHFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)DonhangHFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("DonhangHEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)DonhangHFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits HangtralaiEntity's FieldInfo objects</summary>
		private void InitHangtralaiEntityInfos()
		{
			base.AddElementFieldInfo("HangtralaiEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)HangtralaiFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("HangtralaiEntity", "Sophieugiao", typeof(System.String), false, false, false, false,  (int)HangtralaiFieldIndex.Sophieugiao, 50, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Ngaygiao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HangtralaiFieldIndex.Ngaygiao, 0, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Madon", typeof(System.String), false, false, false, false,  (int)HangtralaiFieldIndex.Madon, 50, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)HangtralaiFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)HangtralaiFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Ngaydat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HangtralaiFieldIndex.Ngaydat, 0, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Masp", typeof(System.String), false, false, false, false,  (int)HangtralaiFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Tenhang", typeof(System.String), false, false, false, true,  (int)HangtralaiFieldIndex.Tenhang, 250, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Soluonggiao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HangtralaiFieldIndex.Soluonggiao, 0, 3, 20);
			base.AddElementFieldInfo("HangtralaiEntity", "Soluongtralai", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)HangtralaiFieldIndex.Soluongtralai, 0, 3, 20);
			base.AddElementFieldInfo("HangtralaiEntity", "Ngaytra", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HangtralaiFieldIndex.Ngaytra, 0, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Nguyennhan", typeof(System.String), false, false, false, true,  (int)HangtralaiFieldIndex.Nguyennhan, 250, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HangtralaiFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)HangtralaiFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)HangtralaiFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("HangtralaiEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)HangtralaiFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits KetquachiaEntity's FieldInfo objects</summary>
		private void InitKetquachiaEntityInfos()
		{
			base.AddElementFieldInfo("KetquachiaEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)KetquachiaFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("KetquachiaEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquachiaFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Ca", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquachiaFieldIndex.Ca, 0, 0, 10);
			base.AddElementFieldInfo("KetquachiaEntity", "Mamay", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Lenh", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Lenh, 50, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Macongnhan", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Macongnhan, 50, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Tenmay", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Tencongnhan", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Tencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Dauraghep", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Dauraghep, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Sometvao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Sometvao, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Sokgvao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Sokgvao, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Socon", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquachiaFieldIndex.Socon, 0, 0, 10);
			base.AddElementFieldInfo("KetquachiaEntity", "Thoigianbatdau", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquachiaFieldIndex.Thoigianbatdau, 0, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Thoigianketthuc", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquachiaFieldIndex.Thoigianketthuc, 0, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Thoigianlencuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Thoigianlencuon, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Thoigianhacuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Thoigianhacuon, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Solanhacuon", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquachiaFieldIndex.Solanhacuon, 0, 0, 10);
			base.AddElementFieldInfo("KetquachiaEntity", "Thoigiancatdau", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Thoigiancatdau, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Thoigiandoilenh", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Thoigiandoilenh, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Thoigiansuco", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Thoigiansuco, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Phein", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Phein, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Pheghep", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Pheghep, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Phechia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Phechia, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "PhethoiNcc", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.PhethoiNcc, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Phesx", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Phesx, 0, 3, 20);
			base.AddElementFieldInfo("KetquachiaEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquachiaFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquachiaFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)KetquachiaFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("KetquachiaEntity", "Nangsuat", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquachiaFieldIndex.Nangsuat, 0, 3, 20);
		}
		/// <summary>Inits KetquaghepEntity's FieldInfo objects</summary>
		private void InitKetquaghepEntityInfos()
		{
			base.AddElementFieldInfo("KetquaghepEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)KetquaghepFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("KetquaghepEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquaghepFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Ca", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquaghepFieldIndex.Ca, 0, 0, 10);
			base.AddElementFieldInfo("KetquaghepEntity", "Mamay", typeof(System.String), false, true, false, true,  (int)KetquaghepFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Lenhghep", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Lenhghep, 50, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Macongnhan", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Macongnhan, 50, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Dauratua", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Dauratua, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "ManginMet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.ManginMet, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "ManginKg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.ManginKg, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "MangcapMet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.MangcapMet, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "MangcapKg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.MangcapKg, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Solopghep", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquaghepFieldIndex.Solopghep, 0, 0, 10);
			base.AddElementFieldInfo("KetquaghepEntity", "ThucteMet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.ThucteMet, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "ThucteKg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.ThucteKg, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Thoigianbatdau", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquaghepFieldIndex.Thoigianbatdau, 0, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Thoigianketthuc", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquaghepFieldIndex.Thoigianketthuc, 0, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Thoigianchuanbi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Thoigianchuanbi, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Thoigiansuco", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Thoigiansuco, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Thuctekeo", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Thuctekeo, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Thuctedongran", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Thuctedongran, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Thuctedungmoi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Thuctedungmoi, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Phein", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Phein, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Pheghep", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Pheghep, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "PheNcc", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.PheNcc, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "PheSx", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.PheSx, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Phethoi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Phethoi, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Pheintui", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Pheintui, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Phegheptui", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Phegheptui, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "PhethoiNcc", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.PhethoiNcc, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Phesxtui", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Phesxtui, 0, 3, 20);
			base.AddElementFieldInfo("KetquaghepEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquaghepFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquaghepFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Tenmay", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Tencongnhan", typeof(System.String), false, false, false, true,  (int)KetquaghepFieldIndex.Tencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("KetquaghepEntity", "Nangsuat", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquaghepFieldIndex.Nangsuat, 0, 3, 20);
		}
		/// <summary>Inits KetquainEntity's FieldInfo objects</summary>
		private void InitKetquainEntityInfos()
		{
			base.AddElementFieldInfo("KetquainEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)KetquainFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("KetquainEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquainFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Ca", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquainFieldIndex.Ca, 0, 0, 10);
			base.AddElementFieldInfo("KetquainEntity", "Mamay", typeof(System.String), false, true, false, true,  (int)KetquainFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Lenhin", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Lenhin, 50, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Macongnhan", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Macongnhan, 50, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "SometLsx", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.SometLsx, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Sometcap", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Sometcap, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Sokgcap", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Sokgcap, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Thuctein", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Thuctein, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Sokgin", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Sokgin, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Saihongthucte", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Saihongthucte, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Thoigianbatdau", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquainFieldIndex.Thoigianbatdau, 0, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Thoigianketthuc", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquainFieldIndex.Thoigianketthuc, 0, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Thoigianchuanbi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Thoigianchuanbi, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Thoigiansuco", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Thoigiansuco, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "PheNcc", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.PheNcc, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "PheSx", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.PheSx, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Tongm2dm", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Tongm2dm, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "M2saihongtt", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.M2saihongtt, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquainFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquainFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Tenmay", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Tencongnhan", typeof(System.String), false, false, false, true,  (int)KetquainFieldIndex.Tencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("KetquainEntity", "Nangsuat", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Nangsuat, 0, 3, 20);
			base.AddElementFieldInfo("KetquainEntity", "Tylesaihong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainFieldIndex.Tylesaihong, 0, 3, 20);
		}
		/// <summary>Inits KetquainmauEntity's FieldInfo objects</summary>
		private void InitKetquainmauEntityInfos()
		{
			base.AddElementFieldInfo("KetquainmauEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)KetquainmauFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("KetquainmauEntity", "KetquainId", typeof(Nullable<System.Int64>), false, false, false, true,  (int)KetquainmauFieldIndex.KetquainId, 0, 0, 19);
			base.AddElementFieldInfo("KetquainmauEntity", "Masp", typeof(System.String), false, false, false, false,  (int)KetquainmauFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("KetquainmauEntity", "Tensp", typeof(System.String), false, false, false, true,  (int)KetquainmauFieldIndex.Tensp, 250, 0, 0);
			base.AddElementFieldInfo("KetquainmauEntity", "Mamau", typeof(System.String), false, false, false, true,  (int)KetquainmauFieldIndex.Mamau, 50, 0, 0);
			base.AddElementFieldInfo("KetquainmauEntity", "Tenmau", typeof(System.String), false, false, false, true,  (int)KetquainmauFieldIndex.Tenmau, 250, 0, 0);
			base.AddElementFieldInfo("KetquainmauEntity", "Xuatdodang", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainmauFieldIndex.Xuatdodang, 0, 3, 20);
			base.AddElementFieldInfo("KetquainmauEntity", "Xuatnguyen", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainmauFieldIndex.Xuatnguyen, 0, 3, 20);
			base.AddElementFieldInfo("KetquainmauEntity", "Nhapdodang", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainmauFieldIndex.Nhapdodang, 0, 3, 20);
			base.AddElementFieldInfo("KetquainmauEntity", "Nhapnguyen", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquainmauFieldIndex.Nhapnguyen, 0, 3, 20);
			base.AddElementFieldInfo("KetquainmauEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquainmauFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("KetquainmauEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)KetquainmauFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("KetquainmauEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquainmauFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("KetquainmauEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)KetquainmauFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits KetquathanhphamEntity's FieldInfo objects</summary>
		private void InitKetquathanhphamEntityInfos()
		{
			base.AddElementFieldInfo("KetquathanhphamEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)KetquathanhphamFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Ca", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Ca, 0, 0, 10);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Mamay", typeof(System.String), false, true, false, true,  (int)KetquathanhphamFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "SoLsx", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.SoLsx, 50, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Macongnhan", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.Macongnhan, 50, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Tenmay", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Tencongnhan", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.Tencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "SoMetvao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.SoMetvao, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "SoKgvao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.SoKgvao, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Thoigianbatdau", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Thoigianbatdau, 0, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Thoigianketthuc", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Thoigianketthuc, 0, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Thoigianchuanbi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Thoigianchuanbi, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Thoigianhacuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Thoigianhacuon, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Thoigiancatdau", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Thoigiancatdau, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Thoigiansuco", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Thoigiansuco, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Dgnangsuat", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Dgnangsuat, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Dmtui", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Dmtui, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Ttetui", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Ttetui, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Kiemtra", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Kiemtra, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Phein", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Phein, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Pheghep", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Pheghep, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Phechia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Phechia, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Phebien", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Phebien, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Phethoi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Phethoi, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Phechinhmay", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Phechinhmay, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Phekhac", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Phekhac, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Titrongtui", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Titrongtui, 0, 3, 20);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)KetquathanhphamFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("KetquathanhphamEntity", "Socon", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquathanhphamFieldIndex.Socon, 0, 0, 10);
		}
		/// <summary>Inits KetquathoiEntity's FieldInfo objects</summary>
		private void InitKetquathoiEntityInfos()
		{
			base.AddElementFieldInfo("KetquathoiEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)KetquathoiFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("KetquathoiEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathoiFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Ca", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquathoiFieldIndex.Ca, 0, 0, 10);
			base.AddElementFieldInfo("KetquathoiEntity", "Mamay", typeof(System.String), false, true, false, true,  (int)KetquathoiFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Lenhthoi", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Lenhthoi, 50, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Mamang", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Mamang, 50, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Macongnhan", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Macongnhan, 50, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Tenmang", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Tenmang, 250, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Tenmay", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Tencongnhan", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Tencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Somet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathoiFieldIndex.Somet, 0, 3, 20);
			base.AddElementFieldInfo("KetquathoiEntity", "Sokg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathoiFieldIndex.Sokg, 0, 3, 20);
			base.AddElementFieldInfo("KetquathoiEntity", "Phelieuthucte", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathoiFieldIndex.Phelieuthucte, 0, 3, 20);
			base.AddElementFieldInfo("KetquathoiEntity", "Thoigianbatdau", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathoiFieldIndex.Thoigianbatdau, 0, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Thoigianketthuc", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathoiFieldIndex.Thoigianketthuc, 0, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Thoigianchuanbi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathoiFieldIndex.Thoigianchuanbi, 0, 3, 20);
			base.AddElementFieldInfo("KetquathoiEntity", "Thoigiansuco", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathoiFieldIndex.Thoigiansuco, 0, 3, 20);
			base.AddElementFieldInfo("KetquathoiEntity", "Chatluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathoiFieldIndex.Chatluong, 0, 3, 20);
			base.AddElementFieldInfo("KetquathoiEntity", "Nangsuat", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquathoiFieldIndex.Nangsuat, 0, 3, 20);
			base.AddElementFieldInfo("KetquathoiEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathoiFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquathoiFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("KetquathoiEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)KetquathoiFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits KetquatuaEntity's FieldInfo objects</summary>
		private void InitKetquatuaEntityInfos()
		{
			base.AddElementFieldInfo("KetquatuaEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)KetquatuaFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("KetquatuaEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquatuaFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Ca", typeof(Nullable<System.Int32>), false, false, false, true,  (int)KetquatuaFieldIndex.Ca, 0, 0, 10);
			base.AddElementFieldInfo("KetquatuaEntity", "Mamay", typeof(System.String), false, true, false, true,  (int)KetquatuaFieldIndex.Mamay, 50, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Lenhtua", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Lenhtua, 50, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Macongnhan", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Macongnhan, 50, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Daurain", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Daurain, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "SoMetvao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.SoMetvao, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "SoKgvao", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.SoKgvao, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "SoMetra", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.SoMetra, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "SoKgra", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.SoKgra, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Saihongthucte", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Saihongthucte, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Thoigianbatdau", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquatuaFieldIndex.Thoigianbatdau, 0, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Thoigianketthuc", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquatuaFieldIndex.Thoigianketthuc, 0, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Thoigianhacuon", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Thoigianhacuon, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Thoigiancatdau", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Thoigiancatdau, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Thoigiandoilenh", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Thoigiandoilenh, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Thoigiansuco", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Thoigiansuco, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Phein", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Phein, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Pheghep", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Pheghep, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Phethoi", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Phethoi, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Phesx", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Phesx, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquatuaFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)KetquatuaFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Tenmay", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Tenmay, 250, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Tencongnhan", typeof(System.String), false, false, false, true,  (int)KetquatuaFieldIndex.Tencongnhan, 250, 0, 0);
			base.AddElementFieldInfo("KetquatuaEntity", "Nangsuat", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Nangsuat, 0, 3, 20);
			base.AddElementFieldInfo("KetquatuaEntity", "Thoigiandauca", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)KetquatuaFieldIndex.Thoigiandauca, 0, 3, 20);
		}
		/// <summary>Inits LogbackupEntity's FieldInfo objects</summary>
		private void InitLogbackupEntityInfos()
		{
			base.AddElementFieldInfo("LogbackupEntity", "Mahieu", typeof(System.Int64), true, false, true, false,  (int)LogbackupFieldIndex.Mahieu, 0, 0, 19);
			base.AddElementFieldInfo("LogbackupEntity", "Nam", typeof(Nullable<System.Int32>), false, false, false, true,  (int)LogbackupFieldIndex.Nam, 0, 0, 10);
			base.AddElementFieldInfo("LogbackupEntity", "Duongdan", typeof(System.String), false, false, false, true,  (int)LogbackupFieldIndex.Duongdan, 250, 0, 0);
			base.AddElementFieldInfo("LogbackupEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)LogbackupFieldIndex.Ngay, 0, 0, 0);
		}
		/// <summary>Inits MaucuahangEntity's FieldInfo objects</summary>
		private void InitMaucuahangEntityInfos()
		{
			base.AddElementFieldInfo("MaucuahangEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)MaucuahangFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("MaucuahangEntity", "Masp", typeof(System.String), false, false, false, false,  (int)MaucuahangFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Tensp", typeof(System.String), false, false, false, true,  (int)MaucuahangFieldIndex.Tensp, 250, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Mamau", typeof(System.String), false, false, false, true,  (int)MaucuahangFieldIndex.Mamau, 50, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Tenmau", typeof(System.String), false, false, false, true,  (int)MaucuahangFieldIndex.Tenmau, 250, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Klmau", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)MaucuahangFieldIndex.Klmau, 0, 3, 20);
			base.AddElementFieldInfo("MaucuahangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)MaucuahangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)MaucuahangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)MaucuahangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)MaucuahangFieldIndex.Nguoisua, 50, 0, 0);
			base.AddElementFieldInfo("MaucuahangEntity", "Tylebaophu", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)MaucuahangFieldIndex.Tylebaophu, 0, 3, 20);
			base.AddElementFieldInfo("MaucuahangEntity", "MaArgb", typeof(Nullable<System.Int64>), false, false, false, true,  (int)MaucuahangFieldIndex.MaArgb, 0, 0, 19);
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
		/// <summary>Inits NhapkhomangEntity's FieldInfo objects</summary>
		private void InitNhapkhomangEntityInfos()
		{
			base.AddElementFieldInfo("NhapkhomangEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)NhapkhomangFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("NhapkhomangEntity", "Ngaynhap", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhomangFieldIndex.Ngaynhap, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Makho", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Mamang", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Mamang, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Tenmang", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Tenmang, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Somet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)NhapkhomangFieldIndex.Somet, 0, 3, 20);
			base.AddElementFieldInfo("NhapkhomangEntity", "Sokg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)NhapkhomangFieldIndex.Sokg, 0, 3, 20);
			base.AddElementFieldInfo("NhapkhomangEntity", "Malydo", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Malydo, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Tenlydo", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Tenlydo, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Lenhsx", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Lenhsx, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Sohopdongmua", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Sohopdongmua, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhomangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhomangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhomangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)NhapkhomangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits NhapkhonguyenlieuEntity's FieldInfo objects</summary>
		private void InitNhapkhonguyenlieuEntityInfos()
		{
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)NhapkhonguyenlieuFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Ngaynhap", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Ngaynhap, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Makho", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Manguyenlieu", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Manguyenlieu, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Tennguyenlieu", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Tennguyenlieu, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Donvitinh", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Donvitinh, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Malydo", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Malydo, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Tenlydo", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Tenlydo, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Sohopdongmua", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Sohopdongmua, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhonguyenlieuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)NhapkhonguyenlieuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits NhapkhosanphamEntity's FieldInfo objects</summary>
		private void InitNhapkhosanphamEntityInfos()
		{
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)NhapkhosanphamFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Ngaynhap", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Ngaynhap, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Makho", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Somet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Somet, 0, 3, 20);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Sokg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Sokg, 0, 3, 20);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Malydo", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Malydo, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Tenlydo", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Tenlydo, 250, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Lenhsx", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Lenhsx, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Sohopdongmua", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Sohopdongmua, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("NhapkhosanphamEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)NhapkhosanphamFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits PhieugiaohangDEntity's FieldInfo objects</summary>
		private void InitPhieugiaohangDEntityInfos()
		{
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)PhieugiaohangDFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Sophieu", typeof(System.String), false, true, false, false,  (int)PhieugiaohangDFieldIndex.Sophieu, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Ngaygiao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Ngaygiao, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Madon", typeof(System.String), false, false, false, false,  (int)PhieugiaohangDFieldIndex.Madon, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "DonchitietId", typeof(Nullable<System.Int64>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.DonchitietId, 0, 0, 19);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Ngaydat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Ngaydat, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Makhach", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Tenkhach", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Loaihang", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Loaihang, 250, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Masp", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Tenhang", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Tenhang, 250, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Dongia", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Dongia, 0, 3, 20);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Thanhtien", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Thanhtien, 0, 3, 20);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Ghichu", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Ghichu, 250, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangDEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)PhieugiaohangDFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits PhieugiaohangHEntity's FieldInfo objects</summary>
		private void InitPhieugiaohangHEntityInfos()
		{
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Sophieu", typeof(System.String), true, false, false, false,  (int)PhieugiaohangHFieldIndex.Sophieu, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Ngaygiao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Ngaygiao, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Madon", typeof(System.String), false, true, false, false,  (int)PhieugiaohangHFieldIndex.Madon, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Ngaydat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Ngaydat, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Makhach", typeof(System.String), false, false, false, false,  (int)PhieugiaohangHFieldIndex.Makhach, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Tenkhach", typeof(System.String), false, false, false, false,  (int)PhieugiaohangHFieldIndex.Tenkhach, 250, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Tongtien", typeof(Nullable<System.Int32>), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Tongtien, 0, 0, 10);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Vat", typeof(Nullable<System.Int32>), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Vat, 0, 0, 10);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Ghichu", typeof(System.String), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Ghichu, 250, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("PhieugiaohangHEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)PhieugiaohangHFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits RolesEntity's FieldInfo objects</summary>
		private void InitRolesEntityInfos()
		{
			base.AddElementFieldInfo("RolesEntity", "Rolesid", typeof(System.String), true, false, false, false,  (int)RolesFieldIndex.Rolesid, 50, 0, 0);
			base.AddElementFieldInfo("RolesEntity", "Rolesname", typeof(System.String), false, false, false, true,  (int)RolesFieldIndex.Rolesname, 50, 0, 0);
			base.AddElementFieldInfo("RolesEntity", "Description", typeof(System.String), false, false, false, true,  (int)RolesFieldIndex.Description, 200, 0, 0);
		}
		/// <summary>Inits SodumangEntity's FieldInfo objects</summary>
		private void InitSodumangEntityInfos()
		{
			base.AddElementFieldInfo("SodumangEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)SodumangFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("SodumangEntity", "Ngaykiemke", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodumangFieldIndex.Ngaykiemke, 0, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Makho", typeof(System.String), false, false, false, true,  (int)SodumangFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)SodumangFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Mamang", typeof(System.String), false, false, false, true,  (int)SodumangFieldIndex.Mamang, 50, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Tenmang", typeof(System.String), false, false, false, true,  (int)SodumangFieldIndex.Tenmang, 250, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Somet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SodumangFieldIndex.Somet, 0, 3, 20);
			base.AddElementFieldInfo("SodumangEntity", "Sokg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SodumangFieldIndex.Sokg, 0, 3, 20);
			base.AddElementFieldInfo("SodumangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodumangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)SodumangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodumangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("SodumangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)SodumangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits SodunguyenlieuEntity's FieldInfo objects</summary>
		private void InitSodunguyenlieuEntityInfos()
		{
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)SodunguyenlieuFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Ngaykiemke", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Ngaykiemke, 0, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Makho", typeof(System.String), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Manguyenlieu", typeof(System.String), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Manguyenlieu, 50, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Tennguyenlieu", typeof(System.String), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Tennguyenlieu, 250, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Donvitinh", typeof(System.String), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Donvitinh, 50, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("SodunguyenlieuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)SodunguyenlieuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits SodusanphamEntity's FieldInfo objects</summary>
		private void InitSodusanphamEntityInfos()
		{
			base.AddElementFieldInfo("SodusanphamEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)SodusanphamFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("SodusanphamEntity", "Ngaykiemke", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodusanphamFieldIndex.Ngaykiemke, 0, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Makho", typeof(System.String), false, false, false, true,  (int)SodusanphamFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)SodusanphamFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)SodusanphamFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)SodusanphamFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Somet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SodusanphamFieldIndex.Somet, 0, 3, 20);
			base.AddElementFieldInfo("SodusanphamEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SodusanphamFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("SodusanphamEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodusanphamFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)SodusanphamFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SodusanphamFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("SodusanphamEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)SodusanphamFieldIndex.Nguoisua, 50, 0, 0);
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
		/// <summary>Inits ThanhphanmauEntity's FieldInfo objects</summary>
		private void InitThanhphanmauEntityInfos()
		{
			base.AddElementFieldInfo("ThanhphanmauEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)ThanhphanmauFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Mamau", typeof(System.String), false, true, false, true,  (int)ThanhphanmauFieldIndex.Mamau, 50, 0, 0);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Tenmau", typeof(System.String), false, false, false, true,  (int)ThanhphanmauFieldIndex.Tenmau, 250, 0, 0);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Mausudung", typeof(System.String), false, false, false, true,  (int)ThanhphanmauFieldIndex.Mausudung, 50, 0, 0);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Tenmausudung", typeof(System.String), false, false, false, true,  (int)ThanhphanmauFieldIndex.Tenmausudung, 250, 0, 0);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Tyle", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ThanhphanmauFieldIndex.Tyle, 0, 3, 20);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ThanhphanmauFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)ThanhphanmauFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ThanhphanmauFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("ThanhphanmauEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)ThanhphanmauFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits TknguyenlieuthoiEntity's FieldInfo objects</summary>
		private void InitTknguyenlieuthoiEntityInfos()
		{
			base.AddElementFieldInfo("TknguyenlieuthoiEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)TknguyenlieuthoiFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("TknguyenlieuthoiEntity", "Ngay", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TknguyenlieuthoiFieldIndex.Ngay, 0, 0, 0);
			base.AddElementFieldInfo("TknguyenlieuthoiEntity", "Ca", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TknguyenlieuthoiFieldIndex.Ca, 0, 0, 10);
			base.AddElementFieldInfo("TknguyenlieuthoiEntity", "Manguyenlieu", typeof(System.String), false, false, false, true,  (int)TknguyenlieuthoiFieldIndex.Manguyenlieu, 50, 0, 0);
			base.AddElementFieldInfo("TknguyenlieuthoiEntity", "Tennguyenlieu", typeof(System.String), false, false, false, true,  (int)TknguyenlieuthoiFieldIndex.Tennguyenlieu, 250, 0, 0);
			base.AddElementFieldInfo("TknguyenlieuthoiEntity", "Klnhap", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)TknguyenlieuthoiFieldIndex.Klnhap, 0, 3, 20);
			base.AddElementFieldInfo("TknguyenlieuthoiEntity", "Klxuat", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)TknguyenlieuthoiFieldIndex.Klxuat, 0, 3, 20);
		}
		/// <summary>Inits TruccuahangEntity's FieldInfo objects</summary>
		private void InitTruccuahangEntityInfos()
		{
			base.AddElementFieldInfo("TruccuahangEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)TruccuahangFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("TruccuahangEntity", "Masp", typeof(System.String), false, false, false, false,  (int)TruccuahangFieldIndex.Masp, 50, 0, 0);
			base.AddElementFieldInfo("TruccuahangEntity", "Tensp", typeof(System.String), false, false, false, true,  (int)TruccuahangFieldIndex.Tensp, 250, 0, 0);
			base.AddElementFieldInfo("TruccuahangEntity", "Stttruc", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TruccuahangFieldIndex.Stttruc, 0, 0, 10);
			base.AddElementFieldInfo("TruccuahangEntity", "Matruc", typeof(System.String), false, false, false, true,  (int)TruccuahangFieldIndex.Matruc, 50, 0, 0);
			base.AddElementFieldInfo("TruccuahangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TruccuahangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("TruccuahangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)TruccuahangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("TruccuahangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TruccuahangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("TruccuahangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)TruccuahangFieldIndex.Nguoisua, 50, 0, 0);
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
		/// <summary>Inits XuatkhomangEntity's FieldInfo objects</summary>
		private void InitXuatkhomangEntityInfos()
		{
			base.AddElementFieldInfo("XuatkhomangEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)XuatkhomangFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("XuatkhomangEntity", "Ngayxuat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhomangFieldIndex.Ngayxuat, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Makho", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Mamang", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Mamang, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Tenmang", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Tenmang, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Somet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)XuatkhomangFieldIndex.Somet, 0, 3, 20);
			base.AddElementFieldInfo("XuatkhomangEntity", "Sokg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)XuatkhomangFieldIndex.Sokg, 0, 3, 20);
			base.AddElementFieldInfo("XuatkhomangEntity", "Malydo", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Malydo, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Tenlydo", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Tenlydo, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Lenhsx", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Lenhsx, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Sophieugiao", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Sophieugiao, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Madonhang", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Madonhang, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhomangFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhomangFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhomangEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)XuatkhomangFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits XuatkhonguyenlieuEntity's FieldInfo objects</summary>
		private void InitXuatkhonguyenlieuEntityInfos()
		{
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)XuatkhonguyenlieuFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Ngayxuat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Ngayxuat, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Makho", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Manguyenlieu", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Manguyenlieu, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Tennguyenlieu", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Tennguyenlieu, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Donvitinh", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Donvitinh, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Malydo", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Malydo, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Tenlydo", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Tenlydo, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Lenhxuat", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Lenhxuat, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhonguyenlieuEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)XuatkhonguyenlieuFieldIndex.Nguoisua, 50, 0, 0);
		}
		/// <summary>Inits XuatkhosanphamEntity's FieldInfo objects</summary>
		private void InitXuatkhosanphamEntityInfos()
		{
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Id", typeof(System.Int64), true, false, true, false,  (int)XuatkhosanphamFieldIndex.Id, 0, 0, 19);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Ngayxuat", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Ngayxuat, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Makho", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Makho, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Tenkho", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Tenkho, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Masanpham", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Masanpham, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Tensanpham", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Tensanpham, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Soluong", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Soluong, 0, 3, 20);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Somet", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Somet, 0, 3, 20);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Sokg", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Sokg, 0, 3, 20);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Malydo", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Malydo, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Tenlydo", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Tenlydo, 250, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Lenhsx", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Lenhsx, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Sophieugiao", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Sophieugiao, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Madonhang", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Madonhang, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Ngaytao", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Ngaytao, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Nguoitao", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Nguoitao, 50, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Ngaysua", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Ngaysua, 0, 0, 0);
			base.AddElementFieldInfo("XuatkhosanphamEntity", "Nguoisua", typeof(System.String), false, false, false, true,  (int)XuatkhosanphamFieldIndex.Nguoisua, 50, 0, 0);
		}
		
	}
}




