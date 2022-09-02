using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ButtonExecuted"/>
    public class OnButtonExecuted : EventBase {

        public OnButtonExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ButtonExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ButtonExecuted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ButtonExecuted"/>
        public Task Event(SocketMessageComponent a) {
            return Task.CompletedTask;
        }

    }
}