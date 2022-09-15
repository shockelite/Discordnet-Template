using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.InviteDeleted"/>
    public class OnInviteDeleted : EventBase {

        public OnInviteDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.InviteDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.InviteDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.InviteDeleted"/>
        public Task Event(SocketGuildChannel channel, string code) {
            return Task.CompletedTask;
        }

    }
}