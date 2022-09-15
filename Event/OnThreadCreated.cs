using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadCreated"/>
    public class OnThreadCreated : EventBase {

        public OnThreadCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadCreated"/>
        public Task Event(SocketThreadChannel arg) {
            return Task.CompletedTask;
        }

    }
}