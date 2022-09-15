using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventUserAdd"/>
    public class OnGuildScheduledEventUserAdd : EventBase {

        public OnGuildScheduledEventUserAdd(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventUserAdd += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventUserAdd -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventUserAdd"/>
        public Task Event(Discord.Cacheable<SocketUser, Discord.Rest.RestUser, Discord.IUser, ulong> arg1, SocketGuildEvent arg2) {
            return Task.CompletedTask;
        }

    }
}