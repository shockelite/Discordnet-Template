using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ApplicationCommandDeleted"/>
    public class OnApplicationCommandDeleted : EventBase {

        public OnApplicationCommandDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.ApplicationCommandDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.ApplicationCommandDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.ApplicationCommandDeleted"/>
        public Task Event(SocketApplicationCommand arg) {
            return Task.CompletedTask;
        }

    }
}