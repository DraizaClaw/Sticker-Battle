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



public class Card
{
    public int id;
    public int health;
    public int attack;
    public int defence;
    public string cardname;
    public string carddescription;
    public string magic;
    public string magicdescription;
    public Sprite spriteImage;

    public Card()
    {

    }

    public Card(int Id,int Health,int Attack,int Defence,string CardName, string CardDescription, string Magic, string MagicDescription, Sprite SpriteImage)
    {
        id = Id;
        health = Health;
        attack = Attack;
        defence = Defence;
        cardname = CardName;
        carddescription = CardDescription;
        magic = Magic;
        magicdescription = MagicDescription;
        spriteImage = SpriteImage;
    }


}
