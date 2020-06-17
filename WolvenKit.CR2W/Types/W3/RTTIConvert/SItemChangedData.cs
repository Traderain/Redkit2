using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SItemChangedData : CVariable
	{
		[RED("itemName")] 		public CName ItemName { get; set;}

		[RED("quantity")] 		public CInt32 Quantity { get; set;}

		[RED("ids", 2,0)] 		public CArray<SItemUniqueId> Ids { get; set;}

		[RED("informGui")] 		public CBool InformGui { get; set;}

		public SItemChangedData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SItemChangedData(cr2w);

	}
}