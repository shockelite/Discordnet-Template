using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventCancelled"/>
    public class OnGuildScheduledEventCancelled : EventBase {

        public OnGuildScheduledEventCancelled(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventCancelled += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventCancelled -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventCancelled"/>
        public Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}