using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildAvailable"/>
    public class OnGuildUnavailable : EventBase {

        public OnGuildUnavailable(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildAvailable += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildAvailable -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildAvailable"/>
        public Task Event(SocketGuild arg) {
            return Task.CompletedTask;
        }

    }
}