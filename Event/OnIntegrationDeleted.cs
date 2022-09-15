using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.IntegrationDeleted"/>
    public class OnIntegrationDeleted : EventBase {

        public OnIntegrationDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.IntegrationDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.IntegrationDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.IntegrationDeleted"/>
        public Task Event(Discord.IGuild arg1, ulong arg2, Discord.Optional<ulong> arg3) {
            return Task.CompletedTask;
        }

    }
}