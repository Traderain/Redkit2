using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIActionLoop : IAIActionTree
	{
		[RED("loopCount")] 		public CInt32 LoopCount { get; set;}

		[RED("loopedAction")] 		public CHandle<IAIActionTree> LoopedAction { get; set;}

		public CAIActionLoop(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIActionLoop(cr2w);

	}
}