using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SpeakerAdded"/>
    public class OnSpeakerAdded : EventBase {

        public OnSpeakerAdded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.SpeakerAdded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.SpeakerAdded -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.SpeakerAdded"/>
        public Task Event(SocketStageChannel arg1, SocketGuildUser arg2) {
            return Task.CompletedTask;
        }

    }
}