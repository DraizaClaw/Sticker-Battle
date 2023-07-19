using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> container = new List<Card>();
    public static int DeckSize;
    private int x; //was pulic  now private, if error presits try making this public again
    public List<Card> deck = new List<Card>();
    public static List<Card> staticdeck = new List<Card>();



    [SerializeField] private GameObject cardInDeck0;
    [SerializeField] private GameObject cardInDeck1;
    [SerializeField] private GameObject cardInDeck2;
    [SerializeField] private GameObject cardInDeck3;
    [SerializeField] private GameObject cardInDeck4;
    [SerializeField] private GameObject cardInDeck5;




    public GameObject CardToHand;
    public GameObject[] Clones;
    public GameObject Hand;


    [SerializeField] private int handcards;




    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        DeckSize = 40;
        for (int i = 0; i < DeckSize; i++)
        {
            x = Random.Range(1, 20);
            deck[i] = CardDatabase.cardlist[x];
        }




        StartCoroutine(StartGame());


    }

    // Update is called once per frame
    void Update()
    {

        staticdeck = deck;







        if (DeckSize < 35)
        {
            cardInDeck0.SetActive(false);
        }
        
        if (DeckSize < 30)
        {
            cardInDeck1.SetActive(false);
        }
        
        if (DeckSize < 25)
        {
            cardInDeck2.SetActive(false);
        }
        
        if (DeckSize < 20)
        {
            cardInDeck3.SetActive(false);
        }
        if (DeckSize < 10)
        {
            cardInDeck4.SetActive(false);
        }
        if (DeckSize < 1)
        {
            cardInDeck5.SetActive(false);
        }



        if (TurnSystem.startTurn == true)
        {
            StartCoroutine(Draw(1));
            TurnSystem.startTurn = false;
        }














    }




    IEnumerator StartGame()
    {
        for (int i = 1; i < handcards + 1; i++) //code to control how many cards are in hand at the beggining of game 
        {
            yield return new WaitForSeconds(1);
            //new //again for some reason
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }







    //the shuffle is useless for now but will have a use once we implement item cards

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
    IEnumerator Draw(int x)
    {
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(1);
            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }
}
