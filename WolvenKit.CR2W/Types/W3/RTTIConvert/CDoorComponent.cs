using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDoorComponent : CInteractionComponent
	{
		[RED("initialState")] 		public EDoorState InitialState { get; set;}

		[RED("isTrapdoor")] 		public CBool IsTrapdoor { get; set;}

		[RED("doorsEnebled")] 		public CBool DoorsEnebled { get; set;}

		[RED("openName")] 		public CString OpenName { get; set;}

		[RED("closeName")] 		public CString CloseName { get; set;}

		public CDoorComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDoorComponent(cr2w);

	}
}