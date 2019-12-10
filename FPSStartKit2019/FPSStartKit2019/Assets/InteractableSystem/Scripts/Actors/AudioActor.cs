// ##################################################################################################
// AudioInteractor.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// An example Interactable that will start playing an audiosource upon activation
// and stop playing on deactivation.
// ##################################################################################################

using UnityEngine;
// An example activator that will play an audio source when activated and stop when deactivated.
public class AudioActor : MonoBehaviour, IInteractor
{
    public AudioSource audioSource;


    public void OnInteractStart()
    {
        audioSource.Play();
    }

    public void OnInteractEnd()
    {
        audioSource.Stop();
    }

}
