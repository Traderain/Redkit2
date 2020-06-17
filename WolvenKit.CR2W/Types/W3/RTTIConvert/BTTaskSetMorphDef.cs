using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSetMorphDef : IBehTreeTaskDefinition
	{
		[RED("morphOnAnimEvent")] 		public CBool MorphOnAnimEvent { get; set;}

		[RED("time")] 		public CFloat Time { get; set;}

		[RED("ratio")] 		public CFloat Ratio { get; set;}

		[RED("morphOnActivate")] 		public CBool MorphOnActivate { get; set;}

		[RED("ratioOnActivate")] 		public CFloat RatioOnActivate { get; set;}

		[RED("timeOnActivate")] 		public CFloat TimeOnActivate { get; set;}

		[RED("morphOnDeactivate")] 		public CBool MorphOnDeactivate { get; set;}

		[RED("ratioOnDeactivate")] 		public CFloat RatioOnDeactivate { get; set;}

		[RED("timeOnDeactivate")] 		public CFloat TimeOnDeactivate { get; set;}

		public BTTaskSetMorphDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskSetMorphDef(cr2w);

	}
}