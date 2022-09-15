using Discord;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Log"/>
    public class OnLog : EventBase {

        public OnLog(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.Log += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.Log -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.Log"/>
        public Task Event(LogMessage arg) {
            return Task.CompletedTask;
        }

    }
}