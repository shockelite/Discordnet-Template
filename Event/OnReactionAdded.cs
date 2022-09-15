using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionAdded"/>
    public class OnReactionAdded : EventBase {

        public OnReactionAdded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ReactionAdded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ReactionAdded -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ReactionAdded"/>
        public Task Event(Cacheable<IUserMessage, ulong> arg1, Cacheable<IMessageChannel, ulong> arg2, SocketReaction arg3) {
            return Task.CompletedTask;
        }

    }
}