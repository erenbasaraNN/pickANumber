using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OyunControl : MonoBehaviour
{
    int minNumber = 1;
    int maxNumber = 100;
    int predict;
    bool gameStart = false;
    bool gameEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Would u play a game with me ? (Y/N)");
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStart)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Excellent ! Now pick a number between 1-100 then press 'ENTER' ");

            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("U KNOW :(");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Control();
                gameStart = true;
            }
        }
        else if (!gameEnd)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minNumber = predict;
                Control();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxNumber = predict;
                Control();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Yeaaah ! Found that.");
                gameEnd = true;
            }
        }
    }
    void Control()
    {
        predict = (minNumber + maxNumber) / 2;
        print("Your number was" + predict + "right ? If its bigger prees 'UP ARROW' else press 'DOWN ARROW'");
    }
}

