using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInventoryComponent : CComponent
	{
		[RED("containerTemplate")] 		public CHandle<CEntityTemplate> ContainerTemplate { get; set;}

		[RED("rebalanceEveryNSeconds")] 		public CUInt32 RebalanceEveryNSeconds { get; set;}

		[RED("turnOffSpawnItemsBudgeting")] 		public CBool TurnOffSpawnItemsBudgeting { get; set;}

		[RED("priceMult")] 		public CFloat PriceMult { get; set;}

		[RED("priceRepairMult")] 		public CFloat PriceRepairMult { get; set;}

		[RED("priceRepair")] 		public CFloat PriceRepair { get; set;}

		[RED("fundsType")] 		public EInventoryFundsType FundsType { get; set;}

		public CInventoryComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CInventoryComponent(cr2w);

	}
}