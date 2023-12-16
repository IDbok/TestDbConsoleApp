namespace TestDbConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Укажите имя переменной среды, значение которой вы хотите получить
            string variableName = "DB_PASS";//"VARIABLE_NAME";// 

            // Получите значение переменной среды
            string variableValue = Environment.GetEnvironmentVariable(variableName);

            TeleBot.DbCommunication.MyBotDbContext.SetDbPasswod(variableValue);

            // Проверьте, было ли получено значение
            if (variableValue != null)
            {
                Console.WriteLine($"Значение переменной {variableName}: {variableValue}");
            }
            else
            {
                Console.WriteLine($"Переменная {variableName} не найдена");
            }

            //make sure to db connection is working
            using (var db = new TeleBot.DbCommunication.MyBotDbContext())
            {
                
            }
        }
    }
}