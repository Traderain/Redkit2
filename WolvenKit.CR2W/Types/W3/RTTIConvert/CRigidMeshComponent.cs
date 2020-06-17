using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CRigidMeshComponent : CStaticMeshComponent
	{
		[RED("motionType")] 		public EMotionType MotionType { get; set;}

		[RED("linearDamping")] 		public CFloat LinearDamping { get; set;}

		[RED("angularDamping")] 		public CFloat AngularDamping { get; set;}

		[RED("linearVelocityClamp")] 		public CFloat LinearVelocityClamp { get; set;}

		public CRigidMeshComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CRigidMeshComponent(cr2w);

	}
}