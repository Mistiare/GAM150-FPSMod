// ##################################################################################################
// ActivatorInteractor.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// An example Interactable that will enable / disable a game object.
// ##################################################################################################
using UnityEngine;


public class ActivationActor : MonoBehaviour, IInteractor
{
    public bool startDisabled = true;
    public GameObject targetObject; // The object that will be activated / deactivated...

    //The functions below are implimented through the IInteractor interface.
    void Awake()
    {
        if (!targetObject)
        { 
            Debug.LogWarning("ActivationActor on " + gameObject.name + " is not set!");
            return;
        }
        if (startDisabled)
            targetObject.SetActive(false);

    }

    public void OnInteractStart()
    {
        targetObject.SetActive(true);
    }

    public void OnInteractEnd()
    {
        targetObject.SetActive(false);
    }
}
