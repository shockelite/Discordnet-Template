using Discord;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessagesBulkDeleted"/>
    public class OnMessagesBulkDeleted : EventBase {

        public OnMessagesBulkDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessagesBulkDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessagesBulkDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessagesBulkDeleted"/>
        public Task Event(IReadOnlyCollection<Cacheable<IMessage, ulong>> arg1, Cacheable<IMessageChannel, ulong> arg2) {
            return Task.CompletedTask;
        }

    }
}