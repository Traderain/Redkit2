using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CVariableValueStateTransitionCondition : IBehaviorStateTransitionCondition
	{
		[RED("compareValue")] 		public CFloat CompareValue { get; set;}

		[RED("compareFunc")] 		public ECompareFunc CompareFunc { get; set;}

		[RED("socketName")] 		public CName SocketName { get; set;}

		[RED("useAbsoluteValue")] 		public CBool UseAbsoluteValue { get; set;}

		[RED("cachedVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedVariableNode { get; set;}

		public CVariableValueStateTransitionCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CVariableValueStateTransitionCondition(cr2w);

	}
}