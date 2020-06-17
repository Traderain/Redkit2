using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CJobTreeNode : CObject
	{
		[RED("onEnterAction")] 		public CPtr<CJobAction> OnEnterAction { get; set;}

		[RED("onLeaveAction")] 		public CPtr<CJobAction> OnLeaveAction { get; set;}

		[RED("onFastLeaveAction")] 		public CPtr<CJobForceOutAction> OnFastLeaveAction { get; set;}

		[RED("childNodes", 2,0)] 		public CArray<CPtr<CJobTreeNode>> ChildNodes { get; set;}

		[RED("validCategories", 2,0)] 		public CArray<CName> ValidCategories { get; set;}

		[RED("selectionMode")] 		public EJobTreeNodeSelectionMode SelectionMode { get; set;}

		[RED("iterations")] 		public CUInt32 Iterations { get; set;}

		[RED("leftItem")] 		public CName LeftItem { get; set;}

		[RED("rightItem")] 		public CName RightItem { get; set;}

		[RED("looped")] 		public CBool Looped { get; set;}

		public CJobTreeNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CJobTreeNode(cr2w);

	}
}