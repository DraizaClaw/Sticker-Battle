using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnSystem : MonoBehaviour
{
    //i need to test if there is a point to keeping them public, if yes then make sure there is a point in keeping them editable from unity
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

        manatext.text = ("Mana = ")+currentmana.ToString();

        if (Input.GetKeyDown(KeyCode.E) && currentmana > 0) // testing purposes only
        {
            currentmana -= 1;
        }
    }

    public void EndYourTurn()
    {
        if (IsYourTurn == true)
        {
            IsYourTurn = false;
            OpponentTurn += 1;
        }
        
    }
    public void EndOpponentTurn()
    {
        if (IsYourTurn == false)
        {
            IsYourTurn = true;
            YourTurn += 1;

            currentmana += 1;

            startTurn = true;
        }
        
    }

}
