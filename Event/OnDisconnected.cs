using System;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Disconnected"/>
    public class OnDisconnected : EventBase {

        public OnDisconnected(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.Disconnected += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Disconnected -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Disconnected"/>
        public Task Event(Exception arg) {
            return Task.CompletedTask;
        }

    }
}