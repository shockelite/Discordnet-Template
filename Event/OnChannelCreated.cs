using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ChannelCreated"/>
    public class OnChannelCreated : EventBase {

        public OnChannelCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ChannelCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ChannelCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ChannelCreated"/>
        public Task Event(SocketChannel a) {
            return Task.CompletedTask;
        }

    }
}