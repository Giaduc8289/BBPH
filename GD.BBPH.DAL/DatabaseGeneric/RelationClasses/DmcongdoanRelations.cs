﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the static Relations variant for the entity: Dmcongdoan. </summary>
	public partial class DmcongdoanRelations
	{
		/// <summary>CTor</summary>
		public DmcongdoanRelations()
		{
		}

		/// <summary>Gets all relations of the DmcongdoanEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();

			toReturn.Add(this.CongsuatmayEntityUsingMacs);
			toReturn.Add(this.DmdongmayEntityUsingMadm);
			toReturn.Add(this.DmquycachEntityUsingMaqc);

			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between DmcongdoanEntity and CongsuatmayEntity over the 1:1 relation they have, using the relation between the fields:
		/// Dmcongdoan.Macd - Congsuatmay.Macs
		/// </summary>
		public virtual IEntityRelation CongsuatmayEntityUsingMacs
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Congsuatmay", true);

				relation.AddEntityFieldPair(DmcongdoanFields.Macd, CongsuatmayFields.Macs);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmcongdoanEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CongsuatmayEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmcongdoanEntity and DmdongmayEntity over the 1:1 relation they have, using the relation between the fields:
		/// Dmcongdoan.Macd - Dmdongmay.Madm
		/// </summary>
		public virtual IEntityRelation DmdongmayEntityUsingMadm
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Dmdongmay", true);

				relation.AddEntityFieldPair(DmcongdoanFields.Macd, DmdongmayFields.Madm);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmcongdoanEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmdongmayEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between DmcongdoanEntity and DmquycachEntity over the 1:1 relation they have, using the relation between the fields:
		/// Dmcongdoan.Macd - Dmquycach.Maqc
		/// </summary>
		public virtual IEntityRelation DmquycachEntityUsingMaqc
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Dmquycach", true);

				relation.AddEntityFieldPair(DmcongdoanFields.Macd, DmquycachFields.Maqc);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmcongdoanEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmquycachEntity", false);
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
