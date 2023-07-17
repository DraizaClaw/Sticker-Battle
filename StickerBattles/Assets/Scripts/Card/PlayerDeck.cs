using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> container = new List<Card>();
    public static int DeckSize;
    public int x;
    public List<Card> deck = new List<Card>();
    public static List<Card> staticdeck = new List<Card>();



    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;



    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;







    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        DeckSize = 40;
        for (int i = 0; i < DeckSize; i++)
        {
            x = Random.Range(1, 4);
            deck[i] = CardDatabase.cardlist[x];
        }




        StartCoroutine(StartGame());


    }

    // Update is called once per frame
    void Update()
    {

        staticdeck = deck;







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




    IEnumerator StartGame()
    {
        for (int i = 1; i < 5; i++)
        {
            yield return new WaitForSeconds(1);
            //new //again for some reason
            Instantiate(CardToHand, transform.position, transform.rotation);
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
