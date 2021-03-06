using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaContextActivatedASTCD : audioAudioStateTransitionConditionData
	{
		private CName _areaMixingContext;

		[Ordinal(1)] 
		[RED("areaMixingContext")] 
		public CName AreaMixingContext
		{
			get => GetProperty(ref _areaMixingContext);
			set => SetProperty(ref _areaMixingContext, value);
		}

		public audioAmbientAreaContextActivatedASTCD(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
