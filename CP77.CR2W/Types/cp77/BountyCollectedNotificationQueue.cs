using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BountyCollectedNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("bountyNotification")] public CName BountyNotification { get; set; }

		public BountyCollectedNotificationQueue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
