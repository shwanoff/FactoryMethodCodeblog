namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Вспомогательный абстрактный класс мессенджера для сокращения количества кода.
    /// Наследовать именно его - необязательно, достаточно реализовать интерфейс IMessanger.
    /// Но он помогает сократить количество дублируемого кода
    /// за счет того, что не нежно объявлять свойства и конструктор в каждом наследнике.
    /// </summary>
    public abstract class MessangerBase : IMessanger
    {
        /// <summary>
        /// Логин пользователя.
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Успешность подключения и авторизации.
        /// </summary>
        public bool Connected { get; }

        /// <summary>
        /// Создание экземпляра мессенджера и авторизация.
        /// </summary>
        /// <param name="name"> Имя пользователя. </param>
        /// <param name="password"> Пароль пользователя. </param>
        public MessangerBase(string name, string password)
        {
            // Не забываем проверять входные параметры перед авторизацией.
            if (!(string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password)))
            {
                UserName = name;
                Password = password;
                Connected = Authorize();
            }
            else
            {
                Connected = false;
            }
        }

        /// <summary>
        /// Выполнить авторизацию в мессенджере.
        /// </summary>
        /// <returns> Успешность авторизации. </returns>
        public abstract bool Authorize();

        /// <summary>
        /// Создать сообщение готовое для отправки.
        /// Это ФАБРИЧНЫЙ МЕТОД. А если точнее интерфейс фабричного метода - объявлен, но не реализован.
        /// </summary>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="source"> Отправитель сообщения. </param>
        /// <param name="target"> Получатель сообщения. </param>
        /// <returns> Сообщение, готовое к отправке. </returns>
        public abstract IMessage CreateMessage(string text, string source, string target);
    }
}
