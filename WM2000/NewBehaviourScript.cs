using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() 
    {
        ShowMainMenu("Hello Dude");

    }

    void ShowMainMenu(string greeting) { 
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Where the Whitegirls at?");
        Terminal.WriteLine("Press 1 for local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter Yourselection");
    }

    void OnUserInput(string input)
    {
        if (input == "1")
        {
            print("They are at Campbell");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
