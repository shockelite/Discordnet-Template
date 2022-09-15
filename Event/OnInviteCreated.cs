using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.InviteCreated"/>
    public class OnInviteCreated : EventBase {

        public OnInviteCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.InviteCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.InviteCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.InviteCreated"/>
        public Task Event(SocketInvite a) {
            return Task.CompletedTask;
        }

    }
}