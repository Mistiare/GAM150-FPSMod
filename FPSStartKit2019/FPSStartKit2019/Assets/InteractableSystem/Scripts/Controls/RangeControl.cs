using UnityEngine;

public class RangeControl : MonoBehaviour
{
    [HideInInspector]
    public InteractionControl control;

    #if UNITY_EDITOR
    void Start()
    {
        if (!control)
            Debug.LogError("Interaction Control not set on " + gameObject.name);
    }
    #endif

    void OnTriggerEnter(Collider col)
    {
        control.SetIsInRange(true);
    }
    void OnTriggerExit(Collider col)
    {
        control.SetIsInRange(false);
    }
}
