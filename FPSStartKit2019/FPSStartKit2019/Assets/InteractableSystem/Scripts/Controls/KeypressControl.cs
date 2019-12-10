using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypressControl : MonoBehaviour
{

    //[HideInInspector]
    public InteractionControl control;

    // Update is called once per frame.  The object is enabled by the InteracationControl script so the update loop will only run when
    // the player is in range and looking in the right place.
    void Update()
    {
        
        if (Input.GetKeyUp(control.keyToPress))
        {
        #if UNITY_EDITOR
            Debug.Log("keypress detected.");
        #endif
            // run the triggers on the interaction control.
            control.RunTriggers();
        }
    }
}
