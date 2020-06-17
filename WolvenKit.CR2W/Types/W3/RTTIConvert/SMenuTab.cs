using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMenuTab : CVariable
	{
		[RED("MenuName")] 		public CName MenuName { get; set;}

		[RED("MenuLabel")] 		public CString MenuLabel { get; set;}

		[RED("Visible")] 		public CBool Visible { get; set;}

		[RED("Enabled")] 		public CBool Enabled { get; set;}

		[RED("Restricted")] 		public CBool Restricted { get; set;}

		[RED("ParentMenu")] 		public CName ParentMenu { get; set;}

		[RED("MenuState")] 		public CName MenuState { get; set;}

		public SMenuTab(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SMenuTab(cr2w);

	}
}