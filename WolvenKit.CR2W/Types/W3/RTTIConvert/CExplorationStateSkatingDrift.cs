using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDrift : CExplorationStateAbstract
	{
		[RED("impulse")] 		public CFloat Impulse { get; set;}

		[RED("impulseSpeedMax")] 		public CFloat ImpulseSpeedMax { get; set;}

		[RED("sharpTurnTime")] 		public CFloat SharpTurnTime { get; set;}

		[RED("sharpTurnSpeed")] 		public CFloat SharpTurnSpeed { get; set;}

		[RED("holdTurnSpeed")] 		public CFloat HoldTurnSpeed { get; set;}

		[RED("chainTimeToDrift")] 		public CFloat ChainTimeToDrift { get; set;}

		[RED("timeEndingMax")] 		public CFloat TimeEndingMax { get; set;}

		[RED("behDriftRestart")] 		public CName BehDriftRestart { get; set;}

		[RED("behDriftEnd")] 		public CName BehDriftEnd { get; set;}

		[RED("behDriftLeftSide")] 		public CName BehDriftLeftSide { get; set;}

		public CExplorationStateSkatingDrift(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateSkatingDrift(cr2w);

	}
}