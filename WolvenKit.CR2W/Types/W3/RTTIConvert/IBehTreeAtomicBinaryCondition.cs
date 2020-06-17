using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBehTreeAtomicBinaryCondition : IBehTreeAtomicCondition
	{
		[RED("condition1")] 		public CPtr<IBehTreeAtomicCondition> Condition1 { get; set;}

		[RED("condition2")] 		public CPtr<IBehTreeAtomicCondition> Condition2 { get; set;}

		public IBehTreeAtomicBinaryCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new IBehTreeAtomicBinaryCondition(cr2w);

	}
}