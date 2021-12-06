using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public int moveNumber;

    // Start is called before the first frame update
    void effectiveReport()
    {
        switch (moveNumber)
        {
            case 1:
                debug.log("That move was super effective!");
                break;

            case 2:
                debug.log("That move was super effective!");
                break;

            case 3:
                debug.log("That was somewhat effective.");
                break;

            case 4:
                debug.log("that was somewhat effective.");
                break;

            case 5:
                debug.log("That was not effective.");
                break;

            case 6:
                debug.log("That was not effective.");
                break;
        }
    }
}
