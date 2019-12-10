using UnityEngine;

public class LookAtControl : MonoBehaviour
{
    [HideInInspector]
    public InteractionControl control;

#if UNITY_EDITOR
    void Start()
    {
        if(!control)
            Debug.LogError("Interaction Control not set on "+gameObject.name);
    }
#endif

    void OnMouseEnter()
    {
        control.SetIsLooking(true);
        //Debug.Log("LookAtTriggered");
    }

    void OnMouseExit()
    {
        control.SetIsLooking(false);
       // Debug.Log("LookAt Disabled");
    }
}
