using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageCommandExecuted"/>
    public class OnMessageCommandExecuted : EventBase {

        public OnMessageCommandExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.MessageCommandExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.MessageCommandExecuted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.MessageCommandExecuted"/>
        public Task Event(SocketMessageCommand arg) {
            return Task.CompletedTask;
        }

    }
}