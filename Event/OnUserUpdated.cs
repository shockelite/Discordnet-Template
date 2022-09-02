using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserUpdated"/>
    public class OnUserUpdated : EventBase {

        public OnUserUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserUpdated"/>
        public Task Event(SocketUser before, SocketUser after) {
            return Task.CompletedTask;
        }

    }
}