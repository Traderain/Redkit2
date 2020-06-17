﻿
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleSystem : CResource
	{
		[RED("previewBackgroundColor")] public CColor PreviewBackgroundColor { get; set; }

		[RED("previewShowGrid")] public CBool PreviewShowGrid { get; set; }

		[RED("visibleThroughWalls")] public CBool VisibleThroughWalls { get; set; }

		[RED("prewarmingTime")] public CFloat PrewarmingTime { get; set; }

		[RED("emitters", 2, 0)] public CArray<CPtr<CParticleEmitter>> Emitters { get; set; }

		[RED("lods", 2, 0)] public CArray<SParticleSystemLODLevel> Lods { get; set; }

		[RED("autoHideDistance")] public CFloat AutoHideDistance { get; set; }

		[RED("autoHideRange")] public CFloat AutoHideRange { get; set; }

		[RED("renderingPlane")] public ERenderingPlane RenderingPlane { get; set; }

		

        public CParticleSystem(CR2WFile cr2w) : base(cr2w)
        {

				
        }



        public override CVariable Create(CR2WFile cr2w)
        {
            return new CParticleSystem(cr2w);
        }

    }
}
