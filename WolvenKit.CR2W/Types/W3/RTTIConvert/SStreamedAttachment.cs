using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStreamedAttachment : CVariable
	{
		[RED("parentName")] 		public CName ParentName { get; set;}

		[RED("parentClass")] 		public CName ParentClass { get; set;}

		[RED("childName")] 		public CName ChildName { get; set;}

		[RED("childClass")] 		public CName ChildClass { get; set;}

		[RED("data", 2,0)] 		public CByteArray Data { get; set;}

		public SStreamedAttachment(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SStreamedAttachment(cr2w);

	}
}