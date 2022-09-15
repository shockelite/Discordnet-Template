using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.LeftGuild"/>
    public class OnGuildLeft : EventBase {

        public OnGuildLeft(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.LeftGuild += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.LeftGuild -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.LeftGuild"/>
        public Task Event(SocketGuild a) {
            return Task.CompletedTask;
        }

    }
}