using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.StageStarted"/>
    public class OnStageStarted : EventBase {

        public OnStageStarted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.StageStarted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.StageStarted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.StageStarted"/>
        public Task Event(SocketStageChannel arg) {
            return Task.CompletedTask;
        }

    }
}