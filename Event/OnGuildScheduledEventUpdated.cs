using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventUpdated"/>
    public class OnGuildScheduledEventUpdated : EventBase {

        public OnGuildScheduledEventUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventUpdated"/>
        public Task Event(Cacheable<SocketGuildEvent, ulong> arg1, SocketGuildEvent arg2) {
            return Task.CompletedTask;
        }

    }
}