using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationContainerSRRef : CVariable
	{
		private CArray<scnRidAnimationContainerSRRefAnimContainer> _animations;

		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<scnRidAnimationContainerSRRefAnimContainer> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		public scnRidAnimationContainerSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}