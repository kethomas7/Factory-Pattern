namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Subway, would you like a grilled cheese sandwich or a club sandwich?");
            var order = Console.ReadLine();


            ISandwiches sandwich = SandwichFactory.MakeSandwiches(order);

            sandwich.Description();
        }
    }
}
