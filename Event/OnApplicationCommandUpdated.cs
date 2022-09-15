using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ApplicationCommandUpdated"/>
    public class OnApplicationCommandUpdated : EventBase {

        public OnApplicationCommandUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ApplicationCommandUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ApplicationCommandUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ApplicationCommandUpdated"/>
        public Task Event(SocketApplicationCommand arg) {
            return Task.CompletedTask;
        }

    }
}