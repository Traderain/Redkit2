using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCachedConnections : CVariable
	{
		[Ordinal(1)] [RED("socketId")] 		public CName SocketId { get; set;}

		[Ordinal(2)] [RED("blocks", 2,0)] 		public CArray<SBlockDesc> Blocks { get; set;}

		public SCachedConnections(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}