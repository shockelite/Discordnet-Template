using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.LoggedOut"/>
    public class OnLoggedOut : EventBase {

        public OnLoggedOut(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.LoggedOut += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.LoggedOut -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.LoggedOut"/>
        public Task Event() {
            return Task.CompletedTask;
        }

    }
}

