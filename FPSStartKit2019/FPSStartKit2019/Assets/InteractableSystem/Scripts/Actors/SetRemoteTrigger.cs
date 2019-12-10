
// ##################################################################################################
// StartRemoteTrigger.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// An example Interactable that remotely activates another Activator (anything that inherits from ActivatorBase).
// ##################################################################################################

using UnityEngine;

public class SetRemoteTrigger : MonoBehaviour, IInteractor
{
    public BasicTrigger remoteActivator;
    //The functions below are implimented through the IInteractor interface.
    public void OnInteractStart()
    {
        remoteActivator.RemoteActivate();
    }

    //Dectivator does nothing when the interaction ends, but we still need to include the function to satisfy the IInteractor interface.
    public void OnInteractEnd()
    {
        remoteActivator.RemoteDeactivate();
    }
}
