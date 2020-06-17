using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRotationControllerNode : CBehaviorGraphBaseNode
	{
		[RED("eventAllowRot")] 		public CName EventAllowRot { get; set;}

		[RED("continueUpdate")] 		public CBool ContinueUpdate { get; set;}

		[RED("cachedAngleVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleVariableNode { get; set;}

		[RED("cachedWeightVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightVariableNode { get; set;}

		public CBehaviorGraphRotationControllerNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphRotationControllerNode(cr2w);

	}
}