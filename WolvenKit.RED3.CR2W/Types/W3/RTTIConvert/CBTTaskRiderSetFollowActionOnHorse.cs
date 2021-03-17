using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskRiderSetFollowActionOnHorse : IBehTreeTask
	{
		[Ordinal(1)] [RED("horseFollowAction")] 		public CHandle<CAIFollowAction> HorseFollowAction { get; set;}

		[Ordinal(2)] [RED("riderData")] 		public CHandle<CAIStorageRiderData> RiderData { get; set;}

		public CBTTaskRiderSetFollowActionOnHorse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskRiderSetFollowActionOnHorse(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}