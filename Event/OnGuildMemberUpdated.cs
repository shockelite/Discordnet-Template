using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildMemberUpdated"/>
    public class OnGuildMemberUpdated : EventBase {

        public OnGuildMemberUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildMemberUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildMemberUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildMemberUpdated"/>
        public Task Event(Cacheable<SocketGuildUser, ulong> a, SocketGuildUser b) {
            return Task.CompletedTask;
        }

    }
}