using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventCreated"/>
    public class OnGuildScheduledEventCreated : EventBase {

        public OnGuildScheduledEventCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventCreated"/>
        public Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}