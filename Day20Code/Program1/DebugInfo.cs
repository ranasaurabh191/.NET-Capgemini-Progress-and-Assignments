[AttributeUsage(
    AttributeTarget.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Class|
    AttributeTargets.Assembly|
    AttributeTargets.Struct|
    AttributeTargets.Method|
    AttributeTargets.Method|

)]
public class DebugInfo:Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    private string message;
}

public DebugInfo(int bg,string dev,string d)
{
    
}