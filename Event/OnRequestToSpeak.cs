using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RequestToSpeak"/>
    public class OnRequestToSpeak : EventBase {

        public OnRequestToSpeak(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.RequestToSpeak += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.RequestToSpeak -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.RequestToSpeak"/>
        public Task Event(SocketStageChannel arg1, SocketGuildUser arg2) {
            return Task.CompletedTask;
        }

    }
}