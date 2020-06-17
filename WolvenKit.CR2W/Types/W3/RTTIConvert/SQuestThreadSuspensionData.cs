using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SQuestThreadSuspensionData : CVariable
	{
		[RED("scopeBlockGUID")] 		public CGUID ScopeBlockGUID { get; set;}

		[RED("scopeData", 154,0)] 		public CByteArray ScopeData { get; set;}

		public SQuestThreadSuspensionData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SQuestThreadSuspensionData(cr2w);

	}
}