using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannervehicleGameController : BaseChunkGameController
	{
		[Ordinal(3)]  [RED("vehicleNameCallbackID")] public CUInt32 VehicleNameCallbackID { get; set; }
		[Ordinal(4)]  [RED("vehicleManufacturerCallbackID")] public CUInt32 VehicleManufacturerCallbackID { get; set; }
		[Ordinal(5)]  [RED("vehicleProdYearsCallbackID")] public CUInt32 VehicleProdYearsCallbackID { get; set; }
		[Ordinal(6)]  [RED("vehicleDriveLayoutCallbackID")] public CUInt32 VehicleDriveLayoutCallbackID { get; set; }
		[Ordinal(7)]  [RED("vehicleHorsepowerCallbackID")] public CUInt32 VehicleHorsepowerCallbackID { get; set; }
		[Ordinal(8)]  [RED("vehicleMassCallbackID")] public CUInt32 VehicleMassCallbackID { get; set; }
		[Ordinal(9)]  [RED("vehicleStateCallbackID")] public CUInt32 VehicleStateCallbackID { get; set; }
		[Ordinal(10)]  [RED("vehicleInfoCallbackID")] public CUInt32 VehicleInfoCallbackID { get; set; }
		[Ordinal(11)]  [RED("isValidVehicleManufacturer")] public CBool IsValidVehicleManufacturer { get; set; }
		[Ordinal(12)]  [RED("isValidVehicleName")] public CBool IsValidVehicleName { get; set; }
		[Ordinal(13)]  [RED("isValidVehicleProdYears")] public CBool IsValidVehicleProdYears { get; set; }
		[Ordinal(14)]  [RED("isValidVehicleDriveLayout")] public CBool IsValidVehicleDriveLayout { get; set; }
		[Ordinal(15)]  [RED("isValidVehicleHorsepower")] public CBool IsValidVehicleHorsepower { get; set; }
		[Ordinal(16)]  [RED("isValidVehicleMass")] public CBool IsValidVehicleMass { get; set; }
		[Ordinal(17)]  [RED("isValidVehicleState")] public CBool IsValidVehicleState { get; set; }
		[Ordinal(18)]  [RED("isValidVehicleInfo")] public CBool IsValidVehicleInfo { get; set; }
		[Ordinal(19)]  [RED("vehicleNameText")] public inkTextWidgetReference VehicleNameText { get; set; }
		[Ordinal(20)]  [RED("vehicleManufacturer")] public inkImageWidgetReference VehicleManufacturer { get; set; }
		[Ordinal(21)]  [RED("vehicleProdYearsText")] public inkTextWidgetReference VehicleProdYearsText { get; set; }
		[Ordinal(22)]  [RED("vehicleDriveLayoutText")] public inkTextWidgetReference VehicleDriveLayoutText { get; set; }
		[Ordinal(23)]  [RED("vehicleHorsepowerText")] public inkTextWidgetReference VehicleHorsepowerText { get; set; }
		[Ordinal(24)]  [RED("vehicleMassText")] public inkTextWidgetReference VehicleMassText { get; set; }
		[Ordinal(25)]  [RED("vehicleStateText")] public inkTextWidgetReference VehicleStateText { get; set; }
		[Ordinal(26)]  [RED("vehicleInfoText")] public inkTextWidgetReference VehicleInfoText { get; set; }
		[Ordinal(27)]  [RED("vehicleNameHolder")] public inkWidgetReference VehicleNameHolder { get; set; }
		[Ordinal(28)]  [RED("vehicleProdYearsHolder")] public inkWidgetReference VehicleProdYearsHolder { get; set; }
		[Ordinal(29)]  [RED("vehicleDriveLayoutHolder")] public inkWidgetReference VehicleDriveLayoutHolder { get; set; }
		[Ordinal(30)]  [RED("vehicleHorsepowerHolder")] public inkWidgetReference VehicleHorsepowerHolder { get; set; }
		[Ordinal(31)]  [RED("vehicleMassHolder")] public inkWidgetReference VehicleMassHolder { get; set; }
		[Ordinal(32)]  [RED("vehicleStateHolder")] public inkWidgetReference VehicleStateHolder { get; set; }
		[Ordinal(33)]  [RED("vehicleInfoHolder")] public inkWidgetReference VehicleInfoHolder { get; set; }

		public ScannervehicleGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
