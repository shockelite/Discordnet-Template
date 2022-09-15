using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserBanned"/>
    public class OnUserBanned : EventBase {

        public OnUserBanned(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserBanned += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserBanned -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserBanned"/>
        public Task Event(SocketUser user, SocketGuild guild) {
            return Task.CompletedTask;
        }

    }
}