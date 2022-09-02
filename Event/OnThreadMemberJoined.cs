using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadMemberJoined"/>
    public class OnThreadMemberJoined : EventBase {

        public OnThreadMemberJoined(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadMemberJoined += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadMemberJoined -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadMemberJoined"/>
        public Task Event(SocketThreadUser arg) {
            return Task.CompletedTask;
        }

    }
}