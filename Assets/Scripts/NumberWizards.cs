using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour
{
    int min, max, guess;
    // Start is called before the first frame update
    void Start()
    {
        print("Welcome to number wizard");
        print("Pick a number in your head but don't tell me!");

        max = 1000;
        min = 1;

        print("The largest number you can pick is" + max);
        print("The smallest number you can pick is" + min);

        print("Is the number higher or lower than 500?");
        print("Up=higher, down=lower, return=equal");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = (max+min) / 2;
            print("Is the number higher or lower than" + (min + max) / 2);
            if (min == max) { print("I won" + min); }

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = (max+min) / 2;
            print("Is the number higher or lower than" +(min+max)/2);
            if (min == max) { print("I won" + min); }
        }
        
    }
}
