using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListGameController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("entryList")] public inkVerticalPanelWidgetReference EntryList { get; set; }
		[Ordinal(8)]  [RED("scanPulse")] public inkCompoundWidgetReference ScanPulse { get; set; }
		[Ordinal(9)]  [RED("optionalHeader")] public inkWidgetReference OptionalHeader { get; set; }
		[Ordinal(10)]  [RED("toDoHeader")] public inkWidgetReference ToDoHeader { get; set; }
		[Ordinal(11)]  [RED("optionalList")] public inkVerticalPanelWidgetReference OptionalList { get; set; }
		[Ordinal(12)]  [RED("nonOptionalList")] public inkVerticalPanelWidgetReference NonOptionalList { get; set; }
		[Ordinal(13)]  [RED("entryControllers")] public CHandle<inkScriptDynArray> EntryControllers { get; set; }
		[Ordinal(14)]  [RED("scanPulseAnimProxy")] public CHandle<inkanimProxy> ScanPulseAnimProxy { get; set; }
		[Ordinal(15)]  [RED("stateChangesBlackboardId")] public CUInt32 StateChangesBlackboardId { get; set; }
		[Ordinal(16)]  [RED("trackedChangesBlackboardId")] public CUInt32 TrackedChangesBlackboardId { get; set; }
		[Ordinal(17)]  [RED("JournalWrapper")] public CHandle<JournalWrapper> JournalWrapper { get; set; }
		[Ordinal(18)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(19)]  [RED("optionalHeaderController")] public CHandle<QuestListHeaderLogicController> OptionalHeaderController { get; set; }
		[Ordinal(20)]  [RED("toDoHeaderController")] public CHandle<QuestListHeaderLogicController> ToDoHeaderController { get; set; }
		[Ordinal(21)]  [RED("lastNonOptionalObjective")] public CHandle<QuestObjectiveWrapper> LastNonOptionalObjective { get; set; }

		public QuestListGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
