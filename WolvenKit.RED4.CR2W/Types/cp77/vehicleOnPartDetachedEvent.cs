using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleOnPartDetachedEvent : redEvent
	{
		private CName _partName;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		public vehicleOnPartDetachedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
