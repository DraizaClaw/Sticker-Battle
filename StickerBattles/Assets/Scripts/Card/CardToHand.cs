using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardToHand : MonoBehaviour
{

    private GameObject Hand; //in tutorial it wasnt hide and was public
    [SerializeField] private GameObject HandCard;


    // Update is called once per frame
    private void Update()
    {
        Hand = GameObject.Find("Hand");
        HandCard.transform.SetParent(Hand.transform);
        HandCard.transform.localScale = Vector3.one;
        HandCard.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        HandCard.transform.eulerAngles = new Vector3(25,0,0);

    }
}
