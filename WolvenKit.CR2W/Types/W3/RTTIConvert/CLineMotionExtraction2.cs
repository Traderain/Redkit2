using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLineMotionExtraction2 : IMotionExtraction
	{
		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("frames", 2,0)] 		public CArray<CFloat> Frames { get; set;}

		[RED("deltaTimes", 2,0)] 		public CByteArray DeltaTimes { get; set;}

		[RED("flags")] 		public CUInt8 Flags { get; set;}

		public CLineMotionExtraction2(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CLineMotionExtraction2(cr2w);

	}
}