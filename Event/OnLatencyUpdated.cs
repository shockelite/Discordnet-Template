using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.LatencyUpdated"/>
    public class OnLatencyUpdated : EventBase {

        public OnLatencyUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.LatencyUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.LatencyUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.LatencyUpdated"/>
        public Task Event(int arg1, int arg2) {
            return Task.CompletedTask;
        }

    }
}