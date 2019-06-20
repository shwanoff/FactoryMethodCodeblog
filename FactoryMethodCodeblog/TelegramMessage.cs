using System;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Реализация сообщения Телеграм.
    /// Принимает сообщения любой длины.
    /// </summary>
    public class TelegramMessage : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Телеграм.
        /// </summary>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public TelegramMessage(string text, string source, string target) : base(text, source, target) { }

        /// <summary>
        /// Отправить сообщение Телеграм.
        /// </summary>
        public override void Send()
        {
            // TODO: Обращение к API Телеграма для отправки сообщения.
            // Здесь должен быть код для обращение к серверам Телеграма.
            // Для экономии времени он проущен.
            Console.WriteLine($"Telegram: Текст от @{Source} для @{Target}: {Text}");
        }
    }
}
