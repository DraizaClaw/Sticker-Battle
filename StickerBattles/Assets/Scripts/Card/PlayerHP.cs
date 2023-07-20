using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    public static float MaxHP;
    public float CurrentHP;
    public Image Circle;
    public Text HealthText;



    // Start is called before the first frame update
    void Start()
    {
        MaxHP = CurrentHP;
    }

    // Update is called once per frame
    void Update()
    {
        Circle.fillAmount = CurrentHP / MaxHP;

        if (CurrentHP >= MaxHP)
        {
            CurrentHP = MaxHP;
        }
        HealthText.text = CurrentHP.ToString();

        if (Input.GetKeyDown(KeyCode.Q)) //testing purposes only
        {
            CurrentHP += 1;
        }
        if (Input.GetKeyDown(KeyCode.W)) //testing purposes only
        {
            CurrentHP -= 1;
        }
    }
}
