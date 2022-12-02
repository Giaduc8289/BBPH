///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, December 2, 2022 10:08:05 AM
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
			toReturn.Add(this.KehoachghepEntityUsingMamay);
			toReturn.Add(this.KehoachinEntityUsingMamay);
			toReturn.Add(this.KehoachlocEntityUsingMamay);
			toReturn.Add(this.KehoachthoiEntityUsingMamay);
			toReturn.Add(this.KehoachtuaEntityUsingMamay);
			toReturn.Add(this.KetquaghepEntityUsingMamay);
			toReturn.Add(this.KetquahoanthienEntityUsingMamay);
			toReturn.Add(this.KetquainEntityUsingMamay);
			toReturn.Add(this.KetquathoiEntityUsingMamay);
			toReturn.Add(this.KetquatuaEntityUsingMamay);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KehoachghepEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Kehoachghep.Mamay
		/// </summary>
		public virtual IEntityRelation KehoachghepEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Kehoachghep" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KehoachghepFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KehoachghepEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KehoachinEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Kehoachin.Mamay
		/// </summary>
		public virtual IEntityRelation KehoachinEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Kehoachin" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KehoachinFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KehoachinEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KehoachlocEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Kehoachloc.Mamay
		/// </summary>
		public virtual IEntityRelation KehoachlocEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Kehoachloc" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KehoachlocFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KehoachlocEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KehoachthoiEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Kehoachthoi.Mamay
		/// </summary>
		public virtual IEntityRelation KehoachthoiEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Kehoachthoi" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KehoachthoiFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KehoachthoiEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KehoachtuaEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Kehoachtua.Mamay
		/// </summary>
		public virtual IEntityRelation KehoachtuaEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Kehoachtua" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KehoachtuaFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KehoachtuaEntity", false);
				return relation;
			}
		}

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

		/// <summary>Returns a new IEntityRelation object, between DmmayEntity and KetquahoanthienEntity over the 1:n relation they have, using the relation between the fields:
		/// Dmmay.Mamay - Ketquahoanthien.Mamay
		/// </summary>
		public virtual IEntityRelation KetquahoanthienEntityUsingMamay
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Ketquahoanthien" , true);
				relation.AddEntityFieldPair(DmmayFields.Mamay, KetquahoanthienFields.Mamay);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmmayEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KetquahoanthienEntity", false);
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



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
