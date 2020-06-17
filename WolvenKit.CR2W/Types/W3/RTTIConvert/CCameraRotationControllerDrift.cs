using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCameraRotationControllerDrift : ICustomCameraScriptedPivotRotationController
	{
		[RED("fixedPitch")] 		public CFloat FixedPitch { get; set;}

		[RED("rollBase")] 		public CFloat RollBase { get; set;}

		[RED("rollExtraTurn")] 		public CFloat RollExtraTurn { get; set;}

		[RED("yawTotal")] 		public CFloat YawTotal { get; set;}

		[RED("blendSpeedRoll")] 		public CFloat BlendSpeedRoll { get; set;}

		[RED("blendSpeedYaw")] 		public CFloat BlendSpeedYaw { get; set;}

		public CCameraRotationControllerDrift(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCameraRotationControllerDrift(cr2w);

	}
}