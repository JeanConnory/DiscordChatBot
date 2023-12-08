using DSharpPlus;

namespace DotNetPowersBot;

public static class DiscordExtensions
{
    private static DotNetPowersBot _TheBot;

    public static DiscordClient AddDotNetPowersBot(this DiscordClient client)
    {
        _TheBot = new DotNetPowersBot();
        _TheBot.Initialize(client);
        return client;
    }
}
