using System;

class CardComparer_bySuit : IComparer<Card>
{
    public int Compare(Card x, Card y)
    {
        if (x.Suit > y.Suit)
        
            return 1;
        
        if (x.Suit < y.Suit)
        
            return -1;
        
        if (x.Value > y.Value)
        
            return 1;
        
        if (x.Value < y.Value)
         
            return -1;
        return 0;

    }

    Deck deck1;
    Deck deck2;
    Randon random = new Random();

   