///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, September 30, 2022 9:36:17 AM
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
	/// <summary>Implements the static Relations variant for the entity: Dmcongnhan. </summary>
	public partial class DmcongnhanRelations
	{
		/// <summary>CTor</summary>
		public DmcongnhanRelations()
		{
		}

		/// <summary>Gets all relations of the DmcongnhanEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.DmbophanEntityUsingMabp);
			toReturn.Add(this.DmchucvuEntityUsingMacv);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between DmcongnhanEntity and DmbophanEntity over the m:1 relation they have, using the relation between the fields:
		/// Dmcongnhan.Mabp - Dmbophan.Mabp
		/// </summary>
		public virtual IEntityRelation DmbophanEntityUsingMabp
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmbophan", false);
				relation.AddEntityFieldPair(DmbophanFields.Mabp, DmcongnhanFields.Mabp);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmbophanEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmcongnhanEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between DmcongnhanEntity and DmchucvuEntity over the m:1 relation they have, using the relation between the fields:
		/// Dmcongnhan.Macv - Dmchucvu.Macv
		/// </summary>
		public virtual IEntityRelation DmchucvuEntityUsingMacv
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmchucvu", false);
				relation.AddEntityFieldPair(DmchucvuFields.Macv, DmcongnhanFields.Macv);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmchucvuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmcongnhanEntity", true);
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
