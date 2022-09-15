using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SelectMenuExecuted"/>
    public class OnSelectMenuExecuted : EventBase {

        public OnSelectMenuExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SelectMenuExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SelectMenuExecuted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SelectMenuExecuted"/>
        public Task Event(SocketMessageComponent arg) {
            return Task.CompletedTask;
        }

    }
}