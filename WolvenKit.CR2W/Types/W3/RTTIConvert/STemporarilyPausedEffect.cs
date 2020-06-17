using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STemporarilyPausedEffect : CVariable
	{
		[RED("buff")] 		public CHandle<CBaseGameplayEffect> Buff { get; set;}

		[RED("timeLeft")] 		public CFloat TimeLeft { get; set;}

		[RED("source")] 		public CName Source { get; set;}

		[RED("singleLock")] 		public CBool SingleLock { get; set;}

		[RED("useMaxDuration")] 		public CBool UseMaxDuration { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		public STemporarilyPausedEffect(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new STemporarilyPausedEffect(cr2w);

	}
}