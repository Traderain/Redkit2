using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskMultipleGameplayEventListenerDef : IBehTreeTaskDefinition
	{
		[RED("gameplayEventsArray", 2,0)] 		public CArray<CName> GameplayEventsArray { get; set;}

		[RED("validFor")] 		public CFloat ValidFor { get; set;}

		[RED("activeFor")] 		public CFloat ActiveFor { get; set;}

		public BTTaskMultipleGameplayEventListenerDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskMultipleGameplayEventListenerDef(cr2w);

	}
}