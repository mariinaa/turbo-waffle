using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleLogic : MonoBehaviour
{

    //HP variable declaration

    public float fullHP = 100F;
    public float noHP = 0F;
    public float startingHP = 50F;
    public float currentHP;

    //Battle impact variable declaration

    public float goodActionImpact = 17F;
    public float neutralActionImpact = -13F;

    //Battle moveset variable declaration -- MIGHT NOT ACTUALLY NEED THIS

    public string[] goodActionList = new string[] { "good1", "good2", "good3" };
    private string[] neutralActionList = new string[] { "neutral1", "neutral2", "neutral3" };





    // Start is called before the first frame update
    void Start()
    {
        currentHP = startingHP;

        Debug.Log("the current HP is: " + currentHP);

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
            checkEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2)) //neutral move
        {
            Debug.Log("Move 2 selected");
            currentHP += neutralActionImpact;
            Debug.Log("current HP: " + currentHP);
            checkEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3)) //neutral move
        {
            Debug.Log("Move 3 selected");
            currentHP += neutralActionImpact;
            Debug.Log("current HP: " + currentHP);
            checkEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4)) //neutral move
        {
            Debug.Log("Move 4 selected");
            currentHP += neutralActionImpact;
            Debug.Log("current HP: " + currentHP);
            checkEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5)) //good move
        {
            Debug.Log("Move 5 selected");
            currentHP += goodActionImpact;
            Debug.Log("current HP: " + currentHP);
            checkEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6)) //neutral move
        {
            Debug.Log("Move 6 selected");
            currentHP += neutralActionImpact;
            Debug.Log("current HP: " + currentHP);
            checkEnding();

        }

        
      




    }


    void CheckEnding()
    {
        if (currentHP == fullHP || currentHP > fullHP)
        {
            Debug.Log("YOU WIN!");
            //maybe a scene change here?
        }

        else if (currentHP == noHP || currentHP < noHP)
            {
            Debug.Log("Try again :(");
            //maybe a scene change here?
            }

        else
        {
            Debug.Log("The game continues");
            Debug.Log("------------------------");
        }
    }

        

    



}


    

