///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Wednesday, November 16, 2022 10:18:25 AM
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
	/// <summary>Implements the static Relations variant for the entity: Dmnguyenlieu. </summary>
	public partial class DmnguyenlieuRelations
	{
		/// <summary>CTor</summary>
		public DmnguyenlieuRelations()
		{
		}

		/// <summary>Gets all relations of the DmnguyenlieuEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();


			toReturn.Add(this.DmnhomnguyenlieuEntityUsingManhom);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between DmnguyenlieuEntity and DmnhomnguyenlieuEntity over the m:1 relation they have, using the relation between the fields:
		/// Dmnguyenlieu.Manhom - Dmnhomnguyenlieu.Manhom
		/// </summary>
		public virtual IEntityRelation DmnhomnguyenlieuEntityUsingManhom
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Dmnhomnguyenlieu", false);
				relation.AddEntityFieldPair(DmnhomnguyenlieuFields.Manhom, DmnguyenlieuFields.Manhom);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmnhomnguyenlieuEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DmnguyenlieuEntity", true);
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
