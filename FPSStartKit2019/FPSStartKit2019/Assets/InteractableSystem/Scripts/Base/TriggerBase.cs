// ##################################################################################################
// TriggerBase.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// Base class for all Activator scripts.
// This script contains the processes common to all of the Activator objects.

// This script makes a protected collection of all scripts on child objects that use the IInteractor interface (see IInteractor.cs).
// Protected functions for activating and deactivating the interactors is here.
// Activator classes that inherit from this determine the conditions for activating and deactivating.

// ##################################################################################################

using UnityEngine;

public abstract class TriggerBase : MonoBehaviour
{
    protected IInteractor[] interactors; // array of all the Interactor components on this object.
    protected int interactorCount = 0;
    protected bool isActive = false;
    protected void Init()
    {
        //gets all of the IInteractor components that are on the object's children.
        interactors = GetComponentsInChildren<IInteractor>();
        interactorCount = interactors.Length;
    }

    protected void Activate()
    {
        isActive = true;
        Debug.Log(gameObject.name+" activated!");
        //if the collection is empty, don't do anything....
        if (interactorCount==0)
        {
            return;
        }

        // go through each interactor script and run its OnInteractStart script.
        for (int i = 0; i < interactors.Length; i++)
        {
            interactors[i].OnInteractStart();
        }
    }
    protected void Deactivate()
    {
        isActive = false;
        Debug.Log(gameObject.name + " deactivated!");
        //if the collection is empty, don't do anything....
        if (interactorCount==0)
        {
            return;
        }

        //run OnInteractEnd on each interactor script.
        for (int i = 0; i < interactors.Length; i++)
        {
            interactors[i].OnInteractEnd();
        }
    }

    // Added these functions so that Activators can be activated, deactivated or toggled from other scripts.
    public void RemoteActivate()
    {
        Activate();
    }

    public void RemoteDeactivate()
    {
        Deactivate();
    }

    public void Toggle()
    {
        if (isActive)
        {
            Deactivate();
        }
        else
        {
            Activate();
        }
    }
}
