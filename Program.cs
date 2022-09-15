using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Valkyrie.DiscordBot {
    internal class Program {

        /// <summary>
        /// Discord object.
        /// </summary>
        public static DiscordSocketClient Client { get; private set; } = new DiscordSocketClient(new DiscordSocketConfig() {
            DefaultRetryMode = RetryMode.AlwaysRetry,
            GatewayIntents = GatewayIntents.AllUnprivileged
        });

        /// <summary>
        /// Listens to all discord events.
        /// </summary>
        public static Event.EventHandler EventHandler { get; private set; }

        /// <summary>
        /// Token to use with <see cref="StartAsync"/>.
        /// </summary>
        /// <remarks>
        /// Get Discord bot token from: <a href="https://discord.com/developers/applications" />
        /// </remarks>
        public static string Token { get; private set; } = "BOT_TOKEN_GOES_HERE";

        /// <summary>
        /// Starting method of the application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {

            // Set the title of the console window.
            Console.Title = "Empty Bot";

            // Start new thread.
            _ = Task.Run(() => StartAsync());

            // Prevent the main thread from closing and listen for input.
            while (true) {
                string l = Console.ReadLine();
                string c = l.Contains(" ") ? l.Substring(0, l.IndexOf(" ")) : l;
                switch (c.ToLower()) {
                    // Quit application
                    case "exit":
                    case "quit":
                        return;

                    // Issue stop and logout of Discord bot.
                    case "stop":
                        _ = Task.Run(() => StopAsync());
                        break;

                    // Begin listening to events and initialize bot connection to Discord.
                    case "start":
                        _ = Task.Run(() => StartAsync());
                        break;

                    // Change bot token used for initialize.
                    case "token":
                        if (l.Length > 5) {
                            Token = l[5..].Trim();
                            Console.WriteLine("New token set and will be used when StartAsync() is triggered.");
                        }
                        else
                            Console.WriteLine("Expected bot token.");
                        break;

                    // Display common properties within the DiscordSocketClient object.
                    case "status":
                        if (Client.ConnectionState == ConnectionState.Connected)
                            Console.WriteLine("Latency=" + Client.Latency + ", State=" + Client.ConnectionState + ", Presence=" + Client.Status + ", User=" + Client.CurrentUser.Username + "#" + Client.CurrentUser.Discriminator);
                        else
                            Console.WriteLine("State=" + Client.ConnectionState);
                        break;

                    // Add more possible commands here.

                    // Unknown command.
                    default:
                        Console.WriteLine("Unknown command: " + c);
                        break;
                }
            }

        }

        /// <summary>
        /// Starting async method of the application. 
        /// </summary>
        /// <returns></returns>
        static async Task StartAsync() {

            if(Token == "BOT_TOKEN_GOES_HERE") {
                Console.WriteLine("Invalid token.");
                return;
            }

            EventHandler?.UnsubscribeAll();
            EventHandler = new Event.EventHandler(Client);
            EventHandler.SubscribeAll();

            try {
                Console.WriteLine("Logging in.");
                await Client.LoginAsync(TokenType.Bot, Token, true);
                Console.WriteLine("Starting.");
                await Client.StartAsync();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }

        }

        /// <summary>
        /// Stop async method of the application. 
        /// </summary>
        /// <returns></returns>
        static async Task StopAsync() {

            Console.WriteLine("Stopping.");
            await Client.LogoutAsync();
            await Client.StopAsync();

        }

    }
}
