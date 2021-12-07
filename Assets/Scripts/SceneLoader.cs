using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    //Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "TitleScreen" && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("BattleScene");
        }

        else if (SceneManager.GetActiveScene().name == "Win" && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScreen");
        }

        else if (SceneManager.GetActiveScene().name == "Lose" && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }

    public void LoadEndingScene(string winOrLose)
    {
        if (winOrLose == "win")
        {
            StartCoroutine(LoadEnding("Win")); //need to pass win or lose scene here **********
        }
        else if (winOrLose == "lose")
        {
            StartCoroutine(LoadEnding("Lose")); //need to pass win or lose scene here **********
        }
        
    }

    IEnumerator LoadEnding(string sceneName)
    {
        //play animation
        transition.SetTrigger("Start"); //name of trigger we created inside of the animator

        //wait for animation  to stop playing
        yield return new WaitForSeconds(transitionTime);

        //load scene
        SceneManager.LoadScene(sceneName);
    }


}
