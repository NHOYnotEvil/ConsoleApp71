namespace ConsoleApp71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float silversToGolds = 100,
                silversToCrystals = 10000,
                goldsToSilvers = Convert.ToSingle(1.0) / 100,
                goldsToCrystals = 100,
                crystalsToSilvers = Convert.ToSingle(1.0) / 10000,
                crystalsToGolds = Convert.ToSingle(1.0) / 100;
            float silvers;
            float golds;
            float crystals;
            string userInput;
            float currencyCount;
            bool isUserExit = false;

            Console.WriteLine("Добро пожаловать в банк нашей игры. Тут вы можете обменять свои валюты.");

            Console.Write("Введите баланс серебра:");
            silvers = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс золота:");
            golds = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс кристаллов:");
            crystals = Convert.ToSingle(Console.ReadLine());

            while (isUserExit == false)
            {
                const string CommandSilversToGolds = "1";
                const string CommandSilversToCrystals = "2";
                const string CommandGoldsToSilvers = "3";
                const string CommandGoldsToCrystals = "4";
                const string CommandCrystalsToSilvers = "5";
                const string CommandCrystalsToGolds = "6";
                const string CommandExit = "exit";

                Console.WriteLine(CommandSilversToGolds + " - обменять серебро на золото.");
                Console.WriteLine(CommandSilversToCrystals + " - обменять серебро на кристаллы.");
                Console.WriteLine(CommandGoldsToSilvers + " - обменять золото на серебро.");
                Console.WriteLine(CommandGoldsToCrystals + " - обменять золото на кристаллы.");
                Console.WriteLine(CommandCrystalsToSilvers + " - обменять кристаллы на серебро.");
                Console.WriteLine(CommandCrystalsToGolds + " - обменять кристаллы на золото.");
                Console.WriteLine(CommandExit + " - выйти из банка.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSilversToGolds:
                        Console.WriteLine("Обмен серебра на золото.");
                        Console.Write("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (silvers >= currencyCount)
                        {
                            silvers -= currencyCount;
                            golds += currencyCount / silversToGolds;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает серебра.");
                        }
                        break;

                    case CommandSilversToCrystals:
                        Console.WriteLine("Обмен серебра на кристаллы.");
                        Console.Write("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (silvers >= currencyCount)
                        {
                            silvers -= currencyCount;
                            crystals += currencyCount / silversToCrystals;
                        }
                        break;

                    case CommandGoldsToSilvers:
                        Console.WriteLine("Обмен золота на серебро.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (golds >= currencyCount)
                        {
                            golds -= currencyCount;
                            silvers += currencyCount / goldsToSilvers;
                        }
                        break;

                    case CommandGoldsToCrystals:
                        Console.WriteLine("Обмен золота на кристаллы.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (golds >= currencyCount)
                        {
                            golds -= currencyCount;
                            crystals += currencyCount / goldsToCrystals;
                        }
                        break;

                    case CommandCrystalsToSilvers:
                        Console.WriteLine("Обмен кристаллов на серебро.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (crystals >= currencyCount)
                        {
                            crystals -= currencyCount;
                            silvers += currencyCount / crystalsToSilvers;
                        }
                        break;

                    case CommandCrystalsToGolds:
                        Console.WriteLine("Обмен кристаллов на золото.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (crystals >= currencyCount)
                        {
                            crystals -= currencyCount;
                            golds += currencyCount / crystalsToGolds;
                        }
                        break;

                    case CommandExit:
                        isUserExit = true;
                        break;
                }

                Console.WriteLine("Ваш балланс: " + silvers + " серебра, " + golds + " золота, " + crystals + " кристаллов.");
            }
        }
    }
}