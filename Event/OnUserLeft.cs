using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserLeft"/>
    public class OnUserLeft : EventBase {

        public OnUserLeft(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserLeft += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserLeft -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserLeft"/>
        public Task Event(SocketGuild guild, SocketUser user) {
            return Task.CompletedTask;
        }

    }
}