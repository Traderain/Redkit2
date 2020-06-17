using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintNodeFloorIKSixLegs : CBehaviorConstraintNodeFloorIKBase
	{
		[RED("usePerpendicularUprightWS")] 		public CFloat UsePerpendicularUprightWS { get; set;}

		[RED("upDirAdditionalWS")] 		public Vector UpDirAdditionalWS { get; set;}

		[RED("upDirUseFromLegsHitLocs")] 		public CFloat UpDirUseFromLegsHitLocs { get; set;}

		[RED("pelvis")] 		public SBehaviorConstraintNodeFloorIKVerticalBoneData Pelvis { get; set;}

		[RED("legs")] 		public SBehaviorConstraintNodeFloorIKLegsData Legs { get; set;}

		[RED("leftBackLegIK")] 		public STwoBonesIKSolverData LeftBackLegIK { get; set;}

		[RED("rightBackLegIK")] 		public STwoBonesIKSolverData RightBackLegIK { get; set;}

		[RED("leftMiddleLegIK")] 		public STwoBonesIKSolverData LeftMiddleLegIK { get; set;}

		[RED("rightMiddleLegIK")] 		public STwoBonesIKSolverData RightMiddleLegIK { get; set;}

		[RED("leftFrontLegIK")] 		public STwoBonesIKSolverData LeftFrontLegIK { get; set;}

		[RED("rightFrontLegIK")] 		public STwoBonesIKSolverData RightFrontLegIK { get; set;}

		public CBehaviorConstraintNodeFloorIKSixLegs(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorConstraintNodeFloorIKSixLegs(cr2w);

	}
}