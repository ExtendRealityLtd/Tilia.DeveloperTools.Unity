# Class SceneConsoleFacade

The public interface into the SceneConsole Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [collapseCounterColorString]
  * [collapseCounterDefaultInsertValue]
  * [collapseCounterDefaultReplaceValue]
  * [collapseCounterPattern]
  * [collapseCountMaskCharacter]
  * [currentBuffer]
  * [lastMessage]
  * [lineBuffer]
  * [newline]
  * [sizeMultiplier]
* [Properties]
  * [AssertMessage]
  * [CollapseCheckMark]
  * [CollapseCounter]
  * [CollapseLog]
  * [ConsoleOutput]
  * [ConsoleRect]
  * [ErrorMessage]
  * [ExceptionMessage]
  * [FontSize]
  * [InfoMessage]
  * [LineSeparator]
  * [ScrollWindow]
  * [WarningMessage]
* [Methods]
  * [ClearLog()]
  * [GetMessage(String, LogType)]
  * [HandleLog(String, String, LogType)]
  * [OnAfterCollapseCounterChange()]
  * [OnAfterCollapseLogChange()]
  * [OnDisable()]
  * [OnEnable()]

## Details

##### Inheritance

* System.Object
* SceneConsoleFacade

##### Namespace

* [Tilia.DeveloperTools.SceneConsole]

##### Syntax

```
public class SceneConsoleFacade : MonoBehaviour
```

### Fields

#### collapseCounterColorString

The string representation of the [CollapseCounter].

##### Declaration

```
protected string collapseCounterColorString
```

#### collapseCounterDefaultInsertValue

The default string to insert for the collapse counter.

##### Declaration

```
protected string collapseCounterDefaultInsertValue
```

#### collapseCounterDefaultReplaceValue

The default starting value for the collapse counter.

##### Declaration

```
protected const string collapseCounterDefaultReplaceValue = "1"
```

#### collapseCounterPattern

The pattern to match for capturing the existing collapse counter.

##### Declaration

```
protected Regex collapseCounterPattern
```

#### collapseCountMaskCharacter

A replacement character for the collapse counter.

##### Declaration

```
protected const string collapseCountMaskCharacter = "x"
```

#### currentBuffer

The current line buffer in use.

##### Declaration

```
protected int currentBuffer
```

#### lastMessage

The last log message.

##### Declaration

```
protected string lastMessage
```

#### lineBuffer

The specified line buffer.

##### Declaration

```
protected const int lineBuffer = 50
```

#### newline

The character to use for the line ending.

##### Declaration

```
protected const string newline = "\n"
```

#### sizeMultiplier

The size to multiply the output content elements by to improve font scaling.

##### Declaration

```
protected const float sizeMultiplier = 10F
```

### Properties

#### AssertMessage

The Color of the text for an assertion log message.

##### Declaration

```
public Color AssertMessage { get; set; }
```

#### CollapseCheckMark

The GameObject that holds the checkmark for the collapse state.

##### Declaration

```
public GameObject CollapseCheckMark { get; protected set; }
```

#### CollapseCounter

The Color of the text when counting collapsed messages.

##### Declaration

```
public Color CollapseCounter { get; set; }
```

#### CollapseLog

Determines whether to collapse same messages into one message in the log.

##### Declaration

```
public bool CollapseLog { get; set; }
```

#### ConsoleOutput

The Text element to output the console to.

##### Declaration

```
public Text ConsoleOutput { get; protected set; }
```

#### ConsoleRect

The output content RectTransform.

##### Declaration

```
public RectTransform ConsoleRect { get; protected set; }
```

#### ErrorMessage

The Color of the text for an error log message.

##### Declaration

```
public Color ErrorMessage { get; set; }
```

#### ExceptionMessage

The Color of the text for an exception log message.

##### Declaration

```
public Color ExceptionMessage { get; set; }
```

#### FontSize

The size of the font the log text is displayed in.

##### Declaration

```
public int FontSize { get; set; }
```

#### InfoMessage

The Color of the text for an info log message.

##### Declaration

```
public Color InfoMessage { get; set; }
```

#### LineSeparator

The System.String to use as a log line separator.

##### Declaration

```
public string LineSeparator { get; set; }
```

#### ScrollWindow

The console scrollable ScrollRect area.

##### Declaration

```
public ScrollRect ScrollWindow { get; protected set; }
```

#### WarningMessage

The Color of the text for a warning log message.

##### Declaration

```
public Color WarningMessage { get; set; }
```

### Methods

#### ClearLog()

Clears the current log view of all messages

##### Declaration

```
public virtual void ClearLog()
```

#### GetMessage(String, LogType)

Gets a rich text styled message for the given LogType.

##### Declaration

```
protected virtual string GetMessage(string message, LogType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | message | The message to style. |
| LogType | type | The LogType of the message. |

##### Returns

| Type | Description |
| --- | --- |
| System.String | A rich text styled message. |

#### HandleLog(String, String, LogType)

Digests the current Unity log stream and outputs it to the provided [ConsoleOutput]

##### Declaration

```
protected virtual void HandleLog(string message, string stackTrace, LogType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | message | The message from the log stream. |
| System.String | stackTrace | The stack-trace data from the log stream |
| LogType | type | The type of the given log message. |

#### OnAfterCollapseCounterChange()

Called after [CollapseCounter] has been changed.

##### Declaration

```
protected virtual void OnAfterCollapseCounterChange()
```

#### OnAfterCollapseLogChange()

Called after [CollapseLog] has been changed.

##### Declaration

```
protected virtual void OnAfterCollapseLogChange()
```

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

[Tilia.DeveloperTools.SceneConsole]: README.md
[CollapseCounter]: SceneConsoleFacade.md#CollapseCounter
[ConsoleOutput]: SceneConsoleFacade.md#ConsoleOutput
[CollapseCounter]: SceneConsoleFacade.md#CollapseCounter
[CollapseLog]: SceneConsoleFacade.md#CollapseLog
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[collapseCounterColorString]: #collapseCounterColorString
[collapseCounterDefaultInsertValue]: #collapseCounterDefaultInsertValue
[collapseCounterDefaultReplaceValue]: #collapseCounterDefaultReplaceValue
[collapseCounterPattern]: #collapseCounterPattern
[collapseCountMaskCharacter]: #collapseCountMaskCharacter
[currentBuffer]: #currentBuffer
[lastMessage]: #lastMessage
[lineBuffer]: #lineBuffer
[newline]: #newline
[sizeMultiplier]: #sizeMultiplier
[Properties]: #Properties
[AssertMessage]: #AssertMessage
[CollapseCheckMark]: #CollapseCheckMark
[CollapseCounter]: #CollapseCounter
[CollapseLog]: #CollapseLog
[ConsoleOutput]: #ConsoleOutput
[ConsoleRect]: #ConsoleRect
[ErrorMessage]: #ErrorMessage
[ExceptionMessage]: #ExceptionMessage
[FontSize]: #FontSize
[InfoMessage]: #InfoMessage
[LineSeparator]: #LineSeparator
[ScrollWindow]: #ScrollWindow
[WarningMessage]: #WarningMessage
[Methods]: #Methods
[ClearLog()]: #ClearLog
[GetMessage(String, LogType)]: #GetMessageString-LogType
[HandleLog(String, String, LogType)]: #HandleLogString-String-LogType
[OnAfterCollapseCounterChange()]: #OnAfterCollapseCounterChange
[OnAfterCollapseLogChange()]: #OnAfterCollapseLogChange
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
