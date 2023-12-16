namespace TestDbConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TeleBot.DbCommunication.MyBotDbContext.SetDbPasswod(Environment.GetEnvironmentVariable("DB_PASS"));

            // make sure to db connection is working
            using (var db = new TeleBot.DbCommunication.MyBotDbContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}