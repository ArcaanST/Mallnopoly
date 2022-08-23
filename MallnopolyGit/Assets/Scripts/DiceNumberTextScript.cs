using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour
{
    Text text;
    public static int diceNumber;
    public static int dice2Number;
    public int dices;

    //public int Num1;
    //public int Num2;
    

    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        dices = diceNumber + dice2Number;
        text.text = dices.ToString();

        //Num1 = diceNumber;
        //Num2 = dice2Number;
        
    }
}
