using System;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Реализация сообщения Твиттера.
    /// Принимает сообщения длиной 140 символов.
    /// </summary>
    public class TwitterMessage : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Твиттера.
        /// </summary>
        /// <param name="text"> Текст сообщения до 140 символов. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
            if(text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
        }

        /// <summary>
        /// Отправить сообщение Твиттера.
        /// </summary>
        public override void Send()
        {
            // TODO: Обращение к API Твиттера для отправки сообщения.
            // Здесь должен быть код для обращение к серверам Твиттера.
            // Для экономии времени он проущен.
            Console.WriteLine($"Twitter: Твит от @{Source} для @{Target}: {Text}");
        }
    }
}
