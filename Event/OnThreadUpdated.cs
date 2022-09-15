using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadUpdated"/>
    public class OnThreadUpdated : EventBase {

        public OnThreadUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadUpdated"/>
        public Task Event(Discord.Cacheable<SocketThreadChannel, ulong> arg1, SocketThreadChannel arg2) {
            return Task.CompletedTask;
        }

    }
}