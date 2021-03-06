using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_IntToFloatConverter : animAnimNode_FloatValue
	{
		private animIntLink _inputNode;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animIntLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		public animAnimNode_IntToFloatConverter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
