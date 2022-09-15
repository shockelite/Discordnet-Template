using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.StageUpdated"/>
    public class OnStageUpdated : EventBase {

        public OnStageUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.StageUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.StageUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.StageUpdated"/>
        public Task Event(SocketStageChannel arg1, SocketStageChannel arg2) {
            return Task.CompletedTask;
        }

    }
}