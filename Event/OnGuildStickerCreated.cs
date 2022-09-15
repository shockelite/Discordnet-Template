using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildStickerCreated"/>
    public class OnGuildStickerCreated : EventBase {

        public OnGuildStickerCreated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildStickerCreated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildStickerCreated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildStickerCreated"/>
        public Task Event(SocketCustomSticker arg) {
            return Task.CompletedTask;
        }

    }
}