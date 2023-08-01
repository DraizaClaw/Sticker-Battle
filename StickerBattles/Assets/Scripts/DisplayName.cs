using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class DisplayName : MonoBehaviourPunCallbacks
{

    private InputField Username;

    private void Awake()
    {

        GameObject.Find("Username").GetComponent<InputField>().text = PlayerPrefs.GetString("Username");
    }





}
