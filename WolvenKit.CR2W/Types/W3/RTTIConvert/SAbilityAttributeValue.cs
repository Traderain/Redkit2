using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAbilityAttributeValue : CVariable
	{
		[RED("valueAdditive")] 		public CFloat ValueAdditive { get; set;}

		[RED("valueMultiplicative")] 		public CFloat ValueMultiplicative { get; set;}

		[RED("valueBase")] 		public CFloat ValueBase { get; set;}

		public SAbilityAttributeValue(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAbilityAttributeValue(cr2w);

	}
}