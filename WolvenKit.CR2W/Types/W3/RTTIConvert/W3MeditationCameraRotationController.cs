using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MeditationCameraRotationController : ICustomCameraScriptedPivotRotationController
	{
		[RED("fixedPitch")] 		public CFloat FixedPitch { get; set;}

		[RED("fixedYaw")] 		public CFloat FixedYaw { get; set;}

		[RED("fixedRoll")] 		public CFloat FixedRoll { get; set;}

		[RED("baseSmooth")] 		public CFloat BaseSmooth { get; set;}

		public W3MeditationCameraRotationController(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3MeditationCameraRotationController(cr2w);

	}
}