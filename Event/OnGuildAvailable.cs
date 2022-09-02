using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildAvailable"/>
    public class OnGuildAvailable : EventBase {

        public OnGuildAvailable(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildAvailable += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildAvailable -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildAvailable"/>
        public Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}