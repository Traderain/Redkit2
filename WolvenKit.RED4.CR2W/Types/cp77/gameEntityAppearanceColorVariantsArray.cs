using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntityAppearanceColorVariantsArray : ISerializable
	{
		private CName _appearanceName;
		private CArray<CName> _colorVariants;

		[Ordinal(0)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get => GetProperty(ref _appearanceName);
			set => SetProperty(ref _appearanceName, value);
		}

		[Ordinal(1)] 
		[RED("colorVariants")] 
		public CArray<CName> ColorVariants
		{
			get => GetProperty(ref _colorVariants);
			set => SetProperty(ref _colorVariants, value);
		}

		public gameEntityAppearanceColorVariantsArray(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
