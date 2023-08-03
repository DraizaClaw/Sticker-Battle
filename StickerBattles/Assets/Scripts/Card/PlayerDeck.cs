using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class PlayerDeck : MonoBehaviourPunCallbacks
{
    [Header("Stuff Mohsen Cannot Edit")]

    public List<Card> container = new List<Card>();


    public static int DeckSize; //Passed my 'is it worthy enough not to get deleted test'


    private int x; //was pulic  now private,


    public List<Card> deck = new List<Card>();



    public static List<Card> staticdeck = new List<Card>();

    public GameObject CardPrefab;




    // remind me to change the name

    public GameObject CardToHand; 

    //public GameObject[] Clones; // this usseless ?????????

    public GameObject Hand;







    [Header ("Stuff Mohsen Can Edit")]



    [SerializeField] private GameObject cardInDeck0;
    [SerializeField] private GameObject cardInDeck1;
    [SerializeField] private GameObject cardInDeck2;
    [SerializeField] private GameObject cardInDeck3;
    [SerializeField] private GameObject cardInDeck4;
    [SerializeField] private GameObject cardInDeck5;

    [SerializeField] private int handcards;


    [SerializeField] private Text DeckText;

    // Start is called before the first frame update
    void Start()
    {

        Hand = GameObject.Find("Hand");







        x = 0;
        DeckSize = deck.Count;
        for (int i = 0; i < DeckSize; i++)
        {
            x = Random.Range(1, 20);
            deck[i] = CardDatabase.cardlist[x];
        }
        //this for loop fills in the deck with random cards from our database



        StartCoroutine(StartGame());
        //this draws on the first x cards

    }

    // Update is called once per frame
    void Update()
    {

        staticdeck = deck;



        DeckText.text = DeckSize.ToString();


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
        for (int i = 0; i < handcards; i++) //code to control how many cards are in hand at the beggining of game //it was for(int i = 1; i < handcards + 1; i++)
        {
            yield return new WaitForSeconds(1);

            GameObject card = PhotonNetwork.Instantiate(CardPrefab.name, transform.position, Quaternion.identity);

            //GameObject card = Instantiate(CardToHand, transform.position, transform.rotation);
            card.transform.SetParent(Hand.transform, false);
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



    public void DrawCard(int x)
    {
        StartCoroutine(Draw(x));
    }
    //testing purposes but may implement it as a mechanic later



    IEnumerator Draw(int x)
    {
        for (int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(1);

            GameObject card = PhotonNetwork.Instantiate(CardPrefab.name, transform.position, transform.rotation);


            //GameObject card = Instantiate(CardToHand, transform.position, transform.rotation);
            card.transform.SetParent(Hand.transform, false);
        }
    }
}
