using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildStickerUpdated"/>
    public class OnGuildStickerUpdated : EventBase {

        public OnGuildStickerUpdated(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildStickerUpdated += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildStickerUpdated -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildStickerUpdated"/>
        public Task Event(SocketCustomSticker arg1, SocketCustomSticker arg2) {
            return Task.CompletedTask;
        }

    }
}