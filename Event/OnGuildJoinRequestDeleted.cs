using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildJoinRequestDeleted"/>
    public class OnGuildJoinRequestDeleted : EventBase {

        public OnGuildJoinRequestDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildJoinRequestDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildJoinRequestDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildJoinRequestDeleted"/>
        public Task Event(Cacheable<SocketGuildUser, ulong> a, SocketGuild b) {
            return Task.CompletedTask;
        }

    }
}