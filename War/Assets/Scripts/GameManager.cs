using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    private List<Card> startingDeck;
    private Queue<Card> playerDeck;
    private Queue<Card> opponentDeck;
    private readonly int NUM_OF_SUITS = 4;
    private readonly int NUM_OF_CARDS_IN_SUIT = 13;


    // Start is called before the first frame update
    void Start()
    {
        startingDeck = new List<Card>();
        playerDeck = new Queue<Card>();
        opponentDeck = new Queue<Card>();

        for (int i = 0; i < NUM_OF_SUITS; i++)
        {
            Card.Suit tempSuit = Card.Suit.none;

            switch (i)
            {
                case 0 : tempSuit = Card.Suit.heart;
                    break;
                case 1 : tempSuit = Card.Suit.spade;
                    break;
                case 2 : tempSuit = Card.Suit.diamond;
                    break;
                case 3 : tempSuit = Card.Suit.club;
                    break;
            }

            for (int j = 0; j < NUM_OF_CARDS_IN_SUIT; j++)
            {
                //startingDeck.Enqueue(new Card(j+1, tempSuit));
                startingDeck.Add(new Card(j+1, tempSuit));
            }
            
        }

        while (startingDeck.Count > 0)
        {
            int random = Random.Range(0, startingDeck.Count - 1);
            playerDeck.Enqueue(startingDeck[random]);
            startingDeck.RemoveAt(random);
            random = Random.Range(0, startingDeck.Count - 1);
            opponentDeck.Enqueue(startingDeck[random]);
            startingDeck.RemoveAt(random);
        }
        Debug.Log("playerDeck size = " + playerDeck.Count);
        foreach (var card in playerDeck)
        {
            Debug.Log(card.ToString());
        }
        Debug.Log("opponentDeck size = " + playerDeck.Count);
        foreach (var card in opponentDeck)
        {
            Debug.Log(card.ToString());
        }

    }
    
}
