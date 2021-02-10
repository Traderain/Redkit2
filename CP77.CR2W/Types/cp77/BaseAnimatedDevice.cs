using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDevice : InteractiveDevice
	{
		[Ordinal(84)]  [RED("openingSpeed")] public CFloat OpeningSpeed { get; set; }
		[Ordinal(85)]  [RED("closingSpeed")] public CFloat ClosingSpeed { get; set; }
		[Ordinal(86)]  [RED("animationController")] public CHandle<entAnimationControllerComponent> AnimationController { get; set; }
		[Ordinal(87)]  [RED("animFeature")] public CHandle<AnimFeature_RoadBlock> AnimFeature { get; set; }
		[Ordinal(88)]  [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }

		public BaseAnimatedDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
