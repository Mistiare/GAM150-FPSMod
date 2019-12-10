// ##################################################################################################
// DoubleAudioInteractor.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// An example Interactable that will set a different audio clip to an audio source 
// depending upon activation or deactivation and play it.
// ##################################################################################################

using UnityEngine;

public class DoubleAudioActor : MonoBehaviour, IInteractor
{
    public AudioSource audioSource;
    public AudioClip enterSound, exitSound;

    public void OnInteractStart()
    {
        audioSource.Stop();
        audioSource.clip = enterSound;
        audioSource.Play();
    }

    public void OnInteractEnd()
    {
        audioSource.Stop();
        audioSource.clip = exitSound;
        audioSource.Play();
    }
}
