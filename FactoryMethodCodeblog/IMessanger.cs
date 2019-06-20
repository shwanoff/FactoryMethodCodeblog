namespace FactoryMethodCodeblog
{
    /// <summary>
    /// Базовый интерфейс, который должен реализовать любой мессенджер.
    /// Для того, чтобы добавить новый мессенждер, необходимо реализовать два интерфейса:
    /// IMessanger (этот) - для мессенжера и IMessage - для сообщения этого мессенджера.
    /// </summary>
    public interface IMessanger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }
        IMessage CreateMessage(string text, string source, string target);
        bool Authorize();
    }
}
