namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Базовый интерфейс, который должен реализовывать любой тип сообщений мессенджера.
    /// Для того, чтобы добавить новый тип сообщений мессенджера
    /// необходимо реализовать пару интерфейсов:
    /// IMessage (этот) - для типа сообщения и IMessenger - для подключения к API мессенджера.
    /// </summary>
    public interface IMessage
    {
        string Text { get; }
        string Target { get; }
        string Source { get; }
        void Send();
    }
}
