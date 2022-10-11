///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Tuesday, October 11, 2022 11:43:59 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using GD.BBPH.DAL;
using GD.BBPH.DAL.FactoryClasses;
using GD.BBPH.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GD.BBPH.DAL.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: Dmkhach. </summary>
	public partial class DmkhachRelations
	{
		/// <summary>CTor</summary>
		public DmkhachRelations()
		{
		}

		/// <summary>Gets all relations of the DmkhachEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BaogiaHEntityUsingMakhach);
			toReturn.Add(this.DonhangHEntityUsingMakhach);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DmkhachEntity and BaogiaHEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmkhach.Makhach - BaogiaH.Makhach
		/// </summary>
		public virtual IEntityRelation BaogiaHEntityUsingMakhach
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BaogiaH" , true);
				relation.AddEntityFieldPair(DmkhachFields.Makhach, BaogiaHFields.Makhach);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmkhachEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BaogiaHEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmkhachEntity and DonhangHEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmkhach.Makhach - DonhangH.Makhach
		/// </summary>
		public virtual IEntityRelation DonhangHEntityUsingMakhach
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "DonhangH" , true);
				relation.AddEntityFieldPair(DmkhachFields.Makhach, DonhangHFields.Makhach);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmkhachEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DonhangHEntity", false);
				return relation;
			}
		}



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
