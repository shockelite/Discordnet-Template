using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.IntegrationUpdated"/>
    public class OnIntegrationUpdated : EventBase {

        public OnIntegrationUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.IntegrationUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.IntegrationUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.IntegrationUpdated"/>
        public Task Event(Discord.IIntegration arg) {
            return Task.CompletedTask;
        }

    }
}