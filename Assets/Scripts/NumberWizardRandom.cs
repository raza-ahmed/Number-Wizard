using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardRandom : MonoBehaviour
{
    int max, min, guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            GuessNumber();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            GuessNumber();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Your number is" + guess);
            print("=================================");
            Start();
        }
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(min, max);
        print("Imagine a number between 1 and 1000");
        print("Is the number higher or lower than" + guess);
        print("UP=Higher, DOWN=Lower and RETURN=equal");
        max += 1;
    }

    void GuessNumber()
    {
        guess = Random.Range(min, max);
        print("Is the number higher or lower than" + guess);
        print("UP=Higher, DOWN=Lower and RETURN=equal");
    }
}