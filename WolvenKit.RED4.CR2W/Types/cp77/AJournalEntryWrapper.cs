using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AJournalEntryWrapper : ABaseWrapper
	{
		private CInt32 _uniqueId;

		[Ordinal(0)] 
		[RED("UniqueId")] 
		public CInt32 UniqueId
		{
			get => GetProperty(ref _uniqueId);
			set => SetProperty(ref _uniqueId, value);
		}

		public AJournalEntryWrapper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
