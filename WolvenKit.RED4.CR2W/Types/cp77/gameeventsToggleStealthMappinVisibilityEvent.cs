using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsToggleStealthMappinVisibilityEvent : redEvent
	{
		private CBool _show;

		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetProperty(ref _show);
			set => SetProperty(ref _show, value);
		}

		public gameeventsToggleStealthMappinVisibilityEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
