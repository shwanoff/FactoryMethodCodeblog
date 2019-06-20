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
        }
    }
}
