using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadMemberLeft"/>
    public class OnThreadMemberLeft : EventBase {

        public OnThreadMemberLeft(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ThreadMemberLeft += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ThreadMemberLeft -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ThreadMemberLeft"/>
        public Task Event(SocketThreadUser arg) {
            return Task.CompletedTask;
        }

    }
}