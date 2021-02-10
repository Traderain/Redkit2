using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemRecipe : CVariable
	{
		[Ordinal(0)]  [RED("targetItem")] public TweakDBID TargetItem { get; set; }
		[Ordinal(1)]  [RED("isHidden")] public CBool IsHidden { get; set; }
		[Ordinal(2)]  [RED("amount")] public CInt32 Amount { get; set; }

		public ItemRecipe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
