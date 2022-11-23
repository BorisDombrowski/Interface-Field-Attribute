# Interface-Field-Attribute
An attribute to assign interface instances in inspector.

## How to use
```
[InterfaceField(typeof(IExampleInterface))]
[SerializeField] private Object _interfaceField;
public IExampleInterface InterfaceProperty => _interfaceField as IExampleInterface;
```

```
[InterfaceField(typeof(IExampleInterface))]
[SerializeField] private List<Object> _interfaceList;
```

Now you can assign to **_interfaceField** in inspector only object of **IExampleInterface** type.

## Special thanks
[Nova GC](https://github.com/novagc) - for help with code
