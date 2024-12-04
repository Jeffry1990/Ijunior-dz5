namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystal;
            int crystalOfCost = 5;

            Console.WriteLine($"Добро пожаловать в наш магазин! Здесь вы можете купить кристаллы за {crystalOfCost} золотых");
            Console.Write("Сколько у вас золота? ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов Вы хотели купить? ");
            crystal = Convert.ToInt32(Console.ReadLine());

            gold -= crystalOfCost * crystal;

            Console.WriteLine($"У вас {gold} золота и {crystal} кристаллов");
        }
    }
}