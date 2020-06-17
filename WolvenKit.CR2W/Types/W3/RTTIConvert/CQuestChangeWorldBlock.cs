using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestChangeWorldBlock : CQuestGraphBlock
	{
		[RED("worldFilePath")] 		public CString WorldFilePath { get; set;}

		[RED("newWorld")] 		public CInt32 NewWorld { get; set;}

		[RED("loadingMovieName")] 		public CString LoadingMovieName { get; set;}

		[RED("targetTag")] 		public TagList TargetTag { get; set;}

		public CQuestChangeWorldBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestChangeWorldBlock(cr2w);

	}
}