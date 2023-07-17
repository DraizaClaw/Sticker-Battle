using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPanelCard : MonoBehaviour
{
    public GameObject CardBack;


    private void Update()
    {
        CardBack.SetActive(true);
    }
}
