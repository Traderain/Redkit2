using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphHorseNode : CBehaviorGraphBaseNode
	{
		[RED("cachedSpeedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedValueNode { get; set;}

		[RED("speedStep")] 		public CFloat SpeedStep { get; set;}

		[RED("slopeFBVar")] 		public CName SlopeFBVar { get; set;}

		[RED("slopeLRVar")] 		public CName SlopeLRVar { get; set;}

		[RED("firstBoneF")] 		public CString FirstBoneF { get; set;}

		[RED("secondBoneF")] 		public CString SecondBoneF { get; set;}

		[RED("thirdBoneF")] 		public CString ThirdBoneF { get; set;}

		[RED("endBoneF")] 		public CString EndBoneF { get; set;}

		[RED("hingeAxisF")] 		public EAxis HingeAxisF { get; set;}

		[RED("firstBoneB")] 		public CString FirstBoneB { get; set;}

		[RED("secondBoneB")] 		public CString SecondBoneB { get; set;}

		[RED("thirdBoneB")] 		public CString ThirdBoneB { get; set;}

		[RED("endBoneB")] 		public CString EndBoneB { get; set;}

		[RED("hingeAxisB")] 		public EAxis HingeAxisB { get; set;}

		[RED("root")] 		public CString Root { get; set;}

		[RED("pelvis")] 		public CString Pelvis { get; set;}

		[RED("axisRootFB")] 		public EAxis AxisRootFB { get; set;}

		[RED("axisRootLR")] 		public EAxis AxisRootLR { get; set;}

		[RED("headFirst")] 		public CString HeadFirst { get; set;}

		[RED("headSecond")] 		public CString HeadSecond { get; set;}

		[RED("headThird")] 		public CString HeadThird { get; set;}

		[RED("hingeAxisHead")] 		public EAxis HingeAxisHead { get; set;}

		[RED("walkFBP")] 		public SHorseStateOffsets WalkFBP { get; set;}

		[RED("trotFBP")] 		public SHorseStateOffsets TrotFBP { get; set;}

		[RED("gallopFBP")] 		public SHorseStateOffsets GallopFBP { get; set;}

		[RED("canterFBP")] 		public SHorseStateOffsets CanterFBP { get; set;}

		[RED("walkFBN")] 		public SHorseStateOffsets WalkFBN { get; set;}

		[RED("trotFBN")] 		public SHorseStateOffsets TrotFBN { get; set;}

		[RED("gallopFBN")] 		public SHorseStateOffsets GallopFBN { get; set;}

		[RED("canterFBN")] 		public SHorseStateOffsets CanterFBN { get; set;}

		[RED("walkLR")] 		public SHorseStateOffsets WalkLR { get; set;}

		[RED("trotLR")] 		public SHorseStateOffsets TrotLR { get; set;}

		[RED("gallopLR")] 		public SHorseStateOffsets GallopLR { get; set;}

		[RED("canterLR")] 		public SHorseStateOffsets CanterLR { get; set;}

		public CBehaviorGraphHorseNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphHorseNode(cr2w);

	}
}