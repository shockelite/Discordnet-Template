using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageReceived"/>
    public class OnMessageReceived : EventBase {

        public OnMessageReceived(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessageReceived += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageReceived -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageReceived"/>
        public Task Event(Discord.WebSocket.SocketMessage arg) {
            return Task.CompletedTask;
        }

    }
}