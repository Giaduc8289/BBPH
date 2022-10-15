﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Saturday, October 15, 2022 9:21:22 AM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using GD.BBPH.DAL;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.FactoryClasses
{
	/// <summary>Generates IEntityFields2 instances for different kind of Entities.</summary>
	public partial class EntityFieldsFactory
	{
		/// <summary>Private CTor, no instantiation possible.</summary>
		private EntityFieldsFactory()
		{
		}

		/// <summary>General factory entrance method which will return an EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields2 instance requested</returns>
		public static IEntityFields2 CreateEntityFieldsObject(GD.BBPH.DAL.EntityType relatedEntityType)
		{
			IEntityFields2 fieldsToReturn=null;
			IInheritanceInfoProvider inheritanceProvider = InheritanceInfoProviderSingleton.GetInstance();
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			switch(relatedEntityType)
			{
				case GD.BBPH.DAL.EntityType.BaogiaDEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "BaogiaDEntity");
					break;
				case GD.BBPH.DAL.EntityType.BaogiaHEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "BaogiaHEntity");
					break;
				case GD.BBPH.DAL.EntityType.CongsuatmayEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "CongsuatmayEntity");
					break;
				case GD.BBPH.DAL.EntityType.CtptmangDEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "CtptmangDEntity");
					break;
				case GD.BBPH.DAL.EntityType.CtptmangHEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "CtptmangHEntity");
					break;
				case GD.BBPH.DAL.EntityType.DinhmucthoigianEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DinhmucthoigianEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmbophanEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmbophanEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmcapmaEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmcapmaEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmchucvuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmchucvuEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmchungloaiEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmchungloaiEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmcongdoanEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmcongdoanEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmcongnhanEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmcongnhanEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmdongmayEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmdongmayEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmhangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmhangEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmkhachEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmkhachEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmkhoEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmkhoEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmlydonhapxuatEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmlydonhapxuatEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmmangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmmangEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmmauEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmmauEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmmayEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmmayEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmnguyenlieuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmnguyenlieuEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmnhomnguyenlieuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmnhomnguyenlieuEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmnhomquycachEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmnhomquycachEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmquycachEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmquycachEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmtaikhoanEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmtaikhoanEntity");
					break;
				case GD.BBPH.DAL.EntityType.DonhangDEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DonhangDEntity");
					break;
				case GD.BBPH.DAL.EntityType.DonhangHEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DonhangHEntity");
					break;
				case GD.BBPH.DAL.EntityType.HangtralaiEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "HangtralaiEntity");
					break;
				case GD.BBPH.DAL.EntityType.KetquachiaEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "KetquachiaEntity");
					break;
				case GD.BBPH.DAL.EntityType.KetquaghepEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "KetquaghepEntity");
					break;
				case GD.BBPH.DAL.EntityType.KetquainEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "KetquainEntity");
					break;
				case GD.BBPH.DAL.EntityType.KetquainmauEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "KetquainmauEntity");
					break;
				case GD.BBPH.DAL.EntityType.KetquathoiEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "KetquathoiEntity");
					break;
				case GD.BBPH.DAL.EntityType.KetquatuaEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "KetquatuaEntity");
					break;
				case GD.BBPH.DAL.EntityType.LogbackupEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "LogbackupEntity");
					break;
				case GD.BBPH.DAL.EntityType.MaucuahangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "MaucuahangEntity");
					break;
				case GD.BBPH.DAL.EntityType.MenuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "MenuEntity");
					break;
				case GD.BBPH.DAL.EntityType.MenuroleEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "MenuroleEntity");
					break;
				case GD.BBPH.DAL.EntityType.NhapkhomangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "NhapkhomangEntity");
					break;
				case GD.BBPH.DAL.EntityType.NhapkhonguyenlieuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "NhapkhonguyenlieuEntity");
					break;
				case GD.BBPH.DAL.EntityType.NhapkhosanphamEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "NhapkhosanphamEntity");
					break;
				case GD.BBPH.DAL.EntityType.PhieugiaohangDEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "PhieugiaohangDEntity");
					break;
				case GD.BBPH.DAL.EntityType.PhieugiaohangHEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "PhieugiaohangHEntity");
					break;
				case GD.BBPH.DAL.EntityType.RolesEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "RolesEntity");
					break;
				case GD.BBPH.DAL.EntityType.SodumangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SodumangEntity");
					break;
				case GD.BBPH.DAL.EntityType.SodunguyenlieuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SodunguyenlieuEntity");
					break;
				case GD.BBPH.DAL.EntityType.SodusanphamEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "SodusanphamEntity");
					break;
				case GD.BBPH.DAL.EntityType.ThamsoEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "ThamsoEntity");
					break;
				case GD.BBPH.DAL.EntityType.ThanhphanmauEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "ThanhphanmauEntity");
					break;
				case GD.BBPH.DAL.EntityType.TknguyenlieuthoiEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "TknguyenlieuthoiEntity");
					break;
				case GD.BBPH.DAL.EntityType.TruccuahangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "TruccuahangEntity");
					break;
				case GD.BBPH.DAL.EntityType.UsersEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "UsersEntity");
					break;
				case GD.BBPH.DAL.EntityType.XuatkhomangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "XuatkhomangEntity");
					break;
				case GD.BBPH.DAL.EntityType.XuatkhonguyenlieuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "XuatkhonguyenlieuEntity");
					break;
				case GD.BBPH.DAL.EntityType.XuatkhosanphamEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "XuatkhosanphamEntity");
					break;
			}
			return fieldsToReturn;
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			IFieldInfoProvider fieldProvider = FieldInfoProviderSingleton.GetInstance();
			return fieldProvider.GetEntityFieldsArray(entityName);
		}
		



		#region Included Code

		#endregion
	}
}
