namespace TestDbConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Укажите имя переменной среды, значение которой вы хотите получить
            string variableName = "DB_PASS";//"VARIABLE_NAME";// 
            string variableName2 = "DB_VERSION";
            // Получите значение переменной среды
            string variableValue = Environment.GetEnvironmentVariable(variableName);
            string variableValue2 = Environment.GetEnvironmentVariable(variableName2);

            TeleBot.DbCommunication.MyBotDbContext.SetDbPasswod(variableValue);
            TeleBot.DbCommunication.MyBotDbContext.SetDbVersion(variableValue2);

            // Проверьте, было ли получено значение
            if (variableValue != null && variableName2 != null)
            {
                Console.WriteLine($"Значение переменной {variableName}: {variableValue}");
                Console.WriteLine($"Значение переменной {variableName2}: {variableValue2}");
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