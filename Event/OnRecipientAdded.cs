using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RecipientAdded"/>
    public class OnRecipientAdded : EventBase {

        public OnRecipientAdded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RecipientAdded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RecipientAdded -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RecipientAdded"/>
        public Task Event(SocketGroupUser arg) {
            return Task.CompletedTask;
        }

    }
}