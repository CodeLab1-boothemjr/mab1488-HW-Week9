using System;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public enum Suit
    {
        none,
        heart,
        spade,
        diamond,
        club
    }

    private Suit suit;
    private int val;

    public Card(int newVal, Suit newSuit)
    {
        
        this.val = newVal;
        this.suit = newSuit;
        
    }

    public override string ToString()
    {
        return this.val + " of " + suit.ToString() + "s";
    }
}


