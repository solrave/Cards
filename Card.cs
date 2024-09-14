namespace ConsoleApp1;

public enum Rank
{
    Six = 6, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
}

public enum Suit
{
    Clubs, Diamonds, Spades, Hearts
}


public class Card
{
    private Rank _rank;
    private Suit _suit;
    
    public Card(Rank rank, Suit suit)
    {
        _rank = rank;
        _suit = suit;

    }
    
    public override string ToString()
    {
        return $"{_rank} of {_suit}";
    }
}