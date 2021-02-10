using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HoloDevice : InteractiveDevice
	{
		[Ordinal(84)]  [RED("questFactName")] public CName QuestFactName { get; set; }

		public HoloDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
