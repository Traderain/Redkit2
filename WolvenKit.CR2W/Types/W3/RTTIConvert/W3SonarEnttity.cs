using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SonarEnttity : CEntity
	{
		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[RED("speedModifier")] 		public CFloat SpeedModifier { get; set;}

		[RED("stopHighlightAfter")] 		public CFloat StopHighlightAfter { get; set;}

		public W3SonarEnttity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SonarEnttity(cr2w);

	}
}