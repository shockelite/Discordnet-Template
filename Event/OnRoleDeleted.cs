using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RoleDeleted"/>
    public class OnRoleDeleted : EventBase {

        public OnRoleDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RoleDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RoleDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RoleDeleted"/>
        public Task Event(SocketRole arg) {
            return Task.CompletedTask;
        }

    }
}