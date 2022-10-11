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
	/// <summary>Implements the static Relations variant for the entity: Dmmay. </summary>
	public partial class DmmayRelations
	{
		/// <summary>CTor</summary>
		public DmmayRelations()
		{
		}

		/// <summary>Gets all relations of the DmmayEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.KetquaghepEntityUsingMamay);
			toReturn.Add(this.KetquainEntityUsingMamay);
			toReturn.Add(this.KetquathoiEntityUsingMamay);
			toReturn.Add(this.KetquatuaEntityUsingMamay);

			toReturn.Add(this.DmdongmayEntityUsingMadm);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KetquaghepEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Ketquaghep.Mamay
		/// </summary>
		public virtual IEntityRelation KetquaghepEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Ketquaghep" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KetquaghepFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KetquaghepEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KetquainEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Ketquain.Mamay
		/// </summary>
		public virtual IEntityRelation KetquainEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Ketquain" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KetquainFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KetquainEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KetquathoiEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Ketquathoi.Mamay
		/// </summary>
		public virtual IEntityRelation KetquathoiEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Ketquathoi" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KetquathoiFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KetquathoiEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KetquatuaEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Ketquatua.Mamay
		/// </summary>
		public virtual IEntityRelation KetquatuaEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Ketquatua" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KetquatuaFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KetquatuaEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and DmdongmayEntity over the m:1 relation they have, using the relation between the fields:
		/// Dmmay.Madm - Dmdongmay.Madm
		/// </summary>
		public virtual IEntityRelation DmdongmayEntityUsingMadm
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmdongmay", false);
				relation.AddEntityFieldPair(DmdongmayFields.Madm, DmmayFields.Madm);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmdongmayEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
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
