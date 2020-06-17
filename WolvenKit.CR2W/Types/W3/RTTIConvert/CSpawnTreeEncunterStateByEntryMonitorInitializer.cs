using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnTreeEncunterStateByEntryMonitorInitializer : ISpawnTreeSpawnMonitorInitializer
	{
		[RED("counterType")] 		public EEncounterMonitorCounterType CounterType { get; set;}

		[RED("referenceValue")] 		public CInt32 ReferenceValue { get; set;}

		[RED("operator")] 		public EOperator Operator { get; set;}

		[RED("disableMonitorAfterTasksFinished")] 		public CBool DisableMonitorAfterTasksFinished { get; set;}

		[RED("factOnConditionMet")] 		public CString FactOnConditionMet { get; set;}

		[RED("ownerEncounterTasks", 2,0)] 		public CArray<SOwnerEncounterTaskParams> OwnerEncounterTasks { get; set;}

		[RED("externalEncounterTasks", 2,0)] 		public CArray<SExternalEncounterTaskParams> ExternalEncounterTasks { get; set;}

		public CSpawnTreeEncunterStateByEntryMonitorInitializer(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSpawnTreeEncunterStateByEntryMonitorInitializer(cr2w);

	}
}