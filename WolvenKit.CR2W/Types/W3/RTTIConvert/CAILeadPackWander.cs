using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAILeadPackWander : CAIDynamicWander
	{
		[RED("leaderRegroupEvent")] 		public CName LeaderRegroupEvent { get; set;}

		[RED("followers")] 		public CInt32 Followers { get; set;}

		[RED("canWanderRun")] 		public CBool CanWanderRun { get; set;}

		[RED("chanceToRun")] 		public CFloat ChanceToRun { get; set;}

		public CAILeadPackWander(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAILeadPackWander(cr2w);

	}
}