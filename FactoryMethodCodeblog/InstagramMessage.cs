using System;
using System.IO;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Реализация сообщения Инстаграма.
    /// Принимает сообщение в виде картинки.
    /// </summary>
    public class InstagramMessage : MessageBase
    {
        /// <summary>
        /// Создать новый экземпляр сообщения Инстаграма.
        /// </summary>
        /// <param name="text"> Путь к файлу изображения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public InstagramMessage(string text, string source, string target) : base(text, source, target)
        {
            if(File.Exists(text))
            {
                var imageBytes = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageBytes);
                Text = base64String;
            }
        }

        /// <summary>
        /// Отправить сообщение Инстаграм.
        /// </summary>
        public override void Send()
        {
            // TODO: Обращение к API Инстаграма для отправки сообщения.
            // Здесь должен быть код для обращение к серверам Инстаграма.
            // Для экономии времени он пропущен.
            Console.WriteLine($"Instagram: Фото от @{Source} для @{Target}: {Text}");
        }
    }
}
