///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Thursday, October 20, 2022 4:00:47 PM
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
	/// <summary>Implements the static Relations variant for the entity: BaogiaH. </summary>
	public partial class BaogiaHRelations
	{
		/// <summary>CTor</summary>
		public BaogiaHRelations()
		{
		}

		/// <summary>Gets all relations of the BaogiaHEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BaogiaDEntityUsingSobaogia);

			toReturn.Add(this.DmkhachEntityUsingMakhach);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between BaogiaHEntity and BaogiaDEntity over the 1:n relation they have, using the relation between the fields:
		/// BaogiaH.Sobaogia - BaogiaD.Sobaogia
		/// </summary>
		public virtual IEntityRelation BaogiaDEntityUsingSobaogia
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BaogiaD" , true);
				relation.AddEntityFieldPair(BaogiaHFields.Sobaogia, BaogiaDFields.Sobaogia);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BaogiaHEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BaogiaDEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between BaogiaHEntity and DmkhachEntity over the m:1 relation they have, using the relation between the fields:
		/// BaogiaH.Makhach - Dmkhach.Makhach
		/// </summary>
		public virtual IEntityRelation DmkhachEntityUsingMakhach
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmkhach", false);
				relation.AddEntityFieldPair(DmkhachFields.Makhach, BaogiaHFields.Makhach);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmkhachEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BaogiaHEntity", true);
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
