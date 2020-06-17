using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BaitProjectile : W3BoltProjectile
	{
		[RED("foodSourceToGenerate")] 		public CHandle<CEntityTemplate> FoodSourceToGenerate { get; set;}

		[RED("addScentToCollidedActors")] 		public CBool AddScentToCollidedActors { get; set;}

		[RED("attractionDuration")] 		public CFloat AttractionDuration { get; set;}

		public W3BaitProjectile(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3BaitProjectile(cr2w);

	}
}