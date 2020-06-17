using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDashAttack : CExplorationStateSkatingDash
	{
		[RED("afterAttackTime")] 		public CFloat AfterAttackTime { get; set;}

		[RED("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[RED("afterAttackImpulse")] 		public CFloat AfterAttackImpulse { get; set;}

		public CExplorationStateSkatingDashAttack(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateSkatingDashAttack(cr2w);

	}
}