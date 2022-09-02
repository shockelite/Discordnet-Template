using Discord.WebSocket;
using System.Collections.Generic;

namespace EmptyBot.Event {

    /// <summary>
    /// Holds all <see cref="BaseSocketClient"/> events.
    /// </summary>
    public class EventHandler {

        /// <summary>
        /// Object events are subscribed to.
        /// </summary>
        public readonly DiscordSocketClient Client;

        /// <summary>
        /// All events in this handler.
        /// </summary>
        public readonly List<EventBase> Events;

        public OnApplicationCommandCreated OnApplicationCommandCreated;
        public OnApplicationCommandDeleted OnApplicationCommandDeleted;
        public OnApplicationCommandUpdated OnApplicationCommandUpdated;
        public OnAutocompleteExecuted OnAutocompleteExecuted;
        public OnButtonExecuted OnButtonExecuted;
        public OnChannelCreated OnChannelCreated;
        public OnChannelDestroyed OnChannelDestroyed;
        public OnChannelUpdated OnChannelUpdated;
        public OnConnected OnConnected;
        public OnCurrentUserUpdated OnCurrentUserUpdated;
        public OnDisconnected OnDisconnected;
        public OnGuildAvailable OnGuildAvailable;
        public OnGuildJoin OnGuildJoin;
        public OnGuildJoinRequestDeleted OnGuildJoinRequestDeleted;
        public OnGuildLeft OnGuildLeft;
        public OnGuildMembersDownloaded OnGuildMembersDownloaded;
        public OnGuildMemberUpdated OnGuildMemberUpdated;
        public OnGuildScheduledEventCancelled OnGuildScheduledEventCancelled;
        public OnGuildScheduledEventCompleted OnGuildScheduledEventCompleted;
        public OnGuildScheduledEventCreated OnGuildScheduledEventCreated;
        public OnGuildScheduledEventStarted OnGuildScheduledEventStarted;
        public OnGuildScheduledEventUpdated OnGuildScheduledEventUpdated;
        public OnGuildScheduledEventUserAdd OnGuildScheduledEventUserAdd;
        public OnGuildScheduledEventUserRemove OnGuildScheduledEventUserRemove;
        public OnGuildStickerCreated OnGuildStickerCreated;
        public OnGuildStickerDeleted OnGuildStickerDeleted;
        public OnGuildStickerUpdated OnGuildStickerUpdated;
        public OnGuildUnavailable OnGuildUnavailable;
        public OnGuildUpdated OnGuildUpdated;
        public OnIntegrationCreated OnIntegrationCreated;
        public OnIntegrationDeleted OnIntegrationDeleted;
        public OnIntegrationUpdated OnIntegrationUpdated;
        public OnInteractionCreated OnInteractionCreated;
        public OnInviteCreated OnInviteCreated;
        public OnInviteDeleted OnInviteDeleted;
        public OnLatencyUpdated OnLatencyUpdated;
        public OnLog OnLog;
        public OnLoggedOut OnLoggedOut;
        public OnMessageCommandExecuted OnMessageCommandExecuted;
        public OnMessageDeleted OnMessageDeleted;
        public OnMessageReceived OnMessageReceived;
        public OnMessagesBulkDeleted OnMessagesBulkDeleted;
        public OnMessageUpdated OnMessageUpdated;
        public OnModalSubmitted OnModalSubmitted;
        public OnPresenceUpdated OnPresenceUpdated;
        public OnReactionAdded OnReactionAdded;
        public OnReactionRemoved OnReactionRemoved;
        public OnReactionsCleared OnReactionsCleared;
        public OnReactionsRemovedForEmote OnReactionsRemovedForEmote;
        public OnReady OnReady;
        public OnRecipientAdded OnRecipientAdded;
        public OnRecipientRemoved OnRecipientRemoved;
        public OnRequestToSpeak OnRequestToSpeak;
        public OnRoleCreated OnRoleCreated;
        public OnRoleDeleted OnRoleDeleted;
        public OnRoleUpdated OnRoleUpdated;
        public OnSelectMenuExecuted OnSelectMenuExecuted;
        public OnSlashCommandExecuted OnSlashCommandExecuted;
        public OnSpeakerAdded OnSpeakerAdded;
        public OnSpeakerRemoved OnSpeakerRemoved;
        public OnStageEnded OnStageEnded;
        public OnStageStarted OnStageStarted;
        public OnStageUpdated OnStageUpdated;
        public OnThreadCreated OnThreadCreated;
        public OnThreadDeleted OnThreadDeleted;
        public OnThreadMemberJoined OnThreadMemberJoined;
        public OnThreadMemberLeft OnThreadMemberLeft;
        public OnThreadUpdated OnThreadUpdated;
        public OnUserBanned OnUserBanned;
        public OnUserCommandExecuted OnUserCommandExecuted;
        public OnUserIsTyping OnUserIsTyping;
        public OnUserJoined OnUserJoined;
        public OnUserLeft OnUserLeft;
        public OnUserUnbanned OnUserUnbanned;
        public OnUserUpdated OnUserUpdated;
        public OnUserVoiceStateUpdated OnUserVoiceStateUpdated;
        public OnVoiceServerUpdated OnVoiceServerUpdated;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="socketClient"></param>
        public EventHandler(DiscordSocketClient client) {
            this.Client = client;
            this.Events = new List<EventBase>();
            this.OnApplicationCommandCreated = new OnApplicationCommandCreated(this);
            this.OnApplicationCommandDeleted = new OnApplicationCommandDeleted(this);
            this.OnApplicationCommandUpdated = new OnApplicationCommandUpdated(this);
            this.OnAutocompleteExecuted = new OnAutocompleteExecuted(this);
            this.OnButtonExecuted = new OnButtonExecuted(this);
            this.OnChannelCreated = new OnChannelCreated(this);
            this.OnChannelDestroyed = new OnChannelDestroyed(this);
            this.OnChannelUpdated = new OnChannelUpdated(this);
            this.OnConnected = new OnConnected(this);
            this.OnCurrentUserUpdated = new OnCurrentUserUpdated(this);
            this.OnDisconnected = new OnDisconnected(this);
            this.OnGuildAvailable = new OnGuildAvailable(this);
            this.OnGuildJoin = new OnGuildJoin(this);
            this.OnGuildJoinRequestDeleted = new OnGuildJoinRequestDeleted(this);
            this.OnGuildLeft = new OnGuildLeft(this);
            this.OnGuildMembersDownloaded = new OnGuildMembersDownloaded(this);
            this.OnGuildMemberUpdated = new OnGuildMemberUpdated(this);
            this.OnGuildScheduledEventCancelled = new OnGuildScheduledEventCancelled(this);
            this.OnGuildScheduledEventCompleted = new OnGuildScheduledEventCompleted(this);
            this.OnGuildScheduledEventCreated = new OnGuildScheduledEventCreated(this);
            this.OnGuildScheduledEventStarted = new OnGuildScheduledEventStarted(this);
            this.OnGuildScheduledEventUpdated = new OnGuildScheduledEventUpdated(this);
            this.OnGuildScheduledEventUserAdd = new OnGuildScheduledEventUserAdd(this);
            this.OnGuildScheduledEventUserRemove = new OnGuildScheduledEventUserRemove(this);
            this.OnGuildStickerCreated = new OnGuildStickerCreated(this);
            this.OnGuildStickerDeleted = new OnGuildStickerDeleted(this);
            this.OnGuildStickerUpdated = new OnGuildStickerUpdated(this);
            this.OnGuildUnavailable = new OnGuildUnavailable(this);
            this.OnGuildUpdated = new OnGuildUpdated(this);
            this.OnIntegrationCreated = new OnIntegrationCreated(this);
            this.OnIntegrationDeleted = new OnIntegrationDeleted(this);
            this.OnIntegrationUpdated = new OnIntegrationUpdated(this);
            this.OnInteractionCreated = new OnInteractionCreated(this);
            this.OnInviteCreated = new OnInviteCreated(this);
            this.OnInviteDeleted = new OnInviteDeleted(this);
            this.OnLatencyUpdated = new OnLatencyUpdated(this);
            this.OnLog = new OnLog(this);
            this.OnLoggedOut = new OnLoggedOut(this);
            this.OnMessageCommandExecuted = new OnMessageCommandExecuted(this);
            this.OnMessageDeleted = new OnMessageDeleted(this);
            this.OnMessageReceived = new OnMessageReceived(this);
            this.OnMessagesBulkDeleted = new OnMessagesBulkDeleted(this);
            this.OnMessageUpdated = new OnMessageUpdated(this);
            this.OnModalSubmitted = new OnModalSubmitted(this);
            this.OnPresenceUpdated = new OnPresenceUpdated(this);
            this.OnReactionAdded = new OnReactionAdded(this);
            this.OnReactionRemoved = new OnReactionRemoved(this);
            this.OnReactionsCleared = new OnReactionsCleared(this);
            this.OnReactionsRemovedForEmote = new OnReactionsRemovedForEmote(this);
            this.OnReady = new OnReady(this);
            this.OnRecipientAdded = new OnRecipientAdded(this);
            this.OnRecipientRemoved = new OnRecipientRemoved(this);
            this.OnRequestToSpeak = new OnRequestToSpeak(this);
            this.OnRoleCreated = new OnRoleCreated(this);
            this.OnRoleDeleted = new OnRoleDeleted(this);
            this.OnRoleUpdated = new OnRoleUpdated(this);
            this.OnSelectMenuExecuted = new OnSelectMenuExecuted(this);
            this.OnSlashCommandExecuted = new OnSlashCommandExecuted(this);
            this.OnSpeakerAdded = new OnSpeakerAdded(this);
            this.OnSpeakerRemoved = new OnSpeakerRemoved(this);
            this.OnStageEnded = new OnStageEnded(this);
            this.OnStageStarted = new OnStageStarted(this);
            this.OnStageUpdated = new OnStageUpdated(this);
            this.OnThreadCreated = new OnThreadCreated(this);
            this.OnThreadDeleted = new OnThreadDeleted(this);
            this.OnThreadMemberJoined = new OnThreadMemberJoined(this);
            this.OnThreadMemberLeft = new OnThreadMemberLeft(this);
            this.OnThreadUpdated = new OnThreadUpdated(this);
            this.OnUserBanned = new OnUserBanned(this);
            this.OnUserCommandExecuted = new OnUserCommandExecuted(this);
            this.OnUserIsTyping = new OnUserIsTyping(this);
            this.OnUserJoined = new OnUserJoined(this);
            this.OnUserLeft = new OnUserLeft(this);
            this.OnUserUnbanned = new OnUserUnbanned(this);
            this.OnUserUpdated = new OnUserUpdated(this);
            this.OnUserVoiceStateUpdated = new OnUserVoiceStateUpdated(this);
            this.OnVoiceServerUpdated = new OnVoiceServerUpdated(this);
        }

        /// <summary>
        /// Enable all possible events.
        /// </summary>
        public void SubscribeAll() {
            foreach (EventBase e in this.Events) e.Subscribe();
        }

        /// <summary>
        /// Disable all events.
        /// </summary>
        public void UnsubscribeAll() {
            foreach (EventBase e in this.Events) e.Unsubscribe();
        }

    }
}