using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown()
    {

        Debug.Log("You've clicked the mouse down");

        if (gameObject.tag == "good")
        {
            Debug.Log("you've clicked a good action");
        }

        else if (gameObject.tag == "neutral")
        {
            Debug.Log("You've clicked a neutral action");
        }
    }
}


