using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CardToHand : MonoBehaviour //this script passes my 'is it worthy enough not to get deleted' test // this script will be re-evaluated // may be removed //implemented diffferent function than original purpose
{
    /*
    private GameObject Hand; //in tutorial it wasnt hide and was public
    [SerializeField] private GameObject HandCard;


    // Update is called once per frame
    private void Update()
    {

        /*
        Hand = GameObject.Find("Hand");
        HandCard.transform.SetParent(Hand.transform);
        HandCard.transform.localScale = Vector3.one;
        HandCard.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        HandCard.transform.eulerAngles = new Vector3(25,0,0);
        
        }
    */
    
    private void Awake()
    {
        if (GetComponent<PhotonView>().IsMine)
        {
            this.transform.SetParent(GameObject.Find("Hand").transform);
        }
        else
        {
            this.transform.SetParent(GameObject.Find("Opp Hand").transform);
        }
    }

}
