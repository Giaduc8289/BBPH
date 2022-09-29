///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, September 28, 2022 5:00:39 PM
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
	/// <summary>
	/// Factory class for IEntityField2 instances, used in IEntityFields2 instances.
	/// </summary>
	public partial class EntityFieldFactory
	{
		/// <summary> Private CTor, no instantiation possible.</summary>
		private EntityFieldFactory()
		{
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DmcapmaEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DmcapmaFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DmcapmaEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DmhangEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DmhangFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DmhangEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the DmkhachEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(DmkhachFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("DmkhachEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the LogbackupEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(LogbackupFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("LogbackupEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the MenuEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(MenuFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MenuEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the MenuroleEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(MenuroleFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MenuroleEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the RolesEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(RolesFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("RolesEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the ThamsoEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(ThamsoFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ThamsoEntity", (int)fieldIndex));
		}

		/// <summary> Creates a new IEntityField2 instance for usage in the EntityFields object for the UsersEntity. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField2 instance should be created</param>
		/// <returns>The IEntityField2 instance for the field specified in fieldIndex</returns>
		public static IEntityField2 Create(UsersFieldIndex fieldIndex)
		{
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("UsersEntity", (int)fieldIndex));
		}


		/// <summary>Creates a new IEntityField2 instance, which represents the field objectName.fieldName</summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField2 Create(string objectName, string fieldName)
        {
			return new EntityField2(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}
