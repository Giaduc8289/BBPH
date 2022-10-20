///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, October 21, 2022 5:42:35 AM
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
	/// <summary>Implements the static Relations variant for the entity: CtptmangD. </summary>
	public partial class CtptmangDRelations
	{
		/// <summary>CTor</summary>
		public CtptmangDRelations()
		{
		}

		/// <summary>Gets all relations of the CtptmangDEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.CtptmangHEntityUsingIdH);
			toReturn.Add(this.DmnguyenlieuEntityUsingManl);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between CtptmangDEntity and CtptmangHEntity over the m:1 relation they have, using the relation between the fields:
		/// CtptmangD.IdH - CtptmangH.Id
		/// </summary>
		public virtual IEntityRelation CtptmangHEntityUsingIdH
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CtptmangH", false);
				relation.AddEntityFieldPair(CtptmangHFields.Id, CtptmangDFields.IdH);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CtptmangHEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CtptmangDEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CtptmangDEntity and DmnguyenlieuEntity over the m:1 relation they have, using the relation between the fields:
		/// CtptmangD.Manl - Dmnguyenlieu.Manl
		/// </summary>
		public virtual IEntityRelation DmnguyenlieuEntityUsingManl
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmnguyenlieu", false);
				relation.AddEntityFieldPair(DmnguyenlieuFields.Manl, CtptmangDFields.Manl);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmnguyenlieuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CtptmangDEntity", true);
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
