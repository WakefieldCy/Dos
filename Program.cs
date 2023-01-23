using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CurrentCard;
        }
    }
    class players
    {
        int start()
        {
            Console.WriteLine("What is the amount of players: ");
            int Nop = Convert.ToInt16(Console.ReadLine());

            return Nop;

        }
    }

    class cards
    {
        Random rnd = new Random();
        public string[] Deck = 
            {
            "r0" ,"r1","r2","r3","r4","r5", "r6", "r7", "r8", "r9",
            "g0", "g1", "g2", "g3", "g4", "g5", "g6", "g7", "g8", "g9",
            "b0", "b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8", "b9",
            "y0", "y1", "y2", "y3", "y4", "y5", "y6", "y7", "y8", "y9"
            };
        public string[] SpDeck = {"r+2","g+2","b+2","y+2","w+4", "rs", "gs", "bs", "ys", "w"};
        // Starting letter indicates the colour of the card
        // The number is the number of the card
        // S represents Skip
        // W indicates Wild card

        void StartCards(int Nop)
        {
            
        }
    }
}
