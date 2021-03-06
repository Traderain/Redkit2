using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workTagNode : workIEntry
	{
		private CName _tag;

		[Ordinal(2)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		public workTagNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
