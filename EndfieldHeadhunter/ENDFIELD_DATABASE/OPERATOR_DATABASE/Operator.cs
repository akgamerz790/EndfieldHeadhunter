using EndfieldHeadhunter.ENDFIELD_DATABASE.ART_DATABASE;
using EndfieldHeadhunter.ENDFIELD_DATABASE.CLASS_DATABASE;

namespace EndfieldHeadhunter
{
    public class Operator 
    {
        public string NAME { get; init; } = "";
        public int STARS { get; init; }
        public CLASS_TYPE.OperatorClass CLASS { get; init; }
        public ART.ElementType ELEMENT { get; init; }
        public string IMAGE_URL { get; init; } = "";
        
        public override string ToString() => 
            $"{NAME} ({STARS}★ {CLASS} {ELEMENT})";
    }

}
