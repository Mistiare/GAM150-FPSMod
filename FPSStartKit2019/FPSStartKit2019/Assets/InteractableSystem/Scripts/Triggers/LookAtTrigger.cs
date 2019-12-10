// ##################################################################################################
// ##################################################################################################
// LookAtTrigger.cs
// =====================
// By Paul Hedley.  
// 6/11/2019

// An Example Activator that will run its list of IInteractors when the mouse pointer enters / leaves
// a collider attached to the object this script is attached to.

// It is intended that the object this script is attached to is enabled and disabled by a trigger. 
// (this will save using Vector3.Distance() to check valid range).
// ##################################################################################################
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTrigger : BasicTrigger
{
    // All activators need to run their Init function to get the list of child interactors.
    void Start()
    {
        Init();
    }

    void OnMouseEnter()
    {
        Activate();
    }

    void OnMouseExit()
    {
        Deactivate();
    }
}
