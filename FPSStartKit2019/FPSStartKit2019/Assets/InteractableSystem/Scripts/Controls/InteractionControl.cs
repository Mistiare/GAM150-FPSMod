using UnityEngine;
using UnityEngine.UI;

public class InteractionControl : MonoBehaviour
{
    [HideInInspector]
    public GameObject lookAtControl;
    [HideInInspector]
    public GameObject keypressControl;

    public KeyCode keyToPress = KeyCode.E;
    public Text UIText;
    public BasicTrigger[] triggerObjects;

    bool isLooking = false; // This value is set based on a call from the LookatControl
    bool isInRange = false; // This value is set based on a call from the RangeControl

    void Start()
    {

#if UNITY_EDITOR
        if(!lookAtControl)
        {
           Debug.LogError("LookAt Control not set on "+gameObject.name);
           return;
        }
        if(!keypressControl)
        {
           Debug.LogError("Keypress Control not set on "+gameObject.name);
           return;
        }
        if(!UIText)
        {
           Debug.LogError("UI Text component not set on "+gameObject.name);
           return;
        }
#endif
        lookAtControl.SetActive(false);
        keypressControl.SetActive(false);
        UIText.text = "Press " + keyToPress.ToString();
        UIText.enabled = false;
    }

    /*
     // Moved this functionality to the RangeControl
    void OnTriggerEnter(Collider col)
    {
        lookAtControl.SetActive(true);
        #if UNITY_EDITOR
        Debug.Log("Player In Range");
        #endif
    }

    void OnTriggerExit(Collider col)
    {
        lookAtControl.SetActive(false);
        #if UNITY_EDITOR
        Debug.Log("Player out of Range");
        #endif
        isLooking = false;
        UIText.enabled = false;
        keypressControl.SetActive(false);
    }
    */

    public void SetIsInRange(bool setRange)
    {
        if (setRange == isInRange)
            return;
        isInRange = setRange;
        if(isInRange)
        {
            lookAtControl.SetActive(true);
            #if UNITY_EDITOR
            Debug.Log("Player In Range");
            #endif
        }
        else
        {
            lookAtControl.SetActive(false);
            #if UNITY_EDITOR
            Debug.Log("Player out of Range");
            #endif
            isLooking = false;
            UIText.enabled = false;
            keypressControl.SetActive(false);
        }
    }

    public void SetIsLooking(bool setIsLooking)
    {
        if (isLooking == setIsLooking)
            return;
        isLooking = setIsLooking;
        keypressControl.SetActive(isLooking);
        UIText.enabled = isLooking;
        #if UNITY_EDITOR
        if(isLooking)
            Debug.Log("Player is looking");
        else
            Debug.Log("Player is not looking");
        #endif
    }

    public void RunTriggers()
    {
        if (triggerObjects.Length == 0)
            return;
        #if UNITY_EDITOR
            Debug.Log("Running Triggers");
        #endif
        for (int i = 0; i < triggerObjects.Length; i++)
        {
            triggerObjects[i].Toggle();
        }
    }
}
