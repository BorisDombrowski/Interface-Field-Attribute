using UnityEngine;

/// <summary>
/// Mark an UnityEngine.Object field by this attribute to assign interface instances in inspector
/// </summary>
public class InterfaceField : PropertyAttribute
{
    public System.Type RequiredType { get; private set; }

    public InterfaceField(System.Type type)
    {
        RequiredType = type;
    }
}
