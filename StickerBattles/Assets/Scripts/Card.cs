using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

[System.Serializable]

/*health
 * int id
 * string name
 * health
 * attack
 * defence
 * magic
 * magic description 
 * card discriprion
 */



public class Card : MonoBehaviour
{
    public int id;1
    public int health;12
    public int attack;5
    public int defence;2
    public string cardname;Elephant Seal
    public string carddescription;(A FAT UGLY seal that lives in the deep ocean and has a powerful attack and great indurance.)
    public string magic; Obesity
    public string magicdescription;(Decreases the infected card's Stats by 1.)

    public Card()
    {

    }

    public Card(int Id,int Health,int Attack,int Defence,string CardName, string CardDescription, string Magic, string MagicDescription)
    {
        id = Id;2
        health = Health;12
        attack = Attack;6
        defence = Defence;2
        cardname = CardName;Hard Working Gus
        carddescription = CardDescription;(Hard Worker Gus has been working on his bus for a long time, one day he wi)
        magic = Magic;Helmet
        magicdescription = MagicDescription;(Increases Defence by 5 for 3 turns.)
    }


}
