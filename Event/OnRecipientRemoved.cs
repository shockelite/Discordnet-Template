using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RecipientRemoved"/>
    public class OnRecipientRemoved : EventBase {

        public OnRecipientRemoved(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RecipientRemoved += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RecipientRemoved -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RecipientRemoved"/>
        public Task Event(SocketGroupUser arg) {
            return Task.CompletedTask;
        }

    }
}