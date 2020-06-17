using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4QuestDLCMounter : IGameplayDLCMounter
	{
		[RED("quest")] 		public CHandle<CQuest> Quest { get; set;}

		[RED("taintFact")] 		public CName TaintFact { get; set;}

		[RED("sceneVoiceTagsTableFilePath")] 		public CString SceneVoiceTagsTableFilePath { get; set;}

		[RED("questLevelsFilePath")] 		public CString QuestLevelsFilePath { get; set;}

		public CR4QuestDLCMounter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4QuestDLCMounter(cr2w);

	}
}