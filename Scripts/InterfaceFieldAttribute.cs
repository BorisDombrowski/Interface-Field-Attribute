using UnityEngine;
using System;

/// <summary>
/// Mark an UnityEngine.Object field by this attribute to assign interface fields in inspector
/// </summary>
public class InterfaceFieldAttribute : PropertyAttribute
{
    public Type RequiredType { get; private set; }

    public InterfaceFieldAttribute(Type type)
    {
        RequiredType = type;
    }
}