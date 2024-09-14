

namespace ConsoleApp1;

public class Player
{
    private List<Card> _cards;

    public Player()
    {
        _cards = new List<Card>();
    }

    public void TakeCard(Card card)
    {
        _cards.Add(card);
    }
    
    public void ShowDeck()
    {
        foreach (Card card in _cards)
        {
            Console.WriteLine(card);
        }
    }

    public int Quantity()
    {
        return _cards.Count;
    }
}

