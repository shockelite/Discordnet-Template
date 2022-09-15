using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SpeakerRemoved"/>
    public class OnSpeakerRemoved : EventBase {

        public OnSpeakerRemoved(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SpeakerRemoved += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SpeakerRemoved -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SpeakerRemoved"/>
        public Task Event(SocketStageChannel arg1, SocketGuildUser arg2) {
            return Task.CompletedTask;
        }

    }
}