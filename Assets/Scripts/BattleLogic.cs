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

    //No double moves variable declaration

    public string lastMove;

    //Battle impact variable declaration

    public float goodActionImpact = 17F;
    public float neutralActionImpact = -13F;

    //Ending condition declaration

    public string winOrLose;

    public GameObject sceneLoader;
    public GameObject enemyHPbar;

    //Turn feedback text declaration

    public Text txt;



    // Start is called before the first frame update
    void Start()
    {
        currentHP = startingHP;

        Debug.Log("the current HP is: " + currentHP);
        //sceneLoader.GetComponent<SceneLoader>().LoadEndingScene(winOrLose);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (lastMove != "Move1")
            {
                Debug.Log("Move 1 selected"); //good move
                goodAction();
                txt.text = "It was super effective!";
                Debug.Log("current HP: " + currentHP);
                lastMove = "Move1";
                CheckEnding();
            }
            else
            {
                Debug.Log("You can't play the same move twice. Please select another move.");
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2)) //neutral move
        {
            if (lastMove != "Move2")
            {
                Debug.Log("Move 2 selected");
                neutralAction();
                txt.text = "It was not effective!";
                Debug.Log("current HP: " + currentHP);
                lastMove = "Move2";
                CheckEnding();
            }
            else
            {
                Debug.Log("You can't play the same move twice. Please select another move.");
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3)) //neutral move
        {
            if (lastMove != "Move3")
            {
                Debug.Log("Move 3 selected");
                neutralAction();
                txt.text = "It was not effective!";
                Debug.Log("current HP: " + currentHP);
                lastMove = "Move3";
                CheckEnding();
            }
            
            else
            {
                Debug.Log("You can't play the same move twice. Please select another move.");
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4)) //neutral move
        {
            if (lastMove != "Move4")
            {
                Debug.Log("Move 4 selected");
                neutralAction();
                txt.text = "It was not effective!";
                Debug.Log("current HP: " + currentHP);
                lastMove = "Move4";
                CheckEnding();
            }
            else

            {
                Debug.Log("You can't play the same move twice. Please select another move.");
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5)) //good move
        {
            if (lastMove != "Move5")
            {
                Debug.Log("Move 5 selected");
                goodAction();
                txt.text = "It was super effective!";
                Debug.Log("current HP: " + currentHP);
                lastMove = "Move5";
                CheckEnding();
            }
            else
            {
                Debug.Log("You can't play the same move twice. Please select another move.");
            }
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6)) //neutral move
        {
            if (lastMove != "Move6")
            {
                Debug.Log("Move 6 selected");
                neutralAction();
                txt.text = "It was not effective!";
                Debug.Log("current HP: " + currentHP);
                lastMove = "Move6";
                CheckEnding();
            }
            
            else
            {
                Debug.Log("You can't play the same move twice. Please select another move.");
            }

        }

        
      




    }


    void CheckEnding()
    {
        if (currentHP == fullHP || currentHP > fullHP)
        {
            Debug.Log("YOU WIN!");
            winOrLose = "win";
            sceneLoader.GetComponent<SceneLoader>().LoadEndingScene(winOrLose); //execute LoadEndingScene function from SceneLoader.cs *******??????
        }

        else if (currentHP == noHP || currentHP < noHP)
            {
            Debug.Log("Try again :(");
            winOrLose = "lose";
            sceneLoader.GetComponent<SceneLoader>().LoadEndingScene(winOrLose); //execute LoadEndingScene function from SceneLoader.cs *******??????

        }

        else
        {
            Debug.Log("The game continues");
            Debug.Log("------------------------");
        }
    }

     void goodAction()
    {
        currentHP += goodActionImpact;
        enemyHPbar.GetComponent<HealthBar>().setHealth(currentHP);
    }   

    void neutralAction()
    {
        currentHP += neutralActionImpact;
        enemyHPbar.GetComponent<HealthBar>().setHealth(currentHP);
    }



}




//Battle moveset variable declaration -- MIGHT NOT ACTUALLY NEED THIS

//public string[] goodActionList = new string[] { "good1", "good2", "good3" };
//private string[] neutralActionList = new string[] { "neutral1", "neutral2", "neutral3" };