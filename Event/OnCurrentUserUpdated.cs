using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.CurrentUserUpdated"/>
    public class OnCurrentUserUpdated : EventBase {

        public OnCurrentUserUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.CurrentUserUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.CurrentUserUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.CurrentUserUpdated"/>
        public Task Event(SocketSelfUser arg1, SocketSelfUser arg2) {
            return Task.CompletedTask;
        }

    }
}