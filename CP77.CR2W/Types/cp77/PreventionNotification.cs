using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionNotification : GenericNotificationController
	{
		[Ordinal(9)]  [RED("bounty_data")] public CHandle<PreventionBountyViewData> Bounty_data { get; set; }
		[Ordinal(10)]  [RED("bountyTitleText")] public inkTextWidgetReference BountyTitleText { get; set; }
		[Ordinal(11)]  [RED("bountyAmountText")] public inkTextWidgetReference BountyAmountText { get; set; }

		public PreventionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
