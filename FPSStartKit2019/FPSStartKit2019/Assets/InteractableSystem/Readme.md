######################################
Generic Interactables Demo.
By Paul Hedley. 5/11/2019
######################################
Project Setup.
================

For this system to work in other projects, you need to setup the layers and physics matrix.  You will also need to set the layers on a couple of objects.
If you are using the complete project, this has already been setup.

Create the following layers:
	* Player
	* PlayerTrigger
	* PlayerLookAt

Setup the physics matrix as follows:

	* PlayerTrigger layer only collides with the Player layer.
	* PlayerLookAt collides with nothing.

The first person controller needs to be set to the Player layer
On the Interactible prefab:
	* Set the object called "01_RangeControl" to the PlayerTrigger layer.
	* Set the object called "02_LookAtControl" to the PlayerLookAt layer.

The InteractiblePrefab should now be fully functional in and can be added to the scene wherever player interaction is needed.

When the player is in range and looking at the collider attached to the "02_LookAtControl" object, a UI text object is enabled, indicating to the player that they need to press a key to interact.
During this time the object called "03_KeyPressControl" is enabled.  This has a script that waits to detect a keypress.  When the key is pressed, the Triggerable objects are toggled.

######################################################################################################################################################################
Triggerable Objects.
==========================

Triggerable objects can be activated and deactivated.  The interactible prefab will toggle between these whenever the key is pressed.

Create an empty game object and add a BasicTrigger script.
Create a child game object and add the Actor scripts for desired behaviour (Actor scripts can be found in Scripts/Actors).
The objects that these actors act upon can be anywhere in the scene.
This project includes 4 working example prefabs that contain both the trigger/actor system accompanied with the assets they act upon (PRF_Light, PRF_ParticleSystem, PRF_Lever and PRF_Portcullis in the prefabs folder).

ActivationActor: This will enable a game object upon activation and disable a game object upon deactivation.  It needs to be told which game object it needs to enable and disable.  There is an extra property called "startDisabled" that will automatically disable its target game object when the game starts if set to true.  This is the one that you will most likely need for most things (eg, lights, particle systems any script that functions through the OnEnable, OnDisable methods).

DeactivationActor: This will disable a game object when activated and does nothing when deactivated.  It needs to be told which game object to disable.

AnimationActor: This actor sends a SetTrigger command to an animator component when activated / deactivated.  It can set a different animation trigger parameter on the animator depending on if it is activating or deactivating.  It needs to be told the Animator component it is acting upon.  It also needs the names of the animation trigger parameters being used.  We can set these to the same value so it sets the same animation trigger parameter regardless of activation / deactivation.  The animator controller will need to have these trigger parameters setup.

AudioActor: Sets an audio source to play when activated and stop when deactivated.  The actor needs to know which AudioSource component it is acting upon.  The AudioSource (eg which clip to play) will need to be setup manually.

DoubleAudioActor: Plays an audio clip when activated and a different audio clip when deactivated.  The actor needs to know which AudioSource it will be using, as well as which audio clips to play on activation/deactivation.  Other properties of the AudioSource need to be setup manually.

######################################################################################################################################################################
Credits
==============

Audio files for the demo are from the "Ultra Sci-Fi UI Pack: Volume One" by Eric Berzins.
Available for free on the Asset Store: 
https://assetstore.unity.com/packages/audio/sound-fx/ultra-sci-fi-game-audio-ui-pack-vol-1-155417