using DotNetPowersBot;
using DSharpPlus;
using Microsoft.Extensions.Configuration;

var source = new CancellationTokenSource();

var config = new ConfigurationBuilder()
	.AddJsonFile("appsettings.json", true)
	.AddUserSecrets(typeof(Program).Assembly, true)
	.Build();

var client = new DiscordClient(new DiscordConfiguration
{
	Token = config["discordtoken"],
	TokenType = TokenType.Bot,
	Intents = DiscordIntents.MessageContents | DiscordIntents.GuildMessages | DiscordIntents.Guilds | DiscordIntents.DirectMessages
	// | DiscordIntents.All
});

client.AddDotNetPowersBot();

await client.ConnectAsync();

var token = source.Token;

//source.Cancel();

while (!token.IsCancellationRequested)
{
	await Task.Delay(100);
}
