using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimatedComponentPhysicsRepresentation : CObject
	{
		[RED("ragdoll")] 		public CHandle<CRagdoll> Ragdoll { get; set;}

		[RED("ragdollCollisionType")] 		public CPhysicalCollision RagdollCollisionType { get; set;}

		[RED("ragdollAlwaysEnabled")] 		public CBool RagdollAlwaysEnabled { get; set;}

		[RED("allowRagdollInCutscene")] 		public CBool AllowRagdollInCutscene { get; set;}

		public CAnimatedComponentPhysicsRepresentation(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimatedComponentPhysicsRepresentation(cr2w);

	}
}