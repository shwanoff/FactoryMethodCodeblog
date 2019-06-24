using System;

namespace FactoryMethodCodeblog
{
    class Program
    {
        static void Main(string[] args)
        {
            var messanger = new TestMessanger("CODE BLOG", "password"); // НИКОГДА не используйте такой пароль!!!
            messanger.SendMessage("Hello, World!", "CODE BLOG", "АйТиБорода");

            var twitter = new TwitterMessanger("CODE BLOG", "password");
            var twit = twitter.CreateMessage("Hi, Bro!", "CODE BLOG", "Soer");
            twit.Send();

            var instagram = new InstagramMessanger("CODE BLOG", "password");
            var photo = instagram.CreateMessage("win.jpg", "CODE BLOG", "Winderton");
            photo.Send();

            var telegram = new TelegramMessanger("CODE BLOG", "password");
            var text = telegram.CreateMessage("Hi, Man!", "CODE BLOG", "howdyho");
            text.Send();

            Console.ReadLine();

            // Создаем конкретного создателя и помещаем его в обобщенного создателя.
            // Обратите внимание, что конкретных создателей может быть много,
            // но за счет полиморфизма их можно помещать в базовый тип создателя
            // и работать с ними обособившись от конкретных реализаций.
            Creator creator = new ConcreteCreator();

            // Создаем конкретный продукт и помещаем его в обобщенный продукт.
            // Обратите внимание, что мы работаем с обобщенным создателем и обобщенным продуктом,
            // но за счет полиморфизма будет вызываться реализация конкретного создатели 
            // и получен конкретный продукт, но он будет помещен в обобщенный продукт.
            // Это позволит нам работать с продуктами обособившись от конкретных реализаций.
            IProduct product = creator.FactoryMethod();

            // Вызываем какое-либо действие обобщенного продукта, 
            // но за счет полиморфизма будет вызываться реализация этого метода в конкретном продукте.
            product.DoWork();
        }
    }
}
