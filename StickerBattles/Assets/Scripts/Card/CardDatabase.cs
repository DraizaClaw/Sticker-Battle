using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardlist = new List<Card>();

    private void Awake()
    {
        // id - health - attack - defense - card name - card description - magic - magic description - sprite(image)
        cardlist.Add(new Card(0, 0, 0, 0, "None", "None", "None", "None", Resources.Load<Sprite>("Player 0")));
        cardlist.Add(new Card(1, 10, 6, 0, "ELephant Seal", "Extremely FAT seal that lives in the deep ocean and has a powerful attack.", "FAT", "decreases all stats on one card that has been placed by -1.", Resources.Load<Sprite>("Elephant Seal")    ));
        cardlist.Add(new Card(2, 8, 5, 1, "Hard Worker Gus", "HE has been working on his busa for a long time and one day he will finish it", "Helmet", "increases defence by 4", Resources.Load<Sprite>("Hard worker gus")  ));
        cardlist.Add(new Card(3, 5, 3, 7, "Shower Monkey", "Showers ALOT and doesn't have great spelling.", "Water Spray", "increases attack damage by 4 on one turn.", Resources.Load<Sprite>("Shower Monkey")  ));
        cardlist.Add(new Card(4, 10, 7, 0, "SUIIII Man", "SUUUUIIIIIIIIIIIIIIIIIIII", "SUUUIII", "allows the user to attack 2 cards at once with 3 AK damage.", Resources.Load<Sprite>("SUIII Man")  ));
        cardlist.Add(new Card(5, 5, 2, 10, "Tughebin Khamun", "THe Tribe leader of the Apokhesis Tribe and he asks alot of questions.", "Y tho...", "after using this magic ability it will stunt one card of every opponent for 2 turn but the card will perish.", Resources.Load<Sprite>("Tughebin Khamun")  ));
        cardlist.Add(new Card(6, 10, 5, 4, "Nanny", "The world's best Chef.", "None", "None.", Resources.Load<Sprite>("Nanny")));
        cardlist.Add(new Card(7, 10, 4, 4, "Mohsen and his EGG", "Mohsen has a EGG pet on his shoulder that he can consume to get powerful buffs!", "EGG Consumption", "eat an egg to get +3 attack for 2 turns but -4 health for the whole round.", Resources.Load<Sprite>("Mohsen and his EGG")));
        cardlist.Add(new Card(8, 7, 5, 3, "KADID and Gus", "KADID and Gus has been friends for a long time and now they work together as a team.", "GUUS", "Increases attack by 3 but decreases health by 2 for the whole round", Resources.Load<Sprite>("KADID and Gus")));
        cardlist.Add(new Card(9, 17, 3, 4, "Coool Gus", "Too coool", "Coool", "increases attack by 2 for 2 turns.", Resources.Load<Sprite>("Coool Gus")));
        cardlist.Add(new Card(10, 21, 2, 3, "The Love Magnet", "attracts anyone to him.", "we love you", "makes all cards against the user useless against this card for 2 turns.", Resources.Load<Sprite>("The Love Magnet")));
        cardlist.Add(new Card(11, 7, 9, 5, "BIG Foot", "Ugly and has giant feet", "BIGGER FEET", "makes any attack against this card useless for 1 turn.", Resources.Load<Sprite>("BIG Foot")));
        cardlist.Add(new Card(12, 10, 6, 5, "Rizzler Dog", "Has an insane amount of rizz.", "Rizz time", "stunts 2 of any opponents cards for 2 turns", Resources.Load<Sprite>("BIG Foot")));
        cardlist.Add(new Card(13, 15, 6, 2, "Scary Faris", "Too Terrifying", "Jumpscare", "makes opponent defence lower by 2 and magic doesnt work on him", Resources.Load<Sprite>("Scary Faris")));
        cardlist.Add(new Card(14, 10, 4, 15, "Defensive Faris", "Uses his stance as defensive mechanism", "THE STANCE", "heals HP by 4", Resources.Load<Sprite>("Defensive Faris")));
        cardlist.Add(new Card(15, 6, 11, 3, "SHHHH Man", "Shushs anything that crosses his path.", "Shuuush", "decreases all enemy cards AK damage by 1", Resources.Load<Sprite>("SHHHH Man")));
        cardlist.Add(new Card(16, 12, 6, 5, "Double Chin Mohsen", "His chin is too POWERFUL!", "quadruple chin", "steals 2 attack and 2 defence from any enemy card", Resources.Load<Sprite>("Double Chin Mohsen")));
        cardlist.Add(new Card(17, 18, 3, 4, "Stwechy BALD Mohsen", "Too stwechy", "Smiley", "blinds a enemy card", Resources.Load<Sprite>("Stwetchy BALD Mohsen")));
        cardlist.Add(new Card(18, 12, 5, 3, "The Deformed Man", "Too Deformed", "Confusion", "Confuses an enemy card", Resources.Load<Sprite>("The Deformed Man")));
        cardlist.Add(new Card(19, 14, 4, 2, "WAKE UP MAN", "WAKES UP WAAAKE UPPP", "DONT WAKE UP", "Makes an enemy card unusable for 2 turns", Resources.Load<Sprite>("WAKE UP MAN")));
        cardlist.Add(new Card(20, 5, 11, 4, "BUFF Caet", "Buffy caety caet", "BUFF", "increases the AK damage of any placed card on your deck", Resources.Load<Sprite>("BUFF Caet")));










    }
}
