// ##################################################################################################
// BasicTrigger.cs
// =====================
// By Paul Hedley.  
// 7/11/2019

// The most basic kind of Activator.
// Unlike other activators, does not check to see if it should activate or deactivate.
// This one is solely intended to be controlled by another script (using ActivatorBase.RemoteActivate() and using ActivatorBase.RemoteDeactivate() ).
// ##################################################################################################

public class BasicTrigger :TriggerBase
{
 void Start()
    {
        Init();
    }
}
