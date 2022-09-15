using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventUserRemove"/>
    public class OnGuildScheduledEventUserRemove : EventBase {

        public OnGuildScheduledEventUserRemove(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventUserRemove += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventUserRemove -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventUserRemove"/>
        public Task Event(Discord.Cacheable<SocketUser, Discord.Rest.RestUser, Discord.IUser, ulong> arg1, SocketGuildEvent arg2) {
            return Task.CompletedTask;
        }

    }
}