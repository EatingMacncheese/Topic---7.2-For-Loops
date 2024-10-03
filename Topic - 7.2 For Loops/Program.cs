namespace Topic___7._2_For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTo;
            int countBy;
            int countFrom;
            Console.WriteLine("count to number");
            int.TryParse(Console.ReadLine(), out countTo);
            
            for (int i = 1; i <= countTo; i = i + 1)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            Console.WriteLine("number counter");
            Console.Write("count to: ");
            int.TryParse(Console.ReadLine(), out countTo);
            Console.Write("count by: ");
            int.TryParse((string)Console.ReadLine(), out countBy);
            Console.Write("count from: ");
            int.TryParse(Console.ReadLine(), out countFrom);
            for (int i = countFrom; i <= countTo; i = i + countBy)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
