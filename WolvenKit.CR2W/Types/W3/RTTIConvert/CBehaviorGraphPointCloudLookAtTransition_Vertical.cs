using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPointCloudLookAtTransition_Vertical : IBehaviorGraphPointCloudLookAtTransition_Vector
	{
		[RED("maxAngleDiffDeg")] 		public CFloat MaxAngleDiffDeg { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("minAngle")] 		public CFloat MinAngle { get; set;}

		[RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		[RED("curve")] 		public CPtr<CCurve> Curve { get; set;}

		public CBehaviorGraphPointCloudLookAtTransition_Vertical(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphPointCloudLookAtTransition_Vertical(cr2w);

	}
}