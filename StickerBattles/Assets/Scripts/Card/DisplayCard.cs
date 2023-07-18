using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> Display_Card = new List<Card>();

    public int displayId;

    public int id;
    public int health;
    public int attack;
    public int defence;
    public string cardname;
    public string carddescription;
    public string magic;
    public string magicdescription;
    public Sprite spriteImage;


    public Text healthtext;
    public Text attacktext;
    public Text Defencetext;
    public Text nametext;
    public Text descriptiontext;
    public Text magictext;
    public Text magicdescriptiontext;
    public Image artImage;





    public bool cardBack;
    public static bool staticCardBack;





    public GameObject Hand;
    public int CardInDeck;








    // Start is called before the first frame update
    void Start()
    {


        CardInDeck = PlayerDeck.DeckSize;







        Display_Card[0] = CardDatabase.cardlist[displayId];








    }

    // Update is called once per frame
    void Update()
    {




        id = Display_Card[0].id;
        health = Display_Card[0].health;
        attack = Display_Card[0].attack;
        defence = Display_Card[0].defence;
        cardname = Display_Card[0].cardname;
        carddescription = Display_Card[0].carddescription;
        magic = Display_Card[0].magic;
        magicdescription = Display_Card[0].magicdescription;
        spriteImage = Display_Card[0].spriteImage;


        healthtext.text = " " + health;
        attacktext.text = " " + attack;
        Defencetext.text = " " + defence;
        nametext.text = " " + cardname;
        descriptiontext.text = " " + carddescription;
        magictext.text = " " + magic;
        magicdescriptiontext.text = " " + magicdescription;
        artImage.sprite = spriteImage;





        Hand = GameObject.Find("Hand");
        if (this.transform.parent == Hand.transform.transform.parent)
        {
            cardBack = false;
        }




        staticCardBack = cardBack;

        if (this.tag == "Clone")
        {
            Display_Card[0] = PlayerDeck.staticdeck[CardInDeck - 1];
            CardInDeck -= 1;
            PlayerDeck.DeckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }
    }
}
