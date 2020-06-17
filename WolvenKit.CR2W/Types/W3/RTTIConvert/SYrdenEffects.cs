using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SYrdenEffects : CVariable
	{
		[RED("castEffect")] 		public CName CastEffect { get; set;}

		[RED("placeEffect")] 		public CName PlaceEffect { get; set;}

		[RED("shootEffect")] 		public CName ShootEffect { get; set;}

		[RED("activateEffect")] 		public CName ActivateEffect { get; set;}

		public SYrdenEffects(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SYrdenEffects(cr2w);

	}
}