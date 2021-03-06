using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animAnimNode_MathExpressionFloat : animAnimNode_MathExpressionFloat_
    {
        private CString _expressionString;

        [Ordinal(999)]
        [RED("expressionString")]
        public CString ExpressionString
        {
            get => GetProperty(ref _expressionString);
            set => SetProperty(ref _expressionString, value);
        }

        public animAnimNode_MathExpressionFloat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
