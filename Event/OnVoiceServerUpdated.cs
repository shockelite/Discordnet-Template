using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.VoiceServerUpdated"/>
    public class OnVoiceServerUpdated : EventBase {

        public OnVoiceServerUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.VoiceServerUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.VoiceServerUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.VoiceServerUpdated"/>
        public Task Event(SocketVoiceServer arg) {
            return Task.CompletedTask;
        }

    }
}