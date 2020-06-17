using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDettlaffColumn : CNewNPC
	{
		[RED("requiredHits")] 		public CInt32 RequiredHits { get; set;}

		[RED("timeBetweenHits")] 		public CFloat TimeBetweenHits { get; set;}

		[RED("timeBetweenFireDamage")] 		public CFloat TimeBetweenFireDamage { get; set;}

		[RED("effectOnTakeDamage")] 		public CName EffectOnTakeDamage { get; set;}

		[RED("timeToDestroy")] 		public CFloat TimeToDestroy { get; set;}

		public CDettlaffColumn(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDettlaffColumn(cr2w);

	}
}