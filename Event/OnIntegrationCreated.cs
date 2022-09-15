using Discord;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.IntegrationCreated"/>
    public class OnIntegrationCreated : EventBase {

        public OnIntegrationCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.IntegrationCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.IntegrationCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.IntegrationCreated"/>
        public Task Event(IIntegration arg) {
            return Task.CompletedTask;
        }

    }
}