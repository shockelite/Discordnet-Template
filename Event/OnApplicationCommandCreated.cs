using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ApplicationCommandCreated"/>
    public class OnApplicationCommandCreated : EventBase {

        public OnApplicationCommandCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ApplicationCommandCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ApplicationCommandCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ApplicationCommandCreated"/>
        public Task Event(SocketApplicationCommand arg) {
            return Task.CompletedTask;
        }

    }
}