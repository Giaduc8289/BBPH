///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, September 30, 2022 2:52:39 PM
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

			toReturn.Add(this.DmcongdoanEntityUsingMadm);
			toReturn.Add(this.DmmayEntityUsingMamay);

			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between DmdongmayEntity and DmcongdoanEntity over the 1:1 relation they have, using the relation between the fields:
		/// Dmdongmay.Madm - Dmcongdoan.Macd
		/// </summary>
		public virtual IEntityRelation DmcongdoanEntityUsingMadm
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Dmcongdoan", false);



				relation.AddEntityFieldPair(DmcongdoanFields.Macd, DmdongmayFields.Madm);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmcongdoanEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmdongmayEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmdongmayEntity and DmmayEntity over the 1:1 relation they have, using the relation between the fields:
		/// Dmdongmay.Madm - Dmmay.Mamay
		/// </summary>
		public virtual IEntityRelation DmmayEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Dmmay", true);

				relation.AddEntityFieldPair(DmdongmayFields.Madm, DmmayFields.Mamay);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmdongmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", false);
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
