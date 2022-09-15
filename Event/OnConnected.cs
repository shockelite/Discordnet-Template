using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Connected"/>
    public class OnConnected : EventBase {

        public OnConnected(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.Connected += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Connected -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Connected"/>
        public Task Event() {
            return Task.CompletedTask;
        }

    }
}