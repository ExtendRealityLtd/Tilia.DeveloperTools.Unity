# Class ObjectExtensions

Extended methods for the System.Object Type.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [GetValue(Object, String)]
  * [GetValue(Object, String, Int32)]

## Details

##### Inheritance

* System.Object
* ObjectExtensions

##### Inherited Members

System.Object.ToString()

System.Object.Equals(System.Object)

System.Object.Equals(System.Object, System.Object)

System.Object.ReferenceEquals(System.Object, System.Object)

System.Object.GetHashCode()

System.Object.GetType()

System.Object.MemberwiseClone()

##### Namespace

* [Tilia.DeveloperTools.Extension]

##### Syntax

```
public static class ObjectExtensions
```

### Methods

#### GetValue(Object, String)

Gets the value for the given property name.

##### Declaration

```
public static object GetValue(this object source, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source | The System.Object to retrieve from. |
| System.String | name | The name of the property to retrieve. |

##### Returns

| Type | Description |
| --- | --- |
| System.Object | The found value. |

#### GetValue(Object, String, Int32)

Gets the value for the given property name.

##### Declaration

```
public static object GetValue(this object source, string name, int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source | The System.Object to retrieve from. |
| System.String | name | The name of the property to retrieve. |
| System.Int32 | index | The index to retrieve the property from. |

##### Returns

| Type | Description |
| --- | --- |
| System.Object | The found value. |

[Tilia.DeveloperTools.Extension]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[GetValue(Object, String)]: #GetValueObject-String
[GetValue(Object, String, Int32)]: #GetValueObject-String-Int32
