using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Ready"/>
    public class OnReady : EventBase {

        public OnReady(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.Ready += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Ready -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Ready"/>
        public Task Event() {
            return Task.CompletedTask;
        }

    }
}