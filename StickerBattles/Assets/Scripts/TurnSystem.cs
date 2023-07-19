using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnSystem : MonoBehaviour
{

    public bool IsYourTurn;
    public int YourTurn;
    public int OpponentTurn;
    public Text TurnText;


//    public int maxmana; //used in tutorial but useless in my code so imma commment it out

    public int currentmana;
    public Text manatext;

    public static bool startTurn;


    void Start()
    {
        IsYourTurn = true;
        YourTurn = 1;
        OpponentTurn = 0;

        currentmana = 1;
        startTurn = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (IsYourTurn == true)
        {
            TurnText.text = ("Your Turn");
        }

        else

        {
            TurnText.text = ("Opponent Turn");
        }

        manatext.text = ("Your mana is at ")+currentmana.ToString();

        if (Input.GetKeyDown(KeyCode.E)) // testing purposes only
        {
            currentmana -= 1;
        }
    }

    public void EndYourTurn()
    {
        IsYourTurn = false;
        OpponentTurn += 1;
    }
    public void EndOpponentTurn()
    {
        IsYourTurn = true;
        YourTurn += 1;

        currentmana += 1;

        startTurn = true;
    }

}
