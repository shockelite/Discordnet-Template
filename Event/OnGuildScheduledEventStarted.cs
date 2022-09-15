using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventStarted"/>
    public class OnGuildScheduledEventStarted : EventBase {

        public OnGuildScheduledEventStarted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventStarted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventStarted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventStarted"/>
        public Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}