using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionsCleared"/>
    public class OnReactionsCleared : EventBase {

        public OnReactionsCleared(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ReactionsCleared += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ReactionsCleared -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionsCleared"/>
        public Task Event(Discord.Cacheable<Discord.IUserMessage, ulong> arg1, Discord.Cacheable<Discord.IMessageChannel, ulong> arg2) {
            return Task.CompletedTask;
        }

    }
}