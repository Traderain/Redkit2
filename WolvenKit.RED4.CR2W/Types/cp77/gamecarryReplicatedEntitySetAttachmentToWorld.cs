using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamecarryReplicatedEntitySetAttachmentToWorld : netEntityAttachmentInterface
	{
		private Transform _localTransform;

		[Ordinal(1)] 
		[RED("localTransform")] 
		public Transform LocalTransform
		{
			get => GetProperty(ref _localTransform);
			set => SetProperty(ref _localTransform, value);
		}

		public gamecarryReplicatedEntitySetAttachmentToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}