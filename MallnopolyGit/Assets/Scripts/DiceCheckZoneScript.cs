using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour
{
    Vector3 diceVelocity;

    private void FixedUpdate()
    {
        diceVelocity = DiceScript.diceVelocity;
    }

    private void OnTriggerStay(Collider other)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (other.gameObject.name)
            {
                case "Side1":
                    DiceNumberTextScript.diceNumber = 6;
                    break;
                case "Side2":
                    DiceNumberTextScript.diceNumber = 4;
                    break;
                case "Side3":
                    DiceNumberTextScript.diceNumber = 5;
                    break;
                case "Side4":
                    DiceNumberTextScript.diceNumber = 2;
                    break;
                case "Side5":
                    DiceNumberTextScript.diceNumber = 3;
                    break;
                case "Side6":
                    DiceNumberTextScript.diceNumber = 1;
                    break;
                case "Side7":
                    DiceNumberTextScript.dice2Number = 6;
                    break;
                case "Side8":
                    DiceNumberTextScript.dice2Number = 4;
                    break;
                case "Side9":
                    DiceNumberTextScript.dice2Number = 5;
                    break;
                case "Side10":
                    DiceNumberTextScript.dice2Number = 2;
                    break;
                case "Side11":
                    DiceNumberTextScript.dice2Number = 1;
                    break;
                case "Side12":
                    DiceNumberTextScript.dice2Number = 3;
                    break;
            }
        }
    }
}
