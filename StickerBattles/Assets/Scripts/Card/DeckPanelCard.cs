using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPanelCard : MonoBehaviour
{
    [SerializeField] private GameObject CardBack;


    private void Update()
    {
        CardBack.SetActive(true);
    }
}
