using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserUnbanned"/>
    public class OnUserUnbanned : EventBase {

        public OnUserUnbanned(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserUnbanned += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserUnbanned -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserUnbanned"/>
        public Task Event(SocketUser arg1, SocketGuild arg2) {
            return Task.CompletedTask;
        }

    }
}