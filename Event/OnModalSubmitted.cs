using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ModalSubmitted"/>
    public class OnModalSubmitted : EventBase {

        public OnModalSubmitted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ModalSubmitted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ModalSubmitted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ModalSubmitted"/>
        public Task Event(SocketModal arg) {
            return Task.CompletedTask;
        }

    }
}