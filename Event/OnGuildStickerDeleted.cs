using Discord.WebSocket;
using System.Threading.Tasks;

namespace EmptyBot.Event {

    /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildStickerDeleted"/>
    public class OnGuildStickerDeleted : EventBase {

        public OnGuildStickerDeleted(EventHandler eventHandler) : base(eventHandler) { }

        public override void Subscribe() =>
            EventHandler.Client.GuildStickerDeleted += Event;

        public override void Unsubscribe() =>
            EventHandler.Client.GuildStickerDeleted -= Event;

        /// <inheritdoc cref="Discord.WebSocket.BaseSocketClient.GuildStickerDeleted"/>
        public Task Event(SocketCustomSticker arg) {
            return Task.CompletedTask;
        }

    }
}