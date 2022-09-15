using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ChannelDestroyed"/>
    public class OnChannelDestroyed : EventBase {

        public OnChannelDestroyed(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ChannelDestroyed += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ChannelDestroyed -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ChannelDestroyed"/>
        public Task Event(SocketChannel a) {
            return Task.CompletedTask;
        }

    }
}