﻿using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Policy;
using System.ComponentModel.DataAnnotations;

class Deck
{
    private List<Card> cards;
    private Random random = new Random();

    public Deck()
    {
        cards = new List<Card>();
        for (int suit = 0; suit <= 3; suit++)
            for (int value = 1; value <= 13; value++)
                cards.Add(new Card((Suits)suit, (Values)value));
    }

    public Deck(IEnumerable<Card> initialCards)
    {
        cards = new List<Card>(initialCards);
    }

    public int Count { get { return cards.Count; } }

    public void Add(Card cardToAdd) { cards.Add(cardToAdd); }

    public Card Deal(int index)
    {
        Card.CardToDeal = cards[index];
        cards.RemoveAt(index);
        return CardToDeal;
    }

    public void Shuffle()
    {
        List<cards> NewCards = new List<cards>();
        while (cards.Count > 0)
        {
            int CardToMove = random.Next(cards.Count);
            NewCards.Add(cards[CardToMove]);
            cards.RemoveAt(CardToMove);
        }
        cards = NewCards;
    }

    public IEnumerable<string> GetCardNames()
    {
        string[] CardNames = new string[cards.Count];
        for (int i = 0; i < cards.Count; i++)
            CardNames[i] = cards[i].Name;
        return CardNames;
    }
    // sort by suit
    public void Sort()
    {
        cards.Sort(new CardComparer_bySuit());
    }

    public Card Peek (int cardNumber)
    {
        return cards[cardNumber];
    }

    public Card Deal()
    {
        return Deal(0);
    }

    public bool ContainsValue(Values value)
    {
        foreach (Card card in cards)
            if (card.Value == value)
                return true;
        return false;
    }

    public Deck PullOutValues(Values value)
    {
        Deck deckToReturn = new Deck(new Card[] { });
        for (int i = cards.Count - 1; i >= 0; i--)
            if (cards[i].Value == value)
                deckToReturn.Add(Deal(i));
        return deckToReturn;
    }

    public bool HasBook(Values value)
    {
        int NumberOfCards = 0;
        foreach (Card card in cards)
            if card.Value == value)
                NumberOfCards++;
        if (NumberOfCards == 4)
            return true;
        else
            return false;
    }

    //sort by value
    public void SortByValue()
    {
        cards.Sort(new CardComparer_byValue());
    }
}