using System;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Реализация мессенджера Инстаграма.
    /// </summary>
    public class InstagramMessanger : MessangerBase
    {
        /// <summary>
        /// Создать экземпляр мессенджера Инстаграма.
        /// </summary>
        /// <param name="name"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        public InstagramMessanger(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя в Инстаграме.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public override bool Authorize()
        {
            // TODO: обращение к API Инстаграма для авторизации.
            // Здесь должен быть код для обращение к серверам Инстаграма.
            // Для экономии времени он пропущен.
            Console.WriteLine($"Авторизация в Instagram пользователя с именем {UserName} и паролем {Password}");
            return true;
        }

        /// <summary>
        /// Создать сообщение готовое для отправки в Инстаграм.
        /// Это ФАБРИЧНЫЙ МЕТОД. А точнее его конкретная реализация для Инстаграма.
        /// </summary>
        /// <param name="text"> Путь к файлу картинки. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение Инстаграма, готовое к отправке. </returns>
        public override IMessage CreateMessage(string text, string source, string target)
        {
            // При необходимости, здесь можно добавить дополнительные действия.
            // Например, выполнять анализ изображений для их улучшения или обучения нейронных сетей.
            var message = new InstagramMessage(text, source, target);
            return message;
        }
    }
}
