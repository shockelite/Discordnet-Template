using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionRemoved"/>
    public class OnReactionRemoved : EventBase {

        public OnReactionRemoved(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ReactionRemoved += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ReactionRemoved -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionRemoved"/>
        public Task Event(Cacheable<IUserMessage, ulong> arg1, Cacheable<IMessageChannel, ulong> arg2, SocketReaction arg3) {
            return Task.CompletedTask;
        }

    }
}