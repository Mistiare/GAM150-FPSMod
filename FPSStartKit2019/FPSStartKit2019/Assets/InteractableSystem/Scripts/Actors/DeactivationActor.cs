// ##################################################################################################
// Deactivator.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// An example Interactable that will disable a game object upon activation 
// and does nothing on deactivation.
// ##################################################################################################

using UnityEngine;

public class DeactivationActor : MonoBehaviour, IInteractor
{
    public GameObject targetObject; // The object that will be  deactivated...

    //The functions below are implimented through the IInteractor interface.
    public void OnInteractStart()
    {
        targetObject.SetActive(false);
    }

    //Dectivator does nothing when the interaction ends, but we still need to include the function to satisfy the IInteractor interface.
    public void OnInteractEnd()
    {

    }
}
