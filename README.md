# Interface-Field-Attribute
An attribute to assign interface instances in inspector.

## How to use
```
[InterfaceField(typeof(IExsampleInterface))]
[SerializeField] private Object _interfaceField;
public IExsampleInterface InterfaceProperty => _interfaceField as IExsampleInterface;
```
Now you can assign to **_interfaceField** in inspector only object of **IExsampleInterface** type.