using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.JoinedGuild"/>
    public class OnGuildJoin : EventBase {

        public OnGuildJoin(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.JoinedGuild += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.JoinedGuild -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.JoinedGuild"/>
        public Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}