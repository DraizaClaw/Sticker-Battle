using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> container = new List<Card>();
    public int DeckSize;
    public int x;
    public List<Card> deck = new List<Card>();



    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;












    // Start is called before the first frame update
    void Start()
    {
        x = 0;

        for (int i = 0; i < DeckSize; i++)
        {
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardlist[x];
        }
    }

    // Update is called once per frame
    void Update()
    {



        if (DeckSize < 30)
        {
            cardInDeck1.SetActive(false);
        }
        
        if (DeckSize < 20)
        {
            cardInDeck2.SetActive(false);
        }
        
        if (DeckSize < 5)
        {
            cardInDeck3.SetActive(false);
        }
        
        if (DeckSize < 1)
        {
            cardInDeck4.SetActive(false);
        }
















    }

    public void Shuffle()
    {
        for (int i = 0; i < DeckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, DeckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }
}
