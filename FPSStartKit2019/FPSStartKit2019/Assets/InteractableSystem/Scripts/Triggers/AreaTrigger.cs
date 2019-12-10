// ##################################################################################################
// AreaTrigger.cs
//=====================
// By Paul Hedley.
// 05/11/2019

// This script makes a collection of all scripts on child objects that use the IInteractor interface (see IInteractor.cs).
// When the player enters the trigger, all child IInteractor scripts run their "OnInteractStart" function.
// When the player exits the trigger, all child IInteractor scripts run their "OnInteractEnd" function.

// !!! This script needs to be attached to an object with a trigger !!!

//  If the trigger should only be activated by the player:
// * Create a "PlayerTrigger" and a "Player" layer.
// * Put this object on the "PlayerTrigger" layer and the player object on the "Player" layer.
// * Update the physics matrix to to make the "Player" layer the only layer that can collide with the player trigger layer.


// ##################################################################################################
using UnityEngine;

public class AreaTrigger : BasicTrigger
{
    // All activators need to run their Init function to get the list of child interactors.
    void Start()
    {
        Init();
    }


    // In this very simple example, we will activate all of the interactors when something enters the trigger.
    // and deactivate all of the interactors when something exits the trigger.
    // In a proper game these would be triggered by a key press (interact button) when the player is in range and looking at the object.
    void OnTriggerEnter(Collider other)
    {
        Activate();
    }

    void OnTriggerExit()
    {
        Deactivate();
    }





}
