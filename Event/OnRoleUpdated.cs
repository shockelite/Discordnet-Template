using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RoleUpdated"/>
    public class OnRoleUpdated : EventBase {

        public OnRoleUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RoleUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RoleUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RoleUpdated"/>
        public Task Event(SocketRole arg1, SocketRole arg2) {
            return Task.CompletedTask;
        }

    }
}