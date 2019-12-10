// ##################################################################################################
// IInteractor.cs
//=====================
// By Paul Hedley.
// 06/11/2019

// This is an example of an interface that can be implimented by other scripts.
// Everything that does something when an Activator on a parent object runs Activate or Deactivate will impliment this interface.

// For more information on Interfaces in C#:
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface

// https://learn.unity.com/tutorial/interfaces

// ##################################################################################################


public interface IInteractor
{
    void OnInteractStart(); // This is the function that will run whenever the controlling Activator activates.
    void OnInteractEnd(); // This is the function that will be run whenever the controlling Activator deactivates.
}
