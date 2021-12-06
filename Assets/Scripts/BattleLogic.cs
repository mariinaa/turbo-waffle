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

    //Ending condition declaration

    public string winOrLose;

    public GameObject sceneLoader;
    public GameObject enemyHPbar;



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
            Debug.Log("Move 1 selected"); //good move
            goodAction();
            Debug.Log("current HP: " + currentHP);
            CheckEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2)) //neutral move
        {
            Debug.Log("Move 2 selected");
            neutralAction();
            Debug.Log("current HP: " + currentHP);
            CheckEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3)) //neutral move
        {
            Debug.Log("Move 3 selected");
            neutralAction();
            Debug.Log("current HP: " + currentHP);
            CheckEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4)) //neutral move
        {
            Debug.Log("Move 4 selected");
            neutralAction();
            Debug.Log("current HP: " + currentHP);
            CheckEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5)) //good move
        {
            Debug.Log("Move 5 selected");
            goodAction();
            Debug.Log("current HP: " + currentHP);
            CheckEnding();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6)) //neutral move
        {
            Debug.Log("Move 6 selected");
            neutralAction();
            Debug.Log("current HP: " + currentHP);
            CheckEnding();

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