using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineConsumableParameterInt : gamestateMachineActionParameterInt
	{
		private CBool _consumed;

		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetProperty(ref _consumed);
			set => SetProperty(ref _consumed, value);
		}

		public gamestateMachineConsumableParameterInt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
