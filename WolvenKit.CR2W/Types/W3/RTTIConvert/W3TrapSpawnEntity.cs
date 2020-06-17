using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapSpawnEntity : W3Trap
	{
		[RED("spawnOnlyOnAreaEnter")] 		public CBool SpawnOnlyOnAreaEnter { get; set;}

		[RED("maxSpawns")] 		public CFloat MaxSpawns { get; set;}

		[RED("entityToSpawn")] 		public CHandle<CEntityTemplate> EntityToSpawn { get; set;}

		[RED("offsetVector")] 		public Vector OffsetVector { get; set;}

		[RED("excludedActorsTags", 2,0)] 		public CArray<CName> ExcludedActorsTags { get; set;}

		[RED("appearanceAfterFirstSpawn")] 		public CString AppearanceAfterFirstSpawn { get; set;}

		public W3TrapSpawnEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3TrapSpawnEntity(cr2w);

	}
}