using System;

namespace SingleResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lottery = new Lottery();

            for (var i = 0; i < 50; i++)
            {
                lottery.EnterTicket();
            }

            Console.WriteLine();
            Console.WriteLine("Announcing winner");
            Console.WriteLine();

            lottery.AnnounceWinner();

            Console.WriteLine("Press ANY key to exit");
            Console.ReadKey();
        }
    }
}
