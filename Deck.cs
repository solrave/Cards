namespace ConsoleApp1;
using static Console;

public class Deck
{
   private List<Card> _cards;

   public Deck()
   {
      _cards = new List<Card>();
      foreach (Suit suit in Enum.GetValues(typeof(Suit)))
      {
         foreach (Rank rank in Enum.GetValues(typeof(Rank)))
         {
            _cards.Add(new Card(rank, suit));
         }
      }
   }

   public void ShuffleDeck()
   {
      Random rand = new Random();
      for (int i = _cards.Count - 1; i > 0; i--)
      {
         int j = rand.Next(i + 1);
         (_cards[i], _cards[j]) = (_cards[j], _cards[i]);
      }
   }

   public void ShowDeck()
   {
      foreach (Card card in _cards)
      {
         Console.WriteLine(card);
      }
   }

   public Card DealedCard()
   {
      Card temp;
      if (_cards.Count == 0)
         throw new InvalidOperationException("The deck is empty!");
      else
      {
         temp = _cards[^1];
         _cards.RemoveAt(_cards.Count - 1);
      }
      return temp;
   }
   
   public int Quantity()
   {
      return _cards.Count;
   }
   
}