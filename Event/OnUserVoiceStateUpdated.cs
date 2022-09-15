using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserVoiceStateUpdated"/>
    public class OnUserVoiceStateUpdated : EventBase {

        public OnUserVoiceStateUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.UserVoiceStateUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.UserVoiceStateUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.UserVoiceStateUpdated"/>
        public Task Event(SocketUser arg1, SocketVoiceState before, SocketVoiceState current) {
            return Task.CompletedTask;
        }

    }
}