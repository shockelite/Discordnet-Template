using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RoleCreated"/>
    public class OnRoleCreated : EventBase {

        public OnRoleCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RoleCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RoleCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RoleCreated"/>
        public Task Event(SocketRole arg) {
            return Task.CompletedTask;
        }

    }
}