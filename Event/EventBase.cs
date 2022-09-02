namespace EmptyBot.Event {

    /// <summary>
    /// Base class for events.
    /// </summary>
    public abstract class EventBase {

        /// <summary>
        /// Root <see cref="EventHandler"/> object.
        /// </summary>
        internal readonly EventHandler EventHandler;

        /// <summary>
        /// Debug level is used for <see cref="Log(string)"/>, <see cref="LogWarning(string)"/>, and <see cref="LogError(string)"/>.
        /// </summary>
        public EventLevel Debug = EventLevel.Info | EventLevel.Warning | EventLevel.Error;

        /// <summary>
        /// Log informational text to console if <see cref="Debug"/> is set to <see cref="EventLevel.Everything"/>.
        /// </summary>
        /// <param name="value">Input</param>
        public void Log(string value) {
            if (Debug.HasFlag(EventLevel.Info)) {
                System.Console.ForegroundColor = System.ConsoleColor.DarkGray;
                System.Console.WriteLine(this.GetType() + " - " + value);
                System.Console.ResetColor();
            }
        }

        /// <summary>
        /// Log warning text to console if <see cref="Debug"/> is set to <see cref="EventLevel.Warning"/> or greater.
        /// </summary>
        /// <param name="value">Input</param>
        public void LogWarning(string value) {
            if (Debug.HasFlag(EventLevel.Warning)) {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine(this.GetType() + " - " + value);
                System.Console.ResetColor();
            }
        }

        /// <summary>
        /// Log error text to console if <see cref="Debug"/> is set to <see cref="EventLevel.Error"/> or greater.
        /// </summary>
        /// <param name="value">Input</param>
        public void LogError(string value) {
            if (Debug.HasFlag(EventLevel.Error)) {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(this.GetType() + " - " + value);
                System.Console.ResetColor();
            }
        }

        /// <summary>
        /// Base event for all events. Should be called when event is first initialized.
        /// </summary>
        /// <param name="eventHandler"></param>
        protected EventBase(EventHandler eventHandler) {
            EventHandler = eventHandler;
            eventHandler.Events.Add(this);
            Log("Created.");
        }

        /// <summary>
        /// Enable this event.
        /// </summary>
        public abstract void Subscribe();

        /// <summary>
        /// Disable this event.
        /// </summary>
        public abstract void Unsubscribe();

    }
}