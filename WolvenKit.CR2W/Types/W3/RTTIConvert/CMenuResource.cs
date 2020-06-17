using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMenuResource : IGuiResource
	{
		[RED("menuClass")] 		public CName MenuClass { get; set;}

		[RED("menuFlashSwf")] 		public CSoft<CSwfResource> MenuFlashSwf { get; set;}

		[RED("layer")] 		public CUInt32 Layer { get; set;}

		[RED("menuDef")] 		public CPtr<CMenuDef> MenuDef { get; set;}

		public CMenuResource(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMenuResource(cr2w);

	}
}