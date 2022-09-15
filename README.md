# Interface-Field-Attribute
An attribute to assign interface instances in inspector.

## How to use
```
[InterfaceField(typeof(IExampleInterface))]
[SerializeField] private Object _interfaceField;
public IExampleInterface InterfaceProperty => _interfaceField as IExampleInterface;
```
Now you can assign to **_interfaceField** in inspector only object of **IExampleInterface** type.