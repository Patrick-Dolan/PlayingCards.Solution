using System.Collections.Generic;
using System;

namespace PlayingCards.Models
{
  public class Deck
  {
    public List<Card> Cards { get; set; } = new List<Card> {};
    public List<Card> ShuffledCards { get; set; } = new List<Card> {};

    public Deck()
    {
      GenerateDeck();
      ShuffledCards = new List<Card>(Cards);
      ShuffleDeck();
    }

    private void GenerateDeck()
    {
      List<string> suits = new List<string> {"Hearts", "Diamonds", "Clubs", "Spades"};
      List<string> values = new List<string> {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

      foreach (string suit in suits)
      {
        foreach (string value in values)
        {
          Card newCard = new Card(value, suit);
          Cards.Add(newCard);
        }
      }
    }

    private void ShuffleDeck()
    {
      Random r = new Random();
      for (int n = ShuffledCards.Count - 1; n > 0; --n)
      {
        int k = r.Next(n + 1);

        Card temp = ShuffledCards[n];
        ShuffledCards[n] = ShuffledCards[k];
        ShuffledCards[k] = temp;
      }
    }
  }
}