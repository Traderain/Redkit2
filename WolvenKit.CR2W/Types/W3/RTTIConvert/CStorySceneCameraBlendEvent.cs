using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneCameraBlendEvent : CStorySceneEventBlend
	{
		[RED("firstPointOfInterpolation")] 		public CFloat FirstPointOfInterpolation { get; set;}

		[RED("lastPointOfInterpolation")] 		public CFloat LastPointOfInterpolation { get; set;}

		[RED("firstPartInterpolation")] 		public ECameraInterpolation FirstPartInterpolation { get; set;}

		[RED("lastPartInterpolation")] 		public ECameraInterpolation LastPartInterpolation { get; set;}

		public CStorySceneCameraBlendEvent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneCameraBlendEvent(cr2w);

	}
}