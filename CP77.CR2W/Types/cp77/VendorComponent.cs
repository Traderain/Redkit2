using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("vendorTweakID")] public TweakDBID VendorTweakID { get; set; }
		[Ordinal(1)]  [RED("junkItemArray")] public CArray<JunkItemRecord> JunkItemArray { get; set; }
		[Ordinal(2)]  [RED("brandProcessingSFX")] public CName BrandProcessingSFX { get; set; }
		[Ordinal(3)]  [RED("itemFallSFX")] public CName ItemFallSFX { get; set; }

		public VendorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
