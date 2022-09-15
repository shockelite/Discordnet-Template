using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ChannelUpdated"/>
    public class OnChannelUpdated : EventBase {

        public OnChannelUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ChannelUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ChannelUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ChannelUpdated"/>
        public Task Event(SocketChannel a, SocketChannel b) {
            return Task.CompletedTask;
        }

    }
}