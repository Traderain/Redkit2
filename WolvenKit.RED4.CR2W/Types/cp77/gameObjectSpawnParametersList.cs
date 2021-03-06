using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameObjectSpawnParametersList : gameObjectSpawnParameter
	{
		private CArray<CHandle<gameObjectSpawnParameter>> _parameterList;

		[Ordinal(0)] 
		[RED("parameterList")] 
		public CArray<CHandle<gameObjectSpawnParameter>> ParameterList
		{
			get => GetProperty(ref _parameterList);
			set => SetProperty(ref _parameterList, value);
		}

		public gameObjectSpawnParametersList(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
