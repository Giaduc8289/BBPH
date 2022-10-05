///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, October 5, 2022 3:24:51 PM
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
	/// <summary>Implements the static Relations variant for the entity: Dmdongmay. </summary>
	public partial class DmdongmayRelations
	{
		/// <summary>CTor</summary>
		public DmdongmayRelations()
		{
		}

		/// <summary>Gets all relations of the DmdongmayEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DmmayEntityUsingMadm);

			toReturn.Add(this.DmcongdoanEntityUsingMacd);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DmdongmayEntity and DmmayEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmdongmay.Madm - Dmmay.Madm
		/// </summary>
		public virtual IEntityRelation DmmayEntityUsingMadm
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Dmmay" , true);
				relation.AddEntityFieldPair(DmdongmayFields.Madm, DmmayFields.Madm);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmdongmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between DmdongmayEntity and DmcongdoanEntity over the m:1 relation they have, using the relation between the fields:
		/// Dmdongmay.Macd - Dmcongdoan.Macd
		/// </summary>
		public virtual IEntityRelation DmcongdoanEntityUsingMacd
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmcongdoan", false);
				relation.AddEntityFieldPair(DmcongdoanFields.Macd, DmdongmayFields.Macd);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmcongdoanEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmdongmayEntity", true);
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
