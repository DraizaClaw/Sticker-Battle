using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardlist = new List<Card>();

    private void Awake()
    {
        // id - health - attack - defense - card name - card description - magic - magic description - sprite(image)
        cardlist.Add(new Card(0, 0, 0, 0, "None", "None", "None", "None", Resources.Load<Sprite>("Player 0")    ));
        cardlist.Add(new Card(1, 2, 5, 1, "Card1", "This has id number 1", "run", "This is a random thing run ", Resources.Load<Sprite>("Run 0")  ));
        cardlist.Add(new Card(2, 5, 1, 5, "Card2", "This has id number 2", "lie", "This is a random thing lie ", Resources.Load<Sprite>("Player 0")  ));
        cardlist.Add(new Card(3, 3, 3, 3, "Card3", "This has id number 3", "die", "This is a random thing die ", Resources.Load<Sprite>("Run 0")  ));
        cardlist.Add(new Card(4, 5, 0, 7, "Card4", "This has id number 4", "die", "This is a random thing bye ", Resources.Load<Sprite>("Player 0")  ));






    }
}
