using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleResponsibility
{
    public class Lottery
    {
        private readonly List<int> _tickets;
        private readonly Random _random;

        public Lottery()
        {
            _tickets = new List<int>();
            _random = new Random();
        }

        public void EnterTicket()
        {
            var ticketNumber = _tickets.Count + 1;
            _tickets.Add(ticketNumber);

            Console.WriteLine($"Entered ticket {ticketNumber} to lottery!");
        }

        public void AnnounceWinner()
        {
            var winningTicket = _random.Next(1, _tickets.Max());

            Console.WriteLine($"The winner is: {winningTicket}");
        }
    }
}
