using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(InterfaceField))]
public class InterfaceFieldDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.ObjectReference)
        {
            var attribute = this.attribute as InterfaceField;

            EditorGUI.BeginProperty(position, label, property);

            var obj = EditorGUI.ObjectField(position, label, property.objectReferenceValue, typeof(Object), true);
            if(attribute.RequiredType.IsInstanceOfType(obj))
            {
                property.objectReferenceValue = obj;
            }
            else if(obj is GameObject go)
            {
                property.objectReferenceValue =
                    go.GetComponents(attribute.RequiredType).FirstOrDefault() ??
                    property.objectReferenceValue;
            }

            EditorGUI.EndProperty();
        }
    }
}