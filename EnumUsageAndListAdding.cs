using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUsing
{

    public enum Suit { heart, diamond, club, spade };

    public class Card
    {
        public Card()
        {
        }
        
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public Card(Suit suit, int value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }

    class EnumUsageAndListAdding
    {
        
        static void Main()
        {

            List<Card> deck = new List<Card>();

            for (int x=0; x<4; x++)
            {
                for (int y=1; y<14; y++)
                {
                    deck.Add(new Card((Suit)x, y)); //populando o deck com as cartas, usado Cast (Suit) para permitir que Suit aceite índice inteiro                                 
                }
            }


            void showDeck()
            {
                Console.WriteLine("Número total de cartas no deck: " + deck.Count());
                foreach (Card c in deck)
                {
                    Console.WriteLine("Carta: {0} of {1}", c.Value, c.Suit);
                }

            }

            showDeck();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
