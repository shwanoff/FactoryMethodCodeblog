using System;

namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Пакет сообщения.
    /// Содержит всю необходимую информацию для отпрвки.
    /// </summary>
    public class TestMessage
    {
        /// <summary>
        /// Текст сообщения.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Получатель сообщения.
        /// </summary>
        public string Target { get; }

        /// <summary>
        /// Отправитель сообщения.
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// Создать новый экземпляр сообщения.
        /// </summary>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="source"> Отправитель. </param>
        /// <param name="target"> Получатель. </param>
        public TestMessage(string text, string source, string target)
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


            // Количество символов в сообщении Твиттера ограничено 140.
            // Все что больше - просто игнорируем.
            if(text.Length <= 140)
            {
                Text = text;
            }
            else
            {
                Text = text.Substring(0, 140);
            }
            Source = source;
            Target = target;
        }
    }
}
