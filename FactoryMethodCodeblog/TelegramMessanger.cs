using System;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Реализация мессенджера Телеграма.
    /// </summary>
    public class TelegramMessanger : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр мессенджера Телеграма.
        /// </summary>
        /// <param name="name"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        public TelegramMessanger(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя в Телеграме.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public override bool Authorize()
        {
            // TODO: обращение к API Телеграма для авторизации.
            // Здесь должен быть код для обращение к серверам Телеграма.
            // Для экономии времени он пропущен.
            Console.WriteLine($"Авторизация в Telegram пользователя с именем {UserName} и паролем {Password}");
            return true;
        }

        /// <summary>
        /// Создать сообщение готовое для отправки в Телеграм.
        /// Это ФАБРИЧНЫЙ МЕТОД. А точнее его конкретная реализация для Телеграма.
        /// </summary>
        /// <param name="text"> Текст сообщения Телеграма. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение Телеграма, готовое к отправке. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости, здесь можно добавить дополнительные действия.
            // Например, выполнять логирование.
            var message = new TelegramMessage(text, source, target);
            return message;
        }
    }
}
