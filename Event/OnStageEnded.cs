using Discord.WebSocket;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.StageEnded"/>
    public class OnStageEnded : EventBase {

        public OnStageEnded(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.StageEnded += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.StageEnded -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.StageEnded"/>
        public Task Event(SocketStageChannel arg) {
            return Task.CompletedTask;
        }

    }
}