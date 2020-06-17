using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBroadcastEventDef : IBehTreeTaskDefinition
	{
		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("lifetime")] 		public CFloat Lifetime { get; set;}

		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("broadcastInterval")] 		public CFloat BroadcastInterval { get; set;}

		[RED("recipientCount")] 		public CInt32 RecipientCount { get; set;}

		[RED("broadcastScene")] 		public CBool BroadcastScene { get; set;}

		[RED("skipInvoker")] 		public CBool SkipInvoker { get; set;}

		public CBTTaskBroadcastEventDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskBroadcastEventDef(cr2w);

	}
}