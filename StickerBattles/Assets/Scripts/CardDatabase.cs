using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardlist = new List<Card>();

    private void Awake()
    {

        cardlist.Add(new Card(0, 0, 0, 0, "None", "None", "None", "None"));
        cardlist.Add(new Card(1, 2, 5, 1, "Card1", "This has id number 1", "run", "This is a random thing run "));
        cardlist.Add(new Card(2, 5, 1, 5, "Card2", "This has id number ", "lie", "This is a random thing lie "));
        cardlist.Add(new Card(3, 3, 3, 3, "Card3", "This has id number ", "die", "This is a random thing die "));







    }
}
