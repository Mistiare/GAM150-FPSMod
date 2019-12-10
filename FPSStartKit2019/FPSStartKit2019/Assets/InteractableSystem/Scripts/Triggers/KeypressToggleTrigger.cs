// ##################################################################################################
// KeypressToggleTrigger.cs
// =====================
// By Paul Hedley.  
// 6/11/2019

// An example Activator that alternates between activate and deactivate each time the key is pressed.
// ##################################################################################################
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypressToggleTrigger : BasicTrigger
{
    public KeyCode interactKey = KeyCode.E;
    bool keyPressed = false;
    void Start()
    {
        Init();
    }

    void Update()
    {
        if(Input.GetKeyUp(interactKey))
        {
            if(keyPressed)
            {
                Activate();
            }
            else
            {
                Deactivate();
            }
            keyPressed = !keyPressed;
            Debug.Log("toggle state = "+ keyPressed);
        }
    }
}
