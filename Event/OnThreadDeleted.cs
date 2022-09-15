using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadDeleted"/>
    public class OnThreadDeleted : EventBase {

        public OnThreadDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadDeleted"/>
        public Task Event(Discord.Cacheable<SocketThreadChannel, ulong> arg) {
            return Task.CompletedTask;
        }

    }
}