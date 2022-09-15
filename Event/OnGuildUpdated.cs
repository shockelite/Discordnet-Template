using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildUpdated"/>
    public class OnGuildUpdated : EventBase {

        public OnGuildUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildUpdated"/>
        public Task Event(SocketGuild a, SocketGuild b) {
            return Task.CompletedTask;
        }

    }
}