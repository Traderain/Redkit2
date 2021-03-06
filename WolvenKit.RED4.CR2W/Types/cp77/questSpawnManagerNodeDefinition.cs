using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CArray<questSpawnManagerNodeActionEntry> _actions;

		[Ordinal(2)] 
		[RED("actions")] 
		public CArray<questSpawnManagerNodeActionEntry> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}

		public questSpawnManagerNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
