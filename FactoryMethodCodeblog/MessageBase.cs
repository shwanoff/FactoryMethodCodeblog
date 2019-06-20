using System;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Вспомогательный абстрактный класс для сообщения, 
    /// который помогает сократить количество кода и уменьшить его дублирования.
    /// Наследовать именно его - совсем не обязательно, достаточно реализовать интерфейс IMessage.
    /// Но он помогает немного сократить количество дублируемого кода, 
    /// за счет того, что не нужно объявлять свойства и конструктор.
    /// </summary>
    public abstract class MessageBase : IMessage
    {
        /// <summary>
        /// Текст сообщения. 
        /// </summary>
        public string Text { get; protected set; }

        /// <summary>
        /// Получатель сообщения.
        /// </summary>
        public string Target { get; }

        /// <summary>
        /// Отправитель сообщения.
        /// </summary>
        public string Source  { get; }

        /// <summary>
        /// Создать новый экземпляр сообщения.
        /// </summary>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public MessageBase(string text, string source, string target)
        {
            #region Проверяем входные аргументы на корректность
            if (string.IsNullOrWhiteSpace(text))
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
            #endregion

            Text = text;
            Source = source;
            Target = target;
        }

        /// <summary>
        /// Отправить сообщение.
        /// </summary>
        public abstract void Send();
    }
}
