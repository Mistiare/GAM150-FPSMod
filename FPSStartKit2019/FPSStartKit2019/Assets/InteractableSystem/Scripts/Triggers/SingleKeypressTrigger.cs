// ##################################################################################################
// SingleKeypressTrigger.cs
//=====================
// By Paul Hedley.
// 05/11/2019

// An Example Trigger that Activates its list of Actors the first time a specific key is pressed.
// The object this trigger is on needs to be disabled and reenabled for it to detect keypresses again (to avoid multiple keypresses).
// It is intended for this script to be put on a disabled object and only enabled when detecting a keypress is required.
// ##################################################################################################

using UnityEngine;

public class SingleKeypressTrigger : BasicTrigger
{
    public KeyCode interactKey = KeyCode.E;
    bool isKeyPressed = false;

    void Start()
    {
        Init();
    }

    void OnEnable()
    {
        isKeyPressed = false;
    }

    void Update()
    {
        if(!isKeyPressed && (Input.GetKeyUp(interactKey)))
        {
            isKeyPressed = true;
            Toggle();
            //Activate();
        }
    }
}
