using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserCommandExecuted"/>
    public class OnUserCommandExecuted : EventBase {

        public OnUserCommandExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserCommandExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserCommandExecuted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserCommandExecuted"/>
        public Task Event(SocketUserCommand arg) {
            return Task.CompletedTask;
        }

    }
}