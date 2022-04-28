namespace Tilia.DeveloperTools.SceneConsole
{
    using System;
    using System.Text.RegularExpressions;
    using UnityEngine;
    using UnityEngine.UI;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface into the SceneConsole Prefab.
    /// </summary>
    public class SceneConsoleFacade : MonoBehaviour
    {
        #region Console Settings
        [Header("Console Settings")]
        [Tooltip("The size of the font the log text is displayed in.")]
        [SerializeField]
        private int fontSize = 10;
        /// <summary>
        /// The size of the font the log text is displayed in.
        /// </summary>
        public int FontSize
        {
            get
            {
                return fontSize;
            }
            set
            {
                fontSize = value;
            }
        }
        [Tooltip("The Color of the text for an info log message.")]
        [SerializeField]
        private Color infoMessage = Color.black;
        /// <summary>
        /// The <see cref="Color"/> of the text for an info log message.
        /// </summary>
        public Color InfoMessage
        {
            get
            {
                return infoMessage;
            }
            set
            {
                infoMessage = value;
            }
        }
        [Tooltip("The Color of the text for an assertion log message.")]
        [SerializeField]
        private Color assertMessage = Color.black;
        /// <summary>
        /// The <see cref="Color"/> of the text for an assertion log message.
        /// </summary>
        public Color AssertMessage
        {
            get
            {
                return assertMessage;
            }
            set
            {
                assertMessage = value;
            }
        }
        [Tooltip("The Color of the text for a warning log message.")]
        [SerializeField]
        private Color warningMessage = Color.yellow;
        /// <summary>
        /// The <see cref="Color"/> of the text for a warning log message.
        /// </summary>
        public Color WarningMessage
        {
            get
            {
                return warningMessage;
            }
            set
            {
                warningMessage = value;
            }
        }
        [Tooltip("The Color of the text for an error log message.")]
        [SerializeField]
        private Color errorMessage = Color.red;
        /// <summary>
        /// The <see cref="Color"/> of the text for an error log message.
        /// </summary>
        public Color ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
            }
        }
        [Tooltip("The Color of the text for an exception log message.")]
        [SerializeField]
        private Color exceptionMessage = Color.red;
        /// <summary>
        /// The <see cref="Color"/> of the text for an exception log message.
        /// </summary>
        public Color ExceptionMessage
        {
            get
            {
                return exceptionMessage;
            }
            set
            {
                exceptionMessage = value;
            }
        }
        [Tooltip("The Color of the text when counting collapsed messages.")]
        [SerializeField]
        [Restricted(RestrictedAttribute.Restrictions.ReadOnlyAtRunTimeAndEnabled)]
        private Color collapseCounter = Color.white;
        /// <summary>
        /// The <see cref="Color"/> of the text when counting collapsed messages.
        /// </summary>
        public Color CollapseCounter
        {
            get
            {
                return collapseCounter;
            }
            set
            {
                collapseCounter = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterCollapseCounterChange();
                }
            }
        }
        [Tooltip("Determines whether to collapse same messages into one message in the log.")]
        [SerializeField]
        private bool collapseLog;
        /// <summary>
        /// Determines whether to collapse same messages into one message in the log.
        /// </summary>
        public bool CollapseLog
        {
            get
            {
                return collapseLog;
            }
            set
            {
                collapseLog = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterCollapseLogChange();
                }
            }
        }
        [Tooltip("The string to use as a log line separator.")]
        [SerializeField]
        private string lineSeparator = "---------------";
        /// <summary>
        /// The <see cref="string"/> to use as a log line separator.
        /// </summary>
        public string LineSeparator
        {
            get
            {
                return lineSeparator;
            }
            set
            {
                lineSeparator = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The console scrollable ScrollRect area.")]
        [SerializeField]
        [Restricted]
        private ScrollRect scrollWindow;
        /// <summary>
        /// The console scrollable <see cref="ScrollRect"/> area.
        /// </summary>
        public ScrollRect ScrollWindow
        {
            get
            {
                return scrollWindow;
            }
            protected set
            {
                scrollWindow = value;
            }
        }
        [Tooltip("The output content RectTransform.")]
        [SerializeField]
        [Restricted]
        private RectTransform consoleRect;
        /// <summary>
        /// The output content <see cref="RectTransform"/>.
        /// </summary>
        public RectTransform ConsoleRect
        {
            get
            {
                return consoleRect;
            }
            protected set
            {
                consoleRect = value;
            }
        }
        [Tooltip("The Text element to output the console to.")]
        [SerializeField]
        [Restricted]
        private Text consoleOutput;
        /// <summary>
        /// The <see cref="Text "/> element to output the console to.
        /// </summary>
        public Text ConsoleOutput
        {
            get
            {
                return consoleOutput;
            }
            protected set
            {
                consoleOutput = value;
            }
        }
        [Tooltip("The GameObject that holds the checkmark for the collapse state.")]
        [SerializeField]
        [Restricted]
        private GameObject collapseCheckMark;
        /// <summary>
        /// The <see cref="GameObject "/> that holds the checkmark for the collapse state.
        /// </summary>
        public GameObject CollapseCheckMark
        {
            get
            {
                return collapseCheckMark;
            }
            protected set
            {
                collapseCheckMark = value;
            }
        }
        #endregion

        /// <summary>
        /// The size to multiply the output content elements by to improve font scaling.
        /// </summary>
        protected const float sizeMultiplier = 10f;
        /// <summary>
        /// A replacement character for the collapse counter.
        /// </summary>
        protected const string collapseCountMaskCharacter = "x";
        /// <summary>
        /// The default starting value for the collapse counter.
        /// </summary>
        protected const string collapseCounterDefaultReplaceValue = "1";
        /// <summary>
        /// The character to use for the line ending.
        /// </summary>
        protected const string newline = "\n";
        /// <summary>
        /// The specified line buffer.
        /// </summary>
        protected const int lineBuffer = 50;
        /// <summary>
        /// The current line buffer in use.
        /// </summary>
        protected int currentBuffer;
        /// <summary>
        /// The last log message.
        /// </summary>
        protected string lastMessage;
        /// <summary>
        /// The string representation of the <see cref="CollapseCounter"/>.
        /// </summary>
        protected string collapseCounterColorString;
        /// <summary>
        /// The default string to insert for the collapse counter.
        /// </summary>
        protected string collapseCounterDefaultInsertValue;
        /// <summary>
        /// The pattern to match for capturing the existing collapse counter.
        /// </summary>
        protected Regex collapseCounterPattern;

        /// <summary>
        /// Clears the current log view of all messages
        /// </summary>
        public virtual void ClearLog()
        {
            if (ConsoleOutput != null)
            {
                ConsoleOutput.text = "";
            }
            currentBuffer = 0;
            lastMessage = "";
        }

        protected virtual void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
            OnAfterCollapseLogChange();
            OnAfterCollapseCounterChange();
        }

        protected virtual void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
            if (ConsoleRect != null)
            {
                ConsoleRect.sizeDelta = Vector2.zero;
            }
        }

        /// <summary>
        /// Gets a rich text styled message for the given <see cref="LogType"/>.
        /// </summary>
        /// <param name="message">The message to style.</param>
        /// <param name="type">The <see cref="LogType"/> of the message.</param>
        /// <returns>A rich text styled message.</returns>
        protected virtual string GetMessage(string message, LogType type)
        {
            Color color;
            switch (type)
            {
                case LogType.Error:
                    color = ErrorMessage;
                    break;
                case LogType.Assert:
                    color = AssertMessage;
                    break;
                case LogType.Warning:
                    color = WarningMessage;
                    break;
                case LogType.Log:
                    color = InfoMessage;
                    break;
                case LogType.Exception:
                    color = ExceptionMessage;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            string hexadecimalColorString = ColorUtility.ToHtmlStringRGBA(color);
            return $"<color=#{hexadecimalColorString}>{message}</color>{newline}" + (!string.IsNullOrEmpty(LineSeparator) ? $"{LineSeparator}{newline}" : "");
        }

        /// <summary>
        /// Digests the current Unity log stream and outputs it to the provided <see cref="ConsoleOutput"/>
        /// </summary>
        /// <param name="message">The message from the log stream.</param>
        /// <param name="stackTrace">The stack-trace data from the log stream</param>
        /// <param name="type">The type of the given log message.</param>
        protected virtual void HandleLog(string message, string stackTrace, LogType type)
        {
            if (ConsoleOutput == null || ScrollWindow == null || ConsoleRect == null)
            {
                return;
            }

            string logOutput = GetMessage(message, type);
            string consoleOutputText = ConsoleOutput.text;

            if (currentBuffer >= lineBuffer)
            {
                const int halfLineBuffer = lineBuffer / 2;
                int lookupIndex = 0;
                int skippedLineCount = 0;

                while (skippedLineCount < halfLineBuffer && lookupIndex < consoleOutputText.Length)
                {
                    int newlineIndex = consoleOutputText.IndexOf(newline, lookupIndex, StringComparison.Ordinal);
                    if (newlineIndex == -1)
                    {
                        break;
                    }

                    lookupIndex = newlineIndex + 1;
                    skippedLineCount++;
                }

                if (lookupIndex < consoleOutputText.Length)
                {
                    consoleOutputText = consoleOutputText.Substring(lookupIndex);
                }

                currentBuffer = halfLineBuffer;
            }

            if (lastMessage == logOutput && CollapseLog)
            {
                string[] lines = consoleOutputText.Split(new string[] { newline }, StringSplitOptions.None);
                int lastLineIndex = lines.Length - (!string.IsNullOrEmpty(LineSeparator) ? 3 : 2);

                string toInsert = collapseCounterDefaultInsertValue;
                string replaceValue = collapseCounterDefaultReplaceValue;
                Match numberMatch = collapseCounterPattern.Match(lines[lastLineIndex]);
                string currentLine = lines[lastLineIndex];

                if (numberMatch.Groups.Count > 2)
                {
                    replaceValue = (int.Parse(numberMatch.Groups[1].Value) + 1).ToString();
                    currentLine = numberMatch.Groups[2].Value.Trim();
                }

                toInsert = toInsert.Replace(collapseCountMaskCharacter, replaceValue);

                lines[lastLineIndex] = $"{toInsert} {currentLine}";
                consoleOutputText = string.Join(newline, lines);
            }
            else
            {
                consoleOutputText += logOutput;
            }

            lastMessage = logOutput;

            ConsoleOutput.text = consoleOutputText;
            ConsoleOutput.fontSize = FontSize * (int)sizeMultiplier;
            ConsoleRect.sizeDelta = new Vector2(ConsoleOutput.preferredWidth / sizeMultiplier, ConsoleOutput.preferredHeight / sizeMultiplier);
            ScrollWindow.verticalNormalizedPosition = 0;
            currentBuffer++;
        }

        /// <summary>
        /// Called after <see cref="CollapseCounter"/> has been changed.
        /// </summary>
        protected virtual void OnAfterCollapseCounterChange()
        {
            collapseCounterColorString = ColorUtility.ToHtmlStringRGBA(CollapseCounter);
            collapseCounterDefaultInsertValue = $"<color=#{collapseCounterColorString}>({collapseCountMaskCharacter})</color>";
            collapseCounterPattern = new Regex($"^<color=#{collapseCounterColorString}>\\((\\d+)\\)</color>(.*)");
        }

        /// <summary>
        /// Called after <see cref="CollapseLog"/> has been changed.
        /// </summary>
        protected virtual void OnAfterCollapseLogChange()
        {
            CollapseCheckMark.SetActive(CollapseLog);
        }
    }
}