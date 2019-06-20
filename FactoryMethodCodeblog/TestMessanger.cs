using System;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Класс эмулирующий работу с Твиттером.
    /// Позволяет авторизовываться и отправлять сообщения.
    /// </summary>
    public class TestMessanger
    {
        /// <summary>
        /// Имя пользователя. 
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// Пароль пользователя.
        /// P.S. Никогда не храните пароли пользователей в открытом виде.
        /// Используйте алгоритмы хеширования и сравнивайте хеши.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Успешность подключения и авторизации в Твиттере.
        /// </summary>
        public bool Connected { get; }

        /// <summary>
        /// Создать новый экземпляр мессенджера Твиттера и выполнить авторизацию.
        /// </summary>
        /// <param name="name"> Имя пользователя. </param>
        /// <param name="password"> Пароль польззователя. </param>
        public TestMessanger(string name, string password)
        {
            // Не забываем проверять входные параметры перед авторизацией.
            if(!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = ConnertToTwitter();
            }
            else
            {
                Connected = false;
            }
        }

        /// <summary>
        /// Отправить сообщение пользователю.
        /// </summary>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public void SendMessage(string text, string source, string target)
        {
            #region Проверяем входные аргументы на корректность
            if(string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text), "Текст сообщения не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(source), "Имя отправителя не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(target), "Имя получателя не может быть пустым.");
            }

            if (text.Length > 140)
            {
                throw new ArgumentException("Текст сообщения не может быть больше 140 символов.", nameof(text));
            }
            #endregion

            var message = new TestMessage(text, source, target);
            SendMessageToTwitter(message);
        }

        /// <summary>
        /// Отправить сообщение в Твиттере.
        /// </summary>
        /// <param name="message"> Отправляемое сообщение. </param>
        private void SendMessageToTwitter(TestMessage message)
        {
            // TODO: Обращение к API Твиттера для отправки сообщения.
            // Здесь должен быть код для обращение к серверам Твиттера.
            // Для экономии времени он проущен.
            Console.WriteLine($"Твиттер: {message.Text}");
        }

        /// <summary>
        /// Авторизация пользователя в Твиттере.
        /// </summary>
        /// <returns> Успешность авторизации. True - авторизовано. False - отказано. </returns>
        private bool ConnertToTwitter()
        {
            // TODO: обращение к API Твиттера для авторизации.
            // Здесь должен быть код для обращение к серверам Твиттера.
            // Для экономии времени он проущен.
            Console.WriteLine($"Авторизация в Твиттере пользователся с именем {UserName} и паролем {Password}");
            return true;
        }
    }
}
