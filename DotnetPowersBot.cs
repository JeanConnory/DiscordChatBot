using DSharpPlus;
using DSharpPlus.EventArgs;

namespace DotNetPowersBot;

public class DotNetPowersBot
{
    public void Initialize(DiscordClient client)
    {
        client.MessageCreated += OnMessageCreated;
    }

    private async Task OnMessageCreated(DiscordClient client, MessageCreateEventArgs args)
    {
        if (args.Message.Content.StartsWith("ping"))
        {
            await client.SendMessageAsync(args.Channel, $"Hey, don't ping me {args.Author.Mention}");
        }
    }
}
