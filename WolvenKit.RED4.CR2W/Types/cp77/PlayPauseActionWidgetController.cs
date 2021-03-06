using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayPauseActionWidgetController : NextPreviousActionWidgetController
	{
		private inkWidgetReference _playContainer;
		private CBool _isPlaying;

		[Ordinal(33)] 
		[RED("playContainer")] 
		public inkWidgetReference PlayContainer
		{
			get => GetProperty(ref _playContainer);
			set => SetProperty(ref _playContainer, value);
		}

		[Ordinal(34)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetProperty(ref _isPlaying);
			set => SetProperty(ref _isPlaying, value);
		}

		public PlayPauseActionWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
