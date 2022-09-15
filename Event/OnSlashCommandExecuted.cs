using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SlashCommandExecuted"/>
    public class OnSlashCommandExecuted : EventBase {

        public OnSlashCommandExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SlashCommandExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SlashCommandExecuted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SlashCommandExecuted"/>
        public Task Event(SocketSlashCommand arg) {
            return Task.CompletedTask;
        }

    }
}