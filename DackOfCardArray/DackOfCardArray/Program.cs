using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DackOfCardArray
{
    public class Program
    {
        
        static void Main(string[] args)
        {
           string[] players = { "Peter", "Rio", "George", "Francis" };
            bool s = true;
            Deck deck1 = new Deck();
            deck1.Shuffle();

                for (int i = 0; i < 36; i++)
                {
                    Console.WriteLine(deck1.DealCard());
                    if ((i + 1) % 9 == 0)
                        Console.WriteLine();
                }
            Console.ReadLine();
        }
    }
}
