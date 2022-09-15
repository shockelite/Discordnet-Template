using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserJoined"/>
    public class OnUserJoined : EventBase {

        public OnUserJoined(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserJoined += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserJoined -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserJoined"/>
        public Task Event(SocketGuildUser user) {
            return Task.CompletedTask;
        }

    }
}