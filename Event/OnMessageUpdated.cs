using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageUpdated"/>
    public class OnMessageUpdated : EventBase {

        public OnMessageUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessageUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageUpdated"/>
        public Task Event(Cacheable<IMessage, ulong> a, SocketMessage b, ISocketMessageChannel c) {
            return Task.CompletedTask;
        }

    }
}