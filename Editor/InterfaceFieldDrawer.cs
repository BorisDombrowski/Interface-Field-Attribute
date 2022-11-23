using System.Linq;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(InterfaceFieldAttribute))]
public class InterfaceFieldDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        Debug.Log($"{property.name}  {property.type}");

        if (property.propertyType == SerializedPropertyType.ObjectReference)
        {            
            var attribute = this.attribute as InterfaceFieldAttribute;

            EditorGUI.BeginProperty(position, label, property);
            DrawPropertyAndAssignValue(attribute, position, property, label);
            EditorGUI.EndProperty();
        }
        else
        {
            Debug.Log(label.text);
        }
    }

    private void DrawPropertyAndAssignValue(InterfaceFieldAttribute attribute, Rect position, SerializedProperty property, GUIContent label)
    {
        var obj = EditorGUI.ObjectField(position, label, property.objectReferenceValue, typeof(Object), true);

        if (attribute.RequiredType.IsInstanceOfType(obj))
        {
            property.objectReferenceValue = obj;
        }
        else if (obj is GameObject go)
        {
            property.objectReferenceValue =
                go.GetComponents(attribute.RequiredType).FirstOrDefault() ??
                property.objectReferenceValue;
        }
    }
}