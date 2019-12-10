// ##################################################################################################
// AnimationInteractor.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// An example Interactable that will run trigger parameters on an animation controller 
// (different trigger depending on whether we are activating or deactivating).
// ##################################################################################################

using UnityEngine;

public class AnimationActor : MonoBehaviour, IInteractor
{
    public Animator anim;
    public string triggerStart = "triggerStart", triggerEnd = "triggerEnd"; // names of the trigger parameters in the animation controller.


    public void OnInteractStart()
    {
        anim.SetTrigger(triggerStart);
    }

    public void OnInteractEnd()
    {
        anim.SetTrigger(triggerEnd);
    }

}
