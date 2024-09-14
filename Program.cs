using static System.Console;
using ConsoleApp1;
Deck deck = new Deck();
Player player = new Player();
deck.ShuffleDeck();
while (true)
{
    Run(player, deck);
}
static bool Run(Player player, Deck deck)
{
    bool run = true;
    WriteLine("Will you take the card? (E - Exit)");
    ConsoleKeyInfo key = ReadKey(false);
    WriteLine();
    switch (key.Key)
    {
        case ConsoleKey.Y:
            player.TakeCard(deck.DealedCard());
            WriteLine($"Hands:{player.Quantity()}  Deck:{deck.Quantity()}");
            break;
        
        case ConsoleKey.N:
            WriteLine("You got the following cards:");
            player.ShowDeck();
            run = false;
            break;
            
        case ConsoleKey.E:
            Environment.Exit(0);
            break;
    }

    return run;
}
