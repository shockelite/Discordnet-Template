using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionsRemovedForEmote"/>
    public class OnReactionsRemovedForEmote : EventBase {

        public OnReactionsRemovedForEmote(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ReactionsRemovedForEmote += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ReactionsRemovedForEmote -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionsRemovedForEmote"/>
        public Task Event(Discord.Cacheable<Discord.IUserMessage, ulong> arg1, Discord.Cacheable<Discord.IMessageChannel, ulong> arg2, Discord.IEmote arg3) {
            return Task.CompletedTask;
        }

    }
}