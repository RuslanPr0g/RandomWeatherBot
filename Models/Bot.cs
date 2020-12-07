using System.Threading.Tasks;
using Telegram.Bot;

namespace RandWeatherBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;

        public static async Task<TelegramBotClient> Get()
        {
            if ((client is null) == false)
            {
                return client;
            }

            client = new TelegramBotClient(AppSettings.Key);
            await client.SetWebhookAsync("");

            return client;
        }
    }
}