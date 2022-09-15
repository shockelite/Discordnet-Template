using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.PresenceUpdated"/>
    public class OnPresenceUpdated : EventBase {

        public OnPresenceUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.PresenceUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.PresenceUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.PresenceUpdated"/>
        public Task Event(SocketUser user, SocketPresence before, SocketPresence after) {
            return Task.CompletedTask;
        }

    }
}