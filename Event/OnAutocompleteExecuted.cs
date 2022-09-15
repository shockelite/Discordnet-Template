using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.AutocompleteExecuted"/>
    public class OnAutocompleteExecuted : EventBase {

        public OnAutocompleteExecuted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.AutocompleteExecuted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.AutocompleteExecuted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.AutocompleteExecuted"/>
        public Task Event(SocketAutocompleteInteraction arg) {
            return Task.CompletedTask;
        }

    }
}