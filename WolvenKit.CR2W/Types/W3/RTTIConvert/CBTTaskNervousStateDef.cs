using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskNervousStateDef : IBehTreeTaskDefinition
	{
		[RED("callFromQuestOnly")] 		public CBool CallFromQuestOnly { get; set;}

		[RED("dangerRadius")] 		public CFloat DangerRadius { get; set;}

		[RED("rearingChance")] 		public CFloat RearingChance { get; set;}

		[RED("kickChance")] 		public CFloat KickChance { get; set;}

		public CBTTaskNervousStateDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskNervousStateDef(cr2w);

	}
}