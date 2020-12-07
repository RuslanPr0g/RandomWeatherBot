using Telegram.Bot;
using Telegram.Bot.Types;

namespace RandWeatherBot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            // TODO: do bot logic

            await client.SendTextMessageAsync(chatId, "хотите ли вы продолжить свою жизнь?", replyToMessageId: messageId);
        }
    }
}