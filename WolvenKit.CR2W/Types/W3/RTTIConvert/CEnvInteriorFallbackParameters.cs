using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvInteriorFallbackParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("colorAmbientMul")] 		public SSimpleCurve ColorAmbientMul { get; set;}

		[RED("colorReflectionLow")] 		public SSimpleCurve ColorReflectionLow { get; set;}

		[RED("colorReflectionMiddle")] 		public SSimpleCurve ColorReflectionMiddle { get; set;}

		[RED("colorReflectionHigh")] 		public SSimpleCurve ColorReflectionHigh { get; set;}

		public CEnvInteriorFallbackParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvInteriorFallbackParameters(cr2w);

	}
}