using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRagdollNode : CBehaviorGraphBaseNode
	{
		[RED("allowToProvidePreRagdollPose")] 		public CBool AllowToProvidePreRagdollPose { get; set;}

		[RED("updateAndSampleInputIfPreRagdollWeightIsNonZero")] 		public CBool UpdateAndSampleInputIfPreRagdollWeightIsNonZero { get; set;}

		[RED("keepInFrozenRagdollPose")] 		public CBool KeepInFrozenRagdollPose { get; set;}

		[RED("switchToSwimming")] 		public CBool SwitchToSwimming { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("cachedRootBoneImpulseVariable")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedRootBoneImpulseVariable { get; set;}

		public CBehaviorGraphRagdollNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphRagdollNode(cr2w);

	}
}