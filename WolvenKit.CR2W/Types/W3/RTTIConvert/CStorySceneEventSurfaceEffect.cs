using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventSurfaceEffect : CStorySceneEvent
	{
		[RED("type")] 		public ESceneEventSurfacePostFXType Type { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[RED("durationTime")] 		public CFloat DurationTime { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		public CStorySceneEventSurfaceEffect(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventSurfaceEffect(cr2w);

	}
}