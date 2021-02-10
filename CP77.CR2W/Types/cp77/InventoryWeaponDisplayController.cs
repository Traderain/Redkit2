using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		[Ordinal(77)]  [RED("weaponSpecyficModsRoot")] public inkCompoundWidgetReference WeaponSpecyficModsRoot { get; set; }
		[Ordinal(78)]  [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }
		[Ordinal(79)]  [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(80)]  [RED("damageTypeIndicatorImage")] public inkImageWidgetReference DamageTypeIndicatorImage { get; set; }
		[Ordinal(81)]  [RED("dpsWrapper")] public inkWidgetReference DpsWrapper { get; set; }
		[Ordinal(82)]  [RED("dpsValue")] public inkTextWidgetReference DpsValue { get; set; }
		[Ordinal(83)]  [RED("silencerIcon")] public inkWidgetReference SilencerIcon { get; set; }
		[Ordinal(84)]  [RED("scopeIcon")] public inkWidgetReference ScopeIcon { get; set; }
		[Ordinal(85)]  [RED("dpsArrow")] public inkWidgetReference DpsArrow { get; set; }
		[Ordinal(86)]  [RED("weaponAttachmentsDisplay")] public CArray<wCHandle<InventoryItemPartDisplay>> WeaponAttachmentsDisplay { get; set; }

		public InventoryWeaponDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
