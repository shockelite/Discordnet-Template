using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildMembersDownloaded"/>
    public class OnGuildMembersDownloaded : EventBase {

        public OnGuildMembersDownloaded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildMembersDownloaded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildMembersDownloaded -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildMembersDownloaded"/>
        public Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}