// ##################################################################################################
// ToggleRemoteActivator.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// An example Interactor that will toggle between Activate / Deactivate 
// on a remote Activator any time the state of this interactor changes.
// IE OnInteractStart and OnInteractEnd tell a seperate Activator to toggle state.
// ##################################################################################################
using UnityEngine;

public class ToggleRemoteTrigger : MonoBehaviour, IInteractor
{
    public BasicTrigger remoteActivator;
    //The functions below are implimented through the IInteractor interface.
    public void OnInteractStart()
    {
        remoteActivator.Toggle();
    }

    public void OnInteractEnd()
    {
        remoteActivator.Toggle();
    }
}
