using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeSequenceCheckAvailabilityDefinition : CBehTreeNodeSequenceDefinition
	{
		[RED("continueSequenceOnChildFailure")] 		public CBool ContinueSequenceOnChildFailure { get; set;}

		[RED("updateCheckIsAvailable")] 		public CBool UpdateCheckIsAvailable { get; set;}

		[RED("updateCheckIsAvailFreq")] 		public CFloat UpdateCheckIsAvailFreq { get; set;}

		public CBehTreeNodeSequenceCheckAvailabilityDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeSequenceCheckAvailabilityDefinition(cr2w);

	}
}