using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.InteractionCreated"/>
    public class OnInteractionCreated : EventBase {

        public OnInteractionCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.InteractionCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.InteractionCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.InteractionCreated"/>
        public Task Event(SocketInteraction arg) {
            return Task.CompletedTask;
        }

    }
}