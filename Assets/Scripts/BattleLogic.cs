using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleLogic : MonoBehaviour
{

    //HP variable declaration

    public float fullHP = 10F;
    public float noHP = 0F;
    public float startingHP = 5F;
    public float currentHP;

    //Battle impact variable declaration

    public float goodActionImpact = 2.5F;
    public float neutralActionImpact = -1.7F;

    //Battle moveset variable declaration -- MIGHT NOT ACTUALLY NEED THIS

    public string[] goodActionList = new string[] { "good1", "good2", "good3" };
    private string[] neutralActionList = new string[] { "neutral1", "neutral2", "neutral3" };

    //Button on click declaration

    //public Button actionSelected;


    // Start is called before the first frame update
    void Start()
    {
        currentHP = startingHP;

        Debug.Log(currentHP);

        //Button btn = actionSelected.GetComponent<Button>();
        //btn.onClick.AddListener(OnMouseDown);

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Move 1 selected"); //good move
            currentHP += goodActionImpact;
            Debug.Log("current HP: " + currentHP);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2)) //good move
        {
            Debug.Log("Move 2 selected");
            currentHP += goodActionImpact;
            Debug.Log("current HP: " + currentHP);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3)) //neutral move
        {
            Debug.Log("Move 3 selected");
            currentHP += neutralActionImpact;
            Debug.Log("current HP: " + currentHP);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4)) //neutral move
        {
            Debug.Log("Move 4 selected");
            currentHP += neutralActionImpact;
            Debug.Log("current HP: " + currentHP);
        }


        if (currentHP == 10 || currentHP > 10)
        {
            Debug.Log("YOU WIN!");
        }

        else if (currentHP == 0 || currentHP < 0)
        {
            Debug.Log("Try again :(");
        }

    }



}


    

