using Discord;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageDeleted"/>
    public class OnMessageDeleted : EventBase {

        public OnMessageDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessageDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageDeleted"/>
        public Task Event(Cacheable<IMessage, ulong> message, Cacheable<IMessageChannel, ulong> channel) {
            return Task.CompletedTask;
        }

    }
}