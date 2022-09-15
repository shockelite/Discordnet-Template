using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventCompleted"/>
    public class OnGuildScheduledEventCompleted : EventBase {

        public OnGuildScheduledEventCompleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildScheduledEventCompleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildScheduledEventCompleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildScheduledEventCompleted"/>
        public Task Event(SocketGuildEvent arg) {
            return Task.CompletedTask;
        }

    }
}