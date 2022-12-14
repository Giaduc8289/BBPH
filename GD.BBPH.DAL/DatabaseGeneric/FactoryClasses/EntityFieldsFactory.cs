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
				case GD.BBPH.DAL.EntityType.DmcapmaEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmcapmaEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmhangEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmhangEntity");
					break;
				case GD.BBPH.DAL.EntityType.DmkhachEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "DmkhachEntity");
					break;
				case GD.BBPH.DAL.EntityType.LogbackupEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "LogbackupEntity");
					break;
				case GD.BBPH.DAL.EntityType.MenuEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "MenuEntity");
					break;
				case GD.BBPH.DAL.EntityType.MenuroleEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "MenuroleEntity");
					break;
				case GD.BBPH.DAL.EntityType.RolesEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "RolesEntity");
					break;
				case GD.BBPH.DAL.EntityType.ThamsoEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "ThamsoEntity");
					break;
				case GD.BBPH.DAL.EntityType.UsersEntity:
					fieldsToReturn = fieldProvider.GetEntityFields(inheritanceProvider, "UsersEntity");
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
